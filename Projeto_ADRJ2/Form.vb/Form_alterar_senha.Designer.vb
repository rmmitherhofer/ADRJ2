<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_alterar_senha
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
        Me.btn_salvar_altersenha = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Login_altersenha = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_senhaatual_Alter = New System.Windows.Forms.TextBox
        Me.txt_novasenha_alter = New System.Windows.Forms.TextBox
        Me.txt_confSenha_alter = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_Cancel_alter = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_salvar_altersenha
        '
        Me.btn_salvar_altersenha.Location = New System.Drawing.Point(153, 184)
        Me.btn_salvar_altersenha.Name = "btn_salvar_altersenha"
        Me.btn_salvar_altersenha.Size = New System.Drawing.Size(96, 23)
        Me.btn_salvar_altersenha.TabIndex = 7
        Me.btn_salvar_altersenha.Text = "Alterar"
        Me.btn_salvar_altersenha.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "*Login:"
        '
        'txt_Login_altersenha
        '
        Me.txt_Login_altersenha.Location = New System.Drawing.Point(63, 41)
        Me.txt_Login_altersenha.MaxLength = 22
        Me.txt_Login_altersenha.Name = "txt_Login_altersenha"
        Me.txt_Login_altersenha.Size = New System.Drawing.Size(190, 20)
        Me.txt_Login_altersenha.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Informe seu Login para alterar sua Senha"
        '
        'txt_senhaatual_Alter
        '
        Me.txt_senhaatual_Alter.Location = New System.Drawing.Point(125, 79)
        Me.txt_senhaatual_Alter.MaxLength = 8
        Me.txt_senhaatual_Alter.Name = "txt_senhaatual_Alter"
        Me.txt_senhaatual_Alter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senhaatual_Alter.Size = New System.Drawing.Size(128, 20)
        Me.txt_senhaatual_Alter.TabIndex = 12
        '
        'txt_novasenha_alter
        '
        Me.txt_novasenha_alter.Location = New System.Drawing.Point(125, 112)
        Me.txt_novasenha_alter.MaxLength = 8
        Me.txt_novasenha_alter.Name = "txt_novasenha_alter"
        Me.txt_novasenha_alter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_novasenha_alter.Size = New System.Drawing.Size(128, 20)
        Me.txt_novasenha_alter.TabIndex = 13
        '
        'txt_confSenha_alter
        '
        Me.txt_confSenha_alter.Location = New System.Drawing.Point(125, 147)
        Me.txt_confSenha_alter.MaxLength = 8
        Me.txt_confSenha_alter.Name = "txt_confSenha_alter"
        Me.txt_confSenha_alter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confSenha_alter.Size = New System.Drawing.Size(128, 20)
        Me.txt_confSenha_alter.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Senha atual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "*Nova senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "*Confirmar senha:"
        '
        'btn_Cancel_alter
        '
        Me.btn_Cancel_alter.Location = New System.Drawing.Point(23, 184)
        Me.btn_Cancel_alter.Name = "btn_Cancel_alter"
        Me.btn_Cancel_alter.Size = New System.Drawing.Size(96, 23)
        Me.btn_Cancel_alter.TabIndex = 18
        Me.btn_Cancel_alter.Text = "Cancelar"
        Me.btn_Cancel_alter.UseVisualStyleBackColor = True
        '
        'Form_alterar_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(275, 261)
        Me.Controls.Add(Me.btn_Cancel_alter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_confSenha_alter)
        Me.Controls.Add(Me.txt_novasenha_alter)
        Me.Controls.Add(Me.txt_senhaatual_Alter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Login_altersenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_salvar_altersenha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_alterar_senha"
        Me.Text = "Alterar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salvar_altersenha As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Login_altersenha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_senhaatual_Alter As System.Windows.Forms.TextBox
    Friend WithEvents txt_novasenha_alter As System.Windows.Forms.TextBox
    Friend WithEvents txt_confSenha_alter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel_alter As System.Windows.Forms.Button
End Class
