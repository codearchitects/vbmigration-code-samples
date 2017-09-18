VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H8000000D&
   Caption         =   "SUPER MASTER MIND"
   ClientHeight    =   10005
   ClientLeft      =   60
   ClientTop       =   750
   ClientWidth     =   10140
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10005
   ScaleWidth      =   10140
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Nuovo 
      Caption         =   "Nuova Partita"
      Height          =   375
      Left            =   720
      TabIndex        =   87
      Top             =   1200
      Width           =   1335
   End
   Begin VB.CommandButton Esci 
      Caption         =   "EXIT"
      Height          =   615
      Left            =   8760
      TabIndex        =   86
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton Soluzione 
      Caption         =   "Vedi soluzione"
      Height          =   375
      Left            =   720
      TabIndex        =   85
      Top             =   600
      Width           =   1335
   End
   Begin VB.CommandButton Command12 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   74
      Top             =   1320
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command11 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   73
      Top             =   2040
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command10 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   65
      Top             =   2760
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command9 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   64
      Top             =   3480
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command8 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   63
      Top             =   4200
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command7 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   62
      Top             =   4920
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command6 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   61
      Top             =   5640
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command5 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   60
      Top             =   6360
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command4 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   59
      Top             =   7080
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command3 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   58
      Top             =   7800
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command2 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   57
      Top             =   8520
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton Command1 
      Caption         =   "VAI"
      Height          =   615
      Left            =   3000
      TabIndex        =   56
      Top             =   9240
      Width           =   855
   End
   Begin VB.Label Soluz 
      Height          =   375
      Left            =   720
      TabIndex        =   89
      Top             =   1680
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Label New 
      Height          =   375
      Left            =   720
      TabIndex        =   88
      Top             =   2160
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Line Line4 
      BorderColor     =   &H80000005&
      BorderWidth     =   5
      X1              =   360
      X2              =   2520
      Y1              =   6840
      Y2              =   6840
   End
   Begin VB.Line Line3 
      BorderColor     =   &H80000005&
      BorderWidth     =   5
      X1              =   2520
      X2              =   2520
      Y1              =   4560
      Y2              =   6840
   End
   Begin VB.Line Line2 
      BorderColor     =   &H80000005&
      BorderWidth     =   5
      X1              =   360
      X2              =   360
      Y1              =   4560
      Y2              =   6840
   End
   Begin VB.Line Line1 
      BorderColor     =   &H80000005&
      BorderWidth     =   5
      X1              =   360
      X2              =   2520
      Y1              =   4560
      Y2              =   4560
   End
   Begin VB.Label LabTent12_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   84
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label LabTent12_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   83
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label LabTent12_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   82
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label LabTent12_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   81
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label LabTent12_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   80
      Top             =   1320
      Width           =   495
   End
   Begin VB.Label LabTent11_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   79
      Top             =   2040
      Width           =   495
   End
   Begin VB.Label LabTent11_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   78
      Top             =   2040
      Width           =   495
   End
   Begin VB.Label LabTent11_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   77
      Top             =   2040
      Width           =   495
   End
   Begin VB.Label LabTent11_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   76
      Top             =   2040
      Width           =   495
   End
   Begin VB.Label LabTent11_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   75
      Top             =   2040
      Width           =   495
   End
   Begin VB.Shape Tent12_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   1005
   End
   Begin VB.Shape Tent12_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   1005
   End
   Begin VB.Shape Tent12_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   1005
   End
   Begin VB.Shape Tent12_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   1005
   End
   Begin VB.Shape Tent12_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   1005
   End
   Begin VB.Shape Tent11_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   2040
      Width           =   1005
   End
   Begin VB.Shape Tent11_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   2040
      Width           =   1005
   End
   Begin VB.Shape Tent11_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   2040
      Width           =   1005
   End
   Begin VB.Shape Tent11_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   2040
      Width           =   1005
   End
   Begin VB.Shape Tent11_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   2040
      Width           =   1005
   End
   Begin VB.Shape RispTent12_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   285
   End
   Begin VB.Shape RispTent12_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   285
   End
   Begin VB.Shape RispTent12_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   285
   End
   Begin VB.Shape RispTent12_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   285
   End
   Begin VB.Shape RispTent12_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   1560
      Width           =   285
   End
   Begin VB.Shape RispTent11_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   2280
      Width           =   285
   End
   Begin VB.Shape RispTent11_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   2280
      Width           =   285
   End
   Begin VB.Shape RispTent11_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   2280
      Width           =   285
   End
   Begin VB.Shape RispTent11_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   2280
      Width           =   285
   End
   Begin VB.Shape RispTent11_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   2280
      Width           =   285
   End
   Begin VB.Label msg 
      BackColor       =   &H8000000D&
      Caption         =   "COLORE SCELTO:"
      Height          =   375
      Left            =   720
      TabIndex        =   72
      Top             =   2760
      Width           =   1455
   End
   Begin VB.Label ColScelto 
      BorderStyle     =   1  'Fixed Single
      Height          =   975
      Left            =   720
      TabIndex        =   71
      Top             =   3120
      Width           =   1455
   End
   Begin VB.Label R5 
      BackColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   6960
      TabIndex        =   70
      Top             =   120
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label R4 
      BackColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   5880
      TabIndex        =   69
      Top             =   120
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label R3 
      BackColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   4800
      TabIndex        =   68
      Top             =   120
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label R2 
      BackColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   3720
      TabIndex        =   67
      Top             =   120
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label R1 
      BackColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   2640
      TabIndex        =   66
      Top             =   120
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label Bianco 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   1560
      TabIndex        =   55
      Top             =   6120
      Width           =   855
   End
   Begin VB.Label Nero 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   480
      TabIndex        =   54
      Top             =   6120
      Width           =   855
   End
   Begin VB.Label Verde 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   1560
      TabIndex        =   53
      Top             =   5400
      Width           =   855
   End
   Begin VB.Label Rosso 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   480
      TabIndex        =   52
      Top             =   5400
      Width           =   855
   End
   Begin VB.Label Giallo 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   1560
      TabIndex        =   51
      Top             =   4680
      Width           =   855
   End
   Begin VB.Label Blu 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   480
      TabIndex        =   50
      Top             =   4680
      Width           =   855
   End
   Begin VB.Label LabTent10_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   49
      Top             =   2760
      Width           =   495
   End
   Begin VB.Label LabTent10_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   48
      Top             =   2760
      Width           =   495
   End
   Begin VB.Label LabTent10_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   47
      Top             =   2760
      Width           =   495
   End
   Begin VB.Label LabTent10_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   46
      Top             =   2760
      Width           =   495
   End
   Begin VB.Label LabTent10_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   45
      Top             =   2760
      Width           =   495
   End
   Begin VB.Label LabTent9_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   44
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label LabTent9_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   43
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label LabTent9_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   42
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label LabTent9_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   41
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label LabTent9_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   40
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label LabTent8_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   39
      Top             =   4200
      Width           =   495
   End
   Begin VB.Label LabTent8_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   38
      Top             =   4200
      Width           =   495
   End
   Begin VB.Label LabTent8_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   37
      Top             =   4200
      Width           =   495
   End
   Begin VB.Label LabTent8_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   36
      Top             =   4200
      Width           =   495
   End
   Begin VB.Label LabTent8_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   35
      Top             =   4200
      Width           =   495
   End
   Begin VB.Label LabTent7_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   34
      Top             =   4920
      Width           =   495
   End
   Begin VB.Label LabTent7_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   33
      Top             =   4920
      Width           =   495
   End
   Begin VB.Label LabTent7_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   32
      Top             =   4920
      Width           =   495
   End
   Begin VB.Label LabTent7_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   31
      Top             =   4920
      Width           =   495
   End
   Begin VB.Label LabTent7_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   30
      Top             =   4920
      Width           =   495
   End
   Begin VB.Label LabTent6_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   29
      Top             =   5640
      Width           =   495
   End
   Begin VB.Label LabTent6_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   28
      Top             =   5640
      Width           =   495
   End
   Begin VB.Label LabTent6_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   27
      Top             =   5640
      Width           =   495
   End
   Begin VB.Label LabTent6_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   26
      Top             =   5640
      Width           =   495
   End
   Begin VB.Label LabTent6_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   25
      Top             =   5640
      Width           =   495
   End
   Begin VB.Label LabTent5_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   24
      Top             =   6360
      Width           =   495
   End
   Begin VB.Label LabTent5_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   23
      Top             =   6360
      Width           =   495
   End
   Begin VB.Label LabTent5_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   22
      Top             =   6360
      Width           =   495
   End
   Begin VB.Label LabTent5_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   21
      Top             =   6360
      Width           =   495
   End
   Begin VB.Label LabTent5_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   20
      Top             =   6360
      Width           =   495
   End
   Begin VB.Label LabTent4_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   19
      Top             =   7080
      Width           =   495
   End
   Begin VB.Label LabTent4_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   18
      Top             =   7080
      Width           =   495
   End
   Begin VB.Label LabTent4_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   17
      Top             =   7080
      Width           =   495
   End
   Begin VB.Label LabTent4_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   16
      Top             =   7080
      Width           =   495
   End
   Begin VB.Label LabTent4_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   15
      Top             =   7080
      Width           =   495
   End
   Begin VB.Label LabTent3_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   14
      Top             =   7800
      Width           =   495
   End
   Begin VB.Label LabTent3_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   13
      Top             =   7800
      Width           =   495
   End
   Begin VB.Label LabTent3_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   12
      Top             =   7800
      Width           =   495
   End
   Begin VB.Label LabTent3_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   11
      Top             =   7800
      Width           =   495
   End
   Begin VB.Label LabTent3_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   10
      Top             =   7800
      Width           =   495
   End
   Begin VB.Label LabTent2_5 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6960
      TabIndex        =   9
      Top             =   8520
      Width           =   495
   End
   Begin VB.Label LabTent2_4 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   6240
      TabIndex        =   8
      Top             =   8520
      Width           =   495
   End
   Begin VB.Label LabTent2_3 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   5520
      TabIndex        =   7
      Top             =   8520
      Width           =   495
   End
   Begin VB.Label LabTent2_2 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4800
      TabIndex        =   6
      Top             =   8520
      Width           =   495
   End
   Begin VB.Label LabTent2_1 
      BackStyle       =   0  'Transparent
      Enabled         =   0   'False
      Height          =   615
      Left            =   4080
      TabIndex        =   5
      Top             =   8520
      Width           =   495
   End
   Begin VB.Label LabTent1_5 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   6960
      TabIndex        =   4
      Top             =   9240
      Width           =   495
   End
   Begin VB.Label LabTent1_4 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   6240
      TabIndex        =   3
      Top             =   9240
      Width           =   495
   End
   Begin VB.Label LabTent1_3 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   5520
      TabIndex        =   2
      Top             =   9240
      Width           =   495
   End
   Begin VB.Label LabTent1_2 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   4800
      TabIndex        =   1
      Top             =   9240
      Width           =   495
   End
   Begin VB.Shape RispTent1_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   9480
      Width           =   285
   End
   Begin VB.Shape RispTent1_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   9480
      Width           =   285
   End
   Begin VB.Shape RispTent1_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   9480
      Width           =   285
   End
   Begin VB.Shape RispTent1_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   9480
      Width           =   285
   End
   Begin VB.Shape RispTent1_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   9480
      Width           =   285
   End
   Begin VB.Shape RispTent2_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   8760
      Width           =   285
   End
   Begin VB.Shape RispTent2_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   8760
      Width           =   285
   End
   Begin VB.Shape RispTent2_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   8760
      Width           =   285
   End
   Begin VB.Shape RispTent2_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   8760
      Width           =   285
   End
   Begin VB.Shape RispTent2_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   8760
      Width           =   285
   End
   Begin VB.Shape RispTent3_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   8040
      Width           =   285
   End
   Begin VB.Shape RispTent3_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   8040
      Width           =   285
   End
   Begin VB.Shape RispTent3_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   8040
      Width           =   285
   End
   Begin VB.Shape RispTent3_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   8040
      Width           =   285
   End
   Begin VB.Shape RispTent3_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   8040
      Width           =   285
   End
   Begin VB.Shape RispTent4_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   7320
      Width           =   285
   End
   Begin VB.Shape RispTent4_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   7320
      Width           =   285
   End
   Begin VB.Shape RispTent4_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   7320
      Width           =   285
   End
   Begin VB.Shape RispTent4_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   7320
      Width           =   285
   End
   Begin VB.Shape RispTent4_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   7320
      Width           =   285
   End
   Begin VB.Shape RispTent5_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   6600
      Width           =   285
   End
   Begin VB.Shape RispTent5_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   6600
      Width           =   285
   End
   Begin VB.Shape RispTent5_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   6600
      Width           =   285
   End
   Begin VB.Shape RispTent5_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   6600
      Width           =   285
   End
   Begin VB.Shape RispTent5_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   6600
      Width           =   285
   End
   Begin VB.Shape RispTent6_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   5880
      Width           =   285
   End
   Begin VB.Shape RispTent6_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   5880
      Width           =   285
   End
   Begin VB.Shape RispTent6_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   5880
      Width           =   285
   End
   Begin VB.Shape RispTent6_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   5880
      Width           =   285
   End
   Begin VB.Shape RispTent6_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   5880
      Width           =   285
   End
   Begin VB.Shape RispTent7_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   5160
      Width           =   285
   End
   Begin VB.Shape RispTent7_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   5160
      Width           =   285
   End
   Begin VB.Shape RispTent7_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   5160
      Width           =   285
   End
   Begin VB.Shape RispTent7_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   5160
      Width           =   285
   End
   Begin VB.Shape RispTent7_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   5160
      Width           =   285
   End
   Begin VB.Shape RispTent8_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   4440
      Width           =   285
   End
   Begin VB.Shape RispTent8_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   4440
      Width           =   285
   End
   Begin VB.Shape RispTent8_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   4440
      Width           =   285
   End
   Begin VB.Shape RispTent8_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   4440
      Width           =   285
   End
   Begin VB.Shape RispTent8_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   4440
      Width           =   285
   End
   Begin VB.Shape RispTent9_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   3720
      Width           =   285
   End
   Begin VB.Shape RispTent9_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   3720
      Width           =   285
   End
   Begin VB.Shape RispTent9_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   3720
      Width           =   285
   End
   Begin VB.Shape RispTent9_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   3720
      Width           =   285
   End
   Begin VB.Shape RispTent9_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   3720
      Width           =   285
   End
   Begin VB.Shape RispTent10_2 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8400
      Shape           =   3  'Circle
      Top             =   3000
      Width           =   285
   End
   Begin VB.Shape RispTent10_3 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8760
      Shape           =   3  'Circle
      Top             =   3000
      Width           =   285
   End
   Begin VB.Shape RispTent10_4 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9120
      Shape           =   3  'Circle
      Top             =   3000
      Width           =   285
   End
   Begin VB.Shape RispTent10_5 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   9480
      Shape           =   3  'Circle
      Top             =   3000
      Width           =   285
   End
   Begin VB.Shape RispTent10_1 
      BackColor       =   &H8000000D&
      BackStyle       =   1  'Opaque
      Height          =   240
      Left            =   8040
      Shape           =   3  'Circle
      Top             =   3000
      Width           =   285
   End
   Begin VB.Shape Col1 
      BackColor       =   &H00FF0000&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   480
      Shape           =   2  'Oval
      Top             =   4680
      Width           =   855
   End
   Begin VB.Shape Col2 
      BackColor       =   &H0000FFFF&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   1560
      Shape           =   2  'Oval
      Top             =   4680
      Width           =   855
   End
   Begin VB.Shape Col3 
      BackColor       =   &H000000FF&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   480
      Shape           =   2  'Oval
      Top             =   5400
      Width           =   855
   End
   Begin VB.Shape Col4 
      BackColor       =   &H0000FF00&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   1560
      Shape           =   2  'Oval
      Top             =   5400
      Width           =   855
   End
   Begin VB.Shape Col5 
      BackColor       =   &H80000007&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   480
      Shape           =   2  'Oval
      Top             =   6120
      Width           =   855
   End
   Begin VB.Shape Col6 
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   1560
      Shape           =   2  'Oval
      Top             =   6120
      Width           =   855
   End
   Begin VB.Label LabTent1_1 
      BackStyle       =   0  'Transparent
      Height          =   615
      Left            =   4080
      TabIndex        =   0
      Top             =   9240
      Width           =   495
   End
   Begin VB.Shape Tent1_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   9240
      Width           =   1005
   End
   Begin VB.Shape Tent1_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   9240
      Width           =   1005
   End
   Begin VB.Shape Tent1_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   9240
      Width           =   1005
   End
   Begin VB.Shape Tent1_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   9240
      Width           =   1005
   End
   Begin VB.Shape Tent1_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   9240
      Width           =   1005
   End
   Begin VB.Shape Tent2_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   8520
      Width           =   1005
   End
   Begin VB.Shape Tent2_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   8520
      Width           =   1005
   End
   Begin VB.Shape Tent2_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   8520
      Width           =   1005
   End
   Begin VB.Shape Tent2_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   8520
      Width           =   1005
   End
   Begin VB.Shape Tent2_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   8520
      Width           =   1005
   End
   Begin VB.Shape Tent3_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   7800
      Width           =   1005
   End
   Begin VB.Shape Tent3_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   7800
      Width           =   1005
   End
   Begin VB.Shape Tent3_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   7800
      Width           =   1005
   End
   Begin VB.Shape Tent3_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   7800
      Width           =   1005
   End
   Begin VB.Shape Tent3_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   7800
      Width           =   1005
   End
   Begin VB.Shape Tent4_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   7080
      Width           =   1005
   End
   Begin VB.Shape Tent4_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   7080
      Width           =   1005
   End
   Begin VB.Shape Tent4_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   7080
      Width           =   1005
   End
   Begin VB.Shape Tent4_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   7080
      Width           =   1005
   End
   Begin VB.Shape Tent4_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   7080
      Width           =   1005
   End
   Begin VB.Shape Tent5_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   6360
      Width           =   1005
   End
   Begin VB.Shape Tent5_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   6360
      Width           =   1005
   End
   Begin VB.Shape Tent5_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   6360
      Width           =   1005
   End
   Begin VB.Shape Tent5_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   6360
      Width           =   1005
   End
   Begin VB.Shape Tent5_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   6360
      Width           =   1005
   End
   Begin VB.Shape Tent6_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   5640
      Width           =   1005
   End
   Begin VB.Shape Tent6_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   5640
      Width           =   1005
   End
   Begin VB.Shape Tent6_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   5640
      Width           =   1005
   End
   Begin VB.Shape Tent6_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   5640
      Width           =   1005
   End
   Begin VB.Shape Tent6_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   5640
      Width           =   1005
   End
   Begin VB.Shape Tent7_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   4920
      Width           =   1005
   End
   Begin VB.Shape Tent7_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   4920
      Width           =   1005
   End
   Begin VB.Shape Tent7_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   4920
      Width           =   1005
   End
   Begin VB.Shape Tent7_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   4920
      Width           =   1005
   End
   Begin VB.Shape Tent7_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   4920
      Width           =   1005
   End
   Begin VB.Shape Tent8_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   4200
      Width           =   1005
   End
   Begin VB.Shape Tent8_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   4200
      Width           =   1005
   End
   Begin VB.Shape Tent8_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   4200
      Width           =   1005
   End
   Begin VB.Shape Tent8_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   4200
      Width           =   1005
   End
   Begin VB.Shape Tent8_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   4200
      Width           =   1005
   End
   Begin VB.Shape Tent9_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   3480
      Width           =   1005
   End
   Begin VB.Shape Tent9_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   3480
      Width           =   1005
   End
   Begin VB.Shape Tent9_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   3480
      Width           =   1005
   End
   Begin VB.Shape Tent9_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   3480
      Width           =   1005
   End
   Begin VB.Shape Tent9_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   3480
      Width           =   1005
   End
   Begin VB.Shape Tent10_2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   4560
      Shape           =   3  'Circle
      Top             =   2760
      Width           =   1005
   End
   Begin VB.Shape Tent10_3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   5280
      Shape           =   3  'Circle
      Top             =   2760
      Width           =   1005
   End
   Begin VB.Shape Tent10_4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6000
      Shape           =   3  'Circle
      Top             =   2760
      Width           =   1005
   End
   Begin VB.Shape Tent10_5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   6720
      Shape           =   3  'Circle
      Top             =   2760
      Width           =   1005
   End
   Begin VB.Shape Tent10_1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   600
      Left            =   3840
      Shape           =   3  'Circle
      Top             =   2760
      Width           =   1005
   End
   Begin VB.Shape C5 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   6960
      Shape           =   2  'Oval
      Top             =   480
      Width           =   855
   End
   Begin VB.Shape C4 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   5880
      Shape           =   2  'Oval
      Top             =   480
      Width           =   855
   End
   Begin VB.Shape C3 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   4800
      Shape           =   2  'Oval
      Top             =   480
      Width           =   855
   End
   Begin VB.Shape C2 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   3720
      Shape           =   2  'Oval
      Top             =   480
      Width           =   855
   End
   Begin VB.Shape C1 
      BackColor       =   &H8000000A&
      BackStyle       =   1  'Opaque
      Height          =   615
      Left            =   2640
      Shape           =   2  'Oval
      Top             =   480
      Width           =   855
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuNew 
         Caption         =   "&Nuova partita"
         Shortcut        =   {F2}
      End
      Begin VB.Menu mnuVediSoluz 
         Caption         =   "&Vedi soluzione"
         Shortcut        =   ^S
      End
      Begin VB.Menu mnuSpazio 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEsci 
         Caption         =   "&Esci"
      End
   End
   Begin VB.Menu mnuAiuto 
      Caption         =   "&Help"
      Begin VB.Menu mnuHelp 
         Caption         =   "&Help"
         Shortcut        =   {F1}
      End
      Begin VB.Menu mnuSpazio2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "&About..."
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Colore As String
Dim Neri As Integer
Dim Bianchi As Integer
Dim T1 As Integer
Dim T2 As Integer
Dim T3 As Integer
Dim T4 As Integer
Dim T5 As Integer
Dim Color1 As Integer
Dim Color2 As Integer
Dim Color3 As Integer
Dim Color4 As Integer
Dim Color5 As Integer
Dim Color1a As Boolean
Dim Color2a As Boolean
Dim Color3a As Boolean
Dim Color4a As Boolean
Dim Color5a As Boolean
Dim A1 As Boolean
Dim A2 As Boolean
Dim A3 As Boolean
Dim A4 As Boolean
Dim A5 As Boolean
Dim Ripetere As Boolean

