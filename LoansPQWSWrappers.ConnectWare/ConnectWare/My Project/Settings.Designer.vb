﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CIAcctPrflWSV7")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISAccountProfile_mtvnCWCIAcctPrflWSV7() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISAccountProfile_mtvnCWCIAcctPrflWSV7"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustNbrSrchWSV7")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISCustomerSearchByCustomerNumber_mtvnCWCICustNbrSrchWSV7() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISCustomerSearchByCustomerNumber_mtvnCWCICustNbrSr"& _ 
                    "chWSV7"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustTaxNbrSrchWSV7")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CSICustomerSearchByTaxNumber_mtvnCWCICustTaxNbrSrchWSV7() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CSICustomerSearchByTaxNumber_mtvnCWCICustTaxNbrSrch"& _ 
                    "WSV7"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustToAcctRltWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISCustomerToAccountRelationship_mtvnCWCICustToAcctRltWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISCustomerToAccountRelationship_mtvnCWCICustToAcct"& _ 
                    "RltWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CIOpenIndvCustWSV4")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISOpenIndividualCustomer_mtvnCWCIOpenIndvCustWSV4() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISOpenIndividualCustomer_mtvnCWCIOpenIndvCustWSV4"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CIRltDemogUpdtWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISRelationshipDemographicUpdate_mtvnCWCIRltDemogUpdtWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISRelationshipDemographicUpdate_mtvnCWCIRltDemogUp"& _ 
                    "dtWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CIRltDemogInqWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISRelationshipDemographicInquiry_mtvnCWCIRltDemogInqWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISRelationshipDemographicInquiry_mtvnCWCIRltDemogI"& _ 
                    "nqWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/DPNewAcctWSV4")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_DepositNewAccount_mtvnCWDPNewAcctWSV4() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_DepositNewAccount_mtvnCWDPNewAcctWSV4"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/DPHoldAddWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_DepositHoldAdd_mtvnCWDPHoldAddWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_DepositHoldAdd_mtvnCWDPHoldAddWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/DPAcctNbrGenWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_DepositAccountNumberGenerator_mtvnCWDPAcctNbrGenWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_DepositAccountNumberGenerator_mtvnCWDPAcctNbrGenWSV"& _ 
                    "1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CustomerInfoSystemSCPWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_CISSingleCommitPointProcessing_FinancialConnectWebSvcV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_CISSingleCommitPointProcessing_FinancialConnectWebS"& _ 
                    "vcV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNoteInqWSV8")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNoteInquiry_mtvnCWLNNoteInqWSV8() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNoteInquiry_mtvnCWLNNoteInqWSV8"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNManFeeWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanManualFeeAssessment_mtvnCWLNManFeeWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanManualFeeAssessment_mtvnCWLNManFeeWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNewAcctWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNewAccount_mtvnCWLNNewAcctWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNewAccount_mtvnCWLNNewAcctWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNewCommtWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNewCommitment_mtvnCWLNNewCommtWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNewCommitment_mtvnCWLNNewCommtWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNewNoteWSV6")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNewNote_mtvnCWLNNewNoteWSV6() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNewNote_mtvnCWLNNewNoteWSV6"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNewNmeAddrWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNewChangeNameAndAddress_mtvnCWLNNewNmeAddrWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNewChangeNameAndAddress_mtvnCWLNNewNmeAddrWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNoteIncrWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNoteIncrease_mtvnCWLNNoteIncrWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNoteIncrease_mtvnCWLNNoteIncrWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNotePmtWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNotePayment_mtvnCWLNNotePmtWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNotePayment_mtvnCWLNNotePmtWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNAutoFeeSetpWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanAutomatedFeeSetup_mtvnCWLNAutoFeeSetpWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanAutomatedFeeSetup_mtvnCWLNAutoFeeSetpWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNoteCollMaintWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanNoteCollateralMainenance_mtvnCWLNNoteCollMaintWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanNoteCollateralMainenance_mtvnCWLNNoteCollMaintW"& _ 
                    "SV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNAcctNbrGenWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanAccountNumberGenerator_mtvnCWLNAcctNbrGenWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanAccountNumberGenerator_mtvnCWLNAcctNbrGenWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/FMDfctTrsfrSetpWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_IFMSDefictFundsTransfer_mtvnCWFMDfctTrsfrSetpWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_IFMSDefictFundsTransfer_mtvnCWFMDfctTrsfrSetpWSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LoanSCPWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_LoanSingleCommitPointProcessing_FinancialConnectWebSvcV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_LoanSingleCommitPointProcessing_FinancialConnectWeb"& _ 
                    "SvcV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustRltInqWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerRelationshipInquiry_mtvnCWCICustRltInqWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerRelationshipInquiry_mtvnCWCI"& _ 
                    "CustRltInqWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustPrflWSV6")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerProfile_mtvnCWCICustPrflWSV6() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerProfile_mtvnCWCICustPrflWSV6"& _ 
                    ""),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNNoteListInqWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_LoanNoteListInquiry_mtvnCWLNNoteListInqWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_LoanNoteListInquiry_mtvnCWLNNoteListInq"& _ 
                    "WSV2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/LNFloodTrackingMaintWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_LoanFloodTrackingMaintenance_mtvnCWLNFloodTrackingMaintWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_LoanFloodTrackingMaintenance_mtvnCWLNFl"& _ 
                    "oodTrackingMaintWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/CICustEmailMaintWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerEmailMaintenance_mtvnCWCICustEmailMaintWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_CISCustomerEmailMaintenance_mtvnCWCICus"& _ 
                    "tEmailMaintWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://xmlgateway.metavante.org/ConnectwareWS/DPAcctInqWSV8")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_DepositAccountInquiry_mtvnCWDPAcctInqWSV8() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_DepositAccountInquiry_mtvnCWDPAcctInqWS"& _ 
                    "V8"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://ih-excust-other.fisglobal.com/ConnectwareWS/CICustDueDiligenceWSV1")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_CICustomerDueDiligence_mtvnCWCICustDueDiligenceWSV1() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_CICustomerDueDiligence_mtvnCWCICustDueD"& _ 
                    "iligenceWSV1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://ih-excust-other.fisglobal.com/ConnectwareWS/LNHMDAMaintWSV3")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_LoanHMDAMaintenance1_mtvnCWLNHMDAMaintWSV3() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_LoanHMDAMaintenance1_mtvnCWLNHMDAMaintW"& _ 
                    "SV3"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://ih-excust-other.fisglobal.com/ConnectwareWS/LNUsrDefFldsWSV2")>  _
        Public ReadOnly Property LoansPQWSWrappers_ConnectWare_ConnectWare_LoanUserDefinedFields_mtvnCWLNUsrDefFldsWSV2() As String
            Get
                Return CType(Me("LoansPQWSWrappers_ConnectWare_ConnectWare_LoanUserDefinedFields_mtvnCWLNUsrDefFld"& _ 
                    "sWSV2"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.LoansPQ.WebServices.Wrappers.My.MySettings
            Get
                Return Global.LoansPQ.WebServices.Wrappers.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
