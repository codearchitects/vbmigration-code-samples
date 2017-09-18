VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPlaces"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-------------------------------
' The CPlaces collection class
'-------------------------------

Option Explicit

Private m_Places As New Collection

' Create a new CPlace item and add it to the collection

Function Create(Name As String, X As Single, Y As Single) As CPlace
Attribute Create.VB_Description = "Adds a member to a Collection object"
    Dim newItem As New CPlace
    newItem.Init Name, X, Y
    ' add to the private collection
    m_Places.Add newItem, newItem.Name
    ' return the new item to the caller
    Set Create = newItem
End Function

' add a new CPlace to the collection (must exist already)

Function Add(place As CPlace) As CPlace
    m_Places.Add place, place.Name
    Set Add = place
End Function

' Remove an item from the collection

Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    m_Places.Remove index
End Sub

' Return a CPlace item from the collection, or nothing if not there
Function Item(index As Variant) As CPlace
Attribute Item.VB_UserMemId = 0
    On Error Resume Next
    Set Item = m_Places.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_Places.Count
End Property

' Remove all items from the collection

Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    Set m_Places = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_Places.[_NewEnum]
End Function

' show this collection on a CMap object

Sub Draw(Map As CMap)
    Dim place As CPlace
    For Each place In m_Places
        place.Draw Map
    Next
End Sub




