' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure Vertex

	Public A As Short
	Public B As Short
	Public C As Short
End Structure

Friend Structure Order
 'Yüzeylerin Z yüksekliklerinin sýralanmasý için kullanýlýyor.
	Public ZValue As Single 'Z deðeri
	Public iVisible As Short 'FaceV indexi
End Structure

Friend Structure POINTAPI

	Public X As Integer
	Public Y As Integer
End Structure

Friend Module modObject

	Friend Structure DrawLimits
	
	' UPGRADE_INFO (#0501): The 'DrawLimits' member isn't used anywhere in current application.
		Public Min As POINTAPI
		Public Max As POINTAPI
	End Structure

	Friend Structure Part
	 'Parçanýn tanýmlandýðý deðiþken
		Public Caption As String 'Parçanýn adý
		Public Position As Vector 'Orijine göre parçanýn konumu
		Public Direction As Vector 'Koordinat sistemine göre parçanýn dönüklüðü,yatýklýðý
		Public Vertices() As Vector 'Orjinal nokta tanýmlamalarý
		Public VerticesT() As Vector 'Transform olmuþ noktalar(rotate ve/veya transform olmuþ)
		Public VerticesV() As Vector 'Görünen nokta tanýmlamalarý
		Public ScreenCoord() As POINTAPI
		Public Normal() As Vector 'Orjinal yüzey normalleri.Dosya yüklendiðinde bir kere hesaplanýyor.
		Public NormalT() As Vector 'Orjinal yüzey normalleri.Dosya yüklendiðinde bir kere hesaplanýyor.
		Public Faces() As Vertex
		Public NumVertices As Short
		Public NumFaces As Short
		Public FaceV() As Order '"Visible Face" Görünen yüzeylerin Face indexlerinin saklandýðý deðiþken
		Public Scale As Single 'Parçanýn büyüklüðü.Ayný dosyadan farklý büyüklükte parçalar elde etmek için.
		Public Color As ColorRGB
	
	#Region "Clone method"
	
		Public Function Clone() As Part
			Dim copy As Part = Me
			copy.Vertices = Me.Vertices.Clone()
			copy.VerticesT = Me.VerticesT.Clone()
			copy.VerticesV = Me.VerticesV.Clone()
			copy.ScreenCoord = Me.ScreenCoord.Clone()
			copy.Normal = Me.Normal.Clone()
			copy.NormalT = Me.NormalT.Clone()
			copy.Faces = Me.Faces.Clone()
			copy.FaceV = Me.FaceV.Clone()
			Return copy
		End Function
	
	#End Region
	
	End Structure

	Public Camera As Vector
	Public Light As Vector
	Public LightT As Vector
	Public ObjPart As Part
	'Public ObjLimits As DrawLimits
	
	Public Sub LoadObject(ByVal strFileName As String)
		
		Dim i As Short
		' UPGRADE_INFO (#0501): The 'rgbcol' member isn't used anywhere in current application.
		Dim rgbcol As ColorRGB
		
		With ObjPart
			FileOpen6(1, strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
			FileInput6(1, .Caption) 'Obje adý
			FileInput6(1, .Scale) 'Ölçek
			FileInput6(1, .Color.R): FileInput6(1, .Color.G): FileInput6(1, .Color.B) 'RGB, renk bilgileri
			FileInput6(1, .Direction.X): FileInput6(1, .Direction.Y): FileInput6(1, .Direction.Z) 'Rotasyon
			FileInput6(1, .Position.X): FileInput6(1, .Position.Y): FileInput6(1, .Position.Z) 'Pozisyon
			FileInput6(1, .NumVertices): FileInput6(1, .NumFaces) 'Nokta ve yüzey adetleri
			ReDim .Vertices(.NumVertices)
			ReDim .ScreenCoord(.NumVertices)
			ReDim .Faces(.NumFaces)
			ReDim .Normal(.NumFaces)
			For i = 0 To (.NumVertices) 'Noktalar(Vertices)
				FileInput6(1, .Vertices(i).X): FileInput6(1, .Vertices(i).Y): FileInput6(1, .Vertices(i).Z)
				.Vertices(i).W = 1
			Next
			For i = 0 To (.NumFaces) 'Yüzeyler(Faces)
				FileInput6(1, .Faces(i).A): FileInput6(1, .Faces(i).B): FileInput6(1, .Faces(i).C)
			Next
			.VerticesT = .Vertices.Clone()
			Call CalculateNormal() 'Yüklenen parçanýn normali hesaplanýyor.
			FileClose6(1)
		End With
		
	End Sub

End Module
