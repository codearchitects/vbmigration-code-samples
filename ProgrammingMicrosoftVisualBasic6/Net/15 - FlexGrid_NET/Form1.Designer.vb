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
		' Open recordsets exposed by DataEnvironment objects bound to controls
		DataEnvironment1_DefInstance.Authors()
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
	Public WithEvents cmdCollapse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdExpand As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCellEditor As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents MSHFlexGrid1 As CodeArchitects.VB6LibraryOcx.VB6MSHFlexGrid
	Public WithEvents DataEnvironment1 As DataEnvironment1_Instance

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdCollapse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdExpand = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCellEditor = New CodeArchitects.VB6Library.VB6TextBox()
		Me.MSHFlexGrid1 = New CodeArchitects.VB6LibraryOcx.VB6MSHFlexGrid()
		Me.DataEnvironment1 = New DataEnvironment1_Instance
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdCollapse
		'
		Me.cmdCollapse.Name = "cmdCollapse"
		Me.cmdCollapse.Size = New System.Drawing.Size(81, 25)
		Me.cmdCollapse.Location = New System.Drawing.Point(80, 0)
		Me.cmdCollapse.Caption = "Collapse All"
		Me.cmdCollapse.TabIndex = 3
		'
		' cmdExpand
		'
		Me.cmdExpand.Name = "cmdExpand"
		Me.cmdExpand.Size = New System.Drawing.Size(81, 25)
		Me.cmdExpand.Location = New System.Drawing.Point(0, 0)
		Me.cmdExpand.Caption = "Expand All"
		Me.cmdExpand.TabIndex = 2
		'
		' txtCellEditor
		'
		Me.txtCellEditor.Name = "txtCellEditor"
		Me.txtCellEditor.Size = New System.Drawing.Size(89, 25)
		Me.txtCellEditor.Location = New System.Drawing.Point(64, 168)
		Me.txtCellEditor.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.txtCellEditor.MultiLine = -1
		Me.txtCellEditor.TabIndex = 1
		'
		' MSHFlexGrid1
		'
		Me.MSHFlexGrid1.Name = "MSHFlexGrid1"
		Me.MSHFlexGrid1.Size = New System.Drawing.Size(350, 80)
		Me.MSHFlexGrid1.Location = New System.Drawing.Point(0, 32)
		Me.MSHFlexGrid1.TabIndex = 0
		Me.MSHFlexGrid1.Tag = "DataMember=Authors;DataSource=DataEnvironment1;"
		Me.MSHFlexGrid1.OcxState = CType(resources.GetObject("MSHFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Hierarchical FlexGrid demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(415, 212)

		Me.Controls.Add(cmdCollapse)
		Me.Controls.Add(cmdExpand)
		Me.Controls.Add(txtCellEditor)
		Me.Controls.Add(MSHFlexGrid1)
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
