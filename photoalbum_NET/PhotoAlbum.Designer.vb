<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PhotoAlbum
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
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Check1 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents VScroll1 As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents File1 As CodeArchitects.VB6Library.VB6FileListBox
	Public WithEvents Drive1 As CodeArchitects.VB6Library.VB6DriveListBox
	Public WithEvents Dir1 As CodeArchitects.VB6Library.VB6DirListBox
	Public WithEvents Image2 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PhotoAlbum))
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Check1 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.VScroll1 = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Image()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.File1 = New CodeArchitects.VB6Library.VB6FileListBox()
		Me.Drive1 = New CodeArchitects.VB6Library.VB6DriveListBox()
		Me.Dir1 = New CodeArchitects.VB6Library.VB6DirListBox()
		Me.Image2 = New CodeArchitects.VB6Library.VB6Image()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Picture1.SuspendLayout()
		Me.Picture2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(49, 17)
		Me.Command2.Location = New System.Drawing.Point(419, 328)
		Me.Command2.Caption = "Fine"
		Me.Command2.TabIndex = 11
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(49, 17)
		Me.Command1.Location = New System.Drawing.Point(368, 328)
		Me.Command1.Caption = "About..."
		Me.Command1.TabIndex = 10
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check1
		'
		Me.Check1.Name = "Check1"
		Me.Check1.Size = New System.Drawing.Size(81, 13)
		Me.Check1.Location = New System.Drawing.Point(8, 332)
		Me.Check1.Caption = "Thumbnail"
		Me.Check1.TabIndex = 8
		Me.Check1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(315, 308)
		Me.Picture1.Location = New System.Drawing.Point(153, 8)
		Me.Picture1.AutoRedraw = True
		Me.Picture1.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Picture1.TabIndex = 1
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' VScroll1
		'
		Me.VScroll1.Name = "VScroll1"
		Me.VScroll1.Size = New System.Drawing.Size(12, 304)
		Me.VScroll1.Location = New System.Drawing.Point(299, 0)
		Me.VScroll1.LargeChange = 1100
		Me.VScroll1.SmallChange = 100
		Me.VScroll1.TabIndex = 9
		Me.VScroll1.Visible = False
		Me.VScroll1.Max = 32767
		Me.VScroll1.TabStop = True
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(299, 81)
		Me.Picture2.Location = New System.Drawing.Point(0, 0)
		Me.Picture2.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Picture2.AutoRedraw = True
		Me.Picture2.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Picture2.TabIndex = 7
		Me.Picture2.Visible = False
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 73)
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Stretch = True
		Me.Label3.Visible = False
		Me.Label3.Picture = CType(resources.GetObject("Label3.Picture"), System.Drawing.Image)
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(137, 316)
		Me.Frame1.Location = New System.Drawing.Point(8, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' File1
		'
		Me.File1.Name = "File1"
		Me.File1.Size = New System.Drawing.Size(121, 175)
		Me.File1.Location = New System.Drawing.Point(8, 128)
		Me.File1.Pattern = "*.gif;*.jpg;*.bmp;*.ico"
		Me.File1.TabIndex = 4
		'
		' Drive1
		'
		Me.Drive1.Name = "Drive1"
		Me.Drive1.Size = New System.Drawing.Size(121, 21)
		Me.Drive1.Location = New System.Drawing.Point(8, 16)
		Me.Drive1.TabIndex = 3
		'
		' Dir1
		'
		Me.Dir1.Name = "Dir1"
		Me.Dir1.Size = New System.Drawing.Size(121, 81)
		Me.Dir1.Location = New System.Drawing.Point(8, 40)
		Me.Dir1.TabIndex = 2
		'
		' Image2
		'
		Me.Image2.Name = "Image2"
		Me.Image2.Size = New System.Drawing.Size(244, 244)
		Me.Image2.Location = New System.Drawing.Point(304, 104)
		Me.Image2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Image2.Visible = False
		Me.Image2.Picture = CType(resources.GetObject("Image2.Picture"), System.Drawing.Image)
		Me.Image2.Stretch = False
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(26, 13)
		Me.Label2.Location = New System.Drawing.Point(264, 332)
		Me.Label2.AutoSize = True
		Me.Label2.Caption = "100%"
		Me.Label2.TabIndex = 6
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(106, 13)
		Me.Label1.Location = New System.Drawing.Point(152, 332)
		Me.Label1.AutoSize = True
		Me.Label1.Caption = "Proporzione immagine:"
		Me.Label1.TabIndex = 5
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(65, 41)
		Me.Image1.Location = New System.Drawing.Point(120, 304)
		Me.Image1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Image1.Visible = False
		Me.Image1.Stretch = False
		'
		' PhotoAlbum
		'
		Me.Name = "PhotoAlbum"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Photo Album"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(473, 352)

		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Check1)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(VScroll1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Picture2.Controls.Add(Label3)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(File1)
		Me.Frame1.Controls.Add(Drive1)
		Me.Frame1.Controls.Add(Dir1)
		Me.Controls.Add(Image2)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Image1)
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.Picture2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
