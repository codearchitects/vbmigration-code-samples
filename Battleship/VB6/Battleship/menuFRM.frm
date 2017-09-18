VERSION 5.00
Begin VB.Form MenuFRM 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   1095
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   1800
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   1095
   ScaleWidth      =   1800
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Label northTOsouthLBL 
      BackStyle       =   0  'Transparent
      Caption         =   "North to South"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   1575
   End
   Begin VB.Label leftTOrightLBL 
      BackStyle       =   0  'Transparent
      Caption         =   "Left to Right"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1575
   End
   Begin VB.Image Image1 
      Height          =   1095
      Left            =   0
      Picture         =   "menuFRM.frx":0000
      Stretch         =   -1  'True
      Top             =   0
      Width           =   1935
   End
End
Attribute VB_Name = "MenuFRM"
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
PlayWav "click!.wav"

End Sub

Private Sub Form_LostFocus()
If FORMtagg = "1" Then 'server
    ServerFRM.DestroyerLBL.BackColor = &H800000: ServerFRM.DestroyerLBL.ForeColor = &HFFFFFF: ServerFRM.SubMarineLBL.BackColor = &H800000: ServerFRM.SubMarineLBL.ForeColor = &HFFFFFF: ServerFRM.CarrierLBL.BackColor = &H800000: ServerFRM.CarrierLBL.ForeColor = &HFFFFFF: ServerFRM.battleshipLBL.BackColor = &H800000: ServerFRM.battleshipLBL.ForeColor = &HFFFFFF: ServerFRM.CruiserLBL.BackColor = &H800000: ServerFRM.CruiserLBL.ForeColor = &HFFFFFF: Unload Me
    Else 'client
        ClientFRM.DestroyerLBL.BackColor = &H800000: ClientFRM.DestroyerLBL.ForeColor = &HFFFFFF: ClientFRM.SubMarineLBL.BackColor = &H800000: ClientFRM.SubMarineLBL.ForeColor = &HFFFFFF: ClientFRM.CarrierLBL.BackColor = &H800000: ClientFRM.CarrierLBL.ForeColor = &HFFFFFF: ClientFRM.battleshipLBL.BackColor = &H800000: ClientFRM.battleshipLBL.ForeColor = &HFFFFFF: ClientFRM.CruiserLBL.BackColor = &H800000: ClientFRM.CruiserLBL.ForeColor = &HFFFFFF: Unload Me
End If

End Sub


Private Sub leftTOrightLBL_Click()
Dim f
If FORMtagg = "1" Then 'server
    For f = 1 To 240
    If ServerFRM.Field(f).BackColor = &H800000 Then 'if blue
        ServerFRM.Field(f).BackColor = &HFFFF& 'changes to  yellow
    End If
    Next
    WhiCHway = "lr" 'left to right
    Unload MenuFRM
    Else 'client
        For f = 1 To 240
        If ClientFRM.Field(f).BackColor = &H800000 Then 'if blue
            ClientFRM.Field(f).BackColor = &HFFFF& 'yellow
        End If
        Next
        WhiCHway = "lr" 'left to right
        Unload MenuFRM
End If


End Sub

Private Sub leftTOrightLBL_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
leftTOrightLBL.BackStyle = 1
leftTOrightLBL.BackColor = vbBlue
northTOsouthLBL.BackStyle = 0

End Sub

Private Sub northTOsouthLBL_Click()
Dim f
If FORMtagg = "1" Then
    For f = 1 To 240
    If ServerFRM.Field(f).BackColor = &H800000 Then
        ServerFRM.Field(f).BackColor = &HFFFF&
    End If
    Next
    WhiCHway = "ns"

    Unload MenuFRM
    Else
        For f = 1 To 240
        If ClientFRM.Field(f).BackColor = &H800000 Then
            ClientFRM.Field(f).BackColor = &HFFFF&
        End If
        Next
        WhiCHway = "ns"

        Unload MenuFRM
End If


End Sub

Private Sub northTOsouthLBL_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
northTOsouthLBL.BackStyle = 1
northTOsouthLBL.BackColor = vbBlue
leftTOrightLBL.BackStyle = 0

End Sub


