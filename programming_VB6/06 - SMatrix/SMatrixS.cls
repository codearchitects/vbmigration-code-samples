VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CSparseMatrixSym"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------------------------------
' CSparseMatrixSym class - (C) Francesco Balena
'
' variant of CSparseMatrix class that uses Variant indices
' and return value, and is also symmetrical
'  (in other words:  m(i,j) = m(j,i)
'-------------------------------------------------------

Option Explicit

' this is the default value used for items not in the collection
Public DefaultValue As Variant

Private m_Value As New Collection

Property Get Value(row As Variant, col As Variant) As Variant
Attribute Value.VB_UserMemId = 0
    ' returns an item, or Empty if it doesn't exist
    On Error Resume Next
    Value = DefaultValue
    ' if the next line fails, the default value is returned instead
    Value = m_Value(GetKey(row, col))
End Property

Property Let Value(row As Variant, col As Variant, newValue As Variant)
    Dim key As String
    key = GetKey(row, col)
    ' first, destroy the value if in the collection
    On Error Resume Next
    m_Value.Remove key
    ' then add the new value, but only if not zero
    If newValue <> DefaultValue Then m_Value.Add newValue, key
End Property

' form the key

Private Function GetKey(row As Variant, col As Variant) As String
    ' always start with the lesser of the two
    ' a case insensitive comparison is needed, because collections
    ' search their keys in this way
    If StrComp(row, col, vbTextCompare) < 0 Then
        ' using a non-printable delimiter is preferable
        GetKey = row & vbCr & col
    Else
        GetKey = col & vbCr & row
    End If
End Function


