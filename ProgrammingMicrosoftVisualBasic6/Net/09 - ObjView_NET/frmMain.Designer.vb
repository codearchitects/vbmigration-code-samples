<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
		' Initialize control arrays.
		Me.Option1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(Option1_002, Option1_001, Option1_000)
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
	Public Option1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Option1_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Option1_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(137, 105)
		Me.Frame1.Location = New System.Drawing.Point(312, 24)
		Me.Frame1.Caption = "Notification "
		Me.Frame1.TabIndex = 2
		'
		' Option1_002
		'
		Me.Option1_002.Name = "Option1_002"
		Me.Option1_002.Size = New System.Drawing.Size(113, 17)
		Me.Option1_002.Location = New System.Drawing.Point(8, 72)
		Me.Option1_002.Caption = "&3. Key-level"
		Me.Option1_002.TabIndex = 5
		'
		' Option1_001
		'
		Me.Option1_001.Name = "Option1_001"
		Me.Option1_001.Size = New System.Drawing.Size(113, 17)
		Me.Option1_001.Location = New System.Drawing.Point(8, 48)
		Me.Option1_001.Caption = "&2. Field-level"
		Me.Option1_001.TabIndex = 4
		'
		' Option1_000
		'
		Me.Option1_000.Name = "Option1_000"
		Me.Option1_000.Size = New System.Drawing.Size(113, 17)
		Me.Option1_000.Location = New System.Drawing.Point(8, 24)
		Me.Option1_000.Caption = "&1. Record-level"
		Me.Option1_000.TabIndex = 3
		Me.Option1_000.Value = True
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(273, 41)
		Me.Command2.Location = New System.Drawing.Point(24, 88)
		Me.Command2.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.Caption = "Anne Lipton"
		Me.Command2.TabIndex = 1
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(273, 41)
		Me.Command1.Location = New System.Drawing.Point(24, 24)
		Me.Command1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Caption = "John Smith"
		Me.Command1.TabIndex = 0
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Caption = "Forms As Object Viewers"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(463, 154)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Option1_002)
		Me.Frame1.Controls.Add(Option1_001)
		Me.Frame1.Controls.Add(Option1_000)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
