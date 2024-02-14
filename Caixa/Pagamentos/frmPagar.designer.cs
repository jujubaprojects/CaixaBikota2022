namespace Caixa
{
    partial class frmPagar
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
            this.btnPagar = new Componentes.ButtonJCS(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboAnotar = new Componentes.ComboBoxJCS(this.components);
            this.chkVlHaver = new Componentes.CheckBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtVlRecebido = new Componentes.TextBoxJCS(this.components);
            this.lblTroco = new Componentes.LabelJCS(this.components);
            this.txtDescPagamento = new Componentes.TextBoxJCS(this.components);
            this.lblAnotou = new Componentes.LabelJCS(this.components);
            this.btnDividirPagamento = new Componentes.ButtonJCS(this.components);
            this.txtValorAberto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.cboTipoPagamento = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPedProdAberto = new Componentes.DataGridViewJCS(this.components);
            this.colPedidoProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChkDividir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProdAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 30);
            this.panel1.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Gold;
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Image = global::Caixa.Properties.Resources.icons8_marcador_duplo_48;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(0, 0);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(434, 30);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Finalizar Pagamento";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboAnotar);
            this.panel2.Controls.Add(this.chkVlHaver);
            this.panel2.Controls.Add(this.labelJCS3);
            this.panel2.Controls.Add(this.txtVlRecebido);
            this.panel2.Controls.Add(this.lblTroco);
            this.panel2.Controls.Add(this.txtDescPagamento);
            this.panel2.Controls.Add(this.lblAnotou);
            this.panel2.Controls.Add(this.btnDividirPagamento);
            this.panel2.Controls.Add(this.txtValorAberto);
            this.panel2.Controls.Add(this.labelJCS2);
            this.panel2.Controls.Add(this.cboTipoPagamento);
            this.panel2.Controls.Add(this.labelJCS1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 162);
            this.panel2.TabIndex = 9;
            // 
            // cboAnotar
            // 
            this.cboAnotar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnotar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboAnotar.FormattingEnabled = true;
            this.cboAnotar.Location = new System.Drawing.Point(126, 127);
            this.cboAnotar.Name = "cboAnotar";
            this.cboAnotar.Size = new System.Drawing.Size(296, 23);
            this.cboAnotar.TabIndex = 23;
            this.cboAnotar.Visible = false;
            // 
            // chkVlHaver
            // 
            this.chkVlHaver.AutoSize = true;
            this.chkVlHaver.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkVlHaver.Location = new System.Drawing.Point(267, 71);
            this.chkVlHaver.Name = "chkVlHaver";
            this.chkVlHaver.Size = new System.Drawing.Size(161, 21);
            this.chkVlHaver.TabIndex = 22;
            this.chkVlHaver.Text = "Deixar valor em haver?";
            this.chkVlHaver.UseVisualStyleBackColor = true;
            this.chkVlHaver.Visible = false;
            this.chkVlHaver.CheckedChanged += new System.EventHandler(this.ChkVlHaver_CheckedChanged);
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(20, 71);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(100, 17);
            this.labelJCS3.TabIndex = 21;
            this.labelJCS3.Text = "Valor Recebido:";
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.BackColor = System.Drawing.Color.White;
            this.txtVlRecebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlRecebido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlRecebido.IconeKeyDown = null;
            this.txtVlRecebido.Location = new System.Drawing.Point(126, 68);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Preenchimento = null;
            this.txtVlRecebido.Size = new System.Drawing.Size(135, 24);
            this.txtVlRecebido.TabIndex = 20;
            this.txtVlRecebido.TipoCampo = "DOUBLE";
            this.txtVlRecebido.TextChanged += new System.EventHandler(this.TxtVlRecebido_TextChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(123, 95);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(138, 24);
            this.lblTroco.TabIndex = 19;
            this.lblTroco.Text = "Troco: R$ 00.00";
            // 
            // txtDescPagamento
            // 
            this.txtDescPagamento.BackColor = System.Drawing.Color.White;
            this.txtDescPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescPagamento.IconeKeyDown = null;
            this.txtDescPagamento.Location = new System.Drawing.Point(127, 127);
            this.txtDescPagamento.Name = "txtDescPagamento";
            this.txtDescPagamento.Preenchimento = null;
            this.txtDescPagamento.Size = new System.Drawing.Size(296, 24);
            this.txtDescPagamento.TabIndex = 16;
            this.txtDescPagamento.TipoCampo = null;
            this.txtDescPagamento.Visible = false;
            // 
            // lblAnotou
            // 
            this.lblAnotou.AutoSize = true;
            this.lblAnotou.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnotou.Location = new System.Drawing.Point(34, 130);
            this.lblAnotou.Name = "lblAnotou";
            this.lblAnotou.Size = new System.Drawing.Size(86, 17);
            this.lblAnotou.TabIndex = 15;
            this.lblAnotou.Text = "Anotou Para:";
            this.lblAnotou.Visible = false;
            // 
            // btnDividirPagamento
            // 
            this.btnDividirPagamento.BackColor = System.Drawing.Color.Gold;
            this.btnDividirPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividirPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDividirPagamento.Image = global::Caixa.Properties.Resources.icons8_equity_security_48;
            this.btnDividirPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDividirPagamento.Location = new System.Drawing.Point(267, 9);
            this.btnDividirPagamento.Name = "btnDividirPagamento";
            this.btnDividirPagamento.Size = new System.Drawing.Size(155, 53);
            this.btnDividirPagamento.TabIndex = 11;
            this.btnDividirPagamento.Text = "Dividir Prod.";
            this.btnDividirPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDividirPagamento.UseVisualStyleBackColor = false;
            this.btnDividirPagamento.Click += new System.EventHandler(this.BtnDividirPagamento_Click);
            // 
            // txtValorAberto
            // 
            this.txtValorAberto.BackColor = System.Drawing.Color.White;
            this.txtValorAberto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorAberto.Enabled = false;
            this.txtValorAberto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtValorAberto.IconeKeyDown = null;
            this.txtValorAberto.Location = new System.Drawing.Point(126, 38);
            this.txtValorAberto.Name = "txtValorAberto";
            this.txtValorAberto.Preenchimento = null;
            this.txtValorAberto.Size = new System.Drawing.Size(135, 24);
            this.txtValorAberto.TabIndex = 10;
            this.txtValorAberto.TipoCampo = "DOUBLE";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(34, 41);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(86, 17);
            this.labelJCS2.TabIndex = 9;
            this.labelJCS2.Text = "Valor Aberto:";
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
            "PIX",
            "NOTA",
            "DESCONTO"});
            this.cboTipoPagamento.Location = new System.Drawing.Point(126, 9);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(135, 23);
            this.cboTipoPagamento.TabIndex = 8;
            this.cboTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.CboTipoPagamento_SelectedIndexChanged);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 12);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(108, 17);
            this.labelJCS1.TabIndex = 7;
            this.labelJCS1.Text = "Tipo Pagamento:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPedProdAberto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 148);
            this.panel3.TabIndex = 10;
            // 
            // dgvPedProdAberto
            // 
            this.dgvPedProdAberto.AllowUserToAddRows = false;
            this.dgvPedProdAberto.AllowUserToDeleteRows = false;
            this.dgvPedProdAberto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedProdAberto.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedProdAberto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedProdAberto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedProdAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedProdAberto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedidoProdutoID,
            this.colProduto,
            this.colDescricao,
            this.colValor,
            this.colChkDividir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedProdAberto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedProdAberto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedProdAberto.EnableHeadersVisualStyles = false;
            this.dgvPedProdAberto.Location = new System.Drawing.Point(0, 0);
            this.dgvPedProdAberto.Name = "dgvPedProdAberto";
            this.dgvPedProdAberto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedProdAberto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedProdAberto.RowHeadersVisible = false;
            this.dgvPedProdAberto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedProdAberto.Size = new System.Drawing.Size(434, 148);
            this.dgvPedProdAberto.TabIndex = 8;
            this.dgvPedProdAberto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedProdAberto_CellContentClick);
            // 
            // colPedidoProdutoID
            // 
            this.colPedidoProdutoID.DataPropertyName = "PED_PROD_ID";
            this.colPedidoProdutoID.HeaderText = "ID";
            this.colPedidoProdutoID.Name = "colPedidoProdutoID";
            this.colPedidoProdutoID.ReadOnly = true;
            this.colPedidoProdutoID.Visible = false;
            this.colPedidoProdutoID.Width = 26;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.Width = 81;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESC_PRODUTO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VL_ABERTO";
            this.colValor.HeaderText = "Vl. Aberto";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 91;
            // 
            // colChkDividir
            // 
            this.colChkDividir.DataPropertyName = "CHKDIVIDIR";
            this.colChkDividir.FalseValue = "false";
            this.colChkDividir.HeaderText = "Dividir";
            this.colChkDividir.IndeterminateValue = "false";
            this.colChkDividir.Name = "colChkDividir";
            this.colChkDividir.ReadOnly = true;
            this.colChkDividir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChkDividir.TrueValue = "true";
            this.colChkDividir.Width = 70;
            // 
            // frmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 340);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPagar";
            this.Text = "Pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagar_KeyDown);
            this.MouseEnter += new System.EventHandler(this.FrmPagar_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProdAberto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Componentes.ButtonJCS btnPagar;
        private System.Windows.Forms.Panel panel2;
        private Componentes.ButtonJCS btnDividirPagamento;
        private Componentes.TextBoxJCS txtValorAberto;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.ComboBoxJCS cboTipoPagamento;
        private Componentes.LabelJCS labelJCS1;
        private System.Windows.Forms.Panel panel3;
        private Componentes.DataGridViewJCS dgvPedProdAberto;
        private Componentes.LabelJCS lblAnotou;
        private Componentes.LabelJCS lblTroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedidoProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChkDividir;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtVlRecebido;
        private Componentes.CheckBoxJCS chkVlHaver;
        private Componentes.TextBoxJCS txtDescPagamento;
        private Componentes.ComboBoxJCS cboAnotar;
    }
}