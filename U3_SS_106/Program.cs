using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    public abstract class Kutuphane
    {
        public string Kitap { get; set; }
        public string Dergi { get; set; }
        public string Ansiklopedi { get; set; }
        public abstract void Oku();

    }
    public class Kitap : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Kitap Oku");
        }
    }
    public class Dergi : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Dergi Oku");
        }
    }
    public class Ansiklopedi : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi Oku");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Kitap ktp = new Kitap()
            {
                Kitap = "Geleceğe Yolculuk"
            };
            Console.Write("{0} adlı ", ktp.Kitap);
            ktp.Oku();

            Dergi d = new Dergi()
            {
                Dergi = "h"
            };
            Console.Write("{0} adlı ", d.Dergi);
            d.Oku();

            Ansiklopedi a = new Ansiklopedi()
            {
                Ansiklopedi = "g"
            };
            Console.Write("{0} adlı ", d.Dergi);
            a.Oku();
            Console.ReadLine();
        }
        

    }
}
