' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Declare Function GetKeyboardState Lib "user32" (ByRef pbKeyState As Byte) As Integer
	Private Declare Function SetKeyboardState Lib "user32" (ByRef lppbKeyState As Byte) As Integer
	
	Private Animation As Boolean
	
	Private Sub cmdCreate_Click() Handles cmdCreate.Click
		' dynamically create a new Panel
		With StatusBar1.Panels.Add(1, "moon", "Click to start animation", MSComctlLib.PanelStyleConstants.sbrText, imgMoon(0).Picture)
			.Alignment = MSComctlLib.PanelAlignmentConstants.sbrCenter
			.AutoSize = MSComctlLib.PanelAutoSizeConstants.sbrContents
			.Tag = "Animated"
		End With
		cmdCreate.Enabled = False
	End Sub

	Private Sub StatusBar1_PanelClick(ByVal Panel As VB6Panel) Handles StatusBar1.PanelClick
		Dim s As String = ""
		Select Case Panel.Tag
		Case "Editable"
			s = InputBox6("Enter a new text for this panel", , Panel.Text)
			If Len6(s) Then  Panel.Text = s
		Case "Animated"
			Animation = Not Animation
			Timer1.Enabled = Animation
			Panel.Text = "Click to " & IIf(Animation, "stop", "start") & " animation"
		End Select
	End Sub

	Private Sub StatusBar1_PanelDblClick(ByVal Panel As VB6Panel) Handles StatusBar1.PanelDblClick
		Select Case Panel.Style
		Case MSComctlLib.PanelStyleConstants.sbrCaps
			ToggleKey(VBRUN.KeyCodeConstants.vbKeyCapital)
		Case MSComctlLib.PanelStyleConstants.sbrNum
			ToggleKey(VBRUN.KeyCodeConstants.vbKeyNumlock)
		Case MSComctlLib.PanelStyleConstants.sbrScrl
			ToggleKey(VBRUN.KeyCodeConstants.vbKeyScrollLock)
		Case MSComctlLib.PanelStyleConstants.sbrIns
			ToggleKey(VBRUN.KeyCodeConstants.vbKeyInsert)
		End Select
		StatusBar1.Refresh()
		Text1.SetFocus()
	End Sub

	Public Sub ToggleKey(ByRef vKey As VBRUN.KeyCodeConstants)
	' UPGRADE_INFO (#0551): The 'vKey' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim keys(255) As Byte
		' read the current state of the keyboard
		GetKeyboardState(keys(0))
		' toggle bit 0 of the virtual key we're interested in
		keys(vKey) = keys(vKey) Xor 1
		' enforce the new keyboard state
		SetKeyboardState(keys(0))
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		Static n As Short
		' show the next image
		StatusBar1.Panels("moon").Picture = imgMoon(n).Picture
		n = (n + 1) Mod 8
	End Sub

	Private Sub cmdProgress_Click() Handles cmdProgress.Click
		Dim v As Single
		
		MoveProgressBarIntoPanel(ProgressBar1, StatusBar1, 1)
		
		' let the progress bar grow
		For v = 1 To 100 Step 0.1
			ProgressBar1.Value = v
			DoEvents6()
		Next
		
		' restore original state
		ProgressBar1.Visible = False
		StatusBar1.Panels(1).Bevel = MSComctlLib.PanelBevelConstants.sbrInset
	End Sub

	Private Sub MoveProgressBarIntoPanel(ByRef pb As VB6ProgressBar, ByRef sb As VB6StatusBar, ByRef pnlIndex As Short)
	' UPGRADE_INFO (#0551): The 'pb' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sb' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'pnlIndex' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim deltaY As Single
		Dim pnl As VB6Panel = Nothing
		Dim y As Single
		
		' account for two pixels around each panel
		deltaY = ScaleY(2, VBRUN.ScaleModeConstants.vbPixels, VBRUN.ScaleModeConstants.vbTwips)
		pnl = sb.Panels(pnlIndex)
		pnl.Bevel = MSComctlLib.PanelBevelConstants.sbrNoBevel
		' It is necessary to evaluate the Y coordinate in this way because
		' if this routine is invoked from Form_Resize you can't rely on
		' the StatusBar's or Panel's Top property, which still has to be updated.
		y = ScaleHeight - sb.Height
		
		' Move the progress bar in position, and in front of the status bar.
		pb.Move(pnl.Left, y + deltaY, pnl.Width, StatusBar1.Height - deltaY)
		pb.Visible = True
		pb.ZOrder()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		' If the progress bar is visible, you need to move it when
		' the form is resized.
		If ProgressBar1.Visible Then 
			MoveProgressBarIntoPanel(ProgressBar1, StatusBar1, 1)
		End If
	End Sub

End Class
