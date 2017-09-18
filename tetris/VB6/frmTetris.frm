VERSION 5.00
Begin VB.Form frmTetris 
   AutoRedraw      =   -1  'True
   BorderStyle     =   0  'None
   Caption         =   "Tetris"
   ClientHeight    =   4590
   ClientLeft      =   3450
   ClientTop       =   2070
   ClientWidth     =   4065
   Icon            =   "frmTetris.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   306
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   271
   Begin VB.PictureBox Picture1 
      Height          =   1695
      Left            =   2820
      ScaleHeight     =   1635
      ScaleWidth      =   1155
      TabIndex        =   9
      Top             =   2880
      Width           =   1215
      Begin VB.Label lblRecN 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "P1"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   285
         Index           =   0
         Left            =   0
         TabIndex        =   15
         Top             =   0
         Width           =   1155
      End
      Begin VB.Label lblRecP 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   285
         Index           =   0
         Left            =   0
         TabIndex        =   14
         Top             =   270
         Width           =   1155
      End
      Begin VB.Label lblRecN 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "P1"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   285
         Index           =   1
         Left            =   0
         TabIndex        =   13
         Top             =   540
         Width           =   1155
      End
      Begin VB.Label lblRecP 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   285
         Index           =   1
         Left            =   0
         TabIndex        =   12
         Top             =   810
         Width           =   1155
      End
      Begin VB.Label lblRecN 
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "P1"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   285
         Index           =   2
         Left            =   0
         TabIndex        =   11
         Top             =   1080
         Width           =   1155
      End
      Begin VB.Label lblRecP 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BackColor       =   &H00FFFFFF&
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Courier"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   285
         Index           =   2
         Left            =   0
         TabIndex        =   10
         Top             =   1350
         Width           =   1155
      End
   End
   Begin VB.PictureBox pctGriglia 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00808080&
      Height          =   4560
      Left            =   0
      MousePointer    =   99  'Custom
      ScaleHeight     =   300
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   180
      TabIndex        =   1
      Top             =   30
      Width           =   2760
      Begin VB.Timer tmrGioco 
         Enabled         =   0   'False
         Interval        =   300
         Left            =   0
         Top             =   4080
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   20
         Left            =   0
         Picture         =   "frmTetris.frx":030A
         Top             =   2700
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   9
         Left            =   300
         Picture         =   "frmTetris.frx":08DC
         Top             =   600
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   15
         Left            =   300
         Picture         =   "frmTetris.frx":0EAE
         Top             =   2400
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   11
         Left            =   300
         Picture         =   "frmTetris.frx":1480
         Top             =   1200
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   13
         Left            =   300
         Picture         =   "frmTetris.frx":1A52
         Top             =   1800
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   12
         Left            =   300
         Picture         =   "frmTetris.frx":2024
         Top             =   1500
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   14
         Left            =   300
         Picture         =   "frmTetris.frx":25F6
         Top             =   2100
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   10
         Left            =   300
         Picture         =   "frmTetris.frx":2BC8
         Top             =   900
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   8
         Left            =   300
         Picture         =   "frmTetris.frx":319A
         Top             =   300
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   7
         Left            =   0
         Picture         =   "frmTetris.frx":376C
         Top             =   2400
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   6
         Left            =   0
         Picture         =   "frmTetris.frx":3D3E
         Top             =   2100
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   5
         Left            =   0
         Picture         =   "frmTetris.frx":4310
         Top             =   1800
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   4
         Left            =   0
         Picture         =   "frmTetris.frx":48E2
         Top             =   1500
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   3
         Left            =   0
         Picture         =   "frmTetris.frx":4EB4
         Top             =   1200
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   2
         Left            =   0
         Picture         =   "frmTetris.frx":5486
         Top             =   900
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   1
         Left            =   0
         Picture         =   "frmTetris.frx":5A58
         Top             =   600
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgSfondo 
         Height          =   300
         Index           =   0
         Left            =   0
         Picture         =   "frmTetris.frx":602A
         Top             =   300
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Label lblMsg 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "lblMsg"
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H008080FF&
         Height          =   372
         Index           =   1
         Left            =   926
         TabIndex        =   3
         Top             =   1610
         Visible         =   0   'False
         Width           =   1056
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   0
         Left            =   0
         Picture         =   "frmTetris.frx":65FC
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   10
         Left            =   2400
         Picture         =   "frmTetris.frx":6BCE
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   6
         Left            =   1800
         Picture         =   "frmTetris.frx":71A0
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   2
         Left            =   600
         Picture         =   "frmTetris.frx":7772
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   5
         Left            =   1500
         Picture         =   "frmTetris.frx":7D44
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   7
         Left            =   2100
         Picture         =   "frmTetris.frx":8316
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   4
         Left            =   1200
         Picture         =   "frmTetris.frx":88E8
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   1
         Left            =   300
         Picture         =   "frmTetris.frx":8EBA
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Image imgBlock 
         Height          =   300
         Index           =   3
         Left            =   900
         Picture         =   "frmTetris.frx":948C
         Top             =   0
         Visible         =   0   'False
         Width           =   300
      End
      Begin VB.Label lblMsg 
         Alignment       =   2  'Center
         BackColor       =   &H00404080&
         Caption         =   "lblMsg"
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   372
         Index           =   0
         Left            =   936
         TabIndex        =   4
         Top             =   1620
         Visible         =   0   'False
         Width           =   1056
      End
   End
   Begin VB.PictureBox pctPreView 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00C0C0C0&
      BorderStyle     =   0  'None
      Height          =   1200
      Left            =   2820
      ScaleHeight     =   80
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   80
      TabIndex        =   2
      Top             =   0
      Width           =   1200
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Punteggi migliori"
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   465
      Index           =   2
      Left            =   2940
      TabIndex        =   16
      Top             =   2430
      Width           =   1020
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Linee"
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Index           =   1
      Left            =   2880
      TabIndex        =   8
      Top             =   1560
      Width           =   735
   End
   Begin VB.Label lblLinee 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Left            =   3870
      TabIndex        =   7
      Top             =   1560
      Width           =   120
   End
   Begin VB.Label lblLivello 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Left            =   3720
      TabIndex        =   6
      Top             =   1290
      Width           =   150
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "LIV."
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   195
      Index           =   0
      Left            =   3000
      TabIndex        =   5
      Top             =   1290
      Width           =   495
   End
   Begin VB.Label lblPunti 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFFFFF&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2820
      TabIndex        =   0
      Top             =   1830
      Width           =   1200
   End
   Begin VB.Menu mnuParita 
      Caption         =   "&Partita"
      Begin VB.Menu mnuNuova 
         Caption         =   "&Nuova"
         Shortcut        =   {F2}
      End
      Begin VB.Menu mnuPausa 
         Caption         =   "Interrompi/&Riprendi"
         Shortcut        =   {F3}
      End
      Begin VB.Menu mnuL1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEsci 
         Caption         =   "&Esci"
      End
   End
   Begin VB.Menu mnuOpzioni 
      Caption         =   "&Opzioni"
      Begin VB.Menu mnuLivello 
         Caption         =   "&Livello"
         Begin VB.Menu mnuL 
            Caption         =   "&1"
            Index           =   1
         End
         Begin VB.Menu mnuL 
            Caption         =   "&2"
            Index           =   2
         End
         Begin VB.Menu mnuL 
            Caption         =   "&3"
            Index           =   3
         End
         Begin VB.Menu mnuL 
            Caption         =   "&4"
            Index           =   4
         End
         Begin VB.Menu mnuL 
            Caption         =   "&5"
            Checked         =   -1  'True
            Index           =   5
         End
         Begin VB.Menu mnuL 
            Caption         =   "&6"
            Index           =   6
         End
         Begin VB.Menu mnuL 
            Caption         =   "&7"
            Index           =   7
         End
         Begin VB.Menu mnuL 
            Caption         =   "&8"
            Index           =   8
         End
         Begin VB.Menu mnuL 
            Caption         =   "&9"
            Index           =   9
         End
      End
      Begin VB.Menu mnuDifficolta 
         Caption         =   "&Difficoltà"
         Begin VB.Menu mnuD 
            Caption         =   "&0"
            Checked         =   -1  'True
            Index           =   0
         End
         Begin VB.Menu mnuD 
            Caption         =   "&1"
            Index           =   1
         End
         Begin VB.Menu mnuD 
            Caption         =   "&2"
            Index           =   2
         End
         Begin VB.Menu mnuD 
            Caption         =   "&3"
            Index           =   3
         End
         Begin VB.Menu mnuD 
            Caption         =   "&4"
            Index           =   4
         End
         Begin VB.Menu mnuD 
            Caption         =   "&5"
            Index           =   5
         End
      End
      Begin VB.Menu mnuL2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuPreview 
         Caption         =   "&Mostra/Nascondi anteprima"
         Checked         =   -1  'True
         Shortcut        =   ^P
      End
      Begin VB.Menu mnuSfondi 
         Caption         =   "&Visualizza sfondi"
         Checked         =   -1  'True
      End
   End
   Begin VB.Menu mnuAiuto 
      Caption         =   "&?"
      Begin VB.Menu mnuTasti 
         Caption         =   "&Tasti"
      End
      Begin VB.Menu mnuPunteggi 
         Caption         =   "&Punteggi"
      End
      Begin VB.Menu mnuL3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "&Informazioni su ..."
      End
   End
