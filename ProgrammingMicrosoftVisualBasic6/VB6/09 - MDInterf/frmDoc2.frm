VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmDocument 
   Caption         =   "frmDocument2"
   ClientHeight    =   4155
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7515
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   4155
   ScaleWidth      =   7515
   Begin VB.PictureBox picBitmap 
      Height          =   2175
      Left            =   240
      ScaleHeight     =   2115
      ScaleWidth      =   2835
      TabIndex        =   0
      Top             =   120
      Width           =   2895
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   1920
      Top             =   2880
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
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
    Caption = IIf(newValue = "", "Untitled", newValue)
End Property

' read-only properties

Property Get IsEmpty() As Boolean
    IsEmpty = (picBitmap.Picture = 0)
End Property

Property Get CanSave() As Boolean
    CanSave = IsDirty
End Property

Property Get CanCopy() As Boolean
    CanCopy = Not IsEmpty
End Property

Property Get CanCut() As Boolean
    CanCut = Not IsEmpty
End Property

Property Get CanPaste() As Boolean
    CanPaste = Not (Clipboard.GetData() Is Nothing)
End Property

Property Get CanPrint() As Boolean
    CanPrint = Not IsEmpty
End Property

' Public Methods

Sub Copy()
    Clipboard.Clear
    Clipboard.SetData picBitmap.Picture
End Sub

Sub Cut()
    Clipboard.Clear
    Clipboard.SetData picBitmap.Picture
    Set picBitmap.Picture = Nothing
End Sub

Sub Paste()
    Set picBitmap.Picture = Clipboard.GetData()
    IsDirty = True
End Sub

Sub PrintDoc()
    Printer.NewPage
    Printer.PaintPicture picBitmap.Picture, 0, 0
    Printer.EndDoc
End Sub

Sub LoadFile(ByVal newFile As String)
    Dim fnum As Integer
    On Error GoTo LoadFile_Error
    
    If newFile = "" Then Exit Sub
    
    Set picBitmap.Picture = LoadPicture(newFile)
    
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
    
    SavePicture picBitmap.Image, newFile
    
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
    If saveFlag Then
        CommonDialog1.Filter = "All Files (*.*)|*.*|Bitmaps (*.bmp)|*.bmp"
    Else
        CommonDialog1.Filter = "All Files (*.*)|*.*|All picture files|*.bmp;*.dib;*.wmf;*.emf;*.gif;*.jpg|" _
            & "Bitmaps (*.bmp;*.dib)|*.bmp;*.dib|Metafiles (*.wmf;*.emf)|*.wmf;*.emf|" _
            & "GIF Files (*.gif)|*.gif|JPEG Files (*.jpg)|*.jpg"
    End If
    
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
    
    answer = MsgBox("The picture in this window has been modified." & vbCr _
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
    picBitmap.Move 0, 0, ScaleWidth, ScaleHeight
    ' force the redraw of the caption
    Filename = m_Filename
End Sub



