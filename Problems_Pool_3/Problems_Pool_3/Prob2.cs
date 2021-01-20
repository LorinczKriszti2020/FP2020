using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_3
{
    class Prob2
    {
        static void Main(string[] args)
        {

            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care
            //apare k. Daca k nu apare in vector rezultatul va fi -1.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            int i;
            bool ok = false;

            for (i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] == k)
                {
                    Console.WriteLine(i);
                    i = n + 1;
                    ok = true;
                }
            }
            if (ok == false)
            {
                Console.WriteLine("-1");
            }



        }
    }
}
