Public Class Form_cadastro_filial
    Dim drDados As System.Data.SqlClient.SqlDataReader
    Dim _operacao As clnFuncoesGerais1.Operacao 'Guarda a operação


    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_cadastra_cep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_cep.Click
        Dim formcadasend As New Form_cadastra_endereco
        formcadasend.ShowDialog()
        Me.txt_rua_filial.Text = formcadasend.txt_lograd_endereco.Text
        Me.txt_bairro_filial.Text = formcadasend.txt_bairro_endereco.Text
        Me.txt_cidade_filial.Text = formcadasend.txt_cidade_endereco.Text
        Me.txt_cep_filial.Text = formcadasend.txt_cep_endereco.Text
        Me.Combo_uf_filial.Text = formcadasend.Combo_uf_end.Text
        Me.txt_n_filial.Text = String.Empty
        Me.txt_complemento_filial.Text = String.Empty
        formcadasend.ShowDialog()
    End Sub

    Private Sub btn_carrega_cep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carrega_cep.Click
        If Me.txt_cep_filial.Text = "     -" Then
            MessageBox.Show("Insira o CEP")
            Me.txt_cep_filial.Focus()
            Exit Sub
        End If
        Dim Enderecofunc As New cldEndereco 'Cria obj classe Agenda
        drDados = Enderecofunc.CarregaCEPgeral(Me.txt_cep_filial.Text) 'Chama o ListarUsuario informando o Código
        If drDados.Read = True Then 'Se houver dados preenche (CONSULTAR OU ALTERAR)
            Me.txt_rua_filial.Text = CStr(drDados("end_Logradouro"))
            Me.txt_bairro_filial.Text = CStr(drDados("end_Bairro"))
            Me.txt_cidade_filial.Text = CStr(drDados("end_Cidade"))
            Me.Combo_uf_filial.Text = CStr(drDados("end_UF"))
            Me.txt_n_filial.Text = String.Empty
            Me.txt_complemento_filial.Text = String.Empty
        Else
            MessageBox.Show("Endereço não esta Cadastrado")
            Exit Sub
        End If
    End Sub

    Private Sub btn_volta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volta.Click
        Me.Close()
    End Sub

    Private Sub btn_cadastra_filial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra_filial.Click
        ' Verifica o nome digitado
        _operacao = clnFuncoesGerais1.Operacao.Inclusao
        If Me.txt_nome_filial.Text = "" Then
            MessageBox.Show("Insira o Nome da filial")
            Me.txt_nome_filial.Focus()
            Exit Sub
        ElseIf Me.txt_dddtel_filial.Text = "(  )" And Me.txt_tel_filial.Text = "    -" Then
            MessageBox.Show("insira o DDD e o telefone")
            Me.txt_dddtel_filial.Focus()
            Exit Sub
        ElseIf Me.txt_cep_filial.Text = "" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_filial.Focus()
            Exit Sub
        ElseIf Me.txt_n_filial.Text = "" Then
            MessageBox.Show("Informe o Numero da Residencia", "Obrigatório")
            Me.txt_n_filial.Focus()
            Exit Sub
        ElseIf Me.txt_hora_filial.Text = "" Then
            MessageBox.Show("Insira o horario de funcionamento")
            Me.txt_hora_filial.Focus()
            Exit Sub

        End If




        Dim Filial As New cldFilial 'Cria obj para Gravar ou Alterar
        With Filial 'Passa os campos para a classe clnAgenda
            .fil_CEP = Trim(Me.txt_cep_filial.Text)
            .fil_CNPJ = Trim(Me.txt_cnpj_fil.Text)
            .fil_Complemento = Trim(Me.txt_complemento_filial.Text)
            .fil_DDD = Trim(Me.txt_dddtel_filial.Text)
            .fil_Horarios = Trim(Me.txt_hora_filial.Text)
            .fil_Nome = Trim(Me.txt_nome_filial.Text)
            .fil_Numero = Trim(Me.txt_n_filial.Text)
            .fil_Telefone = Trim(Me.txt_tel_filial.Text)

        End With

        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            Filial.CadastraFilial() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = Filial.CarregaCodFilial(Me.txt_nome_filial.Text)


            If drDados.Read Then
                Me.txt_cod_filial.Text = CStr(drDados("fil_cod_filial"))
                'Preenche o novo Código
            End If
        End If
        MessageBox.Show("Registro Número " & Me.txt_cod_filial.Text & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub
End Class