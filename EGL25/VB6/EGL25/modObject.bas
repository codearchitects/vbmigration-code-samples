Attribute VB_Name = "modObject"
Option Explicit

Public Type Vertex
    A       As Integer
    B       As Integer
    C       As Integer
End Type

Public Type Order           'Y�zeylerin Z y�ksekliklerinin s�ralanmas� i�in kullan�l�yor.
    ZValue   As Single      'Z de�eri
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

Public Type Part            'Par�an�n tan�mland��� de�i�ken
    Caption As String       'Par�an�n ad�
    Position As Vector      'Orijine g�re par�an�n konumu
    Direction As Vector     'Koordinat sistemine g�re par�an�n d�n�kl���,yat�kl���
    Vertices() As Vector    'Orjinal nokta tan�mlamalar�
    VerticesT() As Vector   'Transform olmu� noktalar(rotate ve/veya transform olmu�)
    VerticesV() As Vector   'G�r�nen nokta tan�mlamalar�
    ScreenCoord() As POINTAPI
    Normal()  As Vector     'Orjinal y�zey normalleri.Dosya y�klendi�inde bir kere hesaplan�yor.
    NormalT()  As Vector    'Orjinal y�zey normalleri.Dosya y�klendi�inde bir kere hesaplan�yor.
    Faces() As Vertex
    NumVertices As Integer
    NumFaces As Integer
    FaceV() As Order        '"Visible Face" G�r�nen y�zeylerin Face indexlerinin sakland��� de�i�ken
    Scale As Single         'Par�an�n b�y�kl���.Ayn� dosyadan farkl� b�y�kl�kte par�alar elde etmek i�in.
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
            Input #1, .Caption                                  'Obje ad�
            Input #1, .Scale                                    '�l�ek
            Input #1, .Color.R, .Color.G, .Color.B              'RGB, renk bilgileri
            Input #1, .Direction.X, .Direction.Y, .Direction.Z  'Rotasyon
            Input #1, .Position.X, .Position.Y, .Position.Z     'Pozisyon
            Input #1, .NumVertices, .NumFaces                   'Nokta ve y�zey adetleri
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
            For i = 0 To (.NumFaces)                            'Y�zeyler(Faces)
                Input #1, .Faces(i).A, _
                          .Faces(i).B, _
                          .Faces(i).C
            Next i
            .VerticesT = .Vertices
            Call CalculateNormal                                'Y�klenen par�an�n normali hesaplan�yor.
        Close #1
    End With

End Sub



