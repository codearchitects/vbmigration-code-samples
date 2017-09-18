' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmPrinter

	Private Sub Form_Load() Handles MyBase.Load
		InitControls()
	End Sub

	Private Sub cboPrinters_Click() Handles cboPrinters.Click
		' update controls with info from this printer
		ShowPrinterInfo(Printers6(cboPrinters.ListIndex))
	End Sub

	Private Sub chkTrackDefault_Click() Handles chkTrackDefault.Click
		Printer6.TrackDefault = (chkTrackDefault.Value = VBRUN.CheckBoxConstants.vbChecked)
	End Sub

	Public Sub InitControls()
		Dim i As Short
		On Error Resume Next 
		
		' load PaperSizes settings
		AddItem(cboPaperSize, "vbPRPSLetter", VBRUN.PrinterObjectConstants.vbPRPSLetter)
		AddItem(cboPaperSize, "vbPRPSLetterSmall", VBRUN.PrinterObjectConstants.vbPRPSLetterSmall)
		AddItem(cboPaperSize, "vbPRPSTabloid", VBRUN.PrinterObjectConstants.vbPRPSTabloid)
		AddItem(cboPaperSize, "vbPRPSLedger", VBRUN.PrinterObjectConstants.vbPRPSLedger)
		AddItem(cboPaperSize, "vbPRPSLegal", VBRUN.PrinterObjectConstants.vbPRPSLegal)
		AddItem(cboPaperSize, "vbPRPSStatement", VBRUN.PrinterObjectConstants.vbPRPSStatement)
		AddItem(cboPaperSize, "vbPRPSExecutive", VBRUN.PrinterObjectConstants.vbPRPSExecutive)
		AddItem(cboPaperSize, "vbPRPSA3", VBRUN.PrinterObjectConstants.vbPRPSA3)
		AddItem(cboPaperSize, "vbPRPSA4", VBRUN.PrinterObjectConstants.vbPRPSA4)
		AddItem(cboPaperSize, "vbPRPSA4Small", VBRUN.PrinterObjectConstants.vbPRPSA4Small)
		AddItem(cboPaperSize, "vbPRPSA5", VBRUN.PrinterObjectConstants.vbPRPSA5)
		AddItem(cboPaperSize, "vbPRPSB4", VBRUN.PrinterObjectConstants.vbPRPSB4)
		AddItem(cboPaperSize, "vbPRPSB5", VBRUN.PrinterObjectConstants.vbPRPSB5)
		AddItem(cboPaperSize, "vbPRPSFolio", VBRUN.PrinterObjectConstants.vbPRPSFolio)
		AddItem(cboPaperSize, "vbPRPSQuarto", VBRUN.PrinterObjectConstants.vbPRPSQuarto)
		AddItem(cboPaperSize, "vbPRPS10x14", VBRUN.PrinterObjectConstants.vbPRPS10x14)
		AddItem(cboPaperSize, "vbPRPS11x17", VBRUN.PrinterObjectConstants.vbPRPS11x17)
		AddItem(cboPaperSize, "vbPRPSNote", VBRUN.PrinterObjectConstants.vbPRPSNote)
		AddItem(cboPaperSize, "vbPRPSEnv9", VBRUN.PrinterObjectConstants.vbPRPSEnv9)
		AddItem(cboPaperSize, "vbPRPSEnv10", VBRUN.PrinterObjectConstants.vbPRPSEnv10)
		AddItem(cboPaperSize, "vbPRPSEnv11", VBRUN.PrinterObjectConstants.vbPRPSEnv11)
		AddItem(cboPaperSize, "vbPRPSEnv12", VBRUN.PrinterObjectConstants.vbPRPSEnv12)
		AddItem(cboPaperSize, "vbPRPSEnv14", VBRUN.PrinterObjectConstants.vbPRPSEnv14)
		AddItem(cboPaperSize, "vbPRPSCSheet", VBRUN.PrinterObjectConstants.vbPRPSCSheet)
		AddItem(cboPaperSize, "vbPRPSDSheet", VBRUN.PrinterObjectConstants.vbPRPSDSheet)
		AddItem(cboPaperSize, "vbPRPSESheet", VBRUN.PrinterObjectConstants.vbPRPSESheet)
		AddItem(cboPaperSize, "vbPRPSEnvDL", VBRUN.PrinterObjectConstants.vbPRPSEnvDL)
		AddItem(cboPaperSize, "vbPRPSEnvC3", VBRUN.PrinterObjectConstants.vbPRPSEnvC3)
		AddItem(cboPaperSize, "vbPRPSEnvC4", VBRUN.PrinterObjectConstants.vbPRPSEnvC4)
		AddItem(cboPaperSize, "vbPRPSEnvC5", VBRUN.PrinterObjectConstants.vbPRPSEnvC5)
		AddItem(cboPaperSize, "vbPRPSEnvC6", VBRUN.PrinterObjectConstants.vbPRPSEnvC6)
		AddItem(cboPaperSize, "vbPRPSEnvC65", VBRUN.PrinterObjectConstants.vbPRPSEnvC65)
		AddItem(cboPaperSize, "vbPRPSEnvB4", VBRUN.PrinterObjectConstants.vbPRPSEnvB4)
		AddItem(cboPaperSize, "vbPRPSEnvB5", VBRUN.PrinterObjectConstants.vbPRPSEnvB5)
		AddItem(cboPaperSize, "vbPRPSEnvB6", VBRUN.PrinterObjectConstants.vbPRPSEnvB6)
		AddItem(cboPaperSize, "vbPRPSEnvItaly", VBRUN.PrinterObjectConstants.vbPRPSEnvItaly)
		AddItem(cboPaperSize, "vbPRPSEnvMonarch", VBRUN.PrinterObjectConstants.vbPRPSEnvMonarch)
		AddItem(cboPaperSize, "vbPRPSEnvPersonal", VBRUN.PrinterObjectConstants.vbPRPSEnvPersonal)
		AddItem(cboPaperSize, "vbPRPSFanfoldUS", VBRUN.PrinterObjectConstants.vbPRPSFanfoldUS)
		AddItem(cboPaperSize, "vbPRPSFanfoldStdGerman", VBRUN.PrinterObjectConstants.vbPRPSFanfoldStdGerman)
		AddItem(cboPaperSize, "vbPRPSFanfoldLglGerman", VBRUN.PrinterObjectConstants.vbPRPSFanfoldLglGerman)
		AddItem(cboPaperSize, "vbPRPSUser", VBRUN.PrinterObjectConstants.vbPRPSUser)
		
		' load PaperBin settings
		AddItem(cboPaperBin, "vbPRBNUpper", VBRUN.PrinterObjectConstants.vbPRBNUpper)
		AddItem(cboPaperBin, "vbPRBNLower", VBRUN.PrinterObjectConstants.vbPRBNLower)
		AddItem(cboPaperBin, "vbPRBNMiddle", VBRUN.PrinterObjectConstants.vbPRBNMiddle)
		AddItem(cboPaperBin, "vbPRBNManual", VBRUN.PrinterObjectConstants.vbPRBNManual)
		AddItem(cboPaperBin, "vbPRBNEnvelope", VBRUN.PrinterObjectConstants.vbPRBNEnvelope)
		AddItem(cboPaperBin, "vbPRBNEnvManual", VBRUN.PrinterObjectConstants.vbPRBNEnvManual)
		AddItem(cboPaperBin, "vbPRBNAuto", VBRUN.PrinterObjectConstants.vbPRBNAuto)
		AddItem(cboPaperBin, "vbPRBNTractor", VBRUN.PrinterObjectConstants.vbPRBNTractor)
		AddItem(cboPaperBin, "vbPRBNSmallFmt", VBRUN.PrinterObjectConstants.vbPRBNSmallFmt)
		AddItem(cboPaperBin, "vbPRBNLargeFmt", VBRUN.PrinterObjectConstants.vbPRBNLargeFmt)
		AddItem(cboPaperBin, "vbPRBNLargeCapacity", VBRUN.PrinterObjectConstants.vbPRBNLargeCapacity)
		AddItem(cboPaperBin, "vbPRBNCassette", VBRUN.PrinterObjectConstants.vbPRBNCassette)
		
		' load Orientation settings
		AddItem(cboOrientation, "vbPRORPortrait", VBRUN.PrinterObjectConstants.vbPRORPortrait)
		AddItem(cboOrientation, "vbPRORLandscape", VBRUN.PrinterObjectConstants.vbPRORLandscape)
		' load ColorMode settings
		AddItem(cboColorMode, "vbPRCMMonochrome", VBRUN.PrinterObjectConstants.vbPRCMMonochrome)
		AddItem(cboColorMode, "vbPRCMColor", VBRUN.PrinterObjectConstants.vbPRCMColor)
		' load Duplex settings
		AddItem(cboDuplex, "vbPRDPSimplex", VBRUN.PrinterObjectConstants.vbPRDPSimplex)
		AddItem(cboDuplex, "vbPRDPHorizontal", VBRUN.PrinterObjectConstants.vbPRDPHorizontal)
		AddItem(cboDuplex, "vbPRDPVertical", VBRUN.PrinterObjectConstants.vbPRDPVertical)
		' load PrintQuality settings
		AddItem(cboPrintQuality, "vbPRPQDraft", VBRUN.PrinterObjectConstants.vbPRPQDraft)
		AddItem(cboPrintQuality, "vbPRPQLow", VBRUN.PrinterObjectConstants.vbPRPQLow)
		AddItem(cboPrintQuality, "vbPRPQMedium", VBRUN.PrinterObjectConstants.vbPRPQMedium)
		AddItem(cboPrintQuality, "vbPRPQHigh", VBRUN.PrinterObjectConstants.vbPRPQHigh)
		
		' check that there are installed printers
		If Printers6.Count = 0 Then 
			MsgBox6("No printers installed", MsgBoxStyle.Critical)
			Application.Exit(): End
		End If
		
		' load their device names into the combo box
		For i = 0 To Printers6.Count - 1
			cboPrinters.AddItem(Printers6(i).DeviceName)
			' if this is the current printer, select it
			If Printers6(i).DeviceName = Printer6.DeviceName Then 
				' this indirectly executes ShowPrinterInfo
				cboPrinters.ListIndex = i
			End If
		Next
		
	End Sub

	Public Sub ShowPrinterInfo(ByRef prn As VB6Printer)
	' UPGRADE_INFO (#0551): The 'prn' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		lblDriverName.Caption = prn.DriverName
		lblPort.Caption = prn.Port
		txtWidth.Text = prn.Width
		txtHeight.Text = prn.Height
		txtScaleLeft.Text = prn.ScaleLeft
		txtScaleTop.Text = prn.ScaleTop
		txtScaleWidth.Text = prn.ScaleWidth
		txtScaleHeight.Text = prn.ScaleHeight
		txtZoom.Text = prn.Zoom
		
		SelectItem(cboPaperSize, prn.PaperSize)
		SelectItem(cboOrientation, prn.Orientation)
		SelectItem(cboColorMode, prn.ColorMode)
		txtCopies.Text = prn.Copies
		SelectItem(cboDuplex, prn.Duplex)
		SelectItem(cboPaperBin, prn.PaperBin)
		SelectItem(cboPrintQuality, prn.PrintQuality)
		
		' clear the DataChanged attribute of all the controls on the form
		Dim ctrl As Object = Nothing
		On Error Resume Next 
		For Each ctrl In Controls6
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'ctrl'. Consider using the GetDefaultMember6 helper method.
			CObj(ctrl).DataChanged = False
		Next
		
	End Sub

	Private Sub cmdMakeCurrent_Click() Handles cmdMakeCurrent.Click
		Printer6 = Printers6(cboPrinters.ListIndex)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		Dim propname As String = ""
		
		' check that the highlighted printer is the current one
		If Printers6(cboPrinters.ListIndex).DeviceName <> Printer6.DeviceName Then 
			MsgBox6("You must make this printer the current one first", MsgBoxStyle.Exclamation)
			Exit Sub
		End If
		
		On Error GoTo ErrorHandler 
		
		propname = "Width"
		If txtWidth.DataChanged Then  Printer6.Width = txtWidth.Text
		propname = "Height"
		If txtHeight.DataChanged Then  Printer6.Height = txtHeight.Text
		propname = "PaperSize"
		If cboPaperSize.DataChanged Then  Printer6.PaperSize = GetItem(cboPaperSize)
		propname = "Orientation"
		If cboOrientation.DataChanged Then  Printer6.Orientation = GetItem(cboOrientation)
		propname = "ColorMode"
		If cboColorMode.DataChanged Then  Printer6.ColorMode = GetItem(cboColorMode)
		propname = "Copies"
		If txtCopies.DataChanged And Val(txtCopies.Text) > 0 Then  Printer6.Copies = txtCopies.Text
		propname = "Duplex"
		If cboDuplex.DataChanged And GetItem(cboDuplex) Then  Printer6.Duplex = GetItem(cboDuplex)
		propname = "PaperBin"
		If cboPaperBin.DataChanged And GetItem(cboPaperBin) Then  Printer6.PaperBin = GetItem(cboPaperBin)
		propname = "PrintQuality"
		If cboPrintQuality.DataChanged And GetItem(cboPrintQuality) Then  Printer6.PrintQuality = GetItem(cboPrintQuality)
		propname = "ScaleLeft"
		If txtScaleLeft.DataChanged Then  Printer6.ScaleLeft = txtScaleLeft.Text
		propname = "ScaleTop"
		If txtScaleTop.DataChanged Then  Printer6.ScaleTop = txtScaleTop.Text
		propname = "ScaleWidth"
		If txtScaleWidth.DataChanged Then  Printer6.ScaleWidth = txtScaleWidth.Text
		propname = "ScaleHeight"
		If txtScaleHeight.DataChanged Then  Printer6.ScaleHeight = txtScaleHeight.Text
		propname = "Zoom"
		If txtZoom.DataChanged And Val(txtZoom.Text) Then  Printer6.Zoom = txtZoom.Text
		
		ShowPrinterInfo(Printer6)
		
		Exit Sub
		
