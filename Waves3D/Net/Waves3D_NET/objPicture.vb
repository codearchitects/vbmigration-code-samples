' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class objPicture

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	Public objects As New Collection
	
	' Draw the picture on the PictureBox.
	
	Public Sub Draw(ByVal canvas As Object, Optional ByVal r As Object = VB6Missing)
		Dim obj As Object = Nothing
		
		For Each obj In objects
			obj.Draw(canvas, r)
		Next
	End Sub

	'' Apply a transformation matrix which may not
	'' contain 0, 0, 0, 1 in the last column to the
	'' objects.
	Public Sub ApplyFull(ByVal M(,) As Single)
		Dim obj As Object = Nothing
		
		For Each obj In objects
			obj.ApplyFull(M)
		Next
	End Sub
	
	'' Apply a transformation matrix to the objects.
	Public Sub Apply(ByVal M() As Single)
	' UPGRADE_INFO (#0501): The 'Apply' member isn't used anywhere in current application.
		Dim obj As Object = Nothing
		
		For Each obj In objects
			obj.Apply(M)
		Next
	End Sub

End Class
