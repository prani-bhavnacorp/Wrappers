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
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.160.82.28/XPWeb/Services/Apex/2006/ComCoreServices.asmx")>  _
        Public ReadOnly Property LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_ComCoreServices_ComCoreServices() As String
            Get
                Return CType(Me("LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_ComCoreServices_ComCoreServices"& _ 
                    ""),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.160.82.28/XPWeb/Services/Apex/2006/FinancialServices.asmx")>  _
        Public ReadOnly Property LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_FinancialServices_FinancialServices() As String
            Get
                Return CType(Me("LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_FinancialServices_FinancialServ"& _ 
                    "ices"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.160.82.28/XPWeb/Services/Apex/2006/LendingServices.asmx")>  _
        Public ReadOnly Property LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_LendingServices_LendingServices() As String
            Get
                Return CType(Me("LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_LendingServices_LendingServices"& _ 
                    ""),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.160.82.28/XPWeb/Services/Apex/2008/01/LendingServices.asmx")>  _
        Public ReadOnly Property LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_LendingServices2008_LendingServices2008() As String
            Get
                Return CType(Me("LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_LendingServices2008_LendingServ"& _ 
                    "ices2008"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://10.160.82.28/xpweb/services/apex/2006/MemberServices.asmx")>  _
        Public ReadOnly Property LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_MemberServices_MemberServices() As String
            Get
                Return CType(Me("LoansPQWSWrappers_XP2_APEX_2020_1_XP2_APEX_2020_1_MemberServices_MemberServices"),String)
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
