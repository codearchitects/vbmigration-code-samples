' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class MainFrm

	'//////////////////////////////////////////
	'//                   ____
	'//    _______       /  / \  (_GrayHat_)
	'//    \      \  __ /  /\  \____   ____
	'//    /   |   \/ _<  <  >  >   \_/ __ \
	'//   /    |   ( <_>\  \/  /  |  \  ___/
	'//   \____|____\___/\__\_/|__|__/\____>
	'//
	'//             [GNU license]
	'//   http://org.gnu.de/copyleft/gpl.html
	'//
	'//////////////////////////////////////////
	
	' UPGRADE_INFO (#0501): The 'Counter' member isn't used anywhere in current application.
	Private Counter As Short
	
	Private Sub Form_Load() Handles MyBase.Load
		'///////////////////////////////////
		'// START UP PROGRAM
		'//////////////////
		On Error Resume Next 
		
		shapeform = New clsTransForm()
		
		Dim HotPurple As Integer = RGB(255, 0, 255)
		
		'// Make us transparent :)
		shapeform.SetRegion(Me, HotPurple, App6.Path & "\typensign.dat")
		
	End Sub
	
	Private Sub StartBtn_Click() Handles StartBtn.Click
		'//////////////////////////////////////////
		'// START BUTTON
		'//////////////
		Dim Txt As String = ""
		Dim LenTxt As Integer
		Dim Countr As Short
		Dim Bffer As String = ""
		
		If STOPED = True Then 
			
			STOPED = False
			StartBtn.Caption = "Stop"
			
			Txt = ConsoleTxt.Text
			LenTxt = Len6(Txt)
			
			'// Run through console for playback
			Countr = 1
			Do While Countr <= LenTxt
				
				Bffer = ""
				Bffer = Mid(Txt, Countr, 1) '// Pick each letter out.
				Call ShowPict_Alpha(Bffer) '// Display sign for it.
				
				If Countr = LenTxt Then  '// At end of text.
					If LOOP_IT = 1 Then  '// Check for loop option.
						Countr = 0
					ElseIf LOOP_IT = 0 Then  '// If loop not set,
						StartBtn.Caption = "Start" '// reset to Start button.
						STOPED = True '// and Stop program.
						Exit Sub
					End If
				End If
				
				Countr += 1 '// Advance counter.
				TimeOut(((HAND_SPEED * 0.05))) '// Pause between pictures.
				
				If STOPED = True Then  Exit Sub
			Loop
			
		Else '// Else we are pressing stop.
			
			StartBtn.Caption = "Start"
			STOPED = True
			
		End If
		
	End Sub
	
	Private Sub TitleBar_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles TitleBar.MouseDown
		'//////////////////////////////////////
		'// FOR MOVING THE FORM AROUND
		'//////////////////////////
		
		If Button = VBRUN.MouseButtonConstants.vbLeftButton Then 
			shapeform = New clsTransForm()
			shapeform.DragForm(Me.hWnd, 1)
		End If
		
	End Sub
	
	Private Sub OptionsBtn_Click() Handles OptionsBtn.Click
		'//////////////////////////////////////////
		'// OPTIONS BUTTON
		'///////////////
		
		MnuCntrol.PopupMenu(MnuCntrol.MnuOptions, 0)
		
	End Sub
	
	Private Sub ResetBtn_Click() Handles ResetBtn.Click
		'/////////////////////////////////////
		'// RESET MENU
		'//////////////////
		
		MnuCntrol.PopupMenu(MnuCntrol.MnuReset, 1)
		
	End Sub
	
	Private Sub TimeOut(ByRef duration As Object)
	' UPGRADE_INFO (#0561): The 'duration' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'duration' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'////////////////////////////////////
		'// TIMER
		'//////////////////
		
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'StartTime'. Consider using the SetDefaultMember6 helper method.
		StartTime = Timer6
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'StartTime'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'duration'. Consider using the GetDefaultMember6 helper method.
		Do While Timer6 - StartTime < duration
			DoEvents6()
		Loop
		
	End Sub
	
	Public Sub Exit_Click() Handles lblExit.Click
		'////////////////////////////////////
		'// EXIT
		'//////////////////
		
		STOPED = True
		
		Unload6(MnuCntrol)
		Unload6(OptionsFrm)
		Unload6(frmSplash)
		
		Unload6(Me)
		
	End Sub
	
	Private Sub ConsoleTxt_KeyPress(ByRef KeyAscii As Short) Handles ConsoleTxt.KeyPress
		'//////////////////////////
		'// MANUAL KEY PRESS
		'////////
		
		Call ShowPict_Alpha(Chr6(KeyAscii))
		
	End Sub
	
	Private Sub Key_Click(ByRef Index As Short)
		'/////////////////////////
		'// MOUSE CLICK ON KEY
		'/////////
		
		Call ShowPict_Num(Index) '// Show picture
		Call StText(Index) '// Display text
		
	End Sub
	
	'///////////////////////////////////////////////////////////////////////////////
	'// KEYBOARD CONTROLS

	Public Sub ShowPict_Num(ByRef Num As Short)
	' UPGRADE_INFO (#0551): The 'Num' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'/////////////////////////
		'// LETTER CONTROLS
		'/////////
		On Error GoTo DifKey 
		Dim lChr As Integer = Num + 97
		
		'// ASCII code for "a" is chr(97)
		
		Picture1.Picture = LoadPicture6(MODULE_PATH & Chr6(lChr) & ".jpg")
		Exit Sub
DifKey:
		Picture1.Picture = LoadPicture6("")
		
	End Sub
	
	Private Sub ShowPict_Alpha(ByRef Alpha As String)
	' UPGRADE_INFO (#0551): The 'Alpha' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error GoTo DifKey 
		Picture1.Picture = LoadPicture6(MODULE_PATH & Alpha & ".jpg")
		Exit Sub
		
DifKey:
		Picture1.Picture = LoadPicture6("")
		
	End Sub
	
	Private Sub StText(ByRef Num As Short)
	' UPGRADE_INFO (#0551): The 'Num' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim lChr As Integer
		
		If Num > 25 Then  '// Check for special char's first
			Select Case Num
			Case 26: ConsoleTxt.AppendText("[")
			Case 27: ConsoleTxt.AppendText("]")
			Case 28: ConsoleTxt.AppendText(";")
			Case 29: ConsoleTxt.AppendText("'")
			Case 30: ConsoleTxt.AppendText(",")
			Case 31: ConsoleTxt.AppendText(".")
			Case 32: ConsoleTxt.Text = ConsoleTxt.Text & "/"
			Case 33: ConsoleTxt.AppendText(ControlChars.CrLf)
			Case 34: ConsoleTxt.AppendText(" ")
			End Select
		End If
		
		lChr = Num + 97 '// ASCII code for "a" is chr(97)
		
		ConsoleTxt.AppendText(Chr6(lChr))
		
	End Sub

End Class
