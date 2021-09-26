Imports System.Data.SqlClient 'Comandos SQL
Imports System.Text 'StringBuilder  Consulta rápida
Public Class cldVenda

    Private vCodVenda As Integer
    Private vCodCliente As Integer
    Private vCodFunc As Integer
    Private vCodLoja As Integer
    Private vCodPagamento As Integer
    Private vDataVenda As String
    Private vParcela As String
    Private vTotal As String
    Private vTipoPagamento As String
    Private vVendaN As Integer

    'Propriedades
    '-------------------------------------------------------------------------------------------------------
    Public Property vnd_Cod_venda() As Integer
        Get
            Return vCodVenda
        End Get
        Set(ByVal value As Integer)
            vCodVenda = value
        End Set
    End Property

    Public Property vnd_Cod_cliente() As Integer
        Get
            Return vCodCliente
        End Get
        Set(ByVal value As Integer)
            vCodCliente = value
        End Set
    End Property

    Public Property vnd_Cod_funcionario() As Integer
        Get
            Return vCodFunc
        End Get
        Set(ByVal value As Integer)
            vCodFunc = value
        End Set
    End Property

    Public Property vnd_Cod_loja() As Integer
        Get
            Return vCodLoja
        End Get
        Set(ByVal value As Integer)
            vCodLoja = value
        End Set
    End Property

    Public Property vnd_Cod_pagamento() As Integer
        Get
            Return vCodPagamento
        End Get
        Set(ByVal value As Integer)
            vCodPagamento = value
        End Set
    End Property

    Public Property vnd_Data_Venda() As String
        Get
            Return vDataVenda
        End Get
        Set(ByVal value As String)
            vDataVenda = value
        End Set
    End Property

    Public Property vnd_Parcela() As String
        Get
            Return vParcela
        End Get
        Set(ByVal value As String)
            vParcela = value
        End Set
    End Property

    Public Property vnd_Total() As String
        Get
            Return vTotal
        End Get
        Set(ByVal value As String)
            vTotal = value
        End Set
    End Property

    Public Property vnd_Tipo_Pagamento() As String
        Get
            Return vTipoPagamento
        End Get
        Set(ByVal value As String)
            vTipoPagamento = value
        End Set
    End Property

    Public Property vnd_VendaN() As Integer
        Get
            Return vVendaN
        End Get
        Set(ByVal value As Integer)
            vVendaN = value
        End Set
    End Property

    ' Funções
    '-------------------------------------------------------------------------------------------------

    Public Sub InseriVenda()
        Dim strQuery As New StringBuilder

        strQuery.Append(" INSERT INTO Venda")
        strQuery.Append(" ( ")
        strQuery.Append(" vnd_Cod_cliente ")
        strQuery.Append(", vnd_Cod_funcionario ")
        strQuery.Append(", vnd_Cod_loja ")
        strQuery.Append(", vnd_Cod_pagamento ")
        strQuery.Append(", vnd_Data_Venda ")
        strQuery.Append(", vnd_Parcela ")
        strQuery.Append(", vnd_Total ")
        strQuery.Append(", vnd_Tipo_Pagamento ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" " & vCodCliente & " ")
        strQuery.Append(", " & vCodFunc & " ")
        strQuery.Append(", " & vCodLoja & " ")
        strQuery.Append(", " & vCodPagamento & " ")
        strQuery.Append(", '" & vDataVenda & "' ")
        strQuery.Append(", '" & vParcela & "' ")
        strQuery.Append(", '" & vTotal & "' ")
        strQuery.Append(", '" & vTipoPagamento & "' ")
        strQuery.Append(" ); ")

        '=====COMO FICA A CONSULTA ACIMA======
        'strQuery = "insert into t_dadosAgenda(Nome) values ('xxxxx')"
        '==============================
        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub ExcluiVenda()

    End Sub

    Public Sub AlteraVenda()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Cod_cliente = '" & vCodCliente & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Cod_funcionario = '" & vCodFunc & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Cod_loja = '" & vCodLoja & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Cod_pagamento = '" & vCodPagamento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Data_Venda = '" & vDataVenda & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Parcela = '" & vParcela & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Total = '" & vTotal & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        strQuery.Append(" UPDATE Venda ")
        strQuery.Append(" SET ")
        strQuery.Append(" vnd_Tipo_Pagamento = '" & vTipoPagamento & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vnd_Cod_venda = '" & vCodVenda & "' ")

        Dim cldBancoDados As New cldBancoDados
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function ListaVenda() As SqlDataReader
        Dim strQuery As String
        strQuery = "select * from VENDA where cl_Cod_venda ='" & vCodVenda & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Function ProcuraVenda(ByVal vCodCliente As String) As System.Data.DataSet 'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" select Detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda,  vnd_cod_loja, venda.vnd_cod_funcionario, venda.vnd_Cod_venda from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda ")
        strQuery.Append(" where venda.vnd_Cod_Cliente = '" & vCodCliente & "'")
        strQuery.Append(" ORDER BY vnd_data_venda ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function ProcuracodVenda(ByVal vCodVenda As String) As System.Data.DataSet  'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" select detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, venda.vnd_Tipo_Pagamento, venda.vnd_parcela, Detalhamento_venda.dv_Quantidade, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda,  vnd_cod_loja, venda.vnd_Cod_venda, venda.vnd_Cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda ")
        strQuery.Append(" where vnd_Cod_venda = '" & vCodVenda & "'")
        strQuery.Append(" ORDER BY vnd_data_venda ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function VendaCod(ByVal vDataVenda As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "select vnd_Cod_venda from Venda where vnd_Data_Venda = '" & vDataVenda & "'"
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function ListaVenda(ByVal vCodVenda As String) As System.Data.DataSet  'ou As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" select detalhamento_venda.dv_Cupom, PRODUTO.pro_Nome_produto, venda.vnd_Tipo_Pagamento, venda.vnd_parcela, Detalhamento_venda.dv_Quantidade, detalhamento_venda.dv_Valor_Parcela, Detalhamento_venda.dv_subtotal, venda.vnd_data_venda,  vnd_cod_loja, venda.vnd_Cod_venda, venda.vnd_Cod_funcionario from detalhamento_venda inner join produto on Detalhamento_venda.dv_cod_produto = PRODUTO.pro_cod_produto inner join venda on DETALHamento_venda.dv_Cod_venda = Venda.vnd_Cod_Venda ")
        strQuery.Append(" where venda.vnd_cOD_vENDA = '" & vCodVenda & "'")
        strQuery.Append(" ORDER BY dv_cupom ")
        '========== Como é a consulta no SQL, sendo pesquisado a letra L ==========
        'SELECT cod,Nome FROM t_dadosAgenda WHERE nome like '%L%' ORDER BY cod
        '=========================================================
        Dim _cldBancoDados As New cldBancoDados() 'Cria/Instancia o obj _cldBancoDados da classe cldBancoDados
        Return _cldBancoDados.RetornaDataSet(strQuery.ToString) 'Chama a função e aguarda o retorno (Return)
    End Function

    Public Function Listarvenda(ByVal vCodVenda As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = "select vnd_vendaN from venda where vnd_cod_venda like '" & vCodVenda & "'" 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function

    Public Function Funandloja(ByVal vCodVenda As String) As SqlDataReader 'Retorna DataReader
        Dim strQuery As String
        strQuery = " select fun_nome, fil_nome, fp_descricao_pagamento from venda inner join funcionario on vnd_cod_funcionario = fun_cod_funcionario inner join filial on vnd_cod_loja = filial.fil_cod_filial inner join forma_pagamento on  vnd_cod_pagamento = forma_pagamento.fp_cod_pagamento where venda.vnd_cod_venda ='" & vCodVenda & "' " 'Consulta tudo pelo Código
        Dim _BancoDados As New cldBancoDados
        Return _BancoDados.RetornaDataReader(strQuery.ToString) 'Solicita DataReader conforme consulta SQL
    End Function
End Class
