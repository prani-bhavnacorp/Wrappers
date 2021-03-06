'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.832
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
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.832.
'
Namespace TotalPlusWebService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="BISYS_DNPServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BISYS_DNPServiceWse
        Inherits Microsoft.Web.Services3.WebServicesClientProtocol
        
        Private MakeRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_TotalPlusService_BISYS_DNPService
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
        Public Event MakeRequestCompleted As MakeRequestCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MakeRequest", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function MakeRequest(ByVal req As DNPRequest) As DNPRequest
            Dim results() As Object = Me.Invoke("MakeRequest", New Object() {req})
            Return CType(results(0),DNPRequest)
        End Function
        
        '''<remarks/>
        Public Overloads Sub MakeRequestAsync(ByVal req As DNPRequest)
            Me.MakeRequestAsync(req, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub MakeRequestAsync(ByVal req As DNPRequest, ByVal userState As Object)
            If (Me.MakeRequestOperationCompleted Is Nothing) Then
                Me.MakeRequestOperationCompleted = AddressOf Me.OnMakeRequestOperationCompleted
            End If
            Me.InvokeAsync("MakeRequest", New Object() {req}, Me.MakeRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnMakeRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.MakeRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent MakeRequestCompleted(Me, New MakeRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="BISYS_DNPServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BISYS_DNPService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private MakeRequestOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_TotalPlusService_BISYS_DNPService
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
        Public Event MakeRequestCompleted As MakeRequestCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MakeRequest", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function MakeRequest(ByVal req As DNPRequest) As DNPRequest
            Dim results() As Object = Me.Invoke("MakeRequest", New Object() {req})
            Return CType(results(0),DNPRequest)
        End Function
        
        '''<remarks/>
        Public Function BeginMakeRequest(ByVal req As DNPRequest, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("MakeRequest", New Object() {req}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndMakeRequest(ByVal asyncResult As System.IAsyncResult) As DNPRequest
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),DNPRequest)
        End Function
        
        '''<remarks/>
        Public Overloads Sub MakeRequestAsync(ByVal req As DNPRequest)
            Me.MakeRequestAsync(req, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub MakeRequestAsync(ByVal req As DNPRequest, ByVal userState As Object)
            If (Me.MakeRequestOperationCompleted Is Nothing) Then
                Me.MakeRequestOperationCompleted = AddressOf Me.OnMakeRequestOperationCompleted
            End If
            Me.InvokeAsync("MakeRequest", New Object() {req}, Me.MakeRequestOperationCompleted, userState)
        End Sub
        
        Private Sub OnMakeRequestOperationCompleted(ByVal arg As Object)
            If (Not (Me.MakeRequestCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent MakeRequestCompleted(Me, New MakeRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.832"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class DNPRequest
        
        Private tOSSIDField As String
        
        Private terminalIDField As String
        
        Private clientNumberField As String
        
        Private requestMessageTranField As String
        
        Private responseMessageTranField As String
        
        Private responseMessageStatusField As Integer
        
        Private userNameField As String
        
        Private passwordField As String
        
        Private forceConversationField As Boolean
        
        Private conversationIdField As String
        
        '''<remarks/>
        Public Property TOSSID() As String
            Get
                Return Me.tOSSIDField
            End Get
            Set
                Me.tOSSIDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property TerminalID() As String
            Get
                Return Me.terminalIDField
            End Get
            Set
                Me.terminalIDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ClientNumber() As String
            Get
                Return Me.clientNumberField
            End Get
            Set
                Me.clientNumberField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property RequestMessageTran() As String
            Get
                Return Me.requestMessageTranField
            End Get
            Set
                Me.requestMessageTranField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ResponseMessageTran() As String
            Get
                Return Me.responseMessageTranField
            End Get
            Set
                Me.responseMessageTranField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ResponseMessageStatus() As Integer
            Get
                Return Me.responseMessageStatusField
            End Get
            Set
                Me.responseMessageStatusField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Password() As String
            Get
                Return Me.passwordField
            End Get
            Set
                Me.passwordField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ForceConversation() As Boolean
            Get
                Return Me.forceConversationField
            End Get
            Set
                Me.forceConversationField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ConversationId() As String
            Get
                Return Me.conversationIdField
            End Get
            Set
                Me.conversationIdField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub MakeRequestCompletedEventHandler(ByVal sender As Object, ByVal e As MakeRequestCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class MakeRequestCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DNPRequest
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DNPRequest)
            End Get
        End Property
    End Class
End Namespace
