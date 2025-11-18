using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_Tahal
{
    internal class Pes
    {
        public Pes(bool hlidaci, string jmeno)
        {
            Hlidaci = hlidaci;
            Jmeno = jmeno;
        }
        public bool Hlidaci {  get; private set; }
        public string Jmeno { get; private set; }
        public void Zastekej()
        {
            Console.WriteLine("Haf-haf");
        }
        public int vek = 7;
        public override string ToString()
        {
            return $"Jsem pes {(Hlidaci? "hlídací" : "nehlídací")} pes jménem {Jmeno}, jsem nejlepší přítel člověka a je mi {vek} let.";
        }
    }
}
