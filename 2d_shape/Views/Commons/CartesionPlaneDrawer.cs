using System.Drawing;

namespace _2d_shape.Views.Commons
{
    internal static class CartesianPlaneDrawer
    {
        public static void DrawPositiveAxes(Graphics g, int width, int height, Font font, int margin, int scale)
        {
            int originX = margin;
            int originY = height - margin;

            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                // X axis
                g.DrawLine(axisPen, originX, originY, width - margin, originY);
                g.DrawLine(axisPen, width - margin, originY, width - margin - 10, originY - 5);
                g.DrawLine(axisPen, width - margin, originY, width - margin - 10, originY + 5);

                // Y axis
                g.DrawLine(axisPen, originX, originY, originX, margin);
                g.DrawLine(axisPen, originX, margin, originX - 5, margin + 10);
                g.DrawLine(axisPen, originX, margin, originX + 5, margin + 10);
            }

            // X marks
            for (int x = originX + scale; x <= width - margin; x += scale)
            {
                g.DrawLine(Pens.Gray, x, originY - 4, x, originY + 4);
                int valueX = (x - originX) / scale;
                g.DrawString(valueX.ToString(), font, Brushes.Black, x - 5, originY + 8);
            }

            // Y marks
            for (int y = originY - scale; y >= margin; y -= scale)
            {
                g.DrawLine(Pens.Gray, originX - 4, y, originX + 4, y);
                int valueY = (originY - y) / scale;
                g.DrawString(valueY.ToString(), font, Brushes.Black, originX - 25, y - 7);
            }

            g.DrawString("0", font, Brushes.Black, originX - 15, originY + 8);
            g.DrawString("X", font, Brushes.Black, width - margin + 5, originY - 15);
            g.DrawString("Y", font, Brushes.Black, originX - 15, margin - 25);
        }

        public static Point ConvertToScreen(int x, int y, int panelHeight, int margin, int scale)
        {
            int originX = margin;
            int originY = panelHeight - margin;

            int screenX = originX + (x * scale);
            int screenY = originY - (y * scale);

            return new Point(screenX, screenY);
        }
    }
}
