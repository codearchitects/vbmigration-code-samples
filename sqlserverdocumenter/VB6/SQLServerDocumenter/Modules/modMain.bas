Attribute VB_Name = "modMain"
Option Explicit

Global objSQLServer                 As SQLDMO.SQLServer
Global objDatabase                  As SQLDMO.Database
Global objTable                     As SQLDMO.Table
Global objColumn                    As SQLDMO.Column
Global blnConnectionState           As Boolean
Global blnShowTable                 As Boolean
Global arrIDXType(11, 3)            As String

Function Center(frm As Form)

' Centers the form on the screen

frm.Left = (Screen.Width / 2) - (frm.Width / 2)
frm.Top = (Screen.Height / 2) - (frm.Height / 2)

End Function

Sub Export2XLS(strTable As String, strPath As String, strServer As String, strDatabase As String)

Dim objFSO              As New FileSystemObject
Dim objFile             As TextStream
Dim strTypeTemp         As String
Dim strIDXCol           As String
Dim objColumn           As SQLDMO.Column
Dim objIndex            As SQLDMO.Index
Dim objTable            As SQLDMO.Table
Dim intCount            As Integer

' Create HTML style report being saved as a .XLS file.
' When opened by Excel, it will be converted to an excel sheet automatically.
' This eliminates the need for excel libraries and DLL's

If blnShowTable = True Then
    
    Set objFile = objFSO.OpenTextFile(strPath, ForWriting, True)
    
    objFile.WriteLine "<table>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td colspan=5><h3><strong>" & strServer & " | " & strDatabase & " | " & strTable & "</strong></h3></td>"
    objFile.WriteLine "</tr>"
    objFile.WriteLine "<tr><td>&nbsp;</td></tr>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td><strong>Column Name</strong></td>"
    objFile.WriteLine " <td><strong>Data Type</strong></td>"
    objFile.WriteLine " <td><strong>Length</strong></td>"
    objFile.WriteLine " <td><strong>Allow NULL</strong></td>"
    objFile.WriteLine " <td><strong>Ident</strong></td>"
    objFile.WriteLine "</tr>"
    
    Set objColumn = New SQLDMO.Column
    Set objTable = objDatabase.Tables(strTable)
    
    
    For Each objColumn In objTable.Columns
        objFile.WriteLine "<tr>"
        objFile.WriteLine " <td>" & objColumn.Name & "</td>"
        objFile.WriteLine " <td>" & objColumn.Datatype & "</td>"
        objFile.WriteLine " <td>" & objColumn.Length & "</td>"
        objFile.WriteLine " <td>" & objColumn.AllowNulls & "</td>"
        objFile.WriteLine " <td>" & objColumn.Identity & "</td>"
        objFile.WriteLine "</tr>"
    
    Next
    
    objFile.WriteLine "</table>"
    
    objFile.Close

Else

    Set objFile = objFSO.OpenTextFile(strPath, ForWriting, True)
    
    objFile.WriteLine "<table>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td colspan=4><h3><strong>" & strServer & " | " & strDatabase & " | " & strTable & "</strong></h3></td>"
    objFile.WriteLine "</tr>"
    objFile.WriteLine "<tr><td>&nbsp;</td></tr>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td><strong>Index Name</strong></td>"
    objFile.WriteLine " <td><strong>Index Type</strong></td>"
    objFile.WriteLine " <td><strong>Fields</strong></td>"
    objFile.WriteLine " <td><strong>Fill Factor</strong></td>"
    objFile.WriteLine "</tr>"
    
    Set objIndex = New SQLDMO.Index
    Set objTable = objDatabase.Tables(strTable)
    
    
    For Each objIndex In objTable.Indexes
        
        ' SQLDMO returns all indexes, even system indexes. Filtering on "_WA_SYS_" and "hind_" hides these from the user
        If Left(objIndex.Name, 8) <> "_WA_Sys_" And Left(objIndex.Name, 5) <> "hind_" Then
            strTypeTemp = DecodeIDXType(objIndex.Type)
            strTypeTemp = Replace(strTypeTemp, ", ", "<BR>")
            For intCount = 1 To objIndex.ListIndexedColumns.Count
                    Set objColumn = objIndex.ListIndexedColumns.Item(intCount)
                    strIDXCol = strIDXCol & objColumn.Name & ", "
            Next
            strIDXCol = Left(strIDXCol, Len(strIDXCol) - 2)
            strIDXCol = Replace(strIDXCol, ", ", "<BR>")
            objFile.WriteLine "<tr>"
            objFile.WriteLine " <td valign=top>" & objIndex.Name & "</td>"
            objFile.WriteLine " <td valign=top>" & strTypeTemp & "</td>"
            objFile.WriteLine " <td valign=top>" & strIDXCol & "</td>"
            objFile.WriteLine " <td valign=top>" & objIndex.FillFactor & "</td>"
        End If
        strIDXCol = ""
    Next
    
    objFile.WriteLine "</table>"
    
    objFile.Close
