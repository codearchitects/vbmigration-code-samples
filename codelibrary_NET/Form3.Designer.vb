<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form3
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
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Combo1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Toolbar1 As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents Toolbar2 As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Toolbar1_Control As System.Windows.Forms.ToolStrip
	Public WithEvents Toolbar2_Control As System.Windows.Forms.ToolStrip
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents ImageList2 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar2_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar2_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar2_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar2_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar2_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar2_Button6 As System.Windows.Forms.ToolStripButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Combo1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Toolbar1 = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.Toolbar2 = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Toolbar1_Control = New System.Windows.Forms.ToolStrip()
		Me.Toolbar2_Control = New System.Windows.Forms.ToolStrip()
		Me.Text1 = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.ImageList2 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar2_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar2_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar2_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar2_Button4 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar2_Button5 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar2_Button6 = New System.Windows.Forms.ToolStripButton()
		Me.Frame1.SuspendLayout()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Toolbar2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		Me.CommonDialog1.Name6 = "CommonDialog1"
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.Name6 = "ImageList1"
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(775, 33)
		Me.Frame1.Location = New System.Drawing.Point(1, -8)
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.TabIndex = 5
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Combo1
		'
		Me.Combo1.Name = "Combo1"
		Me.Combo1.Size = New System.Drawing.Size(47, 21)
		Me.Combo1.Location = New System.Drawing.Point(630, 8)
		Me.Combo1.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.Combo1.TabIndex = 4
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(353, 19)
		Me.Text2.Location = New System.Drawing.Point(48, 10)
		Me.Text2.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Text2.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Text2.TabIndex = 0
		'
		' Toolbar1
		'
		Me.Toolbar1.Name = "Toolbar1"
		Me.Toolbar1.Location = New System.Drawing.Point(402, 8)
		Me.Toolbar1.ButtonWidth = 609
		Me.Toolbar1.ButtonHeight = 582
		Me.Toolbar1.ImageList = ImageList1
		Me.Toolbar1.Size = New System.Drawing.Size(2, 2)
		Me.Toolbar1.ToolStrip = Me.Toolbar1_Control
		Me.Toolbar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button1})
		'
		' Toolbar2
		'
		Me.Toolbar2.Name = "Toolbar2"
		Me.Toolbar2.Location = New System.Drawing.Point(441, 8)
		Me.Toolbar2.ButtonWidth = 609
		Me.Toolbar2.ButtonHeight = 582
		Me.Toolbar2.ImageList = ImageList2
		Me.Toolbar2.Size = New System.Drawing.Size(2, 2)
		Me.Toolbar2.ToolStrip = Me.Toolbar2_Control
		Me.Toolbar2_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar2_Button1, Me.Toolbar2_Button2, Me.Toolbar2_Button3, Me.Toolbar2_Button4, Me.Toolbar2_Button5, Me.Toolbar2_Button6})
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(71, 22)
		Me.Label2.Location = New System.Drawing.Point(574, 11)
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Font Size"
		Me.Label2.TabIndex = 7
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 13)
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Title:"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.TabIndex = 6
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Toolbar1_Control
		'
		Me.Toolbar1_Control.Name = "Toolbar1_Control"
		Me.Toolbar1_Control.Size = New System.Drawing.Size(24, 22)
		Me.Toolbar1_Control.Location = New System.Drawing.Point(402, 8)
		Me.Toolbar1_Control.TabIndex = 2
		Me.Toolbar1_Control.ImageList = ImageList1.ImageList
		Me.Toolbar1_Control.Dock = System.Windows.Forms.DockStyle.None
		'
		' Toolbar2_Control
		'
		Me.Toolbar2_Control.Name = "Toolbar2_Control"
		Me.Toolbar2_Control.Size = New System.Drawing.Size(126, 22)
		Me.Toolbar2_Control.Location = New System.Drawing.Point(441, 8)
		Me.Toolbar2_Control.TabIndex = 3
		Me.Toolbar2_Control.ImageList = ImageList2.ImageList
		Me.Toolbar2_Control.Dock = System.Windows.Forms.DockStyle.None
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(137, 137)
		Me.Text1.Location = New System.Drawing.Point(8, 40)
		Me.Text1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.TabIndex = 1
		Me.Text1.Enabled = True
		Me.Text1.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfBoth
		Me.Text1.TextRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Courier New;}}" & ControlChars.CrLf & "\viewkind4\uc1\pard\f0\fs20 " & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		Me.Text1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.Text1.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		'
		' ImageList2
		'
		Me.ImageList2.Name = "ImageList2"
		Me.ImageList2.ParentForm = Me
		Me.ImageList2.Name6 = "ImageList2"
		Me.ImageList2.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList2.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList2.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' Toolbar1_Button1
		'
		Me.Toolbar1_Button1.Name = "Toolbar1_Button1"
		Me.Toolbar1_Button1.ImageIndex = 0
		Me.Toolbar1_Button1.Width = 23
		Me.Toolbar1_Button1.Height = 22
		Me.Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button1.AutoSize = False
		Me.Toolbar1_Button1.ToolTipText = "Save"
		'
		' Toolbar2_Button1
		'
		Me.Toolbar2_Button1.Name = "Toolbar2_Button1"
		Me.Toolbar2_Button1.ImageIndex = 0
		Me.Toolbar2_Button1.Width = 23
		Me.Toolbar2_Button1.Height = 22
		Me.Toolbar2_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button1.AutoSize = False
		Me.Toolbar2_Button1.ToolTipText = "Bold"
		'
		' Toolbar2_Button2
		'
		Me.Toolbar2_Button2.Name = "Toolbar2_Button2"
		Me.Toolbar2_Button2.ImageIndex = 1
		Me.Toolbar2_Button2.Width = 23
		Me.Toolbar2_Button2.Height = 22
		Me.Toolbar2_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button2.AutoSize = False
		Me.Toolbar2_Button2.ToolTipText = "Italic"
		'
		' Toolbar2_Button3
		'
		Me.Toolbar2_Button3.Name = "Toolbar2_Button3"
		Me.Toolbar2_Button3.ImageIndex = 2
		Me.Toolbar2_Button3.Width = 23
		Me.Toolbar2_Button3.Height = 22
		Me.Toolbar2_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button3.AutoSize = False
		Me.Toolbar2_Button3.ToolTipText = "Underline"
		'
		' Toolbar2_Button4
		'
		Me.Toolbar2_Button4.Name = "Toolbar2_Button4"
		Me.Toolbar2_Button4.ImageIndex = 3
		Me.Toolbar2_Button4.Width = 23
		Me.Toolbar2_Button4.Height = 22
		Me.Toolbar2_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button4.AutoSize = False
		Me.Toolbar2_Button4.ToolTipText = "Normal"
		'
		' Toolbar2_Button5
		'
		Me.Toolbar2_Button5.Name = "Toolbar2_Button5"
		Me.Toolbar2_Button5.Tag = "Style=3;"
		Me.Toolbar2_Button5.Width = 7
		Me.Toolbar2_Button5.Height = 22
		Me.Toolbar2_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button5.AutoSize = False
		'
		' Toolbar2_Button6
		'
		Me.Toolbar2_Button6.Name = "Toolbar2_Button6"
		Me.Toolbar2_Button6.ImageIndex = 4
		Me.Toolbar2_Button6.Width = 23
		Me.Toolbar2_Button6.Height = 22
		Me.Toolbar2_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar2_Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar2_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar2_Button6.AutoSize = False
		Me.Toolbar2_Button6.ToolTipText = "Color"
		'
		' Form3
		'
		Me.Name = "Form3"
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Add New File"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(702, 513)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Combo1)
		Me.Frame1.Controls.Add(Text2)
		Me.Frame1.Controls.Add(Toolbar1)
		Me.Frame1.Controls.Add(Toolbar2)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Toolbar1_Control)
		Me.Frame1.Controls.Add(Toolbar2_Control)
		Me.Controls.Add(Text1)
		Me.Frame1.Controls.SetChildIndex(Me.Toolbar2, 0)
		Me.Frame1.Controls.SetChildIndex(Me.Toolbar2_Control, 0)
		Me.Frame1.Controls.SetChildIndex(Me.Toolbar1, 0)
		Me.Frame1.Controls.SetChildIndex(Me.Toolbar1_Control, 0)
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Toolbar2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
