' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CTracer
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' class CTracer - complete source code
	Private m_procname As String = ""
	Private m_enterTime As Single
	
	Public Sub Enter(ByRef procname As String)
		' remember procedure name and start time
		m_procname = procname
		m_enterTime = Timer6
		' print the log
		Debug.WriteLine("Enter " & m_procname)
	End Sub

	Private Sub Class_Terminate_VB6()
		' print the log when the procedure is exited
		Debug.WriteLine("Exit " & m_procname & " - sec. " & (Timer6 - m_enterTime))
	End Sub

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub

End Class
