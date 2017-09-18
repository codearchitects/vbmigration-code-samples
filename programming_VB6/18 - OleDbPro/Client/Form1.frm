VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "OLE DB Simple Provider Demo"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
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
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdMove 
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   3600
      TabIndex        =   11
      Top             =   2640
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "+"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   2880
      TabIndex        =   10
      Top             =   2640
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">|"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   2160
      TabIndex        =   9
      Top             =   2640
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   1560
      TabIndex        =   8
      Top             =   2640
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   960
      TabIndex        =   7
      Top             =   2640
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "|<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   360
      TabIndex        =   6
      Top             =   2640
      Width           =   615
   End
   Begin VB.TextBox txtHomePhone 
      DataField       =   "HomePhone"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   360
      TabIndex        =   5
      Top             =   1920
      Width           =   3855
   End
   Begin VB.TextBox txtLastName 
      DataField       =   "LastName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   360
      TabIndex        =   1
      Top             =   1200
      Width           =   3855
   End
   Begin VB.TextBox txtFirstName 
      DataField       =   "FirstName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   480
      Width           =   3855
   End
   Begin VB.Label Label3 
      Caption         =   "&Home Phone"
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Top             =   1680
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "&Last Name"
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   960
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "&First Name"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   240
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Form_Load()
    cn.Open "Provider=TextOSP_VB;Data Source=TextOLEDBProvider.TextDataSource"
    rs.Open "G:\DOCS\LIBRI\Programming VB6\Code\18\OleDbPro\Employees.Txt", cn, adOpenStatic, adLockOptimistic
    
    Set txtFirstName.DataSource = rs
    Set txtLastName.DataSource = rs
    Set txtHomePhone.DataSource = rs
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    rs.Close
    cn.Close
End Sub

Private Sub cmdMove_Click(Index As Integer)
    Select Case Index
        Case 0
            If Not rs.BOF Then rs.MoveFirst
        Case 1
            rs.MovePrevious
        Case 2
            If Not rs.EOF Then rs.MoveNext
        Case 3
            rs.MoveLast
        Case 4
            rs.AddNew
        Case 5
            rs.Delete
    End Select
            
End Sub

