'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18063
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace IWCEncryptPassword
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="EncryptPasswordRequestType", [Namespace]:="http://schemas.datacontract.org/2004/07/CUNAMutual.Loanliner.Services.Utility"),  _
     System.SerializableAttribute()>  _
    Partial Public Class EncryptPasswordRequestType
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private _domainField As String
        
        Private _passwordField As String
        
        Private _userIdField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property _domain() As String
            Get
                Return Me._domainField
            End Get
            Set
                If (Object.ReferenceEquals(Me._domainField, value) <> true) Then
                    Me._domainField = value
                    Me.RaisePropertyChanged("_domain")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property _password() As String
            Get
                Return Me._passwordField
            End Get
            Set
                If (Object.ReferenceEquals(Me._passwordField, value) <> true) Then
                    Me._passwordField = value
                    Me.RaisePropertyChanged("_password")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property _userId() As String
            Get
                Return Me._userIdField
            End Get
            Set
                If (Object.ReferenceEquals(Me._userIdField, value) <> true) Then
                    Me._userIdField = value
                    Me.RaisePropertyChanged("_userId")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="EncryptPasswordResponseType", [Namespace]:="http://schemas.datacontract.org/2004/07/CUNAMutual.Loanliner.Services.Utility"),  _
     System.SerializableAttribute()>  _
    Partial Public Class EncryptPasswordResponseType
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private _encryptedPasswordField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property _encryptedPassword() As String
            Get
                Return Me._encryptedPasswordField
            End Get
            Set
                If (Object.ReferenceEquals(Me._encryptedPasswordField, value) <> true) Then
                    Me._encryptedPasswordField = value
                    Me.RaisePropertyChanged("_encryptedPassword")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="CUNAMutual.Loanliner.Services", ConfigurationName:="IWCEncryptPassword.IUtility")>  _
    Public Interface IUtility
        
        <System.ServiceModel.OperationContractAttribute(Action:="CUNAMutual.Loanliner.Services/IUtility/EncryptPassword", ReplyAction:="CUNAMutual.Loanliner.Services/IUtility/EncryptPasswordResponse")>  _
        Function EncryptPassword(ByVal encryptPasswordRequest As IWCEncryptPassword.EncryptPasswordRequestType) As IWCEncryptPassword.EncryptPasswordResponseType
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IUtilityChannel
        Inherits IWCEncryptPassword.IUtility, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class UtilityClient
        Inherits System.ServiceModel.ClientBase(Of IWCEncryptPassword.IUtility)
        Implements IWCEncryptPassword.IUtility
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function EncryptPassword(ByVal encryptPasswordRequest As IWCEncryptPassword.EncryptPasswordRequestType) As IWCEncryptPassword.EncryptPasswordResponseType Implements IWCEncryptPassword.IUtility.EncryptPassword
            Return MyBase.Channel.EncryptPassword(encryptPasswordRequest)
        End Function
    End Class
End Namespace
