using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktoren_broqch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Br.");
            int n = int.Parse(Console.ReadLine());

            Danni[] slujiteli = new Danni[n];

            //Vavejdane na Main s direktno prisvoqwane
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Slujitel{i + 1}");
                slujiteli[i] = new Danni();
            }
            
        }
    }
}

