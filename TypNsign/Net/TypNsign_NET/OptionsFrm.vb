' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class OptionsFrm

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
	
	Private Sub Form_GotFocus() Handles MyBase.GotFocus
		
		Slider1.Value = Val(HAND_SPEED)
		LocationTxt.Text = Trim(MODULE_PATH)
		ChkLoop.Value = LOOP_IT
		
	End Sub
	
	Private Sub LoadFile_Click() Handles LoadFile.Click
		'///////////////////////////////////
		'// LOAD MODULES
		'///////////////
		
		Dim Buffer As String = ""
		On Error GoTo eror 
		
		With MnuCntrol.CommonDialog1
			.Filter = "Type-n-sign Module Index File (Hands.mod) | Hands.mod"
			.ShowOpen()
		End With
		
		Buffer = MnuCntrol.CommonDialog1.FileName
		LocationTxt.Text = Buffer
		
		Buffer = VB.Left(Buffer, (Len6(Buffer) - 9)) '// hands.mod = 9 leters,
		MODULE_PATH = Buffer '// Index file for commonDialog
		
		Exit Sub
		
eror:
		
	End Sub
	
	Private Sub okBtn_Click() Handles okBtn.Click
		'//////////////////////////////////
		'// OK BUTTON
		'/////////////////
		Dim Buffer As String = ""
		On Error GoTo eror 
		
		Buffer = LocationTxt.Text '// Get module path
		Buffer = VB.Left(Buffer, (Len6(Buffer) - 9)) '// hands.mod = 9 leters :)
		
		Call WriteToINI(APP_NAME, "ModPath", Buffer, INIFILE)
		
		MODULE_PATH = Buffer
		
		HAND_SPEED = Slider1.Value
		Call WriteToINI(APP_NAME, "HandSpeed", HAND_SPEED, INIFILE)
		
		LOOP_IT = ChkLoop.Value
		Call WriteToINI(APP_NAME, "Loop", LOOP_IT, INIFILE)
		
		Me.Hide()
		Exit Sub
		
eror:
	End Sub
	
	Private Sub CancelBtn_Click() Handles CancelBtn.Click
		
		Me.Hide()
		
	End Sub

End Class
