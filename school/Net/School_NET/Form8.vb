' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form8

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	'--------------------------------------
	'Create variable to connect to DB
	'--------------------------------------
	Private rs1 As New ADODB.RecordsetClass
	Private rs2 As New ADODB.RecordsetClass
	'--------------------------------------
	'End-Create variable to connect to DB
	'--------------------------------------
	
	Private Sub Combo1_Click() Handles Combo1.Click
		If Combo1.Text = "" Then  Exit Sub
		rs2.Filter = "LevelName ='" & Combo1.Text & "'"
		Call fill_combo(Combo2, rs2)
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		Dim sql As String = ""
		'--------------------------------------
		'Begin filtering of records
		'--------------------------------------
		If Check2.Value = 0 And Check3.Value = 0 Then 
			sql = "Sex ='None'"
		ElseIf Check2.Value <> Check3.Value Then 
			If Check2.Value = 1 Then  sql = "Sex = 'Male'"
			If Check3.Value = 1 Then  sql = "Sex = 'Female'"
		End If
		
		If sql = "" Then 
			If Not Combo1.Text = "" Then  sql = "LevelName = '" & Combo1.Text & "'"
			If Not Combo2.Text = "" Then  sql = sql & " And SectionName = '" & Combo2.Text & "'"
		Else
			If Not Combo1.Text = "" Then  sql = sql & " And LevelName = '" & Combo1.Text & "'"
			If Not Combo2.Text = "" Then  sql = sql & " And SectionName = '" & Combo2.Text & "'"
		End If
		
		If Check1.Value = 0 And Check4.Value = 0 And Check5.Value = 0 Then 
			If sql <> "" Then 
				sql &= " And Status = 'None'"
			Else
				sql = "Status = 'None'"
			End If
		ElseIf Check1.Value <> Check4.Value Or Check1.Value <> Check5.Value Or Check4.Value <> Check5.Value Then 
			If Check1.Value = 1 Then 
				If sql <> "" Then 
					sql &= " And Status = 'Drop'"
				Else
					sql = "Status = 'Drop'"
				End If
			Else
				If sql <> "" Then 
					sql &= " And Status <> 'Drop'"
				Else
					sql = "Status <> 'Drop'"
				End If
			End If
			If Check4.Value <> Check5.Value Then  '///////////////////////////////////////
				If Check4.Value = 1 Then 
					If sql <> "" Then 
						If Check1.Value = 1 Then 
							sql &= " Or Status = 'New'"
						Else
							sql &= " And Status = 'New'"
						End If
					Else
						sql &= "Status = 'New'"
					End If
				End If
				
				If Check5.Value = 1 Then 
					If sql <> "" Then 
						If Check1.Value = 1 Or Check4.Value = 1 Then 
							sql &= " Or Status = 'Old'"
						Else
							sql &= " And Status = 'Old'"
						End If
					Else
						sql &= "Status = 'Old'"
					End If
				End If
			End If '///////////////////////////////////////
		End If
		
		rs_stud.Filter = sql
		'--------------------------------------
		'Save settings to variable
		'--------------------------------------
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sds'. Consider using the SetDefaultMember6 helper method.
		sds = Check1.Value
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sms'. Consider using the SetDefaultMember6 helper method.
		sms = Check2.Value
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sfs'. Consider using the SetDefaultMember6 helper method.
		sfs = Check3.Value
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sns'. Consider using the SetDefaultMember6 helper method.
		sns = Check4.Value
		sos = Check5.Value
		'--------------------------------------
		'End-Clear variable
		'--------------------------------------
		sql = ""
		'--------------------------------------
		'Load search result
		'--------------------------------------
		Form1.fill_rec()
		Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
	End Sub

	Private Sub Combo1_KeyPress(ByRef KeyAscii As Short) Handles Combo1.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Combo2_KeyPress(ByRef KeyAscii As Short) Handles Combo2.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Check1.Value = 0
		Check2.Value = 1
		Check3.Value = 1
		Check4.Value = 1
		Check5.Value = 1
		
		Combo1.Text = ""
		Combo2.Text = ""
		
		rs1.Requery()
		rs2.Filter = ADODB.FilterGroupEnum.adFilterNone '[ You can use also .Filter="" ]
		rs2.Requery()
		
		Call fill_combo(Combo1, rs1)
		Call fill_combo(Combo2, rs2)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sds'. Consider using the GetDefaultMember6 helper method.
		Check1.Value = sds
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sms'. Consider using the GetDefaultMember6 helper method.
		Check2.Value = sms
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sfs'. Consider using the GetDefaultMember6 helper method.
		Check3.Value = sfs
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sns'. Consider using the GetDefaultMember6 helper method.
		Check4.Value = sns
		Check5.Value = sos
		
		'--------------------------------------
		'Set the variables
		'--------------------------------------
		Call set_rec_getData(rs1, cn, "Select tblLevel.* From tblLevel Order by LevelName Asc")
		Call set_rec_getData(rs2, cn, "Select qrySections.* From qrySections Order by SectionName Asc")
		'--------------------------------------
		'End-Set the variables
		'--------------------------------------
		
		'--------------------------------------
		'Fill Combo control
		'--------------------------------------
		Call fill_combo(Combo1, rs1)
		Call fill_combo(Combo2, rs2)
		'--------------------------------------
		'End-Fill Combo control
		'--------------------------------------
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form1.Enabled = True
		
		'--------------------------------------
		'Clear variable
		'--------------------------------------
		rs1 = Nothing
		rs2 = Nothing
		'--------------------------------------
		'End-Clear variable
		'--------------------------------------
		
		Call save_pos(Me)
	End Sub
	
	Public Sub fill_combo(ByRef sCombo As VB6ComboBox, ByRef sRS As ADODB.Recordset)
	' UPGRADE_INFO (#0551): The 'sCombo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sRS' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		sCombo.Clear()
		If sRS.RecordCount < 1 Then  Exit Sub
		sRS.MoveFirst()
		Do While Not sRS.EOF
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sRS.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
			sCombo.AddItem(sRS.Fields(1).Value)
			sRS.MoveNext()
		Loop
		sRS.MoveFirst()
	End Sub

End Class
