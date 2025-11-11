using System.Reflection.Metadata.Ecma335;

namespace Daniel_Tahal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v ZOO");
            object[] zoo = { new Lev(), new Pes(), new Mravenec(), new Kočka(), new Had(), new Opice(), new Slon(), new Chameleon(), new Papoušek(), new Žirafa()};

            foreach (object o in zoo)
            {
                Console.WriteLine(o);
            }
        }
    }
    
    class Lev
    {
        public override string ToString()
        {
            return "Jsem lev, král zvířat.";
        }
    }

    class Pes
    {
        public override string ToString()
        {
            return "Jsem pes, nejlepší přítel člověka.";
        }
    }

    class Mravenec
    {
        public override string ToString()
        {
            return "Jsem mravenec a unesu několikanásobek své váhy.";
        }
    }

    class Kočka
    {
        public override string ToString()
        {
            return "Jsem kočka a mám 9 životů.";
        }
    }

    class Had
    {
        public override string ToString()
        {
            return "Jsem had";
        }
    }

    class Opice
    {
        public override string ToString()
        {
            return "Jsem opice";
        }
    }

    class Slon
    {
        public override string ToString()
        {
            return "Jsem slon a vážím několik tun.";
        }
    }

    class Chameleon
    {
        public override string ToString()
        {
            return "Jsem chameleon a umím se dobře maskovat.";
        }
    }

    class Papoušek
    {
        public override string ToString()
        {
            return "Jsem papoušek a umím napodobovat zvuky";
        }
    }

    class Žirafa
    {
        public override string ToString()
        {
            return "Jsem žirafa a jsem vysoká několik metrů";
        }
    }
}
