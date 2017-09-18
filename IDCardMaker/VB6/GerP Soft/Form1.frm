VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmshowfnt 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00C000C0&
   Caption         =   "GerP Soft"
   ClientHeight    =   9675
   ClientLeft      =   990
   ClientTop       =   630
   ClientWidth     =   16170
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9675
   ScaleWidth      =   16170
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture11 
      Height          =   1215
      Left            =   120
      Picture         =   "Form1.frx":0000
      ScaleHeight     =   1155
      ScaleWidth      =   8475
      TabIndex        =   81
      Top             =   7080
      Width           =   8535
      Begin VB.CommandButton Command5 
         Caption         =   "Delete text"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   6840
         TabIndex        =   85
         Top             =   240
         Width           =   1455
      End
      Begin VB.CommandButton Command6 
         Caption         =   "Fix text"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   6840
         TabIndex        =   84
         Top             =   600
         Width           =   1455
      End
      Begin VB.TextBox Text1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   1800
         Locked          =   -1  'True
         TabIndex        =   83
         Top             =   480
         Width           =   3735
      End
      Begin VB.Label Label8 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "ENTER HERE"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   3000
         TabIndex        =   82
         Top             =   240
         Width           =   1485
      End
   End
   Begin VB.PictureBox Picture10 
      Height          =   2790
      Left            =   12480
      Picture         =   "Form1.frx":256A
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   67
      Top             =   3480
      Width           =   3579
      Begin VB.HScrollBar HScroll5 
         Height          =   255
         Index           =   1
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   71
         Top             =   1680
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll5 
         Height          =   255
         Index           =   2
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   70
         Top             =   2040
         Width           =   2175
      End
      Begin VB.TextBox Text4 
         Height          =   375
         Left            =   360
         Locked          =   -1  'True
         TabIndex        =   69
         Top             =   840
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll5 
         Height          =   255
         Index           =   0
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   68
         Top             =   1320
         Width           =   2175
      End
      Begin VB.Label Label18 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Shadow Color"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   240
         TabIndex        =   75
         Top             =   240
         Width           =   1455
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   2640
         TabIndex        =   74
         Top             =   1680
         Width           =   495
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   2640
         TabIndex        =   73
         Top             =   2040
         Width           =   495
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H008080FF&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   2640
         TabIndex        =   72
         Top             =   1320
         Width           =   495
      End
   End
   Begin VB.PictureBox Picture9 
      Height          =   2790
      Left            =   12480
      Picture         =   "Form1.frx":4346
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   49
      Top             =   120
      Width           =   3579
      Begin VB.CheckBox Check1 
         BackColor       =   &H00800080&
         Caption         =   "Show 3D text"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   720
         TabIndex        =   86
         Top             =   2040
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll4 
         Height          =   300
         LargeChange     =   10
         Left            =   600
         Max             =   600
         Min             =   8
         TabIndex        =   63
         Top             =   1080
         Value           =   8
         Width           =   2295
      End
      Begin VB.CommandButton Command4 
         Height          =   405
         Index           =   0
         Left            =   600
         Style           =   1  'Graphical
         TabIndex        =   62
         ToolTipText     =   "Flat"
         Top             =   1440
         Width           =   405
      End
      Begin VB.CommandButton Command4 
         Height          =   405
         Index           =   6
         Left            =   2040
         Style           =   1  'Graphical
         TabIndex        =   61
         ToolTipText     =   "BottomShadow"
         Top             =   1440
         Width           =   405
      End
      Begin VB.CommandButton Command4 
         Height          =   405
         Index           =   5
         Left            =   2520
         Style           =   1  'Graphical
         TabIndex        =   60
         ToolTipText     =   "BottomShadow"
         Top             =   1440
         Width           =   405
      End
      Begin VB.CommandButton Command4 
         Height          =   405
         Index           =   2
         Left            =   1560
         Style           =   1  'Graphical
         TabIndex        =   59
         ToolTipText     =   "LeftShadow"
         Top             =   1440
         Width           =   405
      End
      Begin VB.CommandButton Command4 
         Height          =   405
         Index           =   1
         Left            =   1080
         Style           =   1  'Graphical
         TabIndex        =   58
         ToolTipText     =   "RightShadow"
         Top             =   1440
         Width           =   405
      End
      Begin VB.Label Label17 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "3D Settings"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   360
         TabIndex        =   66
         Top             =   240
         Width           =   1200
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Depth :"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   255
         Left            =   840
         TabIndex        =   65
         Top             =   720
         Width           =   735
      End
      Begin VB.Label Label5 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   255
         Left            =   1680
         TabIndex        =   64
         Top             =   720
         Width           =   855
      End
   End
   Begin VB.PictureBox Picture8 
      Height          =   2790
      Left            =   8760
      Picture         =   "Form1.frx":6122
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   48
      Top             =   3480
      Width           =   3579
      Begin VB.ComboBox list1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   720
         TabIndex        =   77
         Text            =   "Combo1"
         Top             =   2040
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll3 
         Height          =   375
         LargeChange     =   3
         Left            =   720
         Max             =   100
         Min             =   8
         TabIndex        =   76
         Top             =   1320
         Value           =   8
         Width           =   2175
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00800080&
         Caption         =   "Portriat"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1680
         TabIndex        =   56
         Top             =   600
         Width           =   1335
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H00800080&
         Caption         =   "Landscape"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1680
         TabIndex        =   55
         Top             =   360
         Width           =   1335
      End
      Begin VB.Line Line17 
         X1              =   240
         X2              =   3240
         Y1              =   1800
         Y2              =   1800
      End
      Begin VB.Line Line16 
         X1              =   240
         X2              =   3240
         Y1              =   960
         Y2              =   960
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackStyle       =   0  'Transparent
         Caption         =   "Label1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1440
         TabIndex        =   80
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label19 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Fonts"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   360
         TabIndex        =   79
         Top             =   1800
         Width           =   585
      End
      Begin VB.Label Label6 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Font Size"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   360
         TabIndex        =   78
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label16 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Orientation"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   360
         TabIndex        =   57
         Top             =   240
         Width           =   1140
      End
   End
   Begin VB.PictureBox Picture7 
      Height          =   2790
      Left            =   8760
      Picture         =   "Form1.frx":78C7
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   47
      Top             =   120
      Width           =   3579
      Begin VB.CommandButton Command12 
         Caption         =   "Clear Background "
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   360
         TabIndex        =   53
         Top             =   1320
         Width           =   2775
      End
      Begin VB.CommandButton Command10 
         Caption         =   "Load Background "
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   360
         TabIndex        =   52
         Top             =   960
         Width           =   2775
      End
      Begin VB.CommandButton Command11 
         Caption         =   "Print"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   360
         TabIndex        =   51
         Top             =   2040
         Width           =   2775
      End
      Begin VB.CommandButton Command13 
         Caption         =   "Hide Grid"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   360
         TabIndex        =   50
         Top             =   1680
         Width           =   2775
      End
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   3240
         Top             =   -120
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.Label Label15 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Function"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   240
         TabIndex        =   54
         Top             =   240
         Width           =   885
      End
   End
   Begin VB.PictureBox Picture6 
      Height          =   2790
      Left            =   8760
      Picture         =   "Form1.frx":96A3
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   37
      Top             =   6840
      Width           =   3579
      Begin VB.HScrollBar HScroll2 
         Height          =   255
         Index           =   0
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   42
         Top             =   1440
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll2 
         Height          =   255
         Index           =   1
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   41
         Top             =   1800
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll2 
         Height          =   255
         Index           =   2
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   40
         Top             =   2160
         Width           =   2175
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   360
         Locked          =   -1  'True
         TabIndex        =   38
         Top             =   960
         Width           =   2175
      End
      Begin VB.CommandButton Command8 
         Caption         =   "OK"
         Height          =   375
         Left            =   1680
         TabIndex        =   39
         Top             =   960
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label14 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Textcolor"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   240
         TabIndex        =   46
         Top             =   240
         Width           =   990
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H008080FF&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   2640
         TabIndex        =   45
         Top             =   1440
         Width           =   495
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   2640
         TabIndex        =   44
         Top             =   1800
         Width           =   495
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   2640
         TabIndex        =   43
         Top             =   2160
         Width           =   495
      End
   End
   Begin VB.PictureBox Picture5 
      BackColor       =   &H00FFFFFF&
      Height          =   2790
      Left            =   12480
      Picture         =   "Form1.frx":B47F
      ScaleHeight     =   2730
      ScaleWidth      =   3525
      TabIndex        =   27
      Top             =   6840
      Width           =   3579
      Begin VB.HScrollBar HScroll1 
         Height          =   255
         Index           =   1
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   31
         Top             =   1800
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll1 
         Height          =   255
         Index           =   2
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   30
         Top             =   2160
         Width           =   2175
      End
      Begin VB.HScrollBar HScroll1 
         Height          =   255
         Index           =   0
         LargeChange     =   5
         Left            =   360
         Max             =   255
         TabIndex        =   29
         Top             =   1440
         Width           =   2175
      End
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   360
         Locked          =   -1  'True
         TabIndex        =   28
         Top             =   960
         Width           =   2175
      End
      Begin VB.CommandButton Command7 
         Caption         =   "OK"
         Height          =   375
         Left            =   1200
         TabIndex        =   36
         Top             =   960
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label9 
         Appearance      =   0  'Flat
         AutoSize        =   -1  'True
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "Background Color"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   240
         Left            =   360
         TabIndex        =   35
         Top             =   240
         Width           =   1875
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0080FF80&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   2640
         TabIndex        =   34
         Top             =   1800
         Width           =   495
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   2640
         TabIndex        =   33
         Top             =   2160
         Width           =   495
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H008080FF&
         Caption         =   " "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   2640
         TabIndex        =   32
         Top             =   1440
         Width           =   495
      End
   End
   Begin VB.PictureBox Picture4 
      Appearance      =   0  'Flat
      BackColor       =   &H000000FF&
      ForeColor       =   &H80000008&
      Height          =   1215
      Left            =   120
      Picture         =   "Form1.frx":D25B
      ScaleHeight     =   1185
      ScaleWidth      =   8505
      TabIndex        =   25
      Top             =   8400
      Width           =   8535
      Begin VB.CommandButton Command14 
         Caption         =   "Command14"
         Height          =   495
         Left            =   240
         TabIndex        =   26
         Top             =   360
         Visible         =   0   'False
         Width           =   735
      End
   End
   Begin VB.Frame Frame8 
      Appearance      =   0  'Flat
      BackColor       =   &H00000000&
      Caption         =   "                                  "
      ForeColor       =   &H80000008&
      Height          =   6615
      Left            =   240
      TabIndex        =   17
      Top             =   240
      Width           =   8295
      Begin VB.Frame Frame12 
         Appearance      =   0  'Flat
         BackColor       =   &H00000000&
         Caption         =   "Coordinates"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   735
         Left            =   0
         TabIndex        =   20
         Top             =   0
         Width           =   1695
         Begin VB.Label Label13 
            BackStyle       =   0  'Transparent
            Caption         =   "999"
            ForeColor       =   &H00FFFFFF&
            Height          =   255
            Left            =   1320
            TabIndex        =   24
            Top             =   360
            Width           =   375
         End
         Begin VB.Label Label12 
            BackStyle       =   0  'Transparent
            Caption         =   "Y="
            ForeColor       =   &H00FFFFFF&
            Height          =   255
            Left            =   1080
            TabIndex        =   23
            Top             =   360
            Width           =   255
         End
         Begin VB.Label Label11 
            BackStyle       =   0  'Transparent
            Caption         =   "999"
            ForeColor       =   &H00FFFFFF&
            Height          =   255
            Left            =   360
            TabIndex        =   22
            Top             =   360
            Width           =   375
         End
         Begin VB.Label Label10 
            BackStyle       =   0  'Transparent
            Caption         =   "X="
            ForeColor       =   &H00FFFFFF&
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   360
            Width           =   255
         End
      End
      Begin VB.PictureBox Picture2 
         AutoRedraw      =   -1  'True
         BackColor       =   &H00FFFFFF&
         Height          =   3720
         Left            =   1200
         ScaleHeight     =   3660
         ScaleWidth      =   5850
         TabIndex        =   18
         Top             =   1440
         Width           =   5910
         Begin VB.Line Line20 
            BorderColor     =   &H80000000&
            BorderStyle     =   3  'Dot
            X1              =   0
            X2              =   5880
            Y1              =   1780
            Y2              =   1780
         End
         Begin VB.Line Line19 
            BorderColor     =   &H80000000&
            BorderStyle     =   3  'Dot
            X1              =   2860
            X2              =   2860
            Y1              =   0
            Y2              =   3720
         End
      End
      Begin VB.PictureBox Picture1 
         AutoRedraw      =   -1  'True
         Height          =   3720
         Left            =   1200
         ScaleHeight     =   3660
         ScaleWidth      =   5850
         TabIndex        =   19
         Top             =   1440
         Width           =   5910
      End
      Begin VB.Line Line15 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   5880
         Y2              =   5880
      End
      Begin VB.Line Line14 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   720
         Y2              =   720
      End
      Begin VB.Line Line13 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   4200
         Y2              =   4200
      End
      Begin VB.Line Line11 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   1200
         X2              =   1200
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line10 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   4080
         X2              =   4080
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line9 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   7080
         X2              =   7080
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line8 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   9480
         X2              =   9480
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line7 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   5130
         Y2              =   5130
      End
      Begin VB.Line Line6 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   1440
         Y2              =   1440
      End
      Begin VB.Line Line5 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   8280
         X2              =   8280
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line4 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   2640
         X2              =   2640
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Line Line3 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   3240
         Y2              =   3240
      End
      Begin VB.Line Line2 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   5520
         X2              =   5520
         Y1              =   120
         Y2              =   6610
      End
      Begin VB.Image Image2 
         Height          =   3720
         Left            =   2400
         Top             =   5880
         Visible         =   0   'False
         Width           =   5910
      End
      Begin VB.Image Image1 
         Height          =   3720
         Left            =   2400
         Stretch         =   -1  'True
         Top             =   1440
         Width           =   5910
      End
      Begin VB.Line Line12 
         BorderColor     =   &H00808080&
         BorderStyle     =   3  'Dot
         X1              =   0
         X2              =   10560
         Y1              =   2280
         Y2              =   2280
      End
   End
   Begin VB.Frame Frame6 
      Caption         =   "Textcolor"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3375
      Left            =   3600
      TabIndex        =   8
      Top             =   1080
      Visible         =   0   'False
      Width           =   3615
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   7
         Left            =   1920
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   16
         Top             =   2640
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   6
         Left            =   1920
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   15
         Top             =   1920
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   5
         Left            =   1920
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   14
         Top             =   1200
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   4
         Left            =   1920
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   13
         Top             =   480
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   3
         Left            =   240
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   12
         Top             =   2640
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   2
         Left            =   240
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   11
         Top             =   1920
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   1
         Left            =   360
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   10
         Top             =   1200
         Width           =   1455
      End
      Begin VB.PictureBox Picture3 
         Height          =   615
         Index           =   0
         Left            =   360
         ScaleHeight     =   555
         ScaleWidth      =   1395
         TabIndex        =   9
         Top             =   360
         Width           =   1455
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "save"
      Height          =   495
      Left            =   7200
      TabIndex        =   1
      Top             =   4440
      Visible         =   0   'False
      Width           =   615
   End
   Begin MSComDlg.CommonDialog Cdl1 
      Left            =   4320
      Top             =   6960
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      CancelError     =   -1  'True
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   400
      Left            =   5520
      Top             =   6360
   End
   Begin VB.Frame Frame5 
      Caption         =   "Font Effects"
      Height          =   1335
      Left            =   5280
      TabIndex        =   2
      Top             =   4800
      Visible         =   0   'False
      Width           =   2295
      Begin VB.CommandButton Command9 
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   7
         ToolTipText     =   "Bold"
         Top             =   480
         Width           =   495
      End
      Begin VB.CommandButton Command9 
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   600
         Style           =   1  'Graphical
         TabIndex        =   6
         ToolTipText     =   "Italic"
         Top             =   480
         Width           =   495
      End
      Begin VB.CommandButton Command9 
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   1080
         Style           =   1  'Graphical
         TabIndex        =   5
         ToolTipText     =   "Underline"
         Top             =   480
         Width           =   495
      End
      Begin VB.CommandButton Command9 
         Caption         =   "B"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   -1  'True
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   1560
         Style           =   1  'Graphical
         TabIndex        =   4
         ToolTipText     =   "Strikethru"
         Top             =   480
         Width           =   495
      End
      Begin VB.CommandButton Command9 
         Caption         =   "None"
         Height          =   375
         Index           =   4
         Left            =   600
         Style           =   1  'Graphical
         TabIndex        =   3
         ToolTipText     =   "Draw a straight line"
         Top             =   840
         Width           =   975
      End
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Add Background"
      Height          =   495
      Left            =   5880
      TabIndex        =   0
      Top             =   6120
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Image Image3 
      Height          =   6840
      Left            =   120
      Picture         =   "Form1.frx":F7C5
      Stretch         =   -1  'True
      Top             =   120
      Width           =   8520
   End
   Begin VB.Line Line1 
      X1              =   0
      X2              =   18000
      Y1              =   0
      Y2              =   0
   End
   Begin VB.Menu mnufile 
      Caption         =   "File"
      Begin VB.Menu mnunieuw 
         Caption         =   "New"
      End
      Begin VB.Menu mnuopen 
         Caption         =   "Open"
      End
      Begin VB.Menu mnusave 
         Caption         =   "Save"
      End
      Begin VB.Menu mnuprint 
         Caption         =   "Print"
      End
      Begin VB.Menu streep 
         Caption         =   "-"
      End
      Begin VB.Menu mnuexit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnuedit 
      Caption         =   "Edit"
      Visible         =   0   'False
      Begin VB.Menu mnuresize 
         Caption         =   "Resize"
         Visible         =   0   'False
      End
      Begin VB.Menu mnubackground 
         Caption         =   "Load Background"
      End
      Begin VB.Menu mnuclback 
         Caption         =   "Clear Background"
      End
   End
   Begin VB.Menu mnuhelp 
      Caption         =   "Help"
      Visible         =   0   'False
      Begin VB.Menu mnuabout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "frmshowfnt"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function CreateFontIndirect Lib "gdi32" Alias _
       "CreateFontIndirectA" (lpLogFont As LOGFONT) As Long

