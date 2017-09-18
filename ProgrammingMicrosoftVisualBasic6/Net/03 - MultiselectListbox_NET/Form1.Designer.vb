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
	Public WithEvents cmdInvertAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClearAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSelectAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents List2 As CodeArchitects.VB6Library.VB6CheckedListBox
	Public WithEvents List1 As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdInvertAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClearAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSelectAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.List2 = New CodeArchitects.VB6Library.VB6CheckedListBox()
		Me.List1 = New CodeArchitects.VB6Library.VB6ListBox()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdInvertAll
		'
		Me.cmdInvertAll.Name = "cmdInvertAll"
		Me.cmdInvertAll.Size = New System.Drawing.Size(89, 33)
		Me.cmdInvertAll.Location = New System.Drawing.Point(384, 136)
		Me.cmdInvertAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdInvertAll.Caption = "&Invert All"
		Me.cmdInvertAll.TabIndex = 6
		'
		' cmdClearAll
		'
		Me.cmdClearAll.Name = "cmdClearAll"
		Me.cmdClearAll.Size = New System.Drawing.Size(89, 33)
		Me.cmdClearAll.Location = New System.Drawing.Point(384, 88)
		Me.cmdClearAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClearAll.Caption = "&Clear All"
		Me.cmdClearAll.TabIndex = 5
		'
		' cmdSelectAll
		'
		Me.cmdSelectAll.Name = "cmdSelectAll"
		Me.cmdSelectAll.Size = New System.Drawing.Size(89, 33)
		Me.cmdSelectAll.Location = New System.Drawing.Point(384, 40)
		Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectAll.Caption = "&Select All"
		Me.cmdSelectAll.TabIndex = 4
		'
		' List2
		'
		Me.List2.Name = "List2"
		Me.List2.Size = New System.Drawing.Size(169, 228)
		Me.List2.Location = New System.Drawing.Point(200, 40)
		Me.List2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.List2.IntegralHeight = False
		Me.List2.TabIndex = 1
		'
		' List1
		'
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(161, 228)
		Me.List1.Location = New System.Drawing.Point(16, 40)
		Me.List1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.List1.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.List1.TabIndex = 0
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(89, 41)
		Me.Label3.Location = New System.Drawing.Point(384, 232)
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label3.Caption = "Try deselect the first item"
		Me.Label3.TabIndex = 7
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(161, 25)
		Me.Label2.Location = New System.Drawing.Point(200, 16)
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Caption = "Style = 1-CheckBox"
		Me.Label2.TabIndex = 3
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 25)
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Style = 0-Standard"
		Me.Label1.TabIndex = 2
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Multiple Selection Listbox Controls"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(492, 302)

		Me.Controls.Add(cmdInvertAll)
		Me.Controls.Add(cmdClearAll)
		Me.Controls.Add(cmdSelectAll)
		Me.Controls.Add(List2)
		Me.Controls.Add(List1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
