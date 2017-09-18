VERSION 5.00
Begin VB.Form frmSpellCheck 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Spell Checker Using Soundex and Levinshtein Distance"
   ClientHeight    =   6735
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5880
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6735
   ScaleWidth      =   5880
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCreateList 
      Caption         =   "Create Word List"
      Height          =   375
      Left            =   1200
      TabIndex        =   16
      Top             =   120
      Width           =   2175
   End
   Begin VB.ListBox lstLdMatches 
      Height          =   2400
      Left            =   3000
      TabIndex        =   9
      Top             =   3960
      Width           =   2775
   End
   Begin VB.CommandButton cmdGO 
      Caption         =   "Go!"
      Height          =   375
      Left            =   5160
      TabIndex        =   8
      Top             =   1980
      Width           =   615
   End
   Begin VB.HScrollBar LdVal 
      Height          =   225
      Left            =   135
      TabIndex        =   6
      Top             =   3135
      Width           =   5625
   End
   Begin VB.ListBox lstSoundexMatches 
      Height          =   2400
      Left            =   120
      TabIndex        =   4
      Top             =   3960
      Width           =   2775
   End
   Begin VB.TextBox txtInputWord 
      Height          =   285
      Left            =   1200
      TabIndex        =   1
      Text            =   "Verseon"
      Top             =   2025
      Width           =   3855
   End
   Begin VB.Label Label5 
      Caption         =   "Adjust the Levenshtein Threshold to see how the possible matches change. Smaller values are more accurate."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3360
      TabIndex        =   19
      Top             =   2400
      Width           =   2415
   End
   Begin VB.Label Label2 
      Caption         =   "Step 2: Test the code..."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   18
      Top             =   1560
      Width           =   5415
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      Index           =   1
      X1              =   0
      X2              =   5880
      Y1              =   1455
      Y2              =   1455
   End
   Begin VB.Line Line1 
      BorderColor     =   &H80000010&
      Index           =   0
      X1              =   0
      X2              =   5880
      Y1              =   1440
      Y2              =   1440
   End
   Begin VB.Label Label4 
      Caption         =   $"frmSpellCheck.frx":0000
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   17
      Top             =   600
      Width           =   5655
   End
   Begin VB.Label Label2 
      Caption         =   "Step 1:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   15
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label lblLDMatchCount 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Height          =   255
      Left            =   4320
      TabIndex        =   14
      Top             =   3720
      Width           =   1455
   End
   Begin VB.Label lblSndxMatchCount 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Height          =   255
      Left            =   1320
      TabIndex        =   13
      Top             =   3720
      Width           =   1575
   End
   Begin VB.Label lblLDVal 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Height          =   255
      Left            =   4680
      TabIndex        =   12
      Top             =   2880
      Width           =   1095
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   0
      TabIndex        =   11
      Top             =   6480
      Width           =   5865
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Suggestions narowed down using Levenshtein threshold"
      Height          =   495
      Index           =   3
      Left            =   3000
      TabIndex        =   10
      Top             =   3480
      Width           =   2535
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H80000010&
      Height          =   255
      Left            =   120
      Top             =   3120
      Width           =   5655
   End
   Begin VB.Label Label3 
      Caption         =   "Adjust Levenshtein threshold"
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   2880
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "All words with same soundex"
      Height          =   255
      Index           =   2
      Left            =   120
      TabIndex        =   5
      Top             =   3555
      Width           =   2295
   End
   Begin VB.Label lblSoundex 
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1200
      TabIndex        =   3
      Top             =   2400
      Width           =   2055
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Soundex:"
      Height          =   255
      Index           =   1
      Left            =   420
      TabIndex        =   2
      Top             =   2460
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Enter a word:"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   2040
      Width           =   1095
   End
End
Attribute VB_Name = "frmSpellCheck"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function GetInputState Lib "user32.dll" () As Long

Dim wordlistDB As DAO.Database
Dim cPhoneme As New clsPhoneme

'// Private Helper functions
Private Function DataIsPresentIn(ByRef TestRS As DAO.Recordset) As Boolean
On Error Resume Next
    DataIsPresentIn = True
    TestRS.MoveFirst
    If Err Then DataIsPresentIn = False
    Err.Clear
End Function

