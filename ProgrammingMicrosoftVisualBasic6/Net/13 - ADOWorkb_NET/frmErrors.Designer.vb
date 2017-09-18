<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmErrors
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
	Public WithEvents cmdRefresh As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtErrors As CodeArchitects.VB6Library.VB6TextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdRefresh = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtErrors = New CodeArchitects.VB6Library.VB6TextBox()
		Me.SuspendLayout()
		'
		' cmdRefresh
		'
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.cmdRefresh.Size = New System.Drawing.Size(81, 33)
		Me.cmdRefresh.Location = New System.Drawing.Point(160, 152)
		Me.cmdRefresh.Caption = "Refresh"
		Me.cmdRefresh.TabIndex = 1
		Me.AcceptButton = Me.cmdRefresh
		Me.cmdRefresh.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtErrors
		'
		Me.txtErrors.Name = "txtErrors"
		Me.txtErrors.Size = New System.Drawing.Size(409, 137)
		Me.txtErrors.Location = New System.Drawing.Point(8, 8)
		Me.txtErrors.MultiLine = -1
		Me.txtErrors.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtErrors.TabIndex = 0
		'
		' frmErrors
		'
		Me.Name = "frmErrors"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Errors Collection"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(432, 192)

		Me.Controls.Add(cmdRefresh)
		Me.Controls.Add(txtErrors)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
