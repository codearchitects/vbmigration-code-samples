VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form MnuCntrol 
   BorderStyle     =   0  'None
   Caption         =   "Form2"
   ClientHeight    =   930
   ClientLeft      =   150
   ClientTop       =   720
   ClientWidth     =   4680
   Icon            =   "MnuCntrol.frx":0000
   LinkTopic       =   "Form2"
   ScaleHeight     =   930
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   270
      Top             =   330
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label1 
      Caption         =   "This is for the menus on the main form"
      Height          =   255
      Left            =   1200
      TabIndex        =   0
      Top             =   360
      Width           =   3255
   End
   Begin VB.Menu MnuOptions 
      Caption         =   "options"
      Begin VB.Menu mnuSetup 
         Caption         =   "Setup"
      End
      Begin VB.Menu MnuOnTop 
         Caption         =   "Stay On Top"
         Begin VB.Menu MnuOnTopOn 
            Caption         =   "On"
         End
         Begin VB.Menu MnuOnTopOff 
            Caption         =   "Off"
            Checked         =   -1  'True
         End
      End
      Begin VB.Menu mnuLine1 
         Caption         =   "-"
      End
      Begin VB.Menu MnuBckClr 
         Caption         =   "Background Color"
      End
      Begin VB.Menu MnuFntClr 
         Caption         =   "Font Color"
      End
   End
   Begin VB.Menu MnuReset 
      Caption         =   "reset"
      Begin VB.Menu MnuClearTxt 
         Caption         =   "Clear Text"
      End
      Begin VB.Menu MnuLine3 
         Caption         =   "-"
      End
      Begin VB.Menu MnuExit 
         Caption         =   "Exit Program"
      End
   End
End
Attribute VB_Name = "MnuCntrol"
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

Private Sub MnuBckClr_Click()
    
    CommonDialog1.ShowColor
    MainFrm.ConsoleTxt.BackColor = CommonDialog1.Color

End Sub
Private Sub MnuClearTxt_Click()
    
    With MainFrm
        .ConsoleTxt.Text = ""
        .Picture1 = LoadPicture("")
    End With
    
End Sub
Private Sub MnuExit_Click()
    
    Call MainFrm.Exit_Click
    
End Sub
Private Sub MnuFntClr_Click()
    
    CommonDialog1.ShowColor
    MainFrm.ConsoleTxt.ForeColor = CommonDialog1.Color

End Sub
Private Sub MnuOnTopOff_Click()

    Call NotOntop(MainFrm)
    MnuOnTopOff.Checked = True
    MnuOnTopOn.Checked = False

End Sub
Private Sub MnuOnTopOn_Click()
    
    Call Ontop(MainFrm)
    MnuOnTopOn.Checked = True
    MnuOnTopOff.Checked = False

End Sub
Private Sub mnuSetup_Click()
    
    With OptionsFrm
        .Slider1.Value = Val(HAND_SPEED)
        .LocationTxt.Text = MODULE_PATH$ & "Hands.mod"
        .ChkLoop.Value = LOOP_IT
        .Show
    End With

End Sub
