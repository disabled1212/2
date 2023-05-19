using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_yslovie
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите три числа:");
			int a = Convert.ToInt16(Console.ReadLine());
			int b = Convert.ToInt16(Console.ReadLine());
			int i = Convert.ToInt16(Console.ReadLine());
			int sym;
			if (a < 0)
				a = 0;
			if (b < 0)
				b = 0;
			if (i < 0)
				i = 0;
			sym = a + b + i;
			Console.WriteLine("Сумма положительных чисел:" + sym);
			Console.ReadLine();
		}
    }
}
