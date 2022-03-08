using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Gunler.Pazar);
           Console.WriteLine((int)Gunler.Cumartesi);

           int sıcaklık = 32;
           if(sıcaklık<=(int)HavaDurumu.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle...");
           else if(sıcaklık>=(int)HavaDurumu.Sıcak)
               Console.WriteLine("Dışarıya çıkmak için çok sıcak");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.Sıcak)
                Console.WriteLine("hadi dışarıya çıkalım");
            
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}