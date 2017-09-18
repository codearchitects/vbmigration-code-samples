' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frm_PrintPreview

	Private Sub btn_Close_Click() Handles btn_Close.Click
		Unload6(Me)
	End Sub

	Private Sub btn_Page_Click() Handles btn_Page.Click
		PopupMenu(ppm_Page, , Me.btn_Page.Left, Me.btn_Page.Top + Me.btn_Page.Height)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		With Me
			.pic_Viewport.Width = .ScaleWidth - .vsc_Scroll.Width - 15
			.pic_Viewport.Height = .ScaleHeight - .hsc_Scroll.Height - 15
			
			.pic_Preview.Left = (.pic_Viewport.ScaleWidth / 2) - (.pic_Preview.Width / 2)
			.pic_Shadow.Left = .pic_Preview.Left + 60
			
			.vsc_Scroll.Left = .ScaleWidth - .vsc_Scroll.Width
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.tbr_Preview.Height'. Consider using the GetDefaultMember6 helper method.
			.vsc_Scroll.Height = .ScaleHeight - .hsc_Scroll.Height - .tbr_Preview.Height
			.vsc_Scroll.Min = 120
			.vsc_Scroll.Max = .ScaleHeight - .hsc_Scroll.Height - .pic_Preview.Height - 240
			If .vsc_Scroll.Max < 0 Then 
				.vsc_Scroll.Visible = True
			Else
				.vsc_Scroll.Visible = False
			End If
			
			.hsc_Scroll.Top = .ScaleHeight - .hsc_Scroll.Height
			.hsc_Scroll.Width = .ScaleWidth - .vsc_Scroll.Width
			.hsc_Scroll.Max = .ScaleWidth - .vsc_Scroll.Width - .pic_Preview.Width
			If .hsc_Scroll.Max < 0 Then 
				.hsc_Scroll.Visible = True
			Else
				.hsc_Scroll.Visible = False
			End If
		End With
	End Sub

	Private Sub hsc_Scroll_Change() Handles hsc_Scroll.Change
		Me.pic_Preview.Left = Me.hsc_Scroll.Value
		Me.pic_Shadow.Left = Me.pic_Preview.Left + 60
	End Sub

	Private Sub hsc_Scroll_Scroll() Handles hsc_Scroll.Scroll
		Me.pic_Preview.Left = Me.hsc_Scroll.Value
		Me.pic_Shadow.Left = Me.pic_Preview.Left + 60
	End Sub

	Private Sub ppi_PageNo_Click(ByRef Index As Short)
		Call MakePrintPreview(Index)
	End Sub

	Private Sub tbr_Preview_ButtonClick(ByVal Button As Object)
		Dim v_iLoop As Short
		
		On Error GoTo Err 
		
		Select Case Button.Index
		Case 1
			With Me.pic_Preview
				For v_iLoop = 1 To pPrintPageCount
					Call MakePrintPreview(v_iLoop)
					Printer6.PaintPicture(.Image, 0, 0, Me.pic_Preview.Width, Me.pic_Preview.Height)
					Printer6.EndDoc()
				Next
			End With
		End Select
		Exit Sub
		
Err:
		MsgBox6(Err.Description, MsgBoxStyle.Critical)
	End Sub

	Private Sub vsc_Scroll_Change() Handles vsc_Scroll.Change
		Me.pic_Preview.Top = Me.vsc_Scroll.Value
		Me.pic_Shadow.Top = Me.pic_Preview.Top + 60
	End Sub

	Private Sub vsc_Scroll_Scroll() Handles vsc_Scroll.Scroll
		Me.pic_Preview.Top = Me.vsc_Scroll.Value
		Me.pic_Shadow.Top = Me.pic_Preview.Top + 60
	End Sub

End Class
