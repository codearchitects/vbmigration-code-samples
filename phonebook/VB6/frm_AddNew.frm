VERSION 5.00
Begin VB.Form frm_AddNew 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Add New Person"
   ClientHeight    =   2400
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8190
   Icon            =   "frm_AddNew.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2400
   ScaleWidth      =   8190
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox tbx_Address 
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
      Left            =   3480
      TabIndex        =   4
      Top             =   1185
      Width           =   4335
   End
   Begin VB.TextBox tbx_EMail 
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
      Left            =   360
      TabIndex        =   3
      Top             =   1185
      Width           =   2775
   End
   Begin VB.CommandButton btn_Cancel 
      Caption         =   "&Cancel"
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
      Left            =   6836
      TabIndex        =   6
      Top             =   1680
      Width           =   975
   End
   Begin VB.CommandButton btn_Add 
      Caption         =   "&Add"
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
      Left            =   5786
      TabIndex        =   5
      Top             =   1680
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
      Left            =   4335
      TabIndex        =   2
      Top             =   480
      Width           =   3480
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
      Left            =   2179
      TabIndex        =   1
      Top             =   488
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
      Left            =   379
      TabIndex        =   0
      Top             =   488
      Width           =   1575
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
      Left            =   3600
      TabIndex        =   11
      Top             =   960
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
      Left            =   480
      TabIndex        =   10
      Top             =   960
      Width           =   420
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
      Left            =   4470
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
      Left            =   2306
      TabIndex        =   8
      Top             =   248
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
      Left            =   506
      TabIndex        =   7
      Top             =   248
      Width           =   825
   End
End
Attribute VB_Name = "frm_AddNew"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btn_Cancel_Click()
    Unload frm_AddNew
End Sub

Private Sub btn_Add_Click()
    Dim v_rsAdd As New Recordset
    Dim v_sActiveConnection As String
    
    On Error GoTo Err
    
    If frm_AddNew.tbx_FirstName.Text = "" Or _
       frm_AddNew.tbx_LastName.Text = "" Or _
       frm_AddNew.tbx_TelNo.Text = "" Then
            MsgBox "You should fill all the textboxes.", vbCritical, "Phone Book"
            Exit Sub
    End If

    v_sActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & App.Path & "\PhoneBook.mdb"
    v_rsAdd.Open "SELECT * FROM PhoneBook ORDER BY FirstName", v_sActiveConnection, adOpenDynamic, adLockPessimistic

    v_rsAdd.AddNew
    If frm_AddNew.tbx_FirstName.Text = "" Then
        v_rsAdd!FirstName = ""
    Else
        v_rsAdd!FirstName = frm_AddNew.tbx_FirstName.Text
    End If
    
    If frm_AddNew.tbx_LastName.Text = "" Then
        v_rsAdd!LastName = ""
    Else
        v_rsAdd!LastName = frm_AddNew.tbx_LastName.Text
    End If
    
    If frm_AddNew.tbx_TelNo.Text = "" Then
        v_rsAdd!TelNo = ""
    Else
        v_rsAdd!TelNo = frm_AddNew.tbx_TelNo.Text
    End If
    
    If frm_AddNew.tbx_EMail.Text = "" Then
        v_rsAdd!EMail = ""
    Else
        v_rsAdd!EMail = frm_AddNew.tbx_EMail.Text
    End If
    
    If frm_AddNew.tbx_Address.Text = "" Then
        v_rsAdd!Address = ""
    Else
        v_rsAdd!Address = frm_AddNew.tbx_Address.Text
    End If
    v_rsAdd.Update
    Unload frm_AddNew
    Exit Sub
    
Err:
    MsgBox Err.Description, vbCritical
End Sub
