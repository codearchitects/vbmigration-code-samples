' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmMain

	#Region "Unsupported controls"
	
		' UPGRADE_ISSUE (#02C8): Controls of type ComCtl3.CoolBar aren't supported. This control was replaced by a dummy variable to make the VB.NET compiler happy
	Friend CoolBar1 As Object
	
	#End Region

	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' IGNORED: Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	' List of messages you can send to a RTF Box control
	Private Const WM_USER As Short = &H400S
	Private Const EM_UNDO As Short = &HC7S
	Private Const EM_GETLINECOUNT As Short = &HBAS
	
	' These are used for searches
	Private SearchString As String = ""
	Private SearchOptions As Integer
	Private SearchStart As Integer
	
	Private Sub MDIForm_Load() Handles MyBase.Load
		
		'Put the Toolbar Wrapper controls in the Coolbar band
		TransTBWrapper1.Container = CoolBar1
		CoolBar1.Bands(1).Child = TransTBWrapper1
		' put the toolbar into the toolbar wrapper
		TransTBWrapper1.Toolbar = tbToolBar
		
		cboFonts.Container = CoolBar1
		cboSize.Container = CoolBar1
		
		CoolBar1.Bands(2).Child = cboFonts
		CoolBar1.Bands(3).Child = cboSize
		
		' fill the combobox with all the font's name
		Dim i As Short
		' UPGRADE_WARNING (#80D4): This property returns the number of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
		For i = 0 To Screen6.FontCount - 1
			' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
			cboFonts.AddItem(Screen6.Fonts(i))
		Next
		
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

	Private Sub cboFonts_Click() Handles cboFonts.Click
		On Error Resume Next 
		ActiveForm.rtfText.SelFontName = cboFonts.Text
	End Sub

	Private Sub cboFonts_KeyPress(ByRef KeyAscii As Short) Handles cboFonts.KeyPress
		If KeyAscii = 13 Then  cboFonts_Click()
	End Sub

	Private Sub cboSize_Click() Handles cboSize.Click
		On Error Resume Next 
		ActiveForm.rtfText.SelFontSize = cboSize.Text
	End Sub

	Private Sub cboSize_KeyPress(ByRef KeyAscii As Short) Handles cboSize.KeyPress
		If KeyAscii = 13 Then  cboSize_Click()
	End Sub

	Private Sub cboSize_DropDown() Handles cboSize.DropDown
		FillFontSizeCombo()
	End Sub

	' fill the combo box of fonts' sizes
	
	Private Sub FillFontSizeCombo()
		Dim saveName As String = ""
		Dim saveSize As Single
		Dim sizes As Object = Nothing
		Dim i As Short
		Dim var As Object = Nothing
		
		' save the font properties of the combo itself
		saveName = cboSize.Font.Name
		saveSize = cboSize.Font.Size
		
		' these are the sizes that we will try
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Array6(6, 8, 7, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72)'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sizes'. Consider using the SetDefaultMember6 helper method.
		sizes = Array6(6, 8, 7, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72)
		
		' create a font with given name
		On Error Resume Next 
		cboSize.Clear()
		cboSize.FontName = cboFonts.Text
		
		' if there is an error, just add some standard sizes
		If Err.Number Then 
			For Each var In Array6(8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 30, 36, 42, 48, 60, 72)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'var'. Consider using the GetDefaultMember6 helper method.
				cboSize.AddItem(var)
			Next
		Else
			' else, try all sizes in the array
			For i = LBound6(sizes) To UBound6(sizes)
				' the only simple way to learn if a given font size is
				' supported is making the assignment and then check
				' if it was successful - testing Err doesn't work
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sizes(i)'. Consider using the GetDefaultMember6 helper method.
				cboSize.FontSize = CShort(sizes(i))
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sizes(i)'. Consider using the GetDefaultMember6 helper method.
				If cboSize.FontSize = CShort(sizes(i)) Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sizes(i)'. Consider using the GetDefaultMember6 helper method.
					cboSize.AddItem(sizes(i))
				End If
			Next
		End If
		
		cboSize.FontName = saveName
		cboSize.FontSize = saveSize
	End Sub

	Private Sub LoadNewDoc()
		Static lDocumentCount As Integer
		Dim frmD As frmDocument = Nothing
		lDocumentCount += 1
		frmD = New frmDocument()
		frmD.Caption = "Document " & lDocumentCount
		frmD.Show()
		frmD.IsDirty = False
	End Sub

	Private Sub MDIForm_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		
		' try to unload all forms
		Dim f As VB6Form = Nothing
		gloCancel = False
		For Each f In Forms6
			Unload6(f)
			' don't proceed if a form refused to unload itself
			If gloCancel Then  Exit Sub
		Next

		' it is VERY important to set the wrapper's Toolbar property
		' to Nothing before the form is unloaded
		CoolBar1.Visible = False
		TransTBWrapper1.Toolbar = Nothing
		
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

	Private Sub mnuEditFindNext_Click() Handles mnuEditFindNext.Click
		If SearchString = "" Then  Exit Sub
		
		On Error Resume Next 
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.Find(SearchString, SearchStart, , SearchOptions)'. Consider using the GetDefaultMember6 helper method.
		SearchStart = ActiveForm.rtfText.Find(SearchString, SearchStart, , SearchOptions)
		If Err.Number Then  Exit Sub
		If SearchStart = -1 Then 
			MsgBox6("String not found", MsgBoxStyle.Exclamation)
		End If
		SearchStart += Len6(SearchString)
	End Sub

	Private Sub mnuEditSelectAll_Click() Handles mnuEditSelectAll.Click
		On Error Resume Next 
		With ActiveForm.rtfText
			.SelStart = 0
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Text'. Consider using the GetDefaultMember6 helper method.
			.SelLength = Len6(.Text)
		End With
	End Sub

	Private Sub mnuEditFind_Click() Handles mnuEditFind.Click
		
		frmFind.txtFind.Text = SearchString
		frmFind.chkWholeWords.Value = IIf(SearchOptions And RichTextLib.FindConstants.rtfWholeWord, VBRUN.CheckBoxConstants.vbChecked, VBRUN.CheckBoxConstants.vbUnchecked)
		frmFind.chkMatchCase.Value = IIf(SearchOptions And RichTextLib.FindConstants.rtfMatchCase, VBRUN.CheckBoxConstants.vbChecked, VBRUN.CheckBoxConstants.vbUnchecked)
		frmFind.Show(VBRUN.FormShowConstants.vbModal)
		
		On Error Resume Next 
		
		If Not frmFind.CancelPressed Then 
			If Err.Number Then  Exit Sub
			SearchString = frmFind.txtFind.Text
			SearchOptions = IIf(frmFind.chkWholeWords.Value, RichTextLib.FindConstants.rtfWholeWord, 0) + IIf(frmFind.chkMatchCase.Value, RichTextLib.FindConstants.rtfMatchCase, 0)
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.Find(SearchString, , , SearchOptions)'. Consider using the GetDefaultMember6 helper method.
			SearchStart = ActiveForm.rtfText.Find(SearchString, , , SearchOptions)
			If SearchStart = -1 Then 
				MsgBox6("String not found", MsgBoxStyle.Exclamation)
			End If
			SearchStart += Len6(SearchString)
		End If
		
		Unload6(frmFind)
		
	End Sub

	Private Sub mnuFormatFont_Click() Handles mnuFormatFont.Click
		Dim RTF As VB6RichTextBox = Nothing
		
		On Error Resume Next 
		RTF = ActiveForm.rtfText
		If Err.Number Then  Exit Sub
		
		With dlgCommonDialog
			.CancelError = True
			.Flags = MSComDlg.FontsConstants.cdlCFBoth Or MSComDlg.FontsConstants.cdlCFEffects
			If IsNull6(RTF.SelFontName) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoFaceSel
			Else
				.FontName = RTF.SelFontName
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelFontSize'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(RTF.SelFontSize) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoSizeSel
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelFontSize'. Consider using the GetDefaultMember6 helper method.
				.FontSize = RTF.SelFontSize
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelBold'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelItalic'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(RTF.SelBold) Or IsNull6(RTF.SelItalic) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoStyleSel
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelBold'. Consider using the GetDefaultMember6 helper method.
				.FontBold = RTF.SelBold
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelItalic'. Consider using the GetDefaultMember6 helper method.
				.FontItalic = RTF.SelItalic
			End If
			' These assignments are protected by the On Error
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelUnderline'. Consider using the GetDefaultMember6 helper method.
			.FontUnderline = RTF.SelUnderline
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'RTF.SelStrikeThru'. Consider using the GetDefaultMember6 helper method.
			.FontStrikeThru = RTF.SelStrikeThru
			.Color = FromOleColor6(RTF.SelColor)
			Err.Clear()
			
			.ShowFont()
			If Err.Number Then  Exit Sub
			
			If .FontName <> "" Then 
				RTF.SelFontName = .FontName
			End If
			RTF.SelBold = .FontBold
			RTF.SelItalic = .FontItalic
			If (.Flags And MSComDlg.FontsConstants.cdlCFNoSizeSel) = 0 Then 
				RTF.SelFontSize = .FontSize
			End If
			RTF.SelUnderline = .FontUnderline
			RTF.SelStrikeThru = .FontStrikeThru
			RTF.SelColor = ToOleColor6(.Color)
			' update the toolbar
			ActiveForm.RTF_SelChange
		End With
	End Sub

	Private Sub mnuFormatParagraph_Click() Handles mnuFormatParagraph.Click
		Dim rtb As VB6RichTextBox = Nothing
		
		On Error Resume Next 
		rtb = ActiveForm.rtfText
		If Err.Number Then  Exit Sub
		
		With frmParagraph
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelIndent'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(rtb.SelIndent) Then 
				.txtLeft.Text = ""
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelIndent'. Consider using the GetDefaultMember6 helper method.
				.txtLeft.Text = rtb.SelIndent
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelRightIndent'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(rtb.SelRightIndent) Then 
				.txtRight.Text = ""
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelRightIndent'. Consider using the GetDefaultMember6 helper method.
				.txtRight.Text = rtb.SelRightIndent
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelHangingIndent'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(rtb.SelHangingIndent) Then 
				.txtFirstLine.Text = ""
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelHangingIndent'. Consider using the GetDefaultMember6 helper method.
				.txtFirstLine.Text = rtb.SelHangingIndent
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelAlignment'. Consider using the GetDefaultMember6 helper method.
			If IsNull6(rtb.SelAlignment) Then 
				.opAlign(0).Value = 0
				.opAlign(1).Value = 0
				.opAlign(2).Value = 0
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelAlignment'. Consider using the GetDefaultMember6 helper method.
			ElseIf rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfLeft Then 
				.opAlign(0).Value = True
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelAlignment'. Consider using the GetDefaultMember6 helper method.
			ElseIf rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfCenter Then 
				.opAlign(1).Value = True
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelAlignment'. Consider using the GetDefaultMember6 helper method.
			ElseIf rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfRight Then 
				.opAlign(2).Value = True
			End If
			.Show(VBRUN.FormShowConstants.vbModal)
			If Not .CancelPressed Then 
				If .txtLeft.Text <> "" Then 
					rtb.SelIndent = Int(.txtLeft.Text)
				End If
				If .txtRight.Text <> "" Then 
					rtb.SelRightIndent = Int(.txtRight.Text)
				End If
				If .txtFirstLine.Text <> "" Then 
					rtb.SelHangingIndent = Int(.txtFirstLine.Text)
				End If
				If .opAlign(0).Value Then 
					rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfLeft
				ElseIf .opAlign(1).Value Then 
					rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfCenter
				ElseIf .opAlign(2).Value Then 
					rtb.SelAlignment = RichTextLib.SelAlignmentConstants.rtfRight
				End If
			End If
		End With
	End Sub

	Private Sub mnuFormatTabs_Click() Handles mnuFormatTabs.Click
		Dim rtb As VB6RichTextBox = Nothing
		Dim i As Short
		
		On Error Resume Next 
		rtb = ActiveForm.rtfText
		If Err.Number Then  Exit Sub
		
		With frmTabs
			.lstTabs.Clear()
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelTabCount'. Consider using the GetDefaultMember6 helper method.
			If Not IsNull6(rtb.SelTabCount) Then 
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelTabCount'. Consider using the GetDefaultMember6 helper method.
				For i = 0 To rtb.SelTabCount - 1
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rtb.SelTabs(i)'. Consider using the GetDefaultMember6 helper method.
					.lstTabs.AddItem(Int(rtb.SelTabs(i)))
				Next
			End If
			.Show(VBRUN.FormShowConstants.vbModal)
			If Not .CancelPressed Then 
				' First, clear all existing tab stops
				rtb.SelTabCount = 0
				' Then enforce selected tab stops.
				rtb.SelTabCount = .lstTabs.ListCount
				For i = 0 To .lstTabs.ListCount - 1
					rtb.SelTabs(i) = Int(.lstTabs.List(i))
				Next
			End If
		End With
	End Sub

	Private Sub mnuViewProperties_Click() Handles mnuViewProperties.Click
		Dim rtb As VB6RichTextBox = Nothing
		Dim par As Integer
		
		On Error Resume Next 
		rtb = ActiveForm.rtfText
		If Err.Number Then  Exit Sub
		
		With frmProperties
			' A fast way to count paragraphs.
			par = Len6(rtb.Text) - Len6(Replace(rtb.Text, ControlChars.CrLf, ControlChars.Cr))
			.lblParagraphs.Caption = par
			' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0%' argument. Consider creating an overload of the Declare statement.
			.lblLines.Caption = SendMessage(rtb.hWnd, EM_GETLINECOUNT, 0, 0%)
			' A fast way to count words.
			.lblWords.Caption = UBound6(Split(rtb.Text, " ")) + 1 + par
			.lblChars.Caption = Len6(rtb.Text)
			.Show(VBRUN.FormShowConstants.vbModal)
		End With
		frmProperties = Nothing
	End Sub

	Private Sub mnuViewStatusbar_Click() Handles mnuViewStatusBar.Click
		mnuViewStatusBar.Checked = Not mnuViewStatusBar.Checked
		sbStatusBar.Visible = mnuViewStatusBar.Checked
	End Sub

	Private Sub mnuViewToolbar_Click() Handles mnuViewToolbar.Click
		mnuViewToolbar.Checked = Not mnuViewToolbar.Checked
		CoolBar1.Bands(1).Visible = mnuViewToolbar.Checked
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
		Case "Find"
			mnuEditFind_Click()
		Case "Undo"
			mnuEditUndo_Click()
		Case "Copy"
			mnuEditCopy_Click()
		Case "Cut"
			mnuEditCut_Click()
		Case "Paste"
			mnuEditPaste_Click()
		Case "Bold"
			ActiveForm.rtfText.SelBold = Not ActiveForm.rtfText.SelBold
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelBold'. Consider using the GetDefaultMember6 helper method.
			Button.Value = IIf(ActiveForm.rtfText.SelBold, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Italic"
			ActiveForm.rtfText.SelItalic = Not ActiveForm.rtfText.SelItalic
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelItalic'. Consider using the GetDefaultMember6 helper method.
			Button.Value = IIf(ActiveForm.rtfText.SelItalic, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Underline"
			ActiveForm.rtfText.SelUnderline = Not ActiveForm.rtfText.SelUnderline
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelUnderline'. Consider using the GetDefaultMember6 helper method.
			Button.Value = IIf(ActiveForm.rtfText.SelUnderline, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Strike Through"
			ActiveForm.rtfText.SelStrikeThru = Not ActiveForm.rtfText.SelStrikeThru
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelStrikeThru'. Consider using the GetDefaultMember6 helper method.
			Button.Value = IIf(ActiveForm.rtfText.SelStrikeThru, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		Case "Align Left"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfLeft
		Case "Align Right"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfRight
		Case "Center"
			ActiveForm.rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfCenter
		Case "Help"
			mnuHelpAbout_Click()
		End Select
	End Sub

	Private Sub mnuHelpAbout_Click() Handles mnuHelpAbout.Click
		frmAbout.Show(VBRUN.FormShowConstants.vbModal, Me)
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

	Private Sub mnuEditPaste_Click() Handles mnuEditPaste.Click
		On Error Resume Next 
		ActiveForm.rtfText.SelRTF = Clipboard6.GetText()
	End Sub

	Private Sub mnuEditCopy_Click() Handles mnuEditCopy.Click
		On Error Resume Next 
		Clipboard6.Clear()
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelRTF'. Consider using the GetDefaultMember6 helper method.
		Clipboard6.SetText(ActiveForm.rtfText.SelRTF)
	End Sub

	Private Sub mnuEditCut_Click() Handles mnuEditCut.Click
		On Error Resume Next 
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelRTF'. Consider using the GetDefaultMember6 helper method.
		Clipboard6.SetText(ActiveForm.rtfText.SelRTF)
		ActiveForm.rtfText.SelText = Nothing
	End Sub

	Private Sub mnuEditUndo_Click() Handles mnuEditUndo.Click
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0%' argument. Consider creating an overload of the Declare statement.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.hWnd'. Consider using the GetDefaultMember6 helper method.
		SendMessage(ActiveForm.rtfText.hWnd, EM_UNDO, 0, 0%)
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		'unload the form
		Unload6(Me)
	End Sub

	Private Sub mnuFilePrint_Click() Handles mnuFilePrint.Click
		' Set this Const to True to print using margins.
		Const PRINT_WITH_MARGINS As Boolean = False
		
		On Error Resume Next 
		If ActiveForm Is Nothing Then  Exit Sub

		With dlgCommonDialog
			.CancelError = True
			.Flags = MSComDlg.PrinterConstants.cdlPDReturnDC + MSComDlg.PrinterConstants.cdlPDNoPageNums
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText.SelLength'. Consider using the GetDefaultMember6 helper method.
			If ActiveForm.rtfText.SelLength = 0 Then 
				.Flags += MSComDlg.PrinterConstants.cdlPDAllPages
			Else
				.Flags += MSComDlg.PrinterConstants.cdlPDSelection
			End If
			.ShowPrinter()
			If Err.Number = 0 Then 
				If Not PRINT_WITH_MARGINS Then 
					ActiveForm.rtfText.SelPrint(.hDC)
				Else
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.rtfText'. Consider using the GetDefaultMember6 helper method.
					PrintRTF(ActiveForm.rtfText, 200, 400, 200, 300)
				End If
			End If
		End With
		
	End Sub

	Private Sub mnuFileSaveAs_Click() Handles mnuFileSaveAs.Click
		Dim sFile As String = ""
		
		If ActiveForm Is Nothing Then  Exit Sub
		
		With dlgCommonDialog
			.DialogTitle = "Save As"
			.CancelError = False
			' the app wizard doesn't properly set flags, nor file filters
			.Flags = MSComDlg.FileOpenConstants.cdlOFNPathMustExist + MSComDlg.FileOpenConstants.cdlOFNOverwritePrompt
			.Filter = "All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt"
			.FilterIndex = 2
			.ShowSave()
			If Len6(.FileName) = 0 Then  Exit Sub
			sFile = .FileName
		End With
		ActiveForm.Caption = sFile
		If UCase(VB.Right(sFile, 3)) = "RTF" Then 
			ActiveForm.rtfText.SaveFile(sFile, RichTextLib.LoadSaveConstants.rtfRTF)
		Else
			ActiveForm.rtfText.SaveFile(sFile, RichTextLib.LoadSaveConstants.rtfText)
		End If
		ActiveForm.IsDirty = False
	End Sub

	Private Sub mnuFileSave_Click() Handles mnuFileSave.Click
		Dim sFile As String = ""
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.Caption'. Consider using the GetDefaultMember6 helper method.
		If VB.Left(ActiveForm.Caption, 8) = "Document" Then 
			' delegate the task to the SaveAs command, if no title yet
			mnuFileSaveAs_Click()
		Else
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ActiveForm.Caption'. Consider using the GetDefaultMember6 helper method.
			sFile = ActiveForm.Caption
			If UCase(VB.Right(sFile, 3)) = "RTF" Then 
				ActiveForm.rtfText.SaveFile(sFile, RichTextLib.LoadSaveConstants.rtfRTF)
			Else
				ActiveForm.rtfText.SaveFile(sFile, RichTextLib.LoadSaveConstants.rtfText)
			End If
			ActiveForm.IsDirty = False
		End If
	End Sub

	Private Sub mnuFileClose_Click() Handles mnuFileClose.Click
		On Error Resume Next 
		Unload6(ActiveForm)
	End Sub

	Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
		Dim sFile As String = ""
		If ActiveForm Is Nothing Then  LoadNewDoc()
		
		With dlgCommonDialog
			.DialogTitle = "Open"
			.CancelError = False
			' the app wizard doesn't properly set flags, nor file filters
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
			.Filter = "All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt"
			.FilterIndex = 2
			.ShowOpen()
			If Len6(.FileName) = 0 Then 
				Exit Sub
			End If
			sFile = .FileName
		End With
		If UCase(VB.Right(sFile, 3)) = "RTF" Then 
			ActiveForm.rtfText.LoadFile(sFile, RichTextLib.LoadSaveConstants.rtfRTF)
		Else
			ActiveForm.rtfText.LoadFile(sFile, RichTextLib.LoadSaveConstants.rtfText)
		End If
		ActiveForm.Caption = sFile
		ActiveForm.IsDirty = False
	End Sub

	Private Sub mnuFileNew_Click() Handles mnuFileNew.Click
		LoadNewDoc()
	End Sub

End Class
