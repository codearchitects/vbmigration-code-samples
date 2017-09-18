' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

<System.Runtime.InteropServices.ProgID("TextOLEDBProvider.TextOSP")> _ 
Public Class TextOSP
	Implements IDisposable
	Implements MSDAOSP.OLEDBSimpleProvider
' UPGRADE_INFO (#0511): The 'TextOSP' member is referenced only by members that haven't found to be used in the current project/solution.

	#Region "Constructor"
	
	'A default constructor with Friend scope to prevent instantiation from outside the assembly
	Protected Friend Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	#Region "Static constructor"
	
	' This static constructor ensures that the VB6 support library be initialized before using current class.
	Shared Sub New()
		EnsureVB6LibraryInitialization()
	End Sub
	
	#End Region

	Private Const DELIMITER As String = ";"
	Private Const E_FAIL As Integer = &H80004005I
	
	Private DataArray() As Object ' An array of array
	Private RowCount As Integer ' Number of rows (records)
	Private ColCount As Integer ' Number or columns (fields)
	Private IsDirty As Boolean ' True if data has changed
	Private m_FileName As String = "" ' The path of the data file
	
	Private Listeners As New Collection
	Private Listener As MSDAOSP.OLEDBSimpleProviderListener

	'--------------------------------------------
	' Provider-specific routines
	'--------------------------------------------
	
	Public Sub LoadData(ByRef FileName As String)
	' UPGRADE_INFO (#0511): The 'LoadData' member is referenced only by members that haven't found to be used in the current project/solution.
	' UPGRADE_INFO (#0551): The 'FileName' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fnum As Short
		Dim FileText As String = ""
		Dim records() As String
		Dim fields() As String
		Dim row As Integer
		' UPGRADE_INFO (#0501): The 'col' member isn't used anywhere in current application.
		Dim col As Integer
		
		' Read the file in memory
		m_FileName = FileName
		fnum = FreeFile6()
		On Error GoTo ErrorHandler 
		FileOpen6(fnum, m_FileName, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite, -1)
		FileText = FileInputString6(fnum, LOF6(fnum))
		FileClose6(fnum)
		
		' Split the file in records and fields.
		records = Split(FileText, ControlChars.CrLf)
		RowCount = UBound6(records)
		ColCount = -1
		ReDim DataArray(RowCount)
		
		For row = 0 To RowCount
			fields = Split(records(row), DELIMITER)
			DataArray(row) = fields
		Next
		' The first record sets ColCount.
		ColCount = UBound6(DataArray(0)) + 1
		Exit Sub
		
ErrorHandler:
		Err.Raise(E_FAIL)
		
	End Sub

	Public Sub SaveData()
		Dim fnum As Short
		Dim FileText As String = ""
		' UPGRADE_INFO (#0501): The 'records' member isn't used anywhere in current application.
		Dim records() As String
		' UPGRADE_INFO (#0501): The 'fields' member isn't used anywhere in current application.
		Dim fields() As String
		Dim row As Integer
		' UPGRADE_INFO (#0501): The 'col' member isn't used anywhere in current application.
		Dim col As Integer
		
		For row = 0 To UBound6(DataArray)
			FileText = FileText & Join(DataArray(row), DELIMITER) & ControlChars.CrLf
		Next
		' Drop the last CR-LF.
		FileText = VB.Left(FileText, Len6(FileText) - 2)
		
		' Write the file
		fnum = FreeFile6()
		On Error GoTo ErrorHandler 
		FileOpen6(fnum, m_FileName, OpenMode.Output, OpenAccess.Default, OpenShare.LockReadWrite, -1)
		FilePrint6(fnum, FileText)
		FileClose6(fnum)
		IsDirty = False
		
		Exit Sub
		
