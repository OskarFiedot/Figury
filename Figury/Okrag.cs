using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

// Klasa Okrag, dziedziczy po klasie Figura, definiuje jedynie wygląd siebie jako kontrolki

namespace Figury
{
    public class Okrag : Figura
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Brush myBrush = new SolidBrush(Color.Green);
            g.FillEllipse(myBrush, 0, 0, 150, 150);
        }
    }
}
