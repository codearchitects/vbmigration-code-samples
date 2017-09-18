VERSION 5.00
Begin VB.Form frmPrinter 
   Caption         =   "Printer Demo"
   ClientHeight    =   5850
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10935
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
   ScaleHeight     =   5850
   ScaleWidth      =   10935
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdTestPage 
      Caption         =   "&Print Test Page"
      Height          =   495
      Left            =   6720
      TabIndex        =   37
      Top             =   5040
      Width           =   1695
   End
   Begin VB.TextBox txtZoom 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   9240
      TabIndex        =   35
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox txtScaleWidth 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   6720
      TabIndex        =   32
      Top             =   2280
      Width           =   1095
   End
   Begin VB.TextBox txtScaleHeight 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   9240
      TabIndex        =   31
      Top             =   2280
      Width           =   1095
   End
   Begin VB.TextBox txtScaleLeft 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   1560
      TabIndex        =   28
      Top             =   2280
      Width           =   1095
   End
   Begin VB.TextBox txtScaleTop 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   4080
      TabIndex        =   27
      Top             =   2280
      Width           =   1095
   End
   Begin VB.ComboBox cboPrintQuality 
      Height          =   360
      Left            =   6720
      TabIndex        =   25
      Top             =   3480
      Width           =   2535
   End
   Begin VB.ComboBox cboPaperBin 
      Height          =   360
      Left            =   1560
      TabIndex        =   23
      Text            =   "cboPaperBin"
      Top             =   4080
      Width           =   2535
   End
   Begin VB.ComboBox cboDuplex 
      Height          =   360
      Left            =   6720
      TabIndex        =   21
      Top             =   2880
      Width           =   2535
   End
   Begin VB.TextBox txtCopies 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   6720
      TabIndex        =   19
      Top             =   4080
      Width           =   1095
   End
   Begin VB.ComboBox cboColorMode 
      Height          =   360
      Left            =   1560
      TabIndex        =   17
      Top             =   3480
      Width           =   2535
   End
   Begin VB.ComboBox cboOrientation 
      Height          =   360
      Left            =   1560
      TabIndex        =   15
      Top             =   2880
      Width           =   2535
   End
   Begin VB.CommandButton cmdMakeCurrent 
      Caption         =   "&Make Current"
      Height          =   495
      Left            =   6120
      TabIndex        =   13
      Top             =   360
      Width           =   1695
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set Properties"
      Height          =   495
      Left            =   2400
      TabIndex        =   12
      Top             =   5040
      Width           =   1695
   End
   Begin VB.ComboBox cboPaperSize 
      Height          =   360
      Left            =   6720
      TabIndex        =   11
      Top             =   1680
      Width           =   2535
   End
   Begin VB.TextBox txtHeight 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   4080
      TabIndex        =   10
      Top             =   1680
      Width           =   1095
   End
   Begin VB.TextBox txtWidth 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   1560
      TabIndex        =   8
      Top             =   1680
      Width           =   1095
   End
   Begin VB.CheckBox chkTrackDefault 
      Caption         =   "&Track Default"
      Height          =   375
      Left            =   6240
      TabIndex        =   6
      Top             =   1080
      Width           =   2415
   End
   Begin VB.ComboBox cboPrinters 
      Height          =   360
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   0
      Top             =   480
      Width           =   4215
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Zoom"
      Height          =   255
      Index           =   16
      Left            =   7680
      TabIndex        =   36
      Top             =   4200
      Width           =   1455
   End
   Begin VB.Label lblDriverName 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   1560
      TabIndex        =   1
      Top             =   1080
      Width           =   1815
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ScaleWidth"
      Height          =   255
      Index           =   15
      Left            =   5160
      TabIndex        =   34
      Top             =   2400
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ScaleHeight"
      Height          =   255
      Index           =   14
      Left            =   7920
      TabIndex        =   33
      Top             =   2400
      Width           =   1215
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ScaleLeft"
      Height          =   255
      Index           =   13
      Left            =   0
      TabIndex        =   30
      Top             =   2400
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ScaleTop"
      Height          =   255
      Index           =   12
      Left            =   3000
      TabIndex        =   29
      Top             =   2400
      Width           =   975
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "PrintQuality"
      Height          =   255
      Index           =   11
      Left            =   5160
      TabIndex        =   26
      Top             =   3600
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "PaperBin"
      Height          =   255
      Index           =   10
      Left            =   0
      TabIndex        =   24
      Top             =   4200
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Duplex"
      Height          =   255
      Index           =   9
      Left            =   5160
      TabIndex        =   22
      Top             =   3000
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Copies"
      Height          =   255
      Index           =   8
      Left            =   5160
      TabIndex        =   20
      Top             =   4200
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ColorMode"
      Height          =   255
      Index           =   7
      Left            =   0
      TabIndex        =   18
      Top             =   3600
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Orientation"
      Height          =   255
      Index           =   6
      Left            =   0
      TabIndex        =   16
      Top             =   3000
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "PaperSize"
      Height          =   255
      Index           =   5
      Left            =   5160
      TabIndex        =   14
      Top             =   1800
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Height"
      Height          =   255
      Index           =   4
      Left            =   3240
      TabIndex        =   9
      Top             =   1800
      Width           =   735
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Width"
      Height          =   255
      Index           =   3
      Left            =   0
      TabIndex        =   7
      Top             =   1800
      Width           =   1455
   End
   Begin VB.Label lblPort 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   4080
      TabIndex        =   5
      Top             =   1080
      Width           =   1335
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Port"
      Height          =   255
      Index           =   2
      Left            =   3360
      TabIndex        =   4
      Top             =   1200
      Width           =   615
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "DeviceName"
      Height          =   255
      Index           =   0
      Left            =   -120
      TabIndex        =   3
      Top             =   600
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "DriverName"
      Height          =   255
      Index           =   1
      Left            =   0
      TabIndex        =   2
      Top             =   1200
      Width           =   1455
   End
