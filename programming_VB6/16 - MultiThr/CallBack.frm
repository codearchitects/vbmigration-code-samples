VERSION 5.00
Begin VB.Form CCallBack 
   Caption         =   "Form1"
   ClientHeight    =   1125
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   1560
   LinkTopic       =   "Form1"
   ScaleHeight     =   1125
   ScaleWidth      =   1560
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Left            =   120
      Top             =   240
   End
End
Attribute VB_Name = "CCallBack"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' This form can be added to any project to provide callback capabilities
' It should be used as a class, whose only method is DelayedCall

Dim m_Obj As Object
Dim m_MethodName As String

Public Sub DelayedCall(obj As Object, Milliseconds As Long, MethodName As String)
    ' save arguments
    Set m_Obj = obj
    m_MethodName = MethodName
    ' start the timer
    Timer1.Interval = Milliseconds
    Timer1.Enabled = True
End Sub

Private Sub Timer1_Timer()
    ' ensure that there will be no more calls
    Timer1.Enabled = False
    Unload Me
    ' do the callback
    CallByName m_Obj, m_MethodName, VbMethod
End Sub
