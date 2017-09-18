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
	Public WithEvents Picture3 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture5 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImageList3 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Picture4 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents TreeView1 As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents ImageList2 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Command9 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSec As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuAbout As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture5 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImageList3 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Picture4 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.TreeView1 = New CodeArchitects.VB6Library.VB6TreeView()
		Me.ImageList2 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Command9 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSec = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.Picture2.SuspendLayout()
		Me.Picture1.SuspendLayout()
		Me.Picture4.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.ImageList3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(985, 2)
		Me.Picture2.Location = New System.Drawing.Point(0, 56)
		Me.Picture2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture2.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.TabIndex = 19
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture3
		'
		Me.Picture3.Name = "Picture3"
		Me.Picture3.Size = New System.Drawing.Size(1016, 1)
		Me.Picture3.Location = New System.Drawing.Point(-40, 1)
		Me.Picture3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture3.BackColor = FromOleColor6(CInt(&H8000000E))
		Me.Picture3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture3.TabIndex = 20
		Me.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(673, 19)
		Me.Text1.Location = New System.Drawing.Point(120, 32)
		Me.Text1.ForeColor = FromOleColor6(CInt(&H00808080))
		Me.Text1.ReadOnly = True
		Me.Text1.TabIndex = 0
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(20, 20)
		Me.Command1.Location = New System.Drawing.Point(795, 32)
		Me.Command1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Picture = CType(resources.GetObject("Command1.Picture"), System.Drawing.Image)
		Me.Command1.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(985, 2)
		Me.Picture1.Location = New System.Drawing.Point(-64, 24)
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 16
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture5
		'
		Me.Picture5.Name = "Picture5"
		Me.Picture5.Size = New System.Drawing.Size(1016, 1)
		Me.Picture5.Location = New System.Drawing.Point(-40, 1)
		Me.Picture5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture5.BackColor = FromOleColor6(CInt(&H8000000E))
		Me.Picture5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture5.TabIndex = 17
		Me.Picture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture5.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' ImageList3
		'
		Me.ImageList3.Name = "ImageList3"
		Me.ImageList3.ParentForm = Me
		Me.ImageList3.Name6 = "ImageList3"
		Me.ImageList3.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList3.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList3.ImageList.ImageSize = New System.Drawing.Size(200, 25)
		Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' Picture4
		'
		Me.Picture4.Name = "Picture4"
		Me.Picture4.Size = New System.Drawing.Size(206, 556)
		Me.Picture4.Location = New System.Drawing.Point(-8, 93)
		Me.Picture4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture4.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Picture4.TabIndex = 11
		Me.Picture4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' TreeView1
		'
		Me.TreeView1.Name = "TreeView1"
		Me.TreeView1.Size = New System.Drawing.Size(193, 553)
		Me.TreeView1.Location = New System.Drawing.Point(9, 0)
		Me.TreeView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TreeView1.TabIndex = 5
		Me.TreeView1.HideSelection = False
		Me.TreeView1.Indentation = 529
		Me.TreeView1.LabelEdit = CodeArchitects.VB6Library.MSComctlLib.LabelEditConstants.tvwManual
		Me.TreeView1.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.TreeView1.FullRowSelect = True
		Me.TreeView1.SingleSel = True
		Me.TreeView1.ImageList = ImageList2
		Me.TreeView1.LineStyle = CodeArchitects.VB6Library.MSComctlLib.TreeLineStyleConstants.tvwTreeLines
		'
		' ImageList2
		'
		Me.ImageList2.Name = "ImageList2"
		Me.ImageList2.ParentForm = Me
		Me.ImageList2.Name6 = "ImageList2"
		Me.ImageList2.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList2.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList2.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.Name6 = "ImageList1"
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(199, 93)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(197, 35)
		Me.Frame1.Location = New System.Drawing.Point(0, 56)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.TabIndex = 12
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(20, 20)
		Me.Command2.Location = New System.Drawing.Point(171, 11)
		Me.Command2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.DisabledPicture = CType(resources.GetObject("Command2.DisabledPicture"), System.Drawing.Image)
		Me.Command2.Enabled = False
		Me.Command2.Picture = CType(resources.GetObject("Command2.Picture"), System.Drawing.Image)
		Me.Command2.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command2.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.Command2, "Delete Folder")
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(20, 20)
		Me.Command3.Location = New System.Drawing.Point(151, 11)
		Me.Command3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.DisabledPicture = CType(resources.GetObject("Command3.DisabledPicture"), System.Drawing.Image)
		Me.Command3.Enabled = False
		Me.Command3.Picture = CType(resources.GetObject("Command3.Picture"), System.Drawing.Image)
		Me.Command3.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command3.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.Command3, "Edit Folder")
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(20, 20)
		Me.Command7.Location = New System.Drawing.Point(130, 11)
		Me.Command7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command7.DisabledPicture = CType(resources.GetObject("Command7.DisabledPicture"), System.Drawing.Image)
		Me.Command7.Enabled = False
		Me.Command7.Picture = CType(resources.GetObject("Command7.Picture"), System.Drawing.Image)
		Me.Command7.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command7.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.Command7, "New Folder")
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 11)
		Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Caption = "Folders"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.TabIndex = 14
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(617, 35)
		Me.Frame2.Location = New System.Drawing.Point(200, 56)
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.TabIndex = 13
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9
		'
		Me.Command9.Name = "Command9"
		Me.Command9.Size = New System.Drawing.Size(20, 20)
		Me.Command9.Location = New System.Drawing.Point(528, 11)
		Me.Command9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9.DisabledPicture = CType(resources.GetObject("Command9.DisabledPicture"), System.Drawing.Image)
		Me.Command9.Enabled = False
		Me.Command9.Picture = CType(resources.GetObject("Command9.Picture"), System.Drawing.Image)
		Me.Command9.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.Command9, "Open File")
		Me.Command9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4
		'
		Me.Command4.Name = "Command4"
		Me.Command4.Size = New System.Drawing.Size(20, 20)
		Me.Command4.Location = New System.Drawing.Point(592, 11)
		Me.Command4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.DisabledPicture = CType(resources.GetObject("Command4.DisabledPicture"), System.Drawing.Image)
		Me.Command4.Enabled = False
		Me.Command4.Picture = CType(resources.GetObject("Command4.Picture"), System.Drawing.Image)
		Me.Command4.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.Command4, "Delete File")
		Me.Command4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(20, 20)
		Me.Command5.Location = New System.Drawing.Point(571, 11)
		Me.Command5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.DisabledPicture = CType(resources.GetObject("Command5.DisabledPicture"), System.Drawing.Image)
		Me.Command5.Enabled = False
		Me.Command5.Picture = CType(resources.GetObject("Command5.Picture"), System.Drawing.Image)
		Me.Command5.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command5.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.Command5, "Edit File")
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(20, 20)
		Me.Command6.Location = New System.Drawing.Point(550, 11)
		Me.Command6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command6.DisabledPicture = CType(resources.GetObject("Command6.DisabledPicture"), System.Drawing.Image)
		Me.Command6.Enabled = False
		Me.Command6.Picture = CType(resources.GetObject("Command6.Picture"), System.Drawing.Image)
		Me.Command6.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command6.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.Command6, "New File")
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(289, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 11)
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Caption = "List of files inside the selected directory."
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.TabIndex = 15
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Select Langguage:"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 18
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
		'
		' mnuSec
		'
		Me.mnuSec.Name = "mnuSec"
		Me.mnuSec.Caption = "&Password Settings"
		Me.mnuSec.Shortcut = Keys.Control Or Keys.P
		'
		' sep1
		'
		Me.sep1.Name = "sep1"
		'
		' mnuClose
		'
		Me.mnuClose.Name = "mnuClose"
		Me.mnuClose.Caption = "&Close"
		Me.mnuClose.Shortcut = Keys.Control Or Keys.X
		'
		' mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Caption = "&About"
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(626, 556)
		Me.ListView1_Control.Location = New System.Drawing.Point(199, 93)
		Me.ListView1_Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ListView1_Control.TabIndex = 6
		Me.ListView1_Control.HideSelection = False
		Me.ListView1_Control.LabelWrap = True
		Me.ListView1_Control.LargeImageList = ImageList1.ImageList
		Me.ListView1_Control.SmallImageList = ImageList1.ImageList
		Me.ListView1_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.ListView1_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView1_Control.LabelEdit = False
		Me.ListView1_Control.MultiSelect = False
		Me.ListView1_Control.View = System.Windows.Forms.View.List
		Me.ListView1_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ListView1_Control.BackgroundImageTiled = False
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Code Library version 1.1  - by Philip V. Naparan"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(3, 41)
		Me.ClientSize = New System.Drawing.Size(819, 646)

		Me.Controls.Add(Picture2)
		Me.Picture2.Controls.Add(Picture3)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture5)
		Me.Controls.Add(Picture4)
		Me.Picture4.Controls.Add(TreeView1)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command7)
		Me.Frame1.Controls.Add(Label2)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(Command9)
		Me.Frame2.Controls.Add(Command4)
		Me.Frame2.Controls.Add(Command5)
		Me.Frame2.Controls.Add(Command6)
		Me.Frame2.Controls.Add(Label3)
		Me.Controls.Add(Label1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuSec)
		Me.mnuFile.DropDownItems.Add(sep1)
		Me.mnuFile.DropDownItems.Add(mnuClose)
		Me.MenuStrip1.Items.Add(mnuAbout)
		Me.Controls.Add(ListView1_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.ImageList3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture2.ResumeLayout(False)
		Me.Picture1.ResumeLayout(False)
		Me.Picture4.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
