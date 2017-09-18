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
	Public WithEvents cmdDataGrid As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSingleRecord As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDataGrid = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSingleRecord = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' cmdDataGrid
		'
		Me.cmdDataGrid.Name = "cmdDataGrid"
		Me.cmdDataGrid.Size = New System.Drawing.Size(113, 41)
		Me.cmdDataGrid.Location = New System.Drawing.Point(144, 8)
		Me.cmdDataGrid.Caption = "Data Grid"
		Me.cmdDataGrid.TabIndex = 1
		'
		' cmdSingleRecord
		'
		Me.cmdSingleRecord.Name = "cmdSingleRecord"
		Me.cmdSingleRecord.Size = New System.Drawing.Size(113, 41)
		Me.cmdSingleRecord.Location = New System.Drawing.Point(8, 8)
		Me.cmdSingleRecord.Caption = "Single Record"
		Me.cmdSingleRecord.TabIndex = 0
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Data Object Wizard Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(284, 67)

		Me.Controls.Add(cmdDataGrid)
		Me.Controls.Add(cmdSingleRecord)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
