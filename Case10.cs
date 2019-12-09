using System;

namespace Case10
{
    class Case10
    {
        /* 
         * extension method для строки IsUpperCase, который опеределяет все ли символы в строке с большой буквы:
         "hello I AM DONALD".IsUpperCase() == false
         "HELLO I AM DONALD".IsUpperCase() == true
         "ACSKLDFJSgSKLDFJSKLDFJ".IsUpperCase() == false
         "ACSKLDFJSGSKLDFJSKLDFJ".IsUpperCase() == true
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();       
            bool r = input.IsUpperCase();        
            Console.WriteLine($"{r}");
            
        }
        
    }
}
