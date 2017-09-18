<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ConnectFRM
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
	Public WithEvents nicknameTXT As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Winsock As CodeArchitects.VB6Library.VB6Winsock
	Public WithEvents ConnectCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents IPtxt As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents ClientCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents ServerCMD As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents YouripLBL As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ConnectFRM))
		Me.nicknameTXT = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Winsock = New CodeArchitects.VB6Library.VB6Winsock()
		Me.ConnectCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.IPtxt = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.ClientCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.ServerCMD = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.YouripLBL = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' nicknameTXT
		'
		Me.nicknameTXT.Name = "nicknameTXT"
		Me.nicknameTXT.Size = New System.Drawing.Size(145, 19)
		Me.nicknameTXT.Location = New System.Drawing.Point(8, 80)
		Me.nicknameTXT.MaxLength = 20
		Me.nicknameTXT.TabIndex = 4
		Me.nicknameTXT.Text = "NickName here"
		'
		' Winsock
		'
		Me.Winsock.Name = "Winsock"
		Me.Winsock.ParentForm = Me
		Me.Winsock.Name6 = "Winsock"
		'
		' ConnectCMD
		'
		Me.ConnectCMD.Name = "ConnectCMD"
		Me.ConnectCMD.Size = New System.Drawing.Size(65, 25)
		Me.ConnectCMD.Location = New System.Drawing.Point(48, 128)
		Me.ConnectCMD.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.ConnectCMD.Caption = "&Connect"
		Me.ConnectCMD.TabIndex = 5
		Me.AcceptButton = Me.ConnectCMD
		Me.ConnectCMD.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' IPtxt
		'
		Me.IPtxt.Name = "IPtxt"
		Me.IPtxt.Size = New System.Drawing.Size(145, 19)
		Me.IPtxt.Location = New System.Drawing.Point(8, 56)
		Me.IPtxt.TabIndex = 3
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(161, 49)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.Frame1.TabIndex = 0
		'
		' ClientCMD
		'
		Me.ClientCMD.Name = "ClientCMD"
		Me.ClientCMD.Size = New System.Drawing.Size(65, 25)
		Me.ClientCMD.Location = New System.Drawing.Point(88, 16)
		Me.ClientCMD.Caption = "C&lient"
		Me.ClientCMD.TabIndex = 2
		Me.ClientCMD.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ServerCMD
		'
		Me.ServerCMD.Name = "ServerCMD"
		Me.ServerCMD.Size = New System.Drawing.Size(65, 25)
		Me.ServerCMD.Location = New System.Drawing.Point(8, 16)
		Me.ServerCMD.Caption = "&Server"
		Me.ServerCMD.TabIndex = 1
		Me.ServerCMD.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(57, 9)
		Me.Label1.Location = New System.Drawing.Point(0, 144)
		Me.Label1.Font = New System.Drawing.Font("Arial", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "© 2000 One"
		Me.Label1.TabIndex = 7
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' YouripLBL
		'
		Me.YouripLBL.Name = "YouripLBL"
		Me.YouripLBL.Size = New System.Drawing.Size(145, 17)
		Me.YouripLBL.Location = New System.Drawing.Point(8, 104)
		Me.YouripLBL.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.YouripLBL.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.YouripLBL.TabIndex = 6
		Me.YouripLBL.AutoSize = False
		Me.YouripLBL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ConnectFRM
		'
		Me.Name = "ConnectFRM"
		Me.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Connect as..."
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(160, 156)

		Me.Controls.Add(nicknameTXT)
		Me.Controls.Add(ConnectCMD)
		Me.Controls.Add(IPtxt)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(ClientCMD)
		Me.Frame1.Controls.Add(ServerCMD)
		Me.Controls.Add(Label1)
		Me.Controls.Add(YouripLBL)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
