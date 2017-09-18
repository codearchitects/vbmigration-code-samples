VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Dynamic Control Creation Demo"
   ClientHeight    =   4740
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8130
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
   ScaleHeight     =   4740
   ScaleWidth      =   8130
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdAddEditor 
      Caption         =   "Add a a windowless Editor"
      Height          =   375
      Left            =   3960
      TabIndex        =   1
      Top             =   0
      Width           =   4095
   End
   Begin VB.CommandButton cmdAddTreeView 
      Caption         =   "Add a TreeView"
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   3975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##AddDataFile "MSWLess.key"

Dim WithEvents TreeView As MSComctlLib.TreeView
Attribute TreeView.VB_VarHelpID = -1
Dim WithEvents TxtEditor As VBControlExtender
Attribute TxtEditor.VB_VarHelpID = -1

Private Sub cmdAddTreeView_Click()
    ' add a TreeView control (note the ProgID of the control)
    ' You'll probably need to modify the ProgID if you use a more
    ' recent version of MSComCtlLib library
    Set TreeView = Controls.Add("MSComctlLib.TreeCtrl.2", "TreeView")
    
    ' move and resize it, then make it visible
    TreeView.Move 0, cmdAddTreeView.Height, cmdAddTreeView.Width, ScaleHeight - cmdAddTreeView.Height
    TreeView.Checkboxes = True
    TreeView.Visible = True
    
    ' add some nodes, just to prove that it is working
    Dim i As Integer, j As Integer
    TreeView.Nodes.Add , , , "Root"
    For i = 1 To 5
        TreeView.Nodes.Add 1, tvwChild, , "Child #" & i
    Next
    TreeView.Nodes(1).Expanded = True
End Sub

Private Sub cmdAddEditor_Click()
    Dim licenseKey As String
    
    ' read the license key from a file created at design time
    ' (see the CreateLicenseKey routine)
    ''##ParseMode Remarks, 3
    Open App.Path & "\MSWLess.key" For Input As #1
    Line Input #1, licenseKey
    Close #1
    ' add to the Licenses collection
    Licenses.Add "MSWLess.WLText", licenseKey
    
    ' now it is possible to create the control
    Set TxtEditor = Controls.Add("MSWLess.WLText", "TxtEditor")
    TxtEditor.Move cmdAddEditor.Left, cmdAddEditor.Height, cmdAddEditor.Width, ScaleHeight - cmdAddEditor.Height
    TxtEditor.Visible = True
    
    ' specific (non-Extender) properties must be
    ' accessed using the Object extender property
    TxtEditor.object.MultiLine = True
    TxtEditor.object.ScrollBars = vbBoth
    TxtEditor.object.Text = "(write your text here)"
    
End Sub

' ---------------------------
'   control's events
' ---------------------------

Private Sub TreeView_NodeClick(ByVal Node As MSComctlLib.Node)
    MsgBox "You clicked node " & Node.Text
End Sub

Private Sub TxtEditor_ObjectEvent(Info As EventInfo)
    Select Case Info.Name
        Case "KeyPress"
            ' the Escape key clears the editor
            If Info.EventParameters("KeyAscii") = 27 Then
                TxtEditor.object.Text = ""
            End If
        Case "DblClick"
            ' just to prove that we can trap anything
            MsgBox "Why have you double-clicked me ?"
    End Select
End Sub

' note that extender events must be trapped separatedly

Private Sub TxtEditor_GotFocus()
    ' highlight contents on entry
    With TxtEditor.object
        .SelStart = 0
        .SelLength = 9999
    End With
End Sub


