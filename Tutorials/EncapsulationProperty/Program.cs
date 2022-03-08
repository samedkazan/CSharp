using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Isim = "Ayse",
                Soyisim="Yılmaz",
                OgrenciNo = 293,
                Sinif= 3
            };
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get => isim; 
            set => isim = value; 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
         set{
             
             if(value<1)
             {
                 Console.WriteLine("Sınıf En Az 1 Olabilir!");
                 sinif = 1;
             } 
             else
                sinif = value; 
             }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Ogrenci Bilgileri");
            Console.WriteLine("Ogrenci Adı : {0}",this.Isim);
            Console.WriteLine("Ogrenci Soyisim : {0}",this.Soyisim);
            Console.WriteLine("Ogrenci No : {0}",this.OgrenciNo);
            Console.WriteLine("Ogrenci Sınıfı : {0}",this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }
    }
}