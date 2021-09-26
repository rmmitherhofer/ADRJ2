Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldEstadoCivil

    Private ecCodEstCivil As Integer
    Private ecDescEstCivil As String
    Public Property ec_Cod_Estado_Civil() As Integer
        Get
            Return ecCodEstCivil
        End Get
        Set(ByVal value As Integer)
            ecCodEstCivil = value
        End Set
    End Property

    Public Property ec_Descrição_Estado_Civi() As String
        Get
            Return ecDescEstCivil
        End Get
        Set(ByVal value As String)
            ecDescEstCivil = value
        End Set
    End Property

    Public Sub CadatraEstCivil()

    End Sub

    Public Function CarregaCodEC(ByVal ecDescEstCivil As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select ec_cod_estado_civil from estado_civil where ec_descricao_estado_civil = '" & ecDescEstCivil & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaDescricaoEC(ByVal ecCodEstCivil As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select ec_descricao_estado_civil from Estado_civil where ec_cod_estado_civil  = '" & ecCodEstCivil & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function
End Class
