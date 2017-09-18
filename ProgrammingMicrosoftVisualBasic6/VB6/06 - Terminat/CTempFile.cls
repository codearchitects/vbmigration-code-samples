VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CTempFile"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------------------------
' The CTEMPFILE class
'
' This class lets you easily create temporary files
' in Windows' TEMP directory (or in a directory of
' your choice), and automatically closes and deletes
' it when the object variable goes out of scope
'
' Uses the CFILE class
'-------------------------------------------------

Option Explicit

Private Declare Function GetTempFileName Lib "kernel32" Alias "GetTempFileNameA" (ByVal lpszPath As String, ByVal lpPrefixString As String, ByVal wUnique As Long, ByVal lpTempFileName As String) As Long
Private Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long

' the file handle
Dim m_Handle As Integer
' the internal CFile object
Dim m_CFile As New CFile

' Open a temporary file, return its handle

Sub OpenFile(Optional Path As Variant, Optional Prefix As Variant, Optional mode As OpenModeConstants = omRandom)
    Dim fPath As String, fPrefix As String, fName As String
    
    ' check access mode
    If mode = omInput Or mode = omAppend Then
        Err.Raise 1001, , "Input and Append mode not supported"
    End If
    
    ' retrieve file's path
    ' use vbNullString if not path is provided
    If IsMissing(Path) Then
        ' if the path is not provided, uses Windows' TEMP path
        fPath = Space$(512)
        GetTempPath Len(fPath), fPath
        fPath = Left$(fPath, InStr(fPath, vbNullChar) - 1)
    ElseIf Len(Path) Then
        fPath = Path
        ' ensure there is a trailing backslash
        If Right$(fPath, 1) <> "\" Then fPath = fPath & "\"
    End If
    
    ' retrieve file's prefix string, if any
    ' use vbNullString if not prefix is provided
    If Not IsMissing(Prefix) Then
        fPrefix = Prefix
    End If
    ' the prefix must be three character long
    fPrefix = Right$("TMP" & fPrefix, 3)
    
    ' call Windows to get the name of the temporary file
    fName = Space$(512)
    GetTempFileName fPath, fPrefix, False, fName
    fName = Left$(fName, InStr(fName, vbNullChar) - 1)
   
    ' use a CFile object to open the temporary file
    Set m_CFile = New CFile
    m_CFile.OpenFile fName, mode
End Sub

' the file name (read-only property)

Property Get Filename() As String
    ' delegate to internal CFile object
    Filename = m_CFile.Filename
End Property

' the file handle (read-only property)

Property Get Handle() As Integer
    ' delegate to internal CFile object
    Handle = m_CFile.Handle
End Property

' close the file, if still open

Sub CloseFile()
    ' delegate to internal CFile object
    m_CFile.CloseFile
End Sub

' delete the file

Sub DeleteFile()
    ' close the file, if necessary
    CloseFile
    If Len(Filename) Then
        Kill Filename
    End If
End Sub

' delete the temporary file when the object
' goes out of scope

Private Sub Class_Terminate()
    ' close and delete the temporary file
    On Error Resume Next
    DeleteFile
End Sub

