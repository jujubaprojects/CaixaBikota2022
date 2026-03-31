namespace Caixa.RH
{
    partial class frmCalculoHoras
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
            this.btnCalcular = new Componentes.ButtonJCS(this.components);
            this.btnPlanilha = new System.Windows.Forms.Button();
            this.txtDiretorioPlanilha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gold;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Image = global::Caixa.Properties.Resources.icons8_caixa_de_seleção_marcada_48;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(16, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(472, 55);
            this.btnCalcular.TabIndex = 64;
            this.btnCalcular.Text = "Calcular Horas";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPlanilha
            // 
            this.btnPlanilha.Image = global::Caixa.Properties.Resources.Folder;
            this.btnPlanilha.Location = new System.Drawing.Point(448, 6);
            this.btnPlanilha.Name = "btnPlanilha";
            this.btnPlanilha.Size = new System.Drawing.Size(40, 23);
            this.btnPlanilha.TabIndex = 62;
            this.btnPlanilha.UseVisualStyleBackColor = true;
            this.btnPlanilha.Click += new System.EventHandler(this.btnPlanilha_Click);
            // 
            // txtDiretorioPlanilha
            // 
            this.txtDiretorioPlanilha.Enabled = false;
            this.txtDiretorioPlanilha.Location = new System.Drawing.Point(101, 9);
            this.txtDiretorioPlanilha.Name = "txtDiretorioPlanilha";
            this.txtDiretorioPlanilha.Size = new System.Drawing.Size(341, 20);
            this.txtDiretorioPlanilha.TabIndex = 63;
            this.txtDiretorioPlanilha.Text = "Escolha o arquivo da planilha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Diretório:";
            // 
            // frmCalculoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 102);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnPlanilha);
            this.Controls.Add(this.txtDiretorioPlanilha);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculoHoras";
            this.Text = "frmCalculoHoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.ButtonJCS btnCalcular;
        private System.Windows.Forms.Button btnPlanilha;
        private System.Windows.Forms.TextBox txtDiretorioPlanilha;
        private System.Windows.Forms.Label label1;
    }
}