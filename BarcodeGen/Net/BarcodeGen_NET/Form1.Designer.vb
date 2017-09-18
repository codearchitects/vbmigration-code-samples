<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
	Inherits CodeArchitects.VB6Library.VB6Form

#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
	EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Windows Form Designer generated code "

	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Create all controls and control arrays.
		InitializeComponents()
	End Sub

	' This method wraps the call to InitializeComponent, but can be called from base class.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
		Me.ObjectIsInitializing = True
		InitializeComponent()
		Me.ObjectIsInitializing = False
	End Sub

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing Then
				If components IsNot Nothing Then components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents ChkExecute As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents checkBarCaption As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkTextAlignment As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cboBarSize As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboTextStyle As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkBar39 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkBar128 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents CDialog As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents lblFeedBack As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnucp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCopyImage1 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSaveImage1 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnucp1 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCopyImage2 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSaveImage2 As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.ChkExecute = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.checkBarCaption = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkTextAlignment = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cboBarSize = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboTextStyle = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkBar39 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkBar128 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.CDialog = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.lblFeedBack = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnucp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCopyImage1 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSaveImage1 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnucp1 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCopyImage2 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSaveImage2 = New CodeArchitects.VB6Library.VB6Menu()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(583, 103)
		Me.Picture2.Location = New System.Drawing.Point(6, 244)
		Me.Picture2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture2.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Picture2.AutoRedraw = True
		Me.Picture2.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.Picture2.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Picture2.TabIndex = 12
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(587, 55)
		Me.Frame2.Location = New System.Drawing.Point(4, 72)
		Me.Frame2.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Frame2.Caption = "BarCode 128 Properties"
		Me.Frame2.TabIndex = 3
		'
		' ChkExecute
		'
		Me.ChkExecute.Name = "ChkExecute"
		Me.ChkExecute.Size = New System.Drawing.Size(129, 17)
		Me.ChkExecute.Location = New System.Drawing.Point(24, 36)
		Me.ChkExecute.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.ChkExecute.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.ChkExecute.Caption = "Display after Save"
		Me.ChkExecute.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.ChkExecute.TabIndex = 15
		Me.ChkExecute.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' checkBarCaption
		'
		Me.checkBarCaption.Name = "checkBarCaption"
		Me.checkBarCaption.Size = New System.Drawing.Size(121, 17)
		Me.checkBarCaption.Location = New System.Drawing.Point(176, 14)
		Me.checkBarCaption.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.checkBarCaption.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.checkBarCaption.Caption = "Bar With Caption"
		Me.checkBarCaption.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.checkBarCaption.TabIndex = 9
		Me.checkBarCaption.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' chkTextAlignment
		'
		Me.chkTextAlignment.Name = "chkTextAlignment"
		Me.chkTextAlignment.Size = New System.Drawing.Size(129, 17)
		Me.chkTextAlignment.Location = New System.Drawing.Point(24, 14)
		Me.chkTextAlignment.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.chkTextAlignment.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.chkTextAlignment.Caption = "Bottom Align Caption"
		Me.chkTextAlignment.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.chkTextAlignment.TabIndex = 8
		Me.chkTextAlignment.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' cboBarSize
		'
		Me.cboBarSize.Name = "cboBarSize"
		Me.cboBarSize.Size = New System.Drawing.Size(65, 21)
		Me.cboBarSize.Location = New System.Drawing.Point(514, 12)
		Me.cboBarSize.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboBarSize.TabIndex = 6
		Me.cboBarSize.ItemDataValues = "Small\r0\rMedium\r0\rLarge\r0"
		'
		' cboTextStyle
		'
		Me.cboTextStyle.Name = "cboTextStyle"
		Me.cboTextStyle.Size = New System.Drawing.Size(65, 21)
		Me.cboTextStyle.Location = New System.Drawing.Point(376, 10)
		Me.cboTextStyle.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboTextStyle.TabIndex = 4
		Me.cboTextStyle.ItemDataValues = "Bold\r0\rItalic\r0\rBoldItalic\r0\rUnderLine\r0"
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 13)
		Me.Label5.Location = New System.Drawing.Point(452, 14)
		Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "Bar Size"
		Me.Label5.TabIndex = 7
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(65, 15)
		Me.Label4.Location = New System.Drawing.Point(308, 14)
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "Text Style"
		Me.Label4.TabIndex = 5
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(211, 41)
		Me.Frame1.Location = New System.Drawing.Point(358, 22)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Frame1.Caption = "Type of Bar"
		Me.Frame1.TabIndex = 2
		'
		' chkBar39
		'
		Me.chkBar39.Name = "chkBar39"
		Me.chkBar39.Size = New System.Drawing.Size(93, 23)
		Me.chkBar39.Location = New System.Drawing.Point(116, 12)
		Me.chkBar39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkBar39.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.chkBar39.Caption = "Bar 39"
		Me.chkBar39.TabIndex = 11
		Me.chkBar39.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' chkBar128
		'
		Me.chkBar128.Name = "chkBar128"
		Me.chkBar128.Size = New System.Drawing.Size(95, 21)
		Me.chkBar128.Location = New System.Drawing.Point(6, 14)
		Me.chkBar128.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkBar128.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.chkBar128.Caption = "Bar 128"
		Me.chkBar128.TabIndex = 10
		Me.chkBar128.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(583, 103)
		Me.Picture1.Location = New System.Drawing.Point(6, 134)
		Me.Picture1.AutoRedraw = True
		Me.Picture1.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 1
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(245, 33)
		Me.Text1.Location = New System.Drawing.Point(110, 30)
		Me.Text1.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Text1.MaxLength = 21
		Me.Text1.TabIndex = 0
		Me.Text1.Text = "S123456T789"
		'
		' CDialog
		'
		Me.CDialog.Name = "CDialog"
		Me.CDialog.ParentForm = Me
		Me.CDialog.Name6 = "CDialog"
		'
		' lblFeedBack
		'
		Me.lblFeedBack.Name = "lblFeedBack"
		Me.lblFeedBack.Size = New System.Drawing.Size(129, 27)
		Me.lblFeedBack.Location = New System.Drawing.Point(458, 348)
		Me.lblFeedBack.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFeedBack.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblFeedBack.Caption = "Want to give Feedback on Me , Click here"
		Me.lblFeedBack.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbSizeAll
		Me.lblFeedBack.TabIndex = 16
		Me.lblFeedBack.AutoSize = False
		Me.lblFeedBack.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(99, 27)
		Me.Label2.Location = New System.Drawing.Point(12, 36)
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Enter Text to Create Bar Code"
		Me.Label2.TabIndex = 14
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(425, 25)
		Me.Label1.Location = New System.Drawing.Point(2, 352)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Right Click Over Each Bar to Get Options"
		Me.Label1.TabIndex = 13
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnucp
		'
		Me.mnucp.Name = "mnucp"
		Me.mnucp.Caption = "Copy Image"
		Me.mnucp.Visible = False
		'
		' mnuCopyImage1
		'
		Me.mnuCopyImage1.Name = "mnuCopyImage1"
		Me.mnuCopyImage1.Caption = "Copy  Bar of Code 128 to Clip Board"
		'
		' mnuSaveImage1
		'
		Me.mnuSaveImage1.Name = "mnuSaveImage1"
		Me.mnuSaveImage1.Caption = "Save As"
		'
		' mnucp1
		'
		Me.mnucp1.Name = "mnucp1"
		Me.mnucp1.Caption = "Copy Image2"
		Me.mnucp1.Visible = False
		'
		' mnuCopyImage2
		'
		Me.mnuCopyImage2.Name = "mnuCopyImage2"
		Me.mnuCopyImage2.Caption = "Copy This Bar of Code 39 to Clip Board"
		'
		' mnuSaveImage2
		'
		Me.mnuSaveImage2.Name = "mnuSaveImage2"
		Me.mnuSaveImage2.Caption = "Save As"
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Sample Form"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(592, 378)

		Me.Controls.Add(Picture2)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(ChkExecute)
		Me.Frame2.Controls.Add(checkBarCaption)
		Me.Frame2.Controls.Add(chkTextAlignment)
		Me.Frame2.Controls.Add(cboBarSize)
		Me.Frame2.Controls.Add(cboTextStyle)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Label4)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(chkBar39)
		Me.Frame1.Controls.Add(chkBar128)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(lblFeedBack)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnucp)
		Me.mnucp.DropDownItems.Add(mnuCopyImage1)
		Me.mnucp.DropDownItems.Add(mnuSaveImage1)
		Me.MenuStrip1.Items.Add(mnucp1)
		Me.mnucp1.DropDownItems.Add(mnuCopyImage2)
		Me.mnucp1.DropDownItems.Add(mnuSaveImage2)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
