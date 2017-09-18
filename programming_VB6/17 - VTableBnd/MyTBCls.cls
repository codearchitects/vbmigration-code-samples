VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "MyTextBoxCls"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Private m_UserControl As MyTextBox

' The IsNumeric property

Public Property Get IsNumeric() As Boolean
    IsNumeric = m_UserControl.IsNumeric
End Property

Public Property Let IsNumeric(ByVal newValue As Boolean)
    m_UserControl.IsNumeric = newValue
End Property



' The Value property

Public Property Get Value() As Long
    Value = m_UserControl.Value
End Property

Public Property Let Value(ByVal newValue As Long)
    m_UserControl.Value = newValue
End Property

' The UserControl property

Friend Property Get UserControl() As MyTextBox
    Set UserControl = m_UserControl
End Property

Friend Property Set UserControl(ByVal newValue As MyTextBox)
    Set m_UserControl = newValue
End Property

' The ForeColor property

Public Property Get ForeColor() As Long
    ForeColor = m_UserControl.ForeColor
End Property

Public Property Let ForeColor(ByVal newValue As Long)
    m_UserControl.ForeColor = newValue
End Property

' The Text property

Public Property Get Text() As String
    Text = m_UserControl.Text
End Property

Public Property Let Text(ByVal newValue As String)
    m_UserControl.Text = newValue
End Property


