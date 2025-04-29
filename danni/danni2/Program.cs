using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danni2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Br slujiteli: ");
            int n = int.Parse(Console.ReadLine());
            danni1[] slujiteli = new danni1[n];
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine($"Slujitel {i + 1}");
                slujiteli[i] = new danni1();
                slujiteli[i].vhod();
            }
            Console.WriteLine("--Spisak na slujitelite--");
            for (int i = 0; i < n; i++)
            {
                slujiteli[i].izhod();
            }   
        }
    }
}
