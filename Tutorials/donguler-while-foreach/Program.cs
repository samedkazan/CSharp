using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1'den başlayarak console dan girilen sayıya kadar (Sayi dahil) ortalama hesaplayıp console a yazdıran program.

            Console.WriteLine("Lütfen Bir Sayı Giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye kadar tüm harfleri console a yazdır.
            char character = 'a';

            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("**********Foreach*******");


            string[] arabalar = { "Bmw", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}