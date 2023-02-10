Public Class PlataSedintaLegislatie
    Private _Suma As Double

    Public DocumentPlata As DocumentPlata
    Public SedintaLegislatie As SedintaLegislatie

    Property Suma As Double
        Get
            Return _Suma
        End Get
        Set(value As Double)
            If value > 0 Then
                _Suma = value
            Else
                Throw New Exception("Suma trebuie sa fie mai mare decat 0 !")
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
End Class
