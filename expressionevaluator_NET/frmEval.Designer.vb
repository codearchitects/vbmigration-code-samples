<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEval
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
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdEval As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEval))
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdEval = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(505, 43)
		Me.Text1.Location = New System.Drawing.Point(8, 8)
		Me.Text1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.BackColor = FromOleColor6(CInt(&H00404040))
		Me.Text1.ForeColor = FromOleColor6(CInt(&H0000C000))
		Me.Text1.TabIndex = 1
		Me.Text1.Text = "1+2+3+4+(1*2*3^(3-1)/18-1/2)"
		'
		' cmdEval
		'
		Me.cmdEval.Name = "cmdEval"
		Me.cmdEval.Size = New System.Drawing.Size(217, 41)
		Me.cmdEval.Location = New System.Drawing.Point(152, 56)
		Me.cmdEval.Caption = "Evaluate"
		Me.cmdEval.TabIndex = 0
		Me.cmdEval.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.cmdEval
		Me.cmdEval.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmEval
		'
		Me.Name = "frmEval"
		Me.Caption = "Expression evaluator - CopyrightÃ‚Â© 1999 Tretyakov Konstantin"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(519, 102)

		Me.Controls.Add(Text1)
		Me.Controls.Add(cmdEval)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
