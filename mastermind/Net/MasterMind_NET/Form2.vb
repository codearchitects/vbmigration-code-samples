' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form2

	Public Sub DisableControl_Click() Handles DisableControl.Click
		Form1.LabTent1_1.Enabled = False
		Form1.LabTent1_2.Enabled = False
		Form1.LabTent1_3.Enabled = False
		Form1.LabTent1_4.Enabled = False
		Form1.LabTent1_5.Enabled = False
		
		Form1.LabTent2_1.Enabled = False
		Form1.LabTent2_2.Enabled = False
		Form1.LabTent2_3.Enabled = False
		Form1.LabTent2_4.Enabled = False
		Form1.LabTent2_5.Enabled = False
		
		Form1.LabTent3_1.Enabled = False
		Form1.LabTent3_2.Enabled = False
		Form1.LabTent3_3.Enabled = False
		Form1.LabTent3_4.Enabled = False
		Form1.LabTent3_5.Enabled = False
		
		Form1.LabTent4_1.Enabled = False
		Form1.LabTent4_2.Enabled = False
		Form1.LabTent4_3.Enabled = False
		Form1.LabTent4_4.Enabled = False
		Form1.LabTent4_5.Enabled = False
		
		Form1.LabTent5_1.Enabled = False
		Form1.LabTent5_2.Enabled = False
		Form1.LabTent5_3.Enabled = False
		Form1.LabTent5_4.Enabled = False
		Form1.LabTent5_5.Enabled = False
		
		Form1.LabTent6_1.Enabled = False
		Form1.LabTent6_2.Enabled = False
		Form1.LabTent6_3.Enabled = False
		Form1.LabTent6_4.Enabled = False
		Form1.LabTent6_5.Enabled = False
		
		Form1.LabTent7_1.Enabled = False
		Form1.LabTent7_2.Enabled = False
		Form1.LabTent7_3.Enabled = False
		Form1.LabTent7_4.Enabled = False
		Form1.LabTent7_5.Enabled = False
		
		Form1.LabTent8_1.Enabled = False
		Form1.LabTent8_2.Enabled = False
		Form1.LabTent8_3.Enabled = False
		Form1.LabTent8_4.Enabled = False
		Form1.LabTent8_5.Enabled = False
		
		Form1.LabTent9_1.Enabled = False
		Form1.LabTent9_2.Enabled = False
		Form1.LabTent9_3.Enabled = False
		Form1.LabTent9_4.Enabled = False
		Form1.LabTent9_5.Enabled = False
		
		Form1.LabTent10_1.Enabled = False
		Form1.LabTent10_2.Enabled = False
		Form1.LabTent10_3.Enabled = False
		Form1.LabTent10_4.Enabled = False
		Form1.LabTent10_5.Enabled = False
		
		Form1.LabTent11_1.Enabled = False
		Form1.LabTent11_2.Enabled = False
		Form1.LabTent11_3.Enabled = False
		Form1.LabTent11_4.Enabled = False
		Form1.LabTent11_5.Enabled = False
		
		Form1.LabTent12_1.Enabled = False
		Form1.LabTent12_2.Enabled = False
		Form1.LabTent12_3.Enabled = False
		Form1.LabTent12_4.Enabled = False
		Form1.LabTent12_5.Enabled = False
		
		Form1.Command1.Visible = False
		Form1.Command2.Visible = False
		Form1.Command3.Visible = False
		Form1.Command4.Visible = False
		Form1.Command5.Visible = False
		Form1.Command6.Visible = False
		Form1.Command7.Visible = False
		Form1.Command8.Visible = False
		Form1.Command9.Visible = False
		Form1.Command10.Visible = False
		Form1.Command11.Visible = False
		Form1.Command12.Visible = False
	End Sub

	Private Sub Form_Click() Handles MyBase.Click
		Form1.Show()
		Unload6(Me)
		NuovaPart_Click()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Form1.Hide()
	End Sub

	Private Sub Label1_Click() Handles Label1.Click
		Form1.Show()
		Unload6(Me)
		NuovaPart_Click()
	End Sub

	Public Sub NuovaPart_Click() Handles NuovaPart.Click
		Dim Risposta As Short = MsgBox6("Aprire una nuova partita?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nuova partita")
		If Risposta = MsgBoxResult.Yes Then 
			Form1.New_Click()
		Else
			DisableControl_Click()
		End If
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		If Label1.Visible = True Then 
			Label1.Visible = False
		Else
			Label1.Visible = True
		End If
	End Sub

	Private Sub Timer2_Timer() Handles Timer2.Timer
		Form1.Show()
		Unload6(Me)
		NuovaPart_Click()
	End Sub

End Class
