namespace Caixa
{
    partial class frmPagarNota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizarPagamento = new Componentes.ButtonJCS(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProdutoPai = new Componentes.ComboBoxJCS(this.components);
            this.cboProdutoFilho = new Componentes.ComboBoxJCS(this.components);
            this.cboTipoPagamento = new Componentes.ComboBoxJCS(this.components);
            this.lblTroco = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.txtVlRecebido = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtVlTotal = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.btnAdddProduto = new Componentes.ButtonJCS(this.components);
            this.txtQuantidade = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new Componentes.DataGridViewJCS(this.components);
            this.colProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalizarPagamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 30);
            this.panel1.TabIndex = 7;
            // 
            // btnFinalizarPagamento
            // 
            this.btnFinalizarPagamento.BackColor = System.Drawing.Color.Gold;
            this.btnFinalizarPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarPagamento.Image = global::Caixa.Properties.Resources.icons8_marcador_duplo_48;
            this.btnFinalizarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarPagamento.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizarPagamento.Name = "btnFinalizarPagamento";
            this.btnFinalizarPagamento.Size = new System.Drawing.Size(415, 30);
            this.btnFinalizarPagamento.TabIndex = 0;
            this.btnFinalizarPagamento.Text = "Finalizar Pagamento";
            this.btnFinalizarPagamento.UseVisualStyleBackColor = false;
            this.btnFinalizarPagamento.Click += new System.EventHandler(this.BtnFinalizarPagamento_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboProdutoPai);
            this.panel2.Controls.Add(this.cboProdutoFilho);
            this.panel2.Controls.Add(this.cboTipoPagamento);
            this.panel2.Controls.Add(this.lblTroco);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.labelJCS6);
            this.panel2.Controls.Add(this.txtVlRecebido);
            this.panel2.Controls.Add(this.labelJCS4);
            this.panel2.Controls.Add(this.txtVlTotal);
            this.panel2.Controls.Add(this.labelJCS3);
            this.panel2.Controls.Add(this.btnAdddProduto);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.labelJCS2);
            this.panel2.Controls.Add(this.labelJCS1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 166);
            this.panel2.TabIndex = 8;
            // 
            // cboProdutoPai
            // 
            this.cboProdutoPai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoPai.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoPai.FormattingEnabled = true;
            this.cboProdutoPai.Location = new System.Drawing.Point(101, 9);
            this.cboProdutoPai.Name = "cboProdutoPai";
            this.cboProdutoPai.Size = new System.Drawing.Size(109, 23);
            this.cboProdutoPai.TabIndex = 26;
            this.cboProdutoPai.SelectedIndexChanged += new System.EventHandler(this.CboProdutoPai_SelectedIndexChanged);
            // 
            // cboProdutoFilho
            // 
            this.cboProdutoFilho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoFilho.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoFilho.FormattingEnabled = true;
            this.cboProdutoFilho.Location = new System.Drawing.Point(216, 9);
            this.cboProdutoFilho.Name = "cboProdutoFilho";
            this.cboProdutoFilho.Size = new System.Drawing.Size(180, 23);
            this.cboProdutoFilho.TabIndex = 27;
            // 
            // cboTipoPagamento
            // 
            this.cboTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipoPagamento.FormattingEnabled = true;
            this.cboTipoPagamento.Items.AddRange(new object[] {
            "DINHEIRO",
            "CARTÃO DÉBITO",
            "CARTÃO CRÉDITO",
            "ANOTAR"});
            this.cboTipoPagamento.Location = new System.Drawing.Point(101, 70);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(109, 23);
            this.cboTipoPagamento.TabIndex = 25;
            this.cboTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.CboTipoPagamento_SelectedIndexChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(246, 114);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(138, 24);
            this.lblTroco.TabIndex = 24;
            this.lblTroco.Text = "Troco: R$ 00.00";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(216, 70);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(180, 24);
            this.txtDescricao.TabIndex = 23;
            this.txtDescricao.TipoCampo = null;
            this.txtDescricao.Visible = false;
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(29, 73);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(66, 17);
            this.labelJCS6.TabIndex = 21;
            this.labelJCS6.Text = "Tipo Pag.:";
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.BackColor = System.Drawing.Color.White;
            this.txtVlRecebido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlRecebido.IconeKeyDown = null;
            this.txtVlRecebido.Location = new System.Drawing.Point(101, 129);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Preenchimento = null;
            this.txtVlRecebido.Size = new System.Drawing.Size(109, 24);
            this.txtVlRecebido.TabIndex = 18;
            this.txtVlRecebido.TipoCampo = "DOUBLE";
            this.txtVlRecebido.TextChanged += new System.EventHandler(this.TxtVlRecebido_TextChanged);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(10, 132);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(85, 17);
            this.labelJCS4.TabIndex = 17;
            this.labelJCS4.Text = "Vl. Recebido:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.BackColor = System.Drawing.Color.White;
            this.txtVlTotal.Enabled = false;
            this.txtVlTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlTotal.IconeKeyDown = null;
            this.txtVlTotal.Location = new System.Drawing.Point(101, 99);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.Preenchimento = null;
            this.txtVlTotal.Size = new System.Drawing.Size(109, 24);
            this.txtVlTotal.TabIndex = 16;
            this.txtVlTotal.Text = "0";
            this.txtVlTotal.TipoCampo = null;
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(36, 102);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(59, 17);
            this.labelJCS3.TabIndex = 15;
            this.labelJCS3.Text = "Vl. Total:";
            // 
            // btnAdddProduto
            // 
            this.btnAdddProduto.BackColor = System.Drawing.Color.Gold;
            this.btnAdddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdddProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdddProduto.Image = global::Caixa.Properties.Resources.icons8_adicionar_20;
            this.btnAdddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdddProduto.Location = new System.Drawing.Point(216, 42);
            this.btnAdddProduto.Name = "btnAdddProduto";
            this.btnAdddProduto.Size = new System.Drawing.Size(180, 24);
            this.btnAdddProduto.TabIndex = 11;
            this.btnAdddProduto.Text = "Adicionar";
            this.btnAdddProduto.UseVisualStyleBackColor = false;
            this.btnAdddProduto.Click += new System.EventHandler(this.BtnAdddProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.IconeKeyDown = null;
            this.txtQuantidade.Location = new System.Drawing.Point(101, 42);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Preenchimento = null;
            this.txtQuantidade.Size = new System.Drawing.Size(109, 24);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TipoCampo = "INTEIRO";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 45);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(83, 17);
            this.labelJCS2.TabIndex = 9;
            this.labelJCS2.Text = "Quantidade:";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(34, 15);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 6;
            this.labelJCS1.Text = "Produto:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProdutos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 148);
            this.panel3.TabIndex = 9;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdutoID,
            this.colProduto,
            this.colQuantidade,
            this.colValor,
            this.colVlTotal,
            this.colExcluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(415, 148);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // colProdutoID
            // 
            this.colProdutoID.DataPropertyName = "ID";
            this.colProdutoID.HeaderText = "ProdutoID";
            this.colProdutoID.Name = "colProdutoID";
            this.colProdutoID.ReadOnly = true;
            this.colProdutoID.Visible = false;
            this.colProdutoID.Width = 95;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "QT";
            this.colQuantidade.HeaderText = "Qt.";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantidade.Width = 33;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VL_PRODUTO";
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValor.Width = 44;
            // 
            // colVlTotal
            // 
            this.colVlTotal.DataPropertyName = "VL_TOTAL";
            this.colVlTotal.HeaderText = "Vl. Total";
            this.colVlTotal.Name = "colVlTotal";
            this.colVlTotal.ReadOnly = true;
            this.colVlTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVlTotal.Width = 61;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Del";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 33;
            // 
            // frmPedidoRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 344);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmPedidoRapido";
            this.Text = "frmPedidoRapido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidoRapido_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPedidoRapido_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Componentes.ButtonJCS btnFinalizarPagamento;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ButtonJCS btnAdddProduto;
        private Componentes.TextBoxJCS txtQuantidade;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS1;
        private System.Windows.Forms.Panel panel3;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.TextBoxJCS txtVlRecebido;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtVlTotal;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS lblTroco;
        private Componentes.DataGridViewJCS dgvProdutos;
        private Componentes.ComboBoxJCS cboTipoPagamento;
        private Componentes.ComboBoxJCS cboProdutoPai;
        private Componentes.ComboBoxJCS cboProdutoFilho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlTotal;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}