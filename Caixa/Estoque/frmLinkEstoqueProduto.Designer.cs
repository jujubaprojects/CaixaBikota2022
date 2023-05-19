namespace Caixa.Estoque
{
    partial class frmLinkEstoqueProduto
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
            this.dgvLink = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtIDProd = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtDescricaoEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtIdEstoque = new Componentes.TextBoxJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscaMateriaPrima = new Componentes.ButtonJCS(this.components);
            this.btnBuscaProduto = new Componentes.ButtonJCS(this.components);
            this.btnLinkar = new Componentes.ButtonJCS(this.components);
            this.txtQtSub = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.btnBuscaFornecedor = new Componentes.ButtonJCS(this.components);
            this.txtDescFornecedor = new Componentes.TextBoxJCS(this.components);
            this.txtIDFornecedor = new Componentes.TextBoxJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLink
            // 
            this.dgvLink.AllowUserToAddRows = false;
            this.dgvLink.AllowUserToDeleteRows = false;
            this.dgvLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colID,
            this.colProduto,
            this.colMateriaPrima,
            this.colQtSub,
            this.colExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 244);
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
            this.dgvLink.Size = new System.Drawing.Size(695, 318);
            this.dgvLink.TabIndex = 47;
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
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colMateriaPrima
            // 
            this.colMateriaPrima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMateriaPrima.DataPropertyName = "MATERIA_PRIMA";
            this.colMateriaPrima.HeaderText = "Materia Prima";
            this.colMateriaPrima.Name = "colMateriaPrima";
            this.colMateriaPrima.ReadOnly = true;
            // 
            // colQtSub
            // 
            this.colQtSub.DataPropertyName = "QT_SUB";
            this.colQtSub.HeaderText = "Qt. Sub.";
            this.colQtSub.Name = "colQtSub";
            this.colQtSub.ReadOnly = true;
            this.colQtSub.Width = 82;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 52;
            // 
            // txtIDProd
            // 
            this.txtIDProd.BackColor = System.Drawing.Color.White;
            this.txtIDProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDProd.IconeKeyDown = null;
            this.txtIDProd.Location = new System.Drawing.Point(112, 15);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Preenchimento = null;
            this.txtIDProd.Size = new System.Drawing.Size(47, 24);
            this.txtIDProd.TabIndex = 44;
            this.txtIDProd.TipoCampo = "STRING";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(15, 18);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(91, 17);
            this.labelJCS1.TabIndex = 45;
            this.labelJCS1.Text = "Produto Final:";
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
            this.txtProduto.Location = new System.Drawing.Point(165, 15);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(310, 24);
            this.txtProduto.TabIndex = 48;
            this.txtProduto.TipoCampo = "STRING";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 48);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(94, 17);
            this.labelJCS2.TabIndex = 49;
            this.labelJCS2.Text = "Materia Prima:";
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
            this.txtDescricaoEstoque.Location = new System.Drawing.Point(165, 45);
            this.txtDescricaoEstoque.Name = "txtDescricaoEstoque";
            this.txtDescricaoEstoque.Preenchimento = null;
            this.txtDescricaoEstoque.Size = new System.Drawing.Size(310, 24);
            this.txtDescricaoEstoque.TabIndex = 51;
            this.txtDescricaoEstoque.TipoCampo = "STRING";
            // 
            // txtIdEstoque
            // 
            this.txtIdEstoque.BackColor = System.Drawing.Color.White;
            this.txtIdEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEstoque.Enabled = false;
            this.txtIdEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIdEstoque.IconeKeyDown = null;
            this.txtIdEstoque.Location = new System.Drawing.Point(112, 45);
            this.txtIdEstoque.Name = "txtIdEstoque";
            this.txtIdEstoque.Preenchimento = null;
            this.txtIdEstoque.Size = new System.Drawing.Size(47, 24);
            this.txtIdEstoque.TabIndex = 50;
            this.txtIdEstoque.TipoCampo = "STRING";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_editar_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // btnBuscaMateriaPrima
            // 
            this.btnBuscaMateriaPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaMateriaPrima.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaMateriaPrima.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaMateriaPrima.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaMateriaPrima.Location = new System.Drawing.Point(481, 45);
            this.btnBuscaMateriaPrima.Name = "btnBuscaMateriaPrima";
            this.btnBuscaMateriaPrima.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaMateriaPrima.TabIndex = 52;
            this.btnBuscaMateriaPrima.Text = "Buscar Materia Prima";
            this.btnBuscaMateriaPrima.UseVisualStyleBackColor = false;
            this.btnBuscaMateriaPrima.Click += new System.EventHandler(this.BtnBuscaMateriaPrima_Click);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaProduto.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaProduto.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProduto.Location = new System.Drawing.Point(481, 15);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaProduto.TabIndex = 46;
            this.btnBuscaProduto.Text = "Buscar Produto";
            this.btnBuscaProduto.UseVisualStyleBackColor = false;
            this.btnBuscaProduto.Click += new System.EventHandler(this.BtnBuscaProduto_Click);
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
            this.btnLinkar.Location = new System.Drawing.Point(12, 150);
            this.btnLinkar.Name = "btnLinkar";
            this.btnLinkar.Size = new System.Drawing.Size(671, 88);
            this.btnLinkar.TabIndex = 53;
            this.btnLinkar.Text = "Linkar Produto Final a Materia Prima";
            this.btnLinkar.UseVisualStyleBackColor = false;
            this.btnLinkar.Click += new System.EventHandler(this.BtnLinkar_Click);
            // 
            // txtQtSub
            // 
            this.txtQtSub.BackColor = System.Drawing.Color.White;
            this.txtQtSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtSub.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtSub.IconeKeyDown = null;
            this.txtQtSub.Location = new System.Drawing.Point(112, 105);
            this.txtQtSub.Name = "txtQtSub";
            this.txtQtSub.Preenchimento = null;
            this.txtQtSub.Size = new System.Drawing.Size(47, 24);
            this.txtQtSub.TabIndex = 54;
            this.txtQtSub.Text = "1";
            this.txtQtSub.TipoCampo = "INTEIRO";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(24, 108);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(82, 17);
            this.labelJCS3.TabIndex = 55;
            this.labelJCS3.Text = "Qt. Subtrair:";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(26, 80);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(80, 17);
            this.labelJCS4.TabIndex = 56;
            this.labelJCS4.Text = "Fornecedor:";
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaFornecedor.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaFornecedor.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(481, 75);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaFornecedor.TabIndex = 59;
            this.btnBuscaFornecedor.Text = "Buscar Fornecedor";
            this.btnBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.BtnBuscaFornecedor_Click);
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
            this.txtDescFornecedor.Location = new System.Drawing.Point(165, 75);
            this.txtDescFornecedor.Name = "txtDescFornecedor";
            this.txtDescFornecedor.Preenchimento = null;
            this.txtDescFornecedor.Size = new System.Drawing.Size(310, 24);
            this.txtDescFornecedor.TabIndex = 58;
            this.txtDescFornecedor.TipoCampo = "STRING";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.BackColor = System.Drawing.Color.White;
            this.txtIDFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDFornecedor.Enabled = false;
            this.txtIDFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDFornecedor.IconeKeyDown = null;
            this.txtIDFornecedor.Location = new System.Drawing.Point(112, 75);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Preenchimento = null;
            this.txtIDFornecedor.Size = new System.Drawing.Size(47, 24);
            this.txtIDFornecedor.TabIndex = 57;
            this.txtIDFornecedor.TipoCampo = "STRING";
            // 
            // frmLinkEstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtDescFornecedor);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtQtSub);
            this.Controls.Add(this.btnLinkar);
            this.Controls.Add(this.btnBuscaMateriaPrima);
            this.Controls.Add(this.txtDescricaoEstoque);
            this.Controls.Add(this.txtIdEstoque);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.dgvLink);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.labelJCS1);
            this.Name = "frmLinkEstoqueProduto";
            this.Text = "frmLinkEstoqueProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvLink;
        private Componentes.TextBoxJCS txtIDProd;
        private Componentes.ButtonJCS btnBuscaProduto;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtProduto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtDescricaoEstoque;
        private Componentes.TextBoxJCS txtIdEstoque;
        private Componentes.ButtonJCS btnBuscaMateriaPrima;
        private Componentes.ButtonJCS btnLinkar;
        private Componentes.TextBoxJCS txtQtSub;
        private Componentes.LabelJCS labelJCS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtSub;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.ButtonJCS btnBuscaFornecedor;
        private Componentes.TextBoxJCS txtDescFornecedor;
        private Componentes.TextBoxJCS txtIDFornecedor;
    }
}