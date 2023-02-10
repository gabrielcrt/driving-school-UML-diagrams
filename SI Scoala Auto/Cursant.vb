Public Class Cursant : Inherits Persoana
    Private _CodCursant As String

    Property CodCursant As String
        Get
            Return _CodCursant
        End Get
        Set(value As String)
            If value <> "" Then
                _CodCursant = value
            Else
                Throw New Exception("Introduceti codul cursantului!")
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
    Public Function EligibilExamen(CodC As String) As Boolean
    End Function
End Class
