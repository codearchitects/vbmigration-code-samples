<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRectangle
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
	Public WithEvents txtArea As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtPerimeter As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdEvaluate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtHeight As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtWidth As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblArea As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPerimeter As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblHeight As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWidth As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtArea = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtPerimeter = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdEvaluate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtHeight = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtWidth = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblArea = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPerimeter = New CodeArchitects.VB6Library.VB6Label()
		Me.lblHeight = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWidth = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' txtArea
		'
		Me.txtArea.Name = "txtArea"
		Me.txtArea.Size = New System.Drawing.Size(177, 25)
		Me.txtArea.Location = New System.Drawing.Point(325, 77)
		Me.txtArea.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtArea.TabIndex = 8
		'
		' txtPerimeter
		'
		Me.txtPerimeter.Name = "txtPerimeter"
		Me.txtPerimeter.Size = New System.Drawing.Size(177, 25)
		Me.txtPerimeter.Location = New System.Drawing.Point(325, 29)
		Me.txtPerimeter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPerimeter.TabIndex = 6
		'
		' cmdEvaluate
		'
		Me.cmdEvaluate.Name = "cmdEvaluate"
		Me.cmdEvaluate.Size = New System.Drawing.Size(89, 25)
		Me.cmdEvaluate.Location = New System.Drawing.Point(213, 29)
		Me.cmdEvaluate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEvaluate.Caption = "&Evaluate"
		Me.cmdEvaluate.TabIndex = 4
		'
		' txtHeight
		'
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(177, 25)
		Me.txtHeight.Location = New System.Drawing.Point(13, 80)
		Me.txtHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHeight.TabIndex = 3
		'
		' txtWidth
		'
		Me.txtWidth.Name = "txtWidth"
		Me.txtWidth.Size = New System.Drawing.Size(177, 25)
		Me.txtWidth.Location = New System.Drawing.Point(13, 29)
		Me.txtWidth.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWidth.TabIndex = 1
		'
		' lblArea
		'
		Me.lblArea.Name = "lblArea"
		Me.lblArea.Size = New System.Drawing.Size(89, 17)
		Me.lblArea.Location = New System.Drawing.Point(325, 61)
		Me.lblArea.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblArea.Caption = "&Area"
		Me.lblArea.TabIndex = 7
		'
		' lblPerimeter
		'
		Me.lblPerimeter.Name = "lblPerimeter"
		Me.lblPerimeter.Size = New System.Drawing.Size(89, 17)
		Me.lblPerimeter.Location = New System.Drawing.Point(325, 13)
		Me.lblPerimeter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPerimeter.Caption = "&Perimeter"
		Me.lblPerimeter.TabIndex = 5
		'
		' lblHeight
		'
		Me.lblHeight.Name = "lblHeight"
		Me.lblHeight.Size = New System.Drawing.Size(89, 17)
		Me.lblHeight.Location = New System.Drawing.Point(13, 64)
		Me.lblHeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeight.Caption = "&Height"
		Me.lblHeight.TabIndex = 2
		'
		' lblWidth
		'
		Me.lblWidth.Name = "lblWidth"
		Me.lblWidth.Size = New System.Drawing.Size(89, 17)
		Me.lblWidth.Location = New System.Drawing.Point(13, 13)
		Me.lblWidth.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWidth.Caption = "&Width"
		Me.lblWidth.TabIndex = 0
		'
		' frmRectangle
		'
		Me.Name = "frmRectangle"
		Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Rectangle Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(514, 130)

		Me.Controls.Add(txtArea)
		Me.Controls.Add(txtPerimeter)
		Me.Controls.Add(cmdEvaluate)
		Me.Controls.Add(txtHeight)
		Me.Controls.Add(txtWidth)
		Me.Controls.Add(lblArea)
		Me.Controls.Add(lblPerimeter)
		Me.Controls.Add(lblHeight)
		Me.Controls.Add(lblWidth)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
