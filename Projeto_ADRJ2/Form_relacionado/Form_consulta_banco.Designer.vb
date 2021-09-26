<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_consulta_banco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_consulta_banco))
        Me.dgv_consulta_dado = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Combo_tipo_consu = New System.Windows.Forms.ComboBox
        Me.btn_procura_consu = New System.Windows.Forms.Button
        Me.txt_procura_dado = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_sai_consu = New System.Windows.Forms.Button
        Me.btn_alterafornecedor = New System.Windows.Forms.Button
        Me.btn_altera_filial = New System.Windows.Forms.Button
        CType(Me.dgv_consulta_dado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_consulta_dado
        '
        Me.dgv_consulta_dado.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgv_consulta_dado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgv_consulta_dado, "dgv_consulta_dado")
        Me.dgv_consulta_dado.Name = "dgv_consulta_dado"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Combo_tipo_consu
        '
        Me.Combo_tipo_consu.FormattingEnabled = True
        Me.Combo_tipo_consu.Items.AddRange(New Object() {resources.GetString("Combo_tipo_consu.Items"), resources.GetString("Combo_tipo_consu.Items1"), resources.GetString("Combo_tipo_consu.Items2"), resources.GetString("Combo_tipo_consu.Items3"), resources.GetString("Combo_tipo_consu.Items4"), resources.GetString("Combo_tipo_consu.Items5"), resources.GetString("Combo_tipo_consu.Items6"), resources.GetString("Combo_tipo_consu.Items7")})
        resources.ApplyResources(Me.Combo_tipo_consu, "Combo_tipo_consu")
        Me.Combo_tipo_consu.Name = "Combo_tipo_consu"
        '
        'btn_procura_consu
        '
        resources.ApplyResources(Me.btn_procura_consu, "btn_procura_consu")
        Me.btn_procura_consu.Name = "btn_procura_consu"
        Me.btn_procura_consu.UseVisualStyleBackColor = True
        '
        'txt_procura_dado
        '
        resources.ApplyResources(Me.txt_procura_dado, "txt_procura_dado")
        Me.txt_procura_dado.Name = "txt_procura_dado"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btn_sai_consu
        '
        resources.ApplyResources(Me.btn_sai_consu, "btn_sai_consu")
        Me.btn_sai_consu.Name = "btn_sai_consu"
        Me.btn_sai_consu.UseVisualStyleBackColor = True
        '
        'btn_alterafornecedor
        '
        resources.ApplyResources(Me.btn_alterafornecedor, "btn_alterafornecedor")
        Me.btn_alterafornecedor.Name = "btn_alterafornecedor"
        Me.btn_alterafornecedor.UseVisualStyleBackColor = True
        '
        'btn_altera_filial
        '
        Me.btn_altera_filial.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btn_altera_filial, "btn_altera_filial")
        Me.btn_altera_filial.Name = "btn_altera_filial"
        Me.btn_altera_filial.UseVisualStyleBackColor = False
        '
        'Form_consulta_banco
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_altera_filial)
        Me.Controls.Add(Me.btn_alterafornecedor)
        Me.Controls.Add(Me.btn_sai_consu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_procura_dado)
        Me.Controls.Add(Me.btn_procura_consu)
        Me.Controls.Add(Me.Combo_tipo_consu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_consulta_dado)
        Me.MaximizeBox = False
        Me.Name = "Form_consulta_banco"
        Me.ShowInTaskbar = False
        CType(Me.dgv_consulta_dado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_consulta_dado As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combo_tipo_consu As System.Windows.Forms.ComboBox
    Friend WithEvents btn_procura_consu As System.Windows.Forms.Button
    Friend WithEvents txt_procura_dado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_sai_consu As System.Windows.Forms.Button
    Friend WithEvents btn_alterafornecedor As System.Windows.Forms.Button
    Friend WithEvents btn_altera_filial As System.Windows.Forms.Button
End Class
