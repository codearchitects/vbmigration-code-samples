' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' size of scrollbars in twips
	Private Const SB_WIDTH As Short = 300
	' width of vertical scrollbars
	Private Const SB_HEIGHT As Short = 300
	' height of horizontal scrollbars
	
	'--------------------------------------------
	' code for handling form resizing and scrolling
	'--------------------------------------------
	
	Private Sub Form_Resize() Handles MyBase.Resize
		' resize the scrollbars along the form
		HScroll1.Move(0, ScaleHeight - SB_HEIGHT, ScaleWidth - SB_WIDTH)
		VScroll1.Move(ScaleWidth - SB_WIDTH, 0, SB_WIDTH, ScaleHeight - SB_HEIGHT)
		cmdFiller.Move(ScaleWidth - SB_WIDTH, ScaleHeight - SB_HEIGHT, SB_WIDTH, SB_HEIGHT)
		' put these controls on top
		HScroll1.ZOrder()
		VScroll1.ZOrder()
		cmdFiller.ZOrder()
		picCanvas.BorderStyle = 0
		' a click on the arrow moves one pixel
		HScroll1.SmallChange = ScaleX(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		VScroll1.SmallChange = ScaleY(1, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		'a click on the scrollbar move 16 pixels
		HScroll1.LargeChange = HScroll1.SmallChange * 16
		VScroll1.LargeChange = VScroll1.SmallChange * 16
		
		' if the form is larger than the picCanvas picture box
		' we don't need to show the scrollbar
		
		If ScaleWidth < picCanvas.Width + SB_WIDTH Then 
			HScroll1.Visible = True
			HScroll1.Max = picCanvas.Width + SB_WIDTH - ScaleWidth
		Else
			HScroll1.Value = 0
			HScroll1.Visible = False
		End If
		If ScaleHeight < picCanvas.Height + SB_HEIGHT Then 
			VScroll1.Visible = True
			VScroll1.Max = picCanvas.Height + SB_HEIGHT - ScaleHeight
		Else
			VScroll1.Value = 0
			VScroll1.Visible = False
		End If
		cmdFiller.Visible = (HScroll1.Visible Or VScroll1.Visible)
		
		MoveCanvas()
	End Sub

	Private Sub cmdFiller_Click() Handles cmdFiller.Click
		' resize the form so that scrollbars aren't visible
		Move(Left, Top, picCanvas.Width + SB_WIDTH + 500, picCanvas.Height + SB_HEIGHT + 500)
	End Sub

	Private Sub HScroll1_Change() Handles HScroll1.Change
		MoveCanvas()
	End Sub

	Private Sub HScroll1_Scroll() Handles HScroll1.Scroll
		MoveCanvas()
	End Sub

	Private Sub VScroll1_Change() Handles VScroll1.Change
		MoveCanvas()
	End Sub

	Private Sub VScroll1_Scroll() Handles VScroll1.Scroll
		MoveCanvas()
	End Sub

	Public Sub MoveCanvas()
		picCanvas.Move(-HScroll1.Value, -VScroll1.Value)
	End Sub

	'--------------------------------------------
	' code for handling bound fields
	'--------------------------------------------
	
	Private Sub cmdAdd_Click() Handles cmdAdd.Click
		datPrimaryRS.Recordset.AddNew(): datPrimaryRS.RaiseRepositionEvent()
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		With datPrimaryRS.Recordset
			If .RecordCount = 0 Then  Exit Sub
			.Delete()
			.MoveNext()
			If .RecordCount > 0 And .EOF Then 
				.MoveLast()
			End If
		End With
	End Sub

	Private Sub cmdRefresh_Click() Handles cmdRefresh.Click
		'This is only needed for multi user apps
		datPrimaryRS.Refresh()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub

	Private Sub cmdUpdate_Click() Handles cmdUpdate.Click
		With datPrimaryRS.Recordset
			If .RecordCount = 0 Or .EditMode = 0 Then  Exit Sub
			datPrimaryRS.UpdateRecord()
			.Bookmark = .LastModified.Clone()
		End With
	End Sub

	Private Sub cmdClose_Click() Handles cmdClose.Click
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		Unload6(Me)
	End Sub

	Private Sub datPrimaryRS_Error(ByRef DataErr As Short, ByRef Response As Short) Handles datPrimaryRS.Error
		'This is where you would put error handling code
		'If you want to ignore errors, comment out the next line
		'If you want to trap them, add code here to handle them
		MsgBox6("Data error event hit err:" & ErrorToString(DataErr))
		Response = 0 'Throw away the error
	End Sub

	Private Sub datPrimaryRS_Reposition() Handles datPrimaryRS.Reposition
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		On Error Resume Next 
		'This will display the current record position for dynasets and snapshots
		datPrimaryRS.Caption = "Record: " & (datPrimaryRS.Recordset.AbsolutePosition + 1)
	End Sub

	Private Sub datPrimaryRS_Validate(ByRef Action As Short, ByRef Save As Short) Handles datPrimaryRS.Validate
		'This is where you put validation code
		'This event gets called when the following actions occur
		Select Case Action
		Case VBRUN.DataValidateConstants.vbDataActionMoveFirst
		Case VBRUN.DataValidateConstants.vbDataActionMovePrevious
		Case VBRUN.DataValidateConstants.vbDataActionMoveNext
		Case VBRUN.DataValidateConstants.vbDataActionMoveLast
		Case VBRUN.DataValidateConstants.vbDataActionAddNew
		Case VBRUN.DataValidateConstants.vbDataActionUpdate
		Case VBRUN.DataValidateConstants.vbDataActionDelete
		Case VBRUN.DataValidateConstants.vbDataActionFind
		Case VBRUN.DataValidateConstants.vbDataActionBookmark
		Case VBRUN.DataValidateConstants.vbDataActionClose
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		End Select
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		datPrimaryRS.Refresh()
		If datPrimaryRS.Recordset.RecordCount = 0 Then  datPrimaryRS.Recordset.AddNew(): datPrimaryRS.RaiseRepositionEvent()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub

End Class
