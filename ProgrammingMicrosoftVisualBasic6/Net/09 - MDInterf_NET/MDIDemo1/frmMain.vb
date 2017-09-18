' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub MDIForm_Load() Handles MyBase.Load
		Call mnuFileNew_Click()
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

	Private Sub mnuFileClose_Click() Handles mnuFileClose.Click
		Unload6(ActiveForm)
	End Sub

	Private Sub mnuHelpAbout_Click() Handles mnuHelpAbout.Click
		frmAbout.Show(VBRUN.FormShowConstants.vbModal, Me)
	End Sub

	Private Sub tbToolBar_ButtonClick(ByVal Button As VB6Button) Handles tbToolBar.ButtonClick
		Select Case Button.Key
		Case "New"
			mnuFileNew_Click()
		Case "Open"
			mnuFileOpen_Click()
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

	Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
		If ChildFormType() <= 0 Then 
			' create a new document if no one is current
			Call mnuFileNew_Click()
		ElseIf Not ActiveForm.IsEmpty Then 
			' same if the current document is not empty
			Call mnuFileNew_Click()
		End If
		' ask the document to show a common dialog
		' then load the file selected by the user
		ActiveForm.LoadFile(ActiveForm.AskFilename(False))
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

	Public Function ChildFormType() As Short
		' return 0 if there is no current child form
		' 1 if the current child is of type frmDocument
		' -1 if the current child is of unknown type
		If ActiveForm Is Nothing Then 
			Return 0
		ElseIf TypeOf ActiveForm Is frmDocument Then 
			Return 1
		Else
			Return -1
		End If
	End Function

	Private Sub mnuFileNew_Click() Handles mnuFileNew.Click
		Dim frm As New frmDocument
		frm.Show()
	End Sub

End Class
