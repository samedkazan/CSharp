using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class program
    {

        static void Main(string[] args)
        {

            int deger = 2;
            string degisken = null;

            byte b = 5;         // 1 byte
            sbyte c = 5;        // 1 byte


            short s = 5;        // 2 byte
            ushort us = 5;      // 2 byte

            Int16 i16 = 2;      // 2 byte
            Int32 i32 = 2;      // 4 byte
            int i = 2;          // 4 byte
            Int64 i64 = 2;      // 8 byte

            uint ui = 2;        // 4 byte
            long l= 4;          // 8 byte
            ulong ul = 4;       // 8 byte
            
            
            // reel sayilar
            float f = 5 ;       // 4 byte       
            double d = 5;       // 8 byte
            decimal de = 5;     // 16 byte


            char ch = 'a';       // 2 byte
            string str ="Samed"; //sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 ="x";
            object o2 ='y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Samed Kazan";
            string ad = "Samed";
            string soyad ="Kazan";
            string tamIsim = ad +" "+ soyad;

            //ınteger tanımlama sekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean 

            bool bool1 = 10 < 2 ;

            // Degisken Donusumleri
            
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);// cıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);// cıktı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);// cıktısı 40

            // dateTime

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);

             string datetime2 = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(datetime2);
            //saat
             string datetime3 = DateTime.Now.ToString("hh.m");
            Console.WriteLine(datetime3);










            
        }



    }



}