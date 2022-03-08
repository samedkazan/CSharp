using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");
            Calisan calisan2 = new Calisan()
            {
                Ad = "Ahmet",
                Soyad = "Kumru",
                No = 2345627,
                Departman = "Back-End Developer"
            };

            calisan2.CalisanBilgileri();
            Console.WriteLine("**********");
            Calisan calisan3 = new Calisan("Osman","Alan");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Adı: {0}", Soyad);
            Console.WriteLine("Çalışan Adı: {0}", No);
            Console.WriteLine("Çalışan Adı: {0}", Departman);
        }
    }
}