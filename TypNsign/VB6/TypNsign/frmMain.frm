VERSION 5.00
Begin VB.Form MainFrm 
   AutoRedraw      =   -1  'True
   BorderStyle     =   0  'None
   Caption         =   "Type-N-Sign"
   ClientHeight    =   7080
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   8700
   Icon            =   "frmMain.frx":0000
   LinkMode        =   1  'Source
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmMain.frx":08CA
   ScaleHeight     =   7080
   ScaleWidth      =   8700
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      BorderStyle     =   0  'None
      Height          =   2190
      Left            =   5520
      ScaleHeight     =   2190
      ScaleWidth      =   2625
      TabIndex        =   41
      Top             =   1440
      Width           =   2625
   End
   Begin VB.TextBox ConsoleTxt 
      Appearance      =   0  'Flat
      BackColor       =   &H00000000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   3060
      Left            =   840
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Text            =   "frmMain.frx":DC4AC
      Top             =   1440
      Width           =   4485
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   210
      Index           =   34
      Left            =   2085
      MouseIcon       =   "frmMain.frx":DC4C5
      MousePointer    =   99  'Custom
      TabIndex        =   42
      Top             =   6375
      Width           =   3825
   End
   Begin VB.Label StartBtn 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Start"
      ForeColor       =   &H0000FFFF&
      Height          =   750
      Left            =   7320
      MouseIcon       =   "frmMain.frx":DC7CF
      MousePointer    =   99  'Custom
      TabIndex        =   40
      ToolTipText     =   "Starts and Stops the program."
      Top             =   3750
      Width           =   690
   End
   Begin VB.Label OptionsBtn 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Options"
      ForeColor       =   &H0000FFFF&
      Height          =   540
      Left            =   6435
      MouseIcon       =   "frmMain.frx":DCAD9
      MousePointer    =   99  'Custom
      TabIndex        =   39
      ToolTipText     =   "Control the way Typ-N-Sign runs."
      Top             =   3915
      Width           =   555
   End
   Begin VB.Label ResetBtn 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Reset"
      ForeColor       =   &H0000FFFF&
      Height          =   525
      Left            =   5685
      MouseIcon       =   "frmMain.frx":DCDE3
      MousePointer    =   99  'Custom
      TabIndex        =   38
      ToolTipText     =   "Resets the control panel"
      Top             =   3915
      Width           =   480
   End
   Begin VB.Label TitleBar 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   255
      Left            =   1140
      TabIndex        =   37
      Top             =   1170
      Width           =   6000
   End
   Begin VB.Label MinimizeBtn 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   270
      Left            =   7140
      TabIndex        =   36
      Top             =   1125
      Width           =   270
   End
   Begin VB.Label Exit 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   270
      Left            =   7485
      MouseIcon       =   "frmMain.frx":DD0ED
      MousePointer    =   99  'Custom
      TabIndex        =   35
      Top             =   1125
      Width           =   285
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Enter"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   33
      Left            =   6810
      MouseIcon       =   "frmMain.frx":DD3F7
      MousePointer    =   99  'Custom
      TabIndex        =   34
      Top             =   5445
      Width           =   945
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "/"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   32
      Left            =   6030
      MouseIcon       =   "frmMain.frx":DD701
      MousePointer    =   99  'Custom
      OLEDropMode     =   1  'Manual
      TabIndex        =   33
      Top             =   5940
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   31
      Left            =   5550
      MouseIcon       =   "frmMain.frx":DDA0B
      MousePointer    =   99  'Custom
      TabIndex        =   32
      Top             =   5955
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   ","
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   30
      Left            =   5025
      MouseIcon       =   "frmMain.frx":DDD15
      MousePointer    =   99  'Custom
      TabIndex        =   31
      Top             =   5940
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "'"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   29
      Left            =   6300
      MouseIcon       =   "frmMain.frx":DE01F
      MousePointer    =   99  'Custom
      TabIndex        =   30
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   ";"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   28
      Left            =   5760
      MouseIcon       =   "frmMain.frx":DE329
      MousePointer    =   99  'Custom
      TabIndex        =   29
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "]"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   27
      Left            =   6705
      MouseIcon       =   "frmMain.frx":DE633
      MousePointer    =   99  'Custom
      TabIndex        =   28
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "["
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   26
      Left            =   6150
      MouseIcon       =   "frmMain.frx":DE93D
      MousePointer    =   99  'Custom
      TabIndex        =   27
      Top             =   4995
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Z"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   25
      Left            =   1305
      MouseIcon       =   "frmMain.frx":DEC47
      MousePointer    =   99  'Custom
      TabIndex        =   26
      Top             =   5940
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Y"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   24
      Left            =   3570
      MouseIcon       =   "frmMain.frx":DEF51
      MousePointer    =   99  'Custom
      TabIndex        =   25
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "X"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   23
      Left            =   1875
      MouseIcon       =   "frmMain.frx":DF25B
      MousePointer    =   99  'Custom
      TabIndex        =   24
      Top             =   5940
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "W"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   22
      Left            =   1455
      MouseIcon       =   "frmMain.frx":DF565
      MousePointer    =   99  'Custom
      TabIndex        =   23
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "V"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   21
      Left            =   2925
      MouseIcon       =   "frmMain.frx":DF86F
      MousePointer    =   99  'Custom
      TabIndex        =   22
      Top             =   5955
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "U"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   20
      Left            =   4080
      MouseIcon       =   "frmMain.frx":DFB79
      MousePointer    =   99  'Custom
      TabIndex        =   21
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "T"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   19
      Left            =   3030
      MouseIcon       =   "frmMain.frx":DFE83
      MousePointer    =   99  'Custom
      TabIndex        =   20
      Top             =   4995
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "S"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   18
      Left            =   1620
      MouseIcon       =   "frmMain.frx":E018D
      MousePointer    =   99  'Custom
      TabIndex        =   19
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "R"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   17
      Left            =   2505
      MouseIcon       =   "frmMain.frx":E0497
      MousePointer    =   99  'Custom
      TabIndex        =   18
      Top             =   4995
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Q"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   16
      Left            =   885
      MouseIcon       =   "frmMain.frx":E07A1
      MousePointer    =   99  'Custom
      TabIndex        =   17
      Top             =   4995
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "P"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   15
      Left            =   5610
      MouseIcon       =   "frmMain.frx":E0AAB
      MousePointer    =   99  'Custom
      TabIndex        =   16
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "O"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   14
      Left            =   5130
      MouseIcon       =   "frmMain.frx":E0DB5
      MousePointer    =   99  'Custom
      TabIndex        =   15
      Top             =   4995
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "N"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   13
      Left            =   3975
      MouseIcon       =   "frmMain.frx":E10BF
      MousePointer    =   99  'Custom
      TabIndex        =   14
      Top             =   5955
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "M"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   12
      Left            =   4500
      MouseIcon       =   "frmMain.frx":E13C9
      MousePointer    =   99  'Custom
      TabIndex        =   13
      Top             =   5955
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "L"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   11
      Left            =   5250
      MouseIcon       =   "frmMain.frx":E16D3
      MousePointer    =   99  'Custom
      TabIndex        =   12
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "K"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   10
      Left            =   4725
      MouseIcon       =   "frmMain.frx":E19DD
      MousePointer    =   99  'Custom
      TabIndex        =   11
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "J"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   9
      Left            =   4245
      MouseIcon       =   "frmMain.frx":E1CE7
      MousePointer    =   99  'Custom
      TabIndex        =   10
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "I"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   8
      Left            =   4605
      MouseIcon       =   "frmMain.frx":E1FF1
      MousePointer    =   99  'Custom
      TabIndex        =   9
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "H"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   7
      Left            =   3705
      MouseIcon       =   "frmMain.frx":E22FB
      MousePointer    =   99  'Custom
      TabIndex        =   8
      Top             =   5460
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "G"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   6
      Left            =   3195
      MouseIcon       =   "frmMain.frx":E2605
      MousePointer    =   99  'Custom
      TabIndex        =   7
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "F"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   5
      Left            =   2655
      MouseIcon       =   "frmMain.frx":E290F
      MousePointer    =   99  'Custom
      TabIndex        =   6
      Top             =   5475
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "E"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   4
      Left            =   1980
      MouseIcon       =   "frmMain.frx":E2C19
      MousePointer    =   99  'Custom
      TabIndex        =   5
      Top             =   5010
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "D"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   3
      Left            =   2145
      MouseIcon       =   "frmMain.frx":E2F23
      MousePointer    =   99  'Custom
      TabIndex        =   4
      Top             =   5460
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "C"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   2
      Left            =   2400
      MouseIcon       =   "frmMain.frx":E322D
      MousePointer    =   99  'Custom
      TabIndex        =   3
      Top             =   5940
      Width           =   420
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "B"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   1
      Left            =   3405
      MouseIcon       =   "frmMain.frx":E3537
      MousePointer    =   99  'Custom
      TabIndex        =   2
      Top             =   5955
      Width           =   465
   End
   Begin VB.Label Key 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "A"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Index           =   0
      Left            =   1080
      MouseIcon       =   "frmMain.frx":E3841
      MousePointer    =   99  'Custom
      TabIndex        =   1
      Top             =   5460
      UseMnemonic     =   0   'False
      Width           =   420
   End
