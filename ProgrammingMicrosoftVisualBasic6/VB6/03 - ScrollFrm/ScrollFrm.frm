VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Scrollable Form Demo"
   ClientHeight    =   7110
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10950
   LinkTopic       =   "Form1"
   ScaleHeight     =   7110
   ScaleWidth      =   10950
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdFiller 
      Height          =   375
      Left            =   10320
      TabIndex        =   3
      Top             =   6600
      Width           =   375
   End
   Begin VB.PictureBox picCanvas 
      Height          =   8415
      Left            =   120
      ScaleHeight     =   8355
      ScaleWidth      =   9315
      TabIndex        =   2
      Top             =   0
      Width           =   9375
      Begin VB.PictureBox picButtons 
         Appearance      =   0  'Flat
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   420
         Left            =   -120
         ScaleHeight     =   420
         ScaleWidth      =   5550
         TabIndex        =   34
         Top             =   120
         Width           =   5550
         Begin VB.CommandButton cmdAdd 
            Caption         =   "&Add"
            Height          =   400
            Left            =   240
            TabIndex        =   39
            Top             =   0
            Width           =   975
         End
         Begin VB.CommandButton cmdUpdate 
            Caption         =   "&Update"
            Height          =   400
            Left            =   1335
            TabIndex        =   38
            Top             =   0
            Width           =   975
         End
         Begin VB.CommandButton cmdDelete 
            Caption         =   "&Delete"
            Height          =   400
            Left            =   2430
            TabIndex        =   37
            Top             =   0
            Width           =   975
         End
         Begin VB.CommandButton cmdRefresh 
            Caption         =   "&Refresh"
            Height          =   400
            Left            =   3525
            TabIndex        =   36
            Top             =   0
            Width           =   975
         End
         Begin VB.CommandButton cmdClose 
            Caption         =   "&Close"
            Height          =   400
            Left            =   4560
            TabIndex        =   35
            Top             =   0
            Width           =   975
         End
      End
      Begin VB.Data datPrimaryRS 
         Caption         =   " "
         Connect         =   "Access"
         DatabaseName    =   "C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
         DefaultCursorType=   0  'DefaultCursor
         DefaultType     =   2  'UseODBC
         Exclusive       =   0   'False
         Height          =   400
         Left            =   5520
         Options         =   0
         ReadOnly        =   0   'False
         RecordsetType   =   1  'Dynaset
         RecordSource    =   "SELECT * FROM Employees"
         Top             =   120
         Width           =   1215
      End
      Begin VB.TextBox txtFields 
         DataField       =   "ReportsTo"
         DataSource      =   "datPrimaryRS"
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
         Index           =   15
         Left            =   2040
         TabIndex        =   33
         Top             =   7680
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Notes"
         DataSource      =   "datPrimaryRS"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1080
         Index           =   14
         Left            =   2040
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   31
         Top             =   6390
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Extension"
         DataSource      =   "datPrimaryRS"
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
         Index           =   12
         Left            =   2040
         MaxLength       =   4
         TabIndex        =   29
         Top             =   5880
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "HomePhone"
         DataSource      =   "datPrimaryRS"
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
         Index           =   11
         Left            =   2040
         MaxLength       =   24
         TabIndex        =   27
         Top             =   5445
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Country"
         DataSource      =   "datPrimaryRS"
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
         Index           =   10
         Left            =   2040
         MaxLength       =   15
         TabIndex        =   25
         Top             =   4995
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "PostalCode"
         DataSource      =   "datPrimaryRS"
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
         Index           =   9
         Left            =   2040
         MaxLength       =   10
         TabIndex        =   23
         Top             =   4560
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Region"
         DataSource      =   "datPrimaryRS"
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
         Index           =   8
         Left            =   2040
         MaxLength       =   15
         TabIndex        =   21
         Top             =   4125
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "City"
         DataSource      =   "datPrimaryRS"
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
         Index           =   7
         Left            =   2040
         MaxLength       =   15
         TabIndex        =   19
         Top             =   3675
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Address"
         DataSource      =   "datPrimaryRS"
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
         Index           =   6
         Left            =   2040
         MaxLength       =   60
         TabIndex        =   17
         Top             =   3240
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "HireDate"
         DataSource      =   "datPrimaryRS"
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
         Index           =   5
         Left            =   2040
         TabIndex        =   15
         Top             =   2805
         Width           =   1935
      End
      Begin VB.TextBox txtFields 
         DataField       =   "BirthDate"
         DataSource      =   "datPrimaryRS"
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
         Index           =   4
         Left            =   2040
         TabIndex        =   13
         Top             =   2355
         Width           =   1935
      End
      Begin VB.TextBox txtFields 
         DataField       =   "TitleOfCourtesy"
         DataSource      =   "datPrimaryRS"
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
         Index           =   3
         Left            =   2040
         MaxLength       =   25
         TabIndex        =   11
         Top             =   1920
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "Title"
         DataSource      =   "datPrimaryRS"
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
         Index           =   2
         Left            =   2040
         MaxLength       =   30
         TabIndex        =   9
         Top             =   1485
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "FirstName"
         DataSource      =   "datPrimaryRS"
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
         Index           =   1
         Left            =   2040
         MaxLength       =   10
         TabIndex        =   7
         Top             =   1035
         Width           =   6855
      End
      Begin VB.TextBox txtFields 
         DataField       =   "LastName"
         DataSource      =   "datPrimaryRS"
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
         Index           =   0
         Left            =   2040
         MaxLength       =   20
         TabIndex        =   5
         Top             =   600
         Width           =   6855
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "ReportsTo:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   15
         Left            =   120
         TabIndex        =   32
         Top             =   7680
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Notes:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   14
         Left            =   120
         TabIndex        =   30
         Top             =   6390
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Extension:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   12
         Left            =   120
         TabIndex        =   28
         Top             =   5940
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "HomePhone:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   11
         Left            =   120
         TabIndex        =   26
         Top             =   5490
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Country:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   10
         Left            =   120
         TabIndex        =   24
         Top             =   5055
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PostalCode:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   9
         Left            =   120
         TabIndex        =   22
         Top             =   4605
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Region:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   8
         Left            =   120
         TabIndex        =   20
         Top             =   4155
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "City:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   7
         Left            =   120
         TabIndex        =   18
         Top             =   3720
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Address:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   6
         Left            =   120
         TabIndex        =   16
         Top             =   3270
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "HireDate:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   5
         Left            =   120
         TabIndex        =   14
         Top             =   2820
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "BirthDate:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   4
         Left            =   120
         TabIndex        =   12
         Top             =   2385
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "TitleOfCourtesy:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   3
         Left            =   120
         TabIndex        =   10
         Top             =   1935
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Title:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   2
         Left            =   120
         TabIndex        =   8
         Top             =   1485
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "FirstName:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   1
         Left            =   120
         TabIndex        =   6
         Top             =   1050
         Width           =   1815
      End
      Begin VB.Label lblLabels 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "LastName:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   0
         Left            =   120
         TabIndex        =   4
         Top             =   600
         Width           =   1815
      End
   End
   Begin VB.HScrollBar HScroll1 
      Height          =   300
      Left            =   120
      TabIndex        =   1
      Top             =   6720
      Width           =   2535
   End
   Begin VB.VScrollBar VScroll1 
      Height          =   3255
      Left            =   10440
      TabIndex        =   0
      Top             =   240
      Width           =   300
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' size of scrollbars in twips
Const SB_WIDTH = 300    ' width of vertical scrollbars
Const SB_HEIGHT = 300   ' height of horizontal scrollbars

