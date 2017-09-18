' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<CodeArchitects.VB6Library.VB6Annotation(UseClassSuffix:=True)> _ 
Friend Class CRectangleClass
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
	' The CRectangle Class
	'----------------------------------------------

	' UPGRADE_INFO (#0261): The 'Left' variable has been transformed into a property because it must implement an interface member.
	Private Left_InnerField As Single
	Public Property Left() As Single Implements CRectangle.Left
		Get
			Return Left_InnerField
		End Get
		Set(ByVal value As Single)
			Left_InnerField = value
		End Set
	End Property

	' UPGRADE_INFO (#0261): The 'Top' variable has been transformed into a property because it must implement an interface member.
	Private Top_InnerField As Single
	Public Property Top() As Single Implements CRectangle.Top
		Get
			Return Top_InnerField
		End Get
		Set(ByVal value As Single)
			Top_InnerField = value
		End Set
	End Property

	' UPGRADE_INFO (#0261): The 'Width' variable has been transformed into a property because it must implement an interface member.
	Private Width_InnerField As Single
	Public Property Width() As Single Implements CRectangle.Width
		Get
			Return Width_InnerField
		End Get
		Set(ByVal value As Single)
			Width_InnerField = value
		End Set
	End Property

	' UPGRADE_INFO (#0261): The 'Height' variable has been transformed into a property because it must implement an interface member.
	Private Height_InnerField As Single
	Public Property Height() As Single Implements CRectangle.Height
		Get
			Return Height_InnerField
		End Get
		Set(ByVal value As Single)
			Height_InnerField = value
		End Set
	End Property

	' UPGRADE_INFO (#0261): The 'color' variable has been transformed into a property because it must implement an interface member.
	Private color_InnerField As Integer
	Public Property color() As Integer Implements CRectangle.color
		Get
			Return color_InnerField
		End Get
		Set(ByVal value As Integer)
			color_InnerField = value
		End Set
	End Property

	' UPGRADE_INFO (#0261): The 'FillColor' variable has been transformed into a property because it must implement an interface member.
	Private FillColor_InnerField As Integer
	Public Property FillColor() As Integer Implements CRectangle.FillColor
		Get
			Return FillColor_InnerField
		End Get
		Set(ByVal value As Integer)
			FillColor_InnerField = value
		End Set
	End Property

	' this is required by the IShape interface
	Private Hidden As Boolean
	
	Private Sub Class_Initialize_VB6()
		color = VBRUN.ColorConstants.vbBlack
		FillColor = -1 ' any negative value means "unfilled"
	End Sub

	' a simple constructor for ease of use
	
	Friend Sub Init(ByRef Left As Single, ByRef Top As Single, ByRef Width As Single, ByRef Height As Single, Optional ByRef color As Object = VB6Missing, Optional ByRef FillColor As Object = VB6Missing)
		Me.Left = Left
		Me.Top = Top
		Me.Width = Width
		Me.Height = Height
		If Not IsMissing6(color) Then  Me.color = GetDefaultMember6(color)
		If Not IsMissing6(FillColor) Then  Me.FillColor = GetDefaultMember6(FillColor)
	End Sub

	' Implementation of the IShape interface
	
	Private Sub IShape_Draw(ByRef pic As Object) Implements IShape.Draw
		If Hidden Then  Exit Sub
		If FillColor >= 0 Then 
			pic.Line(VBRUN.GraphicsOptions.Step2 Or VBRUN.GraphicsOptions.BoxFilled, Left, Top, Width, Height, FillColor)
		End If
		pic.Line(VBRUN.GraphicsOptions.Step2 Or VBRUN.GraphicsOptions.Box, Left, Top, Width, Height, color)
	End Sub

	Private Sub IShape_Move(ByRef stepX As Single, ByRef stepY As Single) Implements IShape.Move
		Left += stepX
		Top += stepY
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
		Left = Left + Width * (1 - ZoomFactor) / 2
		Top = Top + Height * (1 - ZoomFactor) / 2
		Width *= ZoomFactor
		Height *= ZoomFactor
	End Sub

End Class

Friend Interface CRectangle
	Property Left() As Single
	Property Top() As Single
	Property Width() As Single
	Property Height() As Single
	Property color() As Integer
	Property FillColor() As Integer
End Interface

