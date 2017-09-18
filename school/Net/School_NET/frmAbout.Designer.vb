<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
		Me.Line1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)(Line1_001, Line1_000)
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
	Public Line1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSysInfo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblVersion As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line1_001 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents lblDescription As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTitle As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line1_000 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents lblDisclaimer As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSysInfo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblVersion = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Line1_001 = New CodeArchitects.VB6Library.VB6Line()
		Me.lblDescription = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTitle = New CodeArchitects.VB6Library.VB6Label()
		Me.Line1_000 = New CodeArchitects.VB6Library.VB6Line()
		Me.lblDisclaimer = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(81, 201)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.Picture = CType(resources.GetObject("Picture1.Picture"), System.Drawing.Image)
		Me.Picture1.TabIndex = 6
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(84, 23)
		Me.cmdOK.Location = New System.Drawing.Point(344, 223)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdOK
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdSysInfo
		'
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me.cmdSysInfo.Size = New System.Drawing.Size(83, 23)
		Me.cmdSysInfo.Location = New System.Drawing.Point(344, 253)
		Me.cmdSysInfo.Caption = "&System Info..."
		Me.cmdSysInfo.TabIndex = 1
		Me.cmdSysInfo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(293, 14)
		Me.Label7.Location = New System.Drawing.Point(128, 152)
		Me.Label7.Caption = "- MIS"
		Me.Label7.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label7.TabIndex = 13
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(221, 14)
		Me.Label5.Location = New System.Drawing.Point(104, 176)
		Me.Label5.Caption = "just contact me at cell# 639186443161 or visit "
		Me.Label5.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label5.TabIndex = 11
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(137, 17)
		Me.Label6.Location = New System.Drawing.Point(104, 192)
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Caption = "www.naparansoft.cjb.net"
		Me.Label6.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.Label6.TabIndex = 12
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblVersion
		'
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(299, 15)
		Me.lblVersion.Location = New System.Drawing.Point(104, 24)
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.Caption = "Version 1"
		Me.lblVersion.TabIndex = 5
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(293, 14)
		Me.Label4.Location = New System.Drawing.Point(128, 136)
		Me.Label4.Caption = "- Accounting System"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label4.TabIndex = 10
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(293, 14)
		Me.Label3.Location = New System.Drawing.Point(128, 120)
		Me.Label3.Caption = "- Billing System"
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.TabIndex = 9
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(293, 14)
		Me.Label2.Location = New System.Drawing.Point(128, 104)
		Me.Label2.Caption = "- Inventory System"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.TabIndex = 8
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(317, 14)
		Me.Label1.Location = New System.Drawing.Point(104, 88)
		Me.Label1.Caption = "If you want more software like the ff:"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 7
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line1_001
		'
		Me.Line1_001.Name = "Line1_001"
		Me.Line1_001.ParentForm = Me
		Me.Line1_001.Name6 = "Line1_001"
		Me.Line1_001.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line1_001.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSInsideSolid
		Me.Line1_001.X1 = 112.686
		Me.Line1_001.X2 = 5972.369
		Me.Line1_001.Y1 = 2184.54
		Me.Line1_001.Y2 = 2184.54
		'
		' lblDescription
		'
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(317, 46)
		Me.lblDescription.Location = New System.Drawing.Point(104, 40)
		Me.lblDescription.Caption = "This software was design for school registration purpose only. It will monitor the current student enrolled in your school and do some reporting also including summary report for the student enrolled"
		Me.lblDescription.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblDescription.TabIndex = 2
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTitle
		'
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(323, 23)
		Me.lblTitle.Location = New System.Drawing.Point(104, 8)
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Caption = "Computerize School Registration Software ( CSRS )"
		Me.lblTitle.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblTitle.TabIndex = 4
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line1_000
		'
		Me.Line1_000.Name = "Line1_000"
		Me.Line1_000.ParentForm = Me
		Me.Line1_000.Name6 = "Line1_000"
		Me.Line1_000.BorderColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Line1_000.BorderWidth = 2
		Me.Line1_000.X1 = 112.686
		Me.Line1_000.X2 = 5972.369
		Me.Line1_000.Y1 = 2194.893
		Me.Line1_000.Y2 = 2194.893
		'
		' lblDisclaimer
		'
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.lblDisclaimer.Size = New System.Drawing.Size(329, 55)
		Me.lblDisclaimer.Location = New System.Drawing.Point(8, 223)
		Me.lblDisclaimer.Caption = "Warning: This software was distributed for free by the author only. Any form of selling or reproduction of this software without permission from the author is strictly prohibited."
		Me.lblDisclaimer.ForeColor = FromOleColor6(CInt(&H000000FF))
		Me.lblDisclaimer.TabIndex = 3
		Me.lblDisclaimer.AutoSize = False
		Me.lblDisclaimer.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmAbout
		'
		Me.Name = "frmAbout"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "About CSRS"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ScaleHeight = 2981.741
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.ScaleWidth = 6099.141
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(156, 129)
		Me.ClientSize = New System.Drawing.Size(433, 288)

		Me.Controls.Add(Picture1)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdSysInfo)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label6)
		Me.Controls.Add(lblVersion)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblDisclaimer)
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
