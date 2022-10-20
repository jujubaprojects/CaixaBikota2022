namespace Caixa.Cadastro
{
    partial class frmCadastroProduto
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
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.cboTipo = new Componentes.ComboBoxJCS(this.components);
            this.txtValor = new Componentes.TextBoxJCS(this.components);
            this.txtQtDesc = new Componentes.TextBoxJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.txtQtSubEstoque = new Componentes.TextBoxJCS(this.components);
            this.dgvProdutos = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExibirApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboExibirApp = new Componentes.ComboBoxJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 62);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 1;
            this.labelJCS1.Text = "Produto:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(79, 59);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = "";
            this.txtID.Size = new System.Drawing.Size(100, 24);
            this.txtID.TabIndex = 2;
            this.txtID.TipoCampo = "INTEIRO";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(35, 92);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(38, 17);
            this.labelJCS2.TabIndex = 3;
            this.labelJCS2.Text = "Tipo:";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(185, 92);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(71, 17);
            this.labelJCS3.TabIndex = 4;
            this.labelJCS3.Text = "Exibir App:";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(369, 92);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(67, 17);
            this.labelJCS4.TabIndex = 5;
            this.labelJCS4.Text = "QT. Desc.:";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(31, 122);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(42, 17);
            this.labelJCS5.TabIndex = 6;
            this.labelJCS5.Text = "Valor:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Yellow;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(185, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = "Required";
            this.txtDescricao.Size = new System.Drawing.Size(357, 24);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.TipoCampo = "STRING";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(79, 89);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(100, 23);
            this.cboTipo.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Yellow;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtValor.IconeKeyDown = null;
            this.txtValor.Location = new System.Drawing.Point(79, 118);
            this.txtValor.Name = "txtValor";
            this.txtValor.Preenchimento = "Required";
            this.txtValor.Size = new System.Drawing.Size(100, 24);
            this.txtValor.TabIndex = 9;
            this.txtValor.TipoCampo = "MONETARIO";
            // 
            // txtQtDesc
            // 
            this.txtQtDesc.BackColor = System.Drawing.Color.Yellow;
            this.txtQtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtDesc.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtDesc.IconeKeyDown = null;
            this.txtQtDesc.Location = new System.Drawing.Point(442, 89);
            this.txtQtDesc.Name = "txtQtDesc";
            this.txtQtDesc.Preenchimento = "Required";
            this.txtQtDesc.Size = new System.Drawing.Size(100, 24);
            this.txtQtDesc.TabIndex = 10;
            this.txtQtDesc.TipoCampo = "";
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(322, 122);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(114, 17);
            this.labelJCS6.TabIndex = 12;
            this.labelJCS6.Text = "QT. Sub. Estoque:";
            // 
            // txtQtSubEstoque
            // 
            this.txtQtSubEstoque.BackColor = System.Drawing.Color.Yellow;
            this.txtQtSubEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtSubEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtSubEstoque.IconeKeyDown = null;
            this.txtQtSubEstoque.Location = new System.Drawing.Point(442, 119);
            this.txtQtSubEstoque.Name = "txtQtSubEstoque";
            this.txtQtSubEstoque.Preenchimento = "Required";
            this.txtQtSubEstoque.Size = new System.Drawing.Size(100, 24);
            this.txtQtSubEstoque.TabIndex = 13;
            this.txtQtSubEstoque.TipoCampo = "INTEIRO";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colID,
            this.colDescricao,
            this.colTipo,
            this.colQtDesc,
            this.colExibirApp,
            this.colQtSub});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 164);
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
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(565, 286);
            this.dgvProdutos.TabIndex = 14;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
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
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.DataPropertyName = "TIPO";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colQtDesc
            // 
            this.colQtDesc.DataPropertyName = "QT_DESCRICAO";
            this.colQtDesc.HeaderText = "QT. Desc.";
            this.colQtDesc.Name = "colQtDesc";
            this.colQtDesc.ReadOnly = true;
            this.colQtDesc.Width = 88;
            // 
            // colExibirApp
            // 
            this.colExibirApp.DataPropertyName = "EXIBIR_APP";
            this.colExibirApp.HeaderText = "Exibir App";
            this.colExibirApp.Name = "colExibirApp";
            this.colExibirApp.ReadOnly = true;
            this.colExibirApp.Width = 92;
            // 
            // colQtSub
            // 
            this.colQtSub.DataPropertyName = "QT_SUB_ESTOQUE";
            this.colQtSub.HeaderText = "QT. Sub.";
            this.colQtSub.Name = "colQtSub";
            this.colQtSub.ReadOnly = true;
            this.colQtSub.Width = 83;
            // 
            // cboExibirApp
            // 
            this.cboExibirApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExibirApp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboExibirApp.FormattingEnabled = true;
            this.cboExibirApp.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.cboExibirApp.Location = new System.Drawing.Point(262, 89);
            this.cboExibirApp.Name = "cboExibirApp";
            this.cboExibirApp.Size = new System.Drawing.Size(100, 23);
            this.cboExibirApp.TabIndex = 15;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.cboExibirApp);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtQtSubEstoque);
            this.Controls.Add(this.labelJCS6);
            this.Controls.Add(this.txtQtDesc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelJCS1);
            this.Name = "frmCadastroProduto";
            this.Text = "frmCadastroProduto";
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.labelJCS3, 0);
            this.Controls.SetChildIndex(this.labelJCS4, 0);
            this.Controls.SetChildIndex(this.labelJCS5, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.txtQtDesc, 0);
            this.Controls.SetChildIndex(this.labelJCS6, 0);
            this.Controls.SetChildIndex(this.txtQtSubEstoque, 0);
            this.Controls.SetChildIndex(this.dgvProdutos, 0);
            this.Controls.SetChildIndex(this.cboExibirApp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtID;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.ComboBoxJCS cboTipo;
        private Componentes.TextBoxJCS txtValor;
        private Componentes.TextBoxJCS txtQtDesc;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.TextBoxJCS txtQtSubEstoque;
        private Componentes.DataGridViewJCS dgvProdutos;
        private Componentes.ComboBoxJCS cboExibirApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExibirApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtSub;
    }
}