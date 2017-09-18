VERSION 5.00
Begin VB.Form frmPerson 
   Caption         =   "Person "
   ClientHeight    =   3450
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7620
   LinkTopic       =   "Form1"
   ScaleHeight     =   3450
   ScaleWidth      =   7620
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkMarried 
      Caption         =   "&Married"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3720
      TabIndex        =   7
      Top             =   2640
      Width           =   2175
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   495
      Left            =   6240
      TabIndex        =   6
      Top             =   600
      Width           =   1215
   End
   Begin VB.TextBox txtCity 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   5
      Top             =   2640
      Width           =   3015
   End
   Begin VB.TextBox txtAddress 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   4
      Top             =   1560
      Width           =   5775
   End
   Begin VB.TextBox txtName 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   3
      Top             =   600
      Width           =   5775
   End
   Begin VB.Label Label1 
      Caption         =   "&City"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   240
      TabIndex        =   2
      Top             =   2280
      Width           =   3375
   End
   Begin VB.Label Label1 
      Caption         =   "&Address"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   1
      Top             =   1200
      Width           =   3375
   End
   Begin VB.Label Label1 
      Caption         =   "&Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3375
   End
End
Attribute VB_Name = "frmPerson"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' the associated CPerson object
Private WithEvents ThisPerson As CPerson
Attribute ThisPerson.VB_VarHelpID = -1

Public Property Get Person() As CPerson
    Set Person = ThisPerson
End Property

Public Property Set Person(newValue As CPerson)
    ' initialize the private object and form fields
    Set ThisPerson = newValue
    With ThisPerson
        txtName.Text = .Name
        txtAddress.Text = .Address
        txtCity.Text = .City
        chkMarried.Value = Abs(.Married)
    End With
End Property

Private Sub txtName_Change()
    ' if key-level notification is active
    If NotifyMode = 2 Then ThisPerson.Name = txtName
End Sub

Private Sub txtName_LostFocus()
    ' if field-level notification is active
    If NotifyMode = 1 Then ThisPerson.Name = txtName
End Sub

Private Sub txtAddress_Change()
    ' if key-level notification is active
    If NotifyMode = 2 Then ThisPerson.Address = txtAddress
End Sub

Private Sub txtAddress_LostFocus()
    ' if field-level notification is active
    If NotifyMode = 1 Then ThisPerson.Address = txtAddress
End Sub

Private Sub txtCity_Change()
    ' if key-level notification is active
    If NotifyMode = 2 Then ThisPerson.City = txtCity
End Sub

Private Sub txtCity_LostFocus()
    ' if field-level notification is active
    If NotifyMode = 1 Then ThisPerson.City = txtCity
End Sub

Private Sub chkMarried_Click()
    ' if key-level notification is active
    If NotifyMode = 2 Then ThisPerson.Married = chkMarried
End Sub

Private Sub chkMarried_LostFocus()
    ' if field-level notification is active
    If NotifyMode = 1 Then ThisPerson.Married = chkMarried
End Sub

Private Sub ThisPerson_Change(PropertyName As String)
    Select Case PropertyName
        Case "Name"
            txtName.Text = ThisPerson.Name
        Case "Address"
            txtAddress.Text = ThisPerson.Address
        Case "City"
            txtCity.Text = ThisPerson.City
        Case "Married"
            chkMarried.Value = Abs(ThisPerson.Married)
    End Select
End Sub

Private Sub cmdOK_Click()
    ' validate all properties
    On Error Resume Next
    
    ThisPerson.Name = txtName.Text
    If Err Then
        MsgBox Err.Description
        txtName.SetFocus
        Exit Sub
    End If
    
    ThisPerson.Address = txtAddress.Text
    If Err Then
        MsgBox Err.Description
        txtAddress.SetFocus
        Exit Sub
    End If
    
    ThisPerson.City = txtCity.Text
    If Err Then
        MsgBox Err.Description
        txtCity.SetFocus
        Exit Sub
    End If
    
    ThisPerson.Married = chkMarried.Value
    ' error checking is not necessary here, but this is a good programming
    ' practice, in case we later add validation in the CPerson class
    If Err Then
        MsgBox Err.Description
        txtName.SetFocus
        Exit Sub
    End If
    
End Sub


