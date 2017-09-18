' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' WARNING: see DB_PATH constant in DataEnvironment1 module
	'          to ensure that it points to the Biblio database
	
	' These variables keep track of the cell that was active
	' when edit mode was entered.
	Private cellRow As Integer
	Private cellCol As Integer
	
	Private Sub Form_Load() Handles MyBase.Load
		txtCellEditor.Visible = False
		txtCellEditor.Font = MSHFlexGrid1.Font
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		MSHFlexGrid1.Move(0, MSHFlexGrid1.Top, ScaleWidth, ScaleHeight - MSHFlexGrid1.Top)
	End Sub

	Private Sub MSHFlexGrid1_DblClick() Handles MSHFlexGrid1.DblClick
		ShowCellEditor()
	End Sub

	Public Sub ShowCellEditor()
		With MSHFlexGrid1
			' Cancel range selection, if any.
			.RowSel = .Row
			.ColSel = .Col
			' Move the cell editor in place, by maing it one pixel smaller
			' then the current cell.
			txtCellEditor.Move(.Left + .CellLeft, .Top + .CellTop, .CellWidth - ScaleX(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips), .CellHeight - ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips))
			' Transfer the contents of the current cell into the TextBox.
			txtCellEditor.Text = .Text
			' Move the textbox in front of the grid.
			txtCellEditor.Visible = True
			txtCellEditor.ZOrder()
			txtCellEditor.SetFocus()
			' Remember current coordinates for later.
			cellRow = .Row
			cellCol = .Col
		End With
	End Sub

	Public Sub HideCellEditor(Optional ByRef Cancel As Boolean = False)
	' UPGRADE_INFO (#0551): The 'Cancel' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' Hide the textbox if necessary.
		If txtCellEditor.Visible Then 
			' If the operation hasn't been canceled, transfer the contents
			' of the textbox into the original active cell.
			If Not Cancel Then 
				MSHFlexGrid1.TextMatrix(cellRow, cellCol) = txtCellEditor.Text
			End If
			txtCellEditor.Visible = False
		End If
	End Sub

	Private Sub MSHFlexGrid1_KeyPress(ByRef KeyAscii As Short) Handles MSHFlexGrid1.KeyPress6
		ShowCellEditor()
		If KeyAscii >= 32 Then 
			txtCellEditor.Text = Chr6(KeyAscii)
			txtCellEditor.SelStart = 1
		End If
	End Sub

	Private Sub txtCellEditor_KeyPress(ByRef KeyAscii As Short) Handles txtCellEditor.KeyPress
		Select Case KeyAscii
		Case 13
			HideCellEditor()
		Case 27
			HideCellEditor(True)
		End Select
	End Sub

	Private Sub txtCellEditor_LostFocus() Handles txtCellEditor.LostFocus
		HideCellEditor()
	End Sub

	Private Sub cmdCollapse_Click() Handles cmdCollapse.Click
		MSHFlexGrid1.CollapseAll()
	End Sub

	Private Sub cmdExpand_Click() Handles cmdExpand.Click
		MSHFlexGrid1.ExpandAll()
	End Sub

End Class
