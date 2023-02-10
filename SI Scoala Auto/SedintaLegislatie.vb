Public Class SedintaLegislatie : Inherits SedintaAuto
    Private _CodLeg As String

    Public Instructor As Instructor
    Public SalaSedinta As SalaSedinte


    Property CodLeg As String
        Get
            Return _CodLeg
        End Get
        Set(value As String)
            If value <> "" Then
                _CodLeg = value
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
    Public Function TotalCursanti(CodL As String) As Double
    End Function
End Class
