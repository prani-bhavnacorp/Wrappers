﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18052
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
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18052.
'
Namespace CUDLConnectCreateAppService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ProcessDecisionRequestServiceSoap", [Namespace]:="http://www.cudl.com/CUDLConnect/")>  _
    Partial Public Class ProcessDecisionRequestService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private CreateApplicationFromCUDLConnectOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_CUDLConnectUnderwriting_ProcessDecisionRequestUnderwriting
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
        Public Event CreateApplicationFromCUDLConnectCompleted As CreateApplicationFromCUDLConnectCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cudl.com/CUDLConnect/CreateApplicationFromCUDLConnect", RequestNamespace:="http://www.cudl.com/CUDLConnect/", ResponseNamespace:="http://www.cudl.com/CUDLConnect/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CreateApplicationFromCUDLConnect(ByVal CUDLConnectMessage As String)
            Me.Invoke("CreateApplicationFromCUDLConnect", New Object() {CUDLConnectMessage})
        End Sub
        
        '''<remarks/>
        Public Function BeginCreateApplicationFromCUDLConnect(ByVal CUDLConnectMessage As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CreateApplicationFromCUDLConnect", New Object() {CUDLConnectMessage}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Sub EndCreateApplicationFromCUDLConnect(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateApplicationFromCUDLConnectAsync(ByVal CUDLConnectMessage As String)
            Me.CreateApplicationFromCUDLConnectAsync(CUDLConnectMessage, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CreateApplicationFromCUDLConnectAsync(ByVal CUDLConnectMessage As String, ByVal userState As Object)
            If (Me.CreateApplicationFromCUDLConnectOperationCompleted Is Nothing) Then
                Me.CreateApplicationFromCUDLConnectOperationCompleted = AddressOf Me.OnCreateApplicationFromCUDLConnectOperationCompleted
            End If
            Me.InvokeAsync("CreateApplicationFromCUDLConnect", New Object() {CUDLConnectMessage}, Me.CreateApplicationFromCUDLConnectOperationCompleted, userState)
        End Sub
        
        Private Sub OnCreateApplicationFromCUDLConnectOperationCompleted(ByVal arg As Object)
            If (Not (Me.CreateApplicationFromCUDLConnectCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CreateApplicationFromCUDLConnectCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub CreateApplicationFromCUDLConnectCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
End Namespace
