' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class MDIForm1

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub MDIForm_Activate() Handles MyBase.Activate
		If end_app = True Then  Application.Exit(): End
	End Sub

	Private Sub MDIForm_Load() Handles MyBase.Load
		Call use_control_vis(Toolbar1)
		Call use_control_vis(StatusBar1)
		Call use_control_pos(Toolbar1)
		
		Call set_conn_getData(cn, App6.Path & "\MasterFile.mdb", True, "reg386")
		
		Dim rs As New ADODB.RecordsetClass
		Call set_rec_getData(rs, cn, "Select SystemInfo.* From SystemInfo")
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		school_name = rs.Fields(0).Value
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
		school_address = rs.Fields(1).Value
		
		rs = Nothing
		
		Me.Caption = school_name & " - " & Me.Caption
		
		Me.Show()
		frmSplash.Show(VBRUN.FormShowConstants.vbModal)
		
		Form24.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub MDIForm_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		Dim repp As Short = MsgBox6("This will terminate the application.Do you want to proceed?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "CSRS version 1")
		If repp = MsgBoxResult.No Then 
			Cancel = 1
		End If
	End Sub

	Private Sub MDIForm_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		'---------------------------------------
		'Record user's logout time
		'---------------------------------------
		Call record_logout(user_login, user_name)
		
		cn = Nothing
		
		Call save_control_pos(Toolbar1)
		Call save_control_vis(Toolbar1)
		Call save_control_vis(StatusBar1)
		
		'---------------------------------------
		'Terminate the entire application
		'---------------------------------------
		Application.Exit(): End
	End Sub

	Private Sub mnuAbt_Click() Handles mnuAbt.Click
		frmAbout.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub mnuAI_Click() Handles mnuAI.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbArrangeIcons)
	End Sub

	Private Sub mnuAO_Click() Handles mnuAO.Click
		If user_type <> "Admin" Then  MsgBox6("This function is for administrator only. Please log-in as administrator to gain access.", MsgBoxStyle.Critical, "CSRS version 1"): Exit Sub

		Form23.Show()
		Form23.SetFocus()
		Form23.WindowState = 0
	End Sub

	Private Sub mnuC_Click() Handles mnuC.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbCascade)
	End Sub

	Private Sub mnuCalc_Click() Handles mnuCalc.Click
		On Error GoTo Err 
		Shell("calc.exe", AppWinStyle.NormalFocus)
		Exit Sub
Err:
		MsgBox6("You don't have a Calculator installed in your computer.", MsgBoxStyle.Exclamation, "CSRS version 1")
	End Sub

	Private Sub mnuCalen_Click() Handles mnuCalen.Click
		Form16.Show()
		Form16.SetFocus()
		Form16.WindowState = 0
	End Sub

	Private Sub mnuE_Click() Handles mnuE.Click
		Unload6(Me)
	End Sub

	Private Sub mnuHSM_Click() Handles mnuHSM.Click
		Toolbar1.Visible = Not Toolbar1.Visible
	End Sub

	Private Sub mnuHSS_Click() Handles mnuHSS.Click
		StatusBar1.Visible = Not StatusBar1.Visible
	End Sub

	Private Sub mnuIR_Click() Handles mnuIR.Click
		Form17.Show()
		Form17.SetFocus()
		Form17.WindowState = 0
		Form17.Command2.SetFocus()
	End Sub

	Private Sub mnuL_Click() Handles mnuL.Click
		Form9.Show()
		Form9.SetFocus()
		Form9.WindowState = 0
	End Sub

	Private Sub mnuMRS_Click() Handles mnuMRS.Click
		Form17.Show()
		Form17.SetFocus()
		Form17.WindowState = 0
		Form17.Command1.SetFocus()
	End Sub

	Private Sub mnuMSR_Click() Handles mnuMSR.Click
		If frm_stud_show = True Then  Form1.SetFocus(): Form1.WindowState = 0: Exit Sub
		Form2.Show()
	End Sub

	Private Sub mnuMSY_Click() Handles mnuMSY.Click
		Form11.Show()
		Form11.SetFocus()
		Form11.WindowState = 0
	End Sub

	Private Sub mnuPR_Click() Handles mnuPR.Click
		Form21.Show()
		Form21.SetFocus()
		Form21.WindowState = 0
	End Sub

	Private Sub mnuS_Click() Handles mnuS.Click
		Form13.Show()
		Form13.SetFocus()
		Form13.WindowState = 0
	End Sub

	Private Sub mnuSI_Click()
	' UPGRADE_INFO (#0501): The 'mnuSI_Click' member isn't used anywhere in current application.
		
	End Sub

	Private Sub mnuSL_Click() Handles mnuSL.Click
		Form20.Show()
		Form20.SetFocus()
		Form20.WindowState = 0
	End Sub

	Private Sub mnuSPS_Click() Handles mnuSPS.Click
		Form17.Show()
		Form17.SetFocus()
		Form17.WindowState = 0
		Form17.Command4.SetFocus()
	End Sub

	Private Sub mnuTAB_Click() Handles mnuTAB.Click
		Toolbar1.Align = 2
	End Sub

	Private Sub mnuTAL_Click() Handles mnuTAL.Click
		Toolbar1.Align = 3
	End Sub

	Private Sub mnuTAP_Click() Handles mnuTAP.Click
		Toolbar1.Align = 1
	End Sub

	Private Sub mnuTAR_Click() Handles mnuTAR.Click
		Toolbar1.Align = 4
	End Sub

	Private Sub mnuTH_Click() Handles mnuTH.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileHorizontal)
	End Sub

	Private Sub mnuTV_Click() Handles mnuTV.Click
		Me.Arrange(VBRUN.FormArrangeConstants.vbTileVertical)
	End Sub

	Private Sub mnuNP_Click() Handles mnuNP.Click
		On Error GoTo Err 
		Shell("notepad.exe", AppWinStyle.NormalFocus)
		Exit Sub
Err:
		MsgBox6("You don't have a NotePad  installed in your computer.", MsgBoxStyle.Exclamation, "CSRS version 1")
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal Button As VB6Button) Handles Toolbar1.ButtonClick
		Select Case Button.Index
		Case 3: mnuMSR_Click()
		Case 4: mnuS_Click()
		Case 5: mnuL_Click()
		Case 6: mnuMSY_Click()
		Case 8: mnuMRS_Click()
		Case 9: mnuIR_Click()
		Case 10: mnuSPS_Click()
		Case 11: mnuSL_Click()
		Case 12: mnuPR_Click()
		Case 14: mnuCalc_Click()
		Case 15: mnuNP_Click()
		Case 16: mnuCalen_Click()
		Case 18: mnuAbt_Click()
		End Select
	End Sub

End Class
