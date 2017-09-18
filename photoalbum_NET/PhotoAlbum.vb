' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class PhotoAlbum

	Private Sub Check1_Click() Handles Check1.Click
		
		If Check1.Value = 0 Then 
			Picture2.Visible = False
			VScroll1.Visible = False
			Label1.Caption = "Proporzione immagine:"
			Label2.Caption = ""
			Label3.Visible = False
		Else
			Label1.Caption = "ATTENDERE..."
			Label2.Caption = "100%"
			File1_PathChange()
		End If
		
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		
		Load6(ScrollPicture)
		
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		
		Application.Exit(): End
		
	End Sub

	Private Sub Dir1_Change() Handles Dir1.Change
		
		File1.Path = Dir1.Path
		
	End Sub

	Private Sub Drive1_Change() Handles Drive1.Change
		
		On Error Resume Next 
		Dir1.Path = Drive1.Drive
		If Err.Number Then 
			MsgBox6("PERIFERICA NON DISPONIBILE", MsgBoxStyle.Exclamation, "Attenzione...")
			Drive1.Drive = VB.Left(Dir1.Path, 2)
		End If
		
	End Sub

	Private Sub File1_Click() Handles File1.Click
		
		On Error Resume Next 
		
		Picture1.Cls()
		
		Image1.Picture = LoadPicture6(Dir1.Path & "\" & File1.List(File1.ListIndex))
		If Err.Number Then 
			Image1.Picture = Image2.Picture
			Err.Number = 0
		End If
		
		Scala = 1
		
		Alt = Image1.Height
		Larg = Image1.Width
		
		hgt = Alt
		wid = Larg
		
		If Alt > Picture1.Height Or Larg > Picture1.Width Then 
			If Alt > Larg Then 
				Scala = Alt / Picture1.Height
				hgt = Alt / Scala
				wid = Larg / Scala
			Else
				Scala = Larg / Picture1.Width
				hgt = Alt / Scala
				wid = Larg / Scala
			End If
		End If
		
		PctRid = 100 / Scala
		
		Y = (Picture1.Height - hgt) / 2
		X = (Picture1.Width - wid) / 2
		
		YZ = File1.ListIndex Mod 4
		XZ = Int(File1.ListIndex / 4)
		
		If Picture2.Visible = False Then 
			Label2.Caption = CInt(PctRid) & "%"
			Picture1.PaintPicture(Image1.Picture, X, Y, wid, hgt)
		Else
			Label3.Left = YZ * 1100
			Label3.Top = XZ * 1100
			'******** MAH!!?! ********'
			Picture2.Top = -(1100 * XZ)
			'*************************'
		End If
		
	End Sub

	Private Sub File1_DblClick() Handles File1.DblClick
		
		Check1.Value = 0
		Picture2.Visible = False
		VScroll1.Visible = False
		File1_Click()
		
	End Sub

	Private Sub File1_PathChange() Handles File1.PathChange
		
		On Error Resume Next 
		
		Picture2.Cls()
		Label3.Visible = False
		
		X2 = 0
		Y2 = 0
		
		If Check1.Value = 1 Then 
			If File1.ListCount > 0 Then 
				Picture2.Visible = True
				VScroll1.Visible = True
				Picture2.Height = (Int(File1.ListCount / 4) * 1100)
				If (File1.ListCount Mod 4) <> 0 Then 
					Picture2.Height += 1200
				End If
				If (Picture2.Height - Picture1.Height) > 32000 Then 
					Prop = (Picture2.Height - Picture1.Height) / 32000
					PropVal = (Picture2.Height - Picture1.Height) / Prop
				Else
					Prop = 1
					PropVal = Picture2.Height - Picture1.Height
				End If
				VScroll1.Max = PropVal
				For Ind = 0 To File1.ListCount - 1
					Err.Number = 0
					DoEvents6()
					Label2.Caption = Ind + 1
					Image1.Picture = LoadPicture6(Dir1.Path & "\" & File1.List(Ind))
					If Err.Number Then 
						Image1.Picture = Image2.Picture
					End If
					
					Alt = Image1.Height
					Larg = Image1.Width
					
					hgt = Alt
					wid = Larg
					
					If Alt > 1000 Or Larg > 1000 Then 
						If Alt > Larg Then 
							Scala = Alt / 1000
							hgt = Alt / Scala
							wid = Larg / Scala
						Else
							Scala = Larg / 1000
							hgt = Alt / Scala
							wid = Larg / Scala
						End If
					End If
					
					XX = (X2 * 1100)
					YY = (Y2 * 1100)
					
					Picture2.PaintPicture(Image1.Picture, XX + ((1100 - wid) / 2), YY + ((1100 - hgt) / 2), wid, hgt)
					X2 += 1
					If X2 > 3 Then 
						X2 = 0
						Y2 += 1
					End If
				Next
				Label1.Caption = "Immagini caricate:"
				File1.SetFocus()
				File1.Selected(0) = True
				Label3.Visible = True
			End If
		End If
		
		VScroll1.Value = 0
		If Picture1.Height > Picture2.Height Then 
			VScroll1.Enabled = False
			Picture2.Height = Picture1.Height
			VScroll1.Max = 0
		Else
			VScroll1.Enabled = True
		End If
		
	End Sub

	Private Sub Label3_Click() Handles Label3.Click
		
		File1_DblClick()
		
	End Sub

	Private Sub Picture2_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles Picture2.MouseUp
		
		On Error Resume Next 
		
		XPic = Int(X / 1100)
		YPic = Int(Y / 1100)
		
		XY = (YPic * 3) + YPic + XPic
		
		File1.Selected(XY) = True
		If Err.Number Then  Exit Sub
		
		File1_Click()
		
	End Sub

	Private Sub VScroll1_Change() Handles VScroll1.Change
		
		VScroll1_Scroll()
		
	End Sub

	Private Sub VScroll1_Scroll() Handles VScroll1.Scroll
		
		Picture2.Top = -VScroll1.Value * Prop
		
	End Sub

End Class
