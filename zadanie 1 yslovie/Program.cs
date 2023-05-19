using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_yslovie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите положительное или отрицательное число:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            { n += 5; }
            else
            { n -= 5; }
            Console.Write(n);
            Console.ReadKey(true);
            
        }
    }
}
