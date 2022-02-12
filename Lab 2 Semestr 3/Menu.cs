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
    public partial class Menu : Form
    {
        int z = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (z%2==0)
                label1.Text = "(｡◕‿◕｡)";
            else
                label1.Text = "_(ಥ﹏ಥ)_";
            z++;
        }
    }
}
