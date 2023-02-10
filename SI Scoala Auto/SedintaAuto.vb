Public Class SedintaAuto
    Private _Cod As String
    Public Data As Date
    Private _Durata As Integer

    Property Cod As String
        Get
            Return _Cod
        End Get
        Set(value As String)
            If value <> "" Then
                _Cod = value
            Else
                Throw New Exception("Introduceti codul sedintei!")
            End If
        End Set
    End Property
    Property Durata As Integer
        Get
            Return _Durata
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Durata = value
            Else
                Throw New Exception("Durata sedintei trebuie sa fie mai mare decat 0!")
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
