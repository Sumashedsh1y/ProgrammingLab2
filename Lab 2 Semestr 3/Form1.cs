using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Semestr_3
{
    public partial class Form1 : Form
    {
        int f = 0;
        int q = 1;
        int W_ = 40;
        int H_ = 40;
        int id = -1;
        private List<GraphObjects> elements = new List<GraphObjects>();
        IGraphicFactory factory = new RandomFactory();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            elements.Add(factory.CreateGraphObject(W_ , H_ ));
            Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            elements.Clear();
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphObjects elem in elements)
            {
                elem.Draw(e.Graphics);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rand.Next(2) == 1)
            {
                ellipse Ellipse = new ellipse(e.X, e.Y, W_, H_);
                Ellipse.X = (int)(Ellipse.X - Ellipse.A / 2);
                Ellipse.Y = (int)(Ellipse.Y - Ellipse.B / 2);
                elements.Add(Ellipse);
            }
            else
            {
                rectangle Rectangle = new rectangle(e.X, e.Y, W_, H_);
                Rectangle.X -= Rectangle.W / 2;
                Rectangle.Y -= Rectangle.H / 2;
                elements.Add(Rectangle);
            }
            Refresh();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (elements.Count > 0)
            {
                int i = 0;
                foreach (GraphObjects element in elements)
                {
                    if (element.ContainsPoint(e.Location))
                    {
                        id = i;
                    }
                    element.Selected = false;
                    i++;
                }
                if (id > -1)
                {
                    elements[id].Selected = true;
                    this.panel1.Invalidate();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (W_ == 0 && H_ == 0)
            {
                W_ = 40;
                H_ = 40;
            }
            else
            {
                W_ = (W_ + 40) % 201;
                H_ = (H_ + 40) % 201;
            }
            q %= 5;
            if (q == 0)
                q=1;
            else
            {
                q += 1;
            }
            label1.Text = "x"+q.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                elements[id].X -= 1;
                this.panel1.Invalidate();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                elements[id].Y -= 1;
                this.panel1.Invalidate();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                elements[id].X += 1;
                this.panel1.Invalidate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                elements[id].Y += 1;
                this.panel1.Invalidate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                elements.Remove(elements[id]);
                id = -1;
                this.panel1.Invalidate();
            }
        }

        private void фигурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f % 2 ==0) factory = new RandomFactory();
            else factory = new TwoTypeFactory();
            if (f % 2 == 0)
                label2.Text = "Factory: Random";
            else
                label2.Text = "Factory: TwoTipes";
            f += 1;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
