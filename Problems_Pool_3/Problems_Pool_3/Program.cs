using System;

namespace Problems_Pool_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int bigger;

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];
            int[] v2 = new int[m];

            for (i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            for (j = 0; j < m; j++)
            {
                v2[j] = int.Parse(Console.ReadLine());
            }

            if (n > m)
            {
                bigger = n;
            }
            else
            {
                bigger = m;
            }

            for (i = 0; i < bigger; i++)
            {
                Console.Write($"{Prob22.Intersectie(v1, v2, n, m)[i]} ,");
            }
        }
    }
}
