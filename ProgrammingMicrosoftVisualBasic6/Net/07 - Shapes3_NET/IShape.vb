' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<CodeArchitects.VB6Library.VB6Annotation(UseClassSuffix:=True)> _ 
Friend Class IShapeClass
	Implements IShape

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	' The IShape interface
	
	' UPGRADE_INFO (#0261): The 'Hidden' variable has been transformed into a property because it must implement an interface member.
	Private Hidden_InnerField As Boolean
	Public Property Hidden() As Boolean Implements IShape.Hidden
		Get
			Return Hidden_InnerField
		End Get
		Set(ByVal value As Boolean)
			Hidden_InnerField = value
		End Set
	End Property

	Public Sub Draw(ByRef pic As Object) Implements IShape.Draw
		'
	End Sub

	Public Sub Move(ByRef stepX As Single, ByRef stepY As Single) Implements IShape.Move
		'
	End Sub

	Public Sub Zoom(ByRef ZoomFactor As Single) Implements IShape.Zoom
		'
	End Sub

End Class

Friend Interface IShape
	Property Hidden() As Boolean
	Sub Draw(ByRef pic As Object)
	Sub Move(ByRef stepX As Single, ByRef stepY As Single)
	Sub Zoom(ByRef ZoomFactor As Single)
End Interface

