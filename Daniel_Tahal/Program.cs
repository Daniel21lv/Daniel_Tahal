using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

namespace Daniel_Tahal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pes pes = new(true, "Indefix");
            Kocka kocka = new("Mikeš");
            Chameleon chameleon = new("Oskar");

            Pes pes2 = new(false, "Štěkanátek");

            //pes.Zastekej();
            //chameleon.Lez();

            //Console.WriteLine(pes);
            //Console.WriteLine(chameleon);
            //chameleon.ResetujBarvu();

            //Console.WriteLine(pes.Jmeno);

            Console.WriteLine("Vítejte v ZOO!");
            object[] zoo = { pes, kocka, chameleon, pes2 };

            foreach (object o in zoo)
            {
                if (o is Pes x)
                {
                    x.Zastekej();
                    Console.WriteLine(x);
                }
                else if (o is Kocka k)
                {
                    k.Zamnoukej();
                    Console.WriteLine(k);
                }
                else if (o is Chameleon c)
                {
                    c.Lez();
                    Console.WriteLine(c);
                    c.ResetujBarvu();
                }
            }
        }
    }

    //class Lev
    //{
    //    public int vek = 25;
       
        
    //    public override string ToString()
    //    {
    //        return $"Jsem lev, král zvířat a je mi {vek} let.";
    //    }
    //}

    ////class Pes
    ////{
    ////    public int vek = 7;

    ////    //public void Zastekej()
    ////    //{
    ////    //    Console.WriteLine("haf");
    ////    //}

    ////    //public override string ToString()
    ////    //{
    ////    //    return $"Jsem pes, nejlepší přítel člověka a je mi {vek} let.";
    ////    //}
    ////}

    //class Mravenec
    //{
    //    public int vek = 3;
    //    public override string ToString()
    //    {
    //        return $"Jsem mravenec a unesu několikanásobek své váhy a je mi {vek} dny.";
    //    }
    //}

    //class Kočka
    //{
    //    public int vek = 2;
    //    public override string ToString()
    //    {
    //        return $"Jsem kočka, mám 9 životů a je mi {vek} let.";
    //    }
    //}

    //class Had
    //{
    //    public int vek = 3;
    //    public override string ToString()
    //    {
    //        return $"Jsem had a je mi {vek} let";
    //    }
    //}

    //class Opice
    //{
    //    public int vek = 8;
    //    public override string ToString()
    //    {
    //        return $"Jsem opice a je mi {vek} let";
    //    }
    //}

    //class Slon
    //{
    //    public int vek = 42;
    //    public override string ToString()
    //    {
    //        return $"Jsem slon, vážím několik tun a je mi {vek} let.";
    //    }
    //}

    ////class Chameleon
    ////{
    ////    public int vek = 3;
    ////    public override string ToString()
    ////    {
    ////        return $"Jsem chameleon, umím se dobře maskovat a je mi {vek} let.";
    ////    }
    ////}

    //class Papoušek
    //{
    //    public int vek = 63;
    //    public override string ToString()
    //    {
    //        return $"Jsem papoušek, umím napodobovat zvuky a je mi {vek} let.";
    //    }
    //}

    //class Žirafa
    //{
    //    public int vek = 27;
    //    public override string ToString()
    //    {
    //        return $"Jsem žirafa, jsem vysoká několik metrů a je mi {vek} let.";
    //    }
    //}
    
}
