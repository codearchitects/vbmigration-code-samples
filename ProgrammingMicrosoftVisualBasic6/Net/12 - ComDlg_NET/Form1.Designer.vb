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
	Public WithEvents cmdOpenMulti As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOpen As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSave As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrinter As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents RichTextBox1 As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents cmdFont As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdColor As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdOpenMulti = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOpen = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSave = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrinter = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.RichTextBox1 = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.cmdFont = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdColor = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SuspendLayout()
		'
		' cmdOpenMulti
		'
		Me.cmdOpenMulti.Name = "cmdOpenMulti"
		Me.cmdOpenMulti.Size = New System.Drawing.Size(81, 25)
		Me.cmdOpenMulti.Location = New System.Drawing.Point(400, 0)
		Me.cmdOpenMulti.Caption = "Open &Multi"
		Me.cmdOpenMulti.TabIndex = 6
		'
		' cmdOpen
		'
		Me.cmdOpen.Name = "cmdOpen"
		Me.cmdOpen.Size = New System.Drawing.Size(81, 25)
		Me.cmdOpen.Location = New System.Drawing.Point(320, 0)
		Me.cmdOpen.Caption = "&Open"
		Me.cmdOpen.TabIndex = 5
		'
		' cmdSave
		'
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.Location = New System.Drawing.Point(240, 0)
		Me.cmdSave.Caption = "&Save"
		Me.cmdSave.TabIndex = 4
		'
		' cmdPrinter
		'
		Me.cmdPrinter.Name = "cmdPrinter"
		Me.cmdPrinter.Size = New System.Drawing.Size(81, 25)
		Me.cmdPrinter.Location = New System.Drawing.Point(160, 0)
		Me.cmdPrinter.Caption = "&Printer"
		Me.cmdPrinter.TabIndex = 3
		'
		' RichTextBox1
		'
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(361, 121)
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 32)
		Me.RichTextBox1.TabIndex = 2
		Me.RichTextBox1.Enabled = True
		Me.RichTextBox1.HideSelection = False
		Me.RichTextBox1.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfVertical
		Me.RichTextBox1.TextRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1040{\fonttbl{\f0\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "\viewkind4\uc1\pard\f0\fs20 This is a RichTextBox control." & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' cmdFont
		'
		Me.cmdFont.Name = "cmdFont"
		Me.cmdFont.Size = New System.Drawing.Size(81, 25)
		Me.cmdFont.Location = New System.Drawing.Point(80, 0)
		Me.cmdFont.Caption = "&Font"
		Me.cmdFont.TabIndex = 1
		'
		' cmdColor
		'
		Me.cmdColor.Name = "cmdColor"
		Me.cmdColor.Size = New System.Drawing.Size(81, 25)
		Me.cmdColor.Location = New System.Drawing.Point(0, 0)
		Me.cmdColor.Caption = "&Color"
		Me.cmdColor.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "CommonDialog Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(489, 238)

		Me.Controls.Add(cmdOpenMulti)
		Me.Controls.Add(cmdOpen)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(cmdPrinter)
		Me.Controls.Add(RichTextBox1)
		Me.Controls.Add(cmdFont)
		Me.Controls.Add(cmdColor)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
