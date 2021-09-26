<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_mudarSenha_login = New System.Windows.Forms.Button
        Me.btn_entrar_login = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_senha_login = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_login_login = New System.Windows.Forms.TextBox
        Me.txt_perfil_login = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Insira seu Login e Senha de Usuario"
        '
        'btn_mudarSenha_login
        '
        Me.btn_mudarSenha_login.Location = New System.Drawing.Point(197, 385)
        Me.btn_mudarSenha_login.Name = "btn_mudarSenha_login"
        Me.btn_mudarSenha_login.Size = New System.Drawing.Size(102, 23)
        Me.btn_mudarSenha_login.TabIndex = 17
        Me.btn_mudarSenha_login.Text = "Alterar Senha"
        Me.btn_mudarSenha_login.UseVisualStyleBackColor = True
        '
        'btn_entrar_login
        '
        Me.btn_entrar_login.Location = New System.Drawing.Point(79, 385)
        Me.btn_entrar_login.Name = "btn_entrar_login"
        Me.btn_entrar_login.Size = New System.Drawing.Size(112, 23)
        Me.btn_entrar_login.TabIndex = 15
        Me.btn_entrar_login.Text = "Entrar"
        Me.btn_entrar_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Senha:"
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_login.Location = New System.Drawing.Point(122, 332)
        Me.txt_senha_login.MaxLength = 8
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_login.Size = New System.Drawing.Size(153, 20)
        Me.txt_senha_login.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Login:"
        '
        'txt_login_login
        '
        Me.txt_login_login.Location = New System.Drawing.Point(122, 303)
        Me.txt_login_login.MaxLength = 22
        Me.txt_login_login.Name = "txt_login_login"
        Me.txt_login_login.Size = New System.Drawing.Size(153, 20)
        Me.txt_login_login.TabIndex = 11
        '
        'txt_perfil_login
        '
        Me.txt_perfil_login.FormattingEnabled = True
        Me.txt_perfil_login.Items.AddRange(New Object() {"ADMINISTRADOR", "FUNCIONARIO"})
        Me.txt_perfil_login.Location = New System.Drawing.Point(122, 358)
        Me.txt_perfil_login.MaxLength = 13
        Me.txt_perfil_login.Name = "txt_perfil_login"
        Me.txt_perfil_login.Size = New System.Drawing.Size(153, 21)
        Me.txt_perfil_login.TabIndex = 20
        Me.txt_perfil_login.Text = "Selecionar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Perfil:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Projeto_ADRJ2.My.Resources.Resources.music
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 270)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 482)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_perfil_login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_mudarSenha_login)
        Me.Controls.Add(Me.btn_entrar_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login_login)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_login"
        Me.Text = "Bem Vindo ao ADRJ² 2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_mudarSenha_login As System.Windows.Forms.Button
    Friend WithEvents btn_entrar_login As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_senha_login As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_login_login As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_perfil_login As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
