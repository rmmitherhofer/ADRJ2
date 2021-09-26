Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldEndereco

    Private eCEP As String
    Private eLogradouro As String
    Private eBairro As String
    Private eCidade As String
    Private eUF As String
    Public Property end_CEP() As String
        Get
            Return eCEP
        End Get
        Set(ByVal value As String)
            eCEP = value
        End Set
    End Property

    Public Property end_Logradouro() As String
        Get
            Return eLogradouro
        End Get
        Set(ByVal value As String)
            eLogradouro = value
        End Set
    End Property

    Public Property end_Bairro() As String
        Get
            Return eBairro
        End Get
        Set(ByVal value As String)
            eBairro = value
        End Set
    End Property

    Public Property end_Cidade() As String
        Get
            Return eCidade
        End Get
        Set(ByVal value As String)
            eCidade = value
        End Set
    End Property

    Public Property end_UF() As String
        Get
            Return eUF
        End Get
        Set(ByVal value As String)
            eUF = value
        End Set
    End Property

    Public Sub InseriEnd()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO Endereco ")
        strQuery.Append(" ( ")
        strQuery.Append(" end_CEP ")
        strQuery.Append(", end_Logradouro ")
        strQuery.Append(", end_Bairro ")
        strQuery.Append(", end_Cidade ")
        strQuery.Append(", end_UF ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & eCEP & "' ")
        strQuery.Append(", '" & eLogradouro & "' ")
        strQuery.Append(", '" & eBairro & "' ")
        strQuery.Append(", '" & eCidade & "' ")
        strQuery.Append(", '" & eUF & "' ")
        strQuery.Append(" ) ")
        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    '   Public Function ListaEnd() As System.Data.SqlClient.SqlDataReader

    '    End Function

    Public Sub AlteraEnd()

    End Sub

    Public Function CarregaCEP(ByVal eCEP As String) As SqlDataReader
        Dim strQuery As String
        'strQuery = "select * from Endereco where end_CEP = '" & eCEP & "'"
        strQuery = "select endereco.*, cliente.cl_CEP from cliente inner join endereco on cliente.cl_CEP = endereco.end_Cep where endereco.end_CEP ='" & eCEP & "'"

        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)

    End Function

    Public Function CarregaCEPgeral(ByVal eCEP As String) As SqlDataReader
        Dim strQuery As String
        'strQuery = "select * from Endereco where end_CEP = '" & eCEP & "'"
        strQuery = "select * from endereco where end_CEP like '" & eCEP & "'"

        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)

    End Function

    Public Function CadastraEnd(ByVal eCEP As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select end_CEP from Endereco where end_CEP = '" & eCEP & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCEPFunc(ByVal eCEP As String) As SqlDataReader
        Dim strQuery As String
        'strQuery = "select * from Endereco where end_CEP = '" & eCEP & "'"
        strQuery = "select endereco.*, FUNCIONARIO.fun_CEP from FUNCIONARIO inner join endereco on FUNCIONARIO.fun_CEP = endereco.end_Cep where endereco.end_CEP ='" & eCEP & "'"

        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)

    End Function
End Class
