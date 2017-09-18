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
	Public WithEvents txtGrandTotal As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtTax As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtPercent As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtAmount As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtGrandTotal = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtTax = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtPercent = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtAmount = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' txtGrandTotal
		'
		Me.txtGrandTotal.Name = "txtGrandTotal"
		Me.txtGrandTotal.Size = New System.Drawing.Size(137, 25)
		Me.txtGrandTotal.Location = New System.Drawing.Point(192, 176)
		Me.txtGrandTotal.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtGrandTotal.TabIndex = 6
		'
		' txtTax
		'
		Me.txtTax.Name = "txtTax"
		Me.txtTax.Size = New System.Drawing.Size(137, 25)
		Me.txtTax.Location = New System.Drawing.Point(192, 112)
		Me.txtTax.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtTax.TabIndex = 4
		'
		' txtPercent
		'
		Me.txtPercent.Name = "txtPercent"
		Me.txtPercent.Size = New System.Drawing.Size(89, 25)
		Me.txtPercent.Location = New System.Drawing.Point(40, 112)
		Me.txtPercent.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtPercent.TabIndex = 2
		'
		' txtAmount
		'
		Me.txtAmount.Name = "txtAmount"
		Me.txtAmount.Size = New System.Drawing.Size(137, 25)
		Me.txtAmount.Location = New System.Drawing.Point(192, 48)
		Me.txtAmount.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtAmount.TabIndex = 0
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(129, 25)
		Me.Label4.Location = New System.Drawing.Point(192, 152)
		Me.Label4.Caption = "&Grand Total"
		Me.Label4.TabIndex = 7
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(129, 25)
		Me.Label3.Location = New System.Drawing.Point(192, 88)
		Me.Label3.Caption = "&Tax"
		Me.Label3.TabIndex = 5
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(129, 25)
		Me.Label2.Location = New System.Drawing.Point(40, 88)
		Me.Label2.Caption = "Tax &Percent"
		Me.Label2.TabIndex = 3
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(129, 25)
		Me.Label1.Location = New System.Drawing.Point(192, 24)
		Me.Label1.Caption = "&Amount"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "CTextBoxNum / CTextBoxCalc Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(401, 249)

		Me.Controls.Add(txtGrandTotal)
		Me.Controls.Add(txtTax)
		Me.Controls.Add(txtPercent)
		Me.Controls.Add(txtAmount)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
