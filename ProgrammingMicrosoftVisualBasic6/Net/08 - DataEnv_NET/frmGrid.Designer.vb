<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGrid
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
	Public WithEvents cmdFilter As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtState As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents DataGrid1 As CodeArchitects.VB6LibraryOcx.VB6DataGrid
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGrid))
		Me.cmdFilter = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtState = New CodeArchitects.VB6Library.VB6TextBox()
		Me.DataGrid1 = New CodeArchitects.VB6LibraryOcx.VB6DataGrid()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdFilter
		'
		Me.cmdFilter.Name = "cmdFilter"
		Me.cmdFilter.Size = New System.Drawing.Size(73, 25)
		Me.cmdFilter.Location = New System.Drawing.Point(232, 8)
		Me.cmdFilter.Caption = "Filter"
		Me.cmdFilter.TabIndex = 3
		Me.AcceptButton = Me.cmdFilter
		Me.cmdFilter.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtState
		'
		Me.txtState.Name = "txtState"
		Me.txtState.Size = New System.Drawing.Size(89, 25)
		Me.txtState.Location = New System.Drawing.Point(136, 8)
		Me.txtState.TabIndex = 2
		'
		' DataGrid1
		'
		Me.DataGrid1.Name = "DataGrid1"
		Me.DataGrid1.Size = New System.Drawing.Size(313, 145)
		Me.DataGrid1.Location = New System.Drawing.Point(11, 40)
		Me.DataGrid1.TabIndex = 0
		Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(121, 25)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1.Caption = "State"
		Me.Label1.TabIndex = 1
		'
		' frmGrid
		'
		Me.Name = "frmGrid"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Parameterized Command Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(439, 247)

		Me.Controls.Add(cmdFilter)
		Me.Controls.Add(txtState)
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(Label1)
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
