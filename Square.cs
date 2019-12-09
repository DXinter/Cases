using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMadness
{
    class Square
    {
        public bool ArrayMadnes(int[] first,  int[] second)
        {          
            int sum1=0, sum2 = 0;
            foreach (int value in first)
                sum1 += value * value;
            foreach(int value in second)
                sum2 += value * value;

            if (sum1 > sum2)
                return true;
            else
            return false;
        }
    }
}
