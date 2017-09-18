<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form25
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
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Option2 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form25))
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Option2 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(153, 105)
		Me.Frame2.Location = New System.Drawing.Point(8, 88)
		Me.Frame2.TabIndex = 5
		Me.Frame2.Visible = False
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(81, 19)
		Me.Text1.Location = New System.Drawing.Point(8, 72)
		Me.Text1.MaxLength = 4
		Me.Text1.TabIndex = 7
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(137, 21)
		Me.Combo1.Location = New System.Drawing.Point(8, 32)
		Me.Combo1.TabIndex = 6
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.Caption = "Enter Year "
		Me.Label2.TabIndex = 9
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.Caption = "Select Month "
		Me.Label1.TabIndex = 8
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(153, 73)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Caption = "Option"
		Me.Frame1.TabIndex = 4
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option2
		'
		Me.Option2.Name = "Option2"
		Me.Option2.Size = New System.Drawing.Size(137, 17)
		Me.Option2.Location = New System.Drawing.Point(8, 40)
		Me.Option2.Caption = "View/Print log-in details"
		Me.Option2.TabIndex = 1
		Me.Option2.TabStop = True
		Me.Option2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Option1
		'
		Me.Option1.Name = "Option1"
		Me.Option1.Size = New System.Drawing.Size(129, 17)
		Me.Option1.Location = New System.Drawing.Point(8, 24)
		Me.Option1.Caption = "Clear log-in details"
		Me.Option1.TabIndex = 0
		Me.Option1.TabStop = True
		Me.Option1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(96, 200)
		Me.Command2.Caption = "&OK"
		Me.Command2.TabIndex = 2
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command2
		Me.Command2.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(65, 23)
		Me.Command1.Location = New System.Drawing.Point(24, 200)
		Me.Command1.Caption = "&Cancel"
		Me.Command1.TabIndex = 3
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form25
		'
		Me.Name = "Form25"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Log-in Info"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(171, 233)

		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(Text1)
		Me.Frame2.Controls.Add(Combo1)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Option2)
		Me.Frame1.Controls.Add(Option1)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
