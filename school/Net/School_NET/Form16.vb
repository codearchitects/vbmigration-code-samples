' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form16

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		MonthView1.Value = Today
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Call save_pos(Me)
	End Sub

End Class
