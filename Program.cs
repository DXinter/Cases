using System;

namespace ArrayMadness
{
    /*
     * функция, которая прнимает на вход два массива, 
     * и возвращает true/false если сумма квадратов первого массива больше суммы квадратов второго:
    */

    class Program
    {
        static void Main()
        {
            int size = 3;
            int[] square1 = new int[size];
            int[] square2 = new int[size];
            Console.WriteLine("Введите элименты массива: ");
            SetValue(size, square1, square2);
            bool result = Result(square1, square2);

            Console.WriteLine($"Результат сравнения: {result}");
            Console.ReadLine();
        }

        private static bool Result(int[] square1, int[] square2)
        {
            Square square = new Square(); ;
            bool result = square.ArrayMadnes(square1, square2);
            return result;
        }

        private static void SetValue(int size, int[] square1, int[] square2)
        {
            
            for (int number = 0; number < size; number++)
                square1[number] = Convert.ToInt32(Console.ReadLine());
            for (int number2 = 0; number2 < size; number2++)
                square2[number2] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
