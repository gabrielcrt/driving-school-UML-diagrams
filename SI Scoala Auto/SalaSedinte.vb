Public Class SalaSedinte
    Private _CodSala As String
    Private _Locatie As String
    Public NrLocuri As Integer

    Property CodSala As String
        Get
            Return _CodSala
        End Get
        Set(value As String)
            If value <> "" Then
                _CodSala = value
            Else
                Throw New Exception("Introduceti codul salii!")
            End If
        End Set
    End Property
    Property Locatie As String
        Get
            Return _Locatie
        End Get
        Set(value As String)
            If value <> "" Then
                _Locatie = value
            Else
                Throw New Exception("Introduceti locatia salii!")
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
