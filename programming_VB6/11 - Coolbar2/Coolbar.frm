VERSION 5.00
Object = "{38911DA0-E448-11D0-84A3-00DD01104159}#1.1#0"; "COMCT332.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmCoolbar 
   Caption         =   "Coolbar Control Demo"
   ClientHeight    =   3180
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3180
   ScaleWidth      =   7560
   StartUpPosition =   3  'Windows Default
   Begin Project1.TransTBWrapper TransTBWrapper1 
      Height          =   495
      Left            =   7080
      TabIndex        =   7
      Top             =   1080
      Width           =   495
      _ExtentX        =   873
      _ExtentY        =   873
   End
   Begin VB.PictureBox Picture1 
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2055
      Left            =   120
      ScaleHeight     =   2055
      ScaleWidth      =   7095
      TabIndex        =   3
      Top             =   960
      Width           =   7095
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
         Height          =   1335
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   5
         Text            =   "Coolbar.frx":0000
         Top             =   600
         Width           =   6855
      End
      Begin VB.Label Label1 
         Caption         =   $"Coolbar.frx":001C
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   480
         Left            =   120
         TabIndex        =   4
         Top             =   0
         Width           =   6630
      End
   End
   Begin ComCtl3.CoolBar CoolBar1 
      Align           =   1  'Align Top
      Height          =   780
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   7560
      _ExtentX        =   13335
      _ExtentY        =   1376
      Picture         =   "Coolbar.frx":00AF
      EmbossShadow    =   13158600
      EmbossPicture   =   -1  'True
      _CBWidth        =   7560
      _CBHeight       =   780
      _Version        =   "6.0.8169"
      Child1          =   "Toolbar1"
      MinHeight1      =   330
      Width1          =   5505
      NewRow1         =   0   'False
      AllowVertical1  =   0   'False
      Caption2        =   "Fonts"
      Child2          =   "cboFonts"
      MinHeight2      =   315
      Width2          =   2820
      UseCoolbarColors2=   0   'False
      NewRow2         =   -1  'True
      Child3          =   "cmdAddBand"
      MinWidth3       =   1695
      MinHeight3      =   375
      Width3          =   1755
      NewRow3         =   0   'False
      BandStyle3      =   1
      Begin VB.CommandButton cmdAddBand 
         Caption         =   "Add a new Band "
         Height          =   375
         Left            =   5775
         TabIndex        =   6
         Top             =   30
         Width           =   1755
      End
      Begin VB.ComboBox cboFonts 
         Height          =   315
         Left            =   615
         TabIndex        =   2
         Text            =   "Combo1"
         Top             =   435
         Width           =   6855
      End
      Begin MSComctlLib.Toolbar Toolbar1 
         Height          =   330
         Left            =   165
         TabIndex        =   1
         Top             =   45
         Width           =   5520
         _ExtentX        =   9737
         _ExtentY        =   582
         ButtonWidth     =   609
         ButtonHeight    =   582
         Appearance      =   1
         Style           =   1
         ImageList       =   "imlToolbarIcons"
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   12
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "New"
               Object.ToolTipText     =   "New"
               ImageKey        =   "New"
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Open"
               Object.ToolTipText     =   "Open"
               ImageKey        =   "Open"
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Save"
               Object.ToolTipText     =   "Save"
               ImageKey        =   "Save"
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Print"
               Object.ToolTipText     =   "Print"
               ImageKey        =   "Print"
            EndProperty
            BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Find"
               Object.ToolTipText     =   "Find"
               ImageKey        =   "Find"
            EndProperty
            BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Undo"
               Object.ToolTipText     =   "Undo"
               ImageKey        =   "Undo"
            EndProperty
            BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Redo"
               Object.ToolTipText     =   "Redo"
               ImageKey        =   "Redo"
            EndProperty
            BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Bold"
               Object.ToolTipText     =   "Bold"
               ImageKey        =   "Bold"
            EndProperty
            BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Italic"
               Object.ToolTipText     =   "Italic"
               ImageKey        =   "Italic"
            EndProperty
            BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Underline"
               Object.ToolTipText     =   "Underline"
               ImageKey        =   "Underline"
            EndProperty
         EndProperty
      End
   End
   Begin MSComctlLib.ImageList imlToolbarIcons 
      Left            =   5880
      Top             =   960
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   10
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":811D
            Key             =   "New"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":822F
            Key             =   "Open"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8341
            Key             =   "Save"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8453
            Key             =   "Print"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8565
            Key             =   "Find"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8677
            Key             =   "Undo"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8789
            Key             =   "Redo"
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":889B
            Key             =   "Bold"
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":89AD
            Key             =   "Italic"
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Coolbar.frx":8ABF
            Key             =   "Underline"
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmCoolbar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Load the name of screen fonts into the Combo box.

