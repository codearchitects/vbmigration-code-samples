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
	Public WithEvents lblVersion As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.lblVersion = New CodeArchitects.VB6Library.VB6Label()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' lblVersion
		'
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(41, 17)
		Me.lblVersion.Location = New System.Drawing.Point(48, 116)
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblVersion.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblVersion.Caption = "X.X.X"
		Me.lblVersion.TabIndex = 1
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(381, 17)
		Me.lblStatus.Location = New System.Drawing.Point(8, 176)
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblStatus.Caption = "Please wait"
		Me.lblStatus.TabIndex = 0
		Me.lblStatus.AutoSize = False
		Me.lblStatus.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(400, 200)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' frmSplash
		'
		Me.Name = "frmSplash"
		Me.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "splash form"
		Me.ShowInTaskbar = False
		Me.Location = New System.Drawing.Point(334, 391)
		Me.ClientSize = New System.Drawing.Size(399, 199)

		Me.Controls.Add(lblVersion)
		Me.Controls.Add(lblStatus)
		Me.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
