using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.DegerBelirle(-40, -25);
            d1.Yaz();
            Dikdortgen d2 = new Dikdortgen();
            d2.DegerBelirle(15, 12);
            d2.Yaz();
            Dikdortgen d3 = new Dikdortgen();
            d3.UzunKenar = 78;
            d3.KisaKenar = 55;
            d3.Yaz();
        }
    }
}
