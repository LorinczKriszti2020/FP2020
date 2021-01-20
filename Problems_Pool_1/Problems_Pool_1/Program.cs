using System;

namespace Problems_Pool_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prob1();
            //Prob2();
            //Prob3();
            Prob4();
        }

        static void Prob1()
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.

            Console.WriteLine("Introduceti valori pentru a si b din formula ax+b=0");

            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            b = b * (-1);
            Console.WriteLine($"Valoarea lui x este {b/a}.");
        }

        static void Prob2()
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

        static void Prob3()
        {
            //Determinati daca N se divide cu K, unde n si k sunt date de intrare.

            Console.WriteLine("Introduceti n si k.");
            double n = Double.Parse(Console.ReadLine());
            double k = Double.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("N se divide cu K.");
            }
            else
            {
                Console.WriteLine("N nu se divide cu K");
            }
        }

        static void Prob4()
        {

        }
    }
}
