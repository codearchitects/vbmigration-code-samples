<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class OptionsFrm
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
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents LocationTxt As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents LoadFile As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents ChkLoop As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Slider1 As CodeArchitects.VB6Library.VB6Slider
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents okBtn As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents CancelBtn As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OptionsFrm))
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.LocationTxt = New CodeArchitects.VB6Library.VB6TextBox()
		Me.LoadFile = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.ChkLoop = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Slider1 = New CodeArchitects.VB6Library.VB6Slider()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.okBtn = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.CancelBtn = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		CType(Me.Slider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(361, 73)
		Me.Frame2.Location = New System.Drawing.Point(112, 96)
		Me.Frame2.Caption = "Frame2"
		Me.Frame2.TabIndex = 9
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' LocationTxt
		'
		Me.LocationTxt.Name = "LocationTxt"
		Me.LocationTxt.Size = New System.Drawing.Size(329, 19)
		Me.LocationTxt.Location = New System.Drawing.Point(16, 24)
		Me.LocationTxt.TabIndex = 11
		'
		' LoadFile
		'
		Me.LoadFile.Name = "LoadFile"
		Me.LoadFile.Size = New System.Drawing.Size(65, 17)
		Me.LoadFile.Location = New System.Drawing.Point(280, 48)
		Me.LoadFile.Caption = "Locate"
		Me.LoadFile.TabIndex = 10
		Me.LoadFile.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(137, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 0)
		Me.Label4.Caption = "Location of Picture Module"
		Me.Label4.TabIndex = 12
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(361, 81)
		Me.Frame1.Location = New System.Drawing.Point(112, 8)
		Me.Frame1.Caption = "Options"
		Me.Frame1.TabIndex = 3
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ChkLoop
		'
		Me.ChkLoop.Name = "ChkLoop"
		Me.ChkLoop.Size = New System.Drawing.Size(97, 17)
		Me.ChkLoop.Location = New System.Drawing.Point(16, 48)
		Me.ChkLoop.Caption = "Continuous Play"
		Me.ChkLoop.TabIndex = 8
		Me.ChkLoop.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Slider1
		'
		Me.Slider1.Name = "Slider1"
		Me.Slider1.Size = New System.Drawing.Size(273, 17)
		Me.Slider1.Location = New System.Drawing.Point(40, 24)
		Me.Slider1.TabIndex = 4
		Me.Slider1.LargeChange = 10
		Me.Slider1.Min = 1
		Me.Slider1.Max = 50
		Me.Slider1.Value = 1
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(25, 17)
		Me.Label3.Location = New System.Drawing.Point(320, 24)
		Me.Label3.Caption = "Slow"
		Me.Label3.TabIndex = 7
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(25, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 24)
		Me.Label2.Caption = "Fast"
		Me.Label2.TabIndex = 6
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 0)
		Me.Label1.Caption = "Hand Speed"
		Me.Label1.TabIndex = 5
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' okBtn
		'
		Me.okBtn.Name = "okBtn"
		Me.okBtn.Size = New System.Drawing.Size(73, 25)
		Me.okBtn.Location = New System.Drawing.Point(312, 200)
		Me.okBtn.Caption = "Ok"
		Me.okBtn.TabIndex = 2
		Me.okBtn.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' CancelBtn
		'
		Me.CancelBtn.Name = "CancelBtn"
		Me.CancelBtn.Size = New System.Drawing.Size(73, 25)
		Me.CancelBtn.Location = New System.Drawing.Point(400, 200)
		Me.CancelBtn.Caption = "Cancel"
		Me.CancelBtn.TabIndex = 1
		Me.CancelBtn.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(97, 217)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.Picture = CType(resources.GetObject("Picture1.Picture"), System.Drawing.Image)
		Me.Picture1.TabIndex = 0
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' OptionsFrm
		'
		Me.Name = "OptionsFrm"
		Me.Caption = "Type-N-Sign  (Options Menu)"
		Me.Icon = Nothing
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(483, 231)

		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(LocationTxt)
		Me.Frame2.Controls.Add(LoadFile)
		Me.Frame2.Controls.Add(Label4)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(ChkLoop)
		Me.Frame1.Controls.Add(Slider1)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Controls.Add(okBtn)
		Me.Controls.Add(CancelBtn)
		Me.Controls.Add(Picture1)
		CType(Me.Slider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