Public Function Rand(ByVal Low As Long, _
                     ByVal High As Long) As Long
                     
Randomize
Low = 1
High = 6
Rand = Int((High - Low + 1) * Rnd) + Low

End Function

Private Sub Bianco_Click()
Colore = vbWhite
Col6.BorderColor = vbWhite
Col1.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col5.BorderColor = vbBlack
ColScelto.BackColor = vbWhite
End Sub

Private Sub Blu_Click()
Colore = vbBlue
Col1.BorderColor = vbWhite
Col6.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col5.BorderColor = vbBlack
ColScelto.BackColor = vbBlue
End Sub

Private Sub Command1_Click()
If Tent1_1.BackColor = &H8000000A Or Tent1_2.BackColor = &H8000000A Or Tent1_3.BackColor = &H8000000A Or Tent1_4.BackColor = &H8000000A Or Tent1_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent1_1.BackColor = vbBlack
   RispTent1_2.BackColor = vbBlack
   RispTent1_3.BackColor = vbBlack
   RispTent1_4.BackColor = vbBlack
   RispTent1_5.BackColor = vbBlack
Else
   
   '* provo prima a vedere se ci sono i colori nelle posizioni *
   '* e poi proverò se ci sono nelle posizioni sbagliate *
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   '* controllo il primo colore inserito nel primo cerchietto *
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
    '* controllo il secondo colore inserito nel secondo cerchietto *
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
    '* controllo il terzo colore inserito nel terzo cerchietto *
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
    '* controllo il quarto colore inserito nel quarto cerchietto *
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
    '* controllo il quinto colore inserito nel quinto cerchietto *
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent1_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent1_1.BackColor = vbBlack
      RispTent1_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent1_1.BackColor = vbBlack
      RispTent1_2.BackColor = vbBlack
      RispTent1_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent1_1.BackColor = vbBlack
      RispTent1_2.BackColor = vbBlack
      RispTent1_3.BackColor = vbBlack
      RispTent1_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent1_1.BackColor = &H8000000D Then
         RispTent1_1.BackColor = vbWhite
      ElseIf RispTent1_2.BackColor = &H8000000D Then
         RispTent1_2.BackColor = vbWhite
      ElseIf RispTent1_3.BackColor = &H8000000D Then
         RispTent1_3.BackColor = vbWhite
      ElseIf RispTent1_4.BackColor = &H8000000D Then
         RispTent1_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent1_1.BackColor = &H8000000D Then
         RispTent1_1.BackColor = vbWhite
         RispTent1_2.BackColor = vbWhite
      ElseIf RispTent1_2.BackColor = &H8000000D Then
         RispTent1_2.BackColor = vbWhite
         RispTent1_3.BackColor = vbWhite
      ElseIf RispTent1_3.BackColor = &H8000000D Then
         RispTent1_3.BackColor = vbWhite
         RispTent1_4.BackColor = vbWhite
      ElseIf RispTent1_4.BackColor = &H8000000D Then
         RispTent1_4.BackColor = vbWhite
         RispTent1_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent1_1.BackColor = &H8000000D Then
         RispTent1_1.BackColor = vbWhite
         RispTent1_2.BackColor = vbWhite
         RispTent1_3.BackColor = vbWhite
      ElseIf RispTent1_2.BackColor = &H8000000D Then
         RispTent1_2.BackColor = vbWhite
         RispTent1_3.BackColor = vbWhite
         RispTent1_4.BackColor = vbWhite
      ElseIf RispTent1_3.BackColor = &H8000000D Then
         RispTent1_3.BackColor = vbWhite
         RispTent1_4.BackColor = vbWhite
         RispTent1_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent1_1.BackColor = &H8000000D Then
         RispTent1_1.BackColor = vbWhite
         RispTent1_2.BackColor = vbWhite
         RispTent1_3.BackColor = vbWhite
         RispTent1_4.BackColor = vbWhite
      ElseIf RispTent1_2.BackColor = &H8000000D Then
         RispTent1_2.BackColor = vbWhite
         RispTent1_3.BackColor = vbWhite
         RispTent1_4.BackColor = vbWhite
         RispTent1_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent1_1.BackColor = vbWhite
      RispTent1_2.BackColor = vbWhite
      RispTent1_3.BackColor = vbWhite
      RispTent1_4.BackColor = vbWhite
      RispTent1_5.BackColor = vbWhite
   End If
   
   LabTent1_1.Enabled = False
   LabTent1_2.Enabled = False
   LabTent1_3.Enabled = False
   LabTent1_4.Enabled = False
   LabTent1_5.Enabled = False
   
   LabTent2_1.Enabled = True
   LabTent2_2.Enabled = True
   LabTent2_3.Enabled = True
   LabTent2_4.Enabled = True
   LabTent2_5.Enabled = True
   
   Command1.Visible = False
   Command2.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
   
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command10_Click()
If Tent10_1.BackColor = &H8000000A Or Tent10_2.BackColor = &H8000000A Or Tent10_3.BackColor = &H8000000A Or Tent10_4.BackColor = &H8000000A Or Tent10_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent10_1.BackColor = vbBlack
   RispTent10_2.BackColor = vbBlack
   RispTent10_3.BackColor = vbBlack
   RispTent10_4.BackColor = vbBlack
   RispTent10_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent10_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent10_1.BackColor = vbBlack
      RispTent10_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent10_1.BackColor = vbBlack
      RispTent10_2.BackColor = vbBlack
      RispTent10_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent10_1.BackColor = vbBlack
      RispTent10_2.BackColor = vbBlack
      RispTent10_3.BackColor = vbBlack
      RispTent10_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent10_1.BackColor = &H8000000D Then
         RispTent10_1.BackColor = vbWhite
      ElseIf RispTent10_2.BackColor = &H8000000D Then
         RispTent10_2.BackColor = vbWhite
      ElseIf RispTent10_3.BackColor = &H8000000D Then
         RispTent10_3.BackColor = vbWhite
      ElseIf RispTent10_4.BackColor = &H8000000D Then
         RispTent10_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent10_1.BackColor = &H8000000D Then
         RispTent10_1.BackColor = vbWhite
         RispTent10_2.BackColor = vbWhite
      ElseIf RispTent10_2.BackColor = &H8000000D Then
         RispTent10_2.BackColor = vbWhite
         RispTent10_3.BackColor = vbWhite
      ElseIf RispTent10_3.BackColor = &H8000000D Then
         RispTent10_3.BackColor = vbWhite
         RispTent10_4.BackColor = vbWhite
      ElseIf RispTent10_4.BackColor = &H8000000D Then
         RispTent10_4.BackColor = vbWhite
         RispTent10_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent10_1.BackColor = &H8000000D Then
         RispTent10_1.BackColor = vbWhite
         RispTent10_2.BackColor = vbWhite
         RispTent10_3.BackColor = vbWhite
      ElseIf RispTent10_2.BackColor = &H8000000D Then
         RispTent10_2.BackColor = vbWhite
         RispTent10_3.BackColor = vbWhite
         RispTent10_4.BackColor = vbWhite
      ElseIf RispTent10_3.BackColor = &H8000000D Then
         RispTent10_3.BackColor = vbWhite
         RispTent10_4.BackColor = vbWhite
         RispTent10_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent10_1.BackColor = &H8000000D Then
         RispTent10_1.BackColor = vbWhite
         RispTent10_2.BackColor = vbWhite
         RispTent10_3.BackColor = vbWhite
         RispTent10_4.BackColor = vbWhite
      ElseIf RispTent10_2.BackColor = &H8000000D Then
         RispTent10_2.BackColor = vbWhite
         RispTent10_3.BackColor = vbWhite
         RispTent10_4.BackColor = vbWhite
         RispTent10_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent10_1.BackColor = vbWhite
      RispTent10_2.BackColor = vbWhite
      RispTent10_3.BackColor = vbWhite
      RispTent10_4.BackColor = vbWhite
      RispTent10_5.BackColor = vbWhite
   End If
   
   LabTent10_1.Enabled = False
   LabTent10_2.Enabled = False
   LabTent10_3.Enabled = False
   LabTent10_4.Enabled = False
   LabTent10_5.Enabled = False
   
   LabTent11_1.Enabled = True
   LabTent11_2.Enabled = True
   LabTent11_3.Enabled = True
   LabTent11_4.Enabled = True
   LabTent11_5.Enabled = True
   
   Command10.Visible = False
   Command11.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
  
   Neri = 0
   Bianchi = 0
      
