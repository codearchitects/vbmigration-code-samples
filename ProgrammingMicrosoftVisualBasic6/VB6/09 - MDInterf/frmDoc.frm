VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmDocument 
   Caption         =   "frmDocument"
   ClientHeight    =   4155
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7515
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   4155
   ScaleWidth      =   7515
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   1920
      Top             =   2880
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.TextBox txtText 
      Height          =   2000
      Left            =   100
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Top             =   100
      Width           =   3000
   End
End
Attribute VB_Name = "frmDocument"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' True if the contents of the document has been modified
Public IsDirty As Boolean

' the name of the file associated to this document
Private m_Filename As String

Property Get Filename() As String
    Filename = m_Filename
End Property

Property Let Filename(ByVal newValue As String)
    m_Filename = newValue
    Caption = IIf(newValue = "", "(untitled)", newValue)
End Property

' read-only properties

Property Get IsEmpty() As Boolean
    IsEmpty = (txtText.Text = "")
End Property

Property Get CanSave() As Boolean
    CanSave = IsDirty
End Property

Property Get CanCopy() As Boolean
    CanCopy = (txtText.SelLength > 0)
End Property

Property Get CanCut() As Boolean
    CanCut = (txtText.SelLength > 0)
End Property

Property Get CanPaste() As Boolean
    CanPaste = (Clipboard.GetText <> "")
End Property

Property Get CanPrint() As Boolean
    CanPrint = (txtText.Text <> "")
End Property

' Public Methods

Sub Copy()
    Clipboard.SetText txtText.SelText
End Sub

Sub Cut()
    Clipboard.SetText txtText.SelText
    txtText.SelText = ""
End Sub

Sub Paste()
    txtText.SelText = Clipboard.GetText
End Sub

Sub PrintDoc()
    Printer.NewPage
    Printer.Print txtText.Text
    Printer.EndDoc
End Sub

Sub LoadFile(ByVal newFile As String)
    Dim fnum As Integer
    On Error GoTo LoadFile_Error
    
    If newFile = "" Then Exit Sub
    
    fnum = FreeFile()
    Open newFile For Input As #fnum
    txtText = Input$(LOF(fnum), fnum)
    Close #fnum
    
    ' show the new caption
    Filename = newFile
    IsDirty = False
    Exit Sub

LoadFile_Error:
    MsgBox "Error while opening file: " & newFile, vbCritical
    
End Sub

Sub SaveFile(ByVal newFile As String)
    Dim fnum As Integer
    On Error GoTo SaveFile_Error
    
    If newFile = "" Then Exit Sub
    
    fnum = FreeFile()
    Open newFile For Output As #fnum
    Print #fnum, txtText.Text
    Close #fnum
    
    ' show the new caption
    Filename = newFile
    IsDirty = False
    Exit Sub

SaveFile_Error:
    MsgBox "Error while writing file: " & newFile, vbCritical
    
End Sub

Function AskFilename(ByVal saveFlag As Boolean)
    ' ask a filename for this document
    ' saveFlag is False for Open, True for Save
    CommonDialog1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
    CommonDialog1.FilterIndex = 2
    If saveFlag Then
        CommonDialog1.ShowSave
    Else
        CommonDialog1.ShowOpen
    End If
    AskFilename = CommonDialog1.Filename
    
End Function

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    ' ask to confirm or save, if data has been modified
    Dim answer As Integer
    
    ' do nothing if data is not modified
    If Not IsDirty Then Exit Sub
    
    answer = MsgBox("The text in this window has been modified." & vbCr _
        & "Do you wish to save it?", vbYesNoCancel + vbInformation, Me.Caption)
    Select Case answer
        Case vbNo
            Exit Sub
        Case vbCancel
            Cancel = True
            Exit Sub
        Case vbYes
            If m_Filename = "" Then
                m_Filename = AskFilename(True)
                If m_Filename = "" Then
                    Cancel = True
                    Exit Sub
                End If
            End If
            SaveFile m_Filename
    End Select
    
End Sub

Private Sub Form_Resize()
    On Error Resume Next
    txtText.Move 0, 0, ScaleWidth, ScaleHeight
    ' force the redraw of the caption
    Filename = m_Filename
End Sub

Private Sub txtText_Change()
    ' set the IsDirty flag
    IsDirty = True
End Sub



