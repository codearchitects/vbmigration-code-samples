VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5220
   ClientLeft      =   120
   ClientTop       =   420
   ClientWidth     =   9795
   LinkTopic       =   "Form1"
   ScaleHeight     =   5220
   ScaleWidth      =   9795
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdRandomArray 
      Caption         =   "Random Array"
      Height          =   855
      Left            =   240
      TabIndex        =   0
      Top             =   360
      Width           =   2415
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdRandomArray_Click()
   '##RandArr.ArrayBounds ForceVB6Array
   Dim RandArr() As Long
   
   RandArr = RandomArray(10, 20)
   
End Sub

