<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form13
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
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column3 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form13))
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.Picture1.SuspendLayout()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(193, 2)
		Me.Picture1.Location = New System.Drawing.Point(8, 208)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 2
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
		Me.Picture2.TabIndex = 3
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(120, 216)
		Me.Command1.Caption = "&Select"
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(8, 24)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3})
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Caption = "List of level:"
		Me.Label1.TabIndex = 4
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(193, 182)
		Me.ListView1_Control.Location = New System.Drawing.Point(8, 24)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ListView1_Control.TabIndex = 0
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
		Me.ListView1_Column1.Width = 40
		'
		' ListView1_Column2
		'
		Me.ListView1_Column2.Name = "ListView1_Column2"
		Me.ListView1_Column2.Text = "yr_no"
		Me.ListView1_Column2.Width = 0
		'
		' ListView1_Column3
		'
		Me.ListView1_Column3.Name = "ListView1_Column3"
		Me.ListView1_Column3.Text = "Level"
		Me.ListView1_Column3.Width = 147
		'
		' Form13
		'
		Me.Name = "Form13"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Select Level"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(211, 248)

		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(Label1)
		Me.Controls.Add(ListView1_Control)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
