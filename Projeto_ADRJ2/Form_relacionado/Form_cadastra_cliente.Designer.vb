<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastra_cliente
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
        Me.txt_nomecliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_complent_client = New System.Windows.Forms.TextBox
        Me.txt_cidad_client = New System.Windows.Forms.TextBox
        Me.txt_bairro_client = New System.Windows.Forms.TextBox
        Me.txt_n_client = New System.Windows.Forms.TextBox
        Me.txt_rua_client = New System.Windows.Forms.TextBox
        Me.txt_nomemae_client = New System.Windows.Forms.TextBox
        Me.txt_codcliente_cadas = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Combo_ecivil = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.raidio_clienteM = New System.Windows.Forms.RadioButton
        Me.radio_clienteF = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btn_carregacep = New System.Windows.Forms.Button
        Me.Combo_uf_client = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.btn_edita_client = New System.Windows.Forms.Button
        Me.btn_volta = New System.Windows.Forms.Button
        Me.btn_exclui_client = New System.Windows.Forms.Button
        Me.btn_atualiza_client = New System.Windows.Forms.Button
        Me.btn_cadastra_client = New System.Windows.Forms.Button
        Me.btn_cadastra_end = New System.Windows.Forms.Button
        Me.box_cliente_cadastr = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_email_cliente = New System.Windows.Forms.TextBox
        Me.txt_rgcliente = New System.Windows.Forms.TextBox
        Me.txt_cpfcliente_cadastr = New System.Windows.Forms.MaskedTextBox
        Me.txt_dtabertura_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_cep_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_cel_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_dddcel_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_tel_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_dddtel_client = New System.Windows.Forms.MaskedTextBox
        Me.txt_dtnascclient = New System.Windows.Forms.MaskedTextBox
        Me.box_cliente_cadastr.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nomecliente
        '
        Me.txt_nomecliente.Location = New System.Drawing.Point(58, 54)
        Me.txt_nomecliente.MaxLength = 64
        Me.txt_nomecliente.Name = "txt_nomecliente"
        Me.txt_nomecliente.Size = New System.Drawing.Size(455, 20)
        Me.txt_nomecliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "*Nome:"
        '
        'txt_complent_client
        '
        Me.txt_complent_client.Location = New System.Drawing.Point(612, 199)
        Me.txt_complent_client.MaxLength = 35
        Me.txt_complent_client.Name = "txt_complent_client"
        Me.txt_complent_client.Size = New System.Drawing.Size(120, 20)
        Me.txt_complent_client.TabIndex = 2
        '
        'txt_cidad_client
        '
        Me.txt_cidad_client.Location = New System.Drawing.Point(338, 229)
        Me.txt_cidad_client.MaxLength = 30
        Me.txt_cidad_client.Name = "txt_cidad_client"
        Me.txt_cidad_client.Size = New System.Drawing.Size(172, 20)
        Me.txt_cidad_client.TabIndex = 3
        '
        'txt_bairro_client
        '
        Me.txt_bairro_client.Location = New System.Drawing.Point(59, 229)
        Me.txt_bairro_client.MaxLength = 40
        Me.txt_bairro_client.Name = "txt_bairro_client"
        Me.txt_bairro_client.Size = New System.Drawing.Size(221, 20)
        Me.txt_bairro_client.TabIndex = 5
        '
        'txt_n_client
        '
        Me.txt_n_client.Location = New System.Drawing.Point(483, 199)
        Me.txt_n_client.MaxLength = 4
        Me.txt_n_client.Name = "txt_n_client"
        Me.txt_n_client.Size = New System.Drawing.Size(41, 20)
        Me.txt_n_client.TabIndex = 6
        '
        'txt_rua_client
        '
        Me.txt_rua_client.Location = New System.Drawing.Point(85, 199)
        Me.txt_rua_client.MaxLength = 60
        Me.txt_rua_client.Name = "txt_rua_client"
        Me.txt_rua_client.Size = New System.Drawing.Size(364, 20)
        Me.txt_rua_client.TabIndex = 7
        '
        'txt_nomemae_client
        '
        Me.txt_nomemae_client.Location = New System.Drawing.Point(50, 109)
        Me.txt_nomemae_client.MaxLength = 50
        Me.txt_nomemae_client.Name = "txt_nomemae_client"
        Me.txt_nomemae_client.Size = New System.Drawing.Size(463, 20)
        Me.txt_nomemae_client.TabIndex = 10
        '
        'txt_codcliente_cadas
        '
        Me.txt_codcliente_cadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codcliente_cadas.ForeColor = System.Drawing.Color.Red
        Me.txt_codcliente_cadas.Location = New System.Drawing.Point(61, 19)
        Me.txt_codcliente_cadas.Name = "txt_codcliente_cadas"
        Me.txt_codcliente_cadas.Size = New System.Drawing.Size(58, 20)
        Me.txt_codcliente_cadas.TabIndex = 13
        Me.txt_codcliente_cadas.Text = "000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "*CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "*RG:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(519, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "*Data de Nascimento:"
        '
        'Combo_ecivil
        '
        Me.Combo_ecivil.DisplayMember = "Descrição_Estado_Civil"
        Me.Combo_ecivil.FormattingEnabled = True
        Me.Combo_ecivil.Items.AddRange(New Object() {"CASADO (A)", "CONCUBINADO (A)", "DIVORCIADO (A)", "SEPARADO (A)", "SOLTEIRO (A)", "VIUVO (A)"})
        Me.Combo_ecivil.Location = New System.Drawing.Point(590, 54)
        Me.Combo_ecivil.MaxLength = 14
        Me.Combo_ecivil.Name = "Combo_ecivil"
        Me.Combo_ecivil.Size = New System.Drawing.Size(130, 21)
        Me.Combo_ecivil.TabIndex = 18
        Me.Combo_ecivil.Text = "Selecionar"
        Me.Combo_ecivil.ValueMember = "Descrição_Estado_Civil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(519, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*Estado Civil:"
        '
        'raidio_clienteM
        '
        Me.raidio_clienteM.AutoSize = True
        Me.raidio_clienteM.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raidio_clienteM.Location = New System.Drawing.Point(351, 84)
        Me.raidio_clienteM.Name = "raidio_clienteM"
        Me.raidio_clienteM.Size = New System.Drawing.Size(33, 19)
        Me.raidio_clienteM.TabIndex = 20
        Me.raidio_clienteM.TabStop = True
        Me.raidio_clienteM.Text = "M"
        Me.raidio_clienteM.UseVisualStyleBackColor = True
        '
        'radio_clienteF
        '
        Me.radio_clienteF.AutoSize = True
        Me.radio_clienteF.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_clienteF.Location = New System.Drawing.Point(391, 84)
        Me.radio_clienteF.Name = "radio_clienteF"
        Me.radio_clienteF.Size = New System.Drawing.Size(31, 19)
        Me.radio_clienteF.TabIndex = 21
        Me.radio_clienteF.TabStop = True
        Me.radio_clienteF.Text = "F"
        Me.radio_clienteF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "*Sexo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Mãe:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Telefone:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(196, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Celular:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "*Logradouro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(455, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "*N°:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "*Bairro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(286, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "*Cidade:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(531, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Complemento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(520, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "*UF:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "*CEP:"
        '
        'btn_carregacep
        '
        Me.btn_carregacep.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carregacep.Location = New System.Drawing.Point(159, 253)
        Me.btn_carregacep.Name = "btn_carregacep"
        Me.btn_carregacep.Size = New System.Drawing.Size(56, 23)
        Me.btn_carregacep.TabIndex = 45
        Me.btn_carregacep.Text = "Carregar"
        Me.btn_carregacep.UseVisualStyleBackColor = True
        '
        'Combo_uf_client
        '
        Me.Combo_uf_client.FormattingEnabled = True
        Me.Combo_uf_client.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MR", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "SC", "SP", "SE", "DF"})
        Me.Combo_uf_client.Location = New System.Drawing.Point(553, 229)
        Me.Combo_uf_client.MaxLength = 2
        Me.Combo_uf_client.Name = "Combo_uf_client"
        Me.Combo_uf_client.Size = New System.Drawing.Size(61, 21)
        Me.Combo_uf_client.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(349, 257)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 15)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "*Data de Abertura:"
        '
        'btn_edita_client
        '
        Me.btn_edita_client.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edita_client.Location = New System.Drawing.Point(10, 320)
        Me.btn_edita_client.Name = "btn_edita_client"
        Me.btn_edita_client.Size = New System.Drawing.Size(152, 23)
        Me.btn_edita_client.TabIndex = 48
        Me.btn_edita_client.Text = "Editar"
        Me.btn_edita_client.UseVisualStyleBackColor = True
        '
        'btn_volta
        '
        Me.btn_volta.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volta.Location = New System.Drawing.Point(668, 320)
        Me.btn_volta.Name = "btn_volta"
        Me.btn_volta.Size = New System.Drawing.Size(75, 23)
        Me.btn_volta.TabIndex = 49
        Me.btn_volta.Text = "Voltar"
        Me.btn_volta.UseVisualStyleBackColor = True
        '
        'btn_exclui_client
        '
        Me.btn_exclui_client.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exclui_client.Location = New System.Drawing.Point(168, 320)
        Me.btn_exclui_client.Name = "btn_exclui_client"
        Me.btn_exclui_client.Size = New System.Drawing.Size(148, 23)
        Me.btn_exclui_client.TabIndex = 50
        Me.btn_exclui_client.Text = "Excluir Cadastro"
        Me.btn_exclui_client.UseVisualStyleBackColor = True
        '
        'btn_atualiza_client
        '
        Me.btn_atualiza_client.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualiza_client.Location = New System.Drawing.Point(335, 320)
        Me.btn_atualiza_client.Name = "btn_atualiza_client"
        Me.btn_atualiza_client.Size = New System.Drawing.Size(170, 23)
        Me.btn_atualiza_client.TabIndex = 51
        Me.btn_atualiza_client.Text = "Atualizar"
        Me.btn_atualiza_client.UseVisualStyleBackColor = True
        '
        'btn_cadastra_client
        '
        Me.btn_cadastra_client.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_client.Location = New System.Drawing.Point(511, 320)
        Me.btn_cadastra_client.Name = "btn_cadastra_client"
        Me.btn_cadastra_client.Size = New System.Drawing.Size(151, 23)
        Me.btn_cadastra_client.TabIndex = 52
        Me.btn_cadastra_client.Text = "Cadastrar"
        Me.btn_cadastra_client.UseVisualStyleBackColor = True
        '
        'btn_cadastra_end
        '
        Me.btn_cadastra_end.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_end.Location = New System.Drawing.Point(221, 253)
        Me.btn_cadastra_end.Name = "btn_cadastra_end"
        Me.btn_cadastra_end.Size = New System.Drawing.Size(117, 23)
        Me.btn_cadastra_end.TabIndex = 122
        Me.btn_cadastra_end.Text = "Cadastrar Endereço"
        Me.btn_cadastra_end.UseVisualStyleBackColor = True
        '
        'box_cliente_cadastr
        '
        Me.box_cliente_cadastr.Controls.Add(Me.Label19)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_email_cliente)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_rgcliente)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_cpfcliente_cadastr)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_dtabertura_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_cep_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_cel_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_dddcel_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_tel_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_dddtel_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_dtnascclient)
        Me.box_cliente_cadastr.Controls.Add(Me.btn_cadastra_end)
        Me.box_cliente_cadastr.Controls.Add(Me.Label18)
        Me.box_cliente_cadastr.Controls.Add(Me.Combo_uf_client)
        Me.box_cliente_cadastr.Controls.Add(Me.btn_carregacep)
        Me.box_cliente_cadastr.Controls.Add(Me.Label17)
        Me.box_cliente_cadastr.Controls.Add(Me.Label16)
        Me.box_cliente_cadastr.Controls.Add(Me.Label15)
        Me.box_cliente_cadastr.Controls.Add(Me.Label14)
        Me.box_cliente_cadastr.Controls.Add(Me.Label13)
        Me.box_cliente_cadastr.Controls.Add(Me.Label12)
        Me.box_cliente_cadastr.Controls.Add(Me.Label11)
        Me.box_cliente_cadastr.Controls.Add(Me.Label10)
        Me.box_cliente_cadastr.Controls.Add(Me.Label9)
        Me.box_cliente_cadastr.Controls.Add(Me.Label8)
        Me.box_cliente_cadastr.Controls.Add(Me.Label7)
        Me.box_cliente_cadastr.Controls.Add(Me.radio_clienteF)
        Me.box_cliente_cadastr.Controls.Add(Me.raidio_clienteM)
        Me.box_cliente_cadastr.Controls.Add(Me.Label6)
        Me.box_cliente_cadastr.Controls.Add(Me.Combo_ecivil)
        Me.box_cliente_cadastr.Controls.Add(Me.Label5)
        Me.box_cliente_cadastr.Controls.Add(Me.Label4)
        Me.box_cliente_cadastr.Controls.Add(Me.Label3)
        Me.box_cliente_cadastr.Controls.Add(Me.Label2)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_codcliente_cadas)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_nomemae_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_rua_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_n_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_bairro_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_cidad_client)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_complent_client)
        Me.box_cliente_cadastr.Controls.Add(Me.Label1)
        Me.box_cliente_cadastr.Controls.Add(Me.txt_nomecliente)
        Me.box_cliente_cadastr.Location = New System.Drawing.Point(10, 12)
        Me.box_cliente_cadastr.Name = "box_cliente_cadastr"
        Me.box_cliente_cadastr.Size = New System.Drawing.Size(734, 293)
        Me.box_cliente_cadastr.TabIndex = 123
        Me.box_cliente_cadastr.TabStop = False
        Me.box_cliente_cadastr.Text = "Cliente"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "e-Mail:"
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.Location = New System.Drawing.Point(55, 170)
        Me.txt_email_cliente.MaxLength = 45
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(364, 20)
        Me.txt_email_cliente.TabIndex = 134
        '
        'txt_rgcliente
        '
        Me.txt_rgcliente.Location = New System.Drawing.Point(199, 82)
        Me.txt_rgcliente.MaxLength = 18
        Me.txt_rgcliente.Name = "txt_rgcliente"
        Me.txt_rgcliente.Size = New System.Drawing.Size(106, 20)
        Me.txt_rgcliente.TabIndex = 133
        '
        'txt_cpfcliente_cadastr
        '
        Me.txt_cpfcliente_cadastr.Location = New System.Drawing.Point(50, 82)
        Me.txt_cpfcliente_cadastr.Mask = "000,000,000-00"
        Me.txt_cpfcliente_cadastr.Name = "txt_cpfcliente_cadastr"
        Me.txt_cpfcliente_cadastr.Size = New System.Drawing.Size(92, 20)
        Me.txt_cpfcliente_cadastr.TabIndex = 132
        '
        'txt_dtabertura_client
        '
        Me.txt_dtabertura_client.Location = New System.Drawing.Point(440, 255)
        Me.txt_dtabertura_client.Mask = "00/00/0000"
        Me.txt_dtabertura_client.Name = "txt_dtabertura_client"
        Me.txt_dtabertura_client.Size = New System.Drawing.Size(74, 20)
        Me.txt_dtabertura_client.TabIndex = 130
        '
        'txt_cep_client
        '
        Me.txt_cep_client.Location = New System.Drawing.Point(53, 254)
        Me.txt_cep_client.Mask = "00000-000"
        Me.txt_cep_client.Name = "txt_cep_client"
        Me.txt_cep_client.Size = New System.Drawing.Size(77, 20)
        Me.txt_cep_client.TabIndex = 129
        '
        'txt_cel_client
        '
        Me.txt_cel_client.Location = New System.Drawing.Point(277, 141)
        Me.txt_cel_client.Mask = "0000-0000"
        Me.txt_cel_client.Name = "txt_cel_client"
        Me.txt_cel_client.Size = New System.Drawing.Size(60, 20)
        Me.txt_cel_client.TabIndex = 127
        '
        'txt_dddcel_client
        '
        Me.txt_dddcel_client.Location = New System.Drawing.Point(243, 141)
        Me.txt_dddcel_client.Mask = "(00)"
        Me.txt_dddcel_client.Name = "txt_dddcel_client"
        Me.txt_dddcel_client.Size = New System.Drawing.Size(29, 20)
        Me.txt_dddcel_client.TabIndex = 126
        '
        'txt_tel_client
        '
        Me.txt_tel_client.Location = New System.Drawing.Point(99, 141)
        Me.txt_tel_client.Mask = "0000-0000"
        Me.txt_tel_client.Name = "txt_tel_client"
        Me.txt_tel_client.Size = New System.Drawing.Size(60, 20)
        Me.txt_tel_client.TabIndex = 125
        '
        'txt_dddtel_client
        '
        Me.txt_dddtel_client.Location = New System.Drawing.Point(65, 141)
        Me.txt_dddtel_client.Mask = "(00)"
        Me.txt_dddtel_client.Name = "txt_dddtel_client"
        Me.txt_dddtel_client.Size = New System.Drawing.Size(29, 20)
        Me.txt_dddtel_client.TabIndex = 124
        '
        'txt_dtnascclient
        '
        Me.txt_dtnascclient.Location = New System.Drawing.Point(623, 83)
        Me.txt_dtnascclient.Mask = "00/00/0000"
        Me.txt_dtnascclient.Name = "txt_dtnascclient"
        Me.txt_dtnascclient.Size = New System.Drawing.Size(74, 20)
        Me.txt_dtnascclient.TabIndex = 123
        '
        'Form_cadastra_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 361)
        Me.Controls.Add(Me.box_cliente_cadastr)
        Me.Controls.Add(Me.btn_cadastra_client)
        Me.Controls.Add(Me.btn_atualiza_client)
        Me.Controls.Add(Me.btn_exclui_client)
        Me.Controls.Add(Me.btn_volta)
        Me.Controls.Add(Me.btn_edita_client)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastra_cliente"
        Me.Text = "Cliente"
        Me.box_cliente_cadastr.ResumeLayout(False)
        Me.box_cliente_cadastr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_nomecliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_complent_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidad_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_rua_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomemae_client As System.Windows.Forms.TextBox
    Friend WithEvents txt_codcliente_cadas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Combo_ecivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents raidio_clienteM As System.Windows.Forms.RadioButton
    Friend WithEvents radio_clienteF As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_carregacep As System.Windows.Forms.Button
    Friend WithEvents Combo_uf_client As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_edita_client As System.Windows.Forms.Button
    Friend WithEvents btn_volta As System.Windows.Forms.Button
    Friend WithEvents btn_exclui_client As System.Windows.Forms.Button
    Friend WithEvents btn_atualiza_client As System.Windows.Forms.Button
    Friend WithEvents btn_cadastra_client As System.Windows.Forms.Button
    Friend WithEvents btn_cadastra_end As System.Windows.Forms.Button
    Friend WithEvents box_cliente_cadastr As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cel_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dddcel_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_tel_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dddtel_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dtnascclient As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dtabertura_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cep_client As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cpfcliente_cadastr As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_rgcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_email_cliente As System.Windows.Forms.TextBox
End Class
