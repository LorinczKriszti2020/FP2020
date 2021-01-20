using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob1
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.

            Console.WriteLine("Introduceti valori pentru a si b din formula ax+b=0");

            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            b = b * (-1);
            Console.WriteLine($"Valoarea lui x este {b / a}.");
        }
    }
}
