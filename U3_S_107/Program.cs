using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_107
{
    interface IHayvan
    {
        void Sescikar();
    }
    interface IBeslen
    {
        void Beslen();
    }
    public class Kedi : IHayvan,IBeslen
    {
        public void Sescikar()
        {
            Console.WriteLine("Kedi: Miaaavv Dedi.");
        }
        public void Beslen()
        {
            Console.WriteLine("Kedi Süt İçer.");
        }
    }
    public class Kopek : IHayvan,IBeslen
    {
        public void Sescikar()
        {
            Console.WriteLine("Köpek: Haw Haw Dedi.");
        }
        public void Beslen()
        {
            Console.WriteLine("Köpek Et Yer.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.Sescikar();
            kedi.Beslen();
            Kopek kopek = new Kopek();
            kopek.Sescikar();
            kopek.Beslen();
            Console.WriteLine("=================");
            IHayvan hayvan1 = kedi;
            IHayvan hayvan2 = kopek;
            hayvan1.Sescikar();
            hayvan2.Sescikar();
            Console.WriteLine("===================");
            IBeslen beslen1 = kedi;
            IBeslen beslen2 = kopek;
            beslen1.Beslen();
            beslen2.Beslen();
            Console.ReadLine();
        }
    }
}
