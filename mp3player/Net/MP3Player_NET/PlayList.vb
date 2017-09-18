' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class PlayList

	Public Docked As Boolean
	Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	
	Public Shadows Sub Dock()
		'comb = MakeRegion(Player.picMainSkin)
		'WindowRegion = MakeRegion(PlayList.PicMMask)
		'OffsetRgn WindowRegion, -5, 168
		'CombineRgn comb, WindowRegion, comb, 2
		'SetWindowRgn Player.hWnd, comb, True
		
		'    If Docked Then
		'        SetParent Me.hWnd, 0
		'    Else
		'        SetParent Me.hWnd, Player.hWnd
		'        Move -15 * 8, 15 * 139
		'    End If
		shapebig(Player)
	End Sub

	Private Sub Close_Click() Handles Close_Renamed.Click
		Player.PL_Click()
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		PicMMask.Visible = Player.Image1.Visible
		If Player.MnuOntop.Checked Then 
			SetWindowPos(Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE)
		End If
	End Sub

	Private Sub Form_DblClick() Handles MyBase.DblClick
		Docked = Not Docked
		If Not Docked Then 
			shapemain(Player)
			SetWindowPos(Me.hWnd, 0, (Player.Left) / 15 - 5 - 15, (Player.Top) / 15 + 168 + 15, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOACTIVATE)
			SetParent(Me.hWnd, 0)
		Else
			shapebig(Player)
			SetParent(Me.hWnd, Player.hWnd)
			SetWindowPos(Me.hWnd, 0, -8, 139, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOACTIVATE)
			'Move -15 * 8, 15 * 139
		End If
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Docked = True
		shapebig(Player)
		'comb = MakeRegion(Player.picMainSkin)
		' UPGRADE_INFO (#0181): Reference to default form instance 'PlayList' was converted to Me keyword.
		WindowRegion = MakeRegion(Me.PicMMask)
		'OffsetRgn WindowRegion, -5, 168
		'CombineRgn comb, WindowRegion, comb, 2
		'SetWindowRgn Player.hWnd, comb, True
		'Dock
		'OffsetRgn WindowRegion, 5, -168
		SetWindowRgn(Me.hWnd, WindowRegion, True)
		' UPGRADE_INFO (#0181): Reference to default form instance 'PlayList' was converted to Me keyword.
		' UPGRADE_ISSUE (#1448): DrawMode property isn't supported and always returns 1-Blackness. Assigning any value other than 1 throws an exception.
		Me.DrawMode = VBRUN.DrawModeConstants.vbCopyPen
		SetParent(Me.hWnd, Player.hWnd)
		Move(-15 * 8, 15 * 139)
		WindowRegion = CreateRoundRectRgn(1, 1, Piclst.Width / 15, Piclst.Height / 15 + 0, 31, 32)
		SetWindowRgn(Piclst.hWnd, WindowRegion, True)
		For i = 1 To 0
			lstPL.AddItem("   " & CheckSize(Format6(i, "00") & ". File" & i))
		Next
		Docked = True
		PicClose.Picture = PicMMask.Picture
		
	End Sub

	Private Sub Form_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseDown
		If Not Docked Then 
			ReleaseCapture()
			SendMessage(Me.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0%)
			ReleaseCapture()
			SendMessage(Player.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0%)
			'End If
		Else
			ReleaseCapture()
			SendMessage(Player.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0%)
		End If
		'MsgBox Top
	End Sub

	Private Function CheckSize(ByRef exp As String) As String
		Dim d3 As String = ""
		lblen.Caption = exp
		Do While lblen.Width > lstPL.Width - 15 * 20
			lblen.Caption = VB.Left(lblen.Caption, Len6(lblen.Caption) - 1)
			td = "..."
		Loop
		Return lblen.Caption & td
	End Function

	Private Sub Form_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseUp
		Player.Form_MouseUp(Button, Shift, X, Y)
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

	Private Sub Form_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.OLEDragDrop
		Player.Form_OLEDragDrop(Data, Effect, Button, Shift, X, Y)
	End Sub

	Private Sub lstPL_Click() Handles lstPL.Click
		lstPL.ToolTipText = Dir6(LstData(lstPL.ListIndex))
	End Sub

	Private Sub LstPL_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstPL.OLEDragDrop
		On Error Resume Next 
		Dim CheckExt As Boolean
		For Each vFileName In Data.Files
			If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
				CheckExt = LCase(VB.Right(Dir6(vFileName), 4)) = ".mp3" Or LCase(VB.Right(Dir6(vFileName), 4)) = ".rmi" Or LCase(VB.Right(Dir6(vFileName), 4)) = ".mid" Or LCase(VB.Right(Dir6(Data.Files(1)), 4)) = ".wav"
				If CheckExt Then 
					If Dir6(CStr(vFileName)) <> "" Then 
						AddPLItem(vFileName)
						'                    lstPL.AddItem CheckSize("   " & Format(lstPL.ListCount + 1, "00") & ". " & Dir(vFileName))
						'                    LstData(lstPL.ListCount - 1) = vFileName
					End If
				Else
					If Data.Files.Count = 1 Then  MsgBox6("Unsupported file format", MsgBoxStyle.Critical)
				End If
			End If
		Next
	End Sub

	Public Sub lstPL_DblClick() Handles lstPL.DblClick
		'MsgBox
		If Dir6(LstData(lstPL.ListIndex)) <> "" Then 
			If Player.mediafile <> LstData(lstPL.ListIndex) Then 
				Player.MnuClose_Click()
				Player.mediafile = LstData(lstPL.ListIndex)
				Player.PLSong = lstPL.ListIndex + 1
				Player.OpenFile(LstData(lstPL.ListIndex), Dir6(LstData(lstPL.ListIndex)))
			End If
			Player.play_Click()
		End If
		'OpenFile Data.Files.Item(1), Dir(Data.Files.Item(1))
	End Sub

	Private Sub lstPL_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstPL.MouseDown
		'    Form_MouseDown Button, Shift, X, Y
	End Sub

	Public Sub AddPLItem(ByRef vFileName As Object)
		Dim CheckExt As Boolean = LCase(VB.Right(Dir6(vFileName), 4)) = ".mp3" Or LCase(VB.Right(Dir6(vFileName), 4)) = ".rmi" Or LCase(VB.Right(Dir6(vFileName), 4)) = ".mid" Or LCase(VB.Right(Dir6(vFileName), 4)) = ".wav"
		If CheckExt = True Then 
			lstPL.AddItem(CheckSize("   " & Format6(lstPL.ListCount + 1, "00") & ". " & Dir6(vFileName)))
			LstData(lstPL.ListCount - 1) = vFileName
		End If
	End Sub

End Class
