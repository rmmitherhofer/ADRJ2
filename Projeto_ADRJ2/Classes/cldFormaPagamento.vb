Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldFormaPagamento

    Private fpCodPag As Integer
    Private fpDescPag As String
    Private fpTipoPag As String
    Private fpVezes As String
    Public Property fp_Cod_Pagamento() As Integer
        Get
            Return fpCodPag
        End Get
        Set(ByVal value As Integer)
            fpCodPag = value
        End Set
    End Property

    Public Property fp_Descricao_pagamento() As String
        Get
            Return fpDescPag
        End Get
        Set(ByVal value As String)
            fpDescPag = value
        End Set
    End Property

    Public Property fp_Tipo_Pagamento() As String
        Get
            Return fpTipoPag
        End Get
        Set(ByVal value As String)
            fpTipoPag = value
        End Set
    End Property

    Public Property fp_Vezes() As String
        Get
            Return fpVezes
        End Get
        Set(ByVal value As String)
            fpVezes = value
        End Set
    End Property

    Public Sub CadastraFormPag()

    End Sub

    Public Function CarregaCodpagamento(ByVal fpDescPag As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select fp_cod_pagamento from FORMA_PAGAMENTO where fp_Descricao_pagamento = '" & fpDescPag & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaDescricaoPagamento(ByVal fpCodPag As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select fp_Descricao_pagamento from FORMA_PAGAMENTO where fp_cod_pagamento = '" & fpCodPag & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function
End Class
