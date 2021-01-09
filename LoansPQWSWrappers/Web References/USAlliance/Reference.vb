﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
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
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.5466.
'
Namespace USAlliance
    
    '''<remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"), _
	 System.Diagnostics.DebuggerStepThroughAttribute(), _
	 System.ComponentModel.DesignerCategoryAttribute("code"), _
	 System.Web.Services.WebServiceBindingAttribute(Name:="AchAccountServiceSoapBinding", [Namespace]:="http://com.fwdco.marketplace/hub/usa")> _
	Partial Public Class AchAccountService
		Inherits Microsoft.Web.Services3.WebServicesClientProtocol
		'Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

		Private setEmployeeAchAccountInfoOperationCompleted As System.Threading.SendOrPostCallback

		Private useDefaultCredentialsSetExplicitly As Boolean

		'''<remarks/>
		Public Sub New()
			MyBase.New()
			Me.Url = Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default.LoansPQWSWrappers_USAlliance_AchAccountService
			If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
				Me.UseDefaultCredentials = True
				Me.useDefaultCredentialsSetExplicitly = False
			Else
				Me.useDefaultCredentialsSetExplicitly = True
			End If
		End Sub

		Public Shadows Property Url() As String
			Get
				Return MyBase.Url
			End Get
			Set(ByVal value As String)
				If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) _
							AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) _
							AndAlso (Me.IsLocalFileSystemWebService(Value) = False)) Then
					MyBase.UseDefaultCredentials = False
				End If
				MyBase.Url = Value
			End Set
		End Property

		Public Shadows Property UseDefaultCredentials() As Boolean
			Get
				Return MyBase.UseDefaultCredentials
			End Get
			Set(ByVal value As Boolean)
				MyBase.UseDefaultCredentials = Value
				Me.useDefaultCredentialsSetExplicitly = True
			End Set
		End Property

		'''<remarks/>
		Public Event setEmployeeAchAccountInfoCompleted As setEmployeeAchAccountInfoCompletedEventHandler

		'''<remarks/>
		<System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)> _
		Public Function setEmployeeAchAccountInfo(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal sessionId As String, <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal employeeId As String, <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal transitNo As String, <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal accountNo As String, <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal memo As String, <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> ByVal logMsg As String) As <System.Xml.Serialization.XmlElementAttribute("setEmployeeAchAccountInfoResponse", [Namespace]:="http://com.fwdco.marketplace/hub/usa", IsNullable:=True)> wsResponse
			Dim results() As Object = Me.Invoke("setEmployeeAchAccountInfo", New Object() {sessionId, employeeId, transitNo, accountNo, memo, logMsg})
			Return CType(results(0), wsResponse)
		End Function

		'''<remarks/>
		Public Function BeginsetEmployeeAchAccountInfo(ByVal sessionId As String, ByVal employeeId As String, ByVal transitNo As String, ByVal accountNo As String, ByVal memo As String, ByVal logMsg As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
			Return Me.BeginInvoke("setEmployeeAchAccountInfo", New Object() {sessionId, employeeId, transitNo, accountNo, memo, logMsg}, callback, asyncState)
		End Function

		'''<remarks/>
		Public Function EndsetEmployeeAchAccountInfo(ByVal asyncResult As System.IAsyncResult) As wsResponse
			Dim results() As Object = Me.EndInvoke(asyncResult)
			Return CType(results(0), wsResponse)
		End Function

		'''<remarks/>
		Public Overloads Sub setEmployeeAchAccountInfoAsync(ByVal sessionId As String, ByVal employeeId As String, ByVal transitNo As String, ByVal accountNo As String, ByVal memo As String, ByVal logMsg As String)
			Me.setEmployeeAchAccountInfoAsync(sessionId, employeeId, transitNo, accountNo, memo, logMsg, Nothing)
		End Sub

		'''<remarks/>
		Public Overloads Sub setEmployeeAchAccountInfoAsync(ByVal sessionId As String, ByVal employeeId As String, ByVal transitNo As String, ByVal accountNo As String, ByVal memo As String, ByVal logMsg As String, ByVal userState As Object)
			If (Me.setEmployeeAchAccountInfoOperationCompleted Is Nothing) Then
				Me.setEmployeeAchAccountInfoOperationCompleted = AddressOf Me.OnsetEmployeeAchAccountInfoOperationCompleted
			End If
			Me.InvokeAsync("setEmployeeAchAccountInfo", New Object() {sessionId, employeeId, transitNo, accountNo, memo, logMsg}, Me.setEmployeeAchAccountInfoOperationCompleted, userState)
		End Sub

		Private Sub OnsetEmployeeAchAccountInfoOperationCompleted(ByVal arg As Object)
			If (Not (Me.setEmployeeAchAccountInfoCompletedEvent) Is Nothing) Then
				Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
				RaiseEvent setEmployeeAchAccountInfoCompleted(Me, New setEmployeeAchAccountInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
			End If
		End Sub

		'''<remarks/>
		Public Shadows Sub CancelAsync(ByVal userState As Object)
			MyBase.CancelAsync(userState)
		End Sub

		Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
			If ((url Is Nothing) _
						OrElse (url Is String.Empty)) Then
				Return False
			End If
			Dim wsUri As System.Uri = New System.Uri(url)
			If ((wsUri.Port >= 1024) _
						AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
				Return True
			End If
			Return False
		End Function
	End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://com.fwdco.marketplace/hub/usa")>  _
    Partial Public Class wsResponse
        
        Private errorCodeField As Integer
        
        Private errorMessageField As String
        
        Private logMsgField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property errorCode() As Integer
            Get
                Return Me.errorCodeField
            End Get
            Set
                Me.errorCodeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property errorMessage() As String
            Get
                Return Me.errorMessageField
            End Get
            Set
                Me.errorMessageField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property logMsg() As String
            Get
                Return Me.logMsgField
            End Get
            Set
                Me.logMsgField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub setEmployeeAchAccountInfoCompletedEventHandler(ByVal sender As Object, ByVal e As setEmployeeAchAccountInfoCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class setEmployeeAchAccountInfoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As wsResponse
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),wsResponse)
            End Get
        End Property
    End Class
End Namespace
