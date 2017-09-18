<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Public WithEvents lblBackToVB As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDontCare As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTellMe As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.lblBackToVB = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDontCare = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTellMe = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' lblBackToVB
		'
		Me.lblBackToVB.Name = "lblBackToVB"
		Me.lblBackToVB.Size = New System.Drawing.Size(229, 20)
		Me.lblBackToVB.Location = New System.Drawing.Point(32, 272)
		Me.lblBackToVB.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBackToVB.AutoSize = True
		Me.lblBackToVB.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblBackToVB.Caption = "Back to VB normal programming"
		Me.lblBackToVB.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblBackToVB.MouseIcon = CType(resources.GetObject("lblBackToVB.MouseIcon"), System.Drawing.Bitmap)
		Me.lblBackToVB.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.lblBackToVB.TabIndex = 4
		'
		' lblDontCare
		'
		Me.lblDontCare.Name = "lblDontCare"
		Me.lblDontCare.Size = New System.Drawing.Size(131, 20)
		Me.lblDontCare.Location = New System.Drawing.Point(32, 232)
		Me.lblDontCare.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDontCare.AutoSize = True
		Me.lblDontCare.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblDontCare.Caption = "I couldn't care less"
		Me.lblDontCare.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblDontCare.MouseIcon = CType(resources.GetObject("lblDontCare.MouseIcon"), System.Drawing.Bitmap)
		Me.lblDontCare.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.lblDontCare.TabIndex = 3
		'
		' lblTellMe
		'
		Me.lblTellMe.Name = "lblTellMe"
		Me.lblTellMe.Size = New System.Drawing.Size(145, 20)
		Me.lblTellMe.Location = New System.Drawing.Point(32, 192)
		Me.lblTellMe.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTellMe.AutoSize = True
		Me.lblTellMe.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblTellMe.Caption = "Tell me more, please"
		Me.lblTellMe.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblTellMe.MouseIcon = CType(resources.GetObject("lblTellMe.MouseIcon"), System.Drawing.Bitmap)
		Me.lblTellMe.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.lblTellMe.TabIndex = 2
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(441, 105)
		Me.Label2.Location = New System.Drawing.Point(32, 72)
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "You don't need to learn HTML language to create pages that appear as they were download from a Web server. In fact, all you need is a bunch of Label controls and some code in their Click and MouseMove events."
		Me.Label2.TabIndex = 1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(393, 49)
		Me.Label1.Location = New System.Drawing.Point(32, 24)
		Me.Label1.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "This is *NOT* an HTML page"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Caption = "Form1"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(610, 332)

		Me.Controls.Add(lblBackToVB)
		Me.Controls.Add(lblDontCare)
		Me.Controls.Add(lblTellMe)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
