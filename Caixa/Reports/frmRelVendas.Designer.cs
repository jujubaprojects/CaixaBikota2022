namespace Caixa.Reports
{
    partial class frmRelVendas
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
            this.dtpDataInicial = new Componentes.dateTimePickerJCS(this.components);
            this.dtpDataFinal = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.cboProdutoPai = new Componentes.ComboBoxJCS(this.components);
            this.cboProdutoFilho = new Componentes.ComboBoxJCS(this.components);
            this.btnGerarRelatorio = new Componentes.ButtonJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.txtDescricao = new Componentes.TextBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.cboSituacao = new Componentes.ComboBoxJCS(this.components);
            this.SuspendLayout();
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(52, 19);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(40, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Data:";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicial.Location = new System.Drawing.Point(100, 12);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(149, 24);
            this.dtpDataInicial.TabIndex = 1;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(276, 12);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(149, 24);
            this.dtpDataFinal.TabIndex = 2;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(255, 19);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(15, 17);
            this.labelJCS2.TabIndex = 3;
            this.labelJCS2.Text = "a";
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(31, 45);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(61, 17);
            this.labelJCS3.TabIndex = 4;
            this.labelJCS3.Text = "Produto:";
            // 
            // cboProdutoPai
            // 
            this.cboProdutoPai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoPai.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoPai.FormattingEnabled = true;
            this.cboProdutoPai.Location = new System.Drawing.Point(100, 42);
            this.cboProdutoPai.Name = "cboProdutoPai";
            this.cboProdutoPai.Size = new System.Drawing.Size(149, 23);
            this.cboProdutoPai.TabIndex = 6;
            this.cboProdutoPai.SelectedIndexChanged += new System.EventHandler(this.CboProdutoPai_SelectedIndexChanged);
            // 
            // cboProdutoFilho
            // 
            this.cboProdutoFilho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdutoFilho.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboProdutoFilho.FormattingEnabled = true;
            this.cboProdutoFilho.Location = new System.Drawing.Point(276, 42);
            this.cboProdutoFilho.Name = "cboProdutoFilho";
            this.cboProdutoFilho.Size = new System.Drawing.Size(149, 23);
            this.cboProdutoFilho.TabIndex = 7;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Gold;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnGerarRelatorio.Location = new System.Drawing.Point(150, 141);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGerarRelatorio.Size = new System.Drawing.Size(150, 24);
            this.btnGerarRelatorio.TabIndex = 15;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(25, 74);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(69, 17);
            this.labelJCS4.TabIndex = 16;
            this.labelJCS4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.IconeKeyDown = null;
            this.txtDescricao.Location = new System.Drawing.Point(100, 71);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Preenchimento = null;
            this.txtDescricao.Size = new System.Drawing.Size(325, 24);
            this.txtDescricao.TabIndex = 17;
            this.txtDescricao.TipoCampo = null;
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(30, 104);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(63, 17);
            this.labelJCS5.TabIndex = 18;
            this.labelJCS5.Text = "Situação:";
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "TODOS",
            "CANCELADO",
            "FILA",
            "FINALIZADO",
            "PAGO",
            "AGUARDANDO IMPRESSÃO"});
            this.cboSituacao.Location = new System.Drawing.Point(100, 101);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(149, 23);
            this.cboSituacao.TabIndex = 19;
            // 
            // frmRelVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 177);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.cboProdutoFilho);
            this.Controls.Add(this.cboProdutoPai);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.labelJCS1);
            this.MaximumSize = new System.Drawing.Size(460, 354);
            this.Name = "frmRelVendas";
            this.Text = "frmRelVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.dateTimePickerJCS dtpDataInicial;
        private Componentes.dateTimePickerJCS dtpDataFinal;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.ComboBoxJCS cboProdutoPai;
        private Componentes.ComboBoxJCS cboProdutoFilho;
        private Componentes.ButtonJCS btnGerarRelatorio;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.TextBoxJCS txtDescricao;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.ComboBoxJCS cboSituacao;
    }
}