Public Class Form_cadastra_cliente
    Dim estadoCivil As New cldEstadoCivil
    Dim drDados As System.Data.SqlClient.SqlDataReader
    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação
    Dim _nome As String
    Dim ec As Integer
    Dim sex As String


    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_edita_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita_client.Click
        Me.box_cliente_cadastr.Enabled = True
        Me.txt_codcliente_cadas.Enabled = False
        Me.txt_nomecliente.Enabled = False
        Me.txt_nomemae_client.Enabled = False
        Me.txt_rua_client.Enabled = False
        Me.txt_rgcliente.Enabled = False
        Me.txt_dtnascclient.Enabled = False
        Me.txt_dtabertura_client.Enabled = False
        Me.txt_cpfcliente_cadastr.Enabled = False
        Me.radio_clienteF.Enabled = False
        Me.raidio_clienteM.Enabled = False
        Me.btn_carregacep.Visible = True
        Me.btn_cadastra_end.Visible = True
        Me.btn_atualiza_client.Visible = True
        Me.txt_cidad_client.Enabled = False
        Me.txt_bairro_client.Enabled = False
        Me.Combo_uf_client.Enabled = False
    End Sub

    Private Sub btn_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta.Click
        Me.Close()
    End Sub

    Private Sub btn_atualiza_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atualiza_client.Click
        ' Verifica o nome digitado
        'Criar a classe clnFuncoesGerais

        _operacao = clnFuncoesGerais1.Operacao.Alteracao 'Informa que é inclusão
        ' CarregaGrid()

        If txt_nomecliente.Text = "" Then
            MessageBox.Show("Insira o nome do cliente")
            Me.txt_nomecliente.Focus()
            Exit Sub
        ElseIf Me.Combo_ecivil.Text = "Selecionar" Then
            MessageBox.Show("Selecione o estado civil")
            Me.Combo_ecivil.Focus()
            Exit Sub
        ElseIf txt_cpfcliente_cadastr.Text = "   .   .   -" Then
            MessageBox.Show("Insira o nome CPF")
            Me.txt_cpfcliente_cadastr.Focus()
            Exit Sub
        ElseIf Me.txt_rgcliente.Text = "" Then
            MessageBox.Show("Insira o RG")
            Me.txt_rgcliente.Focus()
            Exit Sub
        ElseIf Me.radio_clienteF.Checked = False And Me.raidio_clienteM.Checked = False Then
            MessageBox.Show("Selecione o Sexo")
            Exit Sub
        ElseIf Me.txt_dtnascclient.Text = "  /  /" Then
            MessageBox.Show("Insira a data de Nascimento")
            Me.txt_dtnascclient.Focus()
            Exit Sub
        ElseIf Me.txt_cep_client.Text = "     -" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_client.Focus()
            Exit Sub
        ElseIf Me.txt_n_client.Text = "" Then
            MessageBox.Show("Informe o Numero da Residencia", "Obrigatório")
            Me.txt_n_client.Focus()
            Exit Sub
        ElseIf Me.txt_dtabertura_client.Text = "  /  /" Then
            MessageBox.Show("Insira a data de hoje")
            Me.txt_dtabertura_client.Focus()
            Exit Sub
        End If

        drDados = estadoCivil.CarregaCodEC(Me.Combo_ecivil.Text)
        If drDados.Read = True Then
            ec = CStr(drDados("ec_cod_estado_civil"))
        End If


        If Me.radio_clienteF.Checked = True Then
            sex = "F"
        Else
            sex = "M"
        End If



        Dim Cliente As New cldCliente 'Cria obj para Gravar ou Alterar
        With Cliente 'Passa os campos para a classe clnAgenda
            .cl_Nome = Trim(Me.txt_nomecliente.Text)
            .cl_Celular = Trim(Me.txt_cel_client.Text)
            .cl_CEP = Trim(Me.txt_cep_client.Text)
            .cl_Complemento = Trim(Me.txt_complent_client.Text)
            .cl_CPF = Trim(Me.txt_cpfcliente_cadastr.Text)
            .cl_Data_cadastro = Trim(Me.txt_dtabertura_client.Text)
            .cl_Data_nascimento = Trim(Me.txt_dtnascclient.Text)
            .cl_DDD = Trim(Me.txt_dddtel_client.Text)
            .cl_DDD2 = Trim(Me.txt_dddcel_client.Text)
            .cl_Email = Trim(Me.txt_email_cliente.Text)
            .cl_Estado_civil = ec
            .cl_Nome_mae = Trim(Me.txt_nomemae_client.Text)
            .cl_Numero = Trim(Me.txt_n_client.Text)
            .cl_RG = Trim(Me.txt_rgcliente.Text)
            .cl_Sexo = sex.ToString
            .cl_Telefone = Trim(Me.txt_tel_client.Text)
            'Trim retira os espaços
        End With
        If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Alteração
            Cliente.cl_Cod_Cliente = CInt(Me.txt_codcliente_cadas.Text)
            Cliente.AlteraCliente()
        End If
        MessageBox.Show("Registro Número " & Me.txt_codcliente_cadas.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_exclui_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exclui_client.Click
        Dim msg As Integer
        Try
            msg = CInt(CStr(MessageBox.Show("Deseja excluir o registro? " & CStr(Me.txt_codcliente_cadas.Text), Me.Text, MessageBoxButtons.YesNo)))

            If CInt(msg) = Windows.Forms.DialogResult.Yes Then
                Dim frmCliente As New Form_principal
                Dim ExcluiCliente As New cldCliente
                ExcluiCliente.ExcluirCliente(CInt(Me.txt_codcliente_cadas.Text)) 'Captura o Código atual e repassa para a Function Excluir
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

    Private Sub btn_cadastra_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_client.Click

        ' Verifica o nome digitado
        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        If txt_nomecliente.Text = "" Then
            MessageBox.Show("Insira o nome do cliente")
            Me.txt_nomecliente.Focus()
            Exit Sub
        ElseIf Me.Combo_ecivil.Text = "Selecionar" Then
            MessageBox.Show("Selecione o estado civil")
            Me.Combo_ecivil.Focus()
            Exit Sub
        ElseIf txt_cpfcliente_cadastr.Text = "   .   .   -" Then
            MessageBox.Show("Insira o nome CPF")
            Me.txt_cpfcliente_cadastr.Focus()
            Exit Sub
        ElseIf Me.txt_rgcliente.Text = "" Then
            MessageBox.Show("Insira o RG")
            Me.txt_rgcliente.Focus()
            Exit Sub
        ElseIf Me.radio_clienteF.Checked = False And Me.raidio_clienteM.Checked = False Then
            MessageBox.Show("Selecione o Sexo")
            Exit Sub
        ElseIf Me.txt_dtnascclient.Text = "  /  /" Then
            MessageBox.Show("Insira a data de Nascimento")
            Me.txt_dtnascclient.Focus()
            Exit Sub
        ElseIf Me.txt_cep_client.Text = "     -" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_client.Focus()
            Exit Sub
        ElseIf Me.txt_n_client.Text = "" Then
            MessageBox.Show("Informe o Numero da Residencia", "Obrigatório")
            Me.txt_n_client.Focus()
            Exit Sub
        ElseIf Me.txt_dtabertura_client.Text = "  /  /" Then
            MessageBox.Show("Insira a data de hoje")
            Me.txt_dtabertura_client.Focus()
            Exit Sub
        End If


        drDados = estadoCivil.CarregaCodEC(Me.Combo_ecivil.Text)
        If drDados.Read = True Then
            ec = CStr(drDados("ec_cod_estado_civil"))
        End If

        If Me.radio_clienteF.Checked = True Then
            sex = "F"
        Else
            sex = "M"
        End If


        Dim Cliente As New cldCliente 'Cria obj para Gravar ou Alterar
        With Cliente 'Passa os campos para a classe clnAgenda
            .cl_Nome = Trim(Me.txt_nomecliente.Text)
            .cl_RG = Trim(Me.txt_rgcliente.Text)
            .cl_CPF = Trim(Me.txt_cpfcliente_cadastr.Text)
            .cl_Data_nascimento = Trim(Me.txt_dtnascclient.Text)
            .cl_Sexo = sex
            .cl_Nome_mae = Trim(Me.txt_nomemae_client.Text)
            .cl_Estado_civil = ec
            .cl_CEP = Trim(Me.txt_cep_client.Text)
            .cl_Numero = Trim(Me.txt_n_client.Text)
            .cl_Complemento = Trim(Me.txt_complent_client.Text)
            .cl_DDD = (Me.txt_dddtel_client.Text)
            .cl_Telefone = Trim(Me.txt_tel_client.Text)
            .cl_DDD2 = (Me.txt_dddcel_client.Text)
            .cl_Celular = Trim(Me.txt_cel_client.Text)
            .cl_Data_cadastro = Trim(Me.txt_dtabertura_client.Text)
            .cl_Email = Trim(Me.txt_email_cliente.Text) 'Trim retira os espaços

        End With
        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            Cliente.CadastraCliente() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = Cliente.CarregaCod(Me.txt_nomecliente.Text) 'Através do nome procura o novo código
            drDados = Cliente.CarregaCod(Me.txt_cel_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_cep_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_complent_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_cpfcliente_cadastr.Text)
            drDados = Cliente.CarregaCod(Me.txt_dddcel_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_dddtel_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_dtabertura_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_dtnascclient.Text)
            drDados = Cliente.CarregaCod(Me.txt_n_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_nomecliente.Text)
            drDados = Cliente.CarregaCod(Me.txt_nomemae_client.Text)
            drDados = Cliente.CarregaCod(Me.txt_rgcliente.Text)
            drDados = Cliente.CarregaCod(Me.txt_tel_client.Text)
            drDados = Cliente.CarregaCod(Me.Combo_ecivil.Text)
            drDados = Cliente.CarregaCod(Me.txt_email_cliente.Text)
            If drDados.Read Then
                Me.txt_codcliente_cadas.Text = CStr(drDados("cl_Cod_Cliente"))
                'Preenche o novo Código
            End If
        End If
        MessageBox.Show("Registro Número " & Me.txt_codcliente_cadas.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        '===================================
    End Sub

    Private Sub btn_cadastra_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_end.Click
        Dim frmcadasend As New Form_cadastra_endereco
        Me.txt_rua_client.Text = frmcadasend.txt_lograd_endereco.Text
        Me.txt_cep_client.Text = frmcadasend.txt_cep_endereco.Text
        Me.txt_cidad_client.Text = frmcadasend.txt_cidade_endereco.Text
        Me.txt_bairro_client.Text = frmcadasend.txt_bairro_endereco.Text
        Me.Combo_uf_client.Text = frmcadasend.Combo_uf_end.Text
        frmcadasend.ShowDialog()

    End Sub

    Private Sub btn_carregacep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregacep.Click

        Dim EnderecoCliente As New cldEndereco 'Cria obj classe Agenda
        drDados = EnderecoCliente.CarregaCEPgeral(txt_cep_client.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_rua_client.Text = CStr(drDados("end_Logradouro"))
            Me.txt_bairro_client.Text = CStr(drDados("end_Bairro"))
            Me.txt_cidad_client.Text = CStr(drDados("end_Cidade"))
            Me.Combo_uf_client.Text = CStr(drDados("end_UF"))
            Me.txt_n_client.Text = String.Empty
            Me.txt_complent_client.Text = String.Empty
            Exit Sub

        ElseIf Me.txt_cep_client.Text = "     -" Then
            MessageBox.Show("Insira o CEP")
            Me.txt_cep_client.Focus()
            Exit Sub
        Else
            MessageBox.Show("Endereço não Cadastrado")
            Exit Sub
        End If

    End Sub

    Private Sub Form_cadastra_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim estcivil As Integer
        Dim EnderecoCliente As New cldEndereco
        Dim CarregadadoEnd As New cldEndereco 'Cria obj classe Agenda

        'Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        'drDados = cliente.ListarCliente(txt_cpf_cliente.Text) 'Chama o ListarUsuario informando o Código
        Dim CarregadadoClient As New cldCliente 'Cria obj classe Agenda

        drDados = CarregadadoClient.ListarCodClient(Me.txt_codcliente_cadas.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            'Converte para String e preenche o campo nome
            'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_nomecliente.Text = CStr(drDados("cl_Nome"))
            Me.txt_cel_client.Text = CStr(drDados("cl_Celular"))
            Me.txt_cpfcliente_cadastr.Text = CStr(drDados("cl_CPF"))
            Me.txt_dtabertura_client.Text = CStr(drDados("cl_Data_Cadastro"))
            Me.txt_dtnascclient.Text = CStr(drDados("cl_Data_nascimento"))
            Me.txt_dddcel_client.Text = CStr(drDados("cl_DDD2"))
            Me.txt_dddtel_client.Text = CStr(drDados("cl_DDD"))
            estcivil = CInt(drDados("cl_Estado_civil"))
            Me.txt_n_client.Text = CStr(drDados("cl_Numero"))
            Me.txt_rgcliente.Text = CStr(drDados("cl_RG"))
            sex = CStr(drDados("cl_Sexo"))
            Me.txt_tel_client.Text = CStr(drDados("cl_Telefone"))
            Me.txt_cep_client.Text = CStr(drDados("cl_CEP"))
            Me.txt_nomemae_client.Text = CStr(drDados("cl_Nome_mae"))
            Me.txt_complent_client.Text = CStr(drDados("cl_Complemento"))
            Me.txt_email_cliente.Text = CStr(drDados("cl_Email"))
        End If

        drDados = estadoCivil.CarregaDescricaoEC(estcivil)
        If drDados.Read = True Then
            Me.Combo_ecivil.Text = CStr(drDados("ec_descricao_estado_civil"))
        End If


        If sex = "F" Then
            Me.radio_clienteF.Checked = True

        ElseIf sex = "M" Then
            Me.raidio_clienteM.Checked = True
        End If


        Dim endDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        endDados = EnderecoCliente.CarregaCEP(txt_cep_client.Text) 'Chama o ListarUsuario informando o Código
        If endDados.Read = True Then
            Me.txt_rua_client.Text = CStr(endDados("end_Logradouro"))
            Me.txt_bairro_client.Text = CStr(endDados("end_Bairro"))
            Me.txt_cidad_client.Text = CStr(endDados("end_Cidade"))
            Me.Combo_uf_client.Text = CStr(endDados("end_UF"))
        End If
    End Sub

End Class