End If

End Sub

Sub PrintPreview(strTable As String, strDatabase As String, strServer As String)

Dim objFSO              As New FileSystemObject
Dim objFile             As TextStream
Dim strTypeTemp         As String
Dim strIDXCol           As String
Dim objColumn           As SQLDMO.Column
Dim objIndex            As SQLDMO.Index
Dim objTable            As SQLDMO.Table
Dim intCount            As Integer

' Create HTML report to be shown in the browser control for printing

If blnShowTable = True Then
    
    Set objFile = objFSO.OpenTextFile(App.Path & "\tmpprt.dat", ForWriting, True)
    
    objFile.WriteLine "<table cellpadding=1 cellspacing=1 border=1 bordercolor=#F0F0F0>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td colspan=5 style=""font-size : 22px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strServer & " | " & strDatabase & " | " & strTable & "</td>"
    objFile.WriteLine "</tr>"
    objFile.WriteLine "<tr><td colspan=5>&nbsp;</td></tr>"
    objFile.WriteLine "<tr bgcolor=#F0F0F0>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Column Name</td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Data Type</td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Length</td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">NULL</td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;"">Ident</td>"
    objFile.WriteLine "</tr>"
    
    Set objColumn = New SQLDMO.Column
    Set objTable = objDatabase.Tables(strTable)
    
    
    For Each objColumn In objTable.Columns
        objFile.WriteLine "<tr>"
        objFile.WriteLine " <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Name & "</td>"
        objFile.WriteLine " <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Datatype & "</td>"
        objFile.WriteLine " <td style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objColumn.Length & "</td>"
        If objColumn.AllowNulls = True Then
            objFile.WriteLine " <td align=center style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">True</td>"
        Else
            objFile.WriteLine " <td>&nbsp;</td>"
        End If
        If objColumn.Identity = True Then
            objFile.WriteLine " <td align=center style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">True</td>"
        Else
            objFile.WriteLine " <td>&nbsp;</td>"
        End If
        objFile.WriteLine "</tr>"
    
    Next
    
    objFile.WriteLine "</table>"
    
    objFile.Close
