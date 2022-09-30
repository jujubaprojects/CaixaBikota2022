namespace Caixa
{
    partial class frmNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoPedido));
            this.lblProduto = new Componentes.LabelJCS(this.components);
            this.cboProdutoFilho = new Componentes.ComboBoxJCS(this.components);
            this.cboProdutoPai = new Componentes.ComboBoxJCS(this.components);
            this.lblDescricao = new Componentes.LabelJCS(this.components);
            this.lblQuantidade = new Componentes.LabelJCS(this.components);
            this.txtQuantidade = new Componentes.TextBoxJCS(this.components);
            this.txtDescPedido = new Componentes.TextBoxJCS(this.components);
            this.lblDescPedido = new Componentes.LabelJCS(this.components);
            this.txtPedidoID = new Componentes.TextBoxJCS(this.components);
            this.lblCobertura = new Componentes.LabelJCS(this.components);
            this.txtCobertura = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtObservacao = new Componentes.TextBoxJCS(this.components);
            this.dgvProdutos = new Componentes.DataGridViewJCS(this.components);
            this.colPedidoProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAddAdicionais = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.cboTipo = new Componentes.ComboBoxJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelarPedido = new Componentes.ButtonJCS(this.components);
            this.btnEnviarPedido = new Componentes.ButtonJCS(this.components);
            this.btnAddProduto = new Componentes.ButtonJCS(this.components);
            this.cboDesc1 = new Componentes.ComboBoxJCS(this.components);
            this.cboDesc2 = new Componentes.ComboBoxJCS(this.components);
            this.cboDesc3 = new Componentes.ComboBoxJCS(this.components);
            this.txtDescricaoProduto = new Componentes.TextBoxJCS(this.components);
            this.cboDesc6 = new Componentes.ComboBoxJCS(this.components);
            this.cboDesc5 = new Componentes.ComboBoxJCS(this.components);
            this.cboDesc4 = new Componentes.ComboBoxJCS(this.components);
            this.txtEndereco = new Componentes.TextBoxJCS(this.components);
            this.txtObservacaoPedido = new Componentes.TextBoxJCS(this.components);
            this.btnEnviarPedidoSemImprimir = new Componentes.ButtonJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(47, 45);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // cboProdutoFilho
            // 
            this.cboProdutoFilho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoFilho.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoFilho.FormattingEnabled = true;
            this.cboProdutoFilho.Location = new System.Drawing.Point(320, 42);
            this.cboProdutoFilho.Name = "cboProdutoFilho";
            this.cboProdutoFilho.Size = new System.Drawing.Size(459, 23);
            this.cboProdutoFilho.TabIndex = 3;
            this.cboProdutoFilho.SelectedIndexChanged += new System.EventHandler(this.CboProdutoFilho_SelectedIndexChanged);
            // 
            // cboProdutoPai
            // 
            this.cboProdutoPai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoPai.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoPai.FormattingEnabled = true;
            this.cboProdutoPai.Location = new System.Drawing.Point(114, 42);
            this.cboProdutoPai.Name = "cboProdutoPai";
            this.cboProdutoPai.Size = new System.Drawing.Size(200, 23);
            this.cboProdutoPai.TabIndex = 2;
            this.cboProdutoPai.SelectedIndexChanged += new System.EventHandler(this.CboProdutoPai_SelectedIndexChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(12, 74);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(96, 17);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Desc. Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(25, 162);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(83, 17);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.IconeKeyDown = null;
            this.txtQuantidade.Location = new System.Drawing.Point(114, 159);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Preenchimento = null;
            this.txtQuantidade.Size = new System.Drawing.Size(108, 24);
            this.txtQuantidade.TabIndex = 13;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TipoCampo = "INTEIRO";
            // 
            // txtDescPedido
            // 
            this.txtDescPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescPedido.BackColor = System.Drawing.Color.White;
            this.txtDescPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescPedido.IconeKeyDown = null;
            this.txtDescPedido.Location = new System.Drawing.Point(228, 12);
            this.txtDescPedido.Name = "txtDescPedido";
            this.txtDescPedido.Preenchimento = null;
            this.txtDescPedido.Size = new System.Drawing.Size(858, 24);
            this.txtDescPedido.TabIndex = 1;
            this.txtDescPedido.TipoCampo = "STRING";
            this.txtDescPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescPedido_KeyDown);
            // 
            // lblDescPedido
            // 
            this.lblDescPedido.AutoSize = true;
            this.lblDescPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescPedido.Location = new System.Drawing.Point(20, 15);
            this.lblDescPedido.Name = "lblDescPedido";
            this.lblDescPedido.Size = new System.Drawing.Size(88, 17);
            this.lblDescPedido.TabIndex = 14;
            this.lblDescPedido.Text = "Desc. Pedido:";
            // 
            // txtPedidoID
            // 
            this.txtPedidoID.BackColor = System.Drawing.Color.White;
            this.txtPedidoID.Enabled = false;
            this.txtPedidoID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtPedidoID.IconeKeyDown = null;
            this.txtPedidoID.Location = new System.Drawing.Point(114, 12);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Preenchimento = null;
            this.txtPedidoID.Size = new System.Drawing.Size(108, 24);
            this.txtPedidoID.TabIndex = 15;
            this.txtPedidoID.TipoCampo = "INTEIRO";
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCobertura.Location = new System.Drawing.Point(36, 132);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(72, 17);
            this.lblCobertura.TabIndex = 16;
            this.lblCobertura.Text = "Cobertura:";
            // 
            // txtCobertura
            // 
            this.txtCobertura.BackColor = System.Drawing.Color.White;
            this.txtCobertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCobertura.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCobertura.IconeKeyDown = null;
            this.txtCobertura.Location = new System.Drawing.Point(114, 129);
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Preenchimento = null;
            this.txtCobertura.Size = new System.Drawing.Size(108, 24);
            this.txtCobertura.TabIndex = 11;
            this.txtCobertura.TipoCampo = null;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(232, 132);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(82, 17);
            this.labelJCS2.TabIndex = 18;
            this.labelJCS2.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtObservacao.IconeKeyDown = null;
            this.txtObservacao.Location = new System.Drawing.Point(320, 129);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Preenchimento = null;
            this.txtObservacao.Size = new System.Drawing.Size(200, 24);
            this.txtObservacao.TabIndex = 12;
            this.txtObservacao.TipoCampo = null;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colPedidoProdutoID,
            this.colProdutoID,
            this.colProduto,
            this.colDescricao,
            this.colTipo,
            this.colQuantidade,
            this.colValor,
            this.colEditar,
            this.colAddAdicionais,
            this.colExcluir});
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 226);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1098, 273);
            this.dgvProdutos.TabIndex = 100;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
            // 
            // colPedidoProdutoID
            // 
            this.colPedidoProdutoID.DataPropertyName = "ID_PEDIDO_PRODUTO";
            this.colPedidoProdutoID.HeaderText = "PedidoProduto";
            this.colPedidoProdutoID.Name = "colPedidoProdutoID";
            this.colPedidoProdutoID.ReadOnly = true;
            this.colPedidoProdutoID.Visible = false;
            this.colPedidoProdutoID.Width = 104;
            // 
            // colProdutoID
            // 
            this.colProdutoID.DataPropertyName = "ID_PRODUTO";
            this.colProdutoID.HeaderText = "IDProduto";
            this.colProdutoID.Name = "colProdutoID";
            this.colProdutoID.ReadOnly = true;
            this.colProdutoID.Visible = false;
            this.colProdutoID.Width = 76;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // colTipo
            // 
            this.colTipo.DataPropertyName = "TIPO";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Visible = false;
            this.colTipo.Width = 59;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "QUANTIDADE";
            this.colQuantidade.HeaderText = "Quant.";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 75;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VALOR";
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 63;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Image = global::Caixa.Properties.Resources.icons8_editar_20;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Visible = false;
            this.colEditar.Width = 49;
            // 
            // colAddAdicionais
            // 
            this.colAddAdicionais.HeaderText = "Add. Adicionais";
            this.colAddAdicionais.Image = global::Caixa.Properties.Resources.icons8_adicionar_20;
            this.colAddAdicionais.Name = "colAddAdicionais";
            this.colAddAdicionais.ReadOnly = true;
            this.colAddAdicionais.Width = 105;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 52;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(276, 163);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(38, 17);
            this.labelJCS1.TabIndex = 11;
            this.labelJCS1.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(320, 159);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(200, 23);
            this.cboTipo.TabIndex = 14;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.CboTipo_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Caixa.Properties.Resources.icons8_editar_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::Caixa.Properties.Resources.icons8_cancelar_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 52;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPedido.BackColor = System.Drawing.Color.Gold;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPedido.Image = global::Caixa.Properties.Resources.icons8_cancelar_48;
            this.btnCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPedido.Location = new System.Drawing.Point(785, 42);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(301, 53);
            this.btnCancelarPedido.TabIndex = 16;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Visible = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.BtnCancelarPedido_Click);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarPedido.BackColor = System.Drawing.Color.Gold;
            this.btnEnviarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarPedido.Image")));
            this.btnEnviarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarPedido.Location = new System.Drawing.Point(785, 101);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(301, 54);
            this.btnEnviarPedido.TabIndex = 17;
            this.btnEnviarPedido.Text = "Enviar Pedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = false;
            this.btnEnviarPedido.Visible = false;
            this.btnEnviarPedido.Click += new System.EventHandler(this.BtnEnviarPedido_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.Gold;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduto.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(114, 189);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(665, 24);
            this.btnAddProduto.TabIndex = 15;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // cboDesc1
            // 
            this.cboDesc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc1.FormattingEnabled = true;
            this.cboDesc1.Location = new System.Drawing.Point(114, 71);
            this.cboDesc1.Name = "cboDesc1";
            this.cboDesc1.Size = new System.Drawing.Size(200, 23);
            this.cboDesc1.TabIndex = 5;
            this.cboDesc1.SelectedIndexChanged += new System.EventHandler(this.CboDesc1_SelectedIndexChanged);
            // 
            // cboDesc2
            // 
            this.cboDesc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc2.FormattingEnabled = true;
            this.cboDesc2.Location = new System.Drawing.Point(320, 71);
            this.cboDesc2.Name = "cboDesc2";
            this.cboDesc2.Size = new System.Drawing.Size(200, 23);
            this.cboDesc2.TabIndex = 6;
            this.cboDesc2.SelectedIndexChanged += new System.EventHandler(this.CboDesc2_SelectedIndexChanged);
            this.cboDesc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboDesc2_KeyPress);
            // 
            // cboDesc3
            // 
            this.cboDesc3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc3.FormattingEnabled = true;
            this.cboDesc3.Location = new System.Drawing.Point(526, 71);
            this.cboDesc3.Name = "cboDesc3";
            this.cboDesc3.Size = new System.Drawing.Size(253, 23);
            this.cboDesc3.TabIndex = 7;
            this.cboDesc3.SelectedIndexChanged += new System.EventHandler(this.CboDesc3_SelectedIndexChanged);
            this.cboDesc3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboDesc3_KeyPress);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.Color.White;
            this.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricaoProduto.IconeKeyDown = null;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(114, 70);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Preenchimento = null;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(665, 24);
            this.txtDescricaoProduto.TabIndex = 4;
            this.txtDescricaoProduto.TipoCampo = "STRING";
            this.txtDescricaoProduto.Visible = false;
            // 
            // cboDesc6
            // 
            this.cboDesc6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc6.FormattingEnabled = true;
            this.cboDesc6.Location = new System.Drawing.Point(526, 100);
            this.cboDesc6.Name = "cboDesc6";
            this.cboDesc6.Size = new System.Drawing.Size(253, 23);
            this.cboDesc6.TabIndex = 10;
            this.cboDesc6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboDesc6_KeyPress);
            // 
            // cboDesc5
            // 
            this.cboDesc5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc5.FormattingEnabled = true;
            this.cboDesc5.Location = new System.Drawing.Point(320, 100);
            this.cboDesc5.Name = "cboDesc5";
            this.cboDesc5.Size = new System.Drawing.Size(200, 23);
            this.cboDesc5.TabIndex = 9;
            this.cboDesc5.SelectedIndexChanged += new System.EventHandler(this.CboDesc5_SelectedIndexChanged);
            this.cboDesc5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboDesc5_KeyPress);
            // 
            // cboDesc4
            // 
            this.cboDesc4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesc4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboDesc4.FormattingEnabled = true;
            this.cboDesc4.Location = new System.Drawing.Point(114, 100);
            this.cboDesc4.Name = "cboDesc4";
            this.cboDesc4.Size = new System.Drawing.Size(200, 23);
            this.cboDesc4.TabIndex = 8;
            this.cboDesc4.SelectedIndexChanged += new System.EventHandler(this.CboDesc4_SelectedIndexChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEndereco.IconeKeyDown = null;
            this.txtEndereco.Location = new System.Drawing.Point(526, 159);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Preenchimento = null;
            this.txtEndereco.Size = new System.Drawing.Size(253, 24);
            this.txtEndereco.TabIndex = 101;
            this.txtEndereco.Text = "ENDEREÇO";
            this.txtEndereco.TipoCampo = null;
            this.txtEndereco.Visible = false;
            this.txtEndereco.Enter += new System.EventHandler(this.TxtEndereco_Enter);
            // 
            // txtObservacaoPedido
            // 
            this.txtObservacaoPedido.BackColor = System.Drawing.Color.White;
            this.txtObservacaoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacaoPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtObservacaoPedido.IconeKeyDown = null;
            this.txtObservacaoPedido.Location = new System.Drawing.Point(785, 159);
            this.txtObservacaoPedido.Name = "txtObservacaoPedido";
            this.txtObservacaoPedido.Preenchimento = null;
            this.txtObservacaoPedido.Size = new System.Drawing.Size(253, 24);
            this.txtObservacaoPedido.TabIndex = 102;
            this.txtObservacaoPedido.Text = "TROCO OU CARTÃO";
            this.txtObservacaoPedido.TipoCampo = null;
            this.txtObservacaoPedido.Visible = false;
            this.txtObservacaoPedido.Enter += new System.EventHandler(this.TxtObservacaoPedido_Enter);
            // 
            // btnEnviarPedidoSemImprimir
            // 
            this.btnEnviarPedidoSemImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarPedidoSemImprimir.BackColor = System.Drawing.Color.Gold;
            this.btnEnviarPedidoSemImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarPedidoSemImprimir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarPedidoSemImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarPedidoSemImprimir.Image")));
            this.btnEnviarPedidoSemImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarPedidoSemImprimir.Location = new System.Drawing.Point(785, 189);
            this.btnEnviarPedidoSemImprimir.Name = "btnEnviarPedidoSemImprimir";
            this.btnEnviarPedidoSemImprimir.Size = new System.Drawing.Size(301, 24);
            this.btnEnviarPedidoSemImprimir.TabIndex = 103;
            this.btnEnviarPedidoSemImprimir.Text = "Enviar Pedido Sem Imprimir";
            this.btnEnviarPedidoSemImprimir.UseVisualStyleBackColor = false;
            this.btnEnviarPedidoSemImprimir.Visible = false;
            this.btnEnviarPedidoSemImprimir.Click += new System.EventHandler(this.BtnEnviarPedidoSemImprimir_Click);
            // 
            // frmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 499);
            this.Controls.Add(this.btnEnviarPedidoSemImprimir);
            this.Controls.Add(this.txtObservacaoPedido);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.cboDesc6);
            this.Controls.Add(this.cboDesc5);
            this.Controls.Add(this.cboDesc4);
            this.Controls.Add(this.cboDesc3);
            this.Controls.Add(this.cboDesc2);
            this.Controls.Add(this.cboDesc1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtCobertura);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.txtPedidoID);
            this.Controls.Add(this.lblDescPedido);
            this.Controls.Add(this.txtDescPedido);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cboProdutoPai);
            this.Controls.Add(this.cboProdutoFilho);
            this.Controls.Add(this.lblProduto);
            this.KeyPreview = true;
            this.Name = "frmNovoPedido";
            this.Text = "Novo Pedido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNovoPedido_KeyDown);
            this.MouseEnter += new System.EventHandler(this.FrmNovoPedido_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS lblProduto;
        private Componentes.ComboBoxJCS cboProdutoFilho;
        private Componentes.ComboBoxJCS cboProdutoPai;
        private Componentes.LabelJCS lblDescricao;
        private Componentes.LabelJCS lblQuantidade;
        private Componentes.TextBoxJCS txtQuantidade;
        private Componentes.ButtonJCS btnAddProduto;
        private Componentes.ButtonJCS btnEnviarPedido;
        private Componentes.ButtonJCS btnCancelarPedido;
        private Componentes.TextBoxJCS txtDescPedido;
        private Componentes.LabelJCS lblDescPedido;
        private Componentes.TextBoxJCS txtPedidoID;
        private Componentes.LabelJCS lblCobertura;
        private Componentes.TextBoxJCS txtCobertura;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtObservacao;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Componentes.DataGridViewJCS dgvProdutos;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.ComboBoxJCS cboTipo;
        private Componentes.ComboBoxJCS cboDesc1;
        private Componentes.ComboBoxJCS cboDesc2;
        private Componentes.ComboBoxJCS cboDesc3;
        private Componentes.TextBoxJCS txtDescricaoProduto;
        private Componentes.ComboBoxJCS cboDesc6;
        private Componentes.ComboBoxJCS cboDesc5;
        private Componentes.ComboBoxJCS cboDesc4;
        private Componentes.TextBoxJCS txtEndereco;
        private Componentes.TextBoxJCS txtObservacaoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedidoProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colAddAdicionais;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private Componentes.ButtonJCS btnEnviarPedidoSemImprimir;
    }
}