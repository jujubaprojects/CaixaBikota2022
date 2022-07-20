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
            this.novoPedidoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosAbertoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoDeNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baldesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPedidosDetalhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu.Size = new System.Drawing.Size(800, 56);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip2";
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem1,
            this.novoPedidoRápidoToolStripMenuItem,
            this.pedidosAbertoToolStripMenuItem1,
            this.recebimentoDeNotaToolStripMenuItem});
            this.pedidosToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_contabilidade_48;
            this.pedidosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(109, 52);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem1
            // 
            this.novoPedidoToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_adicionar_regra_24;
            this.novoPedidoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novoPedidoToolStripMenuItem1.Name = "novoPedidoToolStripMenuItem1";
            this.novoPedidoToolStripMenuItem1.Size = new System.Drawing.Size(197, 30);
            this.novoPedidoToolStripMenuItem1.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem1.Click += new System.EventHandler(this.NovoPedidoToolStripMenuItem_Click);
            // 
            // novoPedidoRápidoToolStripMenuItem
            // 
            this.novoPedidoRápidoToolStripMenuItem.Image = global::Caixa.Properties.Resources.icons8_doar_24;
            this.novoPedidoRápidoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novoPedidoRápidoToolStripMenuItem.Name = "novoPedidoRápidoToolStripMenuItem";
            this.novoPedidoRápidoToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.novoPedidoRápidoToolStripMenuItem.Text = "Recebimento Rápido";
            this.novoPedidoRápidoToolStripMenuItem.Click += new System.EventHandler(this.NovoPedidoRápidoToolStripMenuItem_Click);
            // 
            // pedidosAbertoToolStripMenuItem1
            // 
            this.pedidosAbertoToolStripMenuItem1.Image = global::Caixa.Properties.Resources.icons8_termos_e_condições_24;
            this.pedidosAbertoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidosAbertoToolStripMenuItem1.Name = "pedidosAbertoToolStripMenuItem1";
            this.pedidosAbertoToolStripMenuItem1.Size = new System.Drawing.Size(197, 30);
            this.pedidosAbertoToolStripMenuItem1.Text = "Pedidos Aberto";
            this.pedidosAbertoToolStripMenuItem1.Click += new System.EventHandler(this.PedidosAbertoToolStripMenuItem_Click);
            // 
            // recebimentoDeNotaToolStripMenuItem
            // 
            this.recebimentoDeNotaToolStripMenuItem.Name = "recebimentoDeNotaToolStripMenuItem";
            this.recebimentoDeNotaToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.recebimentoDeNotaToolStripMenuItem.Text = "Recebimento de Nota";
            this.recebimentoDeNotaToolStripMenuItem.Click += new System.EventHandler(this.RecebimentoDeNotaToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retiradaCaixaToolStripMenuItem,
            this.baldesToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 52);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // retiradaCaixaToolStripMenuItem
            // 
            this.retiradaCaixaToolStripMenuItem.Name = "retiradaCaixaToolStripMenuItem";
            this.retiradaCaixaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.retiradaCaixaToolStripMenuItem.Text = "Retirada Caixa";
            this.retiradaCaixaToolStripMenuItem.Click += new System.EventHandler(this.RetiradaCaixaToolStripMenuItem_Click);
            // 
            // baldesToolStripMenuItem
            // 
            this.baldesToolStripMenuItem.Name = "baldesToolStripMenuItem";
            this.baldesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.baldesToolStripMenuItem.Text = "Baldes";
            this.baldesToolStripMenuItem.Click += new System.EventHandler(this.BaldesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 52);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 52);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasPedidosDetalhadoToolStripMenuItem,
            this.valorPorDiaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasPedidosDetalhadoToolStripMenuItem
            // 
            this.vendasPedidosDetalhadoToolStripMenuItem.Name = "vendasPedidosDetalhadoToolStripMenuItem";
            this.vendasPedidosDetalhadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasPedidosDetalhadoToolStripMenuItem.Text = "Pedidos Detalhado";
            this.vendasPedidosDetalhadoToolStripMenuItem.Click += new System.EventHandler(this.VendasPedidosDetalhadoToolStripMenuItem_Click);
            // 
            // valorPorDiaToolStripMenuItem
            // 
            this.valorPorDiaToolStripMenuItem.Name = "valorPorDiaToolStripMenuItem";
            this.valorPorDiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem novoPedidoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosAbertoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPedidosDetalhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentoDeNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiradaCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baldesToolStripMenuItem;
    }
}

