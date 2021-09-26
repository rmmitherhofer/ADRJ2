Public Class Form_consulta_banco

    Private Sub Form_consulta_banco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_sai_consu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sai_consu.Click
        Me.Close()
    End Sub

    Private Sub btn_procura_consu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procura_consu.Click
        Dim EstoquePesq As New cldProduto

        If Me.Combo_tipo_consu.Text = "Produto/Estoque" Then
            dgv_consulta_dado.DataSource = EstoquePesq.Procuraprodut(Me.txt_procura_dado.Text).Tables(0)
            dgv_consulta_dado.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.dgv_consulta_dado.Columns(0).HeaderText = CStr("Código do Produto")
            Me.dgv_consulta_dado.Columns(1).HeaderText = CStr("Descrição")
            Me.dgv_consulta_dado.Columns(2).HeaderText = CStr("Categoria")
            Me.dgv_consulta_dado.Columns(3).HeaderText = CStr("Fornecedor")
            Me.dgv_consulta_dado.Columns(4).HeaderText = CStr("Valor R$")
            Me.dgv_consulta_dado.Columns(5).HeaderText = CStr("Quantidade")
        End If
    End Sub

End Class