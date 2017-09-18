<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form2
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
	Public WithEvents Timer2 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents DisableControl As CodeArchitects.VB6Library.VB6Label
	Public WithEvents NuovaPart As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
		Me.Timer2 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.DisableControl = New CodeArchitects.VB6Library.VB6Label()
		Me.NuovaPart = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' Timer2
		'
		Me.Timer2.Name = "Timer2"
		Me.Timer2.ParentForm = Me
		Me.Timer2.Name6 = "Timer2"
		Me.Timer2.Interval = 60000
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 350
		'
		' DisableControl
		'
		Me.DisableControl.Name = "DisableControl"
		Me.DisableControl.Size = New System.Drawing.Size(97, 25)
		Me.DisableControl.Location = New System.Drawing.Point(160, 304)
		Me.DisableControl.TabIndex = 2
		Me.DisableControl.Visible = False
		Me.DisableControl.AutoSize = False
		Me.DisableControl.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' NuovaPart
		'
		Me.NuovaPart.Name = "NuovaPart"
		Me.NuovaPart.Size = New System.Drawing.Size(81, 25)
		Me.NuovaPart.Location = New System.Drawing.Point(56, 304)
		Me.NuovaPart.TabIndex = 1
		Me.NuovaPart.Visible = False
		Me.NuovaPart.AutoSize = False
		Me.NuovaPart.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(665, 321)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Font = New System.Drawing.Font("Zurich BlkEx BT", 90!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "    HAI VINTO!!!!!"
		Me.Label1.TabIndex = 0
		Me.Label1.AutoSize = False
		'
		' Form2
		'
		Me.Name = "Form2"
		Me.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.Caption = "VITTORIA"
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(4, 30)
		Me.ClientSize = New System.Drawing.Size(676, 336)

		Me.Controls.Add(DisableControl)
		Me.Controls.Add(NuovaPart)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
