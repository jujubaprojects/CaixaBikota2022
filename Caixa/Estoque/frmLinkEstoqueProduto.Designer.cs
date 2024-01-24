namespace Caixa.Estoque
{
    partial class frmLinkEstoqueProduto
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtEstoqueIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtQtEstoque = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtQTEstIdeal = new Componentes.TextBoxJCS(this.components);
            this.chkAtivo = new Componentes.CheckBoxJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
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
            this.colID,
            this.colDescricao,
            this.colQtEst,
            this.colQtEstoqueIdeal,
            this.colAtivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLink.EnableHeadersVisualStyles = false;
            this.dgvLink.Location = new System.Drawing.Point(0, 119);
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
            this.dgvLink.Size = new System.Drawing.Size(695, 443);
            this.dgvLink.TabIndex = 47;
            this.dgvLink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLink_CellClick);
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
            // colQtEst
            // 
            this.colQtEst.DataPropertyName = "QT_ESTOQUE";
            this.colQtEst.HeaderText = "QT. Estoque";
            this.colQtEst.Name = "colQtEst";
            this.colQtEst.ReadOnly = true;
            this.colQtEst.Width = 105;
            // 
            // colQtEstoqueIdeal
            // 
            this.colQtEstoqueIdeal.DataPropertyName = "QT_ESTOQUE_IDEAL";
            this.colQtEstoqueIdeal.HeaderText = "QT. Ideal";
            this.colQtEstoqueIdeal.Name = "colQtEstoqueIdeal";
            this.colQtEstoqueIdeal.ReadOnly = true;
            this.colQtEstoqueIdeal.Width = 85;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "STATUS";
            this.colAtivo.FalseValue = "";
            this.colAtivo.HeaderText = "Status";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 52;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(27, 45);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(69, 17);
            this.labelJCS1.TabIndex = 45;
            this.labelJCS1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(184, 42);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = "";
            this.txtDescricao.Size = new System.Drawing.Size(499, 24);
            this.txtDescricao.TabIndex = 48;
            this.txtDescricao.TipoCampo = "STRING";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_editar_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // txtQtEstoque
            // 
            this.txtQtEstoque.BackColor = System.Drawing.Color.White;
            this.txtQtEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtEstoque.IconeKeyDown = null;
            this.txtQtEstoque.Location = new System.Drawing.Point(102, 72);
            this.txtQtEstoque.Name = "txtQtEstoque";
            this.txtQtEstoque.Preenchimento = null;
            this.txtQtEstoque.Size = new System.Drawing.Size(76, 24);
            this.txtQtEstoque.TabIndex = 54;
            this.txtQtEstoque.TipoCampo = "DOUBLE";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 74);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(84, 17);
            this.labelJCS2.TabIndex = 55;
            this.labelJCS2.Text = "QT. Estoque:";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(282, 75);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(116, 17);
            this.labelJCS3.TabIndex = 57;
            this.labelJCS3.Text = "QT. Estoque Ideal:";
            // 
            // txtQTEstIdeal
            // 
            this.txtQTEstIdeal.BackColor = System.Drawing.Color.White;
            this.txtQTEstIdeal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQTEstIdeal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQTEstIdeal.IconeKeyDown = null;
            this.txtQTEstIdeal.Location = new System.Drawing.Point(404, 72);
            this.txtQTEstIdeal.Name = "txtQTEstIdeal";
            this.txtQTEstIdeal.Preenchimento = null;
            this.txtQTEstIdeal.Size = new System.Drawing.Size(76, 24);
            this.txtQTEstIdeal.TabIndex = 56;
            this.txtQTEstIdeal.TipoCampo = "DOUBLE";
            // 
            // chkAtivo
            // 
            this.chkAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkAtivo.Location = new System.Drawing.Point(625, 72);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 21);
            this.chkAtivo.TabIndex = 58;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(102, 42);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = null;
            this.txtID.Size = new System.Drawing.Size(76, 24);
            this.txtID.TabIndex = 59;
            this.txtID.TipoCampo = "INTEIRO";
            // 
            // frmLinkEstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtQTEstIdeal);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtQtEstoque);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dgvLink);
            this.Controls.Add(this.labelJCS1);
            this.Name = "frmLinkEstoqueProduto";
            this.Text = "Controle de Estoque";
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.dgvLink, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtQtEstoque, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.txtQTEstIdeal, 0);
            this.Controls.SetChildIndex(this.labelJCS3, 0);
            this.Controls.SetChildIndex(this.chkAtivo, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvLink;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtDescricao;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Componentes.TextBoxJCS txtQtEstoque;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtQTEstIdeal;
        private Componentes.CheckBoxJCS chkAtivo;
        private Componentes.TextBoxJCS txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtEstoqueIdeal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}