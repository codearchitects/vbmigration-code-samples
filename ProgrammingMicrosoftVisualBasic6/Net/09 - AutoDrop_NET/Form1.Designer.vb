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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_005, Label1_004, Label1_003, Label1_002, Label1_001, Label1_000)
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
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents Dir1 As CodeArchitects.VB6Library.VB6DirListBox
	Public WithEvents File1 As CodeArchitects.VB6Library.VB6FileListBox
	Public WithEvents List1 As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents RichTextBox1 As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents Label1_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Dir1 = New CodeArchitects.VB6Library.VB6DirListBox()
		Me.File1 = New CodeArchitects.VB6Library.VB6FileListBox()
		Me.List1 = New CodeArchitects.VB6Library.VB6ListBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.RichTextBox1 = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.Label1_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Dir1
		'
		Me.Dir1.Name = "Dir1"
		Me.Dir1.Size = New System.Drawing.Size(233, 51)
		Me.Dir1.Location = New System.Drawing.Point(472, 192)
		Me.Dir1.TabIndex = 11
		'
		' File1
		'
		Me.File1.Name = "File1"
		Me.File1.Size = New System.Drawing.Size(233, 58)
		Me.File1.Location = New System.Drawing.Point(472, 256)
		Me.File1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.File1.Pattern = "*.txt;*.doc;*.rtf"
		Me.File1.TabIndex = 10
		'
		' List1
		'
		Me.List1.Name = "List1"
		Me.List1.Size = New System.Drawing.Size(233, 121)
		Me.List1.Location = New System.Drawing.Point(472, 32)
		Me.List1.MultiSelect = CodeArchitects.VB6Library.VBRUN.MultiSelectConstants.vbMultiSelectExtended
		Me.List1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.List1.TabIndex = 8
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(217, 121)
		Me.Picture1.Location = New System.Drawing.Point(8, 192)
		Me.Picture1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.Picture1.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.Picture1.Picture = CType(resources.GetObject("Picture1.Picture"), System.Drawing.Image)
		Me.Picture1.TabIndex = 6
		Me.Picture1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(217, 121)
		Me.Text1.Location = New System.Drawing.Point(240, 32)
		Me.Text1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.MultiLine = -1
		Me.Text1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.Text1.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.Text1.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.Text1.TabIndex = 1
		'
		' RichTextBox1
		'
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(217, 121)
		Me.RichTextBox1.Location = New System.Drawing.Point(8, 32)
		Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Enabled = True
		Me.RichTextBox1.TextRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1040{\fonttbl{\f0\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "\viewkind4\uc1\pard\f0\fs20 " & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		'
		' Label1_005
		'
		Me.Label1_005.Name = "Label1_005"
		Me.Label1_005.Size = New System.Drawing.Size(233, 25)
		Me.Label1_005.Location = New System.Drawing.Point(472, 168)
		Me.Label1_005.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_005.Caption = "FileListBox (source for external progs)"
		Me.Label1_005.TabIndex = 9
		'
		' Label1_004
		'
		Me.Label1_004.Name = "Label1_004"
		Me.Label1_004.Size = New System.Drawing.Size(233, 25)
		Me.Label1_004.Location = New System.Drawing.Point(472, 8)
		Me.Label1_004.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_004.Caption = "Multiselect ListBox (source only)"
		Me.Label1_004.TabIndex = 7
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(217, 121)
		Me.Image1.Location = New System.Drawing.Point(240, 192)
		Me.Image1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Image1.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.Image1.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.Image1.Stretch = True
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(217, 25)
		Me.Label1_003.Location = New System.Drawing.Point(240, 168)
		Me.Label1_003.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_003.Caption = "Image"
		Me.Label1_003.TabIndex = 5
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(217, 25)
		Me.Label1_002.Location = New System.Drawing.Point(8, 168)
		Me.Label1_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_002.Caption = "PictureBox"
		Me.Label1_002.TabIndex = 4
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(217, 25)
		Me.Label1_001.Location = New System.Drawing.Point(240, 8)
		Me.Label1_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_001.Caption = "Multiline TextBox"
		Me.Label1_001.TabIndex = 3
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(217, 25)
		Me.Label1_000.Location = New System.Drawing.Point(8, 8)
		Me.Label1_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_000.Caption = "RichTextBox"
		Me.Label1_000.TabIndex = 2
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Automatic Drag And Drop Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(11, 30)
		Me.ClientSize = New System.Drawing.Size(714, 326)

		Me.Controls.Add(Dir1)
		Me.Controls.Add(File1)
		Me.Controls.Add(List1)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(RichTextBox1)
		Me.Controls.Add(Label1_005)
		Me.Controls.Add(Label1_004)
		Me.Controls.Add(Image1)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
