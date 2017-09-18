<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCalendar
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
		Me.optDay = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optDay_000)
		Me.lblWeekDay = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblWeekDay_000)
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
	Public optDay As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public lblWeekDay As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdNextYear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrevYear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents optDay_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents cmdNextMonth As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrevMonth As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblCurrentMonth As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWeekDay_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdNextYear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrevYear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.optDay_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.cmdNextMonth = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrevMonth = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblCurrentMonth = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWeekDay_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdNextYear
		'
		Me.cmdNextYear.Name = "cmdNextYear"
		Me.cmdNextYear.Size = New System.Drawing.Size(25, 25)
		Me.cmdNextYear.Location = New System.Drawing.Point(272, 0)
		Me.cmdNextYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNextYear.Caption = ">>"
		Me.cmdNextYear.TabIndex = 8
		Me.cmdNextYear.TabStop = False
		'
		' cmdPrevYear
		'
		Me.cmdPrevYear.Name = "cmdPrevYear"
		Me.cmdPrevYear.Size = New System.Drawing.Size(25, 25)
		Me.cmdPrevYear.Location = New System.Drawing.Point(8, 0)
		Me.cmdPrevYear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrevYear.Caption = "<<"
		Me.cmdPrevYear.TabIndex = 7
		Me.cmdPrevYear.TabStop = False
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(65, 25)
		Me.cmdOK.Location = New System.Drawing.Point(80, 256)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 5
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(160, 256)
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 6
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' optDay_000
		'
		Me.optDay_000.Name = "optDay_000"
		Me.optDay_000.Size = New System.Drawing.Size(41, 33)
		Me.optDay_000.Location = New System.Drawing.Point(8, 56)
		Me.optDay_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.optDay_000.TabIndex = 4
		'
		' cmdNextMonth
		'
		Me.cmdNextMonth.Name = "cmdNextMonth"
		Me.cmdNextMonth.Size = New System.Drawing.Size(25, 25)
		Me.cmdNextMonth.Location = New System.Drawing.Point(248, 0)
		Me.cmdNextMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNextMonth.Caption = ">"
		Me.cmdNextMonth.TabIndex = 3
		Me.cmdNextMonth.TabStop = False
		'
		' cmdPrevMonth
		'
		Me.cmdPrevMonth.Name = "cmdPrevMonth"
		Me.cmdPrevMonth.Size = New System.Drawing.Size(25, 25)
		Me.cmdPrevMonth.Location = New System.Drawing.Point(32, 0)
		Me.cmdPrevMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrevMonth.Caption = "<"
		Me.cmdPrevMonth.TabIndex = 2
		Me.cmdPrevMonth.TabStop = False
		'
		' lblCurrentMonth
		'
		Me.lblCurrentMonth.Name = "lblCurrentMonth"
		Me.lblCurrentMonth.Size = New System.Drawing.Size(193, 25)
		Me.lblCurrentMonth.Location = New System.Drawing.Point(56, 0)
		Me.lblCurrentMonth.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentMonth.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblCurrentMonth.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblCurrentMonth.TabIndex = 1
		'
		' lblWeekDay_000
		'
		Me.lblWeekDay_000.Name = "lblWeekDay_000"
		Me.lblWeekDay_000.Size = New System.Drawing.Size(41, 25)
		Me.lblWeekDay_000.Location = New System.Drawing.Point(8, 32)
		Me.lblWeekDay_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWeekDay_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWeekDay_000.TabIndex = 0
		'
		' frmCalendar
		'
		Me.Name = "frmCalendar"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Calendar"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(302, 287)

		Me.Controls.Add(cmdNextYear)
		Me.Controls.Add(cmdPrevYear)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(optDay_000)
		Me.Controls.Add(cmdNextMonth)
		Me.Controls.Add(cmdPrevMonth)
		Me.Controls.Add(lblCurrentMonth)
		Me.Controls.Add(lblWeekDay_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
