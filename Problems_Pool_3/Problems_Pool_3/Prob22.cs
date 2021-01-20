using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_3
{
    class Prob22
    {
        static void Main(string[] args)
        {
            //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1
            //(implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[m];

            Console.WriteLine(Intersectie(v1, v2, n, m)[1]);
            
        }
        static public int[] Intersectie(int[] v1, int[]  v2, int n, int m)
        {
            int i;
            int j;
            int k = 0;
            int bigger;
            if (n > m)
            {
                bigger = n;
            }
            else
            {
                bigger = m;
            }
            int[] vectorReturn = new int[bigger];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if(v1[i] == v2[j])
                    {
                        vectorReturn[k] = v1[i];
                        k++;
                    }
                }
            }
            return vectorReturn;
        }
    }
}
