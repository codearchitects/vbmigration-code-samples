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
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdCopy As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents optRGB As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optHex As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optDecimal As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents picTest As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents vsbBlue As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents vsbGreen As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents vsbRed As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents lblBlue As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblGreen As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRed As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdCopy = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.optRGB = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optHex = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optDecimal = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.picTest = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.vsbBlue = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.vsbGreen = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.vsbRed = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.lblBlue = New CodeArchitects.VB6Library.VB6Label()
		Me.lblGreen = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRed = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(17, 25)
		Me.Command1.Location = New System.Drawing.Point(8, 112)
		Me.Command1.Caption = "Command1"
		Me.Command1.TabIndex = 12
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(193, 137)
		Me.Frame1.Location = New System.Drawing.Point(176, 104)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Caption = "Value"
		Me.Frame1.TabIndex = 7
		'
		' cmdCopy
		'
		Me.cmdCopy.Name = "cmdCopy"
		Me.cmdCopy.Size = New System.Drawing.Size(81, 25)
		Me.cmdCopy.Location = New System.Drawing.Point(96, 104)
		Me.cmdCopy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCopy.Caption = "&Copy"
		Me.cmdCopy.TabIndex = 11
		'
		' optRGB
		'
		Me.optRGB.Name = "optRGB"
		Me.optRGB.Size = New System.Drawing.Size(161, 17)
		Me.optRGB.Location = New System.Drawing.Point(16, 80)
		Me.optRGB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optRGB.Caption = "optRGB"
		Me.optRGB.TabIndex = 10
		'
		' optHex
		'
		Me.optHex.Name = "optHex"
		Me.optHex.Size = New System.Drawing.Size(161, 17)
		Me.optHex.Location = New System.Drawing.Point(16, 56)
		Me.optHex.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optHex.Caption = "optHex"
		Me.optHex.TabIndex = 9
		'
		' optDecimal
		'
		Me.optDecimal.Name = "optDecimal"
		Me.optDecimal.Size = New System.Drawing.Size(161, 17)
		Me.optDecimal.Location = New System.Drawing.Point(16, 32)
		Me.optDecimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optDecimal.Caption = "optDecimal"
		Me.optDecimal.TabIndex = 8
		Me.optDecimal.Value = True
		'
		' picTest
		'
		Me.picTest.Name = "picTest"
		Me.picTest.Size = New System.Drawing.Size(193, 73)
		Me.picTest.Location = New System.Drawing.Point(176, 16)
		Me.picTest.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.picTest.BackColor = FromOleColor6(CInt(&H80000005))
		Me.picTest.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.picTest.TabIndex = 6
		'
		' vsbBlue
		'
		Me.vsbBlue.Name = "vsbBlue"
		Me.vsbBlue.Size = New System.Drawing.Size(25, 177)
		Me.vsbBlue.Location = New System.Drawing.Point(120, 56)
		Me.vsbBlue.LargeChange = 16
		Me.vsbBlue.Max = 0
		Me.vsbBlue.Min = 255
		Me.vsbBlue.TabIndex = 2
		'
		' vsbGreen
		'
		Me.vsbGreen.Name = "vsbGreen"
		Me.vsbGreen.Size = New System.Drawing.Size(25, 177)
		Me.vsbGreen.Location = New System.Drawing.Point(80, 56)
		Me.vsbGreen.LargeChange = 16
		Me.vsbGreen.Max = 0
		Me.vsbGreen.Min = 255
		Me.vsbGreen.TabIndex = 1
		'
		' vsbRed
		'
		Me.vsbRed.Name = "vsbRed"
		Me.vsbRed.Size = New System.Drawing.Size(25, 177)
		Me.vsbRed.Location = New System.Drawing.Point(40, 56)
		Me.vsbRed.LargeChange = 16
		Me.vsbRed.Max = 0
		Me.vsbRed.Min = 255
		Me.vsbRed.TabIndex = 0
		'
		' lblBlue
		'
		Me.lblBlue.Name = "lblBlue"
		Me.lblBlue.Size = New System.Drawing.Size(41, 225)
		Me.lblBlue.Location = New System.Drawing.Point(112, 16)
		Me.lblBlue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBlue.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblBlue.BackColor = FromOleColor6(CInt(&H00FF0000))
		Me.lblBlue.TabIndex = 5
		'
		' lblGreen
		'
		Me.lblGreen.Name = "lblGreen"
		Me.lblGreen.Size = New System.Drawing.Size(41, 225)
		Me.lblGreen.Location = New System.Drawing.Point(72, 16)
		Me.lblGreen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGreen.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblGreen.BackColor = FromOleColor6(CInt(&H0000FF00))
		Me.lblGreen.TabIndex = 4
		'
		' lblRed
		'
		Me.lblRed.Name = "lblRed"
		Me.lblRed.Size = New System.Drawing.Size(41, 225)
		Me.lblRed.Location = New System.Drawing.Point(32, 16)
		Me.lblRed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRed.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblRed.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.lblRed.TabIndex = 3
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Pick - A - Color"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(388, 267)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmdCopy)
		Me.Frame1.Controls.Add(optRGB)
		Me.Frame1.Controls.Add(optHex)
		Me.Frame1.Controls.Add(optDecimal)
		Me.Controls.Add(picTest)
		Me.Controls.Add(vsbBlue)
		Me.Controls.Add(vsbGreen)
		Me.Controls.Add(vsbRed)
		Me.Controls.Add(lblBlue)
		Me.Controls.Add(lblGreen)
		Me.Controls.Add(lblRed)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
