<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MainFrm
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
		Me.Image2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(Image2_020, Image2_019, Image2_018, Image2_017, Image2_016, Image2_015, Image2_014, Image2_013, Image2_012, Image2_011, Image2_010, Image2_009, Image2_008, Image2_007, Image2_006, Image2_005, Image2_004, Image2_003, Image2_002, Image2_001, Image2_000)
		Me.Image1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(Image1_000, Image1_001, Image1_002, Image1_003, Image1_004, Image1_005, Image1_006, Image1_007, Image1_008, Image1_009)
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
	Public Image2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public Image1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WithEvents Timer2 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Image2_020 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_019 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_018 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_017 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_016 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_015 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_014 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_013 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_012 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_011 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_010 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_009 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1_009 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainFrm))
		Me.Timer2 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Image2_020 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_019 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_018 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_017 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_016 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_015 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_014 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_013 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_012 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_011 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_010 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_009 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1_009 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.Image2_020, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_019, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_018, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_017, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_016, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_015, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_014, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_013, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_012, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_011, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_009, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1_009, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Timer2
		'
		Me.Timer2.Name = "Timer2"
		Me.Timer2.ParentForm = Me
		Me.Timer2.Name6 = "Timer2"
		Me.Timer2.Interval = 100
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 1
		'
		' Image2_020
		'
		Me.Image2_020.Name = "Image2_020"
		Me.Image2_020.Size = New System.Drawing.Size(10, 39)
		Me.Image2_020.Location = New System.Drawing.Point(301, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_020, "Exit")
		Me.Image2_020.Picture = CType(resources.GetObject("Image2_020.Picture"), System.Drawing.Image)
		Me.Image2_020.Stretch = False
		'
		' Image2_019
		'
		Me.Image2_019.Name = "Image2_019"
		Me.Image2_019.Size = New System.Drawing.Size(12, 39)
		Me.Image2_019.Location = New System.Drawing.Point(0, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_019, "Hide For 10 Seconds")
		Me.Image2_019.Picture = CType(resources.GetObject("Image2_019.Picture"), System.Drawing.Image)
		Me.Image2_019.Stretch = False
		'
		' Image2_018
		'
		Me.Image2_018.Name = "Image2_018"
		Me.Image2_018.Size = New System.Drawing.Size(10, 39)
		Me.Image2_018.Location = New System.Drawing.Point(223, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_018, "Help")
		Me.Image2_018.Picture = CType(resources.GetObject("Image2_018.Picture"), System.Drawing.Image)
		Me.Image2_018.Stretch = False
		'
		' Image2_017
		'
		Me.Image2_017.Name = "Image2_017"
		Me.Image2_017.Size = New System.Drawing.Size(10, 39)
		Me.Image2_017.Location = New System.Drawing.Point(179, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_017, "Swap Day And Month")
		Me.Image2_017.Picture = CType(resources.GetObject("Image2_017.Picture"), System.Drawing.Image)
		Me.Image2_017.Stretch = False
		'
		' Image2_016
		'
		Me.Image2_016.Name = "Image2_016"
		Me.Image2_016.Size = New System.Drawing.Size(17, 39)
		Me.Image2_016.Location = New System.Drawing.Point(128, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_016, "Move")
		Me.Image2_016.Picture = CType(resources.GetObject("Image2_016.Picture"), System.Drawing.Image)
		Me.Image2_016.Stretch = False
		'
		' Image2_015
		'
		Me.Image2_015.Name = "Image2_015"
		Me.Image2_015.Size = New System.Drawing.Size(7, 39)
		Me.Image2_015.Location = New System.Drawing.Point(87, 0)
		Me.Image2_015.Picture = CType(resources.GetObject("Image2_015.Picture"), System.Drawing.Image)
		Me.Image2_015.Stretch = False
		'
		' Image2_014
		'
		Me.Image2_014.Name = "Image2_014"
		Me.Image2_014.Size = New System.Drawing.Size(7, 39)
		Me.Image2_014.Location = New System.Drawing.Point(46, 0)
		Me.Image2_014.Picture = CType(resources.GetObject("Image2_014.Picture"), System.Drawing.Image)
		Me.Image2_014.Stretch = False
		'
		' Image2_013
		'
		Me.Image2_013.Name = "Image2_013"
		Me.Image2_013.Size = New System.Drawing.Size(17, 39)
		Me.Image2_013.Location = New System.Drawing.Point(284, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_013, "Year")
		Me.Image2_013.Stretch = False
		'
		' Image2_012
		'
		Me.Image2_012.Name = "Image2_012"
		Me.Image2_012.Size = New System.Drawing.Size(17, 39)
		Me.Image2_012.Location = New System.Drawing.Point(267, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_012, "Year")
		Me.Image2_012.Stretch = False
		'
		' Image2_011
		'
		Me.Image2_011.Name = "Image2_011"
		Me.Image2_011.Size = New System.Drawing.Size(17, 39)
		Me.Image2_011.Location = New System.Drawing.Point(250, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_011, "Year")
		Me.Image2_011.Stretch = False
		'
		' Image2_010
		'
		Me.Image2_010.Name = "Image2_010"
		Me.Image2_010.Size = New System.Drawing.Size(17, 39)
		Me.Image2_010.Location = New System.Drawing.Point(233, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_010, "Year")
		Me.Image2_010.Stretch = False
		'
		' Image2_009
		'
		Me.Image2_009.Name = "Image2_009"
		Me.Image2_009.Size = New System.Drawing.Size(17, 39)
		Me.Image2_009.Location = New System.Drawing.Point(206, 0)
		Me.Image2_009.Stretch = False
		'
		' Image2_008
		'
		Me.Image2_008.Name = "Image2_008"
		Me.Image2_008.Size = New System.Drawing.Size(17, 39)
		Me.Image2_008.Location = New System.Drawing.Point(189, 0)
		Me.Image2_008.Stretch = False
		'
		' Image2_007
		'
		Me.Image2_007.Name = "Image2_007"
		Me.Image2_007.Size = New System.Drawing.Size(17, 39)
		Me.Image2_007.Location = New System.Drawing.Point(162, 0)
		Me.Image2_007.Stretch = False
		'
		' Image2_006
		'
		Me.Image2_006.Name = "Image2_006"
		Me.Image2_006.Size = New System.Drawing.Size(17, 39)
		Me.Image2_006.Location = New System.Drawing.Point(145, 0)
		Me.Image2_006.Stretch = False
		'
		' Image2_005
		'
		Me.Image2_005.Name = "Image2_005"
		Me.Image2_005.Size = New System.Drawing.Size(17, 39)
		Me.Image2_005.Location = New System.Drawing.Point(111, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_005, "Second")
		Me.Image2_005.Stretch = False
		'
		' Image2_004
		'
		Me.Image2_004.Name = "Image2_004"
		Me.Image2_004.Size = New System.Drawing.Size(17, 39)
		Me.Image2_004.Location = New System.Drawing.Point(94, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_004, "Second")
		Me.Image2_004.Stretch = False
		'
		' Image2_003
		'
		Me.Image2_003.Name = "Image2_003"
		Me.Image2_003.Size = New System.Drawing.Size(17, 39)
		Me.Image2_003.Location = New System.Drawing.Point(70, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_003, "Minute")
		Me.Image2_003.Stretch = False
		'
		' Image2_002
		'
		Me.Image2_002.Name = "Image2_002"
		Me.Image2_002.Size = New System.Drawing.Size(17, 39)
		Me.Image2_002.Location = New System.Drawing.Point(53, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_002, "Minute")
		Me.Image2_002.Stretch = False
		'
		' Image2_001
		'
		Me.Image2_001.Name = "Image2_001"
		Me.Image2_001.Size = New System.Drawing.Size(17, 39)
		Me.Image2_001.Location = New System.Drawing.Point(29, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_001, "Hour")
		Me.Image2_001.Stretch = False
		'
		' Image2_000
		'
		Me.Image2_000.Name = "Image2_000"
		Me.Image2_000.Size = New System.Drawing.Size(17, 39)
		Me.Image2_000.Location = New System.Drawing.Point(12, 0)
		Me.ToolTip1.SetToolTip(Me.Image2_000, "Hour")
		Me.Image2_000.Stretch = False
		'
		' Image1_000
		'
		Me.Image1_000.Name = "Image1_000"
		Me.Image1_000.Size = New System.Drawing.Size(17, 39)
		Me.Image1_000.Location = New System.Drawing.Point(60, 113)
		Me.Image1_000.Visible = False
		Me.Image1_000.Picture = CType(resources.GetObject("Image1_000.Picture"), System.Drawing.Image)
		Me.Image1_000.Stretch = False
		'
		' Image1_001
		'
		Me.Image1_001.Name = "Image1_001"
		Me.Image1_001.Size = New System.Drawing.Size(17, 39)
		Me.Image1_001.Location = New System.Drawing.Point(82, 113)
		Me.Image1_001.Visible = False
		Me.Image1_001.Picture = CType(resources.GetObject("Image1_001.Picture"), System.Drawing.Image)
		Me.Image1_001.Stretch = False
		'
		' Image1_002
		'
		Me.Image1_002.Name = "Image1_002"
		Me.Image1_002.Size = New System.Drawing.Size(17, 39)
		Me.Image1_002.Location = New System.Drawing.Point(106, 113)
		Me.Image1_002.Visible = False
		Me.Image1_002.Picture = CType(resources.GetObject("Image1_002.Picture"), System.Drawing.Image)
		Me.Image1_002.Stretch = False
		'
		' Image1_003
		'
		Me.Image1_003.Name = "Image1_003"
		Me.Image1_003.Size = New System.Drawing.Size(17, 39)
		Me.Image1_003.Location = New System.Drawing.Point(130, 113)
		Me.Image1_003.Visible = False
		Me.Image1_003.Picture = CType(resources.GetObject("Image1_003.Picture"), System.Drawing.Image)
		Me.Image1_003.Stretch = False
		'
		' Image1_004
		'
		Me.Image1_004.Name = "Image1_004"
		Me.Image1_004.Size = New System.Drawing.Size(17, 39)
		Me.Image1_004.Location = New System.Drawing.Point(154, 113)
		Me.Image1_004.Visible = False
		Me.Image1_004.Picture = CType(resources.GetObject("Image1_004.Picture"), System.Drawing.Image)
		Me.Image1_004.Stretch = False
		'
		' Image1_005
		'
		Me.Image1_005.Name = "Image1_005"
		Me.Image1_005.Size = New System.Drawing.Size(17, 39)
		Me.Image1_005.Location = New System.Drawing.Point(178, 113)
		Me.Image1_005.Visible = False
		Me.Image1_005.Picture = CType(resources.GetObject("Image1_005.Picture"), System.Drawing.Image)
		Me.Image1_005.Stretch = False
		'
		' Image1_006
		'
		Me.Image1_006.Name = "Image1_006"
		Me.Image1_006.Size = New System.Drawing.Size(17, 39)
		Me.Image1_006.Location = New System.Drawing.Point(202, 113)
		Me.Image1_006.Visible = False
		Me.Image1_006.Picture = CType(resources.GetObject("Image1_006.Picture"), System.Drawing.Image)
		Me.Image1_006.Stretch = False
		'
		' Image1_007
		'
		Me.Image1_007.Name = "Image1_007"
		Me.Image1_007.Size = New System.Drawing.Size(17, 39)
		Me.Image1_007.Location = New System.Drawing.Point(226, 113)
		Me.Image1_007.Visible = False
		Me.Image1_007.Picture = CType(resources.GetObject("Image1_007.Picture"), System.Drawing.Image)
		Me.Image1_007.Stretch = False
		'
		' Image1_008
		'
		Me.Image1_008.Name = "Image1_008"
		Me.Image1_008.Size = New System.Drawing.Size(17, 39)
		Me.Image1_008.Location = New System.Drawing.Point(250, 113)
		Me.Image1_008.Visible = False
		Me.Image1_008.Picture = CType(resources.GetObject("Image1_008.Picture"), System.Drawing.Image)
		Me.Image1_008.Stretch = False
		'
		' Image1_009
		'
		Me.Image1_009.Name = "Image1_009"
		Me.Image1_009.Size = New System.Drawing.Size(17, 39)
		Me.Image1_009.Location = New System.Drawing.Point(274, 113)
		Me.Image1_009.Visible = False
		Me.Image1_009.Picture = CType(resources.GetObject("Image1_009.Picture"), System.Drawing.Image)
		Me.Image1_009.Stretch = False
		'
		' MainFrm
		'
		Me.Name = "MainFrm"
		Me.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "Form1"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.ShowInTaskbar = False
		Me.Location = New System.Drawing.Point(10, 29)
		Me.ClientSize = New System.Drawing.Size(378, 69)

		Me.Controls.Add(Image2_020)
		Me.Controls.Add(Image2_019)
		Me.Controls.Add(Image2_018)
		Me.Controls.Add(Image2_017)
		Me.Controls.Add(Image2_016)
		Me.Controls.Add(Image2_015)
		Me.Controls.Add(Image2_014)
		Me.Controls.Add(Image2_013)
		Me.Controls.Add(Image2_012)
		Me.Controls.Add(Image2_011)
		Me.Controls.Add(Image2_010)
		Me.Controls.Add(Image2_009)
		Me.Controls.Add(Image2_008)
		Me.Controls.Add(Image2_007)
		Me.Controls.Add(Image2_006)
		Me.Controls.Add(Image2_005)
		Me.Controls.Add(Image2_004)
		Me.Controls.Add(Image2_003)
		Me.Controls.Add(Image2_002)
		Me.Controls.Add(Image2_001)
		Me.Controls.Add(Image2_000)
		Me.Controls.Add(Image1_000)
		Me.Controls.Add(Image1_001)
		Me.Controls.Add(Image1_002)
		Me.Controls.Add(Image1_003)
		Me.Controls.Add(Image1_004)
		Me.Controls.Add(Image1_005)
		Me.Controls.Add(Image1_006)
		Me.Controls.Add(Image1_007)
		Me.Controls.Add(Image1_008)
		Me.Controls.Add(Image1_009)
		CType(Me.Image2_020, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_019, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_018, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_017, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_016, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_015, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_014, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_013, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_012, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_011, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_009, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1_009, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
