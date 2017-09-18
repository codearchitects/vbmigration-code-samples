VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "CTextBoxNum / CTextBoxCalc Demo"
   ClientHeight    =   3735
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6015
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   3735
   ScaleWidth      =   6015
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtGrandTotal 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   2880
      TabIndex        =   6
      Top             =   2640
      Width           =   2055
   End
   Begin VB.TextBox txtTax 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   2880
      TabIndex        =   4
      Top             =   1680
      Width           =   2055
   End
   Begin VB.TextBox txtPercent 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   600
      TabIndex        =   2
      Top             =   1680
      Width           =   1335
   End
   Begin VB.TextBox txtAmount 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   2880
      TabIndex        =   0
      Top             =   720
      Width           =   2055
   End
   Begin VB.Label Label4 
      Caption         =   "&Grand Total"
      Height          =   375
      Left            =   2880
      TabIndex        =   7
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label Label3 
      Caption         =   "&Tax"
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label Label2 
      Caption         =   "Tax &Percent"
      Height          =   375
      Left            =   600
      TabIndex        =   3
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label Label1 
      Caption         =   "&Amount"
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Top             =   360
      Width           =   1935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Amount As CTextBoxNum
Dim WithEvents Percentage As CTextBoxNum
Attribute Percentage.VB_VarHelpID = -1
Dim Tax As CTextBoxCalc
Dim GrandTotal As CTextBoxCalc

Private Sub Form_Load()
    Set Amount = New CTextBoxNum
    Set Amount.TextBox = txtAmount
    Set Percentage = New CTextBoxNum
    Set Percentage.TextBox = txtPercent
    Set Tax = New CTextBoxCalc
    Set Tax.TextBox = txtTax
    Set GrandTotal = New CTextBoxCalc
    Set GrandTotal.TextBox = txtGrandTotal
    
    Amount.FormatMask = "#,###,###"
    Amount.SelectOnEntry = True
    Percentage.FormatMask = "0.00"
    Percentage.IsDecimal = True
    Percentage.SelectOnEntry = True
    Percentage.Min = 0: Percentage.Max = 100
    
    Tax.SetExpression txtAmount, "*", txtPercent, "/", 100
    Tax.FormatMask = "#,###,###"
    GrandTotal.SetExpression txtAmount, "+", txtTax
    GrandTotal.FormatMask = "#,###,###"
End Sub

' These statements aren't in the printed edition of the book.

Private Sub Form_Unload(Cancel As Integer)
    Set Amount = Nothing
    Set Percentage = Nothing
    Set Tax = Nothing
    Set GrandTotal = Nothing
End Sub


Private Sub Percentage_ValidateError(Cancel As Boolean)
    MsgBox "Invalid Percentage Value", vbExclamation
    Cancel = True
End Sub