End
Attribute VB_Name = "MainFrm"
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
Dim Counter As Integer

Private Sub Form_Load()
'///////////////////////////////////
'// START UP PROGRAM
'//////////////////
On Error Resume Next

    Set shapeform = New clsTransForm
    
    Dim HotPurple As Long
    HotPurple& = RGB(255, 0, 255)
        
        '// Make us transparent :)
        shapeform.SetRegion Me, HotPurple&, App.Path & "\typensign.dat"
    
End Sub
Private Sub StartBtn_Click()
'//////////////////////////////////////////
'// START BUTTON
'//////////////
Dim Txt As String, LenTxt As Long
Dim Countr As Integer, Bffer As String

If STOPED = True Then
    
    STOPED = False
    StartBtn.Caption = "Stop"
    
    Txt$ = ConsoleTxt.Text
    LenTxt = Len(Txt$)
    
    '// Run through console for playback
    Countr = 1
    Do While Countr <= LenTxt
        
        Bffer = ""
        Bffer = Mid(Txt, Countr, 1)        '// Pick each letter out.
        Call ShowPict_Alpha(Bffer)         '// Display sign for it.
                            
            If Countr = LenTxt Then             '// At end of text.
                If LOOP_IT = 1 Then             '// Check for loop option.
                    Countr = 0
                ElseIf LOOP_IT = 0 Then         '// If loop not set,
                    StartBtn.Caption = "Start"  '// reset to Start button.
                    STOPED = True               '// and Stop program.
                    Exit Sub
                End If
            End If
            
        Countr = Countr + 1                 '// Advance counter.
        TimeOut ((HAND_SPEED * 0.05))       '// Pause between pictures.
        
        If STOPED = True Then Exit Sub
    Loop
    
