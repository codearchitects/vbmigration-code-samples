VERSION 5.00
Begin VB.Form frmPublishers 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Publishers"
   ClientHeight    =   3765
   ClientLeft      =   1095
   ClientTop       =   330
   ClientWidth     =   6675
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3765
   ScaleWidth      =   6675
   Begin VB.OptionButton optLang 
      Caption         =   "&Italian"
      Height          =   255
      Index           =   1
      Left            =   5640
      TabIndex        =   25
      Top             =   1440
      Width           =   975
   End
   Begin VB.OptionButton optLang 
      Caption         =   "&English"
      Height          =   255
      Index           =   0
      Left            =   5640
      TabIndex        =   24
      Top             =   1080
      Width           =   975
   End
   Begin VB.PictureBox picButtons 
      Align           =   2  'Align Bottom
      Appearance      =   0  'Flat
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   0
      ScaleHeight     =   300
      ScaleWidth      =   6675
      TabIndex        =   18
      Top             =   3120
      Width           =   6675
      Begin VB.CommandButton cmdClose 
         Caption         =   "&Close"
         Height          =   300
         Left            =   4505
         TabIndex        =   23
         Top             =   0
         Width           =   975
      End
      Begin VB.CommandButton cmdRefresh 
         Caption         =   "&Refresh"
         Height          =   300
         Left            =   3409
         TabIndex        =   22
         Top             =   0
         Width           =   975
      End
      Begin VB.CommandButton cmdDelete 
         Caption         =   "&Delete"
         Height          =   300
         Left            =   2313
         TabIndex        =   21
         Top             =   0
         Width           =   975
      End
      Begin VB.CommandButton cmdUpdate 
         Caption         =   "&Update"
         Height          =   300
         Left            =   1217
         TabIndex        =   20
         Top             =   0
         Width           =   975
      End
      Begin VB.CommandButton cmdAdd 
         Caption         =   "&Add"
         Height          =   300
         Left            =   121
         TabIndex        =   19
         Top             =   0
         Width           =   975
      End
   End
   Begin VB.Data datPrimaryRS 
      Align           =   2  'Align Bottom
      Caption         =   " "
      Connect         =   "Access"
      DatabaseName    =   "C:\Program Files\Microsoft Visual Studio\VB98\BIBLIO.MDB"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Publishers"
      Top             =   3420
      Width           =   6675
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Comments"
      DataSource      =   "datPrimaryRS"
      Height          =   310
      Index           =   8
      Left            =   2040
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   17
      Top             =   2610
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Fax"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   7
      Left            =   2040
      MaxLength       =   15
      TabIndex        =   15
      Top             =   2300
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Telephone"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   6
      Left            =   2040
      MaxLength       =   15
      TabIndex        =   13
      Top             =   1980
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Zip"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   5
      Left            =   2040
      MaxLength       =   15
      TabIndex        =   11
      Top             =   1660
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "State"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   4
      Left            =   2040
      MaxLength       =   10
      TabIndex        =   9
      Top             =   1340
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "City"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   3
      Left            =   2040
      MaxLength       =   20
      TabIndex        =   7
      Top             =   1020
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Address"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   2
      Left            =   2040
      MaxLength       =   50
      TabIndex        =   5
      Top             =   700
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Name"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   1
      Left            =   2040
      MaxLength       =   50
      TabIndex        =   3
      Top             =   380
      Width           =   3375
   End
   Begin VB.TextBox txtFields 
      DataField       =   "Name"
      DataSource      =   "datPrimaryRS"
      Height          =   285
      Index           =   0
      Left            =   2040
      MaxLength       =   50
      TabIndex        =   1
      Top             =   60
      Width           =   3375
   End
   Begin VB.Image imgFlag 
      Height          =   495
      Left            =   5640
      Top             =   240
      Width           =   615
   End
   Begin VB.Label lblLabels 
      Caption         =   "Comments:"
      Height          =   255
      Index           =   8
      Left            =   120
      TabIndex        =   16
      Top             =   2620
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Fax:"
      Height          =   255
      Index           =   7
      Left            =   120
      TabIndex        =   14
      Top             =   2300
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Telephone:"
      Height          =   255
      Index           =   6
      Left            =   120
      TabIndex        =   12
      Top             =   1980
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Zip:"
      Height          =   255
      Index           =   5
      Left            =   120
      TabIndex        =   10
      Top             =   1660
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "State:"
      Height          =   255
      Index           =   4
      Left            =   120
      TabIndex        =   8
      Top             =   1340
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "City:"
      Height          =   255
      Index           =   3
      Left            =   120
      TabIndex        =   6
      Top             =   1020
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Address:"
      Height          =   255
      Index           =   2
      Left            =   120
      TabIndex        =   4
      Top             =   700
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Name:"
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   380
      Width           =   1815
   End
   Begin VB.Label lblLabels 
      Caption         =   "Name:"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   60
      Width           =   1815
   End
