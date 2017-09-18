VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CRoute"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'---------------------------------------
' The CRoute class
'---------------------------------------

Option Explicit

Public StartPlace As CPlace    ' where we start from
Public EndPlace As CPlace      ' where we want to go
Public Path As New CSegments   ' the result path

' finds the best path according and return its length
' returns Empty if Path is Nothing

Function GetBestPath() As Variant
    Dim place As CPlace
    Dim segment As CSegment, minSegment As CSegment
    Dim currCost As Variant, minCost As Variant
    Dim route As CRoute, minPath As CRoute
    
    ' if the end point is directly connected, we have completed the search
    ' NOTE: this algorithm always selects the direct path between
    '       two places, even if there is an indirect but more convenient path
    Set segment = StartPlace.GetSegment(EndPlace)
    If Not (segment Is Nothing) Then
        ' create the result
        Set Path = New CSegments
        Path.Add segment
        ' return the expected value
        GetBestPath = Path.Distance
        Exit Function
    End If
    
    ' the two places aren't connected directly, so we must
    ' test each segment recursively
    
    ' from now on, ignore StartPlace in searches
    StartPlace.Ignore = True
    
    For Each place In StartPlace.ConnectedPlaces
        ' let's create a new CRoute, that excludes the StartPlace
        Set route = New CRoute
        Set route.StartPlace = place
        Set route.EndPlace = EndPlace
        
        ' find the best route possible
        currCost = route.GetBestPath
        
        If Not IsEmpty(currCost) Then
            ' we found a valid path
            Set segment = StartPlace.GetSegment(place)
            currCost = currCost + segment.Distance
            
            ' if is this the best route so far, remember it
            If IsEmpty(minCost) Or currCost < minCost Then
                Set minPath = route
                Set minSegment = segment
                minCost = currCost
            End If
        End If
    Next
    
    ' restore regular functioning
    StartPlace.Ignore = False
    
    ' if we found at least one valid path
    If Not IsEmpty(minCost) Then
        ' Init Path property - we must build this collection manually
        ' this is the first segment
        Path.Add minSegment
        ' these are the following ones
        For Each segment In minPath.Path
            Path.Add segment
        Next
        ' return result
        GetBestPath = minCost
    End If
End Function

