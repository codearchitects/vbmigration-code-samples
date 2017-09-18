<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class fd
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
		Me.mnuDrive = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuDrive_000)
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
	Public mnuDrive As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents pb As CodeArchitects.VB6Library.VB6ProgressBar
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents cds As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuAddCd As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCancel As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep01 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuDrive_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCDOptions As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuInfo2 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuInfo As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents fdshg As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuRemCD As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fd))
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.pb = New CodeArchitects.VB6Library.VB6ProgressBar()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.cds = New CodeArchitects.VB6Library.VB6TreeView()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuAddCd = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCancel = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep01 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuDrive_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCDOptions = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuInfo2 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuInfo = New CodeArchitects.VB6Library.VB6Menu()
		Me.fdshg = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuRemCD = New CodeArchitects.VB6Library.VB6Menu()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(121, 17)
		Me.Command3.Location = New System.Drawing.Point(624, 52)
		Me.Command3.Caption = "Compress Database"
		Me.Command3.TabIndex = 8
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' pb
		'
		Me.pb.Name = "pb"
		Me.pb.Size = New System.Drawing.Size(337, 25)
		Me.pb.Location = New System.Drawing.Point(416, 24)
		Me.pb.TabIndex = 7
		Me.pb.Scrolling = CodeArchitects.VB6Library.MSComctlLib.ScrollingConstants.ccScrollingSmooth
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(312, 72)
		Me.ListView1.Sorted = True
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1})
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(89, 25)
		Me.Command1.Location = New System.Drawing.Point(320, 24)
		Me.Command1.Caption = "Add CD"
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(233, 19)
		Me.Text1.Location = New System.Drawing.Point(312, 51)
		Me.Text1.TabIndex = 2
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
		' cds
		'
		Me.cds.Name = "cds"
		Me.cds.Size = New System.Drawing.Size(305, 497)
		Me.cds.Location = New System.Drawing.Point(0, 24)
		Me.cds.TabIndex = 0
		Me.cds.Indentation = 265
		Me.cds.LabelEdit = CodeArchitects.VB6Library.MSComctlLib.LabelEditConstants.tvwManual
		Me.cds.LineStyle = CodeArchitects.VB6Library.MSComctlLib.TreeLineStyleConstants.tvwRootLines
		Me.cds.Sorted = True
		Me.cds.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.cds.HotTracking = True
		Me.cds.SingleSel = True
		Me.cds.ImageList = ImageList1
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 17)
		Me.Command2.Location = New System.Drawing.Point(552, 52)
		Me.Command2.Caption = "Search"
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(433, 35)
		Me.Text2.Location = New System.Drawing.Point(312, 363)
		Me.Text2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text2.ReadOnly = True
		Me.Text2.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbArrow
		Me.Text2.TabIndex = 6
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(435, 117)
		Me.Label1.Location = New System.Drawing.Point(312, 400)
		Me.Label1.TabIndex = 5
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuAddCd
		'
		Me.mnuAddCd.Name = "mnuAddCd"
		Me.mnuAddCd.Caption = "mnuAddCD"
		Me.mnuAddCd.Visible = False
		'
		' mnuCancel
		'
		Me.mnuCancel.Name = "mnuCancel"
		Me.mnuCancel.Caption = "Cancel"
		'
		' sep01
		'
		Me.sep01.Name = "sep01"
		'
		' mnuDrive_000
		'
		Me.mnuDrive_000.Name = "mnuDrive_000"
		Me.mnuDrive_000.Caption = "mnuDrive"
		'
		' mnuCDOptions
		'
		Me.mnuCDOptions.Name = "mnuCDOptions"
		Me.mnuCDOptions.Caption = "mnuCDOptions"
		Me.mnuCDOptions.Visible = False
		'
		' mnuInfo2
		'
		Me.mnuInfo2.Name = "mnuInfo2"
		Me.mnuInfo2.Caption = ""
		'
		' mnuInfo
		'
		Me.mnuInfo.Name = "mnuInfo"
		Me.mnuInfo.Caption = ""
		'
		' fdshg
		'
		Me.fdshg.Name = "fdshg"
		'
		' mnuRemCD
		'
		Me.mnuRemCD.Name = "mnuRemCD"
		Me.mnuRemCD.Caption = "Remove CD From Archive"
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(441, 289)
		Me.ListView1_Control.Location = New System.Drawing.Point(312, 72)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ListView1_Control.TabIndex = 4
		Me.ListView1_Control.HideSelection = True
		Me.ListView1_Control.LabelWrap = True
		Me.ListView1_Control.LargeImageList = ImageList1.ImageList
		Me.ListView1_Control.SmallImageList = ImageList1.ImageList
		Me.ListView1_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.ListView1_Control.LabelEdit = False
		Me.ListView1_Control.MultiSelect = False
		Me.ListView1_Control.View = System.Windows.Forms.View.Details
		Me.ListView1_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ListView1_Control.BackgroundImageTiled = False
		'
		' ListView1_Column1
		'
		Me.ListView1_Column1.Name = "ListView1_Column1"
		Me.ListView1_Column1.Text = "Results"
		Me.ListView1_Column1.Width = 96
		'
		' fd
		'
		Me.Name = "fd"
		Me.Caption = "CDArchive"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(752, 523)

		Me.Controls.Add(Command3)
		Me.Controls.Add(pb)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(cds)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuAddCd)
		Me.mnuAddCd.DropDownItems.Add(mnuCancel)
		Me.mnuAddCd.DropDownItems.Add(sep01)
		Me.mnuAddCd.DropDownItems.Add(mnuDrive_000)
		Me.MenuStrip1.Items.Add(mnuCDOptions)
		Me.mnuCDOptions.DropDownItems.Add(mnuInfo2)
		Me.mnuCDOptions.DropDownItems.Add(mnuInfo)
		Me.mnuCDOptions.DropDownItems.Add(fdshg)
		Me.mnuCDOptions.DropDownItems.Add(mnuRemCD)
		Me.Controls.Add(ListView1_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
