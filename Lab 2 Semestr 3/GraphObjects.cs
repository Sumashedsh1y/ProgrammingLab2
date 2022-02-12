using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Semestr_3
{
    public abstract class GraphObjects
    {
        protected int x, y, w, h;
        protected Color c;
        protected SolidBrush brush;
        private static Random r = new Random();
        public GraphObjects()
        {
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Magenta, Color.Gold };
            Selected = false;
            X = r.Next(700);
            Y = r.Next(700);
            brush = new SolidBrush(colors[r.Next(colors.Length)]);
        }

        public GraphObjects(int x, int y)
        {
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Magenta, Color.Gold };
            Selected = false;
            X = x;
            Y = y;
            brush = new SolidBrush(colors[r.Next(colors.Length)]);
        }

        public bool Selected { get; set; }
        public abstract bool ContainsPoint(Point p);
        public abstract void Draw(Graphics g);
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
    }
}
