<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Public WithEvents cmdHelp As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtNumeric As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRequired As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdHelp = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtNumeric = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRequired = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdHelp
		'
		Me.cmdHelp.Name = "cmdHelp"
		Me.cmdHelp.Size = New System.Drawing.Size(89, 33)
		Me.cmdHelp.Location = New System.Drawing.Point(216, 112)
		Me.cmdHelp.Caption = "&Help"
		Me.cmdHelp.CausesValidation = False
		Me.cmdHelp.TabIndex = 6
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(216, 72)
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.CausesValidation = False
		Me.cmdCancel.TabIndex = 5
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(89, 33)
		Me.cmdOK.Location = New System.Drawing.Point(216, 32)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 4
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtNumeric
		'
		Me.txtNumeric.Name = "txtNumeric"
		Me.txtNumeric.Size = New System.Drawing.Size(145, 25)
		Me.txtNumeric.Location = New System.Drawing.Point(24, 112)
		Me.txtNumeric.TabIndex = 2
		'
		' txtRequired
		'
		Me.txtRequired.Name = "txtRequired"
		Me.txtRequired.Size = New System.Drawing.Size(145, 25)
		Me.txtRequired.Location = New System.Drawing.Point(24, 40)
		Me.txtRequired.TabIndex = 0
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(24, 88)
		Me.Label2.Caption = "&Value in range [1-1000]"
		Me.Label2.TabIndex = 3
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 25)
		Me.Label1.Location = New System.Drawing.Point(24, 16)
		Me.Label1.Caption = "&Required Field"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Validate / CausesValidation Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(11, 30)
		Me.ClientSize = New System.Drawing.Size(358, 184)

		Me.Controls.Add(cmdHelp)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtNumeric)
		Me.Controls.Add(txtRequired)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
