<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
		Me.cmdMove = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMove_001, cmdMove_000)
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
	Public cmdMove As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdConnection As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRun As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents DataGrid1 As CodeArchitects.VB6LibraryOcx.VB6DataGrid
	Public WithEvents txtSQL As CodeArchitects.VB6Library.VB6TextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.cmdConnection = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRun = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.DataGrid1 = New CodeArchitects.VB6LibraryOcx.VB6DataGrid()
		Me.txtSQL = New CodeArchitects.VB6Library.VB6TextBox()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdConnection
		'
		Me.cmdConnection.Name = "cmdConnection"
		Me.cmdConnection.Size = New System.Drawing.Size(73, 25)
		Me.cmdConnection.Location = New System.Drawing.Point(424, 0)
		Me.cmdConnection.Caption = "&New Conn"
		Me.cmdConnection.TabIndex = 6
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(33, 25)
		Me.cmdMove_001.Location = New System.Drawing.Point(464, 88)
		Me.cmdMove_001.Caption = ">"
		Me.cmdMove_001.TabIndex = 5
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(33, 25)
		Me.cmdMove_000.Location = New System.Drawing.Point(424, 88)
		Me.cmdMove_000.Caption = "<"
		Me.cmdMove_000.TabIndex = 4
		'
		' cmdRun
		'
		Me.cmdRun.Name = "cmdRun"
		Me.cmdRun.Size = New System.Drawing.Size(73, 25)
		Me.cmdRun.Location = New System.Drawing.Point(424, 56)
		Me.cmdRun.Caption = "&Run"
		Me.cmdRun.TabIndex = 3
		Me.AcceptButton = Me.cmdRun
		Me.cmdRun.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdClear
		'
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.Size = New System.Drawing.Size(73, 25)
		Me.cmdClear.Location = New System.Drawing.Point(424, 32)
		Me.cmdClear.Caption = "&Clear"
		Me.cmdClear.TabIndex = 2
		Me.CancelButton = Me.cmdClear
		Me.cmdClear.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' DataGrid1
		'
		Me.DataGrid1.Name = "DataGrid1"
		Me.DataGrid1.Size = New System.Drawing.Size(497, 153)
		Me.DataGrid1.Location = New System.Drawing.Point(0, 120)
		Me.DataGrid1.TabIndex = 1
		Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' txtSQL
		'
		Me.txtSQL.Name = "txtSQL"
		Me.txtSQL.Size = New System.Drawing.Size(417, 113)
		Me.txtSQL.Location = New System.Drawing.Point(0, 0)
		Me.txtSQL.MultiLine = -1
		Me.txtSQL.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtSQL.TabIndex = 0
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "SQL Training"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(506, 286)

		Me.Controls.Add(cmdConnection)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_000)
		Me.Controls.Add(cmdRun)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(txtSQL)
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
