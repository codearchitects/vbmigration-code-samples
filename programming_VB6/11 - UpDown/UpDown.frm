VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmUpDown 
   Caption         =   "UpDown Control Demo"
   ClientHeight    =   2535
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5805
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
   ScaleHeight     =   2535
   ScaleWidth      =   5805
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdChangeBuddy 
      Caption         =   "Change Buddy Control"
      Height          =   375
      Left            =   480
      TabIndex        =   7
      Top             =   1320
      Width           =   2295
   End
   Begin VB.TextBox txtValue2 
      Alignment       =   2  'Center
      Height          =   375
      Left            =   480
      TabIndex        =   6
      Top             =   1920
      Width           =   2535
   End
   Begin MSComCtl2.UpDown updHorizontal 
      Height          =   240
      Left            =   4200
      TabIndex        =   5
      Top             =   720
      Width           =   375
      _ExtentX        =   661
      _ExtentY        =   423
      _Version        =   393216
      Orientation     =   1
      Enabled         =   -1  'True
   End
   Begin MSComCtl2.UpDown updVertical 
      Height          =   375
      Left            =   4560
      TabIndex        =   4
      Top             =   960
      Width           =   240
      _ExtentX        =   423
      _ExtentY        =   661
      _Version        =   393216
      Enabled         =   -1  'True
   End
   Begin MSComCtl2.UpDown updBuddy 
      Height          =   375
      Left            =   2760
      TabIndex        =   1
      Top             =   720
      Width           =   240
      _ExtentX        =   423
      _ExtentY        =   661
      _Version        =   393216
      AutoBuddy       =   -1  'True
      BuddyControl    =   "txtValue"
      BuddyDispid     =   196609
      OrigLeft        =   2760
      OrigTop         =   600
      OrigRight       =   3000
      OrigBottom      =   975
      SyncBuddy       =   -1  'True
      BuddyProperty   =   65547
      Enabled         =   -1  'True
   End
   Begin VB.TextBox txtValue 
      Alignment       =   2  'Center
      Height          =   375
      Left            =   480
      TabIndex        =   0
      Top             =   720
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "Moves all controls on this form using these UpDown's"
      Height          =   495
      Index           =   1
      Left            =   3240
      TabIndex        =   3
      Top             =   120
      Width           =   2535
   End
   Begin VB.Label Label1 
      Caption         =   "Type a new value or modify it with the UpDown control"
      Height          =   495
      Index           =   0
      Left            =   480
      TabIndex        =   2
      Top             =   120
      Width           =   2535
   End
End
Attribute VB_Name = "frmUpDown"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##updBuddy.WriteProperty "BuddyProperty", "Text"
'##project:DefaultMemberSupport False

Private Sub updHorizontal_DownClick()
    Dim ctrl As Control
    For Each ctrl In Controls
        ctrl.Left = ctrl.Left - ScaleY(1, vbPixels, vbTwips)
    Next
End Sub

Private Sub updHorizontal_UpClick()
    Dim ctrl As Control
    For Each ctrl In Controls
        ctrl.Left = ctrl.Left + ScaleY(1, vbPixels, vbTwips)
    Next
End Sub

Private Sub updVertical_DownClick()
    Dim ctrl As Control
    For Each ctrl In Controls
        ctrl.Top = ctrl.Top + ScaleY(1, vbPixels, vbTwips)
    Next
End Sub

Private Sub updVertical_UpClick()
    Dim ctrl As Control
    For Each ctrl In Controls
        ctrl.Top = ctrl.Top - ScaleY(1, vbPixels, vbTwips)
    Next
End Sub

Private Sub cmdChangeBuddy_Click()
    If updBuddy.BuddyControl = "txtValue" Then
        ' the BuddyControl property accepts both a reference
        ' and the name of the buddy control
        '##ReplaceStatement updBuddy.BuddyControl = txtValue2.Name
        Set updBuddy.BuddyControl = txtValue2
        updBuddy.BuddyProperty = "Text"
    Else
        updBuddy.BuddyControl = "txtValue"
        updBuddy.BuddyProperty = "Text"
    End If
End Sub


