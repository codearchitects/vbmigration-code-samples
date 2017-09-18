VERSION 5.00
Begin VB.Form frmGrid 
   Caption         =   "Data Object Wizard Demo - Data Grid"
   ClientHeight    =   3390
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8535
   LinkTopic       =   "Form1"
   ScaleHeight     =   3390
   ScaleWidth      =   8535
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdFetch 
      Caption         =   "Fetch"
      Default         =   -1  'True
      Height          =   375
      Left            =   5640
      TabIndex        =   2
      Top             =   0
      Width           =   1095
   End
   Begin VB.TextBox txtProductName 
      Height          =   405
      Left            =   4200
      TabIndex        =   1
      Top             =   0
      Width           =   1215
   End
   Begin Project1.uctProductsDataGrid uctProductsDataGrid1 
      Height          =   2775
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   8295
      _ExtentX        =   14631
      _ExtentY        =   4895
      ManualInitialize=   -1  'True
      GridEditable    =   -1  'True
   End
   Begin VB.Label Label1 
      Caption         =   "Enter search expression (use % and _ as wildcards)"
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   120
      Width           =   3855
   End
End
Attribute VB_Name = "frmGrid"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdFetch_Click()
    uctProductsDataGrid1.Products_FetchProductName = txtProductName & "%"
    uctProductsDataGrid1.InitProducts2
End Sub

Private Sub Form_Resize()
    With uctProductsDataGrid1
        .Width = ScaleWidth - .Left * 2
        .Height = ScaleHeight - .Top - 100
    End With
End Sub
