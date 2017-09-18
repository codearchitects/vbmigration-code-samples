VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPerson"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Event Change(PropertyName As String)

' private members
Private m_Name As String
Private m_Address As String
Private m_City As String
Private m_Married As Boolean

' The Name property

Public Property Get Name() As String
    Name = m_Name
End Property

Public Property Let Name(newValue As String)
    ' it is very important that the new value is checked always
    If newValue = "" Then Err.Raise 5, , "Invalid Value for Name property"
    If m_Name <> newValue Then
        m_Name = newValue
        PropertyChanged "Name"
    End If
End Property

' The Address Property

Public Property Get Address() As String
    Address = m_Address
End Property

Public Property Let Address(newValue As String)
    If newValue = "" Then Err.Raise 5, , "Invalid Value for Address property"
    If m_Address <> newValue Then
        m_Address = newValue
        PropertyChanged "Address"
    End If
End Property

' the City property

Public Property Get City() As String
    City = m_City
End Property

Public Property Let City(newValue As String)
    If newValue = "" Then Err.Raise 5, , "Invalid Value for City property"
    If m_City <> newValue Then
        m_City = newValue
        PropertyChanged "City"
    End If
End Property

' the Married property

Public Property Get Married() As Boolean
    Married = m_Married
End Property

Public Property Let Married(newValue As Boolean)
    If m_Married <> newValue Then
        m_Married = newValue
        PropertyChanged "Married"
    End If
End Property

' the PropertyChanged private method raises a Change event in the client code

Private Sub PropertyChanged(PropertyName As String)
    RaiseEvent Change(PropertyName)
End Sub


