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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLink = new Componentes.DataGridViewJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.txtFiltroQT = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtFiltroSabor = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.cboFiltroProduto = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.colIDEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorico = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHistorico = new Componentes.ButtonJCS(this.components);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEstoque,
            this.colProduto,
            this.colDescricao,
            this.colQt,
            this.colData,
            this.colHistorico});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 57);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLink.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLink.RowHeadersVisible = false;
            this.dgvLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLink.Size = new System.Drawing.Size(800, 393);
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
            this.groupBoxJCS1.Controls.Add(this.btnHistorico);
            this.groupBoxJCS1.Controls.Add(this.txtFiltroQT);
            this.groupBoxJCS1.Controls.Add(this.labelJCS5);
            this.groupBoxJCS1.Controls.Add(this.txtFiltroSabor);
            this.groupBoxJCS1.Controls.Add(this.labelJCS4);
            this.groupBoxJCS1.Controls.Add(this.cboFiltroProduto);
            this.groupBoxJCS1.Controls.Add(this.labelJCS3);
            this.groupBoxJCS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(800, 51);
            this.groupBoxJCS1.TabIndex = 65;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtros";
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
            // txtFiltroSabor
            // 
            this.txtFiltroSabor.BackColor = System.Drawing.Color.White;
            this.txtFiltroSabor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroSabor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtFiltroSabor.IconeKeyDown = null;
            this.txtFiltroSabor.Location = new System.Drawing.Point(227, 17);
            this.txtFiltroSabor.Name = "txtFiltroSabor";
            this.txtFiltroSabor.Preenchimento = null;
            this.txtFiltroSabor.Size = new System.Drawing.Size(151, 24);
            this.txtFiltroSabor.TabIndex = 19;
            this.txtFiltroSabor.TipoCampo = null;
            this.txtFiltroSabor.TextChanged += new System.EventHandler(this.TxtFiltroSabor_TextChanged);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(174, 20);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(47, 17);
            this.labelJCS4.TabIndex = 18;
            this.labelJCS4.Text = "Sabor:";
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
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(11, 20);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(61, 17);
            this.labelJCS3.TabIndex = 17;
            this.labelJCS3.Text = "Produto:";
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
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.Width = 82;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
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
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Gold;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorico.Image = global::Caixa.Properties.Resources.icons8_termos_e_condições_24;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(617, 17);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(171, 24);
            this.btnHistorico.TabIndex = 22;
            this.btnHistorico.Text = "Histórico Completo";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // frmConsultaEstoquePotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.dgvLink);
            this.Name = "frmConsultaEstoquePotes";
            this.Text = "Consulta de Potes";
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
        private Componentes.TextBoxJCS txtFiltroSabor;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.ComboBoxJCS cboFiltroProduto;
        private Componentes.LabelJCS labelJCS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorico;
        private Componentes.ButtonJCS btnHistorico;
    }
}