Private Sub cmdCreateList_Click()
Dim frf As Integer, tmpStr As String, i As Long
Dim wordRS As DAO.Recordset
        
    frf = FreeFile()
    Set wordRS = wordlistDB.OpenRecordset("Words")
    With wordRS
        Open App.Path & "\wl.txt" For Input As #frf
            '// Read words from the file and add to the database
            Do While Not EOF(frf)
                If GetInputState <> 0 Then DoEvents
                Line Input #frf, tmpStr
                tmpStr = Trim$(tmpStr)
                .AddNew
                    !Word = tmpStr
                    !Soundex = cPhoneme.GetSoundexWord(tmpStr)
                .Update
                '// Prevent the UI from freezing up
                i = i + 1
                If i Mod 1000 = 0 Then
                    lblStatus.Caption = "Added..." & i & " words."
                    lblStatus.Refresh
                    DoEvents
                End If
            Loop
        Close #frf
        lblStatus.Caption = "Database created! " & i & " words were added."
        .Close
        '// Just to ensure this is done only once
        frf = FreeFile()
        Open App.Path & "\words.done" For Output As #frf
        Close #frf
    End With
End Sub

Private Sub cmdGO_Click()
Dim workStr As String
Dim SndxMatchRS As DAO.Recordset
Dim navIndex As Long, navMax As Long, LdMax As Long, lenTmp As Long


    '// Get the soundex of the input word
    workStr = Trim$(txtInputWord.Text)
    If workStr <> vbNullString Then _
        lblSoundex = cPhoneme.GetSoundexWord(workStr)
        
    '// Now find all entries in the database which match the soundex of the input word
    Set SndxMatchRS = wordlistDB.OpenRecordset("SELECT [word] from Words WHERE " & _
                                               "Soundex = " & _
                                               Chr$(34) & lblSoundex.Caption & Chr$(34), _
                                               dbOpenSnapshot)
                                
    '// Populate the Listbox
    If DataIsPresentIn(SndxMatchRS) Then
        With SndxMatchRS
            .MoveLast
            navMax = .RecordCount
            .MoveFirst
            lstSoundexMatches.Clear
            
            '// TIP: Use LB_INITSTORAGE with sendmessage here
            
            
            For navIndex = 1 To navMax
                If GetInputState <> 0 Then DoEvents
                lstSoundexMatches.AddItem !Word
                '// The max length of returned matches is the maximum Leveshtein
                '// distance we can have
                lenTmp = Len(!Word)
                If lenTmp > LdMax Then LdMax = lenTmp
                
                .MoveNext
                
                If navIndex Mod 5 = 0 Then
                    lblStatus.Caption = "Adding items..." & FormatPercent$(navIndex \ navMax) & " added."
                    lblStatus.Refresh
                End If
            
            Next navIndex
            lblStatus.Caption = vbNullString
            lblSndxMatchCount.Caption = lstSoundexMatches.ListCount & " matches."
        End With
        
        With LdVal
            .Max = LdMax
            .Min = 0
            .Value = LdMax \ 2
            lblLDVal = .Value
        End With
    End If
               
End Sub

Private Sub Form_Load()
    Set wordlistDB = OpenDatabase(App.Path & "\words.mdb", False, False)
    '// '// Just to ensure this is done only once
    If Dir$(App.Path & "\words.done") = vbNullString Then
        cmdCreateList.Enabled = True
    Else
        cmdCreateList.Enabled = False
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    wordlistDB.Close
    Set cPhoneme = Nothing
End Sub

Private Sub LdVal_Change()
Dim i As Long, threshold As Long, LD As Long
Dim strInput As String, striMatch As String

    strInput = UCase$(Trim$(txtInputWord.Text))
    threshold = LdVal.Value
    lstLdMatches.Clear
    '// walk through all soundex matches
    For i = 0 To lstSoundexMatches.ListCount
        striMatch = Trim$(lstSoundexMatches.List(i))
        If striMatch <> vbNullString Then
            If GetInputState <> 0 Then DoEvents
            LD = cPhoneme.GetLevenshteinDistance(strInput, UCase$(striMatch))
            
            '// Get all Levenshtein distances less than the scroll(threshold) value
            If LD <= threshold Then
                If LD < lstLdMatches.ListCount Then
                    '// Add better matches up
                    lstLdMatches.AddItem striMatch, LD
                Else
                    lstLdMatches.AddItem striMatch
                End If
            End If
            
            If i Mod 5 = 0 Then
                lblStatus.Caption = "Adding items..." & i & "matches found."
                lblStatus.Refresh
            End If
        End If
    Next
    lblLDMatchCount.Caption = lstLdMatches.ListCount
    
    LdVal_Scroll
End Sub

Private Sub LdVal_Scroll()
    lblLDVal.Caption = LdVal.Value
End Sub
