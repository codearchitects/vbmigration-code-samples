VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ObjGrid3D"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private xmin As Single      ' Min X and Y values.
Private Zmin As Single
Private dx As Single        ' Spacing between rows of data.
Private dz As Single
Private NumX As Integer     ' Number of X and Y entries.
Private NumZ As Integer
Private Points() As Point3D ' Data values.

' Draw a line between the points. Set the max and min values for the line.

Sub DrawAndSetLine(canvas As Object, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single, hi() As Integer, lo() As Integer)
Dim tmp As Single
Dim ix As Integer
Dim iy As Integer
Dim y As Single
Dim dy As Single

    ' Deal only with integers.
    x1 = CInt(x1)
    y1 = CInt(y1)
    x2 = CInt(x2)
    y2 = CInt(y2)

    ' Make x1 < x2.
    If x2 < x1 Then
        tmp = x1
        x1 = x2
        x2 = tmp
        tmp = y1
        y1 = y2
        y2 = tmp
    End If

    ' Draw the line.
    canvas.Line (x1, y1)-(x2, y2)

    ' Deal with vertical lines separately.
    If x1 = x2 Then
        If y1 < y2 Then
            lo(x1) = y1
            hi(x1) = y2
        Else
            lo(x1) = y2
            hi(x1) = y1
        End If
        Exit Sub
    End If

    ' Deal with non-vertical lines.
    dy = (y2 - y1) / CInt(x2 - x1)
    y = y1
    For ix = x1 To x2
        iy = CInt(y)

        lo(ix) = iy
        hi(ix) = iy

        y = y + dy
    Next ix
End Sub




' Draw a line between the points using and updating the max and min arrays.


Sub DrawLine(canvas As Object, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single, hi() As Integer, lo() As Integer)
Dim tmp As Single
Dim ix As Integer
Dim iy As Integer
Dim y As Single
Dim dy As Single
Dim firstx As Integer
Dim firsty As Integer
Dim skipping As Boolean
Dim above As Boolean

    ' Deal only with integers.
    x1 = CInt(x1)
    y1 = CInt(y1)
    x2 = CInt(x2)
    y2 = CInt(y2)

    ' Make x1 < x2.
    If x2 < x1 Then
        tmp = x1
        x1 = x2
        x2 = tmp
        tmp = y1
        y1 = y2
        y2 = tmp
    End If

    ' Deal with vertical lines separately.
    If x1 = x2 Then
        ' Make y1 < y2.
        If y2 < y1 Then
            tmp = y1
            y1 = y2
            y2 = tmp
        End If
        If y1 <= lo(x1) Then
            If y2 <= lo(x1) Then
                canvas.Line (x1, y1)-(x2, y2)
            Else
                canvas.Line (x1, y1)-(x2, lo(x2))
            End If
            lo(x1) = y1
        End If
        If y2 >= hi(x2) Then
            If y1 >= hi(x2) Then
                canvas.Line (x1, y1)-(x2, y2)
            Else
                canvas.Line (x1, hi(x1))-(x2, y2)
            End If
            hi(x2) = y2
        End If
        Exit Sub
    End If

    ' Deal with non-vertical lines.
    dy = (y2 - y1) / CInt(x2 - x1)
    y = y1

    ' Find the first visible point.
    skipping = True
    For ix = x1 To x2
        iy = CInt(y)
        ' See if this point is visible.
        If iy <= lo(ix) Then
            If skipping Then
                ' Start a new line below.
                skipping = False
                above = False
                firstx = ix
                firsty = lo(ix)
            End If
        ElseIf iy >= hi(ix) Then
            If skipping Then
                ' Start a new line above.
                skipping = False
                above = True
                firstx = ix
                firsty = hi(ix)
            End If
        Else
            ' This point is not visible.
            If Not skipping Then
                ' Draw the previous visible line.
                If above Then
                    ' The line is coming from
                    ' above. Connect it to hi(ix).
                    canvas.Line (firstx, firsty)-(ix, hi(ix))
                Else
                    ' The line is coming from
                    ' below. Connect it to lo(ix).
                    canvas.Line (firstx, firsty)-(ix, lo(ix))
                End If

                skipping = True
            End If
        End If

        If iy < lo(ix) Then lo(ix) = iy
        If iy > hi(ix) Then hi(ix) = iy

        y = y + dy
    Next ix

    ' Draw to the last point if necessary.
    If Not skipping Then _
        canvas.Line (firstx, firsty)-(x2, y2)
End Sub

