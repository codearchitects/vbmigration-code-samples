<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form6
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
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text17 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text5 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Text13 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Text11 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Text16 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents DTPicker1 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text3 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text4 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text6 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text7 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text8 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture3 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture4 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text9 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text10 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text12 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Picture5 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture6 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text14 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text15 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label14 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label15 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label16 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label17 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label18 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form6))
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text17 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text5 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Text13 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Text11 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Text16 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.DTPicker1 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text3 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text4 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text6 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text7 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text8 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture3 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture4 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text9 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text10 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text12 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Picture5 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture6 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text14 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text15 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label14 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label15 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label16 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label17 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label18 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2.SuspendLayout()
		Me.Picture1.SuspendLayout()
		Me.Picture3.SuspendLayout()
		Me.Picture5.SuspendLayout()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
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
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(89, 23)
		Me.Command1.Location = New System.Drawing.Point(408, 392)
		Me.Command1.Caption = "&Update"
		Me.Command1.TabIndex = 18
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(504, 392)
		Me.Command2.Caption = "C&lear"
		Me.Command2.TabIndex = 19
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(89, 23)
		Me.Command3.Location = New System.Drawing.Point(576, 392)
		Me.Command3.Caption = "&Cancel"
		Me.Command3.TabIndex = 20
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(657, 377)
		Me.Frame2.Location = New System.Drawing.Point(8, 8)
		Me.Frame2.Caption = "General Information"
		Me.Frame2.TabIndex = 21
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text17
		'
		Me.Text17.Name = "Text17"
		Me.Text17.Size = New System.Drawing.Size(57, 23)
		Me.Text17.Location = New System.Drawing.Point(384, 96)
		Me.Text17.MaxLength = 4
		Me.Text17.TabIndex = 6
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(25, 23)
		Me.Text1.Location = New System.Drawing.Point(344, 96)
		Me.Text1.MaxLength = 2
		Me.Text1.TabIndex = 5
		'
		' Text5
		'
		Me.Text5.Name = "Text5"
		Me.Text5.Size = New System.Drawing.Size(81, 21)
		Me.Text5.Location = New System.Drawing.Point(128, 96)
		Me.Text5.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Text5.TabIndex = 3
		Me.Text5.Text = "Male"
		Me.Text5.ItemDataValues = "Male\r0\rFemale\r0"
		'
		' Text13
		'
		Me.Text13.Name = "Text13"
		Me.Text13.Size = New System.Drawing.Size(217, 21)
		Me.Text13.Location = New System.Drawing.Point(408, 232)
		Me.Text13.TabIndex = 13
		Me.Text13.ItemDataValues = "N/A\r0"
		'
		' Text11
		'
		Me.Text11.Name = "Text11"
		Me.Text11.Size = New System.Drawing.Size(217, 21)
		Me.Text11.Location = New System.Drawing.Point(408, 200)
		Me.Text11.TabIndex = 11
		Me.Text11.ItemDataValues = "N/A\r0"
		'
		' Text16
		'
		Me.Text16.Name = "Text16"
		Me.Text16.Size = New System.Drawing.Size(81, 21)
		Me.Text16.Location = New System.Drawing.Point(128, 336)
		Me.Text16.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Text16.TabIndex = 16
		Me.Text16.Text = "New"
		Me.Text16.ItemDataValues = "New\r0\rOld\r0"
		'
		' DTPicker1
		'
		Me.DTPicker1.Name = "DTPicker1"
		Me.DTPicker1.Size = New System.Drawing.Size(153, 23)
		Me.DTPicker1.Location = New System.Drawing.Point(408, 336)
		Me.DTPicker1.TabIndex = 17
		Me.DTPicker1.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpShortDate
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(593, 2)
		Me.Picture1.Location = New System.Drawing.Point(32, 88)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 26
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
		Me.Picture2.TabIndex = 27
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(177, 23)
		Me.Text2.Location = New System.Drawing.Point(128, 24)
		Me.Text2.TabIndex = 0
		'
		' Text3
		'
		Me.Text3.Name = "Text3"
		Me.Text3.Size = New System.Drawing.Size(233, 23)
		Me.Text3.Location = New System.Drawing.Point(392, 24)
		Me.Text3.TabIndex = 1
		'
		' Text4
		'
		Me.Text4.Name = "Text4"
		Me.Text4.Size = New System.Drawing.Size(233, 23)
		Me.Text4.Location = New System.Drawing.Point(128, 56)
		Me.Text4.TabIndex = 2
		'
		' Text6
		'
		Me.Text6.Name = "Text6"
		Me.Text6.Size = New System.Drawing.Size(25, 23)
		Me.Text6.Location = New System.Drawing.Point(304, 96)
		Me.Text6.MaxLength = 2
		Me.Text6.TabIndex = 4
		'
		' Text7
		'
		Me.Text7.Name = "Text7"
		Me.Text7.Size = New System.Drawing.Size(113, 23)
		Me.Text7.Location = New System.Drawing.Point(512, 96)
		Me.Text7.MaxLength = 3
		Me.Text7.TabIndex = 7
		'
		' Text8
		'
		Me.Text8.Name = "Text8"
		Me.Text8.Size = New System.Drawing.Size(369, 23)
		Me.Text8.Location = New System.Drawing.Point(128, 128)
		Me.Text8.TabIndex = 8
		'
		' Picture3
		'
		Me.Picture3.Name = "Picture3"
		Me.Picture3.Size = New System.Drawing.Size(593, 2)
		Me.Picture3.Location = New System.Drawing.Point(32, 160)
		Me.Picture3.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture3.TabIndex = 24
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
		Me.Picture4.TabIndex = 25
		Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text9
		'
		Me.Text9.Name = "Text9"
		Me.Text9.Size = New System.Drawing.Size(369, 23)
		Me.Text9.Location = New System.Drawing.Point(128, 168)
		Me.Text9.TabIndex = 9
		'
		' Text10
		'
		Me.Text10.Name = "Text10"
		Me.Text10.Size = New System.Drawing.Size(185, 23)
		Me.Text10.Location = New System.Drawing.Point(128, 200)
		Me.Text10.TabIndex = 10
		'
		' Text12
		'
		Me.Text12.Name = "Text12"
		Me.Text12.Size = New System.Drawing.Size(185, 23)
		Me.Text12.Location = New System.Drawing.Point(128, 232)
		Me.Text12.TabIndex = 12
		'
		' Picture5
		'
		Me.Picture5.Name = "Picture5"
		Me.Picture5.Size = New System.Drawing.Size(593, 2)
		Me.Picture5.Location = New System.Drawing.Point(32, 296)
		Me.Picture5.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture5.TabIndex = 22
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
		Me.Picture6.TabIndex = 23
		Me.Picture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture6.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text14
		'
		Me.Text14.Name = "Text14"
		Me.Text14.Size = New System.Drawing.Size(369, 23)
		Me.Text14.Location = New System.Drawing.Point(128, 264)
		Me.Text14.TabIndex = 14
		'
		' Text15
		'
		Me.Text15.Name = "Text15"
		Me.Text15.Size = New System.Drawing.Size(497, 23)
		Me.Text15.Location = New System.Drawing.Point(128, 304)
		Me.Text15.TabIndex = 15
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(17, 25)
		Me.Label2.Location = New System.Drawing.Point(368, 96)
		Me.Label2.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = " /"
		Me.Label2.TabIndex = 45
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(17, 25)
		Me.Label1.Location = New System.Drawing.Point(328, 96)
		Me.Label1.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = " /"
		Me.Label1.TabIndex = 44
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 24)
		Me.Label4.Caption = "First Name:"
		Me.Label4.TabIndex = 43
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 17)
		Me.Label5.Location = New System.Drawing.Point(32, 56)
		Me.Label5.Caption = "Last Name:"
		Me.Label5.TabIndex = 42
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(320, 24)
		Me.Label6.Caption = "Middle Name:"
		Me.Label6.TabIndex = 41
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 96)
		Me.Label3.Caption = "Sex:"
		Me.Label3.TabIndex = 40
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(41, 17)
		Me.Label7.Location = New System.Drawing.Point(456, 96)
		Me.Label7.Caption = "Age:"
		Me.Label7.TabIndex = 39
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.Location = New System.Drawing.Point(232, 96)
		Me.Label8.Caption = "Date Of Birth:"
		Me.Label8.TabIndex = 38
		Me.Label8.AutoSize = False
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 17)
		Me.Label9.Location = New System.Drawing.Point(32, 128)
		Me.Label9.Caption = "Place Of Birth:"
		Me.Label9.TabIndex = 37
		Me.Label9.AutoSize = False
		Me.Label9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.Location = New System.Drawing.Point(32, 168)
		Me.Label10.Caption = "Address:"
		Me.Label10.TabIndex = 36
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(73, 17)
		Me.Label11.Location = New System.Drawing.Point(32, 200)
		Me.Label11.Caption = "Father's Name:"
		Me.Label11.TabIndex = 35
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(65, 17)
		Me.Label12.Location = New System.Drawing.Point(336, 200)
		Me.Label12.Caption = "Occupation:"
		Me.Label12.TabIndex = 34
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(89, 17)
		Me.Label13.Location = New System.Drawing.Point(32, 232)
		Me.Label13.Caption = "Mother's Name:"
		Me.Label13.TabIndex = 33
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label14
		'
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(65, 17)
		Me.Label14.Location = New System.Drawing.Point(336, 232)
		Me.Label14.Caption = "Occupation:"
		Me.Label14.TabIndex = 32
		Me.Label14.AutoSize = False
		Me.Label14.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label15
		'
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(89, 17)
		Me.Label15.Location = New System.Drawing.Point(32, 264)
		Me.Label15.Caption = "Parent Address:"
		Me.Label15.TabIndex = 31
		Me.Label15.AutoSize = False
		Me.Label15.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label16
		'
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(97, 17)
		Me.Label16.Location = New System.Drawing.Point(32, 304)
		Me.Label16.Caption = "School Last Attend:"
		Me.Label16.TabIndex = 30
		Me.Label16.AutoSize = False
		Me.Label16.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label17
		'
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(73, 17)
		Me.Label17.Location = New System.Drawing.Point(32, 336)
		Me.Label17.Caption = "Status:"
		Me.Label17.TabIndex = 29
		Me.Label17.AutoSize = False
		Me.Label17.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label18
		'
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(73, 17)
		Me.Label18.Location = New System.Drawing.Point(336, 336)
		Me.Label18.Caption = "Date Enrolled:"
		Me.Label18.TabIndex = 28
		Me.Label18.AutoSize = False
		Me.Label18.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form6
		'
		Me.Name = "Form6"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(675, 424)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(Text17)
		Me.Frame2.Controls.Add(Text1)
		Me.Frame2.Controls.Add(Text5)
		Me.Frame2.Controls.Add(Text13)
		Me.Frame2.Controls.Add(Text11)
		Me.Frame2.Controls.Add(Text16)
		Me.Frame2.Controls.Add(DTPicker1)
		Me.Frame2.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Frame2.Controls.Add(Text2)
		Me.Frame2.Controls.Add(Text3)
		Me.Frame2.Controls.Add(Text4)
		Me.Frame2.Controls.Add(Text6)
		Me.Frame2.Controls.Add(Text7)
		Me.Frame2.Controls.Add(Text8)
		Me.Frame2.Controls.Add(Picture3)
		Me.Picture3.Controls.Add(Picture4)
		Me.Frame2.Controls.Add(Text9)
		Me.Frame2.Controls.Add(Text10)
		Me.Frame2.Controls.Add(Text12)
		Me.Frame2.Controls.Add(Picture5)
		Me.Picture5.Controls.Add(Picture6)
		Me.Frame2.Controls.Add(Text14)
		Me.Frame2.Controls.Add(Text15)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Label6)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label7)
		Me.Frame2.Controls.Add(Label8)
		Me.Frame2.Controls.Add(Label9)
		Me.Frame2.Controls.Add(Label10)
		Me.Frame2.Controls.Add(Label11)
		Me.Frame2.Controls.Add(Label12)
		Me.Frame2.Controls.Add(Label13)
		Me.Frame2.Controls.Add(Label14)
		Me.Frame2.Controls.Add(Label15)
		Me.Frame2.Controls.Add(Label16)
		Me.Frame2.Controls.Add(Label17)
		Me.Frame2.Controls.Add(Label18)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Picture1.ResumeLayout(False)
		Me.Picture3.ResumeLayout(False)
		Me.Picture5.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
