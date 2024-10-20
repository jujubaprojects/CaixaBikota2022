namespace Caixa.Estoque
{
    partial class frmConsultaEstoquePotes
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
            this.dgvLink = new Componentes.DataGridViewJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.btnHistorico = new Componentes.ButtonJCS(this.components);
            this.txtFiltroQT = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.lblDescricao = new Componentes.LabelJCS(this.components);
            this.cboFiltroProduto = new Componentes.ComboBoxJCS(this.components);
            this.lblProduto = new Componentes.LabelJCS(this.components);
            this.rbtEstoquePote = new Componentes.RadioButtonJCScs(this.components);
            this.rbtEstMatPrima = new Componentes.RadioButtonJCScs(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.colIDEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorico = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLink
            // 
            this.dgvLink.AllowUserToAddRows = false;
            this.dgvLink.AllowUserToDeleteRows = false;
            this.dgvLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLink.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEstoque,
            this.colProduto,
            this.colDescricao,
            this.colQt,
            this.colData,
            this.colHistorico});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 96);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLink.RowHeadersVisible = false;
            this.dgvLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLink.Size = new System.Drawing.Size(800, 354);
            this.dgvLink.TabIndex = 64;
            this.dgvLink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLink_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 52;
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.labelJCS1);
            this.groupBoxJCS1.Controls.Add(this.rbtEstMatPrima);
            this.groupBoxJCS1.Controls.Add(this.rbtEstoquePote);
            this.groupBoxJCS1.Controls.Add(this.btnHistorico);
            this.groupBoxJCS1.Controls.Add(this.txtFiltroQT);
            this.groupBoxJCS1.Controls.Add(this.labelJCS5);
            this.groupBoxJCS1.Controls.Add(this.txtDescricao);
            this.groupBoxJCS1.Controls.Add(this.lblDescricao);
            this.groupBoxJCS1.Controls.Add(this.cboFiltroProduto);
            this.groupBoxJCS1.Controls.Add(this.lblProduto);
            this.groupBoxJCS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(800, 90);
            this.groupBoxJCS1.TabIndex = 65;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtros";
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Gold;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorico.Image = global::Caixa.Properties.Resources.icons8_termos_e_condições_24;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(617, 17);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(171, 54);
            this.btnHistorico.TabIndex = 22;
            this.btnHistorico.Text = "Histórico Completo";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // txtFiltroQT
            // 
            this.txtFiltroQT.BackColor = System.Drawing.Color.White;
            this.txtFiltroQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroQT.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtFiltroQT.IconeKeyDown = null;
            this.txtFiltroQT.Location = new System.Drawing.Point(418, 17);
            this.txtFiltroQT.Name = "txtFiltroQT";
            this.txtFiltroQT.Preenchimento = null;
            this.txtFiltroQT.Size = new System.Drawing.Size(113, 24);
            this.txtFiltroQT.TabIndex = 20;
            this.txtFiltroQT.TipoCampo = "DOUBLE";
            this.txtFiltroQT.TextChanged += new System.EventHandler(this.TxtFiltroQT_TextChanged);
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(384, 20);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(28, 17);
            this.labelJCS5.TabIndex = 21;
            this.labelJCS5.Text = "QT:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(227, 17);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(151, 24);
            this.txtDescricao.TabIndex = 19;
            this.txtDescricao.TipoCampo = null;
            this.txtDescricao.TextChanged += new System.EventHandler(this.TxtFiltroSabor_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(177, 20);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(44, 17);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Desc.:";
            // 
            // cboFiltroProduto
            // 
            this.cboFiltroProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFiltroProduto.FormattingEnabled = true;
            this.cboFiltroProduto.Location = new System.Drawing.Point(78, 17);
            this.cboFiltroProduto.Name = "cboFiltroProduto";
            this.cboFiltroProduto.Size = new System.Drawing.Size(90, 23);
            this.cboFiltroProduto.TabIndex = 16;
            this.cboFiltroProduto.SelectedIndexChanged += new System.EventHandler(this.CboFiltroProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(11, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 17;
            this.lblProduto.Text = "Produto:";
            // 
            // rbtEstoquePote
            // 
            this.rbtEstoquePote.AutoSize = true;
            this.rbtEstoquePote.BackColor = System.Drawing.Color.White;
            this.rbtEstoquePote.Checked = true;
            this.rbtEstoquePote.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtEstoquePote.Location = new System.Drawing.Point(78, 51);
            this.rbtEstoquePote.Name = "rbtEstoquePote";
            this.rbtEstoquePote.Size = new System.Drawing.Size(105, 21);
            this.rbtEstoquePote.TabIndex = 23;
            this.rbtEstoquePote.TabStop = true;
            this.rbtEstoquePote.Text = "Estoque Pote";
            this.rbtEstoquePote.UseVisualStyleBackColor = false;
            this.rbtEstoquePote.CheckedChanged += new System.EventHandler(this.RbtEstoquePote_CheckedChanged);
            // 
            // rbtEstMatPrima
            // 
            this.rbtEstMatPrima.AutoSize = true;
            this.rbtEstMatPrima.BackColor = System.Drawing.Color.White;
            this.rbtEstMatPrima.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtEstMatPrima.Location = new System.Drawing.Point(371, 51);
            this.rbtEstMatPrima.Name = "rbtEstMatPrima";
            this.rbtEstMatPrima.Size = new System.Drawing.Size(160, 21);
            this.rbtEstMatPrima.TabIndex = 24;
            this.rbtEstMatPrima.Text = "Estoque Matéria Prima";
            this.rbtEstMatPrima.UseVisualStyleBackColor = false;
            this.rbtEstMatPrima.CheckedChanged += new System.EventHandler(this.RbtEstMatPrima_CheckedChanged);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(34, 54);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(38, 17);
            this.labelJCS1.TabIndex = 25;
            this.labelJCS1.Text = "Tipo:";
            // 
            // colIDEstoque
            // 
            this.colIDEstoque.DataPropertyName = "ID_ESTOQUE";
            this.colIDEstoque.HeaderText = "ID Estoque";
            this.colIDEstoque.Name = "colIDEstoque";
            this.colIDEstoque.ReadOnly = true;
            this.colIDEstoque.Visible = false;
            this.colIDEstoque.Width = 79;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 90;
            // 
            // colQt
            // 
            this.colQt.DataPropertyName = "QT_RESTANTE";
            this.colQt.HeaderText = "QT. Rest.";
            this.colQt.Name = "colQt";
            this.colQt.ReadOnly = true;
            this.colQt.Width = 86;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 61;
            // 
            // colHistorico
            // 
            this.colHistorico.DataPropertyName = "HISTORICO";
            this.colHistorico.HeaderText = "Historico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.ReadOnly = true;
            this.colHistorico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHistorico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colHistorico.Text = "";
            this.colHistorico.Width = 86;
            // 
            // frmConsultaEstoquePotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.dgvLink);
            this.Name = "frmConsultaEstoquePotes";
            this.Text = "Consulta de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).EndInit();
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.DataGridViewJCS dgvLink;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.TextBoxJCS txtFiltroQT;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS lblDescricao;
        private Componentes.ComboBoxJCS cboFiltroProduto;
        private Componentes.LabelJCS lblProduto;
        private Componentes.ButtonJCS btnHistorico;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.RadioButtonJCScs rbtEstMatPrima;
        private Componentes.RadioButtonJCScs rbtEstoquePote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorico;
    }
}