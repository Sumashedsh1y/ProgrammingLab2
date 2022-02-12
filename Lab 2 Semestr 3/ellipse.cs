using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Semestr_3
{
    class ellipse : GraphObjects
    {
        public float a, b;
        public ellipse(int W, int H) : base()
        {
            a = W;
            b = H;
        }

        public ellipse(int x, int y, int W, int H) : base(x, y)
        {
            a = W;
            b = H;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }

        public override bool ContainsPoint(Point p)
        {
            float dx = a / 2f, dy = b / 2f;
            return (Math.Pow(x + dx - p.X, 2f) / Math.Pow(dx, 2f) + Math.Pow(y + dy - p.Y, 2) / Math.Pow(dy, 2) <= 1);
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, x, y, a, b);
            g.DrawEllipse(Selected ? Pens.Aqua : Pens.Black, x, y, a, b);
        }
    }
}
