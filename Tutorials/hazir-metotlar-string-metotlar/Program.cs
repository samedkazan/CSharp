using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp,Hosgeldiniz";
            string degisken2 = "Dersimiz Csharp";
            // Length 
            Console.WriteLine(degisken.Length);
            // ToUpper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat
            Console.WriteLine(string.Concat(degisken, "Merhaba"));
            //Compare,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0-1,-1
            Console.WriteLine(string.Compare(degisken, degisken2, true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));
            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            //İndexOf
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("i"));
            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadRight(30, '-'));
            Console.WriteLine(degisken.PadLeft(30) + degisken2.PadRight(30));
            //Remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(3, 5));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split

            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring 
            Console.WriteLine(degisken.Substring(4, 6));

            
        }
    }
}