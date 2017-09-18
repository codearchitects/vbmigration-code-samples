<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRecord
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
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUpdate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdAddNew As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents uctProductsSingleRecord1 As Project1.uctProductsSingleRecord
	Public WithEvents cmdNext As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrevious As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUpdate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdAddNew = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.uctProductsSingleRecord1 = New Project1.uctProductsSingleRecord()
		Me.cmdNext = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrevious = New CodeArchitects.VB6Library.VB6CommandButton()
		CType(Me.uctProductsSingleRecord1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(65, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(272, 320)
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.TabIndex = 5
		'
		' cmdUpdate
		'
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdUpdate.Size = New System.Drawing.Size(65, 25)
		Me.cmdUpdate.Location = New System.Drawing.Point(208, 320)
		Me.cmdUpdate.Caption = "&Update"
		Me.cmdUpdate.TabIndex = 4
		'
		' cmdAddNew
		'
		Me.cmdAddNew.Name = "cmdAddNew"
		Me.cmdAddNew.Size = New System.Drawing.Size(65, 25)
		Me.cmdAddNew.Location = New System.Drawing.Point(144, 320)
		Me.cmdAddNew.Caption = "&Add New"
		Me.cmdAddNew.TabIndex = 3
		'
		' uctProductsSingleRecord1
		'
		Me.uctProductsSingleRecord1.Name = "uctProductsSingleRecord1"
		Me.uctProductsSingleRecord1.Size = New System.Drawing.Size(313, 297)
		Me.uctProductsSingleRecord1.Location = New System.Drawing.Point(8, 8)
		Me.uctProductsSingleRecord1.TabIndex = 2
		Me.uctProductsSingleRecord1.ManualInitialize = 0
		Me.uctProductsSingleRecord1.SaveMode = 1
		'
		' cmdNext
		'
		Me.cmdNext.Name = "cmdNext"
		Me.cmdNext.Size = New System.Drawing.Size(65, 25)
		Me.cmdNext.Location = New System.Drawing.Point(72, 320)
		Me.cmdNext.Caption = "&Next"
		Me.cmdNext.TabIndex = 1
		'
		' cmdPrevious
		'
		Me.cmdPrevious.Name = "cmdPrevious"
		Me.cmdPrevious.Size = New System.Drawing.Size(65, 25)
		Me.cmdPrevious.Location = New System.Drawing.Point(8, 320)
		Me.cmdPrevious.Caption = "&Previous"
		Me.cmdPrevious.TabIndex = 0
		'
		' frmRecord
		'
		Me.Name = "frmRecord"
		Me.Caption = "Data Object Wizard Demo - Single Record"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(345, 350)

		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdUpdate)
		Me.Controls.Add(cmdAddNew)
		Me.Controls.Add(uctProductsSingleRecord1)
		Me.Controls.Add(cmdNext)
		Me.Controls.Add(cmdPrevious)
		CType(Me.uctProductsSingleRecord1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
