namespace Caixa.Cadastro
{
    partial class frmCadastroFolgasColaboradores
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
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.cboColaborador = new Componentes.ComboBoxJCS(this.components);
            this.groupBoxJCS2 = new Componentes.GroupBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.dtpData = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.dgvFolgas = new Componentes.DataGridViewJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.cboMes = new Componentes.ComboBoxJCS(this.components);
            this.btnAddFolgasAutomatico = new Componentes.ButtonJCS(this.components);
            this.btnAddFolga = new Componentes.ButtonJCS(this.components);
            this.colColaboradorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxJCS1.SuspendLayout();
            this.groupBoxJCS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolgas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.cboMes);
            this.groupBoxJCS1.Controls.Add(this.labelJCS3);
            this.groupBoxJCS1.Controls.Add(this.labelJCS2);
            this.groupBoxJCS1.Controls.Add(this.cboColaborador);
            this.groupBoxJCS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(464, 56);
            this.groupBoxJCS1.TabIndex = 1;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtros";
            // 
            // cboColaborador
            // 
            this.cboColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColaborador.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboColaborador.FormattingEnabled = true;
            this.cboColaborador.Location = new System.Drawing.Point(65, 23);
            this.cboColaborador.Name = "cboColaborador";
            this.cboColaborador.Size = new System.Drawing.Size(188, 23);
            this.cboColaborador.TabIndex = 0;
            this.cboColaborador.SelectedIndexChanged += new System.EventHandler(this.CboColaborador_SelectedIndexChanged);
            // 
            // groupBoxJCS2
            // 
            this.groupBoxJCS2.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS2.Controls.Add(this.dtpData);
            this.groupBoxJCS2.Controls.Add(this.labelJCS1);
            this.groupBoxJCS2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS2.Location = new System.Drawing.Point(0, 56);
            this.groupBoxJCS2.Name = "groupBoxJCS2";
            this.groupBoxJCS2.Size = new System.Drawing.Size(464, 62);
            this.groupBoxJCS2.TabIndex = 3;
            this.groupBoxJCS2.TabStop = false;
            this.groupBoxJCS2.Text = "Adicionar Folgas Manual";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(19, 30);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(40, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(65, 23);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(130, 24);
            this.dtpData.TabIndex = 1;
            this.dtpData.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 26);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(47, 17);
            this.labelJCS2.TabIndex = 2;
            this.labelJCS2.Text = "Nome:";
            // 
            // dgvFolgas
            // 
            this.dgvFolgas.AllowUserToAddRows = false;
            this.dgvFolgas.AllowUserToDeleteRows = false;
            this.dgvFolgas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFolgas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFolgas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFolgas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolgas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColaboradorID,
            this.colNome,
            this.colFolga,
            this.colExcluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFolgas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFolgas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFolgas.EnableHeadersVisualStyles = false;
            this.dgvFolgas.Location = new System.Drawing.Point(0, 118);
            this.dgvFolgas.Name = "dgvFolgas";
            this.dgvFolgas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFolgas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFolgas.RowHeadersVisible = false;
            this.dgvFolgas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFolgas.Size = new System.Drawing.Size(464, 191);
            this.dgvFolgas.TabIndex = 6;
            this.dgvFolgas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFolgas_CellContentClick);
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(288, 26);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(37, 17);
            this.labelJCS3.TabIndex = 3;
            this.labelJCS3.Text = "Mês:";
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cboMes.Location = new System.Drawing.Point(331, 23);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 23);
            this.cboMes.TabIndex = 4;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.CboMes_SelectedIndexChanged);
            // 
            // btnAddFolgasAutomatico
            // 
            this.btnAddFolgasAutomatico.BackColor = System.Drawing.Color.Gold;
            this.btnAddFolgasAutomatico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddFolgasAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolgasAutomatico.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddFolgasAutomatico.Image = global::Caixa.Properties.Resources.icons8_adicionar_regra_24;
            this.btnAddFolgasAutomatico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolgasAutomatico.Location = new System.Drawing.Point(0, 309);
            this.btnAddFolgasAutomatico.Name = "btnAddFolgasAutomatico";
            this.btnAddFolgasAutomatico.Size = new System.Drawing.Size(464, 30);
            this.btnAddFolgasAutomatico.TabIndex = 7;
            this.btnAddFolgasAutomatico.Text = "Inserir Folgas Mes Atual Automatico";
            this.btnAddFolgasAutomatico.UseVisualStyleBackColor = false;
            this.btnAddFolgasAutomatico.Click += new System.EventHandler(this.BtnAddFolgasAutomatico_Click);
            // 
            // btnAddFolga
            // 
            this.btnAddFolga.BackColor = System.Drawing.Color.Gold;
            this.btnAddFolga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddFolga.Enabled = false;
            this.btnAddFolga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolga.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddFolga.Image = global::Caixa.Properties.Resources.icons8_adicionar_20;
            this.btnAddFolga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolga.Location = new System.Drawing.Point(0, 354);
            this.btnAddFolga.Name = "btnAddFolga";
            this.btnAddFolga.Size = new System.Drawing.Size(464, 30);
            this.btnAddFolga.TabIndex = 8;
            this.btnAddFolga.Text = "Adicionar Folga Manual";
            this.btnAddFolga.UseVisualStyleBackColor = false;
            this.btnAddFolga.Click += new System.EventHandler(this.BtnAddFolga_Click);
            // 
            // colColaboradorID
            // 
            this.colColaboradorID.DataPropertyName = "ID_COLABORADOR";
            this.colColaboradorID.HeaderText = "ID";
            this.colColaboradorID.Name = "colColaboradorID";
            this.colColaboradorID.ReadOnly = true;
            this.colColaboradorID.Visible = false;
            this.colColaboradorID.Width = 27;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "NOME";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colFolga
            // 
            this.colFolga.DataPropertyName = "DATA";
            this.colFolga.HeaderText = "Folga";
            this.colFolga.Name = "colFolga";
            this.colFolga.ReadOnly = true;
            this.colFolga.Width = 64;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Apagar";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 56;
            // 
            // frmCadastroFolgasColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 384);
            this.Controls.Add(this.btnAddFolga);
            this.Controls.Add(this.btnAddFolgasAutomatico);
            this.Controls.Add(this.dgvFolgas);
            this.Controls.Add(this.groupBoxJCS2);
            this.Controls.Add(this.groupBoxJCS1);
            this.Name = "frmCadastroFolgasColaboradores";
            this.Text = "frmCadastroFolgasColaboradores";
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.groupBoxJCS2.ResumeLayout(false);
            this.groupBoxJCS2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolgas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.ComboBoxJCS cboColaborador;
        private Componentes.GroupBoxJCS groupBoxJCS2;
        private Componentes.dateTimePickerJCS dtpData;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.ComboBoxJCS cboMes;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.DataGridViewJCS dgvFolgas;
        private Componentes.ButtonJCS btnAddFolgasAutomatico;
        private Componentes.ButtonJCS btnAddFolga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColaboradorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolga;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}