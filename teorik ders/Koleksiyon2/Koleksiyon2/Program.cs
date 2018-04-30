using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koleksiyon2
{
    class Araba
    {
        string marka;
        string model;
        int modelYili;
        public Araba(string marka, string model, int modelYili)
        {
            this.marka = marka;
            this.model = model;
            this.modelYili = modelYili;
        }
        //ToString metodu sınıfın metinsel temsili içindir. Standart olarak sınıfın ismini yazar. override özelliği ile standart metin temsili değiştirilir.
        public override string ToString()
        {
            return String.Format("Araba: marka:{0} model:{1} yılı:{2}",marka,model,modelYili);//Arabanın marka, model ve model yılını biçimlendirerek döndürür
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(22);
            liste.Add(1);
            liste.Add(40);
            liste.Add(10);
            liste.Add(21);
            liste.Add(4);
            List<string> metinListesi = new List<string>();
            metinListesi.Add("dasdsa");
            metinListesi.Add("hfdtfdw1");
            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = i+1; j < liste.Count; j++)
                {
                    if (liste[i] > liste[j])
                    {
                        int gecici = liste[i];
                        liste[i] = liste[j];
                        liste[j] = gecici;
                    }
                }
            }
            foreach (int deger in liste)
            {
                Console.WriteLine(deger);
            }

            List<Araba> arabaListesi = new List<Araba>();
            Araba a1 = new Araba("BMW", "5.20", 2005);
            Araba a2 = new Araba("Murat", "131", 1980);
            Araba a3 = new Araba("Citroen", "C4", 2010);
            arabaListesi.Add(a1);
            arabaListesi.Add(a2);
            arabaListesi.Add(a3);
            arabaListesi.Add(new Araba("Audi", "A3", 2012));
            
            //döngü ile arabaları yazdır
            foreach (Araba araba in arabaListesi)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
