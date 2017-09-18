' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Player

	Private tictac As Boolean
	Private pus As Boolean
	Public mediafile As String = ""
	Public MainRGN As Integer
	Private loc As Integer
	Private VolTimer As Short
	Private STT As String = ""
	Private STL As Single
	Private Midi As Boolean
	Public PLSong As Short
	
	Private Sub BR_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles BR.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Private Sub Close_Click() Handles Close_Renamed.Click
		Application.Exit(): End
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		
		If MnuOntop.Checked Then 
			SetWindowPos(Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE)
		Else
			SetWindowPos(Me.hWnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE)
		End If
	End Sub

	Private Sub Form_DblClick() Handles MyBase.DblClick
		'    Image1.Visible = Not Image1.Visible
		'    If (PlayList.Visible) Then PlayList.PicMMask.Visible = Image1.Visible
		'    Label3.Visible = Not Image1.Visible
	End Sub

	Private Sub Form_Deactivate() Handles MyBase.Deactivate
		If PlayList.Visible And Not PlayList.Docked Then  PlayList.Visible = Me.WindowState = FileAttribute.Normal
	End Sub

	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		If KeyCode = 32 Then  play_Click()
		If slider1.Visible Then 
			If KeyCode = 39 Then 
				loc = FileLocation() + Percent(FileLength(), 5)
				If loc > FileLength() Then  loc = FileLength()
				If Imgpus.Visible Then 
					Call mciSendString("play myfile from " & loc, 0%, 0, 0)
				Else
					Call mciSendString("seek myfile to " & loc, 0%, 0, 0)
				End If
			End If
			If KeyCode = 37 Then 
				loc = FileLocation() - Percent(FileLength(), 5)
				If loc < 0 Then  loc = 0
				If Imgpus.Visible Then 
					Call mciSendString("play myfile from " & loc, 0%, 0, 0)
				Else
					Call mciSendString("seek myfile to " & loc, 0%, 0, 0)
				End If
			End If
		End If
		If KeyCode = 38 Then  VolUp(): ShowVol()
		If KeyCode = 40 Then  VolDown(): ShowVol()
		DoEvents6()
		'Debug.Print KeyCode
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim WindowRegion As Integer
		Dim CMD As String = ""
		Dim CheckExt As Boolean
		Dim Files As New Collection
		' àúçåì úéáú äúîåðä äîëéìä àú äúîåðä
		'With picMainSkin
		'    .ScaleMode = vbPixels
		'    .AutoRedraw = True
		'    .AutoSize = True
		'    .BorderStyle = vbBSNone
		'End With
		'MainRGN = MakeRegion(picMainSkin)
		'Me.Width = picMainSkin.Width
		'Me.Height = picMainSkin.Height
		
		' ÷øéàä ìôåð÷öéä ìéöéøú äàæåø áöåøú äúîåðä
		'WindowRegion = MakeRegion(picMainSkin)
		' òãëåï àæåø äèåôñ ìàæåø äðåöø
		'SetWindowRgn Me.hWnd, WindowRegion, True
		' àúçåì ëììé ùì äèåôñ
		'Me.DrawMode = vbCopyPen: Me.Visible = True: Me.Caption = Me.Caption
		Load6(PlayList)
		shapemain(Me)
		With picPlaySkin
			.ScaleMode = VBRUN.ScaleModeConstants.vbPixels
			.AutoRedraw = True
			.AutoSize = True
			.BorderStyle = VBRUN.FormBorderStyleConstants.vbBSNone
		End With
		
		WindowRegion = MakeRegion(picPlaySkin)
		SetWindowRgn(play.hWnd, WindowRegion, True)
		' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
		play.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
		play.Visible = True
		With picPauseSkin
			.ScaleMode = VBRUN.ScaleModeConstants.vbPixels
			.AutoRedraw = True
			.AutoSize = True
			.BorderStyle = VBRUN.FormBorderStyleConstants.vbBSNone
		End With
		
		WindowRegion = MakeRegion(picPauseSkin)
		SetWindowRgn(Pause.hWnd, WindowRegion, True)
		' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
		Pause.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
		Pause.Visible = True
		
		WindowRegion = MakeRegion(PicPlSkin)
		SetWindowRgn(PL.hWnd, WindowRegion, True)
		' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
		PL.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
		PL.Visible = True
		
		WindowRegion = MakeRegion(PicBRSkin)
		SetWindowRgn(BR.hWnd, WindowRegion, True)
		' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
		BR.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
		BR.Visible = True
		Call mciSendString("close myfile", 0%, 0, 0) ', , "Clearing memory"
		GetCMDFiles()
		'CMD = Command
		'MsgBox CMD
		'If CMD <> "" Then
		'    On Error Resume Next
		'    CMD = Command
		'    MsgBox CMD
		'    If CMD <> "" Then
		'        MsgBox LCase(Right(Dir(CMD), 4))
		'        CheckExt = LCase(Right(Dir(CMD), 4)) = ".mp3" Or LCase(Right(Dir(CMD), 4)) = ".rmi" Or LCase(Right(Dir(CMD), 4)) = ".mid" Or LCase(Right(Dir(CMD), 4)) = ".wav"
		'        If CheckExt = True Then OpenFile Command$, CMD
		'    End If
		'MsgBox UBound(LstData)
		Show()
		If PlayList.lstPL.ListCount > 0 Then 
			mediafile = LstData(0)
			OpenFile(LstData(0), Dir6(LstData(0)))
			PLSong = 1
			PlayList.lstPL.ListIndex = 0
			play_Click()
		End If
		
	End Sub

	Private Sub Form_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseDown
		ReleaseCapture()
		SendMessage(Me.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0%)
	End Sub

	Private Sub BR_Click() Handles BR.Click
		Dim sFile As String = ""
		Dim i As Integer
		Dim DirectoryName As String = ""
		Dim FileNames() As String
		Dim sTemp As String = ""
		Dim j As Integer
		'    PlayList.lstPL.Clear
		'    PlayList.lstPL.AddItem ""
		'
		sFile = OpenDlg(Me.hWnd, "MP3 Files(*.mp3)|*.mp3|WAVE Files(*.wav)|*.wav|MIDI Files(*.mid; *.rmi)|*.mid;*.rmi", , , True)
		If sFile <> "?" Then 
			sFile = UnSpace(sFile)
			PlayList.lstPL.Clear()
			' ëòú îäîçøåæú äîåçæøú îúéáú äãéàìåâ éù ìäåöéà
			' àú ùîåú ä÷áöéí
			For i = 1 To Len6(sFile)
				If Mid(sFile, i, 1) = Chr6(0) Or i = Len6(sFile) Then  ' A sample by Yaniv Drukman
					If DirectoryName = "" And i <> Len6(sFile) Then 
						' ùîéøú ùí äñôøéä áä ðîöàéí ä÷áöéí
						DirectoryName = sTemp
						' áãé÷ä äàí öøéê ìäåñéó ìùí äñôøéä ñìàù áñåó
						If VB.Right(DirectoryName, 1) <> "\" Then  DirectoryName = DirectoryName & "\"
						sTemp = ""
						' áî÷øä ùäîùúîù áçø ø÷ á÷åáõ àçã
					ElseIf DirectoryName = "" Then 
						On Error Resume Next 
						mediafile = sFile
						PlayList.AddPLItem(sFile)
						PLSong = 1 'PlayList.lstPL.ListCount
						OpenFile(mediafile, sFile)
						
					Else
						If i = Len6(sFile) Then  sTemp &= Mid(sFile, i, 1)
						j += 1
						' ùîéøú ùîåú ä÷áöéí áîòøê ãéðîé
						ReDim Preserve FileNames(j)
						FileNames(UBound6(FileNames)) = sTemp
						sTemp = ""
						' äåñôú ùîåú ä÷áöéí ìúéáú øùéîä
						PlayList.AddPLItem(FileNames(UBound6(FileNames)))
						' èòéðú äúîåðä áèåôñ úöåâä
						On Error Resume Next 
						'                frmPicture.Caption = FileNames(UBound(FileNames))
					End If
				Else
					sTemp &= Mid(sFile, i, 1)
				End If
			Next
			If j > 0 Then 
				PLSong = 1
				mediafile = FileNames(1)
				OpenFile(mediafile, FileNames(1))
			End If
		End If
		
	End Sub

	Public Sub Form_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseUp
		If Button = 2 Then 
			MnuInfo.Enabled = mediafile <> "" And Midi = False
			MnuClose.Enabled = mediafile <> ""
			MnuPlay.Enabled = MnuClose.Enabled
			MnuStop.Enabled = FileLocation() > 0 Or FileLocation() = 0 And Imgpus.Visible = True
			MnuShowPL.Checked = PlayList.Visible
			PopupMenu(Mainmenu)
		End If
	End Sub

	Public Sub Form_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.OLEDragDrop
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			'If LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mp3" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mid" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".rmi" Then
			mediafile = Data.Files(1)
			PlayList.lstPL.Clear()
			PlayList.AddPLItem(Data.Files(1))
			PLSong = PlayList.lstPL.ListCount - 1
			OpenFile(Data.Files(1), Dir6(Data.Files(1)))
			'Else
			'    MsgBox "Use only mp3 files", vbCritical
			'End If
		End If
	End Sub

	Private Sub Form_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single, ByRef State As Short) Handles MyBase.OLEDragOver
		Dim CheckExt As Boolean
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			' áãé÷ä äàí äîéãò îä÷åáõ äåà îäñåâ äøöåé
			CheckExt = LCase(VB.Right(Dir6(Data.Files(1)), 4)) = ".mp3" Or LCase(VB.Right(Dir6(Data.Files(1)), 4)) = ".rmi" Or LCase(VB.Right(Dir6(Data.Files(1)), 4)) = ".mid" Or LCase(VB.Right(Dir6(Data.Files(1)), 4)) = ".wav"
			Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy And Effect
			If Data.Files.Count = 1 And CheckExt Then  Exit Sub
		End If
		' àí äîéãò äåà îäñåâ äøöåé àæ àì úàôùø äùìëä
		Effect = VBRUN.OLEDropEffectConstants.vbDropEffectNone
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Application.Exit(): End
	End Sub

	Private Sub Minimize_Click() Handles Minimize.Click
		Me.WindowState = VBRUN.FormWindowStateConstants.vbMinimized
	End Sub

	Private Sub MnuBR_Click() Handles MnuBR.Click
		BR_Click()
	End Sub

	Public Sub MnuClose_Click() Handles MnuClose.Click
		Pause_Click()
		'Timer1 = False
		Call mciSendString("close myfile", 0%, 0, 0)
		Ticker.Left = 525 + 30
		Label1.Left = 0
		Label1.Caption = "No file loaded"
		Label2.Caption = ""
		STT = "No file loaded"
		STL = 0
		mediafile = ""
		Midi = False
	End Sub

	Private Sub MnuInfo_Click() Handles MnuInfo.Click
		Dim msg As String = ""
		Dim md As String = ""
		Dim mp32 As New MP3Tag(True)
		mp32 = GetMP3Info(mediafile).Clone()
		If UnSpace(mp32.Title.Value) <> "" Then  msg = msg & "Title: " & UnSpace(mp32.Title.Value) & ControlChars.CrLf
		If UnSpace(mp32.Artist.Value) <> "" Then  msg = msg & "Artist: " & UnSpace(mp32.Artist.Value) & ControlChars.CrLf
		If UnSpace(mp32.Album.Value) <> "" Then  msg = msg & "Album: " & UnSpace(mp32.Album.Value) & ControlChars.CrLf
		If UnSpace(mp32.Year.Value) <> "" Then  msg = msg & "Year: " & UnSpace(mp32.Year.Value) & ControlChars.CrLf
		
		md = Getmp3data(mediafile)
		If md <> "" Then  msg &= md
		
		If UnSpace(mp32.Comments.Value) <> "" Then  msg = msg & ControlChars.CrLf & "Comment: " & UnSpace(mp32.Comments.Value)
		
		MsgBox6(msg, MsgBoxStyle.Information, "MP3\Time Information")
	End Sub

	Private Sub MnuOntop_Click() Handles MnuOntop.Click
		MnuOntop.Checked = Not MnuOntop.Checked
		Form_Activate()
		If MnuOntop.Checked And PlayList.Visible Then  SetWindowPos(PlayList.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE)
	End Sub

	Private Sub MnuShowPL_Click() Handles MnuShowPL.Click
		MnuShowPL.Checked = Not MnuShowPL.Checked
		PL_Click()
	End Sub

	Private Sub Pause_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles Pause.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Private Sub Picvol_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles Picvol.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Private Sub Picvol_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picvol.MouseDown
		If X < 0 Then  X = 0
		If X > Picvol.Width Then  X = Picvol.Width - 8
		If Button = 1 Then 
			SetVol(Percent(100, X / (slider1.Width / 100)), Midi)
			Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
			Label1.Caption = "Volume: " & GetVol(Midi) & "%"
			VolTimer = 1
		End If
	End Sub
	
	Private Sub Picvol_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picvol.MouseMove
		Picvol_MouseDown(Button, Shift, X, Y)
	End Sub

	Public Sub PL_Click() Handles PL.Click
		Dim WindowRegion As Integer
		Load6(PlayList)
		If PlayList.Visible Then 
			PlayList.Hide()
		Else
			PlayList.Show(, Me)
		End If
		'PlayList.Visible = Not PlayList.Visible
		'
		'SetWindowRgn Me.hWnd, MainRGN, True
		If Not PlayList.Visible Then 
			'WindowRegion = MakeRegion(picMainSkin)
			'SetWindowRgn Me.hWnd, WindowRegion, True
			shapemain(Me)
		Else
			If PlayList.Docked Then  PlayList.Dock()
		End If
		'SetWindowRgn Me.hWnd, MainRGN, True
		'    PlayList.Docked = True
		'    If PlayList.Docked Then
		'        If PlayList.Visible Then
		'            SetWindowRgn Me.hWnd, Bigrgn, True
		'            SetParent PlayList.hWnd, Player.hWnd
		'            PlayList.Dock
		'        Else
		'            SetWindowRgn Me.hWnd, MainRgn, True
		'        End If
		'    End If
	End Sub

	Private Sub LblTime_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles LblTime.MouseDown
		Form_MouseDown(Button, Shift, X, Y)
	End Sub

	Private Sub LblTime_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles LblTime.MouseUp
		Form_MouseUp(Button, Shift, X, Y)
	End Sub

	Private Sub LblTime_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles LblTime.OLEDragDrop
		Form_OLEDragDrop(Data, Effect, Button, Shift, X, Y)
	End Sub

	Private Sub LblTime_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single, ByRef State As Short) Handles LblTime.OLEDragOver
		Form_OLEDragOver(Data, Effect, Button, Shift, X, Y, State)
	End Sub

	Private Sub MnuAbout_Click() Handles MnuAbout.Click
		MsgBox6("Program made by avba0 and Darkstorm!" & ControlChars.CrLf & "Beta stage, v" & App6.Major & "." & App6.Minor & "." & App6.Revision & ControlChars.CrLf & "Copyright © 2005" & ControlChars.CrLf & ControlChars.CrLf & "Main Programmer: Netanel Gabbay (VB)" & ControlChars.CrLf & "Software Design: Moshe Pasker", MsgBoxStyle.Information, "VB MP3 Player v0.1.7")
	End Sub

	Private Sub MnuPlay_Click() Handles MnuPlay.Click
		play_Click()
	End Sub

	Private Sub MnuStop_Click() Handles MnuStop.Click
		Pause_Click()
	End Sub

	Private Sub Pause_Click() Handles Pause.Click
		If MnuPlay.Enabled = False And mediafile = "" Then  Beep()
		Call mciSendString("stop myfile", 0%, 0, 0) ', , "mci: stop"
		Call mciSendString("seek myfile to 0", 0%, 0, 0) ', , "mci: move to 0"
		Imgpus.Visible = False
		MnuPlay.Caption = "Play"
		slider1.Visible = False
		slider2.Visible = False
		slider2.Width = 0
		pus = False
		play.ToolTipText = MnuPlay.Caption
		LblTime.ToolTipText = ""
	End Sub

	Private Sub Pause_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Pause.MouseDown
		ImgPause.Visible = True
	End Sub

	Private Sub Pause_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Pause.MouseUp
		ImgPause.Visible = False
	End Sub

	Private Sub Imgpus_Click() Handles Imgpus.Click
		play_Click()
	End Sub

	Private Sub PL_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles PL.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Public Sub play_Click() Handles play.Click
		If MnuPlay.Enabled = False Then  Beep()
		Dim retval As Object = Nothing
		'    Static NotFirstTime As Boolean
		If Not pus Then 
			retval = mciSendString("play myfile from " & FileLocation(), 0%, 0, 0)
			If retval = 0 Then  MnuPlay.Caption = "Pause"
			LblTime.ToolTipText = TimeString(FileLength() / 1000)
			'MsgBox retval, , "mci: play"
		Else
			retval = mciSendString("stop myfile", 0%, 0, 0)
			If retval = 0 Then  MnuPlay.Caption = "Play"
			LblTime.ToolTipText = TimeString(FileLength() / 1000)
			'MsgBox retval, , "mci: pause"
		End If
		If retval = 0 Then 
			slider1.Visible = True
			slider2.Visible = True
			pus = Not pus
		End If
		'If FileLocation <> 0 Or NotFirstTime = False Then
		Imgpus.Visible = pus
		'End If
		'NotFirstTime = False
		play.ToolTipText = MnuPlay.Caption
	End Sub

	Private Sub play_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles play.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Private Sub play_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles play.MouseDown
		ImgPlay.Visible = True
		Imgprpus.Visible = pus
	End Sub

	Private Sub play_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles play.MouseUp
		ImgPlay.Visible = False
		Imgprpus.Visible = False
	End Sub

	Private Sub Slider1_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles slider1.MouseUp
		'MsgBox X
		If X < 0 Then  X = 0
		If X > slider1.Width Then  X = slider1.Width - 8
		slider2.Width = X + 15 ': Label3 = Percent(FileLength, X / (slider1.Width / 100)) & "/" & FileLength  '"%" & X / (slider1.Width / 100)
		'If MIDI Then: Call mciSendString("stop myfile", 0&, 0, 0)
		If pus Then 
			'If MIDI Then
			Call mciSendString("play myfile from " & Percent(FileLength(), X / (slider1.Width / 100)), 0%, 0, 0)
			'Else
			'    Call mciSendString("play myfile", 0&, 0, 0)
			'End If
		Else
			Call mciSendString("seek myfile to " & Percent(FileLength(), X / (slider1.Width / 100)), 0%, 0, 0) ', , "mci: move to 0"
		End If
	End Sub

	Private Sub pl_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles PL.MouseDown
		ImgPL.Visible = True
	End Sub

	Private Sub pl_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles PL.MouseUp
		ImgPL.Visible = False
		
	End Sub

	Private Sub BR_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles BR.MouseDown
		ImgBR.Visible = True
	End Sub

	Private Sub BR_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles BR.MouseUp
		ImgBR.Visible = False
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		If STT = "" Then  STT = Label1.Caption
		'If Label1 = "No file loaded" Then STT = Label1
		If VolTimer = 50 Then 
			VolTimer = 0
			Picvol.Visible = False
			If STT <> "No file loaded" Then 
				Label2.Visible = True
				Ticker.Left = 1125
			Else
				Ticker.Left = 525 + 30
			End If
			Timer1.Interval = 250
			Label1.Caption = STT
			Label1.Left = STL
		End If
		If VolTimer > 0 Then 
			If ImgPlus.Visible Then 
				'If GetVol(False) < 100 Then SetVol GetVol(False) + 1, False
				'Label1 = "Volume: " & GetVol(False) & "%"
				'Lblvol.Left = Percent(Picvol.Width, GetVol(False)) - (Lblvol.Width \ 2)
				VolUp()
				VolTimer = 1
			ElseIf ImgMin.Visible Then 
				'If GetVol(False) > 0 Then SetVol GetVol(False) - 1, False
				'Label1 = "Volume: " & GetVol(False) & "%"
				'Lblvol.Left = Percent(Picvol.Width, GetVol(False)) - (Lblvol.Width \ 2)
				VolDown()
				VolTimer = 1
			End If
			VolTimer += 1
			Exit Sub
		End If
		STL = Label1.Left
		STT = Label1.Caption
		If STT = "No file loaded" Then  Exit Sub
		If slider1.Visible Then 
			LblTime.Caption = TimeString(FileLocation() \ 1000)
			On Error Resume Next 
			slider2.Width = Percent(slider1.Width, FileLocation() \ (FileLength() \ 100))
			If Imgpus.Visible = True And FileLocation() = FileLength() Then 
				Debug.WriteLine(PlayList.lstPL.ListCount)
				If PlayList.lstPL.ListCount > 1 And Not PLSong = PlayList.lstPL.ListCount - 0 Then 
					Label1.Visible = False
					Label2.Visible = False
					mediafile = LstData(PLSong)
					OpenFile(LstData(PLSong), Dir6(LstData(PLSong)))
					PLSong += 1
					PlayList.lstPL.ListIndex = PLSong - 1
					play_Click()
				Else
					Pause_Click()
				End If
			End If
		Else
			LblTime.Caption = TimeString(FileLength() \ 1000)
		End If
		'If tictac = True Then: If Label1.Left > Label2.Left Then tictac = False
		If tictac = False Then 
			Label1.Left -= 120
			Label2.Left = Label1.Left + Label1.Width + 0 '15 * 15
			If -Label1.Left >= Label1.Width Then  tictac = Not tictac: Label1.Left = Label2.Left + Label1.Width + 15 * 0
			'Label2.Left = Ticker.Width
		Else
			Label2.Left -= 120
			Label1.Left = Label2.Left + Label1.Width + 15 * 0
			If -Label2.Left >= Label2.Width Then  tictac = Not tictac: Label2.Left = Label1.Left + Label1.Width ' Label1.Left = Ticker.Width
		End If
	End Sub

	Public Sub OpenFile(ByRef FileName As String, ByRef FileTitle As String)
		Dim Title As String = ""
		Dim Artist As String = ""
		Dim Album As String = ""
		Dim Year As String = ""
		Dim mp32 As New MP3Tag(True)
		Dim AudioType As String = ""
		mp32 = GetMP3Info(FileName).Clone()
		If mediafile = "" Then  GoTo err
		Timer1.Enabled = False
		MnuInfo.Enabled = mediafile <> ""
		MnuClose.Enabled = mediafile <> ""
		MnuPlay.Enabled = MnuClose.Enabled
		If UnSpace(mp32.Title.Value) <> "" Then  Title = " - " & UnSpace(mp32.Title.Value)
		If UnSpace(mp32.Artist.Value) <> "" Then  Artist = " \\ Artist: " & UnSpace(mp32.Artist.Value)
		If UnSpace(mp32.Album.Value) <> "" Then  Album = " \\ Album: " & UnSpace(mp32.Album.Value)
		If UnSpace(mp32.Year.Value) <> "" Then  Year = " \\ Year: " & UnSpace(mp32.Year.Value)
		Ticker.Left = 525 + 30
		Label1.Left = 0
		DoEvents6()
		LblTime.Caption = "" '' False
		Label1.Visible = True
		Label2.Caption = ""
		Label1.Caption = "Opening..."
		If slider1.Visible Then  Pause_Click()
		Midi = LCase(VB.Right(FileName, 4)) = ".mid" Or LCase(VB.Right(FileName, 4)) = ".rmi"
		Call mciSendString("close myfile", 0%, 0, 0)
		DoEvents6()
		If Not LCase(VB.Right(FileName, 4)) = ".wav" Then  AudioType = " type MpegVideo"
		Call mciSendString("open " & Chr6(34) & FileName & Chr6(34) & AudioType & " alias myfile", 0%, 0, 0) ', , "Open file:" & mediafile
		LblTime.Caption = TimeString(FileLength() \ 1000)
		Label1.Left = 15 * 45
		Label1.Caption = "File: " & FileTitle & Title
		Label1.Caption &= Album
		Label1.Caption &= Artist
		Label1.Caption &= Year
		Label1.Caption &= "    >>>>    "
		Label2.Caption = Label1.Caption
		Label2.Top = Label1.Top
		Label2.Left = Label1.Width
		Ticker.Left = 1125
		slider2.Width = 0
		tictac = False
		Label2.Visible = True
		
		Timer1.Enabled = True
