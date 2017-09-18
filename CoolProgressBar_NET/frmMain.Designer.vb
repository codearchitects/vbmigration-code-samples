<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
	Public WithEvents cpbProgress As pCoolProgressBar_Demo.CoolProgressBar
	Public WithEvents tmrTimer As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents lblX As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape7 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents lblPercentage As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape6 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Line6 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Shape5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Shape4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Line5 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Shape3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line4 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line3 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line2 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line1 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.cpbProgress = New pCoolProgressBar_Demo.CoolProgressBar()
		Me.tmrTimer = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.lblX = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape7 = New CodeArchitects.VB6Library.VB6Shape()
		Me.lblPercentage = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape6 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Line6 = New CodeArchitects.VB6Library.VB6Line()
		Me.Shape5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Shape4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Line5 = New CodeArchitects.VB6Library.VB6Line()
		Me.Shape3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Line4 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line3 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line2 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line1 = New CodeArchitects.VB6Library.VB6Line()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		CType(Me.cpbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cpbProgress
		'
		Me.cpbProgress.Name = "cpbProgress"
		Me.cpbProgress.Size = New System.Drawing.Size(265, 17)
		Me.cpbProgress.Location = New System.Drawing.Point(24, 100)
		Me.cpbProgress.TabIndex = 0
		Me.cpbProgress.BackColor = FromOleColor6(CInt(0))
		Me.cpbProgress.Color2 = FromOleColor6(CInt(8438015))
		Me.cpbProgress.Color1 = FromOleColor6(CInt(128))
		Me.cpbProgress.Max = 200
		Me.cpbProgress.Value = 0
		'
		' tmrTimer
		'
		Me.tmrTimer.Name = "tmrTimer"
		Me.tmrTimer.ParentForm = Me
		Me.tmrTimer.Name6 = "tmrTimer"
		Me.tmrTimer.Interval = 100
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
		Me.lblX.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.lblX, "Skip")
		Me.lblX.AutoSize = False
		'
		' Shape7
		'
		Me.Shape7.Name = "Shape7"
		Me.Shape7.ParentForm = Me
		Me.Shape7.Name6 = "Shape7"
		Me.Shape7.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape7.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape7.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Shape7.Height = 255
		Me.Shape7.Left = 4320
		Me.Shape7.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape7.Top = 120
		Me.Shape7.Width = 255
		'
		' lblPercentage
		'
		Me.lblPercentage.Name = "lblPercentage"
		Me.lblPercentage.Size = New System.Drawing.Size(65, 17)
		Me.lblPercentage.Location = New System.Drawing.Point(144, 128)
		Me.lblPercentage.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPercentage.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPercentage.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblPercentage.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblPercentage.Caption = "0%"
		Me.lblPercentage.ForeColor = FromOleColor6(CInt(&H000040C0))
		Me.lblPercentage.TabIndex = 8
		Me.lblPercentage.AutoSize = False
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.Location = New System.Drawing.Point(144, 128)
		Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label7.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label7.Caption = "| |               | |"
		Me.Label7.ForeColor = FromOleColor6(CInt(&H000080FF))
		Me.Label7.TabIndex = 7
		Me.Label7.AutoSize = False
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(232, 56)
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label6.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label6.Caption = "| | | | | | | | | | | |"
		Me.Label6.ForeColor = FromOleColor6(CInt(&H000080FF))
		Me.Label6.TabIndex = 6
		Me.Label6.AutoSize = False
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(65, 17)
		Me.Label5.Location = New System.Drawing.Point(56, 56)
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "| | | | | | | | | | | |"
		Me.Label5.ForeColor = FromOleColor6(CInt(&H000080FF))
		Me.Label5.TabIndex = 5
		Me.Label5.AutoSize = False
		'
		' Shape6
		'
		Me.Shape6.Name = "Shape6"
		Me.Shape6.ParentForm = Me
		Me.Shape6.Name6 = "Shape6"
		Me.Shape6.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape6.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Shape6.Height = 255
		Me.Shape6.Left = 2160
		Me.Shape6.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape6.Top = 1920
		Me.Shape6.Width = 975
		'
		' Line6
		'
		Me.Line6.Name = "Line6"
		Me.Line6.ParentForm = Me
		Me.Line6.Name6 = "Line6"
		Me.Line6.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Line6.X1 = 0
		Me.Line6.X2 = 4680
		Me.Line6.Y1 = 2040
		Me.Line6.Y2 = 2040
		'
		' Shape5
		'
		Me.Shape5.Name = "Shape5"
		Me.Shape5.ParentForm = Me
		Me.Shape5.Name6 = "Shape5"
		Me.Shape5.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape5.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Shape5.Height = 255
		Me.Shape5.Left = 840
		Me.Shape5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape5.Top = 840
		Me.Shape5.Width = 975
		'
		' Shape4
		'
		Me.Shape4.Name = "Shape4"
		Me.Shape4.ParentForm = Me
		Me.Shape4.Name6 = "Shape4"
		Me.Shape4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape4.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Shape4.Height = 255
		Me.Shape4.Left = 3480
		Me.Shape4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape4.Top = 840
		Me.Shape4.Width = 975
		'
		' Line5
		'
		Me.Line5.Name = "Line5"
		Me.Line5.ParentForm = Me
		Me.Line5.Name6 = "Line5"
		Me.Line5.BorderColor = FromOleColor6(CInt(&H000040C0))
		Me.Line5.X1 = 0
		Me.Line5.X2 = 4680
		Me.Line5.Y1 = 960
		Me.Line5.Y2 = 960
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
		Me.Shape3.Top = 1440
		Me.Shape3.Width = 4215
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 17)
		Me.Label1.Location = New System.Drawing.Point(136, 16)
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Please wait..."
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		'
		' Line4
		'
		Me.Line4.Name = "Line4"
		Me.Line4.ParentForm = Me
		Me.Line4.Name6 = "Line4"
		Me.Line4.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Line4.X1 = 360
		Me.Line4.X2 = 360
		Me.Line4.Y1 = 1440
		Me.Line4.Y2 = 360
		'
		' Line3
		'
		Me.Line3.Name = "Line3"
		Me.Line3.ParentForm = Me
		Me.Line3.Name6 = "Line3"
		Me.Line3.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Line3.X1 = 360
		Me.Line3.X2 = 2040
		Me.Line3.Y1 = 360
		Me.Line3.Y2 = 360
		'
		' Line2
		'
		Me.Line2.Name = "Line2"
		Me.Line2.ParentForm = Me
		Me.Line2.Name6 = "Line2"
		Me.Line2.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Line2.X1 = 4320
		Me.Line2.X2 = 4320
		Me.Line2.Y1 = 2760
		Me.Line2.Y2 = 1800
		'
		' Line1
		'
		Me.Line1.Name = "Line1"
		Me.Line1.ParentForm = Me
		Me.Line1.Name6 = "Line1"
		Me.Line1.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Line1.X1 = 3240
		Me.Line1.X2 = 4320
		Me.Line1.Y1 = 2760
		Me.Line1.Y2 = 2760
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(185, 41)
		Me.Label2.Location = New System.Drawing.Point(32, 160)
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Loading . . ."
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label2.TabIndex = 2
		Me.Label2.AutoSize = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(313, 73)
		Me.Label3.Location = New System.Drawing.Point(0, 144)
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 48!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "Loading . . ."
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00004080))
		Me.Label3.TabIndex = 3
		Me.Label3.AutoSize = False
		'
		' Shape2
		'
		Me.Shape2.Name = "Shape2"
		Me.Shape2.ParentForm = Me
		Me.Shape2.Name6 = "Shape2"
		Me.Shape2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape2.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape2.Height = 615
		Me.Shape2.Left = 480
		Me.Shape2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape2.Top = 2400
		Me.Shape2.Width = 2775
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(217, 33)
		Me.Label4.Location = New System.Drawing.Point(96, 0)
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "Please wait . . ."
		Me.Label4.ForeColor = FromOleColor6(CInt(&H00004080))
		Me.Label4.TabIndex = 4
		Me.Label4.AutoSize = False
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape1.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape1.Height = 255
		Me.Shape1.Left = 2040
		Me.Shape1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape1.Top = 240
		Me.Shape1.Width = 2175
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.BackColor = FromOleColor6(CInt(&H00000000))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(313, 217)

		Me.Controls.Add(cpbProgress)
		Me.Controls.Add(lblX)
		Me.Controls.Add(lblPercentage)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label4)
		CType(Me.cpbProgress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
