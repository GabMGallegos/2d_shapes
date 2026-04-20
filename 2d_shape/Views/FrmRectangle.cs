using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _2d_shape.Views.Commons;

namespace _2d_shape.Views
{
    public partial class FrmRectangle : Form
    {
        public FrmRectangle()
        {
            InitializeComponent();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            CartesianPlaneDrawer.DrawPositiveAxes(e.Graphics, panel2.Width, panel2.Height, lblMensaje.Font, 40, 20);
        }
    }
}
