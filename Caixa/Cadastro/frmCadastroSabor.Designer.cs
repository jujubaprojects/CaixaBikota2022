namespace Caixa.Cadastro
{
    partial class frmCadastroSabor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSabores = new Componentes.DataGridViewJCS(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.txtSaborFiltro = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.cboTipoFiltro = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.chkStatus = new Componentes.CheckBoxJCS(this.components);
            this.txtSabor = new Componentes.TextBoxJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboTipo = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabores)).BeginInit();
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSabores
            // 
            this.dgvSabores.AllowUserToAddRows = false;
            this.dgvSabores.AllowUserToDeleteRows = false;
            this.dgvSabores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSabores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSabores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSabores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colTipo,
            this.colStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSabores.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSabores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSabores.EnableHeadersVisualStyles = false;
            this.dgvSabores.Location = new System.Drawing.Point(0, 148);
            this.dgvSabores.Name = "dgvSabores";
            this.dgvSabores.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSabores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSabores.RowHeadersVisible = false;
            this.dgvSabores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSabores.Size = new System.Drawing.Size(800, 302);
            this.dgvSabores.TabIndex = 5;
            this.dgvSabores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlertas_CellClick);
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.txtSaborFiltro);
            this.groupBoxJCS1.Controls.Add(this.labelJCS3);
            this.groupBoxJCS1.Controls.Add(this.cboTipoFiltro);
            this.groupBoxJCS1.Controls.Add(this.labelJCS2);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(12, 42);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(776, 70);
            this.groupBoxJCS1.TabIndex = 11;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtros";
            // 
            // txtSaborFiltro
            // 
            this.txtSaborFiltro.BackColor = System.Drawing.Color.White;
            this.txtSaborFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaborFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtSaborFiltro.IconeKeyDown = null;
            this.txtSaborFiltro.Location = new System.Drawing.Point(506, 23);
            this.txtSaborFiltro.Name = "txtSaborFiltro";
            this.txtSaborFiltro.Preenchimento = null;
            this.txtSaborFiltro.Size = new System.Drawing.Size(264, 24);
            this.txtSaborFiltro.TabIndex = 3;
            this.txtSaborFiltro.TipoCampo = null;
            this.txtSaborFiltro.TextChanged += new System.EventHandler(this.txtSaborFiltro_TextChanged);
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(453, 27);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(47, 17);
            this.labelJCS3.TabIndex = 2;
            this.labelJCS3.Text = "Sabor:";
            // 
            // cboTipoFiltro
            // 
            this.cboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipoFiltro.FormattingEnabled = true;
            this.cboTipoFiltro.Location = new System.Drawing.Point(50, 24);
            this.cboTipoFiltro.Name = "cboTipoFiltro";
            this.cboTipoFiltro.Size = new System.Drawing.Size(136, 23);
            this.cboTipoFiltro.TabIndex = 1;
            this.cboTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cboTipoFiltro_SelectedIndexChanged);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(6, 27);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(38, 17);
            this.labelJCS2.TabIndex = 0;
            this.labelJCS2.Text = "Tipo:";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkStatus.Location = new System.Drawing.Point(727, 119);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(58, 21);
            this.chkStatus.TabIndex = 10;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtSabor
            // 
            this.txtSabor.BackColor = System.Drawing.Color.White;
            this.txtSabor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSabor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtSabor.IconeKeyDown = null;
            this.txtSabor.Location = new System.Drawing.Point(118, 118);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Preenchimento = null;
            this.txtSabor.Size = new System.Drawing.Size(335, 24);
            this.txtSabor.TabIndex = 9;
            this.txtSabor.TipoCampo = null;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(62, 118);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = null;
            this.txtID.Size = new System.Drawing.Size(50, 24);
            this.txtID.TabIndex = 8;
            this.txtID.TipoCampo = null;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(9, 121);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(47, 17);
            this.labelJCS1.TabIndex = 7;
            this.labelJCS1.Text = "Sabor:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(518, 118);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(203, 23);
            this.cboTipo.TabIndex = 4;
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(474, 121);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(38, 17);
            this.labelJCS4.TabIndex = 4;
            this.labelJCS4.Text = "Tipo:";
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 46;
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
            this.colTipo.DataPropertyName = "TIPO";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 59;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "ATIVO";
            this.colStatus.FalseValue = "0";
            this.colStatus.HeaderText = "Ativo";
            this.colStatus.IndeterminateValue = "0";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.TrueValue = "1";
            this.colStatus.Width = 45;
            // 
            // frmCadastroSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.dgvSabores);
            this.Name = "frmCadastroSabor";
            this.Text = "Cadastro de Sabores";
            this.Controls.SetChildIndex(this.dgvSabores, 0);
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtSabor, 0);
            this.Controls.SetChildIndex(this.chkStatus, 0);
            this.Controls.SetChildIndex(this.groupBoxJCS1, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.labelJCS4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabores)).EndInit();
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.DataGridViewJCS dgvSabores;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.TextBoxJCS txtSaborFiltro;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.ComboBoxJCS cboTipoFiltro;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.CheckBoxJCS chkStatus;
        private Componentes.TextBoxJCS txtSabor;
        private Componentes.TextBoxJCS txtID;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ComboBoxJCS cboTipo;
        private Componentes.LabelJCS labelJCS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    }
}