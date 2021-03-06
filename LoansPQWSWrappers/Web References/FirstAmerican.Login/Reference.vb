'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace FirstAmerican.Login
    
    'CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="Default", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MyFAMS
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private LoginOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_FirstAmerican_Login_MyFAMS
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event LoginCompleted As LoginCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IMyFAMS/Login", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Login(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal username As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal password As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal key As String) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> Response
            Dim results() As Object = Me.Invoke("Login", New Object() {username, password, key})
            Return CType(results(0),Response)
        End Function
        
        '''<remarks/>
        Public Function BeginLogin(ByVal username As String, ByVal password As String, ByVal key As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("Login", New Object() {username, password, key}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndLogin(ByVal asyncResult As System.IAsyncResult) As Response
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Response)
        End Function
        
        '''<remarks/>
        Public Overloads Sub LoginAsync(ByVal username As String, ByVal password As String, ByVal key As String)
            Me.LoginAsync(username, password, key, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LoginAsync(ByVal username As String, ByVal password As String, ByVal key As String, ByVal userState As Object)
            If (Me.LoginOperationCompleted Is Nothing) Then
                Me.LoginOperationCompleted = AddressOf Me.OnLoginOperationCompleted
            End If
            Me.InvokeAsync("Login", New Object() {username, password, key}, Me.LoginOperationCompleted, userState)
        End Sub
        
        Private Sub OnLoginOperationCompleted(ByVal arg As Object)
            If (Not (Me.LoginCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LoginCompleted(Me, New LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/API")>  _
    Partial Public Class Response
        
        Private messageField As String
        
        Private successField As Boolean
        
        Private successFieldSpecified As Boolean
        
        Private uRLField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property Message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Success() As Boolean
            Get
                Return Me.successField
            End Get
            Set
                Me.successField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property SuccessSpecified() As Boolean
            Get
                Return Me.successFieldSpecified
            End Get
            Set
                Me.successFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property URL() As String
            Get
                Return Me.uRLField
            End Get
            Set
                Me.uRLField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")>  _
    Public Delegate Sub LoginCompletedEventHandler(ByVal sender As Object, ByVal e As LoginCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class LoginCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Response
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Response)
            End Get
        End Property
    End Class
End Namespace
