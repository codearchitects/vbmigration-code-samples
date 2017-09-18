<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form7
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
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Combo2 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Option1 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option2 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form7))
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Combo2 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Option1 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option2 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(216, 240)
		Me.Command2.Caption = "&Cancel"
		Me.Command2.TabIndex = 6
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(128, 240)
		Me.Command1.Caption = "&Select"
		Me.Command1.TabIndex = 5
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(273, 225)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Caption = "Search Option"
		Me.Frame1.TabIndex = 7
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(241, 21)
		Me.Text1.Location = New System.Drawing.Point(16, 184)
		Me.Text1.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Text1.ForeColor = FromOleColor6(CInt(&H80000012))
		Me.Text1.ReadOnly = True
		Me.Text1.TabIndex = 4
		Me.Text1.Visible = False
		'
		' Combo2
		'
		Me.Combo2.Name = "Combo2"
		Me.Combo2.Size = New System.Drawing.Size(105, 21)
		Me.Combo2.Location = New System.Drawing.Point(16, 144)
		Me.Combo2.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Combo2.ForeColor = FromOleColor6(CInt(&H80000012))
		Me.Combo2.TabIndex = 3
		Me.Combo2.ItemDataValues = "=\r0\r>\r0\r<\r0\r>=\r0\r<=\r0"
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(241, 21)
		Me.Combo1.Location = New System.Drawing.Point(16, 104)
		Me.Combo1.BackColor = FromOleColor6(CInt(&H00E6FFFF))
		Me.Combo1.ForeColor = FromOleColor6(CInt(&H80000012))
		Me.Combo1.TabIndex = 2
		'
		' Option1
		'
		Me.Option1.Name = "Option1"
		Me.Option1.Size = New System.Drawing.Size(209, 25)
		Me.Option1.Location = New System.Drawing.Point(16, 32)
		Me.Option1.Caption = "Use Quick Search  ( Recommended )"
		Me.Option1.TabIndex = 0
		Me.Option1.TabStop = True
		Me.Option1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option2
		'
		Me.Option2.Name = "Option2"
		Me.Option2.Size = New System.Drawing.Size(193, 25)
		Me.Option2.Location = New System.Drawing.Point(16, 56)
		Me.Option2.Caption = "Use Custom Search"
		Me.Option2.TabIndex = 1
		Me.Option2.TabStop = True
		Me.Option2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(32, 32)
		Me.Image1.Location = New System.Drawing.Point(224, 24)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(153, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 168)
		Me.Label3.Caption = "Search Text"
		Me.Label3.TabIndex = 10
		Me.Label3.Visible = False
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(153, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 128)
		Me.Label2.Caption = "Operator"
		Me.Label2.TabIndex = 9
		Me.Label2.Visible = False
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 88)
		Me.Label1.Caption = "Look In"
		Me.Label1.TabIndex = 8
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form7
		'
		Me.Name = "Form7"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Advanced Search For Student"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(290, 274)

		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(Combo2)
		Me.Frame1.Controls.Add(Combo1)
		Me.Frame1.Controls.Add(Option1)
		Me.Frame1.Controls.Add(Option2)
		Me.Frame1.Controls.Add(Image1)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
