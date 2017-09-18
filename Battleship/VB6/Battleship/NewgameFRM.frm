VERSION 5.00
Begin VB.Form NewgameFRM 
   BackColor       =   &H00FF8080&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "New Game?"
   ClientHeight    =   840
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   2430
   ControlBox      =   0   'False
   Icon            =   "NewgameFRM.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   840
   ScaleWidth      =   2430
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton noCMD 
      Caption         =   "&No"
      Height          =   375
      Left            =   1200
      TabIndex        =   2
      Top             =   240
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FF8080&
      Caption         =   "Play Again?"
      ForeColor       =   &H00FFFFFF&
      Height          =   735
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   2415
      Begin VB.CommandButton yesCMD 
         Caption         =   "&Yes"
         Height          =   375
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   1095
      End
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "© 2000 One"
      BeginProperty Font 
         Name            =   "MS Serif"
         Size            =   6
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   135
      Left            =   0
      TabIndex        =   3
      Top             =   720
      Width           =   855
   End
End
Attribute VB_Name = "NewgameFRM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'

Private Sub Form_Load()
    CenterForm Me

End Sub

Private Sub noCMD_Click()
    PlayWav "douhavtogo.wav"
    TimeOUT 3.68 'lets the sound play
    End
    
End Sub

Private Sub yesCMD_Click()
    If FORMtagg = "1" Then
        ServerFRM.GameStatsLBL.Caption = "Select Your Ships..."
        ServerFRM.startNEWgame
        ServerFRM.MainTXT.SelText = "¨'°*·º·*°'¨ ": ServerFRM.MainTXT.SelColor = vbBlue: ServerFRM.MainTXT.SelText = "New Game": ServerFRM.MainTXT.SelColor = vbBlack: ServerFRM.MainTXT.SelText = " ¨'°*·º·*°'¨" & vbCrLf
        Else
            ClientFRM.GameStatsLBL.Caption = "Select Your Ships..."
            ClientFRM.startNEWgame
            ClientFRM.MainTXT.SelText = "¨'°*·º·*°'¨ ": ClientFRM.MainTXT.SelColor = vbBlue: ClientFRM.MainTXT.SelText = "New Game": ClientFRM.MainTXT.SelColor = vbBlack: ClientFRM.MainTXT.SelText = " ¨'°*·º·*°'¨" & vbCrLf
    End If
    Unload Me
    
End Sub
