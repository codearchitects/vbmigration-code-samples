VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CTracer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' class CTracer - complete source code
Private m_procname As String
Private m_enterTime As Single

Sub Enter(procname As String)
    ' remember procedure name and start time
    m_procname = procname
    m_enterTime = Timer
    ' print the log
    Debug.Print "Enter " & m_procname
End Sub

Private Sub Class_Terminate()
    ' print the log when the procedure is exited
    Debug.Print "Exit " & m_procname & " - sec. " & (Timer - m_enterTime)
End Sub

