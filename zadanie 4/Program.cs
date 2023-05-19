using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Введите число: ");
            x = int.Parse(Console.ReadLine());


            if (x > 10)
            {
                x *= 2;

            }
            else
                x = x;
            


            Console.WriteLine("\nРавно {0}", x);
            Console.ReadKey();

        }
    }
}
