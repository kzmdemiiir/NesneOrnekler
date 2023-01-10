using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class OkulPersoneli
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }
    }

    class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OkulPersoneli op = new OkulPersoneli();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "Serkan";
            ogrt.Soyad = "Aydın";
            ogrt.Brans = "Bilişim";
            Console.WriteLine("Öğretmen Sınıfından Türetilen {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);

            op.Ad = "Ramazan";
            op.Soyad = "Güneş";
            Console.WriteLine("Okul Personeli Sınıfından Türetilen {0} {1}", op.Ad, op.Soyad);
            Console.ReadLine();
        }
    }
}
