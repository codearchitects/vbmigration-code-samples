<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWaves
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
		Me.SurfaceImage = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(SurfaceImage_001)
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
	Public SurfaceImage As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WithEvents txtCounter As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdExit As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDisplay As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCreate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Pict As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblCounter As CodeArchitects.VB6Library.VB6Label
	Public WithEvents SurfaceImage_001 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtCounter = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdExit = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDisplay = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCreate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Pict = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblCounter = New CodeArchitects.VB6Library.VB6Label()
		Me.SurfaceImage_001 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.SurfaceImage_001, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' txtCounter
		'
		Me.txtCounter.Name = "txtCounter"
		Me.txtCounter.Size = New System.Drawing.Size(497, 241)
		Me.txtCounter.Location = New System.Drawing.Point(24, 8)
		Me.txtCounter.Font = New System.Drawing.Font("Arial", 192!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCounter.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtCounter.BackColor = FromOleColor6(CInt(&H80000008))
		Me.txtCounter.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.txtCounter.ForeColor = FromOleColor6(CInt(&H80000009))
		Me.txtCounter.TabIndex = 4
		Me.txtCounter.Visible = False
		'
		' cmdExit
		'
		Me.cmdExit.Name = "cmdExit"
		Me.cmdExit.Size = New System.Drawing.Size(41, 25)
		Me.cmdExit.Location = New System.Drawing.Point(480, 440)
		Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.Caption = "Exit"
		Me.cmdExit.TabIndex = 3
		Me.cmdExit.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdDisplay
		'
		Me.cmdDisplay.Name = "cmdDisplay"
		Me.cmdDisplay.Size = New System.Drawing.Size(97, 25)
		Me.cmdDisplay.Location = New System.Drawing.Point(272, 440)
		Me.cmdDisplay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDisplay.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.cmdDisplay.Caption = "Run"
		Me.cmdDisplay.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdDisplay.TabIndex = 2
		'
		' cmdCreate
		'
		Me.cmdCreate.Name = "cmdCreate"
		Me.cmdCreate.Size = New System.Drawing.Size(105, 25)
		Me.cmdCreate.Location = New System.Drawing.Point(160, 440)
		Me.cmdCreate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCreate.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.cmdCreate.Caption = "Create"
		Me.cmdCreate.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdCreate.TabIndex = 1
		'
		' Pict
		'
		Me.Pict.Name = "Pict"
		Me.Pict.Size = New System.Drawing.Size(513, 409)
		Me.Pict.Location = New System.Drawing.Point(16, 0)
		Me.Pict.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pict.AutoRedraw = True
		Me.Pict.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Pict.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Pict.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.Pict.TabIndex = 0
		Me.Pict.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Pict.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' lblCounter
		'
		Me.lblCounter.Name = "lblCounter"
		Me.lblCounter.Size = New System.Drawing.Size(497, 161)
		Me.lblCounter.Location = New System.Drawing.Point(24, 248)
		Me.lblCounter.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCounter.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblCounter.BackColor = FromOleColor6(CInt(&H80000008))
		Me.lblCounter.ForeColor = FromOleColor6(CInt(&H8000000E))
		Me.lblCounter.TabIndex = 5
		Me.lblCounter.Visible = False
		Me.lblCounter.AutoSize = False
		'
		' SurfaceImage_001
		'
		Me.SurfaceImage_001.Name = "SurfaceImage_001"
		Me.SurfaceImage_001.Size = New System.Drawing.Size(57, 49)
		Me.SurfaceImage_001.Location = New System.Drawing.Point(16, 424)
		Me.SurfaceImage_001.Visible = False
		Me.SurfaceImage_001.Stretch = False
		'
		' frmWaves
		'
		Me.Name = "frmWaves"
		Me.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Caption = "Waves"
		Me.Location = New System.Drawing.Point(191, 127)
		Me.ClientSize = New System.Drawing.Size(542, 485)

		Me.Controls.Add(txtCounter)
		Me.Controls.Add(cmdExit)
		Me.Controls.Add(cmdDisplay)
		Me.Controls.Add(cmdCreate)
		Me.Controls.Add(Pict)
		Me.Controls.Add(lblCounter)
		Me.Controls.Add(SurfaceImage_001)
		CType(Me.SurfaceImage_001, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