End If
End Sub

Private Sub Command11_Click()
If Tent11_1.BackColor = &H8000000A Or Tent11_2.BackColor = &H8000000A Or Tent11_3.BackColor = &H8000000A Or Tent11_4.BackColor = &H8000000A Or Tent11_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent11_1.BackColor = vbBlack
   RispTent11_2.BackColor = vbBlack
   RispTent11_3.BackColor = vbBlack
   RispTent11_4.BackColor = vbBlack
   RispTent11_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent11_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent11_1.BackColor = vbBlack
      RispTent11_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent11_1.BackColor = vbBlack
      RispTent11_2.BackColor = vbBlack
      RispTent11_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent11_1.BackColor = vbBlack
      RispTent11_2.BackColor = vbBlack
      RispTent11_3.BackColor = vbBlack
      RispTent11_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent11_1.BackColor = &H8000000D Then
         RispTent11_1.BackColor = vbWhite
      ElseIf RispTent11_2.BackColor = &H8000000D Then
         RispTent11_2.BackColor = vbWhite
      ElseIf RispTent11_3.BackColor = &H8000000D Then
         RispTent11_3.BackColor = vbWhite
      ElseIf RispTent11_4.BackColor = &H8000000D Then
         RispTent11_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent11_1.BackColor = &H8000000D Then
         RispTent11_1.BackColor = vbWhite
         RispTent11_2.BackColor = vbWhite
      ElseIf RispTent11_2.BackColor = &H8000000D Then
         RispTent11_2.BackColor = vbWhite
         RispTent11_3.BackColor = vbWhite
      ElseIf RispTent11_3.BackColor = &H8000000D Then
         RispTent11_3.BackColor = vbWhite
         RispTent11_4.BackColor = vbWhite
      ElseIf RispTent11_4.BackColor = &H8000000D Then
         RispTent11_4.BackColor = vbWhite
         RispTent11_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent11_1.BackColor = &H8000000D Then
         RispTent11_1.BackColor = vbWhite
         RispTent11_2.BackColor = vbWhite
         RispTent11_3.BackColor = vbWhite
      ElseIf RispTent11_2.BackColor = &H8000000D Then
         RispTent11_2.BackColor = vbWhite
         RispTent11_3.BackColor = vbWhite
         RispTent11_4.BackColor = vbWhite
      ElseIf RispTent11_3.BackColor = &H8000000D Then
         RispTent11_3.BackColor = vbWhite
         RispTent11_4.BackColor = vbWhite
         RispTent11_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent11_1.BackColor = &H8000000D Then
         RispTent11_1.BackColor = vbWhite
         RispTent11_2.BackColor = vbWhite
         RispTent11_3.BackColor = vbWhite
         RispTent11_4.BackColor = vbWhite
      ElseIf RispTent11_2.BackColor = &H8000000D Then
         RispTent11_2.BackColor = vbWhite
         RispTent11_3.BackColor = vbWhite
         RispTent11_4.BackColor = vbWhite
         RispTent11_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent11_1.BackColor = vbWhite
      RispTent11_2.BackColor = vbWhite
      RispTent11_3.BackColor = vbWhite
      RispTent11_4.BackColor = vbWhite
      RispTent11_5.BackColor = vbWhite
   End If
   
   LabTent11_1.Enabled = False
   LabTent11_2.Enabled = False
   LabTent11_3.Enabled = False
   LabTent11_4.Enabled = False
   LabTent11_5.Enabled = False
   
   LabTent12_1.Enabled = True
   LabTent12_2.Enabled = True
   LabTent12_3.Enabled = True
   LabTent12_4.Enabled = True
   LabTent12_5.Enabled = True
   
   Command11.Visible = False
   Command12.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
 
   Neri = 0
   Bianchi = 0

