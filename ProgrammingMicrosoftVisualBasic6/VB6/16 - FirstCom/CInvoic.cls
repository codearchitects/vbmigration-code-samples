VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CInvoice"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'-----------------------------------------
' The CInvoice class
'-----------------------------------------

' set this to -1 to see how you can support backpointers
' without causing any reference counter problem
#Const USE_WEAK_POINTERS = 0

Option Explicit

#If USE_WEAK_POINTERS Then
Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, source As Any, ByVal bytes As Long)
#End If

Public Number As Long
Public InvDate As Date             ' can't use "Date" as a property name
Public Customer As CCustomer       ' in a real app these would
Public SendFrom As CAddress        ' probably be implemented as
                                   ' pairs of property procedures
Private m_ShipTo As CAddress

' these properties are used to demonstrate backpointers
Public Paid As Boolean

#If USE_WEAK_POINTERS = 0 Then
Private m_Collection As CInvoices ' a reference to the parent collection
#Else
Private m_Collection_Ptr As Long  ' a 32-bit weak pointer to the parent collection
#End If

' the collection of all lines
Public InvoiceLines As New CInvoiceLines

' a simple constructor method (could be improved with optional args)

Friend Sub Init(Number As Long, InvDate As Date, Customer As CCustomer)
    Me.Number = Number
    Me.InvDate = InvDate
    Set Me.Customer = Customer
End Sub

' this is read-only property from the outside (Property Let is Friend)

Property Get ShipTo() As CAddress
    If m_ShipTo Is Nothing Then
        Set ShipTo = Customer.Address
    Else
        Set ShipTo = m_ShipTo
    End If
End Property

Property Let ShipTo(newValue As CAddress)
    Set m_ShipTo = newValue
End Property

' the grand total of this invoice is the total of its
' individual lines (no taxes, in this ideal world)

Property Get GrandTotal() As Currency
    GrandTotal = InvoiceLines.Total
End Property

Sub PrintHeader(obj As Object)
    ' print the invoice header on a form, PictureBox or the Printer
    obj.Print "Number " & Number
    obj.Print "Customer: " & Customer.Name
    'obj.Print "Send From: " & SendFrom.CompleteAddress
    obj.Print "Ship To: " & ShipTo.CompleteAddress
End Sub

Sub PrintBody(obj As Object)
    InvoiceLines.PrintLines obj
    obj.Print "Grand Total = " & InvoiceLines.Total
End Sub

Sub PrintNotes(obj As Object)
    ' print a note if the current customer has other Unpaid invoices
    ' for this company
    Dim inv As CInvoice, Found As Long, Total As Currency
    
    For Each inv In Collection
        If inv Is Me Then
            ' don't consider this one
        ElseIf (inv.Customer Is Customer) And inv.Paid = False Then
            Found = Found + 1
            Total = Total + inv.GrandTotal
        End If
    Next
    
    If Found Then
        obj.Print "WARNING: Other " & Found & " invoices still waiting to be paid ($" & Total & ")"
    End If
End Sub

Sub PrintAll(obj As Object)
    PrintHeader obj
    PrintBody obj
    PrintNotes obj
    obj.Print
End Sub

#If USE_WEAK_POINTERS = 0 Then

' these are regular Get/Let property procedures
' that encapsulate the m_Collection private object variable
Friend Property Set Collection(newValue As CInvoices)
    Set m_Collection = newValue
End Property
Public Property Get Collection() As CInvoices
    Set Collection = m_Collection
End Property

#Else

' these procedures have the same interface as the regular ones
' but instead work with a *pointer* to the parent collection in a regular
' Long variable, using the undocumented ObjPtr VBA function.

' the Set property is very simple: instead of using a Set command to
' store a *reference* to the collection, it stores the 32-bit value that
' is stored inside it. This is made simple by the undocumented ObjPtr()
' function, that returns the 32-bit value stored inside the object variable

' The important point here is that no SET command is used,
' therefore VB will not increment the collection's reference counter. This
' means that circular reference is created, which is exactly what we want to achieve.

Friend Property Set Collection(newValue As CInvoices)
    ' just store the 32-bit pointer to the parent collection
    m_Collection_Ptr = ObjPtr(newValue)
End Property

' the code inside the Property Get procedure is trickier, because it has
' to create a valid object reference to the collection starting from a mere
' 32-bit value. VB doesn't offer a "reverse ObjPtr" function, so we must do
' all by ourselves, using the CopyMemory API call to move the 32-bit value
' right into the object variable. We also need a Set command that compensates
' the missing Set that we avoided in the Property Set routine

Public Property Get Collection() As CInvoices
    ' recreate a valid object reference to the parent collection
    Dim dummy As CInvoices
    ' force the value into the dummy variable
    CopyMemory dummy, m_Collection_Ptr, 4
    ' use a Set command to increment the refcounter of the result
    Set Collection = dummy
    ' clear the dummy value before VB sets it to Nothing
    ' if you omit this, VB will decrement the refcounter, vanishing
    ' our previous Set command.
    ' Worse, it will leave it unbalanced, and the app will crash!
    CopyMemory dummy, 0&, 4
End Property

#End If

