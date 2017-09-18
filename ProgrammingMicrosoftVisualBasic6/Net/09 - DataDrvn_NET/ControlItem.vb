' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class ControlItem

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' a public collection for additional properties
	Public Properties As New Collection
	' the object being monitored - this is same as "Control"
	' but it also receives events
	Public WithEvents Control As VB6VBControlExtender
	' the parent ControlItems object
	Private m_Parent As ControlItems
	
	' initialize properties
	
	Public Sub Init(ByRef ctrl As VB6VBControlExtender, ByRef parent As ControlItems)
	' UPGRADE_INFO (#0551): The 'ctrl' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'parent' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Control = ctrl
		m_Parent = parent
	End Sub

	' retrieve a single property
	
	Public Function GetProperty(ByRef PropName As String, Optional ByRef DefaultValue As Object = VB6Missing) As Object
	' UPGRADE_INFO (#0551): The 'PropName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DefaultValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		GetProperty = Properties.Item(PropName)
		If Err.Number And Not IsMissing6(DefaultValue) Then 
			Return DefaultValue
		End If
	End Function

	' the control has raised a Validate event
	
	Private Sub Control_Validate(ByRef Cancel As Boolean) Handles Control.Validate
		' notify it to the parent ControlItems class
		m_Parent.Notify_Validate(Me, Cancel)
	End Sub

End Class
