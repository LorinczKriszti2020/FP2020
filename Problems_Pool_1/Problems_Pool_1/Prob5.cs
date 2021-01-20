using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob5
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

            Console.WriteLine("Introduceti numarul din care se extrage cifra si dupa pe k.");

            int numar = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int cifra;
            int i;
            int imp=1;
            //cifra = numar % Math.Pow(10, k);
            //double f = Math.Pow(10, k - 1);
            for (i = 1; i <= k; i++)
            {
                imp *= 10;
            }
            cifra = numar % imp;
            imp /= 10;
            Console.WriteLine($"A k-a cifra este {cifra /= imp}");


        }
    }
}