End
Attribute VB_Name = "frmPrinter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    InitControls
End Sub

Private Sub cboPrinters_Click()
    ' update controls with info from this printer
    ShowPrinterInfo Printers(cboPrinters.ListIndex)
End Sub

Private Sub chkTrackDefault_Click()
    Printer.TrackDefault = (chkTrackDefault = vbChecked)
End Sub

Sub InitControls()
    Dim i As Integer
    On Error Resume Next
    
    ' load PaperSizes settings
    AddItem cboPaperSize, "vbPRPSLetter", vbPRPSLetter
    AddItem cboPaperSize, "vbPRPSLetterSmall", vbPRPSLetterSmall
    AddItem cboPaperSize, "vbPRPSTabloid", vbPRPSTabloid
    AddItem cboPaperSize, "vbPRPSLedger", vbPRPSLedger
    AddItem cboPaperSize, "vbPRPSLegal", vbPRPSLegal
    AddItem cboPaperSize, "vbPRPSStatement", vbPRPSStatement
    AddItem cboPaperSize, "vbPRPSExecutive", vbPRPSExecutive
    AddItem cboPaperSize, "vbPRPSA3", vbPRPSA3
    AddItem cboPaperSize, "vbPRPSA4", vbPRPSA4
    AddItem cboPaperSize, "vbPRPSA4Small", vbPRPSA4Small
    AddItem cboPaperSize, "vbPRPSA5", vbPRPSA5
    AddItem cboPaperSize, "vbPRPSB4", vbPRPSB4
    AddItem cboPaperSize, "vbPRPSB5", vbPRPSB5
    AddItem cboPaperSize, "vbPRPSFolio", vbPRPSFolio
    AddItem cboPaperSize, "vbPRPSQuarto", vbPRPSQuarto
    AddItem cboPaperSize, "vbPRPS10x14", vbPRPS10x14
    AddItem cboPaperSize, "vbPRPS11x17", vbPRPS11x17
    AddItem cboPaperSize, "vbPRPSNote", vbPRPSNote
    AddItem cboPaperSize, "vbPRPSEnv9", vbPRPSEnv9
    AddItem cboPaperSize, "vbPRPSEnv10", vbPRPSEnv10
    AddItem cboPaperSize, "vbPRPSEnv11", vbPRPSEnv11
    AddItem cboPaperSize, "vbPRPSEnv12", vbPRPSEnv12
    AddItem cboPaperSize, "vbPRPSEnv14", vbPRPSEnv14
    AddItem cboPaperSize, "vbPRPSCSheet", vbPRPSCSheet
    AddItem cboPaperSize, "vbPRPSDSheet", vbPRPSDSheet
    AddItem cboPaperSize, "vbPRPSESheet", vbPRPSESheet
    AddItem cboPaperSize, "vbPRPSEnvDL", vbPRPSEnvDL
    AddItem cboPaperSize, "vbPRPSEnvC3", vbPRPSEnvC3
    AddItem cboPaperSize, "vbPRPSEnvC4", vbPRPSEnvC4
    AddItem cboPaperSize, "vbPRPSEnvC5", vbPRPSEnvC5
    AddItem cboPaperSize, "vbPRPSEnvC6", vbPRPSEnvC6
    AddItem cboPaperSize, "vbPRPSEnvC65", vbPRPSEnvC65
    AddItem cboPaperSize, "vbPRPSEnvB4", vbPRPSEnvB4
    AddItem cboPaperSize, "vbPRPSEnvB5", vbPRPSEnvB5
    AddItem cboPaperSize, "vbPRPSEnvB6", vbPRPSEnvB6
    AddItem cboPaperSize, "vbPRPSEnvItaly", vbPRPSEnvItaly
    AddItem cboPaperSize, "vbPRPSEnvMonarch", vbPRPSEnvMonarch
    AddItem cboPaperSize, "vbPRPSEnvPersonal", vbPRPSEnvPersonal
    AddItem cboPaperSize, "vbPRPSFanfoldUS", vbPRPSFanfoldUS
    AddItem cboPaperSize, "vbPRPSFanfoldStdGerman", vbPRPSFanfoldStdGerman
    AddItem cboPaperSize, "vbPRPSFanfoldLglGerman", vbPRPSFanfoldLglGerman
    AddItem cboPaperSize, "vbPRPSUser", vbPRPSUser
    
    ' load PaperBin settings
    AddItem cboPaperBin, "vbPRBNUpper", vbPRBNUpper
    AddItem cboPaperBin, "vbPRBNLower", vbPRBNLower
    AddItem cboPaperBin, "vbPRBNMiddle", vbPRBNMiddle
    AddItem cboPaperBin, "vbPRBNManual", vbPRBNManual
    AddItem cboPaperBin, "vbPRBNEnvelope", vbPRBNEnvelope
    AddItem cboPaperBin, "vbPRBNEnvManual", vbPRBNEnvManual
    AddItem cboPaperBin, "vbPRBNAuto", vbPRBNAuto
    AddItem cboPaperBin, "vbPRBNTractor", vbPRBNTractor
    AddItem cboPaperBin, "vbPRBNSmallFmt", vbPRBNSmallFmt
    AddItem cboPaperBin, "vbPRBNLargeFmt", vbPRBNLargeFmt
    AddItem cboPaperBin, "vbPRBNLargeCapacity", vbPRBNLargeCapacity
    AddItem cboPaperBin, "vbPRBNCassette", vbPRBNCassette

    ' load Orientation settings
    AddItem cboOrientation, "vbPRORPortrait", vbPRORPortrait
    AddItem cboOrientation, "vbPRORLandscape", vbPRORLandscape
    ' load ColorMode settings
    AddItem cboColorMode, "vbPRCMMonochrome", vbPRCMMonochrome
    AddItem cboColorMode, "vbPRCMColor", vbPRCMColor
    ' load Duplex settings
    AddItem cboDuplex, "vbPRDPSimplex", vbPRDPSimplex
    AddItem cboDuplex, "vbPRDPHorizontal", vbPRDPHorizontal
    AddItem cboDuplex, "vbPRDPVertical", vbPRDPVertical
    ' load PrintQuality settings
    AddItem cboPrintQuality, "vbPRPQDraft", vbPRPQDraft
    AddItem cboPrintQuality, "vbPRPQLow", vbPRPQLow
    AddItem cboPrintQuality, "vbPRPQMedium", vbPRPQMedium
    AddItem cboPrintQuality, "vbPRPQHigh", vbPRPQHigh
    
    ' check that there are installed printers
    If Printers.Count = 0 Then
        MsgBox "No printers installed", vbCritical
        End
    End If
    
    ' load their device names into the combo box
    For i = 0 To Printers.Count - 1
        cboPrinters.AddItem Printers(i).DeviceName
        ' if this is the current printer, select it
        If Printers(i).DeviceName = Printer.DeviceName Then
            ' this indirectly executes ShowPrinterInfo
            cboPrinters.ListIndex = i
        End If
    Next
    
