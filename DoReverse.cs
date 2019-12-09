using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class DoReverse
    {
        public string Reverse(string someString)
        {
            char[] someArray = someString.ToCharArray();
            Array.Reverse(someArray);
            string result = new string(someArray);
            return result;
        }

    }
}
