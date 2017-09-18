<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MyDataControl
	Inherits CodeArchitects.VB6Library.VB6UserControl

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
		Me.cmdMove = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMove_004, cmdMove_005, cmdMove_003, cmdMove_002, cmdMove_001, cmdMove_000)
		Me.ObjectIsInitializing = False
	End Sub

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing Then
				If components IsNot Nothing Then components.Dispose()
			UserControl_Terminate_VB6()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public cmdMove As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Private WithEvents cmdMove_004 As CodeArchitects.VB6Library.VB6CommandButton
	Private WithEvents cmdMove_005 As CodeArchitects.VB6Library.VB6CommandButton
	Private WithEvents cmdMove_003 As CodeArchitects.VB6Library.VB6CommandButton
	Private WithEvents cmdMove_002 As CodeArchitects.VB6Library.VB6CommandButton
	Private WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Private WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdMove_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' cmdMove_004
		'
		Me.cmdMove_004.Name = "cmdMove_004"
		Me.cmdMove_004.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_004.Location = New System.Drawing.Point(160, 0)
		Me.cmdMove_004.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_004.Caption = "+"
		Me.cmdMove_004.TabIndex = 5
		'
		' cmdMove_005
		'
		Me.cmdMove_005.Name = "cmdMove_005"
		Me.cmdMove_005.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_005.Location = New System.Drawing.Point(192, 0)
		Me.cmdMove_005.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_005.Caption = "X"
		Me.cmdMove_005.TabIndex = 4
		'
		' cmdMove_003
		'
		Me.cmdMove_003.Name = "cmdMove_003"
		Me.cmdMove_003.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_003.Location = New System.Drawing.Point(104, 0)
		Me.cmdMove_003.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_003.Caption = ">|"
		Me.cmdMove_003.TabIndex = 3
		'
		' cmdMove_002
		'
		Me.cmdMove_002.Name = "cmdMove_002"
		Me.cmdMove_002.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_002.Location = New System.Drawing.Point(72, 0)
		Me.cmdMove_002.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_002.Caption = ">"
		Me.cmdMove_002.TabIndex = 2
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_001.Location = New System.Drawing.Point(32, 0)
		Me.cmdMove_001.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_001.Caption = "<"
		Me.cmdMove_001.TabIndex = 1
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(33, 33)
		Me.cmdMove_000.Location = New System.Drawing.Point(0, 0)
		Me.cmdMove_000.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_000.Caption = "|<"
		Me.cmdMove_000.TabIndex = 0
		'
		' MyDataControl
		'
		Me.Name = "MyDataControl"
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(226, 34)

		Me.Controls.Add(cmdMove_004)
		Me.Controls.Add(cmdMove_005)
		Me.Controls.Add(cmdMove_003)
		Me.Controls.Add(cmdMove_002)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
