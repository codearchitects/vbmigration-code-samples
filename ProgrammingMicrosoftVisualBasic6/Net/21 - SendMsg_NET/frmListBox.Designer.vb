<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmListBox
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
		Me.cmdSelectAll = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdSelectAll_001, cmdSelectAll_000)
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
	Public cmdSelectAll As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdVisibleItems As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdGetSelItems As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents cmdSetDropWidth As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdGetDropWidth As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowList As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetTabStops As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSelectAll_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSelectAll_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetItemHeight As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdGetItemHeight As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetHorizExt As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdGetHorizExt As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFindExact As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFind As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents List1 As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdVisibleItems = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdGetSelItems = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.cmdSetDropWidth = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdGetDropWidth = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowList = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetTabStops = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSelectAll_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSelectAll_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetItemHeight = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdGetItemHeight = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetHorizExt = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdGetHorizExt = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFindExact = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFind = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.List1 = New CodeArchitects.VB6Library.VB6ListBox()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdVisibleItems
		'
		Me.cmdVisibleItems.Name = "cmdVisibleItems"
		Me.cmdVisibleItems.Size = New System.Drawing.Size(105, 25)
		Me.cmdVisibleItems.Location = New System.Drawing.Point(408, 48)
		Me.cmdVisibleItems.Caption = "Visible Items"
		Me.cmdVisibleItems.TabIndex = 16
		'
		' cmdGetSelItems
		'
		Me.cmdGetSelItems.Name = "cmdGetSelItems"
		Me.cmdGetSelItems.Size = New System.Drawing.Size(105, 25)
		Me.cmdGetSelItems.Location = New System.Drawing.Point(408, 16)
		Me.cmdGetSelItems.Caption = "Get Sel Items"
		Me.cmdGetSelItems.TabIndex = 15
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Interval = 500
		'
		' cmdSetDropWidth
		'
		Me.cmdSetDropWidth.Name = "cmdSetDropWidth"
		Me.cmdSetDropWidth.Size = New System.Drawing.Size(105, 25)
		Me.cmdSetDropWidth.Location = New System.Drawing.Point(408, 144)
		Me.cmdSetDropWidth.Caption = "Set Drop Width"
		Me.cmdSetDropWidth.TabIndex = 13
		'
		' cmdGetDropWidth
		'
		Me.cmdGetDropWidth.Name = "cmdGetDropWidth"
		Me.cmdGetDropWidth.Size = New System.Drawing.Size(105, 25)
		Me.cmdGetDropWidth.Location = New System.Drawing.Point(408, 112)
		Me.cmdGetDropWidth.Caption = "Get Drop Width"
		Me.cmdGetDropWidth.TabIndex = 12
		'
		' cmdShowList
		'
		Me.cmdShowList.Name = "cmdShowList"
		Me.cmdShowList.Size = New System.Drawing.Size(105, 25)
		Me.cmdShowList.Location = New System.Drawing.Point(408, 80)
		Me.cmdShowList.Caption = "Show List"
		Me.cmdShowList.TabIndex = 11
		'
		' cmdSetTabStops
		'
		Me.cmdSetTabStops.Name = "cmdSetTabStops"
		Me.cmdSetTabStops.Size = New System.Drawing.Size(105, 25)
		Me.cmdSetTabStops.Location = New System.Drawing.Point(296, 144)
		Me.cmdSetTabStops.Caption = "Set Tab Stops"
		Me.cmdSetTabStops.TabIndex = 10
		'
		' cmdSelectAll_001
		'
		Me.cmdSelectAll_001.Name = "cmdSelectAll_001"
		Me.cmdSelectAll_001.Size = New System.Drawing.Size(105, 25)
		Me.cmdSelectAll_001.Location = New System.Drawing.Point(296, 112)
		Me.cmdSelectAll_001.Caption = "Deselect All"
		Me.cmdSelectAll_001.TabIndex = 9
		'
		' cmdSelectAll_000
		'
		Me.cmdSelectAll_000.Name = "cmdSelectAll_000"
		Me.cmdSelectAll_000.Size = New System.Drawing.Size(105, 25)
		Me.cmdSelectAll_000.Location = New System.Drawing.Point(296, 80)
		Me.cmdSelectAll_000.Caption = "Select All"
		Me.cmdSelectAll_000.TabIndex = 8
		'
		' cmdSetItemHeight
		'
		Me.cmdSetItemHeight.Name = "cmdSetItemHeight"
		Me.cmdSetItemHeight.Size = New System.Drawing.Size(105, 25)
		Me.cmdSetItemHeight.Location = New System.Drawing.Point(184, 112)
		Me.cmdSetItemHeight.Caption = "Set Item Height"
		Me.cmdSetItemHeight.TabIndex = 7
		'
		' cmdGetItemHeight
		'
		Me.cmdGetItemHeight.Name = "cmdGetItemHeight"
		Me.cmdGetItemHeight.Size = New System.Drawing.Size(105, 25)
		Me.cmdGetItemHeight.Location = New System.Drawing.Point(184, 80)
		Me.cmdGetItemHeight.Caption = "Get Item Height"
		Me.cmdGetItemHeight.TabIndex = 6
		'
		' cmdSetHorizExt
		'
		Me.cmdSetHorizExt.Name = "cmdSetHorizExt"
		Me.cmdSetHorizExt.Size = New System.Drawing.Size(105, 25)
		Me.cmdSetHorizExt.Location = New System.Drawing.Point(296, 48)
		Me.cmdSetHorizExt.Caption = "Set Horiz Ext"
		Me.cmdSetHorizExt.TabIndex = 5
		'
		' cmdGetHorizExt
		'
		Me.cmdGetHorizExt.Name = "cmdGetHorizExt"
		Me.cmdGetHorizExt.Size = New System.Drawing.Size(105, 25)
		Me.cmdGetHorizExt.Location = New System.Drawing.Point(296, 16)
		Me.cmdGetHorizExt.Caption = "Get Horiz Ext"
		Me.cmdGetHorizExt.TabIndex = 4
		'
		' cmdFindExact
		'
		Me.cmdFindExact.Name = "cmdFindExact"
		Me.cmdFindExact.Size = New System.Drawing.Size(105, 25)
		Me.cmdFindExact.Location = New System.Drawing.Point(184, 48)
		Me.cmdFindExact.Caption = "Find Exact"
		Me.cmdFindExact.TabIndex = 3
		'
		' cmdFind
		'
		Me.cmdFind.Name = "cmdFind"
		Me.cmdFind.Size = New System.Drawing.Size(105, 25)
		Me.cmdFind.Location = New System.Drawing.Point(184, 16)
		Me.cmdFind.Caption = "Find"
		Me.cmdFind.TabIndex = 2
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(161, 24)
		Me.Combo1.Location = New System.Drawing.Point(8, 176)
		Me.Combo1.TabIndex = 1
		Me.Combo1.Text = "Combo1"
		'
		' List1
		'
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(161, 148)
		Me.List1.Location = New System.Drawing.Point(8, 16)
		Me.List1.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.List1.TabIndex = 0
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(329, 25)
		Me.lblStatus.Location = New System.Drawing.Point(184, 176)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 14
		'
		' frmListBox
		'
		Me.Name = "frmListBox"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ListBox and ComboBox SendMessage Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(523, 210)

		Me.Controls.Add(cmdVisibleItems)
		Me.Controls.Add(cmdGetSelItems)
		Me.Controls.Add(cmdSetDropWidth)
		Me.Controls.Add(cmdGetDropWidth)
		Me.Controls.Add(cmdShowList)
		Me.Controls.Add(cmdSetTabStops)
		Me.Controls.Add(cmdSelectAll_001)
		Me.Controls.Add(cmdSelectAll_000)
		Me.Controls.Add(cmdSetItemHeight)
		Me.Controls.Add(cmdGetItemHeight)
		Me.Controls.Add(cmdSetHorizExt)
		Me.Controls.Add(cmdGetHorizExt)
		Me.Controls.Add(cmdFindExact)
		Me.Controls.Add(cmdFind)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(List1)
		Me.Controls.Add(lblStatus)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
