VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CLine"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------------------------
' The CLine Class
'----------------------------------------------

Option Explicit

Implements IShape

Public X As Single
Public Y As Single
Public X2 As Single
Public Y2 As Single
Public Color As Long

' this is required by the IShape interface
Private Hidden As Boolean

Private Sub Class_Initialize()
    Color = vbBlack
End Sub

' a simple constructor for ease of use

Friend Sub Init(X As Single, Y As Single, X2 As Single, Y2 As Single, Optional Color As Variant)
    Me.X = X
    Me.Y = Y
    Me.X2 = X2
    Me.Y2 = Y2
    If Not IsMissing(Color) Then Me.Color = Color
End Sub

' Implementation of the IShape Interface

Private Sub IShape_Draw(pic As Object)
    If Hidden Then Exit Sub
    pic.Line (X, Y)-(X2, Y2), Color
End Sub

Private Sub IShape_Move(stepX As Single, stepY As Single)
    X = X + stepX
    Y = Y + stepY
    X2 = X2 + stepX
    Y2 = Y2 + stepY
End Sub

Private Property Let IShape_Hidden(ByVal RHS As Boolean)
    Hidden = RHS
End Property

Private Property Get IShape_Hidden() As Boolean
    IShape_Hidden = Hidden
End Property

Private Sub IShape_Zoom(ZoomFactor As Single)
    Dim XC As Single, YC As Single
    ' Evaluate the middle point on the line.
    XC = (X + X2) / 2: YC = (Y + Y2) / 2
    ' Zoom the line.
    X = XC - (XC - X) * ZoomFactor: X2 = XC - (XC - X2) * ZoomFactor
    Y = YC - (YC - Y) * ZoomFactor: Y2 = YC - (YC - Y2) * ZoomFactor
End Sub

