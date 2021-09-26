Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldFilial

    Private filCodFilial As Integer
    Private filNome As String
    Private filCEP As String
    Private FilNumero As String
    Private filComplemento As String
    Private filDDD As String
    Private filTelefone As String
    Private filHorario As String
    Private filCNPJ As String
    Public Property fil_Cod_filial() As Integer
        Get
            Return filCodFilial
        End Get
        Set(ByVal value As Integer)
            filCodFilial = value
        End Set
    End Property

    Public Property fil_Nome() As String
        Get
            Return filNome
        End Get
        Set(ByVal value As String)
            filNome = value
        End Set
    End Property

    Public Property fil_CEP() As String
        Get
            Return filCEP
        End Get
        Set(ByVal value As String)
            filCEP = value
        End Set
    End Property

    Public Property fil_Numero() As String
        Get
            Return FilNumero
        End Get
        Set(ByVal value As String)
            FilNumero = value
        End Set
    End Property

    Public Property fil_Complemento() As String
        Get
            Return filComplemento
        End Get
        Set(ByVal value As String)
            filComplemento = value
        End Set
    End Property

    Public Property fil_DDD() As String
        Get
            Return filDDD
        End Get
        Set(ByVal value As String)
            filDDD = value
        End Set
    End Property

    Public Property fil_Telefone() As String
        Get
            Return filTelefone
        End Get
        Set(ByVal value As String)
            filTelefone = value
        End Set
    End Property

    Public Property fil_CNPJ() As String
        Get
            Return filCNPJ
        End Get
        Set(ByVal value As String)
            filCNPJ = value
        End Set
    End Property

    Public Property fil_Horarios() As String
        Get
            Return filHorario
        End Get
        Set(ByVal value As String)
            filHorario = value
        End Set
    End Property

    Public Sub CadastraFilial()

        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO FILIAL ")
        strQuery.Append(" ( ")
        strQuery.Append(" fil_Nome ")
        strQuery.Append(", fil_CEP ")
        strQuery.Append(", fil_Numero ")
        strQuery.Append(", fil_Complemento ")
        strQuery.Append(", fil_DDD  ")
        strQuery.Append(", fil_Telefone ")
        strQuery.Append(", fil_Horarios ")
        strQuery.Append(", fil_CNPJ ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & filNome & "' ")
        strQuery.Append(", '" & filCEP & "' ")
        strQuery.Append(", '" & FilNumero & "' ")
        strQuery.Append(", '" & filComplemento & "' ")
        strQuery.Append(", '" & filDDD & "' ")
        strQuery.Append(", '" & filTelefone & "' ")
        strQuery.Append(", " & filHorario & " ")
        strQuery.Append(", '" & filCNPJ & "' ")

        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function CarregaCodFilial(ByVal filNome As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select fil_cod_filial from filial where fil_nome =='" & filNome & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function


End Class
