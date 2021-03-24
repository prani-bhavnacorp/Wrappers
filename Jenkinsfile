@Library('jenkins-shared-libraries@v0.4.14') _
pipeline {
  agent {
    kubernetes {
      yaml podYamlWindows(['jnlp', 'dotnet-framework', 'docker-jfrog-cli'])
    }
  }
  environment {
    NUGET_REPOSITORY = 'https://meridianlink.jfrog.io/artifactory/api/nuget/nuget'
    ARTIFACTORY_ID = 'artifactory'
	BUILD_NAME = "LPQ-WRAPPERSTEST"
	BRANCH_NAME = "LPQ-27663"
	NUGET_UPLOAD_PATH = "lpq-nuget-local/LoansPQWSWrappersTest/"
  }
  stages {
    stage('Pre-Pipeline Checks') {
      agent {
        kubernetes {
          yamlFile 'JenkinsDependency/Kubernetes/LinuxNodePod.yaml'
        }
      }
      steps {
        script {
          env.CI_SKIP = 'false'
          result = sh (script: "git log -1 | grep -E '(\\(release\\)|\\[ci skip\\]|\\[skip ci\\])'", returnStatus: true)

          // skip builds if regex match and NOT building a tag
          if (result == 0 && env.TAG_NAME == null) {
            echo 'Regex match in commit message. Skipping build...'
            env.CI_SKIP = 'true'
            currentBuild.result = 'NOT_BUILT'

          } else {
            echo 'Regex did not match in commit message OR building a tag.  Proceed with build...'
          }

          if (env.TAG_NAME != null) {
            env.SEMANTIC_VERSION = env.TAG_NAME.minus("v")
          }
        }
      }
    }
    stage('Start Main Pipeline ->') {
      when {
        allOf {
          not { environment name: 'CI_SKIP', value: 'true' }
        }
      }
      stages {
        stage('Install Dependencies') {
          steps {
            container('windows-dotnet') {
              withCredentials([string(credentialsId: 'artifactory', variable: 'NUGET_API_TOKEN')]) {
                bat 'nuget sources Add -Name Artifactory -Source %NUGET_REPOSITORY% -username jenkins -password %NUGET_API_TOKEN%'
              }
              bat 'nuget restore LoansPQ2_WSWrappers.sln'
              bat 'dotnet tool restore'
              bat 'nuget restore .\\.nuget -outputdirectory .\\.nuget\\packages'
            }
          }
        }
        stage('Compile') {
          steps {
            container('windows-dotnet') {
              bat 'msbuild LoansPQ2_WSWrappers.sln /p:Configuration=release '
            }
          }
        }
        stage('Create Build Tag or Deploy Nuget Package') {
          stages {
            stage('Create Build Tag') {
              agent {
                kubernetes {
                  yamlFile 'JenkinsDependency/Kubernetes/LinuxNodePod.yaml'
                }
              }
              when {
                beforeAgent true
                not {
                  buildingTag()
                }
              }
              steps {
                container('node') {
                  sh ("""
                    git config --global user.name 'Svc-Az-CICD'
                    git config --global user.email 'Svc-Az-CICD@meridianlink.com'
                    """)

                  sh 'npx standard-version -a'

                  withCredentials([usernamePassword(credentialsId: 'Svc-Az-CICD', usernameVariable: 'GIT_USERNAME', passwordVariable: 'GIT_PASSWORD')]){
                    sh('''
                      git config --local credential.helper "!f() { echo username=\\$GIT_USERNAME; echo password=\\$GIT_PASSWORD; }; f"
                      git push --follow-tags origin HEAD:${BRANCH_NAME}
                    ''')
                  }
                }
              }  
            }
            stage('Deploy Nuget Package') {
              when {
                beforeAgent true
                buildingTag()
              }
              steps {
                container('windows-dotnet') {
                  bat "nuget pack LoansPQWSWrappers\\LoansPQWSWrappers.vbproj -Version ${env.SEMANTIC_VERSION} -Build -Verbosity detailed -Properties Platform=AnyCPU;Configuration=Release"
                }
                uploadToArtifactoryWindows(
					sourcePath: "LoansPQWSWrappers.${env.SEMANTIC_VERSION}.nupkg",
                    targetPath: NUGET_UPLOAD_PATH,
                    buildName: BUILD_NAME
				)
				
				publishBuildAndGitInfoWindows(
					 buildName: BUILD_NAME
				)
              }
            }
          }
        }
      }
    } 
  }
} 