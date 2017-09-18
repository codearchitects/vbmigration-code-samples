' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmshowfnt

	Private Declare Function CreateFontIndirect Lib "gdi32" Alias "CreateFontIndirectA" (ByRef lpLogFont As frmshowfnt.LOGFONT) As Integer
	
	Friend Structure LOGFONT
	
		Public lfHeight As Integer ' In logical units
		Public lfWidth As Integer
		Public lfEscapement As Integer
		Public lfOrientation As Integer
		Public lfWeight As Integer
		Public lfItalic As Byte
		Public lfUnderline As Byte
		Public lfStrikeOut As Byte
		Public lfCharSet As Byte
		Public lfOutPrecision As Byte
		Public lfClipPrecision As Byte
		Public lfQuality As Byte
		Public lfPitchAndFamily As Byte
		<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=33)> _
		Private m_lfFaceName As String ' L_FACESIZE
	
	#Region "Initialization"

		Public Sub New(ByVal dummyArg As Boolean)
			InitializeUDT()
		End Sub
	
		Public Sub InitializeUDT()
			m_lfFaceName = VB6FixedString.GetEmptyBuffer(33)
		End Sub
	
	#End Region

		Public Property lfFaceName() As String
			Get
				Return VB6FixedString.Truncate(m_lfFaceName, 33, ControlChars.NullChar)
			End Get
			Set(ByVal value As String)
				m_lfFaceName = VB6FixedString.Truncate(value, 33)
			End Set
		End Property
	End Structure

	Private Declare Function SelectObject Lib "gdi32" (ByVal hdc As Integer, ByVal hObject As Integer) As Integer
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	
	' In order for Windows NT to work
	Private Declare Function SetGraphicsMode Lib "gdi32" (ByVal hdc As Integer, ByVal iMode As Integer) As Integer
	Private Const GM_ADVANCED As Short = 2
	
	Private t3d As Class1
	Private Cx As Short
	Private Cy As Short
	Private strfontnaam As String = ""
	Private strtext As String = ""
	Private diepte As Short
	Private Comx As Short
	Private tempx As Short
	Private bbackgroundcontrole As Boolean
	
	Private x22 As Single
	Private y22 As Single
	Private x11 As Single
	Private y11 As Single
	
	Private Sub Check1_Click() Handles Check1.Click
		Picture2.Cls()
		Picture2.CurrentX = Cx
		Picture2.CurrentY = Cy
		If Check1.Value = 0 Then 
			Picture2.PrintLine(strtext)
			Command8_Click()
			Command4(0).Value = True
			
		Else
			Command4(1).Value = True
			
			t3d = New Class1()
			t3d.Text3D(strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value)
		End If

	End Sub

	Private Sub Command10_Click() Handles Command10.Click
		Command3.Value = True
		Command12.Enabled = True
		Command10.Enabled = True
	End Sub

	'Print
	Private Sub Command11_Click() Handles Command11.Click
		' UPGRADE_INFO (#0561): The 'xxx' symbol was defined without an explicit "As" clause.
		Dim xxx As Object = Nothing
		On Error Resume Next 
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'xxx'. Consider using the SetDefaultMember6 helper method.
		xxx = MsgBox6("Are you sure want to Print? ", MsgBoxStyle.YesNo, "Gerp Soft ( PRINT )")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'xxx'. Consider using the GetDefaultMember6 helper method.
		If xxx = MsgBoxResult.Yes Then 
			Command6_Click()
			Image2.Picture = LoadPicture6("C:\sample.bmp")
			
			If Option1.Value = True And Option2.Value = False Then 
				Printer6.PrintQuality = -2
				Printer6.PaintPicture(Image2.Picture, 0, 0, 5910, 3720)
				Printer6.EndDoc()
			ElseIf Option2.Value = True And Option1.Value = False Then 
				Printer6.PrintQuality = -2
				Printer6.PaintPicture(Image2.Picture, 0, 0, 3720, 5910)
				Printer6.EndDoc()
				
			End If
		End If
	End Sub

	Private Sub Command12_Click() Handles Command12.Click
		Image1.Picture = LoadPicture6("")
		Picture2.Picture = Image1.Picture
		bbackgroundcontrole = False
		Text1.Text = strtext
		Text1_Change()
	End Sub

	Private Sub Command13_Click() Handles Command13.Click
		If Command13.Caption = "Show Grid" Then 
			Line2.Visible = True
			Line3.Visible = True
			Line4.Visible = True
			Line5.Visible = True
			Line6.Visible = True
			Line7.Visible = True
			Line8.Visible = True
			Line9.Visible = True
			Line10.Visible = True
			Line11.Visible = True
			Line12.Visible = True
			Line13.Visible = True
			Line14.Visible = True
			Line15.Visible = True
			Command13.Caption = "Hide Grid"
			
		ElseIf Command13.Caption = "Hide Grid" Then 
			Line2.Visible = False
			Line3.Visible = False
			Line4.Visible = False
			Line5.Visible = False
			Line6.Visible = False
			Line7.Visible = False
			Line8.Visible = False
			Line9.Visible = False
			Line10.Visible = False
			Line11.Visible = False
			Line12.Visible = False
			Line13.Visible = False
			Line14.Visible = False
			Line15.Visible = False
			Command13.Caption = "Show Grid"
		End If
	End Sub

	Private Sub Command14_Click() Handles Command14.Click
		
		' Engraved, horizontal. &H808080 is gray
		x22 = Picture4.ScaleLeft + 120
		y22 = Picture4.ScaleTop + 18
		RotateText(Picture4, "GerP Soft by: Gerbert S. Pagtama", "Times New Roman", True, False, 16, 0, 2, VBRUN.ColorConstants.vbWhite, &H808080, VBRUN.ColorConstants.vbBlack, x22, y22)
		
		x11 = Picture4.ScaleLeft + 60
		y11 = Picture4.ScaleTop + 45
		RotateText(Picture4, "Mobile number  (+63928 7965237)  E-mail :gerbert_p@yahoo.com", "Times New Roman", True, False, 12, 0, 2, VBRUN.ColorConstants.vbYellow, &H808080, VBRUN.ColorConstants.vbBlack, x11, y11)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Dim strfilen As String = ""
		With Cdl1
			.CancelError = False
			.Filter = "Bitmap (.bmp)|*.bmp"
			.FileName = Text1.Text & ".bmp"
			.ShowSave()
			strfilen = .FileName
		End With
		If Len6(strfilen) > 1 Then 
			' UPGRADE_WARNING (#1094): The SavePicture method isn't fully supported. The SavePicture6 replacement method always saves the image in BMP format.
			SavePicture6(Picture2.Image, strfilen)
		Else
			MsgBox6("you must enter a name to save this picture", MsgBoxStyle.DefaultButton1, "No Save")
		End If
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		On Error Resume Next 
		With Cdl1
			.Filter = "All Picture Files| *.png; *.gif; *.cel; *.pic; *.cut; *.pal; *.tga; *.pcx; *.bmp; *.tiff; *.jpg; *.jpeg; *.wmf|Portable Network Grphics  (*.png)|*.png|CompuServe Images  (*.gif)|*.gif|Autodesk Images  (*.cel,*.pic)|*.cel,*pic|DrHalo Images  (*.cut,*.pal)|*.cut,*.pal|True Vision Images  (*.tga)|*.tga|ZSoft Paintbrush  (*.pcx)|*.pcx|Bitmap Images  (*.bmp)|*.bmp|Tiff Images  (*.Tiff)|*.Tiff|Jpeg Images  (*.jpeg)|*.jpeg|Windos MetaFile  (*.wmf)|*.wmf|"
			.ShowOpen()
		End With
		Image1.Picture = LoadPicture6(Cdl1.FileName)
		If Image1.Width > 1022 * 15 Then  Image1.Width = 1022 * 15
		If Image1.Height > 639 * 15 Then  Image1.Height = 639 * 15
		Picture2.Picture = Image1.Picture
		
		bbackgroundcontrole = True
		Text1.Text = strtext
		Text1_Change()
	End Sub

	Private Sub Command4_Click(ByRef Index As Short)
		If Index > 0 Then 
			Check1.Value = 1
		Else
			Check1.Value = 0
		End If
		
		Comx = Index
		
		Select Case Index
		Case 0
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Picture2.PrintLine(strtext)
			Command4(Index).BackColor = FromOleColor6(&H8080FF)
			Command4(1).BackColor = SystemColors.Control 
			Command4(2).BackColor = SystemColors.Control 
			Command4(5).BackColor = SystemColors.Control 
			Command4(6).BackColor = SystemColors.Control 
			
		Case 1
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Index).BackColor = FromOleColor6(&H8080FF)
			Command4(0).BackColor = SystemColors.Control 
			Command4(2).BackColor = SystemColors.Control 
			Command4(5).BackColor = SystemColors.Control 
			Command4(6).BackColor = SystemColors.Control 
			
			t3d = New Class1()
			
			t3d.Text3D(strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value)

		Case 2
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Index).BackColor = FromOleColor6(&H8080FF)
			Command4(0).BackColor = SystemColors.Control 
			Command4(1).BackColor = SystemColors.Control 
			Command4(5).BackColor = SystemColors.Control 
			Command4(6).BackColor = SystemColors.Control 
			
			t3d = New Class1()
			t3d.Text3D8(strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value)
			
		Case 5
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Index).BackColor = FromOleColor6(&H8080FF)
			Command4(0).BackColor = SystemColors.Control 
			Command4(1).BackColor = SystemColors.Control 
			Command4(2).BackColor = SystemColors.Control 
			Command4(6).BackColor = SystemColors.Control 
			
			t3d = New Class1()
			t3d.Text3D7(strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value)
		Case 6
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Index).BackColor = FromOleColor6(&H8080FF)
			Command4(0).BackColor = SystemColors.Control 
			Command4(1).BackColor = SystemColors.Control 
			Command4(2).BackColor = SystemColors.Control 
			Command4(5).BackColor = SystemColors.Control 
			
			t3d = New Class1()
			t3d.Text3D2(strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value)
		End Select
	End Sub

	Private Sub Command5_Click() Handles Command5.Click
		Text1.Text = ""
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		' UPGRADE_WARNING (#1094): The SavePicture method isn't fully supported. The SavePicture6 replacement method always saves the image in BMP format.
		SavePicture6(Picture2.Image, "C:\sample.bmp")
		Picture2.Picture = LoadPicture6("C:\sample.bmp")
		Text1.Text = ""
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		Picture2.Cls()
		Picture2.CurrentX = Cx
		Picture2.CurrentY = Cy
		
		Picture2.BackColor = FromOleColor6(RGB(Val(HScroll1(0).Value), Val(HScroll1(1).Value), Val(HScroll1(2).Value)))
		If Check1.Value = 0 Then 
			
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
			
		End If

	End Sub

	Private Sub Command8_Click() Handles Command8.Click
		Picture2.Cls()
		Picture2.CurrentX = Cx
		Picture2.CurrentY = Cy

		If Check1.Value = 0 Then 
			Picture2.ForeColor = FromOleColor6(RGB(Val(HScroll2(0).Value), Val(HScroll2(1).Value), Val(HScroll2(2).Value)))
			
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
			
		End If
		
	End Sub

	Private Sub Command9_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			
			Picture2.FontBold = True
			Command4(Comx).Value = True
			Command9(0).BackColor = FromOleColor6(&H8080FF)
			Command9(4).BackColor = SystemColors.Control 
			
		Case 1
			Picture2.FontItalic = True
			Command4(Comx).Value = True
			Command9(1).BackColor = FromOleColor6(&H8080FF)
			Command9(4).BackColor = SystemColors.Control 
			
		Case 2
			Picture2.FontUnderline = True
			Command4(Comx).Value = True
			Command9(2).BackColor = FromOleColor6(&H8080FF)
			Command9(4).BackColor = SystemColors.Control 
			
		Case 3
			Picture2.FontStrikethru = True
			Command4(Comx).Value = True
			Command9(3).BackColor = FromOleColor6(&H8080FF)
			Command9(4).BackColor = SystemColors.Control 
		Case 4
			Picture2.FontBold = False
			Picture2.FontItalic = False
			Picture2.FontUnderline = False
			Picture2.FontStrikethru = False
			Command4(Comx).Value = True
			Command9(0).BackColor = SystemColors.Control 
			Command9(1).BackColor = SystemColors.Control 
			Command9(2).BackColor = SystemColors.Control 
			Command9(3).BackColor = SystemColors.Control 
			Command9(4).BackColor = FromOleColor6(&H8080FF)
			
		End Select
		
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Command14_Click()
		mnusave.Enabled = False
		mnuprint.Enabled = False
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		On Error Resume Next 
		
		Dim X As Short
		Text1.Text = ""
		strtext = Text1.Text
		
		' UPGRADE_WARNING (#80D4): This property returns the number of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
		For X = 0 To Screen6.FontCount - 1
			' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
			list1.AddItem(Screen6.Fonts(X))
		Next

		HScroll3.Value = 14 ' font size
		
		HScroll1(0).Value = 255
		HScroll1(1).Value = 255
		HScroll1(2).Value = 255
		
		HScroll2(0).Value = 220
		HScroll2(1).Value = 87
		HScroll2(2).Value = 40
		HScroll5(0).Value = 0
		HScroll5(1).Value = 0
		HScroll5(2).Value = 0

		PicX = 600
		PicY = 145
		
		Cx = 1200
		Cy = 400
		diepte = 80
		HScroll4.Value = diepte
		Command4(0).BackColor = FromOleColor6(&H8080FF)
		strfontnaam = list1.List(5)
		
		FontChangeName6(Picture2.Font, list1.List(5)): list1.Text = list1.List(5)
		
		Picture2.FontSize = HScroll3.Value
		
		Label2(0).Caption = HScroll1(0).Value
		Label2(1).Caption = HScroll1(1).Value
		Label2(2).Caption = HScroll1(2).Value
		Label3(0).Caption = HScroll2(0).Value
		Label3(1).Caption = HScroll2(1).Value
		Label3(2).Caption = HScroll2(2).Value
		Label7(0).Caption = HScroll5(0).Value
		Label7(1).Caption = HScroll5(1).Value
		Label7(2).Caption = HScroll5(2).Value
		Picture2.Cls()
		
		Picture2.PrintLine(Text1.Text)

		Timer1.Enabled = True
		
		Command4(1).Value = True
		Command9(4).Value = True
		
		Check1.Value = 0

		If Check1.Value = 0 Then 
			Picture2.ForeColor = Color.Black 
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
			
		End If
		Command14_Click()
		Option1.Value = 1
		Picture2.FontBold = True

	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmshowfnt' was converted to Me keyword.
		' UPGRADE_INFO (#0311): Next statement was commented out because it would be invalid in VB.NET
		'EXCLUDED: Me = Nothing
		
	End Sub

	Private Sub Frame2_DragDrop(ByVal Source As Control, ByVal X As Single, ByVal Y As Single)
	' UPGRADE_INFO (#0501): The 'Frame2_DragDrop' member isn't used anywhere in current application.
		
	End Sub

	Private Sub Frame9_DragDrop(ByVal Source As Control, ByVal X As Single, ByVal Y As Single)
	' UPGRADE_INFO (#0501): The 'Frame9_DragDrop' member isn't used anywhere in current application.
		
	End Sub

	Private Sub HScroll1_Change(ByRef Index As Short)
		Text3.BackColor = FromOleColor6(RGB(Val(HScroll1(0).Value), Val(HScroll1(1).Value), Val(HScroll1(2).Value)))
		Command7_Click()
		Label2(0).Caption = HScroll1(0).Value
		Label2(1).Caption = HScroll1(1).Value
		Label2(2).Caption = HScroll1(2).Value
		
	End Sub

	Private Sub HScroll2_Change(ByRef Index As Short)
		Text2.BackColor = FromOleColor6(RGB(Val(HScroll2(0).Value), Val(HScroll2(1).Value), Val(HScroll2(2).Value)))
		Label3(0).Caption = HScroll2(0).Value
		Label3(1).Caption = HScroll2(1).Value
		Label3(2).Caption = HScroll2(2).Value
		Command8_Click()
		
	End Sub

	Private Sub HScroll3_Change() Handles HScroll3.Change
		
		Picture2.Cls()
		Picture2.CurrentX = Cx
		Picture2.CurrentY = Cy

		Picture2.FontSize = HScroll3.Value + 1
		If Check1.Value = 0 Then 
			Picture2.PrintLine(strtext)
			Label1.Caption = HScroll3.Value
		Else
			Command4(Comx).Value = True
			Label1.Caption = HScroll3.Value
			
		End If
		
	End Sub

	Private Sub HScroll4_Change() Handles HScroll4.Change
		diepte = HScroll4.Value
		If Check1.Value = 0 Then 
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
			
		End If
		Label5.Caption = diepte
		
	End Sub

	Private Sub HScroll5_Change(ByRef Index As Short)
		Text4.BackColor = FromOleColor6(RGB(HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value))

		If Check1.Value = 0 Then 
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True

		End If
		Label7(0).Caption = HScroll5(0).Value
		Label7(1).Caption = HScroll5(1).Value
		Label7(2).Caption = HScroll5(2).Value
		
	End Sub

	Private Sub List1_Click() Handles list1.Click
		On Error Resume Next 
		
		Dim z As Short = HScroll3.Value
		Picture2.Cls()
		Picture2.CurrentX = Cx
		Picture2.CurrentY = Cy
		
		' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
		FontChangeName6(Picture2.Font, Screen6.Fonts(list1.ListIndex))
		' UPGRADE_WARNING (#80E4): This property returns the collection of font families and doesn't include character-set versions inside families. Use the FontFamily.Families collection to suppress this warning.
		strfontnaam = Screen6.Fonts(list1.ListIndex)
		Picture2.FontSize = z
		
		If Check1.Value = 0 Then 
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
			
		End If

	End Sub

	Private Sub mnubackground_Click() Handles mnubackground.Click
		Command3.Value = True
		
	End Sub

	Private Sub mnuclback_Click() Handles mnuclback.Click
		Image1.Picture = LoadPicture6("")
		Picture2.Picture = Image1.Picture
		bbackgroundcontrole = False
		Text1.Text = strtext
		Text1_Change()
	End Sub

	Private Sub mnuexit_Click() Handles mnuexit.Click
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmshowfnt' was converted to Me keyword.
		Unload6(Me)
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmshowfnt' was converted to Me keyword.
		' UPGRADE_INFO (#0311): Next statement was commented out because it would be invalid in VB.NET
		'EXCLUDED: Me = Nothing
	End Sub

	Private Sub mnuopen_Click() Handles mnuopen.Click
		On Error GoTo fout 
		With Cdl1
			.CancelError = True
			.FileName = ""
			.Filter = "Bitmap (*.bmp)|*.bmp"
			.ShowOpen()
		End With
		If Len6(Cdl1.FileName) > 1 Then 
			Picture2.Cls()
			Text1.Text = ""
			Picture2.Picture = LoadPicture6(Cdl1.FileName)
			Call Pic_Res()
			If Option1.Value = True And Option2.Value = False Then 
				Option1_Click()
			ElseIf Option2.Value = True And Option1.Value = False Then 
				Option2_Click()
			End If
			
		Else
			
		End If
