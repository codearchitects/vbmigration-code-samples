' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CMouse
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------------------------
	' The CMOUSE class
	'
	' This class lets you set the mouse pointer to any
	' shape, and it will automatically restore the
	' original pointer when the procedure exits
	'-------------------------------------------------

	' this holds the original mouse cursor
	Private m_OldPointer As Object
	
	' enforce a new mouse pointer
	
	Public Sub SetPointer(Optional ByRef NewPointer As VBRUN.MousePointerConstants = VBRUN.MousePointerConstants.vbHourglass)
		' only store it once
		If IsEmpty6(m_OldPointer) Then 
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			m_OldPointer = Screen6.MousePointer
		End If
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = NewPointer
	End Sub

	' automatically restore the original pointer when
	' the object goes out of scope
	
	Private Sub Class_Terminate_VB6()
		' only if SetPointer had been actually called
		If Not IsEmpty6(m_OldPointer) Then 
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			Screen6.MousePointer = m_OldPointer
		End If
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