End
Attribute VB_Name = "frmTetris"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Long, ByVal dwFlags As Long) As Long
Private Const SND_ASYNC = &H1
Private Const SND_NOSTOP = &H2000 '&H10
Private Const SND_NOWAIT = &H2000

Const SND_RUOTA As Integer = 1
Const SND_SPOSTA As Integer = 2
Const SND_DROP As Integer = 3
Const SND_TETRIS As Integer = 4
Const SND_FINE As Integer = 5
Const SND_RIGA As Integer = 6

Private Blocco As tyBlocco

Const CDx As Integer = 1
Const CSx As Integer = -1
Const CDw As Integer = 2
Const CRd As Integer = 3
Const CRs As Integer = 4

Const iRow As Integer = 15
Const iCol As Integer = 9

Public iPxlLato As Integer

Private iGriglia(1 To iCol, 1 To iRow) As Integer

Const CVuoto   As Integer = 0
Const CVerde   As Integer = 1
Const CBlu     As Integer = 2
Const CRosso   As Integer = 3
Const CRosa    As Integer = 4
Const CGiallo  As Integer = 5
Const CArancio As Integer = 6
Const CViola   As Integer = 7
Const CGrigio  As Integer = 10

Const CBLs   As Integer = 1
Const CBLd   As Integer = 2
Const CBSs   As Integer = 3
Const CBSd   As Integer = 4
Const CBT    As Integer = 5
Const CBI    As Integer = 6
Const CBQ    As Integer = 7

