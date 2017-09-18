VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "TextOSP"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Implements OLEDBSimpleProvider

Const DELIMITER = ";"
Const E_FAIL = &H80004005

Dim DataArray() As Variant   ' An array of array
Dim RowCount As Long         ' Number of rows (records)
Dim ColCount As Long         ' Number or columns (fields)
Dim IsDirty As Boolean       ' True if data has changed
Dim m_FileName As String     ' The path of the data file

Dim Listeners As New Collection
Dim Listener As OLEDBSimpleProviderListener


'--------------------------------------------
' Provider-specific routines
'--------------------------------------------

Sub LoadData(FileName As String)
    Dim fnum As Integer, FileText As String
    Dim records() As String, fields() As String
    Dim row As Long, col As Long
    
    ' Read the file in memory
    m_FileName = FileName
    fnum = FreeFile
    On Error GoTo ErrorHandler
    Open m_FileName For Input Lock Read Write As #fnum
    FileText = Input(LOF(fnum), #fnum)
    Close #fnum
    
    ' Split the file in records and fields.
    records = Split(FileText, vbCrLf)
    RowCount = UBound(records)
    ColCount = -1
    ReDim DataArray(0 To RowCount) As Variant
    
    For row = 0 To RowCount
        fields = Split(records(row), DELIMITER)
        DataArray(row) = fields
    Next
    ' The first record sets ColCount.
    ColCount = UBound(DataArray(0)) + 1
    Exit Sub
    
ErrorHandler:
    Err.Raise E_FAIL

End Sub

Sub SaveData()
    Dim fnum As Integer, FileText As String
    Dim records() As String, fields() As String
    Dim row As Long, col As Long
    
    For row = 0 To UBound(DataArray)
        FileText = FileText & Join(DataArray(row), DELIMITER) & vbCrLf
    Next
    ' Drop the last CR-LF.
    FileText = Left$(FileText, Len(FileText) - 2)
    
    ' Write the file
    fnum = FreeFile
    On Error GoTo ErrorHandler
    Open m_FileName For Output Lock Read Write As #fnum
    Print #fnum, FileText;
    Close #fnum
    IsDirty = False
    
    Exit Sub
    
ErrorHandler:
    Err.Raise E_FAIL
End Sub

' Flush to database when the provider terminates.
Private Sub Class_Terminate()
    On Error Resume Next
    If IsDirty Then SaveData
End Sub

'--------------------------------------------
' The OLEDBSimpleProvider interface
'--------------------------------------------

' Return the exact number of rows.
Private Function OLEDBSimpleProvider_getRowCount() As Long
    OLEDBSimpleProvider_getRowCount = RowCount
End Function

' Return the number of columns.
Private Function OLEDBSimpleProvider_getColumnCount() As Long
    OLEDBSimpleProvider_getColumnCount = ColCount
End Function

' Return the estimated number of rows, or -1 if unknown.
' This method is used in asynchronous data transfer.
Private Function OLEDBSimpleProvider_getEstimatedRows() As Long
    OLEDBSimpleProvider_getEstimatedRows = RowCount
End Function

' REturns a string that determined the system international settings,
' or an empty string if the provider doesn't support different locales.
Private Function OLEDBSimpleProvider_getLocale() As String
    OLEDBSimpleProvider_getLocale = ""
End Function

' Returns a non-zero value if the rowset is populated asynchronously.
Private Function OLEDBSimpleProvider_isAsync() As Long
    OLEDBSimpleProvider_isAsync = False
End Function

' Stop asynchronous transfer.
Private Sub OLEDBSimpleProvider_stopTransfer()
    ' Do nothing in this provider.
End Sub

' Add a Listener to the Listeners collection.
Private Sub OLEDBSimpleProvider_addOLEDBSimpleProviderListener(ByVal pospIListener As MSDAOSP.OLEDBSimpleProviderListener)
    If Not (pospIListener Is Nothing) Then
        Listeners.Add pospIListener
    End If
End Sub

' Remove a Listener from the Listeners collection.
Private Sub OLEDBSimpleProvider_removeOLEDBSimpleProviderListener(ByVal pospIListener As MSDAOSP.OLEDBSimpleProviderListener)
    Dim i As Long
    For i = 1 To Listeners.Count
        If Listeners(i) Is pospIListener Then
            Listeners.Remove i
            Exit For
        End If
    Next
End Sub

' Return the Read/Write status of a value.
' If iRow = -1, it returns the status of a column.
' If iColumn = -1, it returns the status of a row.
Private Function OLEDBSimpleProvider_getRWStatus(ByVal iRow As Long, ByVal iColumn As Long) As MSDAOSP.OSPRW
    ' Make all fields read/write.
    OLEDBSimpleProvider_getRWStatus = OSPRW_MIXED
End Function

' Read a value at given row/col coordinates.
Private Function OLEDBSimpleProvider_getVariant(ByVal iRow As Long, ByVal iColumn As Long, ByVal format As MSDAOSP.OSPFORMAT) As Variant
    ' Ignores the format argument.
    OLEDBSimpleProvider_getVariant = DataArray(iRow)(iColumn - 1)
End Function

' Write a value at given row/col coordinates.
Private Sub OLEDBSimpleProvider_setVariant(ByVal iRow As Long, ByVal iColumn As Long, ByVal format As MSDAOSP.OSPFORMAT, ByVal Var As Variant)
    ' Ignores the format argument.
    On Error Resume Next
    ' Pre-notification
    For Each Listener In Listeners
        Listener.aboutToChangeCell iRow, iColumn
    Next
    DataArray(iRow)(iColumn - 1) = Var
    ' Post-notification
    For Each Listener In Listeners
        Listener.cellChanged iRow, iColumn
    Next
    IsDirty = True
End Sub

' Insert one or more rows.
Private Function OLEDBSimpleProvider_insertRows(ByVal iRow As Long, ByVal cRows As Long) As Long
    Dim row As Long
    
    ' Validate iRows
    If iRow < 1 Or iRow > RowCount + 1 Then Err.Raise E_FAIL
    
    On Error Resume Next
    ReDim emptyArray(0 To ColCount - 1) As String
    ReDim Preserve DataArray(RowCount + cRows) As Variant
    
    ' Pre-notification
    For Each Listener In Listeners
        Listener.aboutToInsertRows iRow, cRows
    Next
    ' Make room in the array.
    If iRow <= RowCount Then
        For row = RowCount To iRow Step -1
            DataArray(row + cRows) = DataArray(row)
            DataArray(row) = emptyArray
        Next
    Else
        For row = RowCount + 1 To RowCount + cRows
            DataArray(row) = emptyArray
        Next
    End If
    RowCount = RowCount + cRows
    ' Post-notification
    For Each Listener In Listeners
        Listener.insertedRows iRow, cRows
    Next
    ' Return the number of inserted rows.
    OLEDBSimpleProvider_insertRows = cRows
    IsDirty = True
End Function

' Delete one or more rows.
Private Function OLEDBSimpleProvider_deleteRows(ByVal iRow As Long, ByVal cRows As Long) As Long
    Dim row As Long
    
    ' Validate iRows
    If iRow < 1 Or iRow > RowCount Then Err.Raise E_FAIL
    ' Set cRows to the actual number which can be deleted.
    If iRow + cRows > RowCount + 1 Then cRows = RowCount - iRow + 1
    
    On Error Resume Next

    ' Pre-notification.
    For Each Listener In Listeners
        Listener.aboutToDeleteRows iRow, cRows
    Next
    ' Shrink the array.
    For row = iRow To RowCount - cRows
        DataArray(row) = DataArray(row + cRows)
    Next
    RowCount = RowCount - cRows
    ReDim Preserve DataArray(RowCount) As Variant
    ' Post-notification
    For Each Listener In Listeners
        Listener.deletedRows iRow, cRows
    Next
    ' Return number of deleted rows
    OLEDBSimpleProvider_deleteRows = cRows
    IsDirty = True
End Function

Private Function OLEDBSimpleProvider_find(ByVal iRowStart As Long, ByVal iColumn As Long, ByVal val As Variant, ByVal findFlags As MSDAOSP.OSPFIND, ByVal compType As MSDAOSP.OSPCOMP) As Long
    Dim RowStop As Long, RowStep As Long
    Dim CaseSens As Long, StringComp As Boolean
    Dim result As Long, compResult As Integer, row As Long
    
    ' Determine end row and step value for the loop.
    If findFlags And OSPFIND_UP Then
        RowStop = 1: RowStep = -1
    Else
        RowStop = RowCount: RowStep = 1
    End If
    ' Determine the case sensitive flag.
    If findFlags And OSPFIND_CASESENSITIVE Then
        CaseSens = vbTextCompare
    Else
        CaseSens = vbBinaryCompare
    End If
    ' True if we're dealing with strings.
    StringComp = (VarType(val) = vbString)
    ' -1 means not found.
    result = -1
    ' iColumn is 1-based, but internal data is 0-based.
    iColumn = iColumn - 1
    
    For row = iRowStart To RowStop Step RowStep
        If StringComp Then
            ' We're comparing strings.
            compResult = StrComp(DataArray(row)(iColumn), val, CaseSens)
        Else
            ' We're comparing numbers or dates.
            compResult = Sgn(DataArray(row)(iColumn) - val)
        End If
        Select Case compType
            Case OSPCOMP_DEFAULT, OSPCOMP_EQ
                If compResult = 0 Then result = row
            Case OSPCOMP_GE
                If compResult >= 0 Then result = row
            Case OSPCOMP_GT
                If compResult > 0 Then result = row
            Case OSPCOMP_LE
                If compResult <= 0 Then result = row
            Case OSPCOMP_LT
                If compResult < 0 Then result = row
            Case OSPCOMP_NE
                If compResult <> 0 Then result = row
        End Select
        If result <> -1 Then Exit For
    Next
    
    ' Return the row found, or -1.
    OLEDBSimpleProvider_find = result
    
End Function


