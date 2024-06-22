namespace Caixa
{
    partial class frmPagarNota
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizarPagamento = new Componentes.ButtonJCS(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkValorHaver = new Componentes.CheckBoxJCS(this.components);
            this.cboAnotar = new Componentes.ComboBoxJCS(this.components);
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.cboTipoPagamento = new Componentes.ComboBoxJCS(this.components);
            this.lblTroco = new Componentes.LabelJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.txtVlRecebido = new Componentes.TextBoxJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtVlNota = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalizarPagamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 30);
            this.panel1.TabIndex = 7;
            // 
            // btnFinalizarPagamento
            // 
            this.btnFinalizarPagamento.BackColor = System.Drawing.Color.Gold;
            this.btnFinalizarPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarPagamento.Image = global::Caixa.Properties.Resources.icons8_marcador_duplo_48;
            this.btnFinalizarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarPagamento.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizarPagamento.Name = "btnFinalizarPagamento";
            this.btnFinalizarPagamento.Size = new System.Drawing.Size(453, 30);
            this.btnFinalizarPagamento.TabIndex = 4;
            this.btnFinalizarPagamento.Text = "Finalizar Pagamento";
            this.btnFinalizarPagamento.UseVisualStyleBackColor = false;
            this.btnFinalizarPagamento.Click += new System.EventHandler(this.BtnFinalizarPagamento_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkValorHaver);
            this.panel2.Controls.Add(this.cboAnotar);
            this.panel2.Controls.Add(this.txtProduto);
            this.panel2.Controls.Add(this.cboTipoPagamento);
            this.panel2.Controls.Add(this.lblTroco);
            this.panel2.Controls.Add(this.labelJCS6);
            this.panel2.Controls.Add(this.txtVlRecebido);
            this.panel2.Controls.Add(this.labelJCS4);
            this.panel2.Controls.Add(this.txtVlNota);
            this.panel2.Controls.Add(this.labelJCS3);
            this.panel2.Controls.Add(this.labelJCS1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 141);
            this.panel2.TabIndex = 8;
            // 
            // chkValorHaver
            // 
            this.chkValorHaver.AutoSize = true;
            this.chkValorHaver.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkValorHaver.Location = new System.Drawing.Point(216, 43);
            this.chkValorHaver.Name = "chkValorHaver";
            this.chkValorHaver.Size = new System.Drawing.Size(195, 21);
            this.chkValorHaver.TabIndex = 4;
            this.chkValorHaver.Text = "Deixar valor a mais em haver";
            this.chkValorHaver.UseVisualStyleBackColor = true;
            this.chkValorHaver.CheckedChanged += new System.EventHandler(this.ChkValorHaver_CheckedChanged);
            // 
            // cboAnotar
            // 
            this.cboAnotar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnotar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboAnotar.FormattingEnabled = true;
            this.cboAnotar.Location = new System.Drawing.Point(216, 12);
            this.cboAnotar.Name = "cboAnotar";
            this.cboAnotar.Size = new System.Drawing.Size(225, 23);
            this.cboAnotar.TabIndex = 2;
            this.cboAnotar.SelectedIndexChanged += new System.EventHandler(this.CboAnotar_SelectedIndexChanged);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.IconeKeyDown = null;
            this.txtProduto.Location = new System.Drawing.Point(101, 12);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(109, 24);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TipoCampo = "STRING";
            // 
            // cboTipoPagamento
            // 
            this.cboTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipoPagamento.FormattingEnabled = true;
            this.cboTipoPagamento.Items.AddRange(new object[] {
            "DINHEIRO",
            "PIX",
            "DESCONTO"});
            this.cboTipoPagamento.Location = new System.Drawing.Point(101, 72);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(109, 23);
            this.cboTipoPagamento.TabIndex = 5;
            this.cboTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.CboTipoPagamento_SelectedIndexChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTroco.ForeColor = System.Drawing.Color.Red;
            this.lblTroco.Location = new System.Drawing.Point(220, 102);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(138, 24);
            this.lblTroco.TabIndex = 24;
            this.lblTroco.Text = "Troco: R$ 00.00";
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(29, 75);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(66, 17);
            this.labelJCS6.TabIndex = 21;
            this.labelJCS6.Text = "Tipo Pag.:";
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.BackColor = System.Drawing.Color.White;
            this.txtVlRecebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlRecebido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlRecebido.IconeKeyDown = null;
            this.txtVlRecebido.Location = new System.Drawing.Point(101, 102);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Preenchimento = null;
            this.txtVlRecebido.Size = new System.Drawing.Size(109, 24);
            this.txtVlRecebido.TabIndex = 6;
            this.txtVlRecebido.TipoCampo = "DOUBLE";
            this.txtVlRecebido.TextChanged += new System.EventHandler(this.TxtVlRecebido_TextChanged);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(10, 105);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(85, 17);
            this.labelJCS4.TabIndex = 17;
            this.labelJCS4.Text = "Vl. Recebido:";
            // 
            // txtVlNota
            // 
            this.txtVlNota.BackColor = System.Drawing.Color.White;
            this.txtVlNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlNota.Enabled = false;
            this.txtVlNota.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlNota.IconeKeyDown = null;
            this.txtVlNota.Location = new System.Drawing.Point(101, 42);
            this.txtVlNota.Name = "txtVlNota";
            this.txtVlNota.Preenchimento = null;
            this.txtVlNota.Size = new System.Drawing.Size(109, 24);
            this.txtVlNota.TabIndex = 3;
            this.txtVlNota.Text = "0";
            this.txtVlNota.TipoCampo = null;
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(36, 45);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(59, 17);
            this.labelJCS3.TabIndex = 15;
            this.labelJCS3.Text = "Vl. Nota:";
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(34, 19);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 6;
            this.labelJCS1.Text = "Produto:";
            // 
            // frmPagarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 171);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmPagarNota";
            this.Text = "Pagar Nota";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidoRapido_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPedidoRapido_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Componentes.ButtonJCS btnFinalizarPagamento;
        private System.Windows.Forms.Panel panel2;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtVlRecebido;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtVlNota;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.LabelJCS lblTroco;
        private Componentes.ComboBoxJCS cboTipoPagamento;
        private Componentes.TextBoxJCS txtProduto;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.ComboBoxJCS cboAnotar;
        private Componentes.CheckBoxJCS chkValorHaver;
    }
}