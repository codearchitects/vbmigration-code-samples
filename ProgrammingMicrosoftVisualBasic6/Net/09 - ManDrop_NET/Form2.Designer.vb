<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form2
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
		Me.optDropMode = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optDropMode_001, optDropMode_000)
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
	Public optDropMode As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents optDropMode_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optDropMode_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents cmdSeparator As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtEditor As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
		Me.optDropMode_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optDropMode_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.cmdSeparator = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtEditor = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' optDropMode_001
		'
		Me.optDropMode_001.Name = "optDropMode_001"
		Me.optDropMode_001.Size = New System.Drawing.Size(313, 17)
		Me.optDropMode_001.Location = New System.Drawing.Point(232, 328)
		Me.optDropMode_001.Caption = "Drop File &Contents (single file only)"
		Me.optDropMode_001.TabIndex = 4
		'
		' optDropMode_000
		'
		Me.optDropMode_000.Name = "optDropMode_000"
		Me.optDropMode_000.Size = New System.Drawing.Size(217, 17)
		Me.optDropMode_000.Location = New System.Drawing.Point(16, 328)
		Me.optDropMode_000.Caption = "Drop File &Names"
		Me.optDropMode_000.TabIndex = 3
		Me.optDropMode_000.Value = True
		'
		' cmdSeparator
		'
		Me.cmdSeparator.Name = "cmdSeparator"
		Me.cmdSeparator.Size = New System.Drawing.Size(81, 41)
		Me.cmdSeparator.Location = New System.Drawing.Point(8, 16)
		Me.cmdSeparator.Caption = "Change &Separator"
		Me.cmdSeparator.TabIndex = 2
		'
		' txtEditor
		'
		Me.txtEditor.Name = "txtEditor"
		Me.txtEditor.Size = New System.Drawing.Size(545, 241)
		Me.txtEditor.Location = New System.Drawing.Point(0, 80)
		Me.txtEditor.MultiLine = -1
		Me.txtEditor.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtEditor.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.txtEditor.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtEditor.TabIndex = 0
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(457, 65)
		Me.Label1.Location = New System.Drawing.Point(104, 8)
		Me.Label1.Caption = "You can drag any portion of text into this textbox control, and you can also drag one or more file names from Windows Explorer. If you keep the Ctrl key pressed, file names are included with their complete paths. Click the button to select the separator character among multiple file names (default is CR+LF)."
		Me.Label1.TabIndex = 1
		'
		' Form2
		'
		Me.Name = "Form2"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Drag-And-Drop Batch File Editor"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(560, 348)

		Me.Controls.Add(optDropMode_001)
		Me.Controls.Add(optDropMode_000)
		Me.Controls.Add(cmdSeparator)
		Me.Controls.Add(txtEditor)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
