namespace Caixa.Caixa
{
    partial class frmDespesa
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
            this.dtpData = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.lblDescricao = new Componentes.LabelJCS(this.components);
            this.txtValor = new Componentes.TextBoxJCS(this.components);
            this.lblValor = new Componentes.LabelJCS(this.components);
            this.btnSalvar = new Componentes.ButtonJCS(this.components);
            this.btnHistorico = new Componentes.ButtonJCS(this.components);
            this.cboTipoPagamento = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(87, 44);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 24);
            this.dtpData.TabIndex = 1;
            this.dtpData.Value = new System.DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(40, 51);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(40, 17);
            this.labelJCS1.TabIndex = 68;
            this.labelJCS1.Text = "Data:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(87, 106);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(206, 66);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TipoCampo = null;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(12, 109);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 17);
            this.lblDescricao.TabIndex = 66;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtValor.IconeKeyDown = null;
            this.txtValor.Location = new System.Drawing.Point(86, 14);
            this.txtValor.Name = "txtValor";
            this.txtValor.Preenchimento = null;
            this.txtValor.Size = new System.Drawing.Size(100, 24);
            this.txtValor.TabIndex = 0;
            this.txtValor.TipoCampo = "MONETARIO";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblValor.Location = new System.Drawing.Point(38, 17);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 17);
            this.lblValor.TabIndex = 67;
            this.lblValor.Text = "Valor:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::Caixa.Properties.Resources.icons8_salvar_e_fechar_20;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(192, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 56);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Gold;
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorico.Image = global::Caixa.Properties.Resources.icons8_documentos_do_produto_24;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 190);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(311, 24);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // cboTipoPagamento
            // 
            this.cboTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipoPagamento.FormattingEnabled = true;
            this.cboTipoPagamento.Items.AddRange(new object[] {
            "SELECIONE O PAGAMENTO AQUI",
            "DINHEIRO",
            "PIX/CARTÃO DEBITO"});
            this.cboTipoPagamento.Location = new System.Drawing.Point(87, 74);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(206, 23);
            this.cboTipoPagamento.TabIndex = 2;
            this.cboTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.CboTipoPagamento_SelectedIndexChanged);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(23, 77);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(57, 17);
            this.labelJCS2.TabIndex = 71;
            this.labelJCS2.Text = "Tipo PG:";
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 214);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.cboTipoPagamento);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnSalvar);
            this.MinimumSize = new System.Drawing.Size(327, 191);
            this.Name = "frmDespesa";
            this.Text = "Despesas fora do Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.dateTimePickerJCS dtpData;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS lblDescricao;
        private Componentes.TextBoxJCS txtValor;
        private Componentes.LabelJCS lblValor;
        private Componentes.ButtonJCS btnSalvar;
        private Componentes.ButtonJCS btnHistorico;
        private Componentes.ComboBoxJCS cboTipoPagamento;
        private Componentes.LabelJCS labelJCS2;
    }
}