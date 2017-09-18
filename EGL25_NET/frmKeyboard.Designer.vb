<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmKeyboard
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
	Public WithEvents fraKeyBoard As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Label20 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label21 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label22 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label23 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label24 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label25 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents OKButton As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKeyboard))
		Me.fraKeyBoard = New CodeArchitects.VB6Library.VB6Frame()
		Me.Label20 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label21 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label22 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label23 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label24 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label25 = New CodeArchitects.VB6Library.VB6Label()
		Me.OKButton = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraKeyBoard.SuspendLayout()
		Me.SuspendLayout()
		'
		' fraKeyBoard
		'
		Me.fraKeyBoard.Name = "fraKeyBoard"
		Me.fraKeyBoard.Size = New System.Drawing.Size(337, 105)
		Me.fraKeyBoard.Location = New System.Drawing.Point(8, 8)
		Me.fraKeyBoard.Caption = "Keyboard"
		Me.fraKeyBoard.TabIndex = 1
		Me.fraKeyBoard.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label20
		'
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(41, 81)
		Me.Label20.Location = New System.Drawing.Point(8, 16)
		Me.Label20.Caption = "Shift D" & ControlChars.CrLf & "Shift W" & ControlChars.CrLf & "Shift E" & ControlChars.CrLf & "Shift A" & ControlChars.CrLf & "Shift S" & ControlChars.CrLf & "Shift Q"
		Me.Label20.TabIndex = 7
		Me.Label20.AutoSize = False
		Me.Label20.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label21
		'
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(65, 81)
		Me.Label21.Location = New System.Drawing.Point(48, 16)
		Me.Label21.Caption = "= Move + X" & ControlChars.CrLf & "= Move + Y" & ControlChars.CrLf & "= Move + Z" & ControlChars.CrLf & "= Move - X" & ControlChars.CrLf & "= Move - Y" & ControlChars.CrLf & "= Move - Z"
		Me.Label21.TabIndex = 6
		Me.Label21.AutoSize = False
		Me.Label21.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label22
		'
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(17, 81)
		Me.Label22.Location = New System.Drawing.Point(120, 16)
		Me.Label22.Caption = "S" & ControlChars.CrLf & "D" & ControlChars.CrLf & "Q" & ControlChars.CrLf & "W" & ControlChars.CrLf & "A" & ControlChars.CrLf & "E"
		Me.Label22.TabIndex = 5
		Me.Label22.AutoSize = False
		Me.Label22.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label23
		'
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(73, 81)
		Me.Label23.Location = New System.Drawing.Point(136, 16)
		Me.Label23.Caption = "= Rotate + X" & ControlChars.CrLf & "= Rotate + Y" & ControlChars.CrLf & "= Rotate + Z" & ControlChars.CrLf & "= Rotate - X" & ControlChars.CrLf & "= Rotate - Y" & ControlChars.CrLf & "= Rotate - Z"
		Me.Label23.TabIndex = 4
		Me.Label23.AutoSize = False
		Me.Label23.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label24
		'
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(41, 81)
		Me.Label24.Location = New System.Drawing.Point(216, 16)
		Me.Label24.Caption = "Z" & ControlChars.CrLf & "X" & ControlChars.CrLf & "C" & ControlChars.CrLf & "Escape" & ControlChars.CrLf & ControlChars.CrLf & "Mouse"
		Me.Label24.TabIndex = 3
		Me.Label24.AutoSize = False
		Me.Label24.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label25
		'
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(73, 81)
		Me.Label25.Location = New System.Drawing.Point(256, 16)
		Me.Label25.Caption = "= Scale    +" & ControlChars.CrLf & "= Reset view" & ControlChars.CrLf & "= Scale    -" & ControlChars.CrLf & "= Exit" & ControlChars.CrLf & ControlChars.CrLf & "=Light Position"
		Me.Label25.TabIndex = 2
		Me.Label25.AutoSize = False
		Me.Label25.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' OKButton
		'
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(81, 25)
		Me.OKButton.Location = New System.Drawing.Point(264, 120)
		Me.OKButton.Caption = "OK"
		Me.OKButton.TabIndex = 0
		Me.OKButton.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmKeyboard
		'
		Me.Name = "frmKeyboard"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Keyboard"
		Me.Icon = Nothing
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(184, 250)
		Me.ClientSize = New System.Drawing.Size(355, 153)

		Me.Controls.Add(fraKeyBoard)
		Me.fraKeyBoard.Controls.Add(Label20)
		Me.fraKeyBoard.Controls.Add(Label21)
		Me.fraKeyBoard.Controls.Add(Label22)
		Me.fraKeyBoard.Controls.Add(Label23)
		Me.fraKeyBoard.Controls.Add(Label24)
		Me.fraKeyBoard.Controls.Add(Label25)
		Me.Controls.Add(OKButton)
		Me.fraKeyBoard.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
