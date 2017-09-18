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
	Public WithEvents cmdCreateRecordset As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCreateCommand As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCreateConnection As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdCreateRecordset = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCreateCommand = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCreateConnection = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' cmdCreateRecordset
		'
		Me.cmdCreateRecordset.Name = "cmdCreateRecordset"
		Me.cmdCreateRecordset.Size = New System.Drawing.Size(113, 41)
		Me.cmdCreateRecordset.Location = New System.Drawing.Point(272, 16)
		Me.cmdCreateRecordset.Caption = "Create a &Recordset"
		Me.cmdCreateRecordset.TabIndex = 2
		'
		' cmdCreateCommand
		'
		Me.cmdCreateCommand.Name = "cmdCreateCommand"
		Me.cmdCreateCommand.Size = New System.Drawing.Size(113, 41)
		Me.cmdCreateCommand.Location = New System.Drawing.Point(144, 16)
		Me.cmdCreateCommand.Caption = "Create a C&ommand"
		Me.cmdCreateCommand.TabIndex = 1
		'
		' cmdCreateConnection
		'
		Me.cmdCreateConnection.Name = "cmdCreateConnection"
		Me.cmdCreateConnection.Size = New System.Drawing.Size(113, 41)
		Me.cmdCreateConnection.Location = New System.Drawing.Point(16, 16)
		Me.cmdCreateConnection.Caption = "Create a &Connection"
		Me.cmdCreateConnection.TabIndex = 0
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ADO Object Model Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(398, 71)

		Me.Controls.Add(cmdCreateRecordset)
		Me.Controls.Add(cmdCreateCommand)
		Me.Controls.Add(cmdCreateConnection)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
