using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 10;
            int day = 1;
            double sumDistance = 10;

            while (distance < 20)
            {
                distance *= 1.05;
                day++;
            }
            Console.WriteLine($"День, в котором пробежал 20 киллометров : {day}");


            while (sumDistance < 100)
            {
                distance *= 1.05;
                sumDistance += distance;
                day++;
            }
            Console.WriteLine($"День,когда суммарно пробежал 100 км в общем: {day}");
            Console.ReadLine();
        }
        
    }
}
