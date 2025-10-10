namespace Caixa.Estoque
{
    partial class frmImportXML
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
            this.txtXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXML = new System.Windows.Forms.Button();
            this.bntImportar = new Componentes.ButtonJCS(this.components);
            this.SuspendLayout();
            // 
            // txtXML
            // 
            this.txtXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXML.Location = new System.Drawing.Point(101, 10);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(406, 20);
            this.txtXML.TabIndex = 23;
            this.txtXML.Text = "Caminho da pasta do XML";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Diretório:";
            // 
            // btnXML
            // 
            this.btnXML.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXML.Image = global::Caixa.Properties.Resources.Folder;
            this.btnXML.Location = new System.Drawing.Point(513, 7);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(40, 23);
            this.btnXML.TabIndex = 22;
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // bntImportar
            // 
            this.bntImportar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntImportar.BackColor = System.Drawing.Color.Gold;
            this.bntImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntImportar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.bntImportar.Image = global::Caixa.Properties.Resources.icons8_caixa_de_seleção_marcada_96;
            this.bntImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntImportar.Location = new System.Drawing.Point(16, 38);
            this.bntImportar.Name = "bntImportar";
            this.bntImportar.Size = new System.Drawing.Size(537, 40);
            this.bntImportar.TabIndex = 54;
            this.bntImportar.Text = "Importar";
            this.bntImportar.UseVisualStyleBackColor = false;
            this.bntImportar.Click += new System.EventHandler(this.BntImportar_Click);
            // 
            // frmImportXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 88);
            this.Controls.Add(this.bntImportar);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.label1);
            this.Name = "frmImportXML";
            this.Text = "Importa XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Label label1;
        private Componentes.ButtonJCS bntImportar;
    }
}