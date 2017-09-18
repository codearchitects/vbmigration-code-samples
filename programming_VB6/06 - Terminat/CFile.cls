VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "CFile"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------------------------
' The CFILE class
'
' A wrapper class for the OPEN statement, that
' automatically close the file when the caller
' procedure exits.
'-------------------------------------------------

Option Explicit

Enum OpenModeConstants
    omInput
    omOutput
    omAppend
    omRandom
    omBinary
End Enum

' the file name
Dim m_Filename As String
' the file handle
Dim m_Handle As Integer

' Open a file

Sub OpenFile(Filename As String, Optional mode As OpenModeConstants = omRandom)
    Dim h As Integer
    ' get the next available file handle
    
    h = FreeFile()
    ' open the file with desired access mode
    Select Case mode
        Case omInput
            Open Filename For Input As #h
        Case omOutput
            Open Filename For Output As #h
        Case omAppend
            Open Filename For Append As #h
        Case omBinary
            Open Filename For Binary As #h
        Case Else
            ' this is the default case
            Open Filename For Random As #h
    End Select
    ' (never reaches this point if an error has occurred)
    
    ' store data into private variables and return
    m_Handle = h
    m_Filename = Filename
End Sub

' the file name (read-only property)

Property Get Filename() As String
    Filename = m_Filename
End Property

' the file handle (read-only property)

Property Get Handle() As Integer
    Handle = m_Handle
End Property

' close the file, if still open

Sub CloseFile()
    If m_Handle Then
        Close #m_Handle
        m_Handle = 0
    End If
End Sub

' force a CloseFile operation when the object
' goes out of scope

Private Sub Class_Terminate()
    CloseFile
End Sub

