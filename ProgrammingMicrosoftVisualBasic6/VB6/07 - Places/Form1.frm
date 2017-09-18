VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Object Hierarchy Demo"
   ClientHeight    =   5220
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9945
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
   ScaleHeight     =   5220
   ScaleWidth      =   9945
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picStatus 
      Align           =   2  'Align Bottom
      AutoRedraw      =   -1  'True
      Height          =   375
      Left            =   0
      ScaleHeight     =   315
      ScaleWidth      =   9885
      TabIndex        =   8
      Top             =   4845
      Width           =   9945
   End
   Begin VB.Frame Frame1 
      Caption         =   "Find Best Path"
      Height          =   3735
      Left            =   7080
      TabIndex        =   2
      Top             =   960
      Width           =   2775
      Begin VB.CommandButton cmdFind 
         Caption         =   "&Find"
         Height          =   375
         Left            =   720
         TabIndex        =   7
         Top             =   3120
         Width           =   1215
      End
      Begin VB.ComboBox cboTo 
         Height          =   360
         Left            =   240
         Style           =   2  'Dropdown List
         TabIndex        =   5
         Top             =   1320
         Width           =   2175
      End
      Begin VB.ComboBox cboFrom 
         Height          =   360
         Left            =   240
         Style           =   2  'Dropdown List
         TabIndex        =   3
         Top             =   600
         Width           =   2175
      End
      Begin VB.Label Label2 
         Caption         =   "&To place:"
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   1080
         Width           =   1575
      End
      Begin VB.Label Label1 
         Caption         =   "&From place:"
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   360
         Width           =   1575
      End
   End
   Begin VB.CommandButton cmdRedraw 
      Caption         =   "Redraw"
      Default         =   -1  'True
      Height          =   495
      Left            =   7800
      TabIndex        =   1
      Top             =   240
      Width           =   1215
   End
   Begin VB.PictureBox picMap 
      AutoRedraw      =   -1  'True
      Height          =   4695
      Left            =   0
      ScaleHeight     =   4635
      ScaleWidth      =   6915
      TabIndex        =   0
      Top             =   0
      Width           =   6975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'## project:DefaultMemberSupport True
'## project:UseByVal Yes
'## project:DisableMessage 0501


Const NUM_OF_PLACES = 20        ' the size of the problem
Const PERC_OF_SEGMENTS = 0.1    ' affects number of place connections

Dim Map As CMap          ' the top of the hierarchy

Private Sub Form_Load()
    picMap.ScaleWidth = 4300
    picMap.ScaleHeight = 4300
    
    InitTheData
    Map.Draw
    
    Dim place As CPlace
    For Each place In Map.Places
        cboFrom.AddItem place.Name
        cboTo.AddItem place.Name
    Next
    cboFrom.ListIndex = 0
    cboTo.ListIndex = 1
End Sub

Private Sub InitTheData()
    ' create the Map, and link it to the PictureBox control
    Set Map = New CMap
    Set Map.Surface = picMap
    
    ' add a few random places to the map
    Dim i As Integer, j As Integer
    For i = 1 To NUM_OF_PLACES
        Map.Places.Create "Place#" & i, Int(Rnd * 4000) + 100, Int(Rnd * 4000) + 100
    Next
    
    ' add a few random connection between them
    With Map.Places
        For i = 1 To .Count - 1
            For j = i + 1 To .Count
                ' decide if we want a connection or not
                If Rnd < PERC_OF_SEGMENTS Then
                    ' connect the two points
                    .Item(i).Segments.Create .Item(i), .Item(j)
                End If
            Next
        Next
    End With
        
End Sub

Private Sub cmdRedraw_Click()
    Map.Draw
End Sub

Private Sub cmdFind_Click()
    If cboFrom = cboTo Then
        MsgBox "Select different To/From places", vbExclamation
        Exit Sub
    End If
        
    Dim BestRoute As New CRoute
    Set BestRoute.StartPlace = Map.Places(cboFrom)
    Set BestRoute.EndPlace = Map.Places(cboTo)
    
    BestRoute.GetBestPath
    
    ' highlight the result
    Map.Draw
    If BestRoute.Path.Distance Then
        With BestRoute.Path
            .Draw Map, vbRed
            ShowStatus "Total Distance = " & .Distance
        End With
    Else
        MsgBox "No valid path exists", vbExclamation
    End If
End Sub

Sub ShowStatus(Msg As String)
    picStatus.Cls
    picStatus.Print Msg
End Sub

Private Sub Form_Resize()
    ' some intelligent resizing
    Frame1.Left = ScaleWidth - Frame1.Width - 200
    cmdRedraw.Left = Frame1.Left + (Frame1.Width - cmdRedraw.Width) / 2
    picMap.Move 0, 0, Frame1.Left - 200, ScaleHeight - picStatus.Height - 200

    picMap.ScaleWidth = 4300
    picMap.ScaleHeight = 4300

End Sub






