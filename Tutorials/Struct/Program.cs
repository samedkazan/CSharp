using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.ALanHesapla);

            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen_struct.ALanHesapla);
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
       // public Dikdortgen()
        //{
          //  KisaKenar = 3;
            //UzunKenar = 4;
        //}
        public long ALanHesapla()
        {
            return this.KisaKenar = this.UzunKenar;
        }

    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar) : this()
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long ALanHesapla()
        {
            return this.KisaKenar = this.UzunKenar;
        }
    }
}