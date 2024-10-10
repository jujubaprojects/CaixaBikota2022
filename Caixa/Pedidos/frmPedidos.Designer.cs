namespace Caixa
{
    partial class frmPedidos
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
            this.dtpDataPedido = new Componentes.dateTimePickerJCS(this.components);
            this.lblSituacaoPed = new Componentes.LabelJCS(this.components);
            this.dgvPedidos = new Componentes.DataGridViewJCS(this.components);
            this.colPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVlAberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colReimprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTodos = new Componentes.RadioButtonJCScs(this.components);
            this.rbtLevar = new Componentes.RadioButtonJCScs(this.components);
            this.rbtEntregas = new Componentes.RadioButtonJCScs(this.components);
            this.rbtMesas = new Componentes.RadioButtonJCScs(this.components);
            this.lblData = new Componentes.LabelJCS(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboSituacao = new Componentes.ComboBoxJCS(this.components);
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAtualizar = new Componentes.ButtonJCS(this.components);
            this.chkDataEspec = new Componentes.CheckBoxJCS(this.components);
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNovoPedido = new Componentes.ButtonJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.CustomFormat = "dd/MM/yyyy";
            this.dtpDataPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPedido.Location = new System.Drawing.Point(81, 47);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(128, 24);
            this.dtpDataPedido.TabIndex = 2;
            this.dtpDataPedido.ValueChanged += new System.EventHandler(this.DtpDataPedido_ValueChanged);
            // 
            // lblSituacaoPed
            // 
            this.lblSituacaoPed.AutoSize = true;
            this.lblSituacaoPed.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSituacaoPed.Location = new System.Drawing.Point(12, 21);
            this.lblSituacaoPed.Name = "lblSituacaoPed";
            this.lblSituacaoPed.Size = new System.Drawing.Size(63, 17);
            this.lblSituacaoPed.TabIndex = 0;
            this.lblSituacaoPed.Text = "Situação:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedido,
            this.colDescricao,
            this.colHora,
            this.colVlTotal,
            this.colVlPago,
            this.colVlAberto,
            this.colEditar,
            this.colPagar,
            this.colCancelar,
            this.colReimprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 104);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(912, 150);
            this.dgvPedidos.TabIndex = 4;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellClick);
            // 
            // colPedido
            // 
            this.colPedido.DataPropertyName = "ID";
            this.colPedido.HeaderText = "Pedido";
            this.colPedido.Name = "colPedido";
            this.colPedido.ReadOnly = true;
            this.colPedido.Visible = false;
            this.colPedido.Width = 74;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.FillWeight = 85.94815F;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.DataPropertyName = "HORA";
            this.colHora.FillWeight = 82.72487F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.Width = 62;
            // 
            // colVlTotal
            // 
            this.colVlTotal.DataPropertyName = "VL_TOTAL";
            this.colVlTotal.FillWeight = 138.2767F;
            this.colVlTotal.HeaderText = "Vl. Total";
            this.colVlTotal.Name = "colVlTotal";
            this.colVlTotal.ReadOnly = true;
            this.colVlTotal.Width = 80;
            // 
            // colVlPago
            // 
            this.colVlPago.DataPropertyName = "VL_PAGO";
            this.colVlPago.FillWeight = 162.0506F;
            this.colVlPago.HeaderText = "Vl. Pago";
            this.colVlPago.Name = "colVlPago";
            this.colVlPago.ReadOnly = true;
            this.colVlPago.Width = 80;
            // 
            // colVlAberto
            // 
            this.colVlAberto.DataPropertyName = "VL_ABERTO";
            this.colVlAberto.FillWeight = 206.1355F;
            this.colVlAberto.HeaderText = "Vl. Aberto";
            this.colVlAberto.Name = "colVlAberto";
            this.colVlAberto.ReadOnly = true;
            this.colVlAberto.Width = 92;
            // 
            // colEditar
            // 
            this.colEditar.FillWeight = 13.35693F;
            this.colEditar.HeaderText = "Add";
            this.colEditar.Image = global::Caixa.Properties.Resources.icons8_adicionar_20;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Width = 38;
            // 
            // colPagar
            // 
            this.colPagar.HeaderText = "Pagar";
            this.colPagar.Image = global::Caixa.Properties.Resources.icons8_iniciar_transferência_de_dinheiro_20;
            this.colPagar.Name = "colPagar";
            this.colPagar.ReadOnly = true;
            this.colPagar.Width = 47;
            // 
            // colCancelar
            // 
            this.colCancelar.FillWeight = 11.5073F;
            this.colCancelar.HeaderText = "Cancelar";
            this.colCancelar.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.colCancelar.Name = "colCancelar";
            this.colCancelar.ReadOnly = true;
            this.colCancelar.Width = 64;
            // 
            // colReimprimir
            // 
            this.colReimprimir.HeaderText = "Reimprimir";
            this.colReimprimir.Image = global::Caixa.Properties.Resources.impressora_20x20;
            this.colReimprimir.Name = "colReimprimir";
            this.colReimprimir.ReadOnly = true;
            this.colReimprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReimprimir.Width = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTodos);
            this.groupBox1.Controls.Add(this.rbtLevar);
            this.groupBox1.Controls.Add(this.rbtEntregas);
            this.groupBox1.Controls.Add(this.rbtMesas);
            this.groupBox1.Location = new System.Drawing.Point(260, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.BackColor = System.Drawing.Color.White;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtTodos.Location = new System.Drawing.Point(18, 19);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(62, 21);
            this.rbtTodos.TabIndex = 3;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = false;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.RbtTodos_CheckedChanged);
            // 
            // rbtLevar
            // 
            this.rbtLevar.AutoSize = true;
            this.rbtLevar.BackColor = System.Drawing.Color.White;
            this.rbtLevar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtLevar.Location = new System.Drawing.Point(205, 19);
            this.rbtLevar.Name = "rbtLevar";
            this.rbtLevar.Size = new System.Drawing.Size(58, 21);
            this.rbtLevar.TabIndex = 2;
            this.rbtLevar.Text = "Levar";
            this.rbtLevar.UseVisualStyleBackColor = false;
            this.rbtLevar.CheckedChanged += new System.EventHandler(this.RbtLevar_CheckedChanged);
            // 
            // rbtEntregas
            // 
            this.rbtEntregas.AutoSize = true;
            this.rbtEntregas.BackColor = System.Drawing.Color.White;
            this.rbtEntregas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtEntregas.Location = new System.Drawing.Point(296, 19);
            this.rbtEntregas.Name = "rbtEntregas";
            this.rbtEntregas.Size = new System.Drawing.Size(78, 21);
            this.rbtEntregas.TabIndex = 1;
            this.rbtEntregas.Text = "Entregas";
            this.rbtEntregas.UseVisualStyleBackColor = false;
            this.rbtEntregas.CheckedChanged += new System.EventHandler(this.RbtEntregas_CheckedChanged);
            // 
            // rbtMesas
            // 
            this.rbtMesas.AutoSize = true;
            this.rbtMesas.BackColor = System.Drawing.Color.White;
            this.rbtMesas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtMesas.Location = new System.Drawing.Point(112, 19);
            this.rbtMesas.Name = "rbtMesas";
            this.rbtMesas.Size = new System.Drawing.Size(64, 21);
            this.rbtMesas.TabIndex = 0;
            this.rbtMesas.Text = "Mesas";
            this.rbtMesas.UseVisualStyleBackColor = false;
            this.rbtMesas.CheckedChanged += new System.EventHandler(this.RbtMesas_CheckedChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(35, 54);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 13.35693F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 11.5073F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "Aberto",
            "Pago",
            "Cancelado"});
            this.cboSituacao.Location = new System.Drawing.Point(81, 18);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(173, 23);
            this.cboSituacao.TabIndex = 7;
            this.cboSituacao.SelectedIndexChanged += new System.EventHandler(this.CboSituacao_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.FillWeight = 13.35693F;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Width = 5;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Gold;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.Location = new System.Drawing.Point(646, 18);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(77, 53);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // chkDataEspec
            // 
            this.chkDataEspec.AutoSize = true;
            this.chkDataEspec.Checked = true;
            this.chkDataEspec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataEspec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkDataEspec.Location = new System.Drawing.Point(81, 77);
            this.chkDataEspec.Name = "chkDataEspec";
            this.chkDataEspec.Size = new System.Drawing.Size(180, 21);
            this.chkDataEspec.TabIndex = 10;
            this.chkDataEspec.Text = "Pedidos em Aberto antigo";
            this.chkDataEspec.UseVisualStyleBackColor = true;
            this.chkDataEspec.CheckedChanged += new System.EventHandler(this.ChkDataEspec_CheckedChanged);
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 11.5073F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Caixa.Properties.Resources.icons8_editar_24;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 5;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.FillWeight = 11.5073F;
            this.dataGridViewImageColumn5.HeaderText = "Cancelar";
            this.dataGridViewImageColumn5.Image = global::Caixa.Properties.Resources.icons8_cancelar_16;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Width = 64;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.FillWeight = 11.5073F;
            this.dataGridViewImageColumn6.HeaderText = "Cancelar";
            this.dataGridViewImageColumn6.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Width = 64;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "Reimprimir";
            this.dataGridViewImageColumn7.Image = global::Caixa.Properties.Resources.impressora_20x20;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn7.Width = 78;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.Gold;
            this.btnNovoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnNovoPedido.Image = global::Caixa.Properties.Resources.icons8_mais_48;
            this.btnNovoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoPedido.Location = new System.Drawing.Point(748, 18);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(152, 53);
            this.btnNovoPedido.TabIndex = 8;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.BtnNovoPedido_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.chkDataEspec);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.lblSituacaoPed);
            this.KeyPreview = true;
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidos_KeyDown);
            this.MouseEnter += new System.EventHandler(this.FrmPedidos_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.dateTimePickerJCS dtpDataPedido;
        private Componentes.LabelJCS lblSituacaoPed;
        private Componentes.DataGridViewJCS dgvPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private Componentes.RadioButtonJCScs rbtEntregas;
        private Componentes.RadioButtonJCScs rbtMesas;
        private Componentes.LabelJCS lblData;
        private Componentes.RadioButtonJCScs rbtLevar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Componentes.ComboBoxJCS cboSituacao;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private Componentes.ButtonJCS btnNovoPedido;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private Componentes.ButtonJCS btnAtualizar;
        private Componentes.RadioButtonJCScs rbtTodos;
        private Componentes.CheckBoxJCS chkDataEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVlAberto;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colPagar;
        private System.Windows.Forms.DataGridViewImageColumn colCancelar;
        private System.Windows.Forms.DataGridViewImageColumn colReimprimir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
    }
}