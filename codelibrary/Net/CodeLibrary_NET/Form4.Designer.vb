<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form4
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
	Public WithEvents Command11 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command10 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command8 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command11 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command10 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command8 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(89, 23)
		Me.Command1.Location = New System.Drawing.Point(352, 8)
		Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Caption = "Se&lect"
		Me.Command1.TabIndex = 6
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command11
		'
		Me.Command11.Name = "Command11"
		Me.Command11.Size = New System.Drawing.Size(89, 23)
		Me.Command11.Location = New System.Drawing.Point(352, 264)
		Me.Command11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command11.Caption = "&Cancel"
		Me.Command11.TabIndex = 5
		Me.Command11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command10
		'
		Me.Command10.Name = "Command10"
		Me.Command10.Size = New System.Drawing.Size(89, 23)
		Me.Command10.Location = New System.Drawing.Point(352, 119)
		Me.Command10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command10.Caption = "&Delete"
		Me.Command10.TabIndex = 4
		Me.Command10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command8
		'
		Me.Command8.Name = "Command8"
		Me.Command8.Size = New System.Drawing.Size(89, 23)
		Me.Command8.Location = New System.Drawing.Point(352, 91)
		Me.Command8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command8.Caption = "&Search"
		Me.Command8.TabIndex = 3
		Me.Command8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(89, 23)
		Me.Command7.Location = New System.Drawing.Point(352, 63)
		Me.Command7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command7.Caption = "&Edit"
		Me.Command7.TabIndex = 2
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(89, 23)
		Me.Command6.Location = New System.Drawing.Point(352, 35)
		Me.Command6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command6.Caption = "&Add"
		Me.Command6.TabIndex = 1
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
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
		Me.ListView1.Location = New System.Drawing.Point(8, 8)
		Me.ListView1.Icons = ImageList1
		Me.ListView1.SmallIcons = ImageList1
		Me.ListView1.Size = New System.Drawing.Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1})
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(337, 279)
		Me.ListView1_Control.Location = New System.Drawing.Point(8, 8)
		Me.ListView1_Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(12582912))
		Me.ListView1_Control.TabIndex = 0
		Me.ListView1_Control.FullRowSelect = True
		Me.ListView1_Control.HideSelection = False
		Me.ListView1_Control.LabelWrap = True
		Me.ListView1_Control.LargeImageList = ImageList1.ImageList
		Me.ListView1_Control.SmallImageList = ImageList1.ImageList
		Me.ListView1_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.ListView1_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView1_Control.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.ListView1_Control.LabelEdit = False
		Me.ListView1_Control.MultiSelect = False
		Me.ListView1_Control.View = System.Windows.Forms.View.Details
		Me.ListView1_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ListView1_Control.BackgroundImageTiled = False
		'
		' ListView1_Column1
		'
		Me.ListView1_Column1.Name = "ListView1_Column1"
		Me.ListView1_Column1.Text = "Lang"
		Me.ListView1_Column1.Width = 307
		'
		' Form4
		'
		Me.Name = "Form4"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Select Langguages"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(451, 297)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Command11)
		Me.Controls.Add(Command10)
		Me.Controls.Add(Command8)
		Me.Controls.Add(Command7)
		Me.Controls.Add(Command6)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(ListView1_Control)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
