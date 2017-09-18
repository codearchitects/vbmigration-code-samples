' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CInvoice

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-----------------------------------------
	' The CInvoice class
	'-----------------------------------------
	
	' set this to -1 to see how you can support backpointers
	' without causing any reference counter problem
	#Const USE_WEAK_POINTERS = 0

	#If USE_WEAK_POINTERS Then
	' UPGRADE_WARNING (#0244): Code in current #If ,#ElseIf, or #Else block hasn't been upgraded.
	Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, source As Any, ByVal bytes As Long)
	#End If
	
	Public Number As Integer
	Public InvDate As Date ' can't use "Date" as a property name
	Public Customer As CCustomer ' in a real app these would
	Public SendFrom As CAddress ' probably be implemented as
	' pairs of property procedures
	Private m_ShipTo As CAddress
	
	' these properties are used to demonstrate backpointers
	Public Paid As Boolean
	
	#If USE_WEAK_POINTERS = 0 Then
	Private m_Collection As CInvoices ' a reference to the parent collection
	#Else
	' UPGRADE_WARNING (#0244): Code in current #If ,#ElseIf, or #Else block hasn't been upgraded.
	Private m_Collection_Ptr As Long ' a 32-bit weak pointer to the parent collection
	#End If
	
	' the collection of all lines
	' This wrapper property has been added to preserve As New semantics of InvoiceLines variable
	Public Property InvoiceLines() As CInvoiceLines
		Get
			If InvoiceLines_InnerField Is Nothing Then InvoiceLines_InnerField = New CInvoiceLines()
			Return InvoiceLines_InnerField
		End Get
		Set(value As CInvoiceLines)
			InvoiceLines_InnerField = value
		End Set
	End Property
	
	Private InvoiceLines_InnerField As CInvoiceLines
	
	' a simple constructor method (could be improved with optional args)
	
	Friend Sub Init(ByRef Number As Integer, ByRef InvDate As Date, ByRef Customer As CCustomer)
		Me.Number = Number
		Me.InvDate = InvDate
		Me.Customer = Customer
	End Sub

	' this is read-only property from the outside (Property Let is Friend)

	Public Property ShipTo() As CAddress
		Get
			If m_ShipTo Is Nothing Then 
				Return Customer.Address
			Else
				Return m_ShipTo
			End If
	 	End Get
		Set(ByVal newValue As CAddress)
			m_ShipTo = newValue
	 	End Set
	End Property

	' the grand total of this invoice is the total of its
	' individual lines (no taxes, in this ideal world)
	
	Public ReadOnly Property GrandTotal() As Decimal
		Get
			Return InvoiceLines.Total
	 	End Get
	End Property

	Public Sub PrintHeader(ByRef obj As Object)
		' print the invoice header on a form, PictureBox or the Printer
		obj.PrintLine("Number " & Number)
		obj.PrintLine("Customer: " & Customer.Name)
		'obj.Print "Send From: " & SendFrom.CompleteAddress
		obj.PrintLine("Ship To: " & ShipTo.CompleteAddress)
	End Sub

	Public Sub PrintBody(ByRef obj As Object)
		InvoiceLines.PrintLines(obj)
		obj.PrintLine("Grand Total = " & InvoiceLines.Total)
	End Sub

	Public Sub PrintNotes(ByRef obj As Object)
		' print a note if the current customer has other Unpaid invoices
		' for this company
		Dim inv As CInvoice = Nothing
		Dim Found As Integer
		Dim Total As Decimal
		
		For Each inv In Collection
			If inv Is Me Then 
				' don't consider this one
			ElseIf (inv.Customer Is Customer) And inv.Paid = False Then 
				Found += 1
				Total += inv.GrandTotal
			End If
		Next
		
		If Found Then 
			obj.PrintLine("WARNING: Other " & Found & " invoices still waiting to be paid ($" & Total & ")")
		End If
	End Sub

	Public Sub PrintAll(ByRef obj As Object)
		PrintHeader(obj)
		PrintBody(obj)
		PrintNotes(obj)
		obj.PrintLine
	End Sub

	#If USE_WEAK_POINTERS = 0 Then
	
	' these are regular Get/Let property procedures
	' that encapsulate the m_Collection private object variable
	Public Property Collection() As CInvoices
		Get
			Return m_Collection
	 	End Get
		Friend Set(ByVal newValue As CInvoices)
			m_Collection = newValue
	 	End Set
	End Property

	#Else
	' UPGRADE_WARNING (#0244): Code in current #If ,#ElseIf, or #Else block hasn't been upgraded.
	
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

End Class
