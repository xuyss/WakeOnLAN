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
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0"),  _
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
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("System is shutting down!")>  _
        Public Property DefaultMessage() As String
            Get
                Return CType(Me("DefaultMessage"),String)
            End Get
            Set
                Me("DefaultMessage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property DefaultTimeout() As Integer
            Get
                Return CType(Me("DefaultTimeout"),Integer)
            End Get
            Set
                Me("DefaultTimeout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Emergency shutdown!")>  _
        Public Property emerg_message() As String
            Get
                Return CType(Me("emerg_message"),String)
            End Get
            Set
                Me("emerg_message") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property emerg_delay() As Integer
            Get
                Return CType(Me("emerg_delay"),Integer)
            End Get
            Set
                Me("emerg_delay") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Sound() As Boolean
            Get
                Return CType(Me("Sound"),Boolean)
            End Get
            Set
                Me("Sound") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Reboot() As Boolean
            Get
                Return CType(Me("Reboot"),Boolean)
            End Get
            Set
                Me("Reboot") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Force() As Boolean
            Get
                Return CType(Me("Force"),Boolean)
            End Get
            Set
                Me("Force") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Language() As String
            Get
                Return CType(Me("Language"),String)
            End Get
            Set
                Me("Language") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Tile")>  _
        Public Property ListView_View() As Global.System.Windows.Forms.View
            Get
                Return CType(Me("ListView_View"),Global.System.Windows.Forms.View)
            End Get
            Set
                Me("ListView_View") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("780, 580")>  _
        Public Property MainWindow_Size() As Global.System.Drawing.Size
            Get
                Return CType(Me("MainWindow_Size"),Global.System.Drawing.Size)
            End Get
            Set
                Me("MainWindow_Size") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-1, -1")>  _
        Public Property MainWindow_Location() As Global.System.Drawing.Point
            Get
                Return CType(Me("MainWindow_Location"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MainWindow_Location") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowGroups() As Boolean
            Get
                Return CType(Me("ShowGroups"),Boolean)
            End Get
            Set
                Me("ShowGroups") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Pinger() As Boolean
            Get
                Return CType(Me("Pinger"),Boolean)
            End Get
            Set
                Me("Pinger") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CurrentGroup() As String
            Get
                Return CType(Me("CurrentGroup"),String)
            End Get
            Set
                Me("CurrentGroup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowHotButtons() As Boolean
            Get
                Return CType(Me("ShowHotButtons"),Boolean)
            End Get
            Set
                Me("ShowHotButtons") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.0.1")>  _
        Public Property SearchStart() As String
            Get
                Return CType(Me("SearchStart"),String)
            End Get
            Set
                Me("SearchStart") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.0.20")>  _
        Public Property SearchEnd() As String
            Get
                Return CType(Me("SearchEnd"),String)
            End Get
            Set
                Me("SearchEnd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SortColumn() As Integer
            Get
                Return CType(Me("SortColumn"),Integer)
            End Get
            Set
                Me("SortColumn") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property SortDirection() As Integer
            Get
                Return CType(Me("SortDirection"),Integer)
            End Get
            Set
                Me("SortDirection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TaskUserID() As String
            Get
                Return CType(Me("TaskUserID"),String)
            End Get
            Set
                Me("TaskUserID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TaskPassword() As String
            Get
                Return CType(Me("TaskPassword"),String)
            End Get
            Set
                Me("TaskPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property dbPath() As String
            Get
                Return CType(Me("dbPath"),String)
            End Get
            Set
                Me("dbPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MinimizeToTray() As Boolean
            Get
                Return CType(Me("MinimizeToTray"),Boolean)
            End Get
            Set
                Me("MinimizeToTray") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://wol.aquilatech.com/updates/AppCast.xml")>  _
        Public ReadOnly Property updateURL() As String
            Get
                Return CType(Me("updateURL"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7")>  _
        Public ReadOnly Property updateIntervalDays() As Integer
            Get
                Return CType(Me("updateIntervalDays"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property autocheckUpdates() As Boolean
            Get
                Return CType(Me("autocheckUpdates"),Boolean)
            End Get
            Set
                Me("autocheckUpdates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property shutdownAction() As Integer
            Get
                Return CType(Me("shutdownAction"),Integer)
            End Get
            Set
                Me("shutdownAction") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowFolders() As Boolean
            Get
                Return CType(Me("ShowFolders"),Boolean)
            End Get
            Set
                Me("ShowFolders") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ListView_Columns() As String
            Get
                Return CType(Me("ListView_Columns"),String)
            End Get
            Set
                Me("ListView_Columns") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property schedulerColumns() As String
            Get
                Return CType(Me("schedulerColumns"),String)
            End Get
            Set
                Me("schedulerColumns") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("877, 445")>  _
        Public Property schedulerWindowSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("schedulerWindowSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("schedulerWindowSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property schedulerWindowLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("schedulerWindowLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("schedulerWindowLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://wol.aquilatech.com/updates/version.html")>  _
        Public ReadOnly Property updateVersions() As String
            Get
                Return CType(Me("updateVersions"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property needUpgrade() As Boolean
            Get
                Return CType(Me("needUpgrade"),Boolean)
            End Get
            Set
                Me("needUpgrade") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=878X6KTKWVVE"& _ 
            "Q")>  _
        Public ReadOnly Property donate() As String
            Get
                Return CType(Me("donate"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SearchSortColumn() As Integer
            Get
                Return CType(Me("SearchSortColumn"),Integer)
            End Get
            Set
                Me("SearchSortColumn") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property SearchSortDirection() As Integer
            Get
                Return CType(Me("SearchSortDirection"),Integer)
            End Get
            Set
                Me("SearchSortDirection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property Threads() As Integer
            Get
                Return CType(Me("Threads"),Integer)
            End Get
            Set
                Me("Threads") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowToolBar() As Boolean
            Get
                Return CType(Me("ShowToolBar"),Boolean)
            End Get
            Set
                Me("ShowToolBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowStatusBar() As Boolean
            Get
                Return CType(Me("ShowStatusBar"),Boolean)
            End Get
            Set
                Me("ShowStatusBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30000")>  _
        Public ReadOnly Property keepAliveInterval() As Integer
            Get
                Return CType(Me("keepAliveInterval"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowSplash() As Boolean
            Get
                Return CType(Me("ShowSplash"),Boolean)
            End Get
            Set
                Me("ShowSplash") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ackMinimize() As Boolean
            Get
                Return CType(Me("ackMinimize"),Boolean)
            End Get
            Set
                Me("ackMinimize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("750")>  _
        Public Property repeatInterval() As Integer
            Get
                Return CType(Me("repeatInterval"),Integer)
            End Get
            Set
                Me("repeatInterval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SearchColumns() As String
            Get
                Return CType(Me("SearchColumns"),String)
            End Get
            Set
                Me("SearchColumns") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property SearchWindowSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("SearchWindowSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("SearchWindowSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property SearchWindowLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("SearchWindowLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("SearchWindowLocation") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WakeOnLan.My.MySettings
            Get
                Return Global.WakeOnLan.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
