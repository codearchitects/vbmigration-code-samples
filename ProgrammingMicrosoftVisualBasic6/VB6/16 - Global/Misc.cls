VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Misc"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "Miscellaneous routines"
'---------------------------------------------------------
' Miscellaneous routines
'---------------------------------------------------------

Option Explicit

' API declares (used by the WaitForProcess routine)
Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Long, ByVal dwMilliseconds As Long) As Long
Private Declare Function OpenProcess Lib "kernel32" (ByVal dwAccess As Long, ByVal fInherit As Integer, ByVal hObject As Long) As Long
Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long

' Wait for a number of milliseconds and return the running status of a
' process. If argument is omitted, wait until the process terminates.

Function WaitForProcess(taskId As Long, Optional msecs As Long = -1) As Boolean
    Dim procHandle As Long
    ' get the process handle
    procHandle = OpenProcess(&H100000, True, taskId)
    ' check for its signaled status, return to caller
    WaitForProcess = WaitForSingleObject(procHandle, msecs) <> -1
    ' close the handle
    CloseHandle procHandle
End Function

' Check if an item in a collection actually exists.

Function ItemExists(col As Collection, Key As String) As Boolean
Attribute ItemExists.VB_Description = "Check if an item in a collection actually exists."
    Dim dummy As Variant
    On Error Resume Next
    dummy = col.Item(Key)
    ItemExists = (Err = 0)
End Function

' Remove all items in a collection.

Sub RemoveAllItems(col As Collection)
Attribute RemoveAllItems.VB_Description = "Remove all items in a collection."
    Do While col.count
        col.Remove 1
    Loop
End Sub

' Replace an item in a collection
' Note: INDEX can be either a numeric or a string value

Sub ReplaceItem(col As Collection, index As Variant, newValue As Variant)
Attribute ReplaceItem.VB_Description = "Replace an item in a collection."
    ' first, remove that item (exits with error if it doesn't exist)
    col.Remove index
    ' then, add it again
    If VarType(index) = vbString Then
        ' add a new item with the same string key
        col.Add newValue, index
    Else
        ' add a new item in the same position (without any key)
        col.Add newValue, , index
    End If
End Sub

