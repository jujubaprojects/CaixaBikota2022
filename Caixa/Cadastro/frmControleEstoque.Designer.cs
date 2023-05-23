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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstoque = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEstoqueIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtQTEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtEstoqueIdeaal = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new Componentes.ButtonJCS(this.components);
            this.chkAtivo = new Componentes.CheckBoxJCS(this.components);
            this.cboStatus = new Componentes.ComboBoxJCS(this.components);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colEstoque,
            this.colQtEstoqueIdeal,
            this.STATUS,
            this.colAlterar});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvEstoque.EnableHeadersVisualStyles = false;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 128);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(802, 322);
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
            // colQtEstoqueIdeal
            // 
            this.colQtEstoqueIdeal.DataPropertyName = "QT_ESTOQUE_IDEAL";
            this.colQtEstoqueIdeal.HeaderText = "Estoque Ideal";
            this.colQtEstoqueIdeal.Name = "colQtEstoqueIdeal";
            this.colQtEstoqueIdeal.ReadOnly = true;
            this.colQtEstoqueIdeal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQtEstoqueIdeal.Width = 114;
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
            // colAlterar
            // 
            this.colAlterar.HeaderText = "Alterar";
            this.colAlterar.Image = global::Caixa.Properties.Resources.icons8_editar_20;
            this.colAlterar.Name = "colAlterar";
            this.colAlterar.ReadOnly = true;
            this.colAlterar.Width = 54;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 15);
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
            this.txtDescricao.Location = new System.Drawing.Point(87, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(547, 24);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TipoCampo = "STRING";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(20, 45);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(61, 17);
            this.labelJCS3.TabIndex = 49;
            this.labelJCS3.Text = "Estoque:";
            // 
            // txtQTEstoque
            // 
            this.txtQTEstoque.BackColor = System.Drawing.Color.White;
            this.txtQTEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQTEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQTEstoque.IconeKeyDown = null;
            this.txtQTEstoque.Location = new System.Drawing.Point(87, 42);
            this.txtQTEstoque.Name = "txtQTEstoque";
            this.txtQTEstoque.Preenchimento = null;
            this.txtQTEstoque.Size = new System.Drawing.Size(126, 24);
            this.txtQTEstoque.TabIndex = 2;
            this.txtQTEstoque.TipoCampo = "INTEIRO";
            // 
            // txtEstoqueIdeaal
            // 
            this.txtEstoqueIdeaal.BackColor = System.Drawing.Color.White;
            this.txtEstoqueIdeaal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstoqueIdeaal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEstoqueIdeaal.IconeKeyDown = null;
            this.txtEstoqueIdeaal.Location = new System.Drawing.Point(337, 42);
            this.txtEstoqueIdeaal.Name = "txtEstoqueIdeaal";
            this.txtEstoqueIdeaal.Preenchimento = null;
            this.txtEstoqueIdeaal.Size = new System.Drawing.Size(126, 24);
            this.txtEstoqueIdeaal.TabIndex = 4;
            this.txtEstoqueIdeaal.TipoCampo = "INTEIRO";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(238, 45);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(93, 17);
            this.labelJCS5.TabIndex = 53;
            this.labelJCS5.Text = "Estoque Ideal:";
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
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(640, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 54);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkAtivo.Location = new System.Drawing.Point(522, 41);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(112, 21);
            this.chkAtivo.TabIndex = 54;
            this.chkAtivo.Text = "Controle Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "CONTROLE INATIVO",
            "CONTROLE ATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(15, 99);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(198, 23);
            this.cboStatus.TabIndex = 55;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
            // 
            // frmControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEstoqueIdeaal);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.txtQTEstoque);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.dgvEstoque);
            this.Name = "frmControleEstoque";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvEstoque;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtQTEstoque;
        private Componentes.TextBoxJCS txtEstoqueIdeaal;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.ButtonJCS btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEstoqueIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewImageColumn colAlterar;
        private Componentes.CheckBoxJCS chkAtivo;
        private Componentes.ComboBoxJCS cboStatus;
    }
}