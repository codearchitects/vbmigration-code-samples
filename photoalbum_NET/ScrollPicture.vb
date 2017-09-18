' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class ScrollPicture

	Private Sub PrintCenter(ByRef C As Control, ByRef Txt As String)
		CObj(C).CurrentX = (CObj(C).ScaleWidth - CObj(C).TextWidth(Txt)) / 2
		CObj(C).PrintLine(Txt)
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		
		' UPGRADE_INFO (#0181): Reference to default form instance 'ScrollPicture' was converted to Me keyword.
		Unload6(Me)
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
		Show()
		
		Picture1.Cls()
		Timer1.Enabled = 0
		Picture2.Visible = 0
		Picture2.AutoRedraw = -1
		Picture2.Top = Picture1.ScaleHeight
		Picture2.BackColor = Picture1.BackColor
		Picture2.Height = 16 * Picture1.TextHeight("A")
		Picture2.CurrentY = 0
		
		PrintCenter(Picture2, "Photo Album ver. " & App6.Major & "." & App6.Minor & "." & App6.Revision)
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "Software designed by:")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "TOTARO Salvatore")
		PrintCenter(Picture2, "aka")
		PrintCenter(Picture2, "PaperQuack")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "For bugs, info or reports please")
		PrintCenter(Picture2, "eMail us to: paperquak@libero.it")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "")
		PrintCenter(Picture2, "This program is FREEWARE!")
		PrintCenter(Picture2, "You can distriduited it as is.")
		
		Picture2.Visible = -1
		Timer1.Enabled = -1
		
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		
		Delta = Val(Timer1.Tag)
		Picture1.ScaleMode = 3
		If Picture2.Top + Picture2.Height > 0 Then 
			Picture2.Top -= Delta
		Else
			Picture1.Cls()
			Timer1.Enabled = 0
			Picture2.Visible = 0
			Picture2.AutoRedraw = -1
			Picture2.Top = Picture1.ScaleHeight
			Picture2.BackColor = Picture1.BackColor
			Picture2.Height = 16 * Picture1.TextHeight("A")
			Picture2.CurrentY = 0
			
			PrintCenter(Picture2, "Photo Album ver. " & App6.Major & "." & App6.Minor & "." & App6.Revision)
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "Software designed by:")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "TOTARO Salvatore")
			PrintCenter(Picture2, "aka")
			PrintCenter(Picture2, "PaperQuack")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "For bugs, info or reports please")
			PrintCenter(Picture2, "eMail us to: paperquak@libero.it")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "")
			PrintCenter(Picture2, "This program is FREEWARE!")
			PrintCenter(Picture2, "You can distriduited it as is.")
			
			Picture2.Visible = -1
			Timer1.Enabled = -1
		End If
		
	End Sub

End Class
