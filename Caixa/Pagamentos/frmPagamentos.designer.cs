namespace Caixa
{
    partial class frmPagamentos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPagarTudo = new Componentes.ButtonJCS(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSituacao = new Componentes.LabelJCS(this.components);
            this.txtEndereco = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtVlTotal = new Componentes.TextBoxJCS(this.components);
            this.btnPagarSelecionados = new Componentes.ButtonJCS(this.components);
            this.txtVlPago = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.txtVlAberto = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtDescPedido = new Componentes.TextBoxJCS(this.components);
            this.txtPedidoID = new Componentes.TextBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.dgvProdutosAbertos = new Componentes.DataGridViewJCS(this.components);
            this.colPedidoProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChkPagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddProduto = new Componentes.ButtonJCS(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAbertos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPagarTudo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 100);
            this.panel2.TabIndex = 11;
            // 
            // btnPagarTudo
            // 
            this.btnPagarTudo.BackColor = System.Drawing.Color.Gold;
            this.btnPagarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagarTudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarTudo.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Bold);
            this.btnPagarTudo.Image = global::Caixa.Properties.Resources.icons8_títulos_96;
            this.btnPagarTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarTudo.Location = new System.Drawing.Point(0, 0);
            this.btnPagarTudo.Name = "btnPagarTudo";
            this.btnPagarTudo.Size = new System.Drawing.Size(896, 100);
            this.btnPagarTudo.TabIndex = 8;
            this.btnPagarTudo.Text = "Pagar Tudo";
            this.btnPagarTudo.UseVisualStyleBackColor = false;
            this.btnPagarTudo.Click += new System.EventHandler(this.BtnPagarTudo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddProduto);
            this.panel3.Controls.Add(this.lblSituacao);
            this.panel3.Controls.Add(this.txtEndereco);
            this.panel3.Controls.Add(this.labelJCS4);
            this.panel3.Controls.Add(this.txtVlTotal);
            this.panel3.Controls.Add(this.btnPagarSelecionados);
            this.panel3.Controls.Add(this.txtVlPago);
            this.panel3.Controls.Add(this.labelJCS3);
            this.panel3.Controls.Add(this.txtVlAberto);
            this.panel3.Controls.Add(this.labelJCS2);
            this.panel3.Controls.Add(this.txtDescPedido);
            this.panel3.Controls.Add(this.txtPedidoID);
            this.panel3.Controls.Add(this.labelJCS1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 133);
            this.panel3.TabIndex = 12;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.lblSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblSituacao.Location = new System.Drawing.Point(328, 69);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(319, 41);
            this.lblSituacao.TabIndex = 20;
            this.lblSituacao.Text = "PEDIDO: CANCELADO";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEndereco.IconeKeyDown = null;
            this.txtEndereco.Location = new System.Drawing.Point(170, 42);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Preenchimento = null;
            this.txtEndereco.Size = new System.Drawing.Size(477, 24);
            this.txtEndereco.TabIndex = 21;
            this.txtEndereco.TipoCampo = null;
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(24, 45);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(59, 17);
            this.labelJCS4.TabIndex = 19;
            this.labelJCS4.Text = "Vl. Total:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.BackColor = System.Drawing.Color.White;
            this.txtVlTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlTotal.Enabled = false;
            this.txtVlTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlTotal.IconeKeyDown = null;
            this.txtVlTotal.Location = new System.Drawing.Point(89, 42);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.Preenchimento = null;
            this.txtVlTotal.Size = new System.Drawing.Size(75, 24);
            this.txtVlTotal.TabIndex = 18;
            this.txtVlTotal.TipoCampo = null;
            // 
            // btnPagarSelecionados
            // 
            this.btnPagarSelecionados.BackColor = System.Drawing.Color.Gold;
            this.btnPagarSelecionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarSelecionados.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagarSelecionados.Image = global::Caixa.Properties.Resources.icons8_caixa_de_seleção_marcada_48;
            this.btnPagarSelecionados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarSelecionados.Location = new System.Drawing.Point(653, 72);
            this.btnPagarSelecionados.Name = "btnPagarSelecionados";
            this.btnPagarSelecionados.Size = new System.Drawing.Size(226, 50);
            this.btnPagarSelecionados.TabIndex = 17;
            this.btnPagarSelecionados.Text = "Pagar Selecionados";
            this.btnPagarSelecionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarSelecionados.UseVisualStyleBackColor = false;
            this.btnPagarSelecionados.Click += new System.EventHandler(this.BtnPagarSelecionados_Click);
            // 
            // txtVlPago
            // 
            this.txtVlPago.BackColor = System.Drawing.Color.White;
            this.txtVlPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlPago.Enabled = false;
            this.txtVlPago.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlPago.IconeKeyDown = null;
            this.txtVlPago.Location = new System.Drawing.Point(89, 72);
            this.txtVlPago.Name = "txtVlPago";
            this.txtVlPago.Preenchimento = null;
            this.txtVlPago.Size = new System.Drawing.Size(75, 24);
            this.txtVlPago.TabIndex = 16;
            this.txtVlPago.TipoCampo = "MONETARIO";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(24, 75);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(59, 17);
            this.labelJCS3.TabIndex = 15;
            this.labelJCS3.Text = "Vl. Pago:";
            // 
            // txtVlAberto
            // 
            this.txtVlAberto.BackColor = System.Drawing.Color.White;
            this.txtVlAberto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlAberto.Enabled = false;
            this.txtVlAberto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlAberto.IconeKeyDown = null;
            this.txtVlAberto.Location = new System.Drawing.Point(247, 72);
            this.txtVlAberto.Name = "txtVlAberto";
            this.txtVlAberto.Preenchimento = null;
            this.txtVlAberto.Size = new System.Drawing.Size(75, 24);
            this.txtVlAberto.TabIndex = 14;
            this.txtVlAberto.TipoCampo = "STRING";
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(170, 75);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(71, 17);
            this.labelJCS2.TabIndex = 13;
            this.labelJCS2.Text = "Vl. Aberto:";
            // 
            // txtDescPedido
            // 
            this.txtDescPedido.BackColor = System.Drawing.Color.White;
            this.txtDescPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescPedido.Enabled = false;
            this.txtDescPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescPedido.IconeKeyDown = null;
            this.txtDescPedido.Location = new System.Drawing.Point(170, 12);
            this.txtDescPedido.Name = "txtDescPedido";
            this.txtDescPedido.Preenchimento = null;
            this.txtDescPedido.Size = new System.Drawing.Size(714, 24);
            this.txtDescPedido.TabIndex = 12;
            this.txtDescPedido.TipoCampo = null;
            // 
            // txtPedidoID
            // 
            this.txtPedidoID.BackColor = System.Drawing.Color.White;
            this.txtPedidoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPedidoID.Enabled = false;
            this.txtPedidoID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtPedidoID.IconeKeyDown = null;
            this.txtPedidoID.Location = new System.Drawing.Point(89, 12);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Preenchimento = null;
            this.txtPedidoID.Size = new System.Drawing.Size(75, 24);
            this.txtPedidoID.TabIndex = 11;
            this.txtPedidoID.TipoCampo = null;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(14, 15);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(69, 17);
            this.labelJCS1.TabIndex = 10;
            this.labelJCS1.Text = "Descrição:";
            // 
            // dgvProdutosAbertos
            // 
            this.dgvProdutosAbertos.AllowUserToAddRows = false;
            this.dgvProdutosAbertos.AllowUserToDeleteRows = false;
            this.dgvProdutosAbertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutosAbertos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosAbertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosAbertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedidoProdutoID,
            this.colProduto,
            this.colDescricao,
            this.colQuantidade,
            this.colVlProduto,
            this.colVlTotal,
            this.colValorPago,
            this.colVlAberto,
            this.colOrdem,
            this.colChkPagar,
            this.colCancelar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutosAbertos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutosAbertos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosAbertos.EnableHeadersVisualStyles = false;
            this.dgvProdutosAbertos.Location = new System.Drawing.Point(0, 133);
            this.dgvProdutosAbertos.Name = "dgvProdutosAbertos";
            this.dgvProdutosAbertos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosAbertos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutosAbertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutosAbertos.Size = new System.Drawing.Size(896, 320);
            this.dgvProdutosAbertos.TabIndex = 13;
            this.dgvProdutosAbertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosAbertos_CellContentClick);
            this.dgvProdutosAbertos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProdutosAbertos_CellFormatting);
            // 
            // colPedidoProdutoID
            // 
            this.colPedidoProdutoID.DataPropertyName = "PED_PROD_ID";
            this.colPedidoProdutoID.HeaderText = "ID";
            this.colPedidoProdutoID.Name = "colPedidoProdutoID";
            this.colPedidoProdutoID.ReadOnly = true;
            this.colPedidoProdutoID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPedidoProdutoID.Visible = false;
            this.colPedidoProdutoID.Width = 27;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProduto.DataPropertyName = "PRODUTO";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colProduto.Width = 63;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESC_PRODUTO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "QT_PRODUTO";
            this.colQuantidade.HeaderText = "Qt.";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantidade.Width = 33;
            // 
            // colVlProduto
            // 
            this.colVlProduto.DataPropertyName = "VL_PRODUTO";
            this.colVlProduto.HeaderText = "Vl. Produto";
            this.colVlProduto.Name = "colVlProduto";
            this.colVlProduto.ReadOnly = true;
            this.colVlProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVlProduto.Width = 81;
            // 
            // colVlTotal
            // 
            this.colVlTotal.DataPropertyName = "VL_TOTAL";
            this.colVlTotal.HeaderText = "Vl. Total";
            this.colVlTotal.Name = "colVlTotal";
            this.colVlTotal.ReadOnly = true;
            this.colVlTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVlTotal.Width = 61;
            // 
            // colValorPago
            // 
            this.colValorPago.DataPropertyName = "VL_PAGO";
            this.colValorPago.HeaderText = "Vl. Pago";
            this.colValorPago.Name = "colValorPago";
            this.colValorPago.ReadOnly = true;
            this.colValorPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValorPago.Width = 61;
            // 
            // colVlAberto
            // 
            this.colVlAberto.DataPropertyName = "VL_ABERTO";
            this.colVlAberto.HeaderText = "Vl. Aberto";
            this.colVlAberto.Name = "colVlAberto";
            this.colVlAberto.ReadOnly = true;
            this.colVlAberto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVlAberto.Width = 73;
            // 
            // colOrdem
            // 
            this.colOrdem.DataPropertyName = "ORDEM";
            this.colOrdem.HeaderText = "Ordem";
            this.colOrdem.Name = "colOrdem";
            this.colOrdem.ReadOnly = true;
            this.colOrdem.Visible = false;
            this.colOrdem.Width = 73;
            // 
            // colChkPagar
            // 
            this.colChkPagar.FalseValue = "false";
            this.colChkPagar.HeaderText = "Selecionar";
            this.colChkPagar.IndeterminateValue = "false";
            this.colChkPagar.Name = "colChkPagar";
            this.colChkPagar.ReadOnly = true;
            this.colChkPagar.TrueValue = "true";
            this.colChkPagar.Width = 75;
            // 
            // colCancelar
            // 
            this.colCancelar.DataPropertyName = "CANCELAR";
            this.colCancelar.HeaderText = "Cancelar";
            this.colCancelar.Image = global::Caixa.Properties.Resources.icons8_cancelar_16;
            this.colCancelar.Name = "colCancelar";
            this.colCancelar.ReadOnly = true;
            this.colCancelar.Width = 64;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.Gold;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduto.Image = global::Caixa.Properties.Resources.icons8_adicionar_regra_24;
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(653, 42);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(226, 24);
            this.btnAddProduto.TabIndex = 22;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 553);
            this.Controls.Add(this.dgvProdutosAbertos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmPagamentos";
            this.Text = "frmPagamentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagamentos_KeyDown);
            this.MouseEnter += new System.EventHandler(this.FrmPagamentos_MouseEnter);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAbertos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.ButtonJCS btnPagarTudo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Componentes.ButtonJCS btnPagarSelecionados;
        private Componentes.TextBoxJCS txtVlPago;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.TextBoxJCS txtVlAberto;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtDescPedido;
        private Componentes.TextBoxJCS txtPedidoID;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.DataGridViewJCS dgvProdutosAbertos;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtVlTotal;
        private Componentes.LabelJCS lblSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedidoProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChkPagar;
        private System.Windows.Forms.DataGridViewImageColumn colCancelar;
        private Componentes.TextBoxJCS txtEndereco;
        private Componentes.ButtonJCS btnAddProduto;
    }
}