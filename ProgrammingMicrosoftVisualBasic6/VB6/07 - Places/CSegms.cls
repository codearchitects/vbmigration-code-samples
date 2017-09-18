VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CSegments"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'---------------------------------------
' The CSegments collection class
'---------------------------------------

Option Explicit

' The private collection used to hold the real data
Private m_Segments As New Collection

' Create a new CSegment item and add it to the collection

Function Create(PlaceA As CPlace, PlaceB As CPlace, Optional Distance As Variant) As CSegment
Attribute Create.VB_Description = "Adds a member to a Collection object"
    Dim newItem As New CSegment
    
    newItem.Init PlaceA, PlaceB, Distance
    ' also add to the Segments collection of each Place
    PlaceA.Segments.Add newItem
    PlaceB.Segments.Add newItem
        
    ' add to the private collection, just once
    On Error Resume Next
    m_Segments.Add newItem, newItem.Name
    
    ' return the new item to the caller
    Set Create = newItem
End Function

' Add a CSegment item to the collection (must exist already)

Function Add(segment As CSegment) As CSegment
    Dim key As String
    On Error Resume Next
    ' on error avoids adding an item twice
    m_Segments.Add segment, segment.Name
    Set Add = segment
End Function

' Remove an item from the collection

Public Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    m_Segments.Remove index
End Sub

' Return a CSegment item from the collection, or Nothing if not there

Function Item(index As Variant) As CSegment
Attribute Item.VB_Description = "Returns a specific member of a Collection object either by position or key"
Attribute Item.VB_UserMemId = 0
    On Error Resume Next
    Set Item = m_Segments.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_Segments.Count
End Property

' Remove all items from the collection

Public Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    Set m_Segments = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_Segments.[_NewEnum]
End Function


' draw this series of segments on a CMap object

Sub Draw(Map As CMap, Optional Color As Variant)
    Dim segment As CSegment
    For Each segment In m_Segments
        segment.Draw Map, Color
    Next
End Sub

' return the total Distance

Property Get Distance() As Single
    Dim result As Single, segment As CSegment
    For Each segment In m_Segments
        result = result + segment.Distance
    Next
    Distance = result
End Property

