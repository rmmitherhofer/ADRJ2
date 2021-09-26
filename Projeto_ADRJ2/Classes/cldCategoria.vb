Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldCategoria

    Private catCodCateg As Integer
    Private catDescricao As String
    Public Property cat_Cod_categoria() As Integer
        Get
            Return catCodCateg
        End Get
        Set(ByVal value As Integer)
            catCodCateg = value
        End Set
    End Property

    Public Property cat_Descricao() As String
        Get
            Return catDescricao
        End Get
        Set(ByVal value As String)
            catDescricao = value
        End Set
    End Property

    Public Sub CadastraCateg()

    End Sub

    Public Function ListaCategoriaGeral(ByVal catCodCateg As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select * from categoria where cat_Cod_categoria like '" & catCodCateg & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function ListaCategoriaDESCRICAO(ByVal catDescricao As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select Categoria.cat_Descricao, Produto.pro_Cod_categoria from produto inner join categoria on produto.pro_cod_categoria = categoria.cat_cod_categoria where cat_descricao = '" & catDescricao & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CategoriaCod(ByVal catDescricao As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select cat_cod_categoria from categoria where cat_descricao ='" & catDescricao & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CategoriaDescricao(ByVal catCodCateg As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select cat_descricao from categoria where cat_cod_categoria ='" & catCodCateg & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function


End Class
