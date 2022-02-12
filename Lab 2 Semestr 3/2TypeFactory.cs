using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Semestr_3
{
    class TwoTypeFactory : IGraphicFactory
    {
        private bool k = false;
        public GraphObjects CreateGraphObject(int W, int H)
        {
            k = !k;
            if (k)
            {
                return new rectangle(W, H);
            }
            else
            {
                return new ellipse(W, H);
            }
        }
    }
}