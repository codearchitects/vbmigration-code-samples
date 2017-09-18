' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form25

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub Combo1_KeyPress(ByRef KeyAscii As Short) Handles Combo1.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If is_empty(Combo1) = True Then  Exit Sub
		If is_empty(Text1) = True Then  Exit Sub
		
		If Len6(Text1.Text) <> 4 Then  MsgBox6("Invalid entry. Please check it.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text1.SetFocus(): Exit Sub
		
		Dim rep As Short
		Dim rs_log As New ADODB.RecordsetClass
		If Option1.Value = True Then 
			rep = MsgBox6("Are you sure you want to clear all log-in details?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CSRS version 1")
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			If rep = MsgBoxResult.Yes Then  Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass: cn.Execute("Delete * From UsersLog"): Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault: MsgBox6("All log-in details has been successfully cleared.", MsgBoxStyle.Information, "CSRS version 1")
		Else
			If month_value(Combo1.Text) = 0 Then  MsgBox6("Invalid selection.", MsgBoxStyle.Exclamation, "CSRS version 1"): Combo1.SetFocus(): Exit Sub
			
			Call set_rec_getData(rs_log, cn, "Select qryUsers.* From qryUsers Where Month =" & month_value(Combo1.Text) & " And Year =" & Val(Text1.Text) & " Order by Sort Asc")
			
			With rpt_header
				.SchoolAddress = school_address
				.SchoolName = school_name
			End With
			
	' UNSUPPORTED: 		DataReport6.DataSource = rs_log
	' UNSUPPORTED: 		DataReport6.Show(VBRUN.FormShowConstants.vbModal)
			
			rs_log = Nothing
		End If
	End Sub

	Private Sub Option1_Click() Handles Option1.Click
		If Option1.Value = True Then 
			Frame2.Visible = False
		Else
			Frame2.Visible = True
		End If
	End Sub

	Private Sub Option2_Click() Handles Option2.Click
		If Option1.Value = True Then 
			Frame2.Visible = False
		Else
			Frame2.Visible = True
		End If
	End Sub
	
	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		Option1.Value = True
		With Combo1
			.AddItem("January")
			.AddItem("February")
			.AddItem("March")
			.AddItem("April")
			.AddItem("May")
			.AddItem("June")
			.AddItem("July")
			.AddItem("August")
			.AddItem("September")
			.AddItem("October")
			.AddItem("November")
			.AddItem("December")
		End With
		Text1.Text = Year(Today)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Call save_pos(Me)
	End Sub

	Public Function month_value(ByVal Month_Name As String) As Byte
		month_value = 0
		Month_Name = VB.Left(UCase(Month_Name), 1) & VB.Right(LCase(Month_Name), Len6(Month_Name) - 1)
		Select Case Month_Name
		Case "January": Return 1
		Case "February": Return 2
		Case "March": Return 3
		Case "April": Return 4
		Case "May": Return 5
		Case "June": Return 6
		Case "July": Return 7
		Case "August": Return 8
		Case "September": Return 9
		Case "October": Return 10
		Case "November": Return 11
		Case "December": Return 12
		End Select
	End Function

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

End Class
