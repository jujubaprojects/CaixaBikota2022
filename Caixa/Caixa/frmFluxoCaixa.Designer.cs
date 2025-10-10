namespace Caixa.Caixa
{
    partial class frmFluxoCaixa
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
            this.lblDinheiro = new Componentes.LabelJCS(this.components);
            this.grpSaldo = new Componentes.GroupBoxJCS(this.components);
            this.lblDigital = new Componentes.LabelJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtValorManual = new Componentes.TextBoxJCS(this.components);
            this.cboTipo = new Componentes.ComboBoxJCS(this.components);
            this.grpAddManual = new Componentes.GroupBoxJCS(this.components);
            this.btnAddManual = new Componentes.ButtonJCS(this.components);
            this.grpFiltros = new Componentes.GroupBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.dtpDataInicial = new Componentes.dateTimePickerJCS(this.components);
            this.dtpDataFinal = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.cboFiltroPagamento = new Componentes.ComboBoxJCS(this.components);
            this.dgvFluxoCaixa = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSaldo.SuspendLayout();
            this.grpAddManual.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDinheiro.ForeColor = System.Drawing.Color.Red;
            this.lblDinheiro.Location = new System.Drawing.Point(6, 27);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(149, 19);
            this.lblDinheiro.TabIndex = 0;
            this.lblDinheiro.Text = "Dinheiro: R$ 0000,00";
            // 
            // grpSaldo
            // 
            this.grpSaldo.BackColor = System.Drawing.Color.White;
            this.grpSaldo.Controls.Add(this.lblDigital);
            this.grpSaldo.Controls.Add(this.lblDinheiro);
            this.grpSaldo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaldo.Location = new System.Drawing.Point(454, 12);
            this.grpSaldo.Name = "grpSaldo";
            this.grpSaldo.Size = new System.Drawing.Size(200, 77);
            this.grpSaldo.TabIndex = 1;
            this.grpSaldo.TabStop = false;
            this.grpSaldo.Text = "Saldo";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDigital.ForeColor = System.Drawing.Color.Green;
            this.lblDigital.Location = new System.Drawing.Point(6, 58);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(134, 19);
            this.lblDigital.TabIndex = 1;
            this.lblDigital.Text = "Digital: R$ 0000,00";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(6, 27);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(42, 17);
            this.labelJCS1.TabIndex = 2;
            this.labelJCS1.Text = "Valor:";
            // 
            // txtValorManual
            // 
            this.txtValorManual.BackColor = System.Drawing.Color.White;
            this.txtValorManual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorManual.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtValorManual.IconeKeyDown = null;
            this.txtValorManual.Location = new System.Drawing.Point(54, 23);
            this.txtValorManual.Name = "txtValorManual";
            this.txtValorManual.Preenchimento = null;
            this.txtValorManual.Size = new System.Drawing.Size(130, 24);
            this.txtValorManual.TabIndex = 4;
            this.txtValorManual.TipoCampo = "MONETARIO";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(190, 23);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 23);
            this.cboTipo.TabIndex = 5;
            // 
            // grpAddManual
            // 
            this.grpAddManual.BackColor = System.Drawing.Color.White;
            this.grpAddManual.Controls.Add(this.labelJCS1);
            this.grpAddManual.Controls.Add(this.btnAddManual);
            this.grpAddManual.Controls.Add(this.cboTipo);
            this.grpAddManual.Controls.Add(this.txtValorManual);
            this.grpAddManual.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.grpAddManual.Location = new System.Drawing.Point(11, 12);
            this.grpAddManual.Name = "grpAddManual";
            this.grpAddManual.Size = new System.Drawing.Size(437, 77);
            this.grpAddManual.TabIndex = 6;
            this.grpAddManual.TabStop = false;
            this.grpAddManual.Text = "Adicionar Valor Manual";
            // 
            // btnAddManual
            // 
            this.btnAddManual.BackColor = System.Drawing.Color.Gold;
            this.btnAddManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManual.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddManual.Image = global::Caixa.Properties.Resources.icons8_adicionar_regra_24;
            this.btnAddManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManual.Location = new System.Drawing.Point(317, 24);
            this.btnAddManual.Name = "btnAddManual";
            this.btnAddManual.Size = new System.Drawing.Size(109, 24);
            this.btnAddManual.TabIndex = 3;
            this.btnAddManual.Text = "Adicionar";
            this.btnAddManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManual.UseVisualStyleBackColor = false;
            this.btnAddManual.Click += new System.EventHandler(this.btnAddManual_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.White;
            this.grpFiltros.Controls.Add(this.cboFiltroPagamento);
            this.grpFiltros.Controls.Add(this.labelJCS3);
            this.grpFiltros.Controls.Add(this.dtpDataFinal);
            this.grpFiltros.Controls.Add(this.dtpDataInicial);
            this.grpFiltros.Controls.Add(this.labelJCS2);
            this.grpFiltros.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltros.Location = new System.Drawing.Point(12, 95);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(642, 56);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtro";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(6, 30);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(40, 17);
            this.labelJCS2.TabIndex = 0;
            this.labelJCS2.Text = "Data:";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicial.Location = new System.Drawing.Point(53, 23);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(106, 24);
            this.dtpDataInicial.TabIndex = 1;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(189, 23);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(106, 24);
            this.dtpDataFinal.TabIndex = 2;
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(401, 26);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(108, 17);
            this.labelJCS3.TabIndex = 3;
            this.labelJCS3.Text = "Tipo Pagamento:";
            // 
            // cboFiltroPagamento
            // 
            this.cboFiltroPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFiltroPagamento.FormattingEnabled = true;
            this.cboFiltroPagamento.Items.AddRange(new object[] {
            "Todos",
            "Dinheiro",
            "Digital",
            "Manual Ajuste"});
            this.cboFiltroPagamento.Location = new System.Drawing.Point(515, 23);
            this.cboFiltroPagamento.Name = "cboFiltroPagamento";
            this.cboFiltroPagamento.Size = new System.Drawing.Size(121, 23);
            this.cboFiltroPagamento.TabIndex = 6;
            // 
            // dgvFluxoCaixa
            // 
            this.dgvFluxoCaixa.AllowUserToAddRows = false;
            this.dgvFluxoCaixa.AllowUserToDeleteRows = false;
            this.dgvFluxoCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFluxoCaixa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFluxoCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFluxoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colData,
            this.colValor,
            this.colTipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFluxoCaixa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFluxoCaixa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFluxoCaixa.EnableHeadersVisualStyles = false;
            this.dgvFluxoCaixa.Location = new System.Drawing.Point(0, 157);
            this.dgvFluxoCaixa.Name = "dgvFluxoCaixa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFluxoCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFluxoCaixa.RowHeadersVisible = false;
            this.dgvFluxoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFluxoCaixa.Size = new System.Drawing.Size(668, 293);
            this.dgvFluxoCaixa.TabIndex = 8;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 27;
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.DataPropertyName = "DATA";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValor.DataPropertyName = "VALOR";
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 63;
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "TIPO";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 59;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.dgvFluxoCaixa);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.grpAddManual);
            this.Controls.Add(this.grpSaldo);
            this.Name = "frmFluxoCaixa";
            this.Text = "Fluxo de Caixa";
            this.grpSaldo.ResumeLayout(false);
            this.grpSaldo.PerformLayout();
            this.grpAddManual.ResumeLayout(false);
            this.grpAddManual.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.LabelJCS lblDinheiro;
        private Componentes.GroupBoxJCS grpSaldo;
        private Componentes.LabelJCS lblDigital;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ButtonJCS btnAddManual;
        private Componentes.TextBoxJCS txtValorManual;
        private Componentes.ComboBoxJCS cboTipo;
        private Componentes.GroupBoxJCS grpAddManual;
        private Componentes.GroupBoxJCS grpFiltros;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.dateTimePickerJCS dtpDataFinal;
        private Componentes.dateTimePickerJCS dtpDataInicial;
        private Componentes.ComboBoxJCS cboFiltroPagamento;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.DataGridViewJCS dgvFluxoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
    }
}