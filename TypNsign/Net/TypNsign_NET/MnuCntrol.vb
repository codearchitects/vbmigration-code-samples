' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class MnuCntrol

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
	
	Private Sub MnuBckClr_Click() Handles MnuBckClr.Click
		
		CommonDialog1.ShowColor()
		MainFrm.ConsoleTxt.BackColor = CommonDialog1.Color
		
	End Sub
	
	Private Sub MnuClearTxt_Click() Handles MnuClearTxt.Click
		
		With MainFrm
			.ConsoleTxt.Text = ""
			.Picture1.Picture = LoadPicture6("")
		End With
		
	End Sub
	
	Private Sub MnuExit_Click() Handles MnuExit.Click
		
		Call MainFrm.Exit_Click()
		
	End Sub
	
	Private Sub MnuFntClr_Click() Handles MnuFntClr.Click
		
		CommonDialog1.ShowColor()
		MainFrm.ConsoleTxt.ForeColor = CommonDialog1.Color
		
	End Sub
	
	Private Sub MnuOnTopOff_Click() Handles MnuOnTopOff.Click
		
		Call NotOntop(MainFrm)
		MnuOnTopOff.Checked = True
		MnuOnTopOn.Checked = False
		
	End Sub
	
	Private Sub MnuOnTopOn_Click() Handles MnuOnTopOn.Click
		
		Call Ontop(MainFrm)
		MnuOnTopOn.Checked = True
		MnuOnTopOff.Checked = False
		
	End Sub
	
	Private Sub mnuSetup_Click() Handles mnuSetup.Click
		
		With OptionsFrm
			.Slider1.Value = Val(HAND_SPEED)
			.LocationTxt.Text = MODULE_PATH & "Hands.mod"
			.ChkLoop.Value = LOOP_IT
			.Show()
		End With
		
	End Sub

End Class
