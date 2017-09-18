VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CInvoiceLine"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'--------------------------------------------
' The CInvoiceLine class
'--------------------------------------------

Option Explicit

Public Qty As Long
Public Product As String
Public UnitPrice As Currency
Public Color As String
Public Notes As String

' a friendly constructor-like method

Friend Sub Init(Qty As Long, Product As String, UnitPrice As Currency)
    Me.Qty = Qty
    Me.Product = Product
    Me.UnitPrice = UnitPrice
End Sub

Property Get Total() As Currency
    Total = Qty * UnitPrice
End Property

Property Get Description() As String
    Description = Format$(Qty, "@@@@@@   ") & _
       Format$(Product, "!" & String$(40, "@")) & _
       Format$(UnitPrice, "###,###.00") & "   " & _
       Format$(Total, "###,###,###.00")
End Property

