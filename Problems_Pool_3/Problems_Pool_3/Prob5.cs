using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_3
{
    class Prob5
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea
            //e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 

            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            int i;

            for (i = 0; i < n + 1; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (i == k)
                {
                    v[i + 1] = v[i];
                    v[i] = e;
                    i++;
                }
            }
            for (i = 0; i < n + 1; i++)
            {
                Console.Write($"{v[i]}, ");
            }



        }
    }
}
