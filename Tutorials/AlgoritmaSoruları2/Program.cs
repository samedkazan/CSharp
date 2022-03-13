using System;
using System.Collections;

namespace algoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList noAsal = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                System.Console.Write("Lütfen "+ (i+1)+ ". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (negatifMi(sayi))
                {
                    int sayac = 0;
                    for (int k = 2; k < sayi; k++)
                    {
                        if (sayi % k == 0)
                        {
                            sayac++;
                        }

                    }
                    if (sayac == 0)
                    {
                        if(sayac==1){
                            noAsal.Add(sayi);
                        }
                        else
                            asal.Add(sayi);
                    }
                    else
                    {
                        noAsal.Add(sayi);
                    }


                }
                else
                {
                    System.Console.WriteLine("Lütfen Pozitif ve Numeric Bir sayı Giriniz");
                }

            }
            asal.Sort();
            asal.Reverse();
            noAsal.Sort();
            noAsal.Reverse();

            System.Console.WriteLine("----------Asal Sayılar----------");

            foreach (int item in asal)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------Asal Olmayan Sayılar----------");
            
            foreach (var item in noAsal)
            {
                System.Console.WriteLine(item);
            }

            int toplam1=0;
            int toplam2=0;
            foreach (int item in asal)
            {
                toplam1=toplam1+item;
                    
            }
             System.Console.WriteLine("Asal Sayıların Ortalaması=  " + toplam1/asal.Count+ "  Dizideki Eleman Sayısı= "+asal.Count );
            foreach (int item in noAsal)
            {
                toplam2=toplam2+item;
                    
            }
             System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması=  " + toplam1/asal.Count+ "  Dizideki Eleman Sayısı= "+noAsal.Count );
        }

        private static bool negatifMi(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }
    }
    class Soru2
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            int[] dizi= new int[20];

            for(int i=0;i<20;i++){
                System.Console.WriteLine("Lütfen" + (i+1) +". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi.Add(sayi);

            }
            dizi.Sort();
            
            ArrayList enKucuk=new ArrayList();
            ArrayList enBuyuk=new ArrayList();
            int sayac=1;
            foreach (var item in dizi)
            {
                if(sayac==1 || sayac==2 || sayac==3){
                    enKucuk.Add(item);
                }

                else if(sayac==18|| sayac==19 || sayac==20){
                    enBuyuk.Add(item);
                }
                sayac++;

                
            }
            
            int toplam1=0,toplam2=0 ;
            foreach (var buyuk in enBuyuk)
            {
                toplam1=toplam1+Convert.ToInt32(buyuk);
            }
            System.Console.WriteLine("En Büyük Sayıların Ortalaması: " + (toplam1/3));

            foreach (var kucuk in enKucuk)
            {
                toplam2=toplam2+Convert.ToInt32(kucuk);
            }
            System.Console.WriteLine("En Küçük Sayıların Ortalaması: " + (toplam2/3));


        }
    }
    class Soru3
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            Console.Write("Lütfen bir cümle giriniz: ");
            string metin=Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i=0;i<metin.Length;i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                }

            }

            Console.WriteLine("Kelime içerisinde toplam " + sayac + " tane sesli harf var.");
            Console.WriteLine("Bunlar Şöyledir.");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }

}