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
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Adodc1 As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSelect As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSelect = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(652, 33)
		Me.Adodc1.Location = New System.Drawing.Point(0, 322)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.Adodc1.ConnectMode = ADODB.ConnectModeEnum.adModeUnknown
		Me.Adodc1.CursorLocation = CodeArchitects.VB6Library.MSAdodcLib.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.Cursortype = 3
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = CodeArchitects.VB6Library.MSAdodcLib.CommandTypeEnum.adCmdUnknown
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = CodeArchitects.VB6Library.MSAdodcLib.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.Adodc1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.Adodc1.Enabled = True
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = ""
		Me.Adodc1.Caption = "Adodc1"
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
		' mnuFileOpen
		'
		Me.mnuFileOpen.Name = "mnuFileOpen"
		Me.mnuFileOpen.Caption = "&Open Database"
		'
		' mnuSelect
		'
		Me.mnuSelect.Name = "mnuSelect"
		Me.mnuSelect.Caption = "&Select RecordSource"
		Me.mnuSelect.Enabled = False
		'
		' mnuFileBar
		'
		Me.mnuFileBar.Name = "mnuFileBar"
		'
		' mnuFileExit
		'
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.Caption = "E&xit"
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Dynamic Control Creation Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(15, 55)
		Me.ClientSize = New System.Drawing.Size(652, 355)

		Me.Controls.Add(Adodc1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileOpen)
		Me.mnuFile.DropDownItems.Add(mnuSelect)
		Me.mnuFile.DropDownItems.Add(mnuFileBar)
		Me.mnuFile.DropDownItems.Add(mnuFileExit)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.Adodc1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