' Create the Points array.
Sub SetBounds(x1 As Single, deltax As Single, xnum As Integer, z1 As Single, deltaz As Single, znum As Integer)
Dim i As Integer
Dim j As Integer
Dim x As Single
Dim z As Single

    xmin = x1
    Zmin = z1
    dx = deltax
    dz = deltaz
    NumX = xnum
    NumZ = znum
    ReDim Points(1 To NumX, 1 To NumZ)

    x = xmin
    For i = 1 To NumX
        z = Zmin
        For j = 1 To NumZ
            Points(i, j).coord(1) = x
            Points(i, j).coord(2) = 0
            Points(i, j).coord(3) = z
            Points(i, j).coord(4) = 1#
            z = z + dz
        Next j
        x = x + dx
    Next i
End Sub
' Save the indicated data value.
Sub SetValue(x As Single, y As Single, z As Single)
Dim i As Integer
Dim j As Integer

    i = (x - xmin) / dx + 1
    j = (z - Zmin) / dz + 1
    Points(i, j).coord(2) = y
End Sub

' Return a string indicating the object type.
Property Get ObjectType() As String
    ObjectType = "GRID"
End Property




' Apply a transformation matrix which may not
' contain 0, 0, 0, 1 in the last column to the
' object.
Public Sub ApplyFull(M() As Single)
Dim i As Integer
Dim j As Integer

    For i = 1 To NumX
        For j = 1 To NumZ
            m3ApplyFull Points(i, j).coord, M, Points(i, j).trans
        Next j
    Next i
End Sub

' Apply a transformation matrix to the object.
Public Sub Apply(M() As Single)
Dim i As Integer
Dim j As Integer

    For i = 1 To NumX
        For j = 1 To NumZ
            m3Apply Points(i, j).coord, M, Points(i, j).trans
        Next j
    Next i
End Sub






' Draw the grid without hidden surfaces using the hi-lo algorithm

Public Sub DrawWithoutHidden(canvas As Object, Optional r As Variant)
Dim xmin As Integer
Dim xmax As Integer
Dim lo() As Integer
Dim hi() As Integer
Dim ix As Integer
Dim i As Integer
Dim j As Integer
    
    ' Bound the X values.
    xmin = Points(1, 1).trans(1)
    xmax = xmin
    For i = 1 To NumX
        For j = 1 To NumZ
            ix = CInt(Points(i, j).trans(1))
            If xmin > ix Then xmin = ix
            If xmax < ix Then xmax = ix
        Next j
    Next i
    
    ' Create the max and min arrays.
    ReDim lo(xmin To xmax)
    ReDim hi(xmin To xmax)
    
    ' Draw the X and Z front edges.
    For i = 2 To NumX
        ' Draw the edge between
        ' Points(i - 1, NumZ) and Points(i, NumZ)
        ' and set max and min for its values.
        DrawAndSetLine canvas, _
            Points(i - 1, NumZ).trans(1), _
            Points(i - 1, NumZ).trans(2), _
            Points(i, NumZ).trans(1), _
            Points(i, NumZ).trans(2), _
            hi, lo
    Next i
    For i = 2 To NumZ
        ' Draw the edge between
        ' Points(NumX, i - 1) and Points(NumX, i)
        ' and set max and min for its values.
        DrawAndSetLine canvas, _
            Points(NumX, i - 1).trans(1), _
            Points(NumX, i - 1).trans(2), _
            Points(NumX, i).trans(1), _
            Points(NumX, i).trans(2), _
            hi, lo
    Next i
    
    
    For i = NumX - 1 To 1 Step -1
        For j = NumZ - 1 To 1 Step -1
            
            ' This only happens with perspective projection.
            
            If Points(i + 1, j).trans(1) >= Points(i, j).trans(1) Then
                DrawLine canvas, _
                    Points(i, j).trans(1), _
                    Points(i, j).trans(2), _
                    Points(i, j + 1).trans(1), _
                    Points(i, j + 1).trans(2), _
                    hi, lo
                DrawLine canvas, _
                    Points(i, j).trans(1), _
                    Points(i, j).trans(2), _
                    Points(i + 1, j).trans(1), _
                    Points(i + 1, j).trans(2), _
                    hi, lo
            Else
                DrawLine canvas, _
                    Points(i, j).trans(1), _
                    Points(i, j).trans(2), _
                    Points(i + 1, j).trans(1), _
                    Points(i + 1, j).trans(2), _
                    hi, lo
                DrawLine canvas, _
                    Points(i, j).trans(1), _
                    Points(i, j).trans(2), _
                    Points(i, j + 1).trans(1), _
                    Points(i, j + 1).trans(2), _
                    hi, lo
            End If
        Next j
    Next i
End Sub



' Draw the transformed points on the PictureBox.

Public Sub Draw(canvas As Object, Optional r As Variant)
    DrawWithoutHidden canvas, r
End Sub









