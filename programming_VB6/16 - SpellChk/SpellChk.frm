VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "One-Word Spelling Checker"
   ClientHeight    =   3030
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4830
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
   ScaleHeight     =   3030
   ScaleWidth      =   4830
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstSuggestions 
      Height          =   1260
      Left            =   240
      TabIndex        =   3
      Top             =   1440
      Width           =   2655
   End
   Begin VB.CommandButton cmdCheck 
      Caption         =   "&Check"
      Default         =   -1  'True
      Height          =   375
      Left            =   3000
      TabIndex        =   2
      Top             =   600
      Width           =   1455
   End
   Begin VB.TextBox txtWord 
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   600
      Width           =   2655
   End
   Begin VB.Label Label2 
      Caption         =   "Suggestions"
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   1080
      Width           =   2655
   End
   Begin VB.Label Label1 
      Caption         =   "Type the word to check"
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##AddDisposableType Word.Application
'##MSWord.AutoDispose Force

' The instance of Microsoft Word
Dim MSWord As Word.Application

Private Sub Form_Load()
    ' Create the instance of Word that will be used later.
    Set MSWord = New Word.Application
End Sub

Private Sub cmdCheck_Click()
    ' Check the word in txtWord
    Dim text As String
    Dim suggestion As Word.SpellingSuggestion
    Dim colSuggestions As Word.SpellingSuggestions
    
    text = Trim$(txtWord.text)
    If text = "" Then
        MsgBox "Please enter a word in the text box", vbExclamation
        txtWord.SetFocus
        Exit Sub
    End If
    
    ' Add a document, if there aren't any
    If MSWord.Documents.Count = 0 Then
        MSWord.Documents.Add
    End If
    
    ' check the word
    lstSuggestions.Clear
    If MSWord.CheckSpelling(text) Then
        ' The word is correct.
        lstSuggestions.AddItem "(correct)"
    Else
        ' The word is uncorrect. Get the list of suggested words.
        Set colSuggestions = MSWord.GetSpellingSuggestions(text)
        If colSuggestions.Count = 0 Then
            lstSuggestions.AddItem "(no suggestions)"
        Else
            For Each suggestion In colSuggestions
                lstSuggestions.AddItem suggestion.Name
            Next
        End If
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ' Word needs to be explictly closed.
    MSWord.Quit
End Sub
