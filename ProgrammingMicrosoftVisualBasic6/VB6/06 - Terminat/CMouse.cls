VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "CMouse"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------------------------
' The CMOUSE class
'
' This class lets you set the mouse pointer to any
' shape, and it will automatically restore the
' original pointer when the procedure exits
'-------------------------------------------------

Option Explicit

' this holds the original mouse cursor
Dim m_OldPointer As Variant

' enforce a new mouse pointer

Sub SetPointer(Optional NewPointer As MousePointerConstants = vbHourglass)
    ' only store it once
    If IsEmpty(m_OldPointer) Then
        m_OldPointer = Screen.MousePointer
    End If
    Screen.MousePointer = NewPointer
End Sub

' automatically restore the original pointer when
' the object goes out of scope

Private Sub Class_Terminate()
    ' only if SetPointer had been actually called
    If Not IsEmpty(m_OldPointer) Then
        Screen.MousePointer = m_OldPointer
    End If
End Sub
