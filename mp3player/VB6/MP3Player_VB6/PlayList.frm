VERSION 5.00
Begin VB.Form PlayList 
   BackColor       =   &H0000FFFF&
   BorderStyle     =   0  'None
   Caption         =   "Playlist"
   ClientHeight    =   4620
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3525
   DrawWidth       =   10
   Icon            =   "PlayList.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   OLEDropMode     =   1  'Manual
   ScaleHeight     =   4620
   ScaleWidth      =   3525
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Piclst 
      BorderStyle     =   0  'None
      Height          =   3150
      Left            =   675
      ScaleHeight     =   3150
      ScaleWidth      =   2085
      TabIndex        =   3
      Top             =   675
      Width           =   2085
      Begin VB.ListBox lstPL 
         Appearance      =   0  'Flat
         BackColor       =   &H00F0F0F0&
         Height          =   3150
         ItemData        =   "PlayList.frx":000C
         Left            =   0
         List            =   "PlayList.frx":000E
         OLEDropMode     =   1  'Manual
         TabIndex        =   4
         Top             =   0
         Width           =   2085
      End
   End
   Begin VB.PictureBox PicClose 
      AutoRedraw      =   -1  'True
      BackColor       =   &H000000FF&
      BorderStyle     =   0  'None
      Height          =   255
      Left            =   0
      ScaleHeight     =   17
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   70
      TabIndex        =   1
      Top             =   0
      Width           =   1050
      Begin VB.Image Close 
         Height          =   150
         Left            =   885
         Top             =   120
         Width           =   165
      End
   End
   Begin VB.PictureBox PicMMask 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BackColor       =   &H000000FF&
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      Height          =   4530
      Left            =   0
      Picture         =   "PlayList.frx":0010
      ScaleHeight     =   302
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   226
      TabIndex        =   0
      Top             =   0
      Width           =   3390
      Begin VB.Shape Shape1 
         BackStyle       =   1  'Opaque
         Height          =   3150
         Left            =   675
         Shape           =   4  'Rounded Rectangle
         Top             =   675
         Width           =   2085
      End
   End
   Begin VB.Label lblen 
      AutoSize        =   -1  'True
      Caption         =   "Label1"
      Height          =   195
      Left            =   1155
      TabIndex        =   2
      Top             =   2070
      Width           =   480
   End
End
Attribute VB_Name = "PlayList"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Docked As Boolean
Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long

Public Sub Dock()
    'comb = MakeRegion(Player.picMainSkin)
    'WindowRegion = MakeRegion(PlayList.PicMMask)
    'OffsetRgn WindowRegion, -5, 168
    'CombineRgn comb, WindowRegion, comb, 2
    'SetWindowRgn Player.hWnd, comb, True
    
'    If Docked Then
'        SetParent Me.hWnd, 0
'    Else
'        SetParent Me.hWnd, Player.hWnd
'        Move -15 * 8, 15 * 139
'    End If
    shapebig Player
End Sub

Private Sub Close_Click()
    Player.PL_Click
End Sub

Private Sub Form_Activate()
    PicMMask.Visible = Player.Image1.Visible
    If Player.MnuOntop.Checked Then
        SetWindowPos Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE
    End If
End Sub

Private Sub Form_DblClick()
    Docked = Not Docked
    If Not Docked Then
        shapemain Player
        SetWindowPos Me.hWnd, 0, (Player.Left) / 15 - 5 - 15, (Player.Top) / 15 + 168 + 15, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOACTIVATE
        SetParent Me.hWnd, 0
    Else
        shapebig Player
        SetParent Me.hWnd, Player.hWnd
        SetWindowPos Me.hWnd, 0, -8, 139, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOACTIVATE
        'Move -15 * 8, 15 * 139
    End If
End Sub

Private Sub Form_Load()
    Docked = True
    shapebig Player
    'comb = MakeRegion(Player.picMainSkin)
    WindowRegion = MakeRegion(PlayList.PicMMask)
    'OffsetRgn WindowRegion, -5, 168
    'CombineRgn comb, WindowRegion, comb, 2
    'SetWindowRgn Player.hWnd, comb, True
    'Dock
    'OffsetRgn WindowRegion, 5, -168
    SetWindowRgn Me.hWnd, WindowRegion, True
    PlayList.DrawMode = vbCopyPen
    SetParent Me.hWnd, Player.hWnd
    Move -15 * 8, 15 * 139
    WindowRegion = CreateRoundRectRgn(1, 1, Piclst.Width / 15, Piclst.Height / 15 + 0, 31, 32)
    SetWindowRgn Piclst.hWnd, WindowRegion, True
    For i = 1 To 0
    lstPL.AddItem "   " & CheckSize(Format(i, "00") & ". File" & i)
    Next i
    Docked = True
    PicClose.Picture = PicMMask.Picture

End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Not Docked Then
        ReleaseCapture
        SendMessage Me.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
        ReleaseCapture
        SendMessage Player.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
    'End If
    Else
        ReleaseCapture
        SendMessage Player.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
    End If
    'MsgBox Top
End Sub


Private Function CheckSize(exp As String) As String
    Dim d3 As String
    lblen = exp
    Do While lblen.Width > lstPL.Width - 15 * 20
        lblen = Left$(lblen, Len(lblen) - 1)
        td = "..."
    Loop
    CheckSize = lblen & td
End Function

Private Sub Form_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Player.Form_MouseUp Button, Shift, X, Y
End Sub

Private Sub Form_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    Dim CheckExt As Boolean
    If Data.GetFormat(vbCFFiles) Then
    ' בדיקה האם המידע מהקובץ הוא מהסוג הרצוי
        CheckExt = LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mp3" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".rmi" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mid" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".wav"
        Effect = vbDropEffectCopy And Effect
        If Data.Files.Count = 1 And CheckExt Then Exit Sub
    End If
    ' אם המידע הוא מהסוג הרצוי אז אל תאפשר השלכה
    Effect = vbDropEffectNone

End Sub

Private Sub Form_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Player.Form_OLEDragDrop Data, Effect, Button, Shift, X, Y
End Sub

Private Sub lstPL_Click()
    lstPL.ToolTipText = Dir(LstData(lstPL.ListIndex))
End Sub

Private Sub LstPL_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    On Error Resume Next
    Dim CheckExt As Boolean
    For Each vFileName In Data.Files
        If Data.GetFormat(vbCFFiles) Then
            CheckExt = LCase(Right(Dir(vFileName), 4)) = ".mp3" Or LCase(Right(Dir(vFileName), 4)) = ".rmi" Or LCase(Right(Dir(vFileName), 4)) = ".mid" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".wav"
            If CheckExt Then
                If Dir(CStr(vFileName)) <> "" Then
                    AddPLItem vFileName
'                    lstPL.AddItem CheckSize("   " & Format(lstPL.ListCount + 1, "00") & ". " & Dir(vFileName))
'                    LstData(lstPL.ListCount - 1) = vFileName
                End If
            Else
                If Data.Files.Count = 1 Then MsgBox "Unsupported file format", vbCritical
            End If
        End If
    Next vFileName
End Sub

Public Sub lstPL_DblClick()
    'MsgBox
    If Dir(LstData(lstPL.ListIndex)) <> "" Then
        If Player.mediafile <> LstData(lstPL.ListIndex) Then
            Player.MnuClose_Click
            Player.mediafile = LstData(lstPL.ListIndex)
            Player.PLSong = lstPL.ListIndex + 1
            Player.OpenFile LstData(lstPL.ListIndex), Dir(LstData(lstPL.ListIndex))
        End If
        Player.play_Click
    End If
    'OpenFile Data.Files.Item(1), Dir(Data.Files.Item(1))
End Sub

Private Sub lstPL_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
'    Form_MouseDown Button, Shift, X, Y
End Sub


Public Sub AddPLItem(vFileName)
    Dim CheckExt As Boolean
    CheckExt = LCase(Right(Dir(vFileName), 4)) = ".mp3" Or LCase(Right(Dir(vFileName), 4)) = ".rmi" Or LCase(Right(Dir(vFileName), 4)) = ".mid" Or LCase(Right(Dir(vFileName), 4)) = ".wav"
    If CheckExt = True Then
        lstPL.AddItem CheckSize("   " & Format(lstPL.ListCount + 1, "00") & ". " & Dir(vFileName))
        LstData(lstPL.ListCount - 1) = vFileName
    End If
End Sub
