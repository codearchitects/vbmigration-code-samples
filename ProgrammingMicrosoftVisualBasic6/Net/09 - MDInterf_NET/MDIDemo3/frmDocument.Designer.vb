<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDocument
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
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents txtText As CodeArchitects.VB6Library.VB6TextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.txtText = New CodeArchitects.VB6Library.VB6TextBox()
		Me.SuspendLayout()
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' txtText
		'
		Me.txtText.Name = "txtText"
		Me.txtText.Size = New System.Drawing.Size(200, 133)
		Me.txtText.Location = New System.Drawing.Point(7, 7)
		Me.txtText.MultiLine = -1
		Me.txtText.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtText.TabIndex = 0
		'
		' frmDocument
		'
		Me.Name = "frmDocument"
		Me.Caption = "frmDocument"
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(501, 277)

		Me.Controls.Add(txtText)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
