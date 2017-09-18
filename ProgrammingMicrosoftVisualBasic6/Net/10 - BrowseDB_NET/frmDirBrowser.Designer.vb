<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDirBrowser
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
	Public WithEvents tvwPublishers As CodeArchitects.VB6Library.VB6TreeView

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tvwPublishers = New CodeArchitects.VB6Library.VB6TreeView()
		Me.SuspendLayout()
		'
		' tvwPublishers
		'
		Me.tvwPublishers.Name = "tvwPublishers"
		Me.tvwPublishers.Size = New System.Drawing.Size(313, 185)
		Me.tvwPublishers.Location = New System.Drawing.Point(8, 24)
		Me.tvwPublishers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tvwPublishers.TabIndex = 0
		Me.tvwPublishers.HideSelection = False
		Me.tvwPublishers.Indentation = 529
		Me.tvwPublishers.LabelEdit = CodeArchitects.VB6Library.MSComctlLib.LabelEditConstants.tvwManual
		Me.tvwPublishers.Sorted = True
		Me.tvwPublishers.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		'
		' frmDirBrowser
		'
		Me.Name = "frmDirBrowser"
		Me.Caption = "Publishers Browser"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(337, 325)

		Me.Controls.Add(tvwPublishers)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
