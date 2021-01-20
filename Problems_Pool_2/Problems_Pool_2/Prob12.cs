using System;

namespace Problems_Pool_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare
            //astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa
            //1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.

            int n = int.Parse(Console.ReadLine());
            int curent = 0;
            int i;
            int prev = -3213534;
            bool ok = false;
            int contor = 0;
            for (i = 1; i <= n; i++)
            {
                curent = int.Parse(Console.ReadLine());
                if(i != 1)
                {
                    if (prev + 1 == curent)
                    {
                        ok = true;
                    }

                    if (prev > curent && ok == true)
                    {
                        contor++;
                        ok = false;
                    }

                    if (curent != 0 && curent < prev)
                    {
                        while (curent != 0 && i <= n)
                        {
                            curent = int.Parse(Console.ReadLine());
                            i++;
                        }
                        while (curent == 0 && i <= n)
                        {
                            curent = int.Parse(Console.ReadLine());
                            i++;
                        }
                    }
                    
                    prev = curent;
                }
                prev = curent;

            }
            if (curent > 0 && ok == true)
            {
                contor++;
            }

            Console.WriteLine(contor);

        }
    }
}
