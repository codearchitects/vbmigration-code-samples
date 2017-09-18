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
	Public WithEvents Nuovo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Esci As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Soluzione As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command12 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command11 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command10 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command9 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command8 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command7 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command6 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command5 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command4 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command3 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command2 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Soluz As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblNew As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Line4 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line3 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line2 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents Line1 As CodeArchitects.VB6Library.VB6Line
	Public WithEvents LabTent12_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent12_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent12_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent12_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent12_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent11_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent11_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent11_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent11_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent11_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Tent12_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent12_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent12_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent12_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent12_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent11_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent11_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent11_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent11_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent11_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent12_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent12_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent12_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent12_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent12_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent11_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent11_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent11_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent11_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent11_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents msg As CodeArchitects.VB6Library.VB6Label
	Public WithEvents ColScelto As CodeArchitects.VB6Library.VB6Label
	Public WithEvents R5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents R4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents R3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents R2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents R1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Bianco As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Nero As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Verde As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Rosso As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Giallo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Blu As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent10_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent10_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent10_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent10_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent10_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent9_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent9_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent9_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent9_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent9_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent8_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent8_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent8_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent8_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent8_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent7_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent7_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent7_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent7_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent7_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent6_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent6_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent6_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent6_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent6_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent5_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent5_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent5_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent5_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent5_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent4_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent4_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent4_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent4_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent4_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent3_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent3_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent3_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent3_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent3_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent2_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent2_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent2_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent2_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent2_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent1_5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent1_4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent1_3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents LabTent1_2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents RispTent1_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent1_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent1_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent1_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent1_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent2_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent2_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent2_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent2_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent2_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent3_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent3_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent3_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent3_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent3_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent4_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent4_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent4_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent4_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent4_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent5_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent5_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent5_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent5_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent5_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent6_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent6_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent6_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent6_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent6_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent7_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent7_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent7_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent7_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent7_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent8_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent8_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent8_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent8_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent8_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent9_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent9_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent9_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent9_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent9_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent10_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent10_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent10_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent10_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents RispTent10_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Col6 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents LabTent1_1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Tent1_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent1_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent1_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent1_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent1_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent2_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent2_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent2_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent2_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent2_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent3_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent3_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent3_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent3_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent3_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent4_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent4_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent4_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent4_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent4_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent5_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent5_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent5_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent5_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent5_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent6_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent6_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent6_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent6_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent6_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent7_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent7_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent7_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent7_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent7_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent8_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent8_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent8_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent8_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent8_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent9_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent9_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent9_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent9_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent9_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent10_2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent10_3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent10_4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent10_5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents Tent10_1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents C5 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents C4 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents C3 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents C2 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents C1 As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuVediSoluz As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSpazio As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEsci As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuAiuto As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSpazio2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuAbout As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.Nuovo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Esci = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Soluzione = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command12 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command11 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command10 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command9 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command8 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command7 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command6 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command5 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command4 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command3 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command2 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Soluz = New CodeArchitects.VB6Library.VB6Label()
		Me.lblNew = New CodeArchitects.VB6Library.VB6Label()
		Me.Line4 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line3 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line2 = New CodeArchitects.VB6Library.VB6Line()
		Me.Line1 = New CodeArchitects.VB6Library.VB6Line()
		Me.LabTent12_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent12_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent12_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent12_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent12_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent11_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent11_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent11_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent11_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent11_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Tent12_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent12_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent12_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent12_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent12_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent11_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent11_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent11_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent11_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent11_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent12_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent12_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent12_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent12_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent12_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent11_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent11_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent11_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent11_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent11_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.msg = New CodeArchitects.VB6Library.VB6Label()
		Me.ColScelto = New CodeArchitects.VB6Library.VB6Label()
		Me.R5 = New CodeArchitects.VB6Library.VB6Label()
		Me.R4 = New CodeArchitects.VB6Library.VB6Label()
		Me.R3 = New CodeArchitects.VB6Library.VB6Label()
		Me.R2 = New CodeArchitects.VB6Library.VB6Label()
		Me.R1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Bianco = New CodeArchitects.VB6Library.VB6Label()
		Me.Nero = New CodeArchitects.VB6Library.VB6Label()
		Me.Verde = New CodeArchitects.VB6Library.VB6Label()
		Me.Rosso = New CodeArchitects.VB6Library.VB6Label()
		Me.Giallo = New CodeArchitects.VB6Library.VB6Label()
		Me.Blu = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent10_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent10_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent10_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent10_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent10_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent9_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent9_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent9_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent9_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent9_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent8_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent8_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent8_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent8_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent8_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent7_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent7_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent7_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent7_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent7_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent6_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent6_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent6_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent6_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent6_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent5_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent5_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent5_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent5_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent5_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent4_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent4_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent4_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent4_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent4_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent3_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent3_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent3_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent3_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent3_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent2_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent2_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent2_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent2_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent2_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent1_5 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent1_4 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent1_3 = New CodeArchitects.VB6Library.VB6Label()
		Me.LabTent1_2 = New CodeArchitects.VB6Library.VB6Label()
		Me.RispTent1_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent1_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent1_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent1_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent1_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent2_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent2_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent2_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent2_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent2_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent3_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent3_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent3_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent3_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent3_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent4_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent4_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent4_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent4_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent4_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent5_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent5_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent5_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent5_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent5_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent6_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent6_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent6_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent6_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent6_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent7_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent7_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent7_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent7_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent7_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent8_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent8_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent8_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent8_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent8_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent9_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent9_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent9_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent9_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent9_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent10_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent10_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent10_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent10_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.RispTent10_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Col6 = New CodeArchitects.VB6Library.VB6Shape()
		Me.LabTent1_1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Tent1_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent1_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent1_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent1_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent1_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent2_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent2_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent2_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent2_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent2_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent3_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent3_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent3_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent3_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent3_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent4_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent4_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent4_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent4_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent4_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent5_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent5_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent5_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent5_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent5_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent6_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent6_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent6_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent6_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent6_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent7_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent7_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent7_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent7_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent7_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent8_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent8_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent8_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent8_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent8_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent9_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent9_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent9_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent9_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent9_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent10_2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent10_3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent10_4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent10_5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.Tent10_1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.C5 = New CodeArchitects.VB6Library.VB6Shape()
		Me.C4 = New CodeArchitects.VB6Library.VB6Shape()
		Me.C3 = New CodeArchitects.VB6Library.VB6Shape()
		Me.C2 = New CodeArchitects.VB6Library.VB6Shape()
		Me.C1 = New CodeArchitects.VB6Library.VB6Shape()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuVediSoluz = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSpazio = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEsci = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuAiuto = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSpazio2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent12_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent12_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent12_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent12_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent12_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent11_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent11_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent11_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent11_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent11_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent12_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent12_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent12_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent12_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent12_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent11_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent11_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent11_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent11_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent11_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent1_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent1_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent1_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent1_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent2_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent2_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent2_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent2_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent2_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent3_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent3_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent3_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent3_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent3_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent4_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent4_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent4_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent4_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent4_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent5_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent5_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent5_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent5_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent5_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent6_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent6_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent6_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent6_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent6_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent7_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent7_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent7_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent7_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent7_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent8_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent8_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent8_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent8_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent8_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent9_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent9_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent9_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent9_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent9_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent10_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent10_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent10_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent10_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RispTent10_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Col6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent1_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent1_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent1_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent1_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent2_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent2_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent2_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent2_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent2_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent3_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent3_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent3_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent3_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent3_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent4_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent4_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent4_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent4_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent4_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent5_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent5_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent5_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent5_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent5_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent6_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent6_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent6_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent6_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent6_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent7_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent7_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent7_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent7_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent7_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent8_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent8_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent8_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent8_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent8_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent9_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent9_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent9_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent9_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent9_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent10_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent10_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent10_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent10_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Tent10_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Nuovo
		'
		Me.Nuovo.Name = "Nuovo"
		Me.Nuovo.Size = New System.Drawing.Size(89, 25)
		Me.Nuovo.Location = New System.Drawing.Point(48, 104)
		Me.Nuovo.Caption = "Nuova Partita"
		Me.Nuovo.TabIndex = 87
		Me.Nuovo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Esci
		'
		Me.Esci.Name = "Esci"
		Me.Esci.Size = New System.Drawing.Size(81, 41)
		Me.Esci.Location = New System.Drawing.Point(584, 32)
		Me.Esci.Caption = "EXIT"
		Me.Esci.TabIndex = 86
		Me.Esci.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Soluzione
		'
		Me.Soluzione.Name = "Soluzione"
		Me.Soluzione.Size = New System.Drawing.Size(89, 25)
		Me.Soluzione.Location = New System.Drawing.Point(48, 64)
		Me.Soluzione.Caption = "Vedi soluzione"
		Me.Soluzione.TabIndex = 85
		Me.Soluzione.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command12
		'
		Me.Command12.Name = "Command12"
		Me.Command12.Size = New System.Drawing.Size(57, 41)
		Me.Command12.Location = New System.Drawing.Point(200, 112)
		Me.Command12.Caption = "VAI"
		Me.Command12.TabIndex = 74
		Me.Command12.Visible = False
		Me.Command12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command11
		'
		Me.Command11.Name = "Command11"
		Me.Command11.Size = New System.Drawing.Size(57, 41)
		Me.Command11.Location = New System.Drawing.Point(200, 160)
		Me.Command11.Caption = "VAI"
		Me.Command11.TabIndex = 73
		Me.Command11.Visible = False
		Me.Command11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command10
		'
		Me.Command10.Name = "Command10"
		Me.Command10.Size = New System.Drawing.Size(57, 41)
		Me.Command10.Location = New System.Drawing.Point(200, 208)
		Me.Command10.Caption = "VAI"
		Me.Command10.TabIndex = 65
		Me.Command10.Visible = False
		Me.Command10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command9
		'
		Me.Command9.Name = "Command9"
		Me.Command9.Size = New System.Drawing.Size(57, 41)
		Me.Command9.Location = New System.Drawing.Point(200, 256)
		Me.Command9.Caption = "VAI"
		Me.Command9.TabIndex = 64
		Me.Command9.Visible = False
		Me.Command9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command8
		'
		Me.Command8.Name = "Command8"
		Me.Command8.Size = New System.Drawing.Size(57, 41)
		Me.Command8.Location = New System.Drawing.Point(200, 304)
		Me.Command8.Caption = "VAI"
		Me.Command8.TabIndex = 63
		Me.Command8.Visible = False
		Me.Command8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command7
		'
		Me.Command7.Name = "Command7"
		Me.Command7.Size = New System.Drawing.Size(57, 41)
		Me.Command7.Location = New System.Drawing.Point(200, 352)
		Me.Command7.Caption = "VAI"
		Me.Command7.TabIndex = 62
		Me.Command7.Visible = False
		Me.Command7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command6
		'
		Me.Command6.Name = "Command6"
		Me.Command6.Size = New System.Drawing.Size(57, 41)
		Me.Command6.Location = New System.Drawing.Point(200, 400)
		Me.Command6.Caption = "VAI"
		Me.Command6.TabIndex = 61
		Me.Command6.Visible = False
		Me.Command6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command5
		'
		Me.Command5.Name = "Command5"
		Me.Command5.Size = New System.Drawing.Size(57, 41)
		Me.Command5.Location = New System.Drawing.Point(200, 448)
		Me.Command5.Caption = "VAI"
		Me.Command5.TabIndex = 60
		Me.Command5.Visible = False
		Me.Command5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command4
		'
		Me.Command4.Name = "Command4"
		Me.Command4.Size = New System.Drawing.Size(57, 41)
		Me.Command4.Location = New System.Drawing.Point(200, 496)
		Me.Command4.Caption = "VAI"
		Me.Command4.TabIndex = 59
		Me.Command4.Visible = False
		Me.Command4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command3
		'
		Me.Command3.Name = "Command3"
		Me.Command3.Size = New System.Drawing.Size(57, 41)
		Me.Command3.Location = New System.Drawing.Point(200, 544)
		Me.Command3.Caption = "VAI"
		Me.Command3.TabIndex = 58
		Me.Command3.Visible = False
		Me.Command3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command2
		'
		Me.Command2.Name = "Command2"
		Me.Command2.Size = New System.Drawing.Size(57, 41)
		Me.Command2.Location = New System.Drawing.Point(200, 592)
		Me.Command2.Caption = "VAI"
		Me.Command2.TabIndex = 57
		Me.Command2.Visible = False
		Me.Command2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(57, 41)
		Me.Command1.Location = New System.Drawing.Point(200, 640)
		Me.Command1.Caption = "VAI"
		Me.Command1.TabIndex = 56
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Soluz
		'
		Me.Soluz.Name = "Soluz"
		Me.Soluz.Size = New System.Drawing.Size(89, 25)
		Me.Soluz.Location = New System.Drawing.Point(48, 136)
		Me.Soluz.TabIndex = 89
		Me.Soluz.Visible = False
		Me.Soluz.AutoSize = False
		Me.Soluz.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblNew
		'
		Me.lblNew.Name = "lblNew"
		Me.lblNew.Size = New System.Drawing.Size(89, 25)
		Me.lblNew.Location = New System.Drawing.Point(48, 168)
		Me.lblNew.TabIndex = 88
		Me.lblNew.Visible = False
		Me.lblNew.AutoSize = False
		Me.lblNew.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Line4
		'
		Me.Line4.Name = "Line4"
		Me.Line4.ParentForm = Me
		Me.Line4.Name6 = "Line4"
		Me.Line4.BorderColor = FromOleColor6(CInt(&H80000005))
		Me.Line4.BorderWidth = 5
		Me.Line4.X1 = 360
		Me.Line4.X2 = 2520
		Me.Line4.Y1 = 6840
		Me.Line4.Y2 = 6840
		'
		' Line3
		'
		Me.Line3.Name = "Line3"
		Me.Line3.ParentForm = Me
		Me.Line3.Name6 = "Line3"
		Me.Line3.BorderColor = FromOleColor6(CInt(&H80000005))
		Me.Line3.BorderWidth = 5
		Me.Line3.X1 = 2520
		Me.Line3.X2 = 2520
		Me.Line3.Y1 = 4560
		Me.Line3.Y2 = 6840
		'
		' Line2
		'
		Me.Line2.Name = "Line2"
		Me.Line2.ParentForm = Me
		Me.Line2.Name6 = "Line2"
		Me.Line2.BorderColor = FromOleColor6(CInt(&H80000005))
		Me.Line2.BorderWidth = 5
		Me.Line2.X1 = 360
		Me.Line2.X2 = 360
		Me.Line2.Y1 = 4560
		Me.Line2.Y2 = 6840
		'
		' Line1
		'
		Me.Line1.Name = "Line1"
		Me.Line1.ParentForm = Me
		Me.Line1.Name6 = "Line1"
		Me.Line1.BorderColor = FromOleColor6(CInt(&H80000005))
		Me.Line1.BorderWidth = 5
		Me.Line1.X1 = 360
		Me.Line1.X2 = 2520
		Me.Line1.Y1 = 4560
		Me.Line1.Y2 = 4560
		'
		' LabTent12_1
		'
		Me.LabTent12_1.Name = "LabTent12_1"
		Me.LabTent12_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent12_1.Location = New System.Drawing.Point(272, 112)
		Me.LabTent12_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent12_1.Enabled = False
		Me.LabTent12_1.TabIndex = 84
		Me.LabTent12_1.AutoSize = False
		Me.LabTent12_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent12_2
		'
		Me.LabTent12_2.Name = "LabTent12_2"
		Me.LabTent12_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent12_2.Location = New System.Drawing.Point(320, 112)
		Me.LabTent12_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent12_2.Enabled = False
		Me.LabTent12_2.TabIndex = 83
		Me.LabTent12_2.AutoSize = False
		Me.LabTent12_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent12_3
		'
		Me.LabTent12_3.Name = "LabTent12_3"
		Me.LabTent12_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent12_3.Location = New System.Drawing.Point(368, 112)
		Me.LabTent12_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent12_3.Enabled = False
		Me.LabTent12_3.TabIndex = 82
		Me.LabTent12_3.AutoSize = False
		Me.LabTent12_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent12_4
		'
		Me.LabTent12_4.Name = "LabTent12_4"
		Me.LabTent12_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent12_4.Location = New System.Drawing.Point(416, 112)
		Me.LabTent12_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent12_4.Enabled = False
		Me.LabTent12_4.TabIndex = 81
		Me.LabTent12_4.AutoSize = False
		Me.LabTent12_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent12_5
		'
		Me.LabTent12_5.Name = "LabTent12_5"
		Me.LabTent12_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent12_5.Location = New System.Drawing.Point(464, 112)
		Me.LabTent12_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent12_5.Enabled = False
		Me.LabTent12_5.TabIndex = 80
		Me.LabTent12_5.AutoSize = False
		Me.LabTent12_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent11_1
		'
		Me.LabTent11_1.Name = "LabTent11_1"
		Me.LabTent11_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent11_1.Location = New System.Drawing.Point(272, 160)
		Me.LabTent11_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent11_1.Enabled = False
		Me.LabTent11_1.TabIndex = 79
		Me.LabTent11_1.AutoSize = False
		Me.LabTent11_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent11_2
		'
		Me.LabTent11_2.Name = "LabTent11_2"
		Me.LabTent11_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent11_2.Location = New System.Drawing.Point(320, 160)
		Me.LabTent11_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent11_2.Enabled = False
		Me.LabTent11_2.TabIndex = 78
		Me.LabTent11_2.AutoSize = False
		Me.LabTent11_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent11_3
		'
		Me.LabTent11_3.Name = "LabTent11_3"
		Me.LabTent11_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent11_3.Location = New System.Drawing.Point(368, 160)
		Me.LabTent11_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent11_3.Enabled = False
		Me.LabTent11_3.TabIndex = 77
		Me.LabTent11_3.AutoSize = False
		Me.LabTent11_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent11_4
		'
		Me.LabTent11_4.Name = "LabTent11_4"
		Me.LabTent11_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent11_4.Location = New System.Drawing.Point(416, 160)
		Me.LabTent11_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent11_4.Enabled = False
		Me.LabTent11_4.TabIndex = 76
		Me.LabTent11_4.AutoSize = False
		Me.LabTent11_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent11_5
		'
		Me.LabTent11_5.Name = "LabTent11_5"
		Me.LabTent11_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent11_5.Location = New System.Drawing.Point(464, 160)
		Me.LabTent11_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent11_5.Enabled = False
		Me.LabTent11_5.TabIndex = 75
		Me.LabTent11_5.AutoSize = False
		Me.LabTent11_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Tent12_1
		'
		Me.Tent12_1.Name = "Tent12_1"
		Me.Tent12_1.ParentForm = Me
		Me.Tent12_1.Name6 = "Tent12_1"
		Me.Tent12_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent12_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent12_1.Height = 600
		Me.Tent12_1.Left = 3840
		Me.Tent12_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent12_1.Top = 1320
		Me.Tent12_1.Width = 1005
		'
		' Tent12_5
		'
		Me.Tent12_5.Name = "Tent12_5"
		Me.Tent12_5.ParentForm = Me
		Me.Tent12_5.Name6 = "Tent12_5"
		Me.Tent12_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent12_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent12_5.Height = 600
		Me.Tent12_5.Left = 6720
		Me.Tent12_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent12_5.Top = 1320
		Me.Tent12_5.Width = 1005
		'
		' Tent12_4
		'
		Me.Tent12_4.Name = "Tent12_4"
		Me.Tent12_4.ParentForm = Me
		Me.Tent12_4.Name6 = "Tent12_4"
		Me.Tent12_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent12_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent12_4.Height = 600
		Me.Tent12_4.Left = 6000
		Me.Tent12_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent12_4.Top = 1320
		Me.Tent12_4.Width = 1005
		'
		' Tent12_3
		'
		Me.Tent12_3.Name = "Tent12_3"
		Me.Tent12_3.ParentForm = Me
		Me.Tent12_3.Name6 = "Tent12_3"
		Me.Tent12_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent12_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent12_3.Height = 600
		Me.Tent12_3.Left = 5280
		Me.Tent12_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent12_3.Top = 1320
		Me.Tent12_3.Width = 1005
		'
		' Tent12_2
		'
		Me.Tent12_2.Name = "Tent12_2"
		Me.Tent12_2.ParentForm = Me
		Me.Tent12_2.Name6 = "Tent12_2"
		Me.Tent12_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent12_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent12_2.Height = 600
		Me.Tent12_2.Left = 4560
		Me.Tent12_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent12_2.Top = 1320
		Me.Tent12_2.Width = 1005
		'
		' Tent11_1
		'
		Me.Tent11_1.Name = "Tent11_1"
		Me.Tent11_1.ParentForm = Me
		Me.Tent11_1.Name6 = "Tent11_1"
		Me.Tent11_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent11_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent11_1.Height = 600
		Me.Tent11_1.Left = 3840
		Me.Tent11_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent11_1.Top = 2040
		Me.Tent11_1.Width = 1005
		'
		' Tent11_5
		'
		Me.Tent11_5.Name = "Tent11_5"
		Me.Tent11_5.ParentForm = Me
		Me.Tent11_5.Name6 = "Tent11_5"
		Me.Tent11_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent11_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent11_5.Height = 600
		Me.Tent11_5.Left = 6720
		Me.Tent11_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent11_5.Top = 2040
		Me.Tent11_5.Width = 1005
		'
		' Tent11_4
		'
		Me.Tent11_4.Name = "Tent11_4"
		Me.Tent11_4.ParentForm = Me
		Me.Tent11_4.Name6 = "Tent11_4"
		Me.Tent11_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent11_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent11_4.Height = 600
		Me.Tent11_4.Left = 6000
		Me.Tent11_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent11_4.Top = 2040
		Me.Tent11_4.Width = 1005
		'
		' Tent11_3
		'
		Me.Tent11_3.Name = "Tent11_3"
		Me.Tent11_3.ParentForm = Me
		Me.Tent11_3.Name6 = "Tent11_3"
		Me.Tent11_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent11_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent11_3.Height = 600
		Me.Tent11_3.Left = 5280
		Me.Tent11_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent11_3.Top = 2040
		Me.Tent11_3.Width = 1005
		'
		' Tent11_2
		'
		Me.Tent11_2.Name = "Tent11_2"
		Me.Tent11_2.ParentForm = Me
		Me.Tent11_2.Name6 = "Tent11_2"
		Me.Tent11_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent11_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent11_2.Height = 600
		Me.Tent11_2.Left = 4560
		Me.Tent11_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent11_2.Top = 2040
		Me.Tent11_2.Width = 1005
		'
		' RispTent12_1
		'
		Me.RispTent12_1.Name = "RispTent12_1"
		Me.RispTent12_1.ParentForm = Me
		Me.RispTent12_1.Name6 = "RispTent12_1"
		Me.RispTent12_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent12_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent12_1.Height = 240
		Me.RispTent12_1.Left = 8040
		Me.RispTent12_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent12_1.Top = 1560
		Me.RispTent12_1.Width = 285
		'
		' RispTent12_5
		'
		Me.RispTent12_5.Name = "RispTent12_5"
		Me.RispTent12_5.ParentForm = Me
		Me.RispTent12_5.Name6 = "RispTent12_5"
		Me.RispTent12_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent12_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent12_5.Height = 240
		Me.RispTent12_5.Left = 9480
		Me.RispTent12_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent12_5.Top = 1560
		Me.RispTent12_5.Width = 285
		'
		' RispTent12_4
		'
		Me.RispTent12_4.Name = "RispTent12_4"
		Me.RispTent12_4.ParentForm = Me
		Me.RispTent12_4.Name6 = "RispTent12_4"
		Me.RispTent12_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent12_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent12_4.Height = 240
		Me.RispTent12_4.Left = 9120
		Me.RispTent12_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent12_4.Top = 1560
		Me.RispTent12_4.Width = 285
		'
		' RispTent12_3
		'
		Me.RispTent12_3.Name = "RispTent12_3"
		Me.RispTent12_3.ParentForm = Me
		Me.RispTent12_3.Name6 = "RispTent12_3"
		Me.RispTent12_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent12_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent12_3.Height = 240
		Me.RispTent12_3.Left = 8760
		Me.RispTent12_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent12_3.Top = 1560
		Me.RispTent12_3.Width = 285
		'
		' RispTent12_2
		'
		Me.RispTent12_2.Name = "RispTent12_2"
		Me.RispTent12_2.ParentForm = Me
		Me.RispTent12_2.Name6 = "RispTent12_2"
		Me.RispTent12_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent12_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent12_2.Height = 240
		Me.RispTent12_2.Left = 8400
		Me.RispTent12_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent12_2.Top = 1560
		Me.RispTent12_2.Width = 285
		'
		' RispTent11_1
		'
		Me.RispTent11_1.Name = "RispTent11_1"
		Me.RispTent11_1.ParentForm = Me
		Me.RispTent11_1.Name6 = "RispTent11_1"
		Me.RispTent11_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent11_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent11_1.Height = 240
		Me.RispTent11_1.Left = 8040
		Me.RispTent11_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent11_1.Top = 2280
		Me.RispTent11_1.Width = 285
		'
		' RispTent11_5
		'
		Me.RispTent11_5.Name = "RispTent11_5"
		Me.RispTent11_5.ParentForm = Me
		Me.RispTent11_5.Name6 = "RispTent11_5"
		Me.RispTent11_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent11_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent11_5.Height = 240
		Me.RispTent11_5.Left = 9480
		Me.RispTent11_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent11_5.Top = 2280
		Me.RispTent11_5.Width = 285
		'
		' RispTent11_4
		'
		Me.RispTent11_4.Name = "RispTent11_4"
		Me.RispTent11_4.ParentForm = Me
		Me.RispTent11_4.Name6 = "RispTent11_4"
		Me.RispTent11_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent11_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent11_4.Height = 240
		Me.RispTent11_4.Left = 9120
		Me.RispTent11_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent11_4.Top = 2280
		Me.RispTent11_4.Width = 285
		'
		' RispTent11_3
		'
		Me.RispTent11_3.Name = "RispTent11_3"
		Me.RispTent11_3.ParentForm = Me
		Me.RispTent11_3.Name6 = "RispTent11_3"
		Me.RispTent11_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent11_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent11_3.Height = 240
		Me.RispTent11_3.Left = 8760
		Me.RispTent11_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent11_3.Top = 2280
		Me.RispTent11_3.Width = 285
		'
		' RispTent11_2
		'
		Me.RispTent11_2.Name = "RispTent11_2"
		Me.RispTent11_2.ParentForm = Me
		Me.RispTent11_2.Name6 = "RispTent11_2"
		Me.RispTent11_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent11_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent11_2.Height = 240
		Me.RispTent11_2.Left = 8400
		Me.RispTent11_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent11_2.Top = 2280
		Me.RispTent11_2.Width = 285
		'
		' msg
		'
		Me.msg.Name = "msg"
		Me.msg.Size = New System.Drawing.Size(97, 25)
		Me.msg.Location = New System.Drawing.Point(48, 208)
		Me.msg.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.msg.Caption = "COLORE SCELTO:"
		Me.msg.TabIndex = 72
		Me.msg.AutoSize = False
		'
		' ColScelto
		'
		Me.ColScelto.Name = "ColScelto"
		Me.ColScelto.Size = New System.Drawing.Size(97, 65)
		Me.ColScelto.Location = New System.Drawing.Point(48, 232)
		Me.ColScelto.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.ColScelto.TabIndex = 71
		Me.ColScelto.AutoSize = False
		Me.ColScelto.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' R5
		'
		Me.R5.Name = "R5"
		Me.R5.Size = New System.Drawing.Size(57, 17)
		Me.R5.Location = New System.Drawing.Point(464, 32)
		Me.R5.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.R5.TabIndex = 70
		Me.R5.Visible = False
		Me.R5.AutoSize = False
		'
		' R4
		'
		Me.R4.Name = "R4"
		Me.R4.Size = New System.Drawing.Size(57, 17)
		Me.R4.Location = New System.Drawing.Point(392, 32)
		Me.R4.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.R4.TabIndex = 69
		Me.R4.Visible = False
		Me.R4.AutoSize = False
		'
		' R3
		'
		Me.R3.Name = "R3"
		Me.R3.Size = New System.Drawing.Size(57, 17)
		Me.R3.Location = New System.Drawing.Point(320, 32)
		Me.R3.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.R3.TabIndex = 68
		Me.R3.Visible = False
		Me.R3.AutoSize = False
		'
		' R2
		'
		Me.R2.Name = "R2"
		Me.R2.Size = New System.Drawing.Size(57, 17)
		Me.R2.Location = New System.Drawing.Point(248, 32)
		Me.R2.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.R2.TabIndex = 67
		Me.R2.Visible = False
		Me.R2.AutoSize = False
		'
		' R1
		'
		Me.R1.Name = "R1"
		Me.R1.Size = New System.Drawing.Size(57, 17)
		Me.R1.Location = New System.Drawing.Point(176, 32)
		Me.R1.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.R1.TabIndex = 66
		Me.R1.Visible = False
		Me.R1.AutoSize = False
		'
		' Bianco
		'
		Me.Bianco.Name = "Bianco"
		Me.Bianco.Size = New System.Drawing.Size(57, 41)
		Me.Bianco.Location = New System.Drawing.Point(104, 432)
		Me.Bianco.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Bianco.TabIndex = 55
		Me.Bianco.AutoSize = False
		Me.Bianco.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Nero
		'
		Me.Nero.Name = "Nero"
		Me.Nero.Size = New System.Drawing.Size(57, 41)
		Me.Nero.Location = New System.Drawing.Point(32, 432)
		Me.Nero.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Nero.TabIndex = 54
		Me.Nero.AutoSize = False
		Me.Nero.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Verde
		'
		Me.Verde.Name = "Verde"
		Me.Verde.Size = New System.Drawing.Size(57, 41)
		Me.Verde.Location = New System.Drawing.Point(104, 384)
		Me.Verde.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Verde.TabIndex = 53
		Me.Verde.AutoSize = False
		Me.Verde.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Rosso
		'
		Me.Rosso.Name = "Rosso"
		Me.Rosso.Size = New System.Drawing.Size(57, 41)
		Me.Rosso.Location = New System.Drawing.Point(32, 384)
		Me.Rosso.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Rosso.TabIndex = 52
		Me.Rosso.AutoSize = False
		Me.Rosso.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Giallo
		'
		Me.Giallo.Name = "Giallo"
		Me.Giallo.Size = New System.Drawing.Size(57, 41)
		Me.Giallo.Location = New System.Drawing.Point(104, 336)
		Me.Giallo.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Giallo.TabIndex = 51
		Me.Giallo.AutoSize = False
		Me.Giallo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Blu
		'
		Me.Blu.Name = "Blu"
		Me.Blu.Size = New System.Drawing.Size(57, 41)
		Me.Blu.Location = New System.Drawing.Point(32, 336)
		Me.Blu.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Blu.TabIndex = 50
		Me.Blu.AutoSize = False
		Me.Blu.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent10_5
		'
		Me.LabTent10_5.Name = "LabTent10_5"
		Me.LabTent10_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent10_5.Location = New System.Drawing.Point(464, 208)
		Me.LabTent10_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent10_5.Enabled = False
		Me.LabTent10_5.TabIndex = 49
		Me.LabTent10_5.AutoSize = False
		Me.LabTent10_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent10_4
		'
		Me.LabTent10_4.Name = "LabTent10_4"
		Me.LabTent10_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent10_4.Location = New System.Drawing.Point(416, 208)
		Me.LabTent10_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent10_4.Enabled = False
		Me.LabTent10_4.TabIndex = 48
		Me.LabTent10_4.AutoSize = False
		Me.LabTent10_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent10_3
		'
		Me.LabTent10_3.Name = "LabTent10_3"
		Me.LabTent10_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent10_3.Location = New System.Drawing.Point(368, 208)
		Me.LabTent10_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent10_3.Enabled = False
		Me.LabTent10_3.TabIndex = 47
		Me.LabTent10_3.AutoSize = False
		Me.LabTent10_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent10_2
		'
		Me.LabTent10_2.Name = "LabTent10_2"
		Me.LabTent10_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent10_2.Location = New System.Drawing.Point(320, 208)
		Me.LabTent10_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent10_2.Enabled = False
		Me.LabTent10_2.TabIndex = 46
		Me.LabTent10_2.AutoSize = False
		Me.LabTent10_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent10_1
		'
		Me.LabTent10_1.Name = "LabTent10_1"
		Me.LabTent10_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent10_1.Location = New System.Drawing.Point(272, 208)
		Me.LabTent10_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent10_1.Enabled = False
		Me.LabTent10_1.TabIndex = 45
		Me.LabTent10_1.AutoSize = False
		Me.LabTent10_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent9_5
		'
		Me.LabTent9_5.Name = "LabTent9_5"
		Me.LabTent9_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent9_5.Location = New System.Drawing.Point(464, 256)
		Me.LabTent9_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent9_5.Enabled = False
		Me.LabTent9_5.TabIndex = 44
		Me.LabTent9_5.AutoSize = False
		Me.LabTent9_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent9_4
		'
		Me.LabTent9_4.Name = "LabTent9_4"
		Me.LabTent9_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent9_4.Location = New System.Drawing.Point(416, 256)
		Me.LabTent9_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent9_4.Enabled = False
		Me.LabTent9_4.TabIndex = 43
		Me.LabTent9_4.AutoSize = False
		Me.LabTent9_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent9_3
		'
		Me.LabTent9_3.Name = "LabTent9_3"
		Me.LabTent9_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent9_3.Location = New System.Drawing.Point(368, 256)
		Me.LabTent9_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent9_3.Enabled = False
		Me.LabTent9_3.TabIndex = 42
		Me.LabTent9_3.AutoSize = False
		Me.LabTent9_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent9_2
		'
		Me.LabTent9_2.Name = "LabTent9_2"
		Me.LabTent9_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent9_2.Location = New System.Drawing.Point(320, 256)
		Me.LabTent9_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent9_2.Enabled = False
		Me.LabTent9_2.TabIndex = 41
		Me.LabTent9_2.AutoSize = False
		Me.LabTent9_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent9_1
		'
		Me.LabTent9_1.Name = "LabTent9_1"
		Me.LabTent9_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent9_1.Location = New System.Drawing.Point(272, 256)
		Me.LabTent9_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent9_1.Enabled = False
		Me.LabTent9_1.TabIndex = 40
		Me.LabTent9_1.AutoSize = False
		Me.LabTent9_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent8_5
		'
		Me.LabTent8_5.Name = "LabTent8_5"
		Me.LabTent8_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent8_5.Location = New System.Drawing.Point(464, 304)
		Me.LabTent8_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent8_5.Enabled = False
		Me.LabTent8_5.TabIndex = 39
		Me.LabTent8_5.AutoSize = False
		Me.LabTent8_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent8_4
		'
		Me.LabTent8_4.Name = "LabTent8_4"
		Me.LabTent8_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent8_4.Location = New System.Drawing.Point(416, 304)
		Me.LabTent8_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent8_4.Enabled = False
		Me.LabTent8_4.TabIndex = 38
		Me.LabTent8_4.AutoSize = False
		Me.LabTent8_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent8_3
		'
		Me.LabTent8_3.Name = "LabTent8_3"
		Me.LabTent8_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent8_3.Location = New System.Drawing.Point(368, 304)
		Me.LabTent8_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent8_3.Enabled = False
		Me.LabTent8_3.TabIndex = 37
		Me.LabTent8_3.AutoSize = False
		Me.LabTent8_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent8_2
		'
		Me.LabTent8_2.Name = "LabTent8_2"
		Me.LabTent8_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent8_2.Location = New System.Drawing.Point(320, 304)
		Me.LabTent8_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent8_2.Enabled = False
		Me.LabTent8_2.TabIndex = 36
		Me.LabTent8_2.AutoSize = False
		Me.LabTent8_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent8_1
		'
		Me.LabTent8_1.Name = "LabTent8_1"
		Me.LabTent8_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent8_1.Location = New System.Drawing.Point(272, 304)
		Me.LabTent8_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent8_1.Enabled = False
		Me.LabTent8_1.TabIndex = 35
		Me.LabTent8_1.AutoSize = False
		Me.LabTent8_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent7_5
		'
		Me.LabTent7_5.Name = "LabTent7_5"
		Me.LabTent7_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent7_5.Location = New System.Drawing.Point(464, 352)
		Me.LabTent7_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent7_5.Enabled = False
		Me.LabTent7_5.TabIndex = 34
		Me.LabTent7_5.AutoSize = False
		Me.LabTent7_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent7_4
		'
		Me.LabTent7_4.Name = "LabTent7_4"
		Me.LabTent7_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent7_4.Location = New System.Drawing.Point(416, 352)
		Me.LabTent7_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent7_4.Enabled = False
		Me.LabTent7_4.TabIndex = 33
		Me.LabTent7_4.AutoSize = False
		Me.LabTent7_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent7_3
		'
		Me.LabTent7_3.Name = "LabTent7_3"
		Me.LabTent7_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent7_3.Location = New System.Drawing.Point(368, 352)
		Me.LabTent7_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent7_3.Enabled = False
		Me.LabTent7_3.TabIndex = 32
		Me.LabTent7_3.AutoSize = False
		Me.LabTent7_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent7_2
		'
		Me.LabTent7_2.Name = "LabTent7_2"
		Me.LabTent7_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent7_2.Location = New System.Drawing.Point(320, 352)
		Me.LabTent7_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent7_2.Enabled = False
		Me.LabTent7_2.TabIndex = 31
		Me.LabTent7_2.AutoSize = False
		Me.LabTent7_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent7_1
		'
		Me.LabTent7_1.Name = "LabTent7_1"
		Me.LabTent7_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent7_1.Location = New System.Drawing.Point(272, 352)
		Me.LabTent7_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent7_1.Enabled = False
		Me.LabTent7_1.TabIndex = 30
		Me.LabTent7_1.AutoSize = False
		Me.LabTent7_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent6_5
		'
		Me.LabTent6_5.Name = "LabTent6_5"
		Me.LabTent6_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent6_5.Location = New System.Drawing.Point(464, 400)
		Me.LabTent6_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent6_5.Enabled = False
		Me.LabTent6_5.TabIndex = 29
		Me.LabTent6_5.AutoSize = False
		Me.LabTent6_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent6_4
		'
		Me.LabTent6_4.Name = "LabTent6_4"
		Me.LabTent6_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent6_4.Location = New System.Drawing.Point(416, 400)
		Me.LabTent6_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent6_4.Enabled = False
		Me.LabTent6_4.TabIndex = 28
		Me.LabTent6_4.AutoSize = False
		Me.LabTent6_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent6_3
		'
		Me.LabTent6_3.Name = "LabTent6_3"
		Me.LabTent6_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent6_3.Location = New System.Drawing.Point(368, 400)
		Me.LabTent6_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent6_3.Enabled = False
		Me.LabTent6_3.TabIndex = 27
		Me.LabTent6_3.AutoSize = False
		Me.LabTent6_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent6_2
		'
		Me.LabTent6_2.Name = "LabTent6_2"
		Me.LabTent6_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent6_2.Location = New System.Drawing.Point(320, 400)
		Me.LabTent6_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent6_2.Enabled = False
		Me.LabTent6_2.TabIndex = 26
		Me.LabTent6_2.AutoSize = False
		Me.LabTent6_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent6_1
		'
		Me.LabTent6_1.Name = "LabTent6_1"
		Me.LabTent6_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent6_1.Location = New System.Drawing.Point(272, 400)
		Me.LabTent6_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent6_1.Enabled = False
		Me.LabTent6_1.TabIndex = 25
		Me.LabTent6_1.AutoSize = False
		Me.LabTent6_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent5_5
		'
		Me.LabTent5_5.Name = "LabTent5_5"
		Me.LabTent5_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent5_5.Location = New System.Drawing.Point(464, 448)
		Me.LabTent5_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent5_5.Enabled = False
		Me.LabTent5_5.TabIndex = 24
		Me.LabTent5_5.AutoSize = False
		Me.LabTent5_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent5_4
		'
		Me.LabTent5_4.Name = "LabTent5_4"
		Me.LabTent5_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent5_4.Location = New System.Drawing.Point(416, 448)
		Me.LabTent5_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent5_4.Enabled = False
		Me.LabTent5_4.TabIndex = 23
		Me.LabTent5_4.AutoSize = False
		Me.LabTent5_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent5_3
		'
		Me.LabTent5_3.Name = "LabTent5_3"
		Me.LabTent5_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent5_3.Location = New System.Drawing.Point(368, 448)
		Me.LabTent5_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent5_3.Enabled = False
		Me.LabTent5_3.TabIndex = 22
		Me.LabTent5_3.AutoSize = False
		Me.LabTent5_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent5_2
		'
		Me.LabTent5_2.Name = "LabTent5_2"
		Me.LabTent5_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent5_2.Location = New System.Drawing.Point(320, 448)
		Me.LabTent5_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent5_2.Enabled = False
		Me.LabTent5_2.TabIndex = 21
		Me.LabTent5_2.AutoSize = False
		Me.LabTent5_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent5_1
		'
		Me.LabTent5_1.Name = "LabTent5_1"
		Me.LabTent5_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent5_1.Location = New System.Drawing.Point(272, 448)
		Me.LabTent5_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent5_1.Enabled = False
		Me.LabTent5_1.TabIndex = 20
		Me.LabTent5_1.AutoSize = False
		Me.LabTent5_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent4_5
		'
		Me.LabTent4_5.Name = "LabTent4_5"
		Me.LabTent4_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent4_5.Location = New System.Drawing.Point(464, 496)
		Me.LabTent4_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent4_5.Enabled = False
		Me.LabTent4_5.TabIndex = 19
		Me.LabTent4_5.AutoSize = False
		Me.LabTent4_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent4_4
		'
		Me.LabTent4_4.Name = "LabTent4_4"
		Me.LabTent4_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent4_4.Location = New System.Drawing.Point(416, 496)
		Me.LabTent4_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent4_4.Enabled = False
		Me.LabTent4_4.TabIndex = 18
		Me.LabTent4_4.AutoSize = False
		Me.LabTent4_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent4_3
		'
		Me.LabTent4_3.Name = "LabTent4_3"
		Me.LabTent4_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent4_3.Location = New System.Drawing.Point(368, 496)
		Me.LabTent4_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent4_3.Enabled = False
		Me.LabTent4_3.TabIndex = 17
		Me.LabTent4_3.AutoSize = False
		Me.LabTent4_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent4_2
		'
		Me.LabTent4_2.Name = "LabTent4_2"
		Me.LabTent4_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent4_2.Location = New System.Drawing.Point(320, 496)
		Me.LabTent4_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent4_2.Enabled = False
		Me.LabTent4_2.TabIndex = 16
		Me.LabTent4_2.AutoSize = False
		Me.LabTent4_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent4_1
		'
		Me.LabTent4_1.Name = "LabTent4_1"
		Me.LabTent4_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent4_1.Location = New System.Drawing.Point(272, 496)
		Me.LabTent4_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent4_1.Enabled = False
		Me.LabTent4_1.TabIndex = 15
		Me.LabTent4_1.AutoSize = False
		Me.LabTent4_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent3_5
		'
		Me.LabTent3_5.Name = "LabTent3_5"
		Me.LabTent3_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent3_5.Location = New System.Drawing.Point(464, 544)
		Me.LabTent3_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent3_5.Enabled = False
		Me.LabTent3_5.TabIndex = 14
		Me.LabTent3_5.AutoSize = False
		Me.LabTent3_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent3_4
		'
		Me.LabTent3_4.Name = "LabTent3_4"
		Me.LabTent3_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent3_4.Location = New System.Drawing.Point(416, 544)
		Me.LabTent3_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent3_4.Enabled = False
		Me.LabTent3_4.TabIndex = 13
		Me.LabTent3_4.AutoSize = False
		Me.LabTent3_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent3_3
		'
		Me.LabTent3_3.Name = "LabTent3_3"
		Me.LabTent3_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent3_3.Location = New System.Drawing.Point(368, 544)
		Me.LabTent3_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent3_3.Enabled = False
		Me.LabTent3_3.TabIndex = 12
		Me.LabTent3_3.AutoSize = False
		Me.LabTent3_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent3_2
		'
		Me.LabTent3_2.Name = "LabTent3_2"
		Me.LabTent3_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent3_2.Location = New System.Drawing.Point(320, 544)
		Me.LabTent3_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent3_2.Enabled = False
		Me.LabTent3_2.TabIndex = 11
		Me.LabTent3_2.AutoSize = False
		Me.LabTent3_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent3_1
		'
		Me.LabTent3_1.Name = "LabTent3_1"
		Me.LabTent3_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent3_1.Location = New System.Drawing.Point(272, 544)
		Me.LabTent3_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent3_1.Enabled = False
		Me.LabTent3_1.TabIndex = 10
		Me.LabTent3_1.AutoSize = False
		Me.LabTent3_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent2_5
		'
		Me.LabTent2_5.Name = "LabTent2_5"
		Me.LabTent2_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent2_5.Location = New System.Drawing.Point(464, 592)
		Me.LabTent2_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent2_5.Enabled = False
		Me.LabTent2_5.TabIndex = 9
		Me.LabTent2_5.AutoSize = False
		Me.LabTent2_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent2_4
		'
		Me.LabTent2_4.Name = "LabTent2_4"
		Me.LabTent2_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent2_4.Location = New System.Drawing.Point(416, 592)
		Me.LabTent2_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent2_4.Enabled = False
		Me.LabTent2_4.TabIndex = 8
		Me.LabTent2_4.AutoSize = False
		Me.LabTent2_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent2_3
		'
		Me.LabTent2_3.Name = "LabTent2_3"
		Me.LabTent2_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent2_3.Location = New System.Drawing.Point(368, 592)
		Me.LabTent2_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent2_3.Enabled = False
		Me.LabTent2_3.TabIndex = 7
		Me.LabTent2_3.AutoSize = False
		Me.LabTent2_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent2_2
		'
		Me.LabTent2_2.Name = "LabTent2_2"
		Me.LabTent2_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent2_2.Location = New System.Drawing.Point(320, 592)
		Me.LabTent2_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent2_2.Enabled = False
		Me.LabTent2_2.TabIndex = 6
		Me.LabTent2_2.AutoSize = False
		Me.LabTent2_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent2_1
		'
		Me.LabTent2_1.Name = "LabTent2_1"
		Me.LabTent2_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent2_1.Location = New System.Drawing.Point(272, 592)
		Me.LabTent2_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent2_1.Enabled = False
		Me.LabTent2_1.TabIndex = 5
		Me.LabTent2_1.AutoSize = False
		Me.LabTent2_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent1_5
		'
		Me.LabTent1_5.Name = "LabTent1_5"
		Me.LabTent1_5.Size = New System.Drawing.Size(33, 41)
		Me.LabTent1_5.Location = New System.Drawing.Point(464, 640)
		Me.LabTent1_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent1_5.TabIndex = 4
		Me.LabTent1_5.AutoSize = False
		Me.LabTent1_5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent1_4
		'
		Me.LabTent1_4.Name = "LabTent1_4"
		Me.LabTent1_4.Size = New System.Drawing.Size(33, 41)
		Me.LabTent1_4.Location = New System.Drawing.Point(416, 640)
		Me.LabTent1_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent1_4.TabIndex = 3
		Me.LabTent1_4.AutoSize = False
		Me.LabTent1_4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent1_3
		'
		Me.LabTent1_3.Name = "LabTent1_3"
		Me.LabTent1_3.Size = New System.Drawing.Size(33, 41)
		Me.LabTent1_3.Location = New System.Drawing.Point(368, 640)
		Me.LabTent1_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent1_3.TabIndex = 2
		Me.LabTent1_3.AutoSize = False
		Me.LabTent1_3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LabTent1_2
		'
		Me.LabTent1_2.Name = "LabTent1_2"
		Me.LabTent1_2.Size = New System.Drawing.Size(33, 41)
		Me.LabTent1_2.Location = New System.Drawing.Point(320, 640)
		Me.LabTent1_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent1_2.TabIndex = 1
		Me.LabTent1_2.AutoSize = False
		Me.LabTent1_2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' RispTent1_2
		'
		Me.RispTent1_2.Name = "RispTent1_2"
		Me.RispTent1_2.ParentForm = Me
		Me.RispTent1_2.Name6 = "RispTent1_2"
		Me.RispTent1_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent1_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent1_2.Height = 240
		Me.RispTent1_2.Left = 8400
		Me.RispTent1_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent1_2.Top = 9480
		Me.RispTent1_2.Width = 285
		'
		' RispTent1_3
		'
		Me.RispTent1_3.Name = "RispTent1_3"
		Me.RispTent1_3.ParentForm = Me
		Me.RispTent1_3.Name6 = "RispTent1_3"
		Me.RispTent1_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent1_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent1_3.Height = 240
		Me.RispTent1_3.Left = 8760
		Me.RispTent1_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent1_3.Top = 9480
		Me.RispTent1_3.Width = 285
		'
		' RispTent1_4
		'
		Me.RispTent1_4.Name = "RispTent1_4"
		Me.RispTent1_4.ParentForm = Me
		Me.RispTent1_4.Name6 = "RispTent1_4"
		Me.RispTent1_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent1_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent1_4.Height = 240
		Me.RispTent1_4.Left = 9120
		Me.RispTent1_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent1_4.Top = 9480
		Me.RispTent1_4.Width = 285
		'
		' RispTent1_5
		'
		Me.RispTent1_5.Name = "RispTent1_5"
		Me.RispTent1_5.ParentForm = Me
		Me.RispTent1_5.Name6 = "RispTent1_5"
		Me.RispTent1_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent1_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent1_5.Height = 240
		Me.RispTent1_5.Left = 9480
		Me.RispTent1_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent1_5.Top = 9480
		Me.RispTent1_5.Width = 285
		'
		' RispTent1_1
		'
		Me.RispTent1_1.Name = "RispTent1_1"
		Me.RispTent1_1.ParentForm = Me
		Me.RispTent1_1.Name6 = "RispTent1_1"
		Me.RispTent1_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent1_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent1_1.Height = 240
		Me.RispTent1_1.Left = 8040
		Me.RispTent1_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent1_1.Top = 9480
		Me.RispTent1_1.Width = 285
		'
		' RispTent2_2
		'
		Me.RispTent2_2.Name = "RispTent2_2"
		Me.RispTent2_2.ParentForm = Me
		Me.RispTent2_2.Name6 = "RispTent2_2"
		Me.RispTent2_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent2_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent2_2.Height = 240
		Me.RispTent2_2.Left = 8400
		Me.RispTent2_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent2_2.Top = 8760
		Me.RispTent2_2.Width = 285
		'
		' RispTent2_3
		'
		Me.RispTent2_3.Name = "RispTent2_3"
		Me.RispTent2_3.ParentForm = Me
		Me.RispTent2_3.Name6 = "RispTent2_3"
		Me.RispTent2_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent2_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent2_3.Height = 240
		Me.RispTent2_3.Left = 8760
		Me.RispTent2_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent2_3.Top = 8760
		Me.RispTent2_3.Width = 285
		'
		' RispTent2_4
		'
		Me.RispTent2_4.Name = "RispTent2_4"
		Me.RispTent2_4.ParentForm = Me
		Me.RispTent2_4.Name6 = "RispTent2_4"
		Me.RispTent2_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent2_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent2_4.Height = 240
		Me.RispTent2_4.Left = 9120
		Me.RispTent2_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent2_4.Top = 8760
		Me.RispTent2_4.Width = 285
		'
		' RispTent2_5
		'
		Me.RispTent2_5.Name = "RispTent2_5"
		Me.RispTent2_5.ParentForm = Me
		Me.RispTent2_5.Name6 = "RispTent2_5"
		Me.RispTent2_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent2_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent2_5.Height = 240
		Me.RispTent2_5.Left = 9480
		Me.RispTent2_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent2_5.Top = 8760
		Me.RispTent2_5.Width = 285
		'
		' RispTent2_1
		'
		Me.RispTent2_1.Name = "RispTent2_1"
		Me.RispTent2_1.ParentForm = Me
		Me.RispTent2_1.Name6 = "RispTent2_1"
		Me.RispTent2_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent2_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent2_1.Height = 240
		Me.RispTent2_1.Left = 8040
		Me.RispTent2_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent2_1.Top = 8760
		Me.RispTent2_1.Width = 285
		'
		' RispTent3_2
		'
		Me.RispTent3_2.Name = "RispTent3_2"
		Me.RispTent3_2.ParentForm = Me
		Me.RispTent3_2.Name6 = "RispTent3_2"
		Me.RispTent3_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent3_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent3_2.Height = 240
		Me.RispTent3_2.Left = 8400
		Me.RispTent3_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent3_2.Top = 8040
		Me.RispTent3_2.Width = 285
		'
		' RispTent3_3
		'
		Me.RispTent3_3.Name = "RispTent3_3"
		Me.RispTent3_3.ParentForm = Me
		Me.RispTent3_3.Name6 = "RispTent3_3"
		Me.RispTent3_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent3_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent3_3.Height = 240
		Me.RispTent3_3.Left = 8760
		Me.RispTent3_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent3_3.Top = 8040
		Me.RispTent3_3.Width = 285
		'
		' RispTent3_4
		'
		Me.RispTent3_4.Name = "RispTent3_4"
		Me.RispTent3_4.ParentForm = Me
		Me.RispTent3_4.Name6 = "RispTent3_4"
		Me.RispTent3_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent3_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent3_4.Height = 240
		Me.RispTent3_4.Left = 9120
		Me.RispTent3_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent3_4.Top = 8040
		Me.RispTent3_4.Width = 285
		'
		' RispTent3_5
		'
		Me.RispTent3_5.Name = "RispTent3_5"
		Me.RispTent3_5.ParentForm = Me
		Me.RispTent3_5.Name6 = "RispTent3_5"
		Me.RispTent3_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent3_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent3_5.Height = 240
		Me.RispTent3_5.Left = 9480
		Me.RispTent3_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent3_5.Top = 8040
		Me.RispTent3_5.Width = 285
		'
		' RispTent3_1
		'
		Me.RispTent3_1.Name = "RispTent3_1"
		Me.RispTent3_1.ParentForm = Me
		Me.RispTent3_1.Name6 = "RispTent3_1"
		Me.RispTent3_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent3_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent3_1.Height = 240
		Me.RispTent3_1.Left = 8040
		Me.RispTent3_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent3_1.Top = 8040
		Me.RispTent3_1.Width = 285
		'
		' RispTent4_2
		'
		Me.RispTent4_2.Name = "RispTent4_2"
		Me.RispTent4_2.ParentForm = Me
		Me.RispTent4_2.Name6 = "RispTent4_2"
		Me.RispTent4_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent4_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent4_2.Height = 240
		Me.RispTent4_2.Left = 8400
		Me.RispTent4_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent4_2.Top = 7320
		Me.RispTent4_2.Width = 285
		'
		' RispTent4_3
		'
		Me.RispTent4_3.Name = "RispTent4_3"
		Me.RispTent4_3.ParentForm = Me
		Me.RispTent4_3.Name6 = "RispTent4_3"
		Me.RispTent4_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent4_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent4_3.Height = 240
		Me.RispTent4_3.Left = 8760
		Me.RispTent4_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent4_3.Top = 7320
		Me.RispTent4_3.Width = 285
		'
		' RispTent4_4
		'
		Me.RispTent4_4.Name = "RispTent4_4"
		Me.RispTent4_4.ParentForm = Me
		Me.RispTent4_4.Name6 = "RispTent4_4"
		Me.RispTent4_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent4_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent4_4.Height = 240
		Me.RispTent4_4.Left = 9120
		Me.RispTent4_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent4_4.Top = 7320
		Me.RispTent4_4.Width = 285
		'
		' RispTent4_5
		'
		Me.RispTent4_5.Name = "RispTent4_5"
		Me.RispTent4_5.ParentForm = Me
		Me.RispTent4_5.Name6 = "RispTent4_5"
		Me.RispTent4_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent4_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent4_5.Height = 240
		Me.RispTent4_5.Left = 9480
		Me.RispTent4_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent4_5.Top = 7320
		Me.RispTent4_5.Width = 285
		'
		' RispTent4_1
		'
		Me.RispTent4_1.Name = "RispTent4_1"
		Me.RispTent4_1.ParentForm = Me
		Me.RispTent4_1.Name6 = "RispTent4_1"
		Me.RispTent4_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent4_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent4_1.Height = 240
		Me.RispTent4_1.Left = 8040
		Me.RispTent4_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent4_1.Top = 7320
		Me.RispTent4_1.Width = 285
		'
		' RispTent5_2
		'
		Me.RispTent5_2.Name = "RispTent5_2"
		Me.RispTent5_2.ParentForm = Me
		Me.RispTent5_2.Name6 = "RispTent5_2"
		Me.RispTent5_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent5_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent5_2.Height = 240
		Me.RispTent5_2.Left = 8400
		Me.RispTent5_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent5_2.Top = 6600
		Me.RispTent5_2.Width = 285
		'
		' RispTent5_3
		'
		Me.RispTent5_3.Name = "RispTent5_3"
		Me.RispTent5_3.ParentForm = Me
		Me.RispTent5_3.Name6 = "RispTent5_3"
		Me.RispTent5_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent5_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent5_3.Height = 240
		Me.RispTent5_3.Left = 8760
		Me.RispTent5_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent5_3.Top = 6600
		Me.RispTent5_3.Width = 285
		'
		' RispTent5_4
		'
		Me.RispTent5_4.Name = "RispTent5_4"
		Me.RispTent5_4.ParentForm = Me
		Me.RispTent5_4.Name6 = "RispTent5_4"
		Me.RispTent5_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent5_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent5_4.Height = 240
		Me.RispTent5_4.Left = 9120
		Me.RispTent5_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent5_4.Top = 6600
		Me.RispTent5_4.Width = 285
		'
		' RispTent5_5
		'
		Me.RispTent5_5.Name = "RispTent5_5"
		Me.RispTent5_5.ParentForm = Me
		Me.RispTent5_5.Name6 = "RispTent5_5"
		Me.RispTent5_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent5_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent5_5.Height = 240
		Me.RispTent5_5.Left = 9480
		Me.RispTent5_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent5_5.Top = 6600
		Me.RispTent5_5.Width = 285
		'
		' RispTent5_1
		'
		Me.RispTent5_1.Name = "RispTent5_1"
		Me.RispTent5_1.ParentForm = Me
		Me.RispTent5_1.Name6 = "RispTent5_1"
		Me.RispTent5_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent5_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent5_1.Height = 240
		Me.RispTent5_1.Left = 8040
		Me.RispTent5_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent5_1.Top = 6600
		Me.RispTent5_1.Width = 285
		'
		' RispTent6_2
		'
		Me.RispTent6_2.Name = "RispTent6_2"
		Me.RispTent6_2.ParentForm = Me
		Me.RispTent6_2.Name6 = "RispTent6_2"
		Me.RispTent6_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent6_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent6_2.Height = 240
		Me.RispTent6_2.Left = 8400
		Me.RispTent6_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent6_2.Top = 5880
		Me.RispTent6_2.Width = 285
		'
		' RispTent6_3
		'
		Me.RispTent6_3.Name = "RispTent6_3"
		Me.RispTent6_3.ParentForm = Me
		Me.RispTent6_3.Name6 = "RispTent6_3"
		Me.RispTent6_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent6_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent6_3.Height = 240
		Me.RispTent6_3.Left = 8760
		Me.RispTent6_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent6_3.Top = 5880
		Me.RispTent6_3.Width = 285
		'
		' RispTent6_4
		'
		Me.RispTent6_4.Name = "RispTent6_4"
		Me.RispTent6_4.ParentForm = Me
		Me.RispTent6_4.Name6 = "RispTent6_4"
		Me.RispTent6_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent6_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent6_4.Height = 240
		Me.RispTent6_4.Left = 9120
		Me.RispTent6_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent6_4.Top = 5880
		Me.RispTent6_4.Width = 285
		'
		' RispTent6_5
		'
		Me.RispTent6_5.Name = "RispTent6_5"
		Me.RispTent6_5.ParentForm = Me
		Me.RispTent6_5.Name6 = "RispTent6_5"
		Me.RispTent6_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent6_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent6_5.Height = 240
		Me.RispTent6_5.Left = 9480
		Me.RispTent6_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent6_5.Top = 5880
		Me.RispTent6_5.Width = 285
		'
		' RispTent6_1
		'
		Me.RispTent6_1.Name = "RispTent6_1"
		Me.RispTent6_1.ParentForm = Me
		Me.RispTent6_1.Name6 = "RispTent6_1"
		Me.RispTent6_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent6_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent6_1.Height = 240
		Me.RispTent6_1.Left = 8040
		Me.RispTent6_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent6_1.Top = 5880
		Me.RispTent6_1.Width = 285
		'
		' RispTent7_2
		'
		Me.RispTent7_2.Name = "RispTent7_2"
		Me.RispTent7_2.ParentForm = Me
		Me.RispTent7_2.Name6 = "RispTent7_2"
		Me.RispTent7_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent7_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent7_2.Height = 240
		Me.RispTent7_2.Left = 8400
		Me.RispTent7_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent7_2.Top = 5160
		Me.RispTent7_2.Width = 285
		'
		' RispTent7_3
		'
		Me.RispTent7_3.Name = "RispTent7_3"
		Me.RispTent7_3.ParentForm = Me
		Me.RispTent7_3.Name6 = "RispTent7_3"
		Me.RispTent7_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent7_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent7_3.Height = 240
		Me.RispTent7_3.Left = 8760
		Me.RispTent7_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent7_3.Top = 5160
		Me.RispTent7_3.Width = 285
		'
		' RispTent7_4
		'
		Me.RispTent7_4.Name = "RispTent7_4"
		Me.RispTent7_4.ParentForm = Me
		Me.RispTent7_4.Name6 = "RispTent7_4"
		Me.RispTent7_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent7_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent7_4.Height = 240
		Me.RispTent7_4.Left = 9120
		Me.RispTent7_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent7_4.Top = 5160
		Me.RispTent7_4.Width = 285
		'
		' RispTent7_5
		'
		Me.RispTent7_5.Name = "RispTent7_5"
		Me.RispTent7_5.ParentForm = Me
		Me.RispTent7_5.Name6 = "RispTent7_5"
		Me.RispTent7_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent7_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent7_5.Height = 240
		Me.RispTent7_5.Left = 9480
		Me.RispTent7_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent7_5.Top = 5160
		Me.RispTent7_5.Width = 285
		'
		' RispTent7_1
		'
		Me.RispTent7_1.Name = "RispTent7_1"
		Me.RispTent7_1.ParentForm = Me
		Me.RispTent7_1.Name6 = "RispTent7_1"
		Me.RispTent7_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent7_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent7_1.Height = 240
		Me.RispTent7_1.Left = 8040
		Me.RispTent7_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent7_1.Top = 5160
		Me.RispTent7_1.Width = 285
		'
		' RispTent8_2
		'
		Me.RispTent8_2.Name = "RispTent8_2"
		Me.RispTent8_2.ParentForm = Me
		Me.RispTent8_2.Name6 = "RispTent8_2"
		Me.RispTent8_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent8_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent8_2.Height = 240
		Me.RispTent8_2.Left = 8400
		Me.RispTent8_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent8_2.Top = 4440
		Me.RispTent8_2.Width = 285
		'
		' RispTent8_3
		'
		Me.RispTent8_3.Name = "RispTent8_3"
		Me.RispTent8_3.ParentForm = Me
		Me.RispTent8_3.Name6 = "RispTent8_3"
		Me.RispTent8_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent8_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent8_3.Height = 240
		Me.RispTent8_3.Left = 8760
		Me.RispTent8_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent8_3.Top = 4440
		Me.RispTent8_3.Width = 285
		'
		' RispTent8_4
		'
		Me.RispTent8_4.Name = "RispTent8_4"
		Me.RispTent8_4.ParentForm = Me
		Me.RispTent8_4.Name6 = "RispTent8_4"
		Me.RispTent8_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent8_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent8_4.Height = 240
		Me.RispTent8_4.Left = 9120
		Me.RispTent8_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent8_4.Top = 4440
		Me.RispTent8_4.Width = 285
		'
		' RispTent8_5
		'
		Me.RispTent8_5.Name = "RispTent8_5"
		Me.RispTent8_5.ParentForm = Me
		Me.RispTent8_5.Name6 = "RispTent8_5"
		Me.RispTent8_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent8_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent8_5.Height = 240
		Me.RispTent8_5.Left = 9480
		Me.RispTent8_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent8_5.Top = 4440
		Me.RispTent8_5.Width = 285
		'
		' RispTent8_1
		'
		Me.RispTent8_1.Name = "RispTent8_1"
		Me.RispTent8_1.ParentForm = Me
		Me.RispTent8_1.Name6 = "RispTent8_1"
		Me.RispTent8_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent8_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent8_1.Height = 240
		Me.RispTent8_1.Left = 8040
		Me.RispTent8_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent8_1.Top = 4440
		Me.RispTent8_1.Width = 285
		'
		' RispTent9_2
		'
		Me.RispTent9_2.Name = "RispTent9_2"
		Me.RispTent9_2.ParentForm = Me
		Me.RispTent9_2.Name6 = "RispTent9_2"
		Me.RispTent9_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent9_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent9_2.Height = 240
		Me.RispTent9_2.Left = 8400
		Me.RispTent9_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent9_2.Top = 3720
		Me.RispTent9_2.Width = 285
		'
		' RispTent9_3
		'
		Me.RispTent9_3.Name = "RispTent9_3"
		Me.RispTent9_3.ParentForm = Me
		Me.RispTent9_3.Name6 = "RispTent9_3"
		Me.RispTent9_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent9_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent9_3.Height = 240
		Me.RispTent9_3.Left = 8760
		Me.RispTent9_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent9_3.Top = 3720
		Me.RispTent9_3.Width = 285
		'
		' RispTent9_4
		'
		Me.RispTent9_4.Name = "RispTent9_4"
		Me.RispTent9_4.ParentForm = Me
		Me.RispTent9_4.Name6 = "RispTent9_4"
		Me.RispTent9_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent9_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent9_4.Height = 240
		Me.RispTent9_4.Left = 9120
		Me.RispTent9_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent9_4.Top = 3720
		Me.RispTent9_4.Width = 285
		'
		' RispTent9_5
		'
		Me.RispTent9_5.Name = "RispTent9_5"
		Me.RispTent9_5.ParentForm = Me
		Me.RispTent9_5.Name6 = "RispTent9_5"
		Me.RispTent9_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent9_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent9_5.Height = 240
		Me.RispTent9_5.Left = 9480
		Me.RispTent9_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent9_5.Top = 3720
		Me.RispTent9_5.Width = 285
		'
		' RispTent9_1
		'
		Me.RispTent9_1.Name = "RispTent9_1"
		Me.RispTent9_1.ParentForm = Me
		Me.RispTent9_1.Name6 = "RispTent9_1"
		Me.RispTent9_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent9_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent9_1.Height = 240
		Me.RispTent9_1.Left = 8040
		Me.RispTent9_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent9_1.Top = 3720
		Me.RispTent9_1.Width = 285
		'
		' RispTent10_2
		'
		Me.RispTent10_2.Name = "RispTent10_2"
		Me.RispTent10_2.ParentForm = Me
		Me.RispTent10_2.Name6 = "RispTent10_2"
		Me.RispTent10_2.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent10_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent10_2.Height = 240
		Me.RispTent10_2.Left = 8400
		Me.RispTent10_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent10_2.Top = 3000
		Me.RispTent10_2.Width = 285
		'
		' RispTent10_3
		'
		Me.RispTent10_3.Name = "RispTent10_3"
		Me.RispTent10_3.ParentForm = Me
		Me.RispTent10_3.Name6 = "RispTent10_3"
		Me.RispTent10_3.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent10_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent10_3.Height = 240
		Me.RispTent10_3.Left = 8760
		Me.RispTent10_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent10_3.Top = 3000
		Me.RispTent10_3.Width = 285
		'
		' RispTent10_4
		'
		Me.RispTent10_4.Name = "RispTent10_4"
		Me.RispTent10_4.ParentForm = Me
		Me.RispTent10_4.Name6 = "RispTent10_4"
		Me.RispTent10_4.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent10_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent10_4.Height = 240
		Me.RispTent10_4.Left = 9120
		Me.RispTent10_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent10_4.Top = 3000
		Me.RispTent10_4.Width = 285
		'
		' RispTent10_5
		'
		Me.RispTent10_5.Name = "RispTent10_5"
		Me.RispTent10_5.ParentForm = Me
		Me.RispTent10_5.Name6 = "RispTent10_5"
		Me.RispTent10_5.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent10_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent10_5.Height = 240
		Me.RispTent10_5.Left = 9480
		Me.RispTent10_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent10_5.Top = 3000
		Me.RispTent10_5.Width = 285
		'
		' RispTent10_1
		'
		Me.RispTent10_1.Name = "RispTent10_1"
		Me.RispTent10_1.ParentForm = Me
		Me.RispTent10_1.Name6 = "RispTent10_1"
		Me.RispTent10_1.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.RispTent10_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.RispTent10_1.Height = 240
		Me.RispTent10_1.Left = 8040
		Me.RispTent10_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.RispTent10_1.Top = 3000
		Me.RispTent10_1.Width = 285
		'
		' Col1
		'
		Me.Col1.Name = "Col1"
		Me.Col1.ParentForm = Me
		Me.Col1.Name6 = "Col1"
		Me.Col1.BackColor = FromOleColor6(CInt(&H00FF0000))
		Me.Col1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col1.Height = 615
		Me.Col1.Left = 480
		Me.Col1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col1.Top = 4680
		Me.Col1.Width = 855
		'
		' Col2
		'
		Me.Col2.Name = "Col2"
		Me.Col2.ParentForm = Me
		Me.Col2.Name6 = "Col2"
		Me.Col2.BackColor = FromOleColor6(CInt(&H0000FFFF))
		Me.Col2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col2.Height = 615
		Me.Col2.Left = 1560
		Me.Col2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col2.Top = 4680
		Me.Col2.Width = 855
		'
		' Col3
		'
		Me.Col3.Name = "Col3"
		Me.Col3.ParentForm = Me
		Me.Col3.Name6 = "Col3"
		Me.Col3.BackColor = FromOleColor6(CInt(&H000000FF))
		Me.Col3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col3.Height = 615
		Me.Col3.Left = 480
		Me.Col3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col3.Top = 5400
		Me.Col3.Width = 855
		'
		' Col4
		'
		Me.Col4.Name = "Col4"
		Me.Col4.ParentForm = Me
		Me.Col4.Name6 = "Col4"
		Me.Col4.BackColor = FromOleColor6(CInt(&H0000FF00))
		Me.Col4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col4.Height = 615
		Me.Col4.Left = 1560
		Me.Col4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col4.Top = 5400
		Me.Col4.Width = 855
		'
		' Col5
		'
		Me.Col5.Name = "Col5"
		Me.Col5.ParentForm = Me
		Me.Col5.Name6 = "Col5"
		Me.Col5.BackColor = FromOleColor6(CInt(&H80000007))
		Me.Col5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col5.Height = 615
		Me.Col5.Left = 480
		Me.Col5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col5.Top = 6120
		Me.Col5.Width = 855
		'
		' Col6
		'
		Me.Col6.Name = "Col6"
		Me.Col6.ParentForm = Me
		Me.Col6.Name6 = "Col6"
		Me.Col6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Col6.Height = 615
		Me.Col6.Left = 1560
		Me.Col6.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.Col6.Top = 6120
		Me.Col6.Width = 855
		'
		' LabTent1_1
		'
		Me.LabTent1_1.Name = "LabTent1_1"
		Me.LabTent1_1.Size = New System.Drawing.Size(33, 41)
		Me.LabTent1_1.Location = New System.Drawing.Point(272, 640)
		Me.LabTent1_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LabTent1_1.TabIndex = 0
		Me.LabTent1_1.AutoSize = False
		Me.LabTent1_1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Tent1_2
		'
		Me.Tent1_2.Name = "Tent1_2"
		Me.Tent1_2.ParentForm = Me
		Me.Tent1_2.Name6 = "Tent1_2"
		Me.Tent1_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent1_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent1_2.Height = 600
		Me.Tent1_2.Left = 4560
		Me.Tent1_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent1_2.Top = 9240
		Me.Tent1_2.Width = 1005
		'
		' Tent1_3
		'
		Me.Tent1_3.Name = "Tent1_3"
		Me.Tent1_3.ParentForm = Me
		Me.Tent1_3.Name6 = "Tent1_3"
		Me.Tent1_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent1_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent1_3.Height = 600
		Me.Tent1_3.Left = 5280
		Me.Tent1_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent1_3.Top = 9240
		Me.Tent1_3.Width = 1005
		'
		' Tent1_4
		'
		Me.Tent1_4.Name = "Tent1_4"
		Me.Tent1_4.ParentForm = Me
		Me.Tent1_4.Name6 = "Tent1_4"
		Me.Tent1_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent1_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent1_4.Height = 600
		Me.Tent1_4.Left = 6000
		Me.Tent1_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent1_4.Top = 9240
		Me.Tent1_4.Width = 1005
		'
		' Tent1_5
		'
		Me.Tent1_5.Name = "Tent1_5"
		Me.Tent1_5.ParentForm = Me
		Me.Tent1_5.Name6 = "Tent1_5"
		Me.Tent1_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent1_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent1_5.Height = 600
		Me.Tent1_5.Left = 6720
		Me.Tent1_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent1_5.Top = 9240
		Me.Tent1_5.Width = 1005
		'
		' Tent1_1
		'
		Me.Tent1_1.Name = "Tent1_1"
		Me.Tent1_1.ParentForm = Me
		Me.Tent1_1.Name6 = "Tent1_1"
		Me.Tent1_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent1_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent1_1.Height = 600
		Me.Tent1_1.Left = 3840
		Me.Tent1_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent1_1.Top = 9240
		Me.Tent1_1.Width = 1005
		'
		' Tent2_2
		'
		Me.Tent2_2.Name = "Tent2_2"
		Me.Tent2_2.ParentForm = Me
		Me.Tent2_2.Name6 = "Tent2_2"
		Me.Tent2_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent2_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent2_2.Height = 600
		Me.Tent2_2.Left = 4560
		Me.Tent2_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent2_2.Top = 8520
		Me.Tent2_2.Width = 1005
		'
		' Tent2_3
		'
		Me.Tent2_3.Name = "Tent2_3"
		Me.Tent2_3.ParentForm = Me
		Me.Tent2_3.Name6 = "Tent2_3"
		Me.Tent2_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent2_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent2_3.Height = 600
		Me.Tent2_3.Left = 5280
		Me.Tent2_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent2_3.Top = 8520
		Me.Tent2_3.Width = 1005
		'
		' Tent2_4
		'
		Me.Tent2_4.Name = "Tent2_4"
		Me.Tent2_4.ParentForm = Me
		Me.Tent2_4.Name6 = "Tent2_4"
		Me.Tent2_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent2_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent2_4.Height = 600
		Me.Tent2_4.Left = 6000
		Me.Tent2_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent2_4.Top = 8520
		Me.Tent2_4.Width = 1005
		'
		' Tent2_5
		'
		Me.Tent2_5.Name = "Tent2_5"
		Me.Tent2_5.ParentForm = Me
		Me.Tent2_5.Name6 = "Tent2_5"
		Me.Tent2_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent2_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent2_5.Height = 600
		Me.Tent2_5.Left = 6720
		Me.Tent2_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent2_5.Top = 8520
		Me.Tent2_5.Width = 1005
		'
		' Tent2_1
		'
		Me.Tent2_1.Name = "Tent2_1"
		Me.Tent2_1.ParentForm = Me
		Me.Tent2_1.Name6 = "Tent2_1"
		Me.Tent2_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent2_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent2_1.Height = 600
		Me.Tent2_1.Left = 3840
		Me.Tent2_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent2_1.Top = 8520
		Me.Tent2_1.Width = 1005
		'
		' Tent3_2
		'
		Me.Tent3_2.Name = "Tent3_2"
		Me.Tent3_2.ParentForm = Me
		Me.Tent3_2.Name6 = "Tent3_2"
		Me.Tent3_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent3_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent3_2.Height = 600
		Me.Tent3_2.Left = 4560
		Me.Tent3_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent3_2.Top = 7800
		Me.Tent3_2.Width = 1005
		'
		' Tent3_3
		'
		Me.Tent3_3.Name = "Tent3_3"
		Me.Tent3_3.ParentForm = Me
		Me.Tent3_3.Name6 = "Tent3_3"
		Me.Tent3_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent3_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent3_3.Height = 600
		Me.Tent3_3.Left = 5280
		Me.Tent3_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent3_3.Top = 7800
		Me.Tent3_3.Width = 1005
		'
		' Tent3_4
		'
		Me.Tent3_4.Name = "Tent3_4"
		Me.Tent3_4.ParentForm = Me
		Me.Tent3_4.Name6 = "Tent3_4"
		Me.Tent3_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent3_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent3_4.Height = 600
		Me.Tent3_4.Left = 6000
		Me.Tent3_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent3_4.Top = 7800
		Me.Tent3_4.Width = 1005
		'
		' Tent3_5
		'
		Me.Tent3_5.Name = "Tent3_5"
		Me.Tent3_5.ParentForm = Me
		Me.Tent3_5.Name6 = "Tent3_5"
		Me.Tent3_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent3_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent3_5.Height = 600
		Me.Tent3_5.Left = 6720
		Me.Tent3_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent3_5.Top = 7800
		Me.Tent3_5.Width = 1005
		'
		' Tent3_1
		'
		Me.Tent3_1.Name = "Tent3_1"
		Me.Tent3_1.ParentForm = Me
		Me.Tent3_1.Name6 = "Tent3_1"
		Me.Tent3_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent3_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent3_1.Height = 600
		Me.Tent3_1.Left = 3840
		Me.Tent3_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent3_1.Top = 7800
		Me.Tent3_1.Width = 1005
		'
		' Tent4_2
		'
		Me.Tent4_2.Name = "Tent4_2"
		Me.Tent4_2.ParentForm = Me
		Me.Tent4_2.Name6 = "Tent4_2"
		Me.Tent4_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent4_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent4_2.Height = 600
		Me.Tent4_2.Left = 4560
		Me.Tent4_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent4_2.Top = 7080
		Me.Tent4_2.Width = 1005
		'
		' Tent4_3
		'
		Me.Tent4_3.Name = "Tent4_3"
		Me.Tent4_3.ParentForm = Me
		Me.Tent4_3.Name6 = "Tent4_3"
		Me.Tent4_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent4_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent4_3.Height = 600
		Me.Tent4_3.Left = 5280
		Me.Tent4_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent4_3.Top = 7080
		Me.Tent4_3.Width = 1005
		'
		' Tent4_4
		'
		Me.Tent4_4.Name = "Tent4_4"
		Me.Tent4_4.ParentForm = Me
		Me.Tent4_4.Name6 = "Tent4_4"
		Me.Tent4_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent4_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent4_4.Height = 600
		Me.Tent4_4.Left = 6000
		Me.Tent4_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent4_4.Top = 7080
		Me.Tent4_4.Width = 1005
		'
		' Tent4_5
		'
		Me.Tent4_5.Name = "Tent4_5"
		Me.Tent4_5.ParentForm = Me
		Me.Tent4_5.Name6 = "Tent4_5"
		Me.Tent4_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent4_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent4_5.Height = 600
		Me.Tent4_5.Left = 6720
		Me.Tent4_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent4_5.Top = 7080
		Me.Tent4_5.Width = 1005
		'
		' Tent4_1
		'
		Me.Tent4_1.Name = "Tent4_1"
		Me.Tent4_1.ParentForm = Me
		Me.Tent4_1.Name6 = "Tent4_1"
		Me.Tent4_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent4_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent4_1.Height = 600
		Me.Tent4_1.Left = 3840
		Me.Tent4_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent4_1.Top = 7080
		Me.Tent4_1.Width = 1005
		'
		' Tent5_2
		'
		Me.Tent5_2.Name = "Tent5_2"
		Me.Tent5_2.ParentForm = Me
		Me.Tent5_2.Name6 = "Tent5_2"
		Me.Tent5_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent5_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent5_2.Height = 600
		Me.Tent5_2.Left = 4560
		Me.Tent5_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent5_2.Top = 6360
		Me.Tent5_2.Width = 1005
		'
		' Tent5_3
		'
		Me.Tent5_3.Name = "Tent5_3"
		Me.Tent5_3.ParentForm = Me
		Me.Tent5_3.Name6 = "Tent5_3"
		Me.Tent5_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent5_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent5_3.Height = 600
		Me.Tent5_3.Left = 5280
		Me.Tent5_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent5_3.Top = 6360
		Me.Tent5_3.Width = 1005
		'
		' Tent5_4
		'
		Me.Tent5_4.Name = "Tent5_4"
		Me.Tent5_4.ParentForm = Me
		Me.Tent5_4.Name6 = "Tent5_4"
		Me.Tent5_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent5_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent5_4.Height = 600
		Me.Tent5_4.Left = 6000
		Me.Tent5_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent5_4.Top = 6360
		Me.Tent5_4.Width = 1005
		'
		' Tent5_5
		'
		Me.Tent5_5.Name = "Tent5_5"
		Me.Tent5_5.ParentForm = Me
		Me.Tent5_5.Name6 = "Tent5_5"
		Me.Tent5_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent5_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent5_5.Height = 600
		Me.Tent5_5.Left = 6720
		Me.Tent5_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent5_5.Top = 6360
		Me.Tent5_5.Width = 1005
		'
		' Tent5_1
		'
		Me.Tent5_1.Name = "Tent5_1"
		Me.Tent5_1.ParentForm = Me
		Me.Tent5_1.Name6 = "Tent5_1"
		Me.Tent5_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent5_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent5_1.Height = 600
		Me.Tent5_1.Left = 3840
		Me.Tent5_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent5_1.Top = 6360
		Me.Tent5_1.Width = 1005
		'
		' Tent6_2
		'
		Me.Tent6_2.Name = "Tent6_2"
		Me.Tent6_2.ParentForm = Me
		Me.Tent6_2.Name6 = "Tent6_2"
		Me.Tent6_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent6_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent6_2.Height = 600
		Me.Tent6_2.Left = 4560
		Me.Tent6_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent6_2.Top = 5640
		Me.Tent6_2.Width = 1005
		'
		' Tent6_3
		'
		Me.Tent6_3.Name = "Tent6_3"
		Me.Tent6_3.ParentForm = Me
		Me.Tent6_3.Name6 = "Tent6_3"
		Me.Tent6_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent6_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent6_3.Height = 600
		Me.Tent6_3.Left = 5280
		Me.Tent6_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent6_3.Top = 5640
		Me.Tent6_3.Width = 1005
		'
		' Tent6_4
		'
		Me.Tent6_4.Name = "Tent6_4"
		Me.Tent6_4.ParentForm = Me
		Me.Tent6_4.Name6 = "Tent6_4"
		Me.Tent6_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent6_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent6_4.Height = 600
		Me.Tent6_4.Left = 6000
		Me.Tent6_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent6_4.Top = 5640
		Me.Tent6_4.Width = 1005
		'
		' Tent6_5
		'
		Me.Tent6_5.Name = "Tent6_5"
		Me.Tent6_5.ParentForm = Me
		Me.Tent6_5.Name6 = "Tent6_5"
		Me.Tent6_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent6_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent6_5.Height = 600
		Me.Tent6_5.Left = 6720
		Me.Tent6_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent6_5.Top = 5640
		Me.Tent6_5.Width = 1005
		'
		' Tent6_1
		'
		Me.Tent6_1.Name = "Tent6_1"
		Me.Tent6_1.ParentForm = Me
		Me.Tent6_1.Name6 = "Tent6_1"
		Me.Tent6_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent6_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent6_1.Height = 600
		Me.Tent6_1.Left = 3840
		Me.Tent6_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent6_1.Top = 5640
		Me.Tent6_1.Width = 1005
		'
		' Tent7_2
		'
		Me.Tent7_2.Name = "Tent7_2"
		Me.Tent7_2.ParentForm = Me
		Me.Tent7_2.Name6 = "Tent7_2"
		Me.Tent7_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent7_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent7_2.Height = 600
		Me.Tent7_2.Left = 4560
		Me.Tent7_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent7_2.Top = 4920
		Me.Tent7_2.Width = 1005
		'
		' Tent7_3
		'
		Me.Tent7_3.Name = "Tent7_3"
		Me.Tent7_3.ParentForm = Me
		Me.Tent7_3.Name6 = "Tent7_3"
		Me.Tent7_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent7_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent7_3.Height = 600
		Me.Tent7_3.Left = 5280
		Me.Tent7_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent7_3.Top = 4920
		Me.Tent7_3.Width = 1005
		'
		' Tent7_4
		'
		Me.Tent7_4.Name = "Tent7_4"
		Me.Tent7_4.ParentForm = Me
		Me.Tent7_4.Name6 = "Tent7_4"
		Me.Tent7_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent7_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent7_4.Height = 600
		Me.Tent7_4.Left = 6000
		Me.Tent7_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent7_4.Top = 4920
		Me.Tent7_4.Width = 1005
		'
		' Tent7_5
		'
		Me.Tent7_5.Name = "Tent7_5"
		Me.Tent7_5.ParentForm = Me
		Me.Tent7_5.Name6 = "Tent7_5"
		Me.Tent7_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent7_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent7_5.Height = 600
		Me.Tent7_5.Left = 6720
		Me.Tent7_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent7_5.Top = 4920
		Me.Tent7_5.Width = 1005
		'
		' Tent7_1
		'
		Me.Tent7_1.Name = "Tent7_1"
		Me.Tent7_1.ParentForm = Me
		Me.Tent7_1.Name6 = "Tent7_1"
		Me.Tent7_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent7_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent7_1.Height = 600
		Me.Tent7_1.Left = 3840
		Me.Tent7_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent7_1.Top = 4920
		Me.Tent7_1.Width = 1005
		'
		' Tent8_2
		'
		Me.Tent8_2.Name = "Tent8_2"
		Me.Tent8_2.ParentForm = Me
		Me.Tent8_2.Name6 = "Tent8_2"
		Me.Tent8_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent8_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent8_2.Height = 600
		Me.Tent8_2.Left = 4560
		Me.Tent8_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent8_2.Top = 4200
		Me.Tent8_2.Width = 1005
		'
		' Tent8_3
		'
		Me.Tent8_3.Name = "Tent8_3"
		Me.Tent8_3.ParentForm = Me
		Me.Tent8_3.Name6 = "Tent8_3"
		Me.Tent8_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent8_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent8_3.Height = 600
		Me.Tent8_3.Left = 5280
		Me.Tent8_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent8_3.Top = 4200
		Me.Tent8_3.Width = 1005
		'
		' Tent8_4
		'
		Me.Tent8_4.Name = "Tent8_4"
		Me.Tent8_4.ParentForm = Me
		Me.Tent8_4.Name6 = "Tent8_4"
		Me.Tent8_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent8_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent8_4.Height = 600
		Me.Tent8_4.Left = 6000
		Me.Tent8_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent8_4.Top = 4200
		Me.Tent8_4.Width = 1005
		'
		' Tent8_5
		'
		Me.Tent8_5.Name = "Tent8_5"
		Me.Tent8_5.ParentForm = Me
		Me.Tent8_5.Name6 = "Tent8_5"
		Me.Tent8_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent8_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent8_5.Height = 600
		Me.Tent8_5.Left = 6720
		Me.Tent8_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent8_5.Top = 4200
		Me.Tent8_5.Width = 1005
		'
		' Tent8_1
		'
		Me.Tent8_1.Name = "Tent8_1"
		Me.Tent8_1.ParentForm = Me
		Me.Tent8_1.Name6 = "Tent8_1"
		Me.Tent8_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent8_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent8_1.Height = 600
		Me.Tent8_1.Left = 3840
		Me.Tent8_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent8_1.Top = 4200
		Me.Tent8_1.Width = 1005
		'
		' Tent9_2
		'
		Me.Tent9_2.Name = "Tent9_2"
		Me.Tent9_2.ParentForm = Me
		Me.Tent9_2.Name6 = "Tent9_2"
		Me.Tent9_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent9_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent9_2.Height = 600
		Me.Tent9_2.Left = 4560
		Me.Tent9_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent9_2.Top = 3480
		Me.Tent9_2.Width = 1005
		'
		' Tent9_3
		'
		Me.Tent9_3.Name = "Tent9_3"
		Me.Tent9_3.ParentForm = Me
		Me.Tent9_3.Name6 = "Tent9_3"
		Me.Tent9_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent9_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent9_3.Height = 600
		Me.Tent9_3.Left = 5280
		Me.Tent9_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent9_3.Top = 3480
		Me.Tent9_3.Width = 1005
		'
		' Tent9_4
		'
		Me.Tent9_4.Name = "Tent9_4"
		Me.Tent9_4.ParentForm = Me
		Me.Tent9_4.Name6 = "Tent9_4"
		Me.Tent9_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent9_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent9_4.Height = 600
		Me.Tent9_4.Left = 6000
		Me.Tent9_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent9_4.Top = 3480
		Me.Tent9_4.Width = 1005
		'
		' Tent9_5
		'
		Me.Tent9_5.Name = "Tent9_5"
		Me.Tent9_5.ParentForm = Me
		Me.Tent9_5.Name6 = "Tent9_5"
		Me.Tent9_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent9_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent9_5.Height = 600
		Me.Tent9_5.Left = 6720
		Me.Tent9_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent9_5.Top = 3480
		Me.Tent9_5.Width = 1005
		'
		' Tent9_1
		'
		Me.Tent9_1.Name = "Tent9_1"
		Me.Tent9_1.ParentForm = Me
		Me.Tent9_1.Name6 = "Tent9_1"
		Me.Tent9_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent9_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent9_1.Height = 600
		Me.Tent9_1.Left = 3840
		Me.Tent9_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent9_1.Top = 3480
		Me.Tent9_1.Width = 1005
		'
		' Tent10_2
		'
		Me.Tent10_2.Name = "Tent10_2"
		Me.Tent10_2.ParentForm = Me
		Me.Tent10_2.Name6 = "Tent10_2"
		Me.Tent10_2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent10_2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent10_2.Height = 600
		Me.Tent10_2.Left = 4560
		Me.Tent10_2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent10_2.Top = 2760
		Me.Tent10_2.Width = 1005
		'
		' Tent10_3
		'
		Me.Tent10_3.Name = "Tent10_3"
		Me.Tent10_3.ParentForm = Me
		Me.Tent10_3.Name6 = "Tent10_3"
		Me.Tent10_3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent10_3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent10_3.Height = 600
		Me.Tent10_3.Left = 5280
		Me.Tent10_3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent10_3.Top = 2760
		Me.Tent10_3.Width = 1005
		'
		' Tent10_4
		'
		Me.Tent10_4.Name = "Tent10_4"
		Me.Tent10_4.ParentForm = Me
		Me.Tent10_4.Name6 = "Tent10_4"
		Me.Tent10_4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent10_4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent10_4.Height = 600
		Me.Tent10_4.Left = 6000
		Me.Tent10_4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent10_4.Top = 2760
		Me.Tent10_4.Width = 1005
		'
		' Tent10_5
		'
		Me.Tent10_5.Name = "Tent10_5"
		Me.Tent10_5.ParentForm = Me
		Me.Tent10_5.Name6 = "Tent10_5"
		Me.Tent10_5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent10_5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent10_5.Height = 600
		Me.Tent10_5.Left = 6720
		Me.Tent10_5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent10_5.Top = 2760
		Me.Tent10_5.Width = 1005
		'
		' Tent10_1
		'
		Me.Tent10_1.Name = "Tent10_1"
		Me.Tent10_1.ParentForm = Me
		Me.Tent10_1.Name6 = "Tent10_1"
		Me.Tent10_1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.Tent10_1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.Tent10_1.Height = 600
		Me.Tent10_1.Left = 3840
		Me.Tent10_1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.Tent10_1.Top = 2760
		Me.Tent10_1.Width = 1005
		'
		' C5
		'
		Me.C5.Name = "C5"
		Me.C5.ParentForm = Me
		Me.C5.Name6 = "C5"
		Me.C5.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.C5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.C5.Height = 615
		Me.C5.Left = 6960
		Me.C5.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.C5.Top = 480
		Me.C5.Width = 855
		'
		' C4
		'
		Me.C4.Name = "C4"
		Me.C4.ParentForm = Me
		Me.C4.Name6 = "C4"
		Me.C4.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.C4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.C4.Height = 615
		Me.C4.Left = 5880
		Me.C4.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.C4.Top = 480
		Me.C4.Width = 855
		'
		' C3
		'
		Me.C3.Name = "C3"
		Me.C3.ParentForm = Me
		Me.C3.Name6 = "C3"
		Me.C3.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.C3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.C3.Height = 615
		Me.C3.Left = 4800
		Me.C3.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.C3.Top = 480
		Me.C3.Width = 855
		'
		' C2
		'
		Me.C2.Name = "C2"
		Me.C2.ParentForm = Me
		Me.C2.Name6 = "C2"
		Me.C2.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.C2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.C2.Height = 615
		Me.C2.Left = 3720
		Me.C2.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.C2.Top = 480
		Me.C2.Width = 855
		'
		' C1
		'
		Me.C1.Name = "C1"
		Me.C1.ParentForm = Me
		Me.C1.Name6 = "C1"
		Me.C1.BackColor = FromOleColor6(CInt(&H8000000A))
		Me.C1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Opaque
		Me.C1.Height = 615
		Me.C1.Left = 2640
		Me.C1.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeOval
		Me.C1.Top = 480
		Me.C1.Width = 855
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
		'
		' mnuNew
		'
		Me.mnuNew.Name = "mnuNew"
		Me.mnuNew.Caption = "&Nuova partita"
		Me.mnuNew.Shortcut = Keys.F2
		'
		' mnuVediSoluz
		'
		Me.mnuVediSoluz.Name = "mnuVediSoluz"
		Me.mnuVediSoluz.Caption = "&Vedi soluzione"
		Me.mnuVediSoluz.Shortcut = Keys.Control Or Keys.S
		'
		' mnuSpazio
		'
		Me.mnuSpazio.Name = "mnuSpazio"
		'
		' mnuEsci
		'
		Me.mnuEsci.Name = "mnuEsci"
		Me.mnuEsci.Caption = "&Esci"
		'
		' mnuAiuto
		'
		Me.mnuAiuto.Name = "mnuAiuto"
		Me.mnuAiuto.Caption = "&Help"
		'
		' mnuHelp
		'
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Caption = "&Help"
		Me.mnuHelp.Shortcut = Keys.F1
		'
		' mnuSpazio2
		'
		Me.mnuSpazio2.Name = "mnuSpazio2"
		'
		' mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Caption = "&About..."
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.BackColor = FromOleColor6(CInt(&H8000000D))
		Me.Caption = "SUPER MASTER MIND"
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(4, 50)
		Me.ClientSize = New System.Drawing.Size(676, 691)

		Me.Controls.Add(Nuovo)
		Me.Controls.Add(Esci)
		Me.Controls.Add(Soluzione)
		Me.Controls.Add(Command12)
		Me.Controls.Add(Command11)
		Me.Controls.Add(Command10)
		Me.Controls.Add(Command9)
		Me.Controls.Add(Command8)
		Me.Controls.Add(Command7)
		Me.Controls.Add(Command6)
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Soluz)
		Me.Controls.Add(lblNew)
		Me.Controls.Add(LabTent12_1)
		Me.Controls.Add(LabTent12_2)
		Me.Controls.Add(LabTent12_3)
		Me.Controls.Add(LabTent12_4)
		Me.Controls.Add(LabTent12_5)
		Me.Controls.Add(LabTent11_1)
		Me.Controls.Add(LabTent11_2)
		Me.Controls.Add(LabTent11_3)
		Me.Controls.Add(LabTent11_4)
		Me.Controls.Add(LabTent11_5)
		Me.Controls.Add(msg)
		Me.Controls.Add(ColScelto)
		Me.Controls.Add(R5)
		Me.Controls.Add(R4)
		Me.Controls.Add(R3)
		Me.Controls.Add(R2)
		Me.Controls.Add(R1)
		Me.Controls.Add(Bianco)
		Me.Controls.Add(Nero)
		Me.Controls.Add(Verde)
		Me.Controls.Add(Rosso)
		Me.Controls.Add(Giallo)
		Me.Controls.Add(Blu)
		Me.Controls.Add(LabTent10_5)
		Me.Controls.Add(LabTent10_4)
		Me.Controls.Add(LabTent10_3)
		Me.Controls.Add(LabTent10_2)
		Me.Controls.Add(LabTent10_1)
		Me.Controls.Add(LabTent9_5)
		Me.Controls.Add(LabTent9_4)
		Me.Controls.Add(LabTent9_3)
		Me.Controls.Add(LabTent9_2)
		Me.Controls.Add(LabTent9_1)
		Me.Controls.Add(LabTent8_5)
		Me.Controls.Add(LabTent8_4)
		Me.Controls.Add(LabTent8_3)
		Me.Controls.Add(LabTent8_2)
		Me.Controls.Add(LabTent8_1)
		Me.Controls.Add(LabTent7_5)
		Me.Controls.Add(LabTent7_4)
		Me.Controls.Add(LabTent7_3)
		Me.Controls.Add(LabTent7_2)
		Me.Controls.Add(LabTent7_1)
		Me.Controls.Add(LabTent6_5)
		Me.Controls.Add(LabTent6_4)
		Me.Controls.Add(LabTent6_3)
		Me.Controls.Add(LabTent6_2)
		Me.Controls.Add(LabTent6_1)
		Me.Controls.Add(LabTent5_5)
		Me.Controls.Add(LabTent5_4)
		Me.Controls.Add(LabTent5_3)
		Me.Controls.Add(LabTent5_2)
		Me.Controls.Add(LabTent5_1)
		Me.Controls.Add(LabTent4_5)
		Me.Controls.Add(LabTent4_4)
		Me.Controls.Add(LabTent4_3)
		Me.Controls.Add(LabTent4_2)
		Me.Controls.Add(LabTent4_1)
		Me.Controls.Add(LabTent3_5)
		Me.Controls.Add(LabTent3_4)
		Me.Controls.Add(LabTent3_3)
		Me.Controls.Add(LabTent3_2)
		Me.Controls.Add(LabTent3_1)
		Me.Controls.Add(LabTent2_5)
		Me.Controls.Add(LabTent2_4)
		Me.Controls.Add(LabTent2_3)
		Me.Controls.Add(LabTent2_2)
		Me.Controls.Add(LabTent2_1)
		Me.Controls.Add(LabTent1_5)
		Me.Controls.Add(LabTent1_4)
		Me.Controls.Add(LabTent1_3)
		Me.Controls.Add(LabTent1_2)
		Me.Controls.Add(LabTent1_1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuNew)
		Me.mnuFile.DropDownItems.Add(mnuVediSoluz)
		Me.mnuFile.DropDownItems.Add(mnuSpazio)
		Me.mnuFile.DropDownItems.Add(mnuEsci)
		Me.MenuStrip1.Items.Add(mnuAiuto)
		Me.mnuAiuto.DropDownItems.Add(mnuHelp)
		Me.mnuAiuto.DropDownItems.Add(mnuSpazio2)
		Me.mnuAiuto.DropDownItems.Add(mnuAbout)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.Line4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent12_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent12_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent12_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent12_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent12_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent11_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent11_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent11_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent11_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent11_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent12_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent12_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent12_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent12_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent12_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent11_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent11_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent11_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent11_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent11_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent1_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent1_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent1_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent1_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent2_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent2_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent2_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent2_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent2_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent3_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent3_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent3_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent3_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent3_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent4_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent4_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent4_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent4_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent4_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent5_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent5_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent5_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent5_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent5_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent6_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent6_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent6_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent6_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent6_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent7_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent7_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent7_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent7_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent7_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent8_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent8_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent8_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent8_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent8_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent9_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent9_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent9_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent9_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent9_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent10_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent10_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent10_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent10_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RispTent10_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Col6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent1_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent1_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent1_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent1_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent2_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent2_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent2_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent2_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent2_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent3_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent3_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent3_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent3_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent3_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent4_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent4_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent4_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent4_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent4_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent5_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent5_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent5_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent5_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent5_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent6_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent6_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent6_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent6_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent6_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent7_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent7_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent7_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent7_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent7_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent8_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent8_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent8_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent8_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent8_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent9_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent9_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent9_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent9_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent9_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent10_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent10_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent10_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent10_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Tent10_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
