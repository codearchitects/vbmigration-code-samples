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
	Public WithEvents optCustom As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optZOrder As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optHalftone As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents picPalette As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdLoadImage As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents picTestImage As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.optCustom = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optZOrder = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optHalftone = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.picPalette = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdLoadImage = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.picTestImage = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(57, 33)
		Me.Command1.Location = New System.Drawing.Point(176, 400)
		Me.Command1.Caption = "Show"
		Me.Command1.TabIndex = 7
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(265, 113)
		Me.Frame1.Location = New System.Drawing.Point(328, 304)
		Me.Frame1.Caption = "PaletteMode setting"
		Me.Frame1.TabIndex = 3
		'
		' optCustom
		'
		Me.optCustom.Name = "optCustom"
		Me.optCustom.Size = New System.Drawing.Size(145, 25)
		Me.optCustom.Location = New System.Drawing.Point(16, 72)
		Me.optCustom.Caption = "&2. Custom palette"
		Me.optCustom.TabIndex = 6
		'
		' optZOrder
		'
		Me.optZOrder.Name = "optZOrder"
		Me.optZOrder.Size = New System.Drawing.Size(145, 25)
		Me.optZOrder.Location = New System.Drawing.Point(16, 48)
		Me.optZOrder.Caption = "&1. Z-Order"
		Me.optZOrder.TabIndex = 5
		'
		' optHalftone
		'
		Me.optHalftone.Name = "optHalftone"
		Me.optHalftone.Size = New System.Drawing.Size(145, 25)
		Me.optHalftone.Location = New System.Drawing.Point(16, 24)
		Me.optHalftone.Caption = "&0. Halftone Palette"
		Me.optHalftone.TabIndex = 4
		Me.optHalftone.Value = True
		'
		' picPalette
		'
		Me.picPalette.Name = "picPalette"
		Me.picPalette.Size = New System.Drawing.Size(265, 257)
		Me.picPalette.Location = New System.Drawing.Point(320, 32)
		Me.picPalette.TabIndex = 2
		Me.picPalette.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' cmdLoadImage
		'
		Me.cmdLoadImage.Name = "cmdLoadImage"
		Me.cmdLoadImage.Size = New System.Drawing.Size(137, 41)
		Me.cmdLoadImage.Location = New System.Drawing.Point(8, 296)
		Me.cmdLoadImage.Caption = "Load a &Test Image"
		Me.cmdLoadImage.TabIndex = 1
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' picTestImage
		'
		Me.picTestImage.Name = "picTestImage"
		Me.picTestImage.Size = New System.Drawing.Size(289, 257)
		Me.picTestImage.Location = New System.Drawing.Point(8, 32)
		Me.picTestImage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picTestImage.TabIndex = 0
		Me.picTestImage.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Palette Workbench"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(636, 461)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(optCustom)
		Me.Frame1.Controls.Add(optZOrder)
		Me.Frame1.Controls.Add(optHalftone)
		Me.Controls.Add(picPalette)
		Me.Controls.Add(cmdLoadImage)
		Me.Controls.Add(picTestImage)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
