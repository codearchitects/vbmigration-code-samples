VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{CFC13920-9EF4-11D0-B72F-0000C04D4C0A}#6.0#0"; "MSWLESS.OCX"
Begin VB.Form frmDocument 
   Caption         =   "Untitled"
   ClientHeight    =   3855
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4905
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   NegotiateMenus  =   0   'False
   ScaleHeight     =   3855
   ScaleWidth      =   4905
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   3600
      Top             =   720
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSWLess.WLText txtEditor 
      Height          =   2655
      Left            =   240
      TabIndex        =   0
      Top             =   360
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   4683
      _Version        =   393216
      ScrollBars      =   2
      MultiLine       =   -1  'True
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
   End
End
Attribute VB_Name = "frmDocument"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' this is True if the contents of the editor has been modified
Public IsDirty As Boolean

Private m_FileName As String

Property Get Filename() As String
    Filename = m_FileName
End Property

Property Let Filename(ByVal newValue As String)
    m_FileName = newValue
    ' show the filename on the form's Caption
    Caption = IIf(newValue = "", "Untitled", newValue)
End Property

Private Sub Form_Resize()
    txtEditor.Move 0, 0, ScaleWidth, ScaleHeight
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Dim answer As Integer
    If IsDirty Then
        answer = MsgBox("This document has been modified. " & vbCr _
            & "Do you want to save it?", vbYesNoCancel + vbInformation)
        Select Case answer
            Case vbNo
                ' do nothing: the form will unload without saving data
            Case vbYes
                ' delegate to a procedure in the main MDI form
                frmMainMDI.SaveToFile Filename
            Case vbCancel
                ' refuse to unload the form
                Cancel = True
        End Select
    End If
End Sub

Private Sub txtEditor_Change()
    IsDirty = True
End Sub


