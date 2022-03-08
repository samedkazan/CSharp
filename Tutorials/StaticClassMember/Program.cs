using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yılmaz","İK");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}",Islemler.Cikar(100,200));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string İsim;
        private string Soyİsim;
        private string Departman;


        static Calisan()
        {
            calisanSayisi = 0;

        }

        public Calisan(string isim, string soyİsim, string departman)
        {
            this.İsim= isim;
            this.Soyİsim = soyİsim;
            this.Departman = departman;
            calisanSayisi ++;

        }



    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}