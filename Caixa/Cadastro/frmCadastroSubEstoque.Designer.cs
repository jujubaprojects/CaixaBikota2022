namespace Caixa.Cadastro
{
    partial class frmCadastroSubEstoque
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
            this.txtDescEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtIdEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtDescProduto = new Componentes.TextBoxJCS(this.components);
            this.txtIDProd = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.dgvSubEstoque = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLinkar = new Componentes.ButtonJCS(this.components);
            this.btnBuscaControlEstq = new Componentes.ButtonJCS(this.components);
            this.btnBuscaProdutoFinal = new Componentes.ButtonJCS(this.components);
            this.txtQtSub = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescEstoque
            // 
            this.txtDescEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescEstoque.BackColor = System.Drawing.Color.White;
            this.txtDescEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescEstoque.Enabled = false;
            this.txtDescEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescEstoque.IconeKeyDown = null;
            this.txtDescEstoque.Location = new System.Drawing.Point(150, 50);
            this.txtDescEstoque.Name = "txtDescEstoque";
            this.txtDescEstoque.Preenchimento = null;
            this.txtDescEstoque.Size = new System.Drawing.Size(362, 24);
            this.txtDescEstoque.TabIndex = 78;
            this.txtDescEstoque.TipoCampo = "STRING";
            // 
            // txtIdEstoque
            // 
            this.txtIdEstoque.BackColor = System.Drawing.Color.White;
            this.txtIdEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEstoque.Enabled = false;
            this.txtIdEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIdEstoque.IconeKeyDown = null;
            this.txtIdEstoque.Location = new System.Drawing.Point(97, 50);
            this.txtIdEstoque.Name = "txtIdEstoque";
            this.txtIdEstoque.Preenchimento = null;
            this.txtIdEstoque.Size = new System.Drawing.Size(47, 24);
            this.txtIdEstoque.TabIndex = 77;
            this.txtIdEstoque.TipoCampo = "STRING";
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescProduto.BackColor = System.Drawing.Color.White;
            this.txtDescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProduto.Enabled = false;
            this.txtDescProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescProduto.IconeKeyDown = null;
            this.txtDescProduto.Location = new System.Drawing.Point(150, 20);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Preenchimento = null;
            this.txtDescProduto.Size = new System.Drawing.Size(362, 24);
            this.txtDescProduto.TabIndex = 75;
            this.txtDescProduto.TipoCampo = "STRING";
            // 
            // txtIDProd
            // 
            this.txtIDProd.BackColor = System.Drawing.Color.White;
            this.txtIDProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDProd.IconeKeyDown = null;
            this.txtIDProd.Location = new System.Drawing.Point(97, 20);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Preenchimento = null;
            this.txtIDProd.Size = new System.Drawing.Size(47, 24);
            this.txtIDProd.TabIndex = 72;
            this.txtIDProd.TipoCampo = "STRING";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(30, 23);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 73;
            this.labelJCS1.Text = "Produto:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 53);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(79, 17);
            this.labelJCS2.TabIndex = 76;
            this.labelJCS2.Text = "Controle ID:";
            // 
            // dgvSubEstoque
            // 
            this.dgvSubEstoque.AllowUserToAddRows = false;
            this.dgvSubEstoque.AllowUserToDeleteRows = false;
            this.dgvSubEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubEstoque.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCodProd,
            this.colDescProd,
            this.colCodEst,
            this.colDescEst,
            this.colQtSub,
            this.colExcluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubEstoque.EnableHeadersVisualStyles = false;
            this.dgvSubEstoque.Location = new System.Drawing.Point(0, 221);
            this.dgvSubEstoque.Name = "dgvSubEstoque";
            this.dgvSubEstoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubEstoque.RowHeadersVisible = false;
            this.dgvSubEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubEstoque.Size = new System.Drawing.Size(734, 311);
            this.dgvSubEstoque.TabIndex = 74;
            this.dgvSubEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubEstoque_CellClick);
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
            this.colDescProd.HeaderText = "Produto Final";
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
            // colQtSub
            // 
            this.colQtSub.DataPropertyName = "QT_SUB";
            this.colQtSub.HeaderText = "QT. Sub";
            this.colQtSub.Name = "colQtSub";
            this.colQtSub.ReadOnly = true;
            this.colQtSub.Width = 79;
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
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 52;
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
            this.btnLinkar.Location = new System.Drawing.Point(12, 113);
            this.btnLinkar.Name = "btnLinkar";
            this.btnLinkar.Size = new System.Drawing.Size(708, 88);
            this.btnLinkar.TabIndex = 79;
            this.btnLinkar.Text = "Linkar Produto Final x Controle Estoque";
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
            this.btnBuscaControlEstq.Location = new System.Drawing.Point(518, 50);
            this.btnBuscaControlEstq.Name = "btnBuscaControlEstq";
            this.btnBuscaControlEstq.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaControlEstq.TabIndex = 71;
            this.btnBuscaControlEstq.Text = "Buscar Controle Estoque";
            this.btnBuscaControlEstq.UseVisualStyleBackColor = false;
            this.btnBuscaControlEstq.Click += new System.EventHandler(this.BtnBuscaControlEstq_Click);
            // 
            // btnBuscaProdutoFinal
            // 
            this.btnBuscaProdutoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaProdutoFinal.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaProdutoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProdutoFinal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaProdutoFinal.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaProdutoFinal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProdutoFinal.Location = new System.Drawing.Point(518, 20);
            this.btnBuscaProdutoFinal.Name = "btnBuscaProdutoFinal";
            this.btnBuscaProdutoFinal.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaProdutoFinal.TabIndex = 70;
            this.btnBuscaProdutoFinal.Text = "Buscar Produto Final";
            this.btnBuscaProdutoFinal.UseVisualStyleBackColor = false;
            this.btnBuscaProdutoFinal.Click += new System.EventHandler(this.BtnBuscaProdutoFinal_Click);
            // 
            // txtQtSub
            // 
            this.txtQtSub.BackColor = System.Drawing.Color.White;
            this.txtQtSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtSub.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtSub.IconeKeyDown = null;
            this.txtQtSub.Location = new System.Drawing.Point(97, 80);
            this.txtQtSub.Name = "txtQtSub";
            this.txtQtSub.Preenchimento = null;
            this.txtQtSub.Size = new System.Drawing.Size(47, 24);
            this.txtQtSub.TabIndex = 80;
            this.txtQtSub.TipoCampo = "INTEIRO";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(27, 83);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(58, 17);
            this.labelJCS3.TabIndex = 81;
            this.labelJCS3.Text = "QT. Sub:";
            // 
            // frmCadastroSubEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 532);
            this.Controls.Add(this.txtQtSub);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.btnLinkar);
            this.Controls.Add(this.btnBuscaControlEstq);
            this.Controls.Add(this.txtDescEstoque);
            this.Controls.Add(this.txtIdEstoque);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.btnBuscaProdutoFinal);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.dgvSubEstoque);
            this.Name = "frmCadastroSubEstoque";
            this.Text = "Cadastro Sub Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.ButtonJCS btnLinkar;
        private Componentes.ButtonJCS btnBuscaControlEstq;
        private Componentes.TextBoxJCS txtDescEstoque;
        private Componentes.TextBoxJCS txtIdEstoque;
        private Componentes.TextBoxJCS txtDescProduto;
        private Componentes.TextBoxJCS txtIDProd;
        private Componentes.ButtonJCS btnBuscaProdutoFinal;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.DataGridViewJCS dgvSubEstoque;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.TextBoxJCS txtQtSub;
        private Componentes.LabelJCS labelJCS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtSub;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}