End If
End Sub

Private Sub Command12_Click()
If Tent12_1.BackColor = &H8000000A Or Tent12_2.BackColor = &H8000000A Or Tent12_3.BackColor = &H8000000A Or Tent12_4.BackColor = &H8000000A Or Tent12_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent12_1.BackColor = vbBlack
   RispTent12_2.BackColor = vbBlack
   RispTent12_3.BackColor = vbBlack
   RispTent12_4.BackColor = vbBlack
   RispTent12_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent12_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent12_1.BackColor = vbBlack
      RispTent12_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent12_1.BackColor = vbBlack
      RispTent12_2.BackColor = vbBlack
      RispTent12_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent12_1.BackColor = vbBlack
      RispTent12_2.BackColor = vbBlack
      RispTent12_3.BackColor = vbBlack
      RispTent12_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent12_1.BackColor = &H8000000D Then
         RispTent12_1.BackColor = vbWhite
      ElseIf RispTent12_2.BackColor = &H8000000D Then
         RispTent12_2.BackColor = vbWhite
      ElseIf RispTent12_3.BackColor = &H8000000D Then
         RispTent12_3.BackColor = vbWhite
      ElseIf RispTent12_4.BackColor = &H8000000D Then
         RispTent12_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent12_1.BackColor = &H8000000D Then
         RispTent12_1.BackColor = vbWhite
         RispTent12_2.BackColor = vbWhite
      ElseIf RispTent12_2.BackColor = &H8000000D Then
         RispTent12_2.BackColor = vbWhite
         RispTent12_3.BackColor = vbWhite
      ElseIf RispTent12_3.BackColor = &H8000000D Then
         RispTent12_3.BackColor = vbWhite
         RispTent12_4.BackColor = vbWhite
      ElseIf RispTent12_4.BackColor = &H8000000D Then
         RispTent12_4.BackColor = vbWhite
         RispTent12_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent12_1.BackColor = &H8000000D Then
         RispTent12_1.BackColor = vbWhite
         RispTent12_2.BackColor = vbWhite
         RispTent12_3.BackColor = vbWhite
      ElseIf RispTent12_2.BackColor = &H8000000D Then
         RispTent12_2.BackColor = vbWhite
         RispTent12_3.BackColor = vbWhite
         RispTent12_4.BackColor = vbWhite
      ElseIf RispTent12_3.BackColor = &H8000000D Then
         RispTent12_3.BackColor = vbWhite
         RispTent12_4.BackColor = vbWhite
         RispTent12_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent12_1.BackColor = &H8000000D Then
         RispTent12_1.BackColor = vbWhite
         RispTent12_2.BackColor = vbWhite
         RispTent12_3.BackColor = vbWhite
         RispTent12_4.BackColor = vbWhite
      ElseIf RispTent12_2.BackColor = &H8000000D Then
         RispTent12_2.BackColor = vbWhite
         RispTent12_3.BackColor = vbWhite
         RispTent12_4.BackColor = vbWhite
         RispTent12_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent12_1.BackColor = vbWhite
      RispTent12_2.BackColor = vbWhite
      RispTent12_3.BackColor = vbWhite
      RispTent12_4.BackColor = vbWhite
      RispTent12_5.BackColor = vbWhite
   End If
   
   LabTent12_1.Enabled = False
   LabTent12_2.Enabled = False
   LabTent12_3.Enabled = False
   LabTent12_4.Enabled = False
   LabTent12_5.Enabled = False
      
   Command12.Visible = False

   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
   
   MsgBox "Soluzione non trovata!", vbCritical, "Soluzione non trovata"
   Form2.NuovaPart_Click
   
End If
End Sub

Private Sub Command2_Click()
If Tent2_1.BackColor = &H8000000A Or Tent2_2.BackColor = &H8000000A Or Tent2_3.BackColor = &H8000000A Or Tent2_4.BackColor = &H8000000A Or Tent2_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent2_1.BackColor = vbBlack
   RispTent2_2.BackColor = vbBlack
   RispTent2_3.BackColor = vbBlack
   RispTent2_4.BackColor = vbBlack
   RispTent2_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent2_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent2_1.BackColor = vbBlack
      RispTent2_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent2_1.BackColor = vbBlack
      RispTent2_2.BackColor = vbBlack
      RispTent2_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent2_1.BackColor = vbBlack
      RispTent2_2.BackColor = vbBlack
      RispTent2_3.BackColor = vbBlack
      RispTent2_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent2_1.BackColor = &H8000000D Then
         RispTent2_1.BackColor = vbWhite
      ElseIf RispTent2_2.BackColor = &H8000000D Then
         RispTent2_2.BackColor = vbWhite
      ElseIf RispTent2_3.BackColor = &H8000000D Then
         RispTent2_3.BackColor = vbWhite
      ElseIf RispTent2_4.BackColor = &H8000000D Then
         RispTent2_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent2_1.BackColor = &H8000000D Then
         RispTent2_1.BackColor = vbWhite
         RispTent2_2.BackColor = vbWhite
      ElseIf RispTent2_2.BackColor = &H8000000D Then
         RispTent2_2.BackColor = vbWhite
         RispTent2_3.BackColor = vbWhite
      ElseIf RispTent2_3.BackColor = &H8000000D Then
         RispTent2_3.BackColor = vbWhite
         RispTent2_4.BackColor = vbWhite
      ElseIf RispTent2_4.BackColor = &H8000000D Then
         RispTent2_4.BackColor = vbWhite
         RispTent2_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent2_1.BackColor = &H8000000D Then
         RispTent2_1.BackColor = vbWhite
         RispTent2_2.BackColor = vbWhite
         RispTent2_3.BackColor = vbWhite
      ElseIf RispTent2_2.BackColor = &H8000000D Then
         RispTent2_2.BackColor = vbWhite
         RispTent2_3.BackColor = vbWhite
         RispTent2_4.BackColor = vbWhite
      ElseIf RispTent2_3.BackColor = &H8000000D Then
         RispTent2_3.BackColor = vbWhite
         RispTent2_4.BackColor = vbWhite
         RispTent2_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent2_1.BackColor = &H8000000D Then
         RispTent2_1.BackColor = vbWhite
         RispTent2_2.BackColor = vbWhite
         RispTent2_3.BackColor = vbWhite
         RispTent2_4.BackColor = vbWhite
      ElseIf RispTent2_2.BackColor = &H8000000D Then
         RispTent2_2.BackColor = vbWhite
         RispTent2_3.BackColor = vbWhite
         RispTent2_4.BackColor = vbWhite
         RispTent2_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent2_1.BackColor = vbWhite
      RispTent2_2.BackColor = vbWhite
      RispTent2_3.BackColor = vbWhite
      RispTent2_4.BackColor = vbWhite
      RispTent2_5.BackColor = vbWhite
   End If
   
   LabTent2_1.Enabled = False
   LabTent2_2.Enabled = False
   LabTent2_3.Enabled = False
   LabTent2_4.Enabled = False
   LabTent2_5.Enabled = False
   
   LabTent3_1.Enabled = True
   LabTent3_2.Enabled = True
   LabTent3_3.Enabled = True
   LabTent3_4.Enabled = True
   LabTent3_5.Enabled = True
   
   Command2.Visible = False
   Command3.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command3_Click()
If Tent3_1.BackColor = &H8000000A Or Tent3_2.BackColor = &H8000000A Or Tent3_3.BackColor = &H8000000A Or Tent3_4.BackColor = &H8000000A Or Tent3_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent3_1.BackColor = vbBlack
   RispTent3_2.BackColor = vbBlack
   RispTent3_3.BackColor = vbBlack
   RispTent3_4.BackColor = vbBlack
   RispTent3_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent3_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent3_1.BackColor = vbBlack
      RispTent3_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent3_1.BackColor = vbBlack
      RispTent3_2.BackColor = vbBlack
      RispTent3_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent3_1.BackColor = vbBlack
      RispTent3_2.BackColor = vbBlack
      RispTent3_3.BackColor = vbBlack
      RispTent3_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent3_1.BackColor = &H8000000D Then
         RispTent3_1.BackColor = vbWhite
      ElseIf RispTent3_2.BackColor = &H8000000D Then
         RispTent3_2.BackColor = vbWhite
      ElseIf RispTent3_3.BackColor = &H8000000D Then
         RispTent3_3.BackColor = vbWhite
      ElseIf RispTent3_4.BackColor = &H8000000D Then
         RispTent3_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent3_1.BackColor = &H8000000D Then
         RispTent3_1.BackColor = vbWhite
         RispTent3_2.BackColor = vbWhite
      ElseIf RispTent3_2.BackColor = &H8000000D Then
         RispTent3_2.BackColor = vbWhite
         RispTent3_3.BackColor = vbWhite
      ElseIf RispTent3_3.BackColor = &H8000000D Then
         RispTent3_3.BackColor = vbWhite
         RispTent3_4.BackColor = vbWhite
      ElseIf RispTent3_4.BackColor = &H8000000D Then
         RispTent3_4.BackColor = vbWhite
         RispTent3_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent3_1.BackColor = &H8000000D Then
         RispTent3_1.BackColor = vbWhite
         RispTent3_2.BackColor = vbWhite
         RispTent3_3.BackColor = vbWhite
      ElseIf RispTent3_2.BackColor = &H8000000D Then
         RispTent3_2.BackColor = vbWhite
         RispTent3_3.BackColor = vbWhite
         RispTent3_4.BackColor = vbWhite
      ElseIf RispTent3_3.BackColor = &H8000000D Then
         RispTent3_3.BackColor = vbWhite
         RispTent3_4.BackColor = vbWhite
         RispTent3_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent3_1.BackColor = &H8000000D Then
         RispTent3_1.BackColor = vbWhite
         RispTent3_2.BackColor = vbWhite
         RispTent3_3.BackColor = vbWhite
         RispTent3_4.BackColor = vbWhite
      ElseIf RispTent3_2.BackColor = &H8000000D Then
         RispTent3_2.BackColor = vbWhite
         RispTent3_3.BackColor = vbWhite
         RispTent3_4.BackColor = vbWhite
         RispTent3_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent3_1.BackColor = vbWhite
      RispTent3_2.BackColor = vbWhite
      RispTent3_3.BackColor = vbWhite
      RispTent3_4.BackColor = vbWhite
      RispTent3_5.BackColor = vbWhite
   End If
   
   LabTent3_1.Enabled = False
   LabTent3_2.Enabled = False
   LabTent3_3.Enabled = False
   LabTent3_4.Enabled = False
   LabTent3_5.Enabled = False
   
   LabTent4_1.Enabled = True
   LabTent4_2.Enabled = True
   LabTent4_3.Enabled = True
   LabTent4_4.Enabled = True
   LabTent4_5.Enabled = True
   
   Command3.Visible = False
   Command4.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command4_Click()
