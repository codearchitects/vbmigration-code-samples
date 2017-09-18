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
		Me.Line1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)(Line1_001)
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
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line1_001 As CodeArchitects.VB6Library.VB6Line

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.picIcon = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Line1_001 = New CodeArchitects.VB6Library.VB6Line()
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' picIcon
		'
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(36, 36)
		Me.picIcon.Location = New System.Drawing.Point(24, 16)
		Me.picIcon.AutoSize = True
		Me.picIcon.Picture = CType(resources.GetObject("picIcon.Picture"), System.Drawing.Image)
		Me.picIcon.ScaleHeight = 337.12
		Me.picIcon.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.picIcon.ScaleWidth = 337.12
		Me.picIcon.TabIndex = 1
		Me.picIcon.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picIcon.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picIcon.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(132, 39)
		Me.cmdOK.Location = New System.Drawing.Point(96, 144)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdOK
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(33, 17)
		Me.Label4.Location = New System.Drawing.Point(168, 88)
		Me.Label4.Caption = "2005"
		Me.Label4.TabIndex = 4
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.Location = New System.Drawing.Point(136, 56)
		Me.Label3.Caption = "By Vettolani Alberto"
		Me.Label3.TabIndex = 3
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 17)
		Me.Label1.Location = New System.Drawing.Point(112, 16)
		Me.Label1.Caption = "SUPER MASTER MIND 1.0.0"
		Me.Label1.TabIndex = 2
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
		Me.Line1_001.X1 = 0
		Me.Line1_001.X2 = 4648.307
		Me.Line1_001.Y1 = 1325.218
		Me.Line1_001.Y2 = 1325.218
		'
		' frmAbout
		'
		Me.Name = "frmAbout"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "About SUPER MASTER MIND"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.Moveable = False
		Me.ScaleHeight = 2008.534
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbUser
		Me.ScaleWidth = 4789.164
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(156, 129)
		Me.ClientSize = New System.Drawing.Size(340, 194)

		Me.Controls.Add(picIcon)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label1)
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
