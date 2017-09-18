' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' this routine is actually useful only at design time
	' and isn't necessarily included in the compiled program
	' run this sub from the Immediate window
	
	Public Sub CreateLicenseFile()
	' UPGRADE_INFO (#0501): The 'CreateLicenseFile' member isn't used anywhere in current application.
		FileOpen6(1, App6.Path & "\MSWLess.key", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		FilePrintLine6(1, Licenses6.Add("MSWLess.WLText"))
		FileClose6(1)
	End Sub

End Module
