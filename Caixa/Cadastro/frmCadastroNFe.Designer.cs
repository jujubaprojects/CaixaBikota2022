namespace Caixa.Cadastro
{
    partial class frmCadastroNFe
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
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtValorNFe = new Componentes.TextBoxJCS(this.components);
            this.txtChave1 = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.labelJCS7 = new Componentes.LabelJCS(this.components);
            this.dtpEmissao = new Componentes.dateTimePickerJCS(this.components);
            this.dtpEntrega = new Componentes.dateTimePickerJCS(this.components);
            this.txtFornecedor = new Componentes.TextBoxJCS(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.rbtCupomNFiscal = new Componentes.RadioButtonJCScs(this.components);
            this.rbtCupomFiscal = new Componentes.RadioButtonJCScs(this.components);
            this.txtChave4 = new Componentes.TextBoxJCS(this.components);
            this.txtChave3 = new Componentes.TextBoxJCS(this.components);
            this.txtChave6 = new Componentes.TextBoxJCS(this.components);
            this.txtChave5 = new Componentes.TextBoxJCS(this.components);
            this.txtChave8 = new Componentes.TextBoxJCS(this.components);
            this.txtChave7 = new Componentes.TextBoxJCS(this.components);
            this.txtChave10 = new Componentes.TextBoxJCS(this.components);
            this.txtChave9 = new Componentes.TextBoxJCS(this.components);
            this.txtChave11 = new Componentes.TextBoxJCS(this.components);
            this.txtChave2 = new Componentes.TextBoxJCS(this.components);
            this.btnBuscarFornecedor = new Componentes.ButtonJCS(this.components);
            this.groupBoxJCS2 = new Componentes.GroupBoxJCS(this.components);
            this.btnSalvar = new Componentes.ButtonJCS(this.components);
            this.groupBoxJCS3 = new Componentes.GroupBoxJCS(this.components);
            this.btnAddProdSemCod = new Componentes.ButtonJCS(this.components);
            this.chkProdSemCod = new Componentes.CheckBoxJCS(this.components);
            this.btnAddProduto = new Componentes.ButtonJCS(this.components);
            this.dgvProdutos = new Componentes.DataGridViewJCS(this.components);
            this.colNFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtUnidComercial = new Componentes.TextBoxJCS(this.components);
            this.labelJCS10 = new Componentes.LabelJCS(this.components);
            this.txtVlUnit = new Componentes.TextBoxJCS(this.components);
            this.labelJCS9 = new Componentes.LabelJCS(this.components);
            this.txtQtCom = new Componentes.TextBoxJCS(this.components);
            this.labelJCS8 = new Componentes.LabelJCS(this.components);
            this.txtDescProduto = new Componentes.TextBoxJCS(this.components);
            this.txtCodProduto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtIDFornecedor = new Componentes.TextBoxJCS(this.components);
            this.txtNumeroNFe = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.btnBuscarProd = new Componentes.ButtonJCS(this.components);
            this.groupBoxJCS1.SuspendLayout();
            this.groupBoxJCS2.SuspendLayout();
            this.groupBoxJCS3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(9, 82);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(110, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Chave de Acesso:";
            // 
            // txtValorNFe
            // 
            this.txtValorNFe.BackColor = System.Drawing.Color.White;
            this.txtValorNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorNFe.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtValorNFe.IconeKeyDown = null;
            this.txtValorNFe.Location = new System.Drawing.Point(594, 169);
            this.txtValorNFe.Name = "txtValorNFe";
            this.txtValorNFe.Preenchimento = null;
            this.txtValorNFe.Size = new System.Drawing.Size(86, 24);
            this.txtValorNFe.TabIndex = 17;
            this.txtValorNFe.TipoCampo = "MONETARIO";
            // 
            // txtChave1
            // 
            this.txtChave1.BackColor = System.Drawing.Color.White;
            this.txtChave1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave1.IconeKeyDown = null;
            this.txtChave1.Location = new System.Drawing.Point(125, 79);
            this.txtChave1.MaxLength = 4;
            this.txtChave1.Name = "txtChave1";
            this.txtChave1.Preenchimento = null;
            this.txtChave1.Size = new System.Drawing.Size(45, 24);
            this.txtChave1.TabIndex = 1;
            this.txtChave1.TipoCampo = "INTEIRO";
            this.txtChave1.TextChanged += new System.EventHandler(this.TxtChave1_TextChanged);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(28, 176);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(91, 17);
            this.labelJCS4.TabIndex = 5;
            this.labelJCS4.Text = "Data Emissao:";
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(514, 172);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(74, 17);
            this.labelJCS5.TabIndex = 6;
            this.labelJCS5.Text = "Valor Total:";
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(39, 112);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(80, 17);
            this.labelJCS6.TabIndex = 7;
            this.labelJCS6.Text = "Fornecedor:";
            // 
            // labelJCS7
            // 
            this.labelJCS7.AutoSize = true;
            this.labelJCS7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS7.Location = new System.Drawing.Point(227, 172);
            this.labelJCS7.Name = "labelJCS7";
            this.labelJCS7.Size = new System.Drawing.Size(89, 17);
            this.labelJCS7.TabIndex = 8;
            this.labelJCS7.Text = "Data Entrega:";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.CustomFormat = "dd/MM/yyyy";
            this.dtpEmissao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmissao.Location = new System.Drawing.Point(125, 169);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(96, 24);
            this.dtpEmissao.TabIndex = 15;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpEntrega.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrega.Location = new System.Drawing.Point(322, 169);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(96, 24);
            this.dtpEntrega.TabIndex = 16;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.White;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtFornecedor.IconeKeyDown = null;
            this.txtFornecedor.Location = new System.Drawing.Point(176, 109);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Preenchimento = null;
            this.txtFornecedor.Size = new System.Drawing.Size(402, 24);
            this.txtFornecedor.TabIndex = 333;
            this.txtFornecedor.TipoCampo = null;
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.rbtCupomNFiscal);
            this.groupBoxJCS1.Controls.Add(this.rbtCupomFiscal);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(307, 61);
            this.groupBoxJCS1.TabIndex = 0;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Tipo de NFe ";
            // 
            // rbtCupomNFiscal
            // 
            this.rbtCupomNFiscal.AutoSize = true;
            this.rbtCupomNFiscal.BackColor = System.Drawing.Color.White;
            this.rbtCupomNFiscal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtCupomNFiscal.Location = new System.Drawing.Point(174, 23);
            this.rbtCupomNFiscal.Name = "rbtCupomNFiscal";
            this.rbtCupomNFiscal.Size = new System.Drawing.Size(127, 21);
            this.rbtCupomNFiscal.TabIndex = 1;
            this.rbtCupomNFiscal.Text = "Cupom não fiscal";
            this.rbtCupomNFiscal.UseVisualStyleBackColor = false;
            this.rbtCupomNFiscal.CheckedChanged += new System.EventHandler(this.RbtCupomNFiscal_CheckedChanged);
            // 
            // rbtCupomFiscal
            // 
            this.rbtCupomFiscal.AutoSize = true;
            this.rbtCupomFiscal.BackColor = System.Drawing.Color.White;
            this.rbtCupomFiscal.Checked = true;
            this.rbtCupomFiscal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtCupomFiscal.Location = new System.Drawing.Point(6, 23);
            this.rbtCupomFiscal.Name = "rbtCupomFiscal";
            this.rbtCupomFiscal.Size = new System.Drawing.Size(143, 21);
            this.rbtCupomFiscal.TabIndex = 0;
            this.rbtCupomFiscal.TabStop = true;
            this.rbtCupomFiscal.Text = "NFe eletronica fiscal";
            this.rbtCupomFiscal.UseVisualStyleBackColor = false;
            this.rbtCupomFiscal.CheckedChanged += new System.EventHandler(this.RbtCupomFiscal_CheckedChanged);
            // 
            // txtChave4
            // 
            this.txtChave4.BackColor = System.Drawing.Color.White;
            this.txtChave4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave4.IconeKeyDown = null;
            this.txtChave4.Location = new System.Drawing.Point(278, 79);
            this.txtChave4.MaxLength = 4;
            this.txtChave4.Name = "txtChave4";
            this.txtChave4.Preenchimento = null;
            this.txtChave4.Size = new System.Drawing.Size(45, 24);
            this.txtChave4.TabIndex = 4;
            this.txtChave4.TipoCampo = "INTEIRO";
            this.txtChave4.TextChanged += new System.EventHandler(this.TxtChave4_TextChanged);
            // 
            // txtChave3
            // 
            this.txtChave3.BackColor = System.Drawing.Color.White;
            this.txtChave3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave3.IconeKeyDown = null;
            this.txtChave3.Location = new System.Drawing.Point(227, 79);
            this.txtChave3.MaxLength = 4;
            this.txtChave3.Name = "txtChave3";
            this.txtChave3.Preenchimento = null;
            this.txtChave3.Size = new System.Drawing.Size(45, 24);
            this.txtChave3.TabIndex = 3;
            this.txtChave3.TipoCampo = "INTEIRO";
            this.txtChave3.TextChanged += new System.EventHandler(this.TxtChave3_TextChanged);
            // 
            // txtChave6
            // 
            this.txtChave6.BackColor = System.Drawing.Color.White;
            this.txtChave6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave6.IconeKeyDown = null;
            this.txtChave6.Location = new System.Drawing.Point(380, 79);
            this.txtChave6.MaxLength = 4;
            this.txtChave6.Name = "txtChave6";
            this.txtChave6.Preenchimento = null;
            this.txtChave6.Size = new System.Drawing.Size(45, 24);
            this.txtChave6.TabIndex = 6;
            this.txtChave6.TipoCampo = "INTEIRO";
            this.txtChave6.TextChanged += new System.EventHandler(this.TxtChave6_TextChanged);
            // 
            // txtChave5
            // 
            this.txtChave5.BackColor = System.Drawing.Color.White;
            this.txtChave5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave5.IconeKeyDown = null;
            this.txtChave5.Location = new System.Drawing.Point(329, 79);
            this.txtChave5.MaxLength = 4;
            this.txtChave5.Name = "txtChave5";
            this.txtChave5.Preenchimento = null;
            this.txtChave5.Size = new System.Drawing.Size(45, 24);
            this.txtChave5.TabIndex = 5;
            this.txtChave5.TipoCampo = "INTEIRO";
            this.txtChave5.TextChanged += new System.EventHandler(this.TxtChave5_TextChanged);
            // 
            // txtChave8
            // 
            this.txtChave8.BackColor = System.Drawing.Color.White;
            this.txtChave8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave8.IconeKeyDown = null;
            this.txtChave8.Location = new System.Drawing.Point(482, 79);
            this.txtChave8.MaxLength = 4;
            this.txtChave8.Name = "txtChave8";
            this.txtChave8.Preenchimento = null;
            this.txtChave8.Size = new System.Drawing.Size(45, 24);
            this.txtChave8.TabIndex = 8;
            this.txtChave8.TipoCampo = "INTEIRO";
            this.txtChave8.TextChanged += new System.EventHandler(this.TxtChave8_TextChanged);
            // 
            // txtChave7
            // 
            this.txtChave7.BackColor = System.Drawing.Color.White;
            this.txtChave7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave7.IconeKeyDown = null;
            this.txtChave7.Location = new System.Drawing.Point(431, 79);
            this.txtChave7.MaxLength = 4;
            this.txtChave7.Name = "txtChave7";
            this.txtChave7.Preenchimento = null;
            this.txtChave7.Size = new System.Drawing.Size(45, 24);
            this.txtChave7.TabIndex = 7;
            this.txtChave7.TipoCampo = "INTEIRO";
            this.txtChave7.TextChanged += new System.EventHandler(this.TxtChave7_TextChanged);
            // 
            // txtChave10
            // 
            this.txtChave10.BackColor = System.Drawing.Color.White;
            this.txtChave10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave10.IconeKeyDown = null;
            this.txtChave10.Location = new System.Drawing.Point(584, 79);
            this.txtChave10.MaxLength = 4;
            this.txtChave10.Name = "txtChave10";
            this.txtChave10.Preenchimento = null;
            this.txtChave10.Size = new System.Drawing.Size(45, 24);
            this.txtChave10.TabIndex = 10;
            this.txtChave10.TipoCampo = "INTEIRO";
            this.txtChave10.TextChanged += new System.EventHandler(this.TxtChave10_TextChanged);
            // 
            // txtChave9
            // 
            this.txtChave9.BackColor = System.Drawing.Color.White;
            this.txtChave9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave9.IconeKeyDown = null;
            this.txtChave9.Location = new System.Drawing.Point(533, 79);
            this.txtChave9.MaxLength = 4;
            this.txtChave9.Name = "txtChave9";
            this.txtChave9.Preenchimento = null;
            this.txtChave9.Size = new System.Drawing.Size(45, 24);
            this.txtChave9.TabIndex = 9;
            this.txtChave9.TipoCampo = "INTEIRO";
            this.txtChave9.TextChanged += new System.EventHandler(this.TxtChave9_TextChanged);
            // 
            // txtChave11
            // 
            this.txtChave11.BackColor = System.Drawing.Color.White;
            this.txtChave11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave11.IconeKeyDown = null;
            this.txtChave11.Location = new System.Drawing.Point(635, 79);
            this.txtChave11.MaxLength = 4;
            this.txtChave11.Name = "txtChave11";
            this.txtChave11.Preenchimento = null;
            this.txtChave11.Size = new System.Drawing.Size(45, 24);
            this.txtChave11.TabIndex = 11;
            this.txtChave11.TipoCampo = "INTEIRO";
            // 
            // txtChave2
            // 
            this.txtChave2.BackColor = System.Drawing.Color.White;
            this.txtChave2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChave2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtChave2.IconeKeyDown = null;
            this.txtChave2.Location = new System.Drawing.Point(176, 79);
            this.txtChave2.MaxLength = 4;
            this.txtChave2.Name = "txtChave2";
            this.txtChave2.Preenchimento = null;
            this.txtChave2.Size = new System.Drawing.Size(45, 24);
            this.txtChave2.TabIndex = 2;
            this.txtChave2.TipoCampo = "INTEIRO";
            this.txtChave2.TextChanged += new System.EventHandler(this.TxtChave2_TextChanged);
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(584, 109);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(96, 24);
            this.btnBuscarFornecedor.TabIndex = 13;
            this.btnBuscarFornecedor.Text = "Buscar For.";
            this.btnBuscarFornecedor.UseVisualStyleBackColor = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.BtnBuscarFornecedor_Click);
            // 
            // groupBoxJCS2
            // 
            this.groupBoxJCS2.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS2.Controls.Add(this.btnSalvar);
            this.groupBoxJCS2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS2.Location = new System.Drawing.Point(0, 641);
            this.groupBoxJCS2.Name = "groupBoxJCS2";
            this.groupBoxJCS2.Size = new System.Drawing.Size(687, 64);
            this.groupBoxJCS2.TabIndex = 19;
            this.groupBoxJCS2.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(3, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(681, 41);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBoxJCS3
            // 
            this.groupBoxJCS3.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS3.Controls.Add(this.btnBuscarProd);
            this.groupBoxJCS3.Controls.Add(this.btnAddProdSemCod);
            this.groupBoxJCS3.Controls.Add(this.chkProdSemCod);
            this.groupBoxJCS3.Controls.Add(this.btnAddProduto);
            this.groupBoxJCS3.Controls.Add(this.dgvProdutos);
            this.groupBoxJCS3.Controls.Add(this.txtUnidComercial);
            this.groupBoxJCS3.Controls.Add(this.labelJCS10);
            this.groupBoxJCS3.Controls.Add(this.txtVlUnit);
            this.groupBoxJCS3.Controls.Add(this.labelJCS9);
            this.groupBoxJCS3.Controls.Add(this.txtQtCom);
            this.groupBoxJCS3.Controls.Add(this.labelJCS8);
            this.groupBoxJCS3.Controls.Add(this.txtDescProduto);
            this.groupBoxJCS3.Controls.Add(this.txtCodProduto);
            this.groupBoxJCS3.Controls.Add(this.labelJCS2);
            this.groupBoxJCS3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS3.Location = new System.Drawing.Point(0, 212);
            this.groupBoxJCS3.Name = "groupBoxJCS3";
            this.groupBoxJCS3.Size = new System.Drawing.Size(687, 429);
            this.groupBoxJCS3.TabIndex = 18;
            this.groupBoxJCS3.TabStop = false;
            this.groupBoxJCS3.Text = "Produtos";
            // 
            // btnAddProdSemCod
            // 
            this.btnAddProdSemCod.BackColor = System.Drawing.Color.Gold;
            this.btnAddProdSemCod.Enabled = false;
            this.btnAddProdSemCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdSemCod.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProdSemCod.Location = new System.Drawing.Point(3, 84);
            this.btnAddProdSemCod.Name = "btnAddProdSemCod";
            this.btnAddProdSemCod.Size = new System.Drawing.Size(681, 24);
            this.btnAddProdSemCod.TabIndex = 9;
            this.btnAddProdSemCod.Text = "Adicionar Produto sem código";
            this.btnAddProdSemCod.UseVisualStyleBackColor = false;
            this.btnAddProdSemCod.Click += new System.EventHandler(this.BtnAddProdSemCod_Click);
            // 
            // chkProdSemCod
            // 
            this.chkProdSemCod.AutoSize = true;
            this.chkProdSemCod.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkProdSemCod.Location = new System.Drawing.Point(548, 53);
            this.chkProdSemCod.Name = "chkProdSemCod";
            this.chkProdSemCod.Size = new System.Drawing.Size(132, 21);
            this.chkProdSemCod.TabIndex = 6;
            this.chkProdSemCod.Text = "Produto sem cód.";
            this.chkProdSemCod.UseVisualStyleBackColor = true;
            this.chkProdSemCod.CheckedChanged += new System.EventHandler(this.ChkProdSemCod_CheckedChanged);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.Gold;
            this.btnAddProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduto.Location = new System.Drawing.Point(3, 131);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(681, 24);
            this.btnAddProduto.TabIndex = 7;
            this.btnAddProduto.Text = "Adicionar Produto com código";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNFID,
            this.colCodProd,
            this.colDescProduto,
            this.colQtCom,
            this.colVlUnit,
            this.colUnComercial,
            this.colExcluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 155);
            this.dgvProdutos.Name = "dgvProdutos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(681, 271);
            this.dgvProdutos.TabIndex = 8;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // colNFID
            // 
            this.colNFID.DataPropertyName = "NF";
            this.colNFID.HeaderText = "NF";
            this.colNFID.Name = "colNFID";
            this.colNFID.Width = 48;
            // 
            // colCodProd
            // 
            this.colCodProd.DataPropertyName = "COD_PROD";
            this.colCodProd.HeaderText = "Cod. Prod.";
            this.colCodProd.Name = "colCodProd";
            this.colCodProd.Width = 95;
            // 
            // colDescProduto
            // 
            this.colDescProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescProduto.DataPropertyName = "DESC_PROD";
            this.colDescProduto.HeaderText = "Descrição";
            this.colDescProduto.Name = "colDescProduto";
            // 
            // colQtCom
            // 
            this.colQtCom.DataPropertyName = "QT_COM";
            this.colQtCom.HeaderText = "QT";
            this.colQtCom.Name = "colQtCom";
            this.colQtCom.Width = 50;
            // 
            // colVlUnit
            // 
            this.colVlUnit.DataPropertyName = "VL_UNIT";
            this.colVlUnit.HeaderText = "Valor";
            this.colVlUnit.Name = "colVlUnit";
            this.colVlUnit.Width = 63;
            // 
            // colUnComercial
            // 
            this.colUnComercial.DataPropertyName = "UN_COMERCIAL";
            this.colUnComercial.HeaderText = "Unid.";
            this.colUnComercial.Name = "colUnComercial";
            this.colUnComercial.Width = 65;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Width = 52;
            // 
            // txtUnidComercial
            // 
            this.txtUnidComercial.BackColor = System.Drawing.Color.White;
            this.txtUnidComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidComercial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtUnidComercial.IconeKeyDown = null;
            this.txtUnidComercial.Location = new System.Drawing.Point(80, 52);
            this.txtUnidComercial.MaxLength = 2;
            this.txtUnidComercial.Name = "txtUnidComercial";
            this.txtUnidComercial.Preenchimento = "";
            this.txtUnidComercial.Size = new System.Drawing.Size(86, 24);
            this.txtUnidComercial.TabIndex = 3;
            this.txtUnidComercial.TipoCampo = null;
            // 
            // labelJCS10
            // 
            this.labelJCS10.AutoSize = true;
            this.labelJCS10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS10.Location = new System.Drawing.Point(12, 56);
            this.labelJCS10.Name = "labelJCS10";
            this.labelJCS10.Size = new System.Drawing.Size(62, 17);
            this.labelJCS10.TabIndex = 7;
            this.labelJCS10.Text = "Unidade:";
            // 
            // txtVlUnit
            // 
            this.txtVlUnit.BackColor = System.Drawing.Color.White;
            this.txtVlUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlUnit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlUnit.IconeKeyDown = null;
            this.txtVlUnit.Location = new System.Drawing.Point(435, 52);
            this.txtVlUnit.Name = "txtVlUnit";
            this.txtVlUnit.Preenchimento = null;
            this.txtVlUnit.Size = new System.Drawing.Size(99, 24);
            this.txtVlUnit.TabIndex = 5;
            this.txtVlUnit.TipoCampo = "MONETARIO";
            // 
            // labelJCS9
            // 
            this.labelJCS9.AutoSize = true;
            this.labelJCS9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS9.Location = new System.Drawing.Point(367, 55);
            this.labelJCS9.Name = "labelJCS9";
            this.labelJCS9.Size = new System.Drawing.Size(62, 17);
            this.labelJCS9.TabIndex = 5;
            this.labelJCS9.Text = "VL. Unit.:";
            // 
            // txtQtCom
            // 
            this.txtQtCom.BackColor = System.Drawing.Color.White;
            this.txtQtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtCom.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtCom.IconeKeyDown = null;
            this.txtQtCom.Location = new System.Drawing.Point(262, 52);
            this.txtQtCom.Name = "txtQtCom";
            this.txtQtCom.Preenchimento = null;
            this.txtQtCom.Size = new System.Drawing.Size(99, 24);
            this.txtQtCom.TabIndex = 4;
            this.txtQtCom.TipoCampo = "INTEIRO";
            // 
            // labelJCS8
            // 
            this.labelJCS8.AutoSize = true;
            this.labelJCS8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS8.Location = new System.Drawing.Point(173, 56);
            this.labelJCS8.Name = "labelJCS8";
            this.labelJCS8.Size = new System.Drawing.Size(83, 17);
            this.labelJCS8.TabIndex = 3;
            this.labelJCS8.Text = "Quantidade:";
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.BackColor = System.Drawing.Color.White;
            this.txtDescProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescProduto.IconeKeyDown = null;
            this.txtDescProduto.Location = new System.Drawing.Point(176, 22);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Preenchimento = null;
            this.txtDescProduto.Size = new System.Drawing.Size(402, 24);
            this.txtDescProduto.TabIndex = 2;
            this.txtDescProduto.TipoCampo = null;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.Color.White;
            this.txtCodProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCodProduto.IconeKeyDown = null;
            this.txtCodProduto.Location = new System.Drawing.Point(80, 22);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Preenchimento = null;
            this.txtCodProduto.Size = new System.Drawing.Size(86, 24);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.TipoCampo = null;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.TxtCodProduto_TextChanged);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(21, 25);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(53, 17);
            this.labelJCS2.TabIndex = 0;
            this.labelJCS2.Text = "Codigo:";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.BackColor = System.Drawing.Color.White;
            this.txtIDFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDFornecedor.IconeKeyDown = null;
            this.txtIDFornecedor.Location = new System.Drawing.Point(125, 109);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Preenchimento = null;
            this.txtIDFornecedor.Size = new System.Drawing.Size(45, 24);
            this.txtIDFornecedor.TabIndex = 12;
            this.txtIDFornecedor.TipoCampo = "INTEIRO";
            this.txtIDFornecedor.Leave += new System.EventHandler(this.TxtIDFornecedor_Leave);
            // 
            // txtNumeroNFe
            // 
            this.txtNumeroNFe.BackColor = System.Drawing.Color.White;
            this.txtNumeroNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroNFe.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNumeroNFe.IconeKeyDown = null;
            this.txtNumeroNFe.Location = new System.Drawing.Point(125, 139);
            this.txtNumeroNFe.Name = "txtNumeroNFe";
            this.txtNumeroNFe.Preenchimento = null;
            this.txtNumeroNFe.Size = new System.Drawing.Size(96, 24);
            this.txtNumeroNFe.TabIndex = 14;
            this.txtNumeroNFe.TipoCampo = null;
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(19, 144);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(100, 17);
            this.labelJCS3.TabIndex = 22;
            this.labelJCS3.Text = "N. NF/Ped. For.:";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProd.Location = new System.Drawing.Point(584, 20);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(96, 24);
            this.btnBuscarProd.TabIndex = 334;
            this.btnBuscarProd.Text = "Buscar Prod.";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // frmCadastroNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 705);
            this.Controls.Add(this.txtNumeroNFe);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.groupBoxJCS3);
            this.Controls.Add(this.groupBoxJCS2);
            this.Controls.Add(this.btnBuscarFornecedor);
            this.Controls.Add(this.txtChave11);
            this.Controls.Add(this.txtChave10);
            this.Controls.Add(this.txtChave9);
            this.Controls.Add(this.txtChave8);
            this.Controls.Add(this.txtChave7);
            this.Controls.Add(this.txtChave6);
            this.Controls.Add(this.txtChave5);
            this.Controls.Add(this.txtChave4);
            this.Controls.Add(this.txtChave3);
            this.Controls.Add(this.txtChave2);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.labelJCS7);
            this.Controls.Add(this.labelJCS6);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.txtChave1);
            this.Controls.Add(this.txtValorNFe);
            this.Controls.Add(this.labelJCS1);
            this.Name = "frmCadastroNFe";
            this.Text = "Cadastro de NFe/Cupom Não fiscal Manual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroNFe_FormClosing);
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.groupBoxJCS2.ResumeLayout(false);
            this.groupBoxJCS3.ResumeLayout(false);
            this.groupBoxJCS3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtValorNFe;
        private Componentes.TextBoxJCS txtChave1;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.LabelJCS labelJCS7;
        private Componentes.dateTimePickerJCS dtpEmissao;
        private Componentes.dateTimePickerJCS dtpEntrega;
        private Componentes.TextBoxJCS txtFornecedor;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.RadioButtonJCScs rbtCupomNFiscal;
        private Componentes.RadioButtonJCScs rbtCupomFiscal;
        private Componentes.TextBoxJCS txtChave4;
        private Componentes.TextBoxJCS txtChave3;
        private Componentes.TextBoxJCS txtChave6;
        private Componentes.TextBoxJCS txtChave5;
        private Componentes.TextBoxJCS txtChave8;
        private Componentes.TextBoxJCS txtChave7;
        private Componentes.TextBoxJCS txtChave10;
        private Componentes.TextBoxJCS txtChave9;
        private Componentes.TextBoxJCS txtChave11;
        private Componentes.TextBoxJCS txtChave2;
        private Componentes.ButtonJCS btnBuscarFornecedor;
        private Componentes.GroupBoxJCS groupBoxJCS2;
        private Componentes.ButtonJCS btnSalvar;
        private Componentes.GroupBoxJCS groupBoxJCS3;
        private Componentes.ButtonJCS btnAddProduto;
        private Componentes.DataGridViewJCS dgvProdutos;
        private Componentes.TextBoxJCS txtUnidComercial;
        private Componentes.LabelJCS labelJCS10;
        private Componentes.TextBoxJCS txtVlUnit;
        private Componentes.LabelJCS labelJCS9;
        private Componentes.TextBoxJCS txtQtCom;
        private Componentes.LabelJCS labelJCS8;
        private Componentes.TextBoxJCS txtDescProduto;
        private Componentes.TextBoxJCS txtCodProduto;
        private Componentes.LabelJCS labelJCS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnComercial;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.TextBoxJCS txtIDFornecedor;
        private Componentes.TextBoxJCS txtNumeroNFe;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.CheckBoxJCS chkProdSemCod;
        private Componentes.ButtonJCS btnAddProdSemCod;
        private Componentes.ButtonJCS btnBuscarProd;
    }
}