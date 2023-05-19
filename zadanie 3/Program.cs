using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int a = 1; a<= number; a++)
            {
                factorial = a;
            }
            Console.WriteLine($"Факториал числа равен: {number} = {factorial}");
            Console.ReadLine();
        }
    }
}
