<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTabs
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
	Public WithEvents cmdDeleteAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtTab As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lstTabs As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDeleteAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtTab = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lstTabs = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdDeleteAll
		'
		Me.cmdDeleteAll.Name = "cmdDeleteAll"
		Me.cmdDeleteAll.Size = New System.Drawing.Size(83, 25)
		Me.cmdDeleteAll.Location = New System.Drawing.Point(176, 72)
		Me.cmdDeleteAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDeleteAll.Caption = "Delete &All"
		Me.cmdDeleteAll.TabIndex = 0
		'
		' txtTab
		'
		Me.txtTab.Name = "txtTab"
		Me.txtTab.Size = New System.Drawing.Size(151, 21)
		Me.txtTab.Location = New System.Drawing.Point(8, 24)
		Me.txtTab.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTab.MaxLength = 10
		Me.txtTab.TabIndex = 6
		'
		' lstTabs
		'
		Me.lstTabs.Name = "lstTabs"
		Me.lstTabs.Size = New System.Drawing.Size(151, 132)
		Me.lstTabs.Location = New System.Drawing.Point(8, 50)
		Me.lstTabs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstTabs.TabIndex = 5
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(83, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(176, 160)
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 4
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(83, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(176, 48)
		Me.cmdDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.Enabled = False
		Me.cmdDelete.TabIndex = 3
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(83, 25)
		Me.cmdSet.Location = New System.Drawing.Point(176, 24)
		Me.cmdSet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSet.Caption = "&Set"
		Me.cmdSet.Enabled = False
		Me.cmdSet.TabIndex = 2
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(83, 25)
		Me.cmdOK.Location = New System.Drawing.Point(176, 128)
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Tab Stops"
		Me.Label1.TabIndex = 7
		'
		' frmTabs
		'
		Me.Name = "frmTabs"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Tabs"
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(272, 193)

		Me.Controls.Add(cmdDeleteAll)
		Me.Controls.Add(txtTab)
		Me.Controls.Add(lstTabs)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
