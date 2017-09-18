VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Address"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Public Name As String
Public Street As String
Public City As String
Public Zip As String
Public State As String

Friend Property Get AllProperties() As Byte()
    Dim PropBag As New PropertyBag
    PropBag.WriteProperty "Name", Name, ""
    PropBag.WriteProperty "Street", Street, ""
    PropBag.WriteProperty "City", City, ""
    PropBag.WriteProperty "Zip", Zip, ""
    PropBag.WriteProperty "State", State, ""
    AllProperties = PropBag.Contents
End Property

Friend Property Let AllProperties(value() As Byte)
    Dim PropBag As New PropertyBag
    PropBag.Contents = value()
    Name = PropBag.ReadProperty("Name", "")
    Street = PropBag.ReadProperty("Street", "")
    City = PropBag.ReadProperty("City", "")
    Zip = PropBag.ReadProperty("Zip", "")
    State = PropBag.ReadProperty("State", "")
End Property


