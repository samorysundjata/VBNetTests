Public Class ProdutoValidator

    Public Function Validar(produto As Produto) As List(Of String)
        Dim erros As New List(Of String)()

        If String.IsNullOrWhiteSpace(produto.Nome) Then
            erros.Add("O nome do produto � obrigat�rio.")
        End If

        If produto.Preco < 0 Then
            erros.Add("O pre�o do produto n�o pode ser negativo.")
        End If

        If produto.QuantidadeEmEstoque < 0 Then
            erros.Add("A quantidade em estoque n�o pode ser negativa.")
        End If

        If String.IsNullOrWhiteSpace(produto.Categoria) Then
            erros.Add("A categoria do produto � obrigat�ria.")
        End If

        Return erros
    End Function

End Class
