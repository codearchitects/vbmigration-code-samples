' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub mnuFile_Click() Handles mnuFile.Click
		' enable/disable individual menu items
		Dim ok As Boolean
		If ChildFormType() > 0 Then  ok = True
		
		mnuFileClose.Enabled = ok
		mnuFileSave.Enabled = ok
		mnuFileSaveAs.Enabled = ok
		mnuFilePrint.Enabled = ok
		If ok Then 
			If ActiveForm.CanSave = False Then  mnuFileSave.Enabled = False
			If ActiveForm.CanPrint = False Then  mnuFilePrint.Enabled = False
		End If
		
	End Sub

	Private Sub mnuFileNewItem_Click(ByRef Index As Short)
		Dim frm As Object = Nothing
		Select Case Index
		Case 0
			frm = New frmDocument()
		Case 1
			frm = New frmDocument2()
		End Select
		frm.Show
	End Sub

	Private Sub mnuFileOpenItem_Click(ByRef Index As Short)
		
		' we must decide which version of the Open command should
		' be made available, with or without the submenu
		Dim showSubMenu As Boolean
		If ChildFormType() <= 0 Then 
			' there is no current form, delegate to New submenu
			mnuFileNewItem_Click(Index)
		ElseIf ChildFormType() <> (Index + 1) Or Not ActiveForm.IsEmpty Then 
			' ditto if the current document is not empty
			' or isn't of the right type
			mnuFileNewItem_Click(Index)
		End If
		
		' ask the current form to load a new document
		ActiveForm.LoadFile(ActiveForm.AskFilename(False))
		
	End Sub

	Private Sub mnuFileClose_Click() Handles mnuFileClose.Click
		Unload6(ActiveForm)
	End Sub

	Private Sub mnuFileSave_Click() Handles mnuFileSave.Click
		On Error Resume Next 
		If ActiveForm.Filename = "" Then 
			Call mnuFileSaveAs_Click()
		Else
			ActiveForm.SaveFile(ActiveForm.Filename)
		End If
	End Sub

	Private Sub mnuFileSaveAs_Click() Handles mnuFileSaveAs.Click
		' ask the document to show a common dialog
		' then save the file with the name selected by the user
		On Error Resume Next 
		ActiveForm.SaveFile(ActiveForm.AskFilename(True))
	End Sub

	Private Sub mnuFilePrintSetup_Click() Handles mnuFilePrintSetup.Click
		dlgCommonDialog.ShowPrinter()
	End Sub

	Private Sub mnuFilePrint_Click() Handles mnuFilePrint.Click
		On Error Resume Next 
		ActiveForm.PrintDoc
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		Unload6(Me)
	End Sub

	Private Sub mnuEdit_Click() Handles mnuEdit.Click
		' enable/disable individual menu items
		Dim ok As Boolean
		If ChildFormType() > 0 Then  ok = True
		
		' ask the current document if it can copy, cut and paste
		mnuEditCopy.Enabled = ok
		mnuEditCut.Enabled = ok
		mnuEditPaste.Enabled = ok
		If ok Then 
			If ActiveForm.CanCopy = False Then  mnuEditCopy.Enabled = False
			If ActiveForm.CanCut = False Then  mnuEditCut.Enabled = False
			If ActiveForm.CanPaste = False Then  mnuEditPaste.Enabled = False
		End If
	End Sub

	Private Sub mnuEditCopy_Click() Handles mnuEditCopy.Click
		On Error Resume Next 
		ActiveForm.Copy
	End Sub

	Private Sub mnuEditCut_Click() Handles mnuEditCut.Click
		On Error Resume Next 
		ActiveForm.Cut
	End Sub

	Private Sub mnuEditPaste_Click() Handles mnuEditPaste.Click
		On Error Resume Next 
		ActiveForm.Paste
	End Sub

	Private Sub mnuWindowArrangeIcons_Click() Handles mnuWindowArrangeIcons.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbArrangeIcons)
	End Sub

	Private Sub mnuWindowCascade_Click() Handles mnuWindowCascade.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbCascade)
	End Sub

	Private Sub mnuWindowTileHorizontal_Click() Handles mnuWindowTileHorizontal.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileHorizontal)
	End Sub

	Private Sub mnuWindowTileVertical_Click() Handles mnuWindowTileVertical.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileVertical)
	End Sub

	Private Sub mnuHelpAbout_Click() Handles mnuHelpAbout.Click
		frmAbout.Show(VBRUN.FormShowConstants.vbModal, Me)
	End Sub

	Private Sub tbToolBar_ButtonClick(ByVal Button As VB6Button) Handles tbToolBar.ButtonClick
		Select Case Button.Key
		Case "New"
			PopupMenu(mnuFileNew)
		Case "Open"
			PopupMenu(mnuFileOpen)
		Case "Save"
			mnuFileSave_Click()
		Case "Print"
			mnuFilePrint_Click()
		Case "Cut"
			mnuEditCut_Click()
		Case "Copy"
			mnuEditCopy_Click()
		Case "Paste"
			mnuEditPaste_Click()
		End Select
	End Sub

	Public Function ChildFormType() As Short
		' return 0 if there is no current child form
		' 1 if the current child is of type frmDocument
		' 2 if the current child is of type frmDocument2
		' -1 if the current child is of unknown type
		If ActiveForm Is Nothing Then 
			Return 0
		ElseIf TypeOf ActiveForm Is frmDocument Then 
			Return 1
		ElseIf TypeOf ActiveForm Is frmDocument2 Then 
			Return 2
		Else
			Return -1
		End If
	End Function

End Class
