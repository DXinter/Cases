using System;

namespace Case10
{
    public static class Helper
    {
        public static bool IsUpperCase(this string direct)
        {
            for (int i = 0; i < direct.Length; i++)
            {
                if (Char.IsLower(direct[i]))
                    return false;
            }
            return true;
        }
       
}   }
