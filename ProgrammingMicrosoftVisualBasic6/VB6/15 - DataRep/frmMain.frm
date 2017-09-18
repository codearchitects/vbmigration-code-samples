VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "DataReport demo"
   ClientHeight    =   3015
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5175
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
   ScaleHeight     =   3015
   ScaleWidth      =   5175
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkShowDetails 
      Caption         =   "&Show Order Details"
      Height          =   255
      Left            =   2760
      TabIndex        =   8
      Top             =   960
      Width           =   2175
   End
   Begin VB.OptionButton optOperation 
      Caption         =   "&Export"
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   4
      Top             =   840
      Width           =   975
   End
   Begin VB.OptionButton optOperation 
      Caption         =   "&Preview"
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   3
      Top             =   360
      Width           =   1815
   End
   Begin VB.CommandButton cmdCustomers 
      Caption         =   "Customers"
      Height          =   495
      Left            =   2760
      TabIndex        =   1
      Top             =   1560
      Width           =   1935
   End
   Begin VB.CommandButton cmdOrders 
      Caption         =   "Orders"
      Height          =   495
      Left            =   2760
      TabIndex        =   0
      Top             =   360
      Width           =   1935
   End
   Begin VB.Frame Frame1 
      Caption         =   "Frame1"
      Height          =   1215
      Left            =   120
      TabIndex        =   5
      Top             =   840
      Width           =   2415
      Begin VB.OptionButton optFormat 
         Caption         =   "&Html"
         Height          =   255
         Index           =   1
         Left            =   480
         TabIndex        =   7
         Top             =   840
         Width           =   1695
      End
      Begin VB.OptionButton optFormat 
         Caption         =   "&Text"
         Height          =   255
         Index           =   0
         Left            =   480
         TabIndex        =   6
         Top             =   480
         Value           =   -1  'True
         Width           =   1695
      End
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   0
      TabIndex        =   2
      Top             =   2520
      Width           =   3015
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdOrders_Click()
    DataReport1.ShowDetails = chkShowDetails.Value
    If optOperation(0) Then
        DataReport1.Show
        DataReport1.WindowState = vbMaximized
    Else
        DataReport1.ExportReport GetFormat, App.Path & "\Orders", True
    End If
    Set DataReport1 = Nothing
End Sub

Private Sub cmdCustomers_Click()
    If optOperation(0) Then
        DataReport2.Show
        DataReport2.WindowState = vbMaximized
    Else
        DataReport2.ExportReport GetFormat, App.Path & "\Customers", True
    End If
    Set DataReport2 = Nothing
End Sub

Private Sub Form_Load()
    optOperation(0).Value = True
End Sub

Private Sub Form_Resize()
    lblStatus.Move 0, ScaleHeight - lblStatus.Height, ScaleWidth
End Sub

Private Function GetFormat() As String
    If optFormat(0) Then
        GetFormat = rptKeyText
    Else
        GetFormat = rptKeyHTML
    End If
End Function

Private Sub optOperation_Click(Index As Integer)
    optFormat(0).Enabled = (Index = 1)
    optFormat(1).Enabled = (Index = 1)
End Sub
