Public Class Form_principal
    Dim formaPagamento As New cldFormaPagamento
    Dim CLDescolaridade As New cldEscolaridade
    Dim Estadocivil As New cldEstadoCivil
    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação
    Dim Parcelado, _nome, quantidades As String
    Dim vall, PRtotal, Preco, JUROS, valoress, soma, totalizacompra As Double
    Dim msg, parcel, valore, escola As Integer


    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_consultcpf_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_consultcpf_cliente.Click
        Dim estcivil As Integer
        Dim sex As String
        Dim EnderecoCliente As New cldEndereco
        Dim cliente As New cldCliente 'Cria obj classe Agenda

        If Me.txt_cpf_cliente.Text = "   .   .   -" Then
            MessageBox.Show("Insira o CPF do Cliente")
            Me.txt_cpf_cliente.Focus()
            Exit Sub
        End If

        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = cliente.ListarCliente(txt_cpf_cliente.Text) 'Chama o ListarUsuario informando o Código


        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.lbl_nome_cliente.Text = CStr(drDados("cl_Nome"))
            Me.lbl_cel_cliente.Text = CStr(drDados("cl_Celular"))
            Me.lbl_cpf_cliente.Text = CStr(drDados("cl_CPF"))
            Me.lbl_dataabertura_cliente.Text = CStr(drDados("cl_Data_Cadastro"))
            Me.lbl_datanascimento_cliente.Text = CStr(drDados("cl_Data_nascimento"))
            Me.lbl_dddcel_cliente.Text = CStr(drDados("cl_DDD2"))
            Me.lbl_dddtel_cliente.Text = CStr(drDados("cl_DDD"))
            estcivil = CInt(drDados("cl_Estado_civil"))
            Me.lbl_n_cliente.Text = CStr(drDados("cl_Numero"))
            Me.lbl_rg_cliente.Text = CStr(drDados("cl_RG"))
            sex = CStr(drDados("cl_Sexo"))
            Me.lbl_telefone_cliente.Text = CStr(drDados("cl_Telefone"))
            Me.lbl_cep_cliente.Text = CStr(drDados("cl_CEP"))
            Me.lbl_cod_cliente.Text = CStr(drDados("cl_Cod_cliente"))
            Me.lbl_codcliente_venda.Text = CStr(drDados("cl_Cod_cliente"))
            Me.lbl_datanascimento_venda.Text = CStr(drDados("cl_Data_nascimento"))
            Me.lbl_Nome_venda.Text = CStr(drDados("cl_Nome"))
            Me.lbl_numero_venda.Text = CStr(drDados("cl_Numero"))
            Me.txt_cpf_venda.Text = CStr(drDados("cl_CPF"))

            Dim endDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
            endDados = EnderecoCliente.CarregaCEP(lbl_cep_cliente.Text) 'Chama o ListarUsuario informando o Código
            If endDados.Read = True Then
                Me.lbl_endereco_cliente.Text = CStr(endDados("end_Logradouro"))
                Me.lbl_bairro_cliente.Text = CStr(endDados("end_Bairro"))
                Me.lbl_cit_cliente.Text = CStr(endDados("end_Cidade"))
                Me.lbl_uf_cliente.Text = CStr(endDados("end_UF"))
                Me.lbl_endereco_venda.Text = CStr(endDados("end_Logradouro"))
                Me.lbl_bairro_venda.Text = CStr(endDados("end_Bairro"))
                Me.lbl_cidade_venda.Text = CStr(endDados("end_Cidade"))
                Me.lbl_uf_venda.Text = CStr(endDados("end_UF"))
                Me.lbl_CEP_venda.Text = CStr(drDados("cl_CEP"))


            End If


            drDados = Estadocivil.CarregaDescricaoEC(estcivil)
            If drDados.Read = True Then
                Me.lbl_estadocivil_cliente.Text = CStr(drDados("ec_descricao_estado_civil"))
            End If

            If sex = "F" Then
                Me.lbl_sex_cliente.Text = "Feminino"

            ElseIf sex = "M" Then
                Me.lbl_sex_cliente.Text = "Masculino"

            End If

            Dim venda As New cldVenda
            'Os dados são carregados no DataGridView(dgv) através da Tables(0), tabela gerada na memória RAM pelo DataSet
            DGV_cliente.DataSource = venda.ProcuraVenda(Me.lbl_cod_cliente.Text).Tables(0)
            DGV_cliente.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_cliente.Columns(0).HeaderText = CStr("Cupom")
            Me.DGV_cliente.Columns(1).HeaderText = CStr("Produto")
            Me.DGV_cliente.Columns(2).HeaderText = CStr("Quantidade")
            Me.DGV_cliente.Columns(3).HeaderText = CStr("Valor R$")
            Me.DGV_cliente.Columns(4).HeaderText = CStr("Data")
            Me.DGV_cliente.Columns(5).HeaderText = CStr("Loja")
            Me.DGV_cliente.Columns(6).HeaderText = CStr("Funcionário")
            Me.DGV_cliente.Columns(7).HeaderText = CStr("Venda")
            'Me.DGV_cliente.Columns(9).HeaderText = CStr("Venda")
            ' Me.DGV_cliente.Columns(10).HeaderText = CStr("Vendedor")
        Else
            MessageBox.Show("CPF incorreto")
            Me.txt_cpf_cliente.Clear()
            Me.txt_cpf_cliente.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub btn_detalha_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_detalha_cliente.Click
        Dim frmConsultaCliente As New Form_cadastra_cliente 'Cria obj da classe frmGeral
        frmConsultaCliente.txt_codcliente_cadas.Text = CStr(Me.lbl_cod_cliente.Text) 'Captura o cod atual do DGV da 1º celula
        frmConsultaCliente.btn_cadastra_client.Visible = False
        frmConsultaCliente.btn_atualiza_client.Visible = False
        frmConsultaCliente.box_cliente_cadastr.Enabled = False
        frmConsultaCliente.Text = "Consulta Cliente" 'Alterar nome do formulário
        frmConsultaCliente.ShowDialog() 'Abre o frm de forma bloqueada
        'CarregaGrid() 'No retorno carrega Grid
    End Sub

    Private Sub btn_cadastra_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_cliente.Click
        Dim formNovoCliente As New Form_cadastra_cliente

        'Criar a classe clnFuncoesGerais
        _operacao = clnFuncoesGerais1.Operacao.Inclusao 'Informa que é inclusão
        formNovoCliente.Text = "Cadastrar Cliente" 'Altera o Texto do frmGeral
        formNovoCliente.txt_codcliente_cadas.Enabled = False 'Desativa o Código
        formNovoCliente.btn_cadastra_client.Visible = True
        formNovoCliente.btn_atualiza_client.Visible = False
        formNovoCliente.btn_edita_client.Visible = False
        formNovoCliente.btn_exclui_client.Visible = False
        formNovoCliente.ShowDialog()

        ' CarregaGrid() 'Preenche/Atualiza o DGV
    End Sub

    Private Sub btn_limpa_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpa_cliente.Click
        lbl_bairro_cliente.Text = String.Empty
        lbl_cel_cliente.Text = String.Empty
        lbl_cep_cliente.Text = String.Empty
        lbl_cit_cliente.Text = String.Empty
        lbl_cod_cliente.Text = String.Empty
        lbl_cpf_cliente.Text = String.Empty
        lbl_dataabertura_cliente.Text = String.Empty
        lbl_datanascimento_cliente.Text = String.Empty
        lbl_dddcel_cliente.Text = String.Empty
        lbl_dddtel_cliente.Text = String.Empty
        lbl_endereco_cliente.Text = String.Empty
        lbl_estadocivil_cliente.Text = String.Empty
        lbl_n_cliente.Text = String.Empty
        lbl_nome_cliente.Text = String.Empty
        lbl_rg_cliente.Text = String.Empty
        lbl_sex_cliente.Text = String.Empty
        lbl_telefone_cliente.Text = String.Empty
        lbl_uf_cliente.Text = String.Empty
        txt_cpf_cliente.Text = String.Empty
        lbl_Nome_venda.Text = String.Empty
        lbl_datanascimento_venda.Text = String.Empty
        lbl_codcliente_venda.Text = String.Empty
        lbl_endereco_venda.Text = String.Empty
        lbl_CEP_venda.Text = String.Empty
        lbl_numero_venda.Text = String.Empty
        lbl_bairro_venda.Text = String.Empty
        lbl_cidade_venda.Text = String.Empty
        lbl_uf_venda.Text = String.Empty
        txt_cpf_venda.Text = String.Empty
        DGV_cliente.Columns.Clear()

    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click

        Dim login As New form_login

        msg = CInt(CStr(MessageBox.Show("Atenção!! Deseja desconectar do ambiente de Trabalho?", Me.Text, MessageBoxButtons.YesNo)))
        If CInt(msg) = Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If
    End Sub

    Private Sub btn_procuravenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procuravenda.Click
        Dim venda As New cldVenda
        Dim cliente As String
        Dim tratamento As String
        Dim trat As String

        cliente = lbl_nome_cliente.Text

        If Me.lbl_sex_cliente.Text = "Feminino" Then
            tratamento = "Sra."
            trat = "A"
        Else
            tratamento = "Sr."
            trat = "O"
        End If
        If Me.txt_movimentacao_codvenda_client.Text = "" Then
            MessageBox.Show("Insira o Código da venda")
            Exit Sub
        End If
        'Os dados são carregados no DataGridView(dgv) através da Tables(0), tabela gerada na memória RAM pelo DataSet
        DGV_cliente.DataSource = venda.ProcuraVenda(Me.lbl_cod_cliente.Text).Tables(0)
        DGV_cliente.DataSource = venda.ProcuracodVenda(Me.txt_movimentacao_codvenda_client.Text).Tables(0)
        DGV_cliente.AutoResizeColumns() 'Tamanho exato da maior coluna
        Me.DGV_cliente.Columns(0).HeaderText = CStr("Cupom")
        'Nome do cabeçalho das colunas

    End Sub

    Private Sub btn_detalhavenda_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_detalhavenda_client.Click
        Dim frmdetalhavenda As New Form_detalha_venda 'Cria obj da classe frmGeral
        frmdetalhavenda.lbl_cupom_deta_venda.Text = CStr(Me.DGV_cliente.CurrentRow.Cells(0).Value)
        frmdetalhavenda.lbl_codclient_detavenda.Text = Me.lbl_cod_cliente.Text
        frmdetalhavenda.lbl_nomeclient_detavenda.Text = Me.lbl_nome_cliente.Text
        frmdetalhavenda.ShowDialog() 'Abre o frm de forma bloqueada
    End Sub

    Private Sub Form_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim login As New form_login
        login.Close()
        txt_cod_venda.Enabled = True
        txt_cpf_venda.Enabled = False
        box_pagament.Enabled = False
        Me.box_geraProduto.Enabled = False
        txt_cod_venda.Enabled = False
        Combo_soleciona_estoque.Visible = False
        txt_data_venda.Enabled = False
        txt_cpf_cliente.Focus()
        Parcelado = " "
        box_Forma_pagamento.Enabled = False
        txt_codfunc_venda.Enabled = False
        txt_nomeprodut_venda.Enabled = False
        txt_valorproduto_venda.Enabled = False
        txt_valor_parcela_venda.Enabled = False

    End Sub

    Private Sub btn_procuranomeprodut_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procuranomeprodut_venda.Click
        Dim frmconsultaprotud As New Form_consulta_banco
        frmconsultaprotud.Combo_tipo_consu.Enabled = False
        frmconsultaprotud.btn_altera_filial.Visible = False
        frmconsultaprotud.btn_alterafornecedor.Visible = False
        frmconsultaprotud.ShowDialog()
    End Sub

    Private Sub btn_consulta_cpf_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulta_cpf_func.Click
        Dim estcivilfun As Integer
        Dim sexfun As String
        Dim Enderecofunc As New cldEndereco

        If Me.txt_cpf_func.Text = "   .   .   -" Then
            MessageBox.Show("Insira o CPF do Funcionario")
            Me.txt_cpf_func.Focus()
            Exit Sub
        End If


        Dim Funcionario As New cldFuncionario 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = Funcionario.ListaFun(txt_cpf_func.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.lbl_cargo_func.Text = CStr(drDados("fun_Cargo"))
            Me.lbl_cep_func.Text = CStr(drDados("fun_CEP"))
            Me.lbl_cel_func.Text = CStr(drDados("fun_Celular"))
            Me.lbl_Cod_func.Text = CStr(drDados("fun_Cod_Funcionario"))
            Me.lbl_complemento_func.Text = CStr(drDados("fun_Complemento"))
            estcivilfun = CInt(drDados("fun_Estado_civil"))
            Me.lbl_completo_func.Text = CStr(drDados("fun_Situação_escolar"))
            Me.lbl_cpf_func.Text = CStr(drDados("fun_CPF"))
            sexfun = CStr(drDados("fun_Sexo"))
            Me.lbl_ctps_func.Text = CStr(drDados("fun_CTPS"))
            Me.lbl_curso_func.Text = CStr(drDados("fun_Cursos"))
            Me.lbl_dataadmissao_func.Text = CStr(drDados("fun_Data_admissao"))
            Me.lbl_datadispensa_func.Text = CStr(drDados("fun_Data_Dispensa"))
            Me.lbl_datanascimento_func.Text = CStr(drDados("fun_Data_nascimento"))
            Me.lbl_dddcel_func.Text = CStr(drDados("fun_DDD2"))
            Me.lbl_dddtel_func.Text = CStr(drDados("fun_DDD"))
            escola = CStr(drDados("fun_Grau_escolaridade"))
            Me.lbl_estadocivil_func.Text = CStr(drDados("fun_Estado_civil"))
            Me.lbl_filial_func.Text = CStr(drDados("fun_Filial"))
            Me.lbl_n_func.Text = CStr(drDados("fun_Numero"))
            Me.lbl_nome_func.Text = CStr(drDados("fun_Nome"))
            Me.lbl_nomeescola_func.Text = CStr(drDados("fun_Nome_Escola"))
            Me.lbl_nomemae_func.Text = CStr(drDados("fun_Nome_mae"))
            Me.lbl_rg_func.Text = CStr(drDados("fun_RG"))
            Me.lbl_salario_func.Text = CStr(drDados("fun_Salario"))
            Me.lbl_serie_func.Text = CStr(drDados("fun_Serie"))
            Me.lbl_tel_func.Text = CStr(drDados("fun_Telefone"))
            Me.txt_Cod_func_consulta.Text = CStr(drDados("fun_Cod_Funcionario"))
            Me.lbl_email_func.Text = CStr(drDados("fun_Email"))
            Me.txt_Cod_func_consulta.Enabled = False
            Me.txt_cpf_func.Enabled = False

            Dim endDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
            endDados = Enderecofunc.CarregaCEPFunc(lbl_cep_func.Text) 'Chama o ListarUsuario informando o Código
            If endDados.Read = True Then
                Me.lbl_logradouto_func.Text = CStr(endDados("end_Logradouro"))
                Me.lbl_bairro_func.Text = CStr(endDados("end_Bairro"))
                Me.lbl_cidade_func.Text = CStr(endDados("end_Cidade"))
                Me.lbl_uf_func.Text = CStr(endDados("end_UF"))
            End If


            drDados = Estadocivil.CarregaDescricaoEC(estcivilfun)
            If drDados.Read = True Then
                Me.lbl_estadocivil_func.Text = CStr(drDados("ec_descricao_estado_civil"))
            End If

            drDados = CLDescolaridade.CarregaDescricaoEscol(escola)
            If drDados.Read = True Then
                Me.lbl_escolaridade_func.Text = CStr(drDados("es_escolaridade"))
            End If

            If sexfun = "F" Then
                Me.lbl_sexo_func.Text = "Feminino"

            ElseIf sexfun = "M" Then
                Me.lbl_sexo_func.Text = "Masculino"

            End If
        Else
            MessageBox.Show("CPF invalido")
            Me.txt_cpf_func.Clear()
            Me.txt_cpf_func.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btn_consulta_cod_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulta_cod_func.Click
        Dim estcivilfun As Integer
        Dim sexfun As String
        Dim Enderecofunc As New cldEndereco

        If Me.txt_Cod_func_consulta.Text = "" Then
            MessageBox.Show("Insira o Código do Funcionário")
            Me.txt_Cod_func_consulta.Focus()

            Exit Sub

        End If

        Dim Funcionario As New cldFuncionario 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = Funcionario.ConsultaCod(txt_Cod_func_consulta.Text) 'Chama o ListarUsuario informando o Código

        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.lbl_cargo_func.Text = CStr(drDados("fun_Cargo"))
            Me.lbl_cep_func.Text = CStr(drDados("fun_CEP"))
            Me.lbl_cel_func.Text = CStr(drDados("fun_Celular"))
            Me.lbl_Cod_func.Text = CStr(drDados("fun_Cod_Funcionario"))
            Me.lbl_complemento_func.Text = CStr(drDados("fun_Complemento"))
            estcivilfun = CInt(drDados("fun_Estado_civil"))
            Me.lbl_completo_func.Text = CStr(drDados("fun_Situação_escolar"))
            Me.lbl_cpf_func.Text = CStr(drDados("fun_CPF"))
            sexfun = CStr(drDados("fun_Sexo"))
            Me.lbl_ctps_func.Text = CStr(drDados("fun_CTPS"))
            Me.lbl_curso_func.Text = CStr(drDados("fun_Cursos"))
            Me.lbl_dataadmissao_func.Text = CStr(drDados("fun_Data_admissao"))
            ' Me.lbl_datadispensa_func.Text = CStr(drDados("fun_Data_Dispensa"))
            Me.lbl_datanascimento_func.Text = CStr(drDados("fun_Data_nascimento"))
            Me.lbl_dddcel_func.Text = CStr(drDados("fun_DDD2"))
            Me.lbl_dddtel_func.Text = CStr(drDados("fun_DDD"))
            Me.lbl_escolaridade_func.Text = CStr(drDados("fun_Grau_escolaridade"))
            'Me.lbl_estadocivil_func.Text = CStr(drDados("fun_Estado_civil"))
            Me.lbl_filial_func.Text = CStr(drDados("fun_Filial"))
            Me.lbl_n_func.Text = CStr(drDados("fun_Numero"))
            Me.lbl_nome_func.Text = CStr(drDados("fun_Nome"))
            Me.lbl_nomeescola_func.Text = CStr(drDados("fun_Nome_Escola"))
            Me.lbl_nomemae_func.Text = CStr(drDados("fun_Nome_mae"))
            Me.lbl_rg_func.Text = CStr(drDados("fun_RG"))
            Me.lbl_salario_func.Text = CStr(drDados("fun_Salario"))
            Me.lbl_serie_func.Text = CStr(drDados("fun_Serie"))
            Me.lbl_tel_func.Text = CStr(drDados("fun_Telefone"))
            Me.txt_cpf_func.Text = CStr(drDados("fun_CPF"))
            Me.lbl_email_func.Text = CStr(drDados("fun_Email"))

            Me.txt_Cod_func_consulta.Enabled = False
            Me.txt_cpf_func.Enabled = False

            Dim endDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
            endDados = Enderecofunc.CarregaCEPFunc(lbl_cep_func.Text) 'Chama o ListarUsuario informando o Código
            If endDados.Read = True Then
                Me.lbl_logradouto_func.Text = CStr(endDados("end_Logradouro"))
                Me.lbl_bairro_func.Text = CStr(endDados("end_Bairro"))
                Me.lbl_cidade_func.Text = CStr(endDados("end_Cidade"))
                Me.lbl_uf_func.Text = CStr(endDados("end_UF"))
            End If

            drDados = Estadocivil.CarregaDescricaoEC(estcivilfun)
            If drDados.Read = True Then
                Me.lbl_estadocivil_func.Text = CStr(drDados("ec_descricao_estado_civil"))
            End If

            drDados = CLDescolaridade.CarregaDescricaoEscol(escola)
            If drDados.Read = True Then
                Me.lbl_escolaridade_func.Text = CStr(drDados("es_escolaridade"))
            End If

            If sexfun = "F" Then
                Me.lbl_sexo_func.Text = "Feminino"

            ElseIf sexfun = "M" Then
                Me.lbl_sexo_func.Text = "Masculino"

            End If
        Else
            MessageBox.Show("Código Invalido")
            Me.txt_Cod_func_consulta.Focus()

            Exit Sub
        End If
    End Sub

    Private Sub btn_cadastra_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_func.Click
        Dim formCadasFun As New Form_cadastra_func

        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        formCadasFun.btn_atualiza_func.Visible = False
        formCadasFun.btn_edita_func.Visible = False
        formCadasFun.btn_exclui_func.Visible = False
        formCadasFun.txt_cod_func.Enabled = False
        formCadasFun.ShowDialog()

    End Sub

    Private Sub btn_consulfornecedor_adm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulfornecedor_adm.Click
        Dim consu As New Form_consulta_banco
        MessageBox.Show("Serviço Indisponivel")
    End Sub

    Private Sub btn_consulfilial_adm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulfilial_adm.Click
        MessageBox.Show("Serviço Indisponivel")
    End Sub

    Private Sub btn_consulfinanca_adm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulfinanca_adm.Click
        MessageBox.Show("Serviço Indisponivel")
    End Sub

    Private Sub btn_cadastrafornecedor_adm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastrafornecedor_adm.Click
        Dim filll As New Form_cadastro_filial
        filll.btn_atualiza_filial.Visible = False
        filll.btn_edita_filial.Visible = False
        filll.btn_exclui_filial.Visible = False
        filll.ShowDialog()
    End Sub

    Private Sub btn_cadastrafilial_adm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastrafilial_adm.Click
        MessageBox.Show("Serviço Indisponivel")
    End Sub

    Private Sub btn_limpar_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar_func.Click
        lbl_Cod_func.Text = String.Empty
        lbl_bairro_func.Text = String.Empty
        lbl_cargo_func.Text = String.Empty
        lbl_cel_func.Text = String.Empty
        lbl_cep_func.Text = String.Empty
        lbl_cidade_func.Text = String.Empty
        lbl_complemento_func.Text = String.Empty
        lbl_completo_func.Text = String.Empty
        lbl_cpf_func.Text = String.Empty
        lbl_ctps_func.Text = String.Empty
        lbl_curso_func.Text = String.Empty
        lbl_dataadmissao_func.Text = String.Empty
        lbl_datadispensa_func.Text = String.Empty
        lbl_datanascimento_func.Text = String.Empty
        lbl_dddcel_func.Text = String.Empty
        lbl_dddtel_func.Text = String.Empty
        lbl_email_func.Text = String.Empty
        lbl_escolaridade_func.Text = String.Empty
        lbl_estadocivil_func.Text = String.Empty
        lbl_filial_func.Text = String.Empty
        lbl_logradouto_func.Text = String.Empty
        lbl_n_func.Text = String.Empty
        lbl_nome_func.Text = String.Empty
        lbl_nomeescola_func.Text = String.Empty
        lbl_nomemae_func.Text = String.Empty
        lbl_rg_func.Text = String.Empty
        lbl_salario_func.Text = String.Empty
        lbl_serie_func.Text = String.Empty
        lbl_sexo_func.Text = String.Empty
        lbl_tel_func.Text = String.Empty
        lbl_uf_func.Text = String.Empty
        txt_cpf_func.Text = String.Empty
        txt_Cod_func_consulta.Text = String.Empty
        Me.txt_Cod_func_consulta.Enabled = True
        Me.txt_cpf_func.Enabled = True
    End Sub

    Private Sub btn_editar_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar_func.Click
        Dim frmCadastroFun As New Form_cadastra_func
        frmCadastroFun.txt_cod_func.Text = CStr(Me.lbl_Cod_func.Text)
        frmCadastroFun.boxFunCadas.Enabled = False
        frmCadastroFun.btn_exclui_func.Visible = False
        frmCadastroFun.btn_carega_cep_func.Visible = False
        frmCadastroFun.btn_cadastra_func.Visible = False
        frmCadastroFun.btn_atualiza_func.Visible = False
        frmCadastroFun.btn_cadastra_end.Visible = False
        frmCadastroFun.ShowDialog()
    End Sub

    Private Sub btn_troca_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_troca_user.Click
        Dim login As New form_login
        login.ShowDialog()
    End Sub

    Private Sub btn_cadastrar_produto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastrar_produto.Click
        Dim formProdutoCadas As New Form_cadastra_produto
        formProdutoCadas.btn_edita_produt.Visible = False
        formProdutoCadas.btn_exclui_produt.Visible = False
        formProdutoCadas.btn_atualiza_produt.Visible = False
        formProdutoCadas.txt_cod_produt.Enabled = False
        formProdutoCadas.ShowDialog()
    End Sub

    Private Sub btn_Edita_estoq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edita_estoq.Click
        Dim formProdutoCadas As New Form_cadastra_produto
        formProdutoCadas.txt_cod_produt.Text = CStr(Me.DGV_produto.CurrentRow.Cells(0).Value) 'Captura o cod atual do DGV da 1º celula
        formProdutoCadas.Text = "Alterar Produto" 'Alterar nome do formulário
        formProdutoCadas.btn_cadastra_produt.Visible = False
        formProdutoCadas.btn_exclui_produt.Visible = False
        formProdutoCadas.btn_atualiza_produt.Visible = False
        formProdutoCadas.Box_produtoCadas.Enabled = False
        formProdutoCadas.ShowDialog()
    End Sub

    Private Sub btn_pesquisar_produto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar_produto.Click
        Dim EstoquePesq As New cldProduto

        If Me.combo_tipopesquisaproduto.Text = "Nome do Produto" Then
            DGV_produto.DataSource = EstoquePesq.Procuraprodut(Me.txt_procurar_produto.Text).Tables(0)
            DGV_produto.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_produto.Columns(0).HeaderText = CStr("Código do Produto")
            Me.DGV_produto.Columns(1).HeaderText = CStr("Descrição")
            Me.DGV_produto.Columns(2).HeaderText = CStr("Categoria")
            Me.DGV_produto.Columns(3).HeaderText = CStr("Fornecedor")
            Me.DGV_produto.Columns(4).HeaderText = CStr("Valor R$")
            Me.DGV_produto.Columns(5).HeaderText = CStr("Quantidade")


        ElseIf Me.combo_tipopesquisaproduto.Text = "Código do Produto" Then
            DGV_produto.DataSource = EstoquePesq.ProcuraprodutCod(Me.txt_procurar_produto.Text).Tables(0)
            DGV_produto.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_produto.Columns(0).HeaderText = CStr("Código do Produto")
            Me.DGV_produto.Columns(1).HeaderText = CStr("Descrição")
            Me.DGV_produto.Columns(2).HeaderText = CStr("Categoria")
            Me.DGV_produto.Columns(3).HeaderText = CStr("Fornecedor")
            Me.DGV_produto.Columns(4).HeaderText = CStr("Valor R$")
            Me.DGV_produto.Columns(5).HeaderText = CStr("Quantidade")

        ElseIf Me.combo_tipopesquisaproduto.Text = "Fornecedor" Then
            DGV_produto.DataSource = EstoquePesq.Procuraprodutforn(Me.Combo_soleciona_estoque.Text).Tables(0)
            DGV_produto.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_produto.Columns(0).HeaderText = CStr("Código do Produto")
            Me.DGV_produto.Columns(1).HeaderText = CStr("Descrição")
            Me.DGV_produto.Columns(2).HeaderText = CStr("Categoria")
            Me.DGV_produto.Columns(3).HeaderText = CStr("Fornecedor")
            Me.DGV_produto.Columns(4).HeaderText = CStr("Valor R$")
            Me.DGV_produto.Columns(5).HeaderText = CStr("Quantidade")

        ElseIf Me.combo_tipopesquisaproduto.Text = "Valor R$" Then
            'Os dados são carregados no DataGridView(dgv) através da Tables(0), tabela gerada na memória RAM pelo DataSet
            DGV_produto.DataSource = EstoquePesq.Procuraprodutvalor(Me.txt_procurar_produto.Text).Tables(0)
            DGV_produto.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_produto.Columns(0).HeaderText = CStr("Código do Produto")
            Me.DGV_produto.Columns(1).HeaderText = CStr("Descrição")
            Me.DGV_produto.Columns(2).HeaderText = CStr("Categoria")
            Me.DGV_produto.Columns(3).HeaderText = CStr("Fornecedor")
            Me.DGV_produto.Columns(4).HeaderText = CStr("Valor R$")
            Me.DGV_produto.Columns(5).HeaderText = CStr("Quantidade")

        ElseIf Me.combo_tipopesquisaproduto.Text = "Categoria" Then
            'Os dados são carregados no DataGridView(dgv) através da Tables(0), tabela gerada na memória RAM pelo DataSet
            DGV_produto.DataSource = EstoquePesq.Procuraprodutcateg(Me.txt_procurar_produto.Text).Tables(0)
            DGV_produto.AutoResizeColumns() 'Tamanho exato da maior coluna
            Me.DGV_produto.Columns(0).HeaderText = CStr("Código do Produto")
            Me.DGV_produto.Columns(1).HeaderText = CStr("Descrição")
            Me.DGV_produto.Columns(2).HeaderText = CStr("Categoria")
            Me.DGV_produto.Columns(3).HeaderText = CStr("Fornecedor")
            Me.DGV_produto.Columns(4).HeaderText = CStr("Valor R$")
            Me.DGV_produto.Columns(5).HeaderText = CStr("Quantidade")
        Else
            MessageBox.Show("Selecione o Tipo de Pesquisa")
        End If
    End Sub

    Private Sub btn_conclui_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_conclui_venda.Click
        Dim drDados As System.Data.SqlClient.SqlDataReader
        Dim Vendas As New cldVenda
        Dim pagamento As Integer


        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        If Me.combo_formapagamento_venda.Text = "Selecionar" Then
            MessageBox.Show("Insira o modo de Pagamento")
            Me.combo_formapagamento_venda.Focus()
            Exit Sub
        End If

        drDados = formaPagamento.CarregaCodpagamento(Me.combo_formapagamento_venda.Text)
        If drDados.Read Then
            pagamento = CStr(drDados("fp_cod_pagamento"))
        End If

        _operacao = clnFuncoesGerais1.Operacao.Alteracao 'Informa que é inclusão
        ' CarregaGrid()

        'Cria obj para Gravar ou Alterar
        With Vendas 'Passa os campos para a classe clnAgenda
            .vnd_Cod_cliente = Trim(Me.lbl_codcliente_venda.Text)
            .vnd_Cod_funcionario = Trim(Me.txt_codfunc_venda.Text)
            .vnd_Cod_pagamento = pagamento
            .vnd_Data_Venda = Trim(Me.txt_data_venda.Text)
            .vnd_Tipo_Pagamento = Parcelado


            If Parcelado = "V" Then
                .vnd_Total = totalizacompra
                .vnd_Parcela = ""
            Else
                .vnd_Total = PRtotal
                If Me.combo_quant_parcelas_venda.Text = "Selecionar" Then
                    MessageBox.Show("Insira as parcelas")
                    Me.combo_quant_parcelas_venda.Focus()
                    Exit Sub
                ElseIf Me.txt_valor_parcela_venda.Text = "" Then
                    MessageBox.Show("Calcule o Valor Parcelado")
                    Me.btn_Calc_venda.Focus()
                    Exit Sub
                End If
                .vnd_Parcela = Trim(Me.combo_quant_parcelas_venda.Text)
            End If
            .vnd_Cod_loja = Trim(Me.txt_codLoja_venda.Text)
            'Trim retira os espaços
        End With
        If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Alteração
            Vendas.vnd_Cod_venda = CInt(Me.txt_cod_venda.Text)
            Vendas.AlteraVenda()
        End If



        If Parcelado = "P" Then
            MessageBox.Show("O Valor de cada parcela em " & parcel & "x é de R$ " & PRtotal & " ao mes com Juros de " & valore * JUROS & "% totalizando valor de R$ " & totalizacompra & ".")
        Else
            MessageBox.Show("Venda Concluida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.dgv_lista_compra.Columns.Clear()
        Me.txt_cod_venda.Text = String.Empty
        Me.txt_codLoja_venda.Text = String.Empty
        Me.radio_parcelado.Checked = False
        Me.radio_vista.Checked = False
        Me.txt_valorproduto_venda.Text = String.Empty
        Me.txt_valor_parcela_venda.Text = String.Empty
        Me.combo_quant_parcelas_venda.Text = "Selecionar"
        Me.combo_formapagamento_venda.Text = "Selecionar"
        Me.txt_valorvista_venda.Text = String.Empty
        Me.box_Forma_pagamento.Enabled = False
        Me.box_geraProduto.Enabled = False
        Me.box_pagament.Enabled = False
        Me.txt_data_venda.Text = String.Empty
        Me.txt_codLoja_venda.Focus()

    End Sub

    Private Sub btn_proc_cod_produto_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proc_cod_produto_venda.Click
        Dim Produto As New cldProduto 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = Produto.ConsulCodProdut(Me.txt_cod_produto_venda.Text) 'Chama o ListarUsuario informando o Código

        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_nomeprodut_venda.Text = CStr(drDados("pro_Nome_produto"))
            Me.txt_valorproduto_venda.Text = CStr(drDados("pro_Valor"))
        End If

    End Sub

    Private Sub btn_inclui_compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inclui_compra.Click

        Dim Dados As System.Data.SqlClient.SqlDataReader
        Dim drDados As System.Data.SqlClient.SqlDataReader
        Dim VendaDetal As New cldDetalhaVenda
        Dim preco, total As Double
        Dim quant, totalQuant As Integer
        Dim produt As New cldProduto

        'Filtros
        If Me.txt_cod_produto_venda.Text = "" Then
            MessageBox.Show("Insira o codigo do produto")
            Me.txt_cod_produto_venda.Focus()
            Exit Sub
        ElseIf Me.txt_valorproduto_venda.Text = "" Then
            MessageBox.Show("Insira o valor do Produto")
            Me.txt_valorproduto_venda.Focus()
            Exit Sub
        ElseIf Me.txt_quantidade.Text = "" Then
            MessageBox.Show("Informe a quantidade")
            Me.txt_quantidade.Focus()
            Exit Sub
        End If

        preco = Me.txt_valorproduto_venda.Text
        quant = Me.txt_quantidade.Text

        total = preco * quant

        msg = CInt(CStr(MessageBox.Show("O Preço do Produto é " & total & " Deseja Continuar?", Me.Text, MessageBoxButtons.YesNo)))
        If CInt(msg) = Windows.Forms.DialogResult.Yes Then

            _operacao = clnFuncoesGerais1.Operacao.Inclusao
            'Cria obj para Gravar ou Alterar
            With VendaDetal 'Passa os campos para a classe clnAgenda
                .dv_Cod_venda = Trim(Me.txt_cod_venda.Text)
                .dv_Cod_Produto = Trim(Me.txt_cod_produto_venda.Text)
                .dv_Quantidade = Trim(Me.txt_quantidade.Text)
                .dv_Subtotal = (total)

            End With


            Dados = produt.ListarQuant(Me.txt_cod_produto_venda.Text)
            If Dados.Read Then
                quantidades = CStr(Dados("pro_Quantidade"))
            End If
            If quantidades >= quant Then
                totalQuant = quantidades - quant
            Else
                MessageBox.Show("Produto Indisponivel")
                Me.txt_cod_produto_venda.Text = String.Empty
                Me.txt_nomeprodut_venda.Text = String.Empty
                Me.txt_valorproduto_venda.Text = String.Empty
                Me.txt_quantidade.Text = String.Empty
                Me.txt_cod_produto_venda.Focus()
                Exit Sub
            End If
            If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
                VendaDetal.Inseri_Produto() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação

                drDados = VendaDetal.detalVendaCod(Me.txt_cod_venda.Text) 'Através do nome procura o novo código
                'drDados = VendaDetal.detalVendaCod(Me.txt_quantidade.Text)
                'drDados = VendaDetal.detalVendaCod(total)


                If drDados.Read Then
                    dgv_lista_compra.DataSource = VendaDetal.ListaVendadetalha(Me.txt_cod_venda.Text).Tables(0)
                    DGV_cliente.AutoResizeColumns() 'Tamanho exato da maior coluna
                    Me.dgv_lista_compra.Columns(0).HeaderText = CStr("Cupom")
                    Me.dgv_lista_compra.Columns(1).HeaderText = CStr("Produto")
                    Me.dgv_lista_compra.Columns(2).HeaderText = CStr("Quantidade")
                    Me.dgv_lista_compra.Columns(3).HeaderText = CStr("Subtotal")
                    MessageBox.Show("Produto Inserido")

                    Dados = VendaDetal.SomaListaDVenda(Me.txt_cod_venda.Text)
                    If Dados.Read Then
                        vall = CStr(Dados("dv_Soma_Venda"))
                    End If


                    With produt
                        .pro_Quantidade = totalQuant
                    End With

                    _operacao = clnFuncoesGerais1.Operacao.Alteracao

                    If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Inclusão
                        produt.pro_Cod_Produto = CInt(Me.txt_cod_produto_venda.Text)
                        produt.AlterQuantPro() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
                    End If

                    Me.txt_cod_produto_venda.Text = String.Empty
                    Me.txt_nomeprodut_venda.Text = String.Empty
                    Me.txt_valorproduto_venda.Text = String.Empty
                    Me.txt_quantidade.Text = String.Empty
                    Me.txt_cod_produto_venda.Focus()



                Else
                    MessageBox.Show("Erro ao Inserir a Venda Verifique o codigo do produto")
                    Me.txt_cod_produto_venda.Text = String.Empty
                    Me.txt_nomeprodut_venda.Text = String.Empty
                    Me.txt_valorproduto_venda.Text = String.Empty
                    Me.txt_quantidade.Text = String.Empty
                    Me.txt_cod_produto_venda.Focus()
                    Exit Sub
                End If
            End If

        Else
            MessageBox.Show("Inclusão cancelada!")
            Me.txt_cod_produto_venda.Text = String.Empty
            Me.txt_nomeprodut_venda.Text = String.Empty
            Me.txt_valorproduto_venda.Text = String.Empty
            Me.txt_quantidade.Text = String.Empty
            Me.txt_cod_produto_venda.Focus()
        End If


        '===================================
    End Sub

    Private Sub btn_habilita_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_habilita_venda.Click
        ' Verifica o nome digitado
        Dim data As String
        Dim formapagamento As Integer


        Dim listavendacod As New cldVenda
        'Tratamentos
        If Me.txt_codfunc_venda.Text = "" Then
            MessageBox.Show("Insira o Codigo Funcional")
            Me.txt_codfunc_venda.Focus()
            Exit Sub
        ElseIf Me.txt_codLoja_venda.Text = "" Then
            MessageBox.Show("Insira o Codigo da Loja")
            Me.txt_codLoja_venda.Focus()
            Exit Sub
        ElseIf Me.lbl_codcliente_venda.Text = "000" Then
            MessageBox.Show("Digite o CPF do cliente na tela Cliente")
            tab_cliente.Show()
            Exit Sub
        ElseIf Me.txt_codfunc_venda.Text > 4 Then
            MessageBox.Show("Funcionário não casdatrado")
            Me.txt_codfunc_venda.Text = String.Empty
            Me.txt_codfunc_venda.Focus()
            Exit Sub
        ElseIf Me.txt_codLoja_venda.Text > 1 Then
            MessageBox.Show("Loja não cadastrada")
            Me.txt_codLoja_venda.Text = String.Empty
            Me.txt_codLoja_venda.Focus()
            Exit Sub
        End If


        _operacao = clnFuncoesGerais1.Operacao.Inclusao

        formapagamento = 5

        data = Me.lbl_data_princ.Text

        Dim Venda As New cldVenda 'Cria obj para Gravar ou Alterar
        With Venda 'Passa os campos para a classe clnAgenda
            .vnd_Cod_cliente = Trim(Me.lbl_codcliente_venda.Text)
            .vnd_Cod_funcionario = Trim(Me.txt_codfunc_venda.Text)
            .vnd_Cod_pagamento = formapagamento
            .vnd_Data_Venda = Trim(Me.lbl_data_princ.Text)
            .vnd_Parcela = " "
            .vnd_Tipo_Pagamento = Parcelado
            .vnd_Cod_loja = Trim(Me.txt_codLoja_venda.Text)

            If Me.txt_valorvista_venda.Text = "" Then
                .vnd_Total = 0 'Trim'(Me.txt_valor_parcela_venda.Text)
            Else
                .vnd_Total = Trim(Me.txt_valorvista_venda.Text)
            End If

        End With
        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            Venda.InseriVenda() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            ''=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = Venda.VendaCod(Me.lbl_data_princ.Text)
            If drDados.Read Then
                Me.txt_cod_venda.Text = CStr(drDados("vnd_Cod_venda"))
                Me.txt_data_venda.Text = data

                ' 'Preenche o novo Código
            End If
        End If
        ' MessageBox.Show("Registro Número " & Me.txt_codcliente_cadas.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Me.Close()
        '===================================

        Me.box_geraProduto.Enabled = True
        Me.box_Forma_pagamento.Enabled = True
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    ' Me.lbl_data_princ.Text = Now
    'End Sub

    Private Sub combo_tipopesquisaproduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_tipopesquisaproduto.SelectedIndexChanged
        If Me.combo_tipopesquisaproduto.Text = "Fornecedor" Then
            Me.Combo_soleciona_estoque.Visible = True
        Else
            Me.Combo_soleciona_estoque.Visible = False
        End If
    End Sub

    Private Sub radio_vista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_vista.CheckedChanged
        If Me.radio_vista.Checked = True Then
            Parcelado = "V"
            Me.box_pagament.Enabled = True
            Me.combo_quant_parcelas_venda.Enabled = False
            Me.txt_valor_parcela_venda.Enabled = False
            Me.txt_valorvista_venda.Enabled = True
            Me.txt_valorvista_venda.Text = vall
            Me.txt_valor_parcela_venda.Text = " "
            Me.btn_Calc_venda.Visible = False
        End If
    End Sub

    Private Sub radio_parcelado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_parcelado.CheckedChanged
        If Me.radio_parcelado.Checked = True Then
            Parcelado = "P"
            Me.box_pagament.Enabled = True
            Me.txt_valorvista_venda.Enabled = False
            Me.combo_quant_parcelas_venda.Enabled = True
            Me.txt_valorvista_venda.Text = vall
            Me.btn_Calc_venda.Visible = True
        End If
    End Sub

    Private Sub btn_Calc_venda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calc_venda.Click
        valore = 100
        If Me.combo_quant_parcelas_venda.Text = "2" Then
            JUROS = 0.02
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "3" Then
            JUROS = 0.03
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "4" Then
            JUROS = 0.04
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "5" Then
            JUROS = 0.05
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "6" Then
            JUROS = 0.0699
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "7" Then
            JUROS = 0.0799
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "8" Then
            JUROS = 0.0825
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "9" Then
            JUROS = 0.0999
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "10" Then
            JUROS = 0.175
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "11" Then
            JUROS = 0.1299
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        ElseIf Me.combo_quant_parcelas_venda.Text = "12" Then
            JUROS = 0.1499
            MessageBox.Show("O valor do Juros é de " & valore * JUROS & "%")
        Else
            MessageBox.Show("Selecione a opção de parcelamento")
            Exit Sub
        End If


        parcel = Me.combo_quant_parcelas_venda.Text
        valoress = vall / parcel
        soma = valoress * JUROS
        PRtotal = valoress + soma
        Me.txt_valor_parcela_venda.Text = PRtotal
        totalizacompra = PRtotal * parcel


    End Sub
End Class