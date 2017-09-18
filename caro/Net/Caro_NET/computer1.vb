' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class computer1

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	Public kh As Short
	Public n As Short
	Private Const MaxN As Short = 20
	Private score(MaxN, MaxN) As Short
	Private score1(MaxN, MaxN) As Short
	Private a(MaxN, MaxN) As Short
	
	Private Sub tinh(ByRef X As Object, ByRef Y As Object, ByRef dx As Object, ByRef dy As Short)
		Dim i As Short
		Dim j As Short
		Dim k As Short
		Dim d1 As Short = 0
		Dim d2 As Short = 0
		Dim s As Short
		'Tinh so o cua nguoi va may
		i = X
		j = Y
		For k = 0 To 4
			If (a(i, j) = 1) Then  d1 += 1
			If (a(i, j) = 2) Then  d2 += 1
			i += dx
			j += dy
		Next
		If (d1 > 0) And (d2 > 0) Then  Exit Sub
		If kh = 2 Then  d1 = d2
		If d1 = 0 Then  Exit Sub
		'Tinh diem
		Select Case d1
		Case 1
			s = 1
		Case 2
			s = 10
		Case 3
			s = 100
		Case 4
			s = 1000
		End Select
		'Cap nhat diem cho moi o
		i = X
		j = Y
		For k = 0 To 4
			score(i, j) = score(i, j) + s
			i += dx
			j += dy
		Next
	End Sub

	Private Sub evalute()
		Dim i As Short
		Dim j As Short
		'Fill Zero
		For i = 1 To n
			For j = 1 To n
				score(i, j) = 0
			Next
		Next
		'Vet
		For i = 1 To n
			For j = 1 To n
				'Huong 1
				If (j + 4 <= n) Then 
					Call tinh(i, j, 0, 1)
				End If
				'Huong 2
				If (i + 4 <= n) And (j + 4 <= n) Then 
					Call tinh(i, j, 1, 1)
				End If
				'Huong 3
				If (i + 4 <= n) Then 
					Call tinh(i, j, 1, 0)
				End If
				'Huong 4
				If (i + 4 <= n) And (j >= 5) Then 
					Call tinh(i, j, 1, -1)
				End If
			Next
		Next
	End Sub

	Public Sub gan(ByRef i As Short, ByRef j As Short, ByRef gt As Short)
		a(i, j) = gt
	End Sub

	Private Function check(ByRef i As Short, ByRef j As Short, ByRef dx As Short, ByRef dy As Short) As Short
		Dim i1 As Short
		Dim j1 As Short
		Dim t As Short
		Dim s As Short = 1
		i1 = i
		j1 = j
		For t = 1 To 4
			i1 += dx
			j1 += dy
			If (i1 > 0) And (i1 <= n) And (j1 > 0) And (j1 <= n) Then 
				If a(i, j) = a(i1, j1) Then  s += 1
			End If
		Next
		If s = 5 Then  check = CShort(True) Else Return CShort(False)
	End Function

	Public Function checkwin() As Boolean
		Dim i As Short
		Dim j As Short
		checkwin = True
		For i = 1 To n
			For j = 1 To n
				If a(i, j) <> 0 Then 
					If check(i, j, 0, 1) = True Then  Exit Function
					If check(i, j, 1, 0) = True Then  Exit Function
					If check(i, j, 1, 1) = True Then  Exit Function
					If check(i, j, 1, -1) = True Then  Exit Function
				End If
			Next
		Next
		Return False
	End Function

	Private Function tuongduong(ByRef d1 As Short, ByRef d2 As Short) As Boolean
		Dim e1 As Short
		Dim e2 As Short
		Dim t As Short = 1000
		Dim i As Short
		For i = 1 To 3
			e1 = d1 \ t
			e2 = d2 \ t
			If (e1 > 0) Or (e2 > 0) Then 
				If (e1 = e2) Then 
					Return True
				Else
					Return False
				End If
				Exit Function
			End If
			t \= 10
		Next
		Return True
	End Function

	Public Sub timnuocdi(ByRef X As Short, ByRef Y As Short)
		Dim max As Short
		Dim max1 As Short = 0
		Dim max2 As Short
		Dim i As Short
		Dim j As Short
		Dim li As Short
		Dim lj As Short
		Dim li1 As Short
		Dim lj1 As Short
		Dim li2 As Short
		Dim lj2 As Short
		
		'Nguoi
		kh = 1
		evalute()
		For i = 1 To n
			For j = 1 To n
				score1(i, j) = score(i, j)
				If a(i, j) = 0 Then 
					If max1 < score(i, j) Then 
						max1 = score(i, j)
						li1 = i
						lj1 = j
					End If
				End If
			Next
		Next
		'May
		kh = 2
		evalute()
		max2 = 0
		For i = 1 To n
			For j = 1 To n
				If a(i, j) = 0 Then 
					If max2 < score(i, j) Then 
						max2 = score(i, j)
						li2 = i
						lj2 = j
					End If
				End If
			Next
		Next
		'Ket hop
		If tuongduong(max1, max2) Then 
			max = 0
			For i = 1 To n
				For j = 1 To n
					If a(i, j) = 0 Then 
						If max < score(i, j) + score1(i, j) Then 
							max = score(i, j) + score1(i, j)
							li = i
							lj = j
						End If
					End If
				Next
			Next
			X = li
			Y = lj
		Else
			If max1 < max2 Then 
				X = li2
				Y = lj2
			Else
				X = li1
				Y = lj1
			End If
		End If
		'So sanh
	End Sub

End Class
