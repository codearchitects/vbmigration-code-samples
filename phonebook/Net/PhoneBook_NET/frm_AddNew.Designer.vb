<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_AddNew
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
	Public WithEvents tbx_Address As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_EMail As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents btn_Cancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Add As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents tbx_TelNo As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_LastName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_FirstName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lbl_Address As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_EMail As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_TelNo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_LastName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_FirstName As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_AddNew))
		Me.tbx_Address = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_EMail = New CodeArchitects.VB6Library.VB6TextBox()
		Me.btn_Cancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Add = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.tbx_TelNo = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_LastName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_FirstName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lbl_Address = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_EMail = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_TelNo = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_LastName = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_FirstName = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' tbx_Address
		'
		Me.tbx_Address.Name = "tbx_Address"
		Me.tbx_Address.Size = New System.Drawing.Size(289, 19)
		Me.tbx_Address.Location = New System.Drawing.Point(232, 79)
		Me.tbx_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_Address.DataField = "TelNo"
		Me.tbx_Address.TabIndex = 4
		'
		' tbx_EMail
		'
		Me.tbx_EMail.Name = "tbx_EMail"
		Me.tbx_EMail.Size = New System.Drawing.Size(185, 19)
		Me.tbx_EMail.Location = New System.Drawing.Point(24, 79)
		Me.tbx_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_EMail.DataField = "TelNo"
		Me.tbx_EMail.TabIndex = 3
		'
		' btn_Cancel
		'
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_Cancel.Size = New System.Drawing.Size(65, 25)
		Me.btn_Cancel.Location = New System.Drawing.Point(456, 112)
		Me.btn_Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Cancel.Caption = "&Cancel"
		Me.btn_Cancel.TabIndex = 6
		Me.btn_Cancel.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_Add
		'
		Me.btn_Add.Name = "btn_Add"
		Me.btn_Add.Size = New System.Drawing.Size(65, 25)
		Me.btn_Add.Location = New System.Drawing.Point(386, 112)
		Me.btn_Add.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Add.Caption = "&Add"
		Me.btn_Add.TabIndex = 5
		Me.btn_Add.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.btn_Add
		Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' tbx_TelNo
		'
		Me.tbx_TelNo.Name = "tbx_TelNo"
		Me.tbx_TelNo.Size = New System.Drawing.Size(232, 19)
		Me.tbx_TelNo.Location = New System.Drawing.Point(289, 32)
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
		' lbl_Address
		'
		Me.lbl_Address.Name = "lbl_Address"
		Me.lbl_Address.Size = New System.Drawing.Size(43, 13)
		Me.lbl_Address.Location = New System.Drawing.Point(240, 64)
		Me.lbl_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Address.AutoSize = True
		Me.lbl_Address.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_Address.Caption = "Address:"
		Me.lbl_Address.TabIndex = 11
		Me.lbl_Address.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_EMail
		'
		Me.lbl_EMail.Name = "lbl_EMail"
		Me.lbl_EMail.Size = New System.Drawing.Size(28, 13)
		Me.lbl_EMail.Location = New System.Drawing.Point(32, 64)
		Me.lbl_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_EMail.AutoSize = True
		Me.lbl_EMail.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_EMail.Caption = "EMail:"
		Me.lbl_EMail.TabIndex = 10
		Me.lbl_EMail.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_TelNo
		'
		Me.lbl_TelNo.Name = "lbl_TelNo"
		Me.lbl_TelNo.Size = New System.Drawing.Size(94, 13)
		Me.lbl_TelNo.Location = New System.Drawing.Point(298, 17)
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
		Me.lbl_LastName.Location = New System.Drawing.Point(154, 17)
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
		Me.lbl_FirstName.Location = New System.Drawing.Point(34, 17)
		Me.lbl_FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_FirstName.AutoSize = True
		Me.lbl_FirstName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_FirstName.Caption = "First Name:"
		Me.lbl_FirstName.TabIndex = 7
		Me.lbl_FirstName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frm_AddNew
		'
		Me.Name = "frm_AddNew"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Add New Person"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(546, 160)

		Me.Controls.Add(tbx_Address)
		Me.Controls.Add(tbx_EMail)
		Me.Controls.Add(btn_Cancel)
		Me.Controls.Add(btn_Add)
		Me.Controls.Add(tbx_TelNo)
		Me.Controls.Add(tbx_LastName)
		Me.Controls.Add(tbx_FirstName)
		Me.Controls.Add(lbl_Address)
		Me.Controls.Add(lbl_EMail)
		Me.Controls.Add(lbl_TelNo)
		Me.Controls.Add(lbl_LastName)
		Me.Controls.Add(lbl_FirstName)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
