VERSION 5.00
Begin VB.Form ScrollPicture 
   Appearance      =   0  'Flat
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About..."
   ClientHeight    =   1995
   ClientLeft      =   1230
   ClientTop       =   1590
   ClientWidth     =   3810
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00C0C0C0&
   LinkMode        =   1  'Source
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   1995
   ScaleWidth      =   3810
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command1 
      Caption         =   "Close"
      Height          =   255
      Left            =   2970
      TabIndex        =   2
      Top             =   1680
      Width           =   735
   End
   Begin VB.PictureBox Picture1 
      Height          =   1410
      Left            =   120
      ScaleHeight     =   1350
      ScaleWidth      =   3525
      TabIndex        =   0
      Top             =   120
      Width           =   3585
      Begin VB.PictureBox Picture2 
         Appearance      =   0  'Flat
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   1095
         Left            =   120
         ScaleHeight     =   1095
         ScaleWidth      =   3300
         TabIndex        =   1
         Top             =   120
         Visible         =   0   'False
         Width           =   3300
      End
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   120
      Tag             =   "1"
      Top             =   1560
   End
End
Attribute VB_Name = "ScrollPicture"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub PrintCenter(C As Control, Txt As String)
    C.CurrentX = (C.ScaleWidth - C.TextWidth(Txt)) / 2
    C.Print Txt
End Sub

Private Sub Command1_Click()

Unload ScrollPicture

End Sub

Private Sub Form_Load()

Show

Picture1.Cls
Timer1.Enabled = 0
Picture2.Visible = 0
Picture2.AutoRedraw = -1
Picture2.Top = Picture1.ScaleHeight
Picture2.BackColor = Picture1.BackColor
Picture2.Height = 16 * Picture1.TextHeight("A")
Picture2.CurrentY = 0

PrintCenter Picture2, "Photo Album ver. " & App.Major & "." & App.Minor & "." & App.Revision
PrintCenter Picture2, ""
PrintCenter Picture2, ""
PrintCenter Picture2, "Software designed by:"
PrintCenter Picture2, ""
PrintCenter Picture2, "TOTARO Salvatore"
PrintCenter Picture2, "aka"
PrintCenter Picture2, "PaperQuack"
PrintCenter Picture2, ""
PrintCenter Picture2, ""
PrintCenter Picture2, "For bugs, info or reports please"
PrintCenter Picture2, "eMail us to: paperquak@libero.it"
PrintCenter Picture2, ""
PrintCenter Picture2, ""
PrintCenter Picture2, "This program is FREEWARE!"
PrintCenter Picture2, "You can distriduited it as is."

Picture2.Visible = -1
Timer1.Enabled = -1

End Sub


Private Sub Timer1_Timer()

Delta = Val(Timer1.Tag)
Picture1.ScaleMode = 3
If Picture2.Top + Picture2.Height > 0 Then
    Picture2.Top = Picture2.Top - Delta
Else
    Picture1.Cls
    Timer1.Enabled = 0
    Picture2.Visible = 0
    Picture2.AutoRedraw = -1
    Picture2.Top = Picture1.ScaleHeight
    Picture2.BackColor = Picture1.BackColor
    Picture2.Height = 16 * Picture1.TextHeight("A")
    Picture2.CurrentY = 0
    
    PrintCenter Picture2, "Photo Album ver. " & App.Major & "." & App.Minor & "." & App.Revision
    PrintCenter Picture2, ""
    PrintCenter Picture2, ""
    PrintCenter Picture2, "Software designed by:"
    PrintCenter Picture2, ""
    PrintCenter Picture2, "TOTARO Salvatore"
    PrintCenter Picture2, "aka"
    PrintCenter Picture2, "PaperQuack"
    PrintCenter Picture2, ""
    PrintCenter Picture2, ""
    PrintCenter Picture2, "For bugs, info or reports please"
    PrintCenter Picture2, "eMail us to: paperquak@libero.it"
    PrintCenter Picture2, ""
    PrintCenter Picture2, ""
    PrintCenter Picture2, "This program is FREEWARE!"
    PrintCenter Picture2, "You can distriduited it as is."
    
    Picture2.Visible = -1
    Timer1.Enabled = -1
End If

End Sub

