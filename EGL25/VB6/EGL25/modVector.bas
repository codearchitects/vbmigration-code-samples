Attribute VB_Name = "modVector"
Option Explicit

Public Type Vector
    X As Single
    Y As Single
    Z As Single
    W As Single
End Type

Public Function VectorSet(X As Single, Y As Single, Z As Single) As Vector
     
    VectorSet.X = X
    VectorSet.Y = Y
    VectorSet.Z = Z

End Function

Public Function VectorSub(V1 As Vector, V2 As Vector) As Vector

    VectorSub.X = V1.X - V2.X
    VectorSub.Y = V1.Y - V2.Y
    VectorSub.Z = V1.Z - V2.Z

End Function

Public Function VectorAdd(V1 As Vector, V2 As Vector) As Vector
     
    VectorAdd.X = V1.X + V2.X
    VectorAdd.Y = V1.Y + V2.Y
    VectorAdd.Z = V1.Z + V2.Z

End Function

'------------------------------------------------
'Function:  VectorDot
'DotProduct da diyorlar
'Ýki noktanýn orijine göre konumlarýný belirliyor.
'------------------------------------------------
Public Function VectorDot(V1 As Vector, V2 As Vector) As Single

    VectorDot = (V1.X * V2.X) + _
                (V1.Y * V2.Y) + _
                (V1.Z * V2.Z)

End Function

'-----------------------------------------------
'Function:VectorCross
'CrossProduct da diyorlar.
'iki nokta ve orijin ile oluþan üçgenin normali bulunuyor.
'Nasýl yaptýðýný tam olarak çözemedim.
'Geriye normalin koordinatýný döndürüyor.
'-----------------------------------------------

Public Function VectorCross(V1 As Vector, V2 As Vector) As Vector
     
    VectorCross.X = (V1.Y * V2.Z) - (V1.Z * V2.Y)
    VectorCross.Y = (V1.Z * V2.X) - (V1.X * V2.Z)
    VectorCross.Z = (V1.X * V2.Y) - (V1.Y * V2.X)

End Function

'-----------------------------------
'Function: VectorNormalize
'Normalize vector
'vektörün eðimini veriyor.Boyu 1 birim (mm) oluyor.
'-----------------------------------
Public Function VectorNormalize(V As Vector) As Vector

    Dim VLength As Single
    
    VLength = Sqr((V.X ^ 2) + (V.Y ^ 2) + (V.Z ^ 2))
    If VLength = 0 Then VLength = 1
    VectorNormalize.X = V.X / VLength
    VectorNormalize.Y = V.Y / VLength
    VectorNormalize.Z = V.Z / VLength

End Function

Public Function VectorScale(V As Vector, S As Single) As Vector
     
    VectorScale.X = V.X * S
    VectorScale.Y = V.Y * S
    VectorScale.Z = V.Z * S

End Function

Public Sub CalculateNormal()

    Dim i As Integer
    With ObjPart
        For i = 0 To .NumFaces
            .Normal(i) = VectorCross _
                        (VectorSub(.Vertices(.Faces(i).c), .Vertices(.Faces(i).B)), _
                         VectorSub(.Vertices(.Faces(i).A), .Vertices(.Faces(i).B)))
            .Normal(i) = VectorNormalize(.Normal(i))
        Next
        .NormalT = .Normal
    End With
    
End Sub


