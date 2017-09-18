VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CCustomers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' The private collection used to hold the real data
Private m_Customers As New Collection

' Add a new CCustomer item to the collection

Function Create(Name, Optional Address As CAddress) As CCustomer
Attribute Create.VB_Description = "Adds a member to a Collection object"
    Dim newItem As New CCustomer
    newItem.Name = Name
    m_Customers.Add newItem, newItem.Name
    If Not IsMissing(Address) Then
        Set newItem.Address = Address
    End If
    ' return the new item to the caller
    Set Create = newItem
End Function

' Remove an item from the collection

Public Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    m_Customers.Remove index
End Sub

' Return a CCustomer item from the collection

Function Item(index As Variant) As CCustomer
Attribute Item.VB_UserMemId = 0
    Set Item = m_Customers.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_Customers.Count
End Property

' Remove all items from the collection

Public Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    Set m_Customers = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_Customers.[_NewEnum]
End Function

