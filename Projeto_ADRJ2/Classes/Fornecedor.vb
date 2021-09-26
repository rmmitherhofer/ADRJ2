Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldFornecedor

    Private fornCEP As String
    Private fornCNPJ As String
    Private fornCodFornecedor As Integer
    Private fornComplemento As String
    Private fornDataCadastro As String
    Private fornDDD As String
    Private fornNome As String
    Private fornNumero As String
    Private fornTelefone As String
    Private fornEmail As String
    Private fornSite As String
    Private fornNomeFantas As String
    Private fornInscricaoEstMun As String
    Public Property forn_Cod_fornecedor() As Integer
        Get
            Return fornCodFornecedor
        End Get
        Set(ByVal value As Integer)
            fornCodFornecedor = value
        End Set
    End Property

    Public Property forn_Nome() As String
        Get
            Return fornNome
        End Get
        Set(ByVal value As String)
            fornNome = value
        End Set
    End Property

    Public Property forn_CNPJ() As String
        Get
            Return fornCNPJ
        End Get
        Set(ByVal value As String)
            fornCNPJ = value
        End Set
    End Property

    Public Property forn_CEP() As String
        Get
            Return fornCEP
        End Get
        Set(ByVal value As String)
            fornCEP = value
        End Set
    End Property

    Public Property forn_Numero() As String
        Get
            Return fornNumero
        End Get
        Set(ByVal value As String)
            fornNumero = value
        End Set
    End Property

    Public Property forn_Complemento() As String
        Get
            Return fornComplemento
        End Get
        Set(ByVal value As String)
            fornComplemento = value
        End Set
    End Property

    Public Property forn_DDD() As String
        Get
            Return fornDDD
        End Get
        Set(ByVal value As String)
            fornDDD = value
        End Set
    End Property

    Public Property forn_Telefone() As String
        Get
            Return fornTelefone
        End Get
        Set(ByVal value As String)
            fornTelefone = value
        End Set
    End Property

    Public Property forn_Data_cadastro() As String
        Get
            Return fornDataCadastro
        End Get
        Set(ByVal value As String)
            fornDataCadastro = value
        End Set
    End Property

    Public Property forn_Email() As String
        Get
            Return fornEmail
        End Get
        Set(ByVal value As String)
            fornEmail = value
        End Set
    End Property

    Public Property forn_Site() As String
        Get
            Return fornSite
        End Get
        Set(ByVal value As String)
            fornSite = value
        End Set
    End Property

    Public Property forn_Nome_fantasia() As String
        Get
            Return fornNomeFantas
        End Get
        Set(ByVal value As String)
            fornNomeFantas = value
        End Set
    End Property

    Public Property forn_Inscricao_estMun() As String
        Get
            Return fornInscricaoEstMun
        End Get
        Set(ByVal value As String)
            fornInscricaoEstMun = value
        End Set
    End Property

    Public Sub CadastraFornec()
        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO Fornecedor ")
        strQuery.Append(" ( ")
        strQuery.Append(" forn_Nome ")
        strQuery.Append(", forn_CNPJ ")
        strQuery.Append(", forn_Nome_fantasia ")
        strQuery.Append(", forn_Inscricao_estMun ")
        strQuery.Append(", forn_CEP ")
        strQuery.Append(", forn_Numero ")
        strQuery.Append(", forn_Complemento ")
        strQuery.Append(", forn_DDD ")
        strQuery.Append(", forn_Telefone ")
        strQuery.Append(", forn_Data_cadastro ")
        strQuery.Append(", forn_Email ")
        strQuery.Append(", forn_Site ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & fornNome & "' ")
        strQuery.Append(", '" & fornCNPJ & "' ")
        strQuery.Append(", '" & fornNomeFantas & "' ")
        strQuery.Append(", '" & fornInscricaoEstMun & "' ")
        strQuery.Append(", '" & fornCEP & "' ")
        strQuery.Append(", '" & fornNumero & "' ")
        strQuery.Append(", '" & fornComplemento & "' ")
        strQuery.Append(", '" & fornDDD & "' ")
        strQuery.Append(", '" & fornTelefone & "' ")
        strQuery.Append(", '" & fornDataCadastro & "' ")
        strQuery.Append(", '" & fornEmail & "' ")
        strQuery.Append(", '" & fornSite & "' ")
        strQuery.Append(" ); ")
    End Sub

    Public Sub ExcluiFornec(ByVal mCod_Cliente As Integer) 'Sub não retorna valor
        'Cria um StringBuilder concatenar a query SQL
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM Fornecedor ")
        'strQuery.Append(" WHERE nome= '" & Trim(Nome) & "'") '===Excluir Pelo Nome (Trim retira os espaços)
        strQuery.Append(" WHERE forn_Cod_fornecedor = '" & fornCodFornecedor & "'") 'Excluir Pelo Cod
        ' Método ExecutaComando da classe de BD
        Dim cldBandoDados As New cldBancoDados()
        cldBandoDados.ExecutaComando(strQuery.ToString) 'Repassa a Query de exclusão para ser executado
    End Sub

    Public Sub AlteraFornec()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Nome = '" & fornNome & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_CNPJ = '" & forn_CNPJ & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Nome_fantasia = '" & fornNomeFantas & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Inscricao_estMun = '" & fornInscricaoEstMun & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_CEP = '" & fornCEP & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Numero = '" & fornNumero & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Complemento = '" & fornComplemento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_DDD = '" & fornDDD & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Telefone = '" & fornTelefone & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Data_cadastro = '" & fornDataCadastro & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Email = '" & fornEmail & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append(" forn_Site = '" & fornSite & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" forn_Cod_fornecedor = '" & fornCodFornecedor & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function ListaFORNECEDOR_PRODT(ByVal fornNomeFantas As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select fornecedor.forn_Nome, Produto.pro_Fornecedor from produto inner join fornecedor on produto.pro_fornecedor = fornecedor.forn_cod_fornecedor where forn_Nome_fantasia = '" & fornNomeFantas & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCodForncedor(ByVal fornNome As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select forn_Cod_fornecedor from Fornecedor where forn_Nome='" & fornNome & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function FornecedorNome(ByVal fornCodFornecedor As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select forn_Nome from Fornecedor where forn_Cod_fornecedor ='" & fornCodFornecedor & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function
End Class
