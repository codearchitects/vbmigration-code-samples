VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Class1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Dim shadowx As Integer
Dim shadowy As Integer
Dim i As Integer



Sub Text3D(strng As String, fnt As String, fntsize As Integer, Xval As Integer _
, Yval As Integer, depth As Integer, rood As Integer, blauw As Integer, groen As Integer)

    Form1.Picture1.AutoRedraw = True
        Form1.Picture1.FontSize = fntsize
        
         Form1.Picture1.Font = fnt
          Form1.Picture1.ForeColor = RGB(0, 0, 0)
           shadowx = Xval
           shadowy = Yval
           For i = 0 To depth
            Form1.Picture1.CurrentX = shadowx - i
            Form1.Picture1.CurrentY = shadowy + i
             If i = depth Then Form1.Picture1.ForeColor = RGB(rood + 20, groen + 20, blauw + 20)
             Form1.Picture1.Print strng
             Next i
             'Form1.AutoRedraw = False
             

End Sub
