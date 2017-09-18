' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form23

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub Command1_Click() Handles Command1.Click
		Form26.Show()
		Form26.SetFocus()
		Form26.WindowState = 0
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Form25.Show()
		Form25.SetFocus()
		Form25.WindowState = 0
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Form22.Show()
		Form22.SetFocus()
		Form22.WindowState = 0
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Call save_pos(Me)
	End Sub

End Class
