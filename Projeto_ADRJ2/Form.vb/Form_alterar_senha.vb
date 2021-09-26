Public Class Form_alterar_senha
    Dim _operacao As clnFuncoesGerais1.Operacao
    Dim senha, login, novasenha, confirmasenha, validaSenha, validaLogin As String
    Dim codFun, msg As Integer
    Dim Funcionario As New cldFuncionario
    Dim drDados As System.Data.SqlClient.SqlDataReader

    Public Property operacao() As clnFuncoesGerais1.Operacao
        Get
            Return _operacao 'Saída da Operação
        End Get
        Set(ByVal Value As clnFuncoesGerais1.Operacao)
            _operacao = Value 'Entrada da Operação
        End Set
    End Property

    Private Sub btn_salvar_altersenha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salvar_altersenha.Click

        If Me.txt_Login_altersenha.Text = "" Then
            MessageBox.Show("Insira o Login de Usuario")
            Me.txt_Login_altersenha.Focus()
            Exit Sub
        ElseIf Me.txt_senhaatual_Alter.Text = "" Then
            MessageBox.Show("Insira a Senha Atual")
            Me.txt_senhaatual_Alter.Focus()
            Exit Sub
        ElseIf Me.txt_novasenha_alter.Text = "" Then
            MessageBox.Show("Insira a nova senha")
            Me.txt_novasenha_alter.Focus()
            Exit Sub
        ElseIf Me.txt_confSenha_alter.Text = "" Then
            MessageBox.Show("Confirme a Senha")
            Me.txt_confSenha_alter.Focus()
            Exit Sub
        End If

        login = Me.txt_Login_altersenha.Text
        senha = Me.txt_senhaatual_Alter.Text
        novasenha = Me.txt_novasenha_alter.Text
        confirmasenha = Me.txt_confSenha_alter.Text

        drDados = Funcionario.ValidaFuncLogin(Me.txt_Login_altersenha.Text)
        If drDados.Read Then
            validaLogin = CStr(drDados("fun_Login"))
            validaSenha = CStr(drDados("fun_Senha"))
            codFun = CStr(drDados("fun_Cod_Funcionario"))
        Else
            MessageBox.Show("Login Incorreto")
            Me.txt_Login_altersenha.Text = String.Empty
            Me.txt_Login_altersenha.Focus()
            Exit Sub
        End If

        If senha = validaSenha Then
        Else
            MessageBox.Show("Senha atual incorreta")
            Me.txt_senhaatual_Alter.Focus()
            Exit Sub
        End If

        If novasenha = confirmasenha Then
        Else
            MessageBox.Show("Confirmação Incorreta! verifique a nova senha inserida.")
            Me.txt_confSenha_alter.Focus()
            Exit Sub
        End If
        msg = CInt(CStr(MessageBox.Show("Deseja realmente alterar sua Senha?", Me.Text, MessageBoxButtons.YesNo)))
        If CInt(msg) = Windows.Forms.DialogResult.Yes Then
            _operacao = clnFuncoesGerais1.Operacao.Alteracao

            With Funcionario
                .fun_Senha = novasenha
            End With
            If _operacao = clnFuncoesGerais1.Operacao.Alteracao Then
                Funcionario.fun_Cod_Funcionario = CInt(codFun)
                Funcionario.AlteraSenha()
                MessageBox.Show("Senha Alterada com Sucesso!")
                Me.txt_Login_altersenha.Text = String.Empty
                Me.txt_senhaatual_Alter.Text = String.Empty
                Me.txt_novasenha_alter.Text = String.Empty
                Me.txt_confSenha_alter.Text = String.Empty
                Me.Close()
            End If
        Else
            MessageBox.Show("Alteração Cancelada")
            Me.txt_Login_altersenha.Text = String.Empty
            Me.txt_senhaatual_Alter.Text = String.Empty
            Me.txt_novasenha_alter.Text = String.Empty
            Me.txt_confSenha_alter.Text = String.Empty
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cancel_alter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel_alter.Click
        Me.Close()
    End Sub
End Class