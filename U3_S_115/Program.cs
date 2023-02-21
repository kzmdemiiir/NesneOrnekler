using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_115
{
    enum Seviyeler
    {
        Çok_Düşük,
        Düşük,
        Orta,
        Büyük,
        Çok_Büyük
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Seviyeler.Çok_Düşük);
            Console.Write((int)Seviyeler.Çok_Düşük);
           
            
            Console.ReadLine();
        }
    }
}
