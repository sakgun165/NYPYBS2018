using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif2
{

    class Dikdortgen
    {
        public int UzunKenar;
        public int KisaKenar;
        public void DegerBelirle(int uzunkenar, int kisakenar)
        {
            UzunKenar = uzunkenar;
            KisaKenar = kisakenar;
        }
        public int Cevre()
        {
            return 2 * UzunKenar + 2 * KisaKenar;
        }
        public int Alan()
        {
            return UzunKenar * KisaKenar;
        }
        public void Yaz()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("* Uzun Kenar = {0,5} *", UzunKenar);
            Console.WriteLine("* Kısa Kenar = {0,5} *", KisaKenar);
            Console.WriteLine("* Çevre = {0,5} *", Cevre());
            Console.WriteLine("* Alan = {0,5} *", Alan());
            Console.WriteLine("**********************\n");
        }
    }
}
