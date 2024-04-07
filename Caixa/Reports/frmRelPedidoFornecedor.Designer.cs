namespace Caixa.Reports
{
    partial class frmRelPedidoFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.groupBoxJCS2 = new Componentes.GroupBoxJCS(this.components);
            this.dgvInformacao = new Componentes.DataGridViewJCS(this.components);
            this.colIDEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEstIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInformação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboFornecedor = new Componentes.ComboBoxJCS(this.components);
            this.groupBoxJCS1.SuspendLayout();
            this.groupBoxJCS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.cboFornecedor);
            this.groupBoxJCS1.Controls.Add(this.labelJCS1);
            this.groupBoxJCS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(1157, 62);
            this.groupBoxJCS1.TabIndex = 1;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtro";
            // 
            // groupBoxJCS2
            // 
            this.groupBoxJCS2.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS2.Controls.Add(this.dgvInformacao);
            this.groupBoxJCS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS2.Location = new System.Drawing.Point(0, 62);
            this.groupBoxJCS2.Name = "groupBoxJCS2";
            this.groupBoxJCS2.Size = new System.Drawing.Size(1157, 388);
            this.groupBoxJCS2.TabIndex = 2;
            this.groupBoxJCS2.TabStop = false;
            // 
            // dgvInformacao
            // 
            this.dgvInformacao.AllowUserToAddRows = false;
            this.dgvInformacao.AllowUserToDeleteRows = false;
            this.dgvInformacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInformacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInformacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEstoque,
            this.colDescEstoque,
            this.colQtEst,
            this.colQtEstIdeal,
            this.colVerificar,
            this.colInformação});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformacao.EnableHeadersVisualStyles = false;
            this.dgvInformacao.Location = new System.Drawing.Point(3, 20);
            this.dgvInformacao.Name = "dgvInformacao";
            this.dgvInformacao.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInformacao.RowHeadersVisible = false;
            this.dgvInformacao.RowTemplate.Height = 100;
            this.dgvInformacao.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformacao.Size = new System.Drawing.Size(1151, 365);
            this.dgvInformacao.TabIndex = 1;
            // 
            // colIDEstoque
            // 
            this.colIDEstoque.DataPropertyName = "ID";
            this.colIDEstoque.HeaderText = "ID";
            this.colIDEstoque.Name = "colIDEstoque";
            this.colIDEstoque.ReadOnly = true;
            this.colIDEstoque.Visible = false;
            this.colIDEstoque.Width = 27;
            // 
            // colDescEstoque
            // 
            this.colDescEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescEstoque.DataPropertyName = "DESC_ESTOQUE";
            this.colDescEstoque.HeaderText = "Estoque";
            this.colDescEstoque.Name = "colDescEstoque";
            this.colDescEstoque.ReadOnly = true;
            this.colDescEstoque.Width = 82;
            // 
            // colQtEst
            // 
            this.colQtEst.DataPropertyName = "QT_EST";
            this.colQtEst.HeaderText = "QT. Est.";
            this.colQtEst.Name = "colQtEst";
            this.colQtEst.ReadOnly = true;
            this.colQtEst.Width = 78;
            // 
            // colQtEstIdeal
            // 
            this.colQtEstIdeal.DataPropertyName = "EST_IDEAL";
            this.colQtEstIdeal.HeaderText = "Qt. Ideal";
            this.colQtEstIdeal.Name = "colQtEstIdeal";
            this.colQtEstIdeal.ReadOnly = true;
            this.colQtEstIdeal.Width = 84;
            // 
            // colVerificar
            // 
            this.colVerificar.DataPropertyName = "VERIFICAR";
            this.colVerificar.FalseValue = "0";
            this.colVerificar.HeaderText = "Verificar";
            this.colVerificar.Name = "colVerificar";
            this.colVerificar.ReadOnly = true;
            this.colVerificar.TrueValue = "1";
            this.colVerificar.Width = 62;
            // 
            // colInformação
            // 
            this.colInformação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInformação.DataPropertyName = "HISTORICO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colInformação.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInformação.HeaderText = "Ultimos 4 Pedidos";
            this.colInformação.Name = "colInformação";
            this.colInformação.ReadOnly = true;
            this.colInformação.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInformação.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 20);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(80, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Fornecedor:";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(98, 17);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(1047, 23);
            this.cboFornecedor.TabIndex = 1;
            this.cboFornecedor.SelectedIndexChanged += new System.EventHandler(this.CboFornecedor_SelectedIndexChanged);
            // 
            // frmRelPedidoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.groupBoxJCS2);
            this.Controls.Add(this.groupBoxJCS1);
            this.Name = "frmRelPedidoFornecedor";
            this.Text = "Pedido de Produtos para os Fornecedores";
            this.Load += new System.EventHandler(this.FrmRelPedidoFornecedor_Load);
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.groupBoxJCS2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.GroupBoxJCS groupBoxJCS2;
        private Componentes.DataGridViewJCS dgvInformacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEstIdeal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVerificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformação;
        private Componentes.ComboBoxJCS cboFornecedor;
        private Componentes.LabelJCS labelJCS1;
    }
}