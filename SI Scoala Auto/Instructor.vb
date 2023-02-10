Public Class Instructor : Inherits Persoana
    Private _CodInstr As String

    Property CodInstr As String
        Get
            Return _CodInstr
        End Get
        Set(value As String)
            If value <> "" Then
                _CodInstr = value
            Else
                Throw New Exception("Introduceti codul instructorului!")
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