Private i As Integer
Private j As Integer

Private Type tyQuadro
    X As Integer
    Y As Integer
  End Type

Private Type tyBlocco
    Q1 As tyQuadro
    Q2 As tyQuadro
    Q3 As tyQuadro
    Q4 As tyQuadro
    qdRot As tyQuadro ' punto di rotazione
    iTipo As Integer  ' iTipo di blocco
    iClr  As Integer  ' colore
  End Type

Const CVelBase    As Integer = 1200
Const CVelBoost   As Integer = 30
Public iVelocita As Integer
   
Public iPuntiBoost As Integer

Public iLivello As Integer

Const CNBlocchi As Integer = 7

Private iBlocchi(1 To CNBlocchi) As tyBlocco

Const sMsgPausa    As String = "Premi F3 per continuare"
Const sMsgFine     As String = "GAME OVER"
Const sMsgInizio   As String = "Premi F2 per iniziare"
Const sMsgs As String = " "

Private bPausa As Boolean

Private Sub Form_Load()
Me.Left = (Screen.Width - Me.Width) / 2
Me.Top = (Screen.Height - Me.Height) / 2
Me.Width = 4155
Me.Height = 5250

Randomize (Timer)
iPxlLato = imgBlock(0).Height
pctGriglia.ScaleWidth = iPxlLato * iCol
pctGriglia.ScaleHeight = iPxlLato * iRow
Me.ScaleHeight = pctGriglia.Height
pctPreView.Width = iPxlLato * 4
pctPreView.Height = iPxlLato * 4
lblMsg(0).Left = iPxlLato * 2: lblMsg(1).Left = iPxlLato * 2 - 1
lblMsg(0).Top = iPxlLato * Int(iRow / 2 - 1): lblMsg(1).Top = iPxlLato * Int(iRow / 2 - 1) - 1
lblMsg(0).Width = iPxlLato * (iCol - 4): lblMsg(1).Width = iPxlLato * (iCol - 4)
lblMsg(0).Height = iPxlLato * 2: lblMsg(1).Height = iPxlLato * 2
InizializzaGriglia
InizializzaBlocchi
VisualizzaRecord
Messaggio (sMsgInizio)
ImpostaLivello (5)
End Sub

Private Sub InizializzaBlocchi()
    InizializzaBlocco CBLd, 4, 1, 5, 1, 6, 1, 4, 2, 5, 1, CGiallo
    InizializzaBlocco CBLs, 4, 1, 5, 1, 6, 1, 6, 2, 5, 1, CViola
    InizializzaBlocco CBSd, 5, 1, 6, 1, 4, 2, 5, 2, 5, 1, CBlu
    InizializzaBlocco CBSs, 4, 1, 5, 1, 5, 2, 6, 2, 5, 1, CArancio
     InizializzaBlocco CBT, 4, 1, 5, 1, 6, 1, 5, 2, 5, 1, CVerde
     InizializzaBlocco CBI, 3, 1, 4, 1, 5, 1, 6, 1, 5, 1, CRosso
     InizializzaBlocco CBQ, 4, 1, 5, 1, 4, 2, 5, 2, 0, 0, CRosa
End Sub

Private Sub IniziaPartita()
mnuNuova.Enabled = False
InizializzaGriglia
ImpostaVelocita
ImpostaDifficolta (getChkIndex(mnuD))
AggiornaGriglia (True)
NuovoBlocco
Call DisegnaBlocco(Blocco, True)
tmrGioco.Interval = iVelocita
lblPunti = 0
lblLinee = 0
VisualizzaRecord
HideMsg
End Sub

Private Function getChkIndex(ByRef Mnu As Variant) As Integer
Dim mnuTmp As Menu
For Each mnuTmp In Mnu
      If mnuTmp.Checked Then getChkIndex = mnuTmp.Index
    Next mnuTmp
End Function

Private Sub ImpostaVelocita()
iVelocita = Int(CVelBase / iLivello)
tmrGioco.Interval = iVelocita
End Sub

Private Sub InizializzaBlocco(iBlk As Integer, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, x3 As Integer, y3 As Integer, x4 As Integer, y4 As Integer, Rx As Integer, Ry As Integer, iColor As Integer)
iBlocchi(iBlk).Q1.X = x1
iBlocchi(iBlk).Q1.Y = y1
iBlocchi(iBlk).Q2.X = x2
iBlocchi(iBlk).Q2.Y = y2
iBlocchi(iBlk).Q3.X = x3
iBlocchi(iBlk).Q3.Y = y3
iBlocchi(iBlk).Q4.X = x4
iBlocchi(iBlk).Q4.Y = y4
iBlocchi(iBlk).iClr = iColor
iBlocchi(iBlk).qdRot.X = Rx
iBlocchi(iBlk).qdRot.Y = Ry
iBlocchi(iBlk).iTipo = iBlk
End Sub

Private Sub InizializzaGriglia()
For i = 1 To iRow
    For j = 1 To iCol
        iGriglia(j, i) = CVuoto
        DisegnaQuadro pctGriglia, j, i, CVuoto
        Next j
    Next i
End Sub

Private Sub AggiornaGriglia(Optional bNuova)
Static grdPrec(1 To iCol, 1 To iRow) As Integer

If Not IsMissing(bNuova) Then
   For i = 1 To iRow
        For j = 1 To iCol
               grdPrec(j, i) = CVuoto
            Next j
        Next i
    End If
    
