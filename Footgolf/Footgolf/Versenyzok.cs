using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footgolf
{
    class Versenyzok
    {
        public string Nev { get; set; }
        public bool Kategoria { get; set; }
        public string Egyesulet { get; set; }
        public int[] Helyezes = new int[8];
        public int Osszpontszam => Fel03(Helyezes);

        public Versenyzok(string sor)
        {
            string[] tmp = sor.Split(';');

            this.Nev = tmp[0];
            this.Kategoria = tmp[1] == "Felnott ferfi";
            this.Egyesulet = tmp[2];
            this.Helyezes[0] = int.Parse(tmp[3]);
            this.Helyezes[1] = int.Parse(tmp[4]);
            this.Helyezes[2] = int.Parse(tmp[5]);
            this.Helyezes[3] = int.Parse(tmp[6]);
            this.Helyezes[4] = int.Parse(tmp[7]);
            this.Helyezes[5] = int.Parse(tmp[8]);
            this.Helyezes[6] = int.Parse(tmp[9]);
            this.Helyezes[7] = int.Parse(tmp[10]);  
        }
        private int Fel03(int[] Helyezes)
        {
            Array.Sort(Helyezes);
            int osszpont = 0;
            for (int i = 0; i < Helyezes.Length; i++)
            {
                if (Helyezes[i] != 0 && i < 2) Helyezes[i] = 10;
                osszpont += Helyezes[i];
            }
            return osszpont;
        }
    }
}
