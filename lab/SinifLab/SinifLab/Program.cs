using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci[] ogr = new Ogrenci[3];
            ogr[0] = new Ogrenci("Şevket", "Çakır", 50, 70);
            ogr[1] = new Ogrenci("Murtaza", "Aslan", 30, 90);
            ogr[2] = new Ogrenci("Rezzak", "Dörtgen", 15, 65);

            Console.WriteLine("Sınıf ortalaması: {0}", Ortalama(ogr));

        }

        public static double Ortalama(Ogrenci[] ogrenciler)
        {
            double toplam = 0;
            foreach (Ogrenci o in ogrenciler)
            {
                o.yazdir();
                toplam += o.vize * 0.4 + o.final * 0.6;
            }
            return toplam / ogrenciler.Length;
        }
    }
}
