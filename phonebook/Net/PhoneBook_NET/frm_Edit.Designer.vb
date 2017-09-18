<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_Edit
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
	Public WithEvents btn_Last As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Next As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Previous As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_First As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Delete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents tbx_FirstName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_LastName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tbx_TelNo As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents btn_Update As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents btn_Close As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lbl_Address As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_EMail As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_FirstName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_LastName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbl_TelNo As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_Edit))
		Me.tbx_Address = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_EMail = New CodeArchitects.VB6Library.VB6TextBox()
		Me.btn_Last = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Next = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Previous = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_First = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Delete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.tbx_FirstName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_LastName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tbx_TelNo = New CodeArchitects.VB6Library.VB6TextBox()
		Me.btn_Update = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.btn_Close = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lbl_Address = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_EMail = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_FirstName = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_LastName = New CodeArchitects.VB6Library.VB6Label()
		Me.lbl_TelNo = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' tbx_Address
		'
		Me.tbx_Address.Name = "tbx_Address"
		Me.tbx_Address.Size = New System.Drawing.Size(265, 19)
		Me.tbx_Address.Location = New System.Drawing.Point(244, 71)
		Me.tbx_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_Address.DataField = "FirstName"
		Me.tbx_Address.TabIndex = 4
		'
		' tbx_EMail
		'
		Me.tbx_EMail.Name = "tbx_EMail"
		Me.tbx_EMail.Size = New System.Drawing.Size(201, 19)
		Me.tbx_EMail.Location = New System.Drawing.Point(28, 72)
		Me.tbx_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_EMail.DataField = "FirstName"
		Me.tbx_EMail.TabIndex = 3
		'
		' btn_Last
		'
		Me.btn_Last.Name = "btn_Last"
		Me.btn_Last.Size = New System.Drawing.Size(23, 20)
		Me.btn_Last.Location = New System.Drawing.Point(108, 106)
		Me.btn_Last.Picture = CType(resources.GetObject("btn_Last.Picture"), System.Drawing.Image)
		Me.btn_Last.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.btn_Last.TabIndex = 9
		Me.btn_Last.UseMaskColor = True
		Me.btn_Last.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_Next
		'
		Me.btn_Next.Name = "btn_Next"
		Me.btn_Next.Size = New System.Drawing.Size(23, 20)
		Me.btn_Next.Location = New System.Drawing.Point(85, 106)
		Me.btn_Next.Picture = CType(resources.GetObject("btn_Next.Picture"), System.Drawing.Image)
		Me.btn_Next.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.btn_Next.TabIndex = 8
		Me.btn_Next.UseMaskColor = True
		Me.btn_Next.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_Previous
		'
		Me.btn_Previous.Name = "btn_Previous"
		Me.btn_Previous.Size = New System.Drawing.Size(23, 20)
		Me.btn_Previous.Location = New System.Drawing.Point(52, 106)
		Me.btn_Previous.Picture = CType(resources.GetObject("btn_Previous.Picture"), System.Drawing.Image)
		Me.btn_Previous.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.btn_Previous.TabIndex = 10
		Me.btn_Previous.UseMaskColor = True
		Me.btn_Previous.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_First
		'
		Me.btn_First.Name = "btn_First"
		Me.btn_First.Size = New System.Drawing.Size(23, 20)
		Me.btn_First.Location = New System.Drawing.Point(29, 106)
		Me.btn_First.Picture = CType(resources.GetObject("btn_First.Picture"), System.Drawing.Image)
		Me.btn_First.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.btn_First.TabIndex = 11
		Me.btn_First.UseMaskColor = True
		Me.btn_First.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' btn_Delete
		'
		Me.btn_Delete.Name = "btn_Delete"
		Me.btn_Delete.Size = New System.Drawing.Size(65, 25)
		Me.btn_Delete.Location = New System.Drawing.Point(369, 103)
		Me.btn_Delete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Delete.Caption = "&Delete"
		Me.btn_Delete.TabIndex = 6
		Me.btn_Delete.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' tbx_FirstName
		'
		Me.tbx_FirstName.Name = "tbx_FirstName"
		Me.tbx_FirstName.Size = New System.Drawing.Size(105, 19)
		Me.tbx_FirstName.Location = New System.Drawing.Point(28, 32)
		Me.tbx_FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_FirstName.DataField = "FirstName"
		Me.tbx_FirstName.TabIndex = 0
		'
		' tbx_LastName
		'
		Me.tbx_LastName.Name = "tbx_LastName"
		Me.tbx_LastName.Size = New System.Drawing.Size(129, 19)
		Me.tbx_LastName.Location = New System.Drawing.Point(148, 32)
		Me.tbx_LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_LastName.DataField = "LastName"
		Me.tbx_LastName.TabIndex = 1
		'
		' tbx_TelNo
		'
		Me.tbx_TelNo.Name = "tbx_TelNo"
		Me.tbx_TelNo.Size = New System.Drawing.Size(217, 19)
		Me.tbx_TelNo.Location = New System.Drawing.Point(292, 30)
		Me.tbx_TelNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbx_TelNo.DataField = "TelNo"
		Me.tbx_TelNo.TabIndex = 2
		'
		' btn_Update
		'
		Me.btn_Update.Name = "btn_Update"
		Me.btn_Update.Size = New System.Drawing.Size(65, 25)
		Me.btn_Update.Location = New System.Drawing.Point(295, 103)
		Me.btn_Update.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Update.Caption = "&Update"
		Me.btn_Update.TabIndex = 5
		Me.btn_Update.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.btn_Update
		Me.btn_Update.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' btn_Close
		'
		Me.btn_Close.Name = "btn_Close"
		Me.btn_Close.Size = New System.Drawing.Size(65, 25)
		Me.btn_Close.Location = New System.Drawing.Point(444, 103)
		Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Close.Caption = "&Close"
		Me.btn_Close.TabIndex = 7
		Me.btn_Close.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_Address
		'
		Me.lbl_Address.Name = "lbl_Address"
		Me.lbl_Address.Size = New System.Drawing.Size(43, 13)
		Me.lbl_Address.Location = New System.Drawing.Point(252, 55)
		Me.lbl_Address.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Address.AutoSize = True
		Me.lbl_Address.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_Address.Caption = "Address:"
		Me.lbl_Address.TabIndex = 16
		Me.lbl_Address.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_EMail
		'
		Me.lbl_EMail.Name = "lbl_EMail"
		Me.lbl_EMail.Size = New System.Drawing.Size(28, 13)
		Me.lbl_EMail.Location = New System.Drawing.Point(36, 55)
		Me.lbl_EMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_EMail.AutoSize = True
		Me.lbl_EMail.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_EMail.Caption = "EMail:"
		Me.lbl_EMail.TabIndex = 15
		Me.lbl_EMail.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_FirstName
		'
		Me.lbl_FirstName.Name = "lbl_FirstName"
		Me.lbl_FirstName.Size = New System.Drawing.Size(55, 13)
		Me.lbl_FirstName.Location = New System.Drawing.Point(36, 15)
		Me.lbl_FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_FirstName.AutoSize = True
		Me.lbl_FirstName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_FirstName.Caption = "First Name:"
		Me.lbl_FirstName.TabIndex = 14
		Me.lbl_FirstName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_LastName
		'
		Me.lbl_LastName.Name = "lbl_LastName"
		Me.lbl_LastName.Size = New System.Drawing.Size(54, 13)
		Me.lbl_LastName.Location = New System.Drawing.Point(156, 15)
		Me.lbl_LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_LastName.AutoSize = True
		Me.lbl_LastName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_LastName.Caption = "Last Name:"
		Me.lbl_LastName.TabIndex = 13
		Me.lbl_LastName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbl_TelNo
		'
		Me.lbl_TelNo.Name = "lbl_TelNo"
		Me.lbl_TelNo.Size = New System.Drawing.Size(94, 13)
		Me.lbl_TelNo.Location = New System.Drawing.Point(300, 15)
		Me.lbl_TelNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_TelNo.AutoSize = True
		Me.lbl_TelNo.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lbl_TelNo.Caption = "Telephone Number:"
		Me.lbl_TelNo.TabIndex = 12
		Me.lbl_TelNo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frm_Edit
		'
		Me.Name = "frm_Edit"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Edit A Person"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(537, 152)

		Me.Controls.Add(tbx_Address)
		Me.Controls.Add(tbx_EMail)
		Me.Controls.Add(btn_Last)
		Me.Controls.Add(btn_Next)
		Me.Controls.Add(btn_Previous)
		Me.Controls.Add(btn_First)
		Me.Controls.Add(btn_Delete)
		Me.Controls.Add(tbx_FirstName)
		Me.Controls.Add(tbx_LastName)
		Me.Controls.Add(tbx_TelNo)
		Me.Controls.Add(btn_Update)
		Me.Controls.Add(btn_Close)
		Me.Controls.Add(lbl_Address)
		Me.Controls.Add(lbl_EMail)
		Me.Controls.Add(lbl_FirstName)
		Me.Controls.Add(lbl_LastName)
		Me.Controls.Add(lbl_TelNo)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
