using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

            int[] dizi;
            dizi = new int[5];

            // Değer Atama Ve Erişim

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program.

            Console.Write("Lütfen dizinin eleman sayısını giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;


            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

        }
    }
}