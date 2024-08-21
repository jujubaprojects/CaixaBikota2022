namespace Caixa.Cadastro
{
    partial class frmCadastroLembrete
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
            this.cboRepetir = new Componentes.ComboBoxJCS(this.components);
            this.dgvLembretes = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExibirApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.dtpData = new Componentes.dateTimePickerJCS(this.components);
            this.cboStatus = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLembretes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRepetir
            // 
            this.cboRepetir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepetir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboRepetir.FormattingEnabled = true;
            this.cboRepetir.Location = new System.Drawing.Point(253, 82);
            this.cboRepetir.Name = "cboRepetir";
            this.cboRepetir.Size = new System.Drawing.Size(134, 23);
            this.cboRepetir.TabIndex = 29;
            // 
            // dgvLembretes
            // 
            this.dgvLembretes.AllowUserToAddRows = false;
            this.dgvLembretes.AllowUserToDeleteRows = false;
            this.dgvLembretes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLembretes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLembretes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLembretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLembretes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colQtDesc,
            this.colTipo,
            this.colExibirApp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLembretes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLembretes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLembretes.EnableHeadersVisualStyles = false;
            this.dgvLembretes.Location = new System.Drawing.Point(0, 112);
            this.dgvLembretes.Name = "dgvLembretes";
            this.dgvLembretes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLembretes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLembretes.RowHeadersVisible = false;
            this.dgvLembretes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLembretes.Size = new System.Drawing.Size(569, 338);
            this.dgvLembretes.TabIndex = 28;
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
            // colQtDesc
            // 
            this.colQtDesc.DataPropertyName = "DATA";
            this.colQtDesc.HeaderText = "Data";
            this.colQtDesc.Name = "colQtDesc";
            this.colQtDesc.ReadOnly = true;
            this.colQtDesc.Width = 61;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.DataPropertyName = "REPETIR";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colExibirApp
            // 
            this.colExibirApp.DataPropertyName = "STATUS";
            this.colExibirApp.HeaderText = "Status";
            this.colExibirApp.Name = "colExibirApp";
            this.colExibirApp.ReadOnly = true;
            this.colExibirApp.Width = 71;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Yellow;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(192, 52);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = "Required";
            this.txtDescricao.Size = new System.Drawing.Size(357, 24);
            this.txtDescricao.TabIndex = 22;
            this.txtDescricao.TipoCampo = "STRING";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(192, 85);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(55, 17);
            this.labelJCS3.TabIndex = 19;
            this.labelJCS3.Text = "Repetir:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(40, 85);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(40, 17);
            this.labelJCS2.TabIndex = 18;
            this.labelJCS2.Text = "Data:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(86, 52);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = "";
            this.txtID.Size = new System.Drawing.Size(100, 24);
            this.txtID.TabIndex = 17;
            this.txtID.TipoCampo = "INTEIRO";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 55);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(68, 17);
            this.labelJCS1.TabIndex = 16;
            this.labelJCS1.Text = "Lembrete:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(86, 82);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 24);
            this.dtpData.TabIndex = 30;
            this.dtpData.Value = new System.DateTime(2024, 8, 21, 0, 0, 0, 0);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(449, 82);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 23);
            this.cboStatus.TabIndex = 32;
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(393, 85);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(50, 17);
            this.labelJCS4.TabIndex = 31;
            this.labelJCS4.Text = "Status:";
            // 
            // frmCadastroLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cboRepetir);
            this.Controls.Add(this.dgvLembretes);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelJCS1);
            this.Name = "frmCadastroLembrete";
            this.Text = "Cadastro de Lembretes";
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.labelJCS3, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.dgvLembretes, 0);
            this.Controls.SetChildIndex(this.cboRepetir, 0);
            this.Controls.SetChildIndex(this.dtpData, 0);
            this.Controls.SetChildIndex(this.labelJCS4, 0);
            this.Controls.SetChildIndex(this.cboStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLembretes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.ComboBoxJCS cboRepetir;
        private Componentes.DataGridViewJCS dgvLembretes;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtID;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.dateTimePickerJCS dtpData;
        private Componentes.ComboBoxJCS cboStatus;
        private Componentes.LabelJCS labelJCS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExibirApp;
    }
}