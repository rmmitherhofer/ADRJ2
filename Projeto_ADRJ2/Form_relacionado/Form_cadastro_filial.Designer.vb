<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastro_filial
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
        Me.btn_cadastra_filial = New System.Windows.Forms.Button
        Me.btn_atualiza_filial = New System.Windows.Forms.Button
        Me.btn_exclui_filial = New System.Windows.Forms.Button
        Me.btn_volta = New System.Windows.Forms.Button
        Me.btn_edita_filial = New System.Windows.Forms.Button
        Me.Combo_uf_filial = New System.Windows.Forms.ComboBox
        Me.btn_carrega_cep = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_cod_filial = New System.Windows.Forms.TextBox
        Me.txt_rua_filial = New System.Windows.Forms.TextBox
        Me.txt_n_filial = New System.Windows.Forms.TextBox
        Me.txt_bairro_filial = New System.Windows.Forms.TextBox
        Me.txt_cidade_filial = New System.Windows.Forms.TextBox
        Me.txt_complemento_filial = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nome_filial = New System.Windows.Forms.TextBox
        Me.txt_hora_filial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_cadastra_cep = New System.Windows.Forms.Button
        Me.txt_dddtel_filial = New System.Windows.Forms.MaskedTextBox
        Me.txt_tel_filial = New System.Windows.Forms.MaskedTextBox
        Me.txt_cep_filial = New System.Windows.Forms.MaskedTextBox
        Me.txt_cnpj_fil = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.box_filial = New System.Windows.Forms.GroupBox
        Me.box_filial.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cadastra_filial
        '
        Me.btn_cadastra_filial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_filial.Location = New System.Drawing.Point(546, 247)
        Me.btn_cadastra_filial.Name = "btn_cadastra_filial"
        Me.btn_cadastra_filial.Size = New System.Drawing.Size(120, 23)
        Me.btn_cadastra_filial.TabIndex = 97
        Me.btn_cadastra_filial.Text = "Cadastrar"
        Me.btn_cadastra_filial.UseVisualStyleBackColor = True
        '
        'btn_atualiza_filial
        '
        Me.btn_atualiza_filial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualiza_filial.Location = New System.Drawing.Point(155, 247)
        Me.btn_atualiza_filial.Name = "btn_atualiza_filial"
        Me.btn_atualiza_filial.Size = New System.Drawing.Size(136, 23)
        Me.btn_atualiza_filial.TabIndex = 96
        Me.btn_atualiza_filial.Text = "Atualizar"
        Me.btn_atualiza_filial.UseVisualStyleBackColor = True
        '
        'btn_exclui_filial
        '
        Me.btn_exclui_filial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exclui_filial.Location = New System.Drawing.Point(300, 247)
        Me.btn_exclui_filial.Name = "btn_exclui_filial"
        Me.btn_exclui_filial.Size = New System.Drawing.Size(111, 23)
        Me.btn_exclui_filial.TabIndex = 95
        Me.btn_exclui_filial.Text = "Excluir Filial"
        Me.btn_exclui_filial.UseVisualStyleBackColor = True
        '
        'btn_volta
        '
        Me.btn_volta.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volta.Location = New System.Drawing.Point(672, 247)
        Me.btn_volta.Name = "btn_volta"
        Me.btn_volta.Size = New System.Drawing.Size(70, 23)
        Me.btn_volta.TabIndex = 94
        Me.btn_volta.Text = "Voltar"
        Me.btn_volta.UseVisualStyleBackColor = True
        '
        'btn_edita_filial
        '
        Me.btn_edita_filial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edita_filial.Location = New System.Drawing.Point(30, 247)
        Me.btn_edita_filial.Name = "btn_edita_filial"
        Me.btn_edita_filial.Size = New System.Drawing.Size(119, 23)
        Me.btn_edita_filial.TabIndex = 93
        Me.btn_edita_filial.Text = "Editar"
        Me.btn_edita_filial.UseVisualStyleBackColor = True
        '
        'Combo_uf_filial
        '
        Me.Combo_uf_filial.FormattingEnabled = True
        Me.Combo_uf_filial.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MG", "MR", "MR", "MS", "MT", "ND", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RS", "SC", "SE", "SP"})
        Me.Combo_uf_filial.Location = New System.Drawing.Point(553, 132)
        Me.Combo_uf_filial.MaxLength = 2
        Me.Combo_uf_filial.Name = "Combo_uf_filial"
        Me.Combo_uf_filial.Size = New System.Drawing.Size(61, 21)
        Me.Combo_uf_filial.TabIndex = 91
        '
        'btn_carrega_cep
        '
        Me.btn_carrega_cep.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carrega_cep.Location = New System.Drawing.Point(130, 156)
        Me.btn_carrega_cep.Name = "btn_carrega_cep"
        Me.btn_carrega_cep.Size = New System.Drawing.Size(56, 23)
        Me.btn_carrega_cep.TabIndex = 90
        Me.btn_carrega_cep.Text = "Carregar"
        Me.btn_carrega_cep.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "*CEP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(520, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "*UF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(533, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Complemento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(291, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "*Cidade:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "*Bairro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(457, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "*N°:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "*Logradouro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "*Telefone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Código:"
        '
        'txt_cod_filial
        '
        Me.txt_cod_filial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_filial.ForeColor = System.Drawing.Color.Red
        Me.txt_cod_filial.Location = New System.Drawing.Point(61, 25)
        Me.txt_cod_filial.MaxLength = 4
        Me.txt_cod_filial.Name = "txt_cod_filial"
        Me.txt_cod_filial.Size = New System.Drawing.Size(58, 20)
        Me.txt_cod_filial.TabIndex = 66
        Me.txt_cod_filial.Text = "000000"
        '
        'txt_rua_filial
        '
        Me.txt_rua_filial.Location = New System.Drawing.Point(87, 106)
        Me.txt_rua_filial.MaxLength = 60
        Me.txt_rua_filial.Name = "txt_rua_filial"
        Me.txt_rua_filial.Size = New System.Drawing.Size(364, 20)
        Me.txt_rua_filial.TabIndex = 60
        '
        'txt_n_filial
        '
        Me.txt_n_filial.Location = New System.Drawing.Point(488, 106)
        Me.txt_n_filial.MaxLength = 4
        Me.txt_n_filial.Name = "txt_n_filial"
        Me.txt_n_filial.Size = New System.Drawing.Size(41, 20)
        Me.txt_n_filial.TabIndex = 59
        '
        'txt_bairro_filial
        '
        Me.txt_bairro_filial.Location = New System.Drawing.Point(64, 132)
        Me.txt_bairro_filial.MaxLength = 40
        Me.txt_bairro_filial.Name = "txt_bairro_filial"
        Me.txt_bairro_filial.Size = New System.Drawing.Size(221, 20)
        Me.txt_bairro_filial.TabIndex = 58
        '
        'txt_cidade_filial
        '
        Me.txt_cidade_filial.Location = New System.Drawing.Point(342, 132)
        Me.txt_cidade_filial.MaxLength = 30
        Me.txt_cidade_filial.Name = "txt_cidade_filial"
        Me.txt_cidade_filial.Size = New System.Drawing.Size(172, 20)
        Me.txt_cidade_filial.TabIndex = 56
        '
        'txt_complemento_filial
        '
        Me.txt_complemento_filial.Location = New System.Drawing.Point(613, 106)
        Me.txt_complemento_filial.MaxLength = 45
        Me.txt_complemento_filial.Name = "txt_complemento_filial"
        Me.txt_complemento_filial.Size = New System.Drawing.Size(120, 20)
        Me.txt_complemento_filial.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "*Nome:"
        '
        'txt_nome_filial
        '
        Me.txt_nome_filial.Location = New System.Drawing.Point(58, 54)
        Me.txt_nome_filial.MaxLength = 35
        Me.txt_nome_filial.Name = "txt_nome_filial"
        Me.txt_nome_filial.Size = New System.Drawing.Size(504, 20)
        Me.txt_nome_filial.TabIndex = 53
        '
        'txt_hora_filial
        '
        Me.txt_hora_filial.Location = New System.Drawing.Point(155, 190)
        Me.txt_hora_filial.MaxLength = 60
        Me.txt_hora_filial.Name = "txt_hora_filial"
        Me.txt_hora_filial.Size = New System.Drawing.Size(571, 20)
        Me.txt_hora_filial.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "*Horario de Funcionamento:"
        '
        'btn_cadastra_cep
        '
        Me.btn_cadastra_cep.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_cep.Location = New System.Drawing.Point(192, 156)
        Me.btn_cadastra_cep.Name = "btn_cadastra_cep"
        Me.btn_cadastra_cep.Size = New System.Drawing.Size(117, 23)
        Me.btn_cadastra_cep.TabIndex = 122
        Me.btn_cadastra_cep.Text = "Cadastrar Endereço"
        Me.btn_cadastra_cep.UseVisualStyleBackColor = True
        '
        'txt_dddtel_filial
        '
        Me.txt_dddtel_filial.Location = New System.Drawing.Point(72, 80)
        Me.txt_dddtel_filial.Mask = "(00)"
        Me.txt_dddtel_filial.Name = "txt_dddtel_filial"
        Me.txt_dddtel_filial.Size = New System.Drawing.Size(31, 20)
        Me.txt_dddtel_filial.TabIndex = 124
        '
        'txt_tel_filial
        '
        Me.txt_tel_filial.Location = New System.Drawing.Point(109, 80)
        Me.txt_tel_filial.Mask = "0000-0000"
        Me.txt_tel_filial.Name = "txt_tel_filial"
        Me.txt_tel_filial.Size = New System.Drawing.Size(70, 20)
        Me.txt_tel_filial.TabIndex = 125
        '
        'txt_cep_filial
        '
        Me.txt_cep_filial.Location = New System.Drawing.Point(54, 158)
        Me.txt_cep_filial.Mask = "00000-000"
        Me.txt_cep_filial.Name = "txt_cep_filial"
        Me.txt_cep_filial.Size = New System.Drawing.Size(70, 20)
        Me.txt_cep_filial.TabIndex = 126
        '
        'txt_cnpj_fil
        '
        Me.txt_cnpj_fil.Location = New System.Drawing.Point(244, 80)
        Me.txt_cnpj_fil.MaxLength = 18
        Me.txt_cnpj_fil.Name = "txt_cnpj_fil"
        Me.txt_cnpj_fil.Size = New System.Drawing.Size(178, 20)
        Me.txt_cnpj_fil.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "*CNPJ:"
        '
        'box_filial
        '
        Me.box_filial.Controls.Add(Me.Label4)
        Me.box_filial.Controls.Add(Me.txt_hora_filial)
        Me.box_filial.Controls.Add(Me.txt_cnpj_fil)
        Me.box_filial.Controls.Add(Me.txt_cep_filial)
        Me.box_filial.Controls.Add(Me.txt_tel_filial)
        Me.box_filial.Controls.Add(Me.txt_dddtel_filial)
        Me.box_filial.Controls.Add(Me.btn_cadastra_cep)
        Me.box_filial.Controls.Add(Me.Label3)
        Me.box_filial.Controls.Add(Me.Combo_uf_filial)
        Me.box_filial.Controls.Add(Me.btn_carrega_cep)
        Me.box_filial.Controls.Add(Me.Label17)
        Me.box_filial.Controls.Add(Me.Label16)
        Me.box_filial.Controls.Add(Me.Label15)
        Me.box_filial.Controls.Add(Me.Label14)
        Me.box_filial.Controls.Add(Me.Label13)
        Me.box_filial.Controls.Add(Me.Label12)
        Me.box_filial.Controls.Add(Me.Label11)
        Me.box_filial.Controls.Add(Me.Label9)
        Me.box_filial.Controls.Add(Me.Label2)
        Me.box_filial.Controls.Add(Me.txt_cod_filial)
        Me.box_filial.Controls.Add(Me.txt_rua_filial)
        Me.box_filial.Controls.Add(Me.txt_n_filial)
        Me.box_filial.Controls.Add(Me.txt_bairro_filial)
        Me.box_filial.Controls.Add(Me.txt_cidade_filial)
        Me.box_filial.Controls.Add(Me.txt_complemento_filial)
        Me.box_filial.Controls.Add(Me.Label1)
        Me.box_filial.Controls.Add(Me.txt_nome_filial)
        Me.box_filial.Location = New System.Drawing.Point(16, 6)
        Me.box_filial.Name = "box_filial"
        Me.box_filial.Size = New System.Drawing.Size(742, 235)
        Me.box_filial.TabIndex = 129
        Me.box_filial.TabStop = False
        Me.box_filial.Text = "Filiais"
        '
        'Form_cadastro_filial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 293)
        Me.Controls.Add(Me.box_filial)
        Me.Controls.Add(Me.btn_cadastra_filial)
        Me.Controls.Add(Me.btn_atualiza_filial)
        Me.Controls.Add(Me.btn_exclui_filial)
        Me.Controls.Add(Me.btn_volta)
        Me.Controls.Add(Me.btn_edita_filial)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastro_filial"
        Me.Text = "Filial"
        Me.box_filial.ResumeLayout(False)
        Me.box_filial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cadastra_filial As System.Windows.Forms.Button
    Friend WithEvents btn_atualiza_filial As System.Windows.Forms.Button
    Friend WithEvents btn_exclui_filial As System.Windows.Forms.Button
    Friend WithEvents btn_volta As System.Windows.Forms.Button
    Friend WithEvents btn_edita_filial As System.Windows.Forms.Button
    Friend WithEvents Combo_uf_filial As System.Windows.Forms.ComboBox
    Friend WithEvents btn_carrega_cep As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_rua_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_complemento_filial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_filial As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora_filial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cadastra_cep As System.Windows.Forms.Button
    Friend WithEvents txt_dddtel_filial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_tel_filial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cep_filial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cnpj_fil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents box_filial As System.Windows.Forms.GroupBox
End Class
