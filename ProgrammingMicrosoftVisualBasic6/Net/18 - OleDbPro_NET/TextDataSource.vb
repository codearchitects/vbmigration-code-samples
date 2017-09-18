' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'ADODB' type library is never used in current project. Consider deleting it from VB6 project references.
' UPGRADE_INFO (#0571): The 'OLEDBError' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

<System.Runtime.InteropServices.ProgID("TextOLEDBProvider.TextDataSource")> _ 
Public Class TextDataSource
' UPGRADE_INFO (#0501): The 'TextDataSource' member isn't used anywhere in current application.

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Shared Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	' UPGRADE_INFO (#0511): The 'E_FAIL' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const E_FAIL As Integer = &H80004005I
	
	' UPGRADE_INFO (#0511): The 'TextOSP' member is referenced only by members that haven't found to be used in the current project/solution.
	Private TextOSP As New TextOSP
	
	' The DataMember passed to this function is the
	' path of the text file.
	Public Function msDataSourceObject(ByRef DataMember As String) As MSDAOSP.OLEDBSimpleProvider
	' UPGRADE_INFO (#0501): The 'msDataSourceObject' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'DataMember' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' Raise error if invalid member.
		If DataMember = "" Then  Err.Raise(E_FAIL)
		
		' Creates an instance of the OLE DB Simple Provider component,
		' load a data file, and return the instance to the caller.
		TextOSP.LoadData(DataMember)
		Return TextOSP
	End Function

	Public Function addDataSourceListener(ByVal pospIListener As Object) As Integer
	' UPGRADE_INFO (#0501): The 'addDataSourceListener' member isn't used anywhere in current application.
		Return 0
	End Function

End Class
