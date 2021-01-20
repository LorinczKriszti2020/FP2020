using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prog16
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            Console.WriteLine("Introduceti valori pentru cele 5 numere.");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int minim = n1;
            int maxim = n2;

            if (minim > n2)
            {
                minim = n2;
            }
            if (minim > n3)
            {
                minim = n3;
            }
            if (minim > n4)
            {
                minim = n4;
            }
            if (minim > n5)
            {
                minim = n5;
            }
            if (maxim < n1)
            {
                maxim = n1;
            }
            if (maxim < n3)
            {
                maxim = n3;
            }
            if (maxim < n4)
            {
                maxim = n4;
            }
            if (maxim < n5)
            {
                maxim = n5;
            }

            //a=a+b;
            //b=a-b;
            //a=a-b;


        }
    }
}
