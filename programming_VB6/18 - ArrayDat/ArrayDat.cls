VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 1  'vbDataSource
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ArrayDataSource"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

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

' Member variable for EOFAction and BOFAction properties
Private m_EOFAction As adsEOFActionEnum
Private m_BOFAction As adsBOFAction


' Initialize the array of data.

Sub SetArray(Values As Variant, Fields As Variant)
    Dim row As Long, col As Long
    
    ' Build the ADO recordset.
    If Not (rs Is Nothing) Then
        If rs.Status = adStateOpen Then rs.Close
    End If
    Set rs = New ADODB.Recordset
    
    ' Create the Fields collection.
    For col = LBound(Fields) To UBound(Fields)
        rs.Fields.Append Fields(col), adBSTR
    Next
    
    ' Add the values.
    rs.Open
    For row = LBound(Values) To UBound(Values)
        rs.AddNew
        For col = 0 To UBound(Values, 2)
            rs(col) = Values(row, col)
        Next
    Next
    rs.MoveFirst
    
    ' Inform consumers that the Data has changed
    DataMemberChanged ""
End Sub

' Retrieve the array of data as an array of Variant or String.

Function GetArray(Optional ReturnAsString As Boolean) As Variant
    Dim numFields As Long, row As Long, col As Long
    Dim Bookmark As Variant
    Dim result As Variant
        
    ' Remember the current record pointer, raise error if no recordset.
    Bookmark = Recordset.Bookmark
    
    ' Create the result array (String or Variant) and
    ' assign to the result
    numFields = rs.Fields.Count
    If ReturnAsString Then
        ReDim ValuesStr(0 To rs.RecordCount - 1, 0 To numFields - 1) As String
        result = ValuesStr
    Else
        ReDim ValuesVar(0 To rs.RecordCount - 1, 0 To numFields - 1) As Variant
        result = ValuesVar
    End If
    
    ' Fill the array with data from the recordset.
    rs.MoveFirst
    For row = 0 To rs.RecordCount - 1
        For col = 0 To numFields - 1
            result(row, col) = rs(col)
        Next
        rs.MoveNext
    Next
    GetArray = result
    
    ' restore record pointer
    rs.Bookmark = Bookmark
End Function

' Return the recordset when the consumer ask for it.

Private Sub Class_GetDataMember(DataMember As String, Data As Object)
    ' Return the recordset to the data consumer.
    Set Data = Recordset
End Sub

' "Safe" access to the recordset, raises a meaningful error if Nothing.

Property Get Recordset() As ADODB.Recordset
    If rs Is Nothing Then
        Err.Raise 1001, , "No data array has been provided"
    Else
        Set Recordset = rs
    End If
End Property

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
    ' No need to use Recordset more than once.
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
    ' No real need to use Recordset more than once.
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
    With Recordset
        .Delete
        .MoveNext
        If .EOF And Not .BOF Then
            ' The next statement is necessary because the BOF condition
            ' isn't correctly updated if the record was the only one
            ' in the recordset
            On Error Resume Next
            .MoveLast
        End If
    End With
End Sub


