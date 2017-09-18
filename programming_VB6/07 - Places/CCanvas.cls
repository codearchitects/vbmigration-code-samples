VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CMap"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------
' The CMap class
'----------------------------

Option Explicit

' where items are displayed (form, picture box or printer)
Public Surface As Object
' the collection of Places on this map
Public Places As New CPlaces

' redraw this map
Sub Draw()
    Dim place As CPlace, segment As CSegment
    Surface.Cls
    For Each place In Places
        ' display the place's name and position
        place.Draw Me
        For Each segment In place.Segments
            ' displays all the segments from that place
            ' don't redraw the same segment twice
            If segment.PlaceA Is place Then
                segment.Draw Me
            End If
        Next
    Next
End Sub


' graphic methods

Sub DrawText(X As Single, Y As Single, Text As String, Optional ByVal color As Long = vbBlack)
    Surface.CurrentX = X
    Surface.CurrentY = Y
    Surface.ForeColor = FromOleColor6(color)
    Surface.Print Text;
End Sub

Sub DrawLine(X As Single, Y As Single, X2 As Single, Y2 As Single, Optional ByVal color As Long = vbBlack)
    Surface.Line (X, Y)-(X2, Y2), color
End Sub

Sub DrawCircle(X As Single, Y As Single, Radius As Single, Optional ByVal color As Long = vbBlack)
    Surface.Circle (X, Y), Radius, color
End Sub


