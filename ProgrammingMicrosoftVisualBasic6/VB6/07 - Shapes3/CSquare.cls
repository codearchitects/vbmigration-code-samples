VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CSquare"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------------------------
' The CSquare Class
'----------------------------------------------

Option Explicit

Implements IShape
Implements CRectangle

' this is the private instance of the CRectangle class
Private Rect As CRectangle
' this points the Rect's IShape interface
Private RectShape As IShape

Private Sub Class_Initialize()
    ' create the two variables for doing the delegation
    Set Rect = New CRectangle
    Set RectShape = Rect
End Sub

' a simple constructor for ease of use

Friend Sub Init(Left As Single, Top As Single, Width As Single, Optional Color As Variant, Optional FillColor As Variant)
    Me.Left = Left
    Me.Top = Top
    Me.Width = Width
    If Not IsMissing(Color) Then Me.Color = Color
    If Not IsMissing(FillColor) Then Me.FillColor = FillColor
End Sub

' delegation code

Property Get Left() As Single
    Left = Rect.Left
End Property
Property Let Left(ByVal newValue As Single)
    Rect.Left = newValue
End Property

Property Get Top() As Single
    Top = Rect.Top
End Property
Property Let Top(ByVal newValue As Single)
    Rect.Top = newValue
End Property

Property Get Width() As Single
    Width = Rect.Width
End Property
Property Let Width(ByVal newValue As Single)
    ' squares are rectangles whose Width = Height
    Rect.Width = newValue
    Rect.Height = newValue
End Property

Property Get Color() As Long
    Color = Rect.Color
End Property
Property Let Color(ByVal newValue As Long)
    Rect.Color = newValue
End Property

Property Get FillColor() As Long
    FillColor = Rect.FillColor
End Property
Property Let FillColor(ByVal newValue As Long)
    Rect.FillColor = newValue
End Property

' The IShape interface

Private Sub IShape_Draw(pic As Object)
    RectShape.Draw pic
End Sub

Private Property Let IShape_Hidden(ByVal RHS As Boolean)
    RectShape.Hidden = RHS
End Property

Private Property Get IShape_Hidden() As Boolean
    IShape_Hidden = RectShape.Hidden
End Property

Private Sub IShape_Move(stepX As Single, stepY As Single)
    RectShape.Move stepX, stepY
End Sub

Private Sub IShape_Zoom(ZoomFactor As Single)
    RectShape.Zoom ZoomFactor
End Sub

' the CRectangle interface

Private Property Let CRectangle_Color(ByVal RHS As Long)
    Rect.Color = RHS
End Property

Private Property Get CRectangle_Color() As Long
    CRectangle_Color = Rect.Color
End Property

Private Property Let CRectangle_FillColor(ByVal RHS As Long)
    Rect.FillColor = RHS
End Property

Private Property Get CRectangle_FillColor() As Long
    CRectangle_FillColor = Rect.FillColor
End Property

Private Property Let CRectangle_Height(ByVal RHS As Single)
    Rect.Height = RHS
End Property

Private Property Get CRectangle_Height() As Single
    CRectangle_Height = Rect.Height
End Property

Private Property Let CRectangle_Left(ByVal RHS As Single)
    Rect.Left = RHS
End Property

Private Property Get CRectangle_Left() As Single
    CRectangle_Left = Rect.Left
End Property

Private Property Let CRectangle_Top(ByVal RHS As Single)
    Rect.Top = RHS
End Property

Private Property Get CRectangle_Top() As Single
    CRectangle_Top = Rect.Top
End Property

Private Property Let CRectangle_Width(ByVal RHS As Single)
    Rect.Width = RHS
End Property

Private Property Get CRectangle_Width() As Single
    CRectangle_Width = Rect.Width
End Property