ErrorHandler:
		MsgBox6(Err.Description, MsgBoxStyle.Exclamation, "Property: " & propname)
		Resume Next 
		
	End Sub

	Public Sub AddItem(ByRef cbo As VB6ComboBox, ByRef Text As String, ByVal Value As Integer)
	' UPGRADE_INFO (#0551): The 'cbo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		cbo.AddItem(Text)
		cbo.ItemData(cbo.NewIndex) = Value
	End Sub

	Public Sub SelectItem(ByRef cbo As VB6ComboBox, ByVal Value As Integer)
	' UPGRADE_INFO (#0551): The 'cbo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' special value -9999 means "(other)"
		Dim i As Short
		For i = 0 To cbo.ListCount - 1
			If cbo.ItemData(i) = Value Then 
				cbo.ListIndex = i: Exit Sub
			End If
		Next
		cbo.ListIndex = -1
		cbo.Text = CStr(Value)
	End Sub

	Public Function GetItem(ByRef cbo As VB6ComboBox) As Integer
	' UPGRADE_INFO (#0551): The 'cbo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If cbo.ListIndex <> -1 Then 
			Return cbo.ItemData(cbo.ListIndex)
		Else
			Return CInt(cbo.Text)
		End If
	End Function

	Private Sub cmdTestPage_Click() Handles cmdTestPage.Click
		Dim i As Short
		
		Printer6.PrintLine("")
		Printer6.Line(VBRUN.GraphicsOptions.Box, Printer6.ScaleLeft, Printer6.ScaleTop, Printer6.ScaleWidth, Printer6.ScaleHeight)
		Printer6.Line(VBRUN.GraphicsOptions.None, Printer6.ScaleLeft, Printer6.ScaleTop, Printer6.ScaleWidth, Printer6.ScaleHeight)
		Printer6.Line(VBRUN.GraphicsOptions.None, Printer6.ScaleLeft, Printer6.ScaleHeight, Printer6.ScaleWidth, Printer6.ScaleTop)

		Printer6.CurrentY = 500
		For i = 10 To 70 Step 5
			FontChangeSize6(Printer6.Font, i)
			Printer6.CurrentX = 0
			Printer6.PrintLine("Test line")
		Next
		Printer6.EndDoc()
	End Sub

End Class
