using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_GoldSoru1
{
    interface ISekil
    {
        void Ciz();
        double AlanHesapla(int a, int b = 1, double pi = 3.14);
        double CevreHesapla(int a, int b = 0, int c = 0, double pi = 3.14);

    }
    class Daire : ISekil
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return pi * (a * a);
        }

        public double CevreHesapla(int a, int b = 0, int c = 0, double pi = 3.14)
        {
            return 2 * pi * a;
        }

        public void Ciz()
        {
            Console.WriteLine("Daire Çiz. ");
        }
    }
    class Kare : ISekil
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return a * a;
        }

        public double CevreHesapla(int a, int b = 0, int c = 0, double pi = 3.14)
        {
            return 4 * a;
        }

        public void Ciz()
        {
            Console.WriteLine("Kare Çiz. ");
        }
    }
    class Ucgen : ISekil
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return (a * b) / 2;
        }

        public double CevreHesapla(int a, int b = 0, int c = 0, double pi = 3.14)
        {
            return a + b + c;
        }

        public void Ciz()
        {
            Console.WriteLine("Üçgen Çiz");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Daire d = new Daire();
            d.Ciz();
            Console.WriteLine("Dairenin Alanı : " + d.AlanHesapla(2));
            Console.WriteLine("Dairenin Çevresi : " + d.CevreHesapla(2));

            Kare k = new Kare();
            k.Ciz();
            Console.WriteLine("Karenin Alanı : " + k.AlanHesapla(3));
            Console.WriteLine("Karenin Çevresi : " + k.CevreHesapla(3));

            Ucgen u = new Ucgen();
            u.Ciz();
            Console.WriteLine("Üçgenin Alanı : " + u.AlanHesapla(2));
            Console.WriteLine("Üçgenin Çevresi : " + u.CevreHesapla(2));

            Console.ReadLine();
        }
    }
}
