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
	Public WithEvents MonthView1 As CodeArchitects.VB6Library.VB6MonthView
	Public WithEvents chkMultiSelect As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtDate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkMarkHolidays As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdMark As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdTile As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFont As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents cmdTryMe As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdNext As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrev As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MonthView1 = New CodeArchitects.VB6Library.VB6MonthView()
		Me.chkMultiSelect = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtDate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkMarkHolidays = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdMark = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdTile = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFont = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.cmdTryMe = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdNext = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrev = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.MonthView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' MonthView1
		'
		Me.MonthView1.Name = "MonthView1"
		Me.MonthView1.Size = New System.Drawing.Size(255, 188)
		Me.MonthView1.Location = New System.Drawing.Point(8, 48)
		Me.MonthView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MonthView1.DataField = "BirthDate"
		Me.MonthView1.TabIndex = 0
		Me.MonthView1.ForeColor = FromOleColor6(CInt(-2147483630))
		Me.MonthView1.BackColor = FromOleColor6(CInt(65280))
		Me.MonthView1.MonthBackColor = FromOleColor6(CInt(-2147483624))
		Me.MonthView1.ShowWeekNumbers = True
		Me.MonthView1.TitleBackColor = FromOleColor6(CInt(-2147483647))
		Me.MonthView1.TitleForeColor = FromOleColor6(CInt(-2147483634))
		Me.MonthView1.TrailingForeColor = FromOleColor6(CInt(255))
		Me.MonthView1.StartOfWeek = MSComCtl2.DayConstants.mvwSunday
		'
		' chkMultiSelect
		'
		Me.chkMultiSelect.Name = "chkMultiSelect"
		Me.chkMultiSelect.Size = New System.Drawing.Size(249, 25)
		Me.chkMultiSelect.Location = New System.Drawing.Point(280, 72)
		Me.chkMultiSelect.Caption = "Allow &Multiple Selections"
		Me.chkMultiSelect.TabIndex = 12
		'
		' txtDate
		'
		Me.txtDate.Name = "txtDate"
		Me.txtDate.Size = New System.Drawing.Size(257, 28)
		Me.txtDate.Location = New System.Drawing.Point(272, 144)
		Me.txtDate.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtDate.TabIndex = 9
		'
		' chkMarkHolidays
		'
		Me.chkMarkHolidays.Name = "chkMarkHolidays"
		Me.chkMarkHolidays.Size = New System.Drawing.Size(249, 25)
		Me.chkMarkHolidays.Location = New System.Drawing.Point(280, 48)
		Me.chkMarkHolidays.Caption = "Automatically mark &holidays"
		Me.chkMarkHolidays.TabIndex = 8
		Me.chkMarkHolidays.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' cmdMark
		'
		Me.cmdMark.Name = "cmdMark"
		Me.cmdMark.Size = New System.Drawing.Size(105, 33)
		Me.cmdMark.Location = New System.Drawing.Point(424, 8)
		Me.cmdMark.Caption = "&Mark Fridays"
		Me.cmdMark.TabIndex = 7
		'
		' cmdTile
		'
		Me.cmdTile.Name = "cmdTile"
		Me.cmdTile.Size = New System.Drawing.Size(89, 33)
		Me.cmdTile.Location = New System.Drawing.Point(328, 8)
		Me.cmdTile.Caption = "&Tile Control"
		Me.cmdTile.TabIndex = 5
		'
		' cmdFont
		'
		Me.cmdFont.Name = "cmdFont"
		Me.cmdFont.Size = New System.Drawing.Size(89, 33)
		Me.cmdFont.Location = New System.Drawing.Point(232, 8)
		Me.cmdFont.Caption = "Set &Font"
		Me.cmdFont.TabIndex = 4
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' cmdTryMe
		'
		Me.cmdTryMe.Name = "cmdTryMe"
		Me.cmdTryMe.Size = New System.Drawing.Size(105, 41)
		Me.cmdTryMe.Location = New System.Drawing.Point(328, 272)
		Me.cmdTryMe.Caption = "&Try me"
		Me.cmdTryMe.TabIndex = 3
		'
		' cmdNext
		'
		Me.cmdNext.Name = "cmdNext"
		Me.cmdNext.Size = New System.Drawing.Size(105, 33)
		Me.cmdNext.Location = New System.Drawing.Point(120, 8)
		Me.cmdNext.Caption = "&Next Month"
		Me.cmdNext.TabIndex = 2
		'
		' cmdPrev
		'
		Me.cmdPrev.Name = "cmdPrev"
		Me.cmdPrev.Size = New System.Drawing.Size(105, 33)
		Me.cmdPrev.Location = New System.Drawing.Point(8, 8)
		Me.cmdPrev.Caption = "&Prev Month"
		Me.cmdPrev.TabIndex = 1
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(257, 33)
		Me.lblStatus.Location = New System.Drawing.Point(8, 240)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 11
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(249, 41)
		Me.Label2.Location = New System.Drawing.Point(272, 96)
		Me.Label2.Caption = "Use right button to drag-and-drop a date to this textbox"
		Me.Label2.TabIndex = 10
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(209, 81)
		Me.Label1.Location = New System.Drawing.Point(280, 184)
		Me.Label1.Caption = "This is the only button in the form that reacts to clicks even when the focus is on the MonthView control."
		Me.Label1.TabIndex = 6
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "MonthView Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(538, 368)

		Me.Controls.Add(MonthView1)
		Me.Controls.Add(chkMultiSelect)
		Me.Controls.Add(txtDate)
		Me.Controls.Add(chkMarkHolidays)
		Me.Controls.Add(cmdMark)
		Me.Controls.Add(cmdTile)
		Me.Controls.Add(cmdFont)
		Me.Controls.Add(cmdTryMe)
		Me.Controls.Add(cmdNext)
		Me.Controls.Add(cmdPrev)
		Me.Controls.Add(lblStatus)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.MonthView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
