' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDocument

	Private Sub rtfText_SelChange() Handles rtfText.SelChange
		fMainForm.tbToolBar.Buttons("Bold").Value = IIf(rtfText.SelBold, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		fMainForm.tbToolBar.Buttons("Italic").Value = IIf(rtfText.SelItalic, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		fMainForm.tbToolBar.Buttons("Underline").Value = IIf(rtfText.SelUnderline, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		fMainForm.tbToolBar.Buttons("Align Left").Value = IIf(rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfLeft, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		fMainForm.tbToolBar.Buttons("Center").Value = IIf(rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfCenter, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
		fMainForm.tbToolBar.Buttons("Align Right").Value = IIf(rtfText.SelAlignment = RichTextLib.SelAlignmentConstants.rtfRight, MSComctlLib.ValueConstants.tbrPressed, MSComctlLib.ValueConstants.tbrUnpressed)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Form_Resize()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		rtfText.Move(100, 100, Me.ScaleWidth - 200, Me.ScaleHeight - 200)
		rtfText.RightMargin = rtfText.Width - 400
	End Sub

End Class
