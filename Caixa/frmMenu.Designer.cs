namespace Caixa
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosAbertoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baldesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueBaldesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.subtrairEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoDeNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkarProdutoFinalXEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasFiscaisEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosParaComprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueDePotesDeSorvetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorvetes10lEmFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPedidosDetalhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFCupomManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem1,
            this.caixaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1300, 72);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip2";
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem1,
            this.pedidosAbertoToolStripMenuItem1,
            this.baldesToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.fornecedorToolStripMenuItem,
            this.estoqueBaldesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.subtrairEstoqueToolStripMenuItem,
            this.nFCupomManualToolStripMenuItem});
            this.pedidosToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_contabilidade_48;
            this.pedidosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(114, 68);
            this.pedidosToolStripMenuItem1.Text = "Cadastro";
            // 
            // novoPedidoToolStripMenuItem1
            // 
            this.novoPedidoToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_adicionar_regra_24;
            this.novoPedidoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novoPedidoToolStripMenuItem1.Name = "novoPedidoToolStripMenuItem1";
            this.novoPedidoToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.novoPedidoToolStripMenuItem1.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem1.Click += new System.EventHandler(this.NovoPedidoToolStripMenuItem_Click);
            // 
            // pedidosAbertoToolStripMenuItem1
            // 
            this.pedidosAbertoToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_termos_e_condições_24;
            this.pedidosAbertoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidosAbertoToolStripMenuItem1.Name = "pedidosAbertoToolStripMenuItem1";
            this.pedidosAbertoToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.pedidosAbertoToolStripMenuItem1.Text = "Pedidos Aberto";
            this.pedidosAbertoToolStripMenuItem1.Click += new System.EventHandler(this.PedidosAbertoToolStripMenuItem_Click);
            // 
            // baldesToolStripMenuItem
            // 
            this.baldesToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_documentos_do_produto_24;
            this.baldesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.baldesToolStripMenuItem.Name = "baldesToolStripMenuItem";
            this.baldesToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.baldesToolStripMenuItem.Text = "Baldes";
            this.baldesToolStripMenuItem.Click += new System.EventHandler(this.BaldesToolStripMenuItem_Click_1);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.EstoqueToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.ProdutosToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.FornecedorToolStripMenuItem_Click);
            // 
            // estoqueBaldesToolStripMenuItem
            // 
            this.estoqueBaldesToolStripMenuItem.Name = "estoqueBaldesToolStripMenuItem";
            this.estoqueBaldesToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.estoqueBaldesToolStripMenuItem.Text = "Estoque Baldes";
            this.estoqueBaldesToolStripMenuItem.Click += new System.EventHandler(this.EstoqueBaldesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // subtrairEstoqueToolStripMenuItem
            // 
            this.subtrairEstoqueToolStripMenuItem.Name = "subtrairEstoqueToolStripMenuItem";
            this.subtrairEstoqueToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.subtrairEstoqueToolStripMenuItem.Text = "Subtrair Estoque";
            this.subtrairEstoqueToolStripMenuItem.Click += new System.EventHandler(this.SubtrairEstoqueToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recebimentoRápidoToolStripMenuItem,
            this.retiradaCaixaToolStripMenuItem,
            this.recebimentoDeNotaToolStripMenuItem,
            this.consultarNotasClientesToolStripMenuItem});
            this.caixaToolStripMenuItem.Image = global::Caixa.Properties.Resources.black_and_white_credit_cards;
            this.caixaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(112, 68);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // recebimentoRápidoToolStripMenuItem
            // 
            this.recebimentoRápidoToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_doar_24;
            this.recebimentoRápidoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recebimentoRápidoToolStripMenuItem.Name = "recebimentoRápidoToolStripMenuItem";
            this.recebimentoRápidoToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.recebimentoRápidoToolStripMenuItem.Text = "Recebimento Rápido";
            this.recebimentoRápidoToolStripMenuItem.Click += new System.EventHandler(this.RecebimentoRápidoToolStripMenuItem_Click);
            // 
            // retiradaCaixaToolStripMenuItem
            // 
            this.retiradaCaixaToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_iniciar_transferência_de_dinheiro_20;
            this.retiradaCaixaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retiradaCaixaToolStripMenuItem.Name = "retiradaCaixaToolStripMenuItem";
            this.retiradaCaixaToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.retiradaCaixaToolStripMenuItem.Text = "Retirada do Caixa";
            this.retiradaCaixaToolStripMenuItem.Click += new System.EventHandler(this.RetiradaCaixaToolStripMenuItem_Click);
            // 
            // recebimentoDeNotaToolStripMenuItem
            // 
            this.recebimentoDeNotaToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_títulos_48;
            this.recebimentoDeNotaToolStripMenuItem.Name = "recebimentoDeNotaToolStripMenuItem";
            this.recebimentoDeNotaToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.recebimentoDeNotaToolStripMenuItem.Text = "Recebimento de Nota";
            this.recebimentoDeNotaToolStripMenuItem.Click += new System.EventHandler(this.RecebimentoDeNotaToolStripMenuItem_Click_1);
            // 
            // consultarNotasClientesToolStripMenuItem
            // 
            this.consultarNotasClientesToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_documentos_do_produto_24;
            this.consultarNotasClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarNotasClientesToolStripMenuItem.Name = "consultarNotasClientesToolStripMenuItem";
            this.consultarNotasClientesToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.consultarNotasClientesToolStripMenuItem.Text = "Consultar Notas de Clientes";
            this.consultarNotasClientesToolStripMenuItem.Click += new System.EventHandler(this.ConsultarNotasClientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem,
            this.linkarProdutoFinalXEstoqueToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importarXMLToolStripMenuItem,
            this.notasFiscaisEntradasToolStripMenuItem,
            this.produtosParaComprarToolStripMenuItem,
            this.estoqueDePotesDeSorvetesToolStripMenuItem,
            this.sorvetes10lEmFaltaToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(61, 68);
            this.produtosToolStripMenuItem.Text = "Estoque";
            // 
            // linkarEstoqueXProdutoXFornecedorToolStripMenuItem
            // 
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem.Name = "linkarEstoqueXProdutoXFornecedorToolStripMenuItem";
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem.Text = "Linkar Estoque x Produto NFe x Fornecedor";
            this.linkarEstoqueXProdutoXFornecedorToolStripMenuItem.Click += new System.EventHandler(this.LinkarEstoqueXProdutoXFornecedorToolStripMenuItem_Click);
            // 
            // linkarProdutoFinalXEstoqueToolStripMenuItem
            // 
            this.linkarProdutoFinalXEstoqueToolStripMenuItem.Name = "linkarProdutoFinalXEstoqueToolStripMenuItem";
            this.linkarProdutoFinalXEstoqueToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.linkarProdutoFinalXEstoqueToolStripMenuItem.Text = "Linkar Produto Final x Estoque";
            this.linkarProdutoFinalXEstoqueToolStripMenuItem.Click += new System.EventHandler(this.LinkarProdutoFinalXEstoqueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(299, 6);
            // 
            // importarXMLToolStripMenuItem
            // 
            this.importarXMLToolStripMenuItem.Name = "importarXMLToolStripMenuItem";
            this.importarXMLToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.importarXMLToolStripMenuItem.Text = "Importar XML";
            this.importarXMLToolStripMenuItem.Click += new System.EventHandler(this.ImportarXMLToolStripMenuItem_Click);
            // 
            // notasFiscaisEntradasToolStripMenuItem
            // 
            this.notasFiscaisEntradasToolStripMenuItem.Name = "notasFiscaisEntradasToolStripMenuItem";
            this.notasFiscaisEntradasToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.notasFiscaisEntradasToolStripMenuItem.Text = "Notas Fiscais Entradas";
            this.notasFiscaisEntradasToolStripMenuItem.Click += new System.EventHandler(this.NotasFiscaisEntradasToolStripMenuItem_Click);
            // 
            // produtosParaComprarToolStripMenuItem
            // 
            this.produtosParaComprarToolStripMenuItem.Name = "produtosParaComprarToolStripMenuItem";
            this.produtosParaComprarToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.produtosParaComprarToolStripMenuItem.Text = "Produtos para Comprar";
            this.produtosParaComprarToolStripMenuItem.Click += new System.EventHandler(this.ProdutosParaComprarToolStripMenuItem_Click);
            // 
            // estoqueDePotesDeSorvetesToolStripMenuItem
            // 
            this.estoqueDePotesDeSorvetesToolStripMenuItem.Name = "estoqueDePotesDeSorvetesToolStripMenuItem";
            this.estoqueDePotesDeSorvetesToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.estoqueDePotesDeSorvetesToolStripMenuItem.Text = "Estoque de Potes de Sorvetes";
            this.estoqueDePotesDeSorvetesToolStripMenuItem.Click += new System.EventHandler(this.EstoqueDePotesDeSorvetesToolStripMenuItem_Click);
            // 
            // sorvetes10lEmFaltaToolStripMenuItem
            // 
            this.sorvetes10lEmFaltaToolStripMenuItem.Name = "sorvetes10lEmFaltaToolStripMenuItem";
            this.sorvetes10lEmFaltaToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.sorvetes10lEmFaltaToolStripMenuItem.Text = "Sorvetes 10l Em Falta";
            this.sorvetes10lEmFaltaToolStripMenuItem.Click += new System.EventHandler(this.Sorvetes10lEmFaltaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 68);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasPedidosDetalhadoToolStripMenuItem,
            this.valorPorDiaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasPedidosDetalhadoToolStripMenuItem
            // 
            this.vendasPedidosDetalhadoToolStripMenuItem.Name = "vendasPedidosDetalhadoToolStripMenuItem";
            this.vendasPedidosDetalhadoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vendasPedidosDetalhadoToolStripMenuItem.Text = "Pedidos Detalhado";
            this.vendasPedidosDetalhadoToolStripMenuItem.Click += new System.EventHandler(this.VendasPedidosDetalhadoToolStripMenuItem_Click);
            // 
            // valorPorDiaToolStripMenuItem
            // 
            this.valorPorDiaToolStripMenuItem.Name = "valorPorDiaToolStripMenuItem";
            this.valorPorDiaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.valorPorDiaToolStripMenuItem.Text = "Valor Dia";
            this.valorPorDiaToolStripMenuItem.Click += new System.EventHandler(this.ValorPorDiaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.AutoSize = false;
            this.sairToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_sair_48;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(150, 52);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // nFCupomManualToolStripMenuItem
            // 
            this.nFCupomManualToolStripMenuItem.Name = "nFCupomManualToolStripMenuItem";
            this.nFCupomManualToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.nFCupomManualToolStripMenuItem.Text = "NF/Cupom Manual";
            this.nFCupomManualToolStripMenuItem.Click += new System.EventHandler(this.NFCupomManualToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 1020);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosAbertoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPedidosDetalhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiradaCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baldesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentoDeNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarNotasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasFiscaisEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosParaComprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkarEstoqueXProdutoXFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkarProdutoFinalXEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueBaldesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueDePotesDeSorvetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorvetes10lEmFaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem subtrairEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFCupomManualToolStripMenuItem;
    }
}

