using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_Tahal
{
    internal class Chameleon
    {
        public Chameleon(string jmeno) 
        {
            Jmeno = jmeno;
        }
        public void Lez()
        {
            Console.WriteLine("Lezu na nejvyšší větev");
        }
        public string Jmeno { get; set; }
        private ConsoleColor ZvolBarvu()
        {
            int nahodnaBarva = new Random().Next(0, 3);
            return nahodnaBarva switch
            {
                0 => ConsoleColor.Green,
                1 => ConsoleColor.Blue,
                2 => ConsoleColor.Yellow,
                _ => ConsoleColor.Red,
            };
        }
        public string ResetujBarvu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return "";
        }
        public int vek = 3;
        public override string ToString()
        {
            Console.ForegroundColor = ZvolBarvu();
            return $"Jsem chameleon, umím se dobře maskovat a je mi {vek} let." +ResetujBarvu();
        }
    }
}
