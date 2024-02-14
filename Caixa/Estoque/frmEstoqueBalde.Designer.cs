namespace Caixa.Estoque
{
    partial class frmEstoqueBalde
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
            this.lblProduto = new Componentes.LabelJCS(this.components);
            this.cboProduto = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboSabor1 = new Componentes.ComboBoxJCS(this.components);
            this.cboSabor6 = new Componentes.ComboBoxJCS(this.components);
            this.cboSabor4 = new Componentes.ComboBoxJCS(this.components);
            this.cboSabor2 = new Componentes.ComboBoxJCS(this.components);
            this.cboSabor5 = new Componentes.ComboBoxJCS(this.components);
            this.cboSabor3 = new Componentes.ComboBoxJCS(this.components);
            this.dgvEstPotes = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtQT = new Componentes.TextBoxJCS(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.txtFiltroQT = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtFiltroSabor = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.cboFiltroProduto = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstPotes)).BeginInit();
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(12, 61);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(79, 58);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(300, 23);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.CboProduto_SelectedIndexChanged);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(26, 90);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(47, 17);
            this.labelJCS1.TabIndex = 3;
            this.labelJCS1.Text = "Sabor:";
            // 
            // cboSabor1
            // 
            this.cboSabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor1.FormattingEnabled = true;
            this.cboSabor1.Location = new System.Drawing.Point(79, 87);
            this.cboSabor1.Name = "cboSabor1";
            this.cboSabor1.Size = new System.Drawing.Size(147, 23);
            this.cboSabor1.TabIndex = 4;
            this.cboSabor1.SelectedIndexChanged += new System.EventHandler(this.CboSabor1_SelectedIndexChanged);
            // 
            // cboSabor6
            // 
            this.cboSabor6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor6.Enabled = false;
            this.cboSabor6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor6.FormattingEnabled = true;
            this.cboSabor6.Location = new System.Drawing.Point(385, 116);
            this.cboSabor6.Name = "cboSabor6";
            this.cboSabor6.Size = new System.Drawing.Size(147, 23);
            this.cboSabor6.TabIndex = 5;
            this.cboSabor6.SelectedIndexChanged += new System.EventHandler(this.CboSabor6_SelectedIndexChanged);
            this.cboSabor6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSabor6_KeyPress);
            // 
            // cboSabor4
            // 
            this.cboSabor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor4.Enabled = false;
            this.cboSabor4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor4.FormattingEnabled = true;
            this.cboSabor4.Location = new System.Drawing.Point(79, 116);
            this.cboSabor4.Name = "cboSabor4";
            this.cboSabor4.Size = new System.Drawing.Size(147, 23);
            this.cboSabor4.TabIndex = 6;
            this.cboSabor4.SelectedIndexChanged += new System.EventHandler(this.CboSabor4_SelectedIndexChanged);
            this.cboSabor4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSabor4_KeyPress);
            // 
            // cboSabor2
            // 
            this.cboSabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor2.Enabled = false;
            this.cboSabor2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor2.FormattingEnabled = true;
            this.cboSabor2.Location = new System.Drawing.Point(232, 87);
            this.cboSabor2.Name = "cboSabor2";
            this.cboSabor2.Size = new System.Drawing.Size(147, 23);
            this.cboSabor2.TabIndex = 7;
            this.cboSabor2.SelectedIndexChanged += new System.EventHandler(this.CboSabor2_SelectedIndexChanged);
            this.cboSabor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSabor2_KeyPress);
            // 
            // cboSabor5
            // 
            this.cboSabor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor5.Enabled = false;
            this.cboSabor5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor5.FormattingEnabled = true;
            this.cboSabor5.Location = new System.Drawing.Point(232, 116);
            this.cboSabor5.Name = "cboSabor5";
            this.cboSabor5.Size = new System.Drawing.Size(147, 23);
            this.cboSabor5.TabIndex = 8;
            this.cboSabor5.SelectedIndexChanged += new System.EventHandler(this.CboSabor5_SelectedIndexChanged);
            this.cboSabor5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSabor5_KeyPress);
            // 
            // cboSabor3
            // 
            this.cboSabor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor3.Enabled = false;
            this.cboSabor3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSabor3.FormattingEnabled = true;
            this.cboSabor3.Location = new System.Drawing.Point(385, 87);
            this.cboSabor3.Name = "cboSabor3";
            this.cboSabor3.Size = new System.Drawing.Size(147, 23);
            this.cboSabor3.TabIndex = 9;
            this.cboSabor3.SelectedIndexChanged += new System.EventHandler(this.CboSabor3_SelectedIndexChanged);
            this.cboSabor3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSabor3_KeyPress);
            // 
            // dgvEstPotes
            // 
            this.dgvEstPotes.AllowUserToAddRows = false;
            this.dgvEstPotes.AllowUserToDeleteRows = false;
            this.dgvEstPotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstPotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstPotes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstPotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstPotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstPotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProduto,
            this.colDescricao,
            this.colQt,
            this.colData});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstPotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstPotes.EnableHeadersVisualStyles = false;
            this.dgvEstPotes.Location = new System.Drawing.Point(0, 202);
            this.dgvEstPotes.Name = "dgvEstPotes";
            this.dgvEstPotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstPotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstPotes.RowHeadersVisible = false;
            this.dgvEstPotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstPotes.Size = new System.Drawing.Size(550, 306);
            this.dgvEstPotes.TabIndex = 10;
            this.dgvEstPotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstPotes_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 46;
            // 
            // colProduto
            // 
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
            this.colQt.DataPropertyName = "QT";
            this.colQt.HeaderText = "QT.";
            this.colQt.Name = "colQt";
            this.colQt.ReadOnly = true;
            this.colQt.Width = 53;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 61;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(385, 61);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(28, 17);
            this.labelJCS2.TabIndex = 11;
            this.labelJCS2.Text = "QT:";
            // 
            // txtQT
            // 
            this.txtQT.BackColor = System.Drawing.Color.White;
            this.txtQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQT.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQT.IconeKeyDown = null;
            this.txtQT.Location = new System.Drawing.Point(419, 58);
            this.txtQT.Name = "txtQT";
            this.txtQT.Preenchimento = null;
            this.txtQT.Size = new System.Drawing.Size(113, 24);
            this.txtQT.TabIndex = 1;
            this.txtQT.TipoCampo = "DOUBLE";
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.txtFiltroQT);
            this.groupBoxJCS1.Controls.Add(this.labelJCS5);
            this.groupBoxJCS1.Controls.Add(this.txtFiltroSabor);
            this.groupBoxJCS1.Controls.Add(this.labelJCS4);
            this.groupBoxJCS1.Controls.Add(this.cboFiltroProduto);
            this.groupBoxJCS1.Controls.Add(this.labelJCS3);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(1, 145);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(549, 51);
            this.groupBoxJCS1.TabIndex = 16;
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
            // frmEstoqueBalde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 508);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.dgvEstPotes);
            this.Controls.Add(this.cboSabor3);
            this.Controls.Add(this.cboSabor5);
            this.Controls.Add(this.cboSabor2);
            this.Controls.Add(this.cboSabor4);
            this.Controls.Add(this.cboSabor6);
            this.Controls.Add(this.cboSabor1);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.lblProduto);
            this.Name = "frmEstoqueBalde";
            this.Text = "Estoque de Potes de Sorvete";
            this.Controls.SetChildIndex(this.lblProduto, 0);
            this.Controls.SetChildIndex(this.cboProduto, 0);
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.cboSabor1, 0);
            this.Controls.SetChildIndex(this.cboSabor6, 0);
            this.Controls.SetChildIndex(this.cboSabor4, 0);
            this.Controls.SetChildIndex(this.cboSabor2, 0);
            this.Controls.SetChildIndex(this.cboSabor5, 0);
            this.Controls.SetChildIndex(this.cboSabor3, 0);
            this.Controls.SetChildIndex(this.dgvEstPotes, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.txtQT, 0);
            this.Controls.SetChildIndex(this.groupBoxJCS1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstPotes)).EndInit();
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS lblProduto;
        private Componentes.ComboBoxJCS cboProduto;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ComboBoxJCS cboSabor1;
        private Componentes.ComboBoxJCS cboSabor6;
        private Componentes.ComboBoxJCS cboSabor4;
        private Componentes.ComboBoxJCS cboSabor2;
        private Componentes.ComboBoxJCS cboSabor5;
        private Componentes.ComboBoxJCS cboSabor3;
        private Componentes.DataGridViewJCS dgvEstPotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtQT;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.TextBoxJCS txtFiltroSabor;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.ComboBoxJCS cboFiltroProduto;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtFiltroQT;
        private Componentes.LabelJCS labelJCS5;
    }
}