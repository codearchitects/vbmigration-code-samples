<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_PrintPreview
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
		Me.ppi_PageNo = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(ppi_PageNo_001)
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
	Public ppi_PageNo As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents tbr_Preview As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents hsc_Scroll As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents vsc_Scroll As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents pic_Viewport As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pic_Preview As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pic_Shadow As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents iml_Preview As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents ppm_Page As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents ppi_PageNo_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents tbx_Page As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents btn_Page As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Close As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents tbr_Preview_Control As System.Windows.Forms.ToolStrip
	Public WithEvents tbr_Preview_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbr_Preview_Button2 As System.Windows.Forms.ToolStripSeparator

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_PrintPreview))
		Me.tbr_Preview = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.hsc_Scroll = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.vsc_Scroll = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.pic_Viewport = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pic_Preview = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pic_Shadow = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.iml_Preview = New CodeArchitects.VB6Library.VB6ImageList()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.ppm_Page = New CodeArchitects.VB6Library.VB6Menu()
		Me.ppi_PageNo_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.tbx_Page = New CodeArchitects.VB6Library.VB6TextBox()
		Me.btn_Page = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Close = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.tbr_Preview_Control = New System.Windows.Forms.ToolStrip()
		Me.tbr_Preview_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.tbr_Preview_Button2 = New System.Windows.Forms.ToolStripSeparator()
		Me.pic_Viewport.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.tbr_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.iml_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' tbr_Preview
		'
		Me.tbr_Preview.Name = "tbr_Preview"
		Me.tbr_Preview.Location = New System.Drawing.Point(0, 24)
		Me.tbr_Preview.ButtonWidth = 609
		Me.tbr_Preview.ButtonHeight = 582
		Me.tbr_Preview.ImageList = iml_Preview
		Me.tbr_Preview.Size = New System.Drawing.Size(2, 2)
		Me.tbr_Preview.ToolStrip = Me.tbr_Preview_Control
		Me.tbr_Preview_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbr_Preview_Button1, Me.tbr_Preview_Button2})
		'
		' hsc_Scroll
		'
		Me.hsc_Scroll.Name = "hsc_Scroll"
		Me.hsc_Scroll.Size = New System.Drawing.Size(81, 17)
		Me.hsc_Scroll.Location = New System.Drawing.Point(0, 168)
		Me.hsc_Scroll.LargeChange = 50
		Me.hsc_Scroll.SmallChange = 30
		Me.hsc_Scroll.TabIndex = 2
		Me.hsc_Scroll.Max = 32767
		Me.hsc_Scroll.TabStop = True
		'
		' vsc_Scroll
		'
		Me.vsc_Scroll.Name = "vsc_Scroll"
		Me.vsc_Scroll.Size = New System.Drawing.Size(17, 81)
		Me.vsc_Scroll.Location = New System.Drawing.Point(200, 48)
		Me.vsc_Scroll.LargeChange = 50
		Me.vsc_Scroll.SmallChange = 30
		Me.vsc_Scroll.TabIndex = 1
		Me.vsc_Scroll.Max = 32767
		Me.vsc_Scroll.TabStop = True
		'
		' pic_Viewport
		'
		Me.pic_Viewport.Name = "pic_Viewport"
		Me.pic_Viewport.Size = New System.Drawing.Size(201, 121)
		Me.pic_Viewport.Location = New System.Drawing.Point(0, 48)
		Me.pic_Viewport.BackColor = FromOleColor6(CInt(&H00808080))
		Me.pic_Viewport.TabIndex = 0
		Me.pic_Viewport.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pic_Viewport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pic_Viewport.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' pic_Preview
		'
		Me.pic_Preview.Name = "pic_Preview"
		Me.pic_Preview.Size = New System.Drawing.Size(81, 33)
		Me.pic_Preview.Location = New System.Drawing.Point(0, 8)
		Me.pic_Preview.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pic_Preview.AutoRedraw = True
		Me.pic_Preview.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.pic_Preview.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pic_Preview.TabIndex = 8
		Me.pic_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pic_Preview.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' pic_Shadow
		'
		Me.pic_Shadow.Name = "pic_Shadow"
		Me.pic_Shadow.Size = New System.Drawing.Size(81, 33)
		Me.pic_Shadow.Location = New System.Drawing.Point(4, 12)
		Me.pic_Shadow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pic_Shadow.AutoRedraw = True
		Me.pic_Shadow.BackColor = FromOleColor6(CInt(&H00000000))
		Me.pic_Shadow.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pic_Shadow.TabIndex = 7
		Me.pic_Shadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pic_Shadow.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' iml_Preview
		'
		Me.iml_Preview.Name = "iml_Preview"
		Me.iml_Preview.ParentForm = Me
		Me.iml_Preview.Name6 = "iml_Preview"
		Me.iml_Preview.BackColor = FromOleColor6(CInt(-2147483643))
		Me.iml_Preview.MaskColor = FromOleColor6(CInt(12632256))
		Me.iml_Preview.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.iml_Preview.ImageStream = CType(resources.GetObject("iml_Preview.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' ppm_Page
		'
		Me.ppm_Page.Name = "ppm_Page"
		Me.ppm_Page.Caption = "Page"
		Me.ppm_Page.Visible = False
		'
		' ppi_PageNo_001
		'
		Me.ppi_PageNo_001.Name = "ppi_PageNo_001"
		Me.ppi_PageNo_001.Caption = "1"
		'
		' tbx_Page
		'
		Me.tbx_Page.Name = "tbx_Page"
		Me.tbx_Page.Size = New System.Drawing.Size(57, 19)
		Me.tbx_Page.Location = New System.Drawing.Point(92, 26)
		Me.tbx_Page.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_Page.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.tbx_Page.TabIndex = 4
		'
		' btn_Page
		'
		Me.btn_Page.Name = "btn_Page"
		Me.btn_Page.Size = New System.Drawing.Size(57, 19)
		Me.btn_Page.Location = New System.Drawing.Point(32, 26)
		Me.btn_Page.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Page.Caption = "Page"
		Me.btn_Page.TabIndex = 5
		Me.btn_Page.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_Close
		'
		Me.btn_Close.Name = "btn_Close"
		Me.btn_Close.Size = New System.Drawing.Size(57, 19)
		Me.btn_Close.Location = New System.Drawing.Point(152, 26)
		Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Close.Caption = "Close"
		Me.btn_Close.TabIndex = 6
		Me.btn_Close.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' tbr_Preview_Control
		'
		Me.tbr_Preview_Control.Name = "tbr_Preview_Control"
		Me.tbr_Preview_Control.Size = New System.Drawing.Size(312, 24)
		Me.tbr_Preview_Control.Location = New System.Drawing.Point(0, 24)
		Me.tbr_Preview_Control.TabIndex = 3
		Me.tbr_Preview_Control.ImageList = iml_Preview.ImageList
		Me.tbr_Preview_Control.Dock = System.Windows.Forms.DockStyle.Top
		'
		' tbr_Preview_Button1
		'
		Me.tbr_Preview_Button1.Name = "tbr_Preview_Button1"
		Me.tbr_Preview_Button1.ImageIndex = 0
		Me.tbr_Preview_Button1.Width = 23
		Me.tbr_Preview_Button1.Height = 22
		Me.tbr_Preview_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbr_Preview_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbr_Preview_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbr_Preview_Button1.AutoSize = False
		'
		' tbr_Preview_Button2
		'
		Me.tbr_Preview_Button2.Name = "tbr_Preview_Button2"
		Me.tbr_Preview_Button2.Tag = "Style=3;"
		Me.tbr_Preview_Button2.Width = 7
		Me.tbr_Preview_Button2.Height = 22
		Me.tbr_Preview_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbr_Preview_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbr_Preview_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbr_Preview_Button2.AutoSize = False
		'
		' frm_PrintPreview
		'
		Me.Name = "frm_PrintPreview"
		Me.Caption = "Print Preview"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.WindowState = CodeArchitects.VB6Library.VBRUN.FormWindowStateConstants.vbMaximized
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 30)
		Me.ClientSize = New System.Drawing.Size(312, 237)

		Me.Controls.Add(tbr_Preview)
		Me.Controls.Add(hsc_Scroll)
		Me.Controls.Add(vsc_Scroll)
		Me.Controls.Add(pic_Viewport)
		Me.pic_Viewport.Controls.Add(pic_Preview)
		Me.pic_Viewport.Controls.Add(pic_Shadow)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(ppm_Page)
		Me.ppm_Page.DropDownItems.Add(ppi_PageNo_001)
		Me.Controls.Add(tbx_Page)
		Me.Controls.Add(btn_Page)
		Me.Controls.Add(btn_Close)
		Me.Controls.Add(tbr_Preview_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.tbr_Preview, 0)
		Me.Controls.SetChildIndex(Me.tbr_Preview_Control, 0)
		Me.Controls.SetChildIndex(Me.tbx_Page, 0)
		Me.Controls.SetChildIndex(Me.btn_Page, 0)
		Me.Controls.SetChildIndex(Me.btn_Close, 0)
		CType(Me.tbr_Preview, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.iml_Preview, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pic_Viewport.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