If Tent4_1.BackColor = &H8000000A Or Tent4_2.BackColor = &H8000000A Or Tent4_3.BackColor = &H8000000A Or Tent4_4.BackColor = &H8000000A Or Tent4_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent4_1.BackColor = vbBlack
   RispTent4_2.BackColor = vbBlack
   RispTent4_3.BackColor = vbBlack
   RispTent4_4.BackColor = vbBlack
   RispTent4_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent4_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent4_1.BackColor = vbBlack
      RispTent4_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent4_1.BackColor = vbBlack
      RispTent4_2.BackColor = vbBlack
      RispTent4_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent4_1.BackColor = vbBlack
      RispTent4_2.BackColor = vbBlack
      RispTent4_3.BackColor = vbBlack
      RispTent4_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent4_1.BackColor = &H8000000D Then
         RispTent4_1.BackColor = vbWhite
      ElseIf RispTent4_2.BackColor = &H8000000D Then
         RispTent4_2.BackColor = vbWhite
      ElseIf RispTent4_3.BackColor = &H8000000D Then
         RispTent4_3.BackColor = vbWhite
      ElseIf RispTent4_4.BackColor = &H8000000D Then
         RispTent4_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent4_1.BackColor = &H8000000D Then
         RispTent4_1.BackColor = vbWhite
         RispTent4_2.BackColor = vbWhite
      ElseIf RispTent4_2.BackColor = &H8000000D Then
         RispTent4_2.BackColor = vbWhite
         RispTent4_3.BackColor = vbWhite
      ElseIf RispTent4_3.BackColor = &H8000000D Then
         RispTent4_3.BackColor = vbWhite
         RispTent4_4.BackColor = vbWhite
      ElseIf RispTent4_4.BackColor = &H8000000D Then
         RispTent4_4.BackColor = vbWhite
         RispTent4_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent4_1.BackColor = &H8000000D Then
         RispTent4_1.BackColor = vbWhite
         RispTent4_2.BackColor = vbWhite
         RispTent4_3.BackColor = vbWhite
      ElseIf RispTent4_2.BackColor = &H8000000D Then
         RispTent4_2.BackColor = vbWhite
         RispTent4_3.BackColor = vbWhite
         RispTent4_4.BackColor = vbWhite
      ElseIf RispTent4_3.BackColor = &H8000000D Then
         RispTent4_3.BackColor = vbWhite
         RispTent4_4.BackColor = vbWhite
         RispTent4_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent4_1.BackColor = &H8000000D Then
         RispTent4_1.BackColor = vbWhite
         RispTent4_2.BackColor = vbWhite
         RispTent4_3.BackColor = vbWhite
         RispTent4_4.BackColor = vbWhite
      ElseIf RispTent4_2.BackColor = &H8000000D Then
         RispTent4_2.BackColor = vbWhite
         RispTent4_3.BackColor = vbWhite
         RispTent4_4.BackColor = vbWhite
         RispTent4_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent4_1.BackColor = vbWhite
      RispTent4_2.BackColor = vbWhite
      RispTent4_3.BackColor = vbWhite
      RispTent4_4.BackColor = vbWhite
      RispTent4_5.BackColor = vbWhite
   End If
   
   LabTent4_1.Enabled = False
   LabTent4_2.Enabled = False
   LabTent4_3.Enabled = False
   LabTent4_4.Enabled = False
   LabTent4_5.Enabled = False
   
   LabTent5_1.Enabled = True
   LabTent5_2.Enabled = True
   LabTent5_3.Enabled = True
   LabTent5_4.Enabled = True
   LabTent5_5.Enabled = True
   
   Command4.Visible = False
   Command5.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command5_Click()
If Tent5_1.BackColor = &H8000000A Or Tent5_2.BackColor = &H8000000A Or Tent5_3.BackColor = &H8000000A Or Tent5_4.BackColor = &H8000000A Or Tent5_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent5_1.BackColor = vbBlack
   RispTent5_2.BackColor = vbBlack
   RispTent5_3.BackColor = vbBlack
   RispTent5_4.BackColor = vbBlack
   RispTent5_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent5_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent5_1.BackColor = vbBlack
      RispTent5_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent5_1.BackColor = vbBlack
      RispTent5_2.BackColor = vbBlack
      RispTent5_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent5_1.BackColor = vbBlack
      RispTent5_2.BackColor = vbBlack
      RispTent5_3.BackColor = vbBlack
      RispTent5_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent5_1.BackColor = &H8000000D Then
         RispTent5_1.BackColor = vbWhite
      ElseIf RispTent5_2.BackColor = &H8000000D Then
         RispTent5_2.BackColor = vbWhite
      ElseIf RispTent5_3.BackColor = &H8000000D Then
         RispTent5_3.BackColor = vbWhite
      ElseIf RispTent5_4.BackColor = &H8000000D Then
         RispTent5_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent5_1.BackColor = &H8000000D Then
         RispTent5_1.BackColor = vbWhite
         RispTent5_2.BackColor = vbWhite
      ElseIf RispTent5_2.BackColor = &H8000000D Then
         RispTent5_2.BackColor = vbWhite
         RispTent5_3.BackColor = vbWhite
      ElseIf RispTent5_3.BackColor = &H8000000D Then
         RispTent5_3.BackColor = vbWhite
         RispTent5_4.BackColor = vbWhite
      ElseIf RispTent5_4.BackColor = &H8000000D Then
         RispTent5_4.BackColor = vbWhite
         RispTent5_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent5_1.BackColor = &H8000000D Then
         RispTent5_1.BackColor = vbWhite
         RispTent5_2.BackColor = vbWhite
         RispTent5_3.BackColor = vbWhite
      ElseIf RispTent5_2.BackColor = &H8000000D Then
         RispTent5_2.BackColor = vbWhite
         RispTent5_3.BackColor = vbWhite
         RispTent5_4.BackColor = vbWhite
      ElseIf RispTent5_3.BackColor = &H8000000D Then
         RispTent5_3.BackColor = vbWhite
         RispTent5_4.BackColor = vbWhite
         RispTent5_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent5_1.BackColor = &H8000000D Then
         RispTent5_1.BackColor = vbWhite
         RispTent5_2.BackColor = vbWhite
         RispTent5_3.BackColor = vbWhite
         RispTent5_4.BackColor = vbWhite
      ElseIf RispTent5_2.BackColor = &H8000000D Then
         RispTent5_2.BackColor = vbWhite
         RispTent5_3.BackColor = vbWhite
         RispTent5_4.BackColor = vbWhite
         RispTent5_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent5_1.BackColor = vbWhite
      RispTent5_2.BackColor = vbWhite
      RispTent5_3.BackColor = vbWhite
      RispTent5_4.BackColor = vbWhite
      RispTent5_5.BackColor = vbWhite
   End If
   
   LabTent5_1.Enabled = False
   LabTent5_2.Enabled = False
   LabTent5_3.Enabled = False
   LabTent5_4.Enabled = False
   LabTent5_5.Enabled = False
   
   LabTent6_1.Enabled = True
   LabTent6_2.Enabled = True
   LabTent6_3.Enabled = True
   LabTent6_4.Enabled = True
   LabTent6_5.Enabled = True
   
   Command5.Visible = False
   Command6.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A

   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command6_Click()
If Tent6_1.BackColor = &H8000000A Or Tent6_2.BackColor = &H8000000A Or Tent6_3.BackColor = &H8000000A Or Tent6_4.BackColor = &H8000000A Or Tent6_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent6_1.BackColor = vbBlack
   RispTent6_2.BackColor = vbBlack
   RispTent6_3.BackColor = vbBlack
   RispTent6_4.BackColor = vbBlack
   RispTent6_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent6_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent6_1.BackColor = vbBlack
      RispTent6_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent6_1.BackColor = vbBlack
      RispTent6_2.BackColor = vbBlack
      RispTent6_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent6_1.BackColor = vbBlack
      RispTent6_2.BackColor = vbBlack
      RispTent6_3.BackColor = vbBlack
      RispTent6_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent6_1.BackColor = &H8000000D Then
         RispTent6_1.BackColor = vbWhite
      ElseIf RispTent6_2.BackColor = &H8000000D Then
         RispTent6_2.BackColor = vbWhite
      ElseIf RispTent6_3.BackColor = &H8000000D Then
         RispTent6_3.BackColor = vbWhite
      ElseIf RispTent6_4.BackColor = &H8000000D Then
         RispTent6_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent6_1.BackColor = &H8000000D Then
         RispTent6_1.BackColor = vbWhite
         RispTent6_2.BackColor = vbWhite
      ElseIf RispTent6_2.BackColor = &H8000000D Then
         RispTent6_2.BackColor = vbWhite
         RispTent6_3.BackColor = vbWhite
      ElseIf RispTent6_3.BackColor = &H8000000D Then
         RispTent6_3.BackColor = vbWhite
         RispTent6_4.BackColor = vbWhite
      ElseIf RispTent6_4.BackColor = &H8000000D Then
         RispTent6_4.BackColor = vbWhite
         RispTent6_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent6_1.BackColor = &H8000000D Then
         RispTent6_1.BackColor = vbWhite
         RispTent6_2.BackColor = vbWhite
         RispTent6_3.BackColor = vbWhite
      ElseIf RispTent6_2.BackColor = &H8000000D Then
         RispTent6_2.BackColor = vbWhite
         RispTent6_3.BackColor = vbWhite
         RispTent6_4.BackColor = vbWhite
      ElseIf RispTent6_3.BackColor = &H8000000D Then
         RispTent6_3.BackColor = vbWhite
         RispTent6_4.BackColor = vbWhite
         RispTent6_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent6_1.BackColor = &H8000000D Then
         RispTent6_1.BackColor = vbWhite
         RispTent6_2.BackColor = vbWhite
         RispTent6_3.BackColor = vbWhite
         RispTent6_4.BackColor = vbWhite
      ElseIf RispTent6_2.BackColor = &H8000000D Then
         RispTent6_2.BackColor = vbWhite
         RispTent6_3.BackColor = vbWhite
         RispTent6_4.BackColor = vbWhite
         RispTent6_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent6_1.BackColor = vbWhite
      RispTent6_2.BackColor = vbWhite
      RispTent6_3.BackColor = vbWhite
      RispTent6_4.BackColor = vbWhite
      RispTent6_5.BackColor = vbWhite
   End If
   
   LabTent6_1.Enabled = False
   LabTent6_2.Enabled = False
   LabTent6_3.Enabled = False
   LabTent6_4.Enabled = False
   LabTent6_5.Enabled = False
   
   LabTent7_1.Enabled = True
   LabTent7_2.Enabled = True
   LabTent7_3.Enabled = True
   LabTent7_4.Enabled = True
   LabTent7_5.Enabled = True
   
   Command6.Visible = False
   Command7.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command7_Click()
