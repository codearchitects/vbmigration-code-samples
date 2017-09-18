<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmProperties
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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_000, Label1_001, Label1_002, Label1_003)
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
	Public WithEvents Statistiche As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblParagraphs As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLines As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWords As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblChars As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Statistiche = New CodeArchitects.VB6Library.VB6Frame()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblParagraphs = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLines = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWords = New CodeArchitects.VB6Library.VB6Label()
		Me.lblChars = New CodeArchitects.VB6Library.VB6Label()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Statistiche.SuspendLayout()
		Me.SuspendLayout()
		'
		' Statistiche
		'
		Me.Statistiche.Name = "Statistiche"
		Me.Statistiche.Size = New System.Drawing.Size(167, 131)
		Me.Statistiche.Location = New System.Drawing.Point(8, 8)
		Me.Statistiche.Caption = "Statistics"
		Me.Statistiche.TabIndex = 1
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(57, 13)
		Me.Label1_000.Location = New System.Drawing.Point(12, 22)
		Me.Label1_000.AutoSize = True
		Me.Label1_000.Caption = "Paragraphs:"
		Me.Label1_000.TabIndex = 9
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(28, 13)
		Me.Label1_001.Location = New System.Drawing.Point(12, 46)
		Me.Label1_001.AutoSize = True
		Me.Label1_001.Caption = "Lines:"
		Me.Label1_001.TabIndex = 8
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(34, 13)
		Me.Label1_002.Location = New System.Drawing.Point(12, 70)
		Me.Label1_002.AutoSize = True
		Me.Label1_002.Caption = "Words:"
		Me.Label1_002.TabIndex = 7
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(54, 13)
		Me.Label1_003.Location = New System.Drawing.Point(12, 96)
		Me.Label1_003.AutoSize = True
		Me.Label1_003.Caption = "Characters:"
		Me.Label1_003.TabIndex = 6
		'
		' lblParagraphs
		'
		Me.lblParagraphs.Name = "lblParagraphs"
		Me.lblParagraphs.Size = New System.Drawing.Size(61, 21)
		Me.lblParagraphs.Location = New System.Drawing.Point(98, 22)
		Me.lblParagraphs.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblParagraphs.TabIndex = 5
		'
		' lblLines
		'
		Me.lblLines.Name = "lblLines"
		Me.lblLines.Size = New System.Drawing.Size(61, 21)
		Me.lblLines.Location = New System.Drawing.Point(98, 47)
		Me.lblLines.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLines.TabIndex = 4
		'
		' lblWords
		'
		Me.lblWords.Name = "lblWords"
		Me.lblWords.Size = New System.Drawing.Size(61, 21)
		Me.lblWords.Location = New System.Drawing.Point(98, 71)
		Me.lblWords.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblWords.TabIndex = 3
		'
		' lblChars
		'
		Me.lblChars.Name = "lblChars"
		Me.lblChars.Size = New System.Drawing.Size(61, 21)
		Me.lblChars.Location = New System.Drawing.Point(98, 96)
		Me.lblChars.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblChars.TabIndex = 2
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(69, 25)
		Me.Command1.Location = New System.Drawing.Point(200, 16)
		Me.Command1.Caption = "&OK"
		Me.Command1.TabIndex = 0
		Me.CancelButton = Me.Command1
		Me.Command1.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' frmProperties
		'
		Me.Name = "frmProperties"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Properties"
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(287, 150)

		Me.Controls.Add(Statistiche)
		Me.Statistiche.Controls.Add(Label1_000)
		Me.Statistiche.Controls.Add(Label1_001)
		Me.Statistiche.Controls.Add(Label1_002)
		Me.Statistiche.Controls.Add(Label1_003)
		Me.Statistiche.Controls.Add(lblParagraphs)
		Me.Statistiche.Controls.Add(lblLines)
		Me.Statistiche.Controls.Add(lblWords)
		Me.Statistiche.Controls.Add(lblChars)
		Me.Controls.Add(Command1)
		Me.Statistiche.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
