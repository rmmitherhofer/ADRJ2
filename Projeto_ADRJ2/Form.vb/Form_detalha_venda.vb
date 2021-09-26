Public Class Form_detalha_venda
    Dim venda As New cldVenda
    Dim detalhavenda As New cldDetalhaVenda
    Dim frmprincipal As New Form_principal
    Dim tipoPagamento As New cldFormaPagamento
    Dim drDados As System.Data.SqlClient.SqlDataReader
    Dim formapagamento, modopagamento, valor, valorProduto, valorParcel, valorTotal, Parcela As String
    Dim codFun, cod_venda, codLoja As Integer
    Private Sub btn_volta_detavenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta_detavenda.Click
        Me.Close()
    End Sub

    Private Sub Form_detalha_venda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        drDados = detalhavenda.DetalhavendaD(Me.lbl_cupom_deta_venda.Text)
        If drDados.Read Then

            valor = CStr(drDados("dv_Subtotal"))
            Me.lbl_produt_detavenda.Text = CStr(drDados("Pro_nome_produto"))
            Me.lbl_ValorProduto_DV.Text = CStr(drDados("Pro_valor"))
            Me.lbl_quant_detavenda.Text = CStr(drDados("dv_quantidade"))
            codFun = CStr(drDados("vnd_Cod_funcionario"))
            Me.lbl_datavenda_detavenda.Text = CStr(drDados("vnd_data_venda"))
            Parcela = CStr(drDados("vnd_Parcela"))
            valorTotal = CStr(drDados("vnd_total"))
            modopagamento = CStr(drDados("vnd_tipo_pagamento"))
            codLoja = CStr(drDados("vnd_cod_loja"))
            cod_venda = CStr(drDados("dv_cod_venda"))

            drDados = venda.Funandloja(cod_venda)
            If drDados.Read Then
                Me.lbl_Nomefunc_detavenda.Text = CStr(drDados("fun_nome"))
                Me.lbl_loja_detavenda.Text = CStr(drDados("fil_nome"))
                Me.lbl_tipo_pagamento.Text = CStr(drDados("fp_descricao_pagamento"))
            End If

        Else
            MessageBox.Show("Erro!")
            Me.Close()
        End If



        Me.lbl_valorTotal_Dv.Text = valor
        Me.lbl_parcela_detavenda.Text = Parcela

        If modopagamento = "V" Then
            Me.lbl_fpagamento_detavenda.Text = "Vista"
            Me.lbl_valorparce_detavenda.Text = ""
        Else
            Me.lbl_fpagamento_detavenda.Text = "Prazo"
            valorParcel = valor / Parcela
            Me.lbl_valorparce_detavenda.Text = valorParcel
        End If
    End Sub
End Class