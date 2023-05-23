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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscaFornecedor = new Componentes.ButtonJCS(this.components);
            this.btnLinkar = new Componentes.ButtonJCS(this.components);
            this.btnBuscaControlEstq = new Componentes.ButtonJCS(this.components);
            this.btnBuscaProdutoNFe = new Componentes.ButtonJCS(this.components);
            this.txtQtCaixa = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
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
            this.txtIDFornecedor.Location = new System.Drawing.Point(112, 12);
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
            this.labelJCS4.Location = new System.Drawing.Point(26, 17);
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
            this.txtDescFornecedor.Location = new System.Drawing.Point(165, 12);
            this.txtDescFornecedor.Name = "txtDescFornecedor";
            this.txtDescFornecedor.Preenchimento = null;
            this.txtDescFornecedor.Size = new System.Drawing.Size(548, 24);
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
            this.txtDescricaoEstoque.Size = new System.Drawing.Size(548, 24);
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
            this.txtProduto.Location = new System.Drawing.Point(165, 40);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(548, 24);
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
            this.txtIDProd.Location = new System.Drawing.Point(112, 40);
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
            this.labelJCS1.Location = new System.Drawing.Point(41, 43);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCodProd,
            this.colDescProd,
            this.colCodEst,
            this.colDescEst,
            this.colCodFor,
            this.colDescFor,
            this.colQtCaixa,
            this.colExcluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 251);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLink.RowHeadersVisible = false;
            this.dgvLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLink.Size = new System.Drawing.Size(933, 311);
            this.dgvLink.TabIndex = 63;
            this.dgvLink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLink_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 27;
            // 
            // colCodProd
            // 
            this.colCodProd.DataPropertyName = "COD_PROD";
            this.colCodProd.HeaderText = "Cod Produto";
            this.colCodProd.Name = "colCodProd";
            this.colCodProd.ReadOnly = true;
            this.colCodProd.Visible = false;
            this.colCodProd.Width = 89;
            // 
            // colDescProd
            // 
            this.colDescProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescProd.DataPropertyName = "DESC_PROD";
            this.colDescProd.HeaderText = "Produto NFe";
            this.colDescProd.Name = "colDescProd";
            this.colDescProd.ReadOnly = true;
            // 
            // colCodEst
            // 
            this.colCodEst.DataPropertyName = "COD_EST";
            this.colCodEst.HeaderText = "Cod Estoque";
            this.colCodEst.Name = "colCodEst";
            this.colCodEst.ReadOnly = true;
            this.colCodEst.Visible = false;
            this.colCodEst.Width = 108;
            // 
            // colDescEst
            // 
            this.colDescEst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescEst.DataPropertyName = "DESC_EST";
            this.colDescEst.HeaderText = "Estoque";
            this.colDescEst.Name = "colDescEst";
            this.colDescEst.ReadOnly = true;
            // 
            // colCodFor
            // 
            this.colCodFor.DataPropertyName = "COD_FOR";
            this.colCodFor.HeaderText = "Cod Fornecedor";
            this.colCodFor.Name = "colCodFor";
            this.colCodFor.ReadOnly = true;
            this.colCodFor.Visible = false;
            this.colCodFor.Width = 127;
            // 
            // colDescFor
            // 
            this.colDescFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescFor.DataPropertyName = "DESC_FOR";
            this.colDescFor.HeaderText = "Fornecedor";
            this.colDescFor.Name = "colDescFor";
            this.colDescFor.ReadOnly = true;
            // 
            // colQtCaixa
            // 
            this.colQtCaixa.DataPropertyName = "QT_CAIXA";
            this.colQtCaixa.HeaderText = "QT. Caixa";
            this.colQtCaixa.Name = "colQtCaixa";
            this.colQtCaixa.ReadOnly = true;
            this.colQtCaixa.Width = 86;
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
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(719, 12);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaFornecedor.TabIndex = 1;
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
            this.btnLinkar.Location = new System.Drawing.Point(12, 143);
            this.btnLinkar.Name = "btnLinkar";
            this.btnLinkar.Size = new System.Drawing.Size(909, 88);
            this.btnLinkar.TabIndex = 69;
            this.btnLinkar.Text = "Linkar Fornecedor x Produto NF x Controle Estoque";
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
            this.btnBuscaControlEstq.Location = new System.Drawing.Point(719, 70);
            this.btnBuscaControlEstq.Name = "btnBuscaControlEstq";
            this.btnBuscaControlEstq.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaControlEstq.TabIndex = 3;
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
            this.btnBuscaProdutoNFe.Location = new System.Drawing.Point(719, 40);
            this.btnBuscaProdutoNFe.Name = "btnBuscaProdutoNFe";
            this.btnBuscaProdutoNFe.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaProdutoNFe.TabIndex = 2;
            this.btnBuscaProdutoNFe.Text = "Buscar Produto NFe";
            this.btnBuscaProdutoNFe.UseVisualStyleBackColor = false;
            this.btnBuscaProdutoNFe.Click += new System.EventHandler(this.BtnBuscaProdutoNFe_Click);
            // 
            // txtQtCaixa
            // 
            this.txtQtCaixa.BackColor = System.Drawing.Color.White;
            this.txtQtCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtCaixa.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtCaixa.IconeKeyDown = null;
            this.txtQtCaixa.Location = new System.Drawing.Point(112, 100);
            this.txtQtCaixa.Name = "txtQtCaixa";
            this.txtQtCaixa.Preenchimento = null;
            this.txtQtCaixa.Size = new System.Drawing.Size(47, 24);
            this.txtQtCaixa.TabIndex = 4;
            this.txtQtCaixa.TipoCampo = "INTEIRO";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(27, 103);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(65, 17);
            this.labelJCS3.TabIndex = 76;
            this.labelJCS3.Text = "QT. Caixa:";
            // 
            // frmLinkProdNFFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.txtQtCaixa);
            this.Controls.Add(this.labelJCS3);
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
            this.Text = "Link Produto NFe x Controle Estoque x Fornecedor";
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
        private Componentes.TextBoxJCS txtQtCaixa;
        private Componentes.LabelJCS labelJCS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtCaixa;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}