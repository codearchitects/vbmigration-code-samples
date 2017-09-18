<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptions
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
		Me.picOptions = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)(picOptions_003, picOptions_002, picOptions_001, picOptions_000)
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
	Public picOptions As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdApply As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents picOptions_003 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents fraSample4 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents picOptions_002 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents fraSample3 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents picOptions_001 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents fraSample2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents picOptions_000 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents fraSample1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents tbsOptions As CodeArchitects.VB6Library.VB6TabStrip
	Public WithEvents tbsOptions_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tbsOptions_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tbsOptions_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents tbsOptions_TabPage4 As System.Windows.Forms.TabPage

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdApply = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.picOptions_003 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraSample4 = New CodeArchitects.VB6Library.VB6Frame()
		Me.picOptions_002 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraSample3 = New CodeArchitects.VB6Library.VB6Frame()
		Me.picOptions_001 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraSample2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.picOptions_000 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraSample1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.tbsOptions = New CodeArchitects.VB6Library.VB6TabStrip()
		Me.tbsOptions_TabPage1 = New System.Windows.Forms.TabPage()
		Me.tbsOptions_TabPage2 = New System.Windows.Forms.TabPage()
		Me.tbsOptions_TabPage3 = New System.Windows.Forms.TabPage()
		Me.tbsOptions_TabPage4 = New System.Windows.Forms.TabPage()
		Me.picOptions_003.SuspendLayout()
		Me.picOptions_002.SuspendLayout()
		Me.picOptions_001.SuspendLayout()
		Me.picOptions_000.SuspendLayout()
		Me.tbsOptions.SuspendLayout()
		CType(Me.tbsOptions, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(166, 297)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 1
		Me.cmdOK.Tag = "OK"
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(248, 297)
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 3
		Me.cmdCancel.Tag = "Cancel"
		Me.cmdCancel.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdApply
		'
		Me.cmdApply.Name = "cmdApply"
		Me.cmdApply.Size = New System.Drawing.Size(73, 25)
		Me.cmdApply.Location = New System.Drawing.Point(328, 297)
		Me.cmdApply.Caption = "&Apply"
		Me.cmdApply.TabIndex = 5
		Me.cmdApply.Tag = "&Apply"
		Me.cmdApply.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picOptions_003
		'
		Me.picOptions_003.Name = "picOptions_003"
		Me.picOptions_003.Size = New System.Drawing.Size(379, 252)
		Me.picOptions_003.Location = New System.Drawing.Point(-1333, 32)
		Me.picOptions_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picOptions_003.ScaleHeight = 3840.968
		Me.picOptions_003.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picOptions_003.ScaleWidth = 5745.64
		Me.picOptions_003.TabIndex = 7
		Me.picOptions_003.TabStop = False
		Me.picOptions_003.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOptions_003.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picOptions_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraSample4
		'
		Me.fraSample4.Name = "fraSample4"
		Me.fraSample4.Size = New System.Drawing.Size(136, 135)
		Me.fraSample4.Location = New System.Drawing.Point(34, 33)
		Me.fraSample4.Caption = "Sample 4"
		Me.fraSample4.TabIndex = 11
		Me.fraSample4.Tag = "Sample 4"
		Me.fraSample4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picOptions_002
		'
		Me.picOptions_002.Name = "picOptions_002"
		Me.picOptions_002.Size = New System.Drawing.Size(379, 252)
		Me.picOptions_002.Location = New System.Drawing.Point(-1333, 32)
		Me.picOptions_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picOptions_002.ScaleHeight = 3840.968
		Me.picOptions_002.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picOptions_002.ScaleWidth = 5745.64
		Me.picOptions_002.TabIndex = 9
		Me.picOptions_002.TabStop = False
		Me.picOptions_002.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOptions_002.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picOptions_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraSample3
		'
		Me.fraSample3.Name = "fraSample3"
		Me.fraSample3.Size = New System.Drawing.Size(136, 135)
		Me.fraSample3.Location = New System.Drawing.Point(27, 27)
		Me.fraSample3.Caption = "Sample 3"
		Me.fraSample3.TabIndex = 10
		Me.fraSample3.Tag = "Sample 3"
		Me.fraSample3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picOptions_001
		'
		Me.picOptions_001.Name = "picOptions_001"
		Me.picOptions_001.Size = New System.Drawing.Size(379, 252)
		Me.picOptions_001.Location = New System.Drawing.Point(-1333, 32)
		Me.picOptions_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picOptions_001.ScaleHeight = 3840.968
		Me.picOptions_001.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picOptions_001.ScaleWidth = 5745.64
		Me.picOptions_001.TabIndex = 6
		Me.picOptions_001.TabStop = False
		Me.picOptions_001.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOptions_001.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picOptions_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraSample2
		'
		Me.fraSample2.Name = "fraSample2"
		Me.fraSample2.Size = New System.Drawing.Size(136, 135)
		Me.fraSample2.Location = New System.Drawing.Point(20, 20)
		Me.fraSample2.Caption = "Sample 2"
		Me.fraSample2.TabIndex = 8
		Me.fraSample2.Tag = "Sample 2"
		Me.fraSample2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picOptions_000
		'
		Me.picOptions_000.Name = "picOptions_000"
		Me.picOptions_000.Size = New System.Drawing.Size(379, 252)
		Me.picOptions_000.Location = New System.Drawing.Point(14, 32)
		Me.picOptions_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picOptions_000.ScaleHeight = 3840.968
		Me.picOptions_000.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picOptions_000.ScaleWidth = 5745.64
		Me.picOptions_000.TabIndex = 2
		Me.picOptions_000.TabStop = False
		Me.picOptions_000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOptions_000.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picOptions_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraSample1
		'
		Me.fraSample1.Name = "fraSample1"
		Me.fraSample1.Size = New System.Drawing.Size(136, 135)
		Me.fraSample1.Location = New System.Drawing.Point(14, 14)
		Me.fraSample1.Caption = "Sample 1"
		Me.fraSample1.TabIndex = 4
		Me.fraSample1.Tag = "Sample 1"
		Me.fraSample1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' tbsOptions
		'
		Me.tbsOptions.Name = "tbsOptions"
		Me.tbsOptions.Size = New System.Drawing.Size(393, 283)
		Me.tbsOptions.Location = New System.Drawing.Point(7, 8)
		Me.tbsOptions.TabIndex = 0
		'
		' tbsOptions_TabPage1
		'
		Me.tbsOptions_TabPage1.Name = "tbsOptions_TabPage1"
		Me.tbsOptions_TabPage1.Text = "Group 1"
		Me.tbsOptions_TabPage1.Width = 54
		'
		' tbsOptions_TabPage2
		'
		Me.tbsOptions_TabPage2.Name = "tbsOptions_TabPage2"
		Me.tbsOptions_TabPage2.Text = "Group 2"
		Me.tbsOptions_TabPage2.Width = 54
		'
		' tbsOptions_TabPage3
		'
		Me.tbsOptions_TabPage3.Name = "tbsOptions_TabPage3"
		Me.tbsOptions_TabPage3.Text = "Group 3"
		Me.tbsOptions_TabPage3.Width = 54
		'
		' tbsOptions_TabPage4
		'
		Me.tbsOptions_TabPage4.Name = "tbsOptions_TabPage4"
		Me.tbsOptions_TabPage4.Text = "Group 4"
		Me.tbsOptions_TabPage4.Width = 54
		'
		' frmOptions
		'
		Me.Name = "frmOptions"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Options"
		Me.KeyPreview = True
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Tag = "Options"
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ClientSize = New System.Drawing.Size(410, 329)

		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdApply)
		Me.Controls.Add(picOptions_003)
		Me.picOptions_003.Controls.Add(fraSample4)
		Me.Controls.Add(picOptions_002)
		Me.picOptions_002.Controls.Add(fraSample3)
		Me.Controls.Add(picOptions_001)
		Me.picOptions_001.Controls.Add(fraSample2)
		Me.Controls.Add(picOptions_000)
		Me.picOptions_000.Controls.Add(fraSample1)
		Me.Controls.Add(tbsOptions)
		Me.tbsOptions.Controls.Add(tbsOptions_TabPage1)
		Me.tbsOptions.Controls.Add(tbsOptions_TabPage2)
		Me.tbsOptions.Controls.Add(tbsOptions_TabPage3)
		Me.tbsOptions.Controls.Add(tbsOptions_TabPage4)
		CType(Me.tbsOptions, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picOptions_003.ResumeLayout(False)
		Me.picOptions_002.ResumeLayout(False)
		Me.picOptions_001.ResumeLayout(False)
		Me.picOptions_000.ResumeLayout(False)
		Me.tbsOptions.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
