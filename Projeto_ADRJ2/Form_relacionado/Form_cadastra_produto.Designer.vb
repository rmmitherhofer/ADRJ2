<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cadastra_produto
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
        Me.btn_cadastra_produt = New System.Windows.Forms.Button
        Me.btn_atualiza_produt = New System.Windows.Forms.Button
        Me.btn_exclui_produt = New System.Windows.Forms.Button
        Me.btn_volta = New System.Windows.Forms.Button
        Me.btn_edita_produt = New System.Windows.Forms.Button
        Me.Combo_categoria = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_cod_produt = New System.Windows.Forms.TextBox
        Me.txt_cod_barra_produt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Produto = New System.Windows.Forms.TextBox
        Me.Box_produtoCadas = New System.Windows.Forms.GroupBox
        Me.txt_preco_custo_produt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_quant_produt = New System.Windows.Forms.TextBox
        Me.txt_fornecedor_produt = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_valor_produt = New System.Windows.Forms.TextBox
        Me.Box_produtoCadas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cadastra_produt
        '
        Me.btn_cadastra_produt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra_produt.Location = New System.Drawing.Point(412, 178)
        Me.btn_cadastra_produt.Name = "btn_cadastra_produt"
        Me.btn_cadastra_produt.Size = New System.Drawing.Size(99, 23)
        Me.btn_cadastra_produt.TabIndex = 167
        Me.btn_cadastra_produt.Text = "Cadastrar"
        Me.btn_cadastra_produt.UseVisualStyleBackColor = True
        '
        'btn_atualiza_produt
        '
        Me.btn_atualiza_produt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualiza_produt.Location = New System.Drawing.Point(118, 178)
        Me.btn_atualiza_produt.Name = "btn_atualiza_produt"
        Me.btn_atualiza_produt.Size = New System.Drawing.Size(106, 23)
        Me.btn_atualiza_produt.TabIndex = 166
        Me.btn_atualiza_produt.Text = "Atualizar"
        Me.btn_atualiza_produt.UseVisualStyleBackColor = True
        '
        'btn_exclui_produt
        '
        Me.btn_exclui_produt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exclui_produt.Location = New System.Drawing.Point(230, 178)
        Me.btn_exclui_produt.Name = "btn_exclui_produt"
        Me.btn_exclui_produt.Size = New System.Drawing.Size(107, 23)
        Me.btn_exclui_produt.TabIndex = 165
        Me.btn_exclui_produt.Text = "Excluir Produto"
        Me.btn_exclui_produt.UseVisualStyleBackColor = True
        '
        'btn_volta
        '
        Me.btn_volta.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volta.Location = New System.Drawing.Point(517, 178)
        Me.btn_volta.Name = "btn_volta"
        Me.btn_volta.Size = New System.Drawing.Size(75, 23)
        Me.btn_volta.TabIndex = 164
        Me.btn_volta.Text = "Voltar"
        Me.btn_volta.UseVisualStyleBackColor = True
        '
        'btn_edita_produt
        '
        Me.btn_edita_produt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edita_produt.Location = New System.Drawing.Point(12, 178)
        Me.btn_edita_produt.Name = "btn_edita_produt"
        Me.btn_edita_produt.Size = New System.Drawing.Size(100, 23)
        Me.btn_edita_produt.TabIndex = 163
        Me.btn_edita_produt.Text = "Editar"
        Me.btn_edita_produt.UseVisualStyleBackColor = True
        '
        'Combo_categoria
        '
        Me.Combo_categoria.FormattingEnabled = True
        Me.Combo_categoria.Items.AddRange(New Object() {"Acessorios para Bateria", "Acessorios para Guitarras", "Amplificadores Bass", "Amplificadores Guitarra", "Bass", "Bateria", "Cavacos", "CD", "DVD", "Guitarra", "Microfones", "Pedais", "Percusão", "Piano", "Pratos", "Sopro", "Teclado", "Violão"})
        Me.Combo_categoria.Location = New System.Drawing.Point(378, 103)
        Me.Combo_categoria.MaxLength = 25
        Me.Combo_categoria.Name = "Combo_categoria"
        Me.Combo_categoria.Size = New System.Drawing.Size(186, 21)
        Me.Combo_categoria.TabIndex = 161
        Me.Combo_categoria.Text = "Selecionar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(314, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "*Categoria:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(188, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 15)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "*Valor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "*Fornecedor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Código de Barras:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Código:"
        '
        'txt_cod_produt
        '
        Me.txt_cod_produt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_produt.ForeColor = System.Drawing.Color.Red
        Me.txt_cod_produt.Location = New System.Drawing.Point(64, 19)
        Me.txt_cod_produt.MaxLength = 4
        Me.txt_cod_produt.Name = "txt_cod_produt"
        Me.txt_cod_produt.Size = New System.Drawing.Size(58, 20)
        Me.txt_cod_produt.TabIndex = 136
        Me.txt_cod_produt.Text = "000000"
        '
        'txt_cod_barra_produt
        '
        Me.txt_cod_barra_produt.Location = New System.Drawing.Point(112, 78)
        Me.txt_cod_barra_produt.MaxLength = 45
        Me.txt_cod_barra_produt.Name = "txt_cod_barra_produt"
        Me.txt_cod_barra_produt.Size = New System.Drawing.Size(364, 20)
        Me.txt_cod_barra_produt.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "*Produto:"
        '
        'txt_Produto
        '
        Me.txt_Produto.Location = New System.Drawing.Point(72, 52)
        Me.txt_Produto.MaxLength = 35
        Me.txt_Produto.Name = "txt_Produto"
        Me.txt_Produto.Size = New System.Drawing.Size(492, 20)
        Me.txt_Produto.TabIndex = 123
        '
        'Box_produtoCadas
        '
        Me.Box_produtoCadas.Controls.Add(Me.txt_valor_produt)
        Me.Box_produtoCadas.Controls.Add(Me.txt_preco_custo_produt)
        Me.Box_produtoCadas.Controls.Add(Me.Label4)
        Me.Box_produtoCadas.Controls.Add(Me.txt_quant_produt)
        Me.Box_produtoCadas.Controls.Add(Me.txt_fornecedor_produt)
        Me.Box_produtoCadas.Controls.Add(Me.Label3)
        Me.Box_produtoCadas.Controls.Add(Me.Combo_categoria)
        Me.Box_produtoCadas.Controls.Add(Me.Label16)
        Me.Box_produtoCadas.Controls.Add(Me.Label14)
        Me.Box_produtoCadas.Controls.Add(Me.Label13)
        Me.Box_produtoCadas.Controls.Add(Me.Label11)
        Me.Box_produtoCadas.Controls.Add(Me.Label2)
        Me.Box_produtoCadas.Controls.Add(Me.txt_cod_produt)
        Me.Box_produtoCadas.Controls.Add(Me.txt_cod_barra_produt)
        Me.Box_produtoCadas.Controls.Add(Me.Label1)
        Me.Box_produtoCadas.Controls.Add(Me.txt_Produto)
        Me.Box_produtoCadas.Location = New System.Drawing.Point(6, 4)
        Me.Box_produtoCadas.Name = "Box_produtoCadas"
        Me.Box_produtoCadas.Size = New System.Drawing.Size(591, 168)
        Me.Box_produtoCadas.TabIndex = 170
        Me.Box_produtoCadas.TabStop = False
        Me.Box_produtoCadas.Text = "Produto"
        '
        'txt_preco_custo_produt
        '
        Me.txt_preco_custo_produt.Location = New System.Drawing.Point(105, 129)
        Me.txt_preco_custo_produt.MaxLength = 8
        Me.txt_preco_custo_produt.Name = "txt_preco_custo_produt"
        Me.txt_preco_custo_produt.Size = New System.Drawing.Size(77, 20)
        Me.txt_preco_custo_produt.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "*Quantidade:"
        '
        'txt_quant_produt
        '
        Me.txt_quant_produt.Location = New System.Drawing.Point(421, 129)
        Me.txt_quant_produt.MaxLength = 3
        Me.txt_quant_produt.Name = "txt_quant_produt"
        Me.txt_quant_produt.Size = New System.Drawing.Size(38, 20)
        Me.txt_quant_produt.TabIndex = 173
        '
        'txt_fornecedor_produt
        '
        Me.txt_fornecedor_produt.FormattingEnabled = True
        Me.txt_fornecedor_produt.Items.AddRange(New Object() {"Boss", "Cherub", "Condor", "Digitech", "Dijiorgio", "Eagle", "Epiphone", "ESP", "Fender", "Giannini", "Gibson", "Golden", "Gotoh", "Ibanez", "Laney", "Line 6", "Machael", "Mapex", "Marshall", "Meteoro", "Monner", "Nig", "NUX", "Orion", "Pearl", "RMV", "Santo Angelo", "Shelter", "Shure", "Strinberg", "Tagima", "VOX", "Warm Music", "Yamaha", "Zildjan"})
        Me.txt_fornecedor_produt.Location = New System.Drawing.Point(88, 103)
        Me.txt_fornecedor_produt.MaxLength = 45
        Me.txt_fornecedor_produt.Name = "txt_fornecedor_produt"
        Me.txt_fornecedor_produt.Size = New System.Drawing.Size(220, 21)
        Me.txt_fornecedor_produt.TabIndex = 172
        Me.txt_fornecedor_produt.Text = "Selecionar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "*Preço de Custo:"
        '
        'txt_valor_produt
        '
        Me.txt_valor_produt.Location = New System.Drawing.Point(232, 129)
        Me.txt_valor_produt.MaxLength = 8
        Me.txt_valor_produt.Name = "txt_valor_produt"
        Me.txt_valor_produt.Size = New System.Drawing.Size(77, 20)
        Me.txt_valor_produt.TabIndex = 176
        '
        'Form_cadastra_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 210)
        Me.Controls.Add(Me.Box_produtoCadas)
        Me.Controls.Add(Me.btn_cadastra_produt)
        Me.Controls.Add(Me.btn_atualiza_produt)
        Me.Controls.Add(Me.btn_exclui_produt)
        Me.Controls.Add(Me.btn_volta)
        Me.Controls.Add(Me.btn_edita_produt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_cadastra_produto"
        Me.Text = "Produto"
        Me.Box_produtoCadas.ResumeLayout(False)
        Me.Box_produtoCadas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cadastra_produt As System.Windows.Forms.Button
    Friend WithEvents btn_atualiza_produt As System.Windows.Forms.Button
    Friend WithEvents btn_exclui_produt As System.Windows.Forms.Button
    Friend WithEvents btn_volta As System.Windows.Forms.Button
    Friend WithEvents btn_edita_produt As System.Windows.Forms.Button
    Friend WithEvents Combo_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_produt As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_barra_produt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Produto As System.Windows.Forms.TextBox
    Friend WithEvents Box_produtoCadas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fornecedor_produt As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_quant_produt As System.Windows.Forms.TextBox
    Friend WithEvents txt_preco_custo_produt As System.Windows.Forms.TextBox
    Friend WithEvents txt_valor_produt As System.Windows.Forms.TextBox
End Class
