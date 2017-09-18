VERSION 5.00
Object = "{C6B06BB5-CAC5-11D2-ACF7-0080C8F21830}#1.0#0"; "MyTextBox.OCX"
Begin VB.Form Form1 
   Caption         =   "Optimize OCX"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin MyTB.MyTextBox MyTextBox1 
      Height          =   735
      Left            =   240
      TabIndex        =   2
      Top             =   1560
      Width           =   3975
      _ExtentX        =   7011
      _ExtentY        =   1296
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Events"
      Height          =   495
      Left            =   2520
      TabIndex        =   1
      Top             =   2520
      Width           =   1695
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Properties"
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   2520
      Width           =   1695
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Implements MyTextboxEvents

Dim MyTextBoxCls As MyTextBoxCls

Private Sub Form_Load()
    Set MyTextBoxCls = MyTextBox1.ObjectAux
End Sub

Private Sub Command1_Click()
    Dim t As Single, i As Long, res As Long
    Cls
    
    t = Timer
    For i = 1 To 50000
        res = MyTextBox1.ForeColor
    Next
    Print "MyTextBox1.ForeColor = " & Format$(Timer - t, "###.##") & " secs."
    
    t = Timer
    For i = 1 To 50000
        res = MyTextBoxCls.ForeColor
    Next
    Print "MyTextBoxCls.ForeColor = " & Format$(Timer - t, "###.##") & " secs."
    Print
    
    t = Timer
    For i = 1 To 50000
        res = MyTextBox1.Value
    Next
    Print "MyTextBox1.Value = " & Format$(Timer - t, "###.##") & " secs."
    
    t = Timer
    For i = 1 To 50000
        res = MyTextBoxCls.Value
    Next
    Print "MyTextBoxCls.Value = " & Format$(Timer - t, "###.##") & " secs."

End Sub

Private Sub Command2_Click()
    Dim t As Single, i As Long
    Cls
    
    t = Timer
    Set MyTextBox1.EventItf = Nothing
    MyTextBox1.StartGetData 500000
    Print "RaiseEvent = " & Format$(Timer - t, "###.##") & " secs."
    
    t = Timer
    Set MyTextBox1.EventItf = Me
    MyTextBox1.StartGetData 500000
    Print "EventItf.Change = " & Format$(Timer - t, "###.##") & " secs."
    
End Sub


Private Sub MyTextBox1_GetData(Text As String)
    ' do nothing in this demo
End Sub

Private Sub MyTextboxEvents_GetData(Text As String)
    ' do nothing in this demo
End Sub
