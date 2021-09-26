Public Class Form_cadastra_fornecedor

    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação
    Dim _nome As String

    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_cadastra_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_end.Click
        Dim frmcadasend As New Form_cadastra_endereco

        Me.txt_rua_forne.Text = frmcadasend.txt_lograd_endereco.Text
        Me.txt_cep_forne.Text = frmcadasend.txt_cep_endereco.Text
        Me.txt_cidad_forne.Text = frmcadasend.txt_cidade_endereco.Text
        Me.txt_bairro_forne.Text = frmcadasend.txt_bairro_endereco.Text
        Me.Combo_uf_forne.Text = frmcadasend.Combo_uf_end.Text
        Me.txt_n_forne.Text = String.Empty
        Me.txt_complent_forne.Text = String.Empty
        frmcadasend.ShowDialog()
    End Sub

    Private Sub btn_carregacep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregacep.Click
        Dim EnderecoCliente As New cldEndereco 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = EnderecoCliente.CarregaCEPgeral(txt_cep_forne.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_rua_forne.Text = CStr(drDados("end_Logradouro"))
            Me.txt_bairro_forne.Text = CStr(drDados("end_Bairro"))
            Me.txt_cidad_forne.Text = CStr(drDados("end_Cidade"))
            Me.Combo_uf_forne.Text = CStr(drDados("end_UF"))
            Me.txt_n_forne.Text = String.Empty
            Me.txt_complent_forne.Text = String.Empty
            Exit Sub

        ElseIf Me.txt_cep_forne.Text = "     -" Then
            MessageBox.Show("Insira o CEP")
            txt_cep_forne.Focus()
        Else
            MessageBox.Show("Endereço não Cadastrado")
            Exit Sub
        End If

    End Sub

    Private Sub btn_edita_forne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita_forne.Click

    End Sub

    Private Sub btn_atualiza_forne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atualiza_forne.Click
        ' Verifica o nome digitado
        'Criar a classe clnFuncoesGerais
        _operacao = clnFuncoesGerais1.Operacao.Alteracao 'Informa que é inclusão
        ' CarregaGrid()

        If txt_nome_forne.Text = "" Then
            MessageBox.Show("Insira o nome do Fornecedor")
            txt_nome_forne.Focus()
            Exit Sub
        ElseIf Me.txt_cnpj_forne.Text = "" Then
            MessageBox.Show("Insira o CNPJ")
            Me.txt_cnpj_forne.Focus()
            Exit Sub
        ElseIf txt_email_forn.Text = "" Then
            MessageBox.Show("Insira o e-mail")
            Me.txt_email_forn.Focus()
            Exit Sub
        ElseIf Me.txt_cep_forne.Text = "     -" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_forne.Focus()
            Exit Sub
        ElseIf Me.txt_n_forne.Text = "" Then
            MessageBox.Show("Informe o Numero", "Obrigatório")
            Me.txt_n_forne.Focus()
            Exit Sub
        ElseIf Me.txt_tel_forne.Text = "    -" Then
            MessageBox.Show("Insira o Telefone")
            Me.txt_tel_forne.Focus()
            Exit Sub
        ElseIf Me.txt_dddtel_forne.Text = "(  )" Then
            MessageBox.Show("Insira o DDD")
            Me.txt_dddtel_forne.Focus()
            Exit Sub
        ElseIf Me.txt_dtinclusao_forne.Text = "  /  /" Then
            MessageBox.Show("Insira a data de hoje")
            Me.txt_dtinclusao_forne.Focus()
            Exit Sub
        End If

        Dim Fornecedor As New cldFornecedor 'Cria obj para Gravar ou Alterar
        With Fornecedor 'Passa os campos para a classe clnAgenda
            .forn_Nome = Trim(Me.txt_nome_forne.Text)
            .forn_CNPJ = Trim(Me.txt_cnpj_forne.Text)
            .forn_Nome_fantasia = Trim(Me.txt_nomeFantasia_Forn.Text)
            .forn_Inscricao_estMun = Trim(Me.txt_InscricaoEstMun_forn.Text)
            .forn_CEP = Trim(Me.txt_cep_forne.Text)
            .forn_Numero = Trim(Me.txt_n_forne.Text)
            .forn_Complemento = Trim(Me.txt_complent_forne.Text)
            .forn_DDD = Trim(Me.txt_dddtel_forne.Text)
            .forn_Telefone = Trim(Me.txt_tel_forne.Text)
            .forn_Data_cadastro = Trim(Me.txt_dtinclusao_forne.Text)
            .forn_Email = Trim(Me.txt_email_forn.Text)
            .forn_Site = Trim(Me.txt_site_forn.Text)
        End With
        If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Alteração
            Fornecedor.forn_Cod_fornecedor = CInt(Me.txt_cod_forne.Text)
            Fornecedor.AlteraFornec()
        End If
        MessageBox.Show("Registro Número " & Me.txt_cod_forne.Text & ", Alterado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_exclui_forne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exclui_forne.Click
        Dim msg As Integer
        Try
            msg = CInt(CStr(MessageBox.Show("Deseja excluir o registro? " & CStr(Me.txt_cod_forne.Text), Me.Text, MessageBoxButtons.YesNo)))

            If CInt(msg) = Windows.Forms.DialogResult.Yes Then
                Dim frmCliente As New Form_principal
                Dim ExcluiCliente As New cldCliente
                ExcluiCliente.ExcluirCliente(CInt(Me.txt_cod_forne.Text)) 'Captura o Código atual e repassa para a Function Excluir
                MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'CarregaGrid()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro, talvez não foi definido nenhum valor para exclusão")
        End Try
    End Sub

    Private Sub btn_cadastra_forne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_forne.Click
        ' Verifica o nome digitado
        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        If txt_nome_forne.Text = "" Then
            MessageBox.Show("Insira o nome do Fornecedor")
            txt_nome_forne.Focus()
            Exit Sub
        ElseIf Me.txt_cnpj_forne.Text = "" Then
            MessageBox.Show("Insira o CNPJ")
            Me.txt_cnpj_forne.Focus()
            Exit Sub
        ElseIf txt_email_forn.Text = "" Then
            MessageBox.Show("Insira o e-mail")
            Me.txt_email_forn.Focus()
            Exit Sub
        ElseIf Me.txt_cep_forne.Text = "     -" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_forne.Focus()
            Exit Sub
        ElseIf Me.txt_n_forne.Text = "" Then
            MessageBox.Show("Informe o Numero", "Obrigatório")
            Me.txt_n_forne.Focus()
            Exit Sub
        ElseIf Me.txt_tel_forne.Text = "    -" Then
            MessageBox.Show("Insira o Telefone")
            Me.txt_tel_forne.Focus()
            Exit Sub
        ElseIf Me.txt_dddtel_forne.Text = "(  )" Then
            MessageBox.Show("Insira o DDD")
            Me.txt_dddtel_forne.Focus()
            Exit Sub
        ElseIf Me.txt_dtinclusao_forne.Text = "  /  /" Then
            MessageBox.Show("Insira a data de hoje")
            Me.txt_dtinclusao_forne.Focus()
            Exit Sub
        End If

        Dim Fornecedor As New cldFornecedor 'Cria obj para Gravar ou Alterar
        With Fornecedor 'Passa os campos para a classe clnAgenda
            .forn_Nome = Trim(Me.txt_nome_forne.Text)
            .forn_CNPJ = Trim(Me.txt_cnpj_forne.Text)
            .forn_Nome_fantasia = Trim(Me.txt_nomeFantasia_Forn.Text)
            .forn_Inscricao_estMun = Trim(Me.txt_InscricaoEstMun_forn.Text)
            .forn_CEP = Trim(Me.txt_cep_forne.Text)
            .forn_Numero = Trim(Me.txt_n_forne.Text)
            .forn_Complemento = Trim(Me.txt_complent_forne.Text)
            .forn_DDD = Trim(Me.txt_dddtel_forne.Text)
            .forn_Telefone = Trim(Me.txt_tel_forne.Text)
            .forn_Data_cadastro = Trim(Me.txt_dtinclusao_forne.Text)
            .forn_Email = Trim(Me.txt_email_forn.Text)
            .forn_Site = Trim(Me.txt_site_forn.Text)

        End With
        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            Fornecedor.CadastraFornec() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_nome_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_cnpj_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_nomeFantasia_Forn.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_InscricaoEstMun_forn.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_cep_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_n_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_complent_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_dddtel_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_tel_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_dtinclusao_forne.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_email_forn.Text)
            drDados = Fornecedor.CarregaCodForncedor(Me.txt_site_forn.Text) 'Através do nome procura o novo código

            If drDados.Read Then
                Me.txt_cod_forne.Text = CStr(drDados("forn_Cod_fornecedor"))
                'Preenche o novo Código
            End If
        End If
        MessageBox.Show("Registro Número " & Me.txt_cod_forne.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta.Click
        Me.Close()
    End Sub
End Class