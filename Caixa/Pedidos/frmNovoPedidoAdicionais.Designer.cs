namespace Caixa.Pedidos
{
    partial class frmNovoPedidoAdicionais
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
            this.lblValor = new Componentes.LabelJCS(this.components);
            this.txtObservacao = new Componentes.TextBoxJCS(this.components);
            this.txtQuantidade = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboAdicional = new Componentes.ComboBoxJCS(this.components);
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.labelJCS7 = new Componentes.LabelJCS(this.components);
            this.btnAddAdicional = new Componentes.ButtonJCS(this.components);
            this.dgvAdicionais = new Componentes.DataGridViewJCS(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new Componentes.ButtonJCS(this.components);
            this.colPedProdAddID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = System.Drawing.Color.Red;
            this.lblValor.Location = new System.Drawing.Point(227, 133);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(182, 24);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor Total: R$ 00.00";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtObservacao.IconeKeyDown = null;
            this.txtObservacao.Location = new System.Drawing.Point(100, 70);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Preenchimento = null;
            this.txtObservacao.Size = new System.Drawing.Size(295, 24);
            this.txtObservacao.TabIndex = 4;
            this.txtObservacao.TipoCampo = null;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.IconeKeyDown = null;
            this.txtQuantidade.Location = new System.Drawing.Point(286, 40);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Preenchimento = null;
            this.txtQuantidade.Size = new System.Drawing.Size(109, 24);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TipoCampo = "INTEIRO";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(33, 14);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 32;
            this.labelJCS1.Text = "Produto:";
            // 
            // cboAdicional
            // 
            this.cboAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdicional.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(100, 41);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(180, 23);
            this.cboAdicional.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.IconeKeyDown = null;
            this.txtProduto.Location = new System.Drawing.Point(100, 11);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(295, 24);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TipoCampo = "STRING";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(28, 47);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(66, 17);
            this.labelJCS5.TabIndex = 40;
            this.labelJCS5.Text = "Adicional:";
            // 
            // labelJCS7
            // 
            this.labelJCS7.AutoSize = true;
            this.labelJCS7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS7.Location = new System.Drawing.Point(11, 80);
            this.labelJCS7.Name = "labelJCS7";
            this.labelJCS7.Size = new System.Drawing.Size(82, 17);
            this.labelJCS7.TabIndex = 41;
            this.labelJCS7.Text = "Observação:";
            // 
            // btnAddAdicional
            // 
            this.btnAddAdicional.BackColor = System.Drawing.Color.Gold;
            this.btnAddAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdicional.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAdicional.Image = global::Caixa.Properties.Resources.icons8_adicionar_20;
            this.btnAddAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdicional.Location = new System.Drawing.Point(100, 100);
            this.btnAddAdicional.Name = "btnAddAdicional";
            this.btnAddAdicional.Size = new System.Drawing.Size(295, 24);
            this.btnAddAdicional.TabIndex = 5;
            this.btnAddAdicional.Text = "Adicionar";
            this.btnAddAdicional.UseVisualStyleBackColor = false;
            this.btnAddAdicional.Click += new System.EventHandler(this.BtnAddAdicional_Click);
            // 
            // dgvAdicionais
            // 
            this.dgvAdicionais.AllowUserToAddRows = false;
            this.dgvAdicionais.AllowUserToDeleteRows = false;
            this.dgvAdicionais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdicionais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdicionais.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedProdAddID,
            this.colProduto,
            this.colDescricao,
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
            this.dgvAdicionais.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdicionais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdicionais.EnableHeadersVisualStyles = false;
            this.dgvAdicionais.Location = new System.Drawing.Point(0, 0);
            this.dgvAdicionais.Name = "dgvAdicionais";
            this.dgvAdicionais.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdicionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdicionais.Size = new System.Drawing.Size(412, 282);
            this.dgvAdicionais.TabIndex = 42;
            this.dgvAdicionais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAdicionais_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboAdicional);
            this.panel1.Controls.Add(this.labelJCS1);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.labelJCS7);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.labelJCS5);
            this.panel1.Controls.Add(this.btnAddAdicional);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 168);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAdicionais);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 282);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 36);
            this.panel3.TabIndex = 42;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(412, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // colPedProdAddID
            // 
            this.colPedProdAddID.DataPropertyName = "ID";
            this.colPedProdAddID.HeaderText = "PedProdAddID";
            this.colPedProdAddID.Name = "colPedProdAddID";
            this.colPedProdAddID.ReadOnly = true;
            this.colPedProdAddID.Visible = false;
            this.colPedProdAddID.Width = 120;
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
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 90;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "QT_PRODUTO";
            this.colQuantidade.HeaderText = "Qt.";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantidade.Width = 33;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VALOR";
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
            // frmNovoPedidoAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(428, 489);
            this.MinimumSize = new System.Drawing.Size(428, 489);
            this.Name = "frmNovoPedidoAdicionais";
            this.Text = "frmNovoPedidoAdicionais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.LabelJCS lblValor;
        private Componentes.TextBoxJCS txtObservacao;
        private Componentes.ButtonJCS btnAddAdicional;
        private Componentes.TextBoxJCS txtQuantidade;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ComboBoxJCS cboAdicional;
        private Componentes.TextBoxJCS txtProduto;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.LabelJCS labelJCS7;
        private Componentes.DataGridViewJCS dgvAdicionais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Componentes.ButtonJCS btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedProdAddID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlTotal;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}