namespace Caixa
{
    partial class frmTesteAPI
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
            this.txtTest = new Componentes.TextBoxJCS(this.components);
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.BackColor = System.Drawing.Color.White;
            this.txtTest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTest.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtTest.IconeKeyDown = null;
            this.txtTest.Location = new System.Drawing.Point(12, 61);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Preenchimento = null;
            this.txtTest.Size = new System.Drawing.Size(776, 377);
            this.txtTest.TabIndex = 0;
            this.txtTest.TipoCampo = null;
            // 
            // frmTesteAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTest);
            this.Name = "frmTesteAPI";
            this.Text = "frmTesteAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxJCS txtTest;
    }
}