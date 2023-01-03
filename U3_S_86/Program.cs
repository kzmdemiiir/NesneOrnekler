using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_86
{
    class Program
    {
        static void Main(string[] args)
        {
            SayiBulucu sb = new SayiBulucu();
            int a = 100;
            int b = 25;
            int sonuc = sb.BuyukOlaniBul(a, b);
            Console.WriteLine("Büyük olan sayı: {0}", sonuc);
            Console.ReadLine();
        }
    }
    class SayiBulucu
    {
        public int BuyukOlaniBul (int s1 , int s2)
        {
            int sonuc;
            if (s1<s2)
            {
                sonuc = s2;      
            }
            else
            {
                sonuc = s1;
            }

            return sonuc;
        }
    }
}
