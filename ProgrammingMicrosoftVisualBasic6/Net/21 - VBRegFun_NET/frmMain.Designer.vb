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
	Public WithEvents cmdDeleteSettings As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRestoreSettings As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSaveSettings As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDeleteSettings = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRestoreSettings = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSaveSettings = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdDeleteSettings
		'
		Me.cmdDeleteSettings.Name = "cmdDeleteSettings"
		Me.cmdDeleteSettings.Size = New System.Drawing.Size(113, 33)
		Me.cmdDeleteSettings.Location = New System.Drawing.Point(232, 112)
		Me.cmdDeleteSettings.Caption = "Delete Settings"
		Me.cmdDeleteSettings.TabIndex = 2
		'
		' cmdRestoreSettings
		'
		Me.cmdRestoreSettings.Name = "cmdRestoreSettings"
		Me.cmdRestoreSettings.Size = New System.Drawing.Size(113, 33)
		Me.cmdRestoreSettings.Location = New System.Drawing.Point(232, 64)
		Me.cmdRestoreSettings.Caption = "Restore Settings"
		Me.cmdRestoreSettings.TabIndex = 1
		'
		' cmdSaveSettings
		'
		Me.cmdSaveSettings.Name = "cmdSaveSettings"
		Me.cmdSaveSettings.Size = New System.Drawing.Size(113, 33)
		Me.cmdSaveSettings.Location = New System.Drawing.Point(232, 16)
		Me.cmdSaveSettings.Caption = "Save Settings"
		Me.cmdSaveSettings.TabIndex = 0
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(201, 129)
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.TabIndex = 3
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Registry Functions Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(369, 164)

		Me.Controls.Add(cmdDeleteSettings)
		Me.Controls.Add(cmdRestoreSettings)
		Me.Controls.Add(cmdSaveSettings)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
