using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob6
    {
        static void Main(string[] args)
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            Console.WriteLine("Introduceti valori pentru a, b si c.");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            bool ok = true;

            if (a + b > 2*c)
            {
                ok = false;
            }
            if (a + c > 2*b)
            {
                ok = false;
            }
            if (b + c > 2*a)
            {
                ok = false;
            }

            if (ok == true)
            {
                Console.WriteLine("Valorile introduse pentru a, b si c pot fi lungimi ale unui triunghi.");
            }
            else
            {
                Console.WriteLine("Valorile introduse pentru a, b si c nu pot fi lungimi ale unui triunghi.");
            }
        }
    }
}