Private Type LOGFONT
    lfHeight As Long                           ' In logical units
    lfWidth As Long
    lfEscapement As Long
    lfOrientation As Long
    lfWeight As Long
    lfItalic As Byte
    lfUnderline As Byte
    lfStrikeOut As Byte
    lfCharSet As Byte
    lfOutPrecision As Byte
    lfClipPrecision As Byte
    lfQuality As Byte
    lfPitchAndFamily As Byte
    lfFaceName As String * 33                  ' L_FACESIZE
End Type

Private Declare Function SelectObject Lib "gdi32" (ByVal hdc As Long, _
    ByVal hObject As Long) As Long
Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Long) As Long

' In order for Windows NT to work
Private Declare Function SetGraphicsMode Lib "gdi32" (ByVal hdc As Long, ByVal iMode As Long) As Long
Const GM_ADVANCED = 2

Dim t3d As Class1
Dim Cx As Integer
Dim Cy As Integer
Dim strfontnaam As String
Dim strtext As String
Dim diepte As Integer
Dim Comx As Integer
Dim tempx As Integer
Dim bbackgroundcontrole As Boolean

  Dim x22 As Single, y22 As Single
  Dim x11 As Single, y11 As Single

Private Sub Check1_Click()
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
If Check1 = 0 Then
    Picture2.Print strtext
    Command8_Click
    Command4(0).Value = True
    
    Else
    Command4(1).Value = True
    
    Set t3d = New Class1
    t3d.Text3D strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value
