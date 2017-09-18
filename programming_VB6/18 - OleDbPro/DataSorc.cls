VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "TextDataSource"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Const E_FAIL = &H80004005

Dim TextOSP As New TextOSP

' The DataMember passed to this function is the
' path of the text file.
Public Function msDataSourceObject(DataMember As String) As OLEDBSimpleProvider
    ' Raise error if invalid member.
    If DataMember = "" Then Err.Raise E_FAIL
    
    ' Creates an instance of the OLE DB Simple Provider component,
    ' load a data file, and return the instance to the caller.
    TextOSP.LoadData DataMember
    Set msDataSourceObject = TextOSP
End Function

Public Function addDataSourceListener(ByVal pospIListener As DataSourceListener) As Long
    addDataSourceListener = 0
End Function
