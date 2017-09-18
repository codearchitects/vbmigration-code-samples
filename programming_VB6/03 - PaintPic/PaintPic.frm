VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "PaintPicture Demo"
   ClientHeight    =   5925
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9600
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
   ScaleHeight     =   5925
   ScaleWidth      =   9600
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShow 
      Caption         =   "&Show"
      Default         =   -1  'True
      Height          =   375
      Left            =   7080
      TabIndex        =   11
      Top             =   5160
      Width           =   1815
   End
   Begin VB.Frame fraFlip 
      Caption         =   "Filp"
      Height          =   2055
      Left            =   6720
      TabIndex        =   7
      Top             =   2760
      Width           =   2535
      Begin VB.CommandButton cmdBoth 
         Caption         =   "&Both"
         Height          =   375
         Left            =   360
         TabIndex        =   10
         Top             =   1320
         Width           =   1815
      End
      Begin VB.CommandButton cmdVertical 
         Caption         =   "&Vertical"
         Height          =   375
         Left            =   360
         TabIndex        =   9
         Top             =   840
         Width           =   1815
      End
      Begin VB.CommandButton cmdHorizontal 
         Caption         =   "&Horizontal"
         Height          =   375
         Left            =   360
         TabIndex        =   8
         Top             =   360
         Width           =   1815
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "&Effects"
      Height          =   975
      Left            =   6720
      TabIndex        =   5
      Top             =   0
      Width           =   2655
      Begin VB.ComboBox cboDissolve 
         Height          =   360
         ItemData        =   "PaintPic.frx":0000
         Left            =   120
         List            =   "PaintPic.frx":0025
         Style           =   2  'Dropdown List
         TabIndex        =   6
         Top             =   360
         Width           =   2295
      End
   End
   Begin VB.Frame fraZoom 
      Caption         =   "&Zoom"
      Height          =   1455
      Left            =   6720
      TabIndex        =   2
      Top             =   1080
      Width           =   2655
      Begin VB.ComboBox cboZoom 
         Height          =   360
         ItemData        =   "PaintPic.frx":00DA
         Left            =   120
         List            =   "PaintPic.frx":0105
         TabIndex        =   4
         Text            =   "100%"
         Top             =   480
         Width           =   2295
      End
      Begin VB.CheckBox chkTile 
         Caption         =   "&Tile bitmap"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   960
         Width           =   2055
      End
   End
   Begin VB.PictureBox picDest 
      Height          =   5415
      Left            =   120
      ScaleHeight     =   5355
      ScaleWidth      =   6315
      TabIndex        =   1
      Top             =   120
      Width           =   6375
   End
   Begin VB.PictureBox picSource 
      AutoSize        =   -1  'True
      Height          =   3900
      Left            =   3120
      Picture         =   "PaintPic.frx":0174
      ScaleHeight     =   3840
      ScaleWidth      =   3840
      TabIndex        =   0
      Top             =   3840
      Visible         =   0   'False
      Width           =   3900
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##DisableMessage 0501

Option Explicit

Private Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)

Dim flipped As Integer  ' bit field

Private Sub Form_Load()
    ' we need to make the form visible, first
    Show
    DoEvents
    ' then we can show the image (this cause a refresh)
    cboDissolve.ListIndex = 0
End Sub

Private Sub cboZoom_Click()
    cmdShow.Value = True
End Sub

Private Sub chkTile_Click()
    cmdShow.Value = True
End Sub

Private Sub cboDissolve_Click()
    fraZoom.Enabled = (cboDissolve.ListIndex = 0)
    cmdHorizontal.Enabled = (cboDissolve.ListIndex = 0)
    cmdVertical.Enabled = (cboDissolve.ListIndex = 0)
    cmdBoth.Enabled = (cboDissolve.ListIndex = 0)
    cmdShow.Value = True
End Sub

Private Sub cmdShow_Click()
    If cboDissolve.ListIndex = 0 Then
        ShowImage
    Else
        DissolveImage
    End If
    flipped = 0
End Sub

