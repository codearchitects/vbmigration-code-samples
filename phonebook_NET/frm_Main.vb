' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frm_Main

	Private Sub Form_Load() Handles MyBase.Load
		Dim v_sSQL As String = "SELECT * FROM PhoneBook WHERE FirstName Like "
		Dim v_sActiveConnection As String = ""
		Dim v_iLoop As Short
		Dim v_iIndex As Short
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		
		v_rsPhoneBook = New ADODB.Recordset()
		For v_iLoop = 1 To Me.lvw_PhoneBook.ListItems.Count
			Me.lvw_PhoneBook.ListItems.Remove(1)
		Next
		
		v_rsPhoneBook.Open(v_sSQL & "'A%' OR FirstName LIKE 'B%' OR FirstName LIKE 'C%' ORDER BY FirstName", v_sActiveConnection)
		
		While Not v_rsPhoneBook.EOF
			v_iIndex += 1
			Me.lvw_PhoneBook.ListItems.Add(, , v_rsPhoneBook.Fields("FirstName"))
			Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(1, , v_rsPhoneBook.Fields("LastName"))
			Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(2, , v_rsPhoneBook.Fields("TelNo"))
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPhoneBook.Fields("EMail").Value'. Consider using the GetDefaultMember6 helper method.
			If Not IsNull6(v_rsPhoneBook.Fields("EMail").Value) Then 
				Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(3, , v_rsPhoneBook.Fields("EMail"))
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPhoneBook.Fields("Address").Value'. Consider using the GetDefaultMember6 helper method.
			If Not IsNull6(v_rsPhoneBook.Fields("Address").Value) Then 
				Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(4, , v_rsPhoneBook.Fields("Address"))
			End If
			v_rsPhoneBook.MoveNext()
		End While
	End Sub

	Private Sub Form_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseMove
		Dim v_lMsg As Single = X / Screen6.TwipsPerPixelX
		
		Select Case v_lMsg
		Case WM_LBUTTONUP
		Case WM_RBUTTONUP
			If pSystemTrayOnly Then 
				Me.pdi_ShowPhoneBook.Visible = True
				Me.Separator01.Visible = True
			End If
			PopupMenu(Me.pdm_File)
		Case WM_MOUSEMOVE
		Case WM_LBUTTONDOWN
		Case WM_LBUTTONDBLCLK
			Me.pdi_ShowPhoneBook.Visible = False
			Me.Separator01.Visible = False
			Me.Show()
		Case WM_RBUTTONDOWN
		Case WM_RBUTTONDBLCLK
		Case Else
		End Select
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Call Shell_NotifyIcon(NIM_DELETE, nfIconData)
	End Sub

	Private Sub pdi_About_Click() Handles pdi_About.Click
		frm_About.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub pdi_AddNewPerson_Click() Handles pdi_AddNewPerson.Click
		frm_AddNew.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub pdi_EditAPerson_Click() Handles pdi_EditAPerson.Click
		frm_Edit.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub pdi_Exit_Click() Handles pdi_Exit.Click
		Call Shell_NotifyIcon(NIM_DELETE, nfIconData)
		Unload6(Me)
	End Sub

	Private Sub pdi_FindAPerson_Click() Handles pdi_FindAPerson.Click
		frm_Find.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub pdi_Print_Click() Handles pdi_Print.Click
		Dim v_rsPrint As New ADODB.RecordsetClass
		Dim v_sActiveConnection As String = ""
		' UPGRADE_INFO (#0561): The 'v_iCurrentX' symbol was defined without an explicit "As" clause.
		Dim v_iCurrentX As Object = Nothing
		Dim v_iCurrentY As Short
		
		On Error GoTo Err 
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		v_rsPrint.Open("SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection)
		
		Printer6.CurrentX = 1440
		Printer6.CurrentY = 1800
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'v_iCurrentX'. Consider using the SetDefaultMember6 helper method.
		v_iCurrentX = 1440
		v_iCurrentY = 1800
		
		Printer6.FontBold = True
		Printer6.Print("First Name")
		Printer6.CurrentX = 2940
		Printer6.Print("Last Name")
		Printer6.CurrentX = 5140
		Printer6.PrintLine("Telephone Number")
		
		Printer6.FontBold = False
		While Not v_rsPrint.EOF
			If v_iCurrentY >= (Printer6.ScaleHeight) - 1800 Then 
				Printer6.EndDoc()
				v_iCurrentY = 1800
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPrint.Fields("FirstName").Value'. Consider using the GetDefaultMember6 helper method.
			v_iCurrentY += Printer6.TextHeight(v_rsPrint.Fields("FirstName").Value)
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
			Printer6.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, Printer6.ScaleWidth - v_iCurrentX + 60, v_iCurrentY)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
			Printer6.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 2860, v_iCurrentY)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_iCurrentX'. Consider using the GetDefaultMember6 helper method.
			Printer6.Line(VBRUN.GraphicsOptions.Box, v_iCurrentX - 60, v_iCurrentY, 5060, v_iCurrentY)
			
			Printer6.CurrentX = 1440
			Printer6.Print(v_rsPrint.Fields("FirstName"))
			Printer6.CurrentX = 2940
			Printer6.Print(v_rsPrint.Fields("LastName"))
			Printer6.CurrentX = 5140
			Printer6.PrintLine(v_rsPrint.Fields("TelNo"))
			v_rsPrint.MoveNext()
		End While
		Printer6.EndDoc()
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

	Private Sub pdi_PrintPreview_Click() Handles pdi_PrintPreview.Click
		frm_PrintPreview = Nothing
		
		With frm_PrintPreview
			.pic_Preview.Width = Printer6.Width
			.pic_Preview.Height = Printer6.Height
			.pic_Shadow.Width = .pic_Preview.Width
			.pic_Shadow.Height = .pic_Preview.Height
			
			.pic_Preview.ScaleLeft = Printer6.ScaleLeft
			.pic_Preview.ScaleTop = Printer6.ScaleTop
			.pic_Preview.ScaleWidth = Printer6.ScaleWidth
			.pic_Preview.ScaleHeight = Printer6.ScaleHeight
			.pic_Shadow.ScaleWidth = .pic_Preview.ScaleWidth
			.pic_Shadow.ScaleHeight = .pic_Preview.ScaleHeight
			
			Call MakePrintPreview()
			.Show(VBRUN.FormShowConstants.vbModal)
		End With
	End Sub

	Private Sub pdi_ShowPhoneBook_Click() Handles pdi_ShowPhoneBook.Click
		Me.pdi_ShowPhoneBook.Visible = False
		Me.Separator01.Visible = False
		Me.pdi_SystemTrayIcon.Checked = False
		pSystemTrayOnly = False
		Me.Show()
	End Sub

	Private Sub pdi_SystemTrayIcon_Click() Handles pdi_SystemTrayIcon.Click
		Me.pdi_SystemTrayIcon.Checked = True
		Me.Hide()
		pSystemTrayOnly = True
	End Sub

	Private Sub tab_Main_Click()
		Dim v_sSQL As String = "SELECT * FROM PhoneBook WHERE FirstName Like "
		Dim v_sActiveConnection As String = ""
		Dim v_iLoop As Short
		Dim v_iIndex As Short
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		
		For v_iLoop = 1 To Me.lvw_PhoneBook.ListItems.Count
			Me.lvw_PhoneBook.ListItems.Remove(1)
		Next
		
		v_rsPhoneBook = New ADODB.Recordset()
		Select Case Me.tab_Main.SelectedItem.Index
		Case 1
			v_rsPhoneBook.Open(v_sSQL & "'A%' OR FirstName LIKE 'B%' OR FirstName LIKE 'C%' ORDER BY FirstName", v_sActiveConnection)
		Case 2
			v_rsPhoneBook.Open(v_sSQL & "'D%' OR FirstName LIKE 'E%' OR FirstName LIKE 'F%' ORDER BY FirstName", v_sActiveConnection)
		Case 3
			v_rsPhoneBook.Open(v_sSQL & "'G%' OR FirstName LIKE 'H%' OR FirstName LIKE 'I%' ORDER BY FirstName", v_sActiveConnection)
		Case 4
			v_rsPhoneBook.Open(v_sSQL & "'J%' OR FirstName LIKE 'K%' OR FirstName LIKE 'L%' ORDER BY FirstName", v_sActiveConnection)
		Case 5
			v_rsPhoneBook.Open(v_sSQL & "'M%' OR FirstName LIKE 'N%' OR FirstName LIKE 'O%' ORDER BY FirstName", v_sActiveConnection)
		Case 6
			v_rsPhoneBook.Open(v_sSQL & "'P%' OR FirstName LIKE 'Q%' OR FirstName LIKE 'R%' ORDER BY FirstName", v_sActiveConnection)
		Case 7
			v_rsPhoneBook.Open(v_sSQL & "'S%' OR FirstName LIKE 'T%' OR FirstName LIKE 'U%' ORDER BY FirstName", v_sActiveConnection)
		Case 8
			v_rsPhoneBook.Open(v_sSQL & "'V%' OR FirstName LIKE 'W%' OR FirstName LIKE 'X%' ORDER BY FirstName", v_sActiveConnection)
		Case 9
			v_rsPhoneBook.Open(v_sSQL & "'Y%' OR FirstName LIKE 'Z%' ORDER BY FirstName", v_sActiveConnection)
		End Select
		
		While Not v_rsPhoneBook.EOF
			v_iIndex += 1
			Me.lvw_PhoneBook.ListItems.Add(, , v_rsPhoneBook.Fields("FirstName"))
			Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(1, , v_rsPhoneBook.Fields("LastName"))
			Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(2, , v_rsPhoneBook.Fields("TelNo"))
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPhoneBook.Fields("EMail").Value'. Consider using the GetDefaultMember6 helper method.
			If Not IsNull6(v_rsPhoneBook.Fields("EMail").Value) Then 
				Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(3, , v_rsPhoneBook.Fields("EMail"))
			End If
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'v_rsPhoneBook.Fields("Address").Value'. Consider using the GetDefaultMember6 helper method.
			If Not IsNull6(v_rsPhoneBook.Fields("Address").Value) Then 
				Me.lvw_PhoneBook.ListItems(v_iIndex).ListSubItems.Add(4, , v_rsPhoneBook.Fields("Address"))
			End If
			v_rsPhoneBook.MoveNext()
		End While
	End Sub

End Class
