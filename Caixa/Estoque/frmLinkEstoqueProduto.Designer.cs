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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLink = new Componentes.DataGridViewJCS(this.components);
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLink
            // 
            this.dgvLink.AllowUserToAddRows = false;
            this.dgvLink.AllowUserToDeleteRows = false;
            this.dgvLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLink.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProduto,
            this.colMateriaPrima,
            this.colExcluir});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 188);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLink.RowHeadersVisible = false;
            this.dgvLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLink.Size = new System.Drawing.Size(695, 262);
            this.dgvLink.TabIndex = 47;
            // 
            // txtIDProd
            // 
            this.txtIDProd.BackColor = System.Drawing.Color.White;
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
            this.txtProduto.BackColor = System.Drawing.Color.White;
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
            this.txtDescricaoEstoque.BackColor = System.Drawing.Color.White;
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
            this.btnBuscaMateriaPrima.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaMateriaPrima.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaMateriaPrima.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaMateriaPrima.Location = new System.Drawing.Point(481, 43);
            this.btnBuscaMateriaPrima.Name = "btnBuscaMateriaPrima";
            this.btnBuscaMateriaPrima.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaMateriaPrima.TabIndex = 52;
            this.btnBuscaMateriaPrima.Text = "Buscar Materia Prima";
            this.btnBuscaMateriaPrima.UseVisualStyleBackColor = false;
            this.btnBuscaMateriaPrima.Click += new System.EventHandler(this.BtnBuscaMateriaPrima_Click);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.BackColor = System.Drawing.Color.Gold;
            this.btnBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscaProduto.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscaProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProduto.Location = new System.Drawing.Point(481, 13);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(202, 24);
            this.btnBuscaProduto.TabIndex = 46;
            this.btnBuscaProduto.Text = "Buscar Produto";
            this.btnBuscaProduto.UseVisualStyleBackColor = false;
            this.btnBuscaProduto.Click += new System.EventHandler(this.BtnBuscaProduto_Click);
            // 
            // btnLinkar
            // 
            this.btnLinkar.BackColor = System.Drawing.Color.Gold;
            this.btnLinkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnLinkar.Image = global::Caixa.Properties.Resources.icons8_caixa_de_seleção_marcada_96;
            this.btnLinkar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkar.Location = new System.Drawing.Point(12, 75);
            this.btnLinkar.Name = "btnLinkar";
            this.btnLinkar.Size = new System.Drawing.Size(671, 88);
            this.btnLinkar.TabIndex = 53;
            this.btnLinkar.Text = "Linkar Produto Final a Materia Prima";
            this.btnLinkar.UseVisualStyleBackColor = false;
            this.btnLinkar.Click += new System.EventHandler(this.BtnLinkar_Click);
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
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 52;
            // 
            // frmLinkEstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaPrima;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.ButtonJCS btnLinkar;
    }
}