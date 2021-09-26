Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldEscolaridade

    Private esCodEscolar As Integer
    Private esEscolaridade As String
    Public Property es_Cod_Escolaridade() As Integer
        Get
            Return esCodEscolar
        End Get
        Set(ByVal value As Integer)
            esCodEscolar = value
        End Set
    End Property

    Public Property es_Escolaridade() As String
        Get
            Return esEscolaridade
        End Get
        Set(ByVal value As String)
            esEscolaridade = value
        End Set
    End Property

    Public Function CarregaDescricaoEscol(ByVal esCodEscolar As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select es_escolaridade from escolaridade where es_cod_Escolaridade  ='" & esCodEscolar & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCodEscol(ByVal esEscolaridade As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select es_cod_Escolaridade from escolaridade where es_escolaridade = '" & esEscolaridade & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function
End Class
