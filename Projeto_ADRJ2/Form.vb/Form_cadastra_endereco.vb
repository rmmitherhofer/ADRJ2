Public Class Form_cadastra_endereco
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

    Private Sub btn_cancela_endereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela_endereco.Click
        MessageBox.Show("Inclusão de Endereço Cancelada")
        Me.Close()
    End Sub

    Private Sub btn_salva_endereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salva_endereco.Click

        Dim msg As Integer
        If Me.txt_cep_endereco.Text = "" Then
            MessageBox.Show("Digite o CEP", "Obrigatório")
            Me.txt_cep_endereco.Focus()
            Exit Sub
        ElseIf Me.txt_bairro_endereco.Text = "" Then
            MessageBox.Show("Informe o Bairro", "Obrigatório")
            txt_bairro_endereco.Focus()
            Exit Sub
        ElseIf Me.txt_cidade_endereco.Text = "" Then
            MessageBox.Show("Informe a Cidade", "Obrigatório")
            Me.txt_cidade_endereco.Focus()
            Exit Sub
        ElseIf Me.txt_lograd_endereco.Text = "" Then
            MessageBox.Show("Informe o Logradouro", "Obrigatório")
            Me.txt_lograd_endereco.Focus()
            Exit Sub
        ElseIf Me.Combo_uf_end.Text = "" Then
            MessageBox.Show("Informe a UF do Estado")
            Me.Combo_uf_end.Focus()
            Exit Sub
        End If


        Dim Endereco As New cldEndereco 'Cria obj para Gravar ou Alterar
        With Endereco 'Passa os campos para a classe clnAgenda
            .end_CEP = Trim(Me.txt_cep_endereco.Text)
            .end_Bairro = Trim(Me.txt_bairro_endereco.Text)
            .end_Cidade = Trim(Me.txt_cidade_endereco.Text)
            .end_Logradouro = Trim(Me.txt_lograd_endereco.Text)
            .end_UF = Trim(Me.Combo_uf_end.Text) 'Trim retira os espaços
        End With

        If _operacao = clnFuncoesGerais1.Operacao.Inclusao Then 'Inclusão
            Endereco.InseriEnd() 'Chama a função de GRAVAR. NÃO utilizamos o código na gravação
            '=========Linha Carregar o Código===========
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = Endereco.CadastraEnd(Me.txt_cep_endereco.Text)
            drDados = Endereco.CadastraEnd(Me.txt_bairro_endereco.Text)
            drDados = Endereco.CadastraEnd(Me.txt_cidade_endereco.Text)
            drDados = Endereco.CadastraEnd(Me.txt_lograd_endereco.Text)
            drDados = Endereco.CadastraEnd(Me.Combo_uf_end.Text)
            'Através do nome procura o novo código
        End If
        '===================================

        msg = CInt(CStr(MessageBox.Show("Endereço Salvo com sucesso!    Deseja Cadastrar um novo Endereço?", Me.Text, MessageBoxButtons.YesNo)))
        If CInt(msg) = Windows.Forms.DialogResult.Yes Then
            Me.txt_cep_endereco.Text = String.Empty
            Me.txt_bairro_endereco.Text = String.Empty
            Me.txt_cidade_endereco.Text = String.Empty
            Me.txt_lograd_endereco.Text = String.Empty
            Me.Combo_uf_end.Text = String.Empty
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Form_cadastra_endereco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class