For i = 1 To iRow
    For j = 1 To iCol
        If grdPrec(j, i) <> iGriglia(j, i) Then
                                          DisegnaQuadro pctGriglia, j, i, iGriglia(j, i)
                                          grdPrec(j, i) = iGriglia(j, i)
                                      End If
        Next j
    Next i
End Sub

Private Sub AggiornaSfondo()
For i = 1 To iRow
    For j = 1 To iCol
        If iGriglia(j, i) = CVuoto Then DisegnaQuadro pctGriglia, j, i, iGriglia(j, i)
        Next j
    Next i
End Sub

Private Sub DisegnaQuadro(pct As PictureBox, X As Integer, Y As Integer, iClr As Integer)
pct.PaintPicture imgBlock(iClr).Picture, (X - 1) * iPxlLato, (Y - 1) * iPxlLato, iPxlLato, iPxlLato
End Sub

Public Function Rand(i As Integer) As Integer
Rand = Int(Rnd * i) + 1
End Function

Private Sub DisegnaBlocco(blk As tyBlocco, bNuovo As Boolean)
Static prec As tyBlocco

If Not bNuovo Then 'nuovo blocco
    iGriglia(prec.Q1.X, prec.Q1.Y) = CVuoto 'cancella la posizione precedente
    iGriglia(prec.Q2.X, prec.Q2.Y) = CVuoto
    iGriglia(prec.Q3.X, prec.Q3.Y) = CVuoto
    iGriglia(prec.Q4.X, prec.Q4.Y) = CVuoto
  End If

iGriglia(blk.Q1.X, blk.Q1.Y) = blk.iClr 'disegna nella nuova posizione
iGriglia(blk.Q2.X, blk.Q2.Y) = blk.iClr
iGriglia(blk.Q3.X, blk.Q3.Y) = blk.iClr
iGriglia(blk.Q4.X, blk.Q4.Y) = blk.iClr

prec = blk
AggiornaGriglia
End Sub

Private Sub RuotaQuadro(ByRef Q As tyQuadro, ByRef R As tyQuadro, ByVal iDir As Integer)
Dim iTmpQX As Integer
Dim iTmpQY As Integer

If iDir = CRd Then iDir = CDx
If iDir = CRs Then iDir = CSx

iTmpQX = iDir * (Q.Y - R.Y) + R.X
iTmpQY = -iDir * (Q.X - R.X) + R.Y

Q.X = iTmpQX
Q.Y = iTmpQY
End Sub

Private Function MovimentoBlocco(ByRef blk As tyBlocco, iDir As Integer) As Boolean
Dim blkUndo As tyBlocco

blkUndo = blk
Select Case iDir
  Case CDx, CSx: blk.Q1.X = blk.Q1.X + iDir
                 blk.Q2.X = blk.Q2.X + iDir
                 blk.Q3.X = blk.Q3.X + iDir
                 blk.Q4.X = blk.Q4.X + iDir
                 blk.qdRot.X = blk.qdRot.X + iDir
       Case CDw: blk.Q1.Y = blk.Q1.Y + 1
                 blk.Q2.Y = blk.Q2.Y + 1
                 blk.Q3.Y = blk.Q3.Y + 1
                 blk.Q4.Y = blk.Q4.Y + 1
                 blk.qdRot.Y = blk.qdRot.Y + 1
  Case CRd, CRs:
                 If blk.iTipo <> CBQ Then
                    RuotaQuadro blk.Q1, blk.qdRot, iDir
                    RuotaQuadro blk.Q2, blk.qdRot, iDir
                    RuotaQuadro blk.Q3, blk.qdRot, iDir
                    RuotaQuadro blk.Q4, blk.qdRot, iDir
                 End If
       End Select

MovimentoBlocco = ControllaStatoQuadro(blk.Q1, blkUndo) And _
                  ControllaStatoQuadro(blk.Q2, blkUndo) And _
                  ControllaStatoQuadro(blk.Q3, blkUndo) And _
                  ControllaStatoQuadro(blk.Q4, blkUndo)
              
If Not MovimentoBlocco Then
    blk = blkUndo
   Else
    DisegnaBlocco Blocco, False
   End If

