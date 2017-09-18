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
		Me.txtFields = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtFields_015, txtFields_014, txtFields_012, txtFields_011, txtFields_010, txtFields_009, txtFields_008, txtFields_007, txtFields_006, txtFields_005, txtFields_004, txtFields_003, txtFields_002, txtFields_001, txtFields_000)
		Me.lblLabels = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblLabels_015, lblLabels_014, lblLabels_012, lblLabels_011, lblLabels_010, lblLabels_009, lblLabels_008, lblLabels_007, lblLabels_006, lblLabels_005, lblLabels_004, lblLabels_003, lblLabels_002, lblLabels_001, lblLabels_000)
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
	Public txtFields As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public lblLabels As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdFiller As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents picCanvas As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents picButtons As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdAdd As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUpdate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRefresh As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClose As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents datPrimaryRS As CodeArchitects.VB6Library.VB6Data
	Public WithEvents txtFields_015 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_014 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_012 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_011 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_010 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_009 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_008 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_007 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_006 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_005 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblLabels_015 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_014 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents HScroll1 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents VScroll1 As CodeArchitects.VB6Library.VB6VScrollBar

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdFiller = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.picCanvas = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.picButtons = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdAdd = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUpdate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRefresh = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClose = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.datPrimaryRS = New CodeArchitects.VB6Library.VB6Data()
		Me.txtFields_015 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_014 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_012 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_011 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_010 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_009 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_008 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_007 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_006 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_005 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblLabels_015 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_014 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.HScroll1 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.VScroll1 = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.picCanvas.SuspendLayout()
		Me.picButtons.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdFiller
		'
		Me.cmdFiller.Name = "cmdFiller"
		Me.cmdFiller.Size = New System.Drawing.Size(25, 25)
		Me.cmdFiller.Location = New System.Drawing.Point(688, 440)
		Me.cmdFiller.TabIndex = 3
		'
		' picCanvas
		'
		Me.picCanvas.Name = "picCanvas"
		Me.picCanvas.Size = New System.Drawing.Size(625, 561)
		Me.picCanvas.Location = New System.Drawing.Point(8, 0)
		Me.picCanvas.TabIndex = 2
		Me.picCanvas.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' picButtons
		'
		Me.picButtons.Name = "picButtons"
		Me.picButtons.Size = New System.Drawing.Size(370, 28)
		Me.picButtons.Location = New System.Drawing.Point(-8, 8)
		Me.picButtons.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.picButtons.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picButtons.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.picButtons.TabIndex = 34
		Me.picButtons.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' cmdAdd
		'
		Me.cmdAdd.Name = "cmdAdd"
		Me.cmdAdd.Size = New System.Drawing.Size(65, 27)
		Me.cmdAdd.Location = New System.Drawing.Point(16, 0)
		Me.cmdAdd.Caption = "&Add"
		Me.cmdAdd.TabIndex = 39
		'
		' cmdUpdate
		'
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdUpdate.Size = New System.Drawing.Size(65, 27)
		Me.cmdUpdate.Location = New System.Drawing.Point(89, 0)
		Me.cmdUpdate.Caption = "&Update"
		Me.cmdUpdate.TabIndex = 38
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(65, 27)
		Me.cmdDelete.Location = New System.Drawing.Point(162, 0)
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.TabIndex = 37
		'
		' cmdRefresh
		'
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.cmdRefresh.Size = New System.Drawing.Size(65, 27)
		Me.cmdRefresh.Location = New System.Drawing.Point(235, 0)
		Me.cmdRefresh.Caption = "&Refresh"
		Me.cmdRefresh.TabIndex = 36
		'
		' cmdClose
		'
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(65, 27)
		Me.cmdClose.Location = New System.Drawing.Point(304, 0)
		Me.cmdClose.Caption = "&Close"
		Me.cmdClose.TabIndex = 35
		'
		' datPrimaryRS
		'
		Me.datPrimaryRS.Name = "datPrimaryRS"
		Me.datPrimaryRS.Size = New System.Drawing.Size(81, 27)
		Me.datPrimaryRS.Location = New System.Drawing.Point(368, 8)
		Me.datPrimaryRS.Caption = " "
		Me.datPrimaryRS.Connect = "Access"
		Me.datPrimaryRS.DatabaseName = "C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
		Me.datPrimaryRS.DefaultCursorType = CodeArchitects.VB6Library.VBRUN.DefaultCursorTypeConstants.vbUseDefaultCursor
		Me.datPrimaryRS.DefaultType = 2
		Me.datPrimaryRS.Exclusive = False
		Me.datPrimaryRS.Options = 0
		Me.datPrimaryRS.ReadOnly = False
		Me.datPrimaryRS.RecordsetType = 1
		Me.datPrimaryRS.RecordSource = "SELECT * FROM Employees"
		'
		' txtFields_015
		'
		Me.txtFields_015.Name = "txtFields_015"
		Me.txtFields_015.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_015.Location = New System.Drawing.Point(136, 512)
		Me.txtFields_015.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_015.DataField = "ReportsTo"
		Me.txtFields_015.DataSource = datPrimaryRS
		Me.txtFields_015.TabIndex = 33
		'
		' txtFields_014
		'
		Me.txtFields_014.Name = "txtFields_014"
		Me.txtFields_014.Size = New System.Drawing.Size(457, 72)
		Me.txtFields_014.Location = New System.Drawing.Point(136, 426)
		Me.txtFields_014.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_014.DataField = "Notes"
		Me.txtFields_014.DataSource = datPrimaryRS
		Me.txtFields_014.MultiLine = -1
		Me.txtFields_014.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.txtFields_014.TabIndex = 31
		'
		' txtFields_012
		'
		Me.txtFields_012.Name = "txtFields_012"
		Me.txtFields_012.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_012.Location = New System.Drawing.Point(136, 392)
		Me.txtFields_012.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_012.DataField = "Extension"
		Me.txtFields_012.DataSource = datPrimaryRS
		Me.txtFields_012.MaxLength = 4
		Me.txtFields_012.TabIndex = 29
		'
		' txtFields_011
		'
		Me.txtFields_011.Name = "txtFields_011"
		Me.txtFields_011.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_011.Location = New System.Drawing.Point(136, 363)
		Me.txtFields_011.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_011.DataField = "HomePhone"
		Me.txtFields_011.DataSource = datPrimaryRS
		Me.txtFields_011.MaxLength = 24
		Me.txtFields_011.TabIndex = 27
		'
		' txtFields_010
		'
		Me.txtFields_010.Name = "txtFields_010"
		Me.txtFields_010.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_010.Location = New System.Drawing.Point(136, 333)
		Me.txtFields_010.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_010.DataField = "Country"
		Me.txtFields_010.DataSource = datPrimaryRS
		Me.txtFields_010.MaxLength = 15
		Me.txtFields_010.TabIndex = 25
		'
		' txtFields_009
		'
		Me.txtFields_009.Name = "txtFields_009"
		Me.txtFields_009.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_009.Location = New System.Drawing.Point(136, 304)
		Me.txtFields_009.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_009.DataField = "PostalCode"
		Me.txtFields_009.DataSource = datPrimaryRS
		Me.txtFields_009.MaxLength = 10
		Me.txtFields_009.TabIndex = 23
		'
		' txtFields_008
		'
		Me.txtFields_008.Name = "txtFields_008"
		Me.txtFields_008.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_008.Location = New System.Drawing.Point(136, 275)
		Me.txtFields_008.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_008.DataField = "Region"
		Me.txtFields_008.DataSource = datPrimaryRS
		Me.txtFields_008.MaxLength = 15
		Me.txtFields_008.TabIndex = 21
		'
		' txtFields_007
		'
		Me.txtFields_007.Name = "txtFields_007"
		Me.txtFields_007.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_007.Location = New System.Drawing.Point(136, 245)
		Me.txtFields_007.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_007.DataField = "City"
		Me.txtFields_007.DataSource = datPrimaryRS
		Me.txtFields_007.MaxLength = 15
		Me.txtFields_007.TabIndex = 19
		'
		' txtFields_006
		'
		Me.txtFields_006.Name = "txtFields_006"
		Me.txtFields_006.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_006.Location = New System.Drawing.Point(136, 216)
		Me.txtFields_006.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_006.DataField = "Address"
		Me.txtFields_006.DataSource = datPrimaryRS
		Me.txtFields_006.MaxLength = 60
		Me.txtFields_006.TabIndex = 17
		'
		' txtFields_005
		'
		Me.txtFields_005.Name = "txtFields_005"
		Me.txtFields_005.Size = New System.Drawing.Size(129, 24)
		Me.txtFields_005.Location = New System.Drawing.Point(136, 187)
		Me.txtFields_005.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_005.DataField = "HireDate"
		Me.txtFields_005.DataSource = datPrimaryRS
		Me.txtFields_005.TabIndex = 15
		'
		' txtFields_004
		'
		Me.txtFields_004.Name = "txtFields_004"
		Me.txtFields_004.Size = New System.Drawing.Size(129, 24)
		Me.txtFields_004.Location = New System.Drawing.Point(136, 157)
		Me.txtFields_004.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_004.DataField = "BirthDate"
		Me.txtFields_004.DataSource = datPrimaryRS
		Me.txtFields_004.TabIndex = 13
		'
		' txtFields_003
		'
		Me.txtFields_003.Name = "txtFields_003"
		Me.txtFields_003.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_003.Location = New System.Drawing.Point(136, 128)
		Me.txtFields_003.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_003.DataField = "TitleOfCourtesy"
		Me.txtFields_003.DataSource = datPrimaryRS
		Me.txtFields_003.MaxLength = 25
		Me.txtFields_003.TabIndex = 11
		'
		' txtFields_002
		'
		Me.txtFields_002.Name = "txtFields_002"
		Me.txtFields_002.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_002.Location = New System.Drawing.Point(136, 99)
		Me.txtFields_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_002.DataField = "Title"
		Me.txtFields_002.DataSource = datPrimaryRS
		Me.txtFields_002.MaxLength = 30
		Me.txtFields_002.TabIndex = 9
		'
		' txtFields_001
		'
		Me.txtFields_001.Name = "txtFields_001"
		Me.txtFields_001.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_001.Location = New System.Drawing.Point(136, 69)
		Me.txtFields_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_001.DataField = "FirstName"
		Me.txtFields_001.DataSource = datPrimaryRS
		Me.txtFields_001.MaxLength = 10
		Me.txtFields_001.TabIndex = 7
		'
		' txtFields_000
		'
		Me.txtFields_000.Name = "txtFields_000"
		Me.txtFields_000.Size = New System.Drawing.Size(457, 24)
		Me.txtFields_000.Location = New System.Drawing.Point(136, 40)
		Me.txtFields_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFields_000.DataField = "LastName"
		Me.txtFields_000.DataSource = datPrimaryRS
		Me.txtFields_000.MaxLength = 20
		Me.txtFields_000.TabIndex = 5
		'
		' lblLabels_015
		'
		Me.lblLabels_015.Name = "lblLabels_015"
		Me.lblLabels_015.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_015.Location = New System.Drawing.Point(8, 512)
		Me.lblLabels_015.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_015.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_015.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_015.Caption = "ReportsTo:"
		Me.lblLabels_015.TabIndex = 32
		'
		' lblLabels_014
		'
		Me.lblLabels_014.Name = "lblLabels_014"
		Me.lblLabels_014.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_014.Location = New System.Drawing.Point(8, 426)
		Me.lblLabels_014.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_014.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_014.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_014.Caption = "Notes:"
		Me.lblLabels_014.TabIndex = 30
		'
		' lblLabels_012
		'
		Me.lblLabels_012.Name = "lblLabels_012"
		Me.lblLabels_012.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_012.Location = New System.Drawing.Point(8, 396)
		Me.lblLabels_012.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_012.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_012.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_012.Caption = "Extension:"
		Me.lblLabels_012.TabIndex = 28
		'
		' lblLabels_011
		'
		Me.lblLabels_011.Name = "lblLabels_011"
		Me.lblLabels_011.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_011.Location = New System.Drawing.Point(8, 366)
		Me.lblLabels_011.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_011.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_011.Caption = "HomePhone:"
		Me.lblLabels_011.TabIndex = 26
		'
		' lblLabels_010
		'
		Me.lblLabels_010.Name = "lblLabels_010"
		Me.lblLabels_010.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_010.Location = New System.Drawing.Point(8, 337)
		Me.lblLabels_010.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_010.Caption = "Country:"
		Me.lblLabels_010.TabIndex = 24
		'
		' lblLabels_009
		'
		Me.lblLabels_009.Name = "lblLabels_009"
		Me.lblLabels_009.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_009.Location = New System.Drawing.Point(8, 307)
		Me.lblLabels_009.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_009.Caption = "PostalCode:"
		Me.lblLabels_009.TabIndex = 22
		'
		' lblLabels_008
		'
		Me.lblLabels_008.Name = "lblLabels_008"
		Me.lblLabels_008.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_008.Location = New System.Drawing.Point(8, 277)
		Me.lblLabels_008.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_008.Caption = "Region:"
		Me.lblLabels_008.TabIndex = 20
		'
		' lblLabels_007
		'
		Me.lblLabels_007.Name = "lblLabels_007"
		Me.lblLabels_007.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_007.Location = New System.Drawing.Point(8, 248)
		Me.lblLabels_007.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_007.Caption = "City:"
		Me.lblLabels_007.TabIndex = 18
		'
		' lblLabels_006
		'
		Me.lblLabels_006.Name = "lblLabels_006"
		Me.lblLabels_006.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_006.Location = New System.Drawing.Point(8, 218)
		Me.lblLabels_006.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_006.Caption = "Address:"
		Me.lblLabels_006.TabIndex = 16
		'
		' lblLabels_005
		'
		Me.lblLabels_005.Name = "lblLabels_005"
		Me.lblLabels_005.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_005.Location = New System.Drawing.Point(8, 188)
		Me.lblLabels_005.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_005.Caption = "HireDate:"
		Me.lblLabels_005.TabIndex = 14
		'
		' lblLabels_004
		'
		Me.lblLabels_004.Name = "lblLabels_004"
		Me.lblLabels_004.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_004.Location = New System.Drawing.Point(8, 159)
		Me.lblLabels_004.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_004.Caption = "BirthDate:"
		Me.lblLabels_004.TabIndex = 12
		'
		' lblLabels_003
		'
		Me.lblLabels_003.Name = "lblLabels_003"
		Me.lblLabels_003.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_003.Location = New System.Drawing.Point(8, 129)
		Me.lblLabels_003.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_003.Caption = "TitleOfCourtesy:"
		Me.lblLabels_003.TabIndex = 10
		'
		' lblLabels_002
		'
		Me.lblLabels_002.Name = "lblLabels_002"
		Me.lblLabels_002.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_002.Location = New System.Drawing.Point(8, 99)
		Me.lblLabels_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_002.Caption = "Title:"
		Me.lblLabels_002.TabIndex = 8
		'
		' lblLabels_001
		'
		Me.lblLabels_001.Name = "lblLabels_001"
		Me.lblLabels_001.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_001.Location = New System.Drawing.Point(8, 70)
		Me.lblLabels_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_001.Caption = "FirstName:"
		Me.lblLabels_001.TabIndex = 6
		'
		' lblLabels_000
		'
		Me.lblLabels_000.Name = "lblLabels_000"
		Me.lblLabels_000.Size = New System.Drawing.Size(121, 20)
		Me.lblLabels_000.Location = New System.Drawing.Point(8, 40)
		Me.lblLabels_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLabels_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLabels_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLabels_000.Caption = "LastName:"
		Me.lblLabels_000.TabIndex = 4
		'
		' HScroll1
		'
		Me.HScroll1.Name = "HScroll1"
		Me.HScroll1.Size = New System.Drawing.Size(169, 20)
		Me.HScroll1.Location = New System.Drawing.Point(8, 448)
		Me.HScroll1.TabIndex = 1
		'
		' VScroll1
		'
		Me.VScroll1.Name = "VScroll1"
		Me.VScroll1.Size = New System.Drawing.Size(20, 217)
		Me.VScroll1.Location = New System.Drawing.Point(696, 16)
		Me.VScroll1.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Scrollable Form Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(730, 474)

		Me.Controls.Add(cmdFiller)
		Me.Controls.Add(picCanvas)
		Me.picCanvas.Controls.Add(picButtons)
		Me.picButtons.Controls.Add(cmdAdd)
		Me.picButtons.Controls.Add(cmdUpdate)
		Me.picButtons.Controls.Add(cmdDelete)
		Me.picButtons.Controls.Add(cmdRefresh)
		Me.picButtons.Controls.Add(cmdClose)
		Me.picCanvas.Controls.Add(datPrimaryRS)
		Me.picCanvas.Controls.Add(txtFields_015)
		Me.picCanvas.Controls.Add(txtFields_014)
		Me.picCanvas.Controls.Add(txtFields_012)
		Me.picCanvas.Controls.Add(txtFields_011)
		Me.picCanvas.Controls.Add(txtFields_010)
		Me.picCanvas.Controls.Add(txtFields_009)
		Me.picCanvas.Controls.Add(txtFields_008)
		Me.picCanvas.Controls.Add(txtFields_007)
		Me.picCanvas.Controls.Add(txtFields_006)
		Me.picCanvas.Controls.Add(txtFields_005)
		Me.picCanvas.Controls.Add(txtFields_004)
		Me.picCanvas.Controls.Add(txtFields_003)
		Me.picCanvas.Controls.Add(txtFields_002)
		Me.picCanvas.Controls.Add(txtFields_001)
		Me.picCanvas.Controls.Add(txtFields_000)
		Me.picCanvas.Controls.Add(lblLabels_015)
		Me.picCanvas.Controls.Add(lblLabels_014)
		Me.picCanvas.Controls.Add(lblLabels_012)
		Me.picCanvas.Controls.Add(lblLabels_011)
		Me.picCanvas.Controls.Add(lblLabels_010)
		Me.picCanvas.Controls.Add(lblLabels_009)
		Me.picCanvas.Controls.Add(lblLabels_008)
		Me.picCanvas.Controls.Add(lblLabels_007)
		Me.picCanvas.Controls.Add(lblLabels_006)
		Me.picCanvas.Controls.Add(lblLabels_005)
		Me.picCanvas.Controls.Add(lblLabels_004)
		Me.picCanvas.Controls.Add(lblLabels_003)
		Me.picCanvas.Controls.Add(lblLabels_002)
		Me.picCanvas.Controls.Add(lblLabels_001)
		Me.picCanvas.Controls.Add(lblLabels_000)
		Me.Controls.Add(HScroll1)
		Me.Controls.Add(VScroll1)
		Me.picCanvas.ResumeLayout(False)
		Me.picButtons.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
