namespace Caixa.Estoque
{
    partial class frmPedidoCompra
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
            this.dgvPedidoCompra = new Componentes.DataGridViewJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoCompra
            // 
            this.dgvPedidoCompra.AllowUserToAddRows = false;
            this.dgvPedidoCompra.AllowUserToDeleteRows = false;
            this.dgvPedidoCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidoCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescricao,
            this.colObs,
            this.colComprar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidoCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidoCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidoCompra.EnableHeadersVisualStyles = false;
            this.dgvPedidoCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidoCompra.Name = "dgvPedidoCompra";
            this.dgvPedidoCompra.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidoCompra.RowHeadersVisible = false;
            this.dgvPedidoCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoCompra.Size = new System.Drawing.Size(963, 450);
            this.dgvPedidoCompra.TabIndex = 0;
            this.dgvPedidoCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidoCompra_CellClick);
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
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescricao.DataPropertyName = "DESCRICAO";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 90;
            // 
            // colObs
            // 
            this.colObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObs.DataPropertyName = "OBSERVACAO";
            this.colObs.HeaderText = "Observação";
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            // 
            // colComprar
            // 
            this.colComprar.DataPropertyName = "PEDIDO_COMPRA";
            this.colComprar.HeaderText = "Comprar?";
            this.colComprar.Name = "colComprar";
            this.colComprar.ReadOnly = true;
            this.colComprar.Text = "";
            this.colComprar.Width = 71;
            // 
            // frmPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.dgvPedidoCompra);
            this.Name = "frmPedidoCompra";
            this.Text = "Produtos para adicionar no próximo Pedido De Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.DataGridViewJCS dgvPedidoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.DataGridViewButtonColumn colComprar;
    }
}