If Tent7_1.BackColor = &H8000000A Or Tent7_2.BackColor = &H8000000A Or Tent7_3.BackColor = &H8000000A Or Tent7_4.BackColor = &H8000000A Or Tent7_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent7_1.BackColor = vbBlack
   RispTent7_2.BackColor = vbBlack
   RispTent7_3.BackColor = vbBlack
   RispTent7_4.BackColor = vbBlack
   RispTent7_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent7_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent7_1.BackColor = vbBlack
      RispTent7_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent7_1.BackColor = vbBlack
      RispTent7_2.BackColor = vbBlack
      RispTent7_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent7_1.BackColor = vbBlack
      RispTent7_2.BackColor = vbBlack
      RispTent7_3.BackColor = vbBlack
      RispTent7_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent7_1.BackColor = &H8000000D Then
         RispTent7_1.BackColor = vbWhite
      ElseIf RispTent7_2.BackColor = &H8000000D Then
         RispTent7_2.BackColor = vbWhite
      ElseIf RispTent7_3.BackColor = &H8000000D Then
         RispTent7_3.BackColor = vbWhite
      ElseIf RispTent7_4.BackColor = &H8000000D Then
         RispTent7_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent7_1.BackColor = &H8000000D Then
         RispTent7_1.BackColor = vbWhite
         RispTent7_2.BackColor = vbWhite
      ElseIf RispTent7_2.BackColor = &H8000000D Then
         RispTent7_2.BackColor = vbWhite
         RispTent7_3.BackColor = vbWhite
      ElseIf RispTent7_3.BackColor = &H8000000D Then
         RispTent7_3.BackColor = vbWhite
         RispTent7_4.BackColor = vbWhite
      ElseIf RispTent7_4.BackColor = &H8000000D Then
         RispTent7_4.BackColor = vbWhite
         RispTent7_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent7_1.BackColor = &H8000000D Then
         RispTent7_1.BackColor = vbWhite
         RispTent7_2.BackColor = vbWhite
         RispTent7_3.BackColor = vbWhite
      ElseIf RispTent7_2.BackColor = &H8000000D Then
         RispTent7_2.BackColor = vbWhite
         RispTent7_3.BackColor = vbWhite
         RispTent7_4.BackColor = vbWhite
      ElseIf RispTent7_3.BackColor = &H8000000D Then
         RispTent7_3.BackColor = vbWhite
         RispTent7_4.BackColor = vbWhite
         RispTent7_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent7_1.BackColor = &H8000000D Then
         RispTent7_1.BackColor = vbWhite
         RispTent7_2.BackColor = vbWhite
         RispTent7_3.BackColor = vbWhite
         RispTent7_4.BackColor = vbWhite
      ElseIf RispTent7_2.BackColor = &H8000000D Then
         RispTent7_2.BackColor = vbWhite
         RispTent7_3.BackColor = vbWhite
         RispTent7_4.BackColor = vbWhite
         RispTent7_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent7_1.BackColor = vbWhite
      RispTent7_2.BackColor = vbWhite
      RispTent7_3.BackColor = vbWhite
      RispTent7_4.BackColor = vbWhite
      RispTent7_5.BackColor = vbWhite
   End If
   
   LabTent7_1.Enabled = False
   LabTent7_2.Enabled = False
   LabTent7_3.Enabled = False
   LabTent7_4.Enabled = False
   LabTent7_5.Enabled = False
   
   LabTent8_1.Enabled = True
   LabTent8_2.Enabled = True
   LabTent8_3.Enabled = True
   LabTent8_4.Enabled = True
   LabTent8_5.Enabled = True
   
   Command7.Visible = False
   Command8.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
  
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command8_Click()
If Tent8_1.BackColor = &H8000000A Or Tent8_2.BackColor = &H8000000A Or Tent8_3.BackColor = &H8000000A Or Tent8_4.BackColor = &H8000000A Or Tent8_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent8_1.BackColor = vbBlack
   RispTent8_2.BackColor = vbBlack
   RispTent8_3.BackColor = vbBlack
   RispTent8_4.BackColor = vbBlack
   RispTent8_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent8_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent8_1.BackColor = vbBlack
      RispTent8_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent8_1.BackColor = vbBlack
      RispTent8_2.BackColor = vbBlack
      RispTent8_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent8_1.BackColor = vbBlack
      RispTent8_2.BackColor = vbBlack
      RispTent8_3.BackColor = vbBlack
      RispTent8_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent8_1.BackColor = &H8000000D Then
         RispTent8_1.BackColor = vbWhite
      ElseIf RispTent8_2.BackColor = &H8000000D Then
         RispTent8_2.BackColor = vbWhite
      ElseIf RispTent8_3.BackColor = &H8000000D Then
         RispTent8_3.BackColor = vbWhite
      ElseIf RispTent8_4.BackColor = &H8000000D Then
         RispTent8_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent8_1.BackColor = &H8000000D Then
         RispTent8_1.BackColor = vbWhite
         RispTent8_2.BackColor = vbWhite
      ElseIf RispTent8_2.BackColor = &H8000000D Then
         RispTent8_2.BackColor = vbWhite
         RispTent8_3.BackColor = vbWhite
      ElseIf RispTent8_3.BackColor = &H8000000D Then
         RispTent8_3.BackColor = vbWhite
         RispTent8_4.BackColor = vbWhite
      ElseIf RispTent8_4.BackColor = &H8000000D Then
         RispTent8_4.BackColor = vbWhite
         RispTent8_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent8_1.BackColor = &H8000000D Then
         RispTent8_1.BackColor = vbWhite
         RispTent8_2.BackColor = vbWhite
         RispTent8_3.BackColor = vbWhite
      ElseIf RispTent8_2.BackColor = &H8000000D Then
         RispTent8_2.BackColor = vbWhite
         RispTent8_3.BackColor = vbWhite
         RispTent8_4.BackColor = vbWhite
      ElseIf RispTent8_3.BackColor = &H8000000D Then
         RispTent8_3.BackColor = vbWhite
         RispTent8_4.BackColor = vbWhite
         RispTent8_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent8_1.BackColor = &H8000000D Then
         RispTent8_1.BackColor = vbWhite
         RispTent8_2.BackColor = vbWhite
         RispTent8_3.BackColor = vbWhite
         RispTent8_4.BackColor = vbWhite
      ElseIf RispTent8_2.BackColor = &H8000000D Then
         RispTent8_2.BackColor = vbWhite
         RispTent8_3.BackColor = vbWhite
         RispTent8_4.BackColor = vbWhite
         RispTent8_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent8_1.BackColor = vbWhite
      RispTent8_2.BackColor = vbWhite
      RispTent8_3.BackColor = vbWhite
      RispTent8_4.BackColor = vbWhite
      RispTent8_5.BackColor = vbWhite
   End If
   
   LabTent8_1.Enabled = False
   LabTent8_2.Enabled = False
   LabTent8_3.Enabled = False
   LabTent8_4.Enabled = False
   LabTent8_5.Enabled = False

   LabTent9_1.Enabled = True
   LabTent9_2.Enabled = True
   LabTent9_3.Enabled = True
   LabTent9_4.Enabled = True
   LabTent9_5.Enabled = True
   
   Command8.Visible = False
   Command9.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
 
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Command9_Click()
If Tent9_1.BackColor = &H8000000A Or Tent9_2.BackColor = &H8000000A Or Tent9_3.BackColor = &H8000000A Or Tent9_4.BackColor = &H8000000A Or Tent9_5.BackColor = &H8000000A Then
   MsgBox "Inserire tutti i colori!!!", vbCritical, "Inserire colori"
ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 _
    And T5 = Color5 Then
   Form2.Show
   Soluz_Click
   RispTent9_1.BackColor = vbBlack
   RispTent9_2.BackColor = vbBlack
   RispTent9_3.BackColor = vbBlack
   RispTent9_4.BackColor = vbBlack
   RispTent9_5.BackColor = vbBlack
