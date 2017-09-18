' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' API declares
	' UPGRADE_INFO (#0531): You can replace calls to the 'WaitForSingleObject' unamanged method with the following .NET member(s): System.Threading.WaitHandle.WaitOne
	Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'OpenProcess' unamanged method with the following .NET member(s): System.Diagnostics.Process.GetProcessById
	Private Declare Function OpenProcess Lib "kernel32" (ByVal dwAccess As Integer, ByVal fInherit As Short, ByVal hObject As Integer) As Integer
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	
	' wait for a number of milliseconds and return the running status of a process
	' if argument is omitted, wait until the process terminates
	
	Public Function WaitForProcess(ByRef taskId As Integer, Optional ByRef milliseconds As Integer = -1) As Boolean
	' UPGRADE_INFO (#0551): The 'taskId' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'milliseconds' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim procHandle As Integer = OpenProcess(&H100000, CShort(True), taskId)
		' get the process handle
		' check for its signaled status, return to caller
		Dim res As Integer = WaitForSingleObject(procHandle, milliseconds)
		WaitForProcess = (res <> 0 And res <> -1)
		' close the handle
		CloseHandle(procHandle)
	End Function

End Module
