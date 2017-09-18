<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form3
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
	Public WithEvents Text4 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text3 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
		Me.Text4 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text3 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Text4
		'
		Me.Text4.Name = "Text4"
		Me.Text4.Size = New System.Drawing.Size(161, 20)
		Me.Text4.Location = New System.Drawing.Point(80, 56)
		Me.Text4.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text4.ReadOnly = True
		Me.Text4.TabIndex = 3
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(20, 20)
		Me.Command3.Location = New System.Drawing.Point(232, 32)
		Me.Command3.Picture = CType(resources.GetObject("Command3.Picture"), System.Drawing.Image)
		Me.Command3.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command3.TabIndex = 2
		Me.Command3.Visible = False
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(81, 23)
		Me.Command2.Location = New System.Drawing.Point(88, 112)
		Me.Command2.Caption = "&Edit"
		Me.Command2.TabIndex = 5
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command2
		Me.Command2.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(176, 112)
		Me.Command1.Caption = "&OK"
		Me.Command1.TabIndex = 6
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(249, 2)
		Me.Picture1.Location = New System.Drawing.Point(8, 104)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 10
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
		Me.Picture2.TabIndex = 11
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Text3
		'
		Me.Text3.Name = "Text3"
		Me.Text3.Size = New System.Drawing.Size(121, 20)
		Me.Text3.Location = New System.Drawing.Point(80, 80)
		Me.Text3.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text3.ReadOnly = True
		Me.Text3.TabIndex = 4
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(153, 20)
		Me.Text2.Location = New System.Drawing.Point(80, 32)
		Me.Text2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text2.ReadOnly = True
		Me.Text2.TabIndex = 1
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(57, 20)
		Me.Text1.Location = New System.Drawing.Point(80, 8)
		Me.Text1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.Text1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Text1.ReadOnly = True
		Me.Text1.MaxLength = 3
		Me.Text1.TabIndex = 0
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 56)
		Me.Label4.Caption = "Level:"
		Me.Label4.TabIndex = 12
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 80)
		Me.Label3.Caption = "School Year:"
		Me.Label3.TabIndex = 9
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(41, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.Caption = "Section:"
		Me.Label2.TabIndex = 8
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Caption = "Gen Ave:"
		Me.Label1.TabIndex = 7
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form3
		'
		Me.Name = "Form3"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Student Section"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(266, 145)

		Me.Controls.Add(Text4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Controls.Add(Text3)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