ErrorHandler:
		Err.Raise(E_FAIL)
	End Sub

	' Flush to database when the provider terminates.
	Private Sub Class_Terminate_VB6()
		On Error Resume Next 
		If IsDirty Then  SaveData()
	End Sub

	'--------------------------------------------
	' The OLEDBSimpleProvider interface
	'--------------------------------------------
	
	' Return the exact number of rows.
	Private Function OLEDBSimpleProvider_getRowCount() As Integer Implements MSDAOSP.OLEDBSimpleProvider.getRowCount
		Return RowCount
	End Function

	' Return the number of columns.
	Private Function OLEDBSimpleProvider_getColumnCount() As Integer Implements MSDAOSP.OLEDBSimpleProvider.getColumnCount
		Return ColCount
	End Function

	' Return the estimated number of rows, or -1 if unknown.
	' This method is used in asynchronous data transfer.
	Private Function OLEDBSimpleProvider_getEstimatedRows() As Integer Implements MSDAOSP.OLEDBSimpleProvider.getEstimatedRows
		Return RowCount
	End Function

	' REturns a string that determined the system international settings,
	' or an empty string if the provider doesn't support different locales.
	Private Function OLEDBSimpleProvider_getLocale() As String Implements MSDAOSP.OLEDBSimpleProvider.getLocale
		Return ""
	End Function

	' Returns a non-zero value if the rowset is populated asynchronously.
	Private Function OLEDBSimpleProvider_isAsync() As Integer Implements MSDAOSP.OLEDBSimpleProvider.isAsync
		Return CShort(False)
	End Function

	' Stop asynchronous transfer.
	Private Sub OLEDBSimpleProvider_stopTransfer() Implements MSDAOSP.OLEDBSimpleProvider.stopTransfer
		' Do nothing in this provider.
	End Sub

	' Add a Listener to the Listeners collection.
	Private Sub OLEDBSimpleProvider_addOLEDBSimpleProviderListener(ByVal pospIListener As MSDAOSP.OLEDBSimpleProviderListener) Implements MSDAOSP.OLEDBSimpleProvider.addOLEDBSimpleProviderListener
		If Not (pospIListener Is Nothing) Then 
			Listeners.Add(pospIListener)
		End If
	End Sub

	' Remove a Listener from the Listeners collection.
	Private Sub OLEDBSimpleProvider_removeOLEDBSimpleProviderListener(ByVal pospIListener As MSDAOSP.OLEDBSimpleProviderListener) Implements MSDAOSP.OLEDBSimpleProvider.removeOLEDBSimpleProviderListener
		Dim i As Integer
		For i = 1 To Listeners.Count()
			If Listeners.Item(i) Is pospIListener Then 
				Listeners.Remove(i)
				Exit For
			End If
		Next
	End Sub

	' Return the Read/Write status of a value.
	' If iRow = -1, it returns the status of a column.
	' If iColumn = -1, it returns the status of a row.
	Private Function OLEDBSimpleProvider_getRWStatus(ByVal iRow As Integer, ByVal iColumn As Integer) As MSDAOSP.OSPRW Implements MSDAOSP.OLEDBSimpleProvider.getRWStatus
		' Make all fields read/write.
		Return MSDAOSP.OSPRW.OSPRW_MIXED
	End Function

	' Read a value at given row/col coordinates.
	Private Function OLEDBSimpleProvider_getVariant(ByVal iRow As Integer, ByVal iColumn As Integer, ByVal format As MSDAOSP.OSPFORMAT) As Object Implements MSDAOSP.OLEDBSimpleProvider.getVariant
		' Ignores the format argument.
		Return DataArray(iRow)(iColumn - 1)
	End Function

	' Write a value at given row/col coordinates.
	Private Sub OLEDBSimpleProvider_setVariant(ByVal iRow As Integer, ByVal iColumn As Integer, ByVal format As MSDAOSP.OSPFORMAT, ByVal Var As Object) Implements MSDAOSP.OLEDBSimpleProvider.setVariant
		' Ignores the format argument.
		On Error Resume Next 
		' Pre-notification
		For Each Listener In Listeners
			Listener.aboutToChangeCell(iRow, iColumn)
		Next
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Var'. Consider using the GetDefaultMember6 helper method.
		DataArray(iRow)(iColumn - 1) = Var
		' Post-notification
		For Each Listener In Listeners
			Listener.cellChanged(iRow, iColumn)
		Next
		IsDirty = True
	End Sub

	' Insert one or more rows.
	Private Function OLEDBSimpleProvider_insertRows(ByVal iRow As Integer, ByVal cRows As Integer) As Integer Implements MSDAOSP.OLEDBSimpleProvider.insertRows
		Dim emptyArray() As String    ' Implicitly declared array
		Dim row As Integer
		
		' Validate iRows
		If iRow < 1 Or iRow > RowCount + 1 Then  Err.Raise(E_FAIL)
		
		On Error Resume Next 
		ReDim emptyArray(ColCount - 1)
		ReDim Preserve DataArray(RowCount + cRows)
		
		' Pre-notification
		For Each Listener In Listeners
			Listener.aboutToInsertRows(iRow, cRows)
		Next
		' Make room in the array.
		If iRow <= RowCount Then 
			For row = RowCount To iRow Step -1
				DataArray(row + cRows) = DataArray(row)
				DataArray(row) = emptyArray
			Next
		Else
			For row = RowCount + 1 To RowCount + cRows
				DataArray(row) = emptyArray
			Next
		End If
		RowCount += cRows
		' Post-notification
		For Each Listener In Listeners
			Listener.insertedRows(iRow, cRows)
		Next
		' Return the number of inserted rows.
		OLEDBSimpleProvider_insertRows = cRows
		IsDirty = True
	End Function

	' Delete one or more rows.
	Private Function OLEDBSimpleProvider_deleteRows(ByVal iRow As Integer, ByVal cRows As Integer) As Integer Implements MSDAOSP.OLEDBSimpleProvider.deleteRows
		Dim row As Integer
		
		' Validate iRows
		If iRow < 1 Or iRow > RowCount Then  Err.Raise(E_FAIL)
		' Set cRows to the actual number which can be deleted.
		If iRow + cRows > RowCount + 1 Then  cRows = RowCount - iRow + 1
		
		On Error Resume Next 
		
		' Pre-notification.
		For Each Listener In Listeners
			Listener.aboutToDeleteRows(iRow, cRows)
		Next
		' Shrink the array.
		For row = iRow To RowCount - cRows
			DataArray(row) = DataArray(row + cRows)
		Next
		RowCount -= cRows
		ReDim Preserve DataArray(RowCount)
		' Post-notification
		For Each Listener In Listeners
			Listener.deletedRows(iRow, cRows)
		Next
		' Return number of deleted rows
		OLEDBSimpleProvider_deleteRows = cRows
		IsDirty = True
	End Function

	Private Function OLEDBSimpleProvider_find(ByVal iRowStart As Integer, ByVal iColumn As Integer, ByVal val As Object, ByVal findFlags As MSDAOSP.OSPFIND, ByVal compType As MSDAOSP.OSPCOMP) As Integer Implements MSDAOSP.OLEDBSimpleProvider.find
		Dim RowStop As Integer
		Dim RowStep As Integer
		Dim CaseSens As Integer
		Dim StringComp As Boolean
		Dim result As Integer
		Dim compResult As Short
		Dim row As Integer
		
		' Determine end row and step value for the loop.
		If findFlags And MSDAOSP.OSPFIND.OSPFIND_UP Then 
			RowStop = 1: RowStep = -1
		Else
			RowStop = RowCount: RowStep = 1
		End If
		' Determine the case sensitive flag.
		If findFlags And MSDAOSP.OSPFIND.OSPFIND_CASESENSITIVE Then 
			CaseSens = CompareMethod.Text
		Else
			CaseSens = CompareMethod.Binary
		End If
		' True if we're dealing with strings.
		StringComp = (VarType6(val) = VariantType.String)
		' -1 means not found.
		result = -1
		' iColumn is 1-based, but internal data is 0-based.
		iColumn -= 1
		
		For row = iRowStart To RowStop Step RowStep
			If StringComp Then 
				' We're comparing strings.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'val'. Consider using the GetDefaultMember6 helper method.
				compResult = StrComp(DataArray(row)(iColumn), val, CaseSens)
			Else
				' We're comparing numbers or dates.
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'val'. Consider using the GetDefaultMember6 helper method.
				compResult = Math.Sign(DataArray(row)(iColumn) - val)
			End If
			Select Case compType
			Case MSDAOSP.OSPCOMP.OSPCOMP_DEFAULT, MSDAOSP.OSPCOMP.OSPCOMP_EQ
				If compResult = 0 Then  result = row
			Case MSDAOSP.OSPCOMP.OSPCOMP_GE
				If compResult >= 0 Then  result = row
			Case MSDAOSP.OSPCOMP.OSPCOMP_GT
				If compResult > 0 Then  result = row
			Case MSDAOSP.OSPCOMP.OSPCOMP_LE
				If compResult <= 0 Then  result = row
			Case MSDAOSP.OSPCOMP.OSPCOMP_LT
				If compResult < 0 Then  result = row
			Case MSDAOSP.OSPCOMP.OSPCOMP_NE
				If compResult <> 0 Then  result = row
			End Select
			If result <> -1 Then  Exit For
		Next
		
		' Return the row found, or -1.
		Return result
		
	End Function

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
