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
		Me.imgMoon = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(imgMoon_007, imgMoon_006, imgMoon_005, imgMoon_004, imgMoon_003, imgMoon_002, imgMoon_001, imgMoon_000)
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
	Public imgMoon As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WithEvents cmdProgress As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ProgressBar1 As CodeArchitects.VB6Library.VB6ProgressBar
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdCreate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents StatusBar1 As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents imgMoon_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMoon_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents StatusBar1_Control As System.Windows.Forms.StatusStrip
	Public WithEvents StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel4 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel5 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel6 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel7 As System.Windows.Forms.ToolStripStatusLabel

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdProgress = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ProgressBar1 = New CodeArchitects.VB6Library.VB6ProgressBar()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdCreate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.StatusBar1 = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.imgMoon_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMoon_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.StatusBar1_Control = New System.Windows.Forms.StatusStrip()
		Me.StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel5 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel6 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel7 = New System.Windows.Forms.ToolStripStatusLabel()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMoon_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdProgress
		'
		Me.cmdProgress.Name = "cmdProgress"
		Me.cmdProgress.Size = New System.Drawing.Size(145, 41)
		Me.cmdProgress.Location = New System.Drawing.Point(16, 80)
		Me.cmdProgress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdProgress.Caption = "Show a progress bar"
		Me.cmdProgress.TabIndex = 5
		'
		' ProgressBar1
		'
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(57, 17)
		Me.ProgressBar1.Location = New System.Drawing.Point(176, 72)
		Me.ProgressBar1.TabIndex = 4
		Me.ProgressBar1.Visible = False
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(265, 25)
		Me.Text1.Location = New System.Drawing.Point(272, 128)
		Me.Text1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.TabIndex = 3
		'
		' cmdCreate
		'
		Me.cmdCreate.Name = "cmdCreate"
		Me.cmdCreate.Size = New System.Drawing.Size(145, 41)
		Me.cmdCreate.Location = New System.Drawing.Point(16, 24)
		Me.cmdCreate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate.Caption = "Create a new Panel"
		Me.cmdCreate.TabIndex = 1
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 500
		'
		' StatusBar1
		'
		Me.StatusBar1.Name = "StatusBar1"
		Me.StatusBar1.Location = New System.Drawing.Point(0, 206)
		Me.StatusBar1.Size = New Size(2, 2)
		Me.StatusBar1.StatusStrip = Me.StatusBar1_Control
		Me.StatusBar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBar1_Panel1, Me.StatusBar1_Panel2, Me.StatusBar1_Panel3, Me.StatusBar1_Panel4, Me.StatusBar1_Panel5, Me.StatusBar1_Panel6, Me.StatusBar1_Panel7})
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(41, 25)
		Me.Image1.Location = New System.Drawing.Point(48, 152)
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(281, 49)
		Me.Label1.Location = New System.Drawing.Point(272, 72)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Toggle the state of lock keys by double-clicking on the corresponding Panel, then check the result in this textbox:"
		Me.Label1.TabIndex = 2
		'
		' imgMoon_007
		'
		Me.imgMoon_007.Name = "imgMoon_007"
		Me.imgMoon_007.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_007.Location = New System.Drawing.Point(520, 24)
		Me.imgMoon_007.Visible = False
		Me.imgMoon_007.Picture = CType(resources.GetObject("imgMoon_007.Picture"), System.Drawing.Image)
		'
		' imgMoon_006
		'
		Me.imgMoon_006.Name = "imgMoon_006"
		Me.imgMoon_006.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_006.Location = New System.Drawing.Point(472, 24)
		Me.imgMoon_006.Visible = False
		Me.imgMoon_006.Picture = CType(resources.GetObject("imgMoon_006.Picture"), System.Drawing.Image)
		'
		' imgMoon_005
		'
		Me.imgMoon_005.Name = "imgMoon_005"
		Me.imgMoon_005.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_005.Location = New System.Drawing.Point(424, 24)
		Me.imgMoon_005.Visible = False
		Me.imgMoon_005.Picture = CType(resources.GetObject("imgMoon_005.Picture"), System.Drawing.Image)
		'
		' imgMoon_004
		'
		Me.imgMoon_004.Name = "imgMoon_004"
		Me.imgMoon_004.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_004.Location = New System.Drawing.Point(376, 24)
		Me.imgMoon_004.Visible = False
		Me.imgMoon_004.Picture = CType(resources.GetObject("imgMoon_004.Picture"), System.Drawing.Image)
		'
		' imgMoon_003
		'
		Me.imgMoon_003.Name = "imgMoon_003"
		Me.imgMoon_003.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_003.Location = New System.Drawing.Point(328, 24)
		Me.imgMoon_003.Visible = False
		Me.imgMoon_003.Picture = CType(resources.GetObject("imgMoon_003.Picture"), System.Drawing.Image)
		'
		' imgMoon_002
		'
		Me.imgMoon_002.Name = "imgMoon_002"
		Me.imgMoon_002.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_002.Location = New System.Drawing.Point(280, 24)
		Me.imgMoon_002.Visible = False
		Me.imgMoon_002.Picture = CType(resources.GetObject("imgMoon_002.Picture"), System.Drawing.Image)
		'
		' imgMoon_001
		'
		Me.imgMoon_001.Name = "imgMoon_001"
		Me.imgMoon_001.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_001.Location = New System.Drawing.Point(232, 24)
		Me.imgMoon_001.Visible = False
		Me.imgMoon_001.Picture = CType(resources.GetObject("imgMoon_001.Picture"), System.Drawing.Image)
		'
		' imgMoon_000
		'
		Me.imgMoon_000.Name = "imgMoon_000"
		Me.imgMoon_000.Size = New System.Drawing.Size(32, 32)
		Me.imgMoon_000.Location = New System.Drawing.Point(184, 24)
		Me.imgMoon_000.Visible = False
		Me.imgMoon_000.Picture = CType(resources.GetObject("imgMoon_000.Picture"), System.Drawing.Image)
		'
		' StatusBar1_Control
		'
		Me.StatusBar1_Control.Name = "StatusBar1_Control"
		Me.StatusBar1_Control.Size = New System.Drawing.Size(556, 25)
		Me.StatusBar1_Control.Location = New System.Drawing.Point(0, 206)
		Me.StatusBar1_Control.TabIndex = 0
		Me.StatusBar1_Control.ShowItemToolTips = True
		Me.StatusBar1_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' StatusBar1_Panel1
		'
		Me.StatusBar1_Panel1.Name = "StatusBar1_Panel1"
		Me.StatusBar1_Panel1.Text = "Click to edit text"
		Me.StatusBar1_Panel1.Image = CType(resources.GetObject("StatusBar1_Panel1.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel1.Tag = "Tag=Editable;"
		Me.StatusBar1_Panel1.AutoSize = False
		Me.StatusBar1_Panel1.Size = New System.Drawing.Size(133, 14)
		Me.StatusBar1_Panel1.DoubleClickEnabled = True
		Me.StatusBar1_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel2
		'
		Me.StatusBar1_Panel2.Name = "StatusBar1_Panel2"
		Me.StatusBar1_Panel2.Image = CType(resources.GetObject("StatusBar1_Panel2.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel2.Tag = "Style=6;"
		Me.StatusBar1_Panel2.AutoSize = False
		Me.StatusBar1_Panel2.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel2.DoubleClickEnabled = True
		Me.StatusBar1_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel3
		'
		Me.StatusBar1_Panel3.Name = "StatusBar1_Panel3"
		Me.StatusBar1_Panel3.Image = CType(resources.GetObject("StatusBar1_Panel3.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel3.Tag = "Style=5;"
		Me.StatusBar1_Panel3.AutoSize = False
		Me.StatusBar1_Panel3.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel3.DoubleClickEnabled = True
		Me.StatusBar1_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel4
		'
		Me.StatusBar1_Panel4.Name = "StatusBar1_Panel4"
		Me.StatusBar1_Panel4.Tag = "Style=1;"
		Me.StatusBar1_Panel4.AutoSize = False
		Me.StatusBar1_Panel4.Size = New System.Drawing.Size(53, 14)
		Me.StatusBar1_Panel4.DoubleClickEnabled = True
		Me.StatusBar1_Panel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel5
		'
		Me.StatusBar1_Panel5.Name = "StatusBar1_Panel5"
		Me.StatusBar1_Panel5.Tag = "Style=2;"
		Me.StatusBar1_Panel5.AutoSize = True
		Me.StatusBar1_Panel5.Size = New System.Drawing.Size(53, 14)
		Me.StatusBar1_Panel5.DoubleClickEnabled = True
		Me.StatusBar1_Panel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel6
		'
		Me.StatusBar1_Panel6.Name = "StatusBar1_Panel6"
		Me.StatusBar1_Panel6.Tag = "Style=4;"
		Me.StatusBar1_Panel6.AutoSize = True
		Me.StatusBar1_Panel6.Size = New System.Drawing.Size(53, 14)
		Me.StatusBar1_Panel6.DoubleClickEnabled = True
		Me.StatusBar1_Panel6.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel7
		'
		Me.StatusBar1_Panel7.Name = "StatusBar1_Panel7"
		Me.StatusBar1_Panel7.Tag = "Style=3;"
		Me.StatusBar1_Panel7.AutoSize = False
		Me.StatusBar1_Panel7.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel7.DoubleClickEnabled = True
		Me.StatusBar1_Panel7.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel7.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "StatusBar Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(556, 231)

		Me.Controls.Add(cmdProgress)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(cmdCreate)
		Me.Controls.Add(StatusBar1)
		Me.Controls.Add(Image1)
		Me.Controls.Add(Label1)
		Me.Controls.Add(imgMoon_007)
		Me.Controls.Add(imgMoon_006)
		Me.Controls.Add(imgMoon_005)
		Me.Controls.Add(imgMoon_004)
		Me.Controls.Add(imgMoon_003)
		Me.Controls.Add(imgMoon_002)
		Me.Controls.Add(imgMoon_001)
		Me.Controls.Add(imgMoon_000)
		Me.Controls.Add(StatusBar1_Control)
		Me.Controls.SetChildIndex(Me.StatusBar1, 0)
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMoon_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
