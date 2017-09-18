<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form26
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
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents SSTab1 As CodeArchitects.VB6Library.VB6SSTab
	Public WithEvents SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column3 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column4 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form26))
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SSTab1 = New CodeArchitects.VB6Library.VB6SSTab()
		Me.SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column4 = New System.Windows.Forms.ColumnHeader()
		Me.SSTab1.SuspendLayout()
		Me.SSTab1_TabPage0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(96, 352)
		Me.Command1.Caption = "&Add"
		Me.Command1.TabIndex = 2
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(81, 23)
		Me.Command2.Location = New System.Drawing.Point(184, 352)
		Me.Command2.Caption = "E&dit"
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4
		'
		Me.Command4.Name = "Command4"
		Me.Command4.Size = New System.Drawing.Size(73, 23)
		Me.Command4.Location = New System.Drawing.Point(272, 352)
		Me.Command4.Caption = "De&lete"
		Me.Command4.TabIndex = 4
		Me.Command4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(81, 23)
		Me.Command5.Location = New System.Drawing.Point(352, 352)
		Me.Command5.Caption = "&Reload"
		Me.Command5.TabIndex = 5
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(81, 23)
		Me.Command6.Location = New System.Drawing.Point(440, 352)
		Me.Command6.Caption = "&Close"
		Me.Command6.TabIndex = 6
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' SSTab1
		'
		Me.SSTab1.Name = "SSTab1"
		Me.SSTab1.Size = New System.Drawing.Size(513, 337)
		Me.SSTab1.Location = New System.Drawing.Point(8, 8)
		Me.SSTab1.TabIndex = 7
		Me.SSTab1.Tab = 0
		Me.SSTab1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
		Me.SSTab1.MultiLine = True
		Me.SSTab1.ShowToolTips = True
		'
		' SSTab1_TabPage0
		'
		Me.SSTab1_TabPage0.Name = "SSTab1_TabPage0"
		Me.SSTab1_TabPage0.Text = "General "
		Me.SSTab1_TabPage0.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(16, 20)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3, Me.ListView1_Column4})
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(481, 49)
		Me.Frame1.Location = New System.Drawing.Point(16, 252)
		Me.Frame1.TabIndex = 8
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(353, 20)
		Me.Text1.Location = New System.Drawing.Point(112, 16)
		Me.Text1.TabIndex = 1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 23)
		Me.Label1.Caption = "Enter text to search:"
		Me.Label1.TabIndex = 9
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(481, 230)
		Me.ListView1_Control.Location = New System.Drawing.Point(16, 20)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(8388608))
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
		' ListView1_Column1
		'
		Me.ListView1_Column1.Name = "ListView1_Column1"
		Me.ListView1_Column1.Text = "No."
		Me.ListView1_Column1.Width = 40
		'
		' ListView1_Column2
		'
		Me.ListView1_Column2.Name = "ListView1_Column2"
		Me.ListView1_Column2.Text = "User Name"
		Me.ListView1_Column2.Width = 301
		'
		' ListView1_Column3
		'
		Me.ListView1_Column3.Name = "ListView1_Column3"
		Me.ListView1_Column3.Text = "Type"
		Me.ListView1_Column3.Width = 192
		'
		' ListView1_Column4
		'
		Me.ListView1_Column4.Name = "ListView1_Column4"
		Me.ListView1_Column4.Text = "Password"
		Me.ListView1_Column4.Width = 129
		'
		' Form26
		'
		Me.Name = "Form26"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "List of Users"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(535, 387)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command6)
		Me.Controls.Add(SSTab1)
		Me.SSTab1.Controls.Add(SSTab1_TabPage0)
		Me.SSTab1_TabPage0.Controls.Add(ListView1)
		Me.SSTab1_TabPage0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(Label1)
		Me.SSTab1_TabPage0.Controls.Add(ListView1_Control)
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SSTab1.ResumeLayout(False)
		Me.SSTab1_TabPage0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
