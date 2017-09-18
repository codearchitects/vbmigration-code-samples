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
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents chkSystem As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents TreeView1 As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents cmdBrowse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents lblData As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.chkSystem = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.TreeView1 = New CodeArchitects.VB6Library.VB6TreeView()
		Me.cmdBrowse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.lblData = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		'
		' chkSystem
		'
		Me.chkSystem.Name = "chkSystem"
		Me.chkSystem.Size = New System.Drawing.Size(177, 17)
		Me.chkSystem.Location = New System.Drawing.Point(104, 16)
		Me.chkSystem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSystem.Caption = "&Show System Tables"
		Me.chkSystem.TabIndex = 2
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' TreeView1
		'
		Me.TreeView1.Name = "TreeView1"
		Me.TreeView1.Size = New System.Drawing.Size(281, 305)
		Me.TreeView1.Location = New System.Drawing.Point(8, 40)
		Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TreeView1.TabIndex = 1
		Me.TreeView1.Indentation = 529
		Me.TreeView1.LineStyle = CodeArchitects.VB6Library.MSComctlLib.TreeLineStyleConstants.tvwRootLines
		Me.TreeView1.Sorted = True
		Me.TreeView1.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.TreeView1.ImageList = ImageList1
		'
		' cmdBrowse
		'
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.cmdBrowse.Size = New System.Drawing.Size(81, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(8, 8)
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.Caption = "&Browse"
		Me.cmdBrowse.TabIndex = 0
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(32896))
		Me.ImageList1.Tag = "Key1=Database;Key2=Table;Key3=FieldOld;"
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' lblData
		'
		Me.lblData.Name = "lblData"
		Me.lblData.Size = New System.Drawing.Size(273, 305)
		Me.lblData.Location = New System.Drawing.Point(304, 40)
		Me.lblData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblData.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblData.TabIndex = 3
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Jet Database Explorer"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(591, 359)

		Me.Controls.Add(chkSystem)
		Me.Controls.Add(TreeView1)
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(lblData)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
