'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3615
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
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3615.
'
Namespace EBankService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="MLDepositMethodsSoap", [Namespace]:="http://ancillary.ebanksystems.com/ML")>  _
    Partial Public Class MLDepositMethodsWse
        Inherits Microsoft.Web.Services3.WebServicesClientProtocol
        
        Private SaveNewDepositOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getNextAccountNumberOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_EBankService_MLDepositMethods
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
        Public Event SaveNewDepositCompleted As SaveNewDepositCompletedEventHandler
        
        '''<remarks/>
        Public Event getNextAccountNumberCompleted As getNextAccountNumberCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ancillary.ebanksystems.com/ML/SaveNewDeposit", RequestNamespace:="http://ancillary.ebanksystems.com/ML", ResponseNamespace:="http://ancillary.ebanksystems.com/ML", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SaveNewDeposit(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode)
            Me.Invoke("SaveNewDeposit", New Object() {acctNo, uploadStack, newDeposit})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SaveNewDepositAsync(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode)
            Me.SaveNewDepositAsync(acctNo, uploadStack, newDeposit, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SaveNewDepositAsync(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode, ByVal userState As Object)
            If (Me.SaveNewDepositOperationCompleted Is Nothing) Then
                Me.SaveNewDepositOperationCompleted = AddressOf Me.OnSaveNewDepositOperationCompleted
            End If
            Me.InvokeAsync("SaveNewDeposit", New Object() {acctNo, uploadStack, newDeposit}, Me.SaveNewDepositOperationCompleted, userState)
        End Sub
        
        Private Sub OnSaveNewDepositOperationCompleted(ByVal arg As Object)
            If (Not (Me.SaveNewDepositCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SaveNewDepositCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ancillary.ebanksystems.com/ML/getNextAccountNumber", RequestNamespace:="http://ancillary.ebanksystems.com/ML", ResponseNamespace:="http://ancillary.ebanksystems.com/ML", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getNextAccountNumber() As String
            Dim results() As Object = Me.Invoke("getNextAccountNumber", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getNextAccountNumberAsync()
            Me.getNextAccountNumberAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getNextAccountNumberAsync(ByVal userState As Object)
            If (Me.getNextAccountNumberOperationCompleted Is Nothing) Then
                Me.getNextAccountNumberOperationCompleted = AddressOf Me.OngetNextAccountNumberOperationCompleted
            End If
            Me.InvokeAsync("getNextAccountNumber", New Object(-1) {}, Me.getNextAccountNumberOperationCompleted, userState)
        End Sub
        
        Private Sub OngetNextAccountNumberOperationCompleted(ByVal arg As Object)
            If (Not (Me.getNextAccountNumberCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getNextAccountNumberCompleted(Me, New getNextAccountNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="MLDepositMethodsSoap", [Namespace]:="http://ancillary.ebanksystems.com/ML")>  _
    Partial Public Class MLDepositMethods
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SaveNewDepositOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getNextAccountNumberOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_EBankService_MLDepositMethods
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
        Public Event SaveNewDepositCompleted As SaveNewDepositCompletedEventHandler
        
        '''<remarks/>
        Public Event getNextAccountNumberCompleted As getNextAccountNumberCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ancillary.ebanksystems.com/ML/SaveNewDeposit", RequestNamespace:="http://ancillary.ebanksystems.com/ML", ResponseNamespace:="http://ancillary.ebanksystems.com/ML", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub SaveNewDeposit(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode)
            Me.Invoke("SaveNewDeposit", New Object() {acctNo, uploadStack, newDeposit})
        End Sub
        
        '''<remarks/>
        Public Function BeginSaveNewDeposit(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SaveNewDeposit", New Object() {acctNo, uploadStack, newDeposit}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Sub EndSaveNewDeposit(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SaveNewDepositAsync(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode)
            Me.SaveNewDepositAsync(acctNo, uploadStack, newDeposit, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SaveNewDepositAsync(ByVal acctNo As String, ByVal uploadStack As String, ByVal newDeposit As System.Xml.XmlNode, ByVal userState As Object)
            If (Me.SaveNewDepositOperationCompleted Is Nothing) Then
                Me.SaveNewDepositOperationCompleted = AddressOf Me.OnSaveNewDepositOperationCompleted
            End If
            Me.InvokeAsync("SaveNewDeposit", New Object() {acctNo, uploadStack, newDeposit}, Me.SaveNewDepositOperationCompleted, userState)
        End Sub
        
        Private Sub OnSaveNewDepositOperationCompleted(ByVal arg As Object)
            If (Not (Me.SaveNewDepositCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SaveNewDepositCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ancillary.ebanksystems.com/ML/getNextAccountNumber", RequestNamespace:="http://ancillary.ebanksystems.com/ML", ResponseNamespace:="http://ancillary.ebanksystems.com/ML", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getNextAccountNumber() As String
            Dim results() As Object = Me.Invoke("getNextAccountNumber", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BegingetNextAccountNumber(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("getNextAccountNumber", New Object(-1) {}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndgetNextAccountNumber(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getNextAccountNumberAsync()
            Me.getNextAccountNumberAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getNextAccountNumberAsync(ByVal userState As Object)
            If (Me.getNextAccountNumberOperationCompleted Is Nothing) Then
                Me.getNextAccountNumberOperationCompleted = AddressOf Me.OngetNextAccountNumberOperationCompleted
            End If
            Me.InvokeAsync("getNextAccountNumber", New Object(-1) {}, Me.getNextAccountNumberOperationCompleted, userState)
        End Sub
        
        Private Sub OngetNextAccountNumberOperationCompleted(ByVal arg As Object)
            If (Not (Me.getNextAccountNumberCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getNextAccountNumberCompleted(Me, New getNextAccountNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub SaveNewDepositCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub getNextAccountNumberCompletedEventHandler(ByVal sender As Object, ByVal e As getNextAccountNumberCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getNextAccountNumberCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
