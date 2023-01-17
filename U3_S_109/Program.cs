using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_109
{
    interface ISekil
    {
        void Ciz();
    }
    class Kare : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("Kare Çizildi");
        }
    }
    class Daire : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("Daire Çizildi");
        }
    }
    class Ucgen : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("Üçgen Çizildi");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<ISekil> sekiller = new List<ISekil>
            {
                new Daire(),
                new Kare(),
                new Ucgen()
            };
            foreach (var ISekil in sekiller)
            {
                ISekil.Ciz();
            }
            Console.ReadLine();
        }
    }
}
