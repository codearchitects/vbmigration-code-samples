' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CSquare
	Implements IShape
	Implements CRectangle

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------------------------
	' The CSquare Class
	'----------------------------------------------

	' this is the private instance of the CRectangle class
	Private Rect As CRectangle
	' this points the Rect's IShape interface
	Private RectShape As IShape
	
	Private Sub Class_Initialize_VB6()
		' create the two variables for doing the delegation
		Rect = New CRectangleClass()
		RectShape = Rect
	End Sub

	' a simple constructor for ease of use
	
	Friend Sub Init(ByRef Left As Single, ByRef Top As Single, ByRef Width As Single, Optional ByRef Color As Object = VB6Missing, Optional ByRef FillColor As Object = VB6Missing)
		Me.Left = Left
		Me.Top = Top
		Me.Width = Width
		If Not IsMissing6(Color) Then  Me.Color = GetDefaultMember6(Color)
		If Not IsMissing6(FillColor) Then  Me.FillColor = GetDefaultMember6(FillColor)
	End Sub

	' delegation code
	
	Public Property Left() As Single
		Get
			Return Rect.Left
	 	End Get
		Set(ByVal newValue As Single)
			Rect.Left = newValue
	 	End Set
	End Property

	Public Property Top() As Single
		Get
			Return Rect.Top
	 	End Get
		Set(ByVal newValue As Single)
			Rect.Top = newValue
	 	End Set
	End Property

	Public Property Width() As Single
		Get
			Return Rect.Width
	 	End Get
		Set(ByVal newValue As Single)
			' squares are rectangles whose Width = Height
			Rect.Width = newValue
			Rect.Height = newValue
	 	End Set
	End Property

	Public Property Color() As Integer
		Get
			Return Rect.color
	 	End Get
		Set(ByVal newValue As Integer)
			Rect.color = newValue
	 	End Set
	End Property

	Public Property FillColor() As Integer
		Get
			Return Rect.FillColor
	 	End Get
		Set(ByVal newValue As Integer)
			Rect.FillColor = newValue
	 	End Set
	End Property

	' The IShape interface
	
	Private Sub IShape_Draw(ByRef pic As Object) Implements IShape.Draw
		RectShape.Draw(pic)
	End Sub

	Private Property IShape_Hidden() As Boolean Implements IShape.Hidden
		Get
			Return RectShape.Hidden
	 	End Get
		Set(ByVal RHS As Boolean)
			RectShape.Hidden = RHS
	 	End Set
	End Property

	Private Sub IShape_Move(ByRef stepX As Single, ByRef stepY As Single) Implements IShape.Move
		RectShape.Move(stepX, stepY)
	End Sub

	Private Sub IShape_Zoom(ByRef ZoomFactor As Single) Implements IShape.Zoom
		RectShape.Zoom(ZoomFactor)
	End Sub

	' the CRectangle interface

	Private Property CRectangle_Color() As Integer Implements CRectangle.Color
		Get
			Return Rect.color
	 	End Get
		Set(ByVal RHS As Integer)
			Rect.color = RHS
	 	End Set
	End Property

	Private Property CRectangle_FillColor() As Integer Implements CRectangle.FillColor
		Get
			Return Rect.FillColor
	 	End Get
		Set(ByVal RHS As Integer)
			Rect.FillColor = RHS
	 	End Set
	End Property

	Private Property CRectangle_Height() As Single Implements CRectangle.Height
		Get
			Return Rect.Height
	 	End Get
		Set(ByVal RHS As Single)
			Rect.Height = RHS
	 	End Set
	End Property

	Private Property CRectangle_Left() As Single Implements CRectangle.Left
		Get
			Return Rect.Left
	 	End Get
		Set(ByVal RHS As Single)
			Rect.Left = RHS
	 	End Set
	End Property

	Private Property CRectangle_Top() As Single Implements CRectangle.Top
		Get
			Return Rect.Top
	 	End Get
		Set(ByVal RHS As Single)
			Rect.Top = RHS
	 	End Set
	End Property

	Private Property CRectangle_Width() As Single Implements CRectangle.Width
		Get
			Return Rect.Width
	 	End Get
		Set(ByVal RHS As Single)
			Rect.Width = RHS
	 	End Set
	End Property

End Class
