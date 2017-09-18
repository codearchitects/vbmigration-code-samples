VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "A Sample Invoice Hierarchy"
   ClientHeight    =   5325
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7770
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   5325
   ScaleWidth      =   7770
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "Create another invoice for same customer"
      Enabled         =   0   'False
      Height          =   615
      Left            =   5400
      TabIndex        =   1
      Top             =   1320
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Create an Invoice"
      Height          =   615
      Left            =   5400
      TabIndex        =   0
      Top             =   240
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:UseByval Yes
'##project:DisableMessage 501
'##project:DisableMessage 511

Dim Company As New CCompany

Private Sub Command1_Click()
    
    Dim inv As CInvoice, cust As CCustomer
    
    ' first, create a customer
    Set cust = Company.Customers.Create("Tech Eleven, Inc")
    cust.Address.Init "234 East Road", "Chicago", "IL", "12345"
    ' now create the invoice
    Set inv = Company.Invoices.Create("Mar 12, 1998", cust)
    ' and its invoice lines
    inv.InvoiceLines.Create 10, "Monitors ZX100", 225.25
    ' this second line requires additional properties
    With inv.InvoiceLines.Create(14, "101-key Keyboards", 19.99)
        .Color = "White"
        .Notes = "Special layout for laboratory"
    End With
    ' prints it on the form
    inv.PrintAll Form1
    
    ' disable this and enable the second button
    Command1.Enabled = False
    Command2.Enabled = True
End Sub

Private Sub Command2_Click()
    Dim inv As CInvoice, cust As CCustomer
    
    ' use the same customer as the first invoice
    Set cust = Company.Customers(1)
    ' now create the invoice
    Set inv = Company.Invoices.Create("Mar 21, 1998", cust)
    ' and its invoice lines
    inv.InvoiceLines.Create 14, "Modem TKU", 99.5
    ' this second line requires additional properties
    inv.InvoiceLines.Create 100, "Network adapter", 60
    inv.InvoiceLines.Create 44, "Serial Cables", 5.25
    ' prints it on the form
    ' this will also print a warning for the customer
    inv.PrintAll Form1
    
End Sub




