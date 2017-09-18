Attribute VB_Name = "Module1"
'-----------------------------------------------------------------------------------------------------
'All codes are copyright by Philip V. Naparan 2004
'
'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
'E-mail Address: philipnaparan@yahoo.com
'Contact #: 639186443161
'----------------------------------------------------------------------------------------------------
Option Explicit

Public Sub use_pos(ByRef sForm As Form)
On Error Resume Next
Dim t, l As String
Open App.Path & "\Settings\" & sForm.Name & ".pos" For Input As #1
    Input #1, t
    Input #1, l
Close #1
t = Trim(t)
l = Trim(l)
sForm.Top = Val(t)
sForm.Left = Val(l)
'-------------------------
'Clear variables
'-------------------------
t = ""
l = ""
End Sub
Public Sub save_pos(ByVal sForm As Form)
On Error Resume Next
Call create_save_setting_dir
Open App.Path & "\Settings\" & sForm.Name & ".pos" For Output As #1
    Print #1, sForm.Top
    Print #1, sForm.Left
Close #1
End Sub
Public Sub use_control_vis(ByRef sControl)
On Error Resume Next
Dim t As String
Open App.Path & "\Settings\" & sControl.Name & ".vis" For Input As #1
    Input #1, t
Close #1
t = Trim(t)
sControl.Visible = t
'-------------------------
'Clear variables
'-------------------------
t = ""
End Sub
Public Sub save_control_vis(ByVal sControl)
On Error Resume Next
Call create_save_setting_dir
Open App.Path & "\Settings\" & sControl.Name & ".vis" For Output As #1
    Print #1, sControl.Visible
Close #1
End Sub
Public Sub use_control_pos(ByRef sControl)
On Error Resume Next
Dim t As String
Open App.Path & "\Settings\" & sControl.Name & ".pos" For Input As #1
    Input #1, t
Close #1
t = Trim(t)
sControl.Align = Val(t)
'-------------------------
'Clear variables
'-------------------------
t = ""
End Sub
Public Sub save_control_pos(ByVal sControl)
On Error Resume Next
Call create_save_setting_dir
Open App.Path & "\Settings\" & sControl.Name & ".pos" For Output As #1
    Print #1, sControl.Align
Close #1
End Sub
Private Sub create_save_setting_dir()
On Error Resume Next
MkDir (App.Path & "\Settings")
End Sub
Public Sub FillListView(ByRef sListView As ListView, ByRef sRecordSource As ADODB.Recordset, ByVal sNumOfFields As Byte, ByVal sNumIco As Byte, ByVal with_num As Boolean, ByVal show_first_rec As Boolean)
Dim x As Variant '|Optional to be declare as variant|
Dim i As Byte
On Error Resume Next
sRecordSource.MoveFirst
sListView.ListItems.Clear
Do While Not sRecordSource.EOF
    If with_num = True Then
        Set x = sListView.ListItems.Add(, , sRecordSource.AbsolutePosition, sNumIco, sNumIco)
    Else
        Set x = sListView.ListItems.Add(, , sRecordSource.Fields(0), sNumIco, sNumIco)
    End If
        For i = 1 To sNumOfFields - 1
            If Not sRecordSource.Fields(Val(i)) = "" Then
                If show_first_rec = True Then
                    x.SubItems(i) = sRecordSource.Fields(Val(i) - 1)
                Else
                    x.SubItems(i) = sRecordSource.Fields(Val(i))
                End If
            End If
        Next i
    sRecordSource.MoveNext
Loop
i = 0
Set x = Nothing
End Sub
Public Sub search_in_listview(ByRef sListView As ListView, ByVal sFindText As String)
Dim tmp_listtview As ListItem
Set tmp_listtview = sListView.FindItem(sFindText, lvwSubItem + lvwText, lvwPartial, lvwPartial)
If Not tmp_listtview Is Nothing Then
    tmp_listtview.EnsureVisible
    tmp_listtview.Selected = True
End If
End Sub
Public Sub highlight_focus(ByRef sText As TextBox)
With sText
    .SelStart = 0
    .SelLength = Len(sText.Text)
End With
End Sub
Public Sub prompt_err(ByVal sErrorDescription As String)
MsgBox sErrorDescription & vbCrLf & vbCrLf & "*Note: Contact the programmer to learn more about this.", vbExclamation, "CSRS version 1"
End Sub

Public Sub delete_rec(ByRef sCONN As ADODB.Connection, ByVal sTable As String, ByVal sField As String, ByVal sString As String, ByVal isnumber As Boolean, ByVal snum As Long)
If isnumber = True Then
    sCONN.Execute "Delete * From " & sTable & " Where " & sField & " =" & snum
Else
    sCONN.Execute "Delete * From " & sTable & " Where " & sField & " ='" & sString & "'"
End If
End Sub
Public Function is_empty(ByRef sText As Variant) As Boolean
If sText.Text = "" Then
    is_empty = True
    MsgBox "The field is required.Please check it!", vbExclamation, "CSRS version 1"
    sText.SetFocus
Else
    is_empty = False
End If
End Function
Public Function get_num(ByVal sTable As String, ByVal sField As String, ByRef sCN As ADODB.Connection) As Long
On Error GoTo Err
Dim rs As New ADODB.Recordset
rs.Open "SELECT Max(" & sTable & "." & sField & ") AS [Number] From " & sTable & " ORDER BY Max(" & sTable & "." & sField & ") DESC", sCN, adOpenStatic, adLockOptimistic
get_num = rs.Fields(0) + 1

sTable = ""
sField = ""
Set rs = Nothing
Exit Function
Err:
    '---------------------------------
    'Error when incounter a null value
    '---------------------------------
    If Err.Number = 94 Then get_num = 1: Resume Next
End Function
Public Function if_exist(ByVal sTable As String, ByVal sField As String, ByRef sEntryField As Variant) As Boolean
Dim rs As New ADODB.Recordset
if_exist = False
Call set_rec_getData(rs, cn, "Select * From " & sTable & " Where " & sField & " ='" & sEntryField.Text & "'")
If rs.RecordCount > 0 Then
    MsgBox "The adding of new entry cannot be done because '" & sEntryField.Text & "' is already" & vbCrLf & "exist in the record.Please check and change it." & vbCrLf & vbCrLf & "Note: Duplication of entries is not allowed in this form.", vbExclamation, "CSRS version 1"
    sEntryField.SetFocus
    if_exist = True
End If
Set rs = Nothing
End Function
Public Sub centerForm(ByRef sForm As Form, ByVal sHeight As Integer, ByVal sWidth As Integer)
sForm.Move (sWidth - sForm.Width) / 2, (sHeight - sForm.Height) / 2
End Sub

