VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frm_Find 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Find A Person"
   ClientHeight    =   3390
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8445
   Icon            =   "frm_Find.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3390
   ScaleWidth      =   8445
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox tbx_EMail 
      DataField       =   "FirstName"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   367
      TabIndex        =   3
      Top             =   1095
      Width           =   3015
   End
   Begin VB.TextBox tbx_Address 
      DataField       =   "FirstName"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   3607
      TabIndex        =   4
      Top             =   1095
      Width           =   3255
   End
   Begin MSComctlLib.ListView lvw_Find 
      Height          =   1455
      Left            =   375
      TabIndex        =   10
      Top             =   1575
      Width           =   7695
      _ExtentX        =   13573
      _ExtentY        =   2566
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   3
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "First Name"
         Object.Width           =   2910
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Last Name"
         Object.Width           =   3704
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Telephone Number"
         Object.Width           =   6350
      EndProperty
   End
   Begin VB.CommandButton btn_Find 
      Caption         =   "&Find"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7102
      TabIndex        =   5
      Top             =   495
      Width           =   975
   End
   Begin VB.CommandButton btn_Close 
      Caption         =   "&Close"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7102
      TabIndex        =   6
      Top             =   975
      Width           =   975
   End
   Begin VB.TextBox tbx_TelNo 
      DataField       =   "TelNo"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   4342
      TabIndex        =   2
      Top             =   495
      Width           =   2535
   End
   Begin VB.TextBox tbx_LastName 
      DataField       =   "LastName"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   2182
      TabIndex        =   1
      Top             =   495
      Width           =   1935
   End
   Begin VB.TextBox tbx_FirstName 
      DataField       =   "FirstName"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   382
      TabIndex        =   0
      Top             =   495
      Width           =   1575
   End
   Begin VB.Label lbl_EMail 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "EMail:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   480
      TabIndex        =   12
      Top             =   855
      Width           =   420
   End
   Begin VB.Label lbl_Address 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Address:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   3720
      TabIndex        =   11
      Top             =   855
      Width           =   645
   End
   Begin VB.Line lin_Line 
      BorderColor     =   &H00FFFFFF&
      Index           =   1
      X1              =   375
      X2              =   8055
      Y1              =   1470
      Y2              =   1470
   End
   Begin VB.Line lin_Line 
      BorderColor     =   &H00808080&
      Index           =   0
      X1              =   375
      X2              =   8055
      Y1              =   1455
      Y2              =   1455
   End
   Begin VB.Label lbl_TelNo 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Telephone Number:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   4455
      TabIndex        =   9
      Top             =   255
      Width           =   1410
   End
   Begin VB.Label lbl_LastName 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Last Name:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   2295
      TabIndex        =   8
      Top             =   255
      Width           =   810
   End
   Begin VB.Label lbl_FirstName 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "First Name:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   495
      TabIndex        =   7
      Top             =   255
      Width           =   825
   End
End
Attribute VB_Name = "frm_Find"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btn_Close_Click()
    Unload frm_Find
End Sub

Private Sub btn_Find_Click()
    Dim v_sSQL As String
    Dim v_rsFind As New Recordset
    Dim v_iLoop As Integer
    Dim v_sActiveConnection As String
    Dim v_iIndex As Integer
    
    On Error GoTo Err
    
    frm_Find.lvw_Find.ListItems.Clear
    
    v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App.Path & "\PhoneBook.mdb"
    v_sSQL = "SELECT * FROM PhoneBook WHERE "
    
    If frm_Find.tbx_FirstName.Text <> "" Then
        v_sSQL = v_sSQL & "FirstName LIKE '" & frm_Find.tbx_FirstName.Text & "' AND "
    End If
    
    If frm_Find.tbx_LastName.Text <> "" Then
        v_sSQL = v_sSQL & "LastName LIKE '" & frm_Find.tbx_LastName.Text & "' AND "
    End If
    
    If frm_Find.tbx_TelNo.Text <> "" Then
        v_sSQL = v_sSQL & "TelNo LIKE '" & frm_Find.tbx_TelNo.Text & "' AND "
    End If
    
    If frm_Find.tbx_EMail.Text <> "" Then
        v_sSQL = v_sSQL & "EMail LIKE '" & frm_Find.tbx_EMail.Text & "' AND "
    End If
    
    If frm_Find.tbx_Address.Text <> "" Then
        v_sSQL = v_sSQL & "Address LIKE '" & frm_Find.tbx_Address.Text & "' AND "
    End If
    
    v_sSQL = Left(v_sSQL, Len(v_sSQL) - 5)
    v_rsFind.Open v_sSQL, v_sActiveConnection
    
    While Not v_rsFind.EOF
        v_iIndex = v_iIndex + 1
        frm_Find.lvw_Find.ListItems.Add , , v_rsFind.Fields!FirstName
        frm_Find.lvw_Find.ListItems(v_iIndex).ListSubItems.Add 1, , v_rsFind.Fields!LastName
        frm_Find.lvw_Find.ListItems(v_iIndex).ListSubItems.Add 2, , v_rsFind.Fields!TelNo
        v_rsFind.MoveNext
    Wend
    Exit Sub
    
Err:
    MsgBox Err.Description, vbCritical
End Sub
