' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module One

	'8o. Adam Spicer .o8'

	Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
	
	' UPGRADE_INFO (#0561): The 'hesitator' symbol was defined without an explicit "As" clause.
	Private hesitator As Object
	
	Public ShiPcount As Short
	Public WhiCHway As String = ""
	Public whichMNU As String = ""
	Public FORMtagg As Short
	
	Public Function PlayWav(ByRef Snd As String) As Object
	' UPGRADE_INFO (#0561): The 'PlayWav' symbol was defined without an explicit "As" clause.
		' UPGRADE_INFO (#0561): The 'PlayIt' symbol was defined without an explicit "As" clause.
		Dim PlayIt As Object = Nothing
		Snd = App6.Path & "/" & "sounds/" & Snd
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'PlayIt'. Consider using the SetDefaultMember6 helper method.
		PlayIt = sndPlaySound(Snd, 1)
		
	End Function

	Public Function CenterForm(ByRef frm As VB6Form) As Object
	' UPGRADE_INFO (#0561): The 'CenterForm' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'frm' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		frm.Top = (Screen6.Height - frm.Height) / 2
		frm.Left = (Screen6.Width - frm.Width) / 2
		
	End Function

	Public Function TimeOUT(ByRef HesitateTime As Object) As Object
	' UPGRADE_INFO (#0561): The 'TimeOUT' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0561): The 'HesitateTime' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'HesitateTime' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'hesitator'. Consider using the SetDefaultMember6 helper method.
		hesitator = Timer6
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'hesitator'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'HesitateTime'. Consider using the GetDefaultMember6 helper method.
		Do While Timer6 - hesitator < Val(HesitateTime)
			DoEvents6()
		Loop
		
	End Function

End Module
