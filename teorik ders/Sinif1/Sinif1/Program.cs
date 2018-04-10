using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif1
{
    class Ogrenci
    {
        public ulong OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Bolum;
        public byte Sinif;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2;
            ogr1.OgrenciNo = 123456789;
            ogr1.Ad = "Ahmet";
            ogr1.Soyad = "Yıldız";
            ogr1.Bolum = "Bilgisayar Mühendisliği";
            ogr1.Sinif = 3;
            ogr2 = ogr1;
            Console.WriteLine(ogr2.OgrenciNo);
            ogr1.Ad = "Hamdi";
            Console.WriteLine(ogr2.Ad);
            Console.WriteLine(ogr2.Soyad);
            Console.WriteLine(ogr2.Bolum);
            Console.WriteLine(ogr2.Sinif);
        }
    }
}
