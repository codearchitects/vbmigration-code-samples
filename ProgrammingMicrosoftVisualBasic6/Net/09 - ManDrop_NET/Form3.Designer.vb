<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form3
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
	Public WithEvents File1 As CodeArchitects.VB6Library.VB6FileListBox
	Public WithEvents Dir1 As CodeArchitects.VB6Library.VB6DirListBox
	Public WithEvents Drive1 As CodeArchitects.VB6Library.VB6DriveListBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.File1 = New CodeArchitects.VB6Library.VB6FileListBox()
		Me.Dir1 = New CodeArchitects.VB6Library.VB6DirListBox()
		Me.Drive1 = New CodeArchitects.VB6Library.VB6DriveListBox()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' File1
		'
		Me.File1.Name = "File1"
		Me.File1.Size = New System.Drawing.Size(201, 162)
		Me.File1.Location = New System.Drawing.Point(200, 8)
		Me.File1.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.File1.TabIndex = 2
		'
		' Dir1
		'
		Me.Dir1.Name = "Dir1"
		Me.Dir1.Size = New System.Drawing.Size(185, 126)
		Me.Dir1.Location = New System.Drawing.Point(8, 40)
		Me.Dir1.TabIndex = 1
		'
		' Drive1
		'
		Me.Drive1.Name = "Drive1"
		Me.Drive1.Size = New System.Drawing.Size(185, 21)
		Me.Drive1.Location = New System.Drawing.Point(8, 8)
		Me.Drive1.TabIndex = 0
		'
		' Form3
		'
		Me.Name = "Form3"
		Me.Caption = "Filename Drag-And-Drop Source"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(418, 188)

		Me.Controls.Add(File1)
		Me.Controls.Add(Dir1)
		Me.Controls.Add(Drive1)
		CType(Me.File1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
