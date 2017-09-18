VERSION 5.00
Begin VB.Form PhotoAlbum 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Photo Album"
   ClientHeight    =   5280
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7095
   Icon            =   "PhotoAlbum.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5280
   ScaleWidth      =   7095
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      Caption         =   "Fine"
      Height          =   255
      Left            =   6285
      TabIndex        =   11
      Top             =   4920
      Width           =   735
   End
   Begin VB.CommandButton Command1 
      Caption         =   "About..."
      Height          =   255
      Left            =   5520
      TabIndex        =   10
      Top             =   4920
      Width           =   735
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Thumbnail"
      Height          =   195
      Left            =   120
      TabIndex        =   8
      Top             =   4980
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00C0C0C0&
      Height          =   4620
      Left            =   2295
      ScaleHeight     =   4560
      ScaleWidth      =   4665
      TabIndex        =   1
      Top             =   120
      Width           =   4725
      Begin VB.VScrollBar VScroll1 
         Height          =   4560
         LargeChange     =   1100
         Left            =   4485
         SmallChange     =   100
         TabIndex        =   9
         Top             =   0
         Visible         =   0   'False
         Width           =   180
      End
      Begin VB.PictureBox Picture2 
         Appearance      =   0  'Flat
         AutoRedraw      =   -1  'True
         BackColor       =   &H00C0C0C0&
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   1215
         Left            =   0
         ScaleHeight     =   1215
         ScaleWidth      =   4485
         TabIndex        =   7
         Top             =   0
         Visible         =   0   'False
         Width           =   4485
         Begin VB.Image Label3 
            Height          =   1100
            Left            =   0
            Picture         =   "PhotoAlbum.frx":0442
            Stretch         =   -1  'True
            Top             =   0
            Visible         =   0   'False
            Width           =   1100
         End
      End
   End
   Begin VB.Frame Frame1 
      Height          =   4740
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   2055
      Begin VB.FileListBox File1 
         Height          =   2625
         Left            =   120
         Pattern         =   "*.gif;*.jpg;*.bmp;*.ico"
         TabIndex        =   4
         Top             =   1920
         Width           =   1815
      End
      Begin VB.DriveListBox Drive1 
         Height          =   315
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   1815
      End
      Begin VB.DirListBox Dir1 
         Height          =   1215
         Left            =   120
         TabIndex        =   2
         Top             =   600
         Width           =   1815
      End
   End
   Begin VB.Image Image2 
      BorderStyle     =   1  'Fixed Single
      Height          =   3660
      Left            =   4560
      Picture         =   "PhotoAlbum.frx":08D0
      Top             =   1560
      Visible         =   0   'False
      Width           =   3660
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "100%"
      Height          =   195
      Left            =   3960
      TabIndex        =   6
      Top             =   4980
      Width           =   390
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Proporzione immagine:"
      Height          =   195
      Left            =   2280
      TabIndex        =   5
      Top             =   4980
      Width           =   1590
   End
   Begin VB.Image Image1 
      BorderStyle     =   1  'Fixed Single
      Height          =   615
      Left            =   1800
      Top             =   4560
      Visible         =   0   'False
      Width           =   975
   End
End
Attribute VB_Name = "PhotoAlbum"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Check1_Click()

If Check1.Value = 0 Then
    Picture2.Visible = False
    VScroll1.Visible = False
    Label1.Caption = "Proporzione immagine:"
    Label2.Caption = ""
    Label3.Visible = False
Else
    Label1.Caption = "ATTENDERE..."
    Label2.Caption = "100%"
    File1_PathChange
End If

End Sub

Private Sub Command1_Click()

Load ScrollPicture

End Sub

Private Sub Command2_Click()

End

End Sub

Private Sub Dir1_Change()

File1.Path = Dir1.Path

End Sub

Private Sub Drive1_Change()

On Error Resume Next
Dir1.Path = Drive1.Drive
If Err Then
    MsgBox "PERIFERICA NON DISPONIBILE", vbExclamation, "Attenzione..."
    Drive1.Drive = Left(Dir1.Path, 2)
End If

End Sub

Private Sub File1_Click()

On Error Resume Next

Picture1.Cls

