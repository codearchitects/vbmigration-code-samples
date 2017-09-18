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
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Picture1.SuspendLayout()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(417, 25)
		Me.Picture1.Location = New System.Drawing.Point(0, 272)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 0
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(273, 25)
		Me.Label1.Location = New System.Drawing.Point(136, 5)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Copyright © NaparanSoft, 2004. All Rights Reserved."
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(64, 64)
		Me.Image1.Location = New System.Drawing.Point(336, 16)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BorderWidth = 2
		Me.Shape1.Height = 4455
		Me.Shape1.Left = 0
		Me.Shape1.Top = 0
		Me.Shape1.Width = 6255
		'
		' frmSplash
		'
		Me.Name = "frmSplash"
		Me.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.ControlBox = False
		Me.Icon = Nothing
		Me.KeyPreview = True
		Me.MaxButton = False
		Me.MinButton = False
		Me.Picture = CType(resources.GetObject("$this.Picture"), System.Drawing.Image)
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(15, 92)
		Me.ClientSize = New System.Drawing.Size(416, 297)

		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Label1)
		Me.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
