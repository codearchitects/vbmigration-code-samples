Attribute VB_Name = "VBMigrationPartner_PartialSupportMethods"
'## ExcludeCurrentFile
' -----------------------------------------------------------------------------
'  This is a reduced version of the VBMigrationStudio_SupportMethods.bas module
' -----------------------------------------------------------------------------

'-------------------------------------------------------------------------
' color support
'-------------------------------------------------------------------------

' Use this function to wrap assignments of a 32-bit integer to a color property
' when the color property is accessed in late-bound mode or the source value is stored in a Variant variable
'        EXAMPLE:    variantVar.ForeColor = FromOleColor6( intColorValue )

Public Function FromOleColor6(ByVal color As Long) As Long
    FromOleColor6 = color
End Function

' Use this function to wrap assignments of a color property to a 32-bit integer to a color property
' when the color property is accessed in late-bound mode or the target variable is of Variant type
'        EXAMPLE:   intVar = ToOleColor( objectVar.ForeColor )

Public Function ToOleColor6(ByVal color As Long) As Long
    ToOleColor6 = color
End Function
