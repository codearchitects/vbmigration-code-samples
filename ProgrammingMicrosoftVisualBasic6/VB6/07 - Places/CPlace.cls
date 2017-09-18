VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPlace"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'----------------------------
' The CPlace class
'----------------------------

Option Explicit

Public Name As String              ' a unique name
Attribute Name.VB_VarUserMemId = 0
Public X As Single, Y As Single    ' X-Y coordinates
Public Segments As New CSegments   ' all the connected segments

Public Ignore As Boolean           ' used in the search algorithm

' a simple constructor method

Friend Sub Init(Name As String, X As Single, Y As Single)
    Me.Name = Name
    Me.X = X
    Me.Y = Y
End Sub

' get the collection of all the CPlaces in this collection that
' appear to be connected to the Place passed as argument

Property Get ConnectedPlaces(Optional IncludeIgnore As Boolean) As CPlaces
    Dim segment As CSegment, place As CPlace
    
    Set ConnectedPlaces = New CPlaces
    
    ' scan all the segments that start from this place
    For Each segment In Segments
        ' get the "other" place in the segment
        ' add to the result if it meets all requirements
        Set place = segment.OtherPlace(Me)
        If place.Ignore = False Or IncludeIgnore Then
            ConnectedPlaces.Add place
        End If
    Next
End Property

' get the segment that connects to another CPlace object
' or nothing if there isn't such a segment

Function GetSegment(OtherPlace As CPlace) As CSegment
    Dim segment As CSegment
    For Each segment In Segments
        If segment.OtherPlace(Me) Is OtherPlace Then
            Set GetSegment = segment
            Exit Function
        End If
    Next
End Function

' show on a CMap object

Sub Draw(Map As CMap)
    Map.DrawCircle X, Y, 50
    Map.DrawText X, Y + 100, Name
End Sub
