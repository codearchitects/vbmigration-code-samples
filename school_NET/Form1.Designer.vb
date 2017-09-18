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
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents SSTab1 As CodeArchitects.VB6Library.VB6SSTab
	Public WithEvents SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents Label21 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text18 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command8 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label20 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label19 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Command9 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command10 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text17 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text16 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text15 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text14 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture5 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture6 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text13 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text12 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text11 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text10 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text9 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture3 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture4 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text8 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text7 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text6 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text5 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text4 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text3 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label18 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label17 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label16 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label15 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label14 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column3 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column4 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column5 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column6 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SSTab1 = New CodeArchitects.VB6Library.VB6SSTab()
		Me.SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
		Me.Label21 = New CodeArchitects.VB6Library.VB6Label()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text18 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command8 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label20 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label19 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Command9 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command10 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text17 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text16 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text15 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text14 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture5 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture6 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text13 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text12 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text11 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text10 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text9 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture3 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture4 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text8 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text7 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text6 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text5 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text4 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text3 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label18 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label17 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label16 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label15 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label14 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column4 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column5 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column6 = New System.Windows.Forms.ColumnHeader()
		Me.SSTab1.SuspendLayout()
		Me.SSTab1_TabPage0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SSTab1_TabPage1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Picture5.SuspendLayout()
		Me.Picture3.SuspendLayout()
		Me.Picture1.SuspendLayout()
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(89, 23)
		Me.Command6.Location = New System.Drawing.Point(608, 424)
		Me.Command6.Caption = "&Close"
		Me.Command6.TabIndex = 6
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(105, 23)
		Me.Command5.Location = New System.Drawing.Point(496, 424)
		Me.Command5.Caption = "&Reload Record"
		Me.Command5.TabIndex = 5
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4
		'
		Me.Command4.Name = "Command4"
		Me.Command4.Size = New System.Drawing.Size(73, 23)
		Me.Command4.Location = New System.Drawing.Point(416, 424)
		Me.Command4.Caption = "De&lete"
		Me.Command4.TabIndex = 4
		Me.Command4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(129, 23)
		Me.Command3.Location = New System.Drawing.Point(280, 424)
		Me.Command3.Caption = "&Show/Assign Section"
		Me.Command3.TabIndex = 3
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(208, 424)
		Me.Command2.Caption = "E&dit"
		Me.Command2.TabIndex = 2
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(120, 424)
		Me.Command1.Caption = "&Enroll New"
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' SSTab1
		'
		Me.SSTab1.Name = "SSTab1"
		Me.SSTab1.Size = New System.Drawing.Size(689, 409)
		Me.SSTab1.Location = New System.Drawing.Point(8, 8)
		Me.SSTab1.TabIndex = 0
		Me.SSTab1.Tab = 0
		Me.SSTab1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
		Me.SSTab1.MultiLine = True
		Me.SSTab1.ShowToolTips = True
		'
		' SSTab1_TabPage0
		'
		Me.SSTab1_TabPage0.Name = "SSTab1_TabPage0"
		Me.SSTab1_TabPage0.Text = "Student List"
		Me.SSTab1_TabPage0.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Label21
		'
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(41, 17)
		Me.Label21.Location = New System.Drawing.Point(608, -23)
		Me.Label21.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label21.Caption = "Option:"
		Me.Label21.TabIndex = 59
		Me.Label21.AutoSize = False
		Me.Label21.BackColor = FromOleColor6(CInt(&H8000000F))
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
		Me.ListView1.Location = New System.Drawing.Point(16, 25)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3, Me.ListView1_Column4, Me.ListView1_Column5, Me.ListView1_Column6})
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(657, 81)
		Me.Frame1.Location = New System.Drawing.Point(16, 289)
		Me.Frame1.TabIndex = 8
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text18
		'
		Me.Text18.Name = "Text18"
		Me.Text18.Size = New System.Drawing.Size(49, 20)
		Me.Text18.Location = New System.Drawing.Point(400, 16)
		Me.Text18.TabIndex = 13
		Me.Text18.Text = "0"
		'
		' Command8
		'
		Me.Command8.Name = "Command8"
		Me.Command8.Size = New System.Drawing.Size(113, 23)
		Me.Command8.Location = New System.Drawing.Point(528, 48)
		Me.Command8.Caption = "&View Option"
		Me.Command8.TabIndex = 15
		Me.Command8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(113, 23)
		Me.Command7.Location = New System.Drawing.Point(528, 16)
		Me.Command7.Caption = "&Advanced Search"
		Me.Command7.TabIndex = 14
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(121, 21)
		Me.Combo1.Location = New System.Drawing.Point(120, 48)
		Me.Combo1.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Combo1.TabIndex = 12
		Me.Combo1.Text = "Ascending Order"
		Me.Combo1.ItemDataValues = "Ascending\ Order\r0\rDescending\ Order\r0"
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(233, 20)
		Me.Text1.Location = New System.Drawing.Point(120, 16)
		Me.Text1.TabIndex = 11
		'
		' Label20
		'
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(65, 17)
		Me.Label20.Location = New System.Drawing.Point(456, 23)
		Me.Label20.Caption = "of"
		Me.Label20.TabIndex = 56
		Me.Label20.AutoSize = False
		Me.Label20.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label19
		'
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(33, 17)
		Me.Label19.Location = New System.Drawing.Point(368, 23)
		Me.Label19.Caption = "Goto:"
		Me.Label19.TabIndex = 55
		Me.Label19.AutoSize = False
		Me.Label19.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(97, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 48)
		Me.Label2.Caption = "Sort record in:"
		Me.Label2.TabIndex = 10
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 23)
		Me.Label1.Caption = "Enter text to search:"
		Me.Label1.TabIndex = 9
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9
		'
		Me.Command9.Name = "Command9"
		Me.Command9.Size = New System.Drawing.Size(20, 20)
		Me.Command9.Location = New System.Drawing.Point(648, -23)
		Me.Command9.Picture = CType(resources.GetObject("Command9.Picture"), System.Drawing.Image)
		Me.Command9.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9.TabIndex = 57
		Me.ToolTip1.SetToolTip(Me.Command9, "Drop Student")
		Me.Command9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command10
		'
		Me.Command10.Name = "Command10"
		Me.Command10.Size = New System.Drawing.Size(20, 20)
		Me.Command10.Location = New System.Drawing.Point(669, -23)
		Me.Command10.Picture = CType(resources.GetObject("Command10.Picture"), System.Drawing.Image)
		Me.Command10.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command10.TabIndex = 58
		Me.ToolTip1.SetToolTip(Me.Command10, "Undrop Student")
		Me.Command10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(657, 262)
		Me.ListView1_Control.Location = New System.Drawing.Point(16, 25)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(8388608))
		Me.ListView1_Control.TabIndex = 7
		Me.ListView1_Control.FullRowSelect = True
		Me.ListView1_Control.HideSelection = False
		Me.ListView1_Control.LabelWrap = True
		Me.ListView1_Control.LargeImageList = ImageList1.ImageList
		Me.ListView1_Control.SmallImageList = ImageList1.ImageList
		Me.ListView1_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.ListView1_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView1_Control.LabelEdit = False
		Me.ListView1_Control.MultiSelect = False
		Me.ListView1_Control.View = System.Windows.Forms.View.Details
		Me.ListView1_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ListView1_Control.BackgroundImageTiled = False
		'
		' SSTab1_TabPage1
		'
		Me.SSTab1_TabPage1.Name = "SSTab1_TabPage1"
		Me.SSTab1_TabPage1.Text = "Student Information"
		Me.SSTab1_TabPage1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(657, 353)
		Me.Frame2.Location = New System.Drawing.Point(16, 17)
		Me.Frame2.Caption = "General Information"
		Me.Frame2.TabIndex = 16
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text17
		'
		Me.Text17.Name = "Text17"
		Me.Text17.Size = New System.Drawing.Size(217, 23)
		Me.Text17.Location = New System.Drawing.Point(408, 328)
		Me.Text17.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text17.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text17.ReadOnly = True
		Me.Text17.TabIndex = 54
		'
		' Text16
		'
		Me.Text16.Name = "Text16"
		Me.Text16.Size = New System.Drawing.Size(97, 23)
		Me.Text16.Location = New System.Drawing.Point(128, 328)
		Me.Text16.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text16.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text16.ReadOnly = True
		Me.Text16.TabIndex = 53
		'
		' Text15
		'
		Me.Text15.Name = "Text15"
		Me.Text15.Size = New System.Drawing.Size(497, 23)
		Me.Text15.Location = New System.Drawing.Point(128, 304)
		Me.Text15.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text15.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text15.ReadOnly = True
		Me.Text15.TabIndex = 50
		'
		' Text14
		'
		Me.Text14.Name = "Text14"
		Me.Text14.Size = New System.Drawing.Size(369, 23)
		Me.Text14.Location = New System.Drawing.Point(128, 264)
		Me.Text14.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text14.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text14.ReadOnly = True
		Me.Text14.TabIndex = 48
		'
		' Picture5
		'
		Me.Picture5.Name = "Picture5"
		Me.Picture5.Size = New System.Drawing.Size(593, 2)
		Me.Picture5.Location = New System.Drawing.Point(32, 296)
		Me.Picture5.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture5.TabIndex = 45
		Me.Picture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture5.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture6
		'
		Me.Picture6.Name = "Picture6"
		Me.Picture6.Size = New System.Drawing.Size(593, 1)
		Me.Picture6.Location = New System.Drawing.Point(0, 1)
		Me.Picture6.BackColor = FromOleColor6(CInt(&H80000014))
		Me.Picture6.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture6.TabIndex = 46
		Me.Picture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture6.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text13
		'
		Me.Text13.Name = "Text13"
		Me.Text13.Size = New System.Drawing.Size(225, 23)
		Me.Text13.Location = New System.Drawing.Point(400, 232)
		Me.Text13.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text13.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text13.ReadOnly = True
		Me.Text13.TabIndex = 44
		'
		' Text12
		'
		Me.Text12.Name = "Text12"
		Me.Text12.Size = New System.Drawing.Size(185, 23)
		Me.Text12.Location = New System.Drawing.Point(128, 232)
		Me.Text12.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text12.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text12.ReadOnly = True
		Me.Text12.TabIndex = 42
		'
		' Text11
		'
		Me.Text11.Name = "Text11"
		Me.Text11.Size = New System.Drawing.Size(225, 23)
		Me.Text11.Location = New System.Drawing.Point(400, 200)
		Me.Text11.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text11.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text11.ReadOnly = True
		Me.Text11.TabIndex = 40
		'
		' Text10
		'
		Me.Text10.Name = "Text10"
		Me.Text10.Size = New System.Drawing.Size(185, 23)
		Me.Text10.Location = New System.Drawing.Point(128, 200)
		Me.Text10.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text10.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text10.ReadOnly = True
		Me.Text10.TabIndex = 38
		'
		' Text9
		'
		Me.Text9.Name = "Text9"
		Me.Text9.Size = New System.Drawing.Size(369, 23)
		Me.Text9.Location = New System.Drawing.Point(128, 168)
		Me.Text9.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text9.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text9.ReadOnly = True
		Me.Text9.TabIndex = 36
		'
		' Picture3
		'
		Me.Picture3.Name = "Picture3"
		Me.Picture3.Size = New System.Drawing.Size(593, 2)
		Me.Picture3.Location = New System.Drawing.Point(32, 160)
		Me.Picture3.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture3.TabIndex = 33
		Me.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture4
		'
		Me.Picture4.Name = "Picture4"
		Me.Picture4.Size = New System.Drawing.Size(593, 1)
		Me.Picture4.Location = New System.Drawing.Point(0, 1)
		Me.Picture4.BackColor = FromOleColor6(CInt(&H80000014))
		Me.Picture4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture4.TabIndex = 34
		Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text8
		'
		Me.Text8.Name = "Text8"
		Me.Text8.Size = New System.Drawing.Size(369, 23)
		Me.Text8.Location = New System.Drawing.Point(128, 128)
		Me.Text8.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text8.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text8.ReadOnly = True
		Me.Text8.TabIndex = 32
		'
		' Text7
		'
		Me.Text7.Name = "Text7"
		Me.Text7.Size = New System.Drawing.Size(113, 23)
		Me.Text7.Location = New System.Drawing.Point(512, 96)
		Me.Text7.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text7.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text7.ReadOnly = True
		Me.Text7.TabIndex = 30
		'
		' Text6
		'
		Me.Text6.Name = "Text6"
		Me.Text6.Size = New System.Drawing.Size(145, 23)
		Me.Text6.Location = New System.Drawing.Point(304, 96)
		Me.Text6.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text6.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text6.ReadOnly = True
		Me.Text6.TabIndex = 29
		'
		' Text5
		'
		Me.Text5.Name = "Text5"
		Me.Text5.Size = New System.Drawing.Size(81, 23)
		Me.Text5.Location = New System.Drawing.Point(128, 96)
		Me.Text5.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text5.ReadOnly = True
		Me.Text5.TabIndex = 28
		'
		' Text4
		'
		Me.Text4.Name = "Text4"
		Me.Text4.Size = New System.Drawing.Size(233, 23)
		Me.Text4.Location = New System.Drawing.Point(128, 56)
		Me.Text4.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text4.ReadOnly = True
		Me.Text4.TabIndex = 23
		'
		' Text3
		'
		Me.Text3.Name = "Text3"
		Me.Text3.Size = New System.Drawing.Size(233, 23)
		Me.Text3.Location = New System.Drawing.Point(392, 24)
		Me.Text3.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text3.ReadOnly = True
		Me.Text3.TabIndex = 22
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(177, 23)
		Me.Text2.Location = New System.Drawing.Point(128, 24)
		Me.Text2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text2.ReadOnly = True
		Me.Text2.TabIndex = 21
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(593, 2)
		Me.Picture1.Location = New System.Drawing.Point(32, 88)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 20
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(593, 1)
		Me.Picture2.Location = New System.Drawing.Point(0, 1)
		Me.Picture2.BackColor = FromOleColor6(CInt(&H80000014))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.TabIndex = 24
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Label18
		'
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(89, 17)
		Me.Label18.Location = New System.Drawing.Point(320, 328)
		Me.Label18.Caption = "Date Enrolled:"
		Me.Label18.TabIndex = 52
		Me.Label18.AutoSize = False
		Me.Label18.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label17
		'
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(73, 17)
		Me.Label17.Location = New System.Drawing.Point(32, 328)
		Me.Label17.Caption = "Status:"
		Me.Label17.TabIndex = 51
		Me.Label17.AutoSize = False
		Me.Label17.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label16
		'
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(97, 17)
		Me.Label16.Location = New System.Drawing.Point(32, 304)
		Me.Label16.Caption = "School Last Attend:"
		Me.Label16.TabIndex = 49
		Me.Label16.AutoSize = False
		Me.Label16.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label15
		'
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(89, 17)
		Me.Label15.Location = New System.Drawing.Point(32, 264)
		Me.Label15.Caption = "Parent Address:"
		Me.Label15.TabIndex = 47
		Me.Label15.AutoSize = False
		Me.Label15.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label14
		'
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(73, 17)
		Me.Label14.Location = New System.Drawing.Point(320, 232)
		Me.Label14.Caption = "Occupation:"
		Me.Label14.TabIndex = 43
		Me.Label14.AutoSize = False
		Me.Label14.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(89, 17)
		Me.Label13.Location = New System.Drawing.Point(32, 232)
		Me.Label13.Caption = "Mother's Name:"
		Me.Label13.TabIndex = 41
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(73, 17)
		Me.Label12.Location = New System.Drawing.Point(320, 200)
		Me.Label12.Caption = "Occupation:"
		Me.Label12.TabIndex = 39
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(73, 17)
		Me.Label11.Location = New System.Drawing.Point(32, 200)
		Me.Label11.Caption = "Father's Name:"
		Me.Label11.TabIndex = 37
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.Location = New System.Drawing.Point(32, 168)
		Me.Label10.Caption = "Address:"
		Me.Label10.TabIndex = 35
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 17)
		Me.Label9.Location = New System.Drawing.Point(32, 128)
		Me.Label9.Caption = "Place Of Birth:"
		Me.Label9.TabIndex = 31
		Me.Label9.AutoSize = False
		Me.Label9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(89, 17)
		Me.Label8.Location = New System.Drawing.Point(216, 96)
		Me.Label8.Caption = "Date Of Birth:"
		Me.Label8.TabIndex = 27
		Me.Label8.AutoSize = False
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(41, 17)
		Me.Label7.Location = New System.Drawing.Point(456, 96)
		Me.Label7.Caption = "Age:"
		Me.Label7.TabIndex = 26
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 96)
		Me.Label3.Caption = "Sex:"
		Me.Label3.TabIndex = 25
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(320, 24)
		Me.Label6.Caption = "Middle Name:"
		Me.Label6.TabIndex = 19
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 17)
		Me.Label5.Location = New System.Drawing.Point(32, 56)
		Me.Label5.Caption = "Last Name:"
		Me.Label5.TabIndex = 18
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 24)
		Me.Label4.Caption = "First Name:"
		Me.Label4.TabIndex = 17
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ListView1_Column1
		'
		Me.ListView1_Column1.Name = "ListView1_Column1"
		Me.ListView1_Column1.Text = "No."
		Me.ListView1_Column1.Width = 53
		'
		' ListView1_Column2
		'
		Me.ListView1_Column2.Name = "ListView1_Column2"
		Me.ListView1_Column2.Text = "id"
		Me.ListView1_Column2.Width = 0
		'
		' ListView1_Column3
		'
		Me.ListView1_Column3.Name = "ListView1_Column3"
		Me.ListView1_Column3.Text = "Last Name"
		Me.ListView1_Column3.Width = 180
		'
		' ListView1_Column4
		'
		Me.ListView1_Column4.Name = "ListView1_Column4"
		Me.ListView1_Column4.Text = "First Name"
		Me.ListView1_Column4.Width = 180
		'
		' ListView1_Column5
		'
		Me.ListView1_Column5.Name = "ListView1_Column5"
		Me.ListView1_Column5.Text = "Middle Name"
		Me.ListView1_Column5.Width = 180
		'
		' ListView1_Column6
		'
		Me.ListView1_Column6.Name = "ListView1_Column6"
		Me.ListView1_Column6.Text = "Sex"
		Me.ListView1_Column6.Width = 60
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Student Record"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(709, 455)

		Me.Controls.Add(Command6)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(SSTab1)
		Me.SSTab1.Controls.Add(SSTab1_TabPage0)
		Me.SSTab1_TabPage0.Controls.Add(Label21)
		Me.SSTab1_TabPage0.Controls.Add(ListView1)
		Me.SSTab1_TabPage0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Text18)
		Me.Frame1.Controls.Add(Command8)
		Me.Frame1.Controls.Add(Command7)
		Me.Frame1.Controls.Add(Combo1)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(Label20)
		Me.Frame1.Controls.Add(Label19)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.SSTab1_TabPage0.Controls.Add(Command9)
		Me.SSTab1_TabPage0.Controls.Add(Command10)
		Me.SSTab1_TabPage0.Controls.Add(ListView1_Control)
		Me.SSTab1.Controls.Add(SSTab1_TabPage1)
		Me.SSTab1_TabPage1.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(Text17)
		Me.Frame2.Controls.Add(Text16)
		Me.Frame2.Controls.Add(Text15)
		Me.Frame2.Controls.Add(Text14)
		Me.Frame2.Controls.Add(Picture5)
		Me.Picture5.Controls.Add(Picture6)
		Me.Frame2.Controls.Add(Text13)
		Me.Frame2.Controls.Add(Text12)
		Me.Frame2.Controls.Add(Text11)
		Me.Frame2.Controls.Add(Text10)
		Me.Frame2.Controls.Add(Text9)
		Me.Frame2.Controls.Add(Picture3)
		Me.Picture3.Controls.Add(Picture4)
		Me.Frame2.Controls.Add(Text8)
		Me.Frame2.Controls.Add(Text7)
		Me.Frame2.Controls.Add(Text6)
		Me.Frame2.Controls.Add(Text5)
		Me.Frame2.Controls.Add(Text4)
		Me.Frame2.Controls.Add(Text3)
		Me.Frame2.Controls.Add(Text2)
		Me.Frame2.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Frame2.Controls.Add(Label18)
		Me.Frame2.Controls.Add(Label17)
		Me.Frame2.Controls.Add(Label16)
		Me.Frame2.Controls.Add(Label15)
		Me.Frame2.Controls.Add(Label14)
		Me.Frame2.Controls.Add(Label13)
		Me.Frame2.Controls.Add(Label12)
		Me.Frame2.Controls.Add(Label11)
		Me.Frame2.Controls.Add(Label10)
		Me.Frame2.Controls.Add(Label9)
		Me.Frame2.Controls.Add(Label8)
		Me.Frame2.Controls.Add(Label7)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label6)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Label4)
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SSTab1.ResumeLayout(False)
		Me.SSTab1_TabPage0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.SSTab1_TabPage1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Picture5.ResumeLayout(False)
		Me.Picture3.ResumeLayout(False)
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
