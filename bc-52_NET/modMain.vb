' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Structure POINTAPI

	Public X As Integer
	Public Y As Integer
End Structure

Friend Module modMain

	'-----------------------------------------------------------
	'
	'       Hagelin BC-52 Cipher Machine Simulator v3.6
	'
	'                Written by D. Rijmenants
	'
	'                       (c) 2006
	'
	'-----------------------------------------------------------

	Public Wsel(6) As Short
	Public Wpos(6) As Short
	Public Wpin(6) As String
	Public Wmax(6) As Short
	Public W_len(47) As Short
	Public BLug(32) As String
	Public Wlab(12, 47) As String
	
	Public gintLabelView(12) As Short
	Public gintBarStepping(6) As Short
	Public gstrCipherPrintWheel As String = ""
	Public W_textLabel(12) As String
	Public gblnModeCipher As Boolean
	Public gstrSpaceLetter As String = ""
	Public gintPosMemo(6) As Short
	Public gintAdvanceBar(32) As Short
	Public gintLastDialView As Short
	Public gintWheelOffset As Short
	Public gstrMachineSetup As String = ""
	Public gblnCancelSave As Boolean
	'
	Public gstrExitVal As String = ""
	'
	Public gstrInput As String = ""
	Public gstrOutput As String = ""
	Public gintAlphaWheel As Short
	Public glngGroupCount As Integer
	Public gstrCounter As Short
	Public gstrAutotype As Boolean
	Public gblnSound As Boolean
	Public gstrkeyFile As String = ""
	Public gblnKeyHasChanged As Boolean
	Public gblnFastRun As Boolean
	
	Public DialX As Object
	Public DialY As Object
	
	Public gblnHoldPins As Boolean
	Public gblnCipherBars As Boolean
	Public gblnCxType As Boolean
	Public Const DefaultSetup As String = "1616181921232325252628280102030405010X11111"
	'                            010203040506070809101112
	
	'cursor functions to move forms
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetCursorPos' unamanged method with the following .NET member(s): System.Windows.Forms.Control.MousePosition, System.Windows.Forms.Cursor.Position
	Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	Public LastPoint As POINTAPI
	Public iTPPY As Integer
	Public iTPPX As Integer
	
	'sound api
	' IGNORED: Declare Function sndPlaySound Lib "WINMM.DLL" Alias "sndPlaySoundA"  (ByVal lpszSoundName As Any, ByVal uFlags As Long) As Long
	Declare Function sndPlaySound Lib "WINMM.DLL" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
	Public Const SND_ASYNC As Short = &H1S
	' Play asynchronously
	Public Const SND_NODEFAULT As Short = &H2S
	' Don't use default sound
	Public Const SND_MEMORY As Short = &H4S
	' lpszSoundName points to a memory file
	Public Const SND_FILENAME As Integer = &H20000I
	'lpszSoundName point to FileNAme
	Public SoundBuffer As String = ""
	
	'time function
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetTickCount' unamanged method with the following .NET member(s): System.Environment.TickCount
	Public Declare Function GetTickCount Lib "kernel32" () As Integer

	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	<STAThread()> _
	Public Sub Main()
		Dim k As Short
		Dim j As Short
		Dim tmp As String = ""
		iTPPX = Screen6.TwipsPerPixelX
		iTPPY = Screen6.TwipsPerPixelY
		gblnSound = True
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Array6(4500, 4620, 4740, 4830, 4890, 4920, 4950, 4920, 4890, 4860, 4785, 4665, 4500, 4320, 4185, 4080, 3990, 3915, 3885, 3870, 3870, 3915, 3990, 4095, 4200, 4350)'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'DialX'. Consider using the SetDefaultMember6 helper method.
		DialX = Array6(4500, 4620, 4740, 4830, 4890, 4920, 4950, 4920, 4890, 4860, 4785, 4665, 4500, 4320, 4185, 4080, 3990, 3915, 3885, 3870, 3870, 3915, 3990, 4095, 4200, 4350)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Array6(3825, 3870, 3930, 4005, 4095, 4185, 4305, 4395, 4470, 4545, 4605, 4680, 4725, 4725, 4695, 4635, 4575, 4500, 4410, 4290, 4185, 4080, 3990, 3915, 3855, 3825)'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'DialY'. Consider using the SetDefaultMember6 helper method.
		DialY = Array6(3825, 3870, 3930, 4005, 4095, 4185, 4305, 4395, 4470, 4545, 4605, 4680, 4725, 4725, 4695, 4635, 4575, 4500, 4410, 4290, 4185, 4080, 3990, 3915, 3855, 3825)
		
		'define rotor labels
		'                 12345678901234567890123456789012345678901234567
		W_textLabel(1) = "ABCDEFGHIJKLMNOPQRSTUVXYZ" '25**
		W_textLabel(2) = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" '26
		W_textLabel(3) = "ABCDEFGHI.JKLMNOPQR.STUVWXYZ." '29
		W_textLabel(4) = "ABCDE.FGHIJ.KLMNOP.QRSTU.VWXYZ." '31
		W_textLabel(5) = "A.B.C.D.E.F.G.H.I.J.K.L.M.N.O.P.Q." '34**
		W_textLabel(6) = "ABC.DE.FG.HIJ.KL.MN.OPQ.RS.TU.VWX.YZ." '37
		W_textLabel(7) = "A.B.C.D.E.F.G.H.I.J.K.L.M.N.O.P.Q.R.S." '38**
		W_textLabel(8) = "AB.CD.EF.G.HI.JK.LM.N.OP.QR.ST.U.VW.XY.Z." '41
		W_textLabel(9) = "A.B.C.D.E.F.G.H.I.J.K.L.M.N.O.P.Q.R.S.T.U." '42**
		'                  12345678901234567890123456789012345678901234567
		W_textLabel(10) = "AB.C.DE.F.GH.I.JK.L.MN.O.PQ.R.ST.U.VW.X.YZ." '43
		W_textLabel(11) = "A.B.C.D.E.F.G.H.I.J.K.L.M.N.O.P.Q.R.S.T.U.V.X." '46**
		W_textLabel(12) = "AB.C.D.E.FG.H.I.J.KL.M.N.O.P.QR.S.T.U.VW.X.Y.Z." '47
		
		For k = 1 To 12
			W_len(Len6(W_textLabel(k))) = k
		Next
		
		'read setup
		gstrMachineSetup = GetSetting(App6.EXEName, "config", "setup", DefaultSetup)
		If Len6(gstrMachineSetup) <> 43 Then 
			gstrMachineSetup = DefaultSetup
			SaveSetting(App6.EXEName, "config", "setup", DefaultSetup)
		End If
		If Asc(Mid(gstrMachineSetup, 38, 1)) < 65 Or Asc(Mid(gstrMachineSetup, 38, 1)) > 90 Then 
			gstrMachineSetup = DefaultSetup
			SaveSetting(App6.EXEName, "config", "setup", DefaultSetup)
		End If