fout:
		Text1_Change()
		
		mnusave.Enabled = True
		mnuprint.Enabled = True
		
	End Sub

	Private Sub mnunieuw_Click() Handles mnunieuw.Click
		Form_Load()
		mnuclback_Click()
		mnuopen.Enabled = True
		Text1.Text = ""
		Text2.Text = ""
		mnusave.Enabled = True
		mnuprint.Enabled = True
		Text1.Locked = False
		Command10.Enabled = True
		Command13.Enabled = True
		Command11.Enabled = True
	End Sub

	Private Sub mnuprint_Click() Handles mnuprint.Click
		Command11_Click()
	End Sub

	Private Sub mnusave_Click() Handles mnusave.Click
		Command2_Click()
	End Sub
	
	Private Sub Option1_Click() Handles Option1.Click
		'Portrait
		Picture2.Height = 3720
		Picture2.Width = 5910
		Picture2.Left = 1200
		Picture2.Top = 1440
		
		Picture1.Height = 3720
		Picture1.Width = 5910
		Picture1.Left = 1200
		Picture1.Top = 1440
		
		Image1.Height = 3720
		Image1.Width = 5910
		Image1.Left = 1200
		Image1.Top = 1440
		
		Image2.Height = 3720
		Image2.Width = 5910
		
		Line19.X1 = 2860
		Line19.X2 = 2860
		Line19.Y1 = 0
		Line19.Y2 = 3720
		
		Line20.X1 = 0
		Line20.X2 = 5880
		Line20.Y1 = 1780
		Line20.Y2 = 1780
	End Sub

	Private Sub Option2_Click() Handles Option2.Click
		'Landscape
		Picture2.Height = 5910
		Picture2.Width = 3720
		Picture2.Left = 2255
		Picture2.Top = 460
		
		Picture1.Height = 5910
		Picture1.Width = 3720
		Picture1.Left = 2255
		Picture1.Top = 460
		
		Image1.Height = 5910
		Image1.Width = 3720
		Image1.Left = 2255
		Image1.Top = 460
		
		Image2.Height = 5910
		Image2.Width = 3720
		
		Line19.X1 = 1780
		Line19.X2 = 1780
		Line19.Y1 = 0
		Line19.Y2 = 5880
		
		Line20.X1 = 0
		Line20.X2 = 5880
		Line20.Y1 = 2760
		Line20.Y2 = 2760
		
	End Sub

	Private Sub Picture2_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picture2.MouseMove
		Label11.Caption = CShort(X) / 15
		Label13.Caption = CShort(Y) / 15
	End Sub

	Private Sub picture2_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picture2.MouseDown
		Picture2.Cls()
		Picture2.CurrentX = CShort(X) + 5: Cx = CShort(X) + 5
		Picture2.CurrentY = CShort(Y) - 10: Cy = CShort(Y) - 10
		If Check1.Value = 0 Then 
			Picture2.PrintLine(strtext)
		Else
			Picture2.Cls()
			Picture2.CurrentX = Cx
			Picture2.CurrentY = Cy
			Command4(Comx).Value = True
		End If
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		' UPGRADE_INFO (#0501): The 'currentXX' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'currentXX' symbol was defined without an explicit "As" clause.
		Dim currentXX As Object = Nothing
		' UPGRADE_INFO (#0501): The 'currentYY' member isn't used anywhere in current application.
		' UPGRADE_INFO (#0561): The 'currentYY' symbol was defined without an explicit "As" clause.
		Dim currentYY As Object = Nothing
		' UPGRADE_INFO (#0561): The 'widthx' symbol was defined without an explicit "As" clause.
		Dim widthx As Object = Nothing
		' UPGRADE_INFO (#0561): The 'heighty' symbol was defined without an explicit "As" clause.
		Dim heighty As Object = Nothing
		Dim lent As Short
		strtext = Text1.Text
		Picture2.Cls()
		lent = Len6(Text1.Text)
		lent = CDbl(lent) * CDbl(lent) + 500
		
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'widthx'. Consider using the SetDefaultMember6 helper method.
		widthx = Picture2.Width
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'heighty'. Consider using the SetDefaultMember6 helper method.
		heighty = Picture2.Height
		
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'widthx'. Consider using the SetDefaultMember6 helper method.
		widthx = CDbl(widthx) / 2
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'widthx'. Consider using the SetDefaultMember6 helper method.
		widthx = CDbl(widthx) - CDbl(lent)
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'widthx'. Consider using the GetDefaultMember6 helper method.
		Picture2.CurrentX = widthx
		
		Picture2.CurrentY = Cy
		If Check1.Value = 1 Then 
			Command4(Comx).Value = True
			
		Else
			Picture2.PrintLine(strtext)
		End If
		
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		
		Picture1.PaintPicture(Picture2.Image, 0, 0, PicX * 22, PicY * 22)
		DoEvents6()
		If bbackgroundcontrole = False Then 
			mnuclback.Enabled = False
			mnubackground.Enabled = True
			
		Else
			mnuclback.Enabled = True
			mnubackground.Enabled = False
			
		End If
		
	End Sub

	Public Sub Init()
	' UPGRADE_INFO (#0501): The 'Init' member isn't used anywhere in current application.
		Picture1.Width = PicX * 15
		Picture1.Height = PicY * 15
		Picture2.Width = PicX * 15
		Picture2.Height = PicY * 15
		Image1.Width = PicX * 15
		Image1.Height = PicY * 15
		
		Picture1.Left = 360 + (tempx / 2)
		
		Picture2.Left = Picture1.Left
		Image1.Left = Picture1.Left
		
		Call Pic_Res()
		
	End Sub

	Private Sub Pic_Res()
		Picture1.Width = Picture2.Width
		Picture1.Height = Picture2.Height
		Image1.Width = Picture2.Width
		Image1.Height = Picture2.Height
		PicX = Picture2.Width / 15
		PicY = Picture2.Height / 15

		Picture1.Left = 360 + (tempx / 2)

		Picture2.Left = Picture1.Left
		Image1.Left = Picture1.Left
		
	End Sub

	Public Function RotateText(ByVal inObj As Object, ByVal inText As String, ByVal inFontName As String, ByVal inBold As Boolean, ByVal inItalic As Boolean, ByVal inFontSize As Short, ByVal inAngle As Integer, ByVal inStyle As Short, ByVal firstClr As Integer, ByVal secondClr As Integer, ByVal mainClr As Integer, ByVal X As Single, ByVal Y As Single, Optional ByVal inDepth As Short = 1) As Boolean
		On Error GoTo errHandler 
		
		RotateText = False
		
		Dim L As New frmshowfnt.LOGFONT(True)
		Dim mFont As Integer
		Dim mPrevFont As Integer
		Dim i As Short
		Dim origMode As Short
		Dim tmpX As Single
		Dim tmpY As Single
		' UPGRADE_INFO (#0561): The 'mresult' symbol was defined without an explicit "As" clause.
		Dim mresult As Object = SetGraphicsMode(inObj.hdc, GM_ADVANCED)
		
		' For Windows NT to work
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.hdc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mresult'. Consider using the SetDefaultMember6 helper method.
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.ScaleMode'. Consider using the GetDefaultMember6 helper method.
		origMode = inObj.ScaleMode
		inObj.ScaleMode = VBRUN.ScaleModeConstants.vbPixels
		
		If inBold = True And inItalic = True Then 
			L.lfFaceName = inFontName & Space(1) & "Bold" & Space(1) & "Italic" & Chr6(0) ' Must be null terminated
		ElseIf inBold = True And inItalic = False Then 
			L.lfFaceName = inFontName & Space(1) & "Bold" & Chr6(0)
		ElseIf inBold = False And inItalic = True Then 
			L.lfFaceName = inFontName & Space(1) & "Italic" & Chr6(0)
		Else
			L.lfFaceName = inFontName & Chr6(0)
		End If
		
		L.lfEscapement = inAngle * 10
		L.lfHeight = inFontSize * -20 / Screen6.TwipsPerPixelY
		
		mFont = CreateFontIndirect(L)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.hdc'. Consider using the GetDefaultMember6 helper method.
		mPrevFont = SelectObject(inObj.hdc, mFont)
		
		inObj.CurrentX = X
		inObj.CurrentY = Y
		tmpX = X
		tmpY = Y
		Select Case inStyle
		Case 0 ' Ordinary shade
			If firstClr <> -1 Then  ' Minus 1 indicate N/A
				inObj.ForeColor = FromOleColor6(firstClr)
				For i = 1 To inDepth
					tmpX += 1: tmpY += 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If secondClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				tmpX = X
				tmpY = Y
				inObj.ForeColor = FromOleColor6(secondClr)
				For i = 1 To inDepth
					tmpX -= 1: tmpY -= 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If mainClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				inObj.ForeColor = FromOleColor6(mainClr)
				inObj.PrintLine(inText)
			End If
			
		Case 1 'Embossed effect - text horizontal
			If firstClr <> -1 Then 
				inObj.ForeColor = FromOleColor6(firstClr)
				For i = 1 To inDepth
					tmpX -= 1: tmpY -= 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If secondClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				tmpX = X
				tmpY = Y
				inObj.ForeColor = FromOleColor6(secondClr)
				For i = 1 To inDepth
					tmpX += 1: tmpY += 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If mainClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				inObj.ForeColor = FromOleColor6(mainClr)
				inObj.PrintLine(inText)
			End If
			
		Case 2 ' Engroved effect - text horizontal
			If firstClr <> -1 Then 
				inObj.ForeColor = FromOleColor6(firstClr)
				For i = 1 To inDepth
					tmpX += 1: tmpY += 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If

			If secondClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				tmpX = X
				tmpY = Y
				inObj.ForeColor = FromOleColor6(secondClr)
				For i = 1 To inDepth
					tmpX -= 1: tmpY -= 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If mainClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				inObj.ForeColor = FromOleColor6(mainClr)
				inObj.PrintLine(inText)
			End If
			
		Case 3 ' Embossed effect - text vertical
			If firstClr <> -1 Then 
				inObj.ForeColor = FromOleColor6(secondClr)
				For i = 1 To inDepth
					tmpX += 1: tmpY += 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If secondClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				tmpX = X
				tmpY = Y
				inObj.ForeColor = FromOleColor6(firstClr)
				For i = 1 To inDepth
					tmpX -= 1: tmpY -= 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If mainClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				inObj.ForeColor = FromOleColor6(mainClr)
				inObj.PrintLine(inText)
			End If
			
		Case 4 'Engraved effect - text vertical
			If firstClr <> -1 Then 
				inObj.ForeColor = FromOleColor6(secondClr)
				For i = 1 To inDepth
					tmpX -= 1: tmpY -= 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If secondClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				tmpX = X
				tmpY = Y
				inObj.ForeColor = FromOleColor6(firstClr)
				For i = 1 To inDepth
					tmpX += 1: tmpY += 1
					inObj.CurrentX = tmpX
					inObj.CurrentY = tmpY
					inObj.PrintLine(inText)
				Next
			End If
			
			If mainClr <> -1 Then 
				inObj.CurrentX = X
				inObj.CurrentY = Y
				inObj.ForeColor = FromOleColor6(mainClr)
				inObj.PrintLine(inText)
			End If
		End Select
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.hdc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mresult'. Consider using the SetDefaultMember6 helper method.
		mresult = SelectObject(inObj.hdc, mPrevFont)
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mresult'. Consider using the SetDefaultMember6 helper method.
		mresult = DeleteObject(mFont)
		inObj.ScaleMode = origMode
		RotateText = True
		inObj.ReleaseHdc()
		Exit Function
		
