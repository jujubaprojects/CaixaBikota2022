namespace Caixa.Cadastro
{
    partial class frmCadastroOcorrenciaColaborador
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
            this.dgvOcorrencias = new Componentes.DataGridViewJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.dtpData = new Componentes.dateTimePickerJCS(this.components);
            this.txtDesOcorrencia = new Componentes.TextBoxJCS(this.components);
            this.cboColaborador = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.btnAdd = new Componentes.ButtonJCS(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.cboFiltroColaborador = new Componentes.ComboBoxJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AllowUserToAddRows = false;
            this.dgvOcorrencias.AllowUserToDeleteRows = false;
            this.dgvOcorrencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOcorrencias.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOcorrencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colColaborador,
            this.colDescricao,
            this.colData});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOcorrencias.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOcorrencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOcorrencias.EnableHeadersVisualStyles = false;
            this.dgvOcorrencias.Location = new System.Drawing.Point(0, 221);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOcorrencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOcorrencias.RowHeadersVisible = false;
            this.dgvOcorrencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOcorrencias.Size = new System.Drawing.Size(484, 164);
            this.dgvOcorrencias.TabIndex = 0;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(29, 44);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(69, 17);
            this.labelJCS1.TabIndex = 1;
            this.labelJCS1.Text = "Descrição:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(104, 122);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(130, 24);
            this.dtpData.TabIndex = 2;
            this.dtpData.Value = new System.DateTime(2024, 6, 22, 0, 0, 0, 0);
            // 
            // txtDesOcorrencia
            // 
            this.txtDesOcorrencia.BackColor = System.Drawing.Color.White;
            this.txtDesOcorrencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesOcorrencia.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDesOcorrencia.IconeKeyDown = null;
            this.txtDesOcorrencia.Location = new System.Drawing.Point(104, 41);
            this.txtDesOcorrencia.Multiline = true;
            this.txtDesOcorrencia.Name = "txtDesOcorrencia";
            this.txtDesOcorrencia.Preenchimento = null;
            this.txtDesOcorrencia.Size = new System.Drawing.Size(370, 75);
            this.txtDesOcorrencia.TabIndex = 3;
            this.txtDesOcorrencia.TipoCampo = null;
            // 
            // cboColaborador
            // 
            this.cboColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColaborador.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboColaborador.FormattingEnabled = true;
            this.cboColaborador.Location = new System.Drawing.Point(104, 12);
            this.cboColaborador.Name = "cboColaborador";
            this.cboColaborador.Size = new System.Drawing.Size(370, 23);
            this.cboColaborador.TabIndex = 4;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 15);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(86, 17);
            this.labelJCS2.TabIndex = 5;
            this.labelJCS2.Text = "Colaborador:";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(58, 129);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(40, 17);
            this.labelJCS3.TabIndex = 6;
            this.labelJCS3.Text = "Data:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(240, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar Ocorrencia";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.cboFiltroColaborador);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 172);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(484, 43);
            this.groupBoxJCS1.TabIndex = 8;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtro";
            // 
            // cboFiltroColaborador
            // 
            this.cboFiltroColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroColaborador.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFiltroColaborador.FormattingEnabled = true;
            this.cboFiltroColaborador.Location = new System.Drawing.Point(104, 14);
            this.cboFiltroColaborador.Name = "cboFiltroColaborador";
            this.cboFiltroColaborador.Size = new System.Drawing.Size(370, 23);
            this.cboFiltroColaborador.TabIndex = 9;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 27;
            // 
            // colColaborador
            // 
            this.colColaborador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colColaborador.DataPropertyName = "NOME";
            this.colColaborador.HeaderText = "Colaborador";
            this.colColaborador.Name = "colColaborador";
            this.colColaborador.Width = 107;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Ocorrência";
            this.colDescricao.Name = "colDescricao";
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.Width = 61;
            // 
            // frmCadastroOcorrenciaColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 385);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.cboColaborador);
            this.Controls.Add(this.txtDesOcorrencia);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.dgvOcorrencias);
            this.MaximumSize = new System.Drawing.Size(500, 424);
            this.MinimumSize = new System.Drawing.Size(500, 424);
            this.Name = "frmCadastroOcorrenciaColaborador";
            this.Text = "Ocorrências Colaborador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.groupBoxJCS1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvOcorrencias;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.dateTimePickerJCS dtpData;
        private Componentes.TextBoxJCS txtDesOcorrencia;
        private Componentes.ComboBoxJCS cboColaborador;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.ButtonJCS btnAdd;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.ComboBoxJCS cboFiltroColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}