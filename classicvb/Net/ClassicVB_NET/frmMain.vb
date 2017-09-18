' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmMain

	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Any) As Long
	Private Const EM_UNDO As Short = &HC7S
	' IGNORED: Private Declare Function OSWinHelp% Lib "user32" Alias "WinHelpA" (ByVal hwnd&, ByVal HelpFile$, ByVal wCommand%, dwData As Any)
	Private Declare Function OSWinHelp Lib "user32" Alias "WinHelpA" (ByVal hwnd As Integer, ByVal HelpFile As String, ByVal wCommand As Short, ByRef dwData As Integer) As Short
	
	Private Sub MDIForm_Load() Handles MyBase.Load
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		Me.Left = GetSetting(App6.Title, "Settings", "MainLeft", 1000)
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		Me.Top = GetSetting(App6.Title, "Settings", "MainTop", 1000)
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		Me.Width = GetSetting(App6.Title, "Settings", "MainWidth", 6500)
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		Me.Height = GetSetting(App6.Title, "Settings", "MainHeight", 6500)
		LoadNewDoc()
	End Sub

	Private Sub LoadNewDoc()
		Static lDocumentCount As Integer
		Dim frmD As frmDocument = Nothing
		lDocumentCount += 1
		frmD = New frmDocument()
		frmD.Caption = "Module " & lDocumentCount
		frmD.Show()
	End Sub

	Private Sub MDIForm_Resize() Handles MyBase.Resize
		'Stop
	End Sub

	Private Sub MDIForm_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If Me.WindowState <> VBRUN.FormWindowStateConstants.vbMinimized Then 
			' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
			SaveSetting(App6.Title, "Settings", "MainLeft", Me.Left)
			' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
			SaveSetting(App6.Title, "Settings", "MainTop", Me.Top)
			' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
			SaveSetting(App6.Title, "Settings", "MainWidth", Me.Width)
			' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
			SaveSetting(App6.Title, "Settings", "MainHeight", Me.Height)
		End If
	End Sub

	Private Sub tbToolBar_ButtonClick(ByVal Button As VB6Button) Handles tbToolBar.ButtonClick
		On Error Resume Next 
		Select Case Button.Key
		Case "New"
			LoadNewDoc()
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
		Case "Bold"
			ActiveForm.rtfText.SelBold = Not ActiveForm.rtfText.SelBold
			Button.Value = IIf(ActiveForm.rtfText.SelBold, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Italic"
			ActiveForm.rtfText.SelItalic = Not ActiveForm.rtfText.SelItalic
			Button.Value = IIf(ActiveForm.rtfText.SelItalic, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Underline"
			ActiveForm.rtfText.SelUnderline = Not ActiveForm.rtfText.SelUnderline
			Button.Value = IIf(ActiveForm.rtfText.SelUnderline, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Align Left"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfLeft
		Case "Center"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfCenter
		Case "Align Right"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfRight
		End Select
	End Sub

	Private Sub mnuHelpAbout_Click() Handles mnuHelpAbout.Click
		frmAbout.Show(VBRUN.FormShowConstants.vbModal, Me)
	End Sub

	Private Sub mnuHelpSearchForHelpOn_Click() Handles mnuHelpSearchForHelpOn.Click
		Dim nRet As Short

		'if there is no helpfile for this project display a message to the user
		'you can set the HelpFile for your application in the
		'Project Properties dialog
		If Len6(App6.HelpFile) = 0 Then 
			MsgBox6("Unable to display Help Contents. There is no Help associated with this project.", MsgBoxStyle.Information, Me.Caption)
		Else
			On Error Resume Next 
			nRet = OSWinHelp(Me.hWnd, App6.HelpFile, 261, 0)
			If Err.Number Then 
				MsgBox6(Err.Description)
			End If
		End If
		
	End Sub

	Private Sub mnuHelpContents_Click() Handles mnuHelpContents.Click
		Dim nRet As Short

		'if there is no helpfile for this project display a message to the user
		'you can set the HelpFile for your application in the
		'Project Properties dialog
		If Len6(App6.HelpFile) = 0 Then 
			MsgBox6("Unable to display Help Contents. There is no Help associated with this project.", MsgBoxStyle.Information, Me.Caption)
		Else
			On Error Resume Next 
			nRet = OSWinHelp(Me.hWnd, App6.HelpFile, 3, 0)
			If Err.Number Then 
				MsgBox6(Err.Description)
			End If
		End If
		
	End Sub

	Private Sub mnuWindowArrangeIcons_Click() Handles mnuWindowArrangeIcons.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbArrangeIcons)
	End Sub

	Private Sub mnuWindowTileVertical_Click() Handles mnuWindowTileVertical.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileVertical)
	End Sub

	Private Sub mnuWindowTileHorizontal_Click() Handles mnuWindowTileHorizontal.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileHorizontal)
	End Sub

	Private Sub mnuWindowCascade_Click() Handles mnuWindowCascade.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbCascade)
	End Sub

	Private Sub mnuWindowNewWindow_Click() Handles mnuWindowNewWindow.Click
		LoadNewDoc()
	End Sub

	Private Sub mnuToolsOptions_Click() Handles mnuToolsOptions.Click
		frmOptions.Show(VBRUN.FormShowConstants.vbModal, Me)
	End Sub

	Private Sub mnuViewWebBrowser_Click() Handles mnuViewWebBrowser.Click
		'ToDo: Add 'mnuViewWebBrowser_Click' code.
		MsgBox6("Add 'mnuViewWebBrowser_Click' code.")
	End Sub

	Private Sub mnuViewOptions_Click() Handles mnuViewOptions.Click
		frmOptions.Show(VBRUN.FormShowConstants.vbModal, Me)
	End Sub

	Private Sub mnuViewRefresh_Click() Handles mnuViewRefresh.Click
		'ToDo: Add 'mnuViewRefresh_Click' code.
		MsgBox6("Add 'mnuViewRefresh_Click' code.")
	End Sub

	Private Sub mnuViewStatusBar_Click() Handles mnuViewStatusBar.Click
		mnuViewStatusBar.Checked = Not mnuViewStatusBar.Checked
		sbStatusBar.Visible = mnuViewStatusBar.Checked
	End Sub

	Private Sub mnuViewToolbar_Click() Handles mnuViewToolbar.Click
		mnuViewToolbar.Checked = Not mnuViewToolbar.Checked
		tbToolBar.Visible = mnuViewToolbar.Checked
	End Sub

	Private Sub mnuEditPasteSpecial_Click() Handles mnuEditPasteSpecial.Click
		'ToDo: Add 'mnuEditPasteSpecial_Click' code.
		MsgBox6("Add 'mnuEditPasteSpecial_Click' code.")
	End Sub

	Private Sub mnuEditPaste_Click() Handles mnuEditPaste.Click
		On Error Resume Next 
		ActiveForm.rtfText.SelRTF = Clipboard6.GetText()
		
	End Sub

	Private Sub mnuEditCopy_Click() Handles mnuEditCopy.Click
		On Error Resume Next 
		Clipboard6.SetText(ActiveForm.rtfText.SelRTF)
		
	End Sub

	Private Sub mnuEditCut_Click() Handles mnuEditCut.Click
		On Error Resume Next 
		Clipboard6.SetText(ActiveForm.rtfText.SelRTF)
		ActiveForm.rtfText.SelText = Nothing
		
	End Sub

	Private Sub mnuEditUndo_Click() Handles mnuEditUndo.Click
		'ToDo: Add 'mnuEditUndo_Click' code.
		MsgBox6("Add 'mnuEditUndo_Click' code.")
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		'unload the form
		Unload6(Me)
		
	End Sub

	Private Sub mnuFileSend_Click() Handles mnuFileSend.Click
		'ToDo: Add 'mnuFileSend_Click' code.
		MsgBox6("Add 'mnuFileSend_Click' code.")
	End Sub

	Private Sub mnuFilePrint_Click() Handles mnuFilePrint.Click
		On Error Resume Next 
		If ActiveForm Is Nothing Then  Exit Sub

		With dlgCommonDialog
			.DialogTitle = "Print"
			.CancelError = True
			.Flags = MSComDlg.PrinterConstants.cdlPDReturnDC + MSComDlg.PrinterConstants.cdlPDNoPageNums
			If ActiveForm.rtfText.SelLength = 0 Then 
				.Flags += MSComDlg.PrinterConstants.cdlPDAllPages
			Else
				.Flags += MSComDlg.PrinterConstants.cdlPDSelection
			End If
			.ShowPrinter()
			If Err.Number <> MSComDlg.ErrorConstants.cdlCancel Then 
				ActiveForm.rtfText.SelPrint(.hDC)
			End If
		End With
		
	End Sub

	Private Sub mnuFilePrintPreview_Click() Handles mnuFilePrintPreview.Click
		'ToDo: Add 'mnuFilePrintPreview_Click' code.
		MsgBox6("Add 'mnuFilePrintPreview_Click' code.")
	End Sub

	Private Sub mnuFilePageSetup_Click() Handles mnuFilePageSetup.Click
		On Error Resume Next 
		With dlgCommonDialog
			.DialogTitle = "Page Setup"
			.CancelError = True
			.ShowPrinter()
		End With
		
	End Sub

	Private Sub mnuFileProperties_Click() Handles mnuFileProperties.Click
		'ToDo: Add 'mnuFileProperties_Click' code.
		MsgBox6("Add 'mnuFileProperties_Click' code.")
	End Sub

	Private Sub mnuFileSaveAll_Click() Handles mnuFileSaveAll.Click
		'ToDo: Add 'mnuFileSaveAll_Click' code.
		MsgBox6("Add 'mnuFileSaveAll_Click' code.")
	End Sub

	Private Sub mnuFileSaveAs_Click() Handles mnuFileSaveAs.Click
		Dim sFile As String = ""

		If ActiveForm Is Nothing Then  Exit Sub

		With dlgCommonDialog
			.DialogTitle = "Save As"
			.CancelError = False
			'ToDo: set the flags and attributes of the common dialog control
			.Filter = "All Files (*.*)|*.*"
			.ShowSave()
			If Len6(.FileName) = 0 Then 
				Exit Sub
			End If
			sFile = .FileName
		End With
		ActiveForm.Caption = sFile
		ActiveForm.rtfText.SaveFile(sFile)
		
	End Sub

	Private Sub mnuFileSave_Click() Handles mnuFileSave.Click
		Dim sFile As String = ""
		If VB.Left(ActiveForm.Caption, 8) = "Document" Then 
			With dlgCommonDialog
				.DialogTitle = "Save"
				.CancelError = False
				'ToDo: set the flags and attributes of the common dialog control
				.Filter = "All Files (*.*)|*.*"
				.ShowSave()
				If Len6(.FileName) = 0 Then 
					Exit Sub
				End If
				sFile = .FileName
			End With
			ActiveForm.rtfText.SaveFile(sFile)
		Else
			sFile = ActiveForm.Caption
			ActiveForm.rtfText.SaveFile(sFile)
		End If
		
	End Sub

	Private Sub mnuFileClose_Click() Handles mnuFileClose.Click
		'ToDo: Add 'mnuFileClose_Click' code.
		MsgBox6("Add 'mnuFileClose_Click' code.")
	End Sub

	Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
		Dim sFile As String = ""

		If ActiveForm Is Nothing Then  LoadNewDoc()

		With dlgCommonDialog
			.DialogTitle = "Open"
			.CancelError = False
			'ToDo: set the flags and attributes of the common dialog control
			.Filter = "All Files (*.*)|*.*"
			.ShowOpen()
			If Len6(.FileName) = 0 Then 
				Exit Sub
			End If
			sFile = .FileName
		End With
		ActiveForm.rtfText.LoadFile(sFile, 0)
		ActiveForm.Caption = sFile
		
	End Sub

	Private Sub mnuFileNew_Click() Handles mnuFileNew.Click
		LoadNewDoc()
	End Sub

End Class
