VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmDocument 
   Caption         =   "frmDocument"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   Begin RichTextLib.RichTextBox rtfText 
      Height          =   1995
      Left            =   105
      TabIndex        =   0
      Top             =   120
      Width           =   3000
      _ExtentX        =   5292
      _ExtentY        =   3519
      _Version        =   393217
      Enabled         =   -1  'True
      HideSelection   =   0   'False
      ScrollBars      =   3
      TextRTF         =   $"frmDoc.frx":0000
   End
End
Attribute VB_Name = "frmDocument"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public IsDirty As Boolean

Public Sub RTF_SelChange()
    ' this proc simply acts as a dispatcher to the private procedure
    rtfText_SelChange
End Sub

Private Sub rtfText_Change()
    IsDirty = True
End Sub

Private Sub rtfText_SelChange()
    ' this is the code generated by the application wizard
'    fMainForm.tbToolBar.Buttons("Bold").Value = IIf(rtfText.SelBold, tbrPressed, tbrUnpressed)
'    fMainForm.tbToolBar.Buttons("Italic").Value = IIf(rtfText.SelItalic, tbrPressed, tbrUnpressed)
'    fMainForm.tbToolBar.Buttons("Underline").Value = IIf(rtfText.SelUnderline, tbrPressed, tbrUnpressed)
'    fMainForm.tbToolBar.Buttons("Align Left").Value = IIf(rtfText.SelAlignment = rtfLeft, tbrPressed, tbrUnpressed)
'    fMainForm.tbToolBar.Buttons("Align Right").Value = IIf(rtfText.SelAlignment = rtfRight, tbrPressed, tbrUnpressed)
'    fMainForm.tbToolBar.Buttons("Center").Value = IIf(rtfText.SelAlignment = rtfCenter, tbrPressed, tbrUnpressed)
    
    ' keep the toolbar's button in synch with current selection
    If IsNull(rtfText.SelBold) Then
        fMainForm.tbToolBar.Buttons("Bold").MixedState = True
    Else
        fMainForm.tbToolBar.Buttons("Bold").MixedState = False
        fMainForm.tbToolBar.Buttons("Bold").Value = IIf(rtfText.SelBold, tbrPressed, tbrUnpressed)
    End If
    
    If IsNull(rtfText.SelItalic) Then
        fMainForm.tbToolBar.Buttons("Italic").MixedState = True
    Else
        fMainForm.tbToolBar.Buttons("Italic").MixedState = False
        fMainForm.tbToolBar.Buttons("Italic").Value = IIf(rtfText.SelItalic, tbrPressed, tbrUnpressed)
    End If
    
    If IsNull(rtfText.SelUnderline) Then
        fMainForm.tbToolBar.Buttons("Underline").MixedState = True
    Else
        fMainForm.tbToolBar.Buttons("Underline").MixedState = False
        fMainForm.tbToolBar.Buttons("Underline").Value = IIf(rtfText.SelUnderline, tbrPressed, tbrUnpressed)
    End If
    
    If IsNull(rtfText.SelAlignment) Then
        fMainForm.tbToolBar.Buttons("Align Left").MixedState = True
        fMainForm.tbToolBar.Buttons("Align Right").MixedState = True
        fMainForm.tbToolBar.Buttons("Center").MixedState = True
    Else
        fMainForm.tbToolBar.Buttons("Align Left").MixedState = False
        fMainForm.tbToolBar.Buttons("Align Right").MixedState = False
        fMainForm.tbToolBar.Buttons("Center").MixedState = False
        fMainForm.tbToolBar.Buttons("Align Left").Value = IIf(rtfText.SelAlignment = rtfLeft, tbrPressed, tbrUnpressed)
        fMainForm.tbToolBar.Buttons("Align Right").Value = IIf(rtfText.SelAlignment = rtfRight, tbrPressed, tbrUnpressed)
        fMainForm.tbToolBar.Buttons("Center").Value = IIf(rtfText.SelAlignment = rtfCenter, tbrPressed, tbrUnpressed)
    End If
    
    ' keep the combo boxes in synch with the current selection
    If IsNull(rtfText.SelFontName) Then
        fMainForm.cboFonts.Text = ""
    Else
        fMainForm.cboFonts.Text = rtfText.SelFontName
    End If
    
    If IsNull(rtfText.SelFontSize) Then
        fMainForm.cboSize.Text = ""
    Else
        fMainForm.cboSize.Text = rtfText.SelFontSize
    End If
    
    ' Show the current line on the status bar
    fMainForm.sbStatusBar.Panels(1).Text = "Line " & _
        (1 + rtfText.GetLineFromChar(rtfText.SelStart))

End Sub

' this code was produced by the App Wizard
' has been commented out because it is completely useless,
' because the Resize event always occurs after Form_Load
'Private Sub Form_Load()
'    Form_Resize
'End Sub

Private Sub Form_Resize()
    On Error Resume Next
    rtfText.Move 0, 0, Me.ScaleWidth, Me.ScaleHeight
    rtfText.RightMargin = rtfText.Width
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    
    If IsDirty Then
        Select Case MsgBox("The text in " & Caption & " has been modified." & vbCr _
            & "Do you wish to save it on disk?", vbExclamation + vbYesNoCancel)
                Case vbYes
                    If Left$(Caption, 8) = "Document" Then
                        With fMainForm.dlgCommonDialog
                            .DialogTitle = "Save As"
                            .CancelError = False
                            .Filter = "All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt"
                            .FilterIndex = 2
                            .ShowSave
                            If Len(.FileName) = 0 Then
                                Cancel = True
                            Else
                                rtfText.SaveFile .FileName
                                IsDirty = False
                            End If
                        End With
                    Else
                        rtfText.SaveFile Caption
                        IsDirty = False
                    End If
                Case vbNo
                    IsDirty = False
                Case vbCancel
                    Cancel = True
        End Select
    End If
    ' stop unloading all forms
    If Cancel Then gloCancel = True
End Sub


