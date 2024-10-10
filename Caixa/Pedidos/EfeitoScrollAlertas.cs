using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa.Pedidos
{
    public partial class EfeitoScrollAlertas : Label
    {
        public EfeitoScrollAlertas()
        {
            InitializeComponent();
            UseCompatibleTextRendering = true;
            this.BackColor = Color.White;
            timer1.Start();
            this.AutoSize = true;
        }
        int posicao, velocidade;
        public int Set_Velocidade { get { return velocidade; } set { velocidade = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)posicao, 0);
            base.OnPaint(e);    
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (posicao<-Width)
            {
                posicao = Width;
            }
            posicao -= velocidade;
            Invalidate();

        }
    }
}
