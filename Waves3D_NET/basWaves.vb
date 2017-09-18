' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure Point3D

	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=4)> _
	Public coord() As Single
	<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=4)> _
	Public trans() As Single

#Region "Initialization"

	Public Sub New(ByVal dummyArg As Boolean)
		InitializeUDT()
	End Sub

	Public Sub InitializeUDT()
		ReDim coord(4)
		ReDim trans(4)
	End Sub

#End Region

#Region "Clone method"

	Public Function Clone() As Point3D
		Dim copy As Point3D = Me
		copy.coord = Me.coord.Clone()
		copy.trans = Me.trans.Clone()
		Return copy
	End Function

#End Region

End Structure

Friend Structure Segment3D

' UPGRADE_INFO (#0501): The 'Segment3D' member isn't used anywhere in current application.
	Public pt1 As Short
	Public pt2 As Short
End Structure

Friend Module basWaves

	' UPGRADE_INFO (#0531): You can replace calls to the 'GetTickCount' unamanged method with the following .NET member(s): System.Environment.TickCount
	Declare Function GetTickCount Lib "kernel32" () As Integer
	
	Public Const PI As Double = 3.14159265358979
	' UPGRADE_INFO (#0511): The 'INFINITY' member is referenced only by members that haven't found to be used in the current project/solution.
	Public Const INFINITY As Integer = 2147483647
	
	' UPGRADE_INFO (#0501): The 'm3Parallel' member isn't used anywhere in current application.
	Public Const m3Parallel As Short = 0
	Public Const m3Perspective As Short = 1
	
	' Convert the spherical coordinates into Cartesian coordinates.
	
	Public Sub m3SphericalToCartesian(ByVal r As Single, ByVal theta As Single, ByVal phi As Single, ByRef x As Single, ByRef y As Single, ByRef z As Single)
	' UPGRADE_INFO (#0501): The 'm3SphericalToCartesian' member isn't used anywhere in current application.
		Dim R2 As Single
		
		' Create a line to the center of projection.
		y = r * Math.Sin(phi)
		R2 = r * Math.Cos(phi)
		x = R2 * Math.Cos(theta)
		z = R2 * Math.Sin(theta)
	End Sub
	
	' Create a transformation matrix for an oblique
	' projection onto the X-Y plane.
	
	Public Sub m3ObliqueXY(ByRef M(,) As Single, ByVal S As Single, ByVal theta As Single)
	' UPGRADE_INFO (#0501): The 'm3ObliqueXY' member isn't used anywhere in current application.
		m3Identity(M)
		M(3, 1) = -S * Math.Cos(theta)
		M(3, 2) = -S * Math.Sin(theta)
		M(3, 3) = 0
	End Sub

	' Create a transformation matrix for orthographic
	' projection along the X axis.
	Public Sub m3OrthoSide(ByRef M(,) As Single)
	' UPGRADE_INFO (#0501): The 'm3OrthoSide' member isn't used anywhere in current application.
		m3Identity(M)
		M(1, 1) = 0
		M(3, 1) = -1
		M(3, 3) = 0
	End Sub
	
	' Create a transformation matrix for orthographic
	' projection along the Y axis.
	Public Sub m3OrthoTop(ByRef M(,) As Single)
	' UPGRADE_INFO (#0501): The 'm3OrthoTop' member isn't used anywhere in current application.
		m3Identity(M)
		M(2, 2) = 0
		M(3, 2) = -1
		M(3, 3) = 0
	End Sub

	' Create a transformation matrix for orthographic
	' projection along the Z axis.
	Public Sub m3OrthoFront(ByRef M(,) As Single)
	' UPGRADE_INFO (#0501): The 'm3OrthoFront' member isn't used anywhere in current application.
		m3Identity(M)
		M(3, 3) = 0
	End Sub

	' Create an identity matrix.
	Public Sub m3Identity(ByRef M(,) As Single)
		Dim i As Short
		Dim j As Short
		For i = 1 To 4
			For j = 1 To 4
				If i = j Then 
					M(i, j) = 1
				Else
					M(i, j) = 0
				End If
			Next
		Next
	End Sub

	' Normalize a 3-D point vector.
	Public Sub m3NormalizeCoords(ByRef x As Single, ByRef y As Single, ByRef z As Single, ByRef S As Single)
	' UPGRADE_INFO (#0501): The 'm3NormalizeCoords' member isn't used anywhere in current application.
		x /= S
		y /= S
		z /= S
		S = 1
	End Sub

	' Normalize a 3-D point vector.
	Public Sub m3NormalizePoint(ByRef P() As Single)
	' UPGRADE_INFO (#0501): The 'm3NormalizePoint' member isn't used anywhere in current application.
		Dim i As Short
		Dim value As Single = P(4)
		
		For i = 1 To 3
			P(i) /= value
		Next
		P(4) = 1
	End Sub

	' Normalize a 3-D transformation matrix.
	Public Sub m3NormalizeMatrix(ByRef M(,) As Single)
	' UPGRADE_INFO (#0501): The 'm3NormalizeMatrix' member isn't used anywhere in current application.
		Dim i As Short
		Dim j As Short
		Dim value As Single = M(4, 4)
		For i = 1 To 4
			For j = 1 To 4
				M(i, j) = M(i, j) / value
			Next
		Next
	End Sub

	' Create a 3-D transformation matrix for a
	' perspective projection along the Z axis onto
	' the X-Y plane with focus at the origin and the
	' center of projection at distance (0, 0, D).
	Public Sub m3PerspectiveXZ(ByRef M(,) As Single, ByVal D As Single)
		m3Identity(M)
		If D <> 0 Then  M(3, 4) = -1 / D
	End Sub

	' Create a 3-D transformation matrix
	Public Sub m3Project(ByRef M(,) As Single, ByVal ptype As Short, ByVal Cx As Single, ByVal Cy As Single, ByVal Cz As Single, ByVal Fx As Single, ByVal Fy As Single, ByVal Fz As Single, ByVal ux As Single, ByVal uy As Single, ByVal uz As Single)
		Static M1(4, 4) As Single
		Static M2(4, 4) As Single
		Static M3(4, 4) As Single
		Static M4(4, 4) As Single
		Static M5(4, 4) As Single
		Static M12(4, 4) As Single
		Static M34(4, 4) As Single
		Static M1234(4, 4) As Single
		Dim sin1 As Single
		Dim cos1 As Single
		Dim sin2 As Single
		Dim cos2 As Single
		Dim sin3 As Single
		Dim cos3 As Single
		Dim A As Single
		Dim b As Single
		Dim C As Single
		Dim d1 As Single
		Dim d2 As Single
		Dim d3 As Single
		Dim up1(4) As Single
		Dim up2(4) As Single
		
		' Translate the focus to the origin.
		m3Translate(M1, -Fx, -Fy, -Fz)
		
		A = Cx - Fx
		b = Cy - Fy
		C = Cz - Fz
		d1 = Math.Sqrt(A * A + C * C)
		If d1 <> 0 Then 
			sin1 = -A / d1
			cos1 = C / d1
		End If
		d2 = Math.Sqrt(A * A + b * b + C * C)
		If d2 <> 0 Then 
			sin2 = b / d2
			cos2 = d1 / d2
		End If
		
		' Rotate around the Y axis to place the
		' center of projection in the Y-Z plane.
		m3Identity(M2)
		
		' If d1 = 0 then the center of projection
		' already lies in the Y axis and thus the Y-Z plane.
		If d1 <> 0 Then 
			M2(1, 1) = cos1
			M2(1, 3) = -sin1
			M2(3, 1) = sin1
			M2(3, 3) = cos1
		End If
		
		' Rotate around the X axis to place the
		' center of projection in the Z axis.
		m3Identity(M3)
		
		' If d2 = 0 then the center of projection
		' lies at the origin. This makes projection
		' impossible.
		If d2 <> 0 Then 
			M3(2, 2) = cos2
			M3(2, 3) = sin2
			M3(3, 2) = -sin2
			M3(3, 3) = cos2
		End If
		
		' Apply the rotations to the UP vector.
		up1(1) = ux
		up1(2) = uy
		up1(3) = uz
		up1(4) = 1
		m3Apply(up1, M2, up2)
		m3Apply(up2, M3, up1)
		
		' Rotate around the Z axis to put the UP
		' vector in the Y-Z plane.
		d3 = Math.Sqrt(up1(1) * up1(1) + up1(2) * up1(2))
		m3Identity(M4)
		
		' If d3 = 0 then the UP vector is a zero
		' vector so do nothing.
		If d3 <> 0 Then 
			sin3 = up1(1) / d3
			cos3 = up1(2) / d3
			M4(1, 1) = cos3
			M4(1, 2) = sin3
			M4(2, 1) = -sin3
			M4(2, 2) = cos3
		End If
		
		' Project.
		If ptype = m3Perspective And d2 <> 0 Then 
			m3PerspectiveXZ(M5, d2)
		Else
			m3Identity(M5)
		End If
		
		' Combine the transformations.
		m3MatMultiply(M12, M1, M2)
		m3MatMultiply(M34, M3, M4)
		m3MatMultiply(M1234, M12, M34)
		If ptype = m3Perspective Then 
			m3MatMultiplyFull(M, M1234, M5)
		Else
			m3MatMultiply(M, M1234, M5)
		End If
	End Sub

	' Create a 3-D transformation matrix for a
	' perspective projection with
	'       center of projection    (r, phi, theta)
	'       focus                   (fx, fy, fx)
	'       up vector               <ux, uy, uz>
	' ptype should be m3Perspective or m3Parallel.
	Public Sub m3PProject(ByRef M(,) As Single, ByVal ptype As Short, ByVal r As Single, ByVal phi As Single, ByVal theta As Single, ByVal Fx As Single, ByVal Fy As Single, ByVal Fz As Single, ByVal ux As Single, ByVal uy As Single, ByVal uz As Single)
		Dim Cx As Single
		Dim Cy As Single
		Dim Cz As Single
		Dim R2 As Single
		
		' Convert to Cartesian coordinates.
		Cy = r * Math.Sin(phi)
		R2 = r * Math.Cos(phi)
		Cx = R2 * Math.Cos(theta)
		Cz = R2 * Math.Sin(theta)
		m3Project(M, ptype, Cx, Cy, Cz, Fx, Fy, Fz, ux, uy, uz)
	End Sub

	' Create a transformation matrix for reflecting
	' across the plane passing through (p1, p2, p3)
	' with normal vector <n1, n2, n3>.
	Public Sub m3Reflect(ByRef M(,) As Single, ByVal p1 As Single, ByVal p2 As Single, ByVal p3 As Single, ByVal n1 As Single, ByVal n2 As Single, ByVal n3 As Single)
	' UPGRADE_INFO (#0501): The 'm3Reflect' member isn't used anywhere in current application.
		Dim t(4, 4) As Single ' Translate.
		Dim R1(4, 4) As Single ' Rotate 1.
		Dim R2(4, 4) As Single ' Rotate 2.
		Dim S(4, 4) As Single ' Reflect.
		Dim R2i(4, 4) As Single ' Unrotate 2.
		Dim R1i(4, 4) As Single ' Unrotate 1.
		Dim Ti(4, 4) As Single ' Untranslate.
		Dim D As Single
		Dim L As Single
		Dim M12(4, 4) As Single
		Dim M34(4, 4) As Single
		Dim M1234(4, 4) As Single
		Dim M56(4, 4) As Single
		Dim M567(4, 4) As Single
		
		' Translate the plane to the origin.
		m3Translate(t, -p1, -p2, -p3)
		m3Translate(Ti, p1, p2, p3)
		
		' Rotate around Z-axis until the normal is in
		' the Y-Z plane.
		m3Identity(R1)
		D = Math.Sqrt(n1 * n1 + n2 * n2)
		R1(1, 1) = n2 / D
		R1(1, 2) = n1 / D
		R1(2, 1) = -R1(1, 2)
		R1(2, 2) = R1(1, 1)
		
		m3Identity(R1i)
		R1i(1, 1) = R1(1, 1)
		R1i(1, 2) = -R1(1, 2)
		R1i(2, 1) = -R1(2, 1)
		R1i(2, 2) = R1(2, 2)
		
		' Rotate around the X-axis until the normal
		' lies along the Y axis.
		m3Identity(R2)
		L = Math.Sqrt(n1 * n1 + n2 * n2 + n3 * n3)
		R2(2, 2) = D / L
		R2(2, 3) = -n3 / L
		R2(3, 2) = -R2(2, 3)
		R2(3, 3) = R2(2, 2)
		
		m3Identity(R2i)
		R2i(2, 2) = R2(2, 2)
		R2i(2, 3) = -R2(2, 3)
		R2i(3, 2) = -R2(3, 2)
		R2i(3, 3) = R2(3, 3)
		
		' Reflect across the X-Z plane.
		m3Identity(S)
		S(2, 2) = -1
		
		' Combine the matrices.
		m3MatMultiply(M12, t, R1)
		m3MatMultiply(M34, R2, S)
		m3MatMultiply(M1234, M12, M34)
		m3MatMultiply(M56, R2i, R1i)
		m3MatMultiply(M567, M56, Ti)
		m3MatMultiply(M, M1234, M567)
	End Sub

	' Create a transformation matrix for rotating
	' through angle theta around a line passing
	' through (p1, p2, p3) in direction <d1, d2, d3>.
	' Theta is measured counterclockwise as you look
	' down the line opposite the line's direction.
	Public Sub m3LineRotate(ByRef M(,) As Single, ByVal p1 As Single, ByVal p2 As Single, ByVal p3 As Single, ByVal d1 As Single, ByVal d2 As Single, ByVal d3 As Single, ByVal theta As Single)
	' UPGRADE_INFO (#0501): The 'm3LineRotate' member isn't used anywhere in current application.
		Dim t(4, 4) As Single ' Translate.
		Dim R1(4, 4) As Single ' Rotate 1.
		Dim R2(4, 4) As Single ' Rotate 2.
		Dim Rot3(4, 4) As Single ' Rotate.
		Dim R2i(4, 4) As Single ' Unrotate 2.
		Dim R1i(4, 4) As Single ' Unrotate 1.
		Dim Ti(4, 4) As Single ' Untranslate.
		Dim D As Single
		Dim L As Single
		Dim M12(4, 4) As Single
		Dim M34(4, 4) As Single
		Dim M1234(4, 4) As Single
		Dim M56(4, 4) As Single
		Dim M567(4, 4) As Single
		
		' Translate the plane to the origin.
		m3Translate(t, -p1, -p2, -p3)
		m3Translate(Ti, p1, p2, p3)
		
		' Rotate around Z-axis until the line is in
		' the Y-Z plane.
		m3Identity(R1)
		D = Math.Sqrt(d1 * d1 + d2 * d2)
		R1(1, 1) = d2 / D
		R1(1, 2) = d1 / D
		R1(2, 1) = -R1(1, 2)
		R1(2, 2) = R1(1, 1)
		
		m3Identity(R1i)
		R1i(1, 1) = R1(1, 1)
		R1i(1, 2) = -R1(1, 2)
		R1i(2, 1) = -R1(2, 1)
		R1i(2, 2) = R1(2, 2)
		
		' Rotate around the X-axis until the line
		' lies along the Y axis.
		m3Identity(R2)
		L = Math.Sqrt(d1 * d1 + d2 * d2 + d3 * d3)
		R2(2, 2) = D / L
		R2(2, 3) = -d3 / L
		R2(3, 2) = -R2(2, 3)
		R2(3, 3) = R2(2, 2)
		
		m3Identity(R2i)
		R2i(2, 2) = R2(2, 2)
		R2i(2, 3) = -R2(2, 3)
		R2i(3, 2) = -R2(3, 2)
		R2i(3, 3) = R2(3, 3)
		
		' Rotate around the line (Y axis).
		m3YRotate(Rot3, theta)
		
		' Combine the matrices.
		m3MatMultiply(M12, t, R1)
		m3MatMultiply(M34, R2, Rot3)
		m3MatMultiply(M1234, M12, M34)
		m3MatMultiply(M56, R2i, R1i)
		m3MatMultiply(M567, M56, Ti)
		m3MatMultiply(M, M1234, M567)
	End Sub

	' Create a 3-D transformation matrix for scaling
	' by scale factors Sx, Sy, and Sz.
	Public Sub m3Scale(ByRef M(,) As Single, ByVal Sx As Single, ByVal Sy As Single, ByVal Sz As Single)
		m3Identity(M)
		M(1, 1) = Sx
		M(2, 2) = Sy
		M(3, 3) = Sz
	End Sub

	' Create a 3-D transformation matrix for
	' translation by Tx, Ty, and Tz.
	Public Sub m3Translate(ByRef M(,) As Single, ByVal Tx As Single, ByVal Ty As Single, ByVal Tz As Single)
		m3Identity(M)
		M(4, 1) = Tx
		M(4, 2) = Ty
		M(4, 3) = Tz
	End Sub

	' Create a 3-D transformation matrix for rotation
	' around the X axis (angle measured in radians).
	Public Sub m3XRotate(ByRef M(,) As Single, ByVal theta As Single)
	' UPGRADE_INFO (#0501): The 'm3XRotate' member isn't used anywhere in current application.
		m3Identity(M)
		M(2, 2) = Math.Cos(theta)
		M(3, 3) = M(2, 2)
		M(2, 3) = Math.Sin(theta)
		M(3, 2) = -M(2, 3)
	End Sub

	' Create a 3-D transformation matrix for rotation
	' around the Y axis (angle measured in radians).
	Public Sub m3YRotate(ByRef M(,) As Single, ByVal theta As Single)
	' UPGRADE_INFO (#0511): The 'm3YRotate' member is referenced only by members that haven't found to be used in the current project/solution.
		m3Identity(M)
		M(1, 1) = Math.Cos(theta)
		M(3, 3) = M(1, 1)
		M(3, 1) = Math.Sin(theta)
		M(1, 3) = -M(3, 1)
	End Sub

	' Create a 3-D transformation matrix for rotation
	' around the Z axis (angle measured in radians).
	Public Sub m3ZRotate(ByRef M(,) As Single, ByVal theta As Single)
	' UPGRADE_INFO (#0501): The 'm3ZRotate' member isn't used anywhere in current application.
		m3Identity(M)
		M(1, 1) = Math.Cos(theta)
		M(2, 2) = M(1, 1)
		M(1, 2) = Math.Sin(theta)
		M(2, 1) = -M(1, 2)
	End Sub

	' Create a matrix that rotates around the Y axis
	' so the point (x, y, z) lies in the X-Z plane.
	Public Sub m3YRotateIntoXZ(ByRef Result(,) As Single, ByVal x As Single, ByVal y As Single, ByVal z As Single)
	' UPGRADE_INFO (#0501): The 'm3YRotateIntoXZ' member isn't used anywhere in current application.
		Dim D As Single
		
		m3Identity(Result)
		D = Math.Sqrt(x * x + y * y)
		Result(1, 1) = x / D
		Result(1, 2) = -y / D
		Result(2, 1) = -Result(1, 2)
		Result(2, 2) = Result(1, 1)
	End Sub

	' Set copy = orig.
	Public Sub m3MatCopy(ByRef copy(,) As Single, ByVal orig(,) As Single)
	' UPGRADE_INFO (#0501): The 'm3MatCopy' member isn't used anywhere in current application.
		Dim i As Short
		Dim j As Short
		
		For i = 1 To 4
			For j = 1 To 4
				copy(i, j) = orig(i, j)
			Next
		Next
	End Sub

	' Apply a transformation matrix to a point where
	' the transformation may not have 0, 0, 0, 1 in
	' its final column. Normalize only the X and Y
	' components of the result to preserve the Z
	' information.
	Public Sub m3ApplyFull(ByVal V() As Single, ByVal M(,) As Single, ByRef Result() As Single)
	' UPGRADE_INFO (#0511): The 'm3ApplyFull' member is referenced only by members that haven't found to be used in the current project/solution.
		Dim i As Short
		Dim j As Short
		Dim value As Single
		
		For i = 1 To 4
			value = 0#
			For j = 1 To 4
				value = value + V(j) * M(j, i)
			Next
			Result(i) = value
		Next
		
		' Renormalize the point.
		' Note that value still holds Result(4).
		If value <> 0 Then 
			Result(1) /= value
			Result(2) /= value
			' Do not transform the Z component.
		Else
			' Make the Z value greater than that of
			' the center of projection so the point
			' will be clipped.
			Result(3) = INFINITY
		End If
		Result(4) = 1#
	End Sub

	' Apply a transformation matrix to a point.
	Public Sub m3Apply(ByVal V() As Single, ByVal M(,) As Single, ByRef Result() As Single)
		Result(1) = V(1) * M(1, 1) + V(2) * M(2, 1) + V(3) * M(3, 1) + M(4, 1)
		Result(2) = V(1) * M(1, 2) + V(2) * M(2, 2) + V(3) * M(3, 2) + M(4, 2)
		Result(3) = V(1) * M(1, 3) + V(2) * M(2, 3) + V(3) * M(3, 3) + M(4, 3)
		Result(4) = 1#
	End Sub

	' Multiply two matrices together. The matrices
	' may not contain 0, 0, 0, 1 in their last
	' columns.
	Public Sub m3MatMultiplyFull(ByRef Result(,) As Single, ByVal A(,) As Single, ByVal b(,) As Single)
		Dim i As Short
		Dim j As Short
		Dim k As Short
		Dim value As Single
		
		For i = 1 To 4
			For j = 1 To 4
				value = 0#
				For k = 1 To 4
					value = value + A(i, k) * b(k, j)
				Next
				Result(i, j) = value
			Next
		Next
	End Sub
	
	' Multiply two matrices together.
	Public Sub m3MatMultiply(ByRef Result(,) As Single, ByVal A(,) As Single, ByVal b(,) As Single)
		Result(1, 1) = A(1, 1) * b(1, 1) + A(1, 2) * b(2, 1) + A(1, 3) * b(3, 1)
		Result(1, 2) = A(1, 1) * b(1, 2) + A(1, 2) * b(2, 2) + A(1, 3) * b(3, 2)
		Result(1, 3) = A(1, 1) * b(1, 3) + A(1, 2) * b(2, 3) + A(1, 3) * b(3, 3)
		Result(1, 4) = 0#
		Result(2, 1) = A(2, 1) * b(1, 1) + A(2, 2) * b(2, 1) + A(2, 3) * b(3, 1)
		Result(2, 2) = A(2, 1) * b(1, 2) + A(2, 2) * b(2, 2) + A(2, 3) * b(3, 2)
		Result(2, 3) = A(2, 1) * b(1, 3) + A(2, 2) * b(2, 3) + A(2, 3) * b(3, 3)
		Result(2, 4) = 0#
		Result(3, 1) = A(3, 1) * b(1, 1) + A(3, 2) * b(2, 1) + A(3, 3) * b(3, 1)
		Result(3, 2) = A(3, 1) * b(1, 2) + A(3, 2) * b(2, 2) + A(3, 3) * b(3, 2)
		Result(3, 3) = A(3, 1) * b(1, 3) + A(3, 2) * b(2, 3) + A(3, 3) * b(3, 3)
		Result(3, 4) = 0#
		Result(4, 1) = A(4, 1) * b(1, 1) + A(4, 2) * b(2, 1) + A(4, 3) * b(3, 1) + b(4, 1)
		Result(4, 2) = A(4, 1) * b(1, 2) + A(4, 2) * b(2, 2) + A(4, 3) * b(3, 2) + b(4, 2)
		Result(4, 3) = A(4, 1) * b(1, 3) + A(4, 2) * b(2, 3) + A(4, 3) * b(3, 3) + b(4, 3)
		Result(4, 4) = 1#
	End Sub

	' Compute the cross product of two vectors.
	'Set <x, y, z> = <x1, y1, z1> X <x2, y2, z2>.
	Public Sub m3Cross(ByRef x As Single, ByRef y As Single, ByRef z As Single, ByVal x1 As Single, ByVal y1 As Single, ByVal z1 As Single, ByVal x2 As Single, ByVal y2 As Single, ByVal z2 As Single)
	' UPGRADE_INFO (#0501): The 'm3Cross' member isn't used anywhere in current application.
		x = y1 * z2 - z1 * y2
		y = z1 * x2 - x1 * z2
		z = x1 * y2 - y1 * x2
	End Sub

	' Give the vector the indicated length.
	Public Sub m3SizeVector(ByVal L As Single, ByRef x As Single, ByRef y As Single, ByRef z As Single)
	' UPGRADE_INFO (#0501): The 'm3SizeVector' member isn't used anywhere in current application.
		L = L / Math.Sqrt(x * x + y * y + z * z)
		x *= L
		y *= L
		z *= L
	End Sub

	Public Sub WaitTill(ByVal next_time As Integer)
		Do
			DoEvents6()
		Loop While GetTickCount() < next_time
	End Sub

End Module
