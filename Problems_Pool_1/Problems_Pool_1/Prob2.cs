using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob2
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

            Console.WriteLine("Introduceti valori pentru a, b, c din ecuatia ax ^ 2 + bx + c = 0.");

            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            double delta;

            delta = (b * b) - 4 * a * c;

            double x1;
            double x2;

            if (delta >= 0)
            {
                x1 = (b * (-1) + Math.Sqrt(delta)) / 2 * a;
                x2 = (b * (-1) - Math.Sqrt(delta)) / 2 * a;
                if (x1 == x2)
                {
                    Console.WriteLine($"Radacina este dubla si este {x1}.");
                }
                else if (x1 != x2)
                {
                    Console.WriteLine($"Radacinile sunt {x1} si {x2}.");
                }
            }
            else if (delta < 0)
            {
                Console.WriteLine("Radacinile sunt complexe.");
            }

        }
    }
}
