Attribute VB_Name = "Module2"
Option Explicit

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' THIS ROUTINE HAS BEEN TAKEN BY MSDN Knowledge Base, Article Q146022
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Private Type Rect
   Left As Long
   Top As Long
   Right As Long
   Bottom As Long
End Type

Private Type CharRange
  cpMin As Long     ' First character of range (0 for start of doc)
  cpMax As Long     ' Last character of range (-1 for end of doc)
End Type

Private Type FormatRange
  hdc As Long       ' Actual DC to draw on
  hdcTarget As Long ' Target DC for determining text formatting
  rc As Rect        ' Region of the DC to draw to (in twips)
  rcPage As Rect    ' Region of the entire DC (page size) (in twips)
  chrg As CharRange ' Range of text to draw (see above declaration)
End Type

Private Const WM_USER As Long = &H400
Private Const EM_FORMATRANGE As Long = WM_USER + 57
Private Const EM_SETTARGETDEVICE As Long = WM_USER + 72
Private Const PHYSICALOFFSETX As Long = 112
Private Const PHYSICALOFFSETY As Long = 113

Private Declare Function GetDeviceCaps Lib "gdi32" ( _
   ByVal hdc As Long, ByVal nIndex As Long) As Long
Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" _
   (ByVal hWnd As Long, ByVal msg As Long, ByVal wp As Long, _
   lp As Any) As Long
Private Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" _
   (ByVal lpDriverName As String, ByVal lpDeviceName As String, _
   ByVal lpOutput As Long, ByVal lpInitData As Long) As Long


''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' PrintRTF - Prints the contents of a RichTextBox control using the
'            provided margins
'
' RTF - A RichTextBox control to print
'
' LeftMarginWidth - Width of desired left margin in twips
'
' TopMarginHeight - Height of desired top margin in twips
'
' RightMarginWidth - Width of desired right margin in twips
'
' BottomMarginHeight - Height of desired bottom margin in twips
'
' Notes - If you are also using WYSIWYG_RTF() on the provided RTF
'         parameter you should specify the same LeftMarginWidth and
'         RightMarginWidth that you used to call WYSIWYG_RTF()
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Sub PrintRTF(RTF As RichTextBox, LeftMarginWidth As Long, _
   TopMarginHeight, RightMarginWidth, BottomMarginHeight)
   Dim LeftOffset As Long, TopOffset As Long
   Dim LeftMargin As Long, TopMargin As Long
   Dim RightMargin As Long, BottomMargin As Long
   Dim fr As FormatRange
   Dim rcDrawTo As Rect
   Dim rcPage As Rect
   Dim TextLength As Long
   Dim NextCharPosition As Long
   Dim r As Long

   ' Start a print job to get a valid Printer.hDC
   Printer.Print Space(1)
   Printer.ScaleMode = vbTwips

   ' Get the offsett to the printable area on the page in twips
   LeftOffset = Printer.ScaleX(GetDeviceCaps(Printer.hdc, _
      PHYSICALOFFSETX), vbPixels, vbTwips)
   TopOffset = Printer.ScaleY(GetDeviceCaps(Printer.hdc, _
      PHYSICALOFFSETY), vbPixels, vbTwips)

   ' Calculate the Left, Top, Right, and Bottom margins
   LeftMargin = LeftMarginWidth - LeftOffset
   TopMargin = TopMarginHeight - TopOffset
   RightMargin = (Printer.Width - RightMarginWidth) - LeftOffset
   BottomMargin = (Printer.Height - BottomMarginHeight) - TopOffset

   ' Set printable area rect
   rcPage.Left = 0
   rcPage.Top = 0
   rcPage.Right = Printer.ScaleWidth
   rcPage.Bottom = Printer.ScaleHeight

   ' Set rect in which to print (relative to printable area)
   rcDrawTo.Left = LeftMargin
   rcDrawTo.Top = TopMargin
   rcDrawTo.Right = RightMargin
   rcDrawTo.Bottom = BottomMargin

   ' Set up the print instructions
   fr.hdc = Printer.hdc   ' Use the same DC for measuring and rendering
   fr.hdcTarget = Printer.hdc  ' Point at printer hDC
   fr.rc = rcDrawTo            ' Indicate the area on page to draw to
   fr.rcPage = rcPage          ' Indicate entire size of page
   fr.chrg.cpMin = 0           ' Indicate start of text through
   fr.chrg.cpMax = -1          ' end of the text

   ' Get length of text in RTF
   TextLength = Len(RTF.Text)

   ' Loop printing each page until done
   Do
      ' Print the page by sending EM_FORMATRANGE message
      NextCharPosition = SendMessage(RTF.hWnd, EM_FORMATRANGE, True, fr)
      If NextCharPosition >= TextLength Then Exit Do  'If done then exit
      fr.chrg.cpMin = NextCharPosition ' Starting position for next page
      Printer.NewPage                  ' Move on to next page
   Loop

   ' Commit the print job
   Printer.EndDoc

   ' Allow the RTF to free up memory
   r = SendMessage(RTF.hWnd, EM_FORMATRANGE, False, ByVal CLng(0))
End Sub




