namespace Caixa.Reports
{
    partial class frmRelVendasDia
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
            this.btnGerarRelatorio = new Componentes.ButtonJCS(this.components);
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
            this.dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicial.Location = new System.Drawing.Point(100, 12);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(149, 24);
            this.dtpDataInicial.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Gold;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnGerarRelatorio.Location = new System.Drawing.Point(100, 42);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGerarRelatorio.Size = new System.Drawing.Size(150, 24);
            this.btnGerarRelatorio.TabIndex = 15;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // frmRelVendasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 146);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.labelJCS1);
            this.MaximumSize = new System.Drawing.Size(460, 354);
            this.Name = "frmRelVendasDia";
            this.Text = "frmRelVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.dateTimePickerJCS dtpDataInicial;
        private Componentes.ButtonJCS btnGerarRelatorio;
    }
}