using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.collections.generic

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            // dizinin elemanlarına erişim

            Console.WriteLine("***** Elemanlarına Erişim******");

            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("****** count******");

            Console.WriteLine(kullanicilar.Count);
            // contains

            Console.WriteLine("**** Contains ******");

            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Samed Kazan"));

            // remove

            Console.WriteLine("****** Remove ****");

            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            // Keys
            Console.WriteLine("****** Keys ****");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("****** Values ****");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }




        }
    }
}