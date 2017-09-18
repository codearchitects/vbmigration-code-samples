' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Private Sub cmdPower_Click() Handles cmdPower.Click
		With SysInfo1
			Picture1.Cls()
			Picture1.PrintLine("ACStatus = " & VB.Switch(.ACStatus = 0, "Battery", .ACStatus = 1, "AC Power", True, "Unknown"))
			Picture1.PrintLine("BatteryFullTime = " & IIf(.BatteryFullTime <> -1, .BatteryFullTime, "Unknown"))
			Picture1.PrintLine("BatteryLifePercent = " & IIf(.BatteryLifePercent <> 255, .BatteryLifePercent, "Unknown"))
			Picture1.PrintLine("BatteryLifeTime = " & IIf(.BatteryLifeTime <> -1, .BatteryLifeTime, "Unknown"))
			Picture1.PrintLine("BatteryStatus = " & VB.Switch(.BatteryStatus = 1, "High", .BatteryStatus = 2, "Low", .BatteryStatus = 4, "Critical", .BatteryStatus = 8, "Charging", .BatteryStatus = 128, "(no battery)", True, "Unknown"))
		End With
	End Sub

	Private Sub cmdWindows_Click() Handles cmdWindows.Click
		With SysInfo1
			Picture1.Cls()
			Picture1.PrintLine("OSPlatform = " & Choose(.OSPlatform + 1, "Win32s", "Windows 9x", "Windows NT"))
			Picture1.PrintLine("OSVersion = " & .OSVersion)
			Picture1.PrintLine("OSBuild = " & .OSBuild)
		End With
	End Sub

	Private Sub cmdScreen_Click() Handles cmdScreen.Click
		With SysInfo1
			Picture1.Cls()
			Picture1.PrintLine("WorkAreaLeft = " & .WorkAreaLeft)
			Picture1.PrintLine("WorkAreaTop = " & .WorkAreaTop)
			Picture1.PrintLine("WorkAreaWidth = " & .WorkAreaWidth)
			Picture1.PrintLine("WorkAreaHeight = " & .WorkAreaHeight)
			Picture1.PrintLine("ScrollBarSize = " & .ScrollBarSize)
		End With
	End Sub

	Private Sub cmdClear_Click() Handles cmdClear.Click
		lstEvents.Clear()
	End Sub

	Private Sub SysInfo1_ConfigChangeCancelled() Handles SysInfo1.ConfigChangeCancelled
		AddEvent("ConfigChangeCancelled")
	End Sub

	Private Sub SysInfo1_ConfigChanged(ByVal OldConfigNum As Integer, ByVal NewConfigNum As Integer) Handles SysInfo1.ConfigChanged
		AddEvent("ConfigChanged", OldConfigNum, NewConfigNum)
	End Sub

	Private Sub SysInfo1_DeviceArrival(ByVal DeviceType As Integer, ByVal DeviceID As Integer, ByVal DeviceName As String, ByVal DeviceData As Integer) Handles SysInfo1.DeviceArrival
		AddEvent("DeviceArrival", DeviceType, DeviceID, DeviceName, DeviceData)
	End Sub

	Private Sub SysInfo1_DeviceOtherEvent(ByVal DeviceType As Integer, ByVal eventname As String, ByVal DataPointer As Integer) Handles SysInfo1.DeviceOtherEvent
		AddEvent("DeviceOtherEvent", DeviceType, eventname, DataPointer)
	End Sub

	Private Sub SysInfo1_DeviceQueryRemove(ByVal DeviceType As Integer, ByVal DeviceID As Integer, ByVal DeviceName As String, ByVal DeviceData As Integer, ByRef Cancel As Boolean) Handles SysInfo1.DeviceQueryRemove
		AddEvent("DeviceQueryRemove", DeviceType, DeviceID, DeviceName, DeviceData, Cancel)
	End Sub

	Private Sub SysInfo1_DeviceQueryRemoveFailed(ByVal DeviceType As Integer, ByVal DeviceID As Integer, ByVal DeviceName As String, ByVal DeviceData As Integer) Handles SysInfo1.DeviceQueryRemoveFailed
		AddEvent("DeviceQueryRemoveFailed", DeviceType, DeviceID, DeviceName, DeviceData)
	End Sub

	Private Sub SysInfo1_DeviceRemoveComplete(ByVal DeviceType As Integer, ByVal DeviceID As Integer, ByVal DeviceName As String, ByVal DeviceData As Integer) Handles SysInfo1.DeviceRemoveComplete
		AddEvent("DeviceRemoveComplete", DeviceType, DeviceID, DeviceName, DeviceData)
	End Sub

	Private Sub SysInfo1_DeviceRemovePending(ByVal DeviceType As Integer, ByVal DeviceID As Integer, ByVal DeviceName As String, ByVal DeviceData As Integer) Handles SysInfo1.DeviceRemovePending
		AddEvent("DeviceRemovePending", DeviceType, DeviceID, DeviceName, DeviceData)
	End Sub

	Private Sub SysInfo1_DevModeChanged() Handles SysInfo1.DevModeChanged
		AddEvent("DevModeChanged")
	End Sub

	Private Sub SysInfo1_DisplayChanged() Handles SysInfo1.DisplayChanged
		AddEvent("DisplayChanged")
	End Sub

	Private Sub SysInfo1_PowerQuerySuspend(ByRef Cancel As Boolean) Handles SysInfo1.PowerQuerySuspend
		AddEvent("PowerQuerySuspend", Cancel)
	End Sub

	Private Sub SysInfo1_PowerResume() Handles SysInfo1.PowerResume
		AddEvent("PowerResume")
	End Sub

	Private Sub SysInfo1_PowerStatusChanged() Handles SysInfo1.PowerStatusChanged
		AddEvent("PowerStatusChanged")
	End Sub

	Private Sub SysInfo1_PowerSuspend() Handles SysInfo1.PowerSuspend
		AddEvent("PowerSuspend")
	End Sub

	Private Sub SysInfo1_QueryChangeConfig(ByRef Cancel As Boolean) Handles SysInfo1.QueryChangeConfig
		AddEvent("QueryChangeConfig", Cancel)
	End Sub

	Private Sub SysInfo1_SettingChanged(ByVal Item As Short) Handles SysInfo1.SettingChanged
		AddEvent("SettingChanged", Item)
	End Sub

	Private Sub SysInfo1_SysColorsChanged() Handles SysInfo1.SysColorsChanged
		AddEvent("SysColorsChanged")
	End Sub

	Private Sub SysInfo1_TimeChanged() Handles SysInfo1.TimeChanged
		AddEvent("TimeChanged")
	End Sub

	Public Sub AddEvent(ByVal eventname As String, ByVal ParamArray args() As Object)
		Dim txt As String = ""
		Dim i As Short
		txt = eventname
		If Not IsMissing6(args) Then 
			txt &= "("
			For i = 0 To UBound6(args)
				txt = txt & IIf(i > 0, ",", "") & args(i)
			Next
			txt &= ")"
		End If
		lstEvents.AddItem(txt)
		lstEvents.ListIndex = lstEvents.ListCount - 1
	End Sub

End Class
