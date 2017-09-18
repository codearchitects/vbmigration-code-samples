<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDocument
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
	Public WithEvents rtfText As CodeArchitects.VB6Library.VB6RichTextBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocument))
		Me.rtfText = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.SuspendLayout()
		'
		' rtfText
		'
		Me.rtfText.Name = "rtfText"
		Me.rtfText.Size = New System.Drawing.Size(200, 133)
		Me.rtfText.Location = New System.Drawing.Point(7, 8)
		Me.rtfText.TabIndex = 0
		Me.rtfText.Enabled = True
		Me.rtfText.HideSelection = False
		Me.rtfText.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfBoth
		Me.rtfText.TextRTF = "{\rtf1\ansi\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "{\colortbl\red0\green0\blue0;}" & ControlChars.CrLf & "\deflang1040\pard\plain\f2\fs17 " & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		'
		' frmDocument
		'
		Me.Name = "frmDocument"
		Me.Caption = "frmDocument"
		Me.MDIChild = -1
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(312, 213)

		Me.Controls.Add(rtfText)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
