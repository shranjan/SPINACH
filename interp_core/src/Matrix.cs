/* Author : Sushma Kyasaralli Thimmappa */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelPrototype
{
    class Matrix
    {
        public int getRow()
        {
            return 3;
        }

        public int getCol()
        {
            return 2;
        }

        public int[] getElem()
        {
            int[] elements=new int[6];
            for (int i = 0; i < 6; i++)
                elements[i] = 1;
            return elements;
        }
    }
}
