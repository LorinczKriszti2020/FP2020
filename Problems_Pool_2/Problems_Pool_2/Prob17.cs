using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_2
{
    class Prob17
    {
        static void Main(string[] args)
        {
            //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
            //Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este,
            //determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta
            //si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.

            Console.WriteLine("Introduceti lungimea vectorului.");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            int i;
            int par = 0;
            int impar = 0;
            int contorIncuibare = 0;
            bool ok = true;
            for (i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            if (vector[0] != 0 && vector[n-1] != 1)
            {
                ok = false;
                Console.WriteLine("Secventa este incorecta.");
            }
            if(ok==true && par == impar)
            {
                Console.WriteLine("Secventa este incorecta.");
            }
            if (ok == true)
            {

            }
            



        }
    }
}