Else '// Else we are pressing stop.
    
    StartBtn.Caption = "Start"
    STOPED = True

End If

End Sub
Private Sub TitleBar_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
'//////////////////////////////////////
'// FOR MOVING THE FORM AROUND
'//////////////////////////

    If Button = vbLeftButton Then
        Set shapeform = New clsTransForm
        shapeform.DragForm Me.hWnd, 1
    End If

End Sub
Private Sub OptionsBtn_Click()
'//////////////////////////////////////////
'// OPTIONS BUTTON
'///////////////

    MnuCntrol.PopupMenu MnuCntrol.MnuOptions, 0

End Sub
Private Sub ResetBtn_Click()
'/////////////////////////////////////
'// RESET MENU
'//////////////////

    MnuCntrol.PopupMenu MnuCntrol.MnuReset, 1
    
End Sub
Private Sub TimeOut(duration)
'////////////////////////////////////
'// TIMER
'//////////////////

    StartTime = Timer
    Do While Timer - StartTime < duration
    DoEvents
    Loop

End Sub
Public Sub Exit_Click()
'////////////////////////////////////
'// EXIT
'//////////////////
  
    STOPED = True
    
    Unload MnuCntrol
    Unload OptionsFrm
    Unload frmSplash
    
    Unload Me
   
End Sub
Private Sub ConsoleTxt_KeyPress(KeyAscii As Integer)
'//////////////////////////
'// MANUAL KEY PRESS
'////////

    Call ShowPict_Alpha(Chr(KeyAscii))

End Sub
Private Sub Key_Click(Index As Integer)
'/////////////////////////
'// MOUSE CLICK ON KEY
'/////////

    Call ShowPict_Num(Index)    '// Show picture
    Call StText(Index)          '// Display text
    
End Sub
'///////////////////////////////////////////////////////////////////////////////
'// KEYBOARD CONTROLS


Public Sub ShowPict_Num(Num As Integer)
'/////////////////////////
'// LETTER CONTROLS
'/////////
On Error GoTo DifKey
Dim lChr As Long

lChr = Num + 97 '// ASCII code for "a" is chr(97)
    Picture1 = LoadPicture(MODULE_PATH$ & Chr(lChr&) & ".jpg")
    Exit Sub
DifKey:

Picture1 = LoadPicture("")

End Sub
Private Sub ShowPict_Alpha(Alpha As String)
On Error GoTo DifKey

        Picture1 = LoadPicture(MODULE_PATH & Alpha & ".jpg")
        Exit Sub

DifKey:
Picture1 = LoadPicture("")

End Sub
Private Sub StText(Num As Integer)
Dim lChr As Long

If Num > 25 Then    '// Check for special char's first
    Select Case Num
        Case 26: ConsoleTxt.Text = ConsoleTxt.Text & "["
        Case 27: ConsoleTxt.Text = ConsoleTxt.Text & "]"
        Case 28: ConsoleTxt.Text = ConsoleTxt.Text & ";"
        Case 29: ConsoleTxt.Text = ConsoleTxt.Text & "'"
        Case 30: ConsoleTxt.Text = ConsoleTxt.Text & ","
        Case 31: ConsoleTxt.Text = ConsoleTxt.Text & "."
        Case 32: ConsoleTxt.Text = ConsoleTxt.Text & "/"
        Case 33: ConsoleTxt.Text = ConsoleTxt.Text & vbCrLf
        Case 34: ConsoleTxt.Text = ConsoleTxt.Text & " "
    End Select
End If

lChr = Num + 97 '// ASCII code for "a" is chr(97)

        ConsoleTxt.Text = ConsoleTxt.Text & Chr(lChr&)

End Sub