errHandler:
		inObj.ReleaseHdc()
		inObj.ScaleMode = origMode
		MsgBox6("RotateText")
	End Function

	' Parameters: Object, String, FontName, Bold, Italic, FontSize,
	'   SolidColor(1=red, 2=green, 3=blue, 4=black), X, Y,
	'  (& optional Direction  1=left to right, 2=right to left
	'   3=top down, 4=bottom up)
	'
	' Example: GradientText Me, "Example 3", "Times New Roman", True, False, 18,
	' '               3, X, y (0)
	'          GradientText Me, "Example 3", "Times New Roman", True, False, 18,
	' '               3, X, y, 1
	Public Sub GradientText(ByVal inObj As Object, ByVal inText As String, ByVal inFontName As String, ByVal inBold As Boolean, ByVal inItalic As Boolean, ByVal inFontSize As Short, ByVal SolidClr As Short, ByVal X As Single, ByVal Y As Single, Optional ByVal inDirection As Short = 0)
	' UPGRADE_INFO (#0501): The 'GradientText' member isn't used anywhere in current application.
		On Error GoTo errHandler 
		Dim L As New frmshowfnt.LOGFONT(True)
		Dim mFont As Integer
		Dim mPrevFont As Integer
		Dim i As Short
		Dim j As Short
		Dim k As Short
		Dim t As Short
		Dim origMode As Short
		' UPGRADE_INFO (#0561): The 'interval' symbol was defined without an explicit "As" clause.
		Dim interval As Object = Nothing
		' UPGRADE_INFO (#0561): The 'mColor' symbol was defined without an explicit "As" clause.
		Dim mColor As Object = Nothing
		' UPGRADE_INFO (#0561): The 'w' symbol was defined without an explicit "As" clause.
		Dim w As Object = Nothing
		' UPGRADE_INFO (#0561): The 'h' symbol was defined without an explicit "As" clause.
		Dim h As Object = Nothing
		' UPGRADE_INFO (#0561): The 'x2' symbol was defined without an explicit "As" clause.
		Dim x2 As Object = Nothing
		' UPGRADE_INFO (#0561): The 'y2' symbol was defined without an explicit "As" clause.
		Dim y2 As Object = Nothing
		' UPGRADE_INFO (#0561): The 'mresult' symbol was defined without an explicit "As" clause.
		Dim mresult As Object = Nothing
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.ScaleMode'. Consider using the GetDefaultMember6 helper method.
		origMode = inObj.ScaleMode
		inObj.ScaleMode = VBRUN.ScaleModeConstants.vbPixels
		
		If inBold = True And inItalic = True Then 
			L.lfFaceName = inFontName & Space(1) & "Bold" & Space(1) & "Italic" & Chr6(0) ' Must be null terminated
		ElseIf inBold = True And inItalic = False Then 
			L.lfFaceName = inFontName & Space(1) & "Bold" & Chr6(0)
		ElseIf inBold = False And inItalic = True Then 
			L.lfFaceName = inFontName & Space(1) & "Italic" & Chr6(0)
		Else
			L.lfFaceName = inFontName & Chr6(0)
		End If
		
		L.lfEscapement = 0
		L.lfHeight = inFontSize * -20 / Screen6.TwipsPerPixelY
		mFont = CreateFontIndirect(L)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.hdc'. Consider using the GetDefaultMember6 helper method.
		mPrevFont = SelectObject(inObj.hdc, mFont)
		
		inObj.CurrentX = X
		inObj.CurrentY = Y
		Select Case SolidClr
		Case 1
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mColor'. Consider using the SetDefaultMember6 helper method.
			mColor = VBRUN.ColorConstants.vbRed
		Case 2
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mColor'. Consider using the SetDefaultMember6 helper method.
			mColor = VBRUN.ColorConstants.vbGreen
		Case 3
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mColor'. Consider using the SetDefaultMember6 helper method.
			mColor = VBRUN.ColorConstants.vbBlue
		Case 4
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mColor'. Consider using the SetDefaultMember6 helper method.
			mColor = VBRUN.ColorConstants.vbBlack
		End Select
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
		inObj.ForeColor = mColor
		inObj.PrintLine(inText)
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'x2'. Consider using the SetDefaultMember6 helper method.
		x2 = X: ' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'y2'. Consider using the SetDefaultMember6 helper method.
		y2 = Y
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'w'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.ScaleWidth'. Consider using the GetDefaultMember6 helper method.
		For w = X To inObj.ScaleWidth - 1
			' Assume a height which will not intrude into text of next line
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'h'. Consider using the GetDefaultMember6 helper method.
			For h = Y To (Y + 50)
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.Point(w, h)'. Consider using the GetDefaultMember6 helper method.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
				If inObj.Point(w, h) = mColor Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'w'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
					If w > x2 Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'w'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'x2'. Consider using the SetDefaultMember6 helper method.
						x2 = w
					End If
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'h'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y2'. Consider using the GetDefaultMember6 helper method.
					If h > y2 Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'h'. Consider using the GetDefaultMember6 helper method.
						' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'y2'. Consider using the SetDefaultMember6 helper method.
						y2 = h
					End If
				End If
			Next
		Next
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'interval'. Consider using the SetDefaultMember6 helper method.
		interval = Int((x2 - X) \ 255)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'interval'. Consider using the GetDefaultMember6 helper method.
		If interval = 0 Then 
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'interval'. Consider using the SetDefaultMember6 helper method.
			interval = 1
		End If
		
		Select Case inDirection
		Case 0 ' Left to right
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
			For i = X To x2
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'interval'. Consider using the GetDefaultMember6 helper method.
				k = 255 - (i - X) * interval
				If k < 0 Then 
					k = 0
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y2'. Consider using the GetDefaultMember6 helper method.
				For j = Y To y2
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.Point(i, j)'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
					If inObj.Point(i, j) = mColor Then 
						Select Case SolidClr
						Case 1
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(k, 0, 0))
						Case 2
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(0, k, 0))
						Case 3
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(0, 0, k))
						Case 4
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(255 - k, 255 - k, 255 - k))
						End Select
					End If
				Next
			Next
		Case 1 ' Right to left
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
			For i = x2 To X Step -1
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'interval'. Consider using the GetDefaultMember6 helper method.
				k = (i - X) * interval
				If k > 255 Then 
					k = 255
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y2'. Consider using the GetDefaultMember6 helper method.
				For j = Y To y2 + 10
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.Point(i, j)'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
					If inObj.Point(i, j) = mColor Then 
						Select Case SolidClr
						Case 1
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(k, 0, 0))
						Case 2
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(0, k, 0))
						Case 3
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(0, 0, k))
						Case 4
							inObj.PSet(VBRUN.GraphicsOptions.None, i + t, j, RGB(255 - k, 255 - k, 255 - k))
						End Select
					End If
				Next
			Next
			
		Case 2 ' Top down
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y2'. Consider using the GetDefaultMember6 helper method.
			For i = Y To y2
				k = 255 - ((i - Y) * 8) ' 8 is arbitrarily set,.e.g. can be 6 or 10
				If k < 0 Then 
					k = 0
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
				For j = X To x2
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.Point(j, i)'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
					If inObj.Point(j, i) = mColor Then 
						Select Case SolidClr
						Case 1
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(k, 0, 0))
						Case 2
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(0, k, 0))
						Case 3
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(0, 0, k))
						Case 4
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(255 - k, 255 - k, 255 - k))
						End Select
					End If
				Next
			Next
			
		Case 3 ' Bottom up
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'y2'. Consider using the GetDefaultMember6 helper method.
			For i = y2 To Y Step -1
				k = (i - Y) * 10
				If k > 255 Then 
					k = 255
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'x2'. Consider using the GetDefaultMember6 helper method.
				For j = X To x2
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.Point(j, i)'. Consider using the GetDefaultMember6 helper method.
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'mColor'. Consider using the GetDefaultMember6 helper method.
					If inObj.Point(j, i) = mColor Then 
						Select Case SolidClr
						Case 1
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(k, 0, 0))
						Case 2
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(0, k, 0))
						Case 3
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(0, 0, k))
						Case 4
							inObj.PSet(VBRUN.GraphicsOptions.None, j, i + t, RGB(255 - k, 255 - k, 255 - k))
						End Select
					End If
				Next
			Next
		End Select
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'inObj.hdc'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mresult'. Consider using the SetDefaultMember6 helper method.
		mresult = SelectObject(inObj.hdc, mPrevFont)
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'mresult'. Consider using the SetDefaultMember6 helper method.
		mresult = DeleteObject(mFont)
		inObj.ScaleMode = origMode
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		Exit Sub
		
errHandler:
		inObj.ScaleMode = origMode
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		MsgBox6("GradientText")
	End Sub

End Class
