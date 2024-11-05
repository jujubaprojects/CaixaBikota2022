namespace Caixa.Reports
{
    partial class frmRelPedidoFornecedor
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
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.btnRelatorio = new Componentes.ButtonJCS(this.components);
            this.cboFornecedor = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.btnRelatorio);
            this.groupBoxJCS1.Controls.Add(this.cboFornecedor);
            this.groupBoxJCS1.Controls.Add(this.labelJCS1);
            this.groupBoxJCS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(579, 85);
            this.groupBoxJCS1.TabIndex = 1;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Filtro";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Gold;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 46);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(573, 36);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Gerar Relatório de Compra";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(98, 17);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(469, 23);
            this.cboFornecedor.TabIndex = 1;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 20);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(80, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Fornecedor:";
            // 
            // frmRelPedidoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 89);
            this.Controls.Add(this.groupBoxJCS1);
            this.Name = "frmRelPedidoFornecedor";
            this.Text = "Pedido de Compra Simples para os Fornecedores";
            this.Load += new System.EventHandler(this.FrmRelPedidoFornecedor_Load);
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.ButtonJCS btnRelatorio;
        private Componentes.ComboBoxJCS cboFornecedor;
        private Componentes.LabelJCS labelJCS1;
    }
}