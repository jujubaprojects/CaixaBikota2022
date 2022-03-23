namespace Caixa
{
    partial class frmPagarDividido
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
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtVlTotal = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.txtQtDivisao = new Componentes.TextBoxJCS(this.components);
            this.txtVlRecebido = new Componentes.TextBoxJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.btnCancelar = new Componentes.ButtonJCS(this.components);
            this.btnSalvar = new Componentes.ButtonJCS(this.components);
            this.SuspendLayout();
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(38, 15);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(74, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Valor Total:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.BackColor = System.Drawing.Color.White;
            this.txtVlTotal.Enabled = false;
            this.txtVlTotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlTotal.IconeKeyDown = null;
            this.txtVlTotal.Location = new System.Drawing.Point(118, 12);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.Preenchimento = null;
            this.txtVlTotal.Size = new System.Drawing.Size(130, 24);
            this.txtVlTotal.TabIndex = 1;
            this.txtVlTotal.TipoCampo = null;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(22, 48);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(90, 17);
            this.labelJCS2.TabIndex = 2;
            this.labelJCS2.Text = "Valor Manual:";
            // 
            // txtQtDivisao
            // 
            this.txtQtDivisao.BackColor = System.Drawing.Color.White;
            this.txtQtDivisao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtDivisao.IconeKeyDown = null;
            this.txtQtDivisao.Location = new System.Drawing.Point(118, 75);
            this.txtQtDivisao.Name = "txtQtDivisao";
            this.txtQtDivisao.Preenchimento = null;
            this.txtQtDivisao.Size = new System.Drawing.Size(130, 24);
            this.txtQtDivisao.TabIndex = 3;
            this.txtQtDivisao.TipoCampo = "INTEIRO";
            this.txtQtDivisao.TextChanged += new System.EventHandler(this.TxtQtDivisao_TextChanged);
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.BackColor = System.Drawing.Color.White;
            this.txtVlRecebido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtVlRecebido.IconeKeyDown = null;
            this.txtVlRecebido.Location = new System.Drawing.Point(118, 45);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Preenchimento = null;
            this.txtVlRecebido.Size = new System.Drawing.Size(130, 24);
            this.txtVlRecebido.TabIndex = 4;
            this.txtVlRecebido.TipoCampo = "DOUBLE";
            this.txtVlRecebido.TextChanged += new System.EventHandler(this.TxtVlRecebido_TextChanged);
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(27, 78);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(85, 17);
            this.labelJCS3.TabIndex = 5;
            this.labelJCS3.Text = "Dividido por:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::Caixa.Properties.Resources.icons8_cancelar_20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(238, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(12, 105);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(238, 24);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmPagarDividido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 175);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.txtVlRecebido);
            this.Controls.Add(this.txtQtDivisao);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtVlTotal);
            this.Controls.Add(this.labelJCS1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(278, 309);
            this.Name = "frmPagarDividido";
            this.Text = "frmPagarDividido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPagarDividido_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagarDividido_KeyDown);
            this.MouseEnter += new System.EventHandler(this.FrmPagarDividido_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtVlTotal;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.TextBoxJCS txtQtDivisao;
        private Componentes.TextBoxJCS txtVlRecebido;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.ButtonJCS btnSalvar;
        private Componentes.ButtonJCS btnCancelar;
    }
}