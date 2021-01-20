using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_3
{
    class Prob4
    {
        static void Main(string[] args)
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de
            //cate ori apar acestea. 
            Console.WriteLine("Introduceti lungimea vectorului.");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;
            int minim = 4174621;
            int maxim = -1;
            int contorMinim = 0;
            int contorMaxim = 0;
            int aux;
            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti valoare pentru v[{i}]: ");
                v[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    minim = v[i];
                }
                if (i == 1)
                {
                    maxim = v[i];
                }
                if (minim > maxim && i != 0)
                {
                    aux = minim;
                    minim = maxim;
                    maxim = aux;
                    aux = contorMinim;
                    contorMinim = contorMaxim;
                    contorMaxim = aux;
                }
                if(minim == v[i])
                {
                    contorMinim++;
                }
                if(minim > v[i])
                {
                    minim = v[i];
                    contorMinim = 1;
                }
                if (maxim == v[i])
                {
                    contorMaxim++;
                }
                if (maxim < v[i])
                {
                    maxim = v[i];
                    contorMaxim = 1;
                }
            }

            Console.WriteLine($"Minim: {minim}; Contor: {contorMinim}");
            Console.WriteLine($"Maxim: {maxim}; Contor: {contorMaxim}");
        }
    }
}
