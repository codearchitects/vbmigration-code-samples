Attribute VB_Name = "MouseRoutines"
Option Explicit

Private Declare Function GetCursorPos Lib "user32" (lpPoint As POINTAPI) As Long
Private Declare Function SetCursorPos Lib "user32" (ByVal x As Long, ByVal y As Long) As Long
Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)

Public Type POINTAPI
   x As Long
   y As Long
End Type

' Get Cursor coordinates (x,y)   '
Public Function Mouse() As POINTAPI
  Dim result As Long
  result = GetCursorPos(Mouse)
End Function

Public Function MouseX() As Long
  MouseX = Mouse.x
End Function

Public Function MouseY() As Long
  MouseY = Mouse.y
End Function


'Linke Maustaste simulieren
Public Sub MouseLeftClick()
   mouse_event &H2, 0, 0, 0, 0
   mouse_event &H4, 0, 0, 0, 0
End Sub

'Mittlerer Maustaste simulieren
Public Sub MouseMiddleClick()
   mouse_event &H20, 0, 0, 0, 0
   mouse_event &H40, 0, 0, 0, 0
End Sub

'Rechte Maustaste simulieren
Public Sub MouseRightClick()
   mouse_event &H8, 0, 0, 0, 0
   mouse_event &H10, 0, 0, 0, 0
End Sub

'Maus nach x,y bewegen
Public Sub MouseMove(x As Long, y As Long)
   SetCursorPos x, y
End Sub

