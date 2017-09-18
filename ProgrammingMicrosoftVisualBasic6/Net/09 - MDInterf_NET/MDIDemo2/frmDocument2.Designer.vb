<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDocument2
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
	Public WithEvents picBitmap As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.picBitmap = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.SuspendLayout()
		'
		' picBitmap
		'
		Me.picBitmap.Name = "picBitmap"
		Me.picBitmap.Size = New System.Drawing.Size(193, 145)
		Me.picBitmap.Location = New System.Drawing.Point(16, 8)
		Me.picBitmap.TabIndex = 0
		Me.picBitmap.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' frmDocument2
		'
		Me.Name = "frmDocument2"
		Me.Caption = "frmDocument2"
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(501, 277)

		Me.Controls.Add(picBitmap)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
