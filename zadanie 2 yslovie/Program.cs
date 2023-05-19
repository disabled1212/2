using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_yslovie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] abc = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Введите число {i + 1} = ");
                abc[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(abc);
            Console.WriteLine($"max = {abc[2]}");
            Console.ReadLine();

        }
    }
}
