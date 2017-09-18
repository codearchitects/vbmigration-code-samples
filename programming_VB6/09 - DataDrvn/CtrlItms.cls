VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ControlItems"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' this class raises an event in the parent form
Event Validate(Item As ControlItem, Cancel As Boolean)

' The private collection used to hold the real data
Private m_ControlItems As New Collection

' Add a new ControlItem item to the collection

Public Function Add(ctrl As Control) As ControlItem
Attribute Add.VB_Description = "Adds a member to a Collection object"
    Dim newItem As New ControlItem
    newItem.Init ctrl, Me
    
    ' add to the private collection
    m_ControlItems.Add newItem
    ' return the new item to the caller
    Set Add = newItem
End Function

' Remove an item from the collection

Public Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    m_ControlItems.Remove index
End Sub

' Return a ControlItem item from the collection

Function Item(index As Variant) As ControlItem
Attribute Item.VB_Description = "Returns a specific member of a Collection object either by position or key"
Attribute Item.VB_UserMemId = 0
    Set Item = m_ControlItems.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_ControlItems.Count
End Property

' Remove all items from the collection

Public Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    Set m_ControlItems = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_ControlItems.[_NewEnum]
End Function

'---------------------------------------------
' Friend Subs called when a ControlItem
' receives an event from Visual Basic
'---------------------------------------------

Friend Sub Notify_Validate(Item As ControlItem, Cancel As Boolean)
    ' raise a Validate event in the parent form
    RaiseEvent Validate(Item, Cancel)
End Sub




