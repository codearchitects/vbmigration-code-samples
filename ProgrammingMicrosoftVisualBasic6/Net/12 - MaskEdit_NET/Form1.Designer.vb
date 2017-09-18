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
		' Initialize control arrays.
		Me.Label2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label2_002, Label2_001, Label2_000)
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
	Public Label2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents mebPhone As CodeArchitects.VB6Library.VB6MaskEdBox
	Public WithEvents mebCreditCard As CodeArchitects.VB6Library.VB6MaskEdBox
	Public WithEvents mebDate As CodeArchitects.VB6Library.VB6MaskEdBox
	Public WithEvents mebDecNumber As CodeArchitects.VB6Library.VB6MaskEdBox
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.mebPhone = New CodeArchitects.VB6Library.VB6MaskEdBox()
		Me.mebCreditCard = New CodeArchitects.VB6Library.VB6MaskEdBox()
		Me.mebDate = New CodeArchitects.VB6Library.VB6MaskEdBox()
		Me.mebDecNumber = New CodeArchitects.VB6Library.VB6MaskEdBox()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' mebPhone
		'
		Me.mebPhone.Name = "mebPhone"
		Me.mebPhone.Size = New System.Drawing.Size(193, 33)
		Me.mebPhone.Location = New System.Drawing.Point(24, 32)
		Me.mebPhone.TabIndex = 0
		Me.mebPhone.Mask = "(###)###-####"
		Me.mebPhone.PromptChar = "_"
		'
		' mebCreditCard
		'
		Me.mebCreditCard.Name = "mebCreditCard"
		Me.mebCreditCard.Size = New System.Drawing.Size(193, 33)
		Me.mebCreditCard.Location = New System.Drawing.Point(24, 96)
		Me.mebCreditCard.TabIndex = 2
		Me.mebCreditCard.Mask = "#### #### #### ####"
		Me.mebCreditCard.PromptChar = "_"
		'
		' mebDate
		'
		Me.mebDate.Name = "mebDate"
		Me.mebDate.Size = New System.Drawing.Size(193, 33)
		Me.mebDate.Location = New System.Drawing.Point(248, 32)
		Me.mebDate.TabIndex = 4
		Me.mebDate.Format = "mmmm dd, yyyy"
		Me.mebDate.Mask = "##/##/##"
		Me.mebDate.PromptChar = "_"
		'
		' mebDecNumber
		'
		Me.mebDecNumber.Name = "mebDecNumber"
		Me.mebDecNumber.Size = New System.Drawing.Size(193, 33)
		Me.mebDecNumber.Location = New System.Drawing.Point(248, 96)
		Me.mebDecNumber.TabIndex = 6
		Me.mebDecNumber.Format = "#,##0.00;(#,##0.00);zero;null"
		Me.mebDecNumber.PromptChar = "_"
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(209, 25)
		Me.lblStatus.Location = New System.Drawing.Point(8, 208)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 8
		'
		' Label2_002
		'
		Me.Label2_002.Name = "Label2_002"
		Me.Label2_002.Size = New System.Drawing.Size(233, 17)
		Me.Label2_002.Location = New System.Drawing.Point(248, 72)
		Me.Label2_002.Caption = "Decimal numbers with different formats"
		Me.Label2_002.TabIndex = 7
		'
		' Label2_001
		'
		Me.Label2_001.Name = "Label2_001"
		Me.Label2_001.Size = New System.Drawing.Size(209, 17)
		Me.Label2_001.Location = New System.Drawing.Point(248, 8)
		Me.Label2_001.Caption = "Date (long format on exit)"
		Me.Label2_001.TabIndex = 5
		'
		' Label2_000
		'
		Me.Label2_000.Name = "Label2_000"
		Me.Label2_000.Size = New System.Drawing.Size(137, 17)
		Me.Label2_000.Location = New System.Drawing.Point(24, 72)
		Me.Label2_000.Caption = "Credit Card Number"
		Me.Label2_000.TabIndex = 3
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 8)
		Me.Label1.Caption = "Phone Number"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "MaskedEdit Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(505, 237)

		Me.Controls.Add(mebPhone)
		Me.Controls.Add(mebCreditCard)
		Me.Controls.Add(mebDate)
		Me.Controls.Add(mebDecNumber)
		Me.Controls.Add(lblStatus)
		Me.Controls.Add(Label2_002)
		Me.Controls.Add(Label2_001)
		Me.Controls.Add(Label2_000)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
