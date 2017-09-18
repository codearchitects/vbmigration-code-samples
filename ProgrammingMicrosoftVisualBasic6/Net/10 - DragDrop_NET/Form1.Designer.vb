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
		Me.TreeView1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TreeView)(TreeView1_000, TreeView1_001)
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
	Public TreeView1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TreeView)
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents TreeView1_000 As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents TreeView1_001 As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.TreeView1_000 = New CodeArchitects.VB6Library.VB6TreeView()
		Me.TreeView1_001 = New CodeArchitects.VB6Library.VB6TreeView()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(13, 13)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' TreeView1_000
		'
		Me.TreeView1_000.Name = "TreeView1_000"
		Me.TreeView1_000.Size = New System.Drawing.Size(257, 353)
		Me.TreeView1_000.Location = New System.Drawing.Point(8, 32)
		Me.TreeView1_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TreeView1_000.TabIndex = 0
		Me.TreeView1_000.Indentation = 706
		Me.TreeView1_000.LineStyle = CodeArchitects.VB6Library.MSComctlLib.TreeLineStyleConstants.tvwRootLines
		Me.TreeView1_000.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.TreeView1_000.ImageList = ImageList1
		Me.TreeView1_000.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		'
		' TreeView1_001
		'
		Me.TreeView1_001.Name = "TreeView1_001"
		Me.TreeView1_001.Size = New System.Drawing.Size(257, 353)
		Me.TreeView1_001.Location = New System.Drawing.Point(272, 32)
		Me.TreeView1_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TreeView1_001.TabIndex = 1
		Me.TreeView1_001.Indentation = 706
		Me.TreeView1_001.LineStyle = CodeArchitects.VB6Library.MSComctlLib.TreeLineStyleConstants.tvwRootLines
		Me.TreeView1_001.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.TreeView1_001.ImageList = ImageList1
		Me.TreeView1_001.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(521, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Move a subtree using the right-button - Use Ctrl to copy it."
		Me.Label1.TabIndex = 2
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "TreeView Drag-and-Drop demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(533, 390)

		Me.Controls.Add(TreeView1_000)
		Me.Controls.Add(TreeView1_001)
		Me.Controls.Add(Label1)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
