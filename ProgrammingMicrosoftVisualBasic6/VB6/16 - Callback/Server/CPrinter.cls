VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPrinter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

Dim SaveCBK As CPrinterCBK
Dim frmTimer As frmTimer

Sub StartPrintJob(Filename As String, Optional cbk As CPrinterCBK)
    ' save callback object for later
    Set SaveCBK = cbk
    ' activate the timer that will restart this thread
    Set frmTimer = New frmTimer
    With frmTimer
        Set .Owner = Me
        .Timer1.Interval = 100
        .Timer1.Enabled = True
    End With
End Sub

Friend Sub StartIt()
    Dim totalTime As Single, percent As Integer
    Dim t As Single, startTime As Single

    ' this code is executed when the timer fires for the first time
    ' unload the form and destroy it completely
    Unload frmTimer
    Set frmTimer = Nothing

    ' init a random duration time
    totalTime = Rnd * 10 + 5
    
    ' simulate the printing process
    startTime = Timer
    Do
        ' inform the client that something has happened
        percent = ((Timer - startTime) / totalTime) * 100
        SaveCBK.Progress percent
        ' in this demo just go to sleep for one second
        Sleep 1000
    Loop Until Timer - startTime > totalTime
    
    ' inform the client that the process has been completed
    SaveCBK.Complete 0
    ' IMPORTANT: destroy the reference to the client
    ' so that it won't be kept alive forever
    Set SaveCBK = Nothing
    
End Sub

