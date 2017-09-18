<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MenuFRM
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
	Public WithEvents northTOsouthLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents leftTOrightLBL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MenuFRM))
		Me.northTOsouthLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.leftTOrightLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' northTOsouthLBL
		'
		Me.northTOsouthLBL.Name = "northTOsouthLBL"
		Me.northTOsouthLBL.Size = New System.Drawing.Size(105, 25)
		Me.northTOsouthLBL.Location = New System.Drawing.Point(8, 40)
		Me.northTOsouthLBL.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.northTOsouthLBL.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.northTOsouthLBL.Caption = "North to South"
		Me.northTOsouthLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.northTOsouthLBL.TabIndex = 1
		Me.northTOsouthLBL.AutoSize = False
		Me.northTOsouthLBL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' leftTOrightLBL
		'
		Me.leftTOrightLBL.Name = "leftTOrightLBL"
		Me.leftTOrightLBL.Size = New System.Drawing.Size(105, 25)
		Me.leftTOrightLBL.Location = New System.Drawing.Point(8, 8)
		Me.leftTOrightLBL.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.leftTOrightLBL.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.leftTOrightLBL.Caption = "Left to Right"
		Me.leftTOrightLBL.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.leftTOrightLBL.TabIndex = 0
		Me.leftTOrightLBL.AutoSize = False
		Me.leftTOrightLBL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(129, 73)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Stretch = True
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		'
		' MenuFRM
		'
		Me.Name = "MenuFRM"
		Me.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "Form1"
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(120, 73)

		Me.Controls.Add(northTOsouthLBL)
		Me.Controls.Add(leftTOrightLBL)
		Me.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
