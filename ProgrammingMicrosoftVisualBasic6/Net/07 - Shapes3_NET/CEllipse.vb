' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CEllipse
	Implements IShape

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------------------------
	' The CEllipse Class
	'----------------------------------------------

	Public Left As Single
	Public Top As Single
	Public Width As Single
	Public Height As Single
	Public color As Integer
	Public FillColor As Integer
	
	' this is required by the IShape interface
	Private Hidden As Boolean
	
	Private Sub Class_Initialize_VB6()
		color = VBRUN.ColorConstants.vbBlack
		FillColor = -1 ' any negative value means "unfilled"
	End Sub

	' simple constructor for ease of use
	
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
		
		Dim aspect As Single
		Dim radius As Single
		Dim saveFillColor As Integer
		Dim saveFillStyle As Integer
		aspect = Height / Width
		radius = IIf(Width > Height, Width / 2, Height / 2)
		If FillColor >= 0 Then 
			saveFillColor = GetDefaultMember6(pic.FillColor)
			saveFillStyle = GetDefaultMember6(pic.FillStyle)
			pic.FillColor = FromOleColor6(FillColor)
			pic.FillStyle = VBRUN.DrawStyleConstants.vbSolid
			pic.Circle(VBRUN.GraphicsOptions.None, Left + Width / 2, Top + Height / 2, radius, color, , , aspect)
			pic.FillColor = FromOleColor6(saveFillColor)
			pic.FillStyle = saveFillStyle
		Else
			pic.Circle(VBRUN.GraphicsOptions.None, Left + Width / 2, Top + Height / 2, radius, color, , , aspect)
		End If
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
