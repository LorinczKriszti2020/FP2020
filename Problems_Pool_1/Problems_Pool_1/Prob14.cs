using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar.");

            int n = int.Parse(Console.ReadLine());

            if (Palindrom(n))
            {
                Console.WriteLine($"Numarul {n} este palindrom.");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este palindrom.");
            }
        }

        static bool Palindrom(int n)
        {
            if (n == Reverse(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Reverse(int n)
        {
            int numar = 0;
            int cifra;
            while (n > 0)
            {
                cifra = n % 10;
                numar = numar * 10 + cifra;
                n /= 10;
            }
            return numar;
        }
    }
}
