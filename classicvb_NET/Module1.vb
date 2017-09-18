' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	Public fMainForm As frmMain
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	<STAThread()> _
	Public Sub Main()
		If InitializeFormChaining6() Then Exit Sub
		
		frmSplash.Show()
		frmSplash.Refresh()
		fMainForm = New frmMain()
		Load6(fMainForm)
		Unload6(frmSplash)
		fMainForm.Show()
	End Sub

End Module
