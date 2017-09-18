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
	Public WithEvents cmdShow As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdBrowser As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFilename As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdShow = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdBrowser = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFilename = New CodeArchitects.VB6Library.VB6TextBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdShow
		'
		Me.cmdShow.Name = "cmdShow"
		Me.cmdShow.Size = New System.Drawing.Size(73, 25)
		Me.cmdShow.Location = New System.Drawing.Point(264, 64)
		Me.cmdShow.Caption = "&Show File"
		Me.cmdShow.TabIndex = 2
		Me.AcceptButton = Me.cmdShow
		Me.cmdShow.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdBrowser
		'
		Me.cmdBrowser.Name = "cmdBrowser"
		Me.cmdBrowser.Size = New System.Drawing.Size(73, 25)
		Me.cmdBrowser.Location = New System.Drawing.Point(264, 24)
		Me.cmdBrowser.Caption = "&Browse"
		Me.cmdBrowser.TabIndex = 1
		'
		' txtFilename
		'
		Me.txtFilename.Name = "txtFilename"
		Me.txtFilename.Size = New System.Drawing.Size(249, 25)
		Me.txtFilename.Location = New System.Drawing.Point(16, 24)
		Me.txtFilename.TabIndex = 0
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 8)
		Me.Label1.Caption = "Text File Name:"
		Me.Label1.TabIndex = 3
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Text Browser Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(394, 110)

		Me.Controls.Add(cmdShow)
		Me.Controls.Add(cmdBrowser)
		Me.Controls.Add(txtFilename)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
