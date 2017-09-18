VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "BindingCollection Demo"
   ClientHeight    =   2745
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5790
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
   ScaleHeight     =   2745
   ScaleWidth      =   5790
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtHireDate 
      Height          =   375
      Left            =   3000
      TabIndex        =   10
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtLastName 
      Height          =   375
      Left            =   3000
      TabIndex        =   8
      Top             =   360
      Width           =   2535
   End
   Begin VB.TextBox txtFirstName 
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   360
      Width           =   2655
   End
   Begin VB.TextBox txtBirthDate 
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   1200
      Width           =   2655
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Last"
      Height          =   495
      Index           =   3
      Left            =   4200
      TabIndex        =   3
      Top             =   2040
      Width           =   1335
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Next"
      Height          =   495
      Index           =   2
      Left            =   2880
      TabIndex        =   2
      Top             =   2040
      Width           =   1335
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "Previous"
      Height          =   495
      Index           =   1
      Left            =   1560
      TabIndex        =   1
      Top             =   2040
      Width           =   1335
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "First"
      Height          =   495
      Index           =   0
      Left            =   240
      TabIndex        =   0
      Top             =   2040
      Width           =   1335
   End
   Begin VB.Label Label6 
      Caption         =   "&Hire Date"
      Height          =   255
      Left            =   3000
      TabIndex        =   11
      Top             =   960
      Width           =   2655
   End
   Begin VB.Label Label5 
      Caption         =   "&Last Name"
      Height          =   255
      Left            =   3000
      TabIndex        =   9
      Top             =   120
      Width           =   2415
   End
   Begin VB.Label Label4 
      Caption         =   "&First Name"
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   120
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "&Birth Date"
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   960
      Width           =   2655
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const DBPATH = "c:\program files\microsoft visual studio\Vb98\nwind.mdb"

Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset
Dim WithEvents bndcol As BindingCollection
Attribute bndcol.VB_VarHelpID = -1

Dim DateFormat As New StdDataFormat
Dim WithEvents col As BindingCollection
Attribute col.VB_VarHelpID = -1

Private Sub Form_Load()
    ' Open the recordset
    cn.Open "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH
    rs.Open "Employees", cn, adOpenKeyset, adLockOptimistic
    
    ' Create the two StdDataFormat objects
    DateFormat.Type = fmtCustom
    DateFormat.Format = "mmmm dd, yyyy"
    
    ' bind the recordset to fields
    Set bndcol = New BindingCollection
    Set bndcol.DataSource = rs
    bndcol.Add txtFirstName, "Text", "FirstName"
    bndcol.Add txtLastName, "Text", "LastName"
    bndcol.Add txtBirthDate, "Text", "BirthDate", DateFormat
    bndcol.Add txtHireDate, "Text", "HireDate", DateFormat
End Sub

Private Sub cmdMove_Click(Index As Integer)
    Select Case Index
        Case 0
            rs.MoveFirst
        Case 1
            rs.MovePrevious
        Case 2
            rs.MoveNext
        Case 3
            rs.MoveLast
    End Select
End Sub

Private Sub bndcol_Error(ByVal Error As Long, ByVal Description As String, ByVal Binding As MSBind.Binding, fCancelDisplay As Boolean)
    MsgBox "An error has occurred:" & vbCr _
        & "Code: " & Error & vbCr _
        & "Description: " & Description, vbExclamation
        fCancelDisplay = True
End Sub


