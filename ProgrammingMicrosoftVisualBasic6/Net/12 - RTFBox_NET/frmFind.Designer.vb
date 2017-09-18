<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFind
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
	Public WithEvents txtFind As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkWholeWords As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkMatchCase As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdFind As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtFind = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkWholeWords = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkMatchCase = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdFind = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' txtFind
		'
		Me.txtFind.Name = "txtFind"
		Me.txtFind.Size = New System.Drawing.Size(263, 21)
		Me.txtFind.Location = New System.Drawing.Point(58, 8)
		Me.txtFind.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFind.TabIndex = 4
		'
		' chkWholeWords
		'
		Me.chkWholeWords.Name = "chkWholeWords"
		Me.chkWholeWords.Size = New System.Drawing.Size(143, 15)
		Me.chkWholeWords.Location = New System.Drawing.Point(56, 44)
		Me.chkWholeWords.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkWholeWords.Caption = "&Whole Words"
		Me.chkWholeWords.TabIndex = 3
		'
		' chkMatchCase
		'
		Me.chkMatchCase.Name = "chkMatchCase"
		Me.chkMatchCase.Size = New System.Drawing.Size(179, 13)
		Me.chkMatchCase.Location = New System.Drawing.Point(56, 72)
		Me.chkMatchCase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMatchCase.Caption = "&Match Case"
		Me.chkMatchCase.TabIndex = 2
		'
		' cmdFind
		'
		Me.cmdFind.Name = "cmdFind"
		Me.cmdFind.Size = New System.Drawing.Size(69, 23)
		Me.cmdFind.Location = New System.Drawing.Point(256, 40)
		Me.cmdFind.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFind.Caption = "&Find"
		Me.cmdFind.TabIndex = 1
		Me.AcceptButton = Me.cmdFind
		Me.cmdFind.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(69, 23)
		Me.cmdCancel.Location = New System.Drawing.Point(256, 72)
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 0
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 16)
		Me.Label1.Location = New System.Drawing.Point(8, 12)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.AutoSize = True
		Me.Label1.Caption = "Find:"
		Me.Label1.TabIndex = 5
		'
		' frmFind
		'
		Me.Name = "frmFind"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Find"
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(336, 111)

		Me.Controls.Add(txtFind)
		Me.Controls.Add(chkWholeWords)
		Me.Controls.Add(chkMatchCase)
		Me.Controls.Add(cmdFind)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
