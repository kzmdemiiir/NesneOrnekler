using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_108
{
    interface IKutuphane
    {
        void oku();
    }
    public class Kitap : IKutuphane
    {
        public void oku()
        {
            Console.WriteLine("Kitap Oku.");
        }
    }
    public class Dergi : IKutuphane
    {
        public void oku()
        {
            Console.WriteLine("Dergi Oku. ");
        }
    }
    public class Ansiklopedi : IKutuphane
    {
        public void oku()
        {
            Console.WriteLine("Ansiklopedi Oku. ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.oku();
            Dergi dergi = new Dergi();
            dergi.oku();
            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.oku();
            Console.WriteLine("=================");
            IKutuphane kutuphane1 = kitap;
            IKutuphane kutuphane2 = dergi;
            IKutuphane kutuphane3 = ansiklopedi;
            kutuphane1.oku();
            kutuphane2.oku();
            kutuphane3.oku();
            Console.ReadLine();
        }
    }
}
