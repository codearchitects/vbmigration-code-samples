' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Colore As Integer
	Private Neri As Short
	Private Bianchi As Short
	Private T1 As Short
	Private T2 As Short
	Private T3 As Short
	Private T4 As Short
	Private T5 As Short
	Private Color1 As Short
	Private Color2 As Short
	Private Color3 As Short
	Private Color4 As Short
	Private Color5 As Short
	Private Color1a As Boolean
	Private Color2a As Boolean
	Private Color3a As Boolean
	Private Color4a As Boolean
	Private Color5a As Boolean
	Private A1 As Boolean
	Private A2 As Boolean
	Private A3 As Boolean
	Private A4 As Boolean
	Private A5 As Boolean
	Private Ripetere As Boolean
	
	Public Function Rand(ByVal Low As Integer, ByVal High As Integer) As Integer
		
		Randomize()
		Low = 1
		High = 6
		Return Int((High - Low + 1) * Rnd()) + Low
		
	End Function

	Private Sub Bianco_Click() Handles Bianco.Click
		Colore = VBRUN.ColorConstants.vbWhite
		Col6.BorderColor = Color.White 
		Col1.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		ColScelto.BackColor = Color.White 
	End Sub

	Private Sub Blu_Click() Handles Blu.Click
		Colore = VBRUN.ColorConstants.vbBlue
		Col1.BorderColor = Color.White 
		Col6.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		ColScelto.BackColor = Color.Blue 
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		If Tent1_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent1_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent1_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent1_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent1_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent1_1.BackColor = Color.Black 
			RispTent1_2.BackColor = Color.Black 
			RispTent1_3.BackColor = Color.Black 
			RispTent1_4.BackColor = Color.Black 
			RispTent1_5.BackColor = Color.Black 
		Else
			
			'* provo prima a vedere se ci sono i colori nelle posizioni *
			'* e poi proverò se ci sono nelle posizioni sbagliate *
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			'* controllo il primo colore inserito nel primo cerchietto *
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			'* controllo il secondo colore inserito nel secondo cerchietto *
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			'* controllo il terzo colore inserito nel terzo cerchietto *
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			'* controllo il quarto colore inserito nel quarto cerchietto *
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			'* controllo il quinto colore inserito nel quinto cerchietto *
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent1_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent1_1.BackColor = Color.Black 
				RispTent1_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent1_1.BackColor = Color.Black 
				RispTent1_2.BackColor = Color.Black 
				RispTent1_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent1_1.BackColor = Color.Black 
				RispTent1_2.BackColor = Color.Black 
				RispTent1_3.BackColor = Color.Black 
				RispTent1_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent1_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_1.BackColor = Color.White 
				ElseIf RispTent1_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_2.BackColor = Color.White 
				ElseIf RispTent1_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_3.BackColor = Color.White 
				ElseIf RispTent1_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent1_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_1.BackColor = Color.White 
					RispTent1_2.BackColor = Color.White 
				ElseIf RispTent1_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_2.BackColor = Color.White 
					RispTent1_3.BackColor = Color.White 
				ElseIf RispTent1_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_3.BackColor = Color.White 
					RispTent1_4.BackColor = Color.White 
				ElseIf RispTent1_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_4.BackColor = Color.White 
					RispTent1_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent1_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_1.BackColor = Color.White 
					RispTent1_2.BackColor = Color.White 
					RispTent1_3.BackColor = Color.White 
				ElseIf RispTent1_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_2.BackColor = Color.White 
					RispTent1_3.BackColor = Color.White 
					RispTent1_4.BackColor = Color.White 
				ElseIf RispTent1_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_3.BackColor = Color.White 
					RispTent1_4.BackColor = Color.White 
					RispTent1_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent1_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_1.BackColor = Color.White 
					RispTent1_2.BackColor = Color.White 
					RispTent1_3.BackColor = Color.White 
					RispTent1_4.BackColor = Color.White 
				ElseIf RispTent1_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent1_2.BackColor = Color.White 
					RispTent1_3.BackColor = Color.White 
					RispTent1_4.BackColor = Color.White 
					RispTent1_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent1_1.BackColor = Color.White 
				RispTent1_2.BackColor = Color.White 
				RispTent1_3.BackColor = Color.White 
				RispTent1_4.BackColor = Color.White 
				RispTent1_5.BackColor = Color.White 
			End If
			
			LabTent1_1.Enabled = False
			LabTent1_2.Enabled = False
			LabTent1_3.Enabled = False
			LabTent1_4.Enabled = False
			LabTent1_5.Enabled = False
			
			LabTent2_1.Enabled = True
			LabTent2_2.Enabled = True
			LabTent2_3.Enabled = True
			LabTent2_4.Enabled = True
			LabTent2_5.Enabled = True
			
			Command1.Visible = False
			Command2.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command10_Click() Handles Command10.Click
		If Tent10_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent10_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent10_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent10_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent10_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent10_1.BackColor = Color.Black 
			RispTent10_2.BackColor = Color.Black 
			RispTent10_3.BackColor = Color.Black 
			RispTent10_4.BackColor = Color.Black 
			RispTent10_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent10_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent10_1.BackColor = Color.Black 
				RispTent10_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent10_1.BackColor = Color.Black 
				RispTent10_2.BackColor = Color.Black 
				RispTent10_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent10_1.BackColor = Color.Black 
				RispTent10_2.BackColor = Color.Black 
				RispTent10_3.BackColor = Color.Black 
				RispTent10_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent10_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_1.BackColor = Color.White 
				ElseIf RispTent10_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_2.BackColor = Color.White 
				ElseIf RispTent10_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_3.BackColor = Color.White 
				ElseIf RispTent10_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent10_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_1.BackColor = Color.White 
					RispTent10_2.BackColor = Color.White 
				ElseIf RispTent10_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_2.BackColor = Color.White 
					RispTent10_3.BackColor = Color.White 
				ElseIf RispTent10_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_3.BackColor = Color.White 
					RispTent10_4.BackColor = Color.White 
				ElseIf RispTent10_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_4.BackColor = Color.White 
					RispTent10_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent10_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_1.BackColor = Color.White 
					RispTent10_2.BackColor = Color.White 
					RispTent10_3.BackColor = Color.White 
				ElseIf RispTent10_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_2.BackColor = Color.White 
					RispTent10_3.BackColor = Color.White 
					RispTent10_4.BackColor = Color.White 
				ElseIf RispTent10_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_3.BackColor = Color.White 
					RispTent10_4.BackColor = Color.White 
					RispTent10_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent10_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_1.BackColor = Color.White 
					RispTent10_2.BackColor = Color.White 
					RispTent10_3.BackColor = Color.White 
					RispTent10_4.BackColor = Color.White 
				ElseIf RispTent10_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent10_2.BackColor = Color.White 
					RispTent10_3.BackColor = Color.White 
					RispTent10_4.BackColor = Color.White 
					RispTent10_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent10_1.BackColor = Color.White 
				RispTent10_2.BackColor = Color.White 
				RispTent10_3.BackColor = Color.White 
				RispTent10_4.BackColor = Color.White 
				RispTent10_5.BackColor = Color.White 
			End If
			
			LabTent10_1.Enabled = False
			LabTent10_2.Enabled = False
			LabTent10_3.Enabled = False
			LabTent10_4.Enabled = False
			LabTent10_5.Enabled = False
			
			LabTent11_1.Enabled = True
			LabTent11_2.Enabled = True
			LabTent11_3.Enabled = True
			LabTent11_4.Enabled = True
			LabTent11_5.Enabled = True
			
			Command10.Visible = False
			Command11.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
			
		End If
	End Sub

	Private Sub Command11_Click() Handles Command11.Click
		If Tent11_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent11_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent11_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent11_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent11_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent11_1.BackColor = Color.Black 
			RispTent11_2.BackColor = Color.Black 
			RispTent11_3.BackColor = Color.Black 
			RispTent11_4.BackColor = Color.Black 
			RispTent11_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent11_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent11_1.BackColor = Color.Black 
				RispTent11_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent11_1.BackColor = Color.Black 
				RispTent11_2.BackColor = Color.Black 
				RispTent11_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent11_1.BackColor = Color.Black 
				RispTent11_2.BackColor = Color.Black 
				RispTent11_3.BackColor = Color.Black 
				RispTent11_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent11_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_1.BackColor = Color.White 
				ElseIf RispTent11_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_2.BackColor = Color.White 
				ElseIf RispTent11_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_3.BackColor = Color.White 
				ElseIf RispTent11_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent11_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_1.BackColor = Color.White 
					RispTent11_2.BackColor = Color.White 
				ElseIf RispTent11_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_2.BackColor = Color.White 
					RispTent11_3.BackColor = Color.White 
				ElseIf RispTent11_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_3.BackColor = Color.White 
					RispTent11_4.BackColor = Color.White 
				ElseIf RispTent11_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_4.BackColor = Color.White 
					RispTent11_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent11_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_1.BackColor = Color.White 
					RispTent11_2.BackColor = Color.White 
					RispTent11_3.BackColor = Color.White 
				ElseIf RispTent11_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_2.BackColor = Color.White 
					RispTent11_3.BackColor = Color.White 
					RispTent11_4.BackColor = Color.White 
				ElseIf RispTent11_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_3.BackColor = Color.White 
					RispTent11_4.BackColor = Color.White 
					RispTent11_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent11_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_1.BackColor = Color.White 
					RispTent11_2.BackColor = Color.White 
					RispTent11_3.BackColor = Color.White 
					RispTent11_4.BackColor = Color.White 
				ElseIf RispTent11_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent11_2.BackColor = Color.White 
					RispTent11_3.BackColor = Color.White 
					RispTent11_4.BackColor = Color.White 
					RispTent11_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent11_1.BackColor = Color.White 
				RispTent11_2.BackColor = Color.White 
				RispTent11_3.BackColor = Color.White 
				RispTent11_4.BackColor = Color.White 
				RispTent11_5.BackColor = Color.White 
			End If
			
			LabTent11_1.Enabled = False
			LabTent11_2.Enabled = False
			LabTent11_3.Enabled = False
			LabTent11_4.Enabled = False
			LabTent11_5.Enabled = False
			
			LabTent12_1.Enabled = True
			LabTent12_2.Enabled = True
			LabTent12_3.Enabled = True
			LabTent12_4.Enabled = True
			LabTent12_5.Enabled = True
			
			Command11.Visible = False
			Command12.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
			
		End If
	End Sub

	Private Sub Command12_Click() Handles Command12.Click
		If Tent12_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent12_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent12_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent12_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent12_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent12_1.BackColor = Color.Black 
			RispTent12_2.BackColor = Color.Black 
			RispTent12_3.BackColor = Color.Black 
			RispTent12_4.BackColor = Color.Black 
			RispTent12_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent12_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent12_1.BackColor = Color.Black 
				RispTent12_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent12_1.BackColor = Color.Black 
				RispTent12_2.BackColor = Color.Black 
				RispTent12_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent12_1.BackColor = Color.Black 
				RispTent12_2.BackColor = Color.Black 
				RispTent12_3.BackColor = Color.Black 
				RispTent12_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent12_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_1.BackColor = Color.White 
				ElseIf RispTent12_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_2.BackColor = Color.White 
				ElseIf RispTent12_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_3.BackColor = Color.White 
				ElseIf RispTent12_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent12_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_1.BackColor = Color.White 
					RispTent12_2.BackColor = Color.White 
				ElseIf RispTent12_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_2.BackColor = Color.White 
					RispTent12_3.BackColor = Color.White 
				ElseIf RispTent12_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_3.BackColor = Color.White 
					RispTent12_4.BackColor = Color.White 
				ElseIf RispTent12_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_4.BackColor = Color.White 
					RispTent12_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent12_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_1.BackColor = Color.White 
					RispTent12_2.BackColor = Color.White 
					RispTent12_3.BackColor = Color.White 
				ElseIf RispTent12_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_2.BackColor = Color.White 
					RispTent12_3.BackColor = Color.White 
					RispTent12_4.BackColor = Color.White 
				ElseIf RispTent12_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_3.BackColor = Color.White 
					RispTent12_4.BackColor = Color.White 
					RispTent12_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent12_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_1.BackColor = Color.White 
					RispTent12_2.BackColor = Color.White 
					RispTent12_3.BackColor = Color.White 
					RispTent12_4.BackColor = Color.White 
				ElseIf RispTent12_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent12_2.BackColor = Color.White 
					RispTent12_3.BackColor = Color.White 
					RispTent12_4.BackColor = Color.White 
					RispTent12_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent12_1.BackColor = Color.White 
				RispTent12_2.BackColor = Color.White 
				RispTent12_3.BackColor = Color.White 
				RispTent12_4.BackColor = Color.White 
				RispTent12_5.BackColor = Color.White 
			End If
			
			LabTent12_1.Enabled = False
			LabTent12_2.Enabled = False
			LabTent12_3.Enabled = False
			LabTent12_4.Enabled = False
			LabTent12_5.Enabled = False
			
			Command12.Visible = False
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
			
			MsgBox6("Soluzione non trovata!", MsgBoxStyle.Critical, "Soluzione non trovata")
			Form2.NuovaPart_Click()
			
		End If
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If Tent2_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent2_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent2_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent2_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent2_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent2_1.BackColor = Color.Black 
			RispTent2_2.BackColor = Color.Black 
			RispTent2_3.BackColor = Color.Black 
			RispTent2_4.BackColor = Color.Black 
			RispTent2_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent2_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent2_1.BackColor = Color.Black 
				RispTent2_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent2_1.BackColor = Color.Black 
				RispTent2_2.BackColor = Color.Black 
				RispTent2_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent2_1.BackColor = Color.Black 
				RispTent2_2.BackColor = Color.Black 
				RispTent2_3.BackColor = Color.Black 
				RispTent2_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent2_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_1.BackColor = Color.White 
				ElseIf RispTent2_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_2.BackColor = Color.White 
				ElseIf RispTent2_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_3.BackColor = Color.White 
				ElseIf RispTent2_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent2_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_1.BackColor = Color.White 
					RispTent2_2.BackColor = Color.White 
				ElseIf RispTent2_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_2.BackColor = Color.White 
					RispTent2_3.BackColor = Color.White 
				ElseIf RispTent2_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_3.BackColor = Color.White 
					RispTent2_4.BackColor = Color.White 
				ElseIf RispTent2_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_4.BackColor = Color.White 
					RispTent2_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent2_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_1.BackColor = Color.White 
					RispTent2_2.BackColor = Color.White 
					RispTent2_3.BackColor = Color.White 
				ElseIf RispTent2_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_2.BackColor = Color.White 
					RispTent2_3.BackColor = Color.White 
					RispTent2_4.BackColor = Color.White 
				ElseIf RispTent2_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_3.BackColor = Color.White 
					RispTent2_4.BackColor = Color.White 
					RispTent2_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent2_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_1.BackColor = Color.White 
					RispTent2_2.BackColor = Color.White 
					RispTent2_3.BackColor = Color.White 
					RispTent2_4.BackColor = Color.White 
				ElseIf RispTent2_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent2_2.BackColor = Color.White 
					RispTent2_3.BackColor = Color.White 
					RispTent2_4.BackColor = Color.White 
					RispTent2_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent2_1.BackColor = Color.White 
				RispTent2_2.BackColor = Color.White 
				RispTent2_3.BackColor = Color.White 
				RispTent2_4.BackColor = Color.White 
				RispTent2_5.BackColor = Color.White 
			End If
			
			LabTent2_1.Enabled = False
			LabTent2_2.Enabled = False
			LabTent2_3.Enabled = False
			LabTent2_4.Enabled = False
			LabTent2_5.Enabled = False
			
			LabTent3_1.Enabled = True
			LabTent3_2.Enabled = True
			LabTent3_3.Enabled = True
			LabTent3_4.Enabled = True
			LabTent3_5.Enabled = True
			
			Command2.Visible = False
			Command3.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		If Tent3_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent3_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent3_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent3_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent3_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent3_1.BackColor = Color.Black 
			RispTent3_2.BackColor = Color.Black 
			RispTent3_3.BackColor = Color.Black 
			RispTent3_4.BackColor = Color.Black 
			RispTent3_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent3_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent3_1.BackColor = Color.Black 
				RispTent3_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent3_1.BackColor = Color.Black 
				RispTent3_2.BackColor = Color.Black 
				RispTent3_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent3_1.BackColor = Color.Black 
				RispTent3_2.BackColor = Color.Black 
				RispTent3_3.BackColor = Color.Black 
				RispTent3_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent3_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_1.BackColor = Color.White 
				ElseIf RispTent3_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_2.BackColor = Color.White 
				ElseIf RispTent3_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_3.BackColor = Color.White 
				ElseIf RispTent3_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent3_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_1.BackColor = Color.White 
					RispTent3_2.BackColor = Color.White 
				ElseIf RispTent3_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_2.BackColor = Color.White 
					RispTent3_3.BackColor = Color.White 
				ElseIf RispTent3_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_3.BackColor = Color.White 
					RispTent3_4.BackColor = Color.White 
				ElseIf RispTent3_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_4.BackColor = Color.White 
					RispTent3_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent3_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_1.BackColor = Color.White 
					RispTent3_2.BackColor = Color.White 
					RispTent3_3.BackColor = Color.White 
				ElseIf RispTent3_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_2.BackColor = Color.White 
					RispTent3_3.BackColor = Color.White 
					RispTent3_4.BackColor = Color.White 
				ElseIf RispTent3_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_3.BackColor = Color.White 
					RispTent3_4.BackColor = Color.White 
					RispTent3_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent3_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_1.BackColor = Color.White 
					RispTent3_2.BackColor = Color.White 
					RispTent3_3.BackColor = Color.White 
					RispTent3_4.BackColor = Color.White 
				ElseIf RispTent3_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent3_2.BackColor = Color.White 
					RispTent3_3.BackColor = Color.White 
					RispTent3_4.BackColor = Color.White 
					RispTent3_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent3_1.BackColor = Color.White 
				RispTent3_2.BackColor = Color.White 
				RispTent3_3.BackColor = Color.White 
				RispTent3_4.BackColor = Color.White 
				RispTent3_5.BackColor = Color.White 
			End If
			
			LabTent3_1.Enabled = False
			LabTent3_2.Enabled = False
			LabTent3_3.Enabled = False
			LabTent3_4.Enabled = False
			LabTent3_5.Enabled = False
			
			LabTent4_1.Enabled = True
			LabTent4_2.Enabled = True
			LabTent4_3.Enabled = True
			LabTent4_4.Enabled = True
			LabTent4_5.Enabled = True
			
			Command3.Visible = False
			Command4.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		If Tent4_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent4_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent4_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent4_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent4_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent4_1.BackColor = Color.Black 
			RispTent4_2.BackColor = Color.Black 
			RispTent4_3.BackColor = Color.Black 
			RispTent4_4.BackColor = Color.Black 
			RispTent4_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent4_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent4_1.BackColor = Color.Black 
				RispTent4_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent4_1.BackColor = Color.Black 
				RispTent4_2.BackColor = Color.Black 
				RispTent4_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent4_1.BackColor = Color.Black 
				RispTent4_2.BackColor = Color.Black 
				RispTent4_3.BackColor = Color.Black 
				RispTent4_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent4_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_1.BackColor = Color.White 
				ElseIf RispTent4_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_2.BackColor = Color.White 
				ElseIf RispTent4_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_3.BackColor = Color.White 
				ElseIf RispTent4_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent4_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_1.BackColor = Color.White 
					RispTent4_2.BackColor = Color.White 
				ElseIf RispTent4_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_2.BackColor = Color.White 
					RispTent4_3.BackColor = Color.White 
				ElseIf RispTent4_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_3.BackColor = Color.White 
					RispTent4_4.BackColor = Color.White 
				ElseIf RispTent4_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_4.BackColor = Color.White 
					RispTent4_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent4_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_1.BackColor = Color.White 
					RispTent4_2.BackColor = Color.White 
					RispTent4_3.BackColor = Color.White 
				ElseIf RispTent4_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_2.BackColor = Color.White 
					RispTent4_3.BackColor = Color.White 
					RispTent4_4.BackColor = Color.White 
				ElseIf RispTent4_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_3.BackColor = Color.White 
					RispTent4_4.BackColor = Color.White 
					RispTent4_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent4_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_1.BackColor = Color.White 
					RispTent4_2.BackColor = Color.White 
					RispTent4_3.BackColor = Color.White 
					RispTent4_4.BackColor = Color.White 
				ElseIf RispTent4_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent4_2.BackColor = Color.White 
					RispTent4_3.BackColor = Color.White 
					RispTent4_4.BackColor = Color.White 
					RispTent4_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent4_1.BackColor = Color.White 
				RispTent4_2.BackColor = Color.White 
				RispTent4_3.BackColor = Color.White 
				RispTent4_4.BackColor = Color.White 
				RispTent4_5.BackColor = Color.White 
			End If
			
			LabTent4_1.Enabled = False
			LabTent4_2.Enabled = False
			LabTent4_3.Enabled = False
			LabTent4_4.Enabled = False
			LabTent4_5.Enabled = False
			
			LabTent5_1.Enabled = True
			LabTent5_2.Enabled = True
			LabTent5_3.Enabled = True
			LabTent5_4.Enabled = True
			LabTent5_5.Enabled = True
			
			Command4.Visible = False
			Command5.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command5_Click() Handles Command5.Click
		If Tent5_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent5_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent5_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent5_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent5_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent5_1.BackColor = Color.Black 
			RispTent5_2.BackColor = Color.Black 
			RispTent5_3.BackColor = Color.Black 
			RispTent5_4.BackColor = Color.Black 
			RispTent5_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent5_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent5_1.BackColor = Color.Black 
				RispTent5_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent5_1.BackColor = Color.Black 
				RispTent5_2.BackColor = Color.Black 
				RispTent5_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent5_1.BackColor = Color.Black 
				RispTent5_2.BackColor = Color.Black 
				RispTent5_3.BackColor = Color.Black 
				RispTent5_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent5_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_1.BackColor = Color.White 
				ElseIf RispTent5_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_2.BackColor = Color.White 
				ElseIf RispTent5_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_3.BackColor = Color.White 
				ElseIf RispTent5_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent5_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_1.BackColor = Color.White 
					RispTent5_2.BackColor = Color.White 
				ElseIf RispTent5_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_2.BackColor = Color.White 
					RispTent5_3.BackColor = Color.White 
				ElseIf RispTent5_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_3.BackColor = Color.White 
					RispTent5_4.BackColor = Color.White 
				ElseIf RispTent5_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_4.BackColor = Color.White 
					RispTent5_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent5_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_1.BackColor = Color.White 
					RispTent5_2.BackColor = Color.White 
					RispTent5_3.BackColor = Color.White 
				ElseIf RispTent5_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_2.BackColor = Color.White 
					RispTent5_3.BackColor = Color.White 
					RispTent5_4.BackColor = Color.White 
				ElseIf RispTent5_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_3.BackColor = Color.White 
					RispTent5_4.BackColor = Color.White 
					RispTent5_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent5_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_1.BackColor = Color.White 
					RispTent5_2.BackColor = Color.White 
					RispTent5_3.BackColor = Color.White 
					RispTent5_4.BackColor = Color.White 
				ElseIf RispTent5_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent5_2.BackColor = Color.White 
					RispTent5_3.BackColor = Color.White 
					RispTent5_4.BackColor = Color.White 
					RispTent5_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent5_1.BackColor = Color.White 
				RispTent5_2.BackColor = Color.White 
				RispTent5_3.BackColor = Color.White 
				RispTent5_4.BackColor = Color.White 
				RispTent5_5.BackColor = Color.White 
			End If
			
			LabTent5_1.Enabled = False
			LabTent5_2.Enabled = False
			LabTent5_3.Enabled = False
			LabTent5_4.Enabled = False
			LabTent5_5.Enabled = False
			
			LabTent6_1.Enabled = True
			LabTent6_2.Enabled = True
			LabTent6_3.Enabled = True
			LabTent6_4.Enabled = True
			LabTent6_5.Enabled = True
			
			Command5.Visible = False
			Command6.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		If Tent6_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent6_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent6_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent6_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent6_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent6_1.BackColor = Color.Black 
			RispTent6_2.BackColor = Color.Black 
			RispTent6_3.BackColor = Color.Black 
			RispTent6_4.BackColor = Color.Black 
			RispTent6_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent6_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent6_1.BackColor = Color.Black 
				RispTent6_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent6_1.BackColor = Color.Black 
				RispTent6_2.BackColor = Color.Black 
				RispTent6_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent6_1.BackColor = Color.Black 
				RispTent6_2.BackColor = Color.Black 
				RispTent6_3.BackColor = Color.Black 
				RispTent6_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent6_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_1.BackColor = Color.White 
				ElseIf RispTent6_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_2.BackColor = Color.White 
				ElseIf RispTent6_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_3.BackColor = Color.White 
				ElseIf RispTent6_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent6_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_1.BackColor = Color.White 
					RispTent6_2.BackColor = Color.White 
				ElseIf RispTent6_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_2.BackColor = Color.White 
					RispTent6_3.BackColor = Color.White 
				ElseIf RispTent6_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_3.BackColor = Color.White 
					RispTent6_4.BackColor = Color.White 
				ElseIf RispTent6_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_4.BackColor = Color.White 
					RispTent6_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent6_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_1.BackColor = Color.White 
					RispTent6_2.BackColor = Color.White 
					RispTent6_3.BackColor = Color.White 
				ElseIf RispTent6_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_2.BackColor = Color.White 
					RispTent6_3.BackColor = Color.White 
					RispTent6_4.BackColor = Color.White 
				ElseIf RispTent6_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_3.BackColor = Color.White 
					RispTent6_4.BackColor = Color.White 
					RispTent6_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent6_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_1.BackColor = Color.White 
					RispTent6_2.BackColor = Color.White 
					RispTent6_3.BackColor = Color.White 
					RispTent6_4.BackColor = Color.White 
				ElseIf RispTent6_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent6_2.BackColor = Color.White 
					RispTent6_3.BackColor = Color.White 
					RispTent6_4.BackColor = Color.White 
					RispTent6_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent6_1.BackColor = Color.White 
				RispTent6_2.BackColor = Color.White 
				RispTent6_3.BackColor = Color.White 
				RispTent6_4.BackColor = Color.White 
				RispTent6_5.BackColor = Color.White 
			End If
			
			LabTent6_1.Enabled = False
			LabTent6_2.Enabled = False
			LabTent6_3.Enabled = False
			LabTent6_4.Enabled = False
			LabTent6_5.Enabled = False
			
			LabTent7_1.Enabled = True
			LabTent7_2.Enabled = True
			LabTent7_3.Enabled = True
			LabTent7_4.Enabled = True
			LabTent7_5.Enabled = True
			
			Command6.Visible = False
			Command7.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		If Tent7_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent7_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent7_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent7_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent7_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent7_1.BackColor = Color.Black 
			RispTent7_2.BackColor = Color.Black 
			RispTent7_3.BackColor = Color.Black 
			RispTent7_4.BackColor = Color.Black 
			RispTent7_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent7_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent7_1.BackColor = Color.Black 
				RispTent7_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent7_1.BackColor = Color.Black 
				RispTent7_2.BackColor = Color.Black 
				RispTent7_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent7_1.BackColor = Color.Black 
				RispTent7_2.BackColor = Color.Black 
				RispTent7_3.BackColor = Color.Black 
				RispTent7_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent7_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_1.BackColor = Color.White 
				ElseIf RispTent7_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_2.BackColor = Color.White 
				ElseIf RispTent7_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_3.BackColor = Color.White 
				ElseIf RispTent7_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent7_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_1.BackColor = Color.White 
					RispTent7_2.BackColor = Color.White 
				ElseIf RispTent7_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_2.BackColor = Color.White 
					RispTent7_3.BackColor = Color.White 
				ElseIf RispTent7_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_3.BackColor = Color.White 
					RispTent7_4.BackColor = Color.White 
				ElseIf RispTent7_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_4.BackColor = Color.White 
					RispTent7_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent7_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_1.BackColor = Color.White 
					RispTent7_2.BackColor = Color.White 
					RispTent7_3.BackColor = Color.White 
				ElseIf RispTent7_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_2.BackColor = Color.White 
					RispTent7_3.BackColor = Color.White 
					RispTent7_4.BackColor = Color.White 
				ElseIf RispTent7_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_3.BackColor = Color.White 
					RispTent7_4.BackColor = Color.White 
					RispTent7_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent7_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_1.BackColor = Color.White 
					RispTent7_2.BackColor = Color.White 
					RispTent7_3.BackColor = Color.White 
					RispTent7_4.BackColor = Color.White 
				ElseIf RispTent7_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent7_2.BackColor = Color.White 
					RispTent7_3.BackColor = Color.White 
					RispTent7_4.BackColor = Color.White 
					RispTent7_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent7_1.BackColor = Color.White 
				RispTent7_2.BackColor = Color.White 
				RispTent7_3.BackColor = Color.White 
				RispTent7_4.BackColor = Color.White 
				RispTent7_5.BackColor = Color.White 
			End If
			
			LabTent7_1.Enabled = False
			LabTent7_2.Enabled = False
			LabTent7_3.Enabled = False
			LabTent7_4.Enabled = False
			LabTent7_5.Enabled = False
			
			LabTent8_1.Enabled = True
			LabTent8_2.Enabled = True
			LabTent8_3.Enabled = True
			LabTent8_4.Enabled = True
			LabTent8_5.Enabled = True
			
			Command7.Visible = False
			Command8.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command8_Click() Handles Command8.Click
		If Tent8_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent8_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent8_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent8_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent8_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent8_1.BackColor = Color.Black 
			RispTent8_2.BackColor = Color.Black 
			RispTent8_3.BackColor = Color.Black 
			RispTent8_4.BackColor = Color.Black 
			RispTent8_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent8_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent8_1.BackColor = Color.Black 
				RispTent8_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent8_1.BackColor = Color.Black 
				RispTent8_2.BackColor = Color.Black 
				RispTent8_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent8_1.BackColor = Color.Black 
				RispTent8_2.BackColor = Color.Black 
				RispTent8_3.BackColor = Color.Black 
				RispTent8_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent8_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_1.BackColor = Color.White 
				ElseIf RispTent8_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_2.BackColor = Color.White 
				ElseIf RispTent8_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_3.BackColor = Color.White 
				ElseIf RispTent8_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent8_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_1.BackColor = Color.White 
					RispTent8_2.BackColor = Color.White 
				ElseIf RispTent8_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_2.BackColor = Color.White 
					RispTent8_3.BackColor = Color.White 
				ElseIf RispTent8_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_3.BackColor = Color.White 
					RispTent8_4.BackColor = Color.White 
				ElseIf RispTent8_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_4.BackColor = Color.White 
					RispTent8_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent8_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_1.BackColor = Color.White 
					RispTent8_2.BackColor = Color.White 
					RispTent8_3.BackColor = Color.White 
				ElseIf RispTent8_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_2.BackColor = Color.White 
					RispTent8_3.BackColor = Color.White 
					RispTent8_4.BackColor = Color.White 
				ElseIf RispTent8_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_3.BackColor = Color.White 
					RispTent8_4.BackColor = Color.White 
					RispTent8_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent8_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_1.BackColor = Color.White 
					RispTent8_2.BackColor = Color.White 
					RispTent8_3.BackColor = Color.White 
					RispTent8_4.BackColor = Color.White 
				ElseIf RispTent8_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent8_2.BackColor = Color.White 
					RispTent8_3.BackColor = Color.White 
					RispTent8_4.BackColor = Color.White 
					RispTent8_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent8_1.BackColor = Color.White 
				RispTent8_2.BackColor = Color.White 
				RispTent8_3.BackColor = Color.White 
				RispTent8_4.BackColor = Color.White 
				RispTent8_5.BackColor = Color.White 
			End If
			
			LabTent8_1.Enabled = False
			LabTent8_2.Enabled = False
			LabTent8_3.Enabled = False
			LabTent8_4.Enabled = False
			LabTent8_5.Enabled = False
			
			LabTent9_1.Enabled = True
			LabTent9_2.Enabled = True
			LabTent9_3.Enabled = True
			LabTent9_4.Enabled = True
			LabTent9_5.Enabled = True
			
			Command8.Visible = False
			Command9.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Command9_Click() Handles Command9.Click
		If Tent9_1.BackColor.Equals(SystemColors.ActiveBorder) Or Tent9_2.BackColor.Equals(SystemColors.ActiveBorder) Or Tent9_3.BackColor.Equals(SystemColors.ActiveBorder) Or Tent9_4.BackColor.Equals(SystemColors.ActiveBorder) Or Tent9_5.BackColor.Equals(SystemColors.ActiveBorder) Then 
			MsgBox6("Inserire tutti i colori!!!", MsgBoxStyle.Critical, "Inserire colori")
		ElseIf T1 = Color1 And T2 = Color2 And T3 = Color3 And T4 = Color4 And T5 = Color5 Then 
			Form2.Show()
			Soluz_Click()
			RispTent9_1.BackColor = Color.Black 
			RispTent9_2.BackColor = Color.Black 
			RispTent9_3.BackColor = Color.Black 
			RispTent9_4.BackColor = Color.Black 
			RispTent9_5.BackColor = Color.Black 
		Else
			
			If T1 = Color1 Then 
				Neri += 1
				Color1a = True
				A1 = True
			End If
			If T2 = Color2 Then 
				Neri += 1
				Color2a = True
				A2 = True
			End If
			If T3 = Color3 Then 
				Neri += 1
				Color3a = True
				A3 = True
			End If
			If T4 = Color4 Then 
				Neri += 1
				Color4a = True
				A4 = True
			End If
			If T5 = Color5 Then 
				Neri += 1
				Color5a = True
				A5 = True
			End If
			
			If A1 = False Then 
				If T1 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T1 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T1 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T1 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A2 = False Then 
				If T2 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T2 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T2 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T2 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A3 = False Then 
				If T3 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T3 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T3 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				ElseIf T3 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A4 = False Then 
				If T4 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T4 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T4 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T4 = Color5 And Color5a = False Then 
					Bianchi += 1
					Color5a = True
				End If
			Else
			End If
			
			If A5 = False Then 
				If T5 = Color1 And Color1a = False Then 
					Bianchi += 1
					Color1a = True
				ElseIf T5 = Color2 And Color2a = False Then 
					Bianchi += 1
					Color2a = True
				ElseIf T5 = Color3 And Color3a = False Then 
					Bianchi += 1
					Color3a = True
				ElseIf T5 = Color4 And Color4a = False Then 
					Bianchi += 1
					Color4a = True
				End If
			Else
			End If
			
			If Neri = 1 Then 
				RispTent9_1.BackColor = Color.Black 
			ElseIf Neri = 2 Then 
				RispTent9_1.BackColor = Color.Black 
				RispTent9_2.BackColor = Color.Black 
			ElseIf Neri = 3 Then 
				RispTent9_1.BackColor = Color.Black 
				RispTent9_2.BackColor = Color.Black 
				RispTent9_3.BackColor = Color.Black 
			ElseIf Neri = 4 Then 
				RispTent9_1.BackColor = Color.Black 
				RispTent9_2.BackColor = Color.Black 
				RispTent9_3.BackColor = Color.Black 
				RispTent9_4.BackColor = Color.Black 
			End If
			
			If Bianchi = 1 Then 
				If RispTent9_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_1.BackColor = Color.White 
				ElseIf RispTent9_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_2.BackColor = Color.White 
				ElseIf RispTent9_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_3.BackColor = Color.White 
				ElseIf RispTent9_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_4.BackColor = Color.White 
				End If
			ElseIf Bianchi = 2 Then 
				If RispTent9_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_1.BackColor = Color.White 
					RispTent9_2.BackColor = Color.White 
				ElseIf RispTent9_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_2.BackColor = Color.White 
					RispTent9_3.BackColor = Color.White 
				ElseIf RispTent9_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_3.BackColor = Color.White 
					RispTent9_4.BackColor = Color.White 
				ElseIf RispTent9_4.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_4.BackColor = Color.White 
					RispTent9_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 3 Then 
				If RispTent9_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_1.BackColor = Color.White 
					RispTent9_2.BackColor = Color.White 
					RispTent9_3.BackColor = Color.White 
				ElseIf RispTent9_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_2.BackColor = Color.White 
					RispTent9_3.BackColor = Color.White 
					RispTent9_4.BackColor = Color.White 
				ElseIf RispTent9_3.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_3.BackColor = Color.White 
					RispTent9_4.BackColor = Color.White 
					RispTent9_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 4 Then 
				If RispTent9_1.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_1.BackColor = Color.White 
					RispTent9_2.BackColor = Color.White 
					RispTent9_3.BackColor = Color.White 
					RispTent9_4.BackColor = Color.White 
				ElseIf RispTent9_2.BackColor.Equals(SystemColors.Highlight) Then 
					RispTent9_2.BackColor = Color.White 
					RispTent9_3.BackColor = Color.White 
					RispTent9_4.BackColor = Color.White 
					RispTent9_5.BackColor = Color.White 
				End If
			ElseIf Bianchi = 5 Then 
				RispTent9_1.BackColor = Color.White 
				RispTent9_2.BackColor = Color.White 
				RispTent9_3.BackColor = Color.White 
				RispTent9_4.BackColor = Color.White 
				RispTent9_5.BackColor = Color.White 
			End If
			
			LabTent9_1.Enabled = False
			LabTent9_2.Enabled = False
			LabTent9_3.Enabled = False
			LabTent9_4.Enabled = False
			LabTent9_5.Enabled = False
			
			LabTent10_1.Enabled = True
			LabTent10_2.Enabled = True
			LabTent10_3.Enabled = True
			LabTent10_4.Enabled = True
			LabTent10_5.Enabled = True
			
			Command9.Visible = False
			Command10.Visible = True
			
			Colore = &H8000000A
			
			Color1a = False
			Color2a = False
			Color3a = False
			Color4a = False
			Color5a = False
			A1 = False
			A2 = False
			A3 = False
			A4 = False
			A5 = False
			
			Col1.BorderColor = Color.Black 
			Col2.BorderColor = Color.Black 
			Col3.BorderColor = Color.Black 
			Col4.BorderColor = Color.Black 
			Col5.BorderColor = Color.Black 
			Col6.BorderColor = Color.Black 
			ColScelto.BackColor = SystemColors.ActiveBorder 
			
			Neri = 0
			Bianchi = 0
		End If
	End Sub

	Private Sub Esci_Click() Handles Esci.Click
		Dim Risposta As Short = MsgBox6("Sei sicuro di voler uscire?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Uscita")
		If Risposta = MsgBoxResult.Yes Then 
			Unload6(Me)
		Else
			' UPGRADE_INFO (#0181): Reference to default form instance 'Form1' was converted to Me keyword.
			Me.Show()
		End If
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Colore = &H8000000A
		Bianchi = 0
		Neri = 0
		New_Click()
		Color1a = False
		Color2a = False
		Color3a = False
		Color4a = False
		Color5a = False
		A1 = False
		A2 = False
		A3 = False
		A4 = False
		A5 = False
		Ripetere = False
	End Sub

	Private Sub Giallo_Click() Handles Giallo.Click
		Colore = VBRUN.ColorConstants.vbYellow
		Col2.BorderColor = Color.White 
		Col1.BorderColor = Color.Black 
		Col6.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		ColScelto.BackColor = Color.Yellow 
	End Sub

	Private Sub LabTent1_1_Click() Handles LabTent1_1.Click
		Tent1_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent1_2_Click() Handles LabTent1_2.Click
		Tent1_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent1_3_Click() Handles LabTent1_3.Click
		Tent1_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent1_4_Click() Handles LabTent1_4.Click
		Tent1_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent1_5_Click() Handles LabTent1_5.Click
		Tent1_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent10_1_Click() Handles LabTent10_1.Click
		Tent10_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent10_2_Click() Handles LabTent10_2.Click
		Tent10_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent10_3_Click() Handles LabTent10_3.Click
		Tent10_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent10_4_Click() Handles LabTent10_4.Click
		Tent10_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent10_5_Click() Handles LabTent10_5.Click
		Tent10_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent11_1_Click() Handles LabTent11_1.Click
		Tent11_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent11_2_Click() Handles LabTent11_2.Click
		Tent11_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent11_3_Click() Handles LabTent11_3.Click
		Tent11_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent11_4_Click() Handles LabTent11_4.Click
		Tent11_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent11_5_Click() Handles LabTent11_5.Click
		Tent11_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent12_1_Click() Handles LabTent12_1.Click
		Tent12_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent12_2_Click() Handles LabTent12_2.Click
		Tent12_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent12_3_Click() Handles LabTent12_3.Click
		Tent12_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent12_4_Click() Handles LabTent12_4.Click
		Tent12_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent12_5_Click() Handles LabTent12_5.Click
		Tent12_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent2_1_Click() Handles LabTent2_1.Click
		Tent2_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent2_2_Click() Handles LabTent2_2.Click
		Tent2_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent2_3_Click() Handles LabTent2_3.Click
		Tent2_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent2_4_Click() Handles LabTent2_4.Click
		Tent2_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent2_5_Click() Handles LabTent2_5.Click
		Tent2_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent3_1_Click() Handles LabTent3_1.Click
		Tent3_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent3_2_Click() Handles LabTent3_2.Click
		Tent3_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent3_3_Click() Handles LabTent3_3.Click
		Tent3_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent3_4_Click() Handles LabTent3_4.Click
		Tent3_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent3_5_Click() Handles LabTent3_5.Click
		Tent3_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent4_1_Click() Handles LabTent4_1.Click
		Tent4_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent4_2_Click() Handles LabTent4_2.Click
		Tent4_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent4_3_Click() Handles LabTent4_3.Click
		Tent4_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent4_4_Click() Handles LabTent4_4.Click
		Tent4_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent4_5_Click() Handles LabTent4_5.Click
		Tent4_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent5_1_Click() Handles LabTent5_1.Click
		Tent5_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent5_2_Click() Handles LabTent5_2.Click
		Tent5_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent5_3_Click() Handles LabTent5_3.Click
		Tent5_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent5_4_Click() Handles LabTent5_4.Click
		Tent5_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent5_5_Click() Handles LabTent5_5.Click
		Tent5_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent6_1_Click() Handles LabTent6_1.Click
		Tent6_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent6_2_Click() Handles LabTent6_2.Click
		Tent6_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent6_3_Click() Handles LabTent6_3.Click
		Tent6_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent6_4_Click() Handles LabTent6_4.Click
		Tent6_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent6_5_Click() Handles LabTent6_5.Click
		Tent6_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent7_1_Click() Handles LabTent7_1.Click
		Tent7_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent7_2_Click() Handles LabTent7_2.Click
		Tent7_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent7_3_Click() Handles LabTent7_3.Click
		Tent7_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent7_4_Click() Handles LabTent7_4.Click
		Tent7_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent7_5_Click() Handles LabTent7_5.Click
		Tent7_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent8_1_Click() Handles LabTent8_1.Click
		Tent8_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent8_2_Click() Handles LabTent8_2.Click
		Tent8_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent8_3_Click() Handles LabTent8_3.Click
		Tent8_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent8_4_Click() Handles LabTent8_4.Click
		Tent8_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent8_5_Click() Handles LabTent8_5.Click
		Tent8_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub LabTent9_1_Click() Handles LabTent9_1.Click
		Tent9_1.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T1 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T1 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T1 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T1 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T1 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T1 = 6
		Else
		End If
	End Sub

	Private Sub LabTent9_2_Click() Handles LabTent9_2.Click
		Tent9_2.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T2 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T2 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T2 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T2 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T2 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T2 = 6
		Else
		End If
	End Sub

	Private Sub LabTent9_3_Click() Handles LabTent9_3.Click
		Tent9_3.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T3 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T3 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T3 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T3 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T3 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T3 = 6
		Else
		End If
	End Sub

	Private Sub LabTent9_4_Click() Handles LabTent9_4.Click
		Tent9_4.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T4 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T4 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T4 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T4 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T4 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T4 = 6
		Else
		End If
	End Sub

	Private Sub LabTent9_5_Click() Handles LabTent9_5.Click
		Tent9_5.BackColor = FromOleColor6(Colore)
		If Colore = VBRUN.ColorConstants.vbBlue Then 
			T5 = 1
		ElseIf Colore = VBRUN.ColorConstants.vbYellow Then 
			T5 = 2
		ElseIf Colore = VBRUN.ColorConstants.vbRed Then 
			T5 = 3
		ElseIf Colore = VBRUN.ColorConstants.vbGreen Then 
			T5 = 4
		ElseIf Colore = VBRUN.ColorConstants.vbBlack Then 
			T5 = 5
		ElseIf Colore = VBRUN.ColorConstants.vbWhite Then 
			T5 = 6
		Else
		End If
	End Sub

	Private Sub mnuAbout_Click() Handles mnuAbout.Click
		frmAbout.Show()
	End Sub

	Private Sub mnuEsci_Click() Handles mnuEsci.Click
		Esci_Click()
	End Sub

	Private Sub mnuNew_Click() Handles mnuNew.Click
		Nuovo_Click()
	End Sub

	Private Sub mnuVediSoluz_Click() Handles mnuVediSoluz.Click
		Soluzione_Click()
	End Sub

	Private Sub Nero_Click() Handles Nero.Click
		Colore = VBRUN.ColorConstants.vbBlack
		Col5.BorderColor = Color.White 
		Col1.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col6.BorderColor = Color.Black 
		ColScelto.BackColor = Color.Black 
	End Sub

	Public Sub New_Click() Handles lblNew.Click
		Color1 = Rand(1, 6)
		Color2 = Rand(1, 6)
		Color3 = Rand(1, 6)
		Color4 = Rand(1, 6)
		Color5 = Rand(1, 6)
		R1.Caption = Color1
		R2.Caption = Color2
		R3.Caption = Color3
		R4.Caption = Color4
		R5.Caption = Color5
		
		If ((R1.Caption = R2.Caption) And (R2.Caption = R3.Caption) And (R3.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R3.Caption) And (R3.Caption = R4.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R3.Caption) And (R3.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R3.Caption) And (R3.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R2.Caption = R3.Caption) And (R3.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R3.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R3.Caption) And (R3.Caption = R4.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R2.Caption = R3.Caption) And (R3.Caption = R4.Caption)) Then 
			New_Click()
		ElseIf ((R2.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R3.Caption = R4.Caption) And (R4.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R4.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R2.Caption) And (R2.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R1.Caption = R3.Caption) And (R3.Caption = R5.Caption)) Then 
			New_Click()
		ElseIf ((R2.Caption = R3.Caption) And (R3.Caption = R5.Caption)) Then 
			New_Click()
		End If
		
		C1.BackColor = SystemColors.ActiveBorder 
		C2.BackColor = SystemColors.ActiveBorder 
		C3.BackColor = SystemColors.ActiveBorder 
		C4.BackColor = SystemColors.ActiveBorder 
		C5.BackColor = SystemColors.ActiveBorder 
		
		Tent1_1.BackColor = SystemColors.ActiveBorder 
		Tent1_2.BackColor = SystemColors.ActiveBorder 
		Tent1_3.BackColor = SystemColors.ActiveBorder 
		Tent1_4.BackColor = SystemColors.ActiveBorder 
		Tent1_5.BackColor = SystemColors.ActiveBorder 
		
		Tent2_1.BackColor = SystemColors.ActiveBorder 
		Tent2_2.BackColor = SystemColors.ActiveBorder 
		Tent2_3.BackColor = SystemColors.ActiveBorder 
		Tent2_4.BackColor = SystemColors.ActiveBorder 
		Tent2_5.BackColor = SystemColors.ActiveBorder 
		
		Tent3_1.BackColor = SystemColors.ActiveBorder 
		Tent3_2.BackColor = SystemColors.ActiveBorder 
		Tent3_3.BackColor = SystemColors.ActiveBorder 
		Tent3_4.BackColor = SystemColors.ActiveBorder 
		Tent3_5.BackColor = SystemColors.ActiveBorder 
		
		Tent4_1.BackColor = SystemColors.ActiveBorder 
		Tent4_2.BackColor = SystemColors.ActiveBorder 
		Tent4_3.BackColor = SystemColors.ActiveBorder 
		Tent4_4.BackColor = SystemColors.ActiveBorder 
		Tent4_5.BackColor = SystemColors.ActiveBorder 
		
		Tent5_1.BackColor = SystemColors.ActiveBorder 
		Tent5_2.BackColor = SystemColors.ActiveBorder 
		Tent5_3.BackColor = SystemColors.ActiveBorder 
		Tent5_4.BackColor = SystemColors.ActiveBorder 
		Tent5_5.BackColor = SystemColors.ActiveBorder 
		
		Tent6_1.BackColor = SystemColors.ActiveBorder 
		Tent6_2.BackColor = SystemColors.ActiveBorder 
		Tent6_3.BackColor = SystemColors.ActiveBorder 
		Tent6_4.BackColor = SystemColors.ActiveBorder 
		Tent6_5.BackColor = SystemColors.ActiveBorder 
		
		Tent7_1.BackColor = SystemColors.ActiveBorder 
		Tent7_2.BackColor = SystemColors.ActiveBorder 
		Tent7_3.BackColor = SystemColors.ActiveBorder 
		Tent7_4.BackColor = SystemColors.ActiveBorder 
		Tent7_5.BackColor = SystemColors.ActiveBorder 
		
		Tent8_1.BackColor = SystemColors.ActiveBorder 
		Tent8_2.BackColor = SystemColors.ActiveBorder 
		Tent8_3.BackColor = SystemColors.ActiveBorder 
		Tent8_4.BackColor = SystemColors.ActiveBorder 
		Tent8_5.BackColor = SystemColors.ActiveBorder 
		
		Tent9_1.BackColor = SystemColors.ActiveBorder 
		Tent9_2.BackColor = SystemColors.ActiveBorder 
		Tent9_3.BackColor = SystemColors.ActiveBorder 
		Tent9_4.BackColor = SystemColors.ActiveBorder 
		Tent9_5.BackColor = SystemColors.ActiveBorder 
		
		Tent10_1.BackColor = SystemColors.ActiveBorder 
		Tent10_2.BackColor = SystemColors.ActiveBorder 
		Tent10_3.BackColor = SystemColors.ActiveBorder 
		Tent10_4.BackColor = SystemColors.ActiveBorder 
		Tent10_5.BackColor = SystemColors.ActiveBorder 
		
		Tent11_1.BackColor = SystemColors.ActiveBorder 
		Tent11_2.BackColor = SystemColors.ActiveBorder 
		Tent11_3.BackColor = SystemColors.ActiveBorder 
		Tent11_4.BackColor = SystemColors.ActiveBorder 
		Tent11_5.BackColor = SystemColors.ActiveBorder 
		
		Tent12_1.BackColor = SystemColors.ActiveBorder 
		Tent12_2.BackColor = SystemColors.ActiveBorder 
		Tent12_3.BackColor = SystemColors.ActiveBorder 
		Tent12_4.BackColor = SystemColors.ActiveBorder 
		Tent12_5.BackColor = SystemColors.ActiveBorder 
		
		LabTent1_1.Enabled = True
		LabTent1_2.Enabled = True
		LabTent1_3.Enabled = True
		LabTent1_4.Enabled = True
		LabTent1_5.Enabled = True
		
		LabTent2_1.Enabled = False
		LabTent2_2.Enabled = False
		LabTent2_3.Enabled = False
		LabTent2_4.Enabled = False
		LabTent2_5.Enabled = False
		
		LabTent3_1.Enabled = False
		LabTent3_2.Enabled = False
		LabTent3_3.Enabled = False
		LabTent3_4.Enabled = False
		LabTent3_5.Enabled = False
		
		LabTent4_1.Enabled = False
		LabTent4_2.Enabled = False
		LabTent4_3.Enabled = False
		LabTent4_4.Enabled = False
		LabTent4_5.Enabled = False
		
		LabTent5_1.Enabled = False
		LabTent5_2.Enabled = False
		LabTent5_3.Enabled = False
		LabTent5_4.Enabled = False
		LabTent5_5.Enabled = False
		
		LabTent6_1.Enabled = False
		LabTent6_2.Enabled = False
		LabTent6_3.Enabled = False
		LabTent6_4.Enabled = False
		LabTent6_5.Enabled = False
		
		LabTent7_1.Enabled = False
		LabTent7_2.Enabled = False
		LabTent7_3.Enabled = False
		LabTent7_4.Enabled = False
		LabTent7_5.Enabled = False
		
		LabTent8_1.Enabled = False
		LabTent8_2.Enabled = False
		LabTent8_3.Enabled = False
		LabTent8_4.Enabled = False
		LabTent8_5.Enabled = False
		
		LabTent9_1.Enabled = False
		LabTent9_2.Enabled = False
		LabTent9_3.Enabled = False
		LabTent9_4.Enabled = False
		LabTent9_5.Enabled = False
		
		LabTent10_1.Enabled = False
		LabTent10_2.Enabled = False
		LabTent10_3.Enabled = False
		LabTent10_4.Enabled = False
		LabTent10_5.Enabled = False
		
		LabTent11_1.Enabled = False
		LabTent11_2.Enabled = False
		LabTent11_3.Enabled = False
		LabTent11_4.Enabled = False
		LabTent11_5.Enabled = False
		
		LabTent12_1.Enabled = False
		LabTent12_2.Enabled = False
		LabTent12_3.Enabled = False
		LabTent12_4.Enabled = False
		LabTent12_5.Enabled = False
		
		Command1.Visible = True
		Command2.Visible = False
		Command3.Visible = False
		Command4.Visible = False
		Command5.Visible = False
		Command6.Visible = False
		Command7.Visible = False
		Command8.Visible = False
		Command9.Visible = False
		Command10.Visible = False
		Command11.Visible = False
		Command12.Visible = False
		
		RispTent1_1.BackColor = SystemColors.Highlight 
		RispTent1_2.BackColor = SystemColors.Highlight 
		RispTent1_3.BackColor = SystemColors.Highlight 
		RispTent1_4.BackColor = SystemColors.Highlight 
		RispTent1_5.BackColor = SystemColors.Highlight 
		
		RispTent2_1.BackColor = SystemColors.Highlight 
		RispTent2_2.BackColor = SystemColors.Highlight 
		RispTent2_3.BackColor = SystemColors.Highlight 
		RispTent2_4.BackColor = SystemColors.Highlight 
		RispTent2_5.BackColor = SystemColors.Highlight 
		
		RispTent3_1.BackColor = SystemColors.Highlight 
		RispTent3_2.BackColor = SystemColors.Highlight 
		RispTent3_3.BackColor = SystemColors.Highlight 
		RispTent3_4.BackColor = SystemColors.Highlight 
		RispTent3_5.BackColor = SystemColors.Highlight 
		
		RispTent4_1.BackColor = SystemColors.Highlight 
		RispTent4_2.BackColor = SystemColors.Highlight 
		RispTent4_3.BackColor = SystemColors.Highlight 
		RispTent4_4.BackColor = SystemColors.Highlight 
		RispTent4_5.BackColor = SystemColors.Highlight 
		
		RispTent5_1.BackColor = SystemColors.Highlight 
		RispTent5_2.BackColor = SystemColors.Highlight 
		RispTent5_3.BackColor = SystemColors.Highlight 
		RispTent5_4.BackColor = SystemColors.Highlight 
		RispTent5_5.BackColor = SystemColors.Highlight 
		
		RispTent6_1.BackColor = SystemColors.Highlight 
		RispTent6_2.BackColor = SystemColors.Highlight 
		RispTent6_3.BackColor = SystemColors.Highlight 
		RispTent6_4.BackColor = SystemColors.Highlight 
		RispTent6_5.BackColor = SystemColors.Highlight 
		
		RispTent7_1.BackColor = SystemColors.Highlight 
		RispTent7_2.BackColor = SystemColors.Highlight 
		RispTent7_3.BackColor = SystemColors.Highlight 
		RispTent7_4.BackColor = SystemColors.Highlight 
		RispTent7_5.BackColor = SystemColors.Highlight 
		
		RispTent8_1.BackColor = SystemColors.Highlight 
		RispTent8_2.BackColor = SystemColors.Highlight 
		RispTent8_3.BackColor = SystemColors.Highlight 
		RispTent8_4.BackColor = SystemColors.Highlight 
		RispTent8_5.BackColor = SystemColors.Highlight 
		
		RispTent9_1.BackColor = SystemColors.Highlight 
		RispTent9_2.BackColor = SystemColors.Highlight 
		RispTent9_3.BackColor = SystemColors.Highlight 
		RispTent9_4.BackColor = SystemColors.Highlight 
		RispTent9_5.BackColor = SystemColors.Highlight 
		
		RispTent10_1.BackColor = SystemColors.Highlight 
		RispTent10_2.BackColor = SystemColors.Highlight 
		RispTent10_3.BackColor = SystemColors.Highlight 
		RispTent10_4.BackColor = SystemColors.Highlight 
		RispTent10_5.BackColor = SystemColors.Highlight 
		
		RispTent11_1.BackColor = SystemColors.Highlight 
		RispTent11_2.BackColor = SystemColors.Highlight 
		RispTent11_3.BackColor = SystemColors.Highlight 
		RispTent11_4.BackColor = SystemColors.Highlight 
		RispTent11_5.BackColor = SystemColors.Highlight 
		
		RispTent12_1.BackColor = SystemColors.Highlight 
		RispTent12_2.BackColor = SystemColors.Highlight 
		RispTent12_3.BackColor = SystemColors.Highlight 
		RispTent12_4.BackColor = SystemColors.Highlight 
		RispTent12_5.BackColor = SystemColors.Highlight 
		
		Colore = &H8000000A
		
		Color1a = False
		Color2a = False
		Color3a = False
		Color4a = False
		Color5a = False
		A1 = False
		A2 = False
		A3 = False
		A4 = False
		A5 = False
		
		Col1.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		Col6.BorderColor = Color.Black 
		ColScelto.BackColor = SystemColors.ActiveBorder 
		
		Neri = 0
		Bianchi = 0
	End Sub

	Private Sub Nuovo_Click() Handles Nuovo.Click
		Dim Risposta As Short = MsgBox6("Sei sicuro di chiudere questa partita e aprirne una nuova?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nuova partita")
		If Risposta = MsgBoxResult.Yes Then 
			New_Click()
		End If
	End Sub

	Private Sub Rosso_Click() Handles Rosso.Click
		Colore = VBRUN.ColorConstants.vbRed
		Col3.BorderColor = Color.White 
		Col1.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col6.BorderColor = Color.Black 
		Col4.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		ColScelto.BackColor = Color.Red 
	End Sub

	Private Sub Soluz_Click() Handles Soluz.Click
		If R1.Caption = 1 Then 
			C1.BackColor = Color.Blue 
		ElseIf R1.Caption = 2 Then 
			C1.BackColor = Color.Yellow 
		ElseIf R1.Caption = 3 Then 
			C1.BackColor = Color.Red 
		ElseIf R1.Caption = 4 Then 
			C1.BackColor = Color.Lime 
		ElseIf R1.Caption = 5 Then 
			C1.BackColor = Color.Black 
		ElseIf R1.Caption = 6 Then 
			C1.BackColor = Color.White 
		End If
		
		If R2.Caption = 1 Then 
			C2.BackColor = Color.Blue 
		ElseIf R2.Caption = 2 Then 
			C2.BackColor = Color.Yellow 
		ElseIf R2.Caption = 3 Then 
			C2.BackColor = Color.Red 
		ElseIf R2.Caption = 4 Then 
			C2.BackColor = Color.Lime 
		ElseIf R2.Caption = 5 Then 
			C2.BackColor = Color.Black 
		ElseIf R2.Caption = 6 Then 
			C2.BackColor = Color.White 
		End If
		
		If R3.Caption = 1 Then 
			C3.BackColor = Color.Blue 
		ElseIf R3.Caption = 2 Then 
			C3.BackColor = Color.Yellow 
		ElseIf R3.Caption = 3 Then 
			C3.BackColor = Color.Red 
		ElseIf R3.Caption = 4 Then 
			C3.BackColor = Color.Lime 
		ElseIf R3.Caption = 5 Then 
			C3.BackColor = Color.Black 
		ElseIf R3.Caption = 6 Then 
			C3.BackColor = Color.White 
		End If
		
		If R4.Caption = 1 Then 
			C4.BackColor = Color.Blue 
		ElseIf R4.Caption = 2 Then 
			C4.BackColor = Color.Yellow 
		ElseIf R4.Caption = 3 Then 
			C4.BackColor = Color.Red 
		ElseIf R4.Caption = 4 Then 
			C4.BackColor = Color.Lime 
		ElseIf R4.Caption = 5 Then 
			C4.BackColor = Color.Black 
		ElseIf R4.Caption = 6 Then 
			C4.BackColor = Color.White 
		End If
		
		If R5.Caption = 1 Then 
			C5.BackColor = Color.Blue 
		ElseIf R5.Caption = 2 Then 
			C5.BackColor = Color.Yellow 
		ElseIf R5.Caption = 3 Then 
			C5.BackColor = Color.Red 
		ElseIf R5.Caption = 4 Then 
			C5.BackColor = Color.Lime 
		ElseIf R5.Caption = 5 Then 
			C5.BackColor = Color.Black 
		ElseIf R5.Caption = 6 Then 
			C5.BackColor = Color.White 
		End If
	End Sub

	Private Sub Soluzione_Click() Handles Soluzione.Click
		Dim Risposta As Short = MsgBox6("Sei sicuro di voler vedere la soluzione?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Soluzione")
		If Risposta = MsgBoxResult.Yes Then 
			Soluz_Click()
			Form2.DisableControl_Click()
		End If
	End Sub

	Private Sub Verde_Click() Handles Verde.Click
		Colore = VBRUN.ColorConstants.vbGreen
		Col4.BorderColor = Color.White 
		Col1.BorderColor = Color.Black 
		Col2.BorderColor = Color.Black 
		Col3.BorderColor = Color.Black 
		Col6.BorderColor = Color.Black 
		Col5.BorderColor = Color.Black 
		ColScelto.BackColor = Color.Lime 
	End Sub

End Class
