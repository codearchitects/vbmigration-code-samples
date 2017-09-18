<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTextBrowser
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
	Public WithEvents cmdFind As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrint As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCopy As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtBrowser As CodeArchitects.VB6Library.VB6TextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdFind = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrint = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCopy = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtBrowser = New CodeArchitects.VB6Library.VB6TextBox()
		Me.SuspendLayout()
		'
		' cmdFind
		'
		Me.cmdFind.Name = "cmdFind"
		Me.cmdFind.Size = New System.Drawing.Size(73, 25)
		Me.cmdFind.Location = New System.Drawing.Point(408, 72)
		Me.cmdFind.Caption = "&Find"
		Me.cmdFind.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.cmdFind, "Find the occurrence of a string")
		'
		' cmdPrint
		'
		Me.cmdPrint.Name = "cmdPrint"
		Me.cmdPrint.Size = New System.Drawing.Size(73, 25)
		Me.cmdPrint.Location = New System.Drawing.Point(408, 40)
		Me.cmdPrint.Caption = "&Print"
		Me.cmdPrint.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.cmdPrint, "Send the text to the standard printer")
		'
		' cmdCopy
		'
		Me.cmdCopy.Name = "cmdCopy"
		Me.cmdCopy.Size = New System.Drawing.Size(73, 25)
		Me.cmdCopy.Location = New System.Drawing.Point(408, 8)
		Me.cmdCopy.Caption = "&Copy"
		Me.cmdCopy.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.cmdCopy, "Copy the selected text to the Clipboard")
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(408, 264)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.cmdOK, "Close this dialog")
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtBrowser
		'
		Me.txtBrowser.Name = "txtBrowser"
		Me.txtBrowser.Size = New System.Drawing.Size(385, 281)
		Me.txtBrowser.Location = New System.Drawing.Point(8, 8)
		Me.txtBrowser.HideSelection = False
		Me.txtBrowser.ReadOnly = True
		Me.txtBrowser.MultiLine = -1
		Me.txtBrowser.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtBrowser.TabIndex = 0
		'
		' frmTextBrowser
		'
		Me.Name = "frmTextBrowser"
		Me.Caption = "Form1"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(490, 298)

		Me.Controls.Add(cmdFind)
		Me.Controls.Add(cmdPrint)
		Me.Controls.Add(cmdCopy)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtBrowser)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
