<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
	Public WithEvents cmdOptionsTwo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCalendar As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOptionsOne As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdOptionsTwo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCalendar = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOptionsOne = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdOptionsTwo
		'
		Me.cmdOptionsTwo.Name = "cmdOptionsTwo"
		Me.cmdOptionsTwo.Size = New System.Drawing.Size(137, 33)
		Me.cmdOptionsTwo.Location = New System.Drawing.Point(160, 64)
		Me.cmdOptionsTwo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOptionsTwo.Caption = "Options Form Two"
		Me.cmdOptionsTwo.TabIndex = 3
		'
		' cmdCalendar
		'
		Me.cmdCalendar.Name = "cmdCalendar"
		Me.cmdCalendar.Size = New System.Drawing.Size(137, 33)
		Me.cmdCalendar.Location = New System.Drawing.Point(8, 16)
		Me.cmdCalendar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCalendar.Caption = "Calendar"
		Me.cmdCalendar.TabIndex = 2
		'
		' cmdOptionsOne
		'
		Me.cmdOptionsOne.Name = "cmdOptionsOne"
		Me.cmdOptionsOne.Size = New System.Drawing.Size(137, 33)
		Me.cmdOptionsOne.Location = New System.Drawing.Point(8, 64)
		Me.cmdOptionsOne.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOptionsOne.Caption = "Options Form One"
		Me.cmdOptionsOne.TabIndex = 1
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(137, 33)
		Me.lblStatus.Location = New System.Drawing.Point(160, 16)
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 0
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Caption = "Reusable Forms Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(312, 117)

		Me.Controls.Add(cmdOptionsTwo)
		Me.Controls.Add(cmdCalendar)
		Me.Controls.Add(cmdOptionsOne)
		Me.Controls.Add(lblStatus)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