Sub ShowImage()
    ' show the hidden image
    Dim destWidth As Single, destHeight As Single
    Dim destX As Single, destY As Single
    Dim stepX As Single, stepY As Single
    
    ' determine zoom factor
    Select Case cboZoom.ListIndex
        Case cboZoom.ListCount - 4
            ' fit width
            destWidth = picDest.ScaleWidth
            destHeight = picSource.ScaleHeight * (destWidth / picSource.ScaleWidth)
        Case cboZoom.ListCount - 3
            ' fit height
            destHeight = picDest.ScaleHeight
            destWidth = picSource.ScaleWidth * (destHeight / picSource.ScaleWidth)
        Case cboZoom.ListCount - 2
            ' fit page (no distorsion)
            destWidth = picDest.ScaleWidth
            destHeight = picDest.ScaleHeight
            If destWidth / picSource.ScaleWidth < destHeight / picDest.ScaleHeight Then
                ' fit width, adjust height
                destHeight = picSource.ScaleHeight * (destWidth / picSource.ScaleWidth)
            Else
                ' fit height, adjust width
                destWidth = picSource.ScaleWidth * (destHeight / picSource.ScaleWidth)
            End If
        Case cboZoom.ListCount - 1
            ' fit page (distorsion)
            destWidth = picDest.ScaleWidth
            destHeight = picDest.ScaleHeight
        Case Else
            On Error Resume Next
            destWidth = picSource.ScaleWidth * Val(cboZoom) / 100
            destHeight = picSource.ScaleHeight * Val(cboZoom) / 100
            If Err Then Exit Sub
    End Select
    
    picDest.Cls
    
    If chkTile.Value = vbChecked Then
        ' tile images
        For destX = 0 To picDest.ScaleWidth Step destWidth
            For destY = 0 To picDest.ScaleHeight Step destHeight
                picDest.PaintPicture picSource.Picture, destX, destY, destWidth, destHeight
            Next
        Next
    Else
        ' simple copy
        picDest.PaintPicture picSource.Picture, 0, 0, destWidth, destHeight
    End If
End Sub

