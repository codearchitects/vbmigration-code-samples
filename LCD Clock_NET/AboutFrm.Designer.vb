<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class AboutFrm
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
	Public WithEvents Check1 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AboutFrm))
		Me.Check1 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Check1
		'
		Me.Check1.Name = "Check1"
		Me.Check1.Size = New System.Drawing.Size(13, 12)
		Me.Check1.Location = New System.Drawing.Point(113, 282)
		Me.Check1.Caption = "Check1"
		Me.Check1.TabIndex = 2
		Me.Check1.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.Check1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(77, 22)
		Me.Command1.Location = New System.Drawing.Point(137, 310)
		Me.Command1.Caption = "Close"
		Me.Command1.TabIndex = 0
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(345, 16)
		Me.Label4.Location = New System.Drawing.Point(4, 233)
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label4.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label4.Caption = "Created by Michael Margold"
		Me.Label4.TabIndex = 5
		Me.Label4.AutoSize = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(345, 24)
		Me.Label3.Location = New System.Drawing.Point(4, 200)
		Me.Label3.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label3.Caption = "LCD Clock v1.14"
		Me.Label3.ForeColor = FromOleColor6(CInt(&H000000FF))
		Me.Label3.TabIndex = 4
		Me.Label3.AutoSize = False
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(345, 16)
		Me.Label2.Location = New System.Drawing.Point(4, 281)
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label2.Caption = "    Show Help On Start Up"
		Me.Label2.TabIndex = 3
		Me.Label2.AutoSize = False
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(345, 15)
		Me.Label1.Location = New System.Drawing.Point(4, 256)
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label1.Caption = "http://www.soft-collection.com"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.Label1.MouseIcon = CType(resources.GetObject("Label1.MouseIcon"), System.Drawing.Bitmap)
		Me.Label1.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(352, 193)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' AboutFrm
		'
		Me.Name = "AboutFrm"
		Me.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "About"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(352, 345)

		Me.Controls.Add(Check1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
