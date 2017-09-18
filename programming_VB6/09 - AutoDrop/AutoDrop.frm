VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form Form1 
   Caption         =   "Automatic Drag And Drop Demo"
   ClientHeight    =   4890
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   10710
   LinkTopic       =   "Form1"
   ScaleHeight     =   4890
   ScaleWidth      =   10710
   StartUpPosition =   3  'Windows Default
   Begin VB.DirListBox Dir1 
      Height          =   765
      Left            =   7080
      TabIndex        =   11
      Top             =   2880
      Width           =   3495
   End
   Begin VB.FileListBox File1 
      Height          =   870
      Left            =   7080
      OLEDragMode     =   1  'Automatic
      Pattern         =   "*.txt;*.doc;*.rtf"
      TabIndex        =   10
      Top             =   3840
      Width           =   3495
   End
   Begin VB.ListBox List1 
      Height          =   1815
      Left            =   7080
      MultiSelect     =   2  'Extended
      OLEDragMode     =   1  'Automatic
      TabIndex        =   8
      Top             =   480
      Width           =   3495
   End
   Begin VB.PictureBox Picture1 
      Height          =   1815
      Left            =   120
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      Picture         =   "AutoDrop.frx":0000
      ScaleHeight     =   1755
      ScaleWidth      =   3195
      TabIndex        =   6
      Top             =   2880
      Width           =   3255
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   3600
      MultiLine       =   -1  'True
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      ScrollBars      =   2  'Vertical
      TabIndex        =   1
      Top             =   480
      Width           =   3255
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   1815
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   3255
      _ExtentX        =   5741
      _ExtentY        =   3201
      _Version        =   393217
      Enabled         =   -1  'True
      TextRTF         =   $"AutoDrop.frx":4B146
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "FileListBox (source for external progs)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   7080
      TabIndex        =   9
      Top             =   2520
      Width           =   3495
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Multiselect ListBox (source only)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   7080
      TabIndex        =   7
      Top             =   120
      Width           =   3495
   End
   Begin VB.Image Image1 
      BorderStyle     =   1  'Fixed Single
      Height          =   1815
      Left            =   3600
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      Stretch         =   -1  'True
      Top             =   2880
      Width           =   3255
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Image"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   3600
      TabIndex        =   5
      Top             =   2520
      Width           =   3255
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "PictureBox"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   4
      Top             =   2520
      Width           =   3255
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Multiline TextBox"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   3600
      TabIndex        =   3
      Top             =   120
      Width           =   3255
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "RichTextBox"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   3255
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Dir1_Click()
    File1.Path = Dir1.List(Dir1.ListIndex)
End Sub

Private Sub Form_Load()
    Dim i As Integer
    For i = 1 To 20
        List1.AddItem "Item #" & i
    Next
    
End Sub