Image1.Picture = LoadPicture(Dir1.Path & "\" & File1.List(File1.ListIndex))
If Err Then
    Image1.Picture = Image2.Picture
    Err = 0
End If

Scala = 1

Alt = Image1.Height
Larg = Image1.Width

hgt = Alt
wid = Larg

If Alt > Picture1.Height Or Larg > Picture1.Width Then
    If Alt > Larg Then
        Scala = Alt / Picture1.Height
        hgt = Alt / Scala
        wid = Larg / Scala
    Else
        Scala = Larg / Picture1.Width
        hgt = Alt / Scala
        wid = Larg / Scala
    End If
End If

PctRid = 100 / Scala

Y = (Picture1.Height - hgt) / 2
X = (Picture1.Width - wid) / 2

YZ = File1.ListIndex Mod 4
XZ = Int(File1.ListIndex / 4)

If Picture2.Visible = False Then
    Label2.Caption = CLng(PctRid) & "%"
    Picture1.PaintPicture Image1.Picture, X, Y, wid, hgt
Else
    Label3.Left = YZ * 1100
    Label3.Top = XZ * 1100
    '******** MAH!!?! ********'
    Picture2.Top = -(1100 * XZ)
    '*************************'
End If

End Sub

Private Sub File1_DblClick()

Check1.Value = 0
Picture2.Visible = False
VScroll1.Visible = False
File1_Click

End Sub

Private Sub File1_PathChange()

On Error Resume Next

Picture2.Cls
Label3.Visible = False

X2 = 0
Y2 = 0

If Check1.Value = 1 Then
    If File1.ListCount > 0 Then
        Picture2.Visible = True
        VScroll1.Visible = True
        Picture2.Height = (Int(File1.ListCount / 4) * 1100)
        If (File1.ListCount Mod 4) <> 0 Then
            Picture2.Height = Picture2.Height + 1200
        End If
        If (Picture2.Height - Picture1.Height) > 32000 Then
            Prop = (Picture2.Height - Picture1.Height) / 32000
            PropVal = (Picture2.Height - Picture1.Height) / Prop
        Else
            Prop = 1
            PropVal = Picture2.Height - Picture1.Height
        End If
        VScroll1.Max = PropVal
        For Ind = 0 To File1.ListCount - 1
            Err = 0
            DoEvents
            Label2.Caption = Ind + 1
            Image1.Picture = LoadPicture(Dir1.Path & "\" & File1.List(Ind))
            If Err Then
                Image1.Picture = Image2.Picture
            End If
            
            Alt = Image1.Height
            Larg = Image1.Width
            
            hgt = Alt
            wid = Larg
            
            If Alt > 1000 Or Larg > 1000 Then
                If Alt > Larg Then
                    Scala = Alt / 1000
                    hgt = Alt / Scala
                    wid = Larg / Scala
                Else
                    Scala = Larg / 1000
                    hgt = Alt / Scala
                    wid = Larg / Scala
                End If
            End If
            
            XX = (X2 * 1100)
            YY = (Y2 * 1100)

            Picture2.PaintPicture Image1.Picture, XX + ((1100 - wid) / 2), YY + ((1100 - hgt) / 2), wid, hgt
            X2 = X2 + 1
            If X2 > 3 Then
                X2 = 0
                Y2 = Y2 + 1
            End If
        Next Ind
        Label1.Caption = "Immagini caricate:"
        File1.SetFocus
        File1.Selected(0) = True
        Label3.Visible = True
    End If
End If

VScroll1.Value = 0
If Picture1.Height > Picture2.Height Then
    VScroll1.Enabled = False
    Picture2.Height = Picture1.Height
    VScroll1.Max = 0
Else
    VScroll1.Enabled = True
End If

End Sub


Private Sub Label3_Click()

File1_DblClick

End Sub

Private Sub Picture2_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)

On Error Resume Next

XPic = Int(X / 1100)
YPic = Int(Y / 1100)

XY = (YPic * 3) + YPic + XPic

File1.Selected(XY) = True
If Err Then Exit Sub

File1_Click

End Sub

Private Sub VScroll1_Change()

VScroll1_Scroll

End Sub

Private Sub VScroll1_Scroll()

Picture2.Top = -VScroll1.Value * Prop

End Sub
