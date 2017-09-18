VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Persist CPerson hierarchy"
   ClientHeight    =   4530
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6030
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
   ScaleHeight     =   4530
   ScaleWidth      =   6030
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdLoad 
      Caption         =   "&Load File"
      Height          =   495
      Left            =   4200
      TabIndex        =   6
      Top             =   3840
      Width           =   1455
   End
   Begin VB.CommandButton cmdWrite 
      Caption         =   "&Write File"
      Height          =   495
      Left            =   4200
      TabIndex        =   5
      Top             =   3360
      Width           =   1455
   End
   Begin VB.CommandButton cmdDestroy 
      Caption         =   "&Destroy"
      Height          =   495
      Left            =   4200
      TabIndex        =   4
      Top             =   600
      Width           =   1455
   End
   Begin VB.CommandButton cmdDisplay 
      Caption         =   "&Display"
      Height          =   495
      Left            =   4200
      TabIndex        =   3
      Top             =   1320
      Width           =   1455
   End
   Begin VB.CommandButton cmdRestore 
      Caption         =   "&Restore"
      Height          =   495
      Left            =   4200
      TabIndex        =   2
      Top             =   2640
      Width           =   1455
   End
   Begin VB.CommandButton cmdCreate 
      Caption         =   "&Create"
      Height          =   495
      Left            =   4200
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   495
      Left            =   4200
      TabIndex        =   0
      Top             =   2160
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:UseByVal Yes

'##pers.AutoNew True
Dim pers As CPerson
Dim pb As PropertyBag

Private Sub Form_Load()
    SetButtonState
End Sub

' Initialize a CPerson object.

Private Sub cmdCreate_Click()
    ' Create the root of the hierarchy
    Set pers = CreatePerson("John Smith", "Australian")
    ' Add three children
    pers.Children.Add CreatePerson("Robert Smith")
    pers.Children.Add CreatePerson("Ann Smith")
    pers.Children.Add CreatePerson("Christine Smith")
    ' Add two grandchildren
    pers.Children(3).Children.Add CreatePerson("Patrick Smith")
    pers.Children(3).Children.Add CreatePerson("Mary Smith")
    
    SetButtonState
End Sub

' Destroy the object. Click on this button before restoring an
' object, to prove that persistence actually worked.

Private Sub cmdDestroy_Click()
    Set pers = Nothing
    SetButtonState
End Sub

' Display the hierarchy

Private Sub cmdDisplay_Click()
    Cls
    If pers Is Nothing Then
        Print "Pers is Nothing"
    Else
        ShowPerson pers
    End If
End Sub

' Show a person and its children (recursive routine)

Private Sub ShowPerson(pers As CPerson, Optional level As Integer)
    Dim child As CPerson
    ' Show info on this person, correctly indented.
    Print Space$(6 * level) & pers.Name & " (" & pers.Citizenship; ")"
    ' Show its children, if any.
    If pers.Children.Count Then
        For Each child In pers.Children
            ShowPerson child, level + 1
        Next
    End If
End Sub

' Save the CPerson object in a PropertyBag.

Private Sub cmdSave_Click()
    Set pb = New PropertyBag
    ' The next statement fires a WriteProperties event in the CPerson class.
    pb.WriteProperty "APerson", pers
    
    SetButtonState
End Sub

Private Sub cmdRestore_Click()
    ' To prove that persistence works, destroy the object first
    Set pers = Nothing
    ' The next statement fires a ReadProperties event in the CPerson class.
    Set pers = pb.ReadProperty("APerson")
End Sub

' Save the PropertyBag object to file.

Private Sub cmdWrite_Click()
    Dim tmp As Variant
    Open App.Path & "\Propbag.dat" For Binary As #1
    ' Using a variant is simpler.
    tmp = pb.Contents
    Put #1, , tmp
    Close #1
End Sub

' Reload a PropertyBag object from file.
' Should be followed by a Restore operation to restore the object.

Private Sub cmdLoad_Click()
    Dim tmp As Variant
    Open App.Path & "\Propbag.dat" For Binary As #1
    ' Using a variant is simpler.
    Get #1, , tmp
    Set pb = New PropertyBag
    pb.Contents = tmp
    Close #1
    SetButtonState
End Sub

' Private function that sets all button's state

Private Sub SetButtonState()
    cmdCreate.Enabled = (pers Is Nothing)
    cmdDestroy.Enabled = Not (pers Is Nothing)
    cmdDisplay.Enabled = True
    cmdSave.Enabled = Not (pers Is Nothing)
    cmdRestore.Enabled = Not (pb Is Nothing)
    cmdWrite.Enabled = Not (pb Is Nothing)
    cmdLoad.Enabled = True
End Sub

' Private function that creates a CPerson object

Private Function CreatePerson(Name As String, Optional Citizenship As Variant) As CPerson
    Set CreatePerson = New CPerson
    CreatePerson.Name = Name
    If Not IsMissing(Citizenship) Then CreatePerson.Citizenship = Citizenship
End Function


