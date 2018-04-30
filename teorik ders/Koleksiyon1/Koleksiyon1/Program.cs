using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Koleksiyon1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(6);
            al.Add(25);
            al.Add("Merhaba");
            al.Add(2.5);
            Console.WriteLine(al.Capacity);
            al.Add("Dünya!");
            Console.WriteLine(al.Capacity);
            Console.WriteLine("al içindeki eleman sayısı:{0}",al.Count);
            //foreach döngüsü ile ArrayList'e erişme
            foreach (object eleman in al)
            {
                Console.WriteLine("Eleman değeri: {0}", eleman);
            }
            //for döngüsü ile ArrayList'e erişme
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            //ArrayList'den eleman silme
            al.RemoveAt(1);
            al.Remove("Dünya!");
            al.Remove(2.5);
            Console.WriteLine("Silme işleminden sonra al içeriği");
            foreach (object eleman in al)
                Console.WriteLine(eleman);
            al.Add(5);
            al.Add(36);
            al.Add(41);
            al.Add(55);
            al.Add(41);
            int deger = 41;
            Console.WriteLine("{0} değerinin konumu: {1}", deger, al.IndexOf(deger));
            if(al.Contains(55))
                Console.WriteLine("55 değeri var");
            al.Reverse();//sırayı tersine çevir
            Console.WriteLine("Reverse çağrıldıktan sonra");
            foreach(object eleman in al)
                Console.WriteLine(eleman);
            al.Remove("Merhaba");//hepsi aynı türden olmalı ki sıralanabilsin
            //al.Sort();
            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i+1; j < al.Count; j++)
                {
                    if ((int)al[i] > (int)al[j])
                    {
                        object gecici = al[i];
                        al[i] = al[j];
                        al[j] = gecici;
                    }
                }
            }
            
            Console.WriteLine("Sıralamadan sonra");
            foreach (object eleman in al)
                Console.WriteLine(eleman);
            al.Insert(3, "deneme");
            foreach (object eleman in al)
                Console.WriteLine(eleman);

        }
    }
}
