VERSION 5.00
Begin VB.Form frm_Edit 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Edit A Person"
   ClientHeight    =   2280
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8055
   Icon            =   "frm_Edit.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2280
   ScaleWidth      =   8055
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
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
      Left            =   3660
      TabIndex        =   4
      Top             =   1065
      Width           =   3975
   End
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
      Left            =   420
      TabIndex        =   3
      Top             =   1080
      Width           =   3015
   End
   Begin VB.CommandButton btn_Last 
      Height          =   300
      Left            =   1620
      Picture         =   "frm_Edit.frx":08CA
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   1590
      UseMaskColor    =   -1  'True
      Width           =   345
   End
   Begin VB.CommandButton btn_Next 
      Height          =   300
      Left            =   1275
      Picture         =   "frm_Edit.frx":0C0C
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1590
      UseMaskColor    =   -1  'True
      Width           =   345
   End
   Begin VB.CommandButton btn_Previous 
      Height          =   300
      Left            =   780
      Picture         =   "frm_Edit.frx":0F4E
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   1590
      UseMaskColor    =   -1  'True
      Width           =   345
   End
   Begin VB.CommandButton btn_First 
      Height          =   300
      Left            =   435
      Picture         =   "frm_Edit.frx":1290
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1590
      UseMaskColor    =   -1  'True
      Width           =   345
   End
   Begin VB.CommandButton btn_Delete 
      Caption         =   "&Delete"
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
      Left            =   5535
      TabIndex        =   6
      Top             =   1545
      Width           =   975
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
      Left            =   420
      TabIndex        =   0
      Top             =   480
      Width           =   1575
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
      Left            =   2220
      TabIndex        =   1
      Top             =   480
      Width           =   1935
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
      Left            =   4380
      TabIndex        =   2
      Top             =   450
      Width           =   3255
   End
   Begin VB.CommandButton btn_Update 
      Caption         =   "&Update"
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
      Left            =   4425
      TabIndex        =   5
      Top             =   1545
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
      Left            =   6660
      TabIndex        =   7
      Top             =   1545
      Width           =   975
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
      Left            =   3780
      TabIndex        =   16
      Top             =   825
      Width           =   645
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
      Left            =   540
      TabIndex        =   15
      Top             =   825
      Width           =   420
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
      Left            =   540
      TabIndex        =   14
      Top             =   225
      Width           =   825
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
      Left            =   2340
      TabIndex        =   13
      Top             =   225
      Width           =   810
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
      Left            =   4500
      TabIndex        =   12
      Top             =   225
      Width           =   1410
   End
End
Attribute VB_Name = "frm_Edit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim v_rsEdit As New Recordset

Private Sub btn_Close_Click()
    Unload frm_Edit
End Sub

Private Sub btn_Delete_Click()
    Dim v_iMsg As Integer

    On Error GoTo Err

    v_iMsg = MsgBox("Are you sure you want to delete this person?", vbYesNo + vbQuestion, "Phone Book")
    If v_iMsg = vbYes Then
        v_rsEdit.Delete
        If Not v_rsEdit.EOF Then
            v_rsEdit.MoveNext
        End If
    Else
        Exit Sub
    End If
    Exit Sub
    
Err:
    MsgBox Err.Description, vbCritical
End Sub

Private Sub btn_First_Click()
    v_rsEdit.MoveFirst
End Sub

Private Sub btn_Last_Click()
    v_rsEdit.MoveLast
End Sub

Private Sub btn_Next_Click()
    If Not v_rsEdit.EOF Then v_rsEdit.MoveNext
    If v_rsEdit.EOF Then
        Beep
        v_rsEdit.MoveLast
    End If
End Sub

Private Sub btn_Previous_Click()
    If Not v_rsEdit.BOF Then v_rsEdit.MovePrevious
    If v_rsEdit.BOF Then
        Beep
        v_rsEdit.MoveFirst
    End If
End Sub

Private Sub btn_Update_Click()
    v_rsEdit.Update
End Sub

Private Sub Form_Load()
    Dim v_sActiveConnection As String

    v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App.Path & "\PhoneBook.mdb"
    v_rsEdit.Open "SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, adOpenDynamic, adLockPessimistic
    
    Set frm_Edit.tbx_FirstName.DataSource = v_rsEdit
    frm_Edit.tbx_FirstName.DataField = "FirstName"
    
    Set frm_Edit.tbx_LastName.DataSource = v_rsEdit
    frm_Edit.tbx_LastName.DataField = "LastName"
    
    Set frm_Edit.tbx_TelNo.DataSource = v_rsEdit
    frm_Edit.tbx_TelNo.DataField = "TelNo"

    Set frm_Edit.tbx_TelNo.DataSource = v_rsEdit
    frm_Edit.tbx_EMail.DataField = "EMail"

    Set frm_Edit.tbx_TelNo.DataSource = v_rsEdit
    frm_Edit.tbx_Address.DataField = "Address"
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Set v_rsEdit = Nothing
End Sub
