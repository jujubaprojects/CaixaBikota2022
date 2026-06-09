namespace Caixa.Estoque
{
    partial class frmConsultaBaldesVendidosXRegistrados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.dgvVendidos = new Componentes.DataGridViewJCS(this.components);
            this.groupBoxJCS2 = new Componentes.GroupBoxJCS(this.components);
            this.dgvPagos = new Componentes.DataGridViewJCS(this.components);
            this.groupBoxJCS3 = new Componentes.GroupBoxJCS(this.components);
            this.dgvMarcados = new Componentes.DataGridViewJCS(this.components);
            this.colIDBaldeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaldeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefoneB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColherR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new Componentes.dateTimePickerJCS(this.components);
            this.groupBoxJCS4 = new Componentes.GroupBoxJCS(this.components);
            this.chkTodos = new Componentes.CheckBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.colDescProdutoPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLPagoPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTPagamentoPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPedidoProdutoPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPagamentoPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPedidoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescProdPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxJCS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).BeginInit();
            this.groupBoxJCS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.groupBoxJCS3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcados)).BeginInit();
            this.groupBoxJCS4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.dgvVendidos);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(9, 74);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(845, 129);
            this.groupBoxJCS1.TabIndex = 5;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Baldes Vendidos";
            // 
            // dgvVendidos
            // 
            this.dgvVendidos.AllowUserToAddRows = false;
            this.dgvVendidos.AllowUserToDeleteRows = false;
            this.dgvVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPedido,
            this.colDescPedido,
            this.colIDPedidoProduto,
            this.colDTAlteracao,
            this.colQtProduto,
            this.colDescProdPP,
            this.colSituacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendidos.EnableHeadersVisualStyles = false;
            this.dgvVendidos.Location = new System.Drawing.Point(3, 20);
            this.dgvVendidos.Name = "dgvVendidos";
            this.dgvVendidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendidos.RowHeadersVisible = false;
            this.dgvVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendidos.Size = new System.Drawing.Size(839, 106);
            this.dgvVendidos.TabIndex = 0;
            // 
            // groupBoxJCS2
            // 
            this.groupBoxJCS2.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS2.Controls.Add(this.dgvPagos);
            this.groupBoxJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS2.Location = new System.Drawing.Point(9, 209);
            this.groupBoxJCS2.Name = "groupBoxJCS2";
            this.groupBoxJCS2.Size = new System.Drawing.Size(845, 129);
            this.groupBoxJCS2.TabIndex = 6;
            this.groupBoxJCS2.TabStop = false;
            this.groupBoxJCS2.Text = "Baldes Pago";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPagamentoPG,
            this.colTipoPagamento,
            this.colIDPedidoProdutoPG,
            this.colDTPagamentoPG,
            this.colVLPagoPG,
            this.colDescProdutoPG});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.Location = new System.Drawing.Point(3, 20);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(839, 106);
            this.dgvPagos.TabIndex = 1;
            // 
            // groupBoxJCS3
            // 
            this.groupBoxJCS3.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS3.Controls.Add(this.dgvMarcados);
            this.groupBoxJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS3.Location = new System.Drawing.Point(9, 359);
            this.groupBoxJCS3.Name = "groupBoxJCS3";
            this.groupBoxJCS3.Size = new System.Drawing.Size(845, 129);
            this.groupBoxJCS3.TabIndex = 7;
            this.groupBoxJCS3.TabStop = false;
            this.groupBoxJCS3.Text = "Baldes Registrados";
            // 
            // dgvMarcados
            // 
            this.dgvMarcados.AllowUserToAddRows = false;
            this.dgvMarcados.AllowUserToDeleteRows = false;
            this.dgvMarcados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMarcados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMarcados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDBaldeR,
            this.colNomeB,
            this.colBaldeB,
            this.colDataB,
            this.colTelefoneB,
            this.colColherR});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMarcados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcados.EnableHeadersVisualStyles = false;
            this.dgvMarcados.Location = new System.Drawing.Point(3, 20);
            this.dgvMarcados.Name = "dgvMarcados";
            this.dgvMarcados.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarcados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMarcados.RowHeadersVisible = false;
            this.dgvMarcados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcados.Size = new System.Drawing.Size(839, 106);
            this.dgvMarcados.TabIndex = 2;
            // 
            // colIDBaldeR
            // 
            this.colIDBaldeR.DataPropertyName = "ID_BALDE";
            this.colIDBaldeR.HeaderText = "ID Balde";
            this.colIDBaldeR.Name = "colIDBaldeR";
            this.colIDBaldeR.ReadOnly = true;
            this.colIDBaldeR.Width = 82;
            // 
            // colNomeB
            // 
            this.colNomeB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeB.DataPropertyName = "NOME";
            this.colNomeB.HeaderText = "Nome";
            this.colNomeB.Name = "colNomeB";
            this.colNomeB.ReadOnly = true;
            // 
            // colBaldeB
            // 
            this.colBaldeB.DataPropertyName = "BALDE";
            this.colBaldeB.HeaderText = "Registro";
            this.colBaldeB.Name = "colBaldeB";
            this.colBaldeB.ReadOnly = true;
            this.colBaldeB.Width = 82;
            // 
            // colDataB
            // 
            this.colDataB.DataPropertyName = "DATA";
            this.colDataB.HeaderText = "Data";
            this.colDataB.Name = "colDataB";
            this.colDataB.ReadOnly = true;
            this.colDataB.Width = 61;
            // 
            // colTelefoneB
            // 
            this.colTelefoneB.DataPropertyName = "TELEFONE";
            this.colTelefoneB.HeaderText = "Telefone";
            this.colTelefoneB.Name = "colTelefoneB";
            this.colTelefoneB.ReadOnly = true;
            this.colTelefoneB.Width = 83;
            // 
            // colColherR
            // 
            this.colColherR.DataPropertyName = "COLHER";
            this.colColherR.HeaderText = "Colher";
            this.colColherR.Name = "colColherR";
            this.colColherR.ReadOnly = true;
            this.colColherR.Width = 71;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(52, 23);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(105, 24);
            this.dtpData.TabIndex = 3;
            this.dtpData.Value = new System.DateTime(2026, 5, 27, 0, 0, 0, 0);
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // groupBoxJCS4
            // 
            this.groupBoxJCS4.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS4.Controls.Add(this.chkTodos);
            this.groupBoxJCS4.Controls.Add(this.dtpData);
            this.groupBoxJCS4.Controls.Add(this.labelJCS1);
            this.groupBoxJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS4.Location = new System.Drawing.Point(9, 7);
            this.groupBoxJCS4.Name = "groupBoxJCS4";
            this.groupBoxJCS4.Size = new System.Drawing.Size(309, 61);
            this.groupBoxJCS4.TabIndex = 8;
            this.groupBoxJCS4.TabStop = false;
            this.groupBoxJCS4.Text = "Filtro";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkTodos.Location = new System.Drawing.Point(240, 26);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(63, 21);
            this.chkTodos.TabIndex = 4;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(6, 30);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(40, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Data:";
            // 
            // colDescProdutoPG
            // 
            this.colDescProdutoPG.DataPropertyName = "DESC_PRODUTO";
            this.colDescProdutoPG.HeaderText = "Desc. Prod.";
            this.colDescProdutoPG.Name = "colDescProdutoPG";
            this.colDescProdutoPG.ReadOnly = true;
            // 
            // colVLPagoPG
            // 
            this.colVLPagoPG.DataPropertyName = "VL_PAGO";
            this.colVLPagoPG.HeaderText = "Valor";
            this.colVLPagoPG.Name = "colVLPagoPG";
            this.colVLPagoPG.ReadOnly = true;
            this.colVLPagoPG.Width = 63;
            // 
            // colDTPagamentoPG
            // 
            this.colDTPagamentoPG.DataPropertyName = "DT_PAGAMENTO";
            this.colDTPagamentoPG.HeaderText = "Data";
            this.colDTPagamentoPG.Name = "colDTPagamentoPG";
            this.colDTPagamentoPG.ReadOnly = true;
            this.colDTPagamentoPG.Width = 61;
            // 
            // colIDPedidoProdutoPG
            // 
            this.colIDPedidoProdutoPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIDPedidoProdutoPG.DataPropertyName = "ID_PEDIDO_PRODUTO";
            this.colIDPedidoProdutoPG.HeaderText = "Ped. Prod.";
            this.colIDPedidoProdutoPG.Name = "colIDPedidoProdutoPG";
            this.colIDPedidoProdutoPG.ReadOnly = true;
            // 
            // colTipoPagamento
            // 
            this.colTipoPagamento.DataPropertyName = "DESCRICAO";
            this.colTipoPagamento.HeaderText = "Tipo";
            this.colTipoPagamento.Name = "colTipoPagamento";
            this.colTipoPagamento.ReadOnly = true;
            this.colTipoPagamento.Width = 59;
            // 
            // colIDPagamentoPG
            // 
            this.colIDPagamentoPG.DataPropertyName = "ID_PAGAMENTO";
            this.colIDPagamentoPG.HeaderText = "Pagamento";
            this.colIDPagamentoPG.Name = "colIDPagamentoPG";
            this.colIDPagamentoPG.ReadOnly = true;
            // 
            // colIDPedido
            // 
            this.colIDPedido.DataPropertyName = "ID_PEDIDO";
            this.colIDPedido.HeaderText = "Pedido";
            this.colIDPedido.Name = "colIDPedido";
            this.colIDPedido.ReadOnly = true;
            this.colIDPedido.Width = 74;
            // 
            // colDescPedido
            // 
            this.colDescPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescPedido.DataPropertyName = "DESC_PEDIDO";
            this.colDescPedido.HeaderText = "Desc. Pedido";
            this.colDescPedido.Name = "colDescPedido";
            this.colDescPedido.ReadOnly = true;
            // 
            // colIDPedidoProduto
            // 
            this.colIDPedidoProduto.DataPropertyName = "ID_PEDIDO_PRODUTO";
            this.colIDPedidoProduto.HeaderText = "Ped. Prod.";
            this.colIDPedidoProduto.Name = "colIDPedidoProduto";
            this.colIDPedidoProduto.ReadOnly = true;
            this.colIDPedidoProduto.Width = 94;
            // 
            // colDTAlteracao
            // 
            this.colDTAlteracao.DataPropertyName = "DT_ALTERACAO";
            this.colDTAlteracao.HeaderText = "Data";
            this.colDTAlteracao.Name = "colDTAlteracao";
            this.colDTAlteracao.ReadOnly = true;
            this.colDTAlteracao.Width = 61;
            // 
            // colQtProduto
            // 
            this.colQtProduto.DataPropertyName = "QT_PRODUTO";
            this.colQtProduto.HeaderText = "QT.";
            this.colQtProduto.Name = "colQtProduto";
            this.colQtProduto.ReadOnly = true;
            this.colQtProduto.Width = 53;
            // 
            // colDescProdPP
            // 
            this.colDescProdPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescProdPP.DataPropertyName = "DESC_PRODUTO";
            this.colDescProdPP.HeaderText = "Desc. Prod.";
            this.colDescProdPP.Name = "colDescProdPP";
            this.colDescProdPP.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "SITUACAO";
            this.colSituacao.HeaderText = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Width = 84;
            // 
            // frmConsultaBaldesVendidosXRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 503);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.groupBoxJCS2);
            this.Controls.Add(this.groupBoxJCS3);
            this.Controls.Add(this.groupBoxJCS4);
            this.Name = "frmConsultaBaldesVendidosXRegistrados";
            this.Text = "Consulta Baldes Registrados x Marcados";
            this.groupBoxJCS1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).EndInit();
            this.groupBoxJCS2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.groupBoxJCS3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcados)).EndInit();
            this.groupBoxJCS4.ResumeLayout(false);
            this.groupBoxJCS4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.DataGridViewJCS dgvVendidos;
        private Componentes.GroupBoxJCS groupBoxJCS2;
        private Componentes.DataGridViewJCS dgvPagos;
        private Componentes.GroupBoxJCS groupBoxJCS3;
        private Componentes.DataGridViewJCS dgvMarcados;
        private Componentes.dateTimePickerJCS dtpData;
        private Componentes.GroupBoxJCS groupBoxJCS4;
        private Componentes.CheckBoxJCS chkTodos;
        private Componentes.LabelJCS labelJCS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDBaldeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaldeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefoneB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColherR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPagamentoPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPedidoProdutoPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTPagamentoPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLPagoPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescProdutoPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPedidoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescProdPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
    }
}