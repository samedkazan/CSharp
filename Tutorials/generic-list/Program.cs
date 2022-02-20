using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // List <T> Class
            // System.Collection.Generic
            // T=> object Türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");


            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            // foreach ve list.foreach ile elemanlara ulaşma
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);

            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);

            }


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");

            // Eleman ile indekse erişme
            Console.WriteLine(renkListesi.BinarySearch("kırmızı"));

            // Diziyi list'e çevirme 
            string[] hayvanlar = { "kedi", "kopek", "kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasil temizlerim

            hayvanListesi.Clear();

            // List içerisinde nesne tutma

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();

            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yılaz";
            kullanici1.Yas = 26;


            Kullanicilar kullanici2 = new Kullanicilar();

            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalıskan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici adi: " + kullanici.Isim);
                Console.WriteLine("Kullanici soyadi: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici yas: " + kullanici.Yas);
            }
            yeniListe.Clear();
        }

    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}