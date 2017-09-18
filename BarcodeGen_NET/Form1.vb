' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	'---------------------------------------------------------------------------------------
	' Module    : Form1
	' DateTime  : 10/7/2002 19:40
	' Author    : Joyprakash Saikia
	' Purpose   :  To Display the BarCode and Illustrate the use of it
	'---------------------------------------------------------------------------------------

	Private Target As Object
	Private LastSave As String = "" 'To Store last Saved Directory
	Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	Private Sub cboBarSize_Click() Handles cboBarSize.Click
		'---------------------------------------------------------------------------------------
		' Procedure : cboBarSize_Click
		' DateTime  : 10/7/2002 19:40
		' Author    : Joyprakash
		' Purpose   : This Method is basically used to resize the BarCode
		'---------------------------------------------------------------------------------------
		
		Picture2.ScaleMode = 3
		Picture1.ScaleMode = 3
		Select Case cboBarSize.ListIndex
		Case 0
			Picture2.Height = Picture2.Height * (1.4 * 40 / Picture2.ScaleHeight)
			Picture2.FontSize = 8
		Case 1
			Picture2.Height = Picture2.Height * (2.4 * 40 / Picture2.ScaleHeight)
			Picture2.FontSize = 10
		Case 2
			Picture2.Height = Picture2.Height * (3 * 40 / Picture2.ScaleHeight)
			Picture2.FontSize = 14
		End Select
		Text1_Change()
	End Sub

	Private Sub cboTextStyle_Click() Handles cboTextStyle.Click
		Text1_Change()
	End Sub

	Private Sub checkBarCaption_Click() Handles checkBarCaption.Click
		If checkBarCaption.Value = 1 Then 
			checkBarCaption.Caption = "Show Text Caption"
			chkTextAlignment.Visible = True
		Else
			checkBarCaption.Caption = "No Caption"
			chkTextAlignment.Value = 0
			chkTextAlignment.Visible = False
		End If
	End Sub

	Private Sub chkBar128_Click() Handles chkBar128.Click
		If chkBar128.Value = 0 Then 
			Picture1.Visible = False
		Else
			Picture1.Visible = True
		End If
		
	End Sub

	Private Sub chkBar39_Click() Handles chkBar39.Click
		
		If chkBar39.Value = 0 Then 
			Picture2.Visible = False
		Else
			Picture2.Visible = True
		End If
	End Sub

	Private Sub chkTextAlignment_Click() Handles chkTextAlignment.Click
		If chkTextAlignment.Value = 1 Then 
			chkTextAlignment.Caption = "Bottom Align Caption"
		Else
			chkTextAlignment.Caption = "Top Align Caption"
		End If
	End Sub

	Private Sub printBar128()

		'Combination of bar
		'Start Character    3 character (Fixed)
		'Data
		'Check Character    3 character (Depends upon then value of the bar)
		'Stop Character     4 character (Fixed)

		'//######################################################
		'    //PARAMETERS AND THIER MEANING
		'    //a=LEFT
		'    //b=TOP
		'    //hgt=Height of the Barcode
		'    //width=width of the thin Barcode in pixel
		'    //r1=ratio of the thick barcode and thin barcode
		'    //str=Value of the barcode
		'    //align=alignment ofthe text i.e 1=left,2=center,3=right,4=justify
		'    //textdisp= text position with respect to barcode i.e 2=TOP or 1=BOTTOM
		'    //extra=distance of the text from the barcode
		'    //ln=device context of the out put device
		'//######################################################
		Dim Dl As Integer
		' UPGRADE_INFO (#0501): The 'MinWidth' member isn't used anywhere in current application.
		Dim MinWidth As Integer
		Picture1.Cls()

		' UPGRADE_INFO (#0501): The 'RT_VAL' member isn't used anywhere in current application.
		Dim RT_VAL As RET_VAL
		
		With bar
			.crBack = RGB(255, 255, 255)
			.crFore = RGB(0, 0, 0)
			.lalign = 1 'Alignment of the text
			.lExtra = 4 'Distance between the barcode and the text
			.lheight = 40 'Height of the bar
			.lLeft = 20 'Left Position of the bar in the specified device (here e.g. Pictire1)
			.lR1 = 1 'Ratio between thin and thick bar (Standard all over world)
			.lR2 = 1 'Not necessary
			.lRetHeight = 0 'Returns the actual height of the bar code
			.lRetWidth = 0 'Returns the actual width of the bar code
			.lRotation = 0 'to rotate the bar code 0=0degree , 1=90 degree etc.
			.lShowCheck = 1 'Whether check digit will be displayed or not in the bar
			.lstyle = cboTextStyle.ListIndex + 1 'Bold, Italic, Underline or Strikethrough of text
			.lTop = 1 'Top Position of the bar in the specified device (here e.g. Picture1)
			.ltxtdisp = chkTextAlignment.Value + 1 'Whether text displayed at bottom(1) or top(2) of the bar
			.lWidth = cboBarSize.ListIndex + 1 'Width of thin bar in pixel
			.nsize = 10 'Font Size of bar
			.szAdDigit = "" 'Not necessary
			.szBarCaption = IIf(checkBarCaption.Value, Text1.Text, "")
			.szDigit = "" 'Not necessary
			.szReadText = Text1.Text
			.szSymbology = 16
			.TextColor = RGB(255, 0, 0) 'Color of text
			.tiFaceName = "Courier New" 'Font name of text
		End With
		
		Target = Picture1
		Dl = Special_128b(bar, Target.hDc)
		Target.ReleasehDC()
		
		If Dl <> 0 Then  MsgBox6(ErrSpecial_128bMessage(Dl))
	End Sub

	Private Sub Form_KeyDown(ByRef keycode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		If keycode = VBRUN.KeyCodeConstants.vbKeyEscape Then  Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		cboBarSize.ListIndex = 1
		cboTextStyle.ListIndex = 0
	End Sub

	Private Sub lblFeedBack_Click() Handles lblFeedBack.Click
		ShellExecute(Me.hWnd, "open", "http://www.planet-source-code.com/vb/default.asp?lngCId=39531&lngWId=1", 0%, LastSave, AppWinStyle.NormalFocus)
	End Sub

	Private Sub mnuCopyImage1_Click() Handles mnuCopyImage1.Click
		pCopyToClipBoard(Picture1)
	End Sub

	Private Sub mnuCopyImage2_Click() Handles mnuCopyImage2.Click
		pCopyToClipBoard(Picture2)
	End Sub

	Private Sub mnuSaveImage1_Click() Handles mnuSaveImage1.Click
		'Call FileSaving Routine for BarCode 128
		FileSave(Picture1)
		If ChkExecute.Value = 1 Then 
			'if Asked to Show the exported File
			ShellExecute(Me.hWnd, "open", CDialog.FileName, 0%, LastSave, AppWinStyle.NormalFocus)
		End If
	End Sub

	Private Sub mnuSaveImage2_Click() Handles mnuSaveImage2.Click
		'Call FileSaving Routine for BarCode 39
		FileSave(Picture2)
		If ChkExecute.Value = 1 Then 
			'if Asked to Show the exported File
			ShellExecute(Me.hWnd, "open", CDialog.FileName, 0%, LastSave, AppWinStyle.NormalFocus)
		End If
		
	End Sub

	Private Sub Picture1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picture1.MouseDown
		If Button = 2 And Text1.Text <> "" Then 
			
			PopupMenu(mnucp)
		End If
	End Sub

	Private Sub Picture2_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picture2.MouseDown
		If Button = 2 And Text1.Text <> "" Then 
			
			PopupMenu(mnucp1)
		End If
	End Sub

	'---------------------------------------------------------------------------------------
	' Procedure : Text1_Change
	' DateTime  : 10/7/2002 19:48
	' Author    : Joy
	' Purpose   : This Procedure is used to Print Barcode
	'            I used Change event to Show you the effects
	'---------------------------------------------------------------------------------------
	'
	Private Sub Text1_Change() Handles Text1.Change
		
		' UPGRADE_INFO (#0501): The 'MinWidth' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'MinWidth' symbol was defined without an explicit "As" clause.
		Dim MinWidth As Object = Nothing
		' UPGRADE_INFO (#0501): The 'pw' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'pw' symbol was defined without an explicit "As" clause.
		Dim pw As Object = Nothing
		If chkBar128.Value = 1 Then 
			printBar128()
		End If
		If chkBar39.Value = 1 Then 
			Call DrawBarcode(Text1.Text, Picture2)
		End If

	End Sub
	
	Public Sub pCopyToClipBoard(ByVal PictureBox As Object)
		' copy The Image to clipboard
		PictureBox.Picture = PictureBox.Image
		Clipboard6.Clear()
		Clipboard6.SetData(PictureBox.Image, 2)
	End Sub

	Public Sub FileSave(ByVal Picbox As VB6PictureBox)
		'This Procedure Saves the Bars to desired Format
		' UPGRADE_INFO (#0501): The 'sName' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'sName' symbol was defined without an explicit "As" clause.
		Dim sName As Object = Nothing
		' UPGRADE_INFO (#0501): The 'retVal' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'retVal' symbol was defined without an explicit "As" clause.
		Dim retVal As Object = Nothing
		' UPGRADE_INFO (#0561): The 'retSave' symbol was defined without an explicit "As" clause.
		Dim retSave As Object = Nothing
		Dim ObjGifImg As GIF = Nothing
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = 11
		
		CDialog.FilterIndex = 1 'make Dialog as Save
		If LastSave <> "" Then 
			CDialog.InitDir = LastSave
		Else
			CDialog.InitDir = App6.Path & "\ExportedImages"
		End If
		
		On Error GoTo ErrHandler 
		CDialog.FileName = Picbox.Name
		CDialog.CancelError = True
		CDialog.Flags = MSComDlg.FileOpenConstants.cdlOFNOverwritePrompt + MSComDlg.FileOpenConstants.cdlOFNNoReadOnlyReturn
		CDialog.Filter = "Bitmaps (*.bmp)|*.bmp|Gif (*.gif)|*.gif|Transparent Gif (*.gif)|*.gif"
		CDialog.ShowSave()
		'retrive the Folder Name
		retSave = InStrRev(CDialog.FileName, "\")
		LastSave = Mid(CDialog.FileName, 1, retSave)
		DoEvents6()
		
		Picbox.Picture = Picbox.Image
		Select Case CDialog.FilterIndex
		Case 1: 'if BITMAP is selected
			' UPGRADE_WARNING (#1094): The SavePicture method isn't fully supported. The SavePicture6 replacement method always saves the image in BMP format.
			SavePicture6(Picbox.Picture, CDialog.FileName)
		Case 2: 'if GIF is selected
			ObjGifImg = New GIF()
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			ObjGifImg.SaveGIF(Picbox.Image, CDialog.FileName, Picbox.hDC, False, Picbox.Point(0, 0))
			ObjGifImg = Nothing
		Case 2: 'if Transperent GIF is selected
			ObjGifImg = New GIF()
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			ObjGifImg.SaveGIF(Picbox.Image, CDialog.FileName, Picbox.hDC, True, Picbox.Point(0, 0))
			ObjGifImg = Nothing
		End Select
		Picbox.ReleaseHdc()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = 0
		Exit Sub
ErrHandler:
		
		If Err.Number = 32755 Then  ' Handle the Cancel error
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			Screen6.MousePointer = 0
			Exit Sub
		Else
			If Err.Number <> 0 Then  MsgBox6("Error saving file: " & Err.Number & " - " & Err.Description)
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			Screen6.MousePointer = 0
		End If
		
	End Sub

End Class