End Function

Private Function ControllaStatoQuadro(ByRef Q As tyQuadro, ByRef blkOld As tyBlocco) As Boolean
ControllaStatoQuadro = True
If Q.Y > iRow Or Q.Y < 1 Or _
   Q.X > iCol Or Q.X < 1 Then
                             ControllaStatoQuadro = False
                             Exit Function
                         End If

If (Q.X = blkOld.Q1.X And Q.Y = blkOld.Q1.Y) Or _
   (Q.X = blkOld.Q2.X And Q.Y = blkOld.Q2.Y) Or _
   (Q.X = blkOld.Q3.X And Q.Y = blkOld.Q3.Y) Or _
   (Q.X = blkOld.Q4.X And Q.Y = blkOld.Q4.Y) Then Exit Function
   
If iGriglia(Q.X, Q.Y) <> CVuoto Then ControllaStatoQuadro = False
End Function

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If bPausa Then Exit Sub
Select Case KeyCode
   Case vbKeyRight: MovimentoBlocco Blocco, CDx
                    Suono (SND_SPOSTA)
   Case vbKeyLeft: MovimentoBlocco Blocco, CSx
                    Suono (SND_SPOSTA)
   Case vbKeySpace: MovimentoBlocco Blocco, CRd
                    Suono SND_RUOTA
   Case vbKeyShift: MovimentoBlocco Blocco, CRs
                    Suono SND_RUOTA
   Case vbKeyDown: tmrGioco.Interval = CVelBoost
   End Select
End Sub

