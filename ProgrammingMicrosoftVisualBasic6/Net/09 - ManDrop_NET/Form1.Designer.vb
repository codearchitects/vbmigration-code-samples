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
	Public WithEvents chkLoadOnDemand As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents rtfText As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents cmdBrowse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstWords As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents imgCopy As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.chkLoadOnDemand = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.rtfText = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.cmdBrowse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstWords = New CodeArchitects.VB6Library.VB6ListBox()
		Me.imgCopy = New CodeArchitects.VB6Library.VB6Image()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.imgCopy, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' chkLoadOnDemand
		'
		Me.chkLoadOnDemand.Name = "chkLoadOnDemand"
		Me.chkLoadOnDemand.Size = New System.Drawing.Size(265, 17)
		Me.chkLoadOnDemand.Location = New System.Drawing.Point(16, 312)
		Me.chkLoadOnDemand.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLoadOnDemand.Caption = "&Load data on-demand"
		Me.chkLoadOnDemand.TabIndex = 4
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' rtfText
		'
		Me.rtfText.Name = "rtfText"
		Me.rtfText.Size = New System.Drawing.Size(273, 233)
		Me.rtfText.Location = New System.Drawing.Point(16, 80)
		Me.rtfText.TabIndex = 3
		Me.rtfText.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfVertical
		Me.rtfText.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragManual
		Me.rtfText.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.rtfText.TextRTF = "{\rtf1\ansi\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "{\colortbl\red0\green0\blue0;}" & ControlChars.CrLf & "\deflang1040\pard\plain\f2\fs17 " & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		'
		' cmdBrowse
		'
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.cmdBrowse.Size = New System.Drawing.Size(81, 41)
		Me.cmdBrowse.Location = New System.Drawing.Point(16, 16)
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.Caption = "&Browse"
		Me.cmdBrowse.TabIndex = 2
		'
		' lstWords
		'
		Me.lstWords.Name = "lstWords"
		Me.lstWords.Size = New System.Drawing.Size(209, 228)
		Me.lstWords.Location = New System.Drawing.Point(304, 80)
		Me.lstWords.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstWords.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.lstWords.Sorted = True
		Me.lstWords.TabIndex = 0
		'
		' imgCopy
		'
		Me.imgCopy.Name = "imgCopy"
		Me.imgCopy.Size = New System.Drawing.Size(32, 32)
		Me.imgCopy.Location = New System.Drawing.Point(288, 152)
		Me.imgCopy.Visible = False
		Me.imgCopy.Picture = CType(resources.GetObject("imgCopy.Picture"), System.Drawing.Image)
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(393, 65)
		Me.Label1.Location = New System.Drawing.Point(120, 8)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Type some text in the RTFbox on the left, or load a text file into it using drag and drop or clicking the Browse button, then drag a selected portion of text from it into the listbox on the right to see the list of unique words"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Drag-And-Drop Word Parser"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(531, 337)

		Me.Controls.Add(chkLoadOnDemand)
		Me.Controls.Add(rtfText)
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(lstWords)
		Me.Controls.Add(imgCopy)
		Me.Controls.Add(Label1)
		CType(Me.imgCopy, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
