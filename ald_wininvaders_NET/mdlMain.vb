' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module mdlMain

	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	<STAThread()> _
	Public Sub main()
		frmSplash.Show(VBRUN.FormShowConstants.vbModal)
		frmMain.Show()
	End Sub

End Module
