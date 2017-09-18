<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class uctProductsDataGrid
	Inherits CodeArchitects.VB6Library.VB6UserControl

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
	Private WithEvents cmbEdit As CodeArchitects.VB6Library.VB6ComboBox
	Private WithEvents grdProducts2 As CodeArchitects.VB6LibraryOcx.VB6DataGrid

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(uctProductsDataGrid))
		Me.cmbEdit = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.grdProducts2 = New CodeArchitects.VB6LibraryOcx.VB6DataGrid()
		CType(Me.grdProducts2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmbEdit
		'
		Me.cmbEdit.Name = "cmbEdit"
		Me.cmbEdit.Size = New System.Drawing.Size(67, 21)
		Me.cmbEdit.Location = New System.Drawing.Point(32, 88)
		Me.cmbEdit.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmbEdit.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbEdit.TabIndex = 1
		Me.cmbEdit.Visible = False
		'
		' grdProducts2
		'
		Me.grdProducts2.Name = "grdProducts2"
		Me.grdProducts2.Size = New System.Drawing.Size(307, 227)
		Me.grdProducts2.Location = New System.Drawing.Point(8, 8)
		Me.grdProducts2.TabIndex = 0
		Me.grdProducts2.OcxState = CType(resources.GetObject("grdProducts2.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' uctProductsDataGrid
		'
		Me.Name = "uctProductsDataGrid"
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(320, 240)

		Me.Controls.Add(cmbEdit)
		Me.Controls.Add(grdProducts2)
		CType(Me.grdProducts2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