'--------------------------------------------
' code for handling form resizing and scrolling
'--------------------------------------------

Private Sub Form_Resize()
    ' resize the scrollbars along the form
    HScroll1.Move 0, ScaleHeight - SB_HEIGHT, ScaleWidth - SB_WIDTH
    VScroll1.Move ScaleWidth - SB_WIDTH, 0, SB_WIDTH, ScaleHeight - SB_HEIGHT
    cmdFiller.Move ScaleWidth - SB_WIDTH, ScaleHeight - SB_HEIGHT, SB_WIDTH, SB_HEIGHT
    ' put these controls on top
    HScroll1.ZOrder
    VScroll1.ZOrder
    cmdFiller.ZOrder
    picCanvas.BorderStyle = 0
    ' a click on the arrow moves one pixel
    HScroll1.SmallChange = ScaleX(1, vbPixels, vbTwips)
    VScroll1.SmallChange = ScaleY(1, vbPixels, vbTwips)
    'a click on the scrollbar move 16 pixels
    HScroll1.LargeChange = HScroll1.SmallChange * 16
    VScroll1.LargeChange = VScroll1.SmallChange * 16
    
    ' if the form is larger than the picCanvas picture box
    ' we don't need to show the scrollbar
    
    If ScaleWidth < picCanvas.Width + SB_WIDTH Then
        HScroll1.Visible = True
        HScroll1.Max = picCanvas.Width + SB_WIDTH - ScaleWidth
    Else
        HScroll1.Value = 0
        HScroll1.Visible = False
    End If
    If ScaleHeight < picCanvas.Height + SB_HEIGHT Then
        VScroll1.Visible = True
        VScroll1.Max = picCanvas.Height + SB_HEIGHT - ScaleHeight
    Else
        VScroll1.Value = 0
        VScroll1.Visible = False
    End If
    cmdFiller.Visible = (HScroll1.Visible Or VScroll1.Visible)
    
    MoveCanvas
