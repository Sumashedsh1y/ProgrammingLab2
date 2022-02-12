using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Semestr_3
{
    internal class RandomFactory : IGraphicFactory
    {
        private static readonly Random rand = new Random();

        public GraphObjects CreateGraphObject(int W,int H)
        {
            if (rand.Next(2) == 1) return new ellipse(W, H);
            else return new rectangle(W, H);
        }
    }
}