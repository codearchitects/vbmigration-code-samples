VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "objPicture"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Public objects As New Collection

' Draw the picture on the PictureBox.

Sub Draw(canvas As Object, Optional r As Variant)
Dim obj As Object

    For Each obj In objects
        obj.Draw canvas, r
    Next obj
End Sub


'' Apply a transformation matrix which may not
'' contain 0, 0, 0, 1 in the last column to the
'' objects.
Sub ApplyFull(M() As Single)
Dim obj As Object

    For Each obj In objects
        obj.ApplyFull M
    Next obj
End Sub
'' Apply a transformation matrix to the objects.
Sub Apply(M() As Single)
Dim obj As Object

    For Each obj In objects
        obj.Apply M
    Next obj
End Sub


