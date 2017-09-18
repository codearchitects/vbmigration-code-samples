VERSION 5.00
Begin VB.Form Form4 
   Caption         =   "Custom Format Drag-and-Drop"
   ClientHeight    =   3885
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7245
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form4"
   ScaleHeight     =   3885
   ScaleWidth      =   7245
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtField 
      Height          =   375
      Index           =   4
      Left            =   4560
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   10
      Top             =   2040
      Width           =   2535
   End
   Begin VB.TextBox txtField 
      Height          =   375
      Index           =   3
      Left            =   2280
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   7
      Top             =   2040
      Width           =   2055
   End
   Begin VB.TextBox txtField 
      Height          =   375
      Index           =   2
      Left            =   120
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   5
      Top             =   2040
      Width           =   1935
   End
   Begin VB.TextBox txtField 
      Height          =   375
      Index           =   1
      Left            =   120
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   3
      Top             =   1200
      Width           =   6975
   End
   Begin VB.TextBox txtField 
      Height          =   375
      Index           =   0
      Left            =   120
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   1
      Top             =   360
      Width           =   6975
   End
   Begin VB.Image imgDrag 
      BorderStyle     =   1  'Fixed Single
      Height          =   780
      Left            =   6000
      OLEDropMode     =   1  'Manual
      Picture         =   "Form4.frx":0000
      Stretch         =   -1  'True
      Top             =   2760
      Width           =   900
   End
   Begin VB.Label Label1 
      Caption         =   "&SSN"
      Height          =   255
      Index           =   2
      Left            =   4560
      TabIndex        =   9
      Top             =   1680
      Width           =   495
   End
   Begin VB.Label Label2 
      Caption         =   $"Form4.frx":0102
      Height          =   1095
      Left            =   120
      TabIndex        =   8
      Top             =   2640
      Width           =   5655
   End
   Begin VB.Label Label1 
      Caption         =   "Sa&lary"
      Height          =   255
      Index           =   4
      Left            =   2280
      TabIndex        =   6
      Top             =   1680
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "&Birth Date "
      Height          =   255
      Index           =   3
      Left            =   120
      TabIndex        =   4
      Top             =   1680
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "&Address"
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "&Name"
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   855
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' note that in the original API declaration - as reported by the API viewer -
' this function is declared As Long. However, because the SetData method only
' accept Integer formats we need to declare it as Integer, otherwise an
' overflow error will occur
Private Declare Function RegisterClipboardFormat Lib "user32" Alias "RegisterClipboardFormatA" (ByVal lpString As String) As Integer

Dim CustomFormat As Integer
Dim Dragging As Integer         ' 1=copying, 2=moving

Private Sub Form_Load()
    ' register a custom clipboard format
    CustomFormat = RegisterClipboardFormat("PersonalData")
End Sub

Private Sub imgDrag_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 2 Then
        Dragging = IIf(Shift And vbCtrlMask, 1, 2)
        imgDrag.OLEDrag
    End If
End Sub

Private Sub imgDrag_OLEStartDrag(Data As DataObject, AllowedEffects As Long)
    ' signal that we are moving data in proprietary format
    Data.SetData , CustomFormat
    AllowedEffects = IIf(Dragging = 1, vbDropEffectCopy, vbDropEffectMove)
End Sub

Private Sub imgDrag_OLESetData(Data As DataObject, DataFormat As Integer)
    ' build a long string made up of field contents
    Dim i As Integer, text As String, bytes() As Byte
    For i = 0 To txtField.UBound
        If i > 0 Then text = text & vbNullChar
        text = text & txtField(i)
    Next
    ' move to an array the byte, then assign to DataObject
    bytes() = text
    Data.SetData bytes(), CustomFormat
End Sub

Private Sub imgDrag_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    If Dragging Or Data.GetFormat(CustomFormat) = False Then
        ' prevent from dropping on this same form
        Effect = 0
    End If
End Sub

Private Sub imgDrag_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Dim bytes() As Byte, text() As String, i As Integer
    
    ' get the data
    bytes() = Data.GetData(CustomFormat)
    ' retrieve individual values, and assign to fields
    text() = Split(CStr(bytes), vbNullChar)
    For i = 0 To txtField.UBound
        txtField(i) = text(i)
    Next
End Sub

Private Sub imgDrag_OLECompleteDrag(Effect As Long)
    Dim i As Integer
    If Dragging = 2 Then
        'this was a move command
        For i = 0 To txtField.UBound
            txtField(i) = ""
        Next
    End If
    ' prepare for another drag (or drop) command
    Dragging = 0
End Sub




