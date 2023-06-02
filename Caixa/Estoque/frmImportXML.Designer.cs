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
            this.btnExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXML = new System.Windows.Forms.Button();
            this.bntImportar = new Componentes.ButtonJCS(this.components);
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.Image = global::Caixa.Properties.Resources.Folder;
            this.btnExcel.Location = new System.Drawing.Point(513, 39);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 23);
            this.btnExcel.TabIndex = 28;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Destino XLS:";
            // 
            // txtExcel
            // 
            this.txtExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcel.Location = new System.Drawing.Point(133, 41);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(374, 20);
            this.txtExcel.TabIndex = 24;
            this.txtExcel.Text = "C:\\Users\\Jujuba\\OneDrive\\Documentos\\Teste XML";
            // 
            // txtXML
            // 
            this.txtXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXML.Location = new System.Drawing.Point(133, 12);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(376, 20);
            this.txtXML.TabIndex = 23;
            this.txtXML.Text = "C:\\Users\\Jujuba\\Downloads";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Origem XML:";
            // 
            // btnXML
            // 
            this.btnXML.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXML.Image = global::Caixa.Properties.Resources.Folder;
            this.btnXML.Location = new System.Drawing.Point(513, 10);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(40, 23);
            this.btnXML.TabIndex = 22;
            this.btnXML.UseVisualStyleBackColor = true;
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
            this.bntImportar.Location = new System.Drawing.Point(16, 73);
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
            this.ClientSize = new System.Drawing.Size(565, 125);
            this.Controls.Add(this.bntImportar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.label1);
            this.Name = "frmImportXML";
            this.Text = "Importa XML/Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Label label1;
        private Componentes.ButtonJCS bntImportar;
    }
}