VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3420
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6585
   LinkTopic       =   "Form1"
   ScaleHeight     =   3420
   ScaleWidth      =   6585
   StartUpPosition =   3  'Windows Default
   Begin MSComctlLib.ListView ListView1 
      Height          =   2535
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   6255
      _ExtentX        =   11033
      _ExtentY        =   4471
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   2
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Employee Name"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Age"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.CommandButton cmdLoad 
      Caption         =   "Load Employees"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   0
      Top             =   2760
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const DBPATH = "c:\Program Files\Microsoft Visual Studio\VB98\nwind.mdb"

Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Dim employee As New CEmployee

Private Sub cmdLoad_Click()
    ' Open the recordset
    cn.Open "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH
    rs.Open "Employees", cn, adOpenKeyset, adLockOptimistic
    
    Set employee.DataSource = rs
    
    ' Load the records in the ListView control.
    Do Until rs.EOF
        ' Note that we're using derived CompleteName and Age properties.
        With ListView1.ListItems.Add(, , employee.CompleteName)
            .ListSubItems.Add , , employee.Age
        End With
        rs.MoveNext
    Loop
    rs.Close
    cn.Close

End Sub

