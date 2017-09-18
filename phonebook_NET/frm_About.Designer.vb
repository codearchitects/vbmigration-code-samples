<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_About
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
	Public WithEvents btn_OK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lbl_About As CodeArchitects.VB6Library.VB6Label
	Public WithEvents img_About As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_About))
		Me.btn_OK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lbl_About = New CodeArchitects.VB6Library.VB6Label()
		Me.img_About = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.img_About, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' btn_OK
		'
		Me.btn_OK.Name = "btn_OK"
		Me.btn_OK.Size = New System.Drawing.Size(41, 33)
		Me.btn_OK.Location = New System.Drawing.Point(248, 33)
		Me.btn_OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_OK.Caption = "OK"
		Me.btn_OK.TabIndex = 0
		Me.btn_OK.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.btn_OK
		Me.btn_OK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' lbl_About
		'
		Me.lbl_About.Name = "lbl_About"
		Me.lbl_About.Size = New System.Drawing.Size(133, 48)
		Me.lbl_About.Location = New System.Drawing.Point(84, 25)
		Me.lbl_About.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_About.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lbl_About.AutoSize = True
		Me.lbl_About.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_About.Caption = "Phone Book Version 2.0 Copyroght(c) 2001 by Arbie Sarkissian"
		Me.lbl_About.TabIndex = 1
		Me.lbl_About.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' img_About
		'
		Me.img_About.Name = "img_About"
		Me.img_About.Size = New System.Drawing.Size(32, 32)
		Me.img_About.Location = New System.Drawing.Point(24, 33)
		Me.img_About.Picture = CType(resources.GetObject("img_About.Picture"), System.Drawing.Image)
		Me.img_About.Stretch = False
		'
		' frm_About
		'
		Me.Name = "frm_About"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "About Phone Book"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(312, 98)

		Me.Controls.Add(btn_OK)
		Me.Controls.Add(lbl_About)
		Me.Controls.Add(img_About)
		CType(Me.img_About, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
