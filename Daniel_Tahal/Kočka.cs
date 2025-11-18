using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_Tahal
{
    internal class Kocka
    {
        public Kocka(string jmeno, int pocetZivotu = 9)
        {
            PocetZivotu = pocetZivotu;
            Jmeno = jmeno;
        }

        public int PocetZivotu { get; set; }
        public string Jmeno { get; set; }

        public void Zamnoukej()
        {
            Console.WriteLine("Meowwwww!!!!");
        }


        public override string ToString()
        {
            //return base.ToString();
            return $"Jsem malá chlupatá kočička {Jmeno} a zbývá mi {PocetZivotu} životů";
        }
    }
}
