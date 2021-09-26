Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldDDD

    Private dDDD As String
    Private dCidade As String
    Private dEstado As String
    Public Property d_DDD() As String
        Get
            Return dDDD
        End Get
        Set(ByVal value As String)
            dDDD = value
        End Set
    End Property

    Public Property d_Cidade() As String
        Get
            Return dCidade
        End Get
        Set(ByVal value As String)
            dCidade = value
        End Set
    End Property

    Public Property d_Estado() As String
        Get
            Return dEstado
        End Get
        Set(ByVal value As String)
            dEstado = value
        End Set
    End Property

    'Public Function ListaDDD() As System.Data.DataSet

    'End Function
End Class
