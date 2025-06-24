Imports System.Text.RegularExpressions

Public Class ClienteValidator
    Public Function Validar(cliente As Cliente) As List(Of String)
        Dim erros As New List(Of String)()

        If String.IsNullOrWhiteSpace(cliente.Nome) Then
            erros.Add("O nome � obrigat�rio.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Email) Then
            erros.Add("O e-mail � obrigat�rio.")
        ElseIf Not Regex.IsMatch(cliente.Email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            erros.Add("O e-mail informado � inv�lido.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Telefone) Then
            erros.Add("O telefone � obrigat�rio.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Endereco) Then
            erros.Add("O endere�o � obrigat�rio.")
        End If

        Return erros
    End Function
End Class
