' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CCustomer

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'---------------------------------------
	' The CCustomer sample class
	'---------------------------------------

	Public Name As String = ""
	' This wrapper property has been added to preserve As New semantics of Address variable
	Public Property Address() As CAddress
		Get
			If Address_InnerField Is Nothing Then Address_InnerField = New CAddress()
			Return Address_InnerField
		End Get
		Set(value As CAddress)
			Address_InnerField = value
		End Set
	End Property
	
	Private Address_InnerField As CAddress

End Class
