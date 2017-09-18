' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CAddress

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'--------------------------------------
	' The CAddress class (from Chap 06)
	'--------------------------------------

	' for the sake of simplicity, all properties are declared as Public members
	Public Street As String = ""
	Public City As String = ""
	Public State As String = ""
	Public Zip As String = ""
	Public Country As String = ""
	Public Phone As String = ""
	
	Private Const Country_DEF As String = "USA"
	' a reasonable default value for Country property
	
	Private Sub Class_Initialize_VB6()
		Country = Country_DEF
	End Sub

	' a constructor method
	
	Friend Sub Init(ByRef Street As String, ByRef City As String, ByRef State As String, ByRef Zip As String, Optional ByRef Country As Object = VB6Missing, Optional ByRef Phone As Object = VB6Missing)
		Me.Street = Street
		Me.City = City
		Me.State = State
		Me.Zip = Zip
		If Not IsMissing6(Country) Then  Me.Country = Country
		If Not IsMissing6(Phone) Then  Me.Phone = Phone
	End Sub

	' return the complete address (read-only property)
	' includes the country if different from the default value
	
	Public ReadOnly Property CompleteAddress() As String
		Get
			Return Street & ControlChars.CrLf & City & ", " & State & " " & Zip & IIf(Country <> Country_DEF, Country, "")
	 	End Get
	End Property

End Class
