namespace Caixa.Estoque
{
    partial class frmLinkProdNFFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIDFornecedor = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtDescFornecedor = new Componentes.TextBoxJCS(this.components);
            this.txtDescricaoEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtIdEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.txtIDProd = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.dgvLink = new Componentes.DataGridViewJCS(this.components);
            this.colProdutoNFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscaFornecedor = new Componentes.ButtonJCS(this.components);
            this.btnLinkar = new Componentes.ButtonJCS(this.components);
            this.btnBuscaControlEstq = new Componentes.ButtonJCS(this.components);
            this.btnBuscaProdutoNFe = new Componentes.ButtonJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.BackColor = System.Drawing.Color.White;
            this.txtIDFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDFornecedor.Enabled = false;
            this.txtIDFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDFornecedor.IconeKeyDown = null;
            this.txtIDFornecedor.Location = new System.Drawing.Point(112, 40);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Preenchimento = null;
            this.txtIDFornecedor.Size = new System.Drawing.Size(47, 24);
            this.txtIDFornecedor.TabIndex = 73;
            this.txtIDFornecedor.TipoCampo = "STRING";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(26, 45);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(80, 17);
            this.labelJCS4.TabIndex = 72;
            this.labelJCS4.Text = "Fornecedor:";
            // 
            // txtDescFornecedor
            // 
            this.txtDescFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescFornecedor.BackColor = System.Drawing.Color.White;
            this.txtDescFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescFornecedor.Enabled = false;
            this.txtDescFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescFornecedor.IconeKeyDown = null;
            this.txtDescFornecedor.Location = new System.Drawing.Point(165, 40);
            this.txtDescFornecedor.Name = "txtDescFornecedor";
            this.txtDescFornecedor.Preenchimento = null;
            this.txtDescFornecedor.Size = new System.Drawing.Size(310, 24);
            this.txtDescFornecedor.TabIndex = 74;
            this.txtDescFornecedor.TipoCampo = "STRING";
            // 
            // txtDescricaoEstoque
            // 
            this.txtDescricaoEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoEstoque.BackColor = System.Drawing.Color.White;
            this.txtDescricaoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoEstoque.Enabled = false;
            this.txtDescricaoEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricaoEstoque.IconeKeyDown = null;
            this.txtDescricaoEstoque.Location = new System.Drawing.Point(165, 70);
            this.txtDescricaoEstoque.Name = "txtDescricaoEstoque";
            this.txtDescricaoEstoque.Preenchimento = null;
            this.txtDescricaoEstoque.Size = new System.Drawing.Size(310, 24);
            this.txtDescricaoEstoque.TabIndex = 67;
            this.txtDescricaoEstoque.TipoCampo = "STRING";
            // 
            // txtIdEstoque
            // 
            this.txtIdEstoque.BackColor = System.Drawing.Color.White;
            this.txtIdEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEstoque.Enabled = false;
            this.txtIdEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIdEstoque.IconeKeyDown = null;
            this.txtIdEstoque.Location = new System.Drawing.Point(112, 70);
            this.txtIdEstoque.Name = "txtIdEstoque";
            this.txtIdEstoque.Preenchimento = null;
            this.txtIdEstoque.Size = new System.Drawing.Size(47, 24);
            this.txtIdEstoque.TabIndex = 66;
            this.txtIdEstoque.TipoCampo = "STRING";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.IconeKeyDown = null;
            this.txtProduto.Location = new System.Drawing.Point(165, 10);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(310, 24);
            this.txtProduto.TabIndex = 64;
            this.txtProduto.TipoCampo = "STRING";
            // 
            // txtIDProd
            // 
            this.txtIDProd.BackColor = System.Drawing.Color.White;
            this.txtIDProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDProd.IconeKeyDown = null;
            this.txtIDProd.Location = new System.Drawing.Point(112, 10);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Preenchimento = null;
            this.txtIDProd.Size = new System.Drawing.Size(47, 24);
            this.txtIDProd.TabIndex = 60;
            this.txtIDProd.TipoCampo = "STRING";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(41, 13);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(65, 17);
            this.labelJCS1.TabIndex = 61;
            this.labelJCS1.Text = "NFe Prod:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(27, 73);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(79, 17);
            this.labelJCS2.TabIndex = 65;
            this.labelJCS2.Text = "Controle ID:";
            // 
            // dgvLink
            // 
            this.dgvLink.AllowUserToAddRows = false;
            this.dgvLink.AllowUserToDeleteRows = false;
            this.dgvLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLink.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdutoNFe,
            this.colEstoque,
            this.colFornecedor,
            this.colExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 214);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLink.RowHeadersVisible = false;
            this.dgvLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLink.Size = new System.Drawing.Size(695, 348);
            this.dgvLink.TabIndex = 63;
            // 
            // colProdutoNFe
            // 
            this.colProdutoNFe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProdutoNFe.DataPropertyName = "PRODUTO_NF";
            this.colProdutoNFe.HeaderText = "Produto NFe";
            this.colProdutoNFe.Name = "colProdutoNFe";
            this.colProdutoNFe.ReadOnly = true;
            // 
            // colEstoque
            // 
            this.colEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEstoque.DataPropertyName = "ESTOQUE";
            this.colEstoque.HeaderText = "Estoque";
            this.colEstoque.Name = "colEstoque";
            this.colEstoque.ReadOnly = true;
            // 
            // colFornecedor
            // 
            this.colFornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFornecedor.DataPropertyName = "FORNECEDOR";
            this.colFornecedor.HeaderText = "Fornecedor";
            this.colFornecedor.Name = "colFornecedor";
            this.colFornecedor.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 52;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_editar_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaFornecedor.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaFornecedor.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(481, 40);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaFornecedor.TabIndex = 75;
            this.btnBuscaFornecedor.Text = "Buscar Fornecedor";
            this.btnBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.BtnBuscaFornecedor_Click);
            // 
            // btnLinkar
            // 
            this.btnLinkar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLinkar.BackColor = System.Drawing.Color.Gold;
            this.btnLinkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnLinkar.Image = global::Caixa.Properties.Resources.icons8_caixa_de_seleção_marcada_96;
            this.btnLinkar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkar.Location = new System.Drawing.Point(12, 120);
            this.btnLinkar.Name = "btnLinkar";
            this.btnLinkar.Size = new System.Drawing.Size(671, 88);
            this.btnLinkar.TabIndex = 69;
            this.btnLinkar.Text = "Linkar Produto Final a Materia Prima";
            this.btnLinkar.UseVisualStyleBackColor = false;
            this.btnLinkar.Click += new System.EventHandler(this.BtnLinkar_Click);
            // 
            // btnBuscaControlEstq
            // 
            this.btnBuscaControlEstq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaControlEstq.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaControlEstq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaControlEstq.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaControlEstq.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaControlEstq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaControlEstq.Location = new System.Drawing.Point(481, 70);
            this.btnBuscaControlEstq.Name = "btnBuscaControlEstq";
            this.btnBuscaControlEstq.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaControlEstq.TabIndex = 68;
            this.btnBuscaControlEstq.Text = "Buscar Controle Estoque";
            this.btnBuscaControlEstq.UseVisualStyleBackColor = false;
            this.btnBuscaControlEstq.Click += new System.EventHandler(this.BtnBuscaControlEstq_Click);
            // 
            // btnBuscaProdutoNFe
            // 
            this.btnBuscaProdutoNFe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaProdutoNFe.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaProdutoNFe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProdutoNFe.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaProdutoNFe.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaProdutoNFe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProdutoNFe.Location = new System.Drawing.Point(481, 10);
            this.btnBuscaProdutoNFe.Name = "btnBuscaProdutoNFe";
            this.btnBuscaProdutoNFe.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaProdutoNFe.TabIndex = 62;
            this.btnBuscaProdutoNFe.Text = "Buscar Produto NFe";
            this.btnBuscaProdutoNFe.UseVisualStyleBackColor = false;
            this.btnBuscaProdutoNFe.Click += new System.EventHandler(this.BtnBuscaProdutoNFe_Click);
            // 
            // frmLinkProdNFFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.btnLinkar);
            this.Controls.Add(this.btnBuscaControlEstq);
            this.Controls.Add(this.txtDescFornecedor);
            this.Controls.Add(this.txtDescricaoEstoque);
            this.Controls.Add(this.txtIdEstoque);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.btnBuscaProdutoNFe);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.dgvLink);
            this.Name = "frmLinkProdNFFornecedor";
            this.Text = "frmLinkProdNFFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.ButtonJCS btnBuscaFornecedor;
        private Componentes.TextBoxJCS txtIDFornecedor;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.ButtonJCS btnLinkar;
        private Componentes.ButtonJCS btnBuscaControlEstq;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.TextBoxJCS txtDescFornecedor;
        private Componentes.TextBoxJCS txtDescricaoEstoque;
        private Componentes.TextBoxJCS txtIdEstoque;
        private Componentes.TextBoxJCS txtProduto;
        private Componentes.TextBoxJCS txtIDProd;
        private Componentes.ButtonJCS btnBuscaProdutoNFe;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.DataGridViewJCS dgvLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoNFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFornecedor;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}