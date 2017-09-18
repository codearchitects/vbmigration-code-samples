VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form OptionsFrm 
   Caption         =   "Type-N-Sign  (Options Menu)"
   ClientHeight    =   3465
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7245
   HasDC           =   0   'False
   Icon            =   "OptionsFrm.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   3465
   ScaleWidth      =   7245
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      Caption         =   "Frame2"
      Height          =   1095
      Left            =   1680
      TabIndex        =   9
      Top             =   1440
      Width           =   5415
      Begin VB.TextBox LocationTxt 
         Height          =   285
         Left            =   240
         TabIndex        =   11
         Top             =   360
         Width           =   4935
      End
      Begin VB.CommandButton LoadFile 
         Caption         =   "Locate"
         Height          =   255
         Left            =   4200
         TabIndex        =   10
         Top             =   720
         Width           =   975
      End
      Begin VB.Label Label4 
         Caption         =   "Location of Picture Module"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   0
         Width           =   2055
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Options"
      Height          =   1215
      Left            =   1680
      TabIndex        =   3
      Top             =   120
      Width           =   5415
      Begin VB.CheckBox ChkLoop 
         Caption         =   "Continuous Play"
         Height          =   255
         Left            =   240
         TabIndex        =   8
         Top             =   720
         Width           =   1455
      End
      Begin MSComctlLib.Slider Slider1 
         Height          =   255
         Left            =   600
         TabIndex        =   4
         Top             =   360
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   450
         _Version        =   393216
         LargeChange     =   10
         Min             =   1
         Max             =   50
         SelStart        =   1
         Value           =   1
      End
      Begin VB.Label Label3 
         Caption         =   "Slow"
         Height          =   255
         Left            =   4800
         TabIndex        =   7
         Top             =   360
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "Fast"
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   360
         Width           =   375
      End
      Begin VB.Label Label1 
         Caption         =   "Hand Speed"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   0
         Width           =   975
      End
   End
   Begin VB.CommandButton okBtn 
      Caption         =   "Ok"
      Height          =   375
      Left            =   4680
      TabIndex        =   2
      Top             =   3000
      Width           =   1095
   End
   Begin VB.CommandButton CancelBtn 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   6000
      TabIndex        =   1
      Top             =   3000
      Width           =   1095
   End
   Begin VB.PictureBox Picture1 
      Height          =   3255
      Left            =   120
      Picture         =   "OptionsFrm.frx":000C
      ScaleHeight     =   3195
      ScaleWidth      =   1395
      TabIndex        =   0
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "OptionsFrm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'//////////////////////////////////////////
'//                   ____
'//    _______       /  / \  (_GrayHat_)
'//    \      \  __ /  /\  \____   ____
'//    /   |   \/ _<  <  >  >   \_/ __ \
'//   /    |   ( <_>\  \/  /  |  \  ___/
'//   \____|____\___/\__\_/|__|__/\____>
'//
'//             [GNU license]
'//   http://org.gnu.de/copyleft/gpl.html
'//
'//////////////////////////////////////////

Private Sub Form_GotFocus()

    Slider1.Value = Val(HAND_SPEED)
    LocationTxt.Text = Trim(MODULE_PATH$)
    ChkLoop.Value = LOOP_IT
    
End Sub
Private Sub LoadFile_Click()
'///////////////////////////////////
'// LOAD MODULES
'///////////////
    
    Dim Buffer As String
    On Error GoTo eror
    
    With MnuCntrol.CommonDialog1
        .Filter = "Type-n-sign Module Index File (Hands.mod) | Hands.mod"
        .ShowOpen
    End With
    
        Buffer$ = MnuCntrol.CommonDialog1.FileName
            LocationTxt.Text = Buffer$
            
        Buffer$ = Left(Buffer$, (Len(Buffer$) - 9)) '// hands.mod = 9 leters,
        MODULE_PATH$ = Buffer$                      '// Index file for commonDialog
        
    Exit Sub

eror:

End Sub
Private Sub okBtn_Click()
'//////////////////////////////////
'// OK BUTTON
'/////////////////
    Dim Buffer As String
    On Error GoTo eror

    Buffer$ = LocationTxt.Text                  '// Get module path
    Buffer$ = Left(Buffer$, (Len(Buffer$) - 9)) '// hands.mod = 9 leters :)
    
        Call WriteToINI(APP_NAME, "ModPath", Buffer$, INIFILE)
        
        MODULE_PATH$ = Buffer$
        
        HAND_SPEED = Slider1.Value
        Call WriteToINI(APP_NAME, "HandSpeed", HAND_SPEED, INIFILE)
    
        LOOP_IT = ChkLoop.Value
        Call WriteToINI(APP_NAME, "Loop", LOOP_IT, INIFILE)
    
    Me.Hide
    Exit Sub

eror:
End Sub
Private Sub CancelBtn_Click()

    Me.Hide
    
End Sub
