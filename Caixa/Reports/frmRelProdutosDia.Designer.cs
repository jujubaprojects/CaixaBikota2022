namespace Caixa.Reports
{
    partial class frmRelProdutosDia
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
            this.buttonJCS1 = new Componentes.ButtonJCS(this.components);
            this.lblPeriodo = new Componentes.LabelJCS(this.components);
            this.txtProduto = new Componentes.TextBoxJCS(this.components);
            this.grpFiltros = new Componentes.GroupBoxJCS(this.components);
            this.lblCategoria = new Componentes.LabelJCS(this.components);
            this.dtpDataInicial = new Componentes.dateTimePickerJCS(this.components);
            this.txtCategoria = new Componentes.TextBoxJCS(this.components);
            this.lblProduto = new Componentes.LabelJCS(this.components);
            this.dtpDataFinal = new Componentes.dateTimePickerJCS(this.components);
            this.rbtOrderQtProd = new Componentes.RadioButtonJCScs(this.components);
            this.groupBoxJCS1 = new Componentes.GroupBoxJCS(this.components);
            this.cboCresDesc = new Componentes.ComboBoxJCS(this.components);
            this.rbtOrderCategoria = new Componentes.RadioButtonJCScs(this.components);
            this.rbtOrderProduto = new Componentes.RadioButtonJCScs(this.components);
            this.grpFiltros.SuspendLayout();
            this.groupBoxJCS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonJCS1
            // 
            this.buttonJCS1.BackColor = System.Drawing.Color.Gold;
            this.buttonJCS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.buttonJCS1.Location = new System.Drawing.Point(147, 314);
            this.buttonJCS1.Name = "buttonJCS1";
            this.buttonJCS1.Size = new System.Drawing.Size(150, 24);
            this.buttonJCS1.TabIndex = 0;
            this.buttonJCS1.Text = "Gerar Relatório";
            this.buttonJCS1.UseVisualStyleBackColor = false;
            this.buttonJCS1.Click += new System.EventHandler(this.ButtonJCS1_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.Location = new System.Drawing.Point(25, 30);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(58, 17);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Período:";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.IconeKeyDown = null;
            this.txtProduto.Location = new System.Drawing.Point(89, 53);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Preenchimento = null;
            this.txtProduto.Size = new System.Drawing.Size(306, 24);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.TipoCampo = null;
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.White;
            this.grpFiltros.Controls.Add(this.lblCategoria);
            this.grpFiltros.Controls.Add(this.dtpDataInicial);
            this.grpFiltros.Controls.Add(this.txtCategoria);
            this.grpFiltros.Controls.Add(this.lblPeriodo);
            this.grpFiltros.Controls.Add(this.lblProduto);
            this.grpFiltros.Controls.Add(this.txtProduto);
            this.grpFiltros.Controls.Add(this.dtpDataFinal);
            this.grpFiltros.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(405, 130);
            this.grpFiltros.TabIndex = 3;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(15, 86);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 17);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicial.Location = new System.Drawing.Point(89, 23);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(150, 24);
            this.dtpDataInicial.TabIndex = 5;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.IconeKeyDown = null;
            this.txtCategoria.Location = new System.Drawing.Point(89, 83);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Preenchimento = null;
            this.txtCategoria.Size = new System.Drawing.Size(306, 24);
            this.txtCategoria.TabIndex = 8;
            this.txtCategoria.TipoCampo = null;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(22, 56);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 17);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(245, 23);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(150, 24);
            this.dtpDataFinal.TabIndex = 6;
            // 
            // rbtOrderQtProd
            // 
            this.rbtOrderQtProd.AutoSize = true;
            this.rbtOrderQtProd.BackColor = System.Drawing.Color.White;
            this.rbtOrderQtProd.Checked = true;
            this.rbtOrderQtProd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtOrderQtProd.Location = new System.Drawing.Point(18, 23);
            this.rbtOrderQtProd.Name = "rbtOrderQtProd";
            this.rbtOrderQtProd.Size = new System.Drawing.Size(148, 21);
            this.rbtOrderQtProd.TabIndex = 4;
            this.rbtOrderQtProd.TabStop = true;
            this.rbtOrderQtProd.Text = "Quantidade Vendida";
            this.rbtOrderQtProd.UseVisualStyleBackColor = false;
            // 
            // groupBoxJCS1
            // 
            this.groupBoxJCS1.BackColor = System.Drawing.Color.White;
            this.groupBoxJCS1.Controls.Add(this.cboCresDesc);
            this.groupBoxJCS1.Controls.Add(this.rbtOrderCategoria);
            this.groupBoxJCS1.Controls.Add(this.rbtOrderProduto);
            this.groupBoxJCS1.Controls.Add(this.rbtOrderQtProd);
            this.groupBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxJCS1.Location = new System.Drawing.Point(12, 148);
            this.groupBoxJCS1.Name = "groupBoxJCS1";
            this.groupBoxJCS1.Size = new System.Drawing.Size(405, 92);
            this.groupBoxJCS1.TabIndex = 5;
            this.groupBoxJCS1.TabStop = false;
            this.groupBoxJCS1.Text = "Ordenação";
            // 
            // cboCresDesc
            // 
            this.cboCresDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCresDesc.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboCresDesc.FormattingEnabled = true;
            this.cboCresDesc.Items.AddRange(new object[] {
            "CRESCENTE",
            "DECRESCENTE"});
            this.cboCresDesc.Location = new System.Drawing.Point(245, 58);
            this.cboCresDesc.Name = "cboCresDesc";
            this.cboCresDesc.Size = new System.Drawing.Size(150, 23);
            this.cboCresDesc.TabIndex = 7;
            // 
            // rbtOrderCategoria
            // 
            this.rbtOrderCategoria.AutoSize = true;
            this.rbtOrderCategoria.BackColor = System.Drawing.Color.White;
            this.rbtOrderCategoria.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtOrderCategoria.Location = new System.Drawing.Point(18, 60);
            this.rbtOrderCategoria.Name = "rbtOrderCategoria";
            this.rbtOrderCategoria.Size = new System.Drawing.Size(142, 21);
            this.rbtOrderCategoria.TabIndex = 6;
            this.rbtOrderCategoria.Text = "Descrição Categoria";
            this.rbtOrderCategoria.UseVisualStyleBackColor = false;
            // 
            // rbtOrderProduto
            // 
            this.rbtOrderProduto.AutoSize = true;
            this.rbtOrderProduto.BackColor = System.Drawing.Color.White;
            this.rbtOrderProduto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rbtOrderProduto.Location = new System.Drawing.Point(254, 23);
            this.rbtOrderProduto.Name = "rbtOrderProduto";
            this.rbtOrderProduto.Size = new System.Drawing.Size(141, 21);
            this.rbtOrderProduto.TabIndex = 5;
            this.rbtOrderProduto.Text = "Descrição Produtos";
            this.rbtOrderProduto.UseVisualStyleBackColor = false;
            // 
            // frmRelProdutosDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 350);
            this.Controls.Add(this.groupBoxJCS1);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.buttonJCS1);
            this.Name = "frmRelProdutosDia";
            this.Text = "frmRelProdutosDia";
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.groupBoxJCS1.ResumeLayout(false);
            this.groupBoxJCS1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ButtonJCS buttonJCS1;
        private Componentes.LabelJCS lblPeriodo;
        private Componentes.TextBoxJCS txtProduto;
        private Componentes.GroupBoxJCS grpFiltros;
        private Componentes.LabelJCS lblCategoria;
        private Componentes.dateTimePickerJCS dtpDataInicial;
        private Componentes.TextBoxJCS txtCategoria;
        private Componentes.LabelJCS lblProduto;
        private Componentes.dateTimePickerJCS dtpDataFinal;
        private Componentes.RadioButtonJCScs rbtOrderQtProd;
        private Componentes.GroupBoxJCS groupBoxJCS1;
        private Componentes.RadioButtonJCScs rbtOrderCategoria;
        private Componentes.RadioButtonJCScs rbtOrderProduto;
        private Componentes.ComboBoxJCS cboCresDesc;
    }
}