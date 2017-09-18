<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmQuick
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
	Public WithEvents cmbSpeed As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtQuick As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdClose As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClipBoard As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdStart As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQuick))
		Me.cmbSpeed = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtQuick = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdClose = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClipBoard = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdStart = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmbSpeed
		'
		Me.cmbSpeed.Name = "cmbSpeed"
		Me.cmbSpeed.Size = New System.Drawing.Size(73, 21)
		Me.cmbSpeed.Location = New System.Drawing.Point(8, 312)
		Me.cmbSpeed.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbSpeed.TabIndex = 1
		'
		' txtQuick
		'
		Me.txtQuick.Name = "txtQuick"
		Me.txtQuick.Size = New System.Drawing.Size(489, 273)
		Me.txtQuick.Location = New System.Drawing.Point(8, 32)
		Me.txtQuick.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQuick.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.txtQuick.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.txtQuick.MultiLine = -1
		Me.txtQuick.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtQuick.TabIndex = 0
		'
		' cmdClose
		'
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(416, 312)
		Me.cmdClose.Caption = "&Close"
		Me.cmdClose.TabIndex = 4
		Me.cmdClose.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdClose
		Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdClipBoard
		'
		Me.cmdClipBoard.Name = "cmdClipBoard"
		Me.cmdClipBoard.Size = New System.Drawing.Size(81, 25)
		Me.cmdClipBoard.Location = New System.Drawing.Point(240, 312)
		Me.cmdClipBoard.Caption = "&Get Clipboard"
		Me.cmdClipBoard.TabIndex = 2
		Me.cmdClipBoard.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdStart
		'
		Me.cmdStart.Name = "cmdStart"
		Me.cmdStart.Size = New System.Drawing.Size(81, 25)
		Me.cmdStart.Location = New System.Drawing.Point(328, 312)
		Me.cmdStart.Caption = "&Start"
		Me.cmdStart.TabIndex = 3
		Me.cmdStart.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(497, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "The BC-52 Simulator will only process letters (and space in Cipher mode) and ignore all other characters!"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 5
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmQuick
		'
		Me.Name = "frmQuick"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = " BC-52 Auto Typing"
		Me.ControlBox = False
		Me.Icon = Nothing
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(505, 341)

		Me.Controls.Add(cmbSpeed)
		Me.Controls.Add(txtQuick)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(cmdClipBoard)
		Me.Controls.Add(cmdStart)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
