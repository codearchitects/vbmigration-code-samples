' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	Public Function MSHFlexGrid_Clip(ByRef FlexGrid As CodeArchitects.VB6LibraryOcx.VB6MSHFlexGrid) As String
	' UPGRADE_INFO (#0501): The 'MSHFlexGrid_Clip' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'FlexGrid' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim r As Integer
		Dim c As Integer
		Dim result As String = ""
		Dim rowMin As Integer
		Dim rowMax As Integer
		Dim colMin As Integer
		Dim colMax As Integer
		
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
				result &= FlexGrid.TextMatrix(r, c)
				If c <> colMax Then  result &= ControlChars.Tab
			Next
			result &= ControlChars.Cr
		Next
		
		Return result
	End Function

End Module
