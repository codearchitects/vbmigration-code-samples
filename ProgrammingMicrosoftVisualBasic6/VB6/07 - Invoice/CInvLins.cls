VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CInvoiceLines"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'------------------------------------
' The CInvoiceLines collection class
'------------------------------------

Option Explicit

' The private collection used to hold the real data
Private m_InvoiceLines As New Collection

' Add a new CInvoiceLine item to the collection

Sub Add(newItem As CInvoiceLine, Optional Key As Variant, _
    Optional Before As Variant, Optional After As Variant)
        m_InvoiceLines.Add newItem, Key
End Sub

' Remove an item from the collection

Sub Remove(index As Variant)
Attribute Remove.VB_Description = "Removes a member from a Collection object"
    m_InvoiceLines.Remove index
End Sub

' Return a CInvoiceLine item from the collection

Function Item(index As Variant) As CInvoiceLine
Attribute Item.VB_Description = "Returns a specific member of a Collection object either by position or key"
Attribute Item.VB_UserMemId = 0
    Set Item = m_InvoiceLines.Item(index)
End Function

' Return the number of items in the collection

Property Get Count() As Long
Attribute Count.VB_Description = "Returns the number of members in a collection"
    Count = m_InvoiceLines.Count
End Property

' Remove all items from the collection

Public Sub Clear()
Attribute Clear.VB_Description = "Removes all members from a Collection object"
    Set m_InvoiceLines = New Collection
End Sub

' Implement support for enumeration (For Each)

Function NewEnum() As IUnknown
Attribute NewEnum.VB_UserMemId = -4
Attribute NewEnum.VB_MemberFlags = "40"
    ' delegate to the private collection
    Set NewEnum = m_InvoiceLines.[_NewEnum]
End Function

'-----------------------------------------------
' specific custom methods
'-----------------------------------------------

' create a CInvoiceLine object and add it to the collection

Function Create(Qty As Long, Product As String, UnitPrice As Currency) _
    As CInvoiceLine
        Dim newItem As New CInvoiceLine         ' auto-instancing is safe here
        newItem.Init Qty, Product, UnitPrice
        m_InvoiceLines.Add newItem
        Set Create = newItem
End Function

' get the sum of subtotals

Property Get Total() As Currency
    Dim result As Currency, invline As CInvoiceLine
    For Each invline In m_InvoiceLines
        result = result + invline.Total
    Next
    Total = result
End Property

' print individual lines

Sub PrintLines(obj As Object)
    Dim invline As CInvoiceLine
    For Each invline In m_InvoiceLines
        obj.Print invline.Description
    Next
End Sub

