VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "ImageCombo Demo"
   ClientHeight    =   4275
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4575
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
   ScaleHeight     =   4275
   ScaleWidth      =   4575
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox picInfo 
      Height          =   2655
      Left            =   240
      ScaleHeight     =   2595
      ScaleWidth      =   3075
      TabIndex        =   2
      Top             =   1320
      Width           =   3135
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   3600
      Top             =   600
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   6
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":0000
            Key             =   "MyComputer"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":0452
            Key             =   "FloppyDrive"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":08A4
            Key             =   "HardDrive"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":0CF6
            Key             =   "CDDrive"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":1148
            Key             =   "CloseFolder"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ImgCombo.frx":159A
            Key             =   "OpenFolder"
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ImageCombo ImageCombo1 
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   600
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   661
      _Version        =   393216
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      Text            =   "ImageCombo1"
      ImageList       =   "ImageList1"
   End
   Begin VB.Label Label1 
      Caption         =   "Select the drive"
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   2895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##ImageCombo1.WriteProperty DropDownStyle, 2

Sub LoadDrivesIntoImageCombo(ImgCombo As ImageCombo)
    Dim fso As New Scripting.FileSystemObject, dr As Scripting.Drive
    Dim drLabel As String, drImage As String
        
    ' assumes that the ImageCombo control is linked to an ImageList
    ' control that includes three icons with the following key names
    ImgCombo.ComboItems.Add , , "My Computer", "MyComputer"
    For Each dr In fso.Drives
        ' a different image for each type of drive
        Select Case dr.DriveType
            Case Removable:   drImage = "FloppyDrive"
            Case CDRom:       drImage = "CDDrive"
            Case Else:        drImage = "HardDrive"
        End Select
        ' retrieve the letter and (if possible) the volume label
        drLabel = dr.DriveLetter & ": "
        If dr.IsReady Then
            If Len(dr.VolumeName) Then drLabel = drLabel & "[" & dr.VolumeName & "]"
        End If
        ' add an indented item to the combo
        ImgCombo.ComboItems.Add , dr.DriveLetter, drLabel, drImage, , 2
    Next
    ' select the current drive
    Set ImgCombo.SelectedItem = ImgCombo.ComboItems(Left$(CurDir$, 1))
End Sub

Private Sub Form_Load()
    LoadDrivesIntoImageCombo ImageCombo1
End Sub

Private Sub ImageCombo1_Click()
    Dim fso As New Scripting.FileSystemObject, dr As Scripting.Drive
    
    On Error Resume Next
    Set dr = fso.Drives(ImageCombo1.SelectedItem.Key)
    picInfo.Cls
    If Err Then Exit Sub
    
    picInfo.Print "Drive " & dr.DriveLetter & ":"
    picInfo.Print
    picInfo.Print "Volume Name = " & dr.VolumeName
    picInfo.Print "Available Space = " & dr.AvailableSpace
    picInfo.Print "Free Space = " & dr.FreeSpace
    picInfo.Print "Serial Number = " & Hex$(dr.SerialNumber)
    picInfo.Print "Share Name = " & dr.ShareName
    
End Sub

