Public Class Form_cadastra_produto
    Dim _categoria As New cldCategoria
    Dim _fornecedor As New cldFornecedor
    Dim ProdutoInsert As New cldProduto

    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação

    Dim _nome, quantidades, totalQuant, categoriaDesc, fornNome, quantidades2 As String

    Dim CodCategoria, codFornecedor As Integer


    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_cadastra_produt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_produt.Click
        Dim drDados As System.Data.SqlClient.SqlDataReader
        ' Verifica o nome digitado
        If Me.txt_Produto.Text = "" Then
            MessageBox.Show("Insira o nome do Produto")
            Me.txt_Produto.Focus()
            Exit Sub
        ElseIf Me.txt_fornecedor_produt.Text = "Selecionar" Then
            MessageBox.Show("Insira o Fornecedor")
            Me.txt_fornecedor_produt.Focus()
            Exit Sub
        ElseIf Me.Combo_categoria.Text = "Selecionar" Then
            MessageBox.Show("Insira a Categoria")
            Me.Combo_categoria.Focus()
            Exit Sub
        ElseIf Me.txt_preco_custo_produt.Text = "" Then
            MessageBox.Show("Informe o preço de custo")
            Me.txt_preco_custo_produt.Focus()
            Exit Sub
        ElseIf Me.txt_valor_produt.Text = "" Then
            MessageBox.Show("Informe o valor do produto")
            Me.txt_valor_produt.Focus()
            Exit Sub
        ElseIf Me.txt_quant_produt.Text = "" Then
            MessageBox.Show("Informe a quantidade")
            Me.txt_quant_produt.Focus()
            Exit Sub
        End If

        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        drDados = _categoria.CategoriaCod(Me.Combo_categoria.Text)
        If drDados.Read = True Then
            CodCategoria = CStr(drDados("cat_cod_categoria"))
        End If
        drDados = _fornecedor.CarregaCodForncedor(Me.txt_fornecedor_produt.Text)
        If drDados.Read = True Then
            codFornecedor = CStr(drDados("forn_Cod_fornecedor"))
        End If


        'Cria obj para Gravar ou Alterar
        With ProdutoInsert 'Passa os campos para a classe clnAgenda
            .pro_Nome_produto = Trim(Me.txt_Produto.Text)
            .pro_Cod_Barras = Trim(Me.txt_cod_barra_produt.Text)
            .pro_Preco_custo = Trim(Me.txt_preco_custo_produt.Text)
            .pro_Valor = Trim(Me.txt_valor_produt.Text)
            .pro_Fornecedor = codFornecedor
            .pro_Cod_Categoria = CodCategoria
            .pro_Quantidade = Trim(Me.txt_quant_produt.Text)
        End With

        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            ProdutoInsert.InserirProdut() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========

            drDados = ProdutoInsert.CarregaCodProduto(Me.txt_Produto.Text) 'Através do nome procura o novo código
            If drDados.Read Then
                Me.txt_cod_produt.Text = CStr(drDados("pro_Cod_Produto"))
                'Preenche o novo Código
            End If
        End If
        MessageBox.Show("Produto Numero " & Me.txt_cod_produt.Text & " gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        '===================================
    End Sub

    Private Sub btn_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta.Click
        Me.Close()
    End Sub


    Private Sub btn_edita_produt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita_produt.Click
        Me.Box_produtoCadas.Enabled = True
        Me.txt_cod_produt.Enabled = False
        Me.txt_fornecedor_produt.Enabled = False
        Me.txt_Produto.Enabled = False
        Me.Combo_categoria.Enabled = False
        Me.txt_Produto.Enabled = False
        Me.btn_atualiza_produt.Visible = True
        Me.btn_exclui_produt.Visible = True

    End Sub

    Private Sub btn_atualiza_produt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atualiza_produt.Click
        Dim drDados As System.Data.SqlClient.SqlDataReader

        drDados = _categoria.CategoriaCod(Me.Combo_categoria.Text)
        If drDados.Read = True Then
            CodCategoria = CStr(drDados("cat_cod_categoria"))
        End If
        drDados = _fornecedor.CarregaCodForncedor(Me.txt_fornecedor_produt.Text)
        If drDados.Read = True Then
            codFornecedor = CStr(drDados("forn_Cod_fornecedor"))
        End If

        drDados = ProdutoInsert.ListarQuant(Me.txt_cod_produt.Text)
        If drDados.Read = True Then
            quantidades = CStr(drDados("pro_quantidade"))
        End If

        quantidades2 = Me.txt_quant_produt.Text
        totalQuant = quantidades + +quantidades2

        _operacao = clnFuncoesGerais1.Operacao.Alteracao 'Informa que é inclusão


        Dim Produtoatualiza As New cldProduto 'Cria obj para Gravar ou Alterar
        With Produtoatualiza 'Passa os campos para a classe clnAgenda
            .pro_Nome_produto = Trim(Me.txt_Produto.Text)
            .pro_Cod_Barras = Trim(Me.txt_cod_barra_produt.Text)
            .pro_Preco_custo = Trim(Me.txt_preco_custo_produt.Text)
            .pro_Valor = Trim(Me.txt_valor_produt.Text)
            .pro_Fornecedor = codFornecedor
            .pro_Cod_Categoria = CodCategoria
            .pro_Quantidade = totalQuant
        End With
        If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Alteração
            Produtoatualiza.pro_Cod_Produto = CInt(Me.txt_cod_produt.Text)
            Produtoatualiza.AlterarProdut()
        End If
        MessageBox.Show("Produto Número " & Me.txt_cod_produt.Text & ", Alterado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Form_cadastra_produto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fornecedor As String
        Dim categoria As String

        Dim Produto As New cldProduto 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = Produto.CarregaCodProduto2(Me.txt_cod_produt.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_cod_barra_produt.Text = CStr(drDados("pro_Cod_Barras"))
            fornecedor = CStr(drDados("pro_Fornecedor"))
            Me.txt_preco_custo_produt.Text = CStr(drDados("pro_Preco_custo"))
            Me.txt_Produto.Text = CStr(drDados("pro_Nome_produto"))
            Me.txt_valor_produt.Text = CStr(drDados("pro_Valor"))
            categoria = CStr(drDados("pro_Cod_Categoria"))        'Converte para String e preenche o campo nome

            drDados = _categoria.CategoriaDescricao(categoria)
            If drDados.Read = True Then
                categoriaDesc = CStr(drDados("cat_descricao"))
            End If
            drDados = _fornecedor.FornecedorNome(fornecedor)
            If drDados.Read = True Then
                fornNome = CStr(drDados("forn_Nome"))
            End If

            Me.txt_fornecedor_produt.Text = fornNome
            Me.Combo_categoria.Text = categoriaDesc
        End If
    End Sub

    Private Sub btn_exclui_produt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exclui_produt.Click
        Dim formconsuproduto As New Form_principal
        Dim EstoquePesq As New cldProduto

        Dim msg As Integer
        Try
            msg = CInt(CStr(MessageBox.Show("Deseja excluir o Produto? " & CStr(Me.txt_cod_produt.Text), Me.Text, MessageBoxButtons.YesNo)))
            If CInt(msg) = Windows.Forms.DialogResult.Yes Then
                Dim ExcluiProduto As New cldProduto
                ExcluiProduto.ExcluiProdut(CInt(Me.txt_cod_produt.Text)) 'Captura o Código atual e repassa para a Function Excluir
                MessageBox.Show("Produto excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                formconsuproduto.DGV_produto.DataSource = EstoquePesq.Procuraprodut(Me.txt_cod_produt.Text).Tables(0)

                Me.Close()
            Else
                MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
            'CarregaGrid()
        Catch ex As Exception
            MessageBox.Show("ERRO! Não foi selecionado nenhum valor para exclusão!")
            Me.Close()
        End Try
    End Sub
End Class