VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 1  'Persistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CPerson"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

' Public properties
Public Name As String
Public Citizenship As String
Public Children As New Collection

' Default values
Const Name_Def = ""
Const Citizenship_Def = "American"

Private Sub Class_Initialize()
    Name = Name_Def
    Citizenship = Citizenship_Def
End Sub

' Initialize Properties.

Private Sub Class_InitProperties()
    Name = Name_Def
    Citizenship = Citizenship_Def
End Sub

' Save properties to a PropertyBag.

Private Sub Class_WriteProperties(PropBag As PropertyBag)
    Dim i As Long
    ' Save simple properties, then object properties
    PropBag.WriteProperty "Name", Name, Name_Def
    PropBag.WriteProperty "Citizenship", Citizenship, Citizenship_Def
    
    ' First, save the number of children (default = 0)
    PropBag.WriteProperty "ChildrenCount", Children.Count, 0
    ' Next, save all the children, one by one.
    For i = 1 To Children.Count
        PropBag.WriteProperty "Child" & i, Children.Item(i)
    Next
End Sub

' Restore properties from a PropertyBag.

Private Sub Class_ReadProperties(PropBag As PropertyBag)
    Dim i As Long, ChildrenCount As Long
    ' Restore simple properties, then object properties
    Name = PropBag.ReadProperty("Name", Name_Def)
    Citizenship = PropBag.ReadProperty("Citizenship", Citizenship_Def)
    ' First, restore the number of children
    ChildrenCount = PropBag.ReadProperty("ChildrenCount", 0)
    ' Next, restore all the children, one by one.
    For i = 1 To ChildrenCount
        Children.Add PropBag.ReadProperty("Child" & i)
    Next
End Sub

