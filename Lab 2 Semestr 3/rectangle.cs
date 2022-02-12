using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Semestr_3
{
    class rectangle : GraphObjects
    {
        public int w, h;
        public rectangle(int W, int H) : base()
        {
            w = W;
            h = H;
        }

        public rectangle(int x, int y, int W, int H) : base(x, y)
        {
            w = W;
            h = H;
        }
        public int H { get => h; set => h = value; }
        public int W { get => w; set => w = value; }

        public override bool ContainsPoint(Point p)
        {
            return (p.X <= x + W) & (p.X >= x) & (p.Y >= y) & (p.Y <= y + H);
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, X, Y, W, H);
            g.DrawRectangle(Selected ? Pens.Aqua : Pens.Black, X, Y, W, H);
        }
    }
}