End If

    
End Sub

Private Sub Combo1_Click()
  
 If Combo1.Text = "General Text" Then
    Text1.SetFocus
    HScroll3.Value = 14
    Label8.Caption = "General Text"
    Text5.Visible = False
    Text1.Text = ""
    Text2.Text = ""
    Text5.Enabled = False
     Command6.Visible = True
    ElseIf Combo1.Text = "Name Text" Then
           Text1.SetFocus
           Label8.Caption = "Name Text"
           HScroll3.Value = 35
           Text5.Visible = True
           Text1.Text = ""
           Text2.Text = ""
           Text5.Enabled = False
           Command6.Visible = False
    ElseIf Combo1.Text = "Address Text" Then
           HScroll3.Value = 22
           Text1.SetFocus
           Label8.Caption = "Address Text"
           Text5.Visible = True
           Text1.Text = ""
           Text2.Text = ""
           Text5.Enabled = False
           Command6.Visible = False
 End If
 
End Sub

Private Sub Command10_Click()
  Command3.Value = True
  Command12.Enabled = True
  Command10.Enabled = True
End Sub

'Print
Private Sub Command11_Click()
Dim xxx
 On Error Resume Next
   xxx = MsgBox("Are you sure want to Print? ", vbYesNo, "Gerp Soft ( PRINT )")
              If xxx = vbYes Then
 Command6_Click
 Image2.Picture = LoadPicture("C:\sample.bmp")
 
 If Option1.Value = True And Option2.Value = False Then
   Printer.PrintQuality = -2
   Printer.PaintPicture Image2.Picture, 0, 0, 5910, 3720
   Printer.EndDoc
   ElseIf Option2.Value = True And Option1.Value = False Then
       Printer.PrintQuality = -2
       Printer.PaintPicture Image2.Picture, 0, 0, 3720, 5910
       Printer.EndDoc
   
 End If
