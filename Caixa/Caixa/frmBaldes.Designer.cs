namespace Caixa.Caixa
{
    partial class frmBaldes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new Componentes.TextBoxJCS(this.components);
            this.lblValor = new Componentes.LabelJCS(this.components);
            this.btnSalvar = new Componentes.ButtonJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtEnd = new Componentes.TextBoxJCS(this.components);
            this.cboBalde = new Componentes.ComboBoxJCS(this.components);
            this.txtNumero = new Componentes.TextBoxJCS(this.components);
            this.dgvBaldes = new Componentes.DataGridViewJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtTelefone = new Componentes.TextBoxJCS(this.components);
            this.cboFiltro = new Componentes.ComboBoxJCS(this.components);
            this.lblFiltro = new Componentes.LabelJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtColher = new Componentes.TextBoxJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_DEVOLUCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntregue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaldes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNome.IconeKeyDown = null;
            this.txtNome.Location = new System.Drawing.Point(80, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Preenchimento = null;
            this.txtNome.Size = new System.Drawing.Size(309, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.TipoCampo = "STRING";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblValor.Location = new System.Drawing.Point(27, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(47, 17);
            this.lblValor.TabIndex = 58;
            this.lblValor.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(394, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(153, 48);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Novo Balde";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(39, 69);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(35, 17);
            this.labelJCS1.TabIndex = 59;
            this.labelJCS1.Text = "End:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(29, 99);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(45, 17);
            this.labelJCS2.TabIndex = 60;
            this.labelJCS2.Text = "Balde:";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(251, 99);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(27, 17);
            this.labelJCS3.TabIndex = 61;
            this.labelJCS3.Text = "Nº:";
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.White;
            this.txtEnd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEnd.IconeKeyDown = null;
            this.txtEnd.Location = new System.Drawing.Point(80, 66);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Preenchimento = null;
            this.txtEnd.Size = new System.Drawing.Size(309, 24);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.TipoCampo = "STRING";
            // 
            // cboBalde
            // 
            this.cboBalde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBalde.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboBalde.FormattingEnabled = true;
            this.cboBalde.Items.AddRange(new object[] {
            "04 LITROS",
            "05 LITROS",
            "10 LITROS",
            "APENAS COLHER"});
            this.cboBalde.Location = new System.Drawing.Point(80, 96);
            this.cboBalde.Name = "cboBalde";
            this.cboBalde.Size = new System.Drawing.Size(165, 23);
            this.cboBalde.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumero.IconeKeyDown = null;
            this.txtNumero.Location = new System.Drawing.Point(284, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Preenchimento = null;
            this.txtNumero.Size = new System.Drawing.Size(105, 24);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TipoCampo = "INTEIRO";
            // 
            // dgvBaldes
            // 
            this.dgvBaldes.AllowUserToAddRows = false;
            this.dgvBaldes.AllowUserToDeleteRows = false;
            this.dgvBaldes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBaldes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaldes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBaldes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaldes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colEnd,
            this.colBalde,
            this.colColher,
            this.colTelefone,
            this.colData,
            this.DT_DEVOLUCAO,
            this.colEntregue,
            this.colEditar});
            this.dgvBaldes.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaldes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBaldes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBaldes.EnableHeadersVisualStyles = false;
            this.dgvBaldes.Location = new System.Drawing.Point(0, 169);
            this.dgvBaldes.Name = "dgvBaldes";
            this.dgvBaldes.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaldes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBaldes.RowHeadersVisible = false;
            this.dgvBaldes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaldes.Size = new System.Drawing.Size(908, 281);
            this.dgvBaldes.TabIndex = 101;
            this.dgvBaldes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBaldes_CellClick);
            this.dgvBaldes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvBaldes_CellFormatting);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(12, 39);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(62, 17);
            this.labelJCS4.TabIndex = 102;
            this.labelJCS4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtTelefone.IconeKeyDown = null;
            this.txtTelefone.Location = new System.Drawing.Point(80, 36);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Preenchimento = null;
            this.txtTelefone.Size = new System.Drawing.Size(309, 24);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.TipoCampo = "INTEIRO";
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "BALDES NÃO ENTREGUES",
            "BALDES ENTREGUES",
            "TODOS OS BALDES"});
            this.cboFiltro.Location = new System.Drawing.Point(712, 112);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(184, 23);
            this.cboFiltro.TabIndex = 7;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.CboFiltro_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiltro.Location = new System.Drawing.Point(664, 115);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(42, 17);
            this.lblFiltro.TabIndex = 104;
            this.lblFiltro.Text = "Filtro:";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(154, 129);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(124, 17);
            this.labelJCS5.TabIndex = 105;
            this.labelJCS5.Text = "Quantidade Colher:";
            // 
            // txtColher
            // 
            this.txtColher.BackColor = System.Drawing.Color.White;
            this.txtColher.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtColher.IconeKeyDown = null;
            this.txtColher.Location = new System.Drawing.Point(284, 126);
            this.txtColher.Name = "txtColher";
            this.txtColher.Preenchimento = null;
            this.txtColher.Size = new System.Drawing.Size(105, 24);
            this.txtColher.TabIndex = 5;
            this.txtColher.TipoCampo = "INTEIRO";
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
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "NOME";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEnd
            // 
            this.colEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEnd.DataPropertyName = "ENDERECO";
            this.colEnd.HeaderText = "Endereço";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            // 
            // colBalde
            // 
            this.colBalde.DataPropertyName = "BALDE";
            this.colBalde.HeaderText = "Balde";
            this.colBalde.Name = "colBalde";
            this.colBalde.ReadOnly = true;
            this.colBalde.Width = 66;
            // 
            // colColher
            // 
            this.colColher.DataPropertyName = "COLHER";
            this.colColher.HeaderText = "Colher";
            this.colColher.Name = "colColher";
            this.colColher.ReadOnly = true;
            this.colColher.Width = 71;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "TELEFONE";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 83;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 61;
            // 
            // DT_DEVOLUCAO
            // 
            this.DT_DEVOLUCAO.DataPropertyName = "DATA_ENTREGA";
            this.DT_DEVOLUCAO.HeaderText = "Devolução";
            this.DT_DEVOLUCAO.Name = "DT_DEVOLUCAO";
            this.DT_DEVOLUCAO.ReadOnly = true;
            this.DT_DEVOLUCAO.Width = 96;
            // 
            // colEntregue
            // 
            this.colEntregue.DataPropertyName = "ENTREGUE";
            this.colEntregue.FalseValue = "0";
            this.colEntregue.HeaderText = "Entregue";
            this.colEntregue.IndeterminateValue = "0";
            this.colEntregue.Name = "colEntregue";
            this.colEntregue.ReadOnly = true;
            this.colEntregue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEntregue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEntregue.TrueValue = "1";
            this.colEntregue.Width = 87;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Image = global::Caixa.Properties.Resources.icons8_editar_20;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Width = 49;
            // 
            // frmBaldes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.txtColher);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.dgvBaldes);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboBalde);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmBaldes";
            this.Text = "frmBaldes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaldes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxJCS txtNome;
        private Componentes.LabelJCS lblValor;
        private Componentes.ButtonJCS btnSalvar;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtEnd;
        private Componentes.ComboBoxJCS cboBalde;
        private Componentes.TextBoxJCS txtNumero;
        private Componentes.DataGridViewJCS dgvBaldes;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtTelefone;
        private Componentes.ComboBoxJCS cboFiltro;
        private Componentes.LabelJCS lblFiltro;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtColher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_DEVOLUCAO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEntregue;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
    }
}