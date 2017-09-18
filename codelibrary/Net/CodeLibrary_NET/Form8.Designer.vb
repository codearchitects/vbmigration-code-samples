<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form8
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
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form8))
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(65, 23)
		Me.Command1.Location = New System.Drawing.Point(32, 64)
		Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Caption = "&Cancel"
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(104, 64)
		Me.Command2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.Caption = "&Login"
		Me.Command2.TabIndex = 2
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command2
		Me.Command2.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(185, 19)
		Me.Text1.Location = New System.Drawing.Point(8, 32)
		Me.Text1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.ForeColor = FromOleColor6(CInt(&H00000080))
		Me.Text1.PasswordChar_ = "*"
		Me.Text1.TabIndex = 0
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(169, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Enter application password:"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 3
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form8
		'
		Me.Name = "Form8"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Password Required"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(202, 98)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
