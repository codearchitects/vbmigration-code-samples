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
	Public WithEvents picStatus As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdFind As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboTo As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboFrom As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cmdRedraw As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents picMap As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.picStatus = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdFind = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboTo = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboFrom = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.cmdRedraw = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.picMap = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' picStatus
		'
		Me.picStatus.Name = "picStatus"
		Me.picStatus.Size = New System.Drawing.Size(663, 25)
		Me.picStatus.Location = New System.Drawing.Point(0, 323)
		Me.picStatus.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.picStatus.AutoRedraw = True
		Me.picStatus.TabIndex = 8
		Me.picStatus.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(185, 249)
		Me.Frame1.Location = New System.Drawing.Point(472, 64)
		Me.Frame1.Caption = "Find Best Path"
		Me.Frame1.TabIndex = 2
		'
		' cmdFind
		'
		Me.cmdFind.Name = "cmdFind"
		Me.cmdFind.Size = New System.Drawing.Size(81, 25)
		Me.cmdFind.Location = New System.Drawing.Point(48, 208)
		Me.cmdFind.Caption = "&Find"
		Me.cmdFind.TabIndex = 7
		'
		' cboTo
		'
		Me.cboTo.Name = "cboTo"
		Me.cboTo.Size = New System.Drawing.Size(145, 24)
		Me.cboTo.Location = New System.Drawing.Point(16, 88)
		Me.cboTo.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboTo.TabIndex = 5
		'
		' cboFrom
		'
		Me.cboFrom.Name = "cboFrom"
		Me.cboFrom.Size = New System.Drawing.Size(145, 24)
		Me.cboFrom.Location = New System.Drawing.Point(16, 40)
		Me.cboFrom.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboFrom.TabIndex = 3
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(105, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 72)
		Me.Label2.Caption = "&To place:"
		Me.Label2.TabIndex = 6
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 24)
		Me.Label1.Caption = "&From place:"
		Me.Label1.TabIndex = 4
		'
		' cmdRedraw
		'
		Me.cmdRedraw.Name = "cmdRedraw"
		Me.cmdRedraw.Size = New System.Drawing.Size(81, 33)
		Me.cmdRedraw.Location = New System.Drawing.Point(520, 16)
		Me.cmdRedraw.Caption = "Redraw"
		Me.cmdRedraw.TabIndex = 1
		Me.AcceptButton = Me.cmdRedraw
		Me.cmdRedraw.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' picMap
		'
		Me.picMap.Name = "picMap"
		Me.picMap.Size = New System.Drawing.Size(465, 313)
		Me.picMap.Location = New System.Drawing.Point(0, 0)
		Me.picMap.AutoRedraw = True
		Me.picMap.TabIndex = 0
		Me.picMap.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Object Hierarchy Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(663, 348)

		Me.Controls.Add(picStatus)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmdFind)
		Me.Frame1.Controls.Add(cboTo)
		Me.Frame1.Controls.Add(cboFrom)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Controls.Add(cmdRedraw)
		Me.Controls.Add(picMap)
		Me.Controls.SetChildIndex(Me.picStatus, 0)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
