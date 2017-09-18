VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 1  'vbDataSource
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "TextFileDataSource"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
' A data source class that wraps semicolon delimited text files
' The first line in the file holds the field names.

Option Explicit

' This event is sent when data is flushed to disk.
Event Flush()

Const DEFAULT_EXT = ".DAT"   ' Default extension for text files.

Enum adsEOFActionEnum
    adsEOFActionMoveLast
    adsEOFActionEOF
    adsEOFActionAddnew
End Enum

Enum adsBOFAction
    adsBOFActionMoveFirst
    adsBOFActionBOF
End Enum

' The manufactured ADO recordset
Private rs As ADODB.Recordset

Private m_DataMember As String
Private m_File As String

Private m_EOFAction As adsEOFActionEnum
Private m_BOFAction As adsBOFAction
Private m_FilePath As String
Private m_ReadOnlyMode As Boolean

' Return the recordset when the consumer asks for it.

Private Sub Class_GetDataMember(DataMember As String, Data As Object)
    If DataMember = "" Then Exit Sub
    
    ' Create the recordset only if necessary.
    ' (it doesn't appear to be useful: defensive programming)
    If DataMember <> m_DataMember Or (rs Is Nothing) Then
        LoadRecordset DataMember
    End If
    Set Data = rs
End Sub

