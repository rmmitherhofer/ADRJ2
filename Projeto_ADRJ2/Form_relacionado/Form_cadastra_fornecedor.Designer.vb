<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastra_fornecedor
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
        Me.btn_cadastra_end = New System.Windows.Forms.Button
        Me.btn_cadastra_forne = New System.Windows.Forms.Button
        Me.btn_atualiza_forne = New System.Windows.Forms.Button
        Me.btn_exclui_forne = New System.Windows.Forms.Button
        Me.btn_volta = New System.Windows.Forms.Button
        Me.btn_edita_forne = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Combo_uf_forne = New System.Windows.Forms.ComboBox
        Me.btn_carregacep = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_cod_forne = New System.Windows.Forms.TextBox
        Me.txt_cnpj_forne = New System.Windows.Forms.TextBox
        Me.txt_rua_forne = New System.Windows.Forms.TextBox
        Me.txt_n_forne = New System.Windows.Forms.TextBox
        Me.txt_bairro_forne = New System.Windows.Forms.TextBox
        Me.txt_cidad_forne = New System.Windows.Forms.TextBox
        Me.txt_complent_forne = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nome_forne = New System.Windows.Forms.TextBox
        Me.txt_tel_forne = New System.Windows.Forms.MaskedTextBox
        Me.txt_dddtel_forne = New System.Windows.Forms.MaskedTextBox
        Me.txt_dtinclusao_forne = New System.Windows.Forms.MaskedTextBox
        Me.txt_cep_forne = New System.Windows.Forms.MaskedTextBox
        Me.Box_ForneCadas = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_email_forn = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_site_forn = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_InscricaoEstMun_forn = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_nomeFantasia_Forn = New System.Windows.Forms.TextBox
        Me.Box_ForneCadas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cadastra_end
        '
        Me.btn_cadastra_end.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_end.Location = New System.Drawing.Point(194, 181)
        Me.btn_cadastra_end.Name = "btn_cadastra_end"
        Me.btn_cadastra_end.Size = New System.Drawing.Size(117, 23)
        Me.btn_cadastra_end.TabIndex = 168
        Me.btn_cadastra_end.Text = "Cadastrar Endereço"
        Me.btn_cadastra_end.UseVisualStyleBackColor = True
        '
        'btn_cadastra_forne
        '
        Me.btn_cadastra_forne.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_forne.Location = New System.Drawing.Point(453, 267)
        Me.btn_cadastra_forne.Name = "btn_cadastra_forne"
        Me.btn_cadastra_forne.Size = New System.Drawing.Size(151, 23)
        Me.btn_cadastra_forne.TabIndex = 167
        Me.btn_cadastra_forne.Text = "Cadastrar"
        Me.btn_cadastra_forne.UseVisualStyleBackColor = True
        '
        'btn_atualiza_forne
        '
        Me.btn_atualiza_forne.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualiza_forne.Location = New System.Drawing.Point(140, 267)
        Me.btn_atualiza_forne.Name = "btn_atualiza_forne"
        Me.btn_atualiza_forne.Size = New System.Drawing.Size(130, 23)
        Me.btn_atualiza_forne.TabIndex = 166
        Me.btn_atualiza_forne.Text = "Atualizar"
        Me.btn_atualiza_forne.UseVisualStyleBackColor = True
        '
        'btn_exclui_forne
        '
        Me.btn_exclui_forne.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exclui_forne.Location = New System.Drawing.Point(276, 267)
        Me.btn_exclui_forne.Name = "btn_exclui_forne"
        Me.btn_exclui_forne.Size = New System.Drawing.Size(116, 23)
        Me.btn_exclui_forne.TabIndex = 165
        Me.btn_exclui_forne.Text = "Excluir Cadastro"
        Me.btn_exclui_forne.UseVisualStyleBackColor = True
        '
        'btn_volta
        '
        Me.btn_volta.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volta.Location = New System.Drawing.Point(610, 267)
        Me.btn_volta.Name = "btn_volta"
        Me.btn_volta.Size = New System.Drawing.Size(75, 23)
        Me.btn_volta.TabIndex = 164
        Me.btn_volta.Text = "Voltar"
        Me.btn_volta.UseVisualStyleBackColor = True
        '
        'btn_edita_forne
        '
        Me.btn_edita_forne.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edita_forne.Location = New System.Drawing.Point(13, 267)
        Me.btn_edita_forne.Name = "btn_edita_forne"
        Me.btn_edita_forne.Size = New System.Drawing.Size(118, 23)
        Me.btn_edita_forne.TabIndex = 163
        Me.btn_edita_forne.Text = "Editar"
        Me.btn_edita_forne.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 212)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 15)
        Me.Label18.TabIndex = 162
        Me.Label18.Text = "*Data de Inclusão:"
        '
        'Combo_uf_forne
        '
        Me.Combo_uf_forne.FormattingEnabled = True
        Me.Combo_uf_forne.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MG", "MR", "MR", "MS", "MT", "ND", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RS", "SC", "SE", "SP"})
        Me.Combo_uf_forne.Location = New System.Drawing.Point(494, 157)
        Me.Combo_uf_forne.MaxLength = 2
        Me.Combo_uf_forne.Name = "Combo_uf_forne"
        Me.Combo_uf_forne.Size = New System.Drawing.Size(61, 21)
        Me.Combo_uf_forne.TabIndex = 161
        '
        'btn_carregacep
        '
        Me.btn_carregacep.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carregacep.Location = New System.Drawing.Point(132, 181)
        Me.btn_carregacep.Name = "btn_carregacep"
        Me.btn_carregacep.Size = New System.Drawing.Size(56, 23)
        Me.btn_carregacep.TabIndex = 160
        Me.btn_carregacep.Text = "Carregar"
        Me.btn_carregacep.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 159
        Me.Label17.Text = "*CEP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(461, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "*UF:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(435, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "Complemento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(231, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "*Cidade:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "*Bairro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(357, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "*N°:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "*Logradouro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(493, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Telefone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "*CNPJ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Código:"
        '
        'txt_cod_forne
        '
        Me.txt_cod_forne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_forne.ForeColor = System.Drawing.Color.Red
        Me.txt_cod_forne.Location = New System.Drawing.Point(63, 18)
        Me.txt_cod_forne.Name = "txt_cod_forne"
        Me.txt_cod_forne.Size = New System.Drawing.Size(58, 20)
        Me.txt_cod_forne.TabIndex = 136
        Me.txt_cod_forne.Text = "000000"
        '
        'txt_cnpj_forne
        '
        Me.txt_cnpj_forne.Location = New System.Drawing.Point(470, 52)
        Me.txt_cnpj_forne.MaxLength = 20
        Me.txt_cnpj_forne.Name = "txt_cnpj_forne"
        Me.txt_cnpj_forne.Size = New System.Drawing.Size(128, 20)
        Me.txt_cnpj_forne.TabIndex = 135
        '
        'txt_rua_forne
        '
        Me.txt_rua_forne.Location = New System.Drawing.Point(93, 131)
        Me.txt_rua_forne.MaxLength = 60
        Me.txt_rua_forne.Name = "txt_rua_forne"
        Me.txt_rua_forne.Size = New System.Drawing.Size(256, 20)
        Me.txt_rua_forne.TabIndex = 130
        '
        'txt_n_forne
        '
        Me.txt_n_forne.Location = New System.Drawing.Point(388, 131)
        Me.txt_n_forne.MaxLength = 4
        Me.txt_n_forne.Name = "txt_n_forne"
        Me.txt_n_forne.Size = New System.Drawing.Size(41, 20)
        Me.txt_n_forne.TabIndex = 129
        '
        'txt_bairro_forne
        '
        Me.txt_bairro_forne.Location = New System.Drawing.Point(67, 157)
        Me.txt_bairro_forne.MaxLength = 40
        Me.txt_bairro_forne.Name = "txt_bairro_forne"
        Me.txt_bairro_forne.Size = New System.Drawing.Size(158, 20)
        Me.txt_bairro_forne.TabIndex = 128
        '
        'txt_cidad_forne
        '
        Me.txt_cidad_forne.Location = New System.Drawing.Point(283, 157)
        Me.txt_cidad_forne.MaxLength = 30
        Me.txt_cidad_forne.Name = "txt_cidad_forne"
        Me.txt_cidad_forne.Size = New System.Drawing.Size(172, 20)
        Me.txt_cidad_forne.TabIndex = 126
        '
        'txt_complent_forne
        '
        Me.txt_complent_forne.Location = New System.Drawing.Point(516, 131)
        Me.txt_complent_forne.MaxLength = 45
        Me.txt_complent_forne.Name = "txt_complent_forne"
        Me.txt_complent_forne.Size = New System.Drawing.Size(159, 20)
        Me.txt_complent_forne.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "*Nome:"
        '
        'txt_nome_forne
        '
        Me.txt_nome_forne.Location = New System.Drawing.Point(63, 52)
        Me.txt_nome_forne.MaxLength = 45
        Me.txt_nome_forne.Name = "txt_nome_forne"
        Me.txt_nome_forne.Size = New System.Drawing.Size(356, 20)
        Me.txt_nome_forne.TabIndex = 123
        '
        'txt_tel_forne
        '
        Me.txt_tel_forne.Location = New System.Drawing.Point(586, 183)
        Me.txt_tel_forne.Mask = "0000-0000"
        Me.txt_tel_forne.Name = "txt_tel_forne"
        Me.txt_tel_forne.Size = New System.Drawing.Size(71, 20)
        Me.txt_tel_forne.TabIndex = 170
        '
        'txt_dddtel_forne
        '
        Me.txt_dddtel_forne.Location = New System.Drawing.Point(547, 183)
        Me.txt_dddtel_forne.Mask = "(00)"
        Me.txt_dddtel_forne.Name = "txt_dddtel_forne"
        Me.txt_dddtel_forne.Size = New System.Drawing.Size(30, 20)
        Me.txt_dddtel_forne.TabIndex = 171
        '
        'txt_dtinclusao_forne
        '
        Me.txt_dtinclusao_forne.Location = New System.Drawing.Point(113, 210)
        Me.txt_dtinclusao_forne.Mask = "00/00/0000"
        Me.txt_dtinclusao_forne.Name = "txt_dtinclusao_forne"
        Me.txt_dtinclusao_forne.Size = New System.Drawing.Size(100, 20)
        Me.txt_dtinclusao_forne.TabIndex = 172
        '
        'txt_cep_forne
        '
        Me.txt_cep_forne.Location = New System.Drawing.Point(57, 183)
        Me.txt_cep_forne.Mask = "00000-000"
        Me.txt_cep_forne.Name = "txt_cep_forne"
        Me.txt_cep_forne.Size = New System.Drawing.Size(69, 20)
        Me.txt_cep_forne.TabIndex = 173
        '
        'Box_ForneCadas
        '
        Me.Box_ForneCadas.Controls.Add(Me.Label7)
        Me.Box_ForneCadas.Controls.Add(Me.txt_email_forn)
        Me.Box_ForneCadas.Controls.Add(Me.Label6)
        Me.Box_ForneCadas.Controls.Add(Me.txt_site_forn)
        Me.Box_ForneCadas.Controls.Add(Me.Label5)
        Me.Box_ForneCadas.Controls.Add(Me.txt_InscricaoEstMun_forn)
        Me.Box_ForneCadas.Controls.Add(Me.Label4)
        Me.Box_ForneCadas.Controls.Add(Me.txt_nomeFantasia_Forn)
        Me.Box_ForneCadas.Controls.Add(Me.txt_cep_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_dtinclusao_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_dddtel_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_tel_forne)
        Me.Box_ForneCadas.Controls.Add(Me.btn_cadastra_end)
        Me.Box_ForneCadas.Controls.Add(Me.Label18)
        Me.Box_ForneCadas.Controls.Add(Me.Combo_uf_forne)
        Me.Box_ForneCadas.Controls.Add(Me.btn_carregacep)
        Me.Box_ForneCadas.Controls.Add(Me.Label17)
        Me.Box_ForneCadas.Controls.Add(Me.Label16)
        Me.Box_ForneCadas.Controls.Add(Me.Label15)
        Me.Box_ForneCadas.Controls.Add(Me.Label14)
        Me.Box_ForneCadas.Controls.Add(Me.Label13)
        Me.Box_ForneCadas.Controls.Add(Me.Label12)
        Me.Box_ForneCadas.Controls.Add(Me.Label11)
        Me.Box_ForneCadas.Controls.Add(Me.Label9)
        Me.Box_ForneCadas.Controls.Add(Me.Label3)
        Me.Box_ForneCadas.Controls.Add(Me.Label2)
        Me.Box_ForneCadas.Controls.Add(Me.txt_cod_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_cnpj_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_rua_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_n_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_bairro_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_cidad_forne)
        Me.Box_ForneCadas.Controls.Add(Me.txt_complent_forne)
        Me.Box_ForneCadas.Controls.Add(Me.Label1)
        Me.Box_ForneCadas.Controls.Add(Me.txt_nome_forne)
        Me.Box_ForneCadas.Location = New System.Drawing.Point(10, 6)
        Me.Box_ForneCadas.Name = "Box_ForneCadas"
        Me.Box_ForneCadas.Size = New System.Drawing.Size(682, 255)
        Me.Box_ForneCadas.TabIndex = 174
        Me.Box_ForneCadas.TabStop = False
        Me.Box_ForneCadas.Text = "Fornecedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "*e-Mail:"
        '
        'txt_email_forn
        '
        Me.txt_email_forn.Location = New System.Drawing.Point(65, 105)
        Me.txt_email_forn.MaxLength = 45
        Me.txt_email_forn.Name = "txt_email_forn"
        Me.txt_email_forn.Size = New System.Drawing.Size(241, 20)
        Me.txt_email_forn.TabIndex = 180
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Site:"
        '
        'txt_site_forn
        '
        Me.txt_site_forn.Location = New System.Drawing.Point(345, 105)
        Me.txt_site_forn.MaxLength = 55
        Me.txt_site_forn.Name = "txt_site_forn"
        Me.txt_site_forn.Size = New System.Drawing.Size(263, 20)
        Me.txt_site_forn.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(418, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 15)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Incrição Estadual/Municipal:"
        '
        'txt_InscricaoEstMun_forn
        '
        Me.txt_InscricaoEstMun_forn.Location = New System.Drawing.Point(561, 78)
        Me.txt_InscricaoEstMun_forn.MaxLength = 25
        Me.txt_InscricaoEstMun_forn.Name = "txt_InscricaoEstMun_forn"
        Me.txt_InscricaoEstMun_forn.Size = New System.Drawing.Size(111, 20)
        Me.txt_InscricaoEstMun_forn.TabIndex = 176
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Nome Fantasia:"
        '
        'txt_nomeFantasia_Forn
        '
        Me.txt_nomeFantasia_Forn.Location = New System.Drawing.Point(102, 78)
        Me.txt_nomeFantasia_Forn.MaxLength = 45
        Me.txt_nomeFantasia_Forn.Name = "txt_nomeFantasia_Forn"
        Me.txt_nomeFantasia_Forn.Size = New System.Drawing.Size(310, 20)
        Me.txt_nomeFantasia_Forn.TabIndex = 174
        '
        'Form_cadastra_fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 298)
        Me.Controls.Add(Me.Box_ForneCadas)
        Me.Controls.Add(Me.btn_cadastra_forne)
        Me.Controls.Add(Me.btn_atualiza_forne)
        Me.Controls.Add(Me.btn_exclui_forne)
        Me.Controls.Add(Me.btn_volta)
        Me.Controls.Add(Me.btn_edita_forne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastra_fornecedor"
        Me.Text = "Fornecedor"
        Me.Box_ForneCadas.ResumeLayout(False)
        Me.Box_ForneCadas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cadastra_end As System.Windows.Forms.Button
    Friend WithEvents btn_cadastra_forne As System.Windows.Forms.Button
    Friend WithEvents btn_atualiza_forne As System.Windows.Forms.Button
    Friend WithEvents btn_exclui_forne As System.Windows.Forms.Button
    Friend WithEvents btn_volta As System.Windows.Forms.Button
    Friend WithEvents btn_edita_forne As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Combo_uf_forne As System.Windows.Forms.ComboBox
    Friend WithEvents btn_carregacep As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_cnpj_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_rua_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidad_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_complent_forne As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_forne As System.Windows.Forms.TextBox
    Friend WithEvents txt_tel_forne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dddtel_forne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dtinclusao_forne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cep_forne As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Box_ForneCadas As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_InscricaoEstMun_forn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nomeFantasia_Forn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_email_forn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_site_forn As System.Windows.Forms.TextBox
End Class
