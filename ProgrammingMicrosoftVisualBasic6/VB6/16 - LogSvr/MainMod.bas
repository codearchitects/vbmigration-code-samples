Attribute VB_Name = "MainModule"
Option Explicit

'##project:DisableMessage 0551


' This is global because it has to live for the entire application's life
'##Thread.AutoNew True
Public Thread As New CThread

' This is for logging capabilities
'##Log.AutoNew True
Public Log As New CLog

Sub Main()
    '## InsertStatement If InitializeFormChaining6() Then Exit Sub
    
    ' Initialize the CLog class
    Log.StartLogging "", 0
    Log.ShowTime = True
    Log.ThreadID = App.ThreadID
    
    'Log.LogEvent "Entering Sub Main"

    If Thread.IsFirstThread Then
        ' Refuse to be instantiated as a component.
        If App.StartMode = vbSModeAutomation Then
            Err.Raise 9999, , "Unable to be instantiated as a component"
        End If
        ' Show the user interface.
        frmMainForm.Show
    Else
        ' This is a component instantiated by this same application.
    End If
    
    Log.LogEvent "Exiting Sub Main"
    
End Sub





