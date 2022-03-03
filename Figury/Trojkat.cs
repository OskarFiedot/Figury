using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

// Klasa Trojkat, dziedziczy po klasie Figura, definiuje jedynie wygląd siebie jako kontrolki

namespace Figury
{
    public class Trojkat : Figura
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            Brush myBrush = new SolidBrush(Color.Blue);
            PointF p1 = new PointF(75, 0);
            PointF p2 = new PointF(150, 150);
            PointF p3 = new PointF(0, 150);
            PointF[] points = { p1, p2, p3 };
            graphics.FillPolygon(myBrush, points);
        }
    }
}
