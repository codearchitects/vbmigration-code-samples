<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSource
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
	Public WithEvents text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSource))
		Me.text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' text1
		'
		Me.text1.Name = "text1"
		Me.text1.Size = New System.Drawing.Size(601, 489)
		Me.text1.Location = New System.Drawing.Point(8, 8)
		Me.text1.Font = New System.Drawing.Font("Lucida Console", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.text1.MultiLine = -1
		Me.text1.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.text1.TabIndex = 1
		Me.text1.Text = "Text1"
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(73, 33)
		Me.Command1.Location = New System.Drawing.Point(264, 504)
		Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Caption = "&Close"
		Me.Command1.TabIndex = 0
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmSource
		'
		Me.Name = "frmSource"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Source"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.Location = New System.Drawing.Point(345, 252)
		Me.ClientSize = New System.Drawing.Size(619, 547)

		Me.Controls.Add(text1)
		Me.Controls.Add(Command1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
