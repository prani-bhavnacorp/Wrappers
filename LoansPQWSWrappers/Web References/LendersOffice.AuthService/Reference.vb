﻿'------------------------------------------------------------------------------
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
Namespace LendersOffice.AuthService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="AuthServiceSoap", [Namespace]:="http://www.lendersoffice.com/los/webservices/")>  _
    Partial Public Class AuthService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GetUserAuthTicketOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetPmlUserAuthTicketOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetBrokerPartnerAuthTicketOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_LendersOfficer_AuthService_AuthService
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
        Public Event GetUserAuthTicketCompleted As GetUserAuthTicketCompletedEventHandler
        
        '''<remarks/>
        Public Event GetPmlUserAuthTicketCompleted As GetPmlUserAuthTicketCompletedEventHandler
        
        '''<remarks/>
        Public Event GetBrokerPartnerAuthTicketCompleted As GetBrokerPartnerAuthTicketCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.lendersoffice.com/los/webservices/GetUserAuthTicket", RequestNamespace:="http://www.lendersoffice.com/los/webservices/", ResponseNamespace:="http://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetUserAuthTicket(ByVal userName As String, ByVal passWord As String) As String
            Dim results() As Object = Me.Invoke("GetUserAuthTicket", New Object() {userName, passWord})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginGetUserAuthTicket(ByVal userName As String, ByVal passWord As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetUserAuthTicket", New Object() {userName, passWord}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetUserAuthTicket(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetUserAuthTicketAsync(ByVal userName As String, ByVal passWord As String)
            Me.GetUserAuthTicketAsync(userName, passWord, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetUserAuthTicketAsync(ByVal userName As String, ByVal passWord As String, ByVal userState As Object)
            If (Me.GetUserAuthTicketOperationCompleted Is Nothing) Then
                Me.GetUserAuthTicketOperationCompleted = AddressOf Me.OnGetUserAuthTicketOperationCompleted
            End If
            Me.InvokeAsync("GetUserAuthTicket", New Object() {userName, passWord}, Me.GetUserAuthTicketOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetUserAuthTicketOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetUserAuthTicketCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetUserAuthTicketCompleted(Me, New GetUserAuthTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.lendersoffice.com/los/webservices/GetPmlUserAuthTicket", RequestNamespace:="http://www.lendersoffice.com/los/webservices/", ResponseNamespace:="http://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPmlUserAuthTicket(ByVal userName As String, ByVal passWord As String, ByVal customerCode As String) As String
            Dim results() As Object = Me.Invoke("GetPmlUserAuthTicket", New Object() {userName, passWord, customerCode})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginGetPmlUserAuthTicket(ByVal userName As String, ByVal passWord As String, ByVal customerCode As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetPmlUserAuthTicket", New Object() {userName, passWord, customerCode}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetPmlUserAuthTicket(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetPmlUserAuthTicketAsync(ByVal userName As String, ByVal passWord As String, ByVal customerCode As String)
            Me.GetPmlUserAuthTicketAsync(userName, passWord, customerCode, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetPmlUserAuthTicketAsync(ByVal userName As String, ByVal passWord As String, ByVal customerCode As String, ByVal userState As Object)
            If (Me.GetPmlUserAuthTicketOperationCompleted Is Nothing) Then
                Me.GetPmlUserAuthTicketOperationCompleted = AddressOf Me.OnGetPmlUserAuthTicketOperationCompleted
            End If
            Me.InvokeAsync("GetPmlUserAuthTicket", New Object() {userName, passWord, customerCode}, Me.GetPmlUserAuthTicketOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetPmlUserAuthTicketOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetPmlUserAuthTicketCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetPmlUserAuthTicketCompleted(Me, New GetPmlUserAuthTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.lendersoffice.com/los/webservices/GetBrokerPartnerAuthTicket", RequestNamespace:="http://www.lendersoffice.com/los/webservices/", ResponseNamespace:="http://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetBrokerPartnerAuthTicket(ByVal sSecretKey As String, ByVal brokerId As System.Guid, ByVal userName As String) As String
            Dim results() As Object = Me.Invoke("GetBrokerPartnerAuthTicket", New Object() {sSecretKey, brokerId, userName})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginGetBrokerPartnerAuthTicket(ByVal sSecretKey As String, ByVal brokerId As System.Guid, ByVal userName As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetBrokerPartnerAuthTicket", New Object() {sSecretKey, brokerId, userName}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetBrokerPartnerAuthTicket(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetBrokerPartnerAuthTicketAsync(ByVal sSecretKey As String, ByVal brokerId As System.Guid, ByVal userName As String)
            Me.GetBrokerPartnerAuthTicketAsync(sSecretKey, brokerId, userName, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetBrokerPartnerAuthTicketAsync(ByVal sSecretKey As String, ByVal brokerId As System.Guid, ByVal userName As String, ByVal userState As Object)
            If (Me.GetBrokerPartnerAuthTicketOperationCompleted Is Nothing) Then
                Me.GetBrokerPartnerAuthTicketOperationCompleted = AddressOf Me.OnGetBrokerPartnerAuthTicketOperationCompleted
            End If
            Me.InvokeAsync("GetBrokerPartnerAuthTicket", New Object() {sSecretKey, brokerId, userName}, Me.GetBrokerPartnerAuthTicketOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetBrokerPartnerAuthTicketOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetBrokerPartnerAuthTicketCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetBrokerPartnerAuthTicketCompleted(Me, New GetBrokerPartnerAuthTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    Public Delegate Sub GetUserAuthTicketCompletedEventHandler(ByVal sender As Object, ByVal e As GetUserAuthTicketCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetUserAuthTicketCompletedEventArgs
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub GetPmlUserAuthTicketCompletedEventHandler(ByVal sender As Object, ByVal e As GetPmlUserAuthTicketCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetPmlUserAuthTicketCompletedEventArgs
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub GetBrokerPartnerAuthTicketCompletedEventHandler(ByVal sender As Object, ByVal e As GetBrokerPartnerAuthTicketCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetBrokerPartnerAuthTicketCompletedEventArgs
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
