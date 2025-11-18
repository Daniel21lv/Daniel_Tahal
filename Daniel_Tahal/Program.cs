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

            #region MyRegion
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
            #endregion

            
            object pejsek = (object) pes; //boxing
            Console.WriteLine(pejsek);

        }

        static void DesifrujPsa(object obj)
        {
            Pes hafan = (Pes)obj; //unboxing
            hafan.Zastekej();
        }
    }
}
