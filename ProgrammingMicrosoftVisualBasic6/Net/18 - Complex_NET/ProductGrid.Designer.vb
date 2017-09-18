<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ProductGrid
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
	Private WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Private WithEvents ListView1_Control As System.Windows.Forms.ListView
	Private WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader
	Private WithEvents ListView1_Column2 As System.Windows.Forms.ColumnHeader
	Private WithEvents ListView1_Column3 As System.Windows.Forms.ColumnHeader
	Private WithEvents ListView1_Column4 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column4 = New System.Windows.Forms.ColumnHeader()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(16, 8)
		Me.ListView1.Size = New Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3, Me.ListView1_Column4})
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(337, 169)
		Me.ListView1_Control.Location = New System.Drawing.Point(16, 8)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ListView1_Control.TabIndex = 0
		Me.ListView1_Control.HideSelection = False
		Me.ListView1_Control.LabelWrap = True
		Me.ListView1_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView1_Control.LabelEdit = True
		Me.ListView1_Control.MultiSelect = False
		Me.ListView1_Control.View = System.Windows.Forms.View.Details
		Me.ListView1_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ListView1_Control.BackgroundImageTiled = False
		'
		' ListView1_Column1
		'
		Me.ListView1_Column1.Name = "ListView1_Column1"
		Me.ListView1_Column1.Text = "ProductName"
		Me.ListView1_Column1.Width = 187
		'
		' ListView1_Column2
		'
		Me.ListView1_Column2.Name = "ListView1_Column2"
		Me.ListView1_Column2.Text = "UnitPrice"
		Me.ListView1_Column2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ListView1_Column2.Width = 80
		'
		' ListView1_Column3
		'
		Me.ListView1_Column3.Name = "ListView1_Column3"
		Me.ListView1_Column3.Text = "UnitsInStock"
		Me.ListView1_Column3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ListView1_Column3.Width = 93
		'
		' ListView1_Column4
		'
		Me.ListView1_Column4.Name = "ListView1_Column4"
		Me.ListView1_Column4.Text = "UnitsOnOrder"
		Me.ListView1_Column4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.ListView1_Column4.Width = 93
		'
		' ProductGrid
		'
		Me.Name = "ProductGrid"
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(435, 219)

		Me.Controls.Add(ListView1)
		Me.Controls.Add(ListView1_Control)
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
