using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif5
{
    class Statik
    {
        public static int b = 10;
        public static int deneme()
        {
            int a = 5;
            b = a;
            return b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Statik b = new Statik();
            Console.WriteLine(Statik.deneme());
            Console.WriteLine(Statik.a);
            Console.ReadLine();
        }
    }
}
