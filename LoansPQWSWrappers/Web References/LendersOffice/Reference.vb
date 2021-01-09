﻿'------------------------------------------------------------------------------
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
Namespace LendersOffice
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="LoansPQ Web ServiceSoap", [Namespace]:="https://www.lendersoffice.com/los/webservices/")>  _
    Partial Public Class LoansPQWebServiceWse
        Inherits Microsoft.Web.Services3.WebServicesClientProtocol
        
        Private TransferDataToLendersOfficeOperationCompleted As System.Threading.SendOrPostCallback
        
        Private EditLoanFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RetrieveLoanFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_LendersOffice_LoansPQ_x0020_Web_x0020_Service
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
        Public Event TransferDataToLendersOfficeCompleted As TransferDataToLendersOfficeCompletedEventHandler
        
        '''<remarks/>
        Public Event EditLoanFileCompleted As EditLoanFileCompletedEventHandler
        
        '''<remarks/>
        Public Event RetrieveLoanFileCompleted As RetrieveLoanFileCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/TransferDataToLendersOffice", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function TransferDataToLendersOffice(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String) As String
            Dim results() As Object = Me.Invoke("TransferDataToLendersOffice", New Object() {username, password, loansPQFileID, clfData})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub TransferDataToLendersOfficeAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String)
            Me.TransferDataToLendersOfficeAsync(username, password, loansPQFileID, clfData, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub TransferDataToLendersOfficeAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal userState As Object)
            If (Me.TransferDataToLendersOfficeOperationCompleted Is Nothing) Then
                Me.TransferDataToLendersOfficeOperationCompleted = AddressOf Me.OnTransferDataToLendersOfficeOperationCompleted
            End If
            Me.InvokeAsync("TransferDataToLendersOffice", New Object() {username, password, loansPQFileID, clfData}, Me.TransferDataToLendersOfficeOperationCompleted, userState)
        End Sub
        
        Private Sub OnTransferDataToLendersOfficeOperationCompleted(ByVal arg As Object)
            If (Not (Me.TransferDataToLendersOfficeCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TransferDataToLendersOfficeCompleted(Me, New TransferDataToLendersOfficeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/EditLoanFile", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function EditLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long) As String
            Dim results() As Object = Me.Invoke("EditLoanFile", New Object() {username, password, loansPQFileID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub EditLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long)
            Me.EditLoanFileAsync(username, password, loansPQFileID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub EditLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal userState As Object)
            If (Me.EditLoanFileOperationCompleted Is Nothing) Then
                Me.EditLoanFileOperationCompleted = AddressOf Me.OnEditLoanFileOperationCompleted
            End If
            Me.InvokeAsync("EditLoanFile", New Object() {username, password, loansPQFileID}, Me.EditLoanFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnEditLoanFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.EditLoanFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent EditLoanFileCompleted(Me, New EditLoanFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/RetrieveLoanFile", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RetrieveLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String) As String
            Dim results() As Object = Me.Invoke("RetrieveLoanFile", New Object() {username, password, loansPQFileID, clfData})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RetrieveLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String)
            Me.RetrieveLoanFileAsync(username, password, loansPQFileID, clfData, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RetrieveLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal userState As Object)
            If (Me.RetrieveLoanFileOperationCompleted Is Nothing) Then
                Me.RetrieveLoanFileOperationCompleted = AddressOf Me.OnRetrieveLoanFileOperationCompleted
            End If
            Me.InvokeAsync("RetrieveLoanFile", New Object() {username, password, loansPQFileID, clfData}, Me.RetrieveLoanFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnRetrieveLoanFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.RetrieveLoanFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RetrieveLoanFileCompleted(Me, New RetrieveLoanFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
     System.Web.Services.WebServiceBindingAttribute(Name:="LoansPQ Web ServiceSoap", [Namespace]:="https://www.lendersoffice.com/los/webservices/")>  _
    Partial Public Class LoansPQWebService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private TransferDataToLendersOfficeOperationCompleted As System.Threading.SendOrPostCallback
        
        Private EditLoanFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RetrieveLoanFileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_LendersOffice_LoansPQ_x0020_Web_x0020_Service
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
        Public Event TransferDataToLendersOfficeCompleted As TransferDataToLendersOfficeCompletedEventHandler
        
        '''<remarks/>
        Public Event EditLoanFileCompleted As EditLoanFileCompletedEventHandler
        
        '''<remarks/>
        Public Event RetrieveLoanFileCompleted As RetrieveLoanFileCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/TransferDataToLendersOffice", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function TransferDataToLendersOffice(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String) As String
            Dim results() As Object = Me.Invoke("TransferDataToLendersOffice", New Object() {username, password, loansPQFileID, clfData})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginTransferDataToLendersOffice(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TransferDataToLendersOffice", New Object() {username, password, loansPQFileID, clfData}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndTransferDataToLendersOffice(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub TransferDataToLendersOfficeAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String)
            Me.TransferDataToLendersOfficeAsync(username, password, loansPQFileID, clfData, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub TransferDataToLendersOfficeAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal userState As Object)
            If (Me.TransferDataToLendersOfficeOperationCompleted Is Nothing) Then
                Me.TransferDataToLendersOfficeOperationCompleted = AddressOf Me.OnTransferDataToLendersOfficeOperationCompleted
            End If
            Me.InvokeAsync("TransferDataToLendersOffice", New Object() {username, password, loansPQFileID, clfData}, Me.TransferDataToLendersOfficeOperationCompleted, userState)
        End Sub
        
        Private Sub OnTransferDataToLendersOfficeOperationCompleted(ByVal arg As Object)
            If (Not (Me.TransferDataToLendersOfficeCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TransferDataToLendersOfficeCompleted(Me, New TransferDataToLendersOfficeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/EditLoanFile", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function EditLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long) As String
            Dim results() As Object = Me.Invoke("EditLoanFile", New Object() {username, password, loansPQFileID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginEditLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("EditLoanFile", New Object() {username, password, loansPQFileID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndEditLoanFile(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub EditLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long)
            Me.EditLoanFileAsync(username, password, loansPQFileID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub EditLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal userState As Object)
            If (Me.EditLoanFileOperationCompleted Is Nothing) Then
                Me.EditLoanFileOperationCompleted = AddressOf Me.OnEditLoanFileOperationCompleted
            End If
            Me.InvokeAsync("EditLoanFile", New Object() {username, password, loansPQFileID}, Me.EditLoanFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnEditLoanFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.EditLoanFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent EditLoanFileCompleted(Me, New EditLoanFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://www.lendersoffice.com/los/webservices/RetrieveLoanFile", RequestNamespace:="https://www.lendersoffice.com/los/webservices/", ResponseNamespace:="https://www.lendersoffice.com/los/webservices/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RetrieveLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String) As String
            Dim results() As Object = Me.Invoke("RetrieveLoanFile", New Object() {username, password, loansPQFileID, clfData})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginRetrieveLoanFile(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("RetrieveLoanFile", New Object() {username, password, loansPQFileID, clfData}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndRetrieveLoanFile(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RetrieveLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String)
            Me.RetrieveLoanFileAsync(username, password, loansPQFileID, clfData, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RetrieveLoanFileAsync(ByVal username As String, ByVal password As String, ByVal loansPQFileID As Long, ByVal clfData As String, ByVal userState As Object)
            If (Me.RetrieveLoanFileOperationCompleted Is Nothing) Then
                Me.RetrieveLoanFileOperationCompleted = AddressOf Me.OnRetrieveLoanFileOperationCompleted
            End If
            Me.InvokeAsync("RetrieveLoanFile", New Object() {username, password, loansPQFileID, clfData}, Me.RetrieveLoanFileOperationCompleted, userState)
        End Sub
        
        Private Sub OnRetrieveLoanFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.RetrieveLoanFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RetrieveLoanFileCompleted(Me, New RetrieveLoanFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub TransferDataToLendersOfficeCompletedEventHandler(ByVal sender As Object, ByVal e As TransferDataToLendersOfficeCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class TransferDataToLendersOfficeCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub EditLoanFileCompletedEventHandler(ByVal sender As Object, ByVal e As EditLoanFileCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class EditLoanFileCompletedEventArgs
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub RetrieveLoanFileCompletedEventHandler(ByVal sender As Object, ByVal e As RetrieveLoanFileCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class RetrieveLoanFileCompletedEventArgs
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
