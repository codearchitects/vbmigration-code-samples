' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CLine
	Implements IShape

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------------------------
	' The CLine Class
	'----------------------------------------------

	Public X As Single
	Public Y As Single
	Public X2 As Single
	Public Y2 As Single
	Public Color As Integer
	
	' this is required by the IShape interface
	Private Hidden As Boolean
	
	Private Sub Class_Initialize_VB6()
		Color = VBRUN.ColorConstants.vbBlack
	End Sub

	' a simple constructor for ease of use
	
	Friend Sub Init(ByRef X As Single, ByRef Y As Single, ByRef X2 As Single, ByRef Y2 As Single, Optional ByRef Color As Object = VB6Missing)
		Me.X = X
		Me.Y = Y
		Me.X2 = X2
		Me.Y2 = Y2
		If Not IsMissing6(Color) Then  Me.Color = GetDefaultMember6(Color)
	End Sub

	' Implementation of the IShape Interface
	
	Private Sub IShape_Draw(ByRef pic As Object) Implements IShape.Draw
		If Hidden Then  Exit Sub
		pic.Line(VBRUN.GraphicsOptions.None, X, Y, X2, Y2, Color)
	End Sub

	Private Sub IShape_Move(ByRef stepX As Single, ByRef stepY As Single) Implements IShape.Move
		X += stepX
		Y += stepY
		X2 += stepX
		Y2 += stepY
	End Sub

	Private Property IShape_Hidden() As Boolean Implements IShape.Hidden
		Get
			Return Hidden
	 	End Get
		Set(ByVal RHS As Boolean)
			Hidden = RHS
	 	End Set
	End Property

	Private Sub IShape_Zoom(ByRef ZoomFactor As Single) Implements IShape.Zoom
		Dim XC As Single
		Dim YC As Single
		' Evaluate the middle point on the line.
		XC = (X + X2) / 2: YC = (Y + Y2) / 2
		' Zoom the line.
		X = XC - (XC - X) * ZoomFactor: X2 = XC - (XC - X2) * ZoomFactor
		Y = YC - (YC - Y) * ZoomFactor: Y2 = YC - (YC - Y2) * ZoomFactor
	End Sub

End Class
