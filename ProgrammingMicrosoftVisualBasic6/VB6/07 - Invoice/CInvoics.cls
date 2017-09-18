VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CInvoices"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-----------------------------------------------
' The CInvoices collection class
'-----------------------------------------------

Option Explicit

Private m_LastInvoiceNumber As Long
' the internal collection of invoices
Private m_Invoices As New Collection

' the number used for the last invoice (read-only)

Public Property Get LastInvoiceNumber() As Long
    LastInvoiceNumber = m_LastInvoiceNumber
End Property

' Create a new CInvoice item and add it to the collection

Function Create(InvDate As Date, Customer As CCustomer) As CInvoice
Attribute Create.VB_Description = "Adds a member to a Collection object"
    Dim newItem As New CInvoice
        
    ' don't increment the internal variable yet!
    ' pass "Me" to make this collection the parent of the new invoice
    newItem.Init m_LastInvoiceNumber + 1, InvDate, Customer
    Set newItem.Collection = Me
    ' add to the internal collection, using the number as a key
    m_Invoices.Add newItem, CStr(newItem.Number)
    
    ' increment it now, if now error occurred
    m_LastInvoiceNumber = m_LastInvoiceNumber + 1
    ' return the new item to the caller
    Set Create = newItem
End Function

' Remove an item from the collection

Public Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    Set Item(index).Collection = Nothing     ' first, remove circular references
    m_Invoices.Remove index
End Sub

' Return a CInvoice item from the collection

Function Item(index As Variant) As CInvoice
Attribute Item.VB_Description = "Returns a specific member of a Collection object either by position or key"
Attribute Item.VB_UserMemId = 0
    Set Item = m_Invoices.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_Invoices.Count
End Property

' Remove all items from the collection

Public Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    ' first, solve all circular references
    Dim inv As CInvoice
    For Each inv In m_Invoices
        Set inv.Collection = Nothing
    Next
    Set m_Invoices = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_Invoices.[_NewEnum]
End Function

Private Sub Class_Terminate()
    Debug.Print "CInvoices:Class_Terminate"
End Sub
