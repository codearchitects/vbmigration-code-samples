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
		' Initialize control arrays.
		Me.mnuFileItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuFileItem_000, mnuFileItem_001, mnuFileItem_002, mnuFileItem_004)
		Me.mnuPopupItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuPopupItem_000, mnuPopupItem_001)
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
	Public mnuFileItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuPopupItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents txtEditor As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdClearList As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstEvents As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileItem_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileItem_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileItem_003 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileItem_004 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPopup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPopupItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPopupItem_001 As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.txtEditor = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdClearList = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstEvents = New CodeArchitects.VB6Library.VB6ListBox()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileItem_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileItem_003 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileItem_004 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPopup = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPopupItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPopupItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' txtEditor
		'
		Me.txtEditor.Name = "txtEditor"
		Me.txtEditor.Size = New System.Drawing.Size(241, 73)
		Me.txtEditor.Location = New System.Drawing.Point(8, 32)
		Me.txtEditor.MultiLine = -1
		Me.txtEditor.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtEditor.TabIndex = 2
		Me.txtEditor.Text = "Write some text here and then scroll " & ControlChars.CrLf & "the contents horizontally and vertically." & ControlChars.CrLf
		'
		' cmdClearList
		'
		Me.cmdClearList.Name = "cmdClearList"
		Me.cmdClearList.Size = New System.Drawing.Size(137, 25)
		Me.cmdClearList.Location = New System.Drawing.Point(264, 80)
		Me.cmdClearList.Caption = "Clear Event List"
		Me.cmdClearList.TabIndex = 1
		'
		' lstEvents
		'
		Me.lstEvents.Name = "lstEvents"
		Me.lstEvents.Size = New System.Drawing.Size(521, 164)
		Me.lstEvents.Location = New System.Drawing.Point(8, 120)
		Me.lstEvents.TabIndex = 0
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(521, 25)
		Me.lblStatus.Location = New System.Drawing.Point(8, 296)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 3
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
		'
		' mnuFileItem_000
		'
		Me.mnuFileItem_000.Name = "mnuFileItem_000"
		Me.mnuFileItem_000.Caption = "&New"
		'
		' mnuFileItem_001
		'
		Me.mnuFileItem_001.Name = "mnuFileItem_001"
		Me.mnuFileItem_001.Caption = "&Open"
		'
		' mnuFileItem_002
		'
		Me.mnuFileItem_002.Name = "mnuFileItem_002"
		Me.mnuFileItem_002.Caption = "&Save"
		'
		' mnuFileItem_003
		'
		Me.mnuFileItem_003.Name = "mnuFileItem_003"
		'
		' mnuFileItem_004
		'
		Me.mnuFileItem_004.Name = "mnuFileItem_004"
		Me.mnuFileItem_004.Caption = "E&xit"
		'
		' mnuPopup
		'
		Me.mnuPopup.Name = "mnuPopup"
		Me.mnuPopup.Caption = "(popup)"
		Me.mnuPopup.Visible = False
		'
		' mnuPopupItem_000
		'
		Me.mnuPopupItem_000.Name = "mnuPopupItem_000"
		Me.mnuPopupItem_000.Caption = "Clear the textbox"
		'
		' mnuPopupItem_001
		'
		Me.mnuPopupItem_001.Name = "mnuPopupItem_001"
		Me.mnuPopupItem_001.Caption = "Save to file"
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "MsgHook Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 49)
		Me.ClientSize = New System.Drawing.Size(536, 329)

		Me.Controls.Add(txtEditor)
		Me.Controls.Add(cmdClearList)
		Me.Controls.Add(lstEvents)
		Me.Controls.Add(lblStatus)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileItem_000)
		Me.mnuFile.DropDownItems.Add(mnuFileItem_001)
		Me.mnuFile.DropDownItems.Add(mnuFileItem_002)
		Me.mnuFile.DropDownItems.Add(mnuFileItem_003)
		Me.mnuFile.DropDownItems.Add(mnuFileItem_004)
		Me.MenuStrip1.Items.Add(mnuPopup)
		Me.mnuPopup.DropDownItems.Add(mnuPopupItem_000)
		Me.mnuPopup.DropDownItems.Add(mnuPopupItem_001)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