End Sub

Private Sub cmdFiller_Click()
    ' resize the form so that scrollbars aren't visible
    Move Left, Top, picCanvas.Width + SB_WIDTH + 500, picCanvas.Height + SB_HEIGHT + 500
End Sub

Private Sub HScroll1_Change()
    MoveCanvas
End Sub

Private Sub HScroll1_Scroll()
    MoveCanvas
End Sub

Private Sub VScroll1_Change()
    MoveCanvas
End Sub

Private Sub VScroll1_Scroll()
    MoveCanvas
End Sub

Sub MoveCanvas()
    picCanvas.Move -HScroll1.Value, -VScroll1.Value
End Sub

'--------------------------------------------
' code for handling bound fields
'--------------------------------------------

Private Sub cmdAdd_Click()
  datPrimaryRS.Recordset.AddNew
End Sub

Private Sub cmdDelete_Click()
  With datPrimaryRS.Recordset
    If .RecordCount = 0 Then Exit Sub
    .Delete
    .MoveNext
    If .RecordCount > 0 And .EOF Then
      .MoveLast
    End If
  End With
End Sub

Private Sub cmdRefresh_Click()
  'This is only needed for multi user apps
  datPrimaryRS.Refresh
  Screen.MousePointer = vbDefault
End Sub

Private Sub cmdUpdate_Click()
  With datPrimaryRS.Recordset
    If .RecordCount = 0 Or .EditMode = 0 Then Exit Sub
    datPrimaryRS.UpdateRecord
    .Bookmark = .LastModified
  End With
End Sub

Private Sub cmdClose_Click()
  Screen.MousePointer = vbDefault
  Unload Me
End Sub

Private Sub datPrimaryRS_Error(DataErr As Integer, Response As Integer)
  'This is where you would put error handling code
  'If you want to ignore errors, comment out the next line
  'If you want to trap them, add code here to handle them
  MsgBox "Data error event hit err:" & Error$(DataErr)
  Response = 0  'Throw away the error
End Sub

Private Sub datPrimaryRS_Reposition()
  Screen.MousePointer = vbDefault
  On Error Resume Next
  'This will display the current record position for dynasets and snapshots
  datPrimaryRS.Caption = "Record: " & (datPrimaryRS.Recordset.AbsolutePosition + 1)
End Sub

Private Sub datPrimaryRS_Validate(Action As Integer, Save As Integer)
  'This is where you put validation code
  'This event gets called when the following actions occur
  Select Case Action
    Case vbDataActionMoveFirst
    Case vbDataActionMovePrevious
    Case vbDataActionMoveNext
    Case vbDataActionMoveLast
    Case vbDataActionAddNew
    Case vbDataActionUpdate
    Case vbDataActionDelete
    Case vbDataActionFind
    Case vbDataActionBookmark
    Case vbDataActionClose
      Screen.MousePointer = vbDefault
  End Select
  Screen.MousePointer = vbHourglass
End Sub

Private Sub Form_Load()
  datPrimaryRS.Refresh
  If datPrimaryRS.Recordset.RecordCount = 0 Then datPrimaryRS.Recordset.AddNew
End Sub

Private Sub Form_Unload(Cancel As Integer)
  Screen.MousePointer = vbDefault
End Sub




