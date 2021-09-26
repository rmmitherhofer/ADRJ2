<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastra_endereco
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_lograd_endereco = New System.Windows.Forms.TextBox
        Me.txt_bairro_endereco = New System.Windows.Forms.TextBox
        Me.txt_cidade_endereco = New System.Windows.Forms.TextBox
        Me.btn_salva_endereco = New System.Windows.Forms.Button
        Me.btn_cancela_endereco = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Combo_uf_end = New System.Windows.Forms.ComboBox
        Me.txt_cep_endereco = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "*CEP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(531, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "*UF:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(301, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 15)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "*Cidade:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "*Bairro:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "*Logradouro:"
        '
        'txt_lograd_endereco
        '
        Me.txt_lograd_endereco.Location = New System.Drawing.Point(100, 52)
        Me.txt_lograd_endereco.MaxLength = 60
        Me.txt_lograd_endereco.Name = "txt_lograd_endereco"
        Me.txt_lograd_endereco.Size = New System.Drawing.Size(364, 20)
        Me.txt_lograd_endereco.TabIndex = 96
        '
        'txt_bairro_endereco
        '
        Me.txt_bairro_endereco.Location = New System.Drawing.Point(74, 82)
        Me.txt_bairro_endereco.MaxLength = 40
        Me.txt_bairro_endereco.Name = "txt_bairro_endereco"
        Me.txt_bairro_endereco.Size = New System.Drawing.Size(221, 20)
        Me.txt_bairro_endereco.TabIndex = 94
        '
        'txt_cidade_endereco
        '
        Me.txt_cidade_endereco.Location = New System.Drawing.Point(353, 82)
        Me.txt_cidade_endereco.MaxLength = 30
        Me.txt_cidade_endereco.Name = "txt_cidade_endereco"
        Me.txt_cidade_endereco.Size = New System.Drawing.Size(172, 20)
        Me.txt_cidade_endereco.TabIndex = 93
        '
        'btn_salva_endereco
        '
        Me.btn_salva_endereco.Location = New System.Drawing.Point(496, 142)
        Me.btn_salva_endereco.Name = "btn_salva_endereco"
        Me.btn_salva_endereco.Size = New System.Drawing.Size(111, 23)
        Me.btn_salva_endereco.TabIndex = 107
        Me.btn_salva_endereco.Text = "Salvar"
        Me.btn_salva_endereco.UseVisualStyleBackColor = True
        '
        'btn_cancela_endereco
        '
        Me.btn_cancela_endereco.Location = New System.Drawing.Point(370, 142)
        Me.btn_cancela_endereco.Name = "btn_cancela_endereco"
        Me.btn_cancela_endereco.Size = New System.Drawing.Size(111, 23)
        Me.btn_cancela_endereco.TabIndex = 108
        Me.btn_cancela_endereco.Text = "Cancelar"
        Me.btn_cancela_endereco.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Para Cadastrar endereços é necessário preencher todos os campos"
        '
        'Combo_uf_end
        '
        Me.Combo_uf_end.BackColor = System.Drawing.Color.White
        Me.Combo_uf_end.FormattingEnabled = True
        Me.Combo_uf_end.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MG", "MR", "MR", "MS", "MT", "ND", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RS", "SC", "SE", "SP"})
        Me.Combo_uf_end.Location = New System.Drawing.Point(564, 82)
        Me.Combo_uf_end.MaxLength = 2
        Me.Combo_uf_end.Name = "Combo_uf_end"
        Me.Combo_uf_end.Size = New System.Drawing.Size(46, 21)
        Me.Combo_uf_end.TabIndex = 110
        '
        'txt_cep_endereco
        '
        Me.txt_cep_endereco.Location = New System.Drawing.Point(64, 111)
        Me.txt_cep_endereco.Mask = "00000-000"
        Me.txt_cep_endereco.Name = "txt_cep_endereco"
        Me.txt_cep_endereco.Size = New System.Drawing.Size(71, 20)
        Me.txt_cep_endereco.TabIndex = 111
        '
        'Form_cadastra_endereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 184)
        Me.Controls.Add(Me.txt_cep_endereco)
        Me.Controls.Add(Me.Combo_uf_end)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancela_endereco)
        Me.Controls.Add(Me.btn_salva_endereco)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_lograd_endereco)
        Me.Controls.Add(Me.txt_bairro_endereco)
        Me.Controls.Add(Me.txt_cidade_endereco)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastra_endereco"
        Me.Text = "Cadastrar Endereço"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_lograd_endereco As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_endereco As System.Windows.Forms.TextBox
    Friend WithEvents txt_cidade_endereco As System.Windows.Forms.TextBox
    Friend WithEvents btn_salva_endereco As System.Windows.Forms.Button
    Friend WithEvents btn_cancela_endereco As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combo_uf_end As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cep_endereco As System.Windows.Forms.MaskedTextBox
End Class
