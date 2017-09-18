<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTextBox
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
		Me.cmdScroll = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdScroll_003, cmdScroll_002, cmdScroll_001, cmdScroll_000)
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
	Public cmdScroll As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdSetTabStop As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScrollCaret As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdScroll_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScroll_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdEnlargeRect As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShrinkRect As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdGetAllLines As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCaretLine As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCaretPos As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFirstLine As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdLineCount As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUndo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTextBox))
		Me.cmdSetTabStop = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScrollCaret = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdScroll_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScroll_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdEnlargeRect = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShrinkRect = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdGetAllLines = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCaretLine = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCaretPos = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFirstLine = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdLineCount = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUndo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdSetTabStop
		'
		Me.cmdSetTabStop.Name = "cmdSetTabStop"
		Me.cmdSetTabStop.Size = New System.Drawing.Size(113, 25)
		Me.cmdSetTabStop.Location = New System.Drawing.Point(424, 80)
		Me.cmdSetTabStop.Caption = "Set Tab Stops"
		Me.cmdSetTabStop.TabIndex = 15
		'
		' cmdScrollCaret
		'
		Me.cmdScrollCaret.Name = "cmdScrollCaret"
		Me.cmdScrollCaret.Size = New System.Drawing.Size(113, 25)
		Me.cmdScrollCaret.Location = New System.Drawing.Point(424, 112)
		Me.cmdScrollCaret.Caption = "Scroll Caret"
		Me.cmdScrollCaret.TabIndex = 14
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(113, 97)
		Me.Frame1.Location = New System.Drawing.Point(424, 136)
		Me.Frame1.Caption = "Scroll"
		Me.Frame1.TabIndex = 9
		'
		' cmdScroll_003
		'
		Me.cmdScroll_003.Name = "cmdScroll_003"
		Me.cmdScroll_003.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_003.Location = New System.Drawing.Point(40, 64)
		Me.cmdScroll_003.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_003.Caption = "\/"
		Me.cmdScroll_003.TabIndex = 13
		'
		' cmdScroll_002
		'
		Me.cmdScroll_002.Name = "cmdScroll_002"
		Me.cmdScroll_002.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_002.Location = New System.Drawing.Point(72, 40)
		Me.cmdScroll_002.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_002.Caption = ">"
		Me.cmdScroll_002.TabIndex = 12
		'
		' cmdScroll_001
		'
		Me.cmdScroll_001.Name = "cmdScroll_001"
		Me.cmdScroll_001.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_001.Location = New System.Drawing.Point(8, 40)
		Me.cmdScroll_001.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScroll_001.Caption = "<"
		Me.cmdScroll_001.TabIndex = 11
		'
		' cmdScroll_000
		'
		Me.cmdScroll_000.Name = "cmdScroll_000"
		Me.cmdScroll_000.Size = New System.Drawing.Size(33, 25)
		Me.cmdScroll_000.Location = New System.Drawing.Point(40, 16)
		Me.cmdScroll_000.Caption = "/\"
		Me.cmdScroll_000.TabIndex = 10
		'
		' cmdEnlargeRect
		'
		Me.cmdEnlargeRect.Name = "cmdEnlargeRect"
		Me.cmdEnlargeRect.Size = New System.Drawing.Size(113, 25)
		Me.cmdEnlargeRect.Location = New System.Drawing.Point(424, 48)
		Me.cmdEnlargeRect.Caption = "Enlarge Rect"
		Me.cmdEnlargeRect.TabIndex = 8
		'
		' cmdShrinkRect
		'
		Me.cmdShrinkRect.Name = "cmdShrinkRect"
		Me.cmdShrinkRect.Size = New System.Drawing.Size(113, 25)
		Me.cmdShrinkRect.Location = New System.Drawing.Point(424, 16)
		Me.cmdShrinkRect.Caption = "Shrink Rect"
		Me.cmdShrinkRect.TabIndex = 7
		'
		' cmdGetAllLines
		'
		Me.cmdGetAllLines.Name = "cmdGetAllLines"
		Me.cmdGetAllLines.Size = New System.Drawing.Size(113, 25)
		Me.cmdGetAllLines.Location = New System.Drawing.Point(304, 176)
		Me.cmdGetAllLines.Caption = "Get All Lines"
		Me.cmdGetAllLines.TabIndex = 6
		'
		' cmdCaretLine
		'
		Me.cmdCaretLine.Name = "cmdCaretLine"
		Me.cmdCaretLine.Size = New System.Drawing.Size(113, 25)
		Me.cmdCaretLine.Location = New System.Drawing.Point(304, 144)
		Me.cmdCaretLine.Caption = "Line from Caret"
		Me.cmdCaretLine.TabIndex = 5
		'
		' cmdCaretPos
		'
		Me.cmdCaretPos.Name = "cmdCaretPos"
		Me.cmdCaretPos.Size = New System.Drawing.Size(113, 25)
		Me.cmdCaretPos.Location = New System.Drawing.Point(304, 112)
		Me.cmdCaretPos.Caption = "GetCaretLineCol"
		Me.cmdCaretPos.TabIndex = 4
		'
		' cmdFirstLine
		'
		Me.cmdFirstLine.Name = "cmdFirstLine"
		Me.cmdFirstLine.Size = New System.Drawing.Size(113, 25)
		Me.cmdFirstLine.Location = New System.Drawing.Point(304, 80)
		Me.cmdFirstLine.Caption = "1st Visible Line"
		Me.cmdFirstLine.TabIndex = 3
		'
		' cmdLineCount
		'
		Me.cmdLineCount.Name = "cmdLineCount"
		Me.cmdLineCount.Size = New System.Drawing.Size(113, 25)
		Me.cmdLineCount.Location = New System.Drawing.Point(304, 48)
		Me.cmdLineCount.Caption = "Line Count"
		Me.cmdLineCount.TabIndex = 2
		'
		' cmdUndo
		'
		Me.cmdUndo.Name = "cmdUndo"
		Me.cmdUndo.Size = New System.Drawing.Size(113, 25)
		Me.cmdUndo.Location = New System.Drawing.Point(304, 16)
		Me.cmdUndo.Caption = "Undo"
		Me.cmdUndo.TabIndex = 1
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(281, 193)
		Me.Text1.Location = New System.Drawing.Point(8, 16)
		Me.Text1.HideSelection = False
		Me.Text1.MultiLine = -1
		Me.Text1.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.Text1.TabIndex = 0
		Me.Text1.Text = "Text1"
		'
		' frmTextBox
		'
		Me.Name = "frmTextBox"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "TextBox SendMessage Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(556, 248)

		Me.Controls.Add(cmdSetTabStop)
		Me.Controls.Add(cmdScrollCaret)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmdScroll_003)
		Me.Frame1.Controls.Add(cmdScroll_002)
		Me.Frame1.Controls.Add(cmdScroll_001)
		Me.Frame1.Controls.Add(cmdScroll_000)
		Me.Controls.Add(cmdEnlargeRect)
		Me.Controls.Add(cmdShrinkRect)
		Me.Controls.Add(cmdGetAllLines)
		Me.Controls.Add(cmdCaretLine)
		Me.Controls.Add(cmdCaretPos)
		Me.Controls.Add(cmdFirstLine)
		Me.Controls.Add(cmdLineCount)
		Me.Controls.Add(cmdUndo)
		Me.Controls.Add(Text1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
