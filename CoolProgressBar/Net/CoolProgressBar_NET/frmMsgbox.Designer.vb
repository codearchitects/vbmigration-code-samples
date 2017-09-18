<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMsgbox
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
	Public WithEvents lblEmail As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblVisitPSC As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents lblOk As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape4 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMsgbox))
		Me.lblEmail = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblVisitPSC = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.lblOk = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape4 = New CodeArchitects.VB6Library.VB6Shape()
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' lblEmail
		'
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(145, 25)
		Me.lblEmail.Location = New System.Drawing.Point(116, 128)
		Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmail.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblEmail.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblEmail.Caption = "jotaf98@hotmail.com"
		Me.lblEmail.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.lblEmail.TabIndex = 6
		Me.lblEmail.AutoSize = False
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(57, 25)
		Me.Label4.Location = New System.Drawing.Point(52, 128)
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "E-mail:"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H0080C0FF))
		Me.Label4.TabIndex = 5
		Me.Label4.AutoSize = False
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(265, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 112)
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "(João F. S. Henriques)"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H0080C0FF))
		Me.Label2.TabIndex = 4
		Me.Label2.AutoSize = False
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(265, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 96)
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Made by Jotaf98"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H0080C0FF))
		Me.Label1.TabIndex = 3
		Me.Label1.AutoSize = False
		'
		' lblVisitPSC
		'
		Me.lblVisitPSC.Name = "lblVisitPSC"
		Me.lblVisitPSC.Size = New System.Drawing.Size(201, 17)
		Me.lblVisitPSC.Location = New System.Drawing.Point(96, 184)
		Me.lblVisitPSC.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVisitPSC.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblVisitPSC.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblVisitPSC.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblVisitPSC.Caption = "Visit Planet Source Code"
		Me.lblVisitPSC.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.lblVisitPSC.TabIndex = 2
		Me.lblVisitPSC.AutoSize = False
		'
		' Shape2
		'
		Me.Shape2.Name = "Shape2"
		Me.Shape2.ParentForm = Me
		Me.Shape2.Name6 = "Shape2"
		Me.Shape2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape2.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape2.Height = 255
		Me.Shape2.Left = 1440
		Me.Shape2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape2.Top = 2760
		Me.Shape2.Width = 3015
		'
		' lblOk
		'
		Me.lblOk.Name = "lblOk"
		Me.lblOk.Size = New System.Drawing.Size(65, 17)
		Me.lblOk.Location = New System.Drawing.Point(16, 184)
		Me.lblOk.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOk.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblOk.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblOk.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblOk.Caption = "OK"
		Me.lblOk.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.lblOk.TabIndex = 1
		Me.lblOk.AutoSize = False
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape1.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape1.Height = 255
		Me.Shape1.Left = 240
		Me.Shape1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape1.Top = 2760
		Me.Shape1.Width = 975
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(265, 57)
		Me.Label3.Location = New System.Drawing.Point(24, 24)
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "If you found this control useful, please vote for me on Planet Source Code's Contest!"
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.Label3.TabIndex = 0
		Me.Label3.AutoSize = False
		'
		' Shape4
		'
		Me.Shape4.Name = "Shape4"
		Me.Shape4.ParentForm = Me
		Me.Shape4.Name6 = "Shape4"
		Me.Shape4.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Shape4.BorderColor = FromOleColor6(CInt(&H000080FF))
		Me.Shape4.Height = 2175
		Me.Shape4.Left = 240
		Me.Shape4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape4.Top = 240
		Me.Shape4.Width = 4215
		'
		' frmMsgbox
		'
		Me.Name = "frmMsgbox"
		Me.BackColor = FromOleColor6(CInt(&H00000000))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(313, 217)

		Me.Controls.Add(lblEmail)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblVisitPSC)
		Me.Controls.Add(lblOk)
		Me.Controls.Add(Label3)
		CType(Me.Shape2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
