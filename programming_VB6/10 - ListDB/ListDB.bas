Attribute VB_Name = "Module1"
Option Explicit

' Set this constant to zero to use pure VB code to resize column
' in the ListViewAdjustColumnWidth routine.
#Const USE_API = -1

#If USE_API Then
Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Const LVM_SETCOLUMNWIDTH = &H1000 + 30
Const LVSCW_AUTOSIZE = 65535
Const LVSCW_AUTOSIZE_USEHEADER = 65534
#End If

' load a recordset into a ListView control

Sub LoadListViewFromRecordset(LV As ListView, rs As ADODB.Recordset, _
    Optional MaxRecords As Long)
    Dim fld As ADODB.Field, alignment As Integer
    Dim recCount As Long, i As Long, fldName As String
    Dim li As ListItem
    
    ' clear the contents of the control
    LV.ListItems.Clear
    LV.ColumnHeaders.Clear
    ' create the ColumnHeader collections
    For Each fld In rs.Fields
        ' filter out undesired field types
        Select Case fld.Type
            Case adBoolean, adCurrency, adDate, adDecimal, adDouble
                alignment = lvwColumnRight
            Case adInteger, adNumeric, adSingle, adSmallInt, adVarNumeric
                alignment = lvwColumnRight
            Case adBSTR, adChar, adVarChar, adVariant
                alignment = lvwColumnLeft
            Case Else
                alignment = -1
        End Select
        ' if field type is OK, create a column with correct alignment
        If alignment <> -1 Then
            ' the first column must be left-aligned
            If LV.ColumnHeaders.Count = 0 Then alignment = lvwColumnLeft
            LV.ColumnHeaders.Add , , fld.Name, fld.DefinedSize * 200, _
                alignment
        End If
    Next
    'exit if there are no fields
    If LV.ColumnHeaders.Count = 0 Then Exit Sub
    
    ' add all the records in the recordset
    rs.MoveFirst
    Do Until rs.EOF
        recCount = recCount + 1
        ' add the main ListItem object
        fldName = LV.ColumnHeaders(1).Text
        Set li = LV.ListItems.Add(, , rs.Fields(fldName) & "")
        ' add all subsequent ListSubItem objects
        For i = 2 To LV.ColumnHeaders.Count
            fldName = LV.ColumnHeaders(i)
            li.ListSubItems.Add , , rs.Fields(fldName) & ""
        Next
        If recCount = MaxRecords Then Exit Do
        rs.MoveNext
    Loop
End Sub

' adject the width of a ListView control so that each item is fully visible
' if second argument is True, column headers' width is also considered

Sub ListViewAdjustColumnWidth(LV As ListView, Optional AccountForHeaders _
    As Boolean)

#If USE_API Then
    Dim col As Integer, lParam As Long
    
    If AccountForHeaders Then
        lParam = LVSCW_AUTOSIZE_USEHEADER
    Else
        lParam = LVSCW_AUTOSIZE
    End If
    
    For col = 1 To LV.ColumnHeaders.Count
        SendMessage LV.hwnd, LVM_SETCOLUMNWIDTH, col, lParam
    Next
        
#Else
    Dim row As Long, col As Long
    Dim width As Single, maxWidth As Single
    Dim saveFont As StdFont, saveScaleMode As Integer
    Dim cellText As String
    
    ' exit if there aren't any items
    If LV.ListItems.Count = 0 Then Exit Sub
    
    ' save the font used by the parent form, and enforce ListView's font
    ' we need this in order to use the form's TextWidth method
    Set saveFont = LV.Parent.Font
    Set LV.Parent.Font = LV.Font
    ' enforce ScaleMode = vbTwips for the parent
    saveScaleMode = LV.Parent.ScaleMode
    LV.Parent.ScaleMode = vbTwips
    
    For col = 1 To LV.ColumnHeaders.Count
        maxWidth = 0
        If AccountForHeaders Then
            maxWidth = LV.Parent.TextWidth(LV.ColumnHeaders(col).Text) + 200
        End If
        For row = 1 To LV.ListItems.Count
            ' retrieve the text string (from ListItems or ListSubItems)
            If col = 1 Then
                cellText = LV.ListItems(row).Text
            Else
                cellText = LV.ListItems(row).ListSubItems(col - 1).Text
            End If
            ' calculate its width, account for margins
            ' note: doesn't account for multiple-line text fields
            width = LV.Parent.TextWidth(cellText) + 200
            ' update maxWidth if we've found a larger string
            If width > maxWidth Then maxWidth = width
        Next
        ' change the column's width
        LV.ColumnHeaders(col).width = maxWidth
    Next
    
    ' restore parent form's properties
    Set LV.Parent.Font = saveFont
    LV.Parent.ScaleMode = saveScaleMode
#End If

End Sub

' sort all the items of a ListView control on a numeric/date field

Sub ListViewSortOnNonStringField(LV As ListView, ByVal ColumnIndex As Integer, Optional SortOrder As ListSortOrderConstants, Optional IsDateValue As Boolean)

    Dim li As ListItem, number As Double, newIndex As Integer
    Dim minValue As Double
    
    ' this speeds up things
    LV.Visible = False
    LV.Sorted = False
    
    ' create a new, hidden field
    LV.ColumnHeaders.Add , , "dummy column", 1000
    newIndex = LV.ColumnHeaders.Count - 1
        
    For Each li In LV.ListItems
        ' extract a number out of the field
        If IsDateValue Then
            number = DateValue(li.ListSubItems(ColumnIndex - 1))
        Else
            number = CDbl(li.ListSubItems(ColumnIndex - 1))
        End If
        If number < minValue Then minValue = number
        ' add a string that can be sorted using Sorted property
        li.ListSubItems.Add , , Format$(number, "000000000000000.000")
    Next
    
    ' if there was a negative number, we must account for it by adding an offset
    If minValue < 0 Then
        For Each li In LV.ListItems
            ' the added factor serves to account for negative values
            number = CDbl(li.ListSubItems(newIndex)) - minValue
            li.ListSubItems(newIndex).Text = Format$(number, "000000000000000.000")
        Next
    End If
    
    ' sort on this hidden field
    LV.SortKey = newIndex
    LV.SortOrder = SortOrder
    LV.Sorted = True
    
    ' remove data from the hidden column
    LV.ColumnHeaders.Remove newIndex + 1
    For Each li In LV.ListItems
        li.ListSubItems.Remove newIndex
    Next

    LV.Visible = True
End Sub


