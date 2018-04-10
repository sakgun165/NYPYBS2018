using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifLab
{
    class Ogrenci
    {
        public string adi;
        public string soyadi;
        public int vize;
        public int final;
        public Ogrenci() { }
        public Ogrenci(string adi, string soyadi, int vize, int Final)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.vize = vize;
            final = Final;
        }
        public void yazdir()
        {
            Console.WriteLine("{0} {1} :{2}", adi, soyadi, vize * 0.4 + final * 0.6);
        }
    }
}
