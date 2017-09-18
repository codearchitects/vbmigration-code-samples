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
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Combo2 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Check5 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Check4 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Check3 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Check2 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Check1 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form8))
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Combo2 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Check5 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Check4 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Check3 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Check2 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Check1 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1.SuspendLayout()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(81, 23)
		Me.Command3.Location = New System.Drawing.Point(8, 272)
		Me.Command3.Caption = "&Reset"
		Me.Command3.TabIndex = 7
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(273, 257)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Caption = "Search Option"
		Me.Frame1.TabIndex = 10
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Combo2
		'
		Me.Combo2.Name = "Combo2"
		Me.Combo2.Size = New System.Drawing.Size(241, 21)
		Me.Combo2.Location = New System.Drawing.Point(16, 224)
		Me.Combo2.TabIndex = 6
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(241, 21)
		Me.Combo1.Location = New System.Drawing.Point(16, 184)
		Me.Combo1.TabIndex = 5
		'
		' Check5
		'
		Me.Check5.Name = "Check5"
		Me.Check5.Size = New System.Drawing.Size(185, 25)
		Me.Check5.Location = New System.Drawing.Point(16, 136)
		Me.Check5.Caption = "Show Old Student"
		Me.Check5.TabIndex = 4
		Me.Check5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check4
		'
		Me.Check4.Name = "Check4"
		Me.Check4.Size = New System.Drawing.Size(185, 25)
		Me.Check4.Location = New System.Drawing.Point(16, 112)
		Me.Check4.Caption = "Show New Student"
		Me.Check4.TabIndex = 3
		Me.Check4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check3
		'
		Me.Check3.Name = "Check3"
		Me.Check3.Size = New System.Drawing.Size(185, 25)
		Me.Check3.Location = New System.Drawing.Point(16, 56)
		Me.Check3.Caption = "Show Female Student"
		Me.Check3.TabIndex = 1
		Me.Check3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check2
		'
		Me.Check2.Name = "Check2"
		Me.Check2.Size = New System.Drawing.Size(185, 25)
		Me.Check2.Location = New System.Drawing.Point(16, 32)
		Me.Check2.Caption = "Show Male Student"
		Me.Check2.TabIndex = 0
		Me.Check2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check1
		'
		Me.Check1.Name = "Check1"
		Me.Check1.Size = New System.Drawing.Size(185, 25)
		Me.Check1.Location = New System.Drawing.Point(16, 88)
		Me.Check1.Caption = "Show Drop Student"
		Me.Check1.TabIndex = 2
		Me.Check1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 208)
		Me.Label1.Caption = "Section"
		Me.Label1.TabIndex = 12
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(153, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 168)
		Me.Label3.Caption = "Level"
		Me.Label3.TabIndex = 11
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(32, 32)
		Me.Image1.Location = New System.Drawing.Point(224, 24)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(81, 23)
		Me.Command1.Location = New System.Drawing.Point(128, 272)
		Me.Command1.Caption = "&View"
		Me.Command1.TabIndex = 8
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(65, 23)
		Me.Command2.Location = New System.Drawing.Point(216, 272)
		Me.Command2.Caption = "&Cancel"
		Me.Command2.TabIndex = 9
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Form8
		'
		Me.Name = "Form8"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "View Option"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(290, 302)

		Me.Controls.Add(Command3)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Combo2)
		Me.Frame1.Controls.Add(Combo1)
		Me.Frame1.Controls.Add(Check5)
		Me.Frame1.Controls.Add(Check4)
		Me.Frame1.Controls.Add(Check3)
		Me.Frame1.Controls.Add(Check2)
		Me.Frame1.Controls.Add(Check1)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Image1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Command2)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
