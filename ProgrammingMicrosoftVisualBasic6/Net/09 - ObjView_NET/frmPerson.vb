' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmPerson

	' the associated CPerson object
	Private WithEvents ThisPerson As CPerson
	
	Public Property Person() As CPerson
		Get
			Return ThisPerson
	 	End Get
		Set(ByVal newValue As CPerson)
			' initialize the private object and form fields
			ThisPerson = newValue
			With ThisPerson
				txtName.Text = .Name
				txtAddress.Text = .Address
				txtCity.Text = .City
				chkMarried.Value = Abs6(CShort(.Married))
			End With
	 	End Set
	End Property

	Private Sub txtName_Change() Handles txtName.Change
		' if key-level notification is active
		If NotifyMode = 2 Then  ThisPerson.Name = txtName.Text
	End Sub

	Private Sub txtName_LostFocus() Handles txtName.LostFocus
		' if field-level notification is active
		If NotifyMode = 1 Then  ThisPerson.Name = txtName.Text
	End Sub

	Private Sub txtAddress_Change() Handles txtAddress.Change
		' if key-level notification is active
		If NotifyMode = 2 Then  ThisPerson.Address = txtAddress.Text
	End Sub

	Private Sub txtAddress_LostFocus() Handles txtAddress.LostFocus
		' if field-level notification is active
		If NotifyMode = 1 Then  ThisPerson.Address = txtAddress.Text
	End Sub

	Private Sub txtCity_Change() Handles txtCity.Change
		' if key-level notification is active
		If NotifyMode = 2 Then  ThisPerson.City = txtCity.Text
	End Sub

	Private Sub txtCity_LostFocus() Handles txtCity.LostFocus
		' if field-level notification is active
		If NotifyMode = 1 Then  ThisPerson.City = txtCity.Text
	End Sub

	Private Sub chkMarried_Click() Handles chkMarried.Click
		' if key-level notification is active
		If NotifyMode = 2 Then  ThisPerson.Married = chkMarried.Value
	End Sub

	Private Sub chkMarried_LostFocus() Handles chkMarried.LostFocus
		' if field-level notification is active
		If NotifyMode = 1 Then  ThisPerson.Married = chkMarried.Value
	End Sub

	Private Sub ThisPerson_Change(ByRef PropertyName As String) Handles ThisPerson.Change
		Select Case PropertyName
		Case "Name"
			txtName.Text = ThisPerson.Name
		Case "Address"
			txtAddress.Text = ThisPerson.Address
		Case "City"
			txtCity.Text = ThisPerson.City
		Case "Married"
			chkMarried.Value = Abs6(CShort(ThisPerson.Married))
		End Select
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		' validate all properties
		On Error Resume Next 
		
		ThisPerson.Name = txtName.Text
		If Err.Number Then 
			MsgBox6(Err.Description)
			txtName.SetFocus()
			Exit Sub
		End If
		
		ThisPerson.Address = txtAddress.Text
		If Err.Number Then 
			MsgBox6(Err.Description)
			txtAddress.SetFocus()
			Exit Sub
		End If
		
		ThisPerson.City = txtCity.Text
		If Err.Number Then 
			MsgBox6(Err.Description)
			txtCity.SetFocus()
			Exit Sub
		End If
		
		ThisPerson.Married = chkMarried.Value
		' error checking is not necessary here, but this is a good programming
		' practice, in case we later add validation in the CPerson class
		If Err.Number Then 
			MsgBox6(Err.Description)
			txtName.SetFocus()
			Exit Sub
		End If
		
	End Sub

End Class
