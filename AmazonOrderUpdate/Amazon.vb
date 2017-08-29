Imports System.Runtime.CompilerServices

Namespace UtilityLibraries
    Public Module Amazon
        <Extension>
        Public Function StartsWithUpper(str As String) As Boolean
            If String.IsNullOrWhiteSpace(str) Then
                Return False
            End If

            Dim ch As Char = str(1)
            Return Char.IsUpper(ch)
        End Function
    End Module
End Namespace