Imports System.Diagnostics
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices

Friend Module VisualBasic6_Support

#Region "Initialization"

   ' Constants for the App6 object
   Public Const APP6_HELPFILE As String = ""
   Public Const APP6_HELPCONTEXTID As Integer = 0
   Public Const APP6_UNATTENDEDAPP As Boolean = False

   ' Initialize the VB6 support library
   Public Sub EnsureVB6LibraryInitialization()
      CodeArchitects.VB6Library.InitializeVB6Library(Assembly.GetExecutingAssembly(), Process.GetCurrentProcess(), Application.OpenForms, My.Application.Info, APP6_HELPFILE, APP6_HELPCONTEXTID, APP6_UNATTENDEDAPP)
   End Sub

#End Region

#Region "Resources support"

   ' support for reading resources

   Dim resourceMan As ResourceManager = New Global.System.Resources.ResourceManager(GetType(VisualBasic6_Support).Namespace & ".Resources", GetType(VisualBasic6_Support).Assembly)

   Public Function LoadResString6(ByVal id As Object) As String
      Return DirectCast(GetResourceFromID("str", id), String)
   End Function

   Public Function LoadResPicture6(ByVal id As Object, ByVal resType As Integer) As Object
      Dim prefix As String = Microsoft.VisualBasic.Choose(resType + 1, "bmp", "ico", "cur")
      Return GetResourceFromID(prefix, id)
   End Function

   Public Function LoadResData6(ByVal id As Object, ByVal resType As Object) As Object
      Dim prefix As String = "?"
      If TypeOf resType Is String Then
         prefix = resType.ToString() & "_"
      ElseIf IsNumeric(resType.ToString()) Then
         prefix = Microsoft.VisualBasic.Choose(CInt(resType), "cur", "bmp", "ico", "?", "?", "str")
      End If
      Return GetResourceFromID(prefix, id)
   End Function

   ' extract a resource, throw if not found

   Private Function GetResourceFromID(ByVal prefix As String, ByVal id As Object) As Object
      ' ensure ID doesn't contain invalid chars
      Dim strId As String = System.Text.RegularExpressions.Regex.Replace(id.ToString(), "[^A-Za-z0-9_.]", "_")
      Dim res As Object = resourceMan.GetObject(prefix & strId, Nothing)

      If res IsNot Nothing Then
         Select Case prefix
            Case "str" : If Not TypeOf res Is String Then res = Nothing
            Case "bmp" : If Not TypeOf res Is Image Then res = Nothing
            Case "ico" : If Not TypeOf res Is Image AndAlso Not TypeOf res Is Icon Then res = Nothing
            Case "cur" : If Not TypeOf res Is Cursor Then res = Nothing
         End Select
      Else
         ' Try again with all-uppercase ID
         res = resourceMan.GetObject(prefix.ToUpper() & strId, Nothing)
      End If
      ' Check whether the resource is missing or is of the wrong type
      If res Is Nothing Then Err.Raise(326, , "Resource with identifier '" & strId & "' not found")
      Return res
   End Function

#End Region

End Module

