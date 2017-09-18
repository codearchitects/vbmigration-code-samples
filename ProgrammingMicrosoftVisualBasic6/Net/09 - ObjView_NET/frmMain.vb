' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Person1 As New CPerson
	Private Person2 As New CPerson
	
	Private Sub Form_Load() Handles MyBase.Load
		With Person1
			.Name = "John Smith"
			.Address = "12345 West Road"
			.City = "San Francisco"
			.Married = True
		End With
		With Person2
			.Name = "Anne Lipton"
			.Address = "345 East Street"
			.City = "Los Angeles"
			.Married = True
		End With
		
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		Dim frm As New frmPerson
		frm.Person = Person1
		frm.Show(, Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Dim frm As New frmPerson
		frm.Person = Person2
		frm.Show(, Me)
	End Sub

	Private Sub Option1_Click(ByRef Index As Short)
		NotifyMode = Index
	End Sub

End Class
