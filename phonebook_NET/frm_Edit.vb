' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frm_Edit

	' This wrapper property has been added to preserve As New semantics of v_rsEdit variable
	Private Property v_rsEdit() As ADODB.Recordset
		Get
			If v_rsEdit_InnerField Is Nothing Then v_rsEdit_InnerField = New ADODB.RecordsetClass()
			Return v_rsEdit_InnerField
		End Get
		Set(value As ADODB.Recordset)
			v_rsEdit_InnerField = value
		End Set
	End Property
	
	Private v_rsEdit_InnerField As ADODB.Recordset
	
	Private Sub btn_Close_Click() Handles btn_Close.Click
		Unload6(Me)
	End Sub

	Private Sub btn_Delete_Click() Handles btn_Delete.Click
		Dim v_iMsg As Short
		
		On Error GoTo Err 
		
		v_iMsg = MsgBox6("Are you sure you want to delete this person?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Phone Book")
		If v_iMsg = MsgBoxResult.Yes Then 
			v_rsEdit.Delete()
			If Not v_rsEdit.EOF Then 
				v_rsEdit.MoveNext()
			End If
		Else
			Exit Sub
		End If
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

	Private Sub btn_First_Click() Handles btn_First.Click
		v_rsEdit.MoveFirst()
	End Sub

	Private Sub btn_Last_Click() Handles btn_Last.Click
		v_rsEdit.MoveLast()
	End Sub

	Private Sub btn_Next_Click() Handles btn_Next.Click
		If Not v_rsEdit.EOF Then  v_rsEdit.MoveNext()
		If v_rsEdit.EOF Then 
			Beep()
			v_rsEdit.MoveLast()
		End If
	End Sub

	Private Sub btn_Previous_Click() Handles btn_Previous.Click
		If Not v_rsEdit.BOF Then  v_rsEdit.MovePrevious()
		If v_rsEdit.BOF Then 
			Beep()
			v_rsEdit.MoveFirst()
		End If
	End Sub

	Private Sub btn_Update_Click() Handles btn_Update.Click
		v_rsEdit.Update()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim v_sActiveConnection As String = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App6.Path & "\PhoneBook.mdb"
		
		v_rsEdit.Open("SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
		
		Me.tbx_FirstName.DataSource = v_rsEdit
		Me.tbx_FirstName.DataField = "FirstName"
		
		Me.tbx_LastName.DataSource = v_rsEdit
		Me.tbx_LastName.DataField = "LastName"
		
		Me.tbx_TelNo.DataSource = v_rsEdit
		Me.tbx_TelNo.DataField = "TelNo"
		
		Me.tbx_TelNo.DataSource = v_rsEdit
		Me.tbx_EMail.DataField = "EMail"
		
		Me.tbx_TelNo.DataSource = v_rsEdit
		Me.tbx_Address.DataField = "Address"
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		v_rsEdit = Nothing
	End Sub

End Class
