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
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstRight As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdBackAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdBack As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMoveAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstLeft As CodeArchitects.VB6Library.VB6ListBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstRight = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdBackAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdBack = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMoveAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstLeft = New CodeArchitects.VB6Library.VB6ListBox()
		Me.SuspendLayout()
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(73, 33)
		Me.cmdOK.Location = New System.Drawing.Point(472, 24)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 6
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' lstRight
		'
		Me.lstRight.Name = "lstRight"
		Me.lstRight.Size = New System.Drawing.Size(169, 196)
		Me.lstRight.Location = New System.Drawing.Point(280, 24)
		Me.lstRight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstRight.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.lstRight.Sorted = True
		Me.lstRight.TabIndex = 5
		'
		' cmdBackAll
		'
		Me.cmdBackAll.Name = "cmdBackAll"
		Me.cmdBackAll.Size = New System.Drawing.Size(41, 33)
		Me.cmdBackAll.Location = New System.Drawing.Point(216, 184)
		Me.cmdBackAll.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBackAll.Caption = "<<"
		Me.cmdBackAll.TabIndex = 4
		'
		' cmdBack
		'
		Me.cmdBack.Name = "cmdBack"
		Me.cmdBack.Size = New System.Drawing.Size(41, 33)
		Me.cmdBack.Location = New System.Drawing.Point(216, 144)
		Me.cmdBack.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBack.Caption = "<"
		Me.cmdBack.TabIndex = 3
		'
		' cmdMoveAll
		'
		Me.cmdMoveAll.Name = "cmdMoveAll"
		Me.cmdMoveAll.Size = New System.Drawing.Size(41, 33)
		Me.cmdMoveAll.Location = New System.Drawing.Point(216, 64)
		Me.cmdMoveAll.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMoveAll.Caption = ">>"
		Me.cmdMoveAll.TabIndex = 2
		'
		' cmdMove
		'
		Me.cmdMove.Name = "cmdMove"
		Me.cmdMove.Size = New System.Drawing.Size(41, 33)
		Me.cmdMove.Location = New System.Drawing.Point(216, 24)
		Me.cmdMove.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove.Caption = ">"
		Me.cmdMove.TabIndex = 1
		'
		' lstLeft
		'
		Me.lstLeft.Name = "lstLeft"
		Me.lstLeft.Size = New System.Drawing.Size(169, 196)
		Me.lstLeft.Location = New System.Drawing.Point(24, 24)
		Me.lstLeft.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstLeft.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.lstLeft.Sorted = True
		Me.lstLeft.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Mutually Exclusive Listbox controls"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(563, 249)

		Me.Controls.Add(cmdOK)
		Me.Controls.Add(lstRight)
		Me.Controls.Add(cmdBackAll)
		Me.Controls.Add(cmdBack)
		Me.Controls.Add(cmdMoveAll)
		Me.Controls.Add(cmdMove)
		Me.Controls.Add(lstLeft)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
