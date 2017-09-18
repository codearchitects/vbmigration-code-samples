<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
	Public WithEvents fraMainFrame As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents picLogo As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblLicenseTo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProductName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCompanyProduct As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPlatform As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblVersion As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWarning As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCompany As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCopyright As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.fraMainFrame = New CodeArchitects.VB6Library.VB6Frame()
		Me.picLogo = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblLicenseTo = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProductName = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCompanyProduct = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPlatform = New CodeArchitects.VB6Library.VB6Label()
		Me.lblVersion = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWarning = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCompany = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCopyright = New CodeArchitects.VB6Library.VB6Label()
		Me.fraMainFrame.SuspendLayout()
		Me.SuspendLayout()
		'
		' fraMainFrame
		'
		Me.fraMainFrame.Name = "fraMainFrame"
		Me.fraMainFrame.Size = New System.Drawing.Size(492, 306)
		Me.fraMainFrame.Location = New System.Drawing.Point(3, -1)
		Me.fraMainFrame.TabIndex = 0
		Me.fraMainFrame.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picLogo
		'
		Me.picLogo.Name = "picLogo"
		Me.picLogo.Size = New System.Drawing.Size(121, 159)
		Me.picLogo.Location = New System.Drawing.Point(34, 57)
		Me.picLogo.Picture = CType(resources.GetObject("picLogo.Picture"), System.Drawing.Image)
		Me.picLogo.TabIndex = 2
		Me.picLogo.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picLogo.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picLogo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLicenseTo
		'
		Me.lblLicenseTo.Name = "lblLicenseTo"
		Me.lblLicenseTo.Size = New System.Drawing.Size(457, 17)
		Me.lblLicenseTo.Location = New System.Drawing.Point(18, 20)
		Me.lblLicenseTo.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLicenseTo.Caption = "LicenseTo"
		Me.lblLicenseTo.TabIndex = 1
		Me.lblLicenseTo.Tag = "LicenseTo"
		Me.lblLicenseTo.AutoSize = False
		Me.lblLicenseTo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblProductName
		'
		Me.lblProductName.Name = "lblProductName"
		Me.lblProductName.Size = New System.Drawing.Size(146, 48)
		Me.lblProductName.Location = New System.Drawing.Point(178, 80)
		Me.lblProductName.Font = New System.Drawing.Font("Arial", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProductName.AutoSize = True
		Me.lblProductName.Caption = "Product"
		Me.lblProductName.TabIndex = 9
		Me.lblProductName.Tag = "Product"
		Me.lblProductName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblCompanyProduct
		'
		Me.lblCompanyProduct.Name = "lblCompanyProduct"
		Me.lblCompanyProduct.Size = New System.Drawing.Size(200, 29)
		Me.lblCompanyProduct.Location = New System.Drawing.Point(167, 51)
		Me.lblCompanyProduct.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCompanyProduct.AutoSize = True
		Me.lblCompanyProduct.Caption = "CompanyProduct"
		Me.lblCompanyProduct.TabIndex = 8
		Me.lblCompanyProduct.Tag = "CompanyProduct"
		Me.lblCompanyProduct.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblPlatform
		'
		Me.lblPlatform.Name = "lblPlatform"
		Me.lblPlatform.Size = New System.Drawing.Size(76, 24)
		Me.lblPlatform.Location = New System.Drawing.Point(391, 160)
		Me.lblPlatform.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlatform.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblPlatform.AutoSize = True
		Me.lblPlatform.Caption = "Platform"
		Me.lblPlatform.TabIndex = 7
		Me.lblPlatform.Tag = "Platform"
		Me.lblPlatform.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblVersion
		'
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(62, 20)
		Me.lblVersion.Location = New System.Drawing.Point(405, 184)
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblVersion.AutoSize = True
		Me.lblVersion.Caption = "Version"
		Me.lblVersion.TabIndex = 6
		Me.lblVersion.Tag = "Version"
		Me.lblVersion.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblWarning
		'
		Me.lblWarning.Name = "lblWarning"
		Me.lblWarning.Size = New System.Drawing.Size(457, 13)
		Me.lblWarning.Location = New System.Drawing.Point(20, 248)
		Me.lblWarning.Caption = "Warning"
		Me.lblWarning.TabIndex = 3
		Me.lblWarning.Tag = "Warning"
		Me.lblWarning.AutoSize = False
		Me.lblWarning.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblCompany
		'
		Me.lblCompany.Name = "lblCompany"
		Me.lblCompany.Size = New System.Drawing.Size(161, 17)
		Me.lblCompany.Location = New System.Drawing.Point(314, 222)
		Me.lblCompany.Caption = "Company"
		Me.lblCompany.TabIndex = 5
		Me.lblCompany.Tag = "Company"
		Me.lblCompany.AutoSize = False
		Me.lblCompany.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblCopyright
		'
		Me.lblCopyright.Name = "lblCopyright"
		Me.lblCopyright.Size = New System.Drawing.Size(161, 17)
		Me.lblCopyright.Location = New System.Drawing.Point(314, 208)
		Me.lblCopyright.Caption = "Copyright"
		Me.lblCopyright.TabIndex = 4
		Me.lblCopyright.Tag = "Copyright"
		Me.lblCopyright.AutoSize = False
		Me.lblCopyright.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmSplash
		'
		Me.Name = "frmSplash"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.ControlBox = False
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Visible = False
		Me.Location = New System.Drawing.Point(3, 3)
		Me.ClientSize = New System.Drawing.Size(497, 307)

		Me.Controls.Add(fraMainFrame)
		Me.fraMainFrame.Controls.Add(picLogo)
		Me.fraMainFrame.Controls.Add(lblLicenseTo)
		Me.fraMainFrame.Controls.Add(lblProductName)
		Me.fraMainFrame.Controls.Add(lblCompanyProduct)
		Me.fraMainFrame.Controls.Add(lblPlatform)
		Me.fraMainFrame.Controls.Add(lblVersion)
		Me.fraMainFrame.Controls.Add(lblWarning)
		Me.fraMainFrame.Controls.Add(lblCompany)
		Me.fraMainFrame.Controls.Add(lblCopyright)
		Me.fraMainFrame.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
