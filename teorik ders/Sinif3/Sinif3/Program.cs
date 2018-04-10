using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif3
{
    class Toplama
    {
        public int x;
        public int y;
        public void DegerBelirle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Topla()
        {
            Console.WriteLine(x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Toplama t = new Toplama();
            t.DegerBelirle(15, 20);
            t.Topla();
        }
    }
}
