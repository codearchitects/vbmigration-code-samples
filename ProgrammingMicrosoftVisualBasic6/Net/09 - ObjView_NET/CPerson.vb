' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'DAO' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CPerson

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	Public Event Change(ByRef PropertyName As String)
	
	' private members
	Private m_Name As String = ""
	Private m_Address As String = ""
	Private m_City As String = ""
	Private m_Married As Boolean
	
	' The Name property

	Public Property Name() As String
		Get
			Return m_Name
	 	End Get
		Set(ByVal newValue As String)
			' it is very important that the new value is checked always
			If newValue = "" Then  Err.Raise(5, , "Invalid Value for Name property")
			If m_Name <> newValue Then 
				m_Name = newValue
				PropertyChanged("Name")
			End If
	 	End Set
	End Property

	' The Address Property

	Public Property Address() As String
		Get
			Return m_Address
	 	End Get
		Set(ByVal newValue As String)
			If newValue = "" Then  Err.Raise(5, , "Invalid Value for Address property")
			If m_Address <> newValue Then 
				m_Address = newValue
				PropertyChanged("Address")
			End If
	 	End Set
	End Property

	' the City property

	Public Property City() As String
		Get
			Return m_City
	 	End Get
		Set(ByVal newValue As String)
			If newValue = "" Then  Err.Raise(5, , "Invalid Value for City property")
			If m_City <> newValue Then 
				m_City = newValue
				PropertyChanged("City")
			End If
	 	End Set
	End Property

	' the Married property

	Public Property Married() As Boolean
		Get
			Return m_Married
	 	End Get
		Set(ByVal newValue As Boolean)
			If m_Married <> newValue Then 
				m_Married = newValue
				PropertyChanged("Married")
			End If
	 	End Set
	End Property

	' the PropertyChanged private method raises a Change event in the client code
	
	Private Sub PropertyChanged(ByRef PropertyName As String)
	' UPGRADE_INFO (#0551): The 'PropertyName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		RaiseEvent Change(PropertyName)
	End Sub

End Class
