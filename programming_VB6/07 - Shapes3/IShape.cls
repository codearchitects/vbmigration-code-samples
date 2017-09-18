VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "IShape"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
' The IShape interface

Public Hidden As Boolean

Sub Draw(pic As Object)
    '
End Sub

Sub Move(stepX As Single, stepY As Single)
    '
End Sub

Sub Zoom(ZoomFactor As Single)
    '
End Sub

