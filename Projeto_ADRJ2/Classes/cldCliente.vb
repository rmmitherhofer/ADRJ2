Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldCliente

    Private mCod_Cliente As Integer
    Private mNome As String
    Private mRG As String
    Private mCPF As String
    Private mData_Nascimento As String
    Private mSexo As String
    Private mNome_mae As String
    Private mEstado_civil As Integer
    Private mCEP As String
    Private mNumero As String
    Private mComplemento As String
    Private mDDD As String
    Private mTelefone As String
    Private mDDD2 As String
    Private mCelular As String
    Private mData_cadastro As String
    Private mEmail As String

    Public Property cl_Cod_Cliente() As Integer
        Get
            Return mCod_Cliente
        End Get
        Set(ByVal value As Integer)
            mCod_Cliente = value
        End Set
    End Property

    Public Property cl_Nome() As String
        Get
            Return mNome
        End Get
        Set(ByVal value As String)
            mNome = value
        End Set
    End Property

    Public Property cl_RG() As String
        Get
            Return mRG
        End Get
        Set(ByVal value As String)
            mRG = value
        End Set
    End Property

    Public Property cl_CPF() As String
        Get
            Return mCPF
        End Get
        Set(ByVal value As String)
            mCPF = value
        End Set
    End Property

    Public Property cl_Data_nascimento() As String
        Get
            Return mData_Nascimento
        End Get
        Set(ByVal value As String)
            mData_Nascimento = value
        End Set
    End Property

    Public Property cl_Sexo() As String
        Get
            Return mSexo
        End Get
        Set(ByVal value As String)
            mSexo = value
        End Set
    End Property

    Public Property cl_Nome_mae() As String
        Get
            Return mNome_mae
        End Get
        Set(ByVal value As String)
            mNome_mae = value
        End Set
    End Property

    Public Property cl_Estado_civil() As Integer
        Get
            Return mEstado_civil
        End Get
        Set(ByVal value As Integer)
            mEstado_civil = value
        End Set
    End Property

    Public Property cl_CEP() As String
        Get
            Return mCEP
        End Get
        Set(ByVal value As String)
            mCEP = value
        End Set
    End Property

    Public Property cl_Numero() As String
        Get
            Return mNumero
        End Get
        Set(ByVal value As String)
            mNumero = value
        End Set
    End Property

    Public Property cl_Complemento() As String
        Get
            Return mComplemento
        End Get
        Set(ByVal value As String)
            mComplemento = value
        End Set
    End Property

    Public Property cl_DDD() As String
        Get
            Return mDDD
        End Get
        Set(ByVal value As String)
            mDDD = value
        End Set
    End Property

    Public Property cl_Telefone() As String
        Get
            Return mTelefone
        End Get
        Set(ByVal value As String)
            mTelefone = value
        End Set
    End Property

    Public Property cl_DDD2() As String
        Get
            Return mDDD2
        End Get
        Set(ByVal value As String)
            mDDD2 = value
        End Set
    End Property

    Public Property cl_Celular() As String
        Get
            Return mCelular
        End Get
        Set(ByVal value As String)
            mCelular = value
        End Set
    End Property

    Public Property cl_Data_cadastro() As String
        Get
            Return mData_cadastro
        End Get
        Set(ByVal value As String)
            mData_cadastro = value
        End Set
    End Property

    Public Property cl_Email() As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
        End Set
    End Property

    Public Sub CadastraCliente()
        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO Cliente ")
        strQuery.Append(" ( ")
        strQuery.Append(" cl_Nome ")
        strQuery.Append(", cl_RG ")
        strQuery.Append(", cl_CPF ")
        strQuery.Append(", cl_Data_nascimento ")
        strQuery.Append(", cl_Sexo ")
        strQuery.Append(", cl_Nome_mae ")
        strQuery.Append(", cl_Estado_civil ")
        strQuery.Append(", cl_CEP ")
        strQuery.Append(", cl_Numero ")
        strQuery.Append(", cl_Complemento ")
        strQuery.Append(", cl_DDD ")
        strQuery.Append(", cl_Telefone ")
        strQuery.Append(", cl_DDD2 ")
        strQuery.Append(", cl_Celular ")
        strQuery.Append(", cl_Data_Cadastro ")
        strQuery.Append(", cl_Email ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & mNome & "' ")
        strQuery.Append(", '" & mRG & "' ")
        strQuery.Append(", '" & mCPF & "' ")
        strQuery.Append(", '" & mData_Nascimento & "' ")
        strQuery.Append(", '" & mSexo & "' ")
        strQuery.Append(", '" & mNome_mae & "' ")
        strQuery.Append(", " & mEstado_civil & " ")
        strQuery.Append(", '" & mCEP & "' ")
        strQuery.Append(", '" & mNumero & "' ")
        strQuery.Append(", '" & mComplemento & "' ")
        strQuery.Append(", '" & mDDD & "' ")
        strQuery.Append(", '" & mTelefone & "' ")
        strQuery.Append(", '" & mDDD2 & "' ")
        strQuery.Append(", '" & mCelular & "' ")
        strQuery.Append(", '" & mData_cadastro & "' ")
        strQuery.Append(", '" & mEmail & "' ")
        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function CarregaCod(ByVal cl_Nome As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select cl_Cod_cliente from Cliente where cl_Nome='" & cl_nome & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Sub ExcluirCliente(ByVal mCod_Cliente As Integer) 'Sub não retorna valor
        'Cria um StringBuilder concatenar a query SQL
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM Cliente ")
        'strQuery.Append(" WHERE nome= '" & Trim(Nome) & "'") '===Excluir Pelo Nome (Trim retira os espaços)
        strQuery.Append(" WHERE cl_Cod_cliente= '" & mCod_Cliente & "'") 'Excluir Pelo Cod
        ' Método ExecutaComando da classe de BD
        Dim cldBandoDados As New cldBancoDados()
        cldBandoDados.ExecutaComando(strQuery.ToString) 'Repassa a Query de exclusão para ser executado
    End Sub

    Public Sub AlteraCliente()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Nome = '" & mNome & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_RG = '" & mRG & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_CPF = '" & mCPF & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Data_nascimento = '" & mData_Nascimento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Sexo = '" & mSexo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Nome_mae = '" & mNome_mae & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Estado_civil = '" & mEstado_civil & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_CEP = '" & mCEP & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Numero = '" & mNumero & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Complemento = '" & mComplemento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_DDD = '" & mDDD & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Telefone = '" & mTelefone & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_DDD2 = '" & mDDD2 & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Celular = '" & mCelular & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Data_Cadastro = '" & mData_cadastro & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        strQuery.Append(" UPDATE Cliente ")
        strQuery.Append(" SET ")
        strQuery.Append(" cl_Email = '" & mEmail & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cl_Cod_cliente = '" & mCod_Cliente & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function ListarCliente(ByVal mCPF As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from CLIENTE where cl_CPF like '" & mCPF & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Function Lista(ByVal strDescricao As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cl_Cod_cliente, cl_CPF, cl_Nome, cl_Data_Nascimento")
        strQuery.Append(" FROM CLIENTE ")
        strQuery.Append(" WHERE cl_CPF like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY cl_Cod_cliente ")
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function ListarCodClient(ByVal mCodCliente As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from CLIENTE where cl_Cod_cliente like '" & mCodCliente & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function
End Class

