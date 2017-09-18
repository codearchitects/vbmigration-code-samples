' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Command1_Click() Handles Command1.Click
		Dim pers As CPerson = New CPerson() ' declaration
		' creation
		pers.FirstName = "John" ' assign some properties
		pers.LastName = "Delgado"
		pers.BirthDate = "1 sep 1960"
		
		' an alternative that uses a constructor method
		pers = Factory.New_CPerson("John", "Delgado", 1, "1 sep 1960")
		
		PrintLine(pers.CompleteName)
		PrintLine(pers.ReverseName())
		PrintLine(pers.Age)
		
		pers.MaritalStatus = MaritalStatusConstants.Divorced
		pers.HomeAddress = New CAddress()
		pers.HomeAddress.Init("1234 North Rd", "Los Angeles", "CA", "92405")
		PrintLine(pers.HomeAddress.CompleteAddress)
		
		pers.WorkAddress = New CAddress()
		pers.WorkAddress.Street = pers.HomeAddress.Street

		' try with a regular string value
		pers.CurrentAddress = "test address"
		PrintLine(pers.CurrentAddress)
		' try with an object value
		pers.CurrentAddress = pers.HomeAddress
		PrintLine(pers.CurrentAddress.CompleteAddress)

	End Sub

End Class
