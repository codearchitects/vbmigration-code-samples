<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSecondary
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
	Public WithEvents dlgColors As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents hscValue As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents txtMin As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtMax As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cpbProgress As pCoolProgressBar_Demo.CoolProgressBar
	Public WithEvents lblX As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape9 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents lblColor2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblColor1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape8 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Shape7 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape6 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents shpColor2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Shape2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents shpColor1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape3 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSecondary))
		Me.dlgColors = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.hscValue = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.txtMin = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtMax = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cpbProgress = New pCoolProgressBar_Demo.CoolProgressBar()
		Me.lblX = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape9 = New CodeArchitects.VB6Library.VB6Shape()
		Me.lblColor2 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblColor1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape8 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Shape7 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape6 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.shpColor2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Shape2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.shpColor1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape3 = New CodeArchitects.VB6Library.VB6Shape()
		CType(Me.cpbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shpColor2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shpColor1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' dlgColors
		'
		Me.dlgColors.Name = "dlgColors"
		Me.dlgColors.ParentForm = Me
		Me.dlgColors.Name6 = "dlgColors"
		Me.dlgColors.CancelError = True
		Me.dlgColors.Flags = 2
		'
		' hscValue
		'
		Me.hscValue.Name = "hscValue"
		Me.hscValue.Size = New System.Drawing.Size(197, 15)
		Me.hscValue.Location = New System.Drawing.Point(98, 153)
		Me.hscValue.LargeChange = 10
		Me.hscValue.Max = 100
		Me.hscValue.TabIndex = 9
		Me.hscValue.Value = 100
		Me.hscValue.TabStop = True
		'
		' txtMin
		'
		Me.txtMin.Name = "txtMin"
		Me.txtMin.Size = New System.Drawing.Size(33, 13)
		Me.txtMin.Location = New System.Drawing.Point(104, 122)
		Me.txtMin.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtMin.BackColor = FromOleColor6(CInt(&H00000000))
		Me.txtMin.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.txtMin.ForeColor = FromOleColor6(CInt(&H0080C0FF))
		Me.txtMin.MaxLength = 5
		Me.txtMin.TabIndex = 7
		Me.txtMin.Text = "0"
		'
		' txtMax
		'
		Me.txtMax.Name = "txtMax"
		Me.txtMax.Size = New System.Drawing.Size(33, 13)
		Me.txtMax.Location = New System.Drawing.Point(104, 90)
		Me.txtMax.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtMax.BackColor = FromOleColor6(CInt(&H00000000))
		Me.txtMax.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.txtMax.ForeColor = FromOleColor6(CInt(&H0080C0FF))
		Me.txtMax.MaxLength = 5
		Me.txtMax.TabIndex = 5
		Me.txtMax.Text = "100"
		'
		' cpbProgress
		'
		Me.cpbProgress.Name = "cpbProgress"
		Me.cpbProgress.Size = New System.Drawing.Size(265, 17)
		Me.cpbProgress.Location = New System.Drawing.Point(24, 180)
		Me.cpbProgress.TabIndex = 0
		Me.cpbProgress.BackColor = FromOleColor6(CInt(0))
		Me.cpbProgress.Color2 = FromOleColor6(CInt(8438015))
		Me.cpbProgress.Color1 = FromOleColor6(CInt(128))
		'
		' lblX
		'
		Me.lblX.Name = "lblX"
		Me.lblX.Size = New System.Drawing.Size(17, 17)
		Me.lblX.Location = New System.Drawing.Point(288, 8)
		Me.lblX.Font = New System.Drawing.Font("Times New Roman", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblX.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblX.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblX.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblX.Caption = "X"
		Me.lblX.ForeColor = FromOleColor6(CInt(&H000080FF))
		Me.lblX.TabIndex = 12
		Me.ToolTip1.SetToolTip(Me.lblX, "Close")
		Me.lblX.AutoSize = False
		'
		' Shape9
		'
		Me.Shape9.Name = "Shape9"
		Me.Shape9.ParentForm = Me
		Me.Shape9.Name6 = "Shape9"
		Me.Shape9.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape9.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape9.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Shape9.Height = 255
		Me.Shape9.Left = 4320
		Me.Shape9.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape9.Top = 120
		Me.Shape9.Width = 255
		'
		' lblColor2
		'
		Me.lblColor2.Name = "lblColor2"
		Me.lblColor2.Size = New System.Drawing.Size(17, 17)
		Me.lblColor2.Location = New System.Drawing.Point(280, 120)
		Me.lblColor2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblColor2.TabIndex = 11
		Me.lblColor2.AutoSize = False
		Me.lblColor2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblColor1
		'
		Me.lblColor1.Name = "lblColor1"
		Me.lblColor1.Size = New System.Drawing.Size(17, 17)
		Me.lblColor1.Location = New System.Drawing.Point(280, 88)
		Me.lblColor1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblColor1.TabIndex = 10
		Me.lblColor1.AutoSize = False
		Me.lblColor1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Shape8
		'
		Me.Shape8.Name = "Shape8"
		Me.Shape8.ParentForm = Me
		Me.Shape8.Name6 = "Shape8"
		Me.Shape8.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape8.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape8.FillColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Shape8.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.Shape8.Height = 255
		Me.Shape8.Left = 1440
		Me.Shape8.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape8.Top = 2280
		Me.Shape8.Width = 3015
		'
		' Shape7
		'
		Me.Shape7.Name = "Shape7"
		Me.Shape7.ParentForm = Me
		Me.Shape7.Name6 = "Shape7"
		Me.Shape7.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape7.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape7.Height = 255
		Me.Shape7.Left = 240
		Me.Shape7.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape7.Top = 2280
		Me.Shape7.Width = 4215
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(73, 17)
		Me.Label6.Location = New System.Drawing.Point(24, 152)
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label6.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label6.Caption = "Value:"
		Me.Label6.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label6.TabIndex = 8
		Me.Label6.AutoSize = False
		'
		' Shape6
		'
		Me.Shape6.Name = "Shape6"
		Me.Shape6.ParentForm = Me
		Me.Shape6.Name6 = "Shape6"
		Me.Shape6.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape6.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape6.Height = 255
		Me.Shape6.Left = 240
		Me.Shape6.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape6.Top = 1800
		Me.Shape6.Width = 1935
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 120)
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "Min:"
		Me.Label5.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label5.TabIndex = 6
		Me.Label5.AutoSize = False
		'
		' Shape5
		'
		Me.Shape5.Name = "Shape5"
		Me.Shape5.ParentForm = Me
		Me.Shape5.Name6 = "Shape5"
		Me.Shape5.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape5.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape5.Height = 255
		Me.Shape5.Left = 240
		Me.Shape5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape5.Top = 1320
		Me.Shape5.Width = 1935
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 88)
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "Max:"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label4.TabIndex = 4
		Me.Label4.AutoSize = False
		'
		' Shape4
		'
		Me.Shape4.Name = "Shape4"
		Me.Shape4.ParentForm = Me
		Me.Shape4.Name6 = "Shape4"
		Me.Shape4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape4.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape4.Height = 855
		Me.Shape4.Left = 240
		Me.Shape4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape4.Top = 240
		Me.Shape4.Width = 4215
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(281, 57)
		Me.Label3.Location = New System.Drawing.Point(16, 16)
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "Here you can choose the progress bar's Colors, Max, Min and Value (press [Enter] to apply)."
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label3.TabIndex = 3
		Me.Label3.AutoSize = False
		'
		' shpColor2
		'
		Me.shpColor2.Name = "shpColor2"
		Me.shpColor2.ParentForm = Me
		Me.shpColor2.Name6 = "shpColor2"
		Me.shpColor2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.shpColor2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.shpColor2.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.shpColor2.FillColor = FromOleColor6(CInt(&H0080C0FF))
		Me.shpColor2.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.shpColor2.Height = 255
		Me.shpColor2.Left = 4200
		Me.shpColor2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.shpColor2.Top = 1800
		Me.shpColor2.Width = 255
		'
		' Shape2
		'
		Me.Shape2.Name = "Shape2"
		Me.Shape2.ParentForm = Me
		Me.Shape2.Name6 = "Shape2"
		Me.Shape2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape2.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape2.Height = 255
		Me.Shape2.Left = 2400
		Me.Shape2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape2.Top = 1800
		Me.Shape2.Width = 2055
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(121, 17)
		Me.Label2.Location = New System.Drawing.Point(160, 120)
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Second color:"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label2.TabIndex = 2
		Me.Label2.AutoSize = False
		'
		' shpColor1
		'
		Me.shpColor1.Name = "shpColor1"
		Me.shpColor1.ParentForm = Me
		Me.shpColor1.Name6 = "shpColor1"
		Me.shpColor1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.shpColor1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.shpColor1.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.shpColor1.FillColor = FromOleColor6(CInt(&H00000080))
		Me.shpColor1.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.shpColor1.Height = 255
		Me.shpColor1.Left = 4200
		Me.shpColor1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.shpColor1.Top = 1320
		Me.shpColor1.Width = 255
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape1.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape1.Height = 255
		Me.Shape1.Left = 2400
		Me.Shape1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape1.Top = 1320
		Me.Shape1.Width = 2055
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(121, 17)
		Me.Label1.Location = New System.Drawing.Point(160, 88)
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "First color:"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		'
		' Shape3
		'
		Me.Shape3.Name = "Shape3"
		Me.Shape3.ParentForm = Me
		Me.Shape3.Name6 = "Shape3"
		Me.Shape3.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape3.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape3.Height = 375
		Me.Shape3.Left = 240
		Me.Shape3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape3.Top = 2640
		Me.Shape3.Width = 4215
		'
		' frmSecondary
		'
		Me.Name = "frmSecondary"
		Me.BackColor = FromOleColor6(CInt(&H00000000))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(313, 217)

		Me.Controls.Add(hscValue)
		Me.Controls.Add(txtMin)
		Me.Controls.Add(txtMax)
		Me.Controls.Add(cpbProgress)
		Me.Controls.Add(lblX)
		Me.Controls.Add(lblColor2)
		Me.Controls.Add(lblColor1)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.cpbProgress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.shpColor2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.shpColor1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
