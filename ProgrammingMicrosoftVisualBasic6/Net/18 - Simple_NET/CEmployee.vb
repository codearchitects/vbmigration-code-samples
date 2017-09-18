' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CEmployee
	Implements IVB6BoundControl
	Implements IVB6SimpleBoundClass

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region

	Private m_FirstName As String = ""
	Private m_LastName As String = ""
	Private m_BirthDate As Date

	' Variables for data consumer support
	Private bndcol As New VB6BindingCollection

	' The FirstName property

	<System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)> _
	Public Property FirstName() As String
		Get
			Return m_FirstName
	 	End Get
		Set(ByVal newValue As String)
			If CanPropertyChange("FirstName") Then 
				m_FirstName = newValue
				PropertyChanged("FirstName")
			End If
	 	End Set
	End Property

	' The LastName property

	<System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)> _
	Public Property LastName() As String
		Get
			Return m_LastName
	 	End Get
		Set(ByVal newValue As String)
			If CanPropertyChange("LastName") Then 
				m_LastName = newValue
				PropertyChanged("LastName")
			End If
	 	End Set
	End Property

	' The BirthDate property

	Public Property BirthDate() As Date
		Get
			Return m_BirthDate
	 	End Get
		Set(ByVal newValue As Date)
			If CanPropertyChange("BirthDate") Then 
				m_BirthDate = newValue
				PropertyChanged("BirthDate")
			End If
	 	End Set
	End Property

	' The CompleteName property (read only)
	
	Public ReadOnly Property CompleteName() As String
		Get
			Return FirstName & " " & LastName
	 	End Get
	End Property

	' The Age property (read only)
	
	Public ReadOnly Property Age() As Short
		Get
			Return Year(Now) - Year(BirthDate)
	 	End Get
	End Property

	' The DataSource property

	''' <summary>
	''' The DataSource property
	''' </summary>
	Public Property DataSource() As Object
		Get
			Return bndcol.DataSource
	 	End Get
		Set(ByVal newValue As Object)
			bndcol = New VB6BindingCollection()
			bndcol.DataSource = newValue
			bndcol.UpdateMode = MSBind.UpdateMode.vbUsePropertyAttributes
			
			bndcol.Add(Me, "FirstName", "FirstName", , "FirstName")
			bndcol.Add(Me, "LastName", "LastName", , "LastName")
			bndcol.Add(Me, "BirthDate", "BirthDate", , "LastName")
	 	End Set
	End Property

	Private Sub Class_Initialize_VB6()
		
	End Sub

	#Region "IVB6SimpleBoundClass members"
	
	Public Event BoundPropertyChanged As BoundPropertyChangedEventHandler Implements IVB6SimpleBoundClass.BoundPropertyChanged
	
	Protected Overridable Function CanPropertyChange(ByVal propertyName As String) As Boolean Implements IVB6SimpleBoundClass.CanPropertyChange
		' Changing a bound property is always allowed
		Return True
	End Function
	
	Protected Overridable Sub PropertyChanged(Byval propertyName As String) Implements IVB6SimpleBoundClass.PropertyChanged
		RaiseEvent BoundPropertyChanged(Me, New BoundPropertyChangedEventArgs(propertyName))
	End Sub
	
	#End Region
	
	#Region "IVB6BoundControl members"
	
	Private Property BoundValue_() As Object Implements CodeArchitects.VB6Library.IVB6BoundControl.BoundValue
	   Get
			Return VB6Utils.BoundPropertyToValue(Me.FirstName, GetType(String))
	   End Get
	   Set(ByVal value As Object)
			Me.FirstName = VB6Utils.ValueToBoundProperty(Of String)(value)
	   End Set
	End Property
	
	' The DataChanged property
	
	Private vb6_DataChanged As Boolean = False
	
	<System.ComponentModel.Category("Data")> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	<System.ComponentModel.Browsable(False)> _
	Public Property DataChanged() As Boolean Implements IVB6BoundControl.DataChanged
	   Get
	      Return vb6_DataChanged
	   End Get
	   Set(ByVal Value As Boolean)
	      vb6_DataChanged = Value
	   End Set
	End Property
	
	' The DataField property
	
	Private vb6_DataField As String = ""
	
	<System.ComponentModel.Category("Data")> _
	<System.ComponentModel.DefaultValue("")> _
	Public Property DataField() As String Implements IVB6BoundControl.DataField
	   Get
	      Return vb6_DataField
	   End Get
	   Set(ByVal Value As String)
	      If Value Is Nothing Then Value = ""
	      vb6_DataField = Value
	   End Set
	End Property
	
	' The DataFormat property
	
	Private vb6_DataFormat As VB6StdDataFormat
	
	<System.ComponentModel.Category("Data")> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	<System.ComponentModel.Browsable(False)> _
	Public Property DataFormat() As VB6StdDataFormat Implements IVB6BoundControl.DataFormat
	   Get
	      If vb6_DataFormat Is Nothing Then vb6_DataFormat = New VB6StdDataFormat()
	      Return vb6_DataFormat
	   End Get
	   Set(ByVal Value As VB6StdDataFormat)
	      vb6_DataFormat = Value
	   End Set
	End Property
	
	' The DataMember property
	
	Private vb6_DataMember As String = ""
	
	<System.ComponentModel.Category("Data")> _
	<System.ComponentModel.DefaultValue("")> _
	Public Shadows Property DataMember() As String Implements IVB6BoundControl.DataMember
	   Get
	      Return vb6_DataMember
	   End Get
	   Set(ByVal Value As String)
	      If Value Is Nothing Then Value = ""
	      vb6_DataMember = Value
	      If Not VB6Utils.IsDesignMode Then 
	         Me.DataBindings.DataMember = Value
	         VB6Utils.SetRealDataSource(Me, vb6_RealDataSource, DataSource, DataMember)
	      End If
	   End Set
	End Property
	
	' The DataSource property
	
	Private vb6_DataSource As Object = Nothing
	
	<System.ComponentModel.Category("Data")> _
	<System.ComponentModel.DefaultValue(GetType(Object), Nothing)> _
	<System.ComponentModel.Editor(GetType(DataSourceEditor), GetType(System.Drawing.Design.UITypeEditor))> _
	<System.ComponentModel.TypeConverter(GetType(DataSourceConverter))> _
	Public Shadows Property DataSource_() As Object Implements IVB6BoundControl.DataSource
	   Get
	      Return vb6_DataSource
	   End Get
	   Set(ByVal Value As Object)
	      vb6_DataSource = Value
	      If Not VB6Utils.IsDesignMode Then 
	         Me.DataBindings.DataSource = Value
	         VB6Utils.SetRealDataSource(Me, vb6_RealDataSource, DataSource, DataMember)
	      End If
	   End Set
	End Property
	
	' the RealDataSource property is private
	
	Private vb6_RealDataSource As IVB6DataSource = Nothing
	
	Private Property RealDataSource_() As IVB6DataSource Implements IVB6BoundControl.RealDataSource
	   Get
	      Return vb6_RealDataSource
	   End Get
	   Set(ByVal Value As IVB6DataSource)
	      vb6_RealDataSource = Value
	   End Set
	End Property
	
	' the Bindings property
	
	Dim vb6_Bindings As New VB6BindingCollection()
	
	<System.ComponentModel.Browsable(False)> _
	<System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
	Public Shadows ReadOnly Property DataBindings() As VB6BindingCollection 
	   Get
	      Return vb6_Bindings
	   End Get
	End Property

	#End Region    
End Class
