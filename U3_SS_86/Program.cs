using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_86
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayix s = new Sayix();
            int sayi = 100;
            int x = s.Sayi(sayi);
            Console.WriteLine("Sayı{0}", x);
        }
    }
    class Sayix
    {
        public int Sayi(int sayi1)
        {
            int x;
            if (sayi1 % 2 == 0)
            {
                x = Convert.ToInt32("true");
            }
            else
            {
                x = Convert.ToInt32("false");
            }
            return x;
        }
    }
}
