Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldProduto

    Private pCodProduto As Integer
    Private pProduto As String
    Private pCodCategoria As Integer
    Private pCodBarras As String
    Private pFornecedor As Integer
    Private pValor As String
    Private pPrecoCusto As String
    Private pQuant As String
    Public Property pro_Cod_Produto() As Integer
        Get
            Return pCodProduto
        End Get
        Set(ByVal value As Integer)
            pCodProduto = value
        End Set
    End Property

    Public Property pro_Nome_produto() As String
        Get
            Return pProduto
        End Get
        Set(ByVal value As String)
            pProduto = value
        End Set
    End Property

    Public Property pro_Cod_Categoria() As Integer
        Get
            Return pCodCategoria
        End Get
        Set(ByVal value As Integer)
            pCodCategoria = value
        End Set
    End Property

    Public Property pro_Cod_Barras() As String
        Get
            Return pCodBarras
        End Get
        Set(ByVal value As String)
            pCodBarras = value
        End Set
    End Property

    Public Property pro_Fornecedor() As Integer
        Get
            Return pFornecedor
        End Get
        Set(ByVal value As Integer)
            pFornecedor = value
        End Set
    End Property

    Public Property pro_Valor() As String
        Get
            Return pValor
        End Get
        Set(ByVal value As String)
            pValor = value
        End Set
    End Property

    Public Property pro_Preco_custo() As String
        Get
            Return pPrecoCusto
        End Get
        Set(ByVal value As String)
            pPrecoCusto = value
        End Set
    End Property

    Public Property pro_Quantidade() As String
        Get
            Return pQuant
        End Get
        Set(ByVal value As String)
            pQuant = value
        End Set
    End Property

    Public Sub InserirProdut()
        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO PRODUTO ")
        strQuery.Append(" ( ")
        strQuery.Append(" pro_Nome_produto ")
        strQuery.Append(", pro_Cod_Categoria ")
        strQuery.Append(", pro_Cod_Barras ")
        strQuery.Append(", pro_Fornecedor ")
        strQuery.Append(", pro_Preco_custo ")
        strQuery.Append(", pro_Valor  ")
        strQuery.Append(", pro_Quantidade ")
        strQuery.Append(" ) ")

        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & pProduto & "' ")
        strQuery.Append(", " & pCodCategoria & " ")
        strQuery.Append(", '" & pCodBarras & "' ")
        strQuery.Append(", " & pFornecedor & " ")
        strQuery.Append(", '" & pPrecoCusto & "' ")
        strQuery.Append(", '" & pValor & "' ")
        strQuery.Append(", '" & pQuant & "' ")
        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub AlterarProdut()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE PRODUTO")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Nome_produto = '" & pProduto & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Cod_Categoria = '" & pCodCategoria & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Cod_Barras = '" & pCodBarras & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Fornecedor = '" & pFornecedor & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Preco_custo = '" & pPrecoCusto & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Valor = '" & pValor & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        strQuery.Append(" UPDATE PRODUTO ")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Quantidade = '" & pQuant & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

       

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub ExcluiProdut(ByVal pCodProduto As Integer)
        'Cria um StringBuilder concatenar a query SQL
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM PRODUTO ")
        'strQuery.Append(" WHERE nome= '" & Trim(Nome) & "'") '===Excluir Pelo Nome (Trim retira os espaços)
        strQuery.Append(" WHERE pro_Cod_Produto = '" & pCodProduto & "'") 'Excluir Pelo Cod
        ' Método ExecutaComando da classe de BD
        Dim cldBandoDados As New cldBancoDados()
        cldBandoDados.ExecutaComando(strQuery.ToString) 'Repassa a Query de exclusão para ser executado

    End Sub

    Public Function CarregaCodProduto(ByVal pProduto As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select * from PRODUTO where pro_Nome_produto  ='" & pProduto & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCodProduto2(ByVal pCodProduto As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select * from PRODUTO where pro_Cod_produto  ='" & pCodProduto & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function Procuraprodut(ByVal strDescricao As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor ")
        strQuery.Append(" WHERE pro_Nome_produto like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY pro_Nome_produto ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function ProcuraprodutCod(ByVal strDescricao As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor ")
        strQuery.Append(" WHERE pro_Cod_Produto like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY pro_Cod_Produto ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function Procuraprodutforn(ByVal pFornecedor As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor ")
        strQuery.Append(" WHERE FORNECEDOR.forn_Nome = '" & pFornecedor & "'")
        strQuery.Append(" ORDER BY forn_Nome ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function Procuraprodutvalor(ByVal strDescricao As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor ")
        strQuery.Append(" WHERE pro_Valor like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY pro_Valor ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function Procuraprodutcateg(ByVal strDescricao As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT dbo.PRODUTO.pro_Cod_Produto, dbo.PRODUTO.pro_Nome_produto, CATEGORIA.cat_Descricao, FORNECEDOR.forn_Nome, PRODUTO.pro_Valor, PRODUTO.pro_quantidade FROM dbo.PRODUTO inner join  CATEGORIA on PRODUTO.pro_Cod_Categoria = CATEGORIA.cat_Cod_categoria inner join  FORNECEDOR on PRODUTO.pro_Fornecedor = FORNECEDOR.forn_Cod_fornecedor ")
        strQuery.Append(" WHERE categoria.cat_Descricao like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY cat_Descricao ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function ConsulCodProdut(ByVal pro_Cod_Produto As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from Produto where pro_Cod_produto like '" & pro_Cod_Produto & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Sub AlterQuantPro()

        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE PRODUTO")
        strQuery.Append(" SET ")
        strQuery.Append(" pro_Quantidade = '" & pQuant & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" pro_Cod_Produto = '" & pCodProduto & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function ListarQuant(ByVal pCodProduto As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = " select pro_quantidade from produto where pro_cod_produto = '" & pCodProduto & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

End Class
