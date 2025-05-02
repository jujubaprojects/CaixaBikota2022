namespace Caixa.Cadastro
{
    partial class frmCadastroBloqueioEstoqueSubManual
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
            this.grpFiltro = new Componentes.GroupBoxJCS(this.components);
            this.dgvBloqueioEstoque = new Componentes.DataGridViewJCS(this.components);
            this.colIDEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboFiltro = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboTipo = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtIDEstoque = new Componentes.TextBoxJCS(this.components);
            this.txtDescEstoque = new Componentes.TextBoxJCS(this.components);
            this.btnBuscar = new Componentes.ButtonJCS(this.components);
            this.btnSalvarEstoque = new Componentes.ButtonJCS(this.components);
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloqueioEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltro
            // 
            this.grpFiltro.BackColor = System.Drawing.Color.White;
            this.grpFiltro.Controls.Add(this.dgvBloqueioEstoque);
            this.grpFiltro.Controls.Add(this.cboFiltro);
            this.grpFiltro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltro.Location = new System.Drawing.Point(0, 93);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(800, 357);
            this.grpFiltro.TabIndex = 0;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // dgvBloqueioEstoque
            // 
            this.dgvBloqueioEstoque.AllowUserToAddRows = false;
            this.dgvBloqueioEstoque.AllowUserToDeleteRows = false;
            this.dgvBloqueioEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBloqueioEstoque.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloqueioEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBloqueioEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloqueioEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEstoque,
            this.colDescricao,
            this.colTipoEst,
            this.colApagar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBloqueioEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBloqueioEstoque.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBloqueioEstoque.EnableHeadersVisualStyles = false;
            this.dgvBloqueioEstoque.Location = new System.Drawing.Point(3, 52);
            this.dgvBloqueioEstoque.Name = "dgvBloqueioEstoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBloqueioEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBloqueioEstoque.RowHeadersVisible = false;
            this.dgvBloqueioEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloqueioEstoque.Size = new System.Drawing.Size(794, 302);
            this.dgvBloqueioEstoque.TabIndex = 1;
            this.dgvBloqueioEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBloqueioEstoque_CellClick);
            // 
            // colIDEstoque
            // 
            this.colIDEstoque.DataPropertyName = "ID_ESTOQUE";
            this.colIDEstoque.HeaderText = "ID Estoque";
            this.colIDEstoque.Name = "colIDEstoque";
            this.colIDEstoque.Width = 98;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            // 
            // colTipoEst
            // 
            this.colTipoEst.DataPropertyName = "TIPO_EST";
            this.colTipoEst.HeaderText = "TipoEst";
            this.colTipoEst.Name = "colTipoEst";
            this.colTipoEst.Visible = false;
            this.colTipoEst.Width = 77;
            // 
            // colApagar
            // 
            this.colApagar.HeaderText = "Apagar";
            this.colApagar.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colApagar.Name = "colApagar";
            this.colApagar.Width = 56;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "TODOS OS ESTOQUES",
            "APENAS POTES DE SORVETE",
            "APENAS MATERIAS PRIMA"});
            this.cboFiltro.Location = new System.Drawing.Point(6, 23);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(782, 23);
            this.cboFiltro.TabIndex = 0;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.CboFiltro_SelectedIndexChanged);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 15);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(63, 17);
            this.labelJCS1.TabIndex = 1;
            this.labelJCS1.Text = "Tipo Est.:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "SELECIONE AQUI",
            "POTES DE SORVETE",
            "MATERIAS PRIMA"});
            this.cboTipo.Location = new System.Drawing.Point(81, 12);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 23);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.CboTipo_SelectedIndexChanged);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(218, 15);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(61, 17);
            this.labelJCS2.TabIndex = 3;
            this.labelJCS2.Text = "Estoque:";
            // 
            // txtIDEstoque
            // 
            this.txtIDEstoque.BackColor = System.Drawing.Color.White;
            this.txtIDEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDEstoque.Enabled = false;
            this.txtIDEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDEstoque.IconeKeyDown = null;
            this.txtIDEstoque.Location = new System.Drawing.Point(285, 12);
            this.txtIDEstoque.Name = "txtIDEstoque";
            this.txtIDEstoque.Preenchimento = null;
            this.txtIDEstoque.Size = new System.Drawing.Size(40, 24);
            this.txtIDEstoque.TabIndex = 4;
            this.txtIDEstoque.TipoCampo = null;
            // 
            // txtDescEstoque
            // 
            this.txtDescEstoque.BackColor = System.Drawing.Color.White;
            this.txtDescEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescEstoque.IconeKeyDown = null;
            this.txtDescEstoque.Location = new System.Drawing.Point(331, 11);
            this.txtDescEstoque.Name = "txtDescEstoque";
            this.txtDescEstoque.Preenchimento = null;
            this.txtDescEstoque.Size = new System.Drawing.Size(323, 24);
            this.txtDescEstoque.TabIndex = 5;
            this.txtDescEstoque.TipoCampo = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gold;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = global::Caixa.Properties.Resources.mecanismo_de_pesquisa_na_web20x20;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(660, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Estoque";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnSalvarEstoque
            // 
            this.btnSalvarEstoque.BackColor = System.Drawing.Color.Gold;
            this.btnSalvarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEstoque.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnSalvarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarEstoque.Location = new System.Drawing.Point(12, 42);
            this.btnSalvarEstoque.Name = "btnSalvarEstoque";
            this.btnSalvarEstoque.Size = new System.Drawing.Size(776, 24);
            this.btnSalvarEstoque.TabIndex = 7;
            this.btnSalvarEstoque.Text = "Salvar Estoque";
            this.btnSalvarEstoque.UseVisualStyleBackColor = false;
            this.btnSalvarEstoque.Click += new System.EventHandler(this.BtnSalvarEstoque_Click);
            // 
            // frmCadastroBloqueioEstoqueSubManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarEstoque);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDescEstoque);
            this.Controls.Add(this.txtIDEstoque);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.grpFiltro);
            this.Name = "frmCadastroBloqueioEstoqueSubManual";
            this.Text = "Cadastro de Bloqueio Manuel de Subtrair Estoque";
            this.grpFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloqueioEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GroupBoxJCS grpFiltro;
        private Componentes.DataGridViewJCS dgvBloqueioEstoque;
        private Componentes.ComboBoxJCS cboFiltro;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ComboBoxJCS cboTipo;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtIDEstoque;
        private Componentes.TextBoxJCS txtDescEstoque;
        private Componentes.ButtonJCS btnBuscar;
        private Componentes.ButtonJCS btnSalvarEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEst;
        private System.Windows.Forms.DataGridViewImageColumn colApagar;
    }
}