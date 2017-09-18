Attribute VB_Name = "MainModule"
Option Explicit

'##project:UseByVal Yes

'##Thread.AutoNew True
' This is global because it has to live for the entire application's life
Public Thread As New CThread

Sub Main()
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
End Sub






