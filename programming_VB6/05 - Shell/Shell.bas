Attribute VB_Name = "Module1"
Option Explicit

' API declares
Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Long, ByVal dwMilliseconds As Long) As Long
Private Declare Function OpenProcess Lib "kernel32" (ByVal dwAccess As Long, _
ByVal fInherit As Integer, ByVal hObject As Long) As Long
Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long

' wait for a number of milliseconds and return the running status of a process
' if argument is omitted, wait until the process terminates

Function WaitForProcess(taskId As Long, Optional milliseconds As Long = -1) As Boolean
    Dim procHandle As Long
    ' get the process handle
    procHandle = OpenProcess(&H100000, True, taskId)
    ' check for its signaled status, return to caller
    Dim res As Long
    res = WaitForSingleObject(procHandle, milliseconds)
    WaitForProcess = (res <> 0 And res <> -1)
    ' close the handle
    CloseHandle procHandle
End Function


