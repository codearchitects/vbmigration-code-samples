VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Palette Workbench"
   ClientHeight    =   6915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9540
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
   ScaleHeight     =   6915
   ScaleWidth      =   9540
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Show"
      Height          =   495
      Left            =   2640
      TabIndex        =   7
      Top             =   6000
      Width           =   855
   End
   Begin VB.Frame Frame1 
      Caption         =   "PaletteMode setting"
      Height          =   1695
      Left            =   4920
      TabIndex        =   3
      Top             =   4560
      Width           =   3975
      Begin VB.OptionButton optCustom 
         Caption         =   "&2. Custom palette"
         Height          =   375
         Left            =   240
         TabIndex        =   6
         Top             =   1080
         Width           =   2175
      End
      Begin VB.OptionButton optZOrder 
         Caption         =   "&1. Z-Order"
         Height          =   375
         Left            =   240
         TabIndex        =   5
         Top             =   720
         Width           =   2175
      End
      Begin VB.OptionButton optHalftone 
         Caption         =   "&0. Halftone Palette"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   360
         Value           =   -1  'True
         Width           =   2175
      End
   End
   Begin VB.PictureBox picPalette 
      Height          =   3855
      Left            =   4800
      ScaleHeight     =   3795
      ScaleWidth      =   3915
      TabIndex        =   2
      Top             =   480
      Width           =   3975
   End
   Begin VB.CommandButton cmdLoadImage 
      Caption         =   "Load a &Test Image"
      Height          =   615
      Left            =   120
      TabIndex        =   1
      Top             =   4440
      Width           =   2055
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   720
      Top             =   5160
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.PictureBox picTestImage 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3855
      Left            =   120
      ScaleHeight     =   3795
      ScaleWidth      =   4275
      TabIndex        =   0
      Top             =   480
      Width           =   4335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##DisableMessage 1478

Private Type PALETTEENTRYAPI
    peRed As Byte
    peGreen As Byte
    peBlue As Byte
    peFlags As Byte
End Type

Private Declare Function GetPaletteEntries Lib "gdi32" (ByVal hPalette As Long, ByVal wStartIndex As Long, ByVal wNumEntries As Long, lpPaletteEntries As PALETTEENTRYAPI) As Long
Private Declare Function GetCurrentObject Lib "gdi32" (ByVal hdc As Long, ByVal uObjectType As Long) As Long
Private Declare Function GetSystemPaletteEntries Lib "gdi32" (ByVal hdc As Long, ByVal wStartIndex As Long, ByVal wNumEntries As Long, lpPaletteEntries As PALETTEENTRYAPI) As Long
Const OBJ_PAL = 5

Private Sub cmdLoadImage_Click()
    On Error Resume Next
    With CommonDialog1
        .Flags = cdlOFNFileMustExist
        .Filter = "All files|*.*|Bitmaps (*.bmp;*.dib)|*.bmp;*.dib)"
        .FilterIndex = 2
        .CancelError = True
        .ShowOpen
        If Err = 0 Then
            picTestImage.Picture = LoadPicture(.FileName)
        End If
    End With
End Sub

' show the current palette

Sub ShowPalette()
    Dim x As Single, y As Single
    Dim xStep As Single, yStep As Single
    Dim palIndex As Integer, rgbValue As Long
    
    Dim curPalette(0 To 255) As PALETTEENTRYAPI
    Dim hPalette As Long
    hPalette = GetCurrentObject(picPalette.hdc, OBJ_PAL)
    GetSystemPaletteEntries picPalette.hdc, 0, 256, curPalette(0)
    '##InsertStatement picPalette.ReleaseHdc()
    
    xStep = picPalette.ScaleWidth / 8
    yStep = picPalette.ScaleHeight / 32
    
    For palIndex = 0 To 255
        x = (palIndex \ 32) * xStep
        y = (palIndex Mod 32) * yStep
        ' get the RGB value
        With curPalette(palIndex)
            rgbValue = RGB(.peRed, .peGreen, .peBlue)
        End With
        ' draw the corresponding block
        picPalette.Line (x, y)-Step(xStep, yStep), rgbValue, BF
    Next
            
End Sub

Private Sub Command1_Click()
    ShowPalette
End Sub
