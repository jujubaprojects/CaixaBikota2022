namespace Caixa.Cadastro
{
    partial class frmCadastroFornecedor
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
            this.dgvFornecedores = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new Componentes.TextBoxJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtCNPJ = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtIE = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtFone = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtNomeFantasia = new Componentes.TextBoxJCS(this.components);
            this.txtCEP = new Componentes.TextBoxJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.cboCidade = new Componentes.ComboBoxJCS(this.components);
            this.cboEstado = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS7 = new Componentes.LabelJCS(this.components);
            this.labelJCS8 = new Componentes.LabelJCS(this.components);
            this.txtEnd = new Componentes.TextBoxJCS(this.components);
            this.labelJCS9 = new Componentes.LabelJCS(this.components);
            this.txtNumero = new Componentes.TextBoxJCS(this.components);
            this.labelJCS10 = new Componentes.LabelJCS(this.components);
            this.txtBairro = new Componentes.TextBoxJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCPFCNPJ,
            this.colNome,
            this.colIE,
            this.colFone,
            this.colNomeFantasia,
            this.colCEP,
            this.colEnd,
            this.colCidade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 220);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(800, 230);
            this.dgvFornecedores.TabIndex = 15;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedores_CellClick);
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
            // colCPFCNPJ
            // 
            this.colCPFCNPJ.DataPropertyName = "CPF_CNPJ";
            this.colCPFCNPJ.HeaderText = "CNPJ/CPF";
            this.colCPFCNPJ.Name = "colCPFCNPJ";
            this.colCPFCNPJ.ReadOnly = true;
            this.colCPFCNPJ.Width = 86;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "NOME";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colIE
            // 
            this.colIE.DataPropertyName = "IE";
            this.colIE.HeaderText = "IE";
            this.colIE.Name = "colIE";
            this.colIE.ReadOnly = true;
            this.colIE.Width = 44;
            // 
            // colFone
            // 
            this.colFone.DataPropertyName = "FONE";
            this.colFone.HeaderText = "Fone";
            this.colFone.Name = "colFone";
            this.colFone.ReadOnly = true;
            this.colFone.Width = 62;
            // 
            // colNomeFantasia
            // 
            this.colNomeFantasia.DataPropertyName = "NOME_FANTASIA";
            this.colNomeFantasia.HeaderText = "Nome Fantasia";
            this.colNomeFantasia.Name = "colNomeFantasia";
            this.colNomeFantasia.ReadOnly = true;
            this.colNomeFantasia.Visible = false;
            this.colNomeFantasia.Width = 120;
            // 
            // colCEP
            // 
            this.colCEP.DataPropertyName = "CEP";
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.ReadOnly = true;
            this.colCEP.Visible = false;
            this.colCEP.Width = 54;
            // 
            // colEnd
            // 
            this.colEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEnd.DataPropertyName = "END_RUA";
            this.colEnd.HeaderText = "Endereço";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "END_CIDADE_UF";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 73;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.Yellow;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNome.IconeKeyDown = null;
            this.txtNome.Location = new System.Drawing.Point(206, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Preenchimento = "Required";
            this.txtNome.Size = new System.Drawing.Size(582, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.TipoCampo = "STRING";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(100, 46);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = "";
            this.txtID.Size = new System.Drawing.Size(100, 24);
            this.txtID.TabIndex = 18;
            this.txtID.TipoCampo = "INTEIRO";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(14, 49);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(80, 17);
            this.labelJCS1.TabIndex = 17;
            this.labelJCS1.Text = "Fornecedor:";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(29, 109);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(65, 17);
            this.labelJCS2.TabIndex = 20;
            this.labelJCS2.Text = "CNPJ/CPF:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.White;
            this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCNPJ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCNPJ.IconeKeyDown = null;
            this.txtCNPJ.Location = new System.Drawing.Point(100, 106);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Preenchimento = "";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 24);
            this.txtCNPJ.TabIndex = 3;
            this.txtCNPJ.TipoCampo = "INTEIRO";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(224, 110);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(23, 17);
            this.labelJCS3.TabIndex = 22;
            this.labelJCS3.Text = "IE:";
            // 
            // txtIE
            // 
            this.txtIE.BackColor = System.Drawing.Color.White;
            this.txtIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIE.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIE.IconeKeyDown = null;
            this.txtIE.Location = new System.Drawing.Point(253, 106);
            this.txtIE.Name = "txtIE";
            this.txtIE.Preenchimento = "";
            this.txtIE.Size = new System.Drawing.Size(100, 24);
            this.txtIE.TabIndex = 4;
            this.txtIE.TipoCampo = "STRING";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(474, 110);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(41, 17);
            this.labelJCS4.TabIndex = 24;
            this.labelJCS4.Text = "Fone:";
            // 
            // txtFone
            // 
            this.txtFone.BackColor = System.Drawing.Color.White;
            this.txtFone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtFone.IconeKeyDown = null;
            this.txtFone.Location = new System.Drawing.Point(521, 106);
            this.txtFone.Name = "txtFone";
            this.txtFone.Preenchimento = "";
            this.txtFone.Size = new System.Drawing.Size(100, 24);
            this.txtFone.TabIndex = 5;
            this.txtFone.TipoCampo = "INTEIRO";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(33, 79);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(61, 17);
            this.labelJCS5.TabIndex = 26;
            this.labelJCS5.Text = "Fantasia:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFantasia.BackColor = System.Drawing.Color.White;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNomeFantasia.IconeKeyDown = null;
            this.txtNomeFantasia.Location = new System.Drawing.Point(100, 76);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Preenchimento = "";
            this.txtNomeFantasia.Size = new System.Drawing.Size(688, 24);
            this.txtNomeFantasia.TabIndex = 2;
            this.txtNomeFantasia.TipoCampo = "STRING";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.White;
            this.txtCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCEP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCEP.IconeKeyDown = null;
            this.txtCEP.Location = new System.Drawing.Point(688, 106);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Preenchimento = "";
            this.txtCEP.Size = new System.Drawing.Size(100, 24);
            this.txtCEP.TabIndex = 6;
            this.txtCEP.TipoCampo = "INTEIRO";
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(649, 109);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(33, 17);
            this.labelJCS6.TabIndex = 28;
            this.labelJCS6.Text = "CEP:";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(98, 136);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(195, 36);
            this.cboCidade.TabIndex = 7;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEstado.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(299, 136);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(54, 23);
            this.cboEstado.TabIndex = 8;
            // 
            // labelJCS7
            // 
            this.labelJCS7.AutoSize = true;
            this.labelJCS7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS7.Location = new System.Drawing.Point(19, 139);
            this.labelJCS7.Name = "labelJCS7";
            this.labelJCS7.Size = new System.Drawing.Size(73, 17);
            this.labelJCS7.TabIndex = 32;
            this.labelJCS7.Text = "Cidade/UF:";
            // 
            // labelJCS8
            // 
            this.labelJCS8.AutoSize = true;
            this.labelJCS8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS8.Location = new System.Drawing.Point(12, 173);
            this.labelJCS8.Name = "labelJCS8";
            this.labelJCS8.Size = new System.Drawing.Size(82, 17);
            this.labelJCS8.TabIndex = 33;
            this.labelJCS8.Text = "Logradouro:";
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.White;
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEnd.IconeKeyDown = null;
            this.txtEnd.Location = new System.Drawing.Point(100, 170);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Preenchimento = "";
            this.txtEnd.Size = new System.Drawing.Size(361, 24);
            this.txtEnd.TabIndex = 9;
            this.txtEnd.TipoCampo = "STRING";
            // 
            // labelJCS9
            // 
            this.labelJCS9.AutoSize = true;
            this.labelJCS9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS9.Location = new System.Drawing.Point(467, 173);
            this.labelJCS9.Name = "labelJCS9";
            this.labelJCS9.Size = new System.Drawing.Size(27, 17);
            this.labelJCS9.TabIndex = 35;
            this.labelJCS9.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumero.IconeKeyDown = null;
            this.txtNumero.Location = new System.Drawing.Point(500, 170);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Preenchimento = "";
            this.txtNumero.Size = new System.Drawing.Size(70, 24);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.TipoCampo = "STRING";
            // 
            // labelJCS10
            // 
            this.labelJCS10.AutoSize = true;
            this.labelJCS10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS10.Location = new System.Drawing.Point(575, 173);
            this.labelJCS10.Name = "labelJCS10";
            this.labelJCS10.Size = new System.Drawing.Size(48, 17);
            this.labelJCS10.TabIndex = 37;
            this.labelJCS10.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtBairro.IconeKeyDown = null;
            this.txtBairro.Location = new System.Drawing.Point(629, 170);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Preenchimento = "";
            this.txtBairro.Size = new System.Drawing.Size(159, 24);
            this.txtBairro.TabIndex = 11;
            this.txtBairro.TipoCampo = "STRING";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.labelJCS10);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelJCS9);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.labelJCS8);
            this.Controls.Add(this.labelJCS7);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.labelJCS6);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.dgvFornecedores);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro Fornecedor";
            this.Controls.SetChildIndex(this.dgvFornecedores, 0);
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.txtCNPJ, 0);
            this.Controls.SetChildIndex(this.labelJCS3, 0);
            this.Controls.SetChildIndex(this.txtIE, 0);
            this.Controls.SetChildIndex(this.labelJCS4, 0);
            this.Controls.SetChildIndex(this.txtFone, 0);
            this.Controls.SetChildIndex(this.labelJCS5, 0);
            this.Controls.SetChildIndex(this.txtNomeFantasia, 0);
            this.Controls.SetChildIndex(this.labelJCS6, 0);
            this.Controls.SetChildIndex(this.txtCEP, 0);
            this.Controls.SetChildIndex(this.cboCidade, 0);
            this.Controls.SetChildIndex(this.cboEstado, 0);
            this.Controls.SetChildIndex(this.labelJCS7, 0);
            this.Controls.SetChildIndex(this.labelJCS8, 0);
            this.Controls.SetChildIndex(this.txtEnd, 0);
            this.Controls.SetChildIndex(this.labelJCS9, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.labelJCS10, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvFornecedores;
        private Componentes.TextBoxJCS txtNome;
        private Componentes.TextBoxJCS txtID;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtCNPJ;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtIE;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtFone;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtNomeFantasia;
        private Componentes.TextBoxJCS txtCEP;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.ComboBoxJCS cboCidade;
        private Componentes.ComboBoxJCS cboEstado;
        private Componentes.LabelJCS labelJCS7;
        private Componentes.LabelJCS labelJCS8;
        private Componentes.TextBoxJCS txtEnd;
        private Componentes.LabelJCS labelJCS9;
        private Componentes.TextBoxJCS txtNumero;
        private Componentes.LabelJCS labelJCS10;
        private Componentes.TextBoxJCS txtBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
    }
}