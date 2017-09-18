<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInfo
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
		Me.Image1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(Image1_000)
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
	Public Image1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdOk As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Image1_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblInfo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInfo))
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdOk = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Image1_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.lblInfo = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture1.SuspendLayout()
		CType(Me.Image1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(369, 2)
		Me.Frame1.Location = New System.Drawing.Point(8, 224)
		Me.Frame1.TabIndex = 3
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOk
		'
		Me.cmdOk.Name = "cmdOk"
		Me.cmdOk.Size = New System.Drawing.Size(81, 25)
		Me.cmdOk.Location = New System.Drawing.Point(296, 232)
		Me.cmdOk.Caption = "&OK"
		Me.cmdOk.TabIndex = 2
		Me.cmdOk.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdOk
		Me.AcceptButton = Me.cmdOk
		Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(73, 209)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.TabIndex = 0
		Me.Picture1.TabStop = False
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1_000
		'
		Me.Image1_000.Name = "Image1_000"
		Me.Image1_000.Size = New System.Drawing.Size(32, 32)
		Me.Image1_000.Location = New System.Drawing.Point(20, 152)
		Me.Image1_000.Stretch = True
		Me.Image1_000.Picture = CType(resources.GetObject("Image1_000.Picture"), System.Drawing.Image)
		'
		' lblInfo
		'
		Me.lblInfo.Name = "lblInfo"
		Me.lblInfo.Size = New System.Drawing.Size(281, 177)
		Me.lblInfo.Location = New System.Drawing.Point(88, 40)
		Me.lblInfo.TabIndex = 5
		Me.lblInfo.AutoSize = False
		Me.lblInfo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(289, 33)
		Me.Label2.Location = New System.Drawing.Point(88, 8)
		Me.Label2.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Hagelin BC-52  Cipher Machine"
		Me.Label2.TabIndex = 4
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(257, 57)
		Me.Label1.Location = New System.Drawing.Point(88, 136)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmInfo
		'
		Me.Name = "frmInfo"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedToolWindow
		Me.Caption = " About BC-52"
		Me.ControlBox = False
		Me.Icon = Nothing
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 19)
		Me.ClientSize = New System.Drawing.Size(384, 262)

		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Image1_000)
		Me.Controls.Add(lblInfo)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.Image1_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
