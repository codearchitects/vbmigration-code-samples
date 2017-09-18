Attribute VB_Name = "modObject"
Option Explicit

Public Type Vertex
    A       As Integer
    B       As Integer
    C       As Integer
End Type

Public Type Order           'Yüzeylerin Z yüksekliklerinin sýralanmasý için kullanýlýyor.
    ZValue   As Single      'Z deðeri
    iVisible As Integer     'FaceV indexi
End Type

Public Type POINTAPI
    X As Long
    Y As Long
End Type

Public Type DrawLimits
    Min As POINTAPI
    Max As POINTAPI
End Type

Public Type Part            'Parçanýn tanýmlandýðý deðiþken
    Caption As String       'Parçanýn adý
    Position As Vector      'Orijine göre parçanýn konumu
    Direction As Vector     'Koordinat sistemine göre parçanýn dönüklüðü,yatýklýðý
    Vertices() As Vector    'Orjinal nokta tanýmlamalarý
    VerticesT() As Vector   'Transform olmuþ noktalar(rotate ve/veya transform olmuþ)
    VerticesV() As Vector   'Görünen nokta tanýmlamalarý
    ScreenCoord() As POINTAPI
    Normal()  As Vector     'Orjinal yüzey normalleri.Dosya yüklendiðinde bir kere hesaplanýyor.
    NormalT()  As Vector    'Orjinal yüzey normalleri.Dosya yüklendiðinde bir kere hesaplanýyor.
    Faces() As Vertex
    NumVertices As Integer
    NumFaces As Integer
    FaceV() As Order        '"Visible Face" Görünen yüzeylerin Face indexlerinin saklandýðý deðiþken
    Scale As Single         'Parçanýn büyüklüðü.Ayný dosyadan farklý büyüklükte parçalar elde etmek için.
    Color As ColorRGB
End Type

Public Camera As Vector
Public Light As Vector
Public LightT As Vector
Public ObjPart As Part
'Public ObjLimits As DrawLimits

Public Sub LoadObject(ByVal strFileName As String)

  Dim i      As Integer
  Dim rgbcol As ColorRGB

    With ObjPart
        Open strFileName For Input As 1
            Input #1, .Caption                                  'Obje adý
            Input #1, .Scale                                    'Ölçek
            Input #1, .Color.R, .Color.G, .Color.B              'RGB, renk bilgileri
            Input #1, .Direction.X, .Direction.Y, .Direction.Z  'Rotasyon
            Input #1, .Position.X, .Position.Y, .Position.Z     'Pozisyon
            Input #1, .NumVertices, .NumFaces                   'Nokta ve yüzey adetleri
            ReDim .Vertices(.NumVertices)
            ReDim .ScreenCoord(.NumVertices)
            ReDim .Faces(.NumFaces)
            ReDim .Normal(.NumFaces)
            For i = 0 To (.NumVertices)                         'Noktalar(Vertices)
                Input #1, .Vertices(i).X, _
                          .Vertices(i).Y, _
                          .Vertices(i).Z
                          .Vertices(i).W = 1
            Next i
            For i = 0 To (.NumFaces)                            'Yüzeyler(Faces)
                Input #1, .Faces(i).A, _
                          .Faces(i).B, _
                          .Faces(i).C
            Next i
            .VerticesT = .Vertices
            Call CalculateNormal                                'Yüklenen parçanýn normali hesaplanýyor.
        Close #1
    End With

End Sub



