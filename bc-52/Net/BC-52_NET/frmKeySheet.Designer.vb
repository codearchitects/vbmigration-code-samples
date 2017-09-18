<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmKeySheet
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
	Public WithEvents txtKey As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdCopy As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClose As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKeySheet))
		Me.txtKey = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdCopy = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClose = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' txtKey
		'
		Me.txtKey.Name = "txtKey"
		Me.txtKey.Size = New System.Drawing.Size(305, 313)
		Me.txtKey.Location = New System.Drawing.Point(8, 8)
		Me.txtKey.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKey.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.txtKey.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.txtKey.ReadOnly = True
		Me.txtKey.MultiLine = -1
		Me.txtKey.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtKey.TabIndex = 2
		Me.txtKey.TabStop = False
		'
		' cmdCopy
		'
		Me.cmdCopy.Name = "cmdCopy"
		Me.cmdCopy.Size = New System.Drawing.Size(217, 25)
		Me.cmdCopy.Location = New System.Drawing.Point(8, 328)
		Me.cmdCopy.Caption = "Copy &To Clipboard"
		Me.cmdCopy.TabIndex = 1
		Me.cmdCopy.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdClose
		'
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(232, 328)
		Me.cmdClose.Caption = "&Close"
		Me.cmdClose.TabIndex = 0
		Me.cmdClose.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdClose
		Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmKeySheet
		'
		Me.Name = "frmKeySheet"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedToolWindow
		Me.Caption = " BC-52 Key Settings"
		Me.ControlBox = False
		Me.Icon = Nothing
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 21)
		Me.ClientSize = New System.Drawing.Size(321, 356)

		Me.Controls.Add(txtKey)
		Me.Controls.Add(cmdCopy)
		Me.Controls.Add(cmdClose)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
