﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Strings
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WakeOnLan.Strings", GetType(Strings).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Abort {0} Error: {1}.
        '''</summary>
        Friend Shared ReadOnly Property AbortFailed() As String
            Get
                Return ResourceManager.GetString("AbortFailed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Aborting....
        '''</summary>
        Friend Shared ReadOnly Property Aborting() As String
            Get
                Return ResourceManager.GetString("Aborting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Aborting shutdown command on {0}.
        '''</summary>
        Friend Shared ReadOnly Property AbortingShutdown() As String
            Get
                Return ResourceManager.GetString("AbortingShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Abort Shutdown in progress....
        '''</summary>
        Friend Shared ReadOnly Property AbortShutdown() As String
            Get
                Return ResourceManager.GetString("AbortShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Abort {0} successful.
        '''</summary>
        Friend Shared ReadOnly Property AbortSuccess() As String
            Get
                Return ResourceManager.GetString("AbortSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Send an email.
        '''</summary>
        Friend Shared ReadOnly Property actions_email() As String
            Get
                Return ResourceManager.GetString("actions_email", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Hibernate computer.
        '''</summary>
        Friend Shared ReadOnly Property actions_hibernate() As String
            Get
                Return ResourceManager.GetString("actions_hibernate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Hibernate All Computers.
        '''</summary>
        Friend Shared ReadOnly Property actions_hibernateAll() As String
            Get
                Return ResourceManager.GetString("actions_hibernateAll", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Popup a message.
        '''</summary>
        Friend Shared ReadOnly Property actions_popup() As String
            Get
                Return ResourceManager.GetString("actions_popup", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutdown computer.
        '''</summary>
        Friend Shared ReadOnly Property actions_shutdown() As String
            Get
                Return ResourceManager.GetString("actions_shutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutdown All Computers.
        '''</summary>
        Friend Shared ReadOnly Property actions_shutdownAll() As String
            Get
                Return ResourceManager.GetString("actions_shutdownAll", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sleep computer.
        '''</summary>
        Friend Shared ReadOnly Property actions_sleep() As String
            Get
                Return ResourceManager.GetString("actions_sleep", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sleep All Computers.
        '''</summary>
        Friend Shared ReadOnly Property actions_sleepAll() As String
            Get
                Return ResourceManager.GetString("actions_sleepAll", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Start computer.
        '''</summary>
        Friend Shared ReadOnly Property actions_start() As String
            Get
                Return ResourceManager.GetString("actions_start", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Start All computers.
        '''</summary>
        Friend Shared ReadOnly Property actions_startAll() As String
            Get
                Return ResourceManager.GetString("actions_startAll", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All machines.
        '''</summary>
        Friend Shared ReadOnly Property AllMachines() As String
            Get
                Return ResourceManager.GetString("AllMachines", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure?.
        '''</summary>
        Friend Shared ReadOnly Property AreYouSure() As String
            Get
                Return ResourceManager.GetString("AreYouSure", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Begin shutdown....
        '''</summary>
        Friend Shared ReadOnly Property BeginShutdown() As String
            Get
                Return ResourceManager.GetString("BeginShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your changes will be lost..
        '''</summary>
        Friend Shared ReadOnly Property ChangesLost() As String
            Get
                Return ResourceManager.GetString("ChangesLost", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Changes have not been saved.
        '''</summary>
        Friend Shared ReadOnly Property ChangesNotSaved() As String
            Get
                Return ResourceManager.GetString("ChangesNotSaved", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Emergency shutdown!.
        '''</summary>
        Friend Shared ReadOnly Property DefaultEmergency() As String
            Get
                Return ResourceManager.GetString("DefaultEmergency", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to System is shutting down!.
        '''</summary>
        Friend Shared ReadOnly Property DefaultMessage() As String
            Get
                Return ResourceManager.GetString("DefaultMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete {0} records?.
        '''</summary>
        Friend Shared ReadOnly Property Delete() As String
            Get
                Return ResourceManager.GetString("Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done.
        '''</summary>
        Friend Shared ReadOnly Property Done() As String
            Get
                Return ResourceManager.GetString("Done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Emergency shutdown started.
        '''</summary>
        Friend Shared ReadOnly Property EmergencyShutdown() As String
            Get
                Return ResourceManager.GetString("EmergencyShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid IP Address.  Use ###.###.###.###.
        '''</summary>
        Friend Shared ReadOnly Property ErrorInvalidIP() As String
            Get
                Return ResourceManager.GetString("ErrorInvalidIP", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid MAC Address.  Use ##:##:##:##:##:##.
        '''</summary>
        Friend Shared ReadOnly Property ErrorInvalidMAC() As String
            Get
                Return ResourceManager.GetString("ErrorInvalidMAC", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid computer name.
        '''</summary>
        Friend Shared ReadOnly Property ErrorInvalidName() As String
            Get
                Return ResourceManager.GetString("ErrorInvalidName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error: {0}.
        '''</summary>
        Friend Shared ReadOnly Property ErrorMsg() As String
            Get
                Return ResourceManager.GetString("ErrorMsg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings were exported to [{0}].
        '''</summary>
        Friend Shared ReadOnly Property ExportedTo() As String
            Get
                Return ResourceManager.GetString("ExportedTo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Host {0} not responding.
        '''</summary>
        Friend Shared ReadOnly Property HostNotResponding() As String
            Get
                Return ResourceManager.GetString("HostNotResponding", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This will IMMEDIATELY reboot THIS machine.  Are you sure?.
        '''</summary>
        Friend Shared ReadOnly Property ImmediateReboot() As String
            Get
                Return ResourceManager.GetString("ImmediateReboot", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This will IMMEDIATELY shutdown THIS machine.  Are you sure?.
        '''</summary>
        Friend Shared ReadOnly Property ImmediateShutdown() As String
            Get
                Return ResourceManager.GetString("ImmediateShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings were imported from [{0}].
        '''</summary>
        Friend Shared ReadOnly Property ImportedFrom() As String
            Get
                Return ResourceManager.GetString("ImportedFrom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New.
        '''</summary>
        Friend Shared ReadOnly Property isNew() As String
            Get
                Return ResourceManager.GetString("isNew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} - trial version is limited to 3 machines.
        '''</summary>
        Friend Shared ReadOnly Property Limited() As String
            Get
                Return ResourceManager.GetString("Limited", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to At {0} on {1}.
        '''</summary>
        Friend Shared ReadOnly Property lit_at() As String
            Get
                Return ResourceManager.GetString("lit_at", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to At {0} every {1} day(s).
        '''</summary>
        Friend Shared ReadOnly Property lit_atDays() As String
            Get
                Return ResourceManager.GetString("lit_atDays", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to At {0} every {1} every {2} weeks, starting {3}.
        '''</summary>
        Friend Shared ReadOnly Property lit_atWeeks() As String
            Get
                Return ResourceManager.GetString("lit_atWeeks", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Disabled.
        '''</summary>
        Friend Shared ReadOnly Property lit_Disabled() As String
            Get
                Return ResourceManager.GetString("lit_Disabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enabled.
        '''</summary>
        Friend Shared ReadOnly Property lit_Enabled() As String
            Get
                Return ResourceManager.GetString("lit_Enabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend Shared ReadOnly Property lit_Error() As String
            Get
                Return ResourceManager.GetString("lit_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to False.
        '''</summary>
        Friend Shared ReadOnly Property lit_false() As String
            Get
                Return ResourceManager.GetString("lit_false", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid command line.
        '''</summary>
        Friend Shared ReadOnly Property lit_Invalid() As String
            Get
                Return ResourceManager.GetString("lit_Invalid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Multiple triggers defined.
        '''</summary>
        Friend Shared ReadOnly Property lit_multipleTriggers() As String
            Get
                Return ResourceManager.GetString("lit_multipleTriggers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Never.
        '''</summary>
        Friend Shared ReadOnly Property lit_Never() As String
            Get
                Return ResourceManager.GetString("lit_Never", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to None.
        '''</summary>
        Friend Shared ReadOnly Property lit_None() As String
            Get
                Return ResourceManager.GetString("lit_None", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} does not appear to have read access rights to the WOL Scheduler database. Grant access?.
        '''</summary>
        Friend Shared ReadOnly Property lit_noRights() As String
            Get
                Return ResourceManager.GetString("lit_noRights", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Machine not found.
        '''</summary>
        Friend Shared ReadOnly Property lit_notFound() As String
            Get
                Return ResourceManager.GetString("lit_notFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Queued.
        '''</summary>
        Friend Shared ReadOnly Property lit_Queued() As String
            Get
                Return ResourceManager.GetString("lit_Queued", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ready.
        '''</summary>
        Friend Shared ReadOnly Property lit_Ready() As String
            Get
                Return ResourceManager.GetString("lit_Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Running.
        '''</summary>
        Friend Shared ReadOnly Property lit_Running() As String
            Get
                Return ResourceManager.GetString("lit_Running", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to True.
        '''</summary>
        Friend Shared ReadOnly Property lit_true() As String
            Get
                Return ResourceManager.GetString("lit_true", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unknown.
        '''</summary>
        Friend Shared ReadOnly Property lit_Unknown() As String
            Get
                Return ResourceManager.GetString("lit_Unknown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Host is OFFLINE.
        '''</summary>
        Friend Shared ReadOnly Property OffLine() As String
            Get
                Return ResourceManager.GetString("OffLine", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Host is ONLINE.
        '''</summary>
        Friend Shared ReadOnly Property OnLine() As String
            Get
                Return ResourceManager.GetString("OnLine", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Broadcast Address.
        '''</summary>
        Friend Shared ReadOnly Property Opt_BroadcastAddress() As String
            Get
                Return ResourceManager.GetString("Opt_BroadcastAddress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter the broadcast IP Address for the WOL broadcast packets..
        '''</summary>
        Friend Shared ReadOnly Property Opt_BroadcastDesc() As String
            Get
                Return ResourceManager.GetString("Opt_BroadcastDesc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pausing....
        '''</summary>
        Friend Shared ReadOnly Property Pausing() As String
            Get
                Return ResourceManager.GetString("Pausing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Polling {0}.
        '''</summary>
        Friend Shared ReadOnly Property Polling() As String
            Get
                Return ResourceManager.GetString("Polling", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Properties - {0}.
        '''</summary>
        Friend Shared ReadOnly Property Properties() As String
            Get
                Return ResourceManager.GetString("Properties", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} Response Time {1} ms.
        '''</summary>
        Friend Shared ReadOnly Property ResponseTime() As String
            Get
                Return ResourceManager.GetString("ResponseTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select a WakeOnLan settings file to import.
        '''</summary>
        Friend Shared ReadOnly Property SelectFile() As String
            Get
                Return ResourceManager.GetString("SelectFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sending shutdown command to {0}.
        '''</summary>
        Friend Shared ReadOnly Property SendShutdown() As String
            Get
                Return ResourceManager.GetString("SendShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sent Wake Up packet to {0} at {1}....
        '''</summary>
        Friend Shared ReadOnly Property SentTo() As String
            Get
                Return ResourceManager.GetString("SentTo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutdown failed for {0} {1}.
        '''</summary>
        Friend Shared ReadOnly Property ShutdownFailed() As String
            Get
                Return ResourceManager.GetString("ShutdownFailed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutting down in {0} seconds....
        '''</summary>
        Friend Shared ReadOnly Property ShutDownSeconds() As String
            Get
                Return ResourceManager.GetString("ShutDownSeconds", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutdown {0} successful.
        '''</summary>
        Friend Shared ReadOnly Property ShutdownSuccessful() As String
            Get
                Return ResourceManager.GetString("ShutdownSuccessful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutting down....
        '''</summary>
        Friend Shared ReadOnly Property ShuttingDown() As String
            Get
                Return ResourceManager.GetString("ShuttingDown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Skipping....
        '''</summary>
        Friend Shared ReadOnly Property Skipping() As String
            Get
                Return ResourceManager.GetString("Skipping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Successful.
        '''</summary>
        Friend Shared ReadOnly Property Successful() As String
            Get
                Return ResourceManager.GetString("Successful", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Wake on LAN.
        '''</summary>
        Friend Shared ReadOnly Property Title() As String
            Get
                Return ResourceManager.GetString("Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Version {0}.{1:00}.{2}.
        '''</summary>
        Friend Shared ReadOnly Property Version() As String
            Get
                Return ResourceManager.GetString("Version", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Where do you want to save the settings?.
        '''</summary>
        Friend Shared ReadOnly Property WhereSave() As String
            Get
                Return ResourceManager.GetString("WhereSave", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
