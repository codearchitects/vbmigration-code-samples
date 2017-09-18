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
	Public WithEvents cmdFetch As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtProductName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents uctProductsDataGrid1 As Project1.uctProductsDataGrid
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdFetch = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtProductName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.uctProductsDataGrid1 = New Project1.uctProductsDataGrid()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.uctProductsDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdFetch
		'
		Me.cmdFetch.Name = "cmdFetch"
		Me.cmdFetch.Size = New System.Drawing.Size(73, 25)
		Me.cmdFetch.Location = New System.Drawing.Point(376, 0)
		Me.cmdFetch.Caption = "Fetch"
		Me.cmdFetch.TabIndex = 2
		Me.AcceptButton = Me.cmdFetch
		Me.cmdFetch.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtProductName
		'
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.Size = New System.Drawing.Size(81, 27)
		Me.txtProductName.Location = New System.Drawing.Point(280, 0)
		Me.txtProductName.TabIndex = 1
		'
		' uctProductsDataGrid1
		'
		Me.uctProductsDataGrid1.Name = "uctProductsDataGrid1"
		Me.uctProductsDataGrid1.Size = New System.Drawing.Size(553, 185)
		Me.uctProductsDataGrid1.Location = New System.Drawing.Point(8, 32)
		Me.uctProductsDataGrid1.TabIndex = 0
		Me.uctProductsDataGrid1.ManualInitialize = -1
		Me.uctProductsDataGrid1.GridEditable = -1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(257, 25)
		Me.Label1.Location = New System.Drawing.Point(16, 8)
		Me.Label1.Caption = "Enter search expression (use % and _ as wildcards)"
		Me.Label1.TabIndex = 3
		'
		' frmGrid
		'
		Me.Name = "frmGrid"
		Me.Caption = "Data Object Wizard Demo - Data Grid"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(569, 226)

		Me.Controls.Add(cmdFetch)
		Me.Controls.Add(txtProductName)
		Me.Controls.Add(uctProductsDataGrid1)
		Me.Controls.Add(Label1)
		CType(Me.uctProductsDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
