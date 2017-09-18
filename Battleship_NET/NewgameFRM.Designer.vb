<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class NewgameFRM
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
	Public WithEvents noCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents yesCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewgameFRM))
		Me.noCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.yesCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' noCMD
		'
		Me.noCMD.Name = "noCMD"
		Me.noCMD.Size = New System.Drawing.Size(73, 25)
		Me.noCMD.Location = New System.Drawing.Point(80, 16)
		Me.noCMD.Caption = "&No"
		Me.noCMD.TabIndex = 2
		Me.noCMD.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(161, 49)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Frame1.Caption = "Play Again?"
		Me.Frame1.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Frame1.TabIndex = 0
		'
		' yesCMD
		'
		Me.yesCMD.Name = "yesCMD"
		Me.yesCMD.Size = New System.Drawing.Size(73, 25)
		Me.yesCMD.Location = New System.Drawing.Point(8, 16)
		Me.yesCMD.Caption = "&Yes"
		Me.yesCMD.TabIndex = 1
		Me.yesCMD.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(57, 9)
		Me.Label1.Location = New System.Drawing.Point(0, 48)
		Me.Label1.Font = New System.Drawing.Font("Arial", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "© 2000 One"
		Me.Label1.TabIndex = 3
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' NewgameFRM
		'
		Me.Name = "NewgameFRM"
		Me.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "New Game?"
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(162, 56)

		Me.Controls.Add(noCMD)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(yesCMD)
		Me.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