Private Sub Form_KeyUp(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyDown Then tmrGioco.Interval = iVelocita
iPuntiBoost = 0
End Sub

Private Sub Form_Resize()
If Me.WindowState = vbMinimized Then Call Pausa(True)
End Sub

Private Sub Form_Unload(Cancel As Integer)
End
End Sub

Private Sub mnuAbout_Click()
MsgBox " Creato da:" & vbTab & "Enrico Melani" & Chr(13) & _
       " Versione:" & vbTab & vbTab & "2.0" & Chr(13) & _
       " Ultima modifica:" & vbTab & "07/04/1999" & Chr(13) & _
       " e-mail:" & vbTab & vbTab & "e.melani@infogroup.it" & Chr(13)
End Sub

Private Sub mnuD_Click(Index As Integer)
Dim mnuTmp As Menu
For Each mnuTmp In mnuD
     mnuTmp.Checked = (mnuD(Index).Index = mnuTmp.Index)
    Next
End Sub

Private Sub mnuEsci_Click()
End
End Sub

Private Sub mnuL_Click(Index As Integer)
Dim mnuTmp As Menu
For Each mnuTmp In mnuL
     mnuTmp.Checked = (mnuL(Index).Index = mnuTmp.Index)
    Next
ImpostaLivello (Index)
End Sub

Private Sub mnuNuova_Click()
Call IniziaPartita
End Sub

Private Sub mnuPausa_Click()
Static bFlag As Boolean
bFlag = Not bFlag
Call Pausa(bFlag)
End Sub

Private Sub mnuPreview_Click()
pctPreView.Cls
mnuPreview.Checked = Not mnuPreview.Checked
End Sub

Private Sub mnuSfondi_Click()
mnuSfondi.Checked = Not mnuSfondi.Checked
If Not mnuSfondi.Checked Then
   imgBlock(0).Picture = imgBlock(20).Picture
   Else
   imgBlock(0).Picture = imgSfondo(iLivello)
   End If
AggiornaSfondo
End Sub

Private Sub mnuTasti_Click()
MsgBox "[Spazio]" & vbTab & vbTab & "Rotazione sinistra" & Chr(13) & _
       "[Shift]" & vbTab & vbTab & "Rotazione destra" & Chr(13) & _
       "Freccia giù" & vbTab & "Accelera" & Chr(13) & _
       "Frecce [<]  [>]" & vbTab & "Blocco sinistra/destra" & Chr(13) & _
       "[F2]" & vbTab & vbTab & "Inizia partita" & Chr(13) & _
       "[F3]" & vbTab & vbTab & "Pausa / riprendi" & Chr(13), , "Tasti Tetris"
End Sub

Private Sub pctGriglia_LostFocus()
Call Pausa(True)
End Sub

Private Sub tmrGioco_Timer()
If Not (MovimentoBlocco(Blocco, CDw)) Then
         DropGriglia
         Suono SND_DROP
         lblPunti = lblPunti + iPuntiBoost
         iPuntiBoost = 0
         If Not NuovoBlocco Then
                  Suono SND_FINE
                  Messaggio (sMsgFine)
                  ControllaRecord
                  mnuNuova.Enabled = True
                Else
                 'Beep
                End If
       End If
If tmrGioco.Interval = CVelBoost Then iPuntiBoost = iPuntiBoost + iLivello
End Sub

Public Sub Pausa(bStato As Boolean)
tmrGioco.Enabled = bStato
bPausa = bStato
If bStato Then
     Messaggio (sMsgPausa)
   Else
     HideMsg
   End If
End Sub

Private Function NuovoBlocco() As Boolean
Static blkPreview As tyBlocco

Blocco = blkPreview
blkPreview = iBlocchi(Rand(CNBlocchi))
If Blocco.iTipo = 0 Then Blocco = blkPreview
Anteprima blkPreview

NuovoBlocco = iGriglia(Blocco.Q1.X, Blocco.Q1.Y) = CVuoto And _
              iGriglia(Blocco.Q2.X, Blocco.Q4.Y) = CVuoto And _
              iGriglia(Blocco.Q3.X, Blocco.Q3.Y) = CVuoto And _
              iGriglia(Blocco.Q4.X, Blocco.Q2.Y) = CVuoto

DisegnaBlocco Blocco, True
End Function

Public Sub DropGriglia()
Dim h As Integer
Dim k As Integer
Dim nDropLine As Integer

Dim bLine As Boolean
On Error Resume Next
nDropLine = 0
For i = 1 To iRow
    bLine = True
    For j = 1 To iCol
        bLine = bLine And (iGriglia(j, i) <> CVuoto)
        Next j
        If bLine Then
            nDropLine = nDropLine + 1
            For h = i To 1 Step -1
               For k = 1 To iCol
                   If h > 1 Then
                      iGriglia(k, h) = iGriglia(k, h - 1)
                      Else
                      iGriglia(k, h) = CVuoto
                      End If
               Next k
             Next h
             i = i - 1
           End If
    Next i
Select Case nDropLine
   Case 1: lblPunti = lblPunti + 10 * iLivello
            Suono SND_RIGA
   Case 2: lblPunti = lblPunti + 50 * iLivello
            Suono SND_RIGA
   Case 3: lblPunti = lblPunti + 200 * iLivello
            Suono SND_RIGA
   Case 4: lblPunti = lblPunti + 500 * iLivello
            Suono SND_TETRIS
   End Select
lblLinee = lblLinee + nDropLine
If lblLinee >= (8 * iLivello) Then ImpostaLivello (iLivello + 1)
End Sub

Private Sub Delay(ByVal lMSec As Long)
Dim s1 As Single
tmrGioco.Enabled = False
s1 = Timer
While s1 > Timer - lMSec / 1000
Wend
tmrGioco.Enabled = True
End Sub

Private Sub ImpostaDifficolta(iDiff As Integer)
Dim iRnd As Integer
For i = 0 To iDiff - 1
    For j = 1 To iCol
        iRnd = Rand(10)
        If iRnd > 6 Then iGriglia(j, iRow - i) = CGrigio
    Next j
  Next i
End Sub

Private Sub Messaggio(ByRef sMsg As String)
tmrGioco.Enabled = False
lblMsg(0) = sMsg
lblMsg(1) = sMsg
lblMsg(0).Visible = True
lblMsg(1).Visible = True
End Sub

Private Sub HideMsg()
lblMsg(0).Visible = False
lblMsg(1).Visible = False
tmrGioco.Enabled = True
End Sub

Private Sub ImpostaLivello(iLiv As Integer)
iLivello = iLiv
lblLivello = iLiv
ImpostaVelocita
If mnuSfondi.Checked Then
   imgBlock(0).Picture = imgSfondo(iLiv)
   AggiornaSfondo
   End If
End Sub

Private Sub Anteprima(blk As tyBlocco)
If Not mnuPreview.Checked Then Exit Sub
pctPreView.Cls
DisegnaQuadro pctPreView, blk.Q1.X - 2, blk.Q1.Y, blk.iClr
DisegnaQuadro pctPreView, blk.Q2.X - 2, blk.Q2.Y, blk.iClr
DisegnaQuadro pctPreView, blk.Q3.X - 2, blk.Q3.Y, blk.iClr
DisegnaQuadro pctPreView, blk.Q4.X - 2, blk.Q4.Y, blk.iClr
End Sub

Private Sub VisualizzaRecord()
lblRecN(0) = GetSetting("Tetris", "Record", "Nome1", "Player1")
lblRecP(0) = GetSetting("Tetris", "Record", "Punti1", 0)
lblRecN(1) = GetSetting("Tetris", "Record", "Nome2", "Player2")
lblRecP(1) = GetSetting("Tetris", "Record", "Punti2", 0)
lblRecN(2) = GetSetting("Tetris", "Record", "Nome3", "Player3")
lblRecP(2) = GetSetting("Tetris", "Record", "Punti3", 0)
End Sub

Private Sub SalvaRecord()
SaveSetting "Tetris", "Record", "Nome1", lblRecN(0)
SaveSetting "Tetris", "Record", "Punti1", lblRecP(0)
SaveSetting "Tetris", "Record", "Nome2", lblRecN(1)
SaveSetting "Tetris", "Record", "Punti2", lblRecP(1)
SaveSetting "Tetris", "Record", "Nome3", lblRecN(2)
SaveSetting "Tetris", "Record", "Punti3", lblRecP(2)
End Sub

Private Sub ControllaRecord()
Dim i As Integer
Dim j As Integer
For i = 0 To 2
    If CLng(lblPunti) > CLng(lblRecP(i)) Then
       For j = 2 To i + 1 Step -1
           lblRecP(j) = lblRecP(j - 1)
           lblRecN(j) = lblRecN(j - 1)
           Next j
       lblRecP(i) = lblPunti
       lblRecN(i) = ""
       lblRecN(i) = InputBox("Complimenti, hai ottenuto un nuovo record" & Chr(13) & "Scrivi il tuo nome (max. 10 car)")
       SalvaRecord
       Exit Sub
       End If
   Next i
End Sub

Private Sub mnuPunteggi_Click()
Dim sMsg As String
sMsg = "LIVELLO / LINEE" & vbTab & "1" & vbTab & "2" & vbTab & "3" & vbTab & "TETRIS" & Chr(13) & _
       "----------------------------------------------------------------------------------------------" & Chr(13)
       
For i = 1 To 16
    sMsg = sMsg & "Livello " & i & vbTab & vbTab & i * 10 & vbTab & i * 50 & vbTab & i * 200 & vbTab & i * 500 & Chr(13)
    Next
sMsg = sMsg & "----------------------------------------------------------------------------------------------" & Chr(13)
    
MsgBox sMsg, , "Punteggi Tetris"
End Sub

Private Sub Suono(iSnd As Integer)
Select Case iSnd
  Case SND_RUOTA: PlaySound App.Path & "\wav\tetris3.wav", &O0, SND_ASYNC + SND_NOSTOP
  Case SND_SPOSTA: PlaySound App.Path & "\wav\tetris6.wav", &O0, SND_ASYNC + SND_NOSTOP
  Case SND_DROP: PlaySound App.Path & "\wav\tetris4.wav", &O0, SND_ASYNC + SND_NOSTOP
  Case SND_TETRIS: PlaySound App.Path & "\wav\tetris7.wav", &O0, SND_ASYNC + SND_NOSTOP
  Case SND_RIGA: PlaySound App.Path & "\wav\tetris5.wav", &O0, SND_ASYNC + SND_NOSTOP
  Case SND_FINE: PlaySound App.Path & "\wav\tetris8.wav", &O0, SND_ASYNC + SND_NOSTOP
 End Select
End Sub
