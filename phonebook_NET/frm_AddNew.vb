' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frm_AddNew

	Private Sub btn_Cancel_Click() Handles btn_Cancel.Click
		Unload6(Me)
	End Sub

	Private Sub btn_Add_Click() Handles btn_Add.Click
		Dim v_rsAdd As New ADODB.RecordsetClass
		Dim v_sActiveConnection As String = ""
		
		On Error GoTo Err 
		
		If Me.tbx_FirstName.Text = "" Or Me.tbx_LastName.Text = "" Or Me.tbx_TelNo.Text = "" Then 
			MsgBox6("You should fill all the textboxes.", MsgBoxStyle.Critical, "Phone Book")
			Exit Sub
		End If
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		v_rsAdd.Open("SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
		
		v_rsAdd.AddNew()
		If Me.tbx_FirstName.Text = "" Then 
			v_rsAdd.Fields("FirstName").Value = ""
		Else
			v_rsAdd.Fields("FirstName").Value = Me.tbx_FirstName.Text
		End If
		
		If Me.tbx_LastName.Text = "" Then 
			v_rsAdd.Fields("LastName").Value = ""
		Else
			v_rsAdd.Fields("LastName").Value = Me.tbx_LastName.Text
		End If
		
		If Me.tbx_TelNo.Text = "" Then 
			v_rsAdd.Fields("TelNo").Value = ""
		Else
			v_rsAdd.Fields("TelNo").Value = Me.tbx_TelNo.Text
		End If
		
		If Me.tbx_EMail.Text = "" Then 
			v_rsAdd.Fields("EMail").Value = ""
		Else
			v_rsAdd.Fields("EMail").Value = Me.tbx_EMail.Text
		End If
		
		If Me.tbx_Address.Text = "" Then 
			v_rsAdd.Fields("Address").Value = ""
		Else
			v_rsAdd.Fields("Address").Value = Me.tbx_Address.Text
		End If
		v_rsAdd.Update()
		Unload6(Me)
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

End Class
