<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptions
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
		' Initialize control arrays.
		Me.Check1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)(Check1_000)
		Me.Option1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(Option1_000)
		Me.Frame1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Frame)(Frame1_000)
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
	Public Check1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)
	Public Option1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public Frame1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Frame)
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Check1_000 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Option1_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Frame1_000 As CodeArchitects.VB6Library.VB6Frame

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Check1_000 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Option1_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Frame1_000 = New CodeArchitects.VB6Library.VB6Frame()
		Me.SuspendLayout()
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(65, 25)
		Me.cmdOK.Location = New System.Drawing.Point(64, 208)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 3
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(144, 208)
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 4
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Check1_000
		'
		Me.Check1_000.Name = "Check1_000"
		Me.Check1_000.Size = New System.Drawing.Size(241, 25)
		Me.Check1_000.Location = New System.Drawing.Point(16, 152)
		Me.Check1_000.Caption = "Check1"
		Me.Check1_000.TabIndex = 2
		Me.Check1_000.Visible = False
		'
		' Option1_000
		'
		Me.Option1_000.Name = "Option1_000"
		Me.Option1_000.Size = New System.Drawing.Size(233, 25)
		Me.Option1_000.Location = New System.Drawing.Point(16, 120)
		Me.Option1_000.Caption = "Option1"
		Me.Option1_000.TabIndex = 1
		Me.Option1_000.Value = True
		Me.Option1_000.Visible = False
		'
		' Frame1_000
		'
		Me.Frame1_000.Name = "Frame1_000"
		Me.Frame1_000.Size = New System.Drawing.Size(257, 81)
		Me.Frame1_000.Location = New System.Drawing.Point(8, 8)
		Me.Frame1_000.TabIndex = 0
		Me.Frame1_000.Visible = False
		'
		' frmOptions
		'
		Me.Name = "frmOptions"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Options"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(272, 238)

		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(Check1_000)
		Me.Controls.Add(Option1_000)
		Me.Controls.Add(Frame1_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
