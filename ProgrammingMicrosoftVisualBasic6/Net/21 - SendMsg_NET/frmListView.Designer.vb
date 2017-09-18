<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmListView
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
		Me.cmdScroll = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdScroll_000, cmdScroll_001, cmdScroll_002, cmdScroll_003)
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
	Public cmdScroll As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdScroll_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdVisibleItems As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ListView1 As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents ListView1_Control As System.Windows.Forms.ListView
	Public WithEvents ListView1_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents ListView1_Column3 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdScroll_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdVisibleItems = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ListView1 = New CodeArchitects.VB6Library.VB6ListView()
		Me.ListView1_Control = New System.Windows.Forms.ListView()
		Me.ListView1_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.ListView1_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.Frame1.SuspendLayout()
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(121, 97)
		Me.Frame1.Location = New System.Drawing.Point(248, 80)
		Me.Frame1.Caption = "Scroll"
		Me.Frame1.TabIndex = 2
		'
		' cmdScroll_000
		'
		Me.cmdScroll_000.Name = "cmdScroll_000"
		Me.cmdScroll_000.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_000.Location = New System.Drawing.Point(40, 16)
		Me.cmdScroll_000.Caption = "/\"
		Me.cmdScroll_000.TabIndex = 6
		'
		' cmdScroll_001
		'
		Me.cmdScroll_001.Name = "cmdScroll_001"
		Me.cmdScroll_001.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_001.Location = New System.Drawing.Point(8, 40)
		Me.cmdScroll_001.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_001.Caption = "<"
		Me.cmdScroll_001.TabIndex = 5
		'
		' cmdScroll_002
		'
		Me.cmdScroll_002.Name = "cmdScroll_002"
		Me.cmdScroll_002.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_002.Location = New System.Drawing.Point(72, 40)
		Me.cmdScroll_002.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_002.Caption = ">"
		Me.cmdScroll_002.TabIndex = 4
		'
		' cmdScroll_003
		'
		Me.cmdScroll_003.Name = "cmdScroll_003"
		Me.cmdScroll_003.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_003.Location = New System.Drawing.Point(40, 64)
		Me.cmdScroll_003.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_003.Caption = "\/"
		Me.cmdScroll_003.TabIndex = 3
		'
		' cmdVisibleItems
		'
		Me.cmdVisibleItems.Name = "cmdVisibleItems"
		Me.cmdVisibleItems.Size = New System.Drawing.Size(97, 25)
		Me.cmdVisibleItems.Location = New System.Drawing.Point(240, 8)
		Me.cmdVisibleItems.Caption = "Visible Items"
		Me.cmdVisibleItems.TabIndex = 1
		'
		' ListView1
		'
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Location = New System.Drawing.Point(8, 8)
		Me.ListView1.Size = New Size(2, 2)
		Me.ListView1.ListView = Me.ListView1_Control
		Me.ListView1_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListView1_Column1, Me.ListView1_Column2, Me.ListView1_Column3})
		'
		' ListView1_Control
		'
		Me.ListView1_Control.Name = "ListView1_Control"
		Me.ListView1_Control.Size = New System.Drawing.Size(225, 113)
		Me.ListView1_Control.Location = New System.Drawing.Point(8, 8)
		Me.ListView1_Control.ShowItemToolTips = True
		Me.ListView1_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ListView1_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.ListView1_Control.TabIndex = 0
		Me.ListView1_Control.HideSelection = True
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
		Me.ListView1_Column1.Text = "#"
		Me.ListView1_Column1.Width = 20
		'
		' ListView1_Column2
		'
		Me.ListView1_Column2.Name = "ListView1_Column2"
		Me.ListView1_Column2.Text = "First Name"
		Me.ListView1_Column2.Width = 96
		'
		' ListView1_Column3
		'
		Me.ListView1_Column3.Name = "ListView1_Column3"
		Me.ListView1_Column3.Text = "Last Name"
		Me.ListView1_Column3.Width = 96
		'
		' frmListView
		'
		Me.Name = "frmListView"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Form1"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(382, 191)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmdScroll_000)
		Me.Frame1.Controls.Add(cmdScroll_001)
		Me.Frame1.Controls.Add(cmdScroll_002)
		Me.Frame1.Controls.Add(cmdScroll_003)
		Me.Controls.Add(cmdVisibleItems)
		Me.Controls.Add(ListView1)
		Me.Controls.Add(ListView1_Control)
		CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