End
Attribute VB_Name = "frmPublishers"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Modify this statement to match your system's paths.
Const DATABASE_PATH = "c:\Program files\Microsoft Visual Studio\vb98\biblio.mdb"

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
  MsgBox rs.LoadResString(rsDataError) & Error$(DataErr)
  Response = 0  'Throw away the error
End Sub

Private Sub datPrimaryRS_Reposition()
  Screen.MousePointer = vbDefault
  On Error Resume Next
  'This will display the current record position for dynasets and snapshots
  datPrimaryRS.Caption = rs.LoadResString(rsRecord) & (datPrimaryRS.Recordset.AbsolutePosition + 1)
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
    datPrimaryRS.DatabaseName = DATABASE_PATH
    LoadStrings
  
    ' in this particolar program we must also select
    ' the property Option Button to reflect the select language
    Dim id As Long
    rs.GetInfo id, 0
    If id = 0 Then
        optLang(0).Value = True
    Else
        optLang(1).Value = True
    End If
  
  datPrimaryRS.Refresh
  If datPrimaryRS.Recordset.RecordCount = 0 Then datPrimaryRS.Recordset.AddNew
End Sub

Private Sub Form_Unload(Cancel As Integer)
  Screen.MousePointer = vbDefault
End Sub

Private Sub LoadStrings()
    Caption = rs.LoadResString(rsPublishers)
    cmdClose.Caption = rs.LoadResString(rsClose)
    cmdRefresh.Caption = rs.LoadResString(rsRefresh)
    cmdDelete.Caption = rs.LoadResString(rsDelete)
    cmdUpdate.Caption = rs.LoadResString(rsUpdate)
    cmdAdd.Caption = rs.LoadResString(rsAdd)
    lblLabels(8).Caption = rs.LoadResString(rsComments)
    lblLabels(7).Caption = rs.LoadResString(rsFax)
    lblLabels(6).Caption = rs.LoadResString(rsTelephone)
    lblLabels(5).Caption = rs.LoadResString(rsZip)
    lblLabels(4).Caption = rs.LoadResString(rsState)
    lblLabels(3).Caption = rs.LoadResString(rsCity)
    lblLabels(2).Caption = rs.LoadResString(rsAddress)
    lblLabels(1).Caption = rs.LoadResString(rsName)
    lblLabels(0).Caption = rs.LoadResString(rsName)
    optLang(0).Caption = rs.LoadResString(rsEnglish)
    optLang(1).Caption = rs.LoadResString(rsItalian)
    Set imgFlag.Picture = rs.LoadResPicture(rpFlag)
End Sub

Private Sub optLang_Click(Index As Integer)
    Select Case Index
        Case 0
            Set rs = CreateObject("MyApplication000.Resources")
        Case 1
            Set rs = CreateObject("MyApplication410.Resources")
    End Select
    LoadStrings
End Sub
