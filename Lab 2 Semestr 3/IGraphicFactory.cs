using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_Semestr_3
{
    interface IGraphicFactory
    {
        GraphObjects CreateGraphObject(int W, int H);
    }
}