err:
	End Sub

	Private Sub VOL_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles VOL.KeyDown
		Form_KeyDown(KeyCode, Shift)
	End Sub

	Private Sub VOL_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles VOL.MouseDown
		'Beep
		If Button = VBRUN.MouseButtonConstants.vbLeftButton And Y <= ImgPlus.Width Then 
			If X < ImgMin.Left Then 
				VolUp()
				ImgPlus.Visible = True
				ImgMin.Visible = False
			Else
				'Ticker.Visible = False
				'Label1.Left = 30
				'Ticker.Left = 525 + 30
				'Picvol.Visible = True
				'Label2.Visible = False
				'VolTimer = 1
				' Ticker.Visible = True
				'Timer1.Interval = 10
				'Timer1 = True
				VolDown()
				ImgPlus.Visible = False
				ImgMin.Visible = True
			End If
			ShowVol()
		End If
	End Sub
	
	'            SetVol GetVol(False) - 1, False
	'            Label1 = "Volume: " & GetVol(False)
	
	Private Sub VOL_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles VOL.MouseUp

		'    If Button = vbLeftButton And Y <= ImgPlus.Width Then
		'        If X < ImgMin.Left Then
		
		'        Else
		'        End If
		'    End If
		ImgPlus.Visible = False
		ImgMin.Visible = False
		
	End Sub

	Private Sub VolUp()
		If GetVol(Midi) < 100 Then  SetVol(GetVol(Midi) + 1, Midi)
		Label1.Caption = "Volume: " & GetVol(Midi) & "%"
		Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
	End Sub

	Private Sub VolDown()
		If GetVol(Midi) > 0 Then  SetVol(GetVol(Midi) - 1, Midi)
		Label1.Caption = "Volume: " & GetVol(Midi) & "%"
		Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
	End Sub

	Private Sub ShowVol()
		Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
		Ticker.Visible = False
		Label1.Left = 25
		Ticker.Left = 525 + 30
		Picvol.Visible = True
		Label2.Visible = False
		VolTimer = 1
		Ticker.Visible = True
		Timer1.Interval = 50
		Timer1.Enabled = True
	End Sub

	Private Function GetCMDFiles() As Object ' As Collection
		Dim CMD As String = ""
		Dim Result As String = ""
		Dim i As Short
		'Dim Files As New Collection
		CMD = Command()
		If VB.Right(CMD, 1) = Chr6(34) Then  CMD = VB.Left(CMD, Len6(CMD) - 1)
		If VB.Left(CMD, 1) = Chr6(34) Then  CMD = VB.Right(CMD, Len6(CMD) - 1)
		For i = 1 To Len6(CMD)
			i = InStr(i, CMD, ":")
			Result = ""
			If InStr(i + 1, CMD, ":") Then 
				Do Until i = InStr(i + 1, CMD, ":") - 1
					Result = Result & Mid(CMD, i - 1, 1)
					i += 1
				Loop
				If VB.Right(Result, 1) = Chr6(34) Then  Result = VB.Left(Result, Len6(Result) - 1)
				If VB.Right(Result, 2) = Chr6(34) & Chr6(32) Then  Result = VB.Left(Result, Len6(Result) - 2)
				'Files.Add Result
				PlayList.AddPLItem(Result)
			Else
				Result = Result & Mid(CMD, i - 1, Len6(CMD))
				'Files.Add Result
				PlayList.AddPLItem(Result)
				Exit For
			End If
		Next
	End Function

End Class