End Sub

Sub ShowPrinterInfo(prn As Printer)
    lblDriverName = prn.DriverName
    lblPort = prn.Port
    txtWidth = prn.Width
    txtHeight = prn.Height
    txtScaleLeft = prn.ScaleLeft
    txtScaleTop = prn.ScaleTop
    txtScaleWidth = prn.ScaleWidth
    txtScaleHeight = prn.ScaleHeight
    txtZoom = prn.Zoom
    
    SelectItem cboPaperSize, prn.PaperSize
    SelectItem cboOrientation, prn.Orientation
    SelectItem cboColorMode, prn.ColorMode
    txtCopies = prn.Copies
    SelectItem cboDuplex, prn.Duplex
    SelectItem cboPaperBin, prn.PaperBin
    SelectItem cboPrintQuality, prn.PrintQuality
    
    ' clear the DataChanged attribute of all the controls on the form
    Dim ctrl As Control
    On Error Resume Next
    For Each ctrl In Controls
        ctrl.DataChanged = False
    Next
    
End Sub

Private Sub cmdMakeCurrent_Click()
    Set Printer = Printers(cboPrinters.ListIndex)
End Sub

Private Sub cmdSet_Click()
    Dim propname As String
    
    ' check that the highlighted printer is the current one
    If Printers(cboPrinters.ListIndex).DeviceName <> Printer.DeviceName Then
        MsgBox "You must make this printer the current one first", vbExclamation
        Exit Sub
    End If
    
    On Error GoTo ErrorHandler
    
    propname = "Width"
    If txtWidth.DataChanged Then Printer.Width = txtWidth
    propname = "Height"
    If txtHeight.DataChanged Then Printer.Height = txtHeight
    propname = "PaperSize"
    If cboPaperSize.DataChanged Then Printer.PaperSize = GetItem(cboPaperSize)
    propname = "Orientation"
    If cboOrientation.DataChanged Then Printer.Orientation = GetItem(cboOrientation)
    propname = "ColorMode"
    If cboColorMode.DataChanged Then Printer.ColorMode = GetItem(cboColorMode)
    propname = "Copies"
    If txtCopies.DataChanged And Val(txtCopies) > 0 Then Printer.Copies = txtCopies
    propname = "Duplex"
    If cboDuplex.DataChanged And GetItem(cboDuplex) Then Printer.Duplex = GetItem(cboDuplex)
    propname = "PaperBin"
    If cboPaperBin.DataChanged And GetItem(cboPaperBin) Then Printer.PaperBin = GetItem(cboPaperBin)
    propname = "PrintQuality"
    If cboPrintQuality.DataChanged And GetItem(cboPrintQuality) Then Printer.PrintQuality = GetItem(cboPrintQuality)
    propname = "ScaleLeft"
    If txtScaleLeft.DataChanged Then Printer.ScaleLeft = txtScaleLeft
    propname = "ScaleTop"
    If txtScaleTop.DataChanged Then Printer.ScaleTop = txtScaleTop
    propname = "ScaleWidth"
    If txtScaleWidth.DataChanged Then Printer.ScaleWidth = txtScaleWidth
    propname = "ScaleHeight"
    If txtScaleHeight.DataChanged Then Printer.ScaleHeight = txtScaleHeight
    propname = "Zoom"
    If txtZoom.DataChanged And Val(txtZoom) Then Printer.Zoom = txtZoom
    
    ShowPrinterInfo Printer
    
    Exit Sub
    
