VERSION 5.00
Begin VB.UserControl MyTextBox 
   ClientHeight    =   840
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4620
   ScaleHeight     =   840
   ScaleWidth      =   4620
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4215
   End
End
Attribute VB_Name = "MyTextBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Event GetData(Text As String)

Public EventItf As MyTextboxEvents

Dim MyTextBoxCls As MyTextBoxCls

' An example of a simple Boolean property
Public IsNumeric As Boolean

' member variable for Value property
Private m_Value As Long

Private Sub UserControl_Initialize()
    Set MyTextBoxCls = New MyTextBoxCls
    Set MyTextBoxCls.UserControl = Me
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    On Error Resume Next
'    Set EventItf = UserControl.Parent
End Sub

Property Get ObjectAux() As MyTextBoxCls
    Set ObjectAux = MyTextBoxCls
End Property

' The ForeColor property

Public Property Get ForeColor() As Long
    ForeColor = Text1.ForeColor
End Property

Public Property Let ForeColor(ByVal newValue As Long)
    Text1.ForeColor = newValue
    PropertyChanged "ForeColor"
End Property


' The Value property

Public Property Get Value() As Long
    Value = m_Value
End Property

Public Property Let Value(ByVal newValue As Long)
    m_Value = newValue
End Property


' The Text property

Public Property Get Text() As String
    Text = Text1.Text
End Property

Public Property Let Text(ByVal newValue As String)
    Text1.Text = newValue
    PropertyChanged "Text"
End Property

' The StartGetData method

Public Sub StartGetData(NumberOfTimes As Long)
    Dim i As Long, Text As String
    
    If EventItf Is Nothing Then
        For i = 1 To NumberOfTimes
            RaiseEvent GetData(Text)
        Next
    Else
        For i = 1 To NumberOfTimes
            EventItf.GetData Text
        Next
    End If
End Sub

