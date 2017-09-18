Attribute VB_Name = "Factory"
Option Explicit

' an external constructor method for CAddress

Function New_CAddress(Street As String, City As String, State As String, Zip As String, Optional Country As Variant, Optional Phone As Variant) As CAddress
    Set New_CAddress = New CAddress
    New_CAddress.Init Street, City, State, Zip, Country, Phone
End Function

' an external constructor method for CInvoiceLine

Function New_CInvoiceLine(Qty As Long, Product As String, UnitPrice As Currency) As CInvoiceLine
    Set New_CInvoiceLine = New CInvoiceLine
    New_CInvoiceLine.Init Qty, Product, UnitPrice
End Function

