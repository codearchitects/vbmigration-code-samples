<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form17
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
	Public WithEvents DataCombo1 As CodeArchitects.VB6Library.VB6DataCombo
	Public WithEvents Text5 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
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
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form17))
		Me.DataCombo1 = New CodeArchitects.VB6Library.VB6DataCombo()
		Me.Text5 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column4 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column5 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column6 = New System.Windows.Forms.ColumnHeader()
		Me.Picture1.SuspendLayout()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' DataCombo1
		'
		Me.DataCombo1.Name = "DataCombo1"
		Me.DataCombo1.Size = New System.Drawing.Size(121, 21)
		Me.DataCombo1.Location = New System.Drawing.Point(312, 8)
		Me.DataCombo1.TabIndex = 1
		Me.DataCombo1.BackColor = FromOleColor6(CInt(15138815))
		Me.DataCombo1.Text = ""
		'
		' Text5
		'
		Me.Text5.Name = "Text5"
		Me.Text5.Size = New System.Drawing.Size(81, 21)
		Me.Text5.Location = New System.Drawing.Point(136, 8)
		Me.Text5.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Text5.TabIndex = 0
		Me.Text5.Text = "No"
		Me.Text5.ItemDataValues = "No\r0\rYes\r0"
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(89, 23)
		Me.Command7.Location = New System.Drawing.Point(576, 304)
		Me.Command7.Caption = "&Close"
		Me.Command7.TabIndex = 9
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(105, 23)
		Me.Command5.Location = New System.Drawing.Point(464, 304)
		Me.Command5.Caption = "&Load Record"
		Me.Command5.TabIndex = 8
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4
		'
		Me.Command4.Name = "Command4"
		Me.Command4.Size = New System.Drawing.Size(145, 23)
		Me.Command4.Location = New System.Drawing.Point(264, 304)
		Me.Command4.Caption = "Print All &Student in the List"
		Me.Command4.TabIndex = 7
		Me.Command4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(121, 23)
		Me.Command2.Location = New System.Drawing.Point(136, 304)
		Me.Command2.Caption = "Print &Individual Record"
		Me.Command2.TabIndex = 6
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(657, 2)
		Me.Picture1.Location = New System.Drawing.Point(8, 296)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 12
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(657, 1)
		Me.Picture2.Location = New System.Drawing.Point(0, 1)
		Me.Picture2.BackColor = FromOleColor6(CInt(&H80000014))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.TabIndex = 13
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(20, 20)
		Me.Command3.Location = New System.Drawing.Point(648, 8)
		Me.Command3.Picture = CType(resources.GetObject("Command3.Picture"), System.Drawing.Image)
		Me.Command3.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command3.TabIndex = 3
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(153, 20)
		Me.Text2.Location = New System.Drawing.Point(496, 8)
		Me.Text2.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Text2.ReadOnly = True
		Me.Text2.TabIndex = 2
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(121, 23)
		Me.Command1.Location = New System.Drawing.Point(8, 304)
		Me.Command1.Caption = "Print &Registration Slip"
		Me.Command1.TabIndex = 5
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(8, 56)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3, Me.ListView1_Column4, Me.ListView1_Column5, Me.ListView1_Column6})
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
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(145, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 8)
		Me.Label4.Caption = "Include Dropped Student:"
		Me.Label4.TabIndex = 15
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(240, 8)
		Me.Label3.Caption = "School Year: "
		Me.Label3.TabIndex = 14
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(49, 17)
		Me.Label2.Location = New System.Drawing.Point(448, 8)
		Me.Label2.Caption = "Section:"
		Me.Label2.TabIndex = 11
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(121, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 40)
		Me.Label1.Caption = "List of Students:"
		Me.Label1.TabIndex = 10
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(657, 238)
		Me.ListView1_Control.Location = New System.Drawing.Point(8, 56)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(8388608))
		Me.ListView1_Control.TabIndex = 4
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
		' Form17
		'
		Me.Name = "Form17"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Print Option For Student Record"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(673, 336)

		Me.Controls.Add(DataCombo1)
		Me.Controls.Add(Text5)
		Me.Controls.Add(Command7)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(ListView1_Control)
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
