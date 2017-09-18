' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Factory

	' an external constructor method for CPerson
	
	Public Function New_CPerson(ByRef FirstName As String, ByRef LastName As String, Optional ByRef ID As Object = VB6Missing, Optional ByRef BirthDate As Object = VB6Missing) As CPerson
		' you don't need a temporary local variable
		New_CPerson = New CPerson()
		New_CPerson.Init(FirstName, LastName, ID, BirthDate)
	End Function

	' an external constructor method for CAddress
	
	Public Function New_CAddress(ByRef Street As String, ByRef City As String, ByRef State As String, ByRef Zip As String, Optional ByRef Country As Object = VB6Missing, Optional ByRef Phone As Object = VB6Missing) As CAddress
		New_CAddress = New CAddress()
		New_CAddress.Init(Street, City, State, Zip, Country, Phone)
	End Function

End Module
