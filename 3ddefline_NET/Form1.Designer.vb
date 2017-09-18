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
		' Initialize control arrays.
		Me.cmdControls = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdControls_001, cmdControls_008, cmdControls_006, cmdControls_010, cmdControls_004, cmdControls_007, cmdControls_002, cmdControls_005, cmdControls_009, cmdControls_003)
		Me.mnuChangeRisolution = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuChangeRisolution_001, mnuChangeRisolution_002)
		Me.mnuSetPoint = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuSetPoint_001, mnuSetPoint_002)
		Me.mnuChangeView = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuChangeView_001, mnuChangeView_002, mnuChangeView_003)
		Me.mnuDrawPlane = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuDrawPlane_001, mnuDrawPlane_002, mnuDrawPlane_003)
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
	Public cmdControls As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public mnuChangeRisolution As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuSetPoint As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuChangeView As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuDrawPlane As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents ScriptControl As CodeArchitects.VB6Library.VB6ScriptControl
	Public WithEvents cmdControls_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFunction As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdControls_008 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_010 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_007 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_009 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdControls_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblFunction As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuGeneral As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRisolution As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuChangeRisolution_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuChangeRisolution_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPoint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSetPoint_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSetPoint_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewFrom As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuChangeView_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuChangeView_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuChangeView_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPlane As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuDrawPlane_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuDrawPlane_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuDrawPlane_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuInterval As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRefresh As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.ScriptControl = New CodeArchitects.VB6Library.VB6ScriptControl()
		Me.cmdControls_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFunction = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdControls_008 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_010 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_007 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_009 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdControls_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblFunction = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuGeneral = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRisolution = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuChangeRisolution_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuChangeRisolution_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPoint = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSetPoint_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSetPoint_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewFrom = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuChangeView_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuChangeView_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuChangeView_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPlane = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuDrawPlane_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuDrawPlane_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuDrawPlane_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuInterval = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRefresh = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' ScriptControl
		'
		Me.ScriptControl.Name = "ScriptControl"
		Me.ScriptControl.ParentForm = Me
		Me.ScriptControl.Name6 = "ScriptControl"
		Me.ScriptControl.Language = "VBScript"
		'
		' cmdControls_001
		'
		Me.cmdControls_001.Name = "cmdControls_001"
		Me.cmdControls_001.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_001.Location = New System.Drawing.Point(283, 536)
		Me.cmdControls_001.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_001.Picture = CType(resources.GetObject("cmdControls_001.Picture"), System.Drawing.Image)
		Me.cmdControls_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_001.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.cmdControls_001, "Move to the Left")
		Me.cmdControls_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtFunction
		'
		Me.txtFunction.Name = "txtFunction"
		Me.txtFunction.Size = New System.Drawing.Size(144, 22)
		Me.txtFunction.Location = New System.Drawing.Point(303, 24)
		Me.txtFunction.TabIndex = 0
		Me.txtFunction.Text = "sin (x) * sin(y)"
		Me.ToolTip1.SetToolTip(Me.txtFunction, "Write here the function")
		'
		' cmdControls_008
		'
		Me.cmdControls_008.Name = "cmdControls_008"
		Me.cmdControls_008.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_008.Location = New System.Drawing.Point(379, 568)
		Me.cmdControls_008.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_008.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_008.Picture = CType(resources.GetObject("cmdControls_008.Picture"), System.Drawing.Image)
		Me.cmdControls_008.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_008.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.cmdControls_008, "Rotate to the Right")
		Me.cmdControls_008.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_006
		'
		Me.cmdControls_006.Name = "cmdControls_006"
		Me.cmdControls_006.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_006.Location = New System.Drawing.Point(435, 536)
		Me.cmdControls_006.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_006.Picture = CType(resources.GetObject("cmdControls_006.Picture"), System.Drawing.Image)
		Me.cmdControls_006.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_006.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.cmdControls_006, "Tight axis")
		Me.cmdControls_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_010
		'
		Me.cmdControls_010.Name = "cmdControls_010"
		Me.cmdControls_010.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_010.Location = New System.Drawing.Point(435, 568)
		Me.cmdControls_010.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_010.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_010.Picture = CType(resources.GetObject("cmdControls_010.Picture"), System.Drawing.Image)
		Me.cmdControls_010.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_010.TabIndex = 10
		Me.ToolTip1.SetToolTip(Me.cmdControls_010, "Zoom Out")
		Me.cmdControls_010.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_004
		'
		Me.cmdControls_004.Name = "cmdControls_004"
		Me.cmdControls_004.Size = New System.Drawing.Size(41, 49)
		Me.cmdControls_004.Location = New System.Drawing.Point(339, 552)
		Me.cmdControls_004.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_004.Picture = CType(resources.GetObject("cmdControls_004.Picture"), System.Drawing.Image)
		Me.cmdControls_004.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_004.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.cmdControls_004, "Move Down")
		Me.cmdControls_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_007
		'
		Me.cmdControls_007.Name = "cmdControls_007"
		Me.cmdControls_007.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_007.Location = New System.Drawing.Point(283, 568)
		Me.cmdControls_007.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_007.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_007.Picture = CType(resources.GetObject("cmdControls_007.Picture"), System.Drawing.Image)
		Me.cmdControls_007.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_007.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.cmdControls_007, "Rotate to the Left")
		Me.cmdControls_007.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_002
		'
		Me.cmdControls_002.Name = "cmdControls_002"
		Me.cmdControls_002.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_002.Location = New System.Drawing.Point(379, 536)
		Me.cmdControls_002.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_002.Picture = CType(resources.GetObject("cmdControls_002.Picture"), System.Drawing.Image)
		Me.cmdControls_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_002.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.cmdControls_002, "Move to the Right")
		Me.cmdControls_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_005
		'
		Me.cmdControls_005.Name = "cmdControls_005"
		Me.cmdControls_005.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_005.Location = New System.Drawing.Point(227, 536)
		Me.cmdControls_005.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_005.Picture = CType(resources.GetObject("cmdControls_005.Picture"), System.Drawing.Image)
		Me.cmdControls_005.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_005.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.cmdControls_005, "Expand axis")
		Me.cmdControls_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_009
		'
		Me.cmdControls_009.Name = "cmdControls_009"
		Me.cmdControls_009.Size = New System.Drawing.Size(57, 33)
		Me.cmdControls_009.Location = New System.Drawing.Point(227, 568)
		Me.cmdControls_009.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_009.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_009.Picture = CType(resources.GetObject("cmdControls_009.Picture"), System.Drawing.Image)
		Me.cmdControls_009.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_009.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.cmdControls_009, "Zoom In")
		Me.cmdControls_009.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdControls_003
		'
		Me.cmdControls_003.Name = "cmdControls_003"
		Me.cmdControls_003.Size = New System.Drawing.Size(41, 49)
		Me.cmdControls_003.Location = New System.Drawing.Point(339, 504)
		Me.cmdControls_003.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdControls_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.cmdControls_003.Picture = CType(resources.GetObject("cmdControls_003.Picture"), System.Drawing.Image)
		Me.cmdControls_003.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdControls_003.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.cmdControls_003, "Move Up")
		Me.cmdControls_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblFunction
		'
		Me.lblFunction.Name = "lblFunction"
		Me.lblFunction.Size = New System.Drawing.Size(61, 19)
		Me.lblFunction.Location = New System.Drawing.Point(240, 27)
		Me.lblFunction.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFunction.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblFunction.Caption = "Z ( X , Y ) ="
		Me.lblFunction.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblFunction.TabIndex = 11
		Me.lblFunction.AutoSize = False
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuGeneral
		'
		Me.mnuGeneral.Name = "mnuGeneral"
		Me.mnuGeneral.Caption = "General"
		'
		' mnuRisolution
		'
		Me.mnuRisolution.Name = "mnuRisolution"
		Me.mnuRisolution.Caption = "&Risolution"
		'
		' mnuChangeRisolution_001
		'
		Me.mnuChangeRisolution_001.Name = "mnuChangeRisolution_001"
		Me.mnuChangeRisolution_001.Caption = "Pluss"
		Me.mnuChangeRisolution_001.Shortcut = Keys.Control Or Keys.P
		'
		' mnuChangeRisolution_002
		'
		Me.mnuChangeRisolution_002.Name = "mnuChangeRisolution_002"
		Me.mnuChangeRisolution_002.Caption = "Less"
		Me.mnuChangeRisolution_002.Shortcut = Keys.Control Or Keys.L
		'
		' mnuPoint
		'
		Me.mnuPoint.Name = "mnuPoint"
		Me.mnuPoint.Caption = "&Point"
		'
		' mnuSetPoint_001
		'
		Me.mnuSetPoint_001.Name = "mnuSetPoint_001"
		Me.mnuSetPoint_001.Caption = "Put"
		'
		' mnuSetPoint_002
		'
		Me.mnuSetPoint_002.Name = "mnuSetPoint_002"
		Me.mnuSetPoint_002.Caption = "Evaluate"
		'
		' mnuViewFrom
		'
		Me.mnuViewFrom.Name = "mnuViewFrom"
		Me.mnuViewFrom.Caption = "&View from .."
		'
		' mnuChangeView_001
		'
		Me.mnuChangeView_001.Name = "mnuChangeView_001"
		Me.mnuChangeView_001.Caption = "Front"
		Me.mnuChangeView_001.Shortcut = Keys.Control Or Keys.F
		'
		' mnuChangeView_002
		'
		Me.mnuChangeView_002.Name = "mnuChangeView_002"
		Me.mnuChangeView_002.Caption = "Right"
		Me.mnuChangeView_002.Shortcut = Keys.Control Or Keys.R
		'
		' mnuChangeView_003
		'
		Me.mnuChangeView_003.Name = "mnuChangeView_003"
		Me.mnuChangeView_003.Caption = "Reinitialize"
		'
		' mnuPlane
		'
		Me.mnuPlane.Name = "mnuPlane"
		Me.mnuPlane.Caption = "P&lane"
		'
		' mnuDrawPlane_001
		'
		Me.mnuDrawPlane_001.Name = "mnuDrawPlane_001"
		Me.mnuDrawPlane_001.Caption = "XY"
		'
		' mnuDrawPlane_002
		'
		Me.mnuDrawPlane_002.Name = "mnuDrawPlane_002"
		Me.mnuDrawPlane_002.Caption = "ZX"
		'
		' mnuDrawPlane_003
		'
		Me.mnuDrawPlane_003.Name = "mnuDrawPlane_003"
		Me.mnuDrawPlane_003.Caption = "ZY"
		'
		' mnuInterval
		'
		Me.mnuInterval.Name = "mnuInterval"
		Me.mnuInterval.Caption = "&Interval"
		'
		' mnuRefresh
		'
		Me.mnuRefresh.Name = "mnuRefresh"
		Me.mnuRefresh.Caption = "R&efresh"
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Caption = "3D Graphics"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(4, 42)
		Me.ClientSize = New System.Drawing.Size(718, 602)

		Me.Controls.Add(cmdControls_001)
		Me.Controls.Add(txtFunction)
		Me.Controls.Add(cmdControls_008)
		Me.Controls.Add(cmdControls_006)
		Me.Controls.Add(cmdControls_010)
		Me.Controls.Add(cmdControls_004)
		Me.Controls.Add(cmdControls_007)
		Me.Controls.Add(cmdControls_002)
		Me.Controls.Add(cmdControls_005)
		Me.Controls.Add(cmdControls_009)
		Me.Controls.Add(cmdControls_003)
		Me.Controls.Add(lblFunction)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuGeneral)
		Me.mnuGeneral.DropDownItems.Add(mnuRisolution)
		Me.mnuRisolution.DropDownItems.Add(mnuChangeRisolution_001)
		Me.mnuRisolution.DropDownItems.Add(mnuChangeRisolution_002)
		Me.mnuGeneral.DropDownItems.Add(mnuPoint)
		Me.mnuPoint.DropDownItems.Add(mnuSetPoint_001)
		Me.mnuPoint.DropDownItems.Add(mnuSetPoint_002)
		Me.mnuGeneral.DropDownItems.Add(mnuViewFrom)
		Me.mnuViewFrom.DropDownItems.Add(mnuChangeView_001)
		Me.mnuViewFrom.DropDownItems.Add(mnuChangeView_002)
		Me.mnuViewFrom.DropDownItems.Add(mnuChangeView_003)
		Me.mnuGeneral.DropDownItems.Add(mnuPlane)
		Me.mnuPlane.DropDownItems.Add(mnuDrawPlane_001)
		Me.mnuPlane.DropDownItems.Add(mnuDrawPlane_002)
		Me.mnuPlane.DropDownItems.Add(mnuDrawPlane_003)
		Me.mnuGeneral.DropDownItems.Add(mnuInterval)
		Me.mnuGeneral.DropDownItems.Add(mnuRefresh)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
