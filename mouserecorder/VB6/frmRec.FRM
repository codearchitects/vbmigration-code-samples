VERSION 5.00
Begin VB.Form frmRec 
   BorderStyle     =   0  'Kein
   Caption         =   "Form1"
   ClientHeight    =   480
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   2190
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmRec.frx":0000
   ScaleHeight     =   480
   ScaleWidth      =   2190
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows-Standard
End
Attribute VB_Name = "frmRec"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim ShapeForm As clsTransForm 'make a reference to the class

Private Sub Form_Load()
  Set ShapeForm = New clsTransForm 'instantiate the object from the class
  
  Me.Top = 0
  Me.Left = Screen.Width - Me.Width
  
  If Dir(ApplPath & "recfrm.shp") = "" Then   ' Save the FormRegion
    ShapeForm.ShapeMe Me, RGB(0, 0, 255), False, ApplPath & "recfrm.shp"
  Else  ' Only use below if you wish to recalculate everything...
    ShapeForm.ShapeMe Me, RGB(0, 0, 255), True, ApplPath & "recfrm.shp"
  End If
End Sub

