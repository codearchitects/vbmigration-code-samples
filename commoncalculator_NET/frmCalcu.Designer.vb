<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCalcu
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
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdCancel_002, cmdCancel_001, cmdCancel_000)
		Me.cmdFunction = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdFunction_003, cmdFunction_002, cmdFunction_001, cmdFunction_000)
		Me.cmdMemory = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMemory_003, cmdMemory_002, cmdMemory_001, cmdMemory_000)
		Me.[operator] = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(operator_003, operator_002, operator_001, operator_000)
		Me.numero = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(numero_009, numero_008, numero_007, numero_006, numero_005, numero_004, numero_003, numero_002, numero_001, numero_000)
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
	Public cmdCancel As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public cmdFunction As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public cmdMemory As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public [operator] As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public numero As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdCancel_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdEqual As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFunction_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFunction_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFunction_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFunction_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDot As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMemory_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMemory_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMemory_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMemory_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtDisplay As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents operator_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents operator_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents operator_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents operator_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_009 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_008 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_007 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents numero_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblMem As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCopy As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPaste As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdCancel_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdEqual = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFunction_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFunction_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFunction_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFunction_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDot = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMemory_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMemory_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMemory_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMemory_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtDisplay = New CodeArchitects.VB6Library.VB6TextBox()
		Me.operator_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.operator_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.operator_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.operator_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_009 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_008 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_007 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.numero_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblMem = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCopy = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPaste = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdCancel_002
		'
		Me.cmdCancel_002.Name = "cmdCancel_002"
		Me.cmdCancel_002.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel_002.Location = New System.Drawing.Point(120, 64)
		Me.cmdCancel_002.Caption = "CE"
		Me.cmdCancel_002.TabIndex = 27
		Me.cmdCancel_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCancel_001
		'
		Me.cmdCancel_001.Name = "cmdCancel_001"
		Me.cmdCancel_001.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel_001.Location = New System.Drawing.Point(184, 64)
		Me.cmdCancel_001.Caption = "C"
		Me.cmdCancel_001.TabIndex = 26
		Me.cmdCancel_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCancel_000
		'
		Me.cmdCancel_000.Name = "cmdCancel_000"
		Me.cmdCancel_000.Size = New System.Drawing.Size(65, 33)
		Me.cmdCancel_000.Location = New System.Drawing.Point(48, 64)
		Me.cmdCancel_000.Caption = "Back"
		Me.cmdCancel_000.TabIndex = 25
		Me.cmdCancel_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdEqual
		'
		Me.cmdEqual.Name = "cmdEqual"
		Me.cmdEqual.Size = New System.Drawing.Size(33, 33)
		Me.cmdEqual.Location = New System.Drawing.Point(208, 224)
		Me.cmdEqual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEqual.Caption = "="
		Me.cmdEqual.TabIndex = 0
		Me.cmdEqual.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFunction_003
		'
		Me.cmdFunction_003.Name = "cmdFunction_003"
		Me.cmdFunction_003.Size = New System.Drawing.Size(33, 33)
		Me.cmdFunction_003.Location = New System.Drawing.Point(208, 104)
		Me.cmdFunction_003.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFunction_003.Caption = "Sqrt"
		Me.cmdFunction_003.TabIndex = 24
		Me.cmdFunction_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFunction_002
		'
		Me.cmdFunction_002.Name = "cmdFunction_002"
		Me.cmdFunction_002.Size = New System.Drawing.Size(33, 33)
		Me.cmdFunction_002.Location = New System.Drawing.Point(208, 144)
		Me.cmdFunction_002.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFunction_002.Caption = "%"
		Me.cmdFunction_002.TabIndex = 23
		Me.cmdFunction_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFunction_001
		'
		Me.cmdFunction_001.Name = "cmdFunction_001"
		Me.cmdFunction_001.Size = New System.Drawing.Size(33, 33)
		Me.cmdFunction_001.Location = New System.Drawing.Point(208, 184)
		Me.cmdFunction_001.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFunction_001.Caption = "1/X"
		Me.cmdFunction_001.TabIndex = 22
		Me.cmdFunction_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFunction_000
		'
		Me.cmdFunction_000.Name = "cmdFunction_000"
		Me.cmdFunction_000.Size = New System.Drawing.Size(33, 33)
		Me.cmdFunction_000.Location = New System.Drawing.Point(128, 224)
		Me.cmdFunction_000.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFunction_000.Caption = "+/-"
		Me.cmdFunction_000.TabIndex = 21
		Me.cmdFunction_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdDot
		'
		Me.cmdDot.Name = "cmdDot"
		Me.cmdDot.Size = New System.Drawing.Size(33, 33)
		Me.cmdDot.Location = New System.Drawing.Point(88, 224)
		Me.cmdDot.Font = New System.Drawing.Font("Arial", 19.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDot.Caption = "."
		Me.cmdDot.TabIndex = 20
		Me.cmdDot.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMemory_003
		'
		Me.cmdMemory_003.Name = "cmdMemory_003"
		Me.cmdMemory_003.Size = New System.Drawing.Size(33, 33)
		Me.cmdMemory_003.Location = New System.Drawing.Point(8, 144)
		Me.cmdMemory_003.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMemory_003.Caption = "MR"
		Me.cmdMemory_003.TabIndex = 19
		Me.cmdMemory_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMemory_002
		'
		Me.cmdMemory_002.Name = "cmdMemory_002"
		Me.cmdMemory_002.Size = New System.Drawing.Size(33, 33)
		Me.cmdMemory_002.Location = New System.Drawing.Point(8, 184)
		Me.cmdMemory_002.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMemory_002.Caption = "MS"
		Me.cmdMemory_002.TabIndex = 18
		Me.cmdMemory_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMemory_001
		'
		Me.cmdMemory_001.Name = "cmdMemory_001"
		Me.cmdMemory_001.Size = New System.Drawing.Size(33, 33)
		Me.cmdMemory_001.Location = New System.Drawing.Point(8, 224)
		Me.cmdMemory_001.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMemory_001.Caption = "M+"
		Me.cmdMemory_001.TabIndex = 17
		Me.cmdMemory_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMemory_000
		'
		Me.cmdMemory_000.Name = "cmdMemory_000"
		Me.cmdMemory_000.Size = New System.Drawing.Size(33, 33)
		Me.cmdMemory_000.Location = New System.Drawing.Point(8, 104)
		Me.cmdMemory_000.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMemory_000.Caption = "MC"
		Me.cmdMemory_000.TabIndex = 16
		Me.cmdMemory_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtDisplay
		'
		Me.txtDisplay.Name = "txtDisplay"
		Me.txtDisplay.Size = New System.Drawing.Size(233, 25)
		Me.txtDisplay.Location = New System.Drawing.Point(8, 32)
		Me.txtDisplay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDisplay.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtDisplay.ReadOnly = True
		Me.txtDisplay.TabIndex = 15
		Me.txtDisplay.Text = "0"
		'
		' operator_003
		'
		Me.operator_003.Name = "operator_003"
		Me.operator_003.Size = New System.Drawing.Size(33, 33)
		Me.operator_003.Location = New System.Drawing.Point(168, 144)
		Me.operator_003.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.operator_003.Caption = "*"
		Me.operator_003.TabIndex = 14
		Me.operator_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' operator_002
		'
		Me.operator_002.Name = "operator_002"
		Me.operator_002.Size = New System.Drawing.Size(33, 33)
		Me.operator_002.Location = New System.Drawing.Point(168, 184)
		Me.operator_002.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.operator_002.Caption = "-"
		Me.operator_002.TabIndex = 13
		Me.operator_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' operator_001
		'
		Me.operator_001.Name = "operator_001"
		Me.operator_001.Size = New System.Drawing.Size(33, 33)
		Me.operator_001.Location = New System.Drawing.Point(168, 224)
		Me.operator_001.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.operator_001.Caption = "+"
		Me.operator_001.TabIndex = 12
		Me.operator_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' operator_000
		'
		Me.operator_000.Name = "operator_000"
		Me.operator_000.Size = New System.Drawing.Size(33, 33)
		Me.operator_000.Location = New System.Drawing.Point(168, 104)
		Me.operator_000.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.operator_000.Caption = "/"
		Me.operator_000.TabIndex = 11
		Me.operator_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_009
		'
		Me.numero_009.Name = "numero_009"
		Me.numero_009.Size = New System.Drawing.Size(33, 33)
		Me.numero_009.Location = New System.Drawing.Point(128, 104)
		Me.numero_009.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_009.Caption = "9"
		Me.numero_009.TabIndex = 10
		Me.numero_009.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_008
		'
		Me.numero_008.Name = "numero_008"
		Me.numero_008.Size = New System.Drawing.Size(33, 33)
		Me.numero_008.Location = New System.Drawing.Point(88, 104)
		Me.numero_008.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_008.Caption = "8"
		Me.numero_008.TabIndex = 9
		Me.numero_008.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_007
		'
		Me.numero_007.Name = "numero_007"
		Me.numero_007.Size = New System.Drawing.Size(33, 33)
		Me.numero_007.Location = New System.Drawing.Point(48, 104)
		Me.numero_007.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_007.Caption = "7"
		Me.numero_007.TabIndex = 8
		Me.numero_007.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_006
		'
		Me.numero_006.Name = "numero_006"
		Me.numero_006.Size = New System.Drawing.Size(33, 33)
		Me.numero_006.Location = New System.Drawing.Point(128, 144)
		Me.numero_006.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_006.Caption = "6"
		Me.numero_006.TabIndex = 7
		Me.numero_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_005
		'
		Me.numero_005.Name = "numero_005"
		Me.numero_005.Size = New System.Drawing.Size(33, 33)
		Me.numero_005.Location = New System.Drawing.Point(88, 144)
		Me.numero_005.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_005.Caption = "5"
		Me.numero_005.TabIndex = 6
		Me.numero_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_004
		'
		Me.numero_004.Name = "numero_004"
		Me.numero_004.Size = New System.Drawing.Size(33, 33)
		Me.numero_004.Location = New System.Drawing.Point(48, 144)
		Me.numero_004.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_004.Caption = "4"
		Me.numero_004.TabIndex = 5
		Me.numero_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_003
		'
		Me.numero_003.Name = "numero_003"
		Me.numero_003.Size = New System.Drawing.Size(33, 33)
		Me.numero_003.Location = New System.Drawing.Point(128, 184)
		Me.numero_003.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_003.Caption = "3"
		Me.numero_003.TabIndex = 4
		Me.numero_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_002
		'
		Me.numero_002.Name = "numero_002"
		Me.numero_002.Size = New System.Drawing.Size(33, 33)
		Me.numero_002.Location = New System.Drawing.Point(88, 184)
		Me.numero_002.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_002.Caption = "2"
		Me.numero_002.TabIndex = 3
		Me.numero_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_001
		'
		Me.numero_001.Name = "numero_001"
		Me.numero_001.Size = New System.Drawing.Size(33, 33)
		Me.numero_001.Location = New System.Drawing.Point(48, 184)
		Me.numero_001.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_001.Caption = "1"
		Me.numero_001.TabIndex = 2
		Me.numero_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' numero_000
		'
		Me.numero_000.Name = "numero_000"
		Me.numero_000.Size = New System.Drawing.Size(33, 33)
		Me.numero_000.Location = New System.Drawing.Point(48, 224)
		Me.numero_000.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numero_000.Caption = "0"
		Me.numero_000.TabIndex = 1
		Me.numero_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblMem
		'
		Me.lblMem.Name = "lblMem"
		Me.lblMem.Size = New System.Drawing.Size(33, 33)
		Me.lblMem.Location = New System.Drawing.Point(8, 64)
		Me.lblMem.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMem.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblMem.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMem.TabIndex = 28
		Me.lblMem.AutoSize = False
		Me.lblMem.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuEdit
		'
		Me.mnuEdit.Name = "mnuEdit"
		Me.mnuEdit.Caption = "Edit"
		'
		' mnuCopy
		'
		Me.mnuCopy.Name = "mnuCopy"
		Me.mnuCopy.Caption = "Copy"
		Me.mnuCopy.Shortcut = Keys.Control Or Keys.C
		'
		' mnuPaste
		'
		Me.mnuPaste.Name = "mnuPaste"
		Me.mnuPaste.Caption = "Paste"
		Me.mnuPaste.Shortcut = Keys.Control Or Keys.P
		'
		' frmCalcu
		'
		Me.Name = "frmCalcu"
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Calculator"
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(10, 29)
		Me.ClientSize = New System.Drawing.Size(256, 266)

		Me.Controls.Add(cmdCancel_002)
		Me.Controls.Add(cmdCancel_001)
		Me.Controls.Add(cmdCancel_000)
		Me.Controls.Add(cmdEqual)
		Me.Controls.Add(cmdFunction_003)
		Me.Controls.Add(cmdFunction_002)
		Me.Controls.Add(cmdFunction_001)
		Me.Controls.Add(cmdFunction_000)
		Me.Controls.Add(cmdDot)
		Me.Controls.Add(cmdMemory_003)
		Me.Controls.Add(cmdMemory_002)
		Me.Controls.Add(cmdMemory_001)
		Me.Controls.Add(cmdMemory_000)
		Me.Controls.Add(txtDisplay)
		Me.Controls.Add(operator_003)
		Me.Controls.Add(operator_002)
		Me.Controls.Add(operator_001)
		Me.Controls.Add(operator_000)
		Me.Controls.Add(numero_009)
		Me.Controls.Add(numero_008)
		Me.Controls.Add(numero_007)
		Me.Controls.Add(numero_006)
		Me.Controls.Add(numero_005)
		Me.Controls.Add(numero_004)
		Me.Controls.Add(numero_003)
		Me.Controls.Add(numero_002)
		Me.Controls.Add(numero_001)
		Me.Controls.Add(numero_000)
		Me.Controls.Add(lblMem)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuEdit)
		Me.mnuEdit.DropDownItems.Add(mnuCopy)
		Me.mnuEdit.DropDownItems.Add(mnuPaste)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
