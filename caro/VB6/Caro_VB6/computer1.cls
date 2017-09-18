VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "computer1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Public kh As Integer
Public n As Integer
Const MaxN = 20
Dim score(1 To MaxN, 1 To MaxN) As Integer
Dim score1(1 To MaxN, 1 To MaxN) As Integer
Dim a(1 To MaxN, 1 To MaxN) As Integer

Private Sub tinh(X, Y, dx, dy As Integer)
Dim i As Integer, j As Integer, k As Integer
Dim d1 As Integer, d2 As Integer, s As Integer
'Tinh so o cua nguoi va may
i = X
j = Y
d1 = 0
d2 = 0
For k = 0 To 4
    If (a(i, j) = 1) Then d1 = d1 + 1
    If (a(i, j) = 2) Then d2 = d2 + 1
    i = i + dx
    j = j + dy
Next
If (d1 > 0) And (d2 > 0) Then Exit Sub
If kh = 2 Then d1 = d2
If d1 = 0 Then Exit Sub
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
    i = i + dx
    j = j + dy
Next
End Sub

Private Sub evalute()
Dim i As Integer
Dim j As Integer
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

Public Sub gan(i As Integer, j As Integer, gt As Integer)
    a(i, j) = gt
End Sub

Private Function check(i As Integer, j As Integer, dx As Integer, dy As Integer) As Integer
Dim i1 As Integer, j1 As Integer, t As Integer, s As Integer
i1 = i
j1 = j
s = 1
For t = 1 To 4
    i1 = i1 + dx
    j1 = j1 + dy
    If (i1 > 0) And (i1 <= n) And (j1 > 0) And (j1 <= n) Then
        If a(i, j) = a(i1, j1) Then s = s + 1
    End If
Next
If s = 5 Then check = True Else check = False
End Function

Public Function checkwin() As Boolean
Dim i As Integer, j As Integer
checkwin = True
For i = 1 To n
    For j = 1 To n
        If a(i, j) <> 0 Then
            If check(i, j, 0, 1) = True Then Exit Function
            If check(i, j, 1, 0) = True Then Exit Function
            If check(i, j, 1, 1) = True Then Exit Function
            If check(i, j, 1, -1) = True Then Exit Function
        End If
    Next
Next
checkwin = False
End Function

Private Function tuongduong(d1 As Integer, d2 As Integer) As Boolean
Dim e1 As Integer, e2 As Integer, t As Integer, i As Integer
t = 1000
For i = 1 To 3
    e1 = d1 \ t
    e2 = d2 \ t
    If (e1 > 0) Or (e2 > 0) Then
        If (e1 = e2) Then
            tuongduong = True
        Else
            tuongduong = False
        End If
        Exit Function
    End If
    t = t \ 10
Next
tuongduong = True
End Function

Public Sub timnuocdi(ByRef X As Integer, ByRef Y As Integer)
Dim max As Integer, max1 As Integer, max2 As Integer
Dim i As Integer, j As Integer
Dim li As Integer, lj As Integer, li1 As Integer, lj1 As Integer, li2 As Integer, lj2 As Integer

'Nguoi
max1 = 0
kh = 1
evalute
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
evalute
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
