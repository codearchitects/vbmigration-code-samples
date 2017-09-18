<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmshowfnt
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
		Me.HScroll5 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)(HScroll5_001, HScroll5_002, HScroll5_000)
		Me.Label7 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label7_001, Label7_002, Label7_000)
		Me.Command4 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(Command4_000, Command4_006, Command4_005, Command4_002, Command4_001)
		Me.HScroll2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)(HScroll2_000, HScroll2_001, HScroll2_002)
		Me.Label3 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label3_000, Label3_001, Label3_002)
		Me.HScroll1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)(HScroll1_001, HScroll1_002, HScroll1_000)
		Me.Label2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label2_001, Label2_002, Label2_000)
		Me.Picture3 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)(Picture3_007, Picture3_006, Picture3_005, Picture3_004, Picture3_003, Picture3_002, Picture3_001, Picture3_000)
		Me.Command9 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(Command9_000, Command9_001, Command9_002, Command9_003, Command9_004)
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
	Public HScroll5 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)
	Public Label7 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public Command4 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public HScroll2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)
	Public Label3 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public HScroll1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6HScrollBar)
	Public Label2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public Picture3 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6PictureBox)
	Public Command9 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents Picture11 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture10 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents HScroll5_001 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents HScroll5_002 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Text4 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents HScroll5_000 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Label18 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture9 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Check1 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents HScroll4 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Command4_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label17 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture8 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents list1 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents HScroll3 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Option1 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Option2 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Line17 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line16 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label19 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label16 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture7 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command12 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command10 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command11 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command13 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Label15 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture6 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents HScroll2_000 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents HScroll2_001 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents HScroll2_002 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Text2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command8 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label14 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture5 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents HScroll1_001 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents HScroll1_002 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents HScroll1_000 As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Text3 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture4 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command14 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame8 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Frame12 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Line20 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line19 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Line15 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line14 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line13 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line11 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line10 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line9 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line8 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line7 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line6 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line5 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line4 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line3 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line2 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Image2 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Line12 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Frame6 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Picture3_007 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_006 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_005 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_004 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_003 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_002 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_001 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3_000 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Cdl1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Frame5 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Command9_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command9_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command9_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command9_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command9_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Image3 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Line1 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnufile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnunieuw As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuopen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnusave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuprint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents streep As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuexit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuedit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuresize As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnubackground As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuclback As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuhelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuabout As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmshowfnt))
		Me.Picture11 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture10 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.HScroll5_001 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.HScroll5_002 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Text4 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.HScroll5_000 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Label18 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture9 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Check1 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.HScroll4 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Command4_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label17 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture8 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.list1 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.HScroll3 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Option1 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Option2 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Line17 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line16 = New CodeArchitects.VB6Library.VB6Line()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label19 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label16 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture7 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command12 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command10 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command11 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command13 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Label15 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture6 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.HScroll2_000 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.HScroll2_001 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.HScroll2_002 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Text2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command8 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label14 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture5 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.HScroll1_001 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.HScroll1_002 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.HScroll1_000 = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Text3 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture4 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command14 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame8 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Frame12 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Line20 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line19 = New CodeArchitects.VB6Library.VB6Line()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Line15 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line14 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line13 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line11 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line10 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line9 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line8 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line7 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line6 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line5 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line4 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line3 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line2 = New CodeArchitects.VB6Library.VB6Line()
		Me.Image2 = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Line12 = New CodeArchitects.VB6Library.VB6Line()
		Me.Frame6 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Picture3_007 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_006 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_005 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_004 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_003 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_002 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_001 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3_000 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Cdl1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Frame5 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Command9_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command9_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command9_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command9_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command9_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Image3 = New CodeArchitects.VB6Library.VB6Image()
		Me.Line1 = New CodeArchitects.VB6Library.VB6Line()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnufile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnunieuw = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuopen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnusave = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuprint = New CodeArchitects.VB6Library.VB6Menu()
		Me.streep = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuexit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuedit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuresize = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnubackground = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuclback = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuhelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuabout = New CodeArchitects.VB6Library.VB6Menu()
		Me.Picture11.SuspendLayout()
		Me.Picture10.SuspendLayout()
		Me.Picture9.SuspendLayout()
		Me.Picture8.SuspendLayout()
		Me.Picture7.SuspendLayout()
		Me.Picture6.SuspendLayout()
		Me.Picture5.SuspendLayout()
		Me.Picture4.SuspendLayout()
		Me.Frame8.SuspendLayout()
		Me.Frame12.SuspendLayout()
		Me.Picture2.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.Line17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture11
		'
		Me.Picture11.Name = "Picture11"
		Me.Picture11.Size = New System.Drawing.Size(569, 81)
		Me.Picture11.Location = New System.Drawing.Point(8, 496)
		Me.Picture11.Picture = CType(resources.GetObject("Picture11.Picture"), System.Drawing.Image)
		Me.Picture11.TabIndex = 81
		Me.Picture11.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture11.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(97, 28)
		Me.Command5.Location = New System.Drawing.Point(456, 16)
		Me.Command5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.Caption = "Delete text"
		Me.Command5.TabIndex = 85
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(97, 28)
		Me.Command6.Location = New System.Drawing.Point(456, 40)
		Me.Command6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command6.Caption = "Fix text"
		Me.Command6.TabIndex = 84
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(249, 28)
		Me.Text1.Location = New System.Drawing.Point(120, 32)
		Me.Text1.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.TabIndex = 83
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(99, 16)
		Me.Label8.Location = New System.Drawing.Point(200, 16)
		Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.AutoSize = True
		Me.Label8.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label8.Caption = "ENTER HERE"
		Me.Label8.TabIndex = 82
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture10
		'
		Me.Picture10.Name = "Picture10"
		Me.Picture10.Size = New System.Drawing.Size(239, 186)
		Me.Picture10.Location = New System.Drawing.Point(832, 256)
		Me.Picture10.Picture = CType(resources.GetObject("Picture10.Picture"), System.Drawing.Image)
		Me.Picture10.TabIndex = 67
		Me.Picture10.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture10.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' HScroll5_001
		'
		Me.HScroll5_001.Name = "HScroll5_001"
		Me.HScroll5_001.Size = New System.Drawing.Size(145, 17)
		Me.HScroll5_001.Location = New System.Drawing.Point(24, 112)
		Me.HScroll5_001.LargeChange = 5
		Me.HScroll5_001.Max = 255
		Me.HScroll5_001.TabIndex = 71
		Me.HScroll5_001.TabStop = True
		'
		' HScroll5_002
		'
		Me.HScroll5_002.Name = "HScroll5_002"
		Me.HScroll5_002.Size = New System.Drawing.Size(145, 17)
		Me.HScroll5_002.Location = New System.Drawing.Point(24, 136)
		Me.HScroll5_002.LargeChange = 5
		Me.HScroll5_002.Max = 255
		Me.HScroll5_002.TabIndex = 70
		Me.HScroll5_002.TabStop = True
		'
		' Text4
		'
		Me.Text4.Name = "Text4"
		Me.Text4.Size = New System.Drawing.Size(145, 25)
		Me.Text4.Location = New System.Drawing.Point(24, 56)
		Me.Text4.ReadOnly = True
		Me.Text4.TabIndex = 69
		'
		' HScroll5_000
		'
		Me.HScroll5_000.Name = "HScroll5_000"
		Me.HScroll5_000.Size = New System.Drawing.Size(145, 17)
		Me.HScroll5_000.Location = New System.Drawing.Point(24, 88)
		Me.HScroll5_000.LargeChange = 5
		Me.HScroll5_000.Max = 255
		Me.HScroll5_000.TabIndex = 68
		Me.HScroll5_000.TabStop = True
		'
		' Label18
		'
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(97, 16)
		Me.Label18.Location = New System.Drawing.Point(16, 16)
		Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label18.AutoSize = True
		Me.Label18.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label18.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label18.Caption = "Shadow Color"
		Me.Label18.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label18.TabIndex = 75
		'
		' Label7_001
		'
		Me.Label7_001.Name = "Label7_001"
		Me.Label7_001.Size = New System.Drawing.Size(33, 17)
		Me.Label7_001.Location = New System.Drawing.Point(176, 112)
		Me.Label7_001.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7_001.BackColor = FromOleColor6(CInt(&H0080FF80))
		Me.Label7_001.Caption = " "
		Me.Label7_001.TabIndex = 74
		Me.Label7_001.AutoSize = False
		'
		' Label7_002
		'
		Me.Label7_002.Name = "Label7_002"
		Me.Label7_002.Size = New System.Drawing.Size(33, 17)
		Me.Label7_002.Location = New System.Drawing.Point(176, 136)
		Me.Label7_002.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7_002.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Label7_002.Caption = " "
		Me.Label7_002.TabIndex = 73
		Me.Label7_002.AutoSize = False
		'
		' Label7_000
		'
		Me.Label7_000.Name = "Label7_000"
		Me.Label7_000.Size = New System.Drawing.Size(33, 17)
		Me.Label7_000.Location = New System.Drawing.Point(176, 88)
		Me.Label7_000.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7_000.BackColor = FromOleColor6(CInt(&H008080FF))
		Me.Label7_000.Caption = " "
		Me.Label7_000.TabIndex = 72
		Me.Label7_000.AutoSize = False
		'
		' Picture9
		'
		Me.Picture9.Name = "Picture9"
		Me.Picture9.Size = New System.Drawing.Size(239, 186)
		Me.Picture9.Location = New System.Drawing.Point(832, 32)
		Me.Picture9.Picture = CType(resources.GetObject("Picture9.Picture"), System.Drawing.Image)
		Me.Picture9.TabIndex = 49
		Me.Picture9.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture9.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Check1
		'
		Me.Check1.Name = "Check1"
		Me.Check1.Size = New System.Drawing.Size(145, 17)
		Me.Check1.Location = New System.Drawing.Point(48, 136)
		Me.Check1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Check1.BackColor = FromOleColor6(CInt(&H00800080))
		Me.Check1.Caption = "Show 3D text"
		Me.Check1.TabIndex = 86
		'
		' HScroll4
		'
		Me.HScroll4.Name = "HScroll4"
		Me.HScroll4.Size = New System.Drawing.Size(153, 20)
		Me.HScroll4.Location = New System.Drawing.Point(40, 72)
		Me.HScroll4.LargeChange = 10
		Me.HScroll4.Max = 600
		Me.HScroll4.Min = 8
		Me.HScroll4.TabIndex = 63
		Me.HScroll4.Value = 8
		Me.HScroll4.TabStop = True
		'
		' Command4_000
		'
		Me.Command4_000.Name = "Command4_000"
		Me.Command4_000.Size = New System.Drawing.Size(27, 27)
		Me.Command4_000.Location = New System.Drawing.Point(40, 96)
		Me.Command4_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4_000.TabIndex = 62
		Me.ToolTip1.SetToolTip(Me.Command4_000, "Flat")
		Me.Command4_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4_006
		'
		Me.Command4_006.Name = "Command4_006"
		Me.Command4_006.Size = New System.Drawing.Size(27, 27)
		Me.Command4_006.Location = New System.Drawing.Point(136, 96)
		Me.Command4_006.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4_006.TabIndex = 61
		Me.ToolTip1.SetToolTip(Me.Command4_006, "BottomShadow")
		Me.Command4_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4_005
		'
		Me.Command4_005.Name = "Command4_005"
		Me.Command4_005.Size = New System.Drawing.Size(27, 27)
		Me.Command4_005.Location = New System.Drawing.Point(168, 96)
		Me.Command4_005.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4_005.TabIndex = 60
		Me.ToolTip1.SetToolTip(Me.Command4_005, "BottomShadow")
		Me.Command4_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4_002
		'
		Me.Command4_002.Name = "Command4_002"
		Me.Command4_002.Size = New System.Drawing.Size(27, 27)
		Me.Command4_002.Location = New System.Drawing.Point(104, 96)
		Me.Command4_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4_002.TabIndex = 59
		Me.ToolTip1.SetToolTip(Me.Command4_002, "LeftShadow")
		Me.Command4_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4_001
		'
		Me.Command4_001.Name = "Command4_001"
		Me.Command4_001.Size = New System.Drawing.Size(27, 27)
		Me.Command4_001.Location = New System.Drawing.Point(72, 96)
		Me.Command4_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command4_001.TabIndex = 58
		Me.ToolTip1.SetToolTip(Me.Command4_001, "RightShadow")
		Me.Command4_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label17
		'
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(80, 16)
		Me.Label17.Location = New System.Drawing.Point(24, 16)
		Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label17.AutoSize = True
		Me.Label17.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label17.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label17.Caption = "3D Settings"
		Me.Label17.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label17.TabIndex = 66
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(56, 48)
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label4.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label4.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "Depth :"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label4.TabIndex = 65
		Me.Label4.AutoSize = False
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(112, 48)
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label5.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "Label5"
		Me.Label5.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label5.TabIndex = 64
		Me.Label5.AutoSize = False
		'
		' Picture8
		'
		Me.Picture8.Name = "Picture8"
		Me.Picture8.Size = New System.Drawing.Size(239, 186)
		Me.Picture8.Location = New System.Drawing.Point(584, 256)
		Me.Picture8.Picture = CType(resources.GetObject("Picture8.Picture"), System.Drawing.Image)
		Me.Picture8.TabIndex = 48
		Me.Picture8.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture8.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' list1
		'
		Me.list1.Name = "list1"
		Me.list1.Size = New System.Drawing.Size(145, 24)
		Me.list1.Location = New System.Drawing.Point(48, 136)
		Me.list1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.list1.TabIndex = 77
		Me.list1.Text = "Combo1"
		'
		' HScroll3
		'
		Me.HScroll3.Name = "HScroll3"
		Me.HScroll3.Size = New System.Drawing.Size(145, 25)
		Me.HScroll3.Location = New System.Drawing.Point(48, 88)
		Me.HScroll3.LargeChange = 3
		Me.HScroll3.Max = 100
		Me.HScroll3.Min = 8
		Me.HScroll3.TabIndex = 76
		Me.HScroll3.Value = 8
		Me.HScroll3.TabStop = True
		'
		' Option1
		'
		Me.Option1.Name = "Option1"
		Me.Option1.Size = New System.Drawing.Size(89, 17)
		Me.Option1.Location = New System.Drawing.Point(112, 40)
		Me.Option1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option1.BackColor = FromOleColor6(CInt(&H00800080))
		Me.Option1.Caption = "Portriat"
		Me.Option1.TabIndex = 56
		Me.Option1.TabStop = True
		'
		' Option2
		'
		Me.Option2.Name = "Option2"
		Me.Option2.Size = New System.Drawing.Size(89, 17)
		Me.Option2.Location = New System.Drawing.Point(112, 24)
		Me.Option2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option2.BackColor = FromOleColor6(CInt(&H00800080))
		Me.Option2.Caption = "Landscape"
		Me.Option2.TabIndex = 55
		Me.Option2.TabStop = True
		'
		' Line17
		'
		Me.Line17.Name = "Line17"
		Me.Line17.ParentForm = Me
		Me.Line17.Name6 = "Line17"
		Me.Line17.X1 = 240
		Me.Line17.X2 = 3240
		Me.Line17.Y1 = 1800
		Me.Line17.Y2 = 1800
		Me.Line17.Container = Picture8
		'
		' Line16
		'
		Me.Line16.Name = "Line16"
		Me.Line16.ParentForm = Me
		Me.Line16.Name6 = "Line16"
		Me.Line16.X1 = 240
		Me.Line16.X2 = 3240
		Me.Line16.Y1 = 960
		Me.Line16.Y2 = 960
		Me.Line16.Container = Picture8
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(96, 72)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Label1"
		Me.Label1.TabIndex = 80
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label19
		'
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(39, 16)
		Me.Label19.Location = New System.Drawing.Point(24, 120)
		Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label19.AutoSize = True
		Me.Label19.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label19.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label19.Caption = "Fonts"
		Me.Label19.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label19.TabIndex = 79
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 16)
		Me.Label6.Location = New System.Drawing.Point(24, 72)
		Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label6.Caption = "Font Size"
		Me.Label6.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label6.TabIndex = 78
		'
		' Label16
		'
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(76, 16)
		Me.Label16.Location = New System.Drawing.Point(24, 16)
		Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label16.AutoSize = True
		Me.Label16.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label16.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label16.Caption = "Orientation"
		Me.Label16.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label16.TabIndex = 57
		'
		' Picture7
		'
		Me.Picture7.Name = "Picture7"
		Me.Picture7.Size = New System.Drawing.Size(239, 186)
		Me.Picture7.Location = New System.Drawing.Point(584, 32)
		Me.Picture7.Picture = CType(resources.GetObject("Picture7.Picture"), System.Drawing.Image)
		Me.Picture7.TabIndex = 47
		Me.Picture7.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture7.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command12
		'
		Me.Command12.Name = "Command12"
		Me.Command12.Size = New System.Drawing.Size(185, 20)
		Me.Command12.Location = New System.Drawing.Point(24, 88)
		Me.Command12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command12.Caption = "Clear Background "
		Me.Command12.Enabled = False
		Me.Command12.TabIndex = 53
		Me.Command12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command10
		'
		Me.Command10.Name = "Command10"
		Me.Command10.Size = New System.Drawing.Size(185, 20)
		Me.Command10.Location = New System.Drawing.Point(24, 64)
		Me.Command10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command10.Caption = "Load Background "
		Me.Command10.Enabled = False
		Me.Command10.TabIndex = 52
		Me.Command10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command11
		'
		Me.Command11.Name = "Command11"
		Me.Command11.Size = New System.Drawing.Size(185, 20)
		Me.Command11.Location = New System.Drawing.Point(24, 136)
		Me.Command11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command11.Caption = "Print"
		Me.Command11.Enabled = False
		Me.Command11.TabIndex = 51
		Me.Command11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command13
		'
		Me.Command13.Name = "Command13"
		Me.Command13.Size = New System.Drawing.Size(185, 20)
		Me.Command13.Location = New System.Drawing.Point(24, 112)
		Me.Command13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command13.Caption = "Hide Grid"
		Me.Command13.Enabled = False
		Me.Command13.TabIndex = 50
		Me.Command13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		Me.CommonDialog1.Name6 = "CommonDialog1"
		'
		' Label15
		'
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(59, 16)
		Me.Label15.Location = New System.Drawing.Point(16, 16)
		Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label15.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label15.Caption = "Function"
		Me.Label15.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label15.TabIndex = 54
		'
		' Picture6
		'
		Me.Picture6.Name = "Picture6"
		Me.Picture6.Size = New System.Drawing.Size(239, 186)
		Me.Picture6.Location = New System.Drawing.Point(584, 480)
		Me.Picture6.Picture = CType(resources.GetObject("Picture6.Picture"), System.Drawing.Image)
		Me.Picture6.TabIndex = 37
		Me.Picture6.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture6.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' HScroll2_000
		'
		Me.HScroll2_000.Name = "HScroll2_000"
		Me.HScroll2_000.Size = New System.Drawing.Size(145, 17)
		Me.HScroll2_000.Location = New System.Drawing.Point(24, 96)
		Me.HScroll2_000.LargeChange = 5
		Me.HScroll2_000.Max = 255
		Me.HScroll2_000.TabIndex = 42
		Me.HScroll2_000.TabStop = True
		'
		' HScroll2_001
		'
		Me.HScroll2_001.Name = "HScroll2_001"
		Me.HScroll2_001.Size = New System.Drawing.Size(145, 17)
		Me.HScroll2_001.Location = New System.Drawing.Point(24, 120)
		Me.HScroll2_001.LargeChange = 5
		Me.HScroll2_001.Max = 255
		Me.HScroll2_001.TabIndex = 41
		Me.HScroll2_001.TabStop = True
		'
		' HScroll2_002
		'
		Me.HScroll2_002.Name = "HScroll2_002"
		Me.HScroll2_002.Size = New System.Drawing.Size(145, 17)
		Me.HScroll2_002.Location = New System.Drawing.Point(24, 144)
		Me.HScroll2_002.LargeChange = 5
		Me.HScroll2_002.Max = 255
		Me.HScroll2_002.TabIndex = 40
		Me.HScroll2_002.TabStop = True
		'
		' Text2
		'
		Me.Text2.Name = "Text2"
		Me.Text2.Size = New System.Drawing.Size(145, 25)
		Me.Text2.Location = New System.Drawing.Point(24, 64)
		Me.Text2.ReadOnly = True
		Me.Text2.TabIndex = 38
		'
		' Command8
		'
		Me.Command8.Name = "Command8"
		Me.Command8.Size = New System.Drawing.Size(25, 25)
		Me.Command8.Location = New System.Drawing.Point(112, 64)
		Me.Command8.Caption = "OK"
		Me.Command8.TabIndex = 39
		Me.Command8.Visible = False
		Me.Command8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label14
		'
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(66, 16)
		Me.Label14.Location = New System.Drawing.Point(16, 16)
		Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label14.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label14.Caption = "Textcolor"
		Me.Label14.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label14.TabIndex = 46
		'
		' Label3_000
		'
		Me.Label3_000.Name = "Label3_000"
		Me.Label3_000.Size = New System.Drawing.Size(33, 17)
		Me.Label3_000.Location = New System.Drawing.Point(176, 96)
		Me.Label3_000.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3_000.BackColor = FromOleColor6(CInt(&H008080FF))
		Me.Label3_000.Caption = " "
		Me.Label3_000.TabIndex = 45
		Me.Label3_000.AutoSize = False
		'
		' Label3_001
		'
		Me.Label3_001.Name = "Label3_001"
		Me.Label3_001.Size = New System.Drawing.Size(33, 17)
		Me.Label3_001.Location = New System.Drawing.Point(176, 120)
		Me.Label3_001.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3_001.BackColor = FromOleColor6(CInt(&H0080FF80))
		Me.Label3_001.Caption = " "
		Me.Label3_001.TabIndex = 44
		Me.Label3_001.AutoSize = False
		'
		' Label3_002
		'
		Me.Label3_002.Name = "Label3_002"
		Me.Label3_002.Size = New System.Drawing.Size(33, 17)
		Me.Label3_002.Location = New System.Drawing.Point(176, 144)
		Me.Label3_002.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label3_002.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Label3_002.Caption = " "
		Me.Label3_002.TabIndex = 43
		Me.Label3_002.AutoSize = False
		'
		' Picture5
		'
		Me.Picture5.Name = "Picture5"
		Me.Picture5.Size = New System.Drawing.Size(239, 186)
		Me.Picture5.Location = New System.Drawing.Point(832, 480)
		Me.Picture5.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Picture5.Picture = CType(resources.GetObject("Picture5.Picture"), System.Drawing.Image)
		Me.Picture5.TabIndex = 27
		Me.Picture5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture5.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' HScroll1_001
		'
		Me.HScroll1_001.Name = "HScroll1_001"
		Me.HScroll1_001.Size = New System.Drawing.Size(145, 17)
		Me.HScroll1_001.Location = New System.Drawing.Point(24, 120)
		Me.HScroll1_001.LargeChange = 5
		Me.HScroll1_001.Max = 255
		Me.HScroll1_001.TabIndex = 31
		Me.HScroll1_001.TabStop = True
		'
		' HScroll1_002
		'
		Me.HScroll1_002.Name = "HScroll1_002"
		Me.HScroll1_002.Size = New System.Drawing.Size(145, 17)
		Me.HScroll1_002.Location = New System.Drawing.Point(24, 144)
		Me.HScroll1_002.LargeChange = 5
		Me.HScroll1_002.Max = 255
		Me.HScroll1_002.TabIndex = 30
		Me.HScroll1_002.TabStop = True
		'
		' HScroll1_000
		'
		Me.HScroll1_000.Name = "HScroll1_000"
		Me.HScroll1_000.Size = New System.Drawing.Size(145, 17)
		Me.HScroll1_000.Location = New System.Drawing.Point(24, 96)
		Me.HScroll1_000.LargeChange = 5
		Me.HScroll1_000.Max = 255
		Me.HScroll1_000.TabIndex = 29
		Me.HScroll1_000.TabStop = True
		'
		' Text3
		'
		Me.Text3.Name = "Text3"
		Me.Text3.Size = New System.Drawing.Size(145, 25)
		Me.Text3.Location = New System.Drawing.Point(24, 64)
		Me.Text3.ReadOnly = True
		Me.Text3.TabIndex = 28
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(25, 25)
		Me.Command7.Location = New System.Drawing.Point(80, 64)
		Me.Command7.Caption = "OK"
		Me.Command7.TabIndex = 36
		Me.Command7.Visible = False
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(125, 16)
		Me.Label9.Location = New System.Drawing.Point(24, 16)
		Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label9.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label9.Caption = "Background Color"
		Me.Label9.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label9.TabIndex = 35
		'
		' Label2_001
		'
		Me.Label2_001.Name = "Label2_001"
		Me.Label2_001.Size = New System.Drawing.Size(33, 17)
		Me.Label2_001.Location = New System.Drawing.Point(176, 120)
		Me.Label2_001.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_001.BackColor = FromOleColor6(CInt(&H0080FF80))
		Me.Label2_001.Caption = " "
		Me.Label2_001.TabIndex = 34
		Me.Label2_001.AutoSize = False
		'
		' Label2_002
		'
		Me.Label2_002.Name = "Label2_002"
		Me.Label2_002.Size = New System.Drawing.Size(33, 17)
		Me.Label2_002.Location = New System.Drawing.Point(176, 144)
		Me.Label2_002.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_002.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Label2_002.Caption = " "
		Me.Label2_002.TabIndex = 33
		Me.Label2_002.AutoSize = False
		'
		' Label2_000
		'
		Me.Label2_000.Name = "Label2_000"
		Me.Label2_000.Size = New System.Drawing.Size(33, 17)
		Me.Label2_000.Location = New System.Drawing.Point(176, 96)
		Me.Label2_000.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_000.BackColor = FromOleColor6(CInt(&H008080FF))
		Me.Label2_000.Caption = " "
		Me.Label2_000.TabIndex = 32
		Me.Label2_000.AutoSize = False
		'
		' Picture4
		'
		Me.Picture4.Name = "Picture4"
		Me.Picture4.Size = New System.Drawing.Size(569, 81)
		Me.Picture4.Location = New System.Drawing.Point(8, 584)
		Me.Picture4.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Picture4.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.Picture4.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Picture4.Picture = CType(resources.GetObject("Picture4.Picture"), System.Drawing.Image)
		Me.Picture4.TabIndex = 25
		Me.Picture4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Command14
		'
		Me.Command14.Name = "Command14"
		Me.Command14.Size = New System.Drawing.Size(49, 33)
		Me.Command14.Location = New System.Drawing.Point(16, 24)
		Me.Command14.Caption = "Command14"
		Me.Command14.TabIndex = 26
		Me.Command14.Visible = False
		Me.Command14.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame8
		'
		Me.Frame8.Name = "Frame8"
		Me.Frame8.Size = New System.Drawing.Size(553, 441)
		Me.Frame8.Location = New System.Drawing.Point(16, 40)
		Me.Frame8.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Frame8.Caption = "                                  "
		Me.Frame8.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Frame8.TabIndex = 17
		'
		' Frame12
		'
		Me.Frame12.Name = "Frame12"
		Me.Frame12.Size = New System.Drawing.Size(113, 49)
		Me.Frame12.Location = New System.Drawing.Point(0, 0)
		Me.Frame12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame12.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Frame12.Caption = "Coordinates"
		Me.Frame12.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Frame12.TabIndex = 20
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(25, 17)
		Me.Label13.Location = New System.Drawing.Point(88, 24)
		Me.Label13.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label13.Caption = "999"
		Me.Label13.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label13.TabIndex = 24
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(17, 17)
		Me.Label12.Location = New System.Drawing.Point(72, 24)
		Me.Label12.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label12.Caption = "Y="
		Me.Label12.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label12.TabIndex = 23
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(25, 17)
		Me.Label11.Location = New System.Drawing.Point(24, 24)
		Me.Label11.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label11.Caption = "999"
		Me.Label11.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label11.TabIndex = 22
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(17, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 24)
		Me.Label10.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label10.Caption = "X="
		Me.Label10.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label10.TabIndex = 21
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(394, 248)
		Me.Picture2.Location = New System.Drawing.Point(80, 96)
		Me.Picture2.AutoRedraw = True
		Me.Picture2.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Picture2.TabIndex = 18
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Line20
		'
		Me.Line20.Name = "Line20"
		Me.Line20.ParentForm = Me
		Me.Line20.Name6 = "Line20"
		Me.Line20.BorderColor = FromOleColor6(CInt(&H80000000))
		Me.Line20.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line20.X1 = 0
		Me.Line20.X2 = 5880
		Me.Line20.Y1 = 1780
		Me.Line20.Y2 = 1780
		Me.Line20.Container = Picture2
		'
		' Line19
		'
		Me.Line19.Name = "Line19"
		Me.Line19.ParentForm = Me
		Me.Line19.Name6 = "Line19"
		Me.Line19.BorderColor = FromOleColor6(CInt(&H80000000))
		Me.Line19.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line19.X1 = 2860
		Me.Line19.X2 = 2860
		Me.Line19.Y1 = 0
		Me.Line19.Y2 = 3720
		Me.Line19.Container = Picture2
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(394, 248)
		Me.Picture1.Location = New System.Drawing.Point(80, 96)
		Me.Picture1.AutoRedraw = True
		Me.Picture1.TabIndex = 19
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line15
		'
		Me.Line15.Name = "Line15"
		Me.Line15.ParentForm = Me
		Me.Line15.Name6 = "Line15"
		Me.Line15.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line15.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line15.X1 = 0
		Me.Line15.X2 = 10560
		Me.Line15.Y1 = 5880
		Me.Line15.Y2 = 5880
		Me.Line15.Container = Frame8
		'
		' Line14
		'
		Me.Line14.Name = "Line14"
		Me.Line14.ParentForm = Me
		Me.Line14.Name6 = "Line14"
		Me.Line14.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line14.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line14.X1 = 0
		Me.Line14.X2 = 10560
		Me.Line14.Y1 = 720
		Me.Line14.Y2 = 720
		Me.Line14.Container = Frame8
		'
		' Line13
		'
		Me.Line13.Name = "Line13"
		Me.Line13.ParentForm = Me
		Me.Line13.Name6 = "Line13"
		Me.Line13.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line13.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line13.X1 = 0
		Me.Line13.X2 = 10560
		Me.Line13.Y1 = 4200
		Me.Line13.Y2 = 4200
		Me.Line13.Container = Frame8
		'
		' Line11
		'
		Me.Line11.Name = "Line11"
		Me.Line11.ParentForm = Me
		Me.Line11.Name6 = "Line11"
		Me.Line11.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line11.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line11.X1 = 1200
		Me.Line11.X2 = 1200
		Me.Line11.Y1 = 120
		Me.Line11.Y2 = 6610
		Me.Line11.Container = Frame8
		'
		' Line10
		'
		Me.Line10.Name = "Line10"
		Me.Line10.ParentForm = Me
		Me.Line10.Name6 = "Line10"
		Me.Line10.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line10.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line10.X1 = 4080
		Me.Line10.X2 = 4080
		Me.Line10.Y1 = 120
		Me.Line10.Y2 = 6610
		Me.Line10.Container = Frame8
		'
		' Line9
		'
		Me.Line9.Name = "Line9"
		Me.Line9.ParentForm = Me
		Me.Line9.Name6 = "Line9"
		Me.Line9.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line9.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line9.X1 = 7080
		Me.Line9.X2 = 7080
		Me.Line9.Y1 = 120
		Me.Line9.Y2 = 6610
		Me.Line9.Container = Frame8
		'
		' Line8
		'
		Me.Line8.Name = "Line8"
		Me.Line8.ParentForm = Me
		Me.Line8.Name6 = "Line8"
		Me.Line8.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line8.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line8.X1 = 9480
		Me.Line8.X2 = 9480
		Me.Line8.Y1 = 120
		Me.Line8.Y2 = 6610
		Me.Line8.Container = Frame8
		'
		' Line7
		'
		Me.Line7.Name = "Line7"
		Me.Line7.ParentForm = Me
		Me.Line7.Name6 = "Line7"
		Me.Line7.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line7.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line7.X1 = 0
		Me.Line7.X2 = 10560
		Me.Line7.Y1 = 5130
		Me.Line7.Y2 = 5130
		Me.Line7.Container = Frame8
		'
		' Line6
		'
		Me.Line6.Name = "Line6"
		Me.Line6.ParentForm = Me
		Me.Line6.Name6 = "Line6"
		Me.Line6.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line6.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line6.X1 = 0
		Me.Line6.X2 = 10560
		Me.Line6.Y1 = 1440
		Me.Line6.Y2 = 1440
		Me.Line6.Container = Frame8
		'
		' Line5
		'
		Me.Line5.Name = "Line5"
		Me.Line5.ParentForm = Me
		Me.Line5.Name6 = "Line5"
		Me.Line5.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line5.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line5.X1 = 8280
		Me.Line5.X2 = 8280
		Me.Line5.Y1 = 120
		Me.Line5.Y2 = 6610
		Me.Line5.Container = Frame8
		'
		' Line4
		'
		Me.Line4.Name = "Line4"
		Me.Line4.ParentForm = Me
		Me.Line4.Name6 = "Line4"
		Me.Line4.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line4.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line4.X1 = 2640
		Me.Line4.X2 = 2640
		Me.Line4.Y1 = 120
		Me.Line4.Y2 = 6610
		Me.Line4.Container = Frame8
		'
		' Line3
		'
		Me.Line3.Name = "Line3"
		Me.Line3.ParentForm = Me
		Me.Line3.Name6 = "Line3"
		Me.Line3.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line3.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line3.X1 = 0
		Me.Line3.X2 = 10560
		Me.Line3.Y1 = 3240
		Me.Line3.Y2 = 3240
		Me.Line3.Container = Frame8
		'
		' Line2
		'
		Me.Line2.Name = "Line2"
		Me.Line2.ParentForm = Me
		Me.Line2.Name6 = "Line2"
		Me.Line2.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line2.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line2.X1 = 5520
		Me.Line2.X2 = 5520
		Me.Line2.Y1 = 120
		Me.Line2.Y2 = 6610
		Me.Line2.Container = Frame8
		'
		' Image2
		'
		Me.Image2.Name = "Image2"
		Me.Image2.Size = New System.Drawing.Size(394, 248)
		Me.Image2.Location = New System.Drawing.Point(160, 392)
		Me.Image2.Visible = False
		Me.Image2.Stretch = False
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(394, 248)
		Me.Image1.Location = New System.Drawing.Point(160, 96)
		Me.Image1.Stretch = True
		'
		' Line12
		'
		Me.Line12.Name = "Line12"
		Me.Line12.ParentForm = Me
		Me.Line12.Name6 = "Line12"
		Me.Line12.BorderColor = FromOleColor6(CInt(&H00808080))
		Me.Line12.BorderStyle = CodeArchitects.VB6Library.VBRUN.BorderStyleConstants.vbBSDot
		Me.Line12.X1 = 0
		Me.Line12.X2 = 10560
		Me.Line12.Y1 = 2280
		Me.Line12.Y2 = 2280
		Me.Line12.Container = Frame8
		'
		' Frame6
		'
		Me.Frame6.Name = "Frame6"
		Me.Frame6.Size = New System.Drawing.Size(241, 225)
		Me.Frame6.Location = New System.Drawing.Point(240, 96)
		Me.Frame6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.Caption = "Textcolor"
		Me.Frame6.TabIndex = 8
		Me.Frame6.Visible = False
		Me.Frame6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_007
		'
		Me.Picture3_007.Name = "Picture3_007"
		Me.Picture3_007.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_007.Location = New System.Drawing.Point(128, 176)
		Me.Picture3_007.TabIndex = 16
		Me.Picture3_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_007.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_007.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_007.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_006
		'
		Me.Picture3_006.Name = "Picture3_006"
		Me.Picture3_006.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_006.Location = New System.Drawing.Point(128, 128)
		Me.Picture3_006.TabIndex = 15
		Me.Picture3_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_006.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_006.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_005
		'
		Me.Picture3_005.Name = "Picture3_005"
		Me.Picture3_005.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_005.Location = New System.Drawing.Point(128, 80)
		Me.Picture3_005.TabIndex = 14
		Me.Picture3_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_005.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_005.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_004
		'
		Me.Picture3_004.Name = "Picture3_004"
		Me.Picture3_004.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_004.Location = New System.Drawing.Point(128, 32)
		Me.Picture3_004.TabIndex = 13
		Me.Picture3_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_004.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_004.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_003
		'
		Me.Picture3_003.Name = "Picture3_003"
		Me.Picture3_003.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_003.Location = New System.Drawing.Point(16, 176)
		Me.Picture3_003.TabIndex = 12
		Me.Picture3_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_003.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_003.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_002
		'
		Me.Picture3_002.Name = "Picture3_002"
		Me.Picture3_002.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_002.Location = New System.Drawing.Point(16, 128)
		Me.Picture3_002.TabIndex = 11
		Me.Picture3_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_002.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_002.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_001
		'
		Me.Picture3_001.Name = "Picture3_001"
		Me.Picture3_001.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_001.Location = New System.Drawing.Point(24, 80)
		Me.Picture3_001.TabIndex = 10
		Me.Picture3_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_001.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_001.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture3_000
		'
		Me.Picture3_000.Name = "Picture3_000"
		Me.Picture3_000.Size = New System.Drawing.Size(97, 41)
		Me.Picture3_000.Location = New System.Drawing.Point(24, 24)
		Me.Picture3_000.TabIndex = 9
		Me.Picture3_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture3_000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3_000.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture3_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(41, 33)
		Me.Command2.Location = New System.Drawing.Point(480, 320)
		Me.Command2.Caption = "save"
		Me.Command2.TabIndex = 1
		Me.Command2.Visible = False
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Cdl1
		'
		Me.Cdl1.Name = "Cdl1"
		Me.Cdl1.ParentForm = Me
		Me.Cdl1.Name6 = "Cdl1"
		Me.Cdl1.CancelError = True
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 0
		'
		' Frame5
		'
		Me.Frame5.Name = "Frame5"
		Me.Frame5.Size = New System.Drawing.Size(153, 89)
		Me.Frame5.Location = New System.Drawing.Point(352, 344)
		Me.Frame5.Caption = "Font Effects"
		Me.Frame5.TabIndex = 2
		Me.Frame5.Visible = False
		Me.Frame5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9_000
		'
		Me.Command9_000.Name = "Command9_000"
		Me.Command9_000.Size = New System.Drawing.Size(33, 25)
		Me.Command9_000.Location = New System.Drawing.Point(8, 32)
		Me.Command9_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9_000.Caption = "B"
		Me.Command9_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9_000.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.Command9_000, "Bold")
		Me.Command9_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9_001
		'
		Me.Command9_001.Name = "Command9_001"
		Me.Command9_001.Size = New System.Drawing.Size(33, 25)
		Me.Command9_001.Location = New System.Drawing.Point(40, 32)
		Me.Command9_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9_001.Caption = "B"
		Me.Command9_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9_001.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.Command9_001, "Italic")
		Me.Command9_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9_002
		'
		Me.Command9_002.Name = "Command9_002"
		Me.Command9_002.Size = New System.Drawing.Size(33, 25)
		Me.Command9_002.Location = New System.Drawing.Point(72, 32)
		Me.Command9_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9_002.Caption = "B"
		Me.Command9_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9_002.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.Command9_002, "Underline")
		Me.Command9_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9_003
		'
		Me.Command9_003.Name = "Command9_003"
		Me.Command9_003.Size = New System.Drawing.Size(33, 25)
		Me.Command9_003.Location = New System.Drawing.Point(104, 32)
		Me.Command9_003.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command9_003.Caption = "B"
		Me.Command9_003.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9_003.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.Command9_003, "Strikethru")
		Me.Command9_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9_004
		'
		Me.Command9_004.Name = "Command9_004"
		Me.Command9_004.Size = New System.Drawing.Size(65, 25)
		Me.Command9_004.Location = New System.Drawing.Point(40, 56)
		Me.Command9_004.Caption = "None"
		Me.Command9_004.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.Command9_004.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.Command9_004, "Draw a straight line")
		Me.Command9_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(25, 33)
		Me.Command3.Location = New System.Drawing.Point(392, 432)
		Me.Command3.Caption = "Add Background"
		Me.Command3.TabIndex = 0
		Me.Command3.Visible = False
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image3
		'
		Me.Image3.Name = "Image3"
		Me.Image3.Size = New System.Drawing.Size(568, 456)
		Me.Image3.Location = New System.Drawing.Point(8, 32)
		Me.Image3.Stretch = True
		Me.Image3.Picture = CType(resources.GetObject("Image3.Picture"), System.Drawing.Image)
		'
		' Line1
		'
		Me.Line1.Name = "Line1"
		Me.Line1.ParentForm = Me
		Me.Line1.Name6 = "Line1"
		Me.Line1.X1 = 0
		Me.Line1.X2 = 18000
		Me.Line1.Y1 = 0
		Me.Line1.Y2 = 0
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnufile
		'
		Me.mnufile.Name = "mnufile"
		Me.mnufile.Caption = "File"
		'
		' mnunieuw
		'
		Me.mnunieuw.Name = "mnunieuw"
		Me.mnunieuw.Caption = "New"
		'
		' mnuopen
		'
		Me.mnuopen.Name = "mnuopen"
		Me.mnuopen.Caption = "Open"
		'
		' mnusave
		'
		Me.mnusave.Name = "mnusave"
		Me.mnusave.Caption = "Save"
		'
		' mnuprint
		'
		Me.mnuprint.Name = "mnuprint"
		Me.mnuprint.Caption = "Print"
		'
		' streep
		'
		Me.streep.Name = "streep"
		'
		' mnuexit
		'
		Me.mnuexit.Name = "mnuexit"
		Me.mnuexit.Caption = "Exit"
		'
		' mnuedit
		'
		Me.mnuedit.Name = "mnuedit"
		Me.mnuedit.Caption = "Edit"
		Me.mnuedit.Visible = False
		'
		' mnuresize
		'
		Me.mnuresize.Name = "mnuresize"
		Me.mnuresize.Caption = "Resize"
		Me.mnuresize.Visible = False
		'
		' mnubackground
		'
		Me.mnubackground.Name = "mnubackground"
		Me.mnubackground.Caption = "Load Background"
		'
		' mnuclback
		'
		Me.mnuclback.Name = "mnuclback"
		Me.mnuclback.Caption = "Clear Background"
		'
		' mnuhelp
		'
		Me.mnuhelp.Name = "mnuhelp"
		Me.mnuhelp.Caption = "Help"
		Me.mnuhelp.Visible = False
		'
		' mnuabout
		'
		Me.mnuabout.Name = "mnuabout"
		Me.mnuabout.Caption = "About"
		'
		' frmshowfnt
		'
		Me.Name = "frmshowfnt"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00C000C0))
		Me.Caption = "GerP Soft"
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(66, 42)
		Me.ClientSize = New System.Drawing.Size(1078, 669)

		Me.Controls.Add(Picture11)
		Me.Picture11.Controls.Add(Command5)
		Me.Picture11.Controls.Add(Command6)
		Me.Picture11.Controls.Add(Text1)
		Me.Picture11.Controls.Add(Label8)
		Me.Controls.Add(Picture10)
		Me.Picture10.Controls.Add(HScroll5_001)
		Me.Picture10.Controls.Add(HScroll5_002)
		Me.Picture10.Controls.Add(Text4)
		Me.Picture10.Controls.Add(HScroll5_000)
		Me.Picture10.Controls.Add(Label18)
		Me.Picture10.Controls.Add(Label7_001)
		Me.Picture10.Controls.Add(Label7_002)
		Me.Picture10.Controls.Add(Label7_000)
		Me.Controls.Add(Picture9)
		Me.Picture9.Controls.Add(Check1)
		Me.Picture9.Controls.Add(HScroll4)
		Me.Picture9.Controls.Add(Command4_000)
		Me.Picture9.Controls.Add(Command4_006)
		Me.Picture9.Controls.Add(Command4_005)
		Me.Picture9.Controls.Add(Command4_002)
		Me.Picture9.Controls.Add(Command4_001)
		Me.Picture9.Controls.Add(Label17)
		Me.Picture9.Controls.Add(Label4)
		Me.Picture9.Controls.Add(Label5)
		Me.Controls.Add(Picture8)
		Me.Picture8.Controls.Add(list1)
		Me.Picture8.Controls.Add(HScroll3)
		Me.Picture8.Controls.Add(Option1)
		Me.Picture8.Controls.Add(Option2)
		Me.Picture8.Controls.Add(Label1)
		Me.Picture8.Controls.Add(Label19)
		Me.Picture8.Controls.Add(Label6)
		Me.Picture8.Controls.Add(Label16)
		Me.Controls.Add(Picture7)
		Me.Picture7.Controls.Add(Command12)
		Me.Picture7.Controls.Add(Command10)
		Me.Picture7.Controls.Add(Command11)
		Me.Picture7.Controls.Add(Command13)
		Me.Picture7.Controls.Add(Label15)
		Me.Controls.Add(Picture6)
		Me.Picture6.Controls.Add(HScroll2_000)
		Me.Picture6.Controls.Add(HScroll2_001)
		Me.Picture6.Controls.Add(HScroll2_002)
		Me.Picture6.Controls.Add(Text2)
		Me.Picture6.Controls.Add(Command8)
		Me.Picture6.Controls.Add(Label14)
		Me.Picture6.Controls.Add(Label3_000)
		Me.Picture6.Controls.Add(Label3_001)
		Me.Picture6.Controls.Add(Label3_002)
		Me.Controls.Add(Picture5)
		Me.Picture5.Controls.Add(HScroll1_001)
		Me.Picture5.Controls.Add(HScroll1_002)
		Me.Picture5.Controls.Add(HScroll1_000)
		Me.Picture5.Controls.Add(Text3)
		Me.Picture5.Controls.Add(Command7)
		Me.Picture5.Controls.Add(Label9)
		Me.Picture5.Controls.Add(Label2_001)
		Me.Picture5.Controls.Add(Label2_002)
		Me.Picture5.Controls.Add(Label2_000)
		Me.Controls.Add(Picture4)
		Me.Picture4.Controls.Add(Command14)
		Me.Controls.Add(Frame8)
		Me.Frame8.Controls.Add(Frame12)
		Me.Frame12.Controls.Add(Label13)
		Me.Frame12.Controls.Add(Label12)
		Me.Frame12.Controls.Add(Label11)
		Me.Frame12.Controls.Add(Label10)
		Me.Frame8.Controls.Add(Picture2)
		Me.Frame8.Controls.Add(Picture1)
		Me.Frame8.Controls.Add(Image2)
		Me.Frame8.Controls.Add(Image1)
		Me.Controls.Add(Frame6)
		Me.Frame6.Controls.Add(Picture3_007)
		Me.Frame6.Controls.Add(Picture3_006)
		Me.Frame6.Controls.Add(Picture3_005)
		Me.Frame6.Controls.Add(Picture3_004)
		Me.Frame6.Controls.Add(Picture3_003)
		Me.Frame6.Controls.Add(Picture3_002)
		Me.Frame6.Controls.Add(Picture3_001)
		Me.Frame6.Controls.Add(Picture3_000)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Frame5)
		Me.Frame5.Controls.Add(Command9_000)
		Me.Frame5.Controls.Add(Command9_001)
		Me.Frame5.Controls.Add(Command9_002)
		Me.Frame5.Controls.Add(Command9_003)
		Me.Frame5.Controls.Add(Command9_004)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Image3)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnufile)
		Me.mnufile.DropDownItems.Add(mnunieuw)
		Me.mnufile.DropDownItems.Add(mnuopen)
		Me.mnufile.DropDownItems.Add(mnusave)
		Me.mnufile.DropDownItems.Add(mnuprint)
		Me.mnufile.DropDownItems.Add(streep)
		Me.mnufile.DropDownItems.Add(mnuexit)
		Me.MenuStrip1.Items.Add(mnuedit)
		Me.mnuedit.DropDownItems.Add(mnuresize)
		Me.mnuedit.DropDownItems.Add(mnubackground)
		Me.mnuedit.DropDownItems.Add(mnuclback)
		Me.MenuStrip1.Items.Add(mnuhelp)
		Me.mnuhelp.DropDownItems.Add(mnuabout)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.Line17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture11.ResumeLayout(False)
		Me.Picture10.ResumeLayout(False)
		Me.Picture9.ResumeLayout(False)
		Me.Picture8.ResumeLayout(False)
		Me.Picture7.ResumeLayout(False)
		Me.Picture6.ResumeLayout(False)
		Me.Picture5.ResumeLayout(False)
		Me.Picture4.ResumeLayout(False)
		Me.Frame8.ResumeLayout(False)
		Me.Frame12.ResumeLayout(False)
		Me.Picture2.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
