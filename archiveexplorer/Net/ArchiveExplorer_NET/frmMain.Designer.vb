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
	Public WithEvents btnUnzip As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents FileList As CodeArchitects.VB6Library.VB6FileListBox
	Public WithEvents DirList As CodeArchitects.VB6Library.VB6DirListBox
	Public WithEvents DriveList As CodeArchitects.VB6Library.VB6DriveListBox
	Public WithEvents lstInZip As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents lblHeadLine As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lstInZip_Control As System.Windows.Forms.ListView

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.btnUnzip = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.FileList = New CodeArchitects.VB6Library.VB6FileListBox()
		Me.DirList = New CodeArchitects.VB6Library.VB6DirListBox()
		Me.DriveList = New CodeArchitects.VB6Library.VB6DriveListBox()
		Me.lstInZip = New CodeArchitects.VB6Library.VB6ListView()
		Me.lblHeadLine = New CodeArchitects.VB6Library.VB6Label()
		Me.lstInZip_Control = New System.Windows.Forms.ListView()
		CType(Me.FileList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DirList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DriveList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lstInZip, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' btnUnzip
		'
		Me.btnUnzip.Name = "btnUnzip"
		Me.btnUnzip.Size = New System.Drawing.Size(601, 25)
		Me.btnUnzip.Location = New System.Drawing.Point(280, 280)
		Me.btnUnzip.Caption = "Extract selected ones"
		Me.btnUnzip.TabIndex = 4
		Me.btnUnzip.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' FileList
		'
		Me.FileList.Name = "FileList"
		Me.FileList.Size = New System.Drawing.Size(137, 266)
		Me.FileList.Location = New System.Drawing.Point(136, 8)
		Me.FileList.TabIndex = 2
		'
		' DirList
		'
		Me.DirList.Name = "DirList"
		Me.DirList.Size = New System.Drawing.Size(129, 231)
		Me.DirList.Location = New System.Drawing.Point(8, 8)
		Me.DirList.TabIndex = 1
		'
		' DriveList
		'
		Me.DriveList.Name = "DriveList"
		Me.DriveList.Size = New System.Drawing.Size(129, 21)
		Me.DriveList.Location = New System.Drawing.Point(8, 248)
		Me.DriveList.TabIndex = 0
		'
		' lstInZip
		'
		Me.lstInZip.Name = "lstInZip"
		Me.lstInZip.Location = New System.Drawing.Point(272, 32)
		Me.lstInZip.Size = New System.Drawing.Size(2, 2)
		Me.lstInZip.ListView = Me.lstInZip_Control
		'
		' lblHeadLine
		'
		Me.lblHeadLine.Name = "lblHeadLine"
		Me.lblHeadLine.Size = New System.Drawing.Size(601, 17)
		Me.lblHeadLine.Location = New System.Drawing.Point(280, 8)
		Me.lblHeadLine.TabIndex = 5
		Me.lblHeadLine.AutoSize = False
		Me.lblHeadLine.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lstInZip_Control
		'
		Me.lstInZip_Control.Name = "lstInZip_Control"
		Me.lstInZip_Control.Size = New System.Drawing.Size(609, 241)
		Me.lstInZip_Control.Location = New System.Drawing.Point(272, 32)
		Me.lstInZip_Control.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstInZip_Control.ShowItemToolTips = True
		Me.lstInZip_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.lstInZip_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.lstInZip_Control.TabIndex = 3
		Me.lstInZip_Control.FullRowSelect = True
		Me.lstInZip_Control.HideSelection = True
		Me.lstInZip_Control.LabelWrap = True
		Me.lstInZip_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.lstInZip_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstInZip_Control.LabelEdit = False
		Me.lstInZip_Control.MultiSelect = True
		Me.lstInZip_Control.View = System.Windows.Forms.View.Details
		Me.lstInZip_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.lstInZip_Control.BackgroundImageTiled = False
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Archive Explorer"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(883, 314)

		Me.Controls.Add(btnUnzip)
		Me.Controls.Add(FileList)
		Me.Controls.Add(DirList)
		Me.Controls.Add(DriveList)
		Me.Controls.Add(lstInZip)
		Me.Controls.Add(lblHeadLine)
		Me.Controls.Add(lstInZip_Control)
		CType(Me.FileList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DirList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DriveList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lstInZip, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
