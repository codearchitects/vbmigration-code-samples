' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Public Sub LoadDrivesIntoImageCombo(ByRef ImgCombo As VB6ImageCombo)
	' UPGRADE_INFO (#0551): The 'ImgCombo' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim fso As New VB6FileSystemObject
		Dim dr As VB6Drive = Nothing
		Dim drLabel As String = ""
		Dim drImage As String = ""
		
		' assumes that the ImageCombo control is linked to an ImageList
		' control that includes three icons with the following key names
		ImgCombo.ComboItems.Add(, , "My Computer", "MyComputer")
		For Each dr In fso.Drives
			' a different image for each type of drive
			Select Case dr.DriveType
			Case Scripting.DriveTypeConst.Removable: drImage = "FloppyDrive"
			Case Scripting.DriveTypeConst.CDRom: drImage = "CDDrive"
			Case Else: drImage = "HardDrive"
			End Select
			' retrieve the letter and (if possible) the volume label
			drLabel = dr.DriveLetter & ": "
			If dr.IsReady Then 
				If Len6(dr.VolumeName) Then  drLabel = drLabel & "[" & dr.VolumeName & "]"
			End If
			' add an indented item to the combo
			ImgCombo.ComboItems.Add(, dr.DriveLetter, drLabel, drImage, , 2)
		Next
		' select the current drive
		ImgCombo.SelectedItem = ImgCombo.ComboItems(VB.Left(CurDir6(), 1))
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		LoadDrivesIntoImageCombo(ImageCombo1)
	End Sub

	Private Sub ImageCombo1_Click() Handles ImageCombo1.Click
		Dim fso As New VB6FileSystemObject
		Dim dr As VB6Drive = Nothing
		
		On Error Resume Next 
		dr = fso.Drives(ImageCombo1.SelectedItem.Key)
		picInfo.Cls()
		If Err.Number Then  Exit Sub
		
		picInfo.PrintLine("Drive " & dr.DriveLetter & ":")
		picInfo.PrintLine()
		picInfo.PrintLine("Volume Name = " & dr.VolumeName)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dr.AvailableSpace'. Consider using the GetDefaultMember6 helper method.
		picInfo.PrintLine("Available Space = " & dr.AvailableSpace)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dr.FreeSpace'. Consider using the GetDefaultMember6 helper method.
		picInfo.PrintLine("Free Space = " & dr.FreeSpace)
		picInfo.PrintLine("Serial Number = " & Hex(dr.SerialNumber))
		' UPGRADE_ISSUE (#1B28): ShareName property isn't supported. This replacement property always returns an empty string
		picInfo.PrintLine("Share Name = " & dr.ShareName)
		
	End Sub

End Class
