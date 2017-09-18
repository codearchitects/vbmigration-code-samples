VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CLog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
'-------------------------------------------------
' A class for logging debug messages from a
' multi-threaded client applications
'-------------------------------------------------

'##project:UseByVal Yes

Option Explicit

' If this property is true, current time is printed with each message
Public ShowTime As Boolean
' If this property is False, no logging takes place
Public Enabled As Boolean
' If this property is non-zero, the ThreadID is added to the message.
Public ThreadID As Long

' This method is patterned after the App's method with the same name.
' In this implementation it simply displays the log form
Sub StartLogging(LogFile As String, LogMode As Integer)
    ' Note that this refers to the global hidden form reference.
    ' This form will therefore be shared by all the instances of this class.
    frmLog.Show
    Enabled = True
End Sub

' This method is patterned after the App's method with the same name.
' In this implementation it simply sends text to the window.
Sub LogEvent(ByVal LogText As String, Optional EventType As LogEventTypeConstants)

    If Not Enabled Then Exit Sub

    ' Add event type information.
    Select Case EventType
        Case vbLogEventTypeError
            LogText = "Error: " & LogText
        Case vbLogEventTypeWarning
            LogText = "Warning: " & LogText
        Case vbLogEventTypeInformation
            LogText = "Information: " & LogText
    End Select
        
    ' Add time information if required (format: hh:mm:ss.hh")
    If ShowTime Then
        Dim t As Single
        t = Timer
        LogText = Time$ & Format$(t - Int(t), ".00") & " - " & LogText
    End If
    
    If ThreadID Then
        LogText = "[" & Right$("0000000" & Hex$(ThreadID), 8) & "] " & LogText
    End If
    
    ' Show the message on the window.
    frmLog.LogEvent LogText
End Sub



