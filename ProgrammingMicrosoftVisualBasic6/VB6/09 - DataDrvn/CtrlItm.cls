VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ControlItem"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

' a public collection for additional properties
Public Properties As New Collection
' the object being monitored - this is same as "Control"
' but it also receives events
Public WithEvents Control As VBControlExtender
Attribute Control.VB_VarHelpID = -1

' the parent ControlItems object
Dim m_Parent As ControlItems

' initialize properties

Sub Init(ctrl As VBControlExtender, parent As ControlItems)
    Set Control = ctrl
    Set m_Parent = parent
End Sub

' retrieve a single property

Function GetProperty(PropName As String, Optional DefaultValue As Variant) As Variant
    On Error Resume Next
    GetProperty = Properties(PropName)
    If Err And Not IsMissing(DefaultValue) Then
        GetProperty = DefaultValue
    End If
End Function

' the control has raised a Validate event

Private Sub Control_Validate(Cancel As Boolean)
    ' notify it to the parent ControlItems class
    m_Parent.Notify_Validate Me, Cancel
End Sub
