using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_3
{
    class Prob31
    {
        static void Main(string[] args)
        {
            //(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai
            //mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate
            //acesta este unui singur).  Sa se determine elementul majoritate al unui vector
            //(daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] v = new int[n]; 
            int i;
            int contor = 0;

            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == m)
                {
                    contor++;
                }
            }
            if(contor > n / 2)
            {
                Console.WriteLine($"{m} este elementul major al vectorului.");
            }
            else
            {
                Console.WriteLine("Nu exista.");
            }
        }
    }
}
