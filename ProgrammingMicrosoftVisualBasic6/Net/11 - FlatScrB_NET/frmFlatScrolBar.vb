' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmFlatScrolBar

	Private Sub FlatScrollBar1_Change() Handles FlatScrollBar1.Change
		' Selectively disable one arrow, if necessary.
		If FlatScrollBar1.Value = FlatScrollBar1.Min Then 
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar1.Arrows = MSComCtl2.ArrowsConstants.cc2RightDown
		ElseIf FlatScrollBar1.Value = FlatScrollBar1.Max Then 
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar1.Arrows = MSComCtl2.ArrowsConstants.cc2LeftUp
		Else
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar1.Arrows = MSComCtl2.ArrowsConstants.cc2Both
		End If
		
		Debug.WriteLine("Change Hor = " & FlatScrollBar1.Value)
	End Sub

	Private Sub FlatScrollBar1_Scroll() Handles FlatScrollBar1.Scroll
		Debug.WriteLine("Scroll Hor = " & FlatScrollBar1.Value)
	End Sub

	Private Sub FlatScrollBar2_Change() Handles FlatScrollBar2.Change
		' Selectively disable one arrow, if necessary.
		If FlatScrollBar2.Value = FlatScrollBar2.Min Then 
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar2.Arrows = MSComCtl2.ArrowsConstants.cc2RightDown
		ElseIf FlatScrollBar2.Value = FlatScrollBar2.Max Then 
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar2.Arrows = MSComCtl2.ArrowsConstants.cc2LeftUp
		Else
			' UPGRADE_ISSUE (#1878): The Arrows property isn't supported. It always returns 0-cc2Both. Assigning a non-zero value throws an exception.
			FlatScrollBar2.Arrows = MSComCtl2.ArrowsConstants.cc2Both
		End If
		Debug.WriteLine("Change Ver = " & FlatScrollBar2.Value)
	End Sub

	Private Sub FlatScrollBar2_Scroll() Handles FlatScrollBar2.Scroll
		Debug.WriteLine("Scroll Ver = " & FlatScrollBar2.Value)
	End Sub

End Class
