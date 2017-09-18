' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frm_Find

	Private Sub btn_Close_Click() Handles btn_Close.Click
		Unload6(Me)
	End Sub

	Private Sub btn_Find_Click() Handles btn_Find.Click
		Dim v_sSQL As String = ""
		Dim v_rsFind As New ADODB.RecordsetClass
		' UPGRADE_INFO (#0501): The 'v_iLoop' member isn't used anywhere in current application.
		Dim v_iLoop As Short
		Dim v_sActiveConnection As String = ""
		Dim v_iIndex As Short
		
		On Error GoTo Err 
		
		Me.lvw_Find.ListItems.Clear
		
		v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		v_sSQL = "SELECT * FROM PhoneBook WHERE "
		
		If Me.tbx_FirstName.Text <> "" Then 
			v_sSQL = v_sSQL & "FirstName LIKE '" & Me.tbx_FirstName.Text & "' AND "
		End If
		
		If Me.tbx_LastName.Text <> "" Then 
			v_sSQL = v_sSQL & "LastName LIKE '" & Me.tbx_LastName.Text & "' AND "
		End If
		
		If Me.tbx_TelNo.Text <> "" Then 
			v_sSQL = v_sSQL & "TelNo LIKE '" & Me.tbx_TelNo.Text & "' AND "
		End If
		
		If Me.tbx_EMail.Text <> "" Then 
			v_sSQL = v_sSQL & "EMail LIKE '" & Me.tbx_EMail.Text & "' AND "
		End If
		
		If Me.tbx_Address.Text <> "" Then 
			v_sSQL = v_sSQL & "Address LIKE '" & Me.tbx_Address.Text & "' AND "
		End If
		
		v_sSQL = VB.Left(v_sSQL, Len6(v_sSQL) - 5)
		v_rsFind.Open(v_sSQL, v_sActiveConnection)
		
		While Not v_rsFind.EOF
			v_iIndex += 1
			Me.lvw_Find.ListItems.Add(, , v_rsFind.Fields("FirstName"))
			Me.lvw_Find.ListItems(v_iIndex).ListSubItems.Add(1, , v_rsFind.Fields("LastName"))
			Me.lvw_Find.ListItems(v_iIndex).ListSubItems.Add(2, , v_rsFind.Fields("TelNo"))
			v_rsFind.MoveNext()
		End While
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

End Class
