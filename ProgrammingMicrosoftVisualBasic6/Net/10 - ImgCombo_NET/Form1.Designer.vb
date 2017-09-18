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
	Public WithEvents picInfo As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ImageCombo1 As CodeArchitects.VB6Library.VB6ImageCombo
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.picInfo = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ImageCombo1 = New CodeArchitects.VB6Library.VB6ImageCombo()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' picInfo
		'
		Me.picInfo.Name = "picInfo"
		Me.picInfo.Size = New System.Drawing.Size(209, 177)
		Me.picInfo.Location = New System.Drawing.Point(16, 88)
		Me.picInfo.TabIndex = 2
		Me.picInfo.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.Tag = "Key1=MyComputer;Key2=FloppyDrive;Key3=HardDrive;Key4=CDDrive;Key5=CloseFolder;Key6=OpenFolder;"
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' ImageCombo1
		'
		Me.ImageCombo1.Name = "ImageCombo1"
		Me.ImageCombo1.Size = New System.Drawing.Size(209, 25)
		Me.ImageCombo1.Location = New System.Drawing.Point(16, 40)
		Me.ImageCombo1.TabIndex = 0
		Me.ImageCombo1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ImageCombo1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageCombo1.Text = "ImageCombo1"
		Me.ImageCombo1.ImageList = ImageList1
		Me.ImageCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(193, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.Caption = "Select the drive"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ImageCombo Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(305, 285)

		Me.Controls.Add(picInfo)
		Me.Controls.Add(ImageCombo1)
		Me.Controls.Add(Label1)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
