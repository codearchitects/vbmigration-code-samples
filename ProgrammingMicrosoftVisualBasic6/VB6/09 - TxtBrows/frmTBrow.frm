VERSION 5.00
Begin VB.Form frmTextBrowser 
   Caption         =   "Form1"
   ClientHeight    =   4470
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7350
   LinkTopic       =   "Form1"
   ScaleHeight     =   4470
   ScaleWidth      =   7350
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdFind 
      Caption         =   "&Find"
      Height          =   375
      Left            =   6120
      TabIndex        =   4
      ToolTipText     =   "Find the occurrence of a string"
      Top             =   1080
      Width           =   1095
   End
   Begin VB.CommandButton cmdPrint 
      Caption         =   "&Print"
      Height          =   375
      Left            =   6120
      TabIndex        =   3
      ToolTipText     =   "Send the text to the standard printer"
      Top             =   600
      Width           =   1095
   End
   Begin VB.CommandButton cmdCopy 
      Caption         =   "&Copy"
      Height          =   375
      Left            =   6120
      TabIndex        =   2
      ToolTipText     =   "Copy the selected text to the Clipboard"
      Top             =   120
      Width           =   1095
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   6120
      TabIndex        =   1
      ToolTipText     =   "Close this dialog"
      Top             =   3960
      Width           =   1095
   End
   Begin VB.TextBox txtBrowser 
      Height          =   4215
      HideSelection   =   0   'False
      Left            =   120
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Top             =   120
      Width           =   5775
   End
End
Attribute VB_Name = "frmTextBrowser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' the Title of the dialog, used for the caption of the form
' and in all error messages - defaults to "Readme"
Public DialogTitle As String

' the text that must be loaded into the textbox
Public Text As String

' the name of the text file that must be loaded in the textbox
' this property is used only if Text = ""
Private m_Filename As String

' this is used by the Find command
Private m_SearchText As String

Property Get Filename() As String
    Filename = m_Filename
End Property

Property Let Filename(ByVal newValue As String)
    m_Filename = newValue
    DialogTitle = "Readme - " & newValue
End Property

Private Sub Form_Initialize()
    ' initialize all properties
    DialogTitle = "Readme"
End Sub

Private Sub Form_Load()
    ' load the string of text or the contents of the file
    ' into the multiline textbox
    On Error GoTo Load_Error
    
    ' copy the DialogTitle property into the caption
    Me.Caption = DialogTitle
    
    If Text <> "" Then
        txtBrowser.Text = Text
    
    ElseIf Filename <> "" Then
        Dim fnum As Integer
        fnum = FreeFile()
        Open Filename For Input As #fnum
        txtBrowser.Text = Input$(LOF(fnum), fnum)
        Close #fnum
    End If
    
    ' disable the Copy, Print & Find buttons if there is no text
    If txtBrowser.Text = "" Then
        cmdCopy.Enabled = False
        cmdPrint.Enabled = False
        cmdFind.Enabled = False
    End If
    Exit Sub
    
Load_Error:
    If MsgBox("Unable to load file '" & Filename & "'", vbCritical + vbRetryCancel, DialogTitle) = vbRetry Then
        Resume
    Else
        Unload Me
        Err.Raise Err.Number, "frmTextBrowser", Err.Description
    End If
    
End Sub

Private Sub Form_Resize()
    ' evaluate the new position of all controls
    
    ' the minimum size for the form
    Const MIN_WIDTH = 4000
    Const MIN_HEIGHT = 3000
    ' the distance among the controls and the border
    Const DISTANCE = 100
    
    Dim buttonLeft As Single
    
    ' set a minimum size for the form
    ' (these statements may fire additional resize events)
    If Width < MIN_WIDTH Then Width = MIN_WIDTH
    If Height < MIN_HEIGHT Then Height = MIN_HEIGHT
    
    ' move the buttons
    buttonLeft = ScaleWidth - cmdOK.Width - DISTANCE
    cmdCopy.Move buttonLeft, DISTANCE
    cmdPrint.Move buttonLeft, cmdCopy.Top + cmdCopy.Height + DISTANCE
    cmdFind.Move buttonLeft, cmdPrint.Top + cmdPrint.Height + DISTANCE
    cmdOK.Move buttonLeft, ScaleHeight - cmdOK.Height - DISTANCE
    
    ' resize the multiline textbox
    txtBrowser.Move DISTANCE, DISTANCE, buttonLeft - DISTANCE * 2, ScaleHeight - DISTANCE * 2
    
End Sub

Private Sub cmdOK_Click()
    Unload Me
End Sub

Private Sub cmdCopy_Click()
    Clipboard.Clear
    If txtBrowser.SelLength = 0 Then
        ' if not text is selected, copy the entire contents
        Clipboard.SetText txtBrowser.Text
    Else
        ' otherwise, copy only the selected text
        Clipboard.SetText txtBrowser.SelText
    End If
End Sub

Private Sub cmdPrint_Click()
    ' print the contents of the textbox
    Printer.NewPage
    Printer.Print txtBrowser.Text
    Printer.EndDoc
End Sub

Private Sub cmdFind_Click()
    ' find the next occurrence of a string
    Dim search As String, index As Long
    
    ' exit if no search string has been specified
    search = InputBox("Enter the string to search", DialogTitle, m_SearchText)
    If search = "" Then Exit Sub
    
    ' search in the text following the cursor
    m_SearchText = search
    
    index = InStr(txtBrowser.SelStart + 2, txtBrowser.Text, m_SearchText, vbTextCompare)
    If index = 0 Then
        MsgBox "Text not found", vbExclamation, DialogTitle
    Else
        txtBrowser.SelStart = index - 1
        txtBrowser.SelLength = Len(m_SearchText)
    End If
    
End Sub




