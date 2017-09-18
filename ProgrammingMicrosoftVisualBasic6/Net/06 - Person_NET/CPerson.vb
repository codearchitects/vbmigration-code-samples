' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Public Enum SexConstants
	Male = 1
	Female
End Enum

Public Enum MaritalStatusConstants
	NotMarried = 1
	Married
	Divorced
	Widower
	MARITALSTATUS_MAX = Widower
End Enum

Friend Class CPerson

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region

	' private members
	Private m_FirstName As String = ""
	Private m_LastName As String = ""
	Private m_BirthDate As Date
	Private m_Citizenship As String = ""
	Private m_ID As Object
	Private m_ReverseName As Object
	Private m_Notes As New VB6Array(Of String)(1, 10)
	Private m_Sex As SexConstants
	Private m_MaritalStatus As MaritalStatusConstants
	
	' object properties
	Private m_HomeAddress As CAddress
	Private m_WorkAddress As CAddress
	Private m_VacationAddress As CAddress
	' object/regular property
	Private m_CurrentAddress As Object
	
	Private Sub Class_Initialize_VB6()
		m_Citizenship = "American"
	End Sub

	' a constructor method
	
	Friend Sub Init(ByRef FirstName As String, ByRef LastName As String, Optional ByRef ID As Object = VB6Missing, Optional ByRef BirthDate As Object = VB6Missing)
		Me.FirstName = FirstName
		Me.LastName = LastName
		If Not IsMissing6(ID) Then  Me.ID = ID
		If Not IsMissing6(BirthDate) Then  Me.BirthDate = BirthDate
	End Sub

	' the first name

	Public Property FirstName() As String
		Get
			' simply return the current value of the member variable
			Return m_FirstName
	 	End Get
		Set(ByVal newValue As String)
			' raise an error if an invalid assignment is attempted
			If newValue = "" Then  Err.Raise(5) ' invalid procedure argument
			' else store in the private member variable
			m_FirstName = newValue
			m_ReverseName = VB6Empty
	 	End Set
	End Property

	' the last name

	Public Property LastName() As String
		Get
			' simply return the current value of the member variable
			Return m_LastName
	 	End Get
		Set(ByVal newValue As String)
			' raise an error if an invalid assignment is attempted
			If newValue = "" Then  Err.Raise(5) ' invalid procedure argument
			' else store in the private member variable
			m_LastName = newValue
			m_ReverseName = VB6Empty
	 	End Set
	End Property

	' the birth date

	Public Property BirthDate() As Date
		Get
			Return m_BirthDate
	 	End Get
		Set(ByVal newValue As Date)
			If newValue >= Now Then  Err.Raise(1001, , "Can't be a future Birth Date")
			m_BirthDate = newValue
	 	End Set
	End Property

	' the complete name

	Public Property CompleteName() As String
		Get
			Return FirstName & " " & LastName
	 	End Get
		Set(ByVal newValue As String)
			Dim items() As String
			items = Split(newValue)
			' we expect exactly two items (no support for middle names)
			If UBound6(items) <> 1 Then  Err.Raise(5)
			' assign to main properties
			FirstName = items(0)
			LastName = items(1)
	 	End Set
	End Property

	' reversed name
	
	Public Function ReverseName() As String
		If IsEmpty6(m_ReverseName) Then 
			m_ReverseName = LastName & ", " & FirstName
		End If
		Return m_ReverseName
	End Function

	' the current age (this year)
	
	Public ReadOnly Property Age() As Short
		Get
			Return Year(Now) - Year(BirthDate)
	 	End Get
	End Property

	' Citizenship as a string

	Public Property Citizenship() As String
		Get
			Return m_Citizenship
	 	End Get
		Set(ByVal newValue As String)
			m_Citizenship = newValue
	 	End Set
	End Property

	' ID property (write-once, read-many)

	Public Property ID() As Integer
		Get
			Return m_ID
	 	End Get
		Set(ByVal newValue As Integer)
			If Not IsEmpty6(m_ID) Then  Err.Raise(1002, , "Write-once property")
			m_ID = newValue
	 	End Set
	End Property

	' The Notes property (array)

	Public Property Notes(Optional ByVal index As Short = 0) As String
		Get
			Return m_Notes(index)
	 	End Get
		Set(ByVal newValue As String)
			' check for subscript out of range error
			If index < LBound6(m_Notes) Or index > UBound6(m_Notes) Then  Err.Raise(9)
			m_Notes(index) = newValue
	 	End Set
	End Property

	' The Sex property

	Public Property Sex() As SexConstants
		Get
			Return m_Sex
	 	End Get
		Set(ByVal newValue As SexConstants)
			' refuse invalid assignments
			If newValue <> SexConstants.Male And newValue <> SexConstants.Female Then  Err.Raise(5)
			m_Sex = newValue
	 	End Set
	End Property

	' The MaritalStatus property

	Public Property MaritalStatus() As MaritalStatusConstants
		Get
			Return m_MaritalStatus
	 	End Get
		Set(ByVal newValue As MaritalStatusConstants)
			' refuse invalid assignments (assumes that zero is always invalid)
			If newValue < 0 Or newValue > MaritalStatusConstants.MARITALSTATUS_MAX Then  Err.Raise(5)
			m_MaritalStatus = newValue
	 	End Set
	End Property

	' the MaritalStatusDescr property

	Public Property MaritalStatusDescr() As String
		Get
			Select Case m_MaritalStatus
			Case MaritalStatusConstants.NotMarried: Return "NotMarried"
			Case MaritalStatusConstants.Married: Return "Married"
			Case MaritalStatusConstants.Divorced: Return "Divorced"
			Case MaritalStatusConstants.Widower
				If Sex = SexConstants.Male Then 
					Return "Widower"
				ElseIf Sex = SexConstants.Female Then 
					Return "Widow"
				End If
			Case Else
				Err.Raise(5) ' defensive programming
			End Select
	 	End Get
		Set(ByVal newValue As String)
			Select Case LCase(newValue)
			Case "notmarried": MaritalStatus = MaritalStatusConstants.NotMarried
			Case "married": MaritalStatus = MaritalStatusConstants.Married
			Case "divorced": MaritalStatus = MaritalStatusConstants.Divorced
			Case "widower", "widow": MaritalStatus = MaritalStatusConstants.Widower
			Case Else
				Err.Raise(5) ' error otherwise
			End Select
	 	End Set
	End Property

	' The WorkAddress property

	Public Property WorkAddress() As CAddress
		Get
			Return m_WorkAddress
	 	End Get
		Set(ByVal newValue As CAddress)
			m_WorkAddress = newValue
	 	End Set
	End Property

	' The HomeAddress property

	Public Property HomeAddress() As CAddress
		Get
			Return m_HomeAddress
	 	End Get
		Set(ByVal newValue As CAddress)
			m_HomeAddress = newValue
	 	End Set
	End Property

	' The VacationAddress property

	Public Property VacationAddress() As CAddress
		Get
			Return m_VacationAddress
	 	End Get
		Set(ByVal newValue As CAddress)
			m_VacationAddress = newValue
	 	End Set
	End Property

	' the CurrentAddress property
	' (example of a Variant property that can also hold an object)

	Public Property CurrentAddress() As Object
		Get
				Return m_CurrentAddress	 	End Get
		Set(ByVal newValue As Object)
			If Not IsObject6(newValue) Then
				If VarType6(newValue) <> VariantType.String Then  Err.Raise(5)
				m_CurrentAddress = newValue
		 		Else
				' the next line is useless because the object type is
				' tested automatically by VB compiler
				' If TypeName(newValue) <> "CAddress" Then Err.Raise 5
				m_CurrentAddress = newValue
		 		End If
		End Set
	End Property

End Class
