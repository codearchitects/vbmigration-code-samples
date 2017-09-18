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
		' Initialize control arrays.
		Me.Command3 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(Command3_001, Command3_000)
		Me.Option2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(Option2_002, Option2_001, Option2_000)
		Me.Option1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(Option1_002, Option1_001, Option1_000)
		Me.Text3 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(Text3_002, Text3_001, Text3_000)
		Me.Text4 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(Text4_002, Text4_001, Text4_000)
		Me.Text2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(Text2_001, Text2_000)
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
	Public Command3 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public Option2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public Option1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public Text3 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public Text4 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public Text2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public WithEvents Command3_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Combo2 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Option2_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents HScroll1 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Option1_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option2_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option2_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Text3_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text4_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text4_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text4_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text3_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text3_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text2_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text2_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents SwapScreen As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents SwapScreen2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Timer2 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Label14 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Command3_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Combo2 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Option2_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.HScroll1 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Option1_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option2_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option2_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Text3_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text4_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text4_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text4_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text3_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text3_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text2_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text2_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.SwapScreen = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.SwapScreen2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Timer2 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Label14 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Frame1.SuspendLayout()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command3_001
		'
		Me.Command3_001.Name = "Command3_001"
		Me.Command3_001.Size = New System.Drawing.Size(17, 17)
		Me.Command3_001.Location = New System.Drawing.Point(368, 32)
		Me.Command3_001.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3_001.Caption = "+"
		Me.Command3_001.TabIndex = 37
		Me.Command3_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3_000
		'
		Me.Command3_000.Name = "Command3_000"
		Me.Command3_000.Size = New System.Drawing.Size(17, 17)
		Me.Command3_000.Location = New System.Drawing.Point(352, 32)
		Me.Command3_000.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3_000.Caption = "-"
		Me.Command3_000.TabIndex = 36
		Me.Command3_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Combo2
		'
		Me.Combo2.Name = "Combo2"
		Me.Combo2.Size = New System.Drawing.Size(49, 21)
		Me.Combo2.Location = New System.Drawing.Point(392, 32)
		Me.Combo2.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.Combo2.TabIndex = 35
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(41, 17)
		Me.Command2.Location = New System.Drawing.Point(272, 32)
		Me.Command2.Caption = "Now"
		Me.Command2.TabIndex = 34
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(49, 21)
		Me.Combo1.Location = New System.Drawing.Point(392, 8)
		Me.Combo1.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.Combo1.TabIndex = 32
		'
		' Option2_002
		'
		Me.Option2_002.Name = "Option2_002"
		Me.Option2_002.Size = New System.Drawing.Size(33, 17)
		Me.Option2_002.Location = New System.Drawing.Point(480, 8)
		Me.Option2_002.Caption = "Rew"
		Me.Option2_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option2_002.TabIndex = 31
		Me.Option2_002.TabStop = True
		Me.Option2_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(57, 17)
		Me.Command1.Location = New System.Drawing.Point(624, 32)
		Me.Command1.Caption = "Refresh"
		Me.Command1.TabIndex = 9
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' HScroll1
		'
		Me.HScroll1.Name = "HScroll1"
		Me.HScroll1.Size = New System.Drawing.Size(73, 17)
		Me.HScroll1.Location = New System.Drawing.Point(480, 32)
		Me.HScroll1.LargeChange = 5
		Me.HScroll1.Max = 30
		Me.HScroll1.Min = 1
		Me.HScroll1.TabIndex = 28
		Me.HScroll1.Value = 1
		Me.HScroll1.TabStop = True
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(73, 25)
		Me.Frame1.Location = New System.Drawing.Point(256, 8)
		Me.Frame1.Caption = "Frame1"
		Me.Frame1.TabIndex = 25
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option1_002
		'
		Me.Option1_002.Name = "Option1_002"
		Me.Option1_002.Size = New System.Drawing.Size(25, 17)
		Me.Option1_002.Location = New System.Drawing.Point(48, 0)
		Me.Option1_002.Caption = "24"
		Me.Option1_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option1_002.TabIndex = 38
		Me.Option1_002.TabStop = True
		Me.Option1_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option1_001
		'
		Me.Option1_001.Name = "Option1_001"
		Me.Option1_001.Size = New System.Drawing.Size(25, 17)
		Me.Option1_001.Location = New System.Drawing.Point(24, 0)
		Me.Option1_001.Caption = "PM"
		Me.Option1_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option1_001.TabIndex = 27
		Me.Option1_001.TabStop = True
		Me.Option1_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option1_000
		'
		Me.Option1_000.Name = "Option1_000"
		Me.Option1_000.Size = New System.Drawing.Size(25, 17)
		Me.Option1_000.Location = New System.Drawing.Point(0, 0)
		Me.Option1_000.Caption = "AM"
		Me.Option1_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option1_000.TabIndex = 26
		Me.Option1_000.TabStop = True
		Me.Option1_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option2_001
		'
		Me.Option2_001.Name = "Option2_001"
		Me.Option2_001.Size = New System.Drawing.Size(33, 17)
		Me.Option2_001.Location = New System.Drawing.Point(512, 8)
		Me.Option2_001.Caption = "Stop"
		Me.Option2_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option2_001.TabIndex = 24
		Me.Option2_001.Value = True
		Me.Option2_001.TabStop = True
		Me.Option2_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option2_000
		'
		Me.Option2_000.Name = "Option2_000"
		Me.Option2_000.Size = New System.Drawing.Size(33, 17)
		Me.Option2_000.Location = New System.Drawing.Point(544, 8)
		Me.Option2_000.Caption = "Fwd"
		Me.Option2_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Option2_000.TabIndex = 23
		Me.Option2_000.TabStop = True
		Me.Option2_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text3_002
		'
		Me.Text3_002.Name = "Text3_002"
		Me.Text3_002.Size = New System.Drawing.Size(25, 19)
		Me.Text3_002.Location = New System.Drawing.Point(224, 8)
		Me.Text3_002.TabIndex = 21
		'
		' Text4_002
		'
		Me.Text4_002.Name = "Text4_002"
		Me.Text4_002.Size = New System.Drawing.Size(41, 19)
		Me.Text4_002.Location = New System.Drawing.Point(224, 32)
		Me.Text4_002.TabIndex = 13
		'
		' Text4_001
		'
		Me.Text4_001.Name = "Text4_001"
		Me.Text4_001.Size = New System.Drawing.Size(25, 19)
		Me.Text4_001.Location = New System.Drawing.Point(192, 32)
		Me.Text4_001.TabIndex = 12
		'
		' Text4_000
		'
		Me.Text4_000.Name = "Text4_000"
		Me.Text4_000.Size = New System.Drawing.Size(25, 19)
		Me.Text4_000.Location = New System.Drawing.Point(160, 32)
		Me.Text4_000.TabIndex = 11
		'
		' Text3_001
		'
		Me.Text3_001.Name = "Text3_001"
		Me.Text3_001.Size = New System.Drawing.Size(25, 19)
		Me.Text3_001.Location = New System.Drawing.Point(192, 8)
		Me.Text3_001.TabIndex = 4
		'
		' Text3_000
		'
		Me.Text3_000.Name = "Text3_000"
		Me.Text3_000.Size = New System.Drawing.Size(25, 19)
		Me.Text3_000.Location = New System.Drawing.Point(160, 8)
		Me.Text3_000.TabIndex = 3
		'
		' Text2_001
		'
		Me.Text2_001.Name = "Text2_001"
		Me.Text2_001.Size = New System.Drawing.Size(81, 19)
		Me.Text2_001.Location = New System.Drawing.Point(40, 32)
		Me.Text2_001.TabIndex = 2
		'
		' Text2_000
		'
		Me.Text2_000.Name = "Text2_000"
		Me.Text2_000.Size = New System.Drawing.Size(81, 19)
		Me.Text2_000.Location = New System.Drawing.Point(40, 8)
		Me.Text2_000.TabIndex = 1
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(721, 505)
		Me.Picture1.Location = New System.Drawing.Point(0, 56)
		Me.Picture1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.AutoRedraw = True
		Me.Picture1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Picture1.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.Picture1.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.Picture1.TabIndex = 0
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' SwapScreen
		'
		Me.SwapScreen.Name = "SwapScreen"
		Me.SwapScreen.Size = New System.Drawing.Size(697, 505)
		Me.SwapScreen.Location = New System.Drawing.Point(0, 56)
		Me.SwapScreen.AutoRedraw = True
		Me.SwapScreen.BackColor = FromOleColor6(CInt(&H00000000))
		Me.SwapScreen.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.SwapScreen.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.SwapScreen.TabIndex = 17
		Me.SwapScreen.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.SwapScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.SwapScreen.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' SwapScreen2
		'
		Me.SwapScreen2.Name = "SwapScreen2"
		Me.SwapScreen2.Size = New System.Drawing.Size(697, 505)
		Me.SwapScreen2.Location = New System.Drawing.Point(0, 56)
		Me.SwapScreen2.AutoRedraw = True
		Me.SwapScreen2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.SwapScreen2.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.SwapScreen2.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.SwapScreen2.TabIndex = 20
		Me.SwapScreen2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.SwapScreen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.SwapScreen2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Timer2
		'
		Me.Timer2.Name = "Timer2"
		Me.Timer2.ParentForm = Me
		Me.Timer2.Name6 = "Timer2"
		Me.Timer2.Interval = 10
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 1000
		'
		' Label14
		'
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(33, 17)
		Me.Label14.Location = New System.Drawing.Point(448, 8)
		Me.Label14.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label14.Caption = "Play"
		Me.Label14.TabIndex = 33
		Me.Label14.AutoSize = False
		Me.Label14.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(129, 17)
		Me.Label9.Location = New System.Drawing.Point(584, 8)
		Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label9.BackColor = FromOleColor6(CInt(&H00808080))
		Me.Label9.ForeColor = FromOleColor6(CInt(&H00C0FFFF))
		Me.Label9.TabIndex = 18
		Me.Label9.AutoSize = False
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(33, 17)
		Me.Label13.Location = New System.Drawing.Point(448, 32)
		Me.Label13.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label13.Caption = "Rate"
		Me.Label13.TabIndex = 30
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(25, 17)
		Me.Label12.Location = New System.Drawing.Point(552, 32)
		Me.Label12.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label12.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label12.Caption = "1"
		Me.Label12.TabIndex = 29
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(9, 17)
		Me.Label11.Location = New System.Drawing.Point(216, 8)
		Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label11.Caption = ":"
		Me.Label11.TabIndex = 22
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(129, 25)
		Me.Label10.Location = New System.Drawing.Point(584, 24)
		Me.Label10.TabIndex = 19
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(57, 17)
		Me.Label8.Location = New System.Drawing.Point(336, 8)
		Me.Label8.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label8.Caption = "Time Zone"
		Me.Label8.TabIndex = 16
		Me.Label8.AutoSize = False
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(9, 17)
		Me.Label7.Location = New System.Drawing.Point(216, 32)
		Me.Label7.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7.Caption = "/"
		Me.Label7.TabIndex = 15
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(9, 17)
		Me.Label6.Location = New System.Drawing.Point(184, 32)
		Me.Label6.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label6.Caption = "/"
		Me.Label6.TabIndex = 14
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(128, 32)
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "Date"
		Me.Label5.TabIndex = 10
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(33, 17)
		Me.Label4.Location = New System.Drawing.Point(128, 8)
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "Time"
		Me.Label4.TabIndex = 8
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 8)
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "Lat."
		Me.Label3.TabIndex = 7
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Long."
		Me.Label1.TabIndex = 6
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(9, 17)
		Me.Label2.Location = New System.Drawing.Point(184, 8)
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2.Caption = ":"
		Me.Label2.TabIndex = 5
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BackColor = FromOleColor6(CInt(&H00FFC0C0))
		Me.Shape1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape1.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbTransparent
		Me.Shape1.Height = 57
		Me.Shape1.Left = 440
		Me.Shape1.Top = 0
		Me.Shape1.Width = 145
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Stars"
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(720, 560)

		Me.Controls.Add(Command3_001)
		Me.Controls.Add(Command3_000)
		Me.Controls.Add(Combo2)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(Option2_002)
		Me.Controls.Add(Command1)
		Me.Controls.Add(HScroll1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Option1_002)
		Me.Frame1.Controls.Add(Option1_001)
		Me.Frame1.Controls.Add(Option1_000)
		Me.Controls.Add(Option2_001)
		Me.Controls.Add(Option2_000)
		Me.Controls.Add(Text3_002)
		Me.Controls.Add(Text4_002)
		Me.Controls.Add(Text4_001)
		Me.Controls.Add(Text4_000)
		Me.Controls.Add(Text3_001)
		Me.Controls.Add(Text3_000)
		Me.Controls.Add(Text2_001)
		Me.Controls.Add(Text2_000)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(SwapScreen)
		Me.Controls.Add(SwapScreen2)
		Me.Controls.Add(Label14)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label13)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