Else
   
   If T1 = Color1 Then
      Neri = Neri + 1
      Color1a = True
      A1 = True
   End If
   If T2 = Color2 Then
      Neri = Neri + 1
      Color2a = True
      A2 = True
   End If
   If T3 = Color3 Then
      Neri = Neri + 1
      Color3a = True
      A3 = True
   End If
   If T4 = Color4 Then
      Neri = Neri + 1
      Color4a = True
      A4 = True
   End If
   If T5 = Color5 Then
      Neri = Neri + 1
      Color5a = True
      A5 = True
   End If
   
   If A1 = False Then
      If T1 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T1 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T1 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T1 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A2 = False Then
      If T2 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T2 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T2 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T2 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
    
   If A3 = False Then
      If T3 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T3 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T3 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      ElseIf T3 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A4 = False Then
      If T4 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T4 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T4 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T4 = Color5 And Color5a = False Then
         Bianchi = Bianchi + 1
         Color5a = True
      End If
   Else
   End If
   
   If A5 = False Then
      If T5 = Color1 And Color1a = False Then
         Bianchi = Bianchi + 1
         Color1a = True
      ElseIf T5 = Color2 And Color2a = False Then
         Bianchi = Bianchi + 1
         Color2a = True
      ElseIf T5 = Color3 And Color3a = False Then
         Bianchi = Bianchi + 1
         Color3a = True
      ElseIf T5 = Color4 And Color4a = False Then
         Bianchi = Bianchi + 1
         Color4a = True
      End If
   Else
   End If
   
   If Neri = 1 Then
      RispTent9_1.BackColor = vbBlack
   ElseIf Neri = 2 Then
      RispTent9_1.BackColor = vbBlack
      RispTent9_2.BackColor = vbBlack
   ElseIf Neri = 3 Then
      RispTent9_1.BackColor = vbBlack
      RispTent9_2.BackColor = vbBlack
      RispTent9_3.BackColor = vbBlack
   ElseIf Neri = 4 Then
      RispTent9_1.BackColor = vbBlack
      RispTent9_2.BackColor = vbBlack
      RispTent9_3.BackColor = vbBlack
      RispTent9_4.BackColor = vbBlack
   End If
   
   If Bianchi = 1 Then
      If RispTent9_1.BackColor = &H8000000D Then
         RispTent9_1.BackColor = vbWhite
      ElseIf RispTent9_2.BackColor = &H8000000D Then
         RispTent9_2.BackColor = vbWhite
      ElseIf RispTent9_3.BackColor = &H8000000D Then
         RispTent9_3.BackColor = vbWhite
      ElseIf RispTent9_4.BackColor = &H8000000D Then
         RispTent9_4.BackColor = vbWhite
      End If
   ElseIf Bianchi = 2 Then
      If RispTent9_1.BackColor = &H8000000D Then
         RispTent9_1.BackColor = vbWhite
         RispTent9_2.BackColor = vbWhite
      ElseIf RispTent9_2.BackColor = &H8000000D Then
         RispTent9_2.BackColor = vbWhite
         RispTent9_3.BackColor = vbWhite
      ElseIf RispTent9_3.BackColor = &H8000000D Then
         RispTent9_3.BackColor = vbWhite
         RispTent9_4.BackColor = vbWhite
      ElseIf RispTent9_4.BackColor = &H8000000D Then
         RispTent9_4.BackColor = vbWhite
         RispTent9_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 3 Then
      If RispTent9_1.BackColor = &H8000000D Then
         RispTent9_1.BackColor = vbWhite
         RispTent9_2.BackColor = vbWhite
         RispTent9_3.BackColor = vbWhite
      ElseIf RispTent9_2.BackColor = &H8000000D Then
         RispTent9_2.BackColor = vbWhite
         RispTent9_3.BackColor = vbWhite
         RispTent9_4.BackColor = vbWhite
      ElseIf RispTent9_3.BackColor = &H8000000D Then
         RispTent9_3.BackColor = vbWhite
         RispTent9_4.BackColor = vbWhite
         RispTent9_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 4 Then
      If RispTent9_1.BackColor = &H8000000D Then
         RispTent9_1.BackColor = vbWhite
         RispTent9_2.BackColor = vbWhite
         RispTent9_3.BackColor = vbWhite
         RispTent9_4.BackColor = vbWhite
      ElseIf RispTent9_2.BackColor = &H8000000D Then
         RispTent9_2.BackColor = vbWhite
         RispTent9_3.BackColor = vbWhite
         RispTent9_4.BackColor = vbWhite
         RispTent9_5.BackColor = vbWhite
      End If
   ElseIf Bianchi = 5 Then
      RispTent9_1.BackColor = vbWhite
      RispTent9_2.BackColor = vbWhite
      RispTent9_3.BackColor = vbWhite
      RispTent9_4.BackColor = vbWhite
      RispTent9_5.BackColor = vbWhite
   End If
   
   LabTent9_1.Enabled = False
   LabTent9_2.Enabled = False
   LabTent9_3.Enabled = False
   LabTent9_4.Enabled = False
   LabTent9_5.Enabled = False
   
   LabTent10_1.Enabled = True
   LabTent10_2.Enabled = True
   LabTent10_3.Enabled = True
   LabTent10_4.Enabled = True
   LabTent10_5.Enabled = True
   
   Command9.Visible = False
   Command10.Visible = True
      
   Colore = &H8000000A
      
   Color1a = False
   Color2a = False
   Color3a = False
   Color4a = False
   Color5a = False
   A1 = False
   A2 = False
   A3 = False
   A4 = False
   A5 = False
      
   Col1.BorderColor = vbBlack
   Col2.BorderColor = vbBlack
   Col3.BorderColor = vbBlack
   Col4.BorderColor = vbBlack
   Col5.BorderColor = vbBlack
   Col6.BorderColor = vbBlack
   ColScelto.BackColor = &H8000000A
   
   Neri = 0
   Bianchi = 0
End If
End Sub

Private Sub Esci_Click()
Dim Risposta As Integer
Risposta = MsgBox("Sei sicuro di voler uscire?", vbQuestion + vbYesNo, "Uscita")
If Risposta = vbYes Then
   Unload Me
Else
   Form1.Show
End If
End Sub

Private Sub Form_Load()
Colore = &H8000000A
Bianchi = 0
Neri = 0
New_Click
Color1a = False
Color2a = False
Color3a = False
Color4a = False
Color5a = False
A1 = False
A2 = False
A3 = False
A4 = False
A5 = False
Ripetere = False
End Sub


Private Sub Giallo_Click()
Colore = vbYellow
Col2.BorderColor = vbWhite
Col1.BorderColor = vbBlack
Col6.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col5.BorderColor = vbBlack
ColScelto.BackColor = vbYellow
End Sub

Private Sub LabTent1_1_Click()
Tent1_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent1_2_Click()
Tent1_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent1_3_Click()
Tent1_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent1_4_Click()
Tent1_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent1_5_Click()
Tent1_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent10_1_Click()
Tent10_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent10_2_Click()
Tent10_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent10_3_Click()
Tent10_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent10_4_Click()
Tent10_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent10_5_Click()
Tent10_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent11_1_Click()
Tent11_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent11_2_Click()
Tent11_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent11_3_Click()
Tent11_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent11_4_Click()
Tent11_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent11_5_Click()
Tent11_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent12_1_Click()
Tent12_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent12_2_Click()
Tent12_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent12_3_Click()
Tent12_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent12_4_Click()
Tent12_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent12_5_Click()
Tent12_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent2_1_Click()
Tent2_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent2_2_Click()
Tent2_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent2_3_Click()
Tent2_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent2_4_Click()
Tent2_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent2_5_Click()
Tent2_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent3_1_Click()
Tent3_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent3_2_Click()
Tent3_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent3_3_Click()
Tent3_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent3_4_Click()
Tent3_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent3_5_Click()
Tent3_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent4_1_Click()
Tent4_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent4_2_Click()
Tent4_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent4_3_Click()
Tent4_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent4_4_Click()
Tent4_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent4_5_Click()
Tent4_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent5_1_Click()
Tent5_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent5_2_Click()
Tent5_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent5_3_Click()
Tent5_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent5_4_Click()
Tent5_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent5_5_Click()
Tent5_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent6_1_Click()
Tent6_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent6_2_Click()
Tent6_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent6_3_Click()
Tent6_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent6_4_Click()
Tent6_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent6_5_Click()
Tent6_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent7_1_Click()
Tent7_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent7_2_Click()
Tent7_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent7_3_Click()
Tent7_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent7_4_Click()
Tent7_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent7_5_Click()
Tent7_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent8_1_Click()
Tent8_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent8_2_Click()
Tent8_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent8_3_Click()
Tent8_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent8_4_Click()
Tent8_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent8_5_Click()
Tent8_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub

Private Sub LabTent9_1_Click()
Tent9_1.BackColor = Colore
If Colore = vbBlue Then
   T1 = 1
ElseIf Colore = vbYellow Then
   T1 = 2
ElseIf Colore = vbRed Then
   T1 = 3
ElseIf Colore = vbGreen Then
   T1 = 4
ElseIf Colore = vbBlack Then
   T1 = 5
ElseIf Colore = vbWhite Then
   T1 = 6
Else
End If
End Sub

Private Sub LabTent9_2_Click()
Tent9_2.BackColor = Colore
If Colore = vbBlue Then
   T2 = 1
ElseIf Colore = vbYellow Then
   T2 = 2
ElseIf Colore = vbRed Then
   T2 = 3
ElseIf Colore = vbGreen Then
   T2 = 4
ElseIf Colore = vbBlack Then
   T2 = 5
ElseIf Colore = vbWhite Then
   T2 = 6
Else
End If
End Sub

Private Sub LabTent9_3_Click()
Tent9_3.BackColor = Colore
If Colore = vbBlue Then
   T3 = 1
ElseIf Colore = vbYellow Then
   T3 = 2
ElseIf Colore = vbRed Then
   T3 = 3
ElseIf Colore = vbGreen Then
   T3 = 4
ElseIf Colore = vbBlack Then
   T3 = 5
ElseIf Colore = vbWhite Then
   T3 = 6
Else
End If
End Sub

Private Sub LabTent9_4_Click()
Tent9_4.BackColor = Colore
If Colore = vbBlue Then
   T4 = 1
ElseIf Colore = vbYellow Then
   T4 = 2
ElseIf Colore = vbRed Then
   T4 = 3
ElseIf Colore = vbGreen Then
   T4 = 4
ElseIf Colore = vbBlack Then
   T4 = 5
ElseIf Colore = vbWhite Then
   T4 = 6
Else
End If
End Sub

Private Sub LabTent9_5_Click()
Tent9_5.BackColor = Colore
If Colore = vbBlue Then
   T5 = 1
ElseIf Colore = vbYellow Then
   T5 = 2
ElseIf Colore = vbRed Then
   T5 = 3
ElseIf Colore = vbGreen Then
   T5 = 4
ElseIf Colore = vbBlack Then
   T5 = 5
ElseIf Colore = vbWhite Then
   T5 = 6
Else
End If
End Sub





Private Sub mnuAbout_Click()
frmAbout.Show
End Sub

Private Sub mnuEsci_Click()
Esci_Click
End Sub

Private Sub mnuNew_Click()
Nuovo_Click
End Sub

Private Sub mnuVediSoluz_Click()
Soluzione_Click
End Sub

Private Sub Nero_Click()
Colore = vbBlack
Col5.BorderColor = vbWhite
Col1.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col6.BorderColor = vbBlack
ColScelto.BackColor = vbBlack
End Sub


Public Sub New_Click()
Color1 = Rand(1, 6)
Color2 = Rand(1, 6)
Color3 = Rand(1, 6)
Color4 = Rand(1, 6)
Color5 = Rand(1, 6)
R1 = Color1
R2 = Color2
R3 = Color3
R4 = Color4
R5 = Color5

If ((R1 = R2) And (R2 = R3) And (R3 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R3) And (R3 = R4)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R3) And (R3 = R5)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R1 = R3) And (R3 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R2 = R3) And (R3 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R3)) Then
   New_Click
ElseIf ((R1 = R3) And (R3 = R4)) Then
   New_Click
ElseIf ((R1 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R2 = R3) And (R3 = R4)) Then
   New_Click
ElseIf ((R2 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R3 = R4) And (R4 = R5)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R4)) Then
   New_Click
ElseIf ((R1 = R2) And (R2 = R5)) Then
   New_Click
ElseIf ((R1 = R3) And (R3 = R5)) Then
   New_Click
ElseIf ((R2 = R3) And (R3 = R5)) Then
   New_Click
End If

C1.BackColor = &H8000000A
C2.BackColor = &H8000000A
C3.BackColor = &H8000000A
C4.BackColor = &H8000000A
C5.BackColor = &H8000000A

Tent1_1.BackColor = &H8000000A
Tent1_2.BackColor = &H8000000A
Tent1_3.BackColor = &H8000000A
Tent1_4.BackColor = &H8000000A
Tent1_5.BackColor = &H8000000A

Tent2_1.BackColor = &H8000000A
Tent2_2.BackColor = &H8000000A
Tent2_3.BackColor = &H8000000A
Tent2_4.BackColor = &H8000000A
Tent2_5.BackColor = &H8000000A

Tent3_1.BackColor = &H8000000A
Tent3_2.BackColor = &H8000000A
Tent3_3.BackColor = &H8000000A
Tent3_4.BackColor = &H8000000A
Tent3_5.BackColor = &H8000000A

Tent4_1.BackColor = &H8000000A
Tent4_2.BackColor = &H8000000A
Tent4_3.BackColor = &H8000000A
Tent4_4.BackColor = &H8000000A
Tent4_5.BackColor = &H8000000A

