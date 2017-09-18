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
	Public WithEvents cmdEnumValues As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents List1 As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdEnumKeys As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCreate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdVbSettings As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMathProcessor As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblDescription As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdEnumValues = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.List1 = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdEnumKeys = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCreate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdVbSettings = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMathProcessor = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblDescription = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdEnumValues
		'
		Me.cmdEnumValues.Name = "cmdEnumValues"
		Me.cmdEnumValues.Size = New System.Drawing.Size(113, 25)
		Me.cmdEnumValues.Location = New System.Drawing.Point(8, 176)
		Me.cmdEnumValues.Caption = "Enum Values"
		Me.cmdEnumValues.TabIndex = 6
		'
		' List1
		'
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(417, 196)
		Me.List1.Location = New System.Drawing.Point(136, 16)
		Me.List1.Sorted = True
		Me.List1.TabIndex = 4
		'
		' cmdEnumKeys
		'
		Me.cmdEnumKeys.Name = "cmdEnumKeys"
		Me.cmdEnumKeys.Size = New System.Drawing.Size(113, 25)
		Me.cmdEnumKeys.Location = New System.Drawing.Point(8, 128)
		Me.cmdEnumKeys.Caption = "Enum Classes"
		Me.cmdEnumKeys.TabIndex = 3
		'
		' cmdCreate
		'
		Me.cmdCreate.Name = "cmdCreate"
		Me.cmdCreate.Size = New System.Drawing.Size(113, 25)
		Me.cmdCreate.Location = New System.Drawing.Point(8, 80)
		Me.cmdCreate.Caption = "Create key/value"
		Me.cmdCreate.TabIndex = 2
		'
		' cmdVbSettings
		'
		Me.cmdVbSettings.Name = "cmdVbSettings"
		Me.cmdVbSettings.Size = New System.Drawing.Size(113, 25)
		Me.cmdVbSettings.Location = New System.Drawing.Point(8, 48)
		Me.cmdVbSettings.Caption = "VB Settings"
		Me.cmdVbSettings.TabIndex = 1
		'
		' cmdMathProcessor
		'
		Me.cmdMathProcessor.Name = "cmdMathProcessor"
		Me.cmdMathProcessor.Size = New System.Drawing.Size(113, 25)
		Me.cmdMathProcessor.Location = New System.Drawing.Point(8, 16)
		Me.cmdMathProcessor.Caption = "Math Processor"
		Me.cmdMathProcessor.TabIndex = 0
		'
		' lblDescription
		'
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(425, 65)
		Me.lblDescription.Location = New System.Drawing.Point(136, 216)
		Me.lblDescription.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblDescription.TabIndex = 5
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Registry Functions Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(565, 301)

		Me.Controls.Add(cmdEnumValues)
		Me.Controls.Add(List1)
		Me.Controls.Add(cmdEnumKeys)
		Me.Controls.Add(cmdCreate)
		Me.Controls.Add(cmdVbSettings)
		Me.Controls.Add(cmdMathProcessor)
		Me.Controls.Add(lblDescription)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
