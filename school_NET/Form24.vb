' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form24

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Private c_attempt As String = ""
	Private rs_user As New ADODB.RecordsetClass
	Private conn_user As New ADODB.ConnectionClass
	
	Private Sub Command1_Click() Handles Command1.Click
		end_app = True
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		'-------------------------------------------------
		'Verify the fields if empty
		'-------------------------------------------------
		If Text1.Text = "" Then  Text1.SetFocus(): Exit Sub
		If Text2.Text = "" Then  Text2.SetFocus(): Exit Sub
		'-------------------------------------------------
		'Check if the User Name is valid
		'-------------------------------------------------
		If rec_found(rs_user, "Username", Text1.Text) = False Then 
			c_attempt -= 1
			If c_attempt < 0 Then 
				MsgBox6("You already used all attempt." & ControlChars.CrLf & "This will terminate the application.", MsgBoxStyle.Critical, "CSRS version 1")
			Else
				MsgBox6("The User Name you entered is not valid." & ControlChars.CrLf & "Please try again." & ControlChars.CrLf & ControlChars.CrLf & "Warning: You only have " & c_attempt & " attempt.", MsgBoxStyle.Critical, "CSRS version 1")
				Label7.Caption = c_attempt
			End If
			Text1.SetFocus()
			Call verify_attempt()
			Exit Sub
		End If
		'-------------------------------------------------
		'Check if the Password is valid
		'-------------------------------------------------
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_user.Fields(3).Value'. Consider using the GetDefaultMember6 helper method.
		If Text2.Text <> rs_user.Fields(3).Value Then 
			c_attempt -= 1
			Label7.Caption = c_attempt
			If c_attempt < 0 Then 
				MsgBox6("You already used all attempt." & ControlChars.CrLf & "This will terminate the application.", MsgBoxStyle.Critical, "CSRS version 1")
			Else
				MsgBox6("You did NOT enter the Correct Password." & ControlChars.CrLf & "Please try again." & ControlChars.CrLf & ControlChars.CrLf & "Warning: You only have " & c_attempt & " attempt.", MsgBoxStyle.Critical, "CSRS version 1")
				Label7.Caption = c_attempt
			End If
			Text2.SetFocus()
			Call verify_attempt()
			Exit Sub
		End If
		'-------------------------------------------------
		'Copy the Username and log-time to variable
		'-------------------------------------------------
		user_name = Text1.Text
		user_login = Now
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_user.Fields(2).Value'. Consider using the GetDefaultMember6 helper method.
		user_type = rs_user.Fields(2).Value
		'-------------------------------------------------
		'This the Username and log-time to variable
		'-------------------------------------------------
		Call record_login(user_login, user_name)
		With MDIForm1.StatusBar1.Panels
			.Item(3).Text = user_name
			.Item(6).Text = user_login
		End With
		Unload6(Me)
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Text1.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		'-------------------------------------------------
		'Set the variables to have connection to database
		'-------------------------------------------------
		Call set_conn_getData(conn_user, App6.Path & "\MasterFile.mdb", True, "reg386")
		Call set_rec_getData(rs_user, conn_user, "Select * From Users")
		'-------------------------------------------------
		'Move them form to center
		'-------------------------------------------------
		Call centerForm(Me, Screen6.Height, Screen6.Width)
		'-------------------------------------------------
		'Initialize the number of attempt
		'-------------------------------------------------
		c_attempt = 3
		Label7.Caption = c_attempt
	End Sub

	Private Sub Form_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		'-------------------------------------------------
		'If the user click the close button
		'-------------------------------------------------
		If UnloadMode = 0 Then  end_app = True
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		'-------------------------------------------------
		'Clear variable from the computer memory
		'-------------------------------------------------
		rs_user = Nothing
		conn_user = Nothing
	End Sub
	
	Private Sub verify_attempt()
		'-------------------------------------------------------
		'If all attempt is used then terminate the application
		'-------------------------------------------------------
		If c_attempt < 0 Then  end_app = True: Unload6(Me)
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

End Class
