using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_2
{
    class Prob12v2
    {
        static void Main(string[] args)
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare
            //astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa
            //1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.

            int n = int.Parse(Console.ReadLine());
            int curent;
            int prev = -121;
            int i;
            bool ok = true;
            int contorCurent = 0;
            int contorTotal = 0;

            for (i = 1; i <= n; i++)
            {
                curent = int.Parse(Console.ReadLine());
                if (curent == 0)
                {
                    ok = true;
                    if(contorCurent != 0)
                    {
                        contorTotal++;
                        contorCurent = 0;
                    }
                }
                if (ok = true && curent != 0 && curent != 1)
                {
                    if (curent == prev + 1)
                    {
                        contorCurent += 1;
                    }
                    else
                    {
                        ok = false;
                        contorCurent = 0;
                    }
                }
                prev = curent;

            }
            Console.WriteLine(contorTotal);



        }
    }
}
