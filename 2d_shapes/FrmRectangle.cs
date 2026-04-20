using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_shapes
{
    public partial class FrmRectangle : Form
    {
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Blue, 4);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //calcular el rectangulo
            int ancho = int.Parse(txtAncho.Text);
            int largo = int.Parse(txtLargo.Text);

            //punto de incio: (300, 100)
            //g.DrawRectangle(Pens.Red, 300, 100, ancho, largo);

            //perimetro rectangulo
            int perimetro = 2 * (ancho + largo);
            txtPerimetro.Text = perimetro.ToString();

            FrmRectangle_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));

            //area rectangulo
            int area = ancho * largo;
            txtArea.Text = area.ToString();
        }
    }
}
