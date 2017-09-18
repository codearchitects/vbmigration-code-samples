VERSION 5.00
Begin VB.UserControl UserControl1 
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   1440
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3960
   ScaleHeight     =   1440
   ScaleWidth      =   3960
   Begin VB.Label Label1 
      Caption         =   "This ActiveX control resizes with its parent form"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   2655
   End
End
Attribute VB_Name = "UserControl1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

'##ParentForm.SetType VB6Form
Dim WithEvents ParentForm As Form
Attribute ParentForm.VB_VarHelpID = -1

Private Sub ParentForm_Resize()
    Extender.Move 0, 0, Parent.ScaleWidth, Parent.ScaleHeight
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
    On Error Resume Next
    Set ParentForm = Parent
End Sub

'##Note This is necessary to account for the fact that the ReadProperties event isn't fired under VB2005
'##InsertStatement Protected Overrides Sub EndInit()
'##InsertStatement MyBase.EndInit()
'##InsertStatement If Ambient.UserMode Then UserControl_ReadProperties (New VB6PropertyBag)
'##InsertStatement End Sub

