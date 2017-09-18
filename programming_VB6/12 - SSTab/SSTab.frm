VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmSSTab 
   Caption         =   "SSTab Control Demo"
   ClientHeight    =   2715
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6045
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
   ScaleHeight     =   2715
   ScaleWidth      =   6045
   StartUpPosition =   3  'Windows Default
   Begin TabDlg.SSTab SSTab1 
      Height          =   2655
      Left            =   0
      TabIndex        =   19
      Top             =   0
      Width           =   6015
      _ExtentX        =   10610
      _ExtentY        =   4683
      _Version        =   393216
      TabsPerRow      =   9
      TabHeight       =   520
      TabCaption(0)   =   "&First"
      TabPicture(0)   =   "SSTab.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label1"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "Label3"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "txtRequired"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "Frame1"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "txtGeneric"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).ControlCount=   5
      TabCaption(1)   =   "&Second"
      TabPicture(1)   =   "SSTab.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Label2"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "Label4"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).Control(2)=   "txtNumeric"
      Tab(1).Control(2).Enabled=   0   'False
      Tab(1).Control(3)=   "Frame2"
      Tab(1).Control(3).Enabled=   0   'False
      Tab(1).ControlCount=   4
      TabCaption(2)   =   "&Third"
      TabPicture(2)   =   "SSTab.frx":0038
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "Label5"
      Tab(2).Control(0).Enabled=   0   'False
      Tab(2).Control(1)=   "Label6"
      Tab(2).Control(1).Enabled=   0   'False
      Tab(2).Control(2)=   "Text5"
      Tab(2).Control(2).Enabled=   0   'False
      Tab(2).Control(3)=   "Text6"
      Tab(2).Control(3).Enabled=   0   'False
      Tab(2).Control(4)=   "cmdAddTab"
      Tab(2).Control(4).Enabled=   0   'False
      Tab(2).ControlCount=   5
      Begin VB.CommandButton cmdAddTab 
         Caption         =   "Add a &New Tab"
         Height          =   495
         Left            =   -71160
         TabIndex        =   20
         Top             =   1560
         Width           =   1695
      End
      Begin VB.Frame Frame2 
         Caption         =   "Frame1"
         Height          =   1695
         Left            =   -71760
         TabIndex        =   11
         Top             =   600
         Width           =   2175
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   5
            Left            =   240
            TabIndex        =   12
            Top             =   480
            Value           =   -1  'True
            Width           =   1575
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   4
            Left            =   240
            TabIndex        =   13
            Top             =   840
            Width           =   1575
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   3
            Left            =   240
            TabIndex        =   14
            Top             =   1200
            Width           =   1575
         End
      End
      Begin VB.TextBox txtGeneric 
         Height          =   375
         Left            =   480
         TabIndex        =   3
         Top             =   1920
         Width           =   2535
      End
      Begin VB.Frame Frame1 
         Caption         =   "Frame1"
         Height          =   1695
         Left            =   3240
         TabIndex        =   4
         Top             =   720
         Width           =   2175
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   2
            Left            =   240
            TabIndex        =   7
            Top             =   1200
            Width           =   1575
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   1
            Left            =   240
            TabIndex        =   6
            Top             =   840
            Width           =   1575
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Option1"
            Height          =   255
            Index           =   0
            Left            =   240
            TabIndex        =   5
            Top             =   480
            Value           =   -1  'True
            Width           =   1575
         End
      End
      Begin VB.TextBox Text6 
         Height          =   375
         Left            =   -74640
         TabIndex        =   18
         Top             =   1560
         Width           =   3255
      End
      Begin VB.TextBox Text5 
         Height          =   375
         Left            =   -74640
         TabIndex        =   16
         Top             =   720
         Width           =   5175
      End
      Begin VB.TextBox txtNumeric 
         Height          =   375
         Left            =   -74520
         TabIndex        =   9
         Top             =   720
         Width           =   1935
      End
      Begin VB.TextBox txtRequired 
         Height          =   375
         Left            =   480
         TabIndex        =   1
         Top             =   960
         Width           =   2535
      End
      Begin VB.Label Label6 
         Caption         =   "&Another generic textbox"
         Height          =   255
         Left            =   -74640
         TabIndex        =   17
         Top             =   1320
         Width           =   4095
      End
      Begin VB.Label Label5 
         Caption         =   "A &Generic textbox"
         Height          =   255
         Left            =   -74640
         TabIndex        =   15
         Top             =   480
         Width           =   2055
      End
      Begin VB.Label Label4 
         Caption         =   "The OptionButtons controls on this tab are distinct from those on page ""First"" because are enclosed in a Frame control."
         Height          =   1215
         Left            =   -74520
         TabIndex        =   10
         Top             =   1200
         Width           =   2535
      End
      Begin VB.Label Label3 
         Caption         =   "&Generic textbox"
         Height          =   255
         Left            =   480
         TabIndex        =   2
         Top             =   1560
         Width           =   2295
      End
      Begin VB.Label Label1 
         Caption         =   "&Required textbox"
         Height          =   255
         Left            =   480
         TabIndex        =   0
         Top             =   600
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "&Numeric Textbox"
         Height          =   255
         Left            =   -74520
         TabIndex        =   8
         Top             =   480
         Width           =   2055
      End
   End
End
Attribute VB_Name = "frmSSTab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Add a new tab.

Private Sub cmdAddTab_Click()
    Dim lbl As Label, txt As TextBox
    
    ' Create a new tab, make it current.
    SSTab1.Tabs = SSTab1.Tabs + 1
    SSTab1.Tab = SSTab1.Tabs - 1
    SSTab1.TabCaption(SSTab1.Tab) = "Tab #" & SSTab1.Tabs
    
    ' Add a Label and a TextBox control on the new tab.
    Set lbl = Controls.Add("VB.Label", "NewLabel" & SSTab1.Tabs)
    Set lbl.Container = SSTab1
    lbl.Caption = "A new Label"
    lbl.Move 400, 600
    lbl.Visible = True
    
    Set txt = Controls.Add("VB.Textbox", "NewTextBox" & SSTab1.Tabs)
    Set txt.Container = SSTab1
    txt.Text = "A new TextBox"
    txt.Move 400, 900, 1800, 400
    txt.Visible = True
    
    txt.SetFocus
    
End Sub

' Validate the tab that is being abandoned.

Private Sub SSTab1_Click(PreviousTab As Integer)
    Static Cancel As Boolean, msg As String
    ' Avoid recursive calls
    If Cancel Then Exit Sub
    
    Select Case PreviousTab
        Case 0
            If txtRequired = "" Then
                txtRequired.SetFocus
                msg = "Enter a value in this field"
                Cancel = True
            End If
        Case 1
            If Not IsNumeric(txtNumeric) Then
                txtNumeric.SetFocus
                msg = "Enter a number in this field"
                Cancel = True
            End If
        Case 2
            ' No validation for this tab.
    End Select
    
    If Cancel Then
        ' Restore previous tab (this fires another Click event).
        SSTab1.Tab = PreviousTab
        ' Show the error message
        If Len(msg) Then MsgBox msg, vbExclamation
        ' Accept future Click events.
        Cancel = False
    Else
        ' Input focus management
        ChangeTab SSTab1
    End If
    
End Sub


