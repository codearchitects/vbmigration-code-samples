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
	Public WithEvents cmdShow As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents fraFlip As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdBoth As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdVertical As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdHorizontal As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cboDissolve As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents fraZoom As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cboZoom As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents chkTile As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents picDest As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents picSource As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdShow = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraFlip = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdBoth = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdVertical = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdHorizontal = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cboDissolve = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.fraZoom = New CodeArchitects.VB6Library.VB6Frame()
		Me.cboZoom = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.chkTile = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.picDest = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.picSource = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraFlip.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraZoom.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdShow
		'
		Me.cmdShow.Name = "cmdShow"
		Me.cmdShow.Size = New System.Drawing.Size(121, 25)
		Me.cmdShow.Location = New System.Drawing.Point(472, 344)
		Me.cmdShow.Caption = "&Show"
		Me.cmdShow.TabIndex = 11
		Me.AcceptButton = Me.cmdShow
		Me.cmdShow.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' fraFlip
		'
		Me.fraFlip.Name = "fraFlip"
		Me.fraFlip.Size = New System.Drawing.Size(169, 137)
		Me.fraFlip.Location = New System.Drawing.Point(448, 184)
		Me.fraFlip.Caption = "Filp"
		Me.fraFlip.TabIndex = 7
		'
		' cmdBoth
		'
		Me.cmdBoth.Name = "cmdBoth"
		Me.cmdBoth.Size = New System.Drawing.Size(121, 25)
		Me.cmdBoth.Location = New System.Drawing.Point(24, 88)
		Me.cmdBoth.Caption = "&Both"
		Me.cmdBoth.TabIndex = 10
		'
		' cmdVertical
		'
		Me.cmdVertical.Name = "cmdVertical"
		Me.cmdVertical.Size = New System.Drawing.Size(121, 25)
		Me.cmdVertical.Location = New System.Drawing.Point(24, 56)
		Me.cmdVertical.Caption = "&Vertical"
		Me.cmdVertical.TabIndex = 9
		'
		' cmdHorizontal
		'
		Me.cmdHorizontal.Name = "cmdHorizontal"
		Me.cmdHorizontal.Size = New System.Drawing.Size(121, 25)
		Me.cmdHorizontal.Location = New System.Drawing.Point(24, 24)
		Me.cmdHorizontal.Caption = "&Horizontal"
		Me.cmdHorizontal.TabIndex = 8
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(177, 65)
		Me.Frame1.Location = New System.Drawing.Point(448, 0)
		Me.Frame1.Caption = "&Effects"
		Me.Frame1.TabIndex = 5
		'
		' cboDissolve
		'
		Me.cboDissolve.Name = "cboDissolve"
		Me.cboDissolve.Size = New System.Drawing.Size(153, 24)
		Me.cboDissolve.Location = New System.Drawing.Point(8, 24)
		Me.cboDissolve.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboDissolve.TabIndex = 6
		Me.cboDissolve.ItemDataValues = "Appear\r0\rScroll\ from\ Left\r0\rScroll\ from\ Right\r0\rScroll\ from\ Top\r0\rScroll\ from\ Bottom\r0\rRoll\ from\ Left\r0\rRoll\ from\ Right\r0\rRoll\ from\ Top\r0\rRoll\ from\ Bottom\r0\rExplode\ from\ Center\r0\rMosaic\r0"
		'
		' fraZoom
		'
		Me.fraZoom.Name = "fraZoom"
		Me.fraZoom.Size = New System.Drawing.Size(177, 97)
		Me.fraZoom.Location = New System.Drawing.Point(448, 72)
		Me.fraZoom.Caption = "&Zoom"
		Me.fraZoom.TabIndex = 2
		'
		' cboZoom
		'
		Me.cboZoom.Name = "cboZoom"
		Me.cboZoom.Size = New System.Drawing.Size(153, 24)
		Me.cboZoom.Location = New System.Drawing.Point(8, 32)
		Me.cboZoom.TabIndex = 4
		Me.cboZoom.Text = "100%"
		Me.cboZoom.ItemDataValues = "25%\r0\r50%\r0\r75%\r0\r100%\r0\r125%\r0\r150%\r0\r200%\r0\r300%\r0\r400%\r0\rFit\ Width\r0\rFit\ Height\r0\rFit\ Page\r0\rFit\ Page\ \(distorsion\)\r0"
		'
		' chkTile
		'
		Me.chkTile.Name = "chkTile"
		Me.chkTile.Size = New System.Drawing.Size(137, 17)
		Me.chkTile.Location = New System.Drawing.Point(8, 64)
		Me.chkTile.Caption = "&Tile bitmap"
		Me.chkTile.TabIndex = 3
		'
		' picDest
		'
		Me.picDest.Name = "picDest"
		Me.picDest.Size = New System.Drawing.Size(425, 361)
		Me.picDest.Location = New System.Drawing.Point(8, 8)
		Me.picDest.TabIndex = 1
		Me.picDest.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' picSource
		'
		Me.picSource.Name = "picSource"
		Me.picSource.Size = New System.Drawing.Size(260, 260)
		Me.picSource.Location = New System.Drawing.Point(208, 256)
		Me.picSource.AutoSize = True
		Me.picSource.Picture = CType(resources.GetObject("picSource.Picture"), System.Drawing.Image)
		Me.picSource.TabIndex = 0
		Me.picSource.Visible = False
		Me.picSource.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "PaintPicture Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(640, 395)

		Me.Controls.Add(cmdShow)
		Me.Controls.Add(fraFlip)
		Me.fraFlip.Controls.Add(cmdBoth)
		Me.fraFlip.Controls.Add(cmdVertical)
		Me.fraFlip.Controls.Add(cmdHorizontal)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cboDissolve)
		Me.Controls.Add(fraZoom)
		Me.fraZoom.Controls.Add(cboZoom)
		Me.fraZoom.Controls.Add(chkTile)
		Me.Controls.Add(picDest)
		Me.Controls.Add(picSource)
		Me.fraFlip.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraZoom.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