Private Sub Form_Load()

    ' Put the Toolbar Wrapper controls in the Coolbar band
    Set TransTBWrapper1.Container = CoolBar1
    Set CoolBar1.Bands(1).Child = TransTBWrapper1
    ' Put the toolbar into the toolbar wrapper
    Set TransTBWrapper1.Toolbar = Toolbar1

    Dim i As Integer
    For i = 0 To Screen.FontCount - 1
        cboFonts.AddItem Screen.Fonts(i)
        If Screen.Fonts(i) = FontName Then cboFonts.ListIndex = i
    Next
End Sub

' Resize the PictureBox when the form resizes.

Private Sub Form_Resize()
    On Error Resume Next
    Picture1.Move 0, CoolBar1.Height, ScaleWidth, ScaleHeight - CoolBar1.Height
End Sub

' Resize and move the PictureBox when the Coolbar's height changes.

Private Sub CoolBar1_HeightChanged(ByVal NewHeight As Single)
    Picture1.Move 0, NewHeight, ScaleWidth, ScaleHeight - NewHeight
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' it is VERY important to set the wrapper's Toolbar property
    ' to Nothing before the form is unloaded
    CoolBar1.Visible = False
    Set TransTBWrapper1.Toolbar = Nothing
End Sub

' Resize the controls inside the PictureBox when the latter is resized.

Private Sub Picture1_Resize()
    On Error Resume Next
    Label1.Move 0, 0, Picture1.ScaleWidth, Label1.Height
    Text1.Move 0, Label1.Height, Picture1.ScaleWidth, Picture1.ScaleHeight - Label1.Height
End Sub

' Add a new Band object with a ComboBox inside it

Private Sub cmdAddBand_Click()
    ' First, create a new ComboBox. Note how the Bands' Count
    ' Property is used to assign a unique name to the control.
    Dim cb As ComboBox
    Set cb = Controls.Add("VB.ComboBox", "Combo" & CoolBar1.Bands.Count)
    ' Make the ComboBox a child of the Coolbar control.
    Set cb.Container = CoolBar1
    ' Create a new Band object.
    CoolBar1.Bands.Add , , cb.Name, , , cb
    
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
    On Error Resume Next
    Select Case Button.Key
        Case "New"
            'ToDo: Add 'New' button code.
            MsgBox "Add 'New' button code."
        Case "Open"
            'ToDo: Add 'Open' button code.
            MsgBox "Add 'Open' button code."
        Case "Save"
            'ToDo: Add 'Save' button code.
            MsgBox "Add 'Save' button code."
        Case "Print"
            'ToDo: Add 'Print' button code.
            MsgBox "Add 'Print' button code."
        Case "Find"
            'ToDo: Add 'Find' button code.
            MsgBox "Add 'Find' button code."
        Case "Undo"
            'ToDo: Add 'Undo' button code.
            MsgBox "Add 'Undo' button code."
        Case "Redo"
            'ToDo: Add 'Redo' button code.
            MsgBox "Add 'Redo' button code."
        Case "Bold"
            'ToDo: Add 'Bold' button code.
            MsgBox "Add 'Bold' button code."
        Case "Italic"
            'ToDo: Add 'Italic' button code.
            MsgBox "Add 'Italic' button code."
        Case "Underline"
            'ToDo: Add 'Underline' button code.
            MsgBox "Add 'Underline' button code."
    End Select
End Sub




