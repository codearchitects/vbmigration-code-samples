VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CSparseMatrix"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------------------------------
' CSparseMatrix class - (C) Francesco Balena
'-------------------------------------------------------

Option Explicit

Private m_Value As New Collection

Property Get Value(row As Long, col As Long) As Single
Attribute Value.VB_UserMemId = 0
    ' returns an item, or zero if it doesn't exist
    On Error Resume Next
    Value = m_Value(GetKey(row, col))
End Property

Property Let Value(row As Long, col As Long, newValue As Single)
    Dim key As String
    key = GetKey(row, col)
    ' first, destroy the value if in the collection
    On Error Resume Next
    m_Value.Remove key
    ' then add the new value, but only if not zero
    If newValue <> 0 Then m_Value.Add newValue, key
End Property

' form the key

Private Function GetKey(row As Long, col As Long) As String
    GetKey = row & vbCr & col
End Function



