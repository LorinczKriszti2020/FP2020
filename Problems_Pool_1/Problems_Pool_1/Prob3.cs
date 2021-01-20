using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_Pool_1
{
    class Prob3
    {
        static void Main(string[] args)
        {
            //Determinati daca N se divide cu K, unde n si k sunt date de intrare.

            Console.WriteLine("Introduceti n si k.");
            double n = Double.Parse(Console.ReadLine());
            double k = Double.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("N se divide cu K.");
            }
            else
            {
                Console.WriteLine("N nu se divide cu K");
            }
        }
    }
}
