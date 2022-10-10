namespace Caixa.Cadastro
{
    partial class frmControleEstoque
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
            this.dgvEstoque = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEstoqueIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEntregueFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtQTEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtUnidadeMedida = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtEstoqueIdeaal = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtCusto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.txtQtEntregueFornecedor = new Componentes.TextBoxJCS(this.components);
            this.labelJCS7 = new Componentes.LabelJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new Componentes.ButtonJCS(this.components);
            this.colAumentarEstoque = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDiminuirEstoque = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDesativar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProduto,
            this.colDescricao,
            this.colEstoque,
            this.colUnidadeMedida,
            this.colQtEstoqueIdeal,
            this.colQtEntregueFornecedor,
            this.colCusto,
            this.STATUS,
            this.colAumentarEstoque,
            this.colDiminuirEstoque,
            this.colAlterar,
            this.colDesativar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoque.EnableHeadersVisualStyles = false;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 124);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(800, 326);
            this.dgvEstoque.TabIndex = 44;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstoque_CellClick);
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
            this.colProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstoque
            // 
            this.colEstoque.DataPropertyName = "QT_ESTOQUE";
            this.colEstoque.HeaderText = "QT. Estoque";
            this.colEstoque.Name = "colEstoque";
            this.colEstoque.ReadOnly = true;
            this.colEstoque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEstoque.Width = 105;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.DataPropertyName = "UNIDADE_MEDIDA";
            this.colUnidadeMedida.HeaderText = "Unidade";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.ReadOnly = true;
            this.colUnidadeMedida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnidadeMedida.Visible = false;
            this.colUnidadeMedida.Width = 83;
            // 
            // colQtEstoqueIdeal
            // 
            this.colQtEstoqueIdeal.DataPropertyName = "QT_ESTOQUE_IDEAL";
            this.colQtEstoqueIdeal.HeaderText = "Estoque Ideal";
            this.colQtEstoqueIdeal.Name = "colQtEstoqueIdeal";
            this.colQtEstoqueIdeal.ReadOnly = true;
            this.colQtEstoqueIdeal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQtEstoqueIdeal.Width = 114;
            // 
            // colQtEntregueFornecedor
            // 
            this.colQtEntregueFornecedor.DataPropertyName = "QT_ENTREGUE_FORNECEDOR";
            this.colQtEntregueFornecedor.HeaderText = "QT. Entregue";
            this.colQtEntregueFornecedor.Name = "colQtEntregueFornecedor";
            this.colQtEntregueFornecedor.ReadOnly = true;
            this.colQtEntregueFornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQtEntregueFornecedor.Width = 110;
            // 
            // colCusto
            // 
            this.colCusto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCusto.DataPropertyName = "CUSTO";
            this.colCusto.HeaderText = "Custo";
            this.colCusto.Name = "colCusto";
            this.colCusto.ReadOnly = true;
            this.colCusto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "colStatus";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Visible = false;
            this.STATUS.Width = 88;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.IconeKeyDown = null;
            this.txtProduto.Location = new System.Drawing.Point(79, 12);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(324, 24);
            this.txtProduto.TabIndex = 45;
            this.txtProduto.TipoCampo = "STRING";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 15);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 46;
            this.labelJCS1.Text = "Produto:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(433, 15);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(69, 17);
            this.labelJCS2.TabIndex = 47;
            this.labelJCS2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(508, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(280, 24);
            this.txtDescricao.TabIndex = 48;
            this.txtDescricao.TipoCampo = "STRING";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(12, 45);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(61, 17);
            this.labelJCS3.TabIndex = 49;
            this.labelJCS3.Text = "Estoque:";
            // 
            // txtQTEstoque
            // 
            this.txtQTEstoque.BackColor = System.Drawing.Color.White;
            this.txtQTEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQTEstoque.IconeKeyDown = null;
            this.txtQTEstoque.Location = new System.Drawing.Point(79, 42);
            this.txtQTEstoque.Name = "txtQTEstoque";
            this.txtQTEstoque.Preenchimento = null;
            this.txtQTEstoque.Size = new System.Drawing.Size(126, 24);
            this.txtQTEstoque.TabIndex = 50;
            this.txtQTEstoque.TipoCampo = "INTEIRO";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BackColor = System.Drawing.Color.White;
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtUnidadeMedida.IconeKeyDown = null;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(279, 42);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Preenchimento = null;
            this.txtUnidadeMedida.Size = new System.Drawing.Size(124, 24);
            this.txtUnidadeMedida.TabIndex = 52;
            this.txtUnidadeMedida.TipoCampo = "STRING";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(211, 45);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(62, 17);
            this.labelJCS4.TabIndex = 51;
            this.labelJCS4.Text = "Unidade:";
            // 
            // txtEstoqueIdeaal
            // 
            this.txtEstoqueIdeaal.BackColor = System.Drawing.Color.White;
            this.txtEstoqueIdeaal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEstoqueIdeaal.IconeKeyDown = null;
            this.txtEstoqueIdeaal.Location = new System.Drawing.Point(508, 42);
            this.txtEstoqueIdeaal.Name = "txtEstoqueIdeaal";
            this.txtEstoqueIdeaal.Preenchimento = null;
            this.txtEstoqueIdeaal.Size = new System.Drawing.Size(126, 24);
            this.txtEstoqueIdeaal.TabIndex = 54;
            this.txtEstoqueIdeaal.TipoCampo = "INTEIRO";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(409, 45);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(93, 17);
            this.labelJCS5.TabIndex = 53;
            this.labelJCS5.Text = "Estoque Ideal:";
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.White;
            this.txtCusto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCusto.IconeKeyDown = null;
            this.txtCusto.Location = new System.Drawing.Point(79, 72);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Preenchimento = null;
            this.txtCusto.Size = new System.Drawing.Size(126, 24);
            this.txtCusto.TabIndex = 56;
            this.txtCusto.TipoCampo = "MONETARIO";
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(27, 75);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(46, 17);
            this.labelJCS6.TabIndex = 55;
            this.labelJCS6.Text = "Custo:";
            // 
            // txtQtEntregueFornecedor
            // 
            this.txtQtEntregueFornecedor.BackColor = System.Drawing.Color.White;
            this.txtQtEntregueFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtEntregueFornecedor.IconeKeyDown = null;
            this.txtQtEntregueFornecedor.Location = new System.Drawing.Point(508, 72);
            this.txtQtEntregueFornecedor.Name = "txtQtEntregueFornecedor";
            this.txtQtEntregueFornecedor.Preenchimento = null;
            this.txtQtEntregueFornecedor.Size = new System.Drawing.Size(126, 24);
            this.txtQtEntregueFornecedor.TabIndex = 58;
            this.txtQtEntregueFornecedor.TipoCampo = "INTEIRO";
            // 
            // labelJCS7
            // 
            this.labelJCS7.AutoSize = true;
            this.labelJCS7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS7.Location = new System.Drawing.Point(218, 75);
            this.labelJCS7.Name = "labelJCS7";
            this.labelJCS7.Size = new System.Drawing.Size(284, 17);
            this.labelJCS7.TabIndex = 57;
            this.labelJCS7.Text = "Quantidade padrão entregue pelo fornecedor:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_editar_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Sub";
            this.dataGridViewImageColumn2.Image = global::Caixa.Properties.Resources.menos;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 37;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Excluir";
            this.dataGridViewImageColumn3.Image = global::Caixa.Properties.Resources.cancelar;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 52;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Excluir";
            this.dataGridViewImageColumn4.Image = global::Caixa.Properties.Resources.cancelar16x16;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Width = 52;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(640, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 54);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // colAumentarEstoque
            // 
            this.colAumentarEstoque.HeaderText = "Add";
            this.colAumentarEstoque.Image = global::Caixa.Properties.Resources.mais16x16;
            this.colAumentarEstoque.Name = "colAumentarEstoque";
            this.colAumentarEstoque.ReadOnly = true;
            this.colAumentarEstoque.Width = 38;
            // 
            // colDiminuirEstoque
            // 
            this.colDiminuirEstoque.HeaderText = "Sub";
            this.colDiminuirEstoque.Image = global::Caixa.Properties.Resources.menos16x16;
            this.colDiminuirEstoque.Name = "colDiminuirEstoque";
            this.colDiminuirEstoque.ReadOnly = true;
            this.colDiminuirEstoque.Width = 37;
            // 
            // colAlterar
            // 
            this.colAlterar.HeaderText = "Alterar";
            this.colAlterar.Image = global::Caixa.Properties.Resources.icons8_editar_20;
            this.colAlterar.Name = "colAlterar";
            this.colAlterar.ReadOnly = true;
            this.colAlterar.Width = 54;
            // 
            // colDesativar
            // 
            this.colDesativar.HeaderText = "Excluir";
            this.colDesativar.Image = global::Caixa.Properties.Resources.cancelar16x16;
            this.colDesativar.Name = "colDesativar";
            this.colDesativar.ReadOnly = true;
            this.colDesativar.Width = 52;
            // 
            // frmControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQtEntregueFornecedor);
            this.Controls.Add(this.labelJCS7);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.labelJCS6);
            this.Controls.Add(this.txtEstoqueIdeaal);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.txtUnidadeMedida);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.txtQTEstoque);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.dgvEstoque);
            this.Name = "frmControleEstoque";
            this.Text = "frmControleEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvEstoque;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.TextBoxJCS txtProduto;
        private Componentes.LabelJCS labelJCS1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtQTEstoque;
        private Componentes.TextBoxJCS txtUnidadeMedida;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtEstoqueIdeaal;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtCusto;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.TextBoxJCS txtQtEntregueFornecedor;
        private Componentes.LabelJCS labelJCS7;
        private Componentes.ButtonJCS btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEstoqueIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEntregueFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewImageColumn colAumentarEstoque;
        private System.Windows.Forms.DataGridViewImageColumn colDiminuirEstoque;
        private System.Windows.Forms.DataGridViewImageColumn colAlterar;
        private System.Windows.Forms.DataGridViewImageColumn colDesativar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
    }
}