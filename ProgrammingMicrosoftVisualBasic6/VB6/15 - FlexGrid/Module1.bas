Attribute VB_Name = "Module1"
Option Explicit

Function MSHFlexGrid_Clip(FlexGrid As MSHFlexGrid) As String
    Dim r As Long, c As Long, result As String
    Dim rowMin As Long, rowMax As Long
    Dim colMin As Long, colMax As Long
    
    If FlexGrid.Row < FlexGrid.RowSel Then
        rowMin = FlexGrid.Row
        rowMax = FlexGrid.RowSel
    Else
        rowMin = FlexGrid.RowSel
        rowMax = FlexGrid.Row
    End If
    If FlexGrid.Col < FlexGrid.ColSel Then
        colMin = FlexGrid.Col
        colMax = FlexGrid.ColSel
    Else
        colMin = FlexGrid.ColSel
        colMax = FlexGrid.Col
    End If
    
    For r = rowMin To rowMax
        For c = colMin To colMax
            result = result & FlexGrid.TextMatrix(r, c)
            If c <> colMax Then result = result & vbTab
        Next
        result = result & vbCr
    Next
        
    MSHFlexGrid_Clip = result
End Function