Else
    
    Set objFile = objFSO.OpenTextFile(App.Path & "\tmpprt.dat", ForWriting, True)

    objFile.WriteLine "<table cellpadding=1 cellspacing=1 border=1 bordercolor=#F0F0F0>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td colspan=4 style=""font-size : 22px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strServer & " | " & strDatabase & " | " & strTable & "</td>"
    objFile.WriteLine "</tr>"
    objFile.WriteLine "<tr><td colspan=4>&nbsp;</td></tr>"
    objFile.WriteLine "<tr>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Index Name</strong></td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Index Type</strong></td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Fields</strong></td>"
    objFile.WriteLine " <td style=""font-size : 14px; font-family : Arial, Helvetica, sans-serif; background-color : #F0F0F0; font-weight : bold;""><strong>Fill Factor</strong></td>"
    objFile.WriteLine "</tr>"
    
    Set objIndex = New SQLDMO.Index
    Set objTable = objDatabase.Tables(strTable)
    
    
    For Each objIndex In objTable.Indexes
        
        ' SQLDMO returns all indexes, even system indexes. Filtering on "_WA_SYS_" and "hind_" hides these from the user
        If Left(objIndex.Name, 8) <> "_WA_Sys_" And Left(objIndex.Name, 5) <> "hind_" Then
            strTypeTemp = DecodeIDXType(objIndex.Type)
            strTypeTemp = Replace(strTypeTemp, ", ", "<BR>")
            For intCount = 1 To objIndex.ListIndexedColumns.Count
                    Set objColumn = objIndex.ListIndexedColumns.Item(intCount)
                    strIDXCol = strIDXCol & objColumn.Name & ", "
            Next
            strIDXCol = Left(strIDXCol, Len(strIDXCol) - 2)
            strIDXCol = Replace(strIDXCol, ", ", "<BR>")
            objFile.WriteLine "<tr>"
            objFile.WriteLine " <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objIndex.Name & "</td>"
            objFile.WriteLine " <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strTypeTemp & "</td>"
            objFile.WriteLine " <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & strIDXCol & "</td>"
            objFile.WriteLine " <td valign=top style=""font-size : 10px; font-family : Arial, Helvetica, sans-serif; font-weight : bold;"">" & objIndex.FillFactor & "</td>"
            objFile.WriteLine "</tr>"
        End If
        strIDXCol = ""
    Next
    
    objFile.WriteLine "</table>"
    
    objFile.Close

End If

End Sub

Sub InitArray()

'Static array of index type names
' arrIDXType(x, y) : x represents the bit that should be high in a 32 bit word, y holds the name of the index type

arrIDXType(1, 1) = "32"
arrIDXType(1, 3) = "Ignore Dupl. Key"
arrIDXType(2, 1) = "31"
arrIDXType(2, 3) = "Unique"
arrIDXType(3, 1) = "28"
arrIDXType(3, 3) = "Clustered"
arrIDXType(4, 1) = "27"
arrIDXType(4, 3) = "Hypotethical"
arrIDXType(5, 1) = "24"
arrIDXType(5, 3) = "Pad index nodes"
arrIDXType(6, 1) = "23"
arrIDXType(6, 3) = "!!OBSOLETE!!"
arrIDXType(7, 1) = "21"
arrIDXType(7, 3) = "Primary Key"
arrIDXType(8, 1) = "20"
arrIDXType(8, 3) = "Unique Key"
arrIDXType(9, 1) = "19"
arrIDXType(9, 3) = "!!OBSOLETE!!"
arrIDXType(10, 1) = "17"
arrIDXType(10, 3) = "Drop Exist"
arrIDXType(11, 1) = "8"
arrIDXType(11, 3) = "No Recompute"

End Sub

Private Function ConvertToBinary(ByVal Number As Long, ByVal Bits As Byte) As String

Dim intCount As Byte

' The actual long to binary conversion.
' This snippet was taken from http://www.planet-source-code.com

ConvertToBinary = String$(Bits, "0")
For intCount = 1 To Bits
    If Number And 1 Then Mid$(ConvertToBinary, Bits + 1 - intCount, 1) = "1"
    Number = Number \ 2
Next intCount
    
End Function

Public Function DecodeIDXType(TypeNr As Long) As String

Dim intCount            As Integer
Dim strOutput           As String
Dim strInput            As String

' Convert the Type number to binary and check which bits are high
' Macht the "high" bits to the array "arrIDXType" and return the index type name

For intCount = 1 To 11
    If TypeNr <> "0" Then
        strInput = ConvertToBinary(TypeNr, 32)
        If Mid(strInput, CInt(arrIDXType(intCount, 1)), 1) = "1" Then
            arrIDXType(intCount, 2) = "Y"
        End If
    End If
Next


For intCount = 1 To 11
    If arrIDXType(intCount, 2) = "Y" Then
        strOutput = arrIDXType(intCount, 3) & ", " & strOutput
    End If
Next

If strOutput = "" Then
    DecodeIDXType = "UNKNOWN (" & TypeNr & ")"
Else
    DecodeIDXType = Left(strOutput, Len(strOutput) - 2)
End If

End Function
