Public Class DocumentPlata
    Private _Numar As Integer
    Public Data As Date
    Public Explicatii As String

    Public Cursant As Cursant

    Property Numar As Integer
        Get
            Return _Numar
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Numar = value
            Else
                Throw New Exception("Numarul documentului trebuie sa fie pozitiv!")
            End If
        End Set
    End Property
    Sub Adauga()
    End Sub
    Sub Salvare()
    End Sub
    Sub Incarca()
    End Sub
    Sub Sterge()
    End Sub
    Public Function TotalPlatit(CodC As String) As Double
    End Function
End Class