End If
End Sub

Private Sub Command12_Click()
     Image1.Picture = LoadPicture("")
    Set Picture2.Picture = Image1.Picture
    bbackgroundcontrole = False
    Text1.Text = strtext
    Text1_Change
End Sub


Private Sub Command13_Click()
  If Command13.Caption = "Show Grid" Then
        Line2.Visible = True
        Line3.Visible = True
        Line4.Visible = True
        Line5.Visible = True
        Line6.Visible = True
        Line7.Visible = True
        Line8.Visible = True
        Line9.Visible = True
        Line10.Visible = True
        Line11.Visible = True
        Line12.Visible = True
        Line13.Visible = True
        Line14.Visible = True
        Line15.Visible = True
        Command13.Caption = "Hide Grid"
        
        ElseIf Command13.Caption = "Hide Grid" Then
                Line2.Visible = False
                Line3.Visible = False
                Line4.Visible = False
                Line5.Visible = False
                Line6.Visible = False
                Line7.Visible = False
                Line8.Visible = False
                Line9.Visible = False
                Line10.Visible = False
                Line11.Visible = False
                Line12.Visible = False
                Line13.Visible = False
                Line14.Visible = False
                Line15.Visible = False
                Command13.Caption = "Show Grid"
 End If
End Sub

Private Sub Command14_Click()
 
      ' Engraved, horizontal. &H808080 is gray
    x22 = Picture4.ScaleLeft + 120
    y22 = Picture4.ScaleTop + 18
    RotateText Picture4, "GerP Soft by: Gerbert S. Pagtama", "Times New Roman", True, False, 16, _
            0, 2, vbWhite, &H808080, vbBlack, x22, y22
            
    x11 = Picture4.ScaleLeft + 60
    y11 = Picture4.ScaleTop + 45
    RotateText Picture4, "Mobile number  (+63928 7965237)  E-mail :gerbert_p@yahoo.com", "Times New Roman", True, False, 12, _
            0, 2, vbYellow, &H808080, vbBlack, x11, y11
End Sub

Private Sub Command2_Click()
    Dim strfilen As String
     With Cdl1
        .CancelError = False
        .Filter = "Bitmap (.bmp)|*.bmp"
        .FileName = Text1 & ".bmp"
        .ShowSave
        strfilen = .FileName
    End With
    If Len(strfilen) > 1 Then
        SavePicture Picture2.Image, strfilen
    Else
        MsgBox "you must enter a name to save this picture", vbOKOnly, "No Save"
    End If
End Sub

Private Sub Command3_Click()
On Error Resume Next
    With Cdl1
   .Filter = "All Picture Files| *.png; *.gif; *.cel; *.pic; *.cut; *.pal; *.tga; *.pcx; *.bmp; *.tiff; *.jpg; *.jpeg; *.wmf|Portable Network Grphics  (*.png)|*.png|CompuServe Images  (*.gif)|*.gif|Autodesk Images  (*.cel,*.pic)|*.cel,*pic|DrHalo Images  (*.cut,*.pal)|*.cut,*.pal|True Vision Images  (*.tga)|*.tga|ZSoft Paintbrush  (*.pcx)|*.pcx|Bitmap Images  (*.bmp)|*.bmp|Tiff Images  (*.Tiff)|*.Tiff|Jpeg Images  (*.jpeg)|*.jpeg|Windos MetaFile  (*.wmf)|*.wmf|"
    .ShowOpen
End With
    Image1.Picture = LoadPicture(Cdl1.FileName)
    If Image1.Width > 1022 * 15 Then Image1 = 1022 * 15
    If Image1.Height > 639 * 15 Then Image1 = 639 * 15
    Set Picture2.Picture = Image1.Picture
 
    bbackgroundcontrole = True
    Text1.Text = strtext
    Text1_Change
End Sub

Private Sub Command4_Click(Index As Integer)
If Index > 0 Then
    Check1.Value = 1
Else
    Check1.Value = 0
End If

Comx = Index

Select Case Index
    Case 0
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Picture2.Print strtext
    Command4(Index).BackColor = &H8080FF
    Command4(1).BackColor = &H8000000F
    Command4(2).BackColor = &H8000000F
    Command4(5).BackColor = &H8000000F
    Command4(6).BackColor = &H8000000F

    Case 1
        Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Index).BackColor = &H8080FF
    Command4(0).BackColor = &H8000000F
    Command4(2).BackColor = &H8000000F
    Command4(5).BackColor = &H8000000F
    Command4(6).BackColor = &H8000000F

    Set t3d = New Class1
  
         t3d.Text3D strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value
    
    
    Case 2
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Index).BackColor = &H8080FF
    Command4(0).BackColor = &H8000000F
    Command4(1).BackColor = &H8000000F
    Command4(5).BackColor = &H8000000F
    Command4(6).BackColor = &H8000000F

    Set t3d = New Class1
        t3d.Text3D8 strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value
    
    Case 5
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Index).BackColor = &H8080FF
    Command4(0).BackColor = &H8000000F
    Command4(1).BackColor = &H8000000F
    Command4(2).BackColor = &H8000000F
    Command4(6).BackColor = &H8000000F

    Set t3d = New Class1
        t3d.Text3D7 strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value
    Case 6
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Index).BackColor = &H8080FF
    Command4(0).BackColor = &H8000000F
    Command4(1).BackColor = &H8000000F
    Command4(2).BackColor = &H8000000F
    Command4(5).BackColor = &H8000000F

    Set t3d = New Class1
        t3d.Text3D2 strtext, strfontnaam, HScroll3.Value, Cx, Cy, diepte, HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value, HScroll2(0).Value, HScroll2(1).Value, HScroll2(2).Value
End Select
End Sub

Private Sub Command5_Click()
    Text1.Text = ""
End Sub

Private Sub Command6_Click()
 SavePicture Picture2.Image, "C:\sample.bmp"
 Picture2.Picture = LoadPicture("C:\sample.bmp")
 Text1.Text = ""
End Sub

Private Sub Command7_Click()
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    
    Picture2.BackColor = RGB(Val(HScroll1(0)), Val(HScroll1(1)), Val(HScroll1(2)))
If Check1 = 0 Then

    Picture2.Print strtext
   Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
    
End If
    

End Sub

Private Sub Command8_Click()
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy

    
If Check1 = 0 Then
    Picture2.ForeColor = RGB(Val(HScroll2(0)), Val(HScroll2(1)), Val(HScroll2(2)))

    Picture2.Print strtext
   Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
    
End If

End Sub

Private Sub Command9_Click(Index As Integer)
    Select Case Index
            Case 0
                          
            Picture2.FontBold = True
            Command4(Comx).Value = True
            Command9(0).BackColor = &H8080FF
            Command9(4).BackColor = &H8000000F
            
            Case 1
            Picture2.FontItalic = True
            Command4(Comx).Value = True
            Command9(1).BackColor = &H8080FF
            Command9(4).BackColor = &H8000000F
            
            Case 2
            Picture2.FontUnderline = True
            Command4(Comx).Value = True
            Command9(2).BackColor = &H8080FF
            Command9(4).BackColor = &H8000000F
            
            Case 3
            Picture2.FontStrikethru = True
            Command4(Comx).Value = True
            Command9(3).BackColor = &H8080FF
            Command9(4).BackColor = &H8000000F
            Case 4
            Picture2.FontBold = False
            Picture2.FontItalic = False
            Picture2.FontUnderline = False
            Picture2.FontStrikethru = False
            Command4(Comx).Value = True
            Command9(0).BackColor = &H8000000F
            Command9(1).BackColor = &H8000000F
            Command9(2).BackColor = &H8000000F
            Command9(3).BackColor = &H8000000F
            Command9(4).BackColor = &H8080FF

    End Select
    
End Sub

Private Sub Form_Activate()
  Command14_Click
  mnusave.Enabled = False
  mnuprint.Enabled = False
End Sub

Private Sub Form_Initialize()
 On Error Resume Next
 
Dim X As Integer
    Text1.Text = ""
    strtext = Text1
    
    For X = 0 To Screen.FontCount - 1
        list1.AddItem Screen.Fonts(X)
    Next X
        
   
        HScroll3.Value = 14 ' font size
        
        HScroll1(0).Value = 255
        HScroll1(1).Value = 255
        HScroll1(2).Value = 255
   
        HScroll2(0).Value = 220
        HScroll2(1).Value = 87
        HScroll2(2).Value = 40
        HScroll5(0).Value = 0
        HScroll5(1).Value = 0
        HScroll5(2).Value = 0
        
  
    PicX = 600
    PicY = 145
    
    Cx = 1200
    Cy = 400
    diepte = 80
    HScroll4.Value = diepte
    Command4(0).BackColor = &H8080FF
    strfontnaam = list1.List(5)
    
    Picture2.Font = list1.List(5): list1.Text = list1.List(5)

    Picture2.FontSize = HScroll3.Value
    
    Label2(0) = HScroll1(0).Value
    Label2(1) = HScroll1(1).Value
    Label2(2) = HScroll1(2).Value
    Label3(0) = HScroll2(0).Value
    Label3(1) = HScroll2(1).Value
    Label3(2) = HScroll2(2).Value
    Label7(0).Caption = HScroll5(0).Value
    Label7(1).Caption = HScroll5(1).Value
    Label7(2).Caption = HScroll5(2).Value
    Picture2.Cls

    Picture2.Print Text1.Text
       

            Timer1.Enabled = True

    Command4(1).Value = True
    Command9(4).Value = True
    
    Check1.Value = 0
    
 
    
    
              If Check1 = 0 Then
              Picture2.ForeColor = vbBlack
              Picture2.Print strtext
              Else
                Picture2.Cls
                Picture2.CurrentX = Cx
                Picture2.CurrentY = Cy
                Command4(Comx).Value = True
                
           End If
           Command14_Click
     Option1.Value = 1
      Picture2.FontBold = True
      

End Sub


Private Sub Form_Unload(Cancel As Integer)

    Set frmshowfnt = Nothing
 
End Sub



Private Sub Frame2_DragDrop(Source As Control, X As Single, Y As Single)

End Sub

Private Sub Frame9_DragDrop(Source As Control, X As Single, Y As Single)

End Sub

Private Sub HScroll1_Change(Index As Integer)
    Text3.BackColor = RGB(Val(HScroll1(0)), Val(HScroll1(1)), Val(HScroll1(2)))
    Command7_Click
    Label2(0) = HScroll1(0).Value
    Label2(1) = HScroll1(1).Value
    Label2(2) = HScroll1(2).Value
    
End Sub

Private Sub HScroll2_Change(Index As Integer)
    Text2.BackColor = RGB(Val(HScroll2(0)), Val(HScroll2(1)), Val(HScroll2(2)))
    Label3(0) = HScroll2(0).Value
    Label3(1) = HScroll2(1).Value
    Label3(2) = HScroll2(2).Value
    Command8_Click

End Sub

Private Sub HScroll3_Change()

    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    
    
    Picture2.FontSize = HScroll3.Value + 1
If Check1.Value = 0 Then
    Picture2.Print strtext
    Label1.Caption = HScroll3.Value
   Else
    Command4(Comx).Value = True
        Label1.Caption = HScroll3.Value

End If

End Sub

Private Sub HScroll4_Change()
    diepte = HScroll4.Value
    If Check1 = 0 Then
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Picture2.Print strtext
   Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
        
End If
    Label5 = diepte
    
End Sub

Private Sub HScroll5_Change(Index As Integer)
    Text4.BackColor = RGB(HScroll5(0).Value, HScroll5(1).Value, HScroll5(2).Value)
    
    
    If Check1 = 0 Then
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Picture2.Print strtext
   Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
    
    
End If
    Label7(0).Caption = HScroll5(0).Value
    Label7(1).Caption = HScroll5(1).Value
    Label7(2).Caption = HScroll5(2).Value
    
End Sub







Private Sub List1_Click()
On Error Resume Next

Dim z As Integer
    z = HScroll3.Value
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    
    Picture2.Font = Screen.Fonts(list1.ListIndex)
    strfontnaam = Screen.Fonts(list1.ListIndex)
    Picture2.FontSize = z
    
If Check1 = 0 Then
    Picture2.Print strtext
   Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
    
End If

    
End Sub



Private Sub mnubackground_Click()
    Command3.Value = True
    
End Sub

Private Sub mnuclback_Click()
    Image1.Picture = LoadPicture("")
    Set Picture2.Picture = Image1.Picture
    bbackgroundcontrole = False
    Text1.Text = strtext
    Text1_Change
End Sub

Private Sub mnuexit_Click()
    Unload frmshowfnt
    Set frmshowfnt = Nothing
End Sub



Private Sub mnuopen_Click()
On Error GoTo fout
    With Cdl1
    .CancelError = True
    .FileName = ""
    .Filter = "Bitmap (*.bmp)|*.bmp"
    .ShowOpen
End With
If Len(Cdl1.FileName) > 1 Then
    Picture2.Cls
    Text1.Text = ""
    Picture2.Picture = LoadPicture(Cdl1.FileName)
    Call Pic_Res
            If Option1.Value = True And Option2.Value = False Then
               Option1_Click
               ElseIf Option2.Value = True And Option1.Value = False Then
                      Option2_Click
            End If
    
    Else
    
End If
fout:
    Text1_Change
    
   mnusave.Enabled = True
  mnuprint.Enabled = True
    
End Sub

Private Sub mnunieuw_Click()
    Form_Initialize
    mnuclback_Click
    mnuopen.Enabled = True
    Text1.Text = ""
    Text2.Text = ""
    mnusave.Enabled = True
    mnuprint.Enabled = True
    Text1.Locked = False
    Command10.Enabled = True
    Command13.Enabled = True
    Command11.Enabled = True
End Sub

Private Sub mnuprint_Click()
   Command11_Click
End Sub

Private Sub mnusave_Click()
    Command2_Click
End Sub
Private Sub Option1_Click()
'Portrait
  Picture2.Height = 3720
  Picture2.Width = 5910
  Picture2.Left = 1200
  Picture2.Top = 1440
  
  Picture1.Height = 3720
  Picture1.Width = 5910
  Picture1.Left = 1200
  Picture1.Top = 1440
  
  Image1.Height = 3720
  Image1.Width = 5910
  Image1.Left = 1200
  Image1.Top = 1440
  
  Image2.Height = 3720
  Image2.Width = 5910
  
  Line19.X1 = 2860
  Line19.x2 = 2860
  Line19.Y1 = 0
  Line19.y2 = 3720
  
  Line20.X1 = 0
  Line20.x2 = 5880
  Line20.Y1 = 1780
  Line20.y2 = 1780
End Sub

Private Sub Option2_Click()
'Landscape
  Picture2.Height = 5910
  Picture2.Width = 3720
  Picture2.Left = 2255
  Picture2.Top = 460
  
  Picture1.Height = 5910
  Picture1.Width = 3720
  Picture1.Left = 2255
  Picture1.Top = 460
  
  Image1.Height = 5910
  Image1.Width = 3720
  Image1.Left = 2255
  Image1.Top = 460
  
  Image2.Height = 5910
  Image2.Width = 3720
  
  Line19.X1 = 1780
  Line19.x2 = 1780
  Line19.Y1 = 0
  Line19.y2 = 5880
  
  Line20.X1 = 0
  Line20.x2 = 5880
  Line20.Y1 = 2760
  Line20.y2 = 2760
  
End Sub

Private Sub Picture2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Label11.Caption = CInt(X) / 15
    Label13.Caption = CInt(Y) / 15
End Sub

Private Sub picture2_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Picture2.Cls
    Picture2.CurrentX = CInt(X) + 5: Cx = CInt(X) + 5
    Picture2.CurrentY = CInt(Y) - 10: Cy = CInt(Y) - 10
If Check1 = 0 Then
    Picture2.Print strtext
    Else
    Picture2.Cls
    Picture2.CurrentX = Cx
    Picture2.CurrentY = Cy
    Command4(Comx).Value = True
End If
End Sub

