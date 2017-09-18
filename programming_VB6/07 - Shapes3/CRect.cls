VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CRectangle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------------------------
' The CRectangle Class
'----------------------------------------------

Option Explicit

Implements IShape

Public Left As Single
Public Top As Single
Public Width As Single
Public Height As Single
Public color As Long
Public FillColor As Long

' this is required by the IShape interface
Private Hidden As Boolean

Private Sub Class_Initialize()
    color = vbBlack
    FillColor = -1       ' any negative value means "unfilled"
End Sub

' a simple constructor for ease of use

Friend Sub Init(Left As Single, Top As Single, Width As Single, Height As Single, Optional color As Variant, Optional FillColor As Variant)
    Me.Left = Left
    Me.Top = Top
    Me.Width = Width
    Me.Height = Height
    If Not IsMissing(color) Then Me.color = color
    If Not IsMissing(FillColor) Then Me.FillColor = FillColor
End Sub

' Implementation of the IShape interface

Private Sub IShape_Draw(pic As Object)
    If Hidden Then Exit Sub
    If FillColor >= 0 Then
        pic.Line (Left, Top)-Step(Width, Height), FillColor, BF
    End If
    pic.Line (Left, Top)-Step(Width, Height), color, B
End Sub

Private Sub IShape_Move(stepX As Single, stepY As Single)
    Left = Left + stepX
    Top = Top + stepY
End Sub

Private Property Let IShape_Hidden(ByVal RHS As Boolean)
    Hidden = RHS
End Property

Private Property Get IShape_Hidden() As Boolean
    IShape_Hidden = Hidden
End Property

Private Sub IShape_Zoom(ZoomFactor As Single)
    Left = Left + Width * (1 - ZoomFactor) / 2
    Top = Top + Height * (1 - ZoomFactor) / 2
    Width = Width * ZoomFactor
    Height = Height * ZoomFactor
End Sub
