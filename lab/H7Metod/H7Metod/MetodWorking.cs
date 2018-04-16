using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H7Metod
{
    class MetodWorking
    {
        public static double kiraUcreti(int km)
        {
            double tutar;
            if (km < 100)
                tutar = 10 + km * 0.9;
            else
                tutar = 10 + 100 * 0.9 + (km - 100) * 0.6;
            return tutar;
        }

        public static int sporSalonuUcret(int paket, int uyelik)
        {
            int tutar;
            if (paket == 1 && uyelik == 1)
                tutar = 1050;
            else if (paket == 1 && uyelik == 2)
                tutar = 1650;
            else if (paket == 2 && uyelik == 1)
                tutar = 775;
            else if (paket == 2 && uyelik == 2)
                tutar = 1100;
            else if (paket == 3 && uyelik == 1)
                tutar = 650;
            else
                tutar = 850;
            return tutar;
        }

        public static double komisyonUcreti(double miktar)
        {
            if (miktar < 100)
                miktar = miktar * 1.01;//miktarın %101'i toplam tutarı verir
            else
                miktar *= 1.02;//100 TL'den fazla ise miktarın %102'si toplam tutarı verir
            return miktar;
        }
    }
}
