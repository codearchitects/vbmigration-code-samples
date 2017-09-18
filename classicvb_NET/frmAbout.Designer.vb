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
	Public WithEvents picIcon As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSysInfo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblDescription As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTitle As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line1_001 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line1_000 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents lblVersion As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDisclaimer As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.picIcon = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSysInfo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblDescription = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTitle = New CodeArchitects.VB6Library.VB6Label()
		Me.Line1_001 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line1_000 = New CodeArchitects.VB6Library.VB6Line()
		Me.lblVersion = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDisclaimer = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' picIcon
		'
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(40, 40)
		Me.picIcon.Location = New System.Drawing.Point(16, 16)
		Me.picIcon.AutoSize = True
		Me.picIcon.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picIcon.Picture = CType(resources.GetObject("picIcon.Picture"), System.Drawing.Image)
		Me.picIcon.ScaleHeight = 600
		Me.picIcon.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picIcon.ScaleWidth = 600
		Me.picIcon.TabIndex = 2
		Me.picIcon.TabStop = False
		Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picIcon.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picIcon.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(98, 23)
		Me.cmdOK.Location = New System.Drawing.Point(283, 175)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Tag = "OK"
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdOK
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdSysInfo
		'
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me.cmdSysInfo.Size = New System.Drawing.Size(97, 23)
		Me.cmdSysInfo.Location = New System.Drawing.Point(284, 205)
		Me.cmdSysInfo.Caption = "&System Info..."
		Me.cmdSysInfo.TabIndex = 1
		Me.cmdSysInfo.Tag = "&System Info..."
		Me.cmdSysInfo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDescription
		'
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(273, 78)
		Me.lblDescription.Location = New System.Drawing.Point(70, 75)
		Me.lblDescription.Caption = "An Open Source IDE for Visual Basic Developers."
		Me.lblDescription.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblDescription.TabIndex = 6
		Me.lblDescription.Tag = "App Description"
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTitle
		'
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(273, 32)
		Me.lblTitle.Location = New System.Drawing.Point(70, 16)
		Me.lblTitle.Caption = "Application Title"
		Me.lblTitle.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblTitle.TabIndex = 5
		Me.lblTitle.Tag = "Application Title"
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line1_001
		'
		Me.Line1_001.Name = "Line1_001"
		Me.Line1_001.ParentForm = Me
		Me.Line1_001.Name6 = "Line1_001"
		Me.Line1_001.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line1_001.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSInsideSolid
		Me.Line1_001.X1 = 225
		Me.Line1_001.X2 = 5657
		Me.Line1_001.Y1 = 2430
		Me.Line1_001.Y2 = 2430
		'
		' Line1_000
		'
		Me.Line1_000.Name = "Line1_000"
		Me.Line1_000.ParentForm = Me
		Me.Line1_000.Name6 = "Line1_000"
		Me.Line1_000.BorderColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Line1_000.BorderWidth = 2
		Me.Line1_000.X1 = 240
		Me.Line1_000.X2 = 5657
		Me.Line1_000.Y1 = 2445
		Me.Line1_000.Y2 = 2445
		'
		' lblVersion
		'
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(273, 15)
		Me.lblVersion.Location = New System.Drawing.Point(70, 52)
		Me.lblVersion.Caption = "Version"
		Me.lblVersion.TabIndex = 4
		Me.lblVersion.Tag = "Version"
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDisclaimer
		'
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.lblDisclaimer.Size = New System.Drawing.Size(258, 55)
		Me.lblDisclaimer.Location = New System.Drawing.Point(17, 175)
		Me.lblDisclaimer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisclaimer.Caption = "Released under GPL. A project of Source Systems"
		Me.lblDisclaimer.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.lblDisclaimer.TabIndex = 3
		Me.lblDisclaimer.Tag = "Warning: ..."
		Me.lblDisclaimer.AutoSize = False
		Me.lblDisclaimer.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmAbout
		'
		Me.Name = "frmAbout"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "About ClassicVB"
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Tag = "About ClassicVB"
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ClientSize = New System.Drawing.Size(391, 235)

		Me.Controls.Add(picIcon)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdSysInfo)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblVersion)
		Me.Controls.Add(lblDisclaimer)
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
