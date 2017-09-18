VERSION 5.00
Object = "*\AMyData.vbp"
Begin VB.Form Form1 
   Caption         =   "MyDataControl Demo"
   ClientHeight    =   4425
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4065
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
   ScaleHeight     =   4425
   ScaleWidth      =   4065
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Filter on Name"
      Height          =   975
      Left            =   120
      TabIndex        =   9
      Top             =   2400
      Width           =   3615
      Begin VB.CommandButton cmdApply 
         Caption         =   "Apply"
         Height          =   375
         Left            =   2640
         TabIndex        =   11
         Top             =   360
         Width           =   735
      End
      Begin VB.TextBox txtFilter 
         Height          =   375
         Left            =   240
         TabIndex        =   10
         Top             =   360
         Width           =   2415
      End
   End
   Begin VB.TextBox txtCity 
      DataField       =   "City"
      DataSource      =   "MyDataControl1"
      Height          =   375
      Left            =   360
      TabIndex        =   7
      Top             =   1800
      Width           =   1455
   End
   Begin VB.TextBox txtState 
      DataField       =   "State"
      DataSource      =   "MyDataControl1"
      Height          =   375
      Left            =   2280
      TabIndex        =   5
      Top             =   1800
      Width           =   1335
   End
   Begin Project1.MyDataControl MyDataControl1 
      Height          =   495
      Left            =   360
      TabIndex        =   2
      Top             =   3600
      Width           =   3495
      _ExtentX        =   6165
      _ExtentY        =   873
      RecordSource    =   "Publishers"
      ConnectionString=   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=c:\program files\microsoft visual studio\VB98\Biblio.mdb"
   End
   Begin VB.TextBox txtAddress 
      DataField       =   "Address"
      DataSource      =   "MyDataControl1"
      Height          =   375
      Left            =   360
      TabIndex        =   1
      Top             =   1080
      Width           =   3255
   End
   Begin VB.TextBox txtName 
      DataField       =   "Company Name"
      DataSource      =   "MyDataControl1"
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   3255
   End
   Begin VB.Label Label1 
      Caption         =   "&City"
      Height          =   255
      Index           =   3
      Left            =   360
      TabIndex        =   8
      Top             =   1560
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "&State"
      Height          =   255
      Index           =   2
      Left            =   2280
      TabIndex        =   6
      Top             =   1560
      Width           =   2535
   End
   Begin VB.Label Label1 
      Caption         =   "&Address"
      Height          =   255
      Index           =   1
      Left            =   360
      TabIndex        =   4
      Top             =   840
      Width           =   2535
   End
   Begin VB.Label Label1 
      Caption         =   "Publisher &Name"
      Height          =   255
      Index           =   0
      Left            =   360
      TabIndex        =   3
      Top             =   120
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'## AddReference "C:\Program Files\Microsoft.NET\Primary Interop Assemblies\adodb.dll"

Option Explicit

Const DATABASE_NAME = "c:\program files\microsoft visual studio\VB98\Biblio.mdb"

Private Sub txtFilter_Change()
    cmdApply.Enabled = True
End Sub

Private Sub cmdApply_Click()
    If txtFilter = "" Then
        MyDataControl1.RecordSource = "Publishers"
    Else
        MyDataControl1.RecordSource = "Select * From Publishers Where Name Like '" & txtFilter & "%'"
    End If
    MyDataControl1.Refresh
    cmdApply.Enabled = False
End Sub

Private Sub Form_Load()
    MyDataControl1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DATABASE_NAME
End Sub

