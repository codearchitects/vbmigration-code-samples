VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CSegment"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------
' The CSegment class
'----------------------------

Option Explicit

Public PlaceA As CPlace
Public PlaceB As CPlace

Private m_Distance As Variant

' a simple constructor method

Friend Sub Init(PlaceA As CPlace, PlaceB As CPlace, Optional Distance As Variant)
    Set Me.PlaceA = PlaceA
    Set Me.PlaceB = PlaceB
    If Not IsMissing(Distance) Then Me.Distance = Distance
End Sub

' Name is a read-only property, mostly used to identify this
' item in a CSegments collection

Property Get Name() As String
    If StrComp(PlaceA.Name, PlaceB.Name, vbTextCompare) < 0 Then
        Name = PlaceA.Name & " - " & PlaceB.Name
    Else
        Name = PlaceB.Name & " - " & PlaceA.Name
    End If
End Property

' The Distance property

Property Get Distance() As Single
    If IsEmpty(m_Distance) Then
        ' if Distance is unknown, use an approximization
        Distance = Int(Sqr((PlaceA.X - PlaceB.X) ^ 2 + (PlaceA.Y - PlaceB.Y) ^ 2))
    Else
        ' else use exact distance
        Distance = m_Distance
    End If
End Property

Property Let Distance(ByVal newValue As Single)
    m_Distance = newValue
End Property

' show on a CMap object

Sub Draw(Map As CMap, Optional ByVal Color As Variant)
    If IsMissing(Color) Then Color = vbBlue
    Map.DrawLine PlaceA.X, PlaceA.Y, PlaceB.X, PlaceB.Y, Color
End Sub

' return the "other" place object in this segment
' or Nothing if this CPlace object isn't in the segment

Function OtherPlace(place As CPlace) As CPlace
    If PlaceA Is place Then
        Set OtherPlace = PlaceB
    ElseIf PlaceB Is place Then
        Set OtherPlace = PlaceA
    End If
End Function

