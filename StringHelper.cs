using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    class StringHelper
    {
        public string Swap(string input)
        {
            string result = "";          
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                result += Convert.ToString(input[i]);
            }
            for (int i = 0; i < input.Length/2; i++) 
            {
                result += Convert.ToString(input[i]);                              
            }       
                return result;
        }
    }
}