Sub DissolveImage()
    ' show the hidden image
    Dim srcWidth As Single, srcHeight As Single
    Dim srcX As Single, srcY As Single
    Dim destWidth As Single, destHeight As Single
    Dim destX As Single, destY As Single
    Dim stepX As Single, stepY As Single
    Dim i As Integer
    
    Const DISSOLVE_STEPS = 20
    
    ' most routine below use these values
    srcWidth = picSource.ScaleWidth
    srcHeight = picSource.ScaleHeight
        
    stepX = srcWidth / DISSOLVE_STEPS
    stepY = srcHeight / DISSOLVE_STEPS
    
    picDest.Cls
    
    Select Case cboDissolve.ListIndex
        Case 1
            ' Scroll from Left
            srcX = srcWidth
            For i = 1 To DISSOLVE_STEPS
                srcX = srcX - stepX
                picDest.PaintPicture picSource.Picture, 0, 0, , , srcX, 0
                RefreshAndDelay
            Next
        Case 2
            ' Scroll from right
            destX = srcWidth
            For i = 1 To DISSOLVE_STEPS
                destX = destX - stepX
                picDest.PaintPicture picSource.Picture, destX, 0, srcWidth - destX, , , , srcWidth - destX
                RefreshAndDelay
            Next
        Case 3
            ' Scroll from Top
            srcY = srcHeight
            For i = 1 To DISSOLVE_STEPS
                srcY = srcY - stepY
                picDest.PaintPicture picSource.Picture, 0, 0, , , 0, srcY
                RefreshAndDelay
            Next
        Case 4
            ' Scroll from bottom
            destY = srcHeight
            For i = 1 To DISSOLVE_STEPS
                destY = destY - stepY
                picDest.PaintPicture picSource.Picture, 0, destY, , , , , , srcHeight - destY
                RefreshAndDelay
            Next
            
        Case 5
            ' Roll from Left
            destWidth = 0
            For i = 1 To DISSOLVE_STEPS
                destWidth = destWidth + stepX
                picDest.PaintPicture picSource.Picture, 0, 0, , , 0, 0, destWidth
                RefreshAndDelay
            Next
        Case 6
            ' Roll from right
            destX = srcWidth
            For i = 1 To DISSOLVE_STEPS
                destX = destX - stepX
                picDest.PaintPicture picSource.Picture, destX, 0, , , destX, 0, srcWidth - destX
                RefreshAndDelay
            Next
        Case 7
            ' Roll from Top
            destHeight = 0
            For i = 1 To DISSOLVE_STEPS
                destHeight = destHeight + stepY
                picDest.PaintPicture picSource.Picture, 0, 0, , , 0, 0, , destHeight
                RefreshAndDelay
            Next
        Case 8
            ' Roll from bottom
            destY = srcHeight
            For i = 1 To DISSOLVE_STEPS
                destY = destY - stepY
                picDest.PaintPicture picSource.Picture, 0, destY, , , 0, destY, , srcHeight - destY
                RefreshAndDelay
            Next
        Case 9
            ' explode
            destX = srcWidth / 2
            destY = srcHeight / 2
            srcWidth = 0
            srcHeight = 0
            For i = 1 To DISSOLVE_STEPS
                destX = destX - stepX / 2
                destY = destY - stepY / 2
                srcWidth = srcWidth + stepX
                srcHeight = srcHeight + stepY
                picDest.PaintPicture picSource.Picture, destX, destY, , , destX, destY, srcWidth, srcHeight
                RefreshAndDelay
            Next
        Case 10
            ' mosaic
            ' first, prepare the matrix of the (X,Y) coordinates
            ' for all the tiles
            Dim xy(DISSOLVE_STEPS * DISSOLVE_STEPS, 1) As ShiftConstants
            Dim kx As Integer, ky As Integer, ndx As Integer
            destX = 0
            For kx = 1 To DISSOLVE_STEPS
                destY = 0
                For ky = 1 To DISSOLVE_STEPS
                    i = i + 1
                    xy(i, 0) = destX
                    xy(i, 1) = destY
                    destY = destY + stepY
                Next
                destX = destX + stepX
            Next
            ' this loop picks up a random tile, draws it and then
            ' deletes it from the xy() array so that it can't be
            ' selected any more
            For ndx = UBound(xy) To 1 Step -1
                ' draw the tile
                i = Int(Rnd * ndx + 1)
                destX = xy(i, 0)
                destY = xy(i, 1)
                picDest.PaintPicture picSource.Picture, destX, destY, , , destX, destY, stepX, stepY
                ' delete it from xy() - actually it just replace it
                ' with the last item in the array
                xy(i, 0) = xy(ndx, 0)
                xy(i, 1) = xy(ndx, 1)
            Next
    End Select

End Sub

Private Sub cmdHorizontal_Click()
    ' flip the image horizontally
    flipped = flipped Xor 1
    ShowFlippedImage
End Sub

Private Sub cmdVertical_Click()
    ' flip the image vertically
    flipped = flipped Xor 2
    ShowFlippedImage
End Sub

Private Sub cmdBoth_Click()
    ' flip the image on both axis
    flipped = flipped Xor 3
    ShowFlippedImage
End Sub

Sub ShowFlippedImage()
    picDest.Cls
    Select Case flipped
        Case 0
            picDest.PaintPicture picSource.Picture, 0, 0
        Case 1
            ' flip the image horizontally
            picDest.PaintPicture picSource.Picture, picSource.ScaleWidth, 0, -picSource.ScaleWidth
        Case 2
            ' flip the image vertically
            picDest.PaintPicture picSource.Picture, 0, picSource.ScaleHeight, , -picSource.ScaleHeight
        Case 3
            ' flip the image on both axis
            picDest.PaintPicture picSource.Picture, picSource.ScaleWidth, picSource.ScaleHeight, -picSource.ScaleWidth, -picSource.ScaleHeight
    End Select
End Sub

Sub RefreshAndDelay()
    'Refresh
    Sleep 50
End Sub

