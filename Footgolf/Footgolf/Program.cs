using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Footgolf
{
    class Program
    {
        static List<Versenyzok> versenyzok;
        static void Main(string[] args)
        {
            Beolvas();
            Fel01();
            Fel02(false);
            Fel04(false);
            //Fel05(true);
            Console.ReadKey();
        }

        /*private static void Fel05(bool gender)
        {
        
            var sw = new StreamWriter(@"ferfi.txt",false, Encoding.UTF8);
            var a = versenyzok.Select(f => f.Nev).Where(f=> f.Kategoria == gender);
            foreach (var v in versenyzok)
            {
                sw.WriteLine(a + ";" + );
            }
        }*/

        private static void Fel04(bool gender)
        {
            var a = versenyzok.Where(f => f.Kategoria == gender).Max(f => f.Osszpontszam);
            Console.WriteLine($"Feladat 6: \n\tNév: {a.Nev}\n\tEgyesület: {a.Egyesulet}\n\tÖsszpont: {a.Osszpontszam}");
        }

        private static void Fel02(bool gender)
        {
            var a = versenyzok.Count(f => f.Kategoria == gender);
            var b = versenyzok.Count;
            double szazalek = ((double)a / (double)b) * 100; 
            Console.WriteLine($"Feladat 4: {Math.Round(szazalek,2)}");
        }

        private static void Fel01()
        {
            Console.WriteLine($"Fealadat 3: {versenyzok.Count}");
        }

        private static void Beolvas()
        {
            versenyzok = new List<Versenyzok>();
            var sr = new StreamReader(@"doga.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                versenyzok.Add(new Versenyzok(sr.ReadLine()));

            }
            sr.Close();
        }
    }
}
