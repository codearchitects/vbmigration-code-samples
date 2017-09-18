VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Image Preview"
   ClientHeight    =   5535
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9495
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
   ScaleHeight     =   5535
   ScaleWidth      =   9495
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picPreview 
      Height          =   4935
      Left            =   3120
      ScaleHeight     =   4875
      ScaleWidth      =   6195
      TabIndex        =   9
      Top             =   480
      Width           =   6255
   End
   Begin VB.OptionButton optTile 
      Caption         =   "&3. Tile"
      Height          =   375
      Left            =   6960
      TabIndex        =   8
      Top             =   120
      Width           =   1815
   End
   Begin VB.OptionButton optStretch 
      Caption         =   "&2. Stretch"
      Height          =   375
      Left            =   5040
      TabIndex        =   7
      Top             =   120
      Width           =   1815
   End
   Begin VB.OptionButton optActual 
      Caption         =   "&1 Actual size"
      Height          =   375
      Left            =   3120
      TabIndex        =   6
      Top             =   120
      Value           =   -1  'True
      Width           =   1695
   End
   Begin VB.FileListBox File1 
      Height          =   2010
      Left            =   120
      TabIndex        =   5
      Top             =   3360
      Width           =   2775
   End
   Begin VB.DirListBox Dir1 
      Height          =   1440
      Left            =   120
      TabIndex        =   3
      Top             =   1320
      Width           =   2775
   End
   Begin VB.DriveListBox Drive1 
      Height          =   360
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   2775
   End
   Begin VB.Image imgHidden 
      Height          =   615
      Left            =   2520
      Top             =   0
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "&File"
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   3000
      Width           =   2775
   End
   Begin VB.Label Label2 
      Caption         =   "&Path"
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   960
      Width           =   2415
   End
   Begin VB.Label Label1 
      Caption         =   "&Drive"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2415
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    Drive1.Drive = "c:"
    Dir1.Path = "c:\windows"
    File1.Pattern = "*.bmp;*.dib;*.wmf;*.emf;*.gif;*.jpg"
End Sub

Private Sub Drive1_Change()
    ' beware: the Drive property also returns the volume label
    Dir1.Path = Left$(Drive1.Drive, 1) & ":\"
End Sub

Private Sub Dir1_Change()
    File1.Path = Dir1.Path
End Sub

Private Sub File1_Click()
    ' load the image in the hidden Image control
    LoadImage File1.Path & IIf(Right$(File1.Path, 1) <> "\", "\", "") & File1.filename
End Sub

Private Sub Form_Resize()
    On Error Resume Next
    File1.Height = ScaleHeight - File1.Top
    picPreview.Move picPreview.Left, picPreview.Top, ScaleWidth - picPreview.Left, ScaleHeight - picPreview.Top
    ShowImage
End Sub

Private Sub optActual_Click()
    ShowImage
End Sub

Private Sub optStretch_Click()
    ShowImage
End Sub

Private Sub optTile_Click()
    ShowImage
End Sub

Sub LoadImage(filename As String)
    On Error Resume Next
    Set imgHidden.Picture = LoadPicture(filename)
    If Err Then
        MsgBox "Unable to load file " & filename, vbExclamation
        Exit Sub
    End If
    ' show it,and modify the form's caption
    ShowImage
    Caption = filename & "- Image Preview"
End Sub

Sub ShowImage()
    ' show the image
    Dim x As Single, y As Single
    
    If optActual.Value Then
        ' show in the center
        picPreview.Cls
        picPreview.PaintPicture imgHidden.Picture, (picPreview.ScaleWidth - imgHidden.Width) / 2, (picPreview.ScaleHeight - imgHidden.Height) / 2
    ElseIf optStretch.Value Then
        ' stretch
        picPreview.PaintPicture imgHidden.Picture, 0, 0, picPreview.ScaleWidth, picPreview.ScaleHeight
    ElseIf optTile.Value Then
        ' tile
        ' this code only works if imgHidden.BorderStyle = 0
        
        x = 0
        Do While x < picPreview.ScaleWidth
            y = 0
            Do While y < picPreview.ScaleHeight
                picPreview.PaintPicture imgHidden.Picture, x, y
                y = y + imgHidden.Height
            Loop
            x = x + imgHidden.Width
        Loop
    End If

End Sub

