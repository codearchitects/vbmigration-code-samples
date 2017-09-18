VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CAddress"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'--------------------------------------
' The CAddress class (from Chap 06)
'--------------------------------------

Option Explicit

' for the sake of simplicity, all properties are declared as Public members
Public Street As String
Public City As String
Public State As String
Public Zip As String
Public Country As String
Public Phone As String

Const Country_DEF As String = "USA"     ' a reasonable default value for Country property

Private Sub Class_Initialize()
    Country = Country_DEF
End Sub

' a constructor method

Friend Sub Init(Street As String, City As String, State As String, _
    Zip As String, Optional Country As Variant, Optional Phone As Variant)
        Me.Street = Street
        Me.City = City
        Me.State = State
        Me.Zip = Zip
        If Not IsMissing(Country) Then Me.Country = Country
        If Not IsMissing(Phone) Then Me.Phone = Phone
End Sub

' return the complete address (read-only property)
' includes the country if different from the default value

Property Get CompleteAddress() As String
    CompleteAddress = Street & vbCrLf & City & ", " & State & " " & Zip _
        & IIf(Country <> Country_DEF, Country, "")
End Property


