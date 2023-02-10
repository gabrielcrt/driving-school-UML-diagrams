Public Class SedintaPractica : Inherits SedintaAuto
    Private _CodPrc As String

    Public Autoturism As Autoturism

    Property CodPrc As String
        Get
            Return _CodPrc
        End Get
        Set(value As String)
            If value <> "" Then
                _CodPrc = value
            Else
                Throw New Exception("Introduceti codul sedintei!")
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
