using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_cikl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i;
            Console.Write("Введите натуральное число не меньше двух: ");
            bool found = false;
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
    } 