Tent5_1.BackColor = &H8000000A
Tent5_2.BackColor = &H8000000A
Tent5_3.BackColor = &H8000000A
Tent5_4.BackColor = &H8000000A
Tent5_5.BackColor = &H8000000A

Tent6_1.BackColor = &H8000000A
Tent6_2.BackColor = &H8000000A
Tent6_3.BackColor = &H8000000A
Tent6_4.BackColor = &H8000000A
Tent6_5.BackColor = &H8000000A

Tent7_1.BackColor = &H8000000A
Tent7_2.BackColor = &H8000000A
Tent7_3.BackColor = &H8000000A
Tent7_4.BackColor = &H8000000A
Tent7_5.BackColor = &H8000000A

Tent8_1.BackColor = &H8000000A
Tent8_2.BackColor = &H8000000A
Tent8_3.BackColor = &H8000000A
Tent8_4.BackColor = &H8000000A
Tent8_5.BackColor = &H8000000A

Tent9_1.BackColor = &H8000000A
Tent9_2.BackColor = &H8000000A
Tent9_3.BackColor = &H8000000A
Tent9_4.BackColor = &H8000000A
Tent9_5.BackColor = &H8000000A

Tent10_1.BackColor = &H8000000A
Tent10_2.BackColor = &H8000000A
Tent10_3.BackColor = &H8000000A
Tent10_4.BackColor = &H8000000A
Tent10_5.BackColor = &H8000000A

Tent11_1.BackColor = &H8000000A
Tent11_2.BackColor = &H8000000A
Tent11_3.BackColor = &H8000000A
Tent11_4.BackColor = &H8000000A
Tent11_5.BackColor = &H8000000A

Tent12_1.BackColor = &H8000000A
Tent12_2.BackColor = &H8000000A
Tent12_3.BackColor = &H8000000A
Tent12_4.BackColor = &H8000000A
Tent12_5.BackColor = &H8000000A

LabTent1_1.Enabled = True
LabTent1_2.Enabled = True
LabTent1_3.Enabled = True
LabTent1_4.Enabled = True
LabTent1_5.Enabled = True

LabTent2_1.Enabled = False
LabTent2_2.Enabled = False
LabTent2_3.Enabled = False
LabTent2_4.Enabled = False
LabTent2_5.Enabled = False

LabTent3_1.Enabled = False
LabTent3_2.Enabled = False
LabTent3_3.Enabled = False
LabTent3_4.Enabled = False
LabTent3_5.Enabled = False

LabTent4_1.Enabled = False
LabTent4_2.Enabled = False
LabTent4_3.Enabled = False
LabTent4_4.Enabled = False
LabTent4_5.Enabled = False

LabTent5_1.Enabled = False
LabTent5_2.Enabled = False
LabTent5_3.Enabled = False
LabTent5_4.Enabled = False
LabTent5_5.Enabled = False

LabTent6_1.Enabled = False
LabTent6_2.Enabled = False
LabTent6_3.Enabled = False
LabTent6_4.Enabled = False
LabTent6_5.Enabled = False

LabTent7_1.Enabled = False
LabTent7_2.Enabled = False
LabTent7_3.Enabled = False
LabTent7_4.Enabled = False
LabTent7_5.Enabled = False

LabTent8_1.Enabled = False
LabTent8_2.Enabled = False
LabTent8_3.Enabled = False
LabTent8_4.Enabled = False
LabTent8_5.Enabled = False

LabTent9_1.Enabled = False
LabTent9_2.Enabled = False
LabTent9_3.Enabled = False
LabTent9_4.Enabled = False
LabTent9_5.Enabled = False

LabTent10_1.Enabled = False
LabTent10_2.Enabled = False
LabTent10_3.Enabled = False
LabTent10_4.Enabled = False
LabTent10_5.Enabled = False

LabTent11_1.Enabled = False
LabTent11_2.Enabled = False
LabTent11_3.Enabled = False
LabTent11_4.Enabled = False
LabTent11_5.Enabled = False

LabTent12_1.Enabled = False
LabTent12_2.Enabled = False
LabTent12_3.Enabled = False
LabTent12_4.Enabled = False
LabTent12_5.Enabled = False

Command1.Visible = True
Command2.Visible = False
Command3.Visible = False
Command4.Visible = False
Command5.Visible = False
Command6.Visible = False
Command7.Visible = False
Command8.Visible = False
Command9.Visible = False
Command10.Visible = False
Command11.Visible = False
Command12.Visible = False

RispTent1_1.BackColor = &H8000000D
RispTent1_2.BackColor = &H8000000D
RispTent1_3.BackColor = &H8000000D
RispTent1_4.BackColor = &H8000000D
RispTent1_5.BackColor = &H8000000D

RispTent2_1.BackColor = &H8000000D
RispTent2_2.BackColor = &H8000000D
RispTent2_3.BackColor = &H8000000D
RispTent2_4.BackColor = &H8000000D
RispTent2_5.BackColor = &H8000000D

RispTent3_1.BackColor = &H8000000D
RispTent3_2.BackColor = &H8000000D
RispTent3_3.BackColor = &H8000000D
RispTent3_4.BackColor = &H8000000D
RispTent3_5.BackColor = &H8000000D

RispTent4_1.BackColor = &H8000000D
RispTent4_2.BackColor = &H8000000D
RispTent4_3.BackColor = &H8000000D
RispTent4_4.BackColor = &H8000000D
RispTent4_5.BackColor = &H8000000D

RispTent5_1.BackColor = &H8000000D
RispTent5_2.BackColor = &H8000000D
RispTent5_3.BackColor = &H8000000D
RispTent5_4.BackColor = &H8000000D
RispTent5_5.BackColor = &H8000000D

RispTent6_1.BackColor = &H8000000D
RispTent6_2.BackColor = &H8000000D
RispTent6_3.BackColor = &H8000000D
RispTent6_4.BackColor = &H8000000D
RispTent6_5.BackColor = &H8000000D

RispTent7_1.BackColor = &H8000000D
RispTent7_2.BackColor = &H8000000D
RispTent7_3.BackColor = &H8000000D
RispTent7_4.BackColor = &H8000000D
RispTent7_5.BackColor = &H8000000D

RispTent8_1.BackColor = &H8000000D
RispTent8_2.BackColor = &H8000000D
RispTent8_3.BackColor = &H8000000D
RispTent8_4.BackColor = &H8000000D
RispTent8_5.BackColor = &H8000000D

RispTent9_1.BackColor = &H8000000D
RispTent9_2.BackColor = &H8000000D
RispTent9_3.BackColor = &H8000000D
RispTent9_4.BackColor = &H8000000D
RispTent9_5.BackColor = &H8000000D

RispTent10_1.BackColor = &H8000000D
RispTent10_2.BackColor = &H8000000D
RispTent10_3.BackColor = &H8000000D
RispTent10_4.BackColor = &H8000000D
RispTent10_5.BackColor = &H8000000D

RispTent11_1.BackColor = &H8000000D
RispTent11_2.BackColor = &H8000000D
RispTent11_3.BackColor = &H8000000D
RispTent11_4.BackColor = &H8000000D
RispTent11_5.BackColor = &H8000000D

RispTent12_1.BackColor = &H8000000D
RispTent12_2.BackColor = &H8000000D
RispTent12_3.BackColor = &H8000000D
RispTent12_4.BackColor = &H8000000D
RispTent12_5.BackColor = &H8000000D

Colore = &H8000000A
      
Color1a = False
Color2a = False
Color3a = False
Color4a = False
Color5a = False
A1 = False
A2 = False
A3 = False
A4 = False
A5 = False
      
Col1.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col5.BorderColor = vbBlack
Col6.BorderColor = vbBlack
ColScelto.BackColor = &H8000000A
  
Neri = 0
Bianchi = 0
End Sub

Private Sub Nuovo_Click()
Dim Risposta As Integer
Risposta = MsgBox("Sei sicuro di chiudere questa partita e aprirne una nuova?", vbQuestion + vbYesNo, "Nuova partita")
If Risposta = vbYes Then
   New_Click
End If
End Sub

Private Sub Rosso_Click()
Colore = vbRed
Col3.BorderColor = vbWhite
Col1.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col6.BorderColor = vbBlack
Col4.BorderColor = vbBlack
Col5.BorderColor = vbBlack
ColScelto.BackColor = vbRed
End Sub

Private Sub Soluz_Click()
   If R1 = 1 Then
      C1.BackColor = vbBlue
   ElseIf R1 = 2 Then
      C1.BackColor = vbYellow
   ElseIf R1 = 3 Then
      C1.BackColor = vbRed
   ElseIf R1 = 4 Then
      C1.BackColor = vbGreen
   ElseIf R1 = 5 Then
      C1.BackColor = vbBlack
   ElseIf R1 = 6 Then
      C1.BackColor = vbWhite
   End If
   
   If R2 = 1 Then
      C2.BackColor = vbBlue
   ElseIf R2 = 2 Then
      C2.BackColor = vbYellow
   ElseIf R2 = 3 Then
      C2.BackColor = vbRed
   ElseIf R2 = 4 Then
      C2.BackColor = vbGreen
   ElseIf R2 = 5 Then
      C2.BackColor = vbBlack
   ElseIf R2 = 6 Then
      C2.BackColor = vbWhite
   End If
   
   If R3 = 1 Then
      C3.BackColor = vbBlue
   ElseIf R3 = 2 Then
      C3.BackColor = vbYellow
   ElseIf R3 = 3 Then
      C3.BackColor = vbRed
   ElseIf R3 = 4 Then
      C3.BackColor = vbGreen
   ElseIf R3 = 5 Then
      C3.BackColor = vbBlack
   ElseIf R3 = 6 Then
      C3.BackColor = vbWhite
   End If
   
   If R4 = 1 Then
      C4.BackColor = vbBlue
   ElseIf R4 = 2 Then
      C4.BackColor = vbYellow
   ElseIf R4 = 3 Then
      C4.BackColor = vbRed
   ElseIf R4 = 4 Then
      C4.BackColor = vbGreen
   ElseIf R4 = 5 Then
      C4.BackColor = vbBlack
   ElseIf R4 = 6 Then
      C4.BackColor = vbWhite
   End If
   
   If R5 = 1 Then
      C5.BackColor = vbBlue
   ElseIf R5 = 2 Then
      C5.BackColor = vbYellow
   ElseIf R5 = 3 Then
      C5.BackColor = vbRed
   ElseIf R5 = 4 Then
      C5.BackColor = vbGreen
   ElseIf R5 = 5 Then
      C5.BackColor = vbBlack
   ElseIf R5 = 6 Then
      C5.BackColor = vbWhite
   End If
End Sub

Private Sub Soluzione_Click()
Dim Risposta As Integer
Risposta = MsgBox("Sei sicuro di voler vedere la soluzione?", vbQuestion + vbYesNo, "Soluzione")
If Risposta = vbYes Then
   Soluz_Click
   Form2.DisableControl_Click
End If
End Sub

Private Sub Verde_Click()
Colore = vbGreen
Col4.BorderColor = vbWhite
Col1.BorderColor = vbBlack
Col2.BorderColor = vbBlack
Col3.BorderColor = vbBlack
Col6.BorderColor = vbBlack
Col5.BorderColor = vbBlack
ColScelto.BackColor = vbGreen
End Sub
