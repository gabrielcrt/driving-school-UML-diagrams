Public Class Autoturism
    Private _NrInmatriculare As String
    Private _Marca As String
    Public Model As String
    Public AnFabricatie As Integer

    Public Instructor As Instructor

    Property NrInmatriculare As String
        Get
            Return _NrInmatriculare
        End Get
        Set(value As String)
            If value <> "" Then
                _NrInmatriculare = value
            Else
                Throw New Exception("Introduceti numarul de inmatriculare!")
            End If
        End Set
    End Property
    Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            If value <> "" Then
                _Marca = value
            Else
                Throw New Exception("Introduceti marca autoturismului!")
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
