Attribute VB_Name = "Factory"
Option Explicit

' an external constructor method for CPerson

Function New_CPerson(FirstName As String, LastName As String, _
    Optional ID As Variant, Optional BirthDate As Variant) As CPerson
        ' you don't need a temporary local variable
        Set New_CPerson = New CPerson
        New_CPerson.Init FirstName, LastName, ID, BirthDate
End Function

' an external constructor method for CAddress

Function New_CAddress(Street As String, City As String, State As String, Zip As String, Optional Country As Variant, Optional Phone As Variant) As CAddress
    Set New_CAddress = New CAddress
    New_CAddress.Init Street, City, State, Zip, Country, Phone
End Function
