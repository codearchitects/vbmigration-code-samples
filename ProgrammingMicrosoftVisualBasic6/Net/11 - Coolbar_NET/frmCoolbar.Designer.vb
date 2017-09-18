<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCoolbar
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
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents CoolBar1_Placeholder As CodeArchitects.VB6Library.VB6Placeholder
	Public WithEvents cmdAddBand As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboFonts As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Toolbar1 As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents Toolbar1_Control As System.Windows.Forms.ToolStrip
	Public WithEvents imlToolbarIcons As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button9 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button12 As System.Windows.Forms.ToolStripButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCoolbar))
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.CoolBar1_Placeholder = New CodeArchitects.VB6Library.VB6Placeholder()
		Me.cmdAddBand = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboFonts = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Toolbar1 = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.Toolbar1_Control = New System.Windows.Forms.ToolStrip()
		Me.imlToolbarIcons = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button7 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button9 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button10 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button11 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button12 = New System.Windows.Forms.ToolStripButton()
		Me.Picture1.SuspendLayout()
		Me.CoolBar1_Placeholder.SuspendLayout()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imlToolbarIcons, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(473, 137)
		Me.Picture1.Location = New System.Drawing.Point(8, 64)
		Me.Picture1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 3
		Me.Picture1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(457, 89)
		Me.Text1.Location = New System.Drawing.Point(8, 40)
		Me.Text1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.MultiLine = -1
		Me.Text1.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.Text1.TabIndex = 5
		Me.Text1.Text = "An example of a text editor"
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(442, 32)
		Me.Label1.Location = New System.Drawing.Point(8, 0)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "All the controls on this form below the Coolbar are contained in a picture box that is moved and resized when the height of the Coolbar changes"
		Me.Label1.TabIndex = 4
		'
		' CoolBar1_Placeholder
		'
		Me.CoolBar1_Placeholder.Name = "CoolBar1_Placeholder"
		Me.CoolBar1_Placeholder.Size = New System.Drawing.Size(504, 52)
		Me.CoolBar1_Placeholder.Location = New System.Drawing.Point(0, 0)
		'
		' cmdAddBand
		'
		Me.cmdAddBand.Name = "cmdAddBand"
		Me.cmdAddBand.Size = New System.Drawing.Size(121, 25)
		Me.cmdAddBand.Location = New System.Drawing.Point(381, 2)
		Me.cmdAddBand.Caption = "Add a new Band "
		Me.cmdAddBand.TabIndex = 6
		'
		' cboFonts
		'
		Me.cboFonts.Name = "cboFonts"
		Me.cboFonts.Size = New System.Drawing.Size(457, 21)
		Me.cboFonts.Location = New System.Drawing.Point(41, 29)
		Me.cboFonts.TabIndex = 2
		Me.cboFonts.Text = "Combo1"
		'
		' Toolbar1
		'
		Me.Toolbar1.Name = "Toolbar1"
		Me.Toolbar1.Location = New System.Drawing.Point(11, 3)
		Me.Toolbar1.ButtonWidth = 609
		Me.Toolbar1.ImageList = imlToolbarIcons
		Me.Toolbar1.Size = New Size(2, 2)
		Me.Toolbar1.ToolStrip = Me.Toolbar1_Control
		Me.Toolbar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button1, Me.Toolbar1_Button2, Me.Toolbar1_Button3, Me.Toolbar1_Button4, Me.Toolbar1_Button5, Me.Toolbar1_Button6, Me.Toolbar1_Button7, Me.Toolbar1_Button8, Me.Toolbar1_Button9, Me.Toolbar1_Button10, Me.Toolbar1_Button11, Me.Toolbar1_Button12})
		'
		' Toolbar1_Control
		'
		Me.Toolbar1_Control.Name = "Toolbar1_Control"
		Me.Toolbar1_Control.Size = New System.Drawing.Size(364, 22)
		Me.Toolbar1_Control.Location = New System.Drawing.Point(11, 3)
		Me.Toolbar1_Control.TabIndex = 1
		Me.Toolbar1_Control.ImageList = imlToolbarIcons.ImageList
		Me.Toolbar1_Control.Dock = System.Windows.Forms.DockStyle.None
		'
		' imlToolbarIcons
		'
		Me.imlToolbarIcons.Name = "imlToolbarIcons"
		Me.imlToolbarIcons.ParentForm = Me
		Me.imlToolbarIcons.BackColor = FromOleColor6(CInt(-2147483643))
		Me.imlToolbarIcons.MaskColor = FromOleColor6(CInt(12632256))
		Me.imlToolbarIcons.Tag = "Key1=New;Key2=Open;Key3=Save;Key4=Print;Key5=Find;Key6=Undo;Key7=Redo;Key8=Bold;Key9=Italic;Key10=Underline;"
		Me.imlToolbarIcons.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlToolbarIcons.ImageStream = CType(resources.GetObject("imlToolbarIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' Toolbar1_Button1
		'
		Me.Toolbar1_Button1.Name = "Toolbar1_Button1"
		Me.Toolbar1_Button1.Tag = "Key=New;ImageKey=New;"
		Me.Toolbar1_Button1.ImageIndex = 0
		Me.Toolbar1_Button1.Width = 23
		Me.Toolbar1_Button1.Height = 24
		Me.Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button1.AutoSize = False
		Me.Toolbar1_Button1.ToolTipText = "New"
		'
		' Toolbar1_Button2
		'
		Me.Toolbar1_Button2.Name = "Toolbar1_Button2"
		Me.Toolbar1_Button2.Tag = "Key=Open;ImageKey=Open;"
		Me.Toolbar1_Button2.ImageIndex = 1
		Me.Toolbar1_Button2.Width = 23
		Me.Toolbar1_Button2.Height = 24
		Me.Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button2.AutoSize = False
		Me.Toolbar1_Button2.ToolTipText = "Open"
		'
		' Toolbar1_Button3
		'
		Me.Toolbar1_Button3.Name = "Toolbar1_Button3"
		Me.Toolbar1_Button3.Tag = "Key=Save;ImageKey=Save;"
		Me.Toolbar1_Button3.ImageIndex = 2
		Me.Toolbar1_Button3.Width = 23
		Me.Toolbar1_Button3.Height = 24
		Me.Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button3.AutoSize = False
		Me.Toolbar1_Button3.ToolTipText = "Save"
		'
		' Toolbar1_Button4
		'
		Me.Toolbar1_Button4.Name = "Toolbar1_Button4"
		Me.Toolbar1_Button4.Tag = "Style=3;"
		Me.Toolbar1_Button4.Width = 7
		Me.Toolbar1_Button4.Height = 24
		Me.Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button4.AutoSize = False
		'
		' Toolbar1_Button5
		'
		Me.Toolbar1_Button5.Name = "Toolbar1_Button5"
		Me.Toolbar1_Button5.Tag = "Key=Print;ImageKey=Print;"
		Me.Toolbar1_Button5.ImageIndex = 3
		Me.Toolbar1_Button5.Width = 23
		Me.Toolbar1_Button5.Height = 24
		Me.Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button5.AutoSize = False
		Me.Toolbar1_Button5.ToolTipText = "Print"
		'
		' Toolbar1_Button6
		'
		Me.Toolbar1_Button6.Name = "Toolbar1_Button6"
		Me.Toolbar1_Button6.Tag = "Key=Find;ImageKey=Find;"
		Me.Toolbar1_Button6.ImageIndex = 4
		Me.Toolbar1_Button6.Width = 23
		Me.Toolbar1_Button6.Height = 24
		Me.Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button6.AutoSize = False
		Me.Toolbar1_Button6.ToolTipText = "Find"
		'
		' Toolbar1_Button7
		'
		Me.Toolbar1_Button7.Name = "Toolbar1_Button7"
		Me.Toolbar1_Button7.Tag = "Key=Undo;ImageKey=Undo;"
		Me.Toolbar1_Button7.ImageIndex = 5
		Me.Toolbar1_Button7.Width = 23
		Me.Toolbar1_Button7.Height = 24
		Me.Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button7.AutoSize = False
		Me.Toolbar1_Button7.ToolTipText = "Undo"
		'
		' Toolbar1_Button8
		'
		Me.Toolbar1_Button8.Name = "Toolbar1_Button8"
		Me.Toolbar1_Button8.Tag = "Key=Redo;ImageKey=Redo;"
		Me.Toolbar1_Button8.ImageIndex = 6
		Me.Toolbar1_Button8.Width = 23
		Me.Toolbar1_Button8.Height = 24
		Me.Toolbar1_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button8.AutoSize = False
		Me.Toolbar1_Button8.ToolTipText = "Redo"
		'
		' Toolbar1_Button9
		'
		Me.Toolbar1_Button9.Name = "Toolbar1_Button9"
		Me.Toolbar1_Button9.Tag = "Style=3;"
		Me.Toolbar1_Button9.Width = 7
		Me.Toolbar1_Button9.Height = 24
		Me.Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button9.AutoSize = False
		'
		' Toolbar1_Button10
		'
		Me.Toolbar1_Button10.Name = "Toolbar1_Button10"
		Me.Toolbar1_Button10.Tag = "Key=Bold;ImageKey=Bold;"
		Me.Toolbar1_Button10.ImageIndex = 7
		Me.Toolbar1_Button10.Width = 23
		Me.Toolbar1_Button10.Height = 24
		Me.Toolbar1_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button10.AutoSize = False
		Me.Toolbar1_Button10.ToolTipText = "Bold"
		'
		' Toolbar1_Button11
		'
		Me.Toolbar1_Button11.Name = "Toolbar1_Button11"
		Me.Toolbar1_Button11.Tag = "Key=Italic;ImageKey=Italic;"
		Me.Toolbar1_Button11.ImageIndex = 8
		Me.Toolbar1_Button11.Width = 23
		Me.Toolbar1_Button11.Height = 24
		Me.Toolbar1_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button11.AutoSize = False
		Me.Toolbar1_Button11.ToolTipText = "Italic"
		'
		' Toolbar1_Button12
		'
		Me.Toolbar1_Button12.Name = "Toolbar1_Button12"
		Me.Toolbar1_Button12.Tag = "Key=Underline;ImageKey=Underline;"
		Me.Toolbar1_Button12.ImageIndex = 9
		Me.Toolbar1_Button12.Width = 23
		Me.Toolbar1_Button12.Height = 24
		Me.Toolbar1_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button12.AutoSize = False
		Me.Toolbar1_Button12.ToolTipText = "Underline"
		'
		' frmCoolbar
		'
		Me.Name = "frmCoolbar"
		Me.Caption = "Coolbar Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(504, 212)

		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Text1)
		Me.Picture1.Controls.Add(Label1)
		Me.Controls.Add(CoolBar1_Placeholder)
		Me.CoolBar1_Placeholder.Controls.Add(cmdAddBand)
		Me.CoolBar1_Placeholder.Controls.Add(cboFonts)
		Me.CoolBar1_Placeholder.Controls.Add(Toolbar1)
		Me.CoolBar1_Placeholder.Controls.Add(Toolbar1_Control)
		Me.CoolBar1_Placeholder.Controls.SetChildIndex(Me.Toolbar1, 0)
		Me.CoolBar1_Placeholder.Controls.SetChildIndex(Me.Toolbar1_Control, 0)
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imlToolbarIcons, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.CoolBar1_Placeholder.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
