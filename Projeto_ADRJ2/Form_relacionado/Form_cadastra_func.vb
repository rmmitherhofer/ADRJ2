Public Class Form_cadastra_func
    Dim estadoCivil As New cldEstadoCivil
    Dim CLDescolaridade As New cldEscolaridade
    Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação
    Dim _nome As String
    Dim ec, escola As Integer
    Dim sex As String
    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub Form_cadastra_func_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim EnderecoFunc As New cldEndereco
        Dim CarregadadoEnd As New cldEndereco 'Cria obj classe Agenda

        'Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        'drDados = cliente.ListarCliente(txt_cpf_cliente.Text) 'Chama o ListarUsuario informando o Código
        Dim CarregadadoFunc As New cldFuncionario 'Cria obj classe Agenda
        Dim drDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
        drDados = CarregadadoFunc.ListarCodFUN(Me.txt_cod_func.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read Then 'Se houver dados preenche (CONSULTAR OU ALTERAR) 'Chama o ListarUsuario informando o Código

            'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_cargo_func.Text = CStr(drDados("fun_Cargo"))
            Me.txt_cep_func.Text = CStr(drDados("fun_CEP"))
            Me.txt_cel_func.Text = CStr(drDados("fun_Celular"))
            Me.txt_complemento_func.Text = CStr(drDados("fun_Complemento"))
            ec = CInt(drDados("fun_Estado_civil"))
            Me.txt_situacao_func.Text = CStr(drDados("fun_Situação_escolar"))
            Me.txt_cpf_func.Text = CStr(drDados("fun_CPF"))
            sex = CStr(drDados("fun_Sexo"))
            Me.txt_ctps_func.Text = CStr(drDados("fun_CTPS"))
            Me.txt_curso_func.Text = CStr(drDados("fun_Cursos"))
            Me.txt_dt_admissao_func.Text = CStr(drDados("fun_Data_admissao"))
            Me.txt_dt_dispensa_func.Text = CStr(drDados("fun_Data_Dispensa"))
            Me.txt_dtnasc_func.Text = CStr(drDados("fun_Data_nascimento"))
            Me.txt_dddcel_func.Text = CStr(drDados("fun_DDD2"))
            Me.txt_dddtel_func.Text = CStr(drDados("fun_DDD"))
            escola = CStr(drDados("fun_Grau_escolaridade"))
            Me.txt_filial_func.Text = CStr(drDados("fun_Filial"))
            Me.txt_n_func.Text = CStr(drDados("fun_Numero"))
            Me.txt_nome_func.Text = CStr(drDados("fun_Nome"))
            Me.txt_escola_func.Text = CStr(drDados("fun_Nome_Escola"))
            Me.txt_mae_func.Text = CStr(drDados("fun_Nome_mae"))
            Me.txt_rg_func.Text = CStr(drDados("fun_RG"))
            Me.txt_salario_func.Text = CStr(drDados("fun_Salario"))
            Me.txt_serie_func.Text = CStr(drDados("fun_Serie"))
            Me.txt_tel_func.Text = CStr(drDados("fun_Telefone"))
            Me.txt_cpf_func.Text = CStr(drDados("fun_CPF"))
            Me.txt_email_func.Text = CStr(drDados("fun_Email"))
            Me.txt_login_func.Text = CStr(drDados("fun_Login"))
            Me.txt_senha_func.Text = CStr(drDados("fun_Senha"))
            Me.Combo_localhost_fun.Text = CStr(drDados("fun_localhost"))

            Dim endDados As System.Data.SqlClient.SqlDataReader 'Cria obj DataReader (DR)
            endDados = EnderecoFunc.CarregaCEPFunc(txt_cep_func.Text) 'Chama o ListarUsuario informando o Código
            If endDados.Read = True Then
                Me.txt_rua_func.Text = CStr(endDados("end_Logradouro"))
                Me.txt_bairro_func.Text = CStr(endDados("end_Bairro"))
                Me.txt_cidade_func.Text = CStr(endDados("end_Cidade"))
                Me.combo_uf_func.Text = CStr(endDados("end_UF"))
            End If

            drDados = estadoCivil.CarregaDescricaoEC(ec)
            If drDados.Read = True Then
                Me.Combo_ecivil_func.Text = CStr(drDados("ec_descricao_estado_civil"))
            End If

            drDados = CLDescolaridade.CarregaDescricaoEscol(escola)
            If drDados.Read = True Then
                Me.Combo_escolarid_func.Text = CStr(drDados("es_escolaridade"))
            End If

            If sex = "M" Then
                Me.Radio_funcM.Checked = True
            Else
                Me.Radio_funcF.Checked = True
            End If
        End If
    End Sub

    Private Sub btn_carega_cep_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carega_cep_func.Click

        If Me.txt_cep_func.Text = "     -" Then
            MessageBox.Show("Insira o CEP")
            Me.txt_cep_func.Focus()
            Exit Sub
        End If
        Dim Enderecofunc As New cldEndereco 'Cria obj classe Agenda
        drDados = Enderecofunc.CarregaCEPgeral(txt_cep_func.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_rua_func.Text = CStr(drDados("end_Logradouro"))
            Me.txt_bairro_func.Text = CStr(drDados("end_Bairro"))
            Me.txt_cidade_func.Text = CStr(drDados("end_Cidade"))
            Me.combo_uf_func.Text = CStr(drDados("end_UF"))
            Me.txt_n_func.Text = String.Empty
            Me.txt_complemento_func.Text = String.Empty
        Else
            MessageBox.Show("Endereço não esta Cadastrado")
            Exit Sub
        End If

    End Sub

    Private Sub btn_edita_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edita_func.Click
        Me.boxFunCadas.Enabled = True
        txt_nome_func.Enabled = False
        txt_bairro_func.Enabled = False
        txt_cidade_func.Enabled = False
        txt_bairro_func.Enabled = False
        txt_cod_func.Enabled = False
        txt_cpf_func.Enabled = False
        txt_ctps_func.Enabled = False
        txt_dt_admissao_func.Enabled = False
        txt_dtnasc_func.Enabled = False
        txt_mae_func.Enabled = False
        txt_rg_func.Enabled = False
        txt_rua_func.Enabled = False
        txt_serie_func.Enabled = False

        btn_atualiza_func.Visible = True
        btn_cadastra_end.Visible = True
        btn_exclui_func.Visible = True
        btn_carega_cep_func.Visible = True

        Radio_funcF.Enabled = False
        Radio_funcM.Enabled = False
        combo_uf_func.Enabled = False
    End Sub

    Private Sub btn_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta.Click
        Me.Close()
    End Sub

    Private Sub btn_atualiza_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atualiza_func.Click
        ' Verifica o nome digitado
        'Criar a classe clnFuncoesGerais
        _operacao = clnFuncoesGerais1.Operacao.Alteracao 'Informa que é inclusão
        ' CarregaGrid()

        If Me.txt_cep_func.Text = "" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_func.Focus()
            Exit Sub
        ElseIf Me.Combo_ecivil_func.Text = "" Then
            MessageBox.Show("Selecione o Estado Civil", "Obrigatório")
            Exit Sub
        ElseIf Me.txt_n_func.Text = "" Then
            MessageBox.Show("Informe o Numero da Residencia", "Obrigatório")
            Me.txt_n_func.Focus()
            Exit Sub
        End If

        drDados = estadoCivil.CarregaCodEC(Me.Combo_ecivil_func.Text)
        If drDados.Read = True Then
            ec = CStr(drDados("ec_cod_estado_civil"))
        End If

        drDados = CLDescolaridade.CarregaCodEscol(Me.Combo_escolarid_func.Text)
        If drDados.Read = True Then
            escola = CStr(drDados("es_cod_Escolaridade"))
        End If

        If Me.Radio_funcF.Checked = True Then
            sex = "F"
        Else
            sex = "M"
        End If



        Dim FUNCIONARIO As New cldFuncionario 'Cria obj para Gravar ou Alterar
        With FUNCIONARIO 'Passa os campos para a classe clnAgenda

            'Trim retira os espaços

            .fun_Nome = Trim(Me.txt_nome_func.Text)
            .fun_RG = Trim(Me.txt_rg_func.Text)
            .fun_CPF = Trim(Me.txt_cpf_func.Text)
            .fun_Data_nascimento = Trim(Me.txt_dtnasc_func.Text)
            .fun_Sexo = sex
            .fun_Nome_mae = Trim(Me.txt_mae_func.Text)
            .fun_Estado_civil = ec
            .fun_CEP = Trim(Me.txt_cep_func.Text)
            .fun_Numero = Trim(Me.txt_n_func.Text)
            .fun_Complemento = Trim(Me.txt_complemento_func.Text)
            .fun_Grau_escolaridade = escola
            .fun_Situação_escolar = Trim(Me.txt_situacao_func.Text)
            .fun_Nome_Escola = Trim(Me.txt_escola_func.Text)
            .fun_Cursos = Trim(Me.txt_curso_func.Text)
            .fun_CTPS = Trim(Me.txt_ctps_func.Text)
            .fun_Serie = Trim(Me.txt_serie_func.Text)
            .fun_DDD = (Me.txt_dddtel_func.Text)
            .fun_Telefone = Trim(Me.txt_tel_func.Text)
            .fun_DDD2 = (Me.txt_dddcel_func.Text)
            .fun_Celular = Trim(Me.txt_cel_func.Text)
            .fun_Cargo = Trim(Me.txt_cargo_func.Text)
            .fun_Data_admissao = Trim(Me.txt_dt_admissao_func.Text)
            .fun_Data_Dispensa = Trim(Me.txt_dt_dispensa_func.Text)
            .fun_Filial = Trim(Me.txt_filial_func.Text)
            .fun_Salario = Trim(Me.txt_salario_func.Text)
            .fun_Email = Trim(Me.txt_email_func.Text)
            .fun_Login = Trim(Me.txt_login_func.Text)
            .fun_Senha = Trim(Me.txt_senha_func.Text)
            .fun_localhost = Trim(Me.Combo_localhost_fun.Text)
        End With

        If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then 'Alteração
            FUNCIONARIO.fun_Cod_Funcionario = CInt(Me.txt_cod_func.Text)
            FUNCIONARIO.AlteraFuncionario()
        End If
        MessageBox.Show("Registro Número " & Me.txt_cod_func.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn_exclui_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exclui_func.Click
        Dim msg As Integer
        Try
            msg = CInt(CStr(MessageBox.Show("Deseja excluir o registro? " & CStr(Me.txt_cod_func.Text), Me.Text, MessageBoxButtons.YesNo)))
            If CInt(msg) = Windows.Forms.DialogResult.Yes Then
                Dim ExcluiFuncionario As New cldFuncionario
                ExcluiFuncionario.ExcluiFun(CInt(Me.txt_cod_func.Text)) 'Captura o Código atual e repassa para a Function Excluir
                MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'CarregaGrid()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro, talvez não foi definido nenhum valor para exclusão")
        End Try
    End Sub

    Private Sub btn_cadastra_func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_func.Click
        ' Verifica o nome digitado
        _operacao = clnFuncoesGerais1.Operacao.Inclusao

        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        If txt_nome_func.Text = "" Then
            MessageBox.Show("Insira o nome do cliente")
            Me.txt_nome_func.Focus()
            Exit Sub
        ElseIf Me.Combo_ecivil_func.Text = "Selecionar" Then
            MessageBox.Show("Selecione o estado civil")
            Me.Combo_ecivil_func.Focus()
            Exit Sub
        ElseIf txt_cpf_func.Text = "   .   .   -" Then
            MessageBox.Show("Insira o nome CPF")
            Me.txt_cpf_func.Focus()
            Exit Sub
        ElseIf Me.txt_rg_func.Text = "" Then
            MessageBox.Show("Insira o RG")
            Me.txt_rg_func.Focus()
            Exit Sub
        ElseIf Me.Radio_funcF.Checked = False And Me.Radio_funcM.Checked = False Then
            MessageBox.Show("Selecione o Sexo")
            Exit Sub
        ElseIf Me.txt_dtnasc_func.Text = "  /  /" Then
            MessageBox.Show("Insira a data de Nascimento")
            Me.txt_dtnasc_func.Focus()
            Exit Sub
        ElseIf Me.Combo_escolarid_func.Text = "Selecionar" Then
            MessageBox.Show("Insira a Escolaridade")
            Me.Combo_escolarid_func.Focus()
            Exit Sub
        ElseIf Me.txt_situacao_func.Text = "Selecionar" Then
            MessageBox.Show("Insira o Status escolar")
            Me.txt_situacao_func.Focus()
            Exit Sub
        ElseIf Me.txt_escola_func.Text = "" Then
            MessageBox.Show("Insira o Nome da escola")
            Me.txt_escola_func.Focus()
            Exit Sub
        ElseIf Me.txt_ctps_func.Text = "" Then
            MessageBox.Show("Insira o numero da carteira de trabalho")
            Me.txt_ctps_func.Focus()
            Exit Sub
        ElseIf Me.txt_serie_func.Text = "" Then
            MessageBox.Show("Insira a série da carteira de trabalho")
            Me.txt_serie_func.Focus()
            Exit Sub
        ElseIf Me.txt_cep_func.Text = "     -" Then
            MessageBox.Show("Insira o CEP")
            Me.txt_cep_func.Focus()
            Exit Sub
        ElseIf Me.txt_n_func.Text = "" Then
            MessageBox.Show("Informe o Numero da Residencia", "Obrigatório")
            Me.txt_n_func.Focus()
            Exit Sub
        ElseIf Me.txt_filial_func.Text = "" Then
            MessageBox.Show("Informe a filial que o contratado ira trabalhar")
            Me.txt_filial_func.Focus()
            Exit Sub
        ElseIf Me.txt_cargo_func.Text = "" Then
            MessageBox.Show("Informe o cargo")
            Me.txt_cargo_func.Focus()
            Exit Sub
        ElseIf Me.txt_salario_func.Text = "" Then
            MessageBox.Show("Informe o Sálario, somente numeros")
            Me.txt_salario_func.Focus()
            Exit Sub
        ElseIf Me.txt_login_func.Text = "" Then
            MessageBox.Show("Informe o Login de Usuario")
            Me.txt_login_func.Focus()
            Exit Sub
        ElseIf Me.txt_senha_func.Text = "" Then
            MessageBox.Show("Informe a Senha de Usuario")
            Me.txt_senha_func.Focus()
            Exit Sub
        ElseIf Me.Combo_localhost_fun.Text = "Selecionar" Then
            MessageBox.Show("Informe o tipo de Usuario")
            Me.Combo_localhost_fun.Focus()
            Exit Sub
        ElseIf Me.txt_dt_admissao_func.Text = "  /  /" Then
            MessageBox.Show("Insira a data de hoje")
            Me.txt_dt_admissao_func.Focus()
            Exit Sub
        End If



        drDados = estadoCivil.CarregaCodEC(Me.Combo_ecivil_func.Text)
        If drDados.Read = True Then
            ec = CStr(drDados("ec_cod_estado_civil"))
        End If

        drDados = CLDescolaridade.CarregaCodEscol(Me.Combo_escolarid_func.Text)
        If drDados.Read = True Then
            escola = CStr(drDados("es_cod_Escolaridade"))
        End If

        If Me.Radio_funcF.Checked = True Then
            sex = "F"
        Else
            sex = "M"
        End If




        Dim newFunc As New cldFuncionario 'Cria obj para Gravar ou Alterar
        With newFunc 'Passa os campos para a classe clnAgenda
            .fun_Nome = Trim(Me.txt_nome_func.Text)
            .fun_RG = Trim(Me.txt_rg_func.Text)
            .fun_CPF = Trim(Me.txt_cpf_func.Text)
            .fun_Data_nascimento = Trim(Me.txt_dtnasc_func.Text)
            .fun_Sexo = sex
            .fun_Nome_mae = Trim(Me.txt_mae_func.Text)
            .fun_Estado_civil = ec
            .fun_CEP = Trim(Me.txt_cep_func.Text)
            .fun_Numero = Trim(Me.txt_n_func.Text)
            .fun_Complemento = Trim(Me.txt_complemento_func.Text)
            .fun_Grau_escolaridade = escola
            .fun_Situação_escolar = Trim(Me.txt_situacao_func.Text)
            .fun_Nome_Escola = Trim(Me.txt_escola_func.Text)
            .fun_Cursos = Trim(Me.txt_curso_func.Text)
            .fun_CTPS = Trim(Me.txt_ctps_func.Text)
            .fun_Serie = Trim(Me.txt_serie_func.Text)
            .fun_DDD = (Me.txt_dddtel_func.Text)
            .fun_Telefone = Trim(Me.txt_tel_func.Text)
            .fun_DDD2 = (Me.txt_dddcel_func.Text)
            .fun_Celular = Trim(Me.txt_cel_func.Text)
            .fun_Cargo = Trim(Me.txt_cargo_func.Text)
            .fun_Data_admissao = Trim(Me.txt_dt_admissao_func.Text)
            .fun_Data_Dispensa = Trim(Me.txt_dt_dispensa_func.Text)
            .fun_Filial = Trim(Me.txt_filial_func.Text)
            .fun_Salario = Trim(Me.txt_salario_func.Text)
            .fun_Email = Trim(Me.txt_email_func.Text)
            .fun_Login = Trim(Me.txt_login_func.Text)
            .fun_Senha = Trim(Me.txt_senha_func.Text)
            .fun_localhost = Trim(Me.Combo_localhost_fun.Text)
        End With

        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            newFunc.CadastraFun() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = newFunc.CarregaCodfUN(Me.txt_nome_func.Text)


            If drDados.Read Then
                Me.txt_cod_func.Text = CStr(drDados("fun_Cod_Funcionario"))
                'Preenche o novo Código
            End If
        End If
        MessageBox.Show("Registro Número " & Me.txt_cod_func.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub btn_cadastra_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_end.Click
        Dim formcadasend As New Form_cadastra_endereco
        formcadasend.ShowDialog()
        Me.txt_rua_func.Text = formcadasend.txt_lograd_endereco.Text
        Me.txt_bairro_func.Text = formcadasend.txt_bairro_endereco.Text
        Me.txt_cidade_func.Text = formcadasend.txt_cidade_endereco.Text
        Me.txt_cep_func.Text = formcadasend.txt_cep_endereco.Text
        Me.combo_uf_func.Text = formcadasend.Combo_uf_end.Text
        Me.txt_n_func.Text = String.Empty
        Me.txt_complemento_func.Text = String.Empty
        formcadasend.ShowDialog()
    End Sub
End Class