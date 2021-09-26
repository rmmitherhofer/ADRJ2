Public Class form_login
    Dim frmprincipal As New Form_principal
    Dim senha, validasenha, login, validalogin, local, validalocal, NomeFun As String
    Dim CodFun As Integer

    Private Sub btn_entrar_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar_login.Click
        Dim Funcionario As New cldFuncionario
        Dim drDados As System.Data.SqlClient.SqlDataReader

        login = Me.txt_login_login.Text
        senha = Me.txt_senha_login.Text
        local = Me.txt_perfil_login.Text

        If login = "" Then
            MessageBox.Show("Insira o Login")
            Me.txt_login_login.Focus()
            Exit Sub
        ElseIf senha = "" Then
            MessageBox.Show("Insira a Senha")
            Me.txt_senha_login.Focus()
            Exit Sub
        ElseIf local = "Selecionar" Then
            MessageBox.Show("Selecione o Perfil")
            Me.txt_perfil_login.Focus()
            Exit Sub
        End If

        'drDados = Funcionario.ValidaFuncLogin(Me.txt_login_login.Text)
       ' If drDados.Read Then
           ' validalogin = CStr(drDados("fun_Login"))
          '  validasenha = CStr(drDados("fun_Senha"))
           ' validalocal = CStr(drDados("fun_LocalHost"))
           ' CodFun = CStr(drDados("fun_Cod_Funcionario"))
           ' NomeFun = CStr(drDados("fun_Nome"))
      '  Else
         '   MessageBox.Show("Login Invalido")
          '  Me.txt_login_login.Text = String.Empty
          '  Me.txt_senha_login.Text = String.Empty
           ' Me.txt_perfil_login.Text = "Selecionar"
           ' Me.txt_login_login.Focus()
           ' Exit Sub
        'End If
        'If validasenha = senha Then
        'Else
        '    MessageBox.Show("Senha Incorreta")
         '   Me.txt_senha_login.Text = String.Empty
         '   Me.txt_perfil_login.Text = "Selecionar"
         '   Me.txt_senha_login.Focus()
         '   Exit Sub
        'End If
        'If validalocal = local Then
        'Else
        '    MessageBox.Show("Perfil Incorreto")
         '   Me.txt_perfil_login.Focus()
         '   Exit Sub
        'End If


        If local = "ADMINISTRADOR" Then
            frmprincipal.tab_adm.Enabled = True
            frmprincipal.tab_adm.Enabled = True
            frmprincipal.tab_func.Enabled = True
            frmprincipal.btn_Edita_estoq.Visible = True
            frmprincipal.txt_codfunc_venda.Text = CodFun
            MessageBox.Show("Bem Vindo, " & NomeFun & " você tem total acesso ao ADRJ² 2.0")
            Me.txt_login_login.Text = String.Empty
            Me.txt_senha_login.Text = String.Empty
            Me.txt_perfil_login.Text = String.Empty
            frmprincipal.txt_cpf_cliente.Focus()
            frmprincipal.ShowDialog()

        Else
            frmprincipal.tab_adm.Enabled = False
            frmprincipal.tab_func.Enabled = False
            frmprincipal.btn_Edita_estoq.Visible = False
            frmprincipal.txt_codfunc_venda.Text = CodFun
            MessageBox.Show("Bem Vindo " & NomeFun & "!!!")
            Me.txt_login_login.Text = String.Empty
            Me.txt_senha_login.Text = String.Empty
            Me.txt_perfil_login.Text = String.Empty
            frmprincipal.txt_cpf_cliente.Focus()
            frmprincipal.ShowDialog()
        End If
        frmprincipal.ShowDialog()
    End Sub

    Private Sub btn_mudarSenha_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mudarSenha_login.Click
        Form_alterar_senha.ShowDialog()
    End Sub

    Private Sub form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class



