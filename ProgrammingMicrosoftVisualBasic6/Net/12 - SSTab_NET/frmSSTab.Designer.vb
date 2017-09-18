<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSSTab
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
		Me.Option1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(Option1_005, Option1_004, Option1_003, Option1_002, Option1_001, Option1_000)
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
	Public Option1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents SSTab1 As CodeArchitects.VB6Library.VB6SSTab
	Public WithEvents SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents txtRequired As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Option1_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents txtGeneric As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents txtNumeric As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Option1_005 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_004 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option1_003 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Text5 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Text6 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdAddTab As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSSTab))
		Me.SSTab1 = New CodeArchitects.VB6Library.VB6SSTab()
		Me.SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.txtRequired = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Option1_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.txtGeneric = New CodeArchitects.VB6Library.VB6TextBox()
		Me.SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.txtNumeric = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Option1_005 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_004 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option1_003 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Text5 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Text6 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdAddTab = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.SSTab1.SuspendLayout()
		Me.SSTab1_TabPage0.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SSTab1_TabPage1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SSTab1_TabPage2.SuspendLayout()
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' SSTab1
		'
		Me.SSTab1.Name = "SSTab1"
		Me.SSTab1.Size = New System.Drawing.Size(401, 177)
		Me.SSTab1.Location = New System.Drawing.Point(0, 0)
		Me.SSTab1.TabIndex = 19
		Me.SSTab1.Tab = 0
		'
		' SSTab1_TabPage0
		'
		Me.SSTab1_TabPage0.Name = "SSTab1_TabPage0"
		Me.SSTab1_TabPage0.Text = "First"
		Me.SSTab1_TabPage0.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 17)
		Me.Label1.Location = New System.Drawing.Point(32, 20)
		Me.Label1.Caption = "&Required textbox"
		Me.Label1.TabIndex = 0
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(153, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 84)
		Me.Label3.Caption = "&Generic textbox"
		Me.Label3.TabIndex = 2
		'
		' txtRequired
		'
		Me.txtRequired.Name = "txtRequired"
		Me.txtRequired.Size = New System.Drawing.Size(169, 25)
		Me.txtRequired.Location = New System.Drawing.Point(32, 44)
		Me.txtRequired.TabIndex = 1
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(145, 113)
		Me.Frame1.Location = New System.Drawing.Point(216, 28)
		Me.Frame1.Caption = "Frame1"
		Me.Frame1.TabIndex = 4
		'
		' Option1_002
		'
		Me.Option1_002.Name = "Option1_002"
		Me.Option1_002.Size = New System.Drawing.Size(105, 17)
		Me.Option1_002.Location = New System.Drawing.Point(16, 80)
		Me.Option1_002.Caption = "Option1"
		Me.Option1_002.TabIndex = 7
		'
		' Option1_001
		'
		Me.Option1_001.Name = "Option1_001"
		Me.Option1_001.Size = New System.Drawing.Size(105, 17)
		Me.Option1_001.Location = New System.Drawing.Point(16, 56)
		Me.Option1_001.Caption = "Option1"
		Me.Option1_001.TabIndex = 6
		'
		' Option1_000
		'
		Me.Option1_000.Name = "Option1_000"
		Me.Option1_000.Size = New System.Drawing.Size(105, 17)
		Me.Option1_000.Location = New System.Drawing.Point(16, 32)
		Me.Option1_000.Caption = "Option1"
		Me.Option1_000.TabIndex = 5
		Me.Option1_000.Value = True
		'
		' txtGeneric
		'
		Me.txtGeneric.Name = "txtGeneric"
		Me.txtGeneric.Size = New System.Drawing.Size(169, 25)
		Me.txtGeneric.Location = New System.Drawing.Point(32, 108)
		Me.txtGeneric.TabIndex = 3
		'
		' SSTab1_TabPage1
		'
		Me.SSTab1_TabPage1.Name = "SSTab1_TabPage1"
		Me.SSTab1_TabPage1.Text = "Second"
		Me.SSTab1_TabPage1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(137, 17)
		Me.Label2.Location = New System.Drawing.Point(32, 12)
		Me.Label2.Caption = "&Numeric Textbox"
		Me.Label2.TabIndex = 8
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(169, 81)
		Me.Label4.Location = New System.Drawing.Point(32, 60)
		Me.Label4.Caption = "The OptionButtons controls on this tab are distinct from those on page ""First"" because are enclosed in a Frame control."
		Me.Label4.TabIndex = 10
		'
		' txtNumeric
		'
		Me.txtNumeric.Name = "txtNumeric"
		Me.txtNumeric.Size = New System.Drawing.Size(129, 25)
		Me.txtNumeric.Location = New System.Drawing.Point(32, 28)
		Me.txtNumeric.TabIndex = 9
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(145, 113)
		Me.Frame2.Location = New System.Drawing.Point(216, 20)
		Me.Frame2.Caption = "Frame1"
		Me.Frame2.TabIndex = 11
		'
		' Option1_005
		'
		Me.Option1_005.Name = "Option1_005"
		Me.Option1_005.Size = New System.Drawing.Size(105, 17)
		Me.Option1_005.Location = New System.Drawing.Point(16, 32)
		Me.Option1_005.Caption = "Option1"
		Me.Option1_005.TabIndex = 12
		Me.Option1_005.Value = True
		'
		' Option1_004
		'
		Me.Option1_004.Name = "Option1_004"
		Me.Option1_004.Size = New System.Drawing.Size(105, 17)
		Me.Option1_004.Location = New System.Drawing.Point(16, 56)
		Me.Option1_004.Caption = "Option1"
		Me.Option1_004.TabIndex = 13
		'
		' Option1_003
		'
		Me.Option1_003.Name = "Option1_003"
		Me.Option1_003.Size = New System.Drawing.Size(105, 17)
		Me.Option1_003.Location = New System.Drawing.Point(16, 80)
		Me.Option1_003.Caption = "Option1"
		Me.Option1_003.TabIndex = 14
		'
		' SSTab1_TabPage2
		'
		Me.SSTab1_TabPage2.Name = "SSTab1_TabPage2"
		Me.SSTab1_TabPage2.Text = "Third"
		Me.SSTab1_TabPage2.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(137, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 12)
		Me.Label5.Caption = "A &Generic textbox"
		Me.Label5.TabIndex = 15
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(273, 17)
		Me.Label6.Location = New System.Drawing.Point(24, 68)
		Me.Label6.Caption = "&Another generic textbox"
		Me.Label6.TabIndex = 17
		'
		' Text5
		'
		Me.Text5.Name = "Text5"
		Me.Text5.Size = New System.Drawing.Size(345, 25)
		Me.Text5.Location = New System.Drawing.Point(24, 28)
		Me.Text5.TabIndex = 16
		'
		' Text6
		'
		Me.Text6.Name = "Text6"
		Me.Text6.Size = New System.Drawing.Size(217, 25)
		Me.Text6.Location = New System.Drawing.Point(24, 84)
		Me.Text6.TabIndex = 18
		'
		' cmdAddTab
		'
		Me.cmdAddTab.Name = "cmdAddTab"
		Me.cmdAddTab.Size = New System.Drawing.Size(113, 33)
		Me.cmdAddTab.Location = New System.Drawing.Point(256, 84)
		Me.cmdAddTab.Caption = "Add a &New Tab"
		Me.cmdAddTab.TabIndex = 20
		'
		' frmSSTab
		'
		Me.Name = "frmSSTab"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "SSTab Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(403, 181)

		Me.Controls.Add(SSTab1)
		Me.SSTab1.Controls.Add(SSTab1_TabPage0)
		Me.SSTab1_TabPage0.Controls.Add(Label1)
		Me.SSTab1_TabPage0.Controls.Add(Label3)
		Me.SSTab1_TabPage0.Controls.Add(txtRequired)
		Me.SSTab1_TabPage0.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Option1_002)
		Me.Frame1.Controls.Add(Option1_001)
		Me.Frame1.Controls.Add(Option1_000)
		Me.SSTab1_TabPage0.Controls.Add(txtGeneric)
		Me.SSTab1.Controls.Add(SSTab1_TabPage1)
		Me.SSTab1_TabPage1.Controls.Add(Label2)
		Me.SSTab1_TabPage1.Controls.Add(Label4)
		Me.SSTab1_TabPage1.Controls.Add(txtNumeric)
		Me.SSTab1_TabPage1.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(Option1_005)
		Me.Frame2.Controls.Add(Option1_004)
		Me.Frame2.Controls.Add(Option1_003)
		Me.SSTab1.Controls.Add(SSTab1_TabPage2)
		Me.SSTab1_TabPage2.Controls.Add(Label5)
		Me.SSTab1_TabPage2.Controls.Add(Label6)
		Me.SSTab1_TabPage2.Controls.Add(Text5)
		Me.SSTab1_TabPage2.Controls.Add(Text6)
		Me.SSTab1_TabPage2.Controls.Add(cmdAddTab)
		CType(Me.SSTab1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SSTab1.ResumeLayout(False)
		Me.SSTab1_TabPage0.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.SSTab1_TabPage1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.SSTab1_TabPage2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
