<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form5
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
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form5))
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(177, 23)
		Me.Text1.Location = New System.Drawing.Point(88, 8)
		Me.Text1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Text1.TabIndex = 2
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(81, 23)
		Me.Command3.Location = New System.Drawing.Point(112, 48)
		Me.Command3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.Caption = "&Update"
		Me.Command3.TabIndex = 1
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command3
		Me.Command3.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(65, 23)
		Me.Command1.Location = New System.Drawing.Point(200, 48)
		Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Caption = "&Cancel"
		Me.Command1.TabIndex = 0
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
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
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 8)
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Caption = "Langguage:"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label4.TabIndex = 3
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form5
		'
		Me.Name = "Form5"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(273, 83)

		Me.Controls.Add(Text1)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Label4)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
