<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSpellCheck
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
		Me.Label2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label2_001, Label2_000)
		Me.Line1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)(Line1_001, Line1_000)
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_003, Label1_002, Label1_001, Label1_000)
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
	Public Label2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public Line1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdCreateList As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstLdMatches As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdGO As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents LdVal As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents lstSoundexMatches As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents txtInputWord As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line1_001 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line1_000 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLDMatchCount As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblSndxMatchCount As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLDVal As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblSoundex As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSpellCheck))
		Me.cmdCreateList = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstLdMatches = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdGO = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.LdVal = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.lstSoundexMatches = New CodeArchitects.VB6Library.VB6ListBox()
		Me.txtInputWord = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Line1_001 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line1_000 = New CodeArchitects.VB6Library.VB6Line()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLDMatchCount = New CodeArchitects.VB6Library.VB6Label()
		Me.lblSndxMatchCount = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLDVal = New CodeArchitects.VB6Library.VB6Label()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblSoundex = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdCreateList
		'
		Me.cmdCreateList.Name = "cmdCreateList"
		Me.cmdCreateList.Size = New System.Drawing.Size(145, 25)
		Me.cmdCreateList.Location = New System.Drawing.Point(80, 8)
		Me.cmdCreateList.Caption = "Create Word List"
		Me.cmdCreateList.TabIndex = 16
		Me.cmdCreateList.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lstLdMatches
		'
		Me.lstLdMatches.Name = "lstLdMatches"
		Me.lstLdMatches.Size = New System.Drawing.Size(185, 160)
		Me.lstLdMatches.Location = New System.Drawing.Point(200, 264)
		Me.lstLdMatches.TabIndex = 9
		'
		' cmdGO
		'
		Me.cmdGO.Name = "cmdGO"
		Me.cmdGO.Size = New System.Drawing.Size(41, 25)
		Me.cmdGO.Location = New System.Drawing.Point(344, 132)
		Me.cmdGO.Caption = "Go!"
		Me.cmdGO.TabIndex = 8
		Me.cmdGO.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LdVal
		'
		Me.LdVal.Name = "LdVal"
		Me.LdVal.Size = New System.Drawing.Size(375, 15)
		Me.LdVal.Location = New System.Drawing.Point(9, 209)
		Me.LdVal.TabIndex = 6
		Me.LdVal.LargeChange = 1
		Me.LdVal.Max = 32767
		Me.LdVal.TabStop = True
		'
		' lstSoundexMatches
		'
		Me.lstSoundexMatches.Name = "lstSoundexMatches"
		Me.lstSoundexMatches.Size = New System.Drawing.Size(185, 160)
		Me.lstSoundexMatches.Location = New System.Drawing.Point(8, 264)
		Me.lstSoundexMatches.TabIndex = 4
		'
		' txtInputWord
		'
		Me.txtInputWord.Name = "txtInputWord"
		Me.txtInputWord.Size = New System.Drawing.Size(257, 19)
		Me.txtInputWord.Location = New System.Drawing.Point(80, 135)
		Me.txtInputWord.TabIndex = 1
		Me.txtInputWord.Text = "Verseon"
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(161, 33)
		Me.Label5.Location = New System.Drawing.Point(224, 160)
		Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Caption = "Adjust the Levenshtein Threshold to see how the possible matches change. Smaller values are more accurate."
		Me.Label5.TabIndex = 19
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_001
		'
		Me.Label2_001.Name = "Label2_001"
		Me.Label2_001.Size = New System.Drawing.Size(361, 25)
		Me.Label2_001.Location = New System.Drawing.Point(8, 104)
		Me.Label2_001.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2_001.Caption = "Step 2: Test the code..."
		Me.Label2_001.TabIndex = 18
		Me.Label2_001.AutoSize = False
		Me.Label2_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line1_001
		'
		Me.Line1_001.Name = "Line1_001"
		Me.Line1_001.ParentForm = Me
		Me.Line1_001.Name6 = "Line1_001"
		Me.Line1_001.BorderColor = FromOleColor6(CInt(&H8000000E))
		Me.Line1_001.X1 = 0
		Me.Line1_001.X2 = 5880
		Me.Line1_001.Y1 = 1455
		Me.Line1_001.Y2 = 1455
		'
		' Line1_000
		'
		Me.Line1_000.Name = "Line1_000"
		Me.Line1_000.ParentForm = Me
		Me.Line1_000.Name6 = "Line1_000"
		Me.Line1_000.BorderColor = FromOleColor6(CInt(&H80000010))
		Me.Line1_000.X1 = 0
		Me.Line1_000.X2 = 5880
		Me.Line1_000.Y1 = 1440
		Me.Line1_000.Y2 = 1440
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(377, 49)
		Me.Label4.Location = New System.Drawing.Point(8, 40)
		Me.Label4.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Caption = "The wordlist is a huge collection of over 450,000 words. In order to save you a LOT of download time, I have packed the database as a text file. Please click the 'Create Word List' button to create the word database before testing the Spell checker. NOTE: This is done only the first time you run this application"
		Me.Label4.TabIndex = 17
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_000
		'
		Me.Label2_000.Name = "Label2_000"
		Me.Label2_000.Size = New System.Drawing.Size(97, 25)
		Me.Label2_000.Location = New System.Drawing.Point(8, 8)
		Me.Label2_000.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2_000.Caption = "Step 1:"
		Me.Label2_000.TabIndex = 15
		Me.Label2_000.AutoSize = False
		Me.Label2_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLDMatchCount
		'
		Me.lblLDMatchCount.Name = "lblLDMatchCount"
		Me.lblLDMatchCount.Size = New System.Drawing.Size(97, 17)
		Me.lblLDMatchCount.Location = New System.Drawing.Point(288, 248)
		Me.lblLDMatchCount.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLDMatchCount.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblLDMatchCount.TabIndex = 14
		Me.lblLDMatchCount.AutoSize = False
		Me.lblLDMatchCount.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblSndxMatchCount
		'
		Me.lblSndxMatchCount.Name = "lblSndxMatchCount"
		Me.lblSndxMatchCount.Size = New System.Drawing.Size(105, 17)
		Me.lblSndxMatchCount.Location = New System.Drawing.Point(88, 248)
		Me.lblSndxMatchCount.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblSndxMatchCount.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblSndxMatchCount.TabIndex = 13
		Me.lblSndxMatchCount.AutoSize = False
		Me.lblSndxMatchCount.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLDVal
		'
		Me.lblLDVal.Name = "lblLDVal"
		Me.lblLDVal.Size = New System.Drawing.Size(73, 17)
		Me.lblLDVal.Location = New System.Drawing.Point(312, 192)
		Me.lblLDVal.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLDVal.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblLDVal.TabIndex = 12
		Me.lblLDVal.AutoSize = False
		Me.lblLDVal.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(391, 17)
		Me.lblStatus.Location = New System.Drawing.Point(0, 432)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 11
		Me.lblStatus.AutoSize = False
		Me.lblStatus.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(169, 33)
		Me.Label1_003.Location = New System.Drawing.Point(200, 232)
		Me.Label1_003.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_003.Caption = "Suggestions narowed down using Levenshtein threshold"
		Me.Label1_003.TabIndex = 10
		Me.Label1_003.AutoSize = False
		Me.Label1_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.BorderColor = FromOleColor6(CInt(&H80000010))
		Me.Shape1.Height = 255
		Me.Shape1.Left = 120
		Me.Shape1.Top = 3120
		Me.Shape1.Width = 5655
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(153, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 192)
		Me.Label3.Caption = "Adjust Levenshtein threshold"
		Me.Label3.TabIndex = 7
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(153, 17)
		Me.Label1_002.Location = New System.Drawing.Point(8, 237)
		Me.Label1_002.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_002.Caption = "All words with same soundex"
		Me.Label1_002.TabIndex = 5
		Me.Label1_002.AutoSize = False
		Me.Label1_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblSoundex
		'
		Me.lblSoundex.Name = "lblSoundex"
		Me.lblSoundex.Size = New System.Drawing.Size(137, 25)
		Me.lblSoundex.Location = New System.Drawing.Point(80, 160)
		Me.lblSoundex.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSoundex.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblSoundex.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblSoundex.TabIndex = 3
		Me.lblSoundex.AutoSize = False
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(73, 17)
		Me.Label1_001.Location = New System.Drawing.Point(28, 164)
		Me.Label1_001.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_001.Caption = "Soundex:"
		Me.Label1_001.TabIndex = 2
		Me.Label1_001.AutoSize = False
		Me.Label1_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(73, 17)
		Me.Label1_000.Location = New System.Drawing.Point(8, 136)
		Me.Label1_000.Caption = "Enter a word:"
		Me.Label1_000.TabIndex = 0
		Me.Label1_000.AutoSize = False
		Me.Label1_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmSpellCheck
		'
		Me.Name = "frmSpellCheck"
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Spell Checker Using Soundex and Levinshtein Distance"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ClientSize = New System.Drawing.Size(392, 449)

		Me.Controls.Add(cmdCreateList)
		Me.Controls.Add(lstLdMatches)
		Me.Controls.Add(cmdGO)
		Me.Controls.Add(LdVal)
		Me.Controls.Add(lstSoundexMatches)
		Me.Controls.Add(txtInputWord)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label2_001)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label2_000)
		Me.Controls.Add(lblLDMatchCount)
		Me.Controls.Add(lblSndxMatchCount)
		Me.Controls.Add(lblLDVal)
		Me.Controls.Add(lblStatus)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(lblSoundex)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		CType(Me.Line1_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
