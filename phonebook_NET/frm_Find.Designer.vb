<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_Find
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
		Me.lin_Line = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)(lin_Line_001, lin_Line_000)
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
	Public lin_Line As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Line)
	Public WithEvents tbx_EMail As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_Address As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lvw_Find As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents btn_Find As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Close As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents tbx_TelNo As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_LastName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_FirstName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lbl_EMail As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_Address As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lin_Line_001 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents lin_Line_000 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents lbl_TelNo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_LastName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_FirstName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lvw_Find_Control As System.Windows.Forms.ListView
	Public WithEvents lvw_Find_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_Find_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_Find_Column3 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_Find))
		Me.tbx_EMail = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_Address = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lvw_Find = New CodeArchitects.VB6Library.VB6ListView()
		Me.btn_Find = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Close = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.tbx_TelNo = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_LastName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_FirstName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lbl_EMail = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_Address = New CodeArchitects.VB6Library.VB6Label()
		Me.lin_Line_001 = New CodeArchitects.VB6Library.VB6Line()
		Me.lin_Line_000 = New CodeArchitects.VB6Library.VB6Line()
		Me.lbl_TelNo = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_LastName = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_FirstName = New CodeArchitects.VB6Library.VB6Label()
		Me.lvw_Find_Control = New System.Windows.Forms.ListView()
		Me.lvw_Find_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_Find_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_Find_Column3 = New System.Windows.Forms.ColumnHeader()
		CType(Me.lvw_Find, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lin_Line_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lin_Line_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' tbx_EMail
		'
		Me.tbx_EMail.Name = "tbx_EMail"
		Me.tbx_EMail.Size = New System.Drawing.Size(201, 19)
		Me.tbx_EMail.Location = New System.Drawing.Point(24, 73)
		Me.tbx_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_EMail.DataField = "FirstName"
		Me.tbx_EMail.TabIndex = 3
		'
		' tbx_Address
		'
		Me.tbx_Address.Name = "tbx_Address"
		Me.tbx_Address.Size = New System.Drawing.Size(217, 19)
		Me.tbx_Address.Location = New System.Drawing.Point(240, 73)
		Me.tbx_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_Address.DataField = "FirstName"
		Me.tbx_Address.TabIndex = 4
		'
		' lvw_Find
		'
		Me.lvw_Find.Name = "lvw_Find"
		Me.lvw_Find.Location = New System.Drawing.Point(25, 105)
		Me.lvw_Find.Size = New System.Drawing.Size(2, 2)
		Me.lvw_Find.ListView = Me.lvw_Find_Control
		Me.lvw_Find_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvw_Find_Column1, Me.lvw_Find_Column2, Me.lvw_Find_Column3})
		'
		' btn_Find
		'
		Me.btn_Find.Name = "btn_Find"
		Me.btn_Find.Size = New System.Drawing.Size(65, 25)
		Me.btn_Find.Location = New System.Drawing.Point(473, 33)
		Me.btn_Find.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Find.Caption = "&Find"
		Me.btn_Find.TabIndex = 5
		Me.btn_Find.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.btn_Find
		Me.btn_Find.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' btn_Close
		'
		Me.btn_Close.Name = "btn_Close"
		Me.btn_Close.Size = New System.Drawing.Size(65, 25)
		Me.btn_Close.Location = New System.Drawing.Point(473, 65)
		Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Close.Caption = "&Close"
		Me.btn_Close.TabIndex = 6
		Me.btn_Close.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' tbx_TelNo
		'
		Me.tbx_TelNo.Name = "tbx_TelNo"
		Me.tbx_TelNo.Size = New System.Drawing.Size(169, 19)
		Me.tbx_TelNo.Location = New System.Drawing.Point(289, 33)
		Me.tbx_TelNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_TelNo.DataField = "TelNo"
		Me.tbx_TelNo.TabIndex = 2
		'
		' tbx_LastName
		'
		Me.tbx_LastName.Name = "tbx_LastName"
		Me.tbx_LastName.Size = New System.Drawing.Size(129, 19)
		Me.tbx_LastName.Location = New System.Drawing.Point(145, 33)
		Me.tbx_LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_LastName.DataField = "LastName"
		Me.tbx_LastName.TabIndex = 1
		'
		' tbx_FirstName
		'
		Me.tbx_FirstName.Name = "tbx_FirstName"
		Me.tbx_FirstName.Size = New System.Drawing.Size(105, 19)
		Me.tbx_FirstName.Location = New System.Drawing.Point(25, 33)
		Me.tbx_FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_FirstName.DataField = "FirstName"
		Me.tbx_FirstName.TabIndex = 0
		'
		' lbl_EMail
		'
		Me.lbl_EMail.Name = "lbl_EMail"
		Me.lbl_EMail.Size = New System.Drawing.Size(28, 13)
		Me.lbl_EMail.Location = New System.Drawing.Point(32, 57)
		Me.lbl_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_EMail.AutoSize = True
		Me.lbl_EMail.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_EMail.Caption = "EMail:"
		Me.lbl_EMail.TabIndex = 12
		Me.lbl_EMail.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_Address
		'
		Me.lbl_Address.Name = "lbl_Address"
		Me.lbl_Address.Size = New System.Drawing.Size(43, 13)
		Me.lbl_Address.Location = New System.Drawing.Point(248, 57)
		Me.lbl_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Address.AutoSize = True
		Me.lbl_Address.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_Address.Caption = "Address:"
		Me.lbl_Address.TabIndex = 11
		Me.lbl_Address.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lin_Line_001
		'
		Me.lin_Line_001.Name = "lin_Line_001"
		Me.lin_Line_001.ParentForm = Me
		Me.lin_Line_001.Name6 = "lin_Line_001"
		Me.lin_Line_001.BorderColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lin_Line_001.X1 = 375
		Me.lin_Line_001.X2 = 8055
		Me.lin_Line_001.Y1 = 1470
		Me.lin_Line_001.Y2 = 1470
		'
		' lin_Line_000
		'
		Me.lin_Line_000.Name = "lin_Line_000"
		Me.lin_Line_000.ParentForm = Me
		Me.lin_Line_000.Name6 = "lin_Line_000"
		Me.lin_Line_000.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.lin_Line_000.X1 = 375
		Me.lin_Line_000.X2 = 8055
		Me.lin_Line_000.Y1 = 1455
		Me.lin_Line_000.Y2 = 1455
		'
		' lbl_TelNo
		'
		Me.lbl_TelNo.Name = "lbl_TelNo"
		Me.lbl_TelNo.Size = New System.Drawing.Size(94, 13)
		Me.lbl_TelNo.Location = New System.Drawing.Point(297, 17)
		Me.lbl_TelNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_TelNo.AutoSize = True
		Me.lbl_TelNo.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_TelNo.Caption = "Telephone Number:"
		Me.lbl_TelNo.TabIndex = 9
		Me.lbl_TelNo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_LastName
		'
		Me.lbl_LastName.Name = "lbl_LastName"
		Me.lbl_LastName.Size = New System.Drawing.Size(54, 13)
		Me.lbl_LastName.Location = New System.Drawing.Point(153, 17)
		Me.lbl_LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_LastName.AutoSize = True
		Me.lbl_LastName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_LastName.Caption = "Last Name:"
		Me.lbl_LastName.TabIndex = 8
		Me.lbl_LastName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_FirstName
		'
		Me.lbl_FirstName.Name = "lbl_FirstName"
		Me.lbl_FirstName.Size = New System.Drawing.Size(55, 13)
		Me.lbl_FirstName.Location = New System.Drawing.Point(33, 17)
		Me.lbl_FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_FirstName.AutoSize = True
		Me.lbl_FirstName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_FirstName.Caption = "First Name:"
		Me.lbl_FirstName.TabIndex = 7
		Me.lbl_FirstName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lvw_Find_Control
		'
		Me.lvw_Find_Control.Name = "lvw_Find_Control"
		Me.lvw_Find_Control.Size = New System.Drawing.Size(513, 97)
		Me.lvw_Find_Control.Location = New System.Drawing.Point(25, 105)
		Me.lvw_Find_Control.ShowItemToolTips = True
		Me.lvw_Find_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.lvw_Find_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.lvw_Find_Control.TabIndex = 10
		Me.lvw_Find_Control.FullRowSelect = True
		Me.lvw_Find_Control.GridLines = True
		Me.lvw_Find_Control.HideSelection = True
		Me.lvw_Find_Control.LabelWrap = True
		Me.lvw_Find_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.lvw_Find_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvw_Find_Control.LabelEdit = True
		Me.lvw_Find_Control.MultiSelect = False
		Me.lvw_Find_Control.View = System.Windows.Forms.View.Details
		Me.lvw_Find_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.lvw_Find_Control.BackgroundImageTiled = False
		'
		' lvw_Find_Column1
		'
		Me.lvw_Find_Column1.Name = "lvw_Find_Column1"
		Me.lvw_Find_Column1.Text = "First Name"
		Me.lvw_Find_Column1.Width = 110
		'
		' lvw_Find_Column2
		'
		Me.lvw_Find_Column2.Name = "lvw_Find_Column2"
		Me.lvw_Find_Column2.Text = "Last Name"
		Me.lvw_Find_Column2.Width = 140
		'
		' lvw_Find_Column3
		'
		Me.lvw_Find_Column3.Name = "lvw_Find_Column3"
		Me.lvw_Find_Column3.Text = "Telephone Number"
		Me.lvw_Find_Column3.Width = 240
		'
		' frm_Find
		'
		Me.Name = "frm_Find"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Find A Person"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(563, 226)

		Me.Controls.Add(tbx_EMail)
		Me.Controls.Add(tbx_Address)
		Me.Controls.Add(lvw_Find)
		Me.Controls.Add(btn_Find)
		Me.Controls.Add(btn_Close)
		Me.Controls.Add(tbx_TelNo)
		Me.Controls.Add(tbx_LastName)
		Me.Controls.Add(tbx_FirstName)
		Me.Controls.Add(lbl_EMail)
		Me.Controls.Add(lbl_Address)
		Me.Controls.Add(lbl_TelNo)
		Me.Controls.Add(lbl_LastName)
		Me.Controls.Add(lbl_FirstName)
		Me.Controls.Add(lvw_Find_Control)
		CType(Me.lvw_Find, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lin_Line_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lin_Line_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
