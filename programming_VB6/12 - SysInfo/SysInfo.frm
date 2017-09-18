VERSION 5.00
Object = "{6FBA474E-43AC-11CE-9A0E-00AA0062BB4C}#1.0#0"; "SYSINFO.OCX"
Begin VB.Form Form1 
   Caption         =   "SysInfo Control Demo"
   ClientHeight    =   4065
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5745
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4065
   ScaleWidth      =   5745
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdClear 
      Caption         =   "&Clear"
      Height          =   495
      Left            =   4320
      TabIndex        =   6
      Top             =   2640
      Width           =   1335
   End
   Begin VB.ListBox lstEvents 
      Height          =   1260
      Left            =   120
      TabIndex        =   5
      Top             =   2640
      Width           =   3975
   End
   Begin VB.CommandButton cmdPower 
      Caption         =   "&Power"
      Height          =   495
      Left            =   4320
      TabIndex        =   3
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton cmdWindows 
      Caption         =   "&Windows"
      Height          =   495
      Left            =   4320
      TabIndex        =   2
      Top             =   600
      Width           =   1335
   End
   Begin VB.CommandButton cmdScreen 
      Caption         =   "&Screen"
      Height          =   495
      Left            =   4320
      TabIndex        =   1
      Top             =   120
      Width           =   1335
   End
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      Height          =   1935
      Left            =   120
      ScaleHeight     =   1875
      ScaleWidth      =   3915
      TabIndex        =   0
      Top             =   120
      Width           =   3975
   End
   Begin SysInfoLib.SysInfo SysInfo1 
      Left            =   5040
      Top             =   1680
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
   End
   Begin VB.Label Label1 
      Caption         =   "Events:"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   2280
      Width           =   2895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##DefaultMemberSupport False

Private Sub cmdPower_Click()
    With SysInfo1
        Picture1.Cls
        Picture1.Print "ACStatus = " & Switch(.ACStatus = 0, "Battery", .ACStatus = 1, "AC Power", True, "Unknown")
        Picture1.Print "BatteryFullTime = " & IIf(.BatteryFullTime <> -1, .BatteryFullTime, "Unknown")
        Picture1.Print "BatteryLifePercent = " & IIf(.BatteryLifePercent <> 255, .BatteryLifePercent, "Unknown")
        Picture1.Print "BatteryLifeTime = " & IIf(.BatteryLifeTime <> -1, .BatteryLifeTime, "Unknown")
        Picture1.Print "BatteryStatus = " & Switch(.BatteryStatus = 1, "High", .BatteryStatus = 2, "Low", .BatteryStatus = 4, "Critical", .BatteryStatus = 8, "Charging", .BatteryStatus = 128, "(no battery)", True, "Unknown")
    End With
End Sub

Private Sub cmdWindows_Click()
    With SysInfo1
        Picture1.Cls
        Picture1.Print "OSPlatform = " & Choose(.OSPlatform + 1, "Win32s", "Windows 9x", "Windows NT")
        Picture1.Print "OSVersion = " & .OSVersion
        Picture1.Print "OSBuild = " & .OSBuild
    End With
End Sub

Private Sub cmdScreen_Click()
    With SysInfo1
        Picture1.Cls
        Picture1.Print "WorkAreaLeft = " & .WorkAreaLeft
        Picture1.Print "WorkAreaTop = " & .WorkAreaTop
        Picture1.Print "WorkAreaWidth = " & .WorkAreaWidth
        Picture1.Print "WorkAreaHeight = " & .WorkAreaHeight
        Picture1.Print "ScrollBarSize = " & .ScrollBarSize
    End With
End Sub

Private Sub cmdClear_Click()
    lstEvents.Clear
End Sub

Private Sub SysInfo1_ConfigChangeCancelled()
    AddEvent "ConfigChangeCancelled"
End Sub

Private Sub SysInfo1_ConfigChanged(ByVal OldConfigNum As Long, ByVal NewConfigNum As Long)
    AddEvent "ConfigChanged", OldConfigNum, NewConfigNum
End Sub

Private Sub SysInfo1_DeviceArrival(ByVal DeviceType As Long, ByVal DeviceID As Long, ByVal DeviceName As String, ByVal DeviceData As Long)
    AddEvent "DeviceArrival", DeviceType, DeviceID, DeviceName, DeviceData
End Sub

Private Sub SysInfo1_DeviceOtherEvent(ByVal DeviceType As Long, ByVal eventname As String, ByVal DataPointer As Long)
    AddEvent "DeviceOtherEvent", DeviceType, eventname, DataPointer
End Sub

Private Sub SysInfo1_DeviceQueryRemove(ByVal DeviceType As Long, ByVal DeviceID As Long, ByVal DeviceName As String, ByVal DeviceData As Long, Cancel As Boolean)
    AddEvent "DeviceQueryRemove", DeviceType, DeviceID, DeviceName, DeviceData, Cancel
End Sub

Private Sub SysInfo1_DeviceQueryRemoveFailed(ByVal DeviceType As Long, ByVal DeviceID As Long, ByVal DeviceName As String, ByVal DeviceData As Long)
    AddEvent "DeviceQueryRemoveFailed", DeviceType, DeviceID, DeviceName, DeviceData
End Sub

Private Sub SysInfo1_DeviceRemoveComplete(ByVal DeviceType As Long, ByVal DeviceID As Long, ByVal DeviceName As String, ByVal DeviceData As Long)
    AddEvent "DeviceRemoveComplete", DeviceType, DeviceID, DeviceName, DeviceData
End Sub

Private Sub SysInfo1_DeviceRemovePending(ByVal DeviceType As Long, ByVal DeviceID As Long, ByVal DeviceName As String, ByVal DeviceData As Long)
    AddEvent "DeviceRemovePending", DeviceType, DeviceID, DeviceName, DeviceData
End Sub

Private Sub SysInfo1_DevModeChanged()
    AddEvent "DevModeChanged"
End Sub

Private Sub SysInfo1_DisplayChanged()
    AddEvent "DisplayChanged"
End Sub

Private Sub SysInfo1_PowerQuerySuspend(Cancel As Boolean)
    AddEvent "PowerQuerySuspend", Cancel
End Sub

Private Sub SysInfo1_PowerResume()
    AddEvent "PowerResume"
End Sub

Private Sub SysInfo1_PowerStatusChanged()
    AddEvent "PowerStatusChanged"
End Sub

Private Sub SysInfo1_PowerSuspend()
    AddEvent "PowerSuspend"
End Sub

Private Sub SysInfo1_QueryChangeConfig(Cancel As Boolean)
    AddEvent "QueryChangeConfig", Cancel
End Sub

Private Sub SysInfo1_SettingChanged(ByVal Item As Integer)
    AddEvent "SettingChanged", Item
End Sub

Private Sub SysInfo1_SysColorsChanged()
    AddEvent "SysColorsChanged"
End Sub

Private Sub SysInfo1_TimeChanged()
    AddEvent "TimeChanged"
End Sub

Sub AddEvent(eventname As String, ParamArray args() As Variant)
'##eventname.UseByVal Yes
    Dim txt As String, i As Integer
    txt = eventname
    If Not IsMissing(args) Then
        txt = txt & "("
        For i = 0 To UBound(args)
            txt = txt & IIf(i > 0, ",", "") & args(i)
        Next
        txt = txt & ")"
    End If
    lstEvents.AddItem txt
    lstEvents.ListIndex = lstEvents.ListCount - 1
End Sub




