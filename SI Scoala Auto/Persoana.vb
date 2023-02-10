Public Class Persoana
    Private _CNP As String
    Private _Nume As String
    Private _Prenume As String
    Public Localitate As String
    Public Adresa As String
    Public Telefon As String
    Public Email As String

    Property CNP As String
        Get
            Return _CNP
        End Get
        Set(value As String)
            If Len(value) = 13 Then
                _CNP = value
            Else
                Throw New Exception("CNP-ul trebuie sa fie format din 13 caractere!")
            End If
        End Set
    End Property
    Property Nume As String
        Get
            Return _Nume
        End Get
        Set(value As String)
            If value <> "" Then
                _Nume = value
            Else
                Throw New Exception("Introduceti numele persoanei!")
            End If
        End Set
    End Property
    Property Prenume As String
        Get
            Return _Prenume
        End Get
        Set(value As String)
            If value <> "" Then
                _Prenume = value
            Else
                Throw New Exception("Introduceti prenumele persoanei!")
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