ErrorHandler:
    MsgBox Err.Description, vbExclamation, "Property: " & propname
    Resume Next
    
End Sub

Sub AddItem(cbo As ComboBox, Text As String, ByVal Value As Long)
    cbo.AddItem Text
    cbo.ItemData(cbo.NewIndex) = Value
End Sub

Sub SelectItem(cbo As ComboBox, ByVal Value As Long)
    ' special value -9999 means "(other)"
    Dim i As Integer
    For i = 0 To cbo.ListCount - 1
        If cbo.ItemData(i) = Value Then
            cbo.ListIndex = i: Exit Sub
        End If
    Next
    cbo.ListIndex = -1
    cbo.Text = CStr(Value)
End Sub

Function GetItem(cbo As ComboBox) As Long
    If cbo.ListIndex <> -1 Then
        GetItem = cbo.ItemData(cbo.ListIndex)
    Else
        GetItem = CLng(cbo.Text)
    End If
End Function

Private Sub cmdTestPage_Click()
    Dim i As Integer
    
    Printer.Print ""
    Printer.Line (Printer.ScaleLeft, Printer.ScaleTop)-(Printer.ScaleWidth, Printer.ScaleHeight), , B
    Printer.Line (Printer.ScaleLeft, Printer.ScaleTop)-(Printer.ScaleWidth, Printer.ScaleHeight)
    Printer.Line (Printer.ScaleLeft, Printer.ScaleHeight)-(Printer.ScaleWidth, Printer.ScaleTop)

    

    Printer.CurrentY = 500
    For i = 10 To 70 Step 5
        Printer.Font.Size = i
        Printer.CurrentX = 0
        Printer.Print "Test line"
    Next
    Printer.EndDoc
End Sub


