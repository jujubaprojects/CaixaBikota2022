namespace Caixa.Estoque
{
    partial class frmSubEstoque
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
            this.txtEstoque = new Componentes.TextBoxJCS(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.rbtPotes = new Componentes.RadioButtonJCScs(this.components);
            this.rbtProdutos = new Componentes.RadioButtonJCScs(this.components);
            this.btnEstoque = new Componentes.ButtonJCS(this.components);
            this.txtQt = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.btnSubtrair = new Componentes.ButtonJCS(this.components);
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 82);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(61, 17);
            this.labelJCS1.TabIndex = 0;
            this.labelJCS1.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.White;
            this.txtEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEstoque.IconeKeyDown = null;
            this.txtEstoque.Location = new System.Drawing.Point(79, 79);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Preenchimento = null;
            this.txtEstoque.Size = new System.Drawing.Size(216, 24);
            this.txtEstoque.TabIndex = 1;
            this.txtEstoque.TipoCampo = null;
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.rbtProdutos);
            this.groupBoxJCS1.Controls.Add(this.rbtPotes);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(439, 58);
            this.groupBoxJCS1.TabIndex = 4;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Tipo de Estoque";
            // 
            // rbtPotes
            // 
            this.rbtPotes.AutoSize = true;
            this.rbtPotes.BackColor = System.Drawing.Color.White;
            this.rbtPotes.Checked = true;
            this.rbtPotes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtPotes.Location = new System.Drawing.Point(6, 23);
            this.rbtPotes.Name = "rbtPotes";
            this.rbtPotes.Size = new System.Drawing.Size(132, 21);
            this.rbtPotes.TabIndex = 0;
            this.rbtPotes.TabStop = true;
            this.rbtPotes.Text = "Potes de Sorvetes";
            this.rbtPotes.UseVisualStyleBackColor = false;
            this.rbtPotes.CheckedChanged += new System.EventHandler(this.RbtPotes_CheckedChanged);
            // 
            // rbtProdutos
            // 
            this.rbtProdutos.AutoSize = true;
            this.rbtProdutos.BackColor = System.Drawing.Color.White;
            this.rbtProdutos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtProdutos.Location = new System.Drawing.Point(264, 23);
            this.rbtProdutos.Name = "rbtProdutos";
            this.rbtProdutos.Size = new System.Drawing.Size(169, 21);
            this.rbtProdutos.TabIndex = 1;
            this.rbtProdutos.Text = "Produtos/Matéria Prima";
            this.rbtProdutos.UseVisualStyleBackColor = false;
            this.rbtProdutos.CheckedChanged += new System.EventHandler(this.RbtProdutos_CheckedChanged);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Gold;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnEstoque.Location = new System.Drawing.Point(301, 77);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(150, 24);
            this.btnEstoque.TabIndex = 5;
            this.btnEstoque.Text = "Buscar Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // txtQt
            // 
            this.txtQt.BackColor = System.Drawing.Color.White;
            this.txtQt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQt.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtQt.IconeKeyDown = null;
            this.txtQt.Location = new System.Drawing.Point(79, 109);
            this.txtQt.Name = "txtQt";
            this.txtQt.Preenchimento = null;
            this.txtQt.Size = new System.Drawing.Size(130, 24);
            this.txtQt.TabIndex = 6;
            this.txtQt.TipoCampo = "INTEIRO";
            this.txtQt.Leave += new System.EventHandler(this.TxtQt_Leave);
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(12, 112);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(58, 17);
            this.labelJCS2.TabIndex = 7;
            this.labelJCS2.Text = "QT. Sub:";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Gold;
            this.btnSubtrair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubtrair.Location = new System.Drawing.Point(0, 159);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(468, 37);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "Subtrair Estoque";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // frmSubEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(468, 196);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.labelJCS1);
            this.MaximumSize = new System.Drawing.Size(484, 235);
            this.MinimumSize = new System.Drawing.Size(484, 235);
            this.Name = "frmSubEstoque";
            this.Text = "Formulário para subtrarir estoques";
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtEstoque;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.RadioButtonJCScs rbtProdutos;
        private Componentes.RadioButtonJCScs rbtPotes;
        private Componentes.ButtonJCS btnEstoque;
        private Componentes.TextBoxJCS txtQt;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.ButtonJCS btnSubtrair;
    }
}