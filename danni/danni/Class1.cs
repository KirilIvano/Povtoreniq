using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danni
{
    internal class Class1
    {
        public string Ime
        {
            get { return Ime; }
            set { Ime = value; }
        }
        public decimal zaplata
        {
            get { return zaplata; }
            set { zaplata = value; }
        }
        public void izhod()
        {
            Console.WriteLine($"Slujitel:{Ime}, zaplata {zaplata}lv.");
        }

    }
}
