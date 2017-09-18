<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDirBrowser
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
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents tvwDir As CodeArchitects.VB6Library.VB6TreeView
	Public WithEvents lblPath As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDirBrowser))
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.tvwDir = New CodeArchitects.VB6Library.VB6TreeView()
		Me.lblPath = New CodeArchitects.VB6Library.VB6Label()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(168, 288)
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 2
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(65, 25)
		Me.cmdOK.Location = New System.Drawing.Point(88, 288)
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 1
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' tvwDir
		'
		Me.tvwDir.Name = "tvwDir"
		Me.tvwDir.Size = New System.Drawing.Size(313, 185)
		Me.tvwDir.Location = New System.Drawing.Point(8, 24)
		Me.tvwDir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tvwDir.TabIndex = 0
		Me.tvwDir.HideSelection = False
		Me.tvwDir.Indentation = 529
		Me.tvwDir.LabelEdit = CodeArchitects.VB6Library.MSComctlLib.LabelEditConstants.tvwManual
		Me.tvwDir.Sorted = True
		Me.tvwDir.Style = CodeArchitects.VB6Library.MSComctlLib.TreeStyleConstants.tvwTreelinesPlusMinusPictureText
		Me.tvwDir.ImageList = ImageList1
		'
		' lblPath
		'
		Me.lblPath.Name = "lblPath"
		Me.lblPath.Size = New System.Drawing.Size(313, 17)
		Me.lblPath.Location = New System.Drawing.Point(8, 8)
		Me.lblPath.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPath.Caption = "lblPath"
		Me.lblPath.TabIndex = 3
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.Tag = "Key1=Computer;Key3=Folder;Key4=OpenFolder;"
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' frmDirBrowser
		'
		Me.Name = "frmDirBrowser"
		Me.Caption = "Directory Browser"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(337, 325)

		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(tvwDir)
		Me.Controls.Add(lblPath)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
