VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "DateTime"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Attribute VB_Description = "Date and Time routines"
'---------------------------------------------------------
' Date and Time routines
'---------------------------------------------------------

Option Explicit

' Wait for the current timer tick to elapse.

Function NextTimerTick() As Single
Attribute NextTimerTick.VB_Description = "Wait for the current timer tick to elapse."
    Dim t As Single
    t = Timer
    Do: Loop While t = Timer
    NextTimerTick = Timer
End Function

' Insert a pause of a given duration (rounded to nearest integer).

Sub Pause(seconds As Integer)
Attribute Pause.VB_Description = "Insert a pause of a given duration (rounded to nearest integer)."
    Const SECS_INDAY = 24! * 60 * 60    ' seconds per day
    Dim start As Single
    start = Timer
    Do: Loop Until (Timer + SECS_INDAY - start) Mod SECS_INDAY >= seconds
End Sub

' Check if argument a leap year.

Function IsLeapYear(year As Integer) As Boolean
Attribute IsLeapYear.VB_Description = "Check if argument a leap year."
    ' does February 29 coincides with March 1 ?
    IsLeapYear = DateSerial(year, 2, 29) <> DateSerial(year, 3, 1)
End Function

