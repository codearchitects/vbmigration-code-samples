' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<System.Runtime.InteropServices.ProgID("MsgHookSvr.MsgHook")> _ 
Public Class MsgHook
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Shared Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	Public Event BeforeMessage(ByRef hWnd As Integer, ByRef uMsg As Integer, ByRef wParam As Integer, ByRef lParam As Integer, ByRef retValue As Integer, ByRef Cancel As Boolean)
	Public Event AfterMessage(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer, ByRef retValue As Integer)
	
	' member variable for hWnd property
	Private m_hWnd As Integer
	' member variable for Enabled property
	Private m_Enabled As Boolean
	
	' True if the component should raise event in its owner

	Public Property Enabled() As Boolean
		Get
			Return m_Enabled
	 	End Get
		Set(ByVal newValue As Boolean)
			m_Enabled = newValue
	 	End Set
	End Property

	' The handle of the window being subclassed (read-only).
	
	Public ReadOnly Property hWnd() As Integer
	' UPGRADE_INFO (#0501): The 'hWnd' member isn't used anywhere in current application.
		Get
			Return m_hWnd
	 	End Get
	End Property

	' Start the subclassing.
	' You can stop subclassing by passing a null handle.
	
	Public Sub StartSubclass(ByVal hWnd As Integer)
		' Minimal error trapping
		If hWnd <> 0 And IsWindow(hWnd) = 0 Then 
			Err.Raise(1001, , "Invalid window handle")
		ElseIf hWnd = m_hWnd Then 
			' Nothing to do
			Exit Sub
		End If
		
		' Terminate current subclassing, if necessary
		If m_hWnd Then  StopSubclass()
		' Store arguments in member variables.
		m_hWnd = hWnd
		
		' Add a new item to the list of subclassed window.
		If m_hWnd Then  HookWindow(Me, m_hWnd)
	End Sub

	' Stop the subclassing.
	
	Public Sub StopSubclass()
		' Delete this item from the list of subclassed window.
		If m_hWnd Then  UnhookWindow(Me)
	End Sub

	' This Friend procedure is called when a message is sent to this window.
	
	Friend Function WndProc(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer, ByVal oldWindowProc As Integer) As Integer
		Dim retValue As Integer
		Dim Cancel As Boolean
		
		If Not Enabled Then 
			' If subclassing is disabled, just call the original procedure.
			retValue = CallWindowProc(oldWindowProc, hWnd, uMsg, wParam, lParam)
		Else
			' Call the application before processing the message.
			RaiseEvent BeforeMessage(hWnd, uMsg, wParam, lParam, retValue, Cancel)
			If Not Cancel Then 
				' Call the original window procedure, unless the program canceled it.
				retValue = CallWindowProc(oldWindowProc, hWnd, uMsg, wParam, lParam)
				' Call the application after processing the message.
				RaiseEvent AfterMessage(hWnd, uMsg, wParam, lParam, retValue)
			End If
		End If
		
		' Return the value to Windows.
		Return retValue
		
	End Function

	' ------------------------------------------------
	' Private procedures
	' ------------------------------------------------
	
	Private Sub Class_Initialize_VB6()
		' Initialize the Enabled property.
		Enabled = True
	End Sub

	' This event fires also when the client program is abruptly Ended.
	
	Private Sub Class_Terminate_VB6()
		StopSubclass()
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
