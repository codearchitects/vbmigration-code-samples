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
	Public WithEvents cmdAddEditor As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdAddTreeView As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdAddEditor = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdAddTreeView = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' cmdAddEditor
		'
		Me.cmdAddEditor.Name = "cmdAddEditor"
		Me.cmdAddEditor.Size = New System.Drawing.Size(273, 25)
		Me.cmdAddEditor.Location = New System.Drawing.Point(264, 0)
		Me.cmdAddEditor.Caption = "Add a a windowless Editor"
		Me.cmdAddEditor.TabIndex = 1
		'
		' cmdAddTreeView
		'
		Me.cmdAddTreeView.Name = "cmdAddTreeView"
		Me.cmdAddTreeView.Size = New System.Drawing.Size(265, 25)
		Me.cmdAddTreeView.Location = New System.Drawing.Point(0, 0)
		Me.cmdAddTreeView.Caption = "Add a TreeView"
		Me.cmdAddTreeView.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Dynamic Control Creation Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(542, 316)

		Me.Controls.Add(cmdAddEditor)
		Me.Controls.Add(cmdAddTreeView)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
