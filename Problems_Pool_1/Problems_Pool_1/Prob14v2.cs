using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob14v2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul care doriti sa fie verificat.");
            int numar = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j;
            int n = numar;
            bool ok = true;
            int k;

            while (n > 0)
            {
                n = n / 10;
                i = i + 1;
            }
            n = numar;
            j = i - 1;

            while (j > 0)
            {
                k = Convert.ToInt32(n / Math.Pow(10, j));
                if (k % 10 != n % 10)
                {
                    ok = false;
                    //Console.WriteLine(k + " , " + n % 10);
                }
                n = n / 10;
                j = j - 2;
            }

            if (ok == true)
            {
                Console.WriteLine($"Numarul {numar} este palindrom.");
            }
            else if (ok == false)
            {
                Console.WriteLine($"Numarul {numar} nu este palindrom.");
            }
        }
    }
}
