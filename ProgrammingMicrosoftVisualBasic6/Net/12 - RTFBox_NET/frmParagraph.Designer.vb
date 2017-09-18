<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmParagraph
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
		Me.opAlign = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(opAlign_000, opAlign_001, opAlign_002)
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
	Public opAlign As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents txtLeft As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRight As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFirstLine As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents opAlign_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents opAlign_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents opAlign_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.txtLeft = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRight = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFirstLine = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.opAlign_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.opAlign_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.opAlign_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(169, 93)
		Me.Frame1.Location = New System.Drawing.Point(16, 8)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Caption = "Indentation "
		Me.Frame1.TabIndex = 6
		'
		' txtLeft
		'
		Me.txtLeft.Name = "txtLeft"
		Me.txtLeft.Size = New System.Drawing.Size(39, 19)
		Me.txtLeft.Location = New System.Drawing.Point(78, 14)
		Me.txtLeft.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLeft.MaxLength = 4
		Me.txtLeft.TabIndex = 9
		'
		' txtRight
		'
		Me.txtRight.Name = "txtRight"
		Me.txtRight.Size = New System.Drawing.Size(39, 19)
		Me.txtRight.Location = New System.Drawing.Point(78, 38)
		Me.txtRight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRight.MaxLength = 5
		Me.txtRight.TabIndex = 8
		'
		' txtFirstLine
		'
		Me.txtFirstLine.Name = "txtFirstLine"
		Me.txtFirstLine.Size = New System.Drawing.Size(39, 19)
		Me.txtFirstLine.Location = New System.Drawing.Point(78, 62)
		Me.txtFirstLine.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstLine.MaxLength = 4
		Me.txtFirstLine.TabIndex = 7
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(21, 16)
		Me.Label1.Location = New System.Drawing.Point(12, 20)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.AutoSize = True
		Me.Label1.Caption = "Left"
		Me.Label1.TabIndex = 15
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 16)
		Me.Label2.Location = New System.Drawing.Point(12, 68)
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.AutoSize = True
		Me.Label2.Caption = "First Line"
		Me.Label2.TabIndex = 14
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(31, 16)
		Me.Label3.Location = New System.Drawing.Point(12, 44)
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.AutoSize = True
		Me.Label3.Caption = "Right"
		Me.Label3.TabIndex = 13
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(30, 16)
		Me.Label4.Location = New System.Drawing.Point(120, 18)
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.AutoSize = True
		Me.Label4.Caption = "twips"
		Me.Label4.TabIndex = 12
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(30, 16)
		Me.Label5.Location = New System.Drawing.Point(120, 42)
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.AutoSize = True
		Me.Label5.Caption = "twips"
		Me.Label5.TabIndex = 11
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(30, 16)
		Me.Label6.Location = New System.Drawing.Point(120, 66)
		Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.AutoSize = True
		Me.Label6.Caption = "twips"
		Me.Label6.TabIndex = 10
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(171, 85)
		Me.Frame2.Location = New System.Drawing.Point(16, 110)
		Me.Frame2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Caption = "Allineamento:"
		Me.Frame2.TabIndex = 2
		'
		' opAlign_000
		'
		Me.opAlign_000.Name = "opAlign_000"
		Me.opAlign_000.Size = New System.Drawing.Size(103, 15)
		Me.opAlign_000.Location = New System.Drawing.Point(12, 20)
		Me.opAlign_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opAlign_000.Caption = "&Left"
		Me.opAlign_000.TabIndex = 5
		'
		' opAlign_001
		'
		Me.opAlign_001.Name = "opAlign_001"
		Me.opAlign_001.Size = New System.Drawing.Size(103, 15)
		Me.opAlign_001.Location = New System.Drawing.Point(12, 38)
		Me.opAlign_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opAlign_001.Caption = "&Center"
		Me.opAlign_001.TabIndex = 4
		'
		' opAlign_002
		'
		Me.opAlign_002.Name = "opAlign_002"
		Me.opAlign_002.Size = New System.Drawing.Size(103, 15)
		Me.opAlign_002.Location = New System.Drawing.Point(12, 56)
		Me.opAlign_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opAlign_002.Caption = "&Right"
		Me.opAlign_002.TabIndex = 3
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(77, 23)
		Me.cmdOK.Location = New System.Drawing.Point(198, 16)
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.Caption = "&OK"
		Me.cmdOK.TabIndex = 1
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(77, 23)
		Me.cmdCancel.Location = New System.Drawing.Point(198, 48)
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 0
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmParagraph
		'
		Me.Name = "frmParagraph"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Paragraph Attributes"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(286, 211)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(txtLeft)
		Me.Frame1.Controls.Add(txtRight)
		Me.Frame1.Controls.Add(txtFirstLine)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label6)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(opAlign_000)
		Me.Frame2.Controls.Add(opAlign_001)
		Me.Frame2.Controls.Add(opAlign_002)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
