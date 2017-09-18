VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CCountDown"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

Dim frm As frmCountDown
Dim m_Counter As Integer

' The Counter property. Setting a positive value displays
' the form and starts the countdown

Property Get Counter() As Integer
    Counter = m_Counter
End Property

Property Let Counter(newValue As Integer)
    Dim cbk As New CCallBack
    m_Counter = newValue
    cbk.DelayedCall Me, 100, "Start"
End Property

'##Start.MarkAsReferenced True
Sub Start()
    Static active As Boolean
    If active Then Exit Sub
    active = True
    
    If m_Counter > 0 Then
        If frm Is Nothing Then
            Set frm = New frmCountDown
            frm.Show
        End If
        Do Until m_Counter <= 0
            frm.lblCount.Caption = m_Counter
            frm.lblCount.Refresh
            Sleep 1000
            m_Counter = m_Counter - 1
        Loop
    End If
    
    If m_Counter <= 0 Then
        If Not (frm Is Nothing) Then
            Unload frm
            Set frm = Nothing
        End If
    End If
    
    active = False

End Sub


