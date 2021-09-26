Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldDetalhaVenda


    Private dvCupom As Integer
    Private dvQuant As String
    Private dvCodProdut As Integer
    Private dvSubtotal As String
    Private dvCodVenda As Integer



    Public Property dv_Cod_Produto() As Integer
        Get
            Return dvCodProdut
        End Get
        Set(ByVal value As Integer)
            dvCodProdut = value
        End Set
    End Property

    Public Property dv_Cod_venda() As Integer
        Get
            Return dvCodVenda
        End Get
        Set(ByVal value As Integer)
            dvCodVenda = value
        End Set
    End Property

    Public Property dv_Quantidade() As String
        Get
            Return dvQuant
        End Get
        Set(ByVal value As String)
            dvQuant = value
        End Set
    End Property

    Public Property dv_Cupom() As Integer
        Get
            Return dvCupom
        End Get
        Set(ByVal value As Integer)
            dvCupom = value
        End Set
    End Property

    Public Property dv_Subtotal() As String
        Get
            Return dvSubtotal
        End Get
        Set(ByVal value As String)
            dvSubtotal = value
        End Set
    End Property

    Public Function ListaDV(ByVal dvCupom As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select * from DETALHAMENTO_VENDA where dv_Cupom Like '" & dvCupom & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Sub Inseri_Produto()

        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO DETALHAMENTO_VENDA ")
        strQuery.Append(" ( ")
        strQuery.Append(" dv_Cod_Produto ")
        strQuery.Append(", dv_Quantidade ")
        strQuery.Append(", dv_Subtotal ")
        strQuery.Append(", dv_Cod_venda ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & dvCodProdut & "' ")
        strQuery.Append(", '" & dvQuant & "' ")
        strQuery.Append(", '" & dvSubtotal & "' ")
        strQuery.Append(", '" & dvCodVenda & "' ")
        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function detalVendaCod(ByVal dvCodVenda As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select dv_Cupom from DETALHAMENTO_VENDA where dv_Cod_Venda='" & dvCodVenda & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function ListaVendadetalha(ByVal vCodVenda As String) As System.Data.DataSet  'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda ")
        strQuery.Append(" where Detalhamento_venda.dv_Cod_Venda = '" & dvCodVenda & "'")
        strQuery.Append(" ORDER BY dv_cupom ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function SomaListaDVenda(ByVal dvCodVenda As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select sum (dv_subtotal) as dv_Soma_Venda from detalhamento_venda where dv_cod_venda ='" & dvCodVenda & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function DetalhavendaD(ByVal dvCupom As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = " select Produto.pro_Nome_produto, produto.pro_valor, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, Detalhamento_venda.dv_cod_venda, venda.vnd_data_venda, venda.vnd_Parcela, venda.vnd_total, venda.vnd_tipo_pagamento, venda.vnd_cod_loja, venda.vnd_cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda Where dv_Cupom = '" & dvCupom & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function
End Class

