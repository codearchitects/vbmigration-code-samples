<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PlayList
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
	Public WithEvents Piclst As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lstPL As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents PicClose As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Close_Renamed As CodeArchitects.VB6Library.VB6Image
	Public WithEvents PicMMask As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents lblen As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PlayList))
		Me.Piclst = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lstPL = New CodeArchitects.VB6Library.VB6ListBox()
		Me.PicClose = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Close_Renamed = New CodeArchitects.VB6Library.VB6Image()
		Me.PicMMask = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.lblen = New CodeArchitects.VB6Library.VB6Label()
		Me.Piclst.SuspendLayout()
		Me.PicClose.SuspendLayout()
		Me.PicMMask.SuspendLayout()
		CType(Me.Close_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Piclst
		'
		Me.Piclst.Name = "Piclst"
		Me.Piclst.Size = New System.Drawing.Size(139, 210)
		Me.Piclst.Location = New System.Drawing.Point(45, 45)
		Me.Piclst.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Piclst.TabIndex = 3
		Me.Piclst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Piclst.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Piclst.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lstPL
		'
		Me.lstPL.Name = "lstPL"
		Me.lstPL.Size = New System.Drawing.Size(139, 210)
		Me.lstPL.Location = New System.Drawing.Point(0, 0)
		Me.lstPL.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lstPL.BackColor = FromOleColor6(CInt(&H00F0F0F0))
		Me.lstPL.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.lstPL.TabIndex = 4
		'
		' PicClose
		'
		Me.PicClose.Name = "PicClose"
		Me.PicClose.Size = New System.Drawing.Size(70, 17)
		Me.PicClose.Location = New System.Drawing.Point(0, 0)
		Me.PicClose.AutoRedraw = True
		Me.PicClose.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.PicClose.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.PicClose.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.PicClose.TabIndex = 1
		Me.PicClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PicClose.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Close_Renamed
		'
		Me.Close_Renamed.Name = "Close_Renamed"
		Me.Close_Renamed.Size = New System.Drawing.Size(11, 10)
		Me.Close_Renamed.Location = New System.Drawing.Point(59, 8)
		Me.Close_Renamed.Stretch = False
		'
		' PicMMask
		'
		Me.PicMMask.Name = "PicMMask"
		Me.PicMMask.Size = New System.Drawing.Size(226, 302)
		Me.PicMMask.Location = New System.Drawing.Point(0, 0)
		Me.PicMMask.AutoRedraw = True
		Me.PicMMask.AutoSize = True
		Me.PicMMask.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.PicMMask.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.PicMMask.Enabled = False
		Me.PicMMask.Picture = CType(resources.GetObject("PicMMask.Picture"), System.Drawing.Image)
		Me.PicMMask.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.PicMMask.TabIndex = 0
		Me.PicMMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PicMMask.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Shape1.Height = 210
		Me.Shape1.Left = 45
		Me.Shape1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeRoundedRectangle
		Me.Shape1.Top = 45
		Me.Shape1.Width = 139
		Me.Shape1.Container = PicMMask
		'
		' lblen
		'
		Me.lblen.Name = "lblen"
		Me.lblen.Size = New System.Drawing.Size(32, 13)
		Me.lblen.Location = New System.Drawing.Point(77, 138)
		Me.lblen.AutoSize = True
		Me.lblen.Caption = "Label1"
		Me.lblen.TabIndex = 2
		Me.lblen.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' PlayList
		'
		Me.Name = "PlayList"
		Me.BackColor = FromOleColor6(CInt(&H0000FFFF))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "Playlist"
		Me.DrawWidth = 10
		Me.Icon = Nothing
		Me.MaxButton = False
		Me.MinButton = False
		Me.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(235, 308)

		Me.Controls.Add(Piclst)
		Me.Piclst.Controls.Add(lstPL)
		Me.Controls.Add(PicClose)
		Me.PicClose.Controls.Add(Close_Renamed)
		Me.Controls.Add(PicMMask)
		Me.Controls.Add(lblen)
		CType(Me.Close_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Piclst.ResumeLayout(False)
		Me.PicClose.ResumeLayout(False)
		Me.PicMMask.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
