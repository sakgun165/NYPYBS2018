using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listeLab
{
    class Kisi
    {
        public string adi;
        public string soyadi;
        public string telefonNo;
        public string adres;
        public Kisi(string adi, string soyadi, string telefonNo, string adres)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.telefonNo = telefonNo;
            this.adres = adres;
        }
        public override string ToString()
        {
            return String.Format("Adı:{0} Soyadı:{1}, Telefonu:{2}, Adresi:{3}",adi,soyadi,telefonNo,adres);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Kisi a = new Kisi("Şevket", "Çakır", "5551234567", "denizli");
            //rehberi oluştur
            List<Kisi> rehber = new List<Kisi>();
            int secim;
            do
            {
                menuYazdir();
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    //Rehbere ekle
                    case 1:
                        Console.Write("Adı girin: ");
                        string adi = Console.ReadLine();
                        Console.Write("Soyadı girin: ");
                        string soyadi = Console.ReadLine();
                        Console.Write("Telefon numarası girin: ");
                        string telefonNo = Console.ReadLine();
                        Console.Write("Adresi girin: ");
                        string adres = Console.ReadLine();
                        Kisi k = new Kisi(adi, soyadi, telefonNo, adres);
                        rehber.Add(k);
                        break;
                    //Rehberde ara
                    case 2:
                        Console.WriteLine("Arama kriterini girin");
                        Console.WriteLine("1) Ada göre");
                        Console.WriteLine("2) Soyada göre");
                        Console.Write("Seçiminiz: ");
                        int s = Convert.ToInt32(Console.ReadLine());
                        bool aramaTipi=false;
                        if (s == 1)
                            aramaTipi = true;
                        Console.Write("Aranacak değeri girin: ");
                        string aranacak = Console.ReadLine();
                        foreach (Kisi kisi in rehber)
                        {
                            if(aramaTipi && kisi.adi==aranacak)//ada göre ara
                                Console.WriteLine(kisi);
                            else if(!aramaTipi && kisi.soyadi==aranacak)//soyada göre ara
                                Console.WriteLine(kisi);
                        }

                        break;
                    //Rehberden sil
                    case 3:
                        sil(rehber);
                        break;
                    //Kayıt düzenle
                    case 4:
                        duzenle(rehber);
                        break;
                    case 5:
                        break;
                    //Rehberi listele
                    case 6:
                        foreach (Kisi kisi in rehber)
                        {
                            Console.WriteLine(kisi);
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim");
                        break;
                }
            }
            while (secim != 5);
        }

        static void menuYazdir()
        {
            Console.WriteLine();
            Console.WriteLine("1) Rehbere ekle");
            Console.WriteLine("2) Rehberde ara");
            Console.WriteLine("3) Rehberden sil");
            Console.WriteLine("4) Kayıt düzenle");
            Console.WriteLine("5) Çıkış");
            Console.WriteLine("6) Rehberi listele");
            Console.Write("Seçiminiz: ");
        }
        static void sil(List<Kisi> r)
        {
            Console.Write("Silinecek kişinin soyadını girin: ");
            string s = Console.ReadLine();
            List<Kisi> silinecek = new List<Kisi>();//Silinecek kayıtlar listesi
            foreach (Kisi k in r)
            {
                if (k.soyadi == s)
                {
                    Console.WriteLine(k+" kişisini silmek istiyor musunuz(e/h)?");
                    string secim = Console.ReadLine();
                    if (secim == "e" || secim == "E")
                        silinecek.Add(k);
                }
            }
            foreach (Kisi k in silinecek)
            {
                r.Remove(k);
            }
        }
        static void duzenle(List<Kisi> r)
        {
            for (int i = 0; i < r.Count; i++)
            {
                for (int j = i+1; j < r.Count; j++)
                {
                    if (r[i].soyadi.CompareTo(r[j].soyadi) < 0)
                    {
                        Kisi gecici = r[i];
                        r[i] = r[j];
                        r[j] = gecici;
                    }
                }
            }
            Console.WriteLine("Hangi kaydı düzenlemek istiyorsunuz?");
            for (int i = 0; i < r.Count; i++)
            {
                Console.WriteLine("{0}) {1}", i, r[i]);
            }
            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            Kisi duzenlenecek = r[secim];
            Console.Write("Ad girin[{0}]: ",duzenlenecek.adi);
            string adi = Console.ReadLine();
            if (adi != "")
                duzenlenecek.adi = adi;
            Console.Write("Soyad girin[{0}]: ", duzenlenecek.soyadi);
            string soyadi = Console.ReadLine();
            if (soyadi != "")
                duzenlenecek.soyadi = soyadi;
            Console.Write("Telefon girin[{0}]: ", duzenlenecek.telefonNo);
            string tel = Console.ReadLine();
            if (tel != "")
                duzenlenecek.telefonNo = tel;
            Console.Write("Adres girin[{0}]: ", duzenlenecek.adres);
            string adres = Console.ReadLine();
            if (adres != "")
                duzenlenecek.adres= adres;

        }
    }
}
