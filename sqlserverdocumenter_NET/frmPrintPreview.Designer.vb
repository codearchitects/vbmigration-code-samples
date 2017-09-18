<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintPreview
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
	Public WithEvents fmePrintPreview As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdClose As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrint As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents wbrPrintPreview As CodeArchitects.VB6Library.VB6WebBrowser

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintPreview))
		Me.fmePrintPreview = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdClose = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrint = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.wbrPrintPreview = New CodeArchitects.VB6Library.VB6WebBrowser()
		Me.fmePrintPreview.SuspendLayout()
		Me.SuspendLayout()
		'
		' fmePrintPreview
		'
		Me.fmePrintPreview.Name = "fmePrintPreview"
		Me.fmePrintPreview.Size = New System.Drawing.Size(649, 45)
		Me.fmePrintPreview.Location = New System.Drawing.Point(4, 0)
		Me.fmePrintPreview.TabIndex = 1
		Me.fmePrintPreview.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdClose
		'
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(101, 21)
		Me.cmdClose.Location = New System.Drawing.Point(116, 16)
		Me.cmdClose.Caption = "Close"
		Me.cmdClose.TabIndex = 3
		Me.cmdClose.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdPrint
		'
		Me.cmdPrint.Name = "cmdPrint"
		Me.cmdPrint.Size = New System.Drawing.Size(101, 21)
		Me.cmdPrint.Location = New System.Drawing.Point(8, 16)
		Me.cmdPrint.Caption = "Print"
		Me.cmdPrint.TabIndex = 2
		Me.cmdPrint.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' wbrPrintPreview
		'
		Me.wbrPrintPreview.Name = "wbrPrintPreview"
		Me.wbrPrintPreview.Size = New System.Drawing.Size(649, 457)
		Me.wbrPrintPreview.Location = New System.Drawing.Point(4, 48)
		Me.wbrPrintPreview.TabIndex = 0
		Me.wbrPrintPreview.TabStop = False
		Me.wbrPrintPreview.Silent = False
		Me.wbrPrintPreview.RegisterAsDropTarget = True
		'
		' frmPrintPreview
		'
		Me.Name = "frmPrintPreview"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Print Preview"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.Location = New System.Drawing.Point(194, 165)
		Me.ClientSize = New System.Drawing.Size(657, 513)

		Me.Controls.Add(fmePrintPreview)
		Me.fmePrintPreview.Controls.Add(cmdClose)
		Me.fmePrintPreview.Controls.Add(cmdPrint)
		Me.Controls.Add(wbrPrintPreview)
		Me.fmePrintPreview.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
