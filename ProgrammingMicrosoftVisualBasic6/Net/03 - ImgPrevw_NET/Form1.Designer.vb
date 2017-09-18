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
	Public WithEvents picPreview As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents optTile As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optStretch As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optActual As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents File1 As CodeArchitects.VB6Library.VB6FileListBox
	Public WithEvents Dir1 As CodeArchitects.VB6Library.VB6DirListBox
	Public WithEvents Drive1 As CodeArchitects.VB6Library.VB6DriveListBox
	Public WithEvents imgHidden As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.picPreview = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.optTile = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optStretch = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optActual = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.File1 = New CodeArchitects.VB6Library.VB6FileListBox()
		Me.Dir1 = New CodeArchitects.VB6Library.VB6DirListBox()
		Me.Drive1 = New CodeArchitects.VB6Library.VB6DriveListBox()
		Me.imgHidden = New CodeArchitects.VB6Library.VB6Image()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.File1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgHidden, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' picPreview
		'
		Me.picPreview.Name = "picPreview"
		Me.picPreview.Size = New System.Drawing.Size(417, 329)
		Me.picPreview.Location = New System.Drawing.Point(208, 32)
		Me.picPreview.TabIndex = 9
		Me.picPreview.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' optTile
		'
		Me.optTile.Name = "optTile"
		Me.optTile.Size = New System.Drawing.Size(121, 25)
		Me.optTile.Location = New System.Drawing.Point(464, 8)
		Me.optTile.Caption = "&3. Tile"
		Me.optTile.TabIndex = 8
		'
		' optStretch
		'
		Me.optStretch.Name = "optStretch"
		Me.optStretch.Size = New System.Drawing.Size(121, 25)
		Me.optStretch.Location = New System.Drawing.Point(336, 8)
		Me.optStretch.Caption = "&2. Stretch"
		Me.optStretch.TabIndex = 7
		'
		' optActual
		'
		Me.optActual.Name = "optActual"
		Me.optActual.Size = New System.Drawing.Size(113, 25)
		Me.optActual.Location = New System.Drawing.Point(208, 8)
		Me.optActual.Caption = "&1 Actual size"
		Me.optActual.TabIndex = 6
		Me.optActual.Value = True
		'
		' File1
		'
		Me.File1.Name = "File1"
		Me.File1.Size = New System.Drawing.Size(185, 134)
		Me.File1.Location = New System.Drawing.Point(8, 224)
		Me.File1.TabIndex = 5
		'
		' Dir1
		'
		Me.Dir1.Name = "Dir1"
		Me.Dir1.Size = New System.Drawing.Size(185, 96)
		Me.Dir1.Location = New System.Drawing.Point(8, 88)
		Me.Dir1.TabIndex = 3
		'
		' Drive1
		'
		Me.Drive1.Name = "Drive1"
		Me.Drive1.Size = New System.Drawing.Size(185, 24)
		Me.Drive1.Location = New System.Drawing.Point(8, 32)
		Me.Drive1.TabIndex = 1
		'
		' imgHidden
		'
		Me.imgHidden.Name = "imgHidden"
		Me.imgHidden.Size = New System.Drawing.Size(49, 41)
		Me.imgHidden.Location = New System.Drawing.Point(168, 0)
		Me.imgHidden.Visible = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(185, 25)
		Me.Label3.Location = New System.Drawing.Point(8, 200)
		Me.Label3.Caption = "&File"
		Me.Label3.TabIndex = 4
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(161, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.Caption = "&Path"
		Me.Label2.TabIndex = 2
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(161, 25)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Caption = "&Drive"
		Me.Label1.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Image Preview"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(633, 369)

		Me.Controls.Add(picPreview)
		Me.Controls.Add(optTile)
		Me.Controls.Add(optStretch)
		Me.Controls.Add(optActual)
		Me.Controls.Add(File1)
		Me.Controls.Add(Dir1)
		Me.Controls.Add(Drive1)
		Me.Controls.Add(imgHidden)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.File1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dir1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Drive1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgHidden, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
