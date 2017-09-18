<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmClipBoard
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
	Public WithEvents txtFormat As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdApply As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtLF As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents optOutput As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optInput As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtFormat = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdApply = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtLF = New CodeArchitects.VB6Library.VB6TextBox()
		Me.optOutput = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optInput = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		'
		' txtFormat
		'
		Me.txtFormat.Name = "txtFormat"
		Me.txtFormat.Size = New System.Drawing.Size(313, 281)
		Me.txtFormat.Location = New System.Drawing.Point(160, 16)
		Me.txtFormat.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFormat.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.txtFormat.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.txtFormat.ReadOnly = True
		Me.txtFormat.MultiLine = -1
		Me.txtFormat.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtFormat.TabIndex = 6
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(145, 289)
		Me.Frame2.Location = New System.Drawing.Point(8, 8)
		Me.Frame2.Caption = "Source"
		Me.Frame2.TabIndex = 7
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdApply
		'
		Me.cmdApply.Name = "cmdApply"
		Me.cmdApply.Size = New System.Drawing.Size(129, 25)
		Me.cmdApply.Location = New System.Drawing.Point(8, 96)
		Me.cmdApply.Caption = "Apply &New Groups"
		Me.cmdApply.TabIndex = 5
		Me.cmdApply.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtLF
		'
		Me.txtLF.Name = "txtLF"
		Me.txtLF.Size = New System.Drawing.Size(25, 19)
		Me.txtLF.Location = New System.Drawing.Point(12, 64)
		Me.txtLF.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtLF.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.txtLF.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.txtLF.MaxLength = 2
		Me.txtLF.TabIndex = 4
		Me.txtLF.Text = "5"
		'
		' optOutput
		'
		Me.optOutput.Name = "optOutput"
		Me.optOutput.Size = New System.Drawing.Size(113, 17)
		Me.optOutput.Location = New System.Drawing.Point(24, 24)
		Me.optOutput.Caption = "Machine &Output"
		Me.optOutput.TabIndex = 2
		Me.optOutput.TabStop = True
		Me.optOutput.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optInput
		'
		Me.optInput.Name = "optInput"
		Me.optInput.Size = New System.Drawing.Size(113, 17)
		Me.optInput.Location = New System.Drawing.Point(24, 40)
		Me.optInput.Caption = "Typed &Input"
		Me.optInput.TabIndex = 3
		Me.optInput.TabStop = True
		Me.optInput.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 67)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Groups per line"
		Me.Label1.TabIndex = 8
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(81, 25)
		Me.cmdOK.Location = New System.Drawing.Point(304, 304)
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.cmdOK.Caption = "&To Clipboard"
		Me.cmdOK.TabIndex = 0
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(392, 304)
		Me.cmdCancel.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.cmdCancel.Caption = "&Close"
		Me.cmdCancel.TabIndex = 1
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmClipBoard
		'
		Me.Name = "frmClipBoard"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = " BC-52 Clipboard"
		Me.ControlBox = False
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(482, 334)

		Me.Controls.Add(txtFormat)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(cmdApply)
		Me.Frame2.Controls.Add(txtLF)
		Me.Frame2.Controls.Add(optOutput)
		Me.Frame2.Controls.Add(optInput)
		Me.Frame2.Controls.Add(Label1)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