Private Sub Text1_Change()
Dim currentXX, currentYY, widthx, heighty
Dim lent As Integer
    strtext = Text1.Text
    Picture2.Cls
    lent = Len(Text1.Text)
    lent = CDbl(lent) * CDbl(lent) + 500

    widthx = Picture2.Width
    heighty = Picture2.Height
    
    widthx = CDbl(widthx) / 2
    widthx = CDbl(widthx) - CDbl(lent)
    
    Picture2.CurrentX = widthx
    
    Picture2.CurrentY = Cy
If Check1.Value = 1 Then
    Command4(Comx).Value = True
    
Else
    Picture2.Print strtext
End If

End Sub


Private Sub Text5_Change()
  Text1.Text = Text5.Text
End Sub

Private Sub Timer1_Timer()

     Picture1.PaintPicture Picture2.Image, 0, 0, PicX * 22, PicY * 22
    DoEvents
If bbackgroundcontrole = False Then
    mnuclback.Enabled = False
    mnubackground = True
    
Else
    mnuclback.Enabled = True
    mnubackground = False
    
End If

End Sub

Public Sub Init()
    Picture1.Width = PicX * 15
    Picture1.Height = PicY * 15
    Picture2.Width = PicX * 15
    Picture2.Height = PicY * 15
    Image1.Width = PicX * 15
    Image1.Height = PicY * 15
   
    Picture1.Left = 360 + (tempx / 2)
       
    Picture2.Left = Picture1.Left
    Image1.Left = Picture1.Left

    Call Pic_Res
    
End Sub

Private Sub Pic_Res()
    Picture1.Width = Picture2.Width
    Picture1.Height = Picture2.Height
    Image1.Width = Picture2.Width
    Image1.Height = Picture2.Height
    PicX = Picture2.Width / 15
    PicY = Picture2.Height / 15

    
    Picture1.Left = 360 + (tempx / 2)
    
    
    Picture2.Left = Picture1.Left
    Image1.Left = Picture1.Left

End Sub


Function RotateText(inObj As Object, inText As String, inFontName As String, _
        inBold As Boolean, inItalic As Boolean, inFontSize As Integer, _
        inAngle As Long, inStyle As Integer, _
        firstClr As Long, secondClr As Long, mainClr As Long, _
        X As Single, Y As Single, _
        Optional inDepth As Integer = 1) As Boolean
    On Error GoTo errHandler
    
    RotateText = False
    
    Dim L As LOGFONT
    Dim mFont As Long
    Dim mPrevFont As Long
    Dim i As Integer
    Dim origMode As Integer
    Dim tmpX As Single, tmpY As Single
    Dim mresult
    
     ' For Windows NT to work
    mresult = SetGraphicsMode(inObj.hdc, GM_ADVANCED)
    
    origMode = inObj.ScaleMode
    inObj.ScaleMode = vbPixels
    
    If inBold = True And inItalic = True Then
        L.lfFaceName = inFontName & Space(1) & "Bold" & Space(1) & "Italic" & Chr(0)    ' Must be null terminated
    ElseIf inBold = True And inItalic = False Then
        L.lfFaceName = inFontName & Space(1) & "Bold" + Chr$(0)
    ElseIf inBold = False And inItalic = True Then
        L.lfFaceName = inFontName & Space(1) & "Italic" + Chr$(0)
    Else
        L.lfFaceName = inFontName & Chr$(0)
    End If

    L.lfEscapement = inAngle * 10
    L.lfHeight = inFontSize * -20 / Screen.TwipsPerPixelY
       
    mFont = CreateFontIndirect(L)
    mPrevFont = SelectObject(inObj.hdc, mFont)
    
    inObj.CurrentX = X
    inObj.CurrentY = Y
    tmpX = X
    tmpY = Y
    Select Case inStyle
         Case 0          ' Ordinary shade
            If firstClr <> -1 Then         ' Minus 1 indicate N/A
                inObj.ForeColor = firstClr
                For i = 1 To inDepth
                    tmpX = tmpX + 1: tmpY = tmpY + 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If secondClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                tmpX = X
                tmpY = Y
                inObj.ForeColor = secondClr
                For i = 1 To inDepth
                    tmpX = tmpX - 1: tmpY = tmpY - 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If mainClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                inObj.ForeColor = mainClr
                inObj.Print inText
            End If
            
        Case 1             'Embossed effect - text horizontal
            If firstClr <> -1 Then
                inObj.ForeColor = firstClr
                For i = 1 To inDepth
                    tmpX = tmpX - 1: tmpY = tmpY - 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If secondClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                tmpX = X
                tmpY = Y
                inObj.ForeColor = secondClr
                For i = 1 To inDepth
                    tmpX = tmpX + 1: tmpY = tmpY + 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If mainClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                inObj.ForeColor = mainClr
                inObj.Print inText
            End If
            
         Case 2          ' Engroved effect - text horizontal
            If firstClr <> -1 Then
                inObj.ForeColor = firstClr
                For i = 1 To inDepth
                    tmpX = tmpX + 1: tmpY = tmpY + 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            
            If secondClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                tmpX = X
                tmpY = Y
                inObj.ForeColor = secondClr
                For i = 1 To inDepth
                    tmpX = tmpX - 1: tmpY = tmpY - 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If mainClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                inObj.ForeColor = mainClr
                inObj.Print inText
            End If
            
         Case 3          ' Embossed effect - text vertical
            If firstClr <> -1 Then
                inObj.ForeColor = secondClr
                For i = 1 To inDepth
                    tmpX = tmpX + 1: tmpY = tmpY + 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If secondClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                tmpX = X
                tmpY = Y
                inObj.ForeColor = firstClr
                For i = 1 To inDepth
                    tmpX = tmpX - 1: tmpY = tmpY - 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If mainClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                inObj.ForeColor = mainClr
                inObj.Print inText
            End If
            
        Case 4             'Engraved effect - text vertical
            If firstClr <> -1 Then
                inObj.ForeColor = secondClr
                For i = 1 To inDepth
                    tmpX = tmpX - 1: tmpY = tmpY - 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If secondClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                tmpX = X
                tmpY = Y
                inObj.ForeColor = firstClr
                For i = 1 To inDepth
                    tmpX = tmpX + 1: tmpY = tmpY + 1
                    inObj.CurrentX = tmpX
                    inObj.CurrentY = tmpY
                    inObj.Print inText
                Next i
            End If
            
            If mainClr <> -1 Then
                inObj.CurrentX = X
                inObj.CurrentY = Y
                inObj.ForeColor = mainClr
                inObj.Print inText
            End If
    End Select
            
    mresult = SelectObject(inObj.hdc, mPrevFont)
    mresult = DeleteObject(mFont)
    inObj.ScaleMode = origMode
    RotateText = True
    Exit Function
    
