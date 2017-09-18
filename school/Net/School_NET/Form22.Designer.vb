<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form22
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
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form22))
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(329, 2)
		Me.Picture1.Location = New System.Drawing.Point(8, 72)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 6
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
		Me.Picture2.TabIndex = 7
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(272, 80)
		Me.Command2.Caption = "&Cancel"
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(113, 23)
		Me.Command1.Location = New System.Drawing.Point(152, 80)
		Me.Command1.Caption = "&Save Changes"
		Me.Command1.TabIndex = 2
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(249, 23)
		Me.Text2.Location = New System.Drawing.Point(88, 40)
		Me.Text2.TabIndex = 1
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(249, 23)
		Me.Text1.Location = New System.Drawing.Point(88, 8)
		Me.Text1.TabIndex = 0
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 40)
		Me.Label1.Caption = "Address:"
		Me.Label1.TabIndex = 5
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 8)
		Me.Label4.Caption = "School Name:"
		Me.Label4.TabIndex = 4
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form22
		'
		Me.Name = "Form22"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "School Information"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(345, 112)

		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label4)
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
