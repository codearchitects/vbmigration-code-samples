VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   495
      Left            =   1800
      TabIndex        =   0
      Top             =   1320
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


'##project:DisableMessage 0354
'##project:DisableMessage 0364
'##project:DisableMessages CodeAnalysis

Option Explicit





Private Sub Command1_Click()
    Dim pers As CPerson                          ' declaration
    Set pers = New CPerson                       ' creation
    pers.FirstName = "John"                      ' assign some properties
    pers.LastName = "Delgado"
    pers.BirthDate = "1 sep 1960"
    
    ' an alternative that uses a constructor method
    Set pers = Factory.New_CPerson("John", "Delgado", 1, "1 sep 1960")
    
    Print pers.CompleteName
    Print pers.ReverseName
    Print pers.Age
    
    pers.MaritalStatus = Divorced
    Set pers.HomeAddress = New CAddress
    pers.HomeAddress.Init "1234 North Rd", "Los Angeles", "CA", "92405"
    Print pers.HomeAddress.CompleteAddress
    
    Set pers.WorkAddress = New CAddress
    pers.WorkAddress = pers.HomeAddress
    
    
    
    ' try with a regular string value
    pers.CurrentAddress = "test address"
    Print pers.CurrentAddress
    ' try with an object value
    Set pers.CurrentAddress = pers.HomeAddress
    Print pers.CurrentAddress.CompleteAddress
    
    
    
End Sub