errHandler:
    inObj.ScaleMode = origMode
    MsgBox "RotateText"
End Function




' Parameters: Object, String, FontName, Bold, Italic, FontSize,
'   SolidColor(1=red, 2=green, 3=blue, 4=black), X, Y,
'  (& optional Direction  1=left to right, 2=right to left
'   3=top down, 4=bottom up)
'
' Example: GradientText Me, "Example 3", "Times New Roman", True, False, 18, _
'               3, X, y (0)
'          GradientText Me, "Example 3", "Times New Roman", True, False, 18, _
'               3, X, y, 1
Sub GradientText(inObj As Object, inText As String, inFontName As String, _
        inBold As Boolean, inItalic As Boolean, inFontSize As Integer, _
        SolidClr As Integer, X As Single, Y As Single, Optional inDirection As Integer = 0)
    On Error GoTo errHandler
    Dim L As LOGFONT
    Dim mFont As Long
    Dim mPrevFont As Long
    Dim i As Integer, j As Integer, k As Integer, t As Integer
    Dim origMode As Integer
    Dim interval
    Dim mColor
    Dim w, h, x2, y2
    Dim mresult
    
    origMode = inObj.ScaleMode
    inObj.ScaleMode = vbPixels
    
    If inBold = True And inItalic = True Then
        L.lfFaceName = inFontName & Space(1) & "Bold" & Space(1) & "Italic" & Chr(0)    ' Must be null terminated
    ElseIf inBold = True And inItalic = False Then
        L.lfFaceName = inFontName & Space(1) & "Bold" + Chr$(0)
    ElseIf inBold = False And inItalic = True Then
        L.lfFaceName = inFontName & Space(1) & "Italic" + Chr$(0)
    Else
        L.lfFaceName = inFontName & Chr$(0)
    End If

    L.lfEscapement = 0
    L.lfHeight = inFontSize * -20 / Screen.TwipsPerPixelY
    mFont = CreateFontIndirect(L)
    mPrevFont = SelectObject(inObj.hdc, mFont)
    
    inObj.CurrentX = X
    inObj.CurrentY = Y
    Select Case SolidClr
        Case 1
            mColor = vbRed
        Case 2
            mColor = vbGreen
        Case 3
            mColor = vbBlue
        Case 4
            mColor = vbBlack
    End Select
    inObj.ForeColor = mColor
    inObj.Print inText
    
    Screen.MousePointer = vbHourglass
    x2 = X: y2 = Y
    For w = X To inObj.ScaleWidth - 1
          ' Assume a height which will not intrude into text of next line
         For h = Y To (Y + 50)
              If inObj.Point(w, h) = mColor Then
                   If w > x2 Then
                       x2 = w
                   End If
                   If h > y2 Then
                       y2 = h
                   End If
              End If
         Next h
    Next w
    
    interval = Int((x2 - X) \ 255)
    If interval = 0 Then
        interval = 1
    End If
    
    Select Case inDirection
        Case 0                        ' Left to right
            For i = X To x2
               k = 255 - (i - X) * interval
               If k < 0 Then
                  k = 0
               End If
               For j = Y To y2
                  If inObj.Point(i, j) = mColor Then
                       Select Case SolidClr
                           Case 1
                                inObj.PSet (i + t, j), RGB(k, 0, 0)
                           Case 2
                                inObj.PSet (i + t, j), RGB(0, k, 0)
                           Case 3
                                inObj.PSet (i + t, j), RGB(0, 0, k)
                            Case 4
                                inObj.PSet (i + t, j), RGB(255 - k, 255 - k, 255 - k)
                       End Select
                  End If
               Next j
           Next i
        Case 1                        ' Right to left
           For i = x2 To X Step -1
               k = (i - X) * interval
               If k > 255 Then
                   k = 255
               End If
               For j = Y To y2 + 10
                   If inObj.Point(i, j) = mColor Then
                       Select Case SolidClr
                            Case 1
                                 inObj.PSet (i + t, j), RGB(k, 0, 0)
                            Case 2
                                 inObj.PSet (i + t, j), RGB(0, k, 0)
                            Case 3
                                 inObj.PSet (i + t, j), RGB(0, 0, k)
                            Case 4
                                inObj.PSet (i + t, j), RGB(255 - k, 255 - k, 255 - k)
                        End Select
                  End If
              Next j
           Next i
           
        Case 2                                ' Top down
           For i = Y To y2
               k = 255 - ((i - Y) * 8)        ' 8 is arbitrarily set,.e.g. can be 6 or 10
               If k < 0 Then
                   k = 0
               End If
               For j = X To x2
                  If inObj.Point(j, i) = mColor Then
                       Select Case SolidClr
                           Case 1
                              inObj.PSet (j, i + t), RGB(k, 0, 0)
                           Case 2
                              inObj.PSet (j, i + t), RGB(0, k, 0)
                           Case 3
                              inObj.PSet (j, i + t), RGB(0, 0, k)
                            Case 4
                              inObj.PSet (j, i + t), RGB(255 - k, 255 - k, 255 - k)
                       End Select
                  End If
               Next j
           Next i
           
        Case 3                     ' Bottom up
           For i = y2 To Y Step -1
               k = (i - Y) * 10
               If k > 255 Then
                   k = 255
               End If
               For j = X To x2
                  If inObj.Point(j, i) = mColor Then
                       Select Case SolidClr
                           Case 1
                              inObj.PSet (j, i + t), RGB(k, 0, 0)
                           Case 2
                              inObj.PSet (j, i + t), RGB(0, k, 0)
                           Case 3
                              inObj.PSet (j, i + t), RGB(0, 0, k)
                            Case 4
                              inObj.PSet (j, i + t), RGB(255 - k, 255 - k, 255 - k)
                       End Select
                  End If
               Next j
           Next i
    End Select
    
    mresult = SelectObject(inObj.hdc, mPrevFont)
    mresult = DeleteObject(mFont)
    inObj.ScaleMode = origMode
    
    Screen.MousePointer = vbDefault
    Exit Sub
    
errHandler:
    inObj.ScaleMode = origMode
    Screen.MousePointer = vbDefault
    MsgBox "GradientText"
End Sub