DoReload:
		'check labels
		For k = 1 To 12
			gintLabelView(k) = Val(Mid(gstrMachineSetup, (k * 2) - 1, 2))
			If gintLabelView(k) < 1 Or gintLabelView(k) > Len6(W_textLabel(k)) Then 
				'error setup
				gstrMachineSetup = DefaultSetup
				SaveSetting(App6.EXEName, "config", "setup", DefaultSetup)
				GoTo DoReload
			End If
		Next
		'check bar advancing
		For k = 13 To 17
			j = Val(Mid(gstrMachineSetup, (k * 2) - 1, 2))
			If j < 1 Or j > 32 Then 
				'error setup
				tmp = DefaultSetup
				SaveSetting(App6.EXEName, "config", "setup", DefaultSetup)
				GoTo DoReload
			Else
				gintAdvanceBar(j) = k - 11
			End If
		Next
		
		If Mid(gstrMachineSetup, 35, 1) = "1" Then  gblnCipherBars = True
		If Mid(gstrMachineSetup, 36, 1) = "1" Then  gblnHoldPins = True
		If Mid(gstrMachineSetup, 37, 1) = "1" Then  gblnCxType = True
		
		gstrSpaceLetter = Mid(gstrMachineSetup, 38, 1)
		
		For k = 39 To 43
			gintBarStepping(k - 37) = Val(Mid(gstrMachineSetup, k, 1))
		Next
		
		Load6(frmMain)
		Load6(frmClipBoard)
		Load6(frmQuick)
		Load6(frmInfo)
		Load6(frmKeySheet)
		Load6(frmKey)
		Load6(frmCustom)
		
		App6.HelpFile = App6.Path & "\BC-52.hlp"
		
		frmMain.shpDot.FillColor = FromOleColor6(RGB(166, 166, 166))
		frmMain.shpDot.BorderColor = FromOleColor6(RGB(166, 166, 166))
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DialX(0)'. Consider using the GetDefaultMember6 helper method.
		frmMain.shpDot.Left = DialX(0)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DialY(0)'. Consider using the GetDefaultMember6 helper method.
		frmMain.shpDot.Top = DialY(0)
		
		gstrCipherPrintWheel = "ZYXWVUTSRQPONMLKJIHGFEDCBA"
		gblnModeCipher = True
		gintLastDialView = 1
		
		'EXCLUDED: frmMain.Show()
		
		'get key file
		gstrkeyFile = GetSetting(App6.EXEName, "config", "key", "")
		
		If gstrkeyFile = "" Then 
			gstrkeyFile = App6.Path & "\Example Key.C52"
			MsgBox6("Example key settings are loaded!", MsgBoxStyle.Exclamation)
		End If
		
		Call LoadKeySettings(gstrkeyFile)
		
		tmp = GetSetting(App6.EXEName, "config", "fastrun", "0")
		If tmp = "0" Then 
			gblnFastRun = False
		Else
			gblnFastRun = True
		End If
		
		frmMain.Show
		
	End Sub

	Public Sub SetWheelView(ByVal wheel As Short)
		'set wheels view
		Dim k As Short
		Dim j As Short
		Dim P As Short
		Dim Lpos As Short = Wpos(wheel) + (gintLabelView(Wsel(wheel)) - 1)
		'calculatte labeling offset to pin
		If Lpos > Wmax(wheel) Then  Lpos -= Wmax(wheel)
		frmMain.lblWindow(wheel).Caption = ""
		For j = Lpos + 2 To Lpos - 2 Step -1
			If j < 1 Then 
				P = j + Wmax(wheel)
			ElseIf j > Wmax(wheel) Then 
				P = j - Wmax(wheel)
			Else
				P = j
			End If
			frmMain.lblWindow(wheel).Caption = frmMain.lblWindow(wheel).Caption & Wlab(wheel, P) & ControlChars.CrLf
		Next
		
	End Sub

	'-----------------------------key ------------------------------------
	
	Public Sub LoadKeySettings(ByVal aFile As String)
		'load key settings from "C52.dat" file
		Dim infile As Short
		Dim fileName As String = ""
		Dim tmpInput(40) As String
		Dim k As Short
		Dim j As Short
		Dim tmp As String = ""
		
		On Error GoTo errHandle 
		If aFile = "" Then  GoTo errHandle
		
		infile = FreeFile6()
		fileName = aFile
		If Dir6(fileName) = "" Then 
			'no file
			GoTo errHandle
		End If
		FileOpen6(infile, fileName, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		
		tmp = FileLineInput6(infile)
		If tmp <> "BC52SIM" Then 
			MsgBox6("Failed loading key. Unknown data format", MsgBoxStyle.Critical)
			GoTo errHandle
		End If
		
		For k = 1 To 38
			tmpInput(k) = FileLineInput6(infile)
		Next
		
		FileClose6(infile)
		'load pins
		For k = 1 To 6
			Wpin(k) = tmpInput(k)
			Wmax(k) = Len6(tmpInput(k))
			Wsel(k) = W_len(Len6(tmpInput(k)))
		Next
		
		If Wmax(1) = 47 And Wmax(2) = 47 Then 
			'CX-52 key settings
			If gblnCxType = False Then 
				MsgBox6("The loaded key settings are for a CX-52 model only." & ControlChars.CrLf & ControlChars.CrLf & "Machine settings are changed to the CX-52 model.", MsgBoxStyle.Information)
				'change setup
				Mid(gstrMachineSetup, 37, 1) = "1"
				SaveSetting(App6.EXEName, "config", "setup", gstrMachineSetup)
			End If
			gblnCxType = True
		Else
			'C-52 key settings
			If gblnCxType = True Then 
				MsgBox6("The loaded key settings are for a C-52 model only." & ControlChars.CrLf & ControlChars.CrLf & "Machine settings are changed to the C-52 model.", MsgBoxStyle.Information)
				'change setup
				Mid(gstrMachineSetup, 37, 1) = "0"
				SaveSetting(App6.EXEName, "config", "setup", gstrMachineSetup)
			End If
			gblnCxType = False
		End If
		
		'load and check lugs
		For k = 1 To 32
			If Len6(tmpInput(k + 6)) <> 6 Then  GoTo errHandle
			BLug(k) = tmpInput(k + 6)
		Next
		
		'create labels
		Call CreateLabels()
		Call resetAllWheels()
		Call MemorizeWheels()
		gblnKeyHasChanged = False
		gstrkeyFile = aFile
		
		Exit Sub
errHandle:
		FileClose6(infile)
		
		'load default settings
		
		If gblnCxType = True Then 
			'set 6 wheels with 47 pins
			Call SetCX52wheels()
			MsgBox6("Default key settings for CX-52 model are loaded!" & ControlChars.CrLf & ControlChars.CrLf & "Please set Pins and Lugs before using the CX-52", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, " BC-52")
		Else
			'set 6 different wheels
			Call SetC52wheels()
			MsgBox6("Default key settings for C-52 model are loaded!" & ControlChars.CrLf & ControlChars.CrLf & "Please set Pins and Lugs before using the C-52", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, " BC-52")
		End If
		
	End Sub

	Public Sub SaveKeySettings(ByVal aFile As String)
		'save current key settings to file
		Dim infile As Short
		Dim fileName As String = ""
		Dim tmp As String = ""
		Dim k As Short
		
		On Error GoTo errHandle 
		
		infile = FreeFile6()
		
		FileOpen6(infile, aFile, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		
		'header
		tmp = "BC52SIM"
		FilePrintLine6(infile, tmp)
		
		'save pins
		For k = 1 To 6
			tmp = Wpin(k)
			FilePrintLine6(infile, tmp)
		Next
		'save lugs
		For k = 1 To 32
			tmp = BLug(k)
			FilePrintLine6(infile, tmp)
		Next

		FileClose6(infile)
		gblnKeyHasChanged = False
		gstrkeyFile = aFile
		Exit Sub
		
errHandle:
		FileClose6(infile)
		gblnCancelSave = True
		MsgBox6("Failed saving the key settings." & ControlChars.CrLf & ControlChars.CrLf & Err.Description, MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1)
	End Sub

	Public Sub EraseStettings()
		' erase saved settings (kill "atomix.dat" file)
		Dim fileName As String = ""
		Dim infile As Short
		On Error GoTo errHandle 
		infile = FreeFile6()
		fileName = App6.Path & "\atomix.dat"
		Kill(fileName)
		Exit Sub
errHandle:
		MsgBox6("Failed deleting the Key settings." & ControlChars.CrLf & ControlChars.CrLf & Err.Description, MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1)
	End Sub

	Public Sub CreateLabels()
		'create wheel labels array for current wheels
		Dim k As Short
		Dim j As Short
		For k = 1 To 6
			For j = 1 To Wmax(k)
				If Mid(W_textLabel(Wsel(k)), j, 1) <> "." Then 
					Wlab(k, j) = Mid(W_textLabel(Wsel(k)), j, 1)
				Else
					Wlab(k, j) = Format6(j, "00")
				End If
			Next
		Next
	End Sub

	Public Sub EndProgram()
		' exit program
		Dim k As Short
		Dim retval As Short
		
		If gblnKeyHasChanged = True Then 
			retval = MsgBox6("The BC-52 key settings are changed." & ControlChars.CrLf & ControlChars.CrLf & "Do you want to save these changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
			If retval = MsgBoxResult.Cancel Then  Exit Sub
			If retval = MsgBoxResult.Yes Then 
				gblnCancelSave = False
				Call SaveFile()
				If gblnCancelSave = True Then  Exit Sub
			End If
		End If
		
		'save current key
		If gstrkeyFile <> "Untitled" Then  SaveSetting(App6.EXEName, "config", "key", gstrkeyFile)
		SaveSetting(App6.EXEName, "config", "fastrun", gblnFastRun)
		
		Unload6(frmMain)
		Unload6(frmInfo)
		Unload6(frmClipBoard)
		Unload6(frmQuick)
		Unload6(frmKeySheet)
		Unload6(frmKey)
		Unload6(frmCustom)
		
		Application.Exit(): End
	End Sub

	Public Function ReadPin(ByVal wheel As Short) As Short
		'read current pin of a wheel
		Dim PinPos As Short
		If Mid(Wpin(wheel), Wpos(wheel), 1) = "1" Then 
			Return 1
		Else
			Return 0
		End If
	End Function

	Public Sub Crypto(ByVal akey As Short)
		Dim KeyOffset As Short
		Dim KeyOut As Short
		Dim CharOut As String = ""
		Dim currPin(6) As Short
		Dim k As Short
		Dim j As Short
		Dim i As Short
		Dim barHasSlided As Boolean
		'memorize pins
		For k = 1 To 6
			currPin(k) = ReadPin(k)
		Next
		
		KeyOffset = 0
		
		'turn drum
		
		For k = 1 To 32
			i = gintAdvanceBar(k)
			barHasSlided = False
			For j = 1 To 6
				'if No pin hold, read pins settings each time
				If gblnHoldPins = False Then  currPin(j) = ReadPin(j)
				'check for sliding bars
				If Mid(BLug(k), j, 1) = "1" And currPin(j) = 1 Then 
					'pin and lug
					barHasSlided = True
					If i = 0 Then 
						'only cipher bar
						KeyOffset += 1
					Else
						'advance bar
						If gintBarStepping(i) = 1 Or gintBarStepping(i) = 3 Then  Call MoveWheel(i)
						'if gintAdvanceBar is also cipher bar +1
						If gblnCipherBars = True Then  KeyOffset += 1
					End If
					Exit For
				End If
			Next
			If barHasSlided = False Then 
				If i <> 0 Then 
					If gintBarStepping(i) = 2 Or gintBarStepping(i) = 3 Then  Call MoveWheel(i)
				End If
			End If
			If gstrAutotype = False Then  PauzeTime((10))
			SetDialView((akey + KeyOffset))
		Next
		
		Call MoveWheel(1)
		
		KeyOut = akey + KeyOffset + gintWheelOffset
DoStrip:
		If KeyOut > 26 Then  KeyOut -= 26: GoTo DoStrip
		
		'print plain and cipher output
		SetDialView((KeyOut))
		CharOut = Mid(gstrCipherPrintWheel, KeyOut, 1)
		If gblnModeCipher = False And CharOut = gstrSpaceLetter Then  CharOut = " "
		gstrInput = gstrInput & Chr6(akey + 64)
		gstrOutput &= CharOut
		
		With frmMain
			.lblInput.Caption = .lblInput.Caption & Chr6(akey + 64)
			.lblOutput.Caption &= CharOut
			
			If gblnModeCipher = True Then 
				'check for groups
				glngGroupCount += 1
				If glngGroupCount = 5 Then 
					glngGroupCount = 0
					.lblInput.Caption &= " "
					.lblOutput.Caption &= " "
				End If
			End If
			
			'check for maximum display length
			If Len6(.lblInput.Caption) > 34 Then 
				.lblInput.Caption = VB.Right(.lblInput.Caption, 34)
				.lblOutput.Caption = VB.Right(.lblOutput.Caption, 34)
			Else
			End If
			
			'set counter
			gstrCounter += 1
			If gstrCounter > 999 Then  gstrCounter = 0
			.lblCounter.Caption = Format6(gstrCounter, "000")
			
		End With
	End Sub

	Public Sub SetDialView(ByVal aLetter As Short)
		Dim sq As Single
DoStrip:
		If aLetter > 26 Then  aLetter -= 26: GoTo DoStrip
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DialX(aLetter - 1)'. Consider using the GetDefaultMember6 helper method.
		frmMain.shpDot.Left = DialX(aLetter - 1)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DialY(aLetter - 1)'. Consider using the GetDefaultMember6 helper method.
		frmMain.shpDot.Top = DialY(aLetter - 1)
		gintLastDialView = aLetter
	End Sub

	Public Sub MoveWheel(ByVal wheel As Short)
		'move a wheel
		Wpos(wheel) += 1
		If Wpos(wheel) > Wmax(wheel) Then  Wpos(wheel) -= Wmax(wheel)
		Call SetWheelView(wheel)
	End Sub

	Public Sub resetAllWheels()
		Dim k As Short
		Dim i As Short
		For k = 1 To 6
			Wpos(k) = 1 - (gintLabelView(Wsel(k)) - 1)
			If Wpos(k) < 1 Then  Wpos(k) += Wmax(k)
			Call SetWheelView(k)
		Next
	End Sub

	Public Sub AutoTyping()
		'autotyping function
		Dim tmpQuick As String = ""
		Dim tmp As Short
		Dim i As Integer
		Dim tm As Integer
		'delet all but alphabet
		tmpQuick = frmQuick.txtQuick.Text
		If tmpQuick = "" Then  Exit Sub
		gstrAutotype = True
		'select autotyping speed
		Select Case frmQuick.cmbSpeed.Text
		Case "Slow"
			tm = 2000
		Case "Normal"
			tm = 250
		Case "Fast"
			tm = 0
		End Select
		For i = 1 To Len6(tmpQuick)
			tmp = Asc(UCase(Mid(tmpQuick, i, 1)))
			If (tmp > 64 And tmp < 91) Or tmp = 32 Then 
				If gblnModeCipher = True And tmp = 32 Then  tmp = Asc(gstrSpaceLetter)
				If tmp <> 32 Then 
					PauzeTime((tm))
					If frmQuick.cmbSpeed.Text <> "Fast" Then  PlaySound((1))
					Call Crypto(tmp - 64)
				End If
			End If
			DoEvents6()
			If gstrAutotype = False Then 
				MsgBox6("Auto Typing aborted.", MsgBoxStyle.Information, " BC-52")
				Exit For
			End If
		Next
		gstrAutotype = False
	End Sub

	Public Sub PlaySound(ByVal aSound As Short)
		'play sound
		
		' UPGRADE_INFO (#0561): The 'Ret' symbol was defined without an explicit "As" clause.
		Dim Ret As Object = Nothing
		
		Select Case aSound
		Case 0
			Exit Sub
		Case 1
			If gblnSound = False Then  Exit Sub
			SoundBuffer = System.Text.Encoding.Default.GetString(LoadResData6(1, "Sounds"))
		Case 2
			If gblnSound = False Then  Exit Sub
			SoundBuffer = System.Text.Encoding.Default.GetString(LoadResData6(2, "Sounds"))
		Case 3
			SoundBuffer = System.Text.Encoding.Default.GetString(LoadResData6(3, "Sounds"))
		End Select
		
		Dim ByteSoundBuffer() As Byte

		ByteSoundBuffer = StringToByteArray6(SoundBuffer)
		
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'Ret'. Consider using the SetDefaultMember6 helper method.
		Ret = sndPlaySound(SoundBuffer, SND_NODEFAULT Or SND_MEMORY)
	End Sub

	Public Sub PauzeTime(ByVal TimeToWait As Integer)
		'make a pauze
		If gblnFastRun = True Then  Exit Sub
		Dim currTime As Integer
		Dim passedTime As Integer
		currTime = GetTickCount()
		Do
			passedTime = Abs6(GetTickCount() - currTime)
		Loop While passedTime < TimeToWait
	End Sub

	Public Sub MemorizeWheels()
		Dim k As Short
		For k = 1 To 6
			gintPosMemo(k) = Wpos(k)
		Next
	End Sub

	Public Sub SetCX52wheels()
		Dim k As Short
		For k = 1 To 6
			Wpin(k) = String6(47, "0")
		Next
		For k = 1 To 6
			Wmax(k) = Len6(Wpin(k))
			Wsel(k) = W_len(Len6(Wpin(k)))
			Wpos(k) = 1
			gintPosMemo(k) = 1
		Next
		
		Call CreateLabels()
		Call resetAllWheels()
		Call MemorizeWheels()
		
		For k = 1 To 6
			Call SetWheelView(k)
		Next
		
		'lugs
		For k = 0 To 32
			BLug(k) = "000000"
		Next
		
		gstrkeyFile = "Untitled"
		gblnKeyHasChanged = True
		MsgBox6("CX-52 model selected and all pins and lugs cleared." & ControlChars.CrLf & ControlChars.CrLf & "Please set pins and lugs before using the CX-52!", MsgBoxStyle.Exclamation)
		
	End Sub

	Public Sub SetC52wheels()
		Dim k As Short
		'set 6 different wheels
		Wpin(1) = "00000000000000000000000000000" '29
		Wpin(2) = "0000000000000000000000000000000" '31
		Wpin(3) = "0000000000000000000000000000000000000" '37
		Wpin(4) = "00000000000000000000000000000000000000000" '41
		Wpin(5) = "0000000000000000000000000000000000000000000" '43
		Wpin(6) = "00000000000000000000000000000000000000000000000" '47
		For k = 1 To 6
			Wmax(k) = Len6(Wpin(k))
			Wsel(k) = W_len(Len6(Wpin(k)))
			Wpos(k) = 1
			gintPosMemo(k) = 1
		Next
		
		Call CreateLabels()
		Call resetAllWheels()
		Call MemorizeWheels()
		
		For k = 1 To 6
			Call SetWheelView(k)
		Next
		
		'lugs
		For k = 0 To 32
			BLug(k) = "000000"
		Next
		
		gstrkeyFile = "Untitled"
		gblnKeyHasChanged = True
		MsgBox6("C-52 model selected and all pins and lugs cleared." & ControlChars.CrLf & ControlChars.CrLf & "Please set pins and lugs before using the C-52!", MsgBoxStyle.Exclamation)
		
	End Sub

	Public Sub OpenFile()
		Dim tmpfilename As String = ""
		Dim retval As Short
		
		If gblnKeyHasChanged = True Then 
			retval = MsgBox6("The BC-52 key settings are changed." & ControlChars.CrLf & ControlChars.CrLf & "Do you want to save these changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
			If retval = MsgBoxResult.Cancel Then  Exit Sub
			If retval = MsgBoxResult.Yes Then 
				Call SaveFile()
				If gblnCancelSave = True Then  Exit Sub
			End If
		End If
		
		On Error Resume Next 
		With frmMain.Dialog2
			.FileName = ""
			.DialogTitle = " Load BC-52 Key..."
			.Flags = &H1000 Or &H4
			.DefaultExt = ".C52"
			.InitDir = gstrkeyFile
			.Filter = "BC-52 Key Files (*.C52)|*.C52"
			.FilterIndex = 1
			.ShowOpen()
			If Err.Number = 32755 Or .FileName = "" Then  Exit Sub
			tmpfilename = .FileName
		End With
		
		Call LoadKeySettings(tmpfilename)
		
	End Sub

	Public Sub SaveFile()
		Dim tmpfilename As String = ""
		On Error Resume Next 
		With frmMain.Dialog2
			.FileName = CutFilePath(gstrkeyFile)
			.DialogTitle = " Save BC-52 Key..."
			.Flags = &H4 Or &H2
			.DefaultExt = ".C52"
			.InitDir = gstrkeyFile
			.Filter = "BC-52 Key Files (*.C52)|*.C52"
			.FilterIndex = 1
			.ShowSave()
			If Err.Number = 32755 Or .FileName = "" Then  gblnCancelSave = True: Exit Sub
			tmpfilename = .FileName
		End With
		
		Call SaveKeySettings(tmpfilename)
		
	End Sub

	Public Function CutFilePath(ByVal strFile As String) As String
		'returns only the filename without full path
		Dim k As Short
		Dim pos As Short
		For k = 1 To Len6(strFile)
			If Mid(strFile, k, 1) = "\" Then  pos = k
		Next
		If pos = 0 Then 
			Return strFile
		Else
			Return Mid(strFile, pos + 1)
		End If
	End Function

End Module
