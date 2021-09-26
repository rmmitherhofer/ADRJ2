Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida

Public Class cldFuncionario

    Private fCargo As String
    Private fCelular As String
    Private fCEP As String
    Private fCod_Funcionario As Integer
    Private fComplemento As String
    Private fCPF As String
    Private fCTPS As String
    Private fCursos As String
    Private fData_admissao As String
    Private fData_dispensa As String
    Private fData_nascimento As String
    Private fDDD As String
    Private fDDD2 As String
    Private fEstadoCivil As Integer
    Private fFilial As Integer
    Private fGrau_esolar As Integer
    Private fNome As String
    Private fNome_escola As String
    Private fNomeMae As String
    Private fNumero As String
    Private fRG As String
    Private fSalario As String
    Private fSerie As String
    Private fSexo As String
    Private fSituacaoEscolar As String
    Private fTelefone As String
    Private fEmail As String
    Private fLogin As String
    Private fSenha As String
    Private fLocal As String


    Public Property fun_Cod_Funcionario() As Integer
        Get
            Return fCod_Funcionario
        End Get
        Set(ByVal value As Integer)
            fCod_Funcionario = value
        End Set
    End Property

    Public Property fun_Nome() As String
        Get
            Return fNome
        End Get
        Set(ByVal value As String)
            fNome = value
        End Set
    End Property

    Public Property fun_RG() As String
        Get
            Return fRG
        End Get
        Set(ByVal value As String)
            fRG = value
        End Set
    End Property

    Public Property fun_CPF() As String
        Get
            Return fCPF
        End Get
        Set(ByVal value As String)
            fCPF = value
        End Set
    End Property

    Public Property fun_Data_nascimento() As String
        Get
            Return fData_nascimento
        End Get
        Set(ByVal value As String)
            fData_nascimento = value
        End Set
    End Property

    Public Property fun_Sexo() As String
        Get
            Return fSexo
        End Get
        Set(ByVal value As String)
            fSexo = value
        End Set
    End Property

    Public Property fun_Nome_mae() As String
        Get
            Return fNomeMae
        End Get
        Set(ByVal value As String)
            fNomeMae = value
        End Set
    End Property

    Public Property fun_Estado_civil() As Integer
        Get
            Return fEstadoCivil
        End Get
        Set(ByVal value As Integer)
            fEstadoCivil = value
        End Set
    End Property

    Public Property fun_CEP() As String
        Get
            Return fCEP
        End Get
        Set(ByVal value As String)
            fCEP = value
        End Set
    End Property

    Public Property fun_Numero() As String
        Get
            Return fNumero
        End Get
        Set(ByVal value As String)
            fNumero = value
        End Set
    End Property

    Public Property fun_Complemento() As String
        Get
            Return fComplemento
        End Get
        Set(ByVal value As String)
            fComplemento = value
        End Set
    End Property

    Public Property fun_Grau_escolaridade() As Integer
        Get
            Return fGrau_esolar
        End Get
        Set(ByVal value As Integer)
            fGrau_esolar = value
        End Set
    End Property

    Public Property fun_Situação_escolar() As String
        Get
            Return fSituacaoEscolar
        End Get
        Set(ByVal value As String)
            fSituacaoEscolar = value
        End Set
    End Property

    Public Property fun_Nome_Escola() As String
        Get
            Return fNome_escola
        End Get
        Set(ByVal value As String)
            fNome_escola = value
        End Set
    End Property

    Public Property fun_Cursos() As String
        Get
            Return fCursos
        End Get
        Set(ByVal value As String)
            fCursos = value
        End Set
    End Property

    Public Property fun_CTPS() As String
        Get
            Return fCTPS
        End Get
        Set(ByVal value As String)
            fCTPS = value
        End Set
    End Property

    Public Property fun_Serie() As String
        Get
            Return fSerie
        End Get
        Set(ByVal value As String)
            fSerie = value
        End Set
    End Property

    Public Property fun_DDD() As String
        Get
            Return fDDD
        End Get
        Set(ByVal value As String)
            fDDD = value
        End Set
    End Property

    Public Property fun_Telefone() As String
        Get
            Return fTelefone
        End Get
        Set(ByVal value As String)
            fTelefone = value
        End Set
    End Property

    Public Property fun_DDD2() As String
        Get
            Return fDDD2
        End Get
        Set(ByVal value As String)
            fDDD2 = value
        End Set
    End Property

    Public Property fun_Celular() As String
        Get
            Return fCelular
        End Get
        Set(ByVal value As String)
            fCelular = value
        End Set
    End Property

    Public Property fun_Cargo() As String
        Get
            Return fCargo
        End Get
        Set(ByVal value As String)
            fCargo = value
        End Set
    End Property

    Public Property fun_Data_admissao() As String
        Get
            Return fData_admissao
        End Get
        Set(ByVal value As String)
            fData_admissao = value
        End Set
    End Property

    Public Property fun_Data_Dispensa() As String
        Get
            Return fData_dispensa
        End Get
        Set(ByVal value As String)
            fData_dispensa = value
        End Set
    End Property

    Public Property fun_Filial() As Integer
        Get
            Return fFilial
        End Get
        Set(ByVal value As Integer)
            fFilial = value
        End Set
    End Property

    Public Property fun_Salario() As String
        Get
            Return fSalario
        End Get
        Set(ByVal value As String)
            fSalario = value
        End Set
    End Property

    Public Property fun_Email() As String
        Get
            Return fEmail
        End Get
        Set(ByVal value As String)
            fEmail = value
        End Set
    End Property

    Public Property fun_Login() As String
        Get
            Return fLogin
        End Get
        Set(ByVal value As String)
            fLogin = value
        End Set
    End Property

    Public Property fun_Senha() As String
        Get
            Return fSenha
        End Get
        Set(ByVal value As String)
            fSenha = value
        End Set
    End Property

    Public Property fun_localhost() As String
        Get
            Return fLocal
        End Get
        Set(ByVal value As String)
            fLocal = value
        End Set
    End Property

    Public Sub CadastraFun()

        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO FUNCIONARIO ")
        strQuery.Append(" ( ")
        strQuery.Append(" fun_Nome ")
        strQuery.Append(", fun_RG ")
        strQuery.Append(", fun_CPF ")
        strQuery.Append(", fun_Data_nascimento ")
        strQuery.Append(", fun_Sexo  ")
        strQuery.Append(", fun_Nome_mae ")
        strQuery.Append(", fun_Estado_civil ")
        strQuery.Append(", fun_CEP ")
        strQuery.Append(", fun_Numero ")
        strQuery.Append(", fun_Complemento ")
        strQuery.Append(", fun_Grau_escolaridade ")
        strQuery.Append(", fun_Situação_escolar ")
        strQuery.Append(", fun_Nome_Escola ")
        strQuery.Append(", fun_Cursos ")
        strQuery.Append(", fun_CTPS ")
        strQuery.Append(", fun_Serie ")
        strQuery.Append(", fun_DDD ")
        strQuery.Append(", fun_Telefone ")
        strQuery.Append(", fun_DDD2 ")
        strQuery.Append(", fun_Celular ")
        strQuery.Append(", fun_Cargo ")
        strQuery.Append(", fun_Data_admissao ")
        strQuery.Append(", fun_Data_Dispensa ")
        strQuery.Append(", fun_Filial ")
        strQuery.Append(", fun_Salario ")
        strQuery.Append(", fun_Email ")
        strQuery.Append(", fun_Login ")
        strQuery.Append(", fun_Senha  ")
        strQuery.Append(", fun_localhost ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & fNome & "' ")
        strQuery.Append(", '" & fRG & "' ")
        strQuery.Append(", '" & fCPF & "' ")
        strQuery.Append(", '" & fData_nascimento & "' ")
        strQuery.Append(", '" & fSexo & "' ")
        strQuery.Append(", '" & fNomeMae & "' ")
        strQuery.Append(", " & fEstadoCivil & " ")
        strQuery.Append(", '" & fCEP & "' ")
        strQuery.Append(", '" & fNumero & "' ")
        strQuery.Append(", '" & fComplemento & "' ")
        strQuery.Append(", " & fGrau_esolar & " ")
        strQuery.Append(", '" & fSituacaoEscolar & "'  ")
        strQuery.Append(", '" & fNome_escola & "' ")
        strQuery.Append(", '" & fCursos & "' ")
        strQuery.Append(", '" & fCTPS & "' ")
        strQuery.Append(", '" & fSerie & "' ")
        strQuery.Append(", '" & fDDD & "' ")
        strQuery.Append(", '" & fTelefone & "' ")
        strQuery.Append(", '" & fDDD2 & "' ")
        strQuery.Append(", '" & fCelular & "' ")
        strQuery.Append(", '" & fCargo & "' ")
        strQuery.Append(", '" & fData_admissao & "' ")
        strQuery.Append(", '" & fData_dispensa & "' ")
        strQuery.Append(", " & fFilial & " ")
        strQuery.Append(", '" & fSalario & "' ")
        strQuery.Append(", '" & fEmail & "' ")
        strQuery.Append(", '" & fLogin & "' ")
        strQuery.Append(", '" & fSenha & "' ")
        strQuery.Append(", '" & fLocal & "' ")
        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub ExcluiFun(ByVal fCod_Funcionario As Integer)
        'Cria um StringBuilder concatenar a query SQL
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM FUNCIONARIO ")
        'strQuery.Append(" WHERE nome= '" & Trim(Nome) & "'") '===Excluir Pelo Nome (Trim retira os espaços)
        strQuery.Append(" WHERE fun_Cod_Funcionario = '" & fCod_Funcionario & "'") 'Excluir Pelo Cod
        ' Método ExecutaComando da classe de BD
        Dim cldBandoDados As New cldBancoDados()
        cldBandoDados.ExecutaComando(strQuery.ToString) 'Repassa a Query de exclusão para ser executado
    End Sub

    Public Function ListaFun(ByVal fCPF As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from Funcionario where fun_CPF like '" & fCPF & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Function ConsultaCod(ByVal fCod_Funcionario As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from Funcionario where fun_Cod_Funcionario like '" & fCod_Funcionario & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Function ListarCodFUN(ByVal fCod_Funcionario As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from FUNCIONARIO where fun_Cod_Funcionario like '" & fCod_Funcionario & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Sub AlteraFuncionario()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Nome = '" & fNome & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_RG = '" & fRG & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_CPF = '" & fCPF & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Data_nascimento = '" & fData_nascimento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Sexo = '" & fSexo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Nome_mae = '" & fNomeMae & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Estado_civil = '" & fEstadoCivil & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_CEP = '" & fCEP & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Numero = '" & fNumero & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Complemento = '" & fComplemento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Grau_escolaridade = '" & fGrau_esolar & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Situação_escolar = '" & fSituacaoEscolar & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Nome_Escola = '" & fNome_escola & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Cursos = '" & fCursos & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_CTPS = '" & fCTPS & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Serie = '" & fSerie & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_DDD = '" & fDDD & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Telefone = '" & fTelefone & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_DDD2 = '" & fDDD2 & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Celular = '" & fCelular & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Cargo = '" & fCargo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Data_admissao = '" & fData_admissao & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Data_Dispensa  = '" & fData_dispensa & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Filial = '" & fFilial & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Salario = '" & fSalario & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Email = '" & fEmail & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Login = '" & fLogin & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Senha  = '" & fSenha & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_localhost = '" & fLocal & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_funcionario = '" & fCod_Funcionario & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function CarregaCodfUN(ByVal fNome As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select fun_Cod_Funcionario from FUNCIONARIO where fun_Nome ='" & fNome & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Sub AlteraSenha()
        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE Funcionario ")
        strQuery.Append(" SET ")
        strQuery.Append(" fun_Senha = '" & fSenha & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" fun_Cod_Funcionario = '" & fCod_Funcionario & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    'valida a senha e usuario do funcionario
    Public Function ValidaFuncLogin(ByVal fLogin As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = " select fun_cod_funcionario, fun_Nome, fun_senha, fun_localHost, fun_login from funcionario where fun_login = '" & fLogin & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function
End Class