Private Sub LoadRecordset(ByVal DataMember As String)
    Dim File As String, fnum As Integer
    Dim row As Long, col As Long
    Dim Text As String
    Dim Lines() As String, Values() As String
    
    On Error GoTo ErrorHandler
        
    File = m_FilePath & DataMember
    If InStr(File, ".") = 0 Then File = File & DEFAULT_EXT
    
    ' Read the contents of file in memory.
    fnum = FreeFile()
    Open File For Input As #fnum
    Text = Input$(LOF(fnum), #fnum)
    Close #fnum
    
    ' Create a new recordset.
    CloseRecordset
    Set rs = New ADODB.Recordset
    
    ' Convert the long string into an array of arrays
    Lines() = Split(Text, vbCrLf)
    ' Get the field names, append to the Fields collection.
    Values() = Split(Lines(0), ";")
    For col = 0 To UBound(Values)
        rs.Fields.Append Values(col), adBSTR
    Next
    
    ' Read the actual data, append to the recordset
    rs.Open
    For row = 1 To UBound(Lines)
        ' Skip over empty lines.
        If Len(Lines(row)) Then
            Values() = Split(Lines(row), ";")
            rs.AddNew
            For col = 0 To UBound(Values)
                rs(col) = Values(col)
            Next
        End If
    Next
    ' Reset the record pointer.
    rs.MoveFirst
    
    ' remember DataMember and File for next time.
    m_DataMember = DataMember
    m_File = File
    Exit Sub
    
ErrorHandler:
    Err.Raise 1001, , "Unable to load data from " & DataMember
End Sub

Sub Flush()
    Dim fnum As Integer, Text As String
    Dim row As Long, col As Long
    Dim Bookmark As Variant
    
    On Error GoTo Error_Handler
    
    ' convert Field names into a semicolon-delimited string
    For col = 0 To rs.Fields.Count - 1
        Text = Text & rs.Fields(col).Name & ";"
    Next
    Text = Left$(Text, Len(Text) - 1) & vbCrLf

    ' Remember the current position in the recordset.
    Bookmark = rs.Bookmark
    ' Convert data into a semicolon-delimited string
    rs.MoveFirst
    Text = Text & rs.GetString(adClipString, , ";", vbCrLf)
    ' Restore original position.
    rs.Bookmark = Bookmark
    
    ' Flush the string to the file.
    fnum = FreeFile
    Open m_File For Output As #fnum
    Print #fnum, Text;
    Close #1
    
    RaiseEvent Flush
    
    Exit Sub
    
Error_Handler:
    Err.Raise 1002, , "Unable to flush data to file"
End Sub

' "Safe" access to the recordset, raises a meaningful error if Nothing.

Property Get Recordset() As ADODB.Recordset
    If rs Is Nothing Then
        Err.Raise 1001, , "Recordset isn't available yet"
    Else
        Set Recordset = rs
    End If
End Property

' Close the recordset if still open.

Private Sub CloseRecordset()
    If Not (rs Is Nothing) Then
        If Not ReadOnlyMode Then Flush
        rs.Close
    End If
    m_DataMember = ""
End Sub

Private Sub Class_Initialize()
    RefreshDataMembers
    m_ReadOnlyMode = True
End Sub

Private Sub Class_Terminate()
    ' Close the recordset on exit.
    CloseRecordset
End Sub


' The FilePath property.
' Each time this property changes the DataMembers collection is refreshed.

Public Property Get FilePath() As String
    FilePath = m_FilePath
End Property

Public Property Let FilePath(ByVal newValue As String)
    If newValue <> m_FilePath Then
        m_FilePath = newValue
        If Len(m_FilePath) > 0 And InStr(":\", Right$(m_FilePath, 1)) = 0 Then
            m_FilePath = m_FilePath & "\"
        End If
        RefreshDataMembers
    End If
End Property

' Rebuild the DataMembers collections

Private Sub RefreshDataMembers()
    Dim File As String
    
    DataMembers.Clear
    ' Load all the file names in the directory
    File = Dir$(m_FilePath & "*" & DEFAULT_EXT)
    Do While Len(File)
        DataMembers.Add Left$(File, Len(File) - Len(DEFAULT_EXT))
        File = Dir$()
    Loop
End Sub

' Public properties.

Public Property Get EOF() As Boolean
    EOF = Recordset.EOF
End Property

Public Property Get BOF() As Boolean
    BOF = Recordset.BOF
End Property

Public Property Get RecordCount() As Long
    RecordCount = Recordset.RecordCount
End Property

Public Property Get Bookmark() As Variant
    Bookmark = Recordset.Bookmark
End Property

Public Property Let Bookmark(ByVal newValue As Variant)
    Recordset.Bookmark = newValue
End Property

' If ReadOnlyMode property is True, the file is saved

Public Property Get ReadOnlyMode() As Boolean
    ReadOnlyMode = m_ReadOnlyMode
End Property

Public Property Let ReadOnlyMode(ByVal newValue As Boolean)
    m_ReadOnlyMode = newValue
End Property


' The EOFAction and BOFAction properties can't be delegated to the recordset.

Public Property Get EOFAction() As adsEOFActionEnum
    EOFAction = m_EOFAction
End Property

Public Property Let EOFAction(ByVal newValue As adsEOFActionEnum)
    m_EOFAction = newValue
End Property

Public Property Get BOFAction() As adsBOFAction
    BOFAction = m_BOFAction
End Property

Public Property Let BOFAction(ByVal newValue As adsBOFAction)
    m_BOFAction = newValue
End Property

' Public Methods

Sub MoveFirst()
    Recordset.MoveFirst
End Sub

Sub MovePrevious()
    ' Note that we don't need to use Recordset more than once.
    If Recordset.BOF Then
        Select Case BOFAction
            Case adsBOFActionMoveFirst
                rs.MoveFirst
            Case adsBOFActionBOF
                ' do nothing
        End Select
    Else
        rs.MovePrevious
    End If
End Sub

Sub MoveNext()
    ' Note that we don't need to use Recordset more than once.
    If Not Recordset.EOF Then rs.MoveNext
    
    If rs.EOF Then
        Select Case EOFAction
            Case adsEOFActionMoveLast
                rs.MoveLast
            Case adsEOFActionEOF
                ' do nothing
            Case adsEOFActionAddnew
                rs.AddNew
        End Select
    End If
End Sub

Sub MoveLast()
    Recordset.MoveLast
End Sub

Sub AddNew()
    Recordset.AddNew
End Sub

Sub Delete()
    Recordset.Delete
End Sub

Sub Refresh()
    LoadRecordset m_DataMember
End Sub

