VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "shdocvw.dll"
Begin VB.Form frmPrintPreview 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Print Preview"
   ClientHeight    =   7695
   ClientLeft      =   2910
   ClientTop       =   2475
   ClientWidth     =   9855
   Icon            =   "frmPrintPreview.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7695
   ScaleWidth      =   9855
   Begin VB.Frame fmePrintPreview 
      Height          =   675
      Left            =   60
      TabIndex        =   1
      Top             =   0
      Width           =   9735
      Begin VB.CommandButton cmdClose 
         Caption         =   "Close"
         Height          =   315
         Left            =   1740
         TabIndex        =   3
         Top             =   240
         Width           =   1515
      End
      Begin VB.CommandButton cmdPrint 
         Caption         =   "Print"
         Height          =   315
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   1515
      End
   End
   Begin SHDocVwCtl.WebBrowser wbrPrintPreview 
      Height          =   6855
      Left            =   60
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   720
      Width           =   9735
      ExtentX         =   17171
      ExtentY         =   12091
      ViewMode        =   0
      Offline         =   0
      Silent          =   0
      RegisterAsBrowser=   0
      RegisterAsDropTarget=   1
      AutoArrange     =   0   'False
      NoClientEdge    =   0   'False
      AlignLeft       =   0   'False
      NoWebView       =   0   'False
      HideFileNames   =   0   'False
      SingleClick     =   0   'False
      SingleSelection =   0   'False
      NoFolders       =   0   'False
      Transparent     =   0   'False
      ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
      Location        =   ""
   End
End
Attribute VB_Name = "frmPrintPreview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdClose_Click()

Unload Me

End Sub

Private Sub cmdPrint_Click()

wbrPrintPreview.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_PROMPTUSER

End Sub

Private Sub Form_Load()

Center Me

wbrPrintPreview.Navigate App.Path & "\tmpprt.dat"

End Sub
