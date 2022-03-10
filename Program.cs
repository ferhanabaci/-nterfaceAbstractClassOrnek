using System;

namespace interfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("********İnterface*******");
                Focus focus = new Focus();
                Console.WriteLine(focus.HangiMarkanınAraci().ToString());
                Console.WriteLine(focus.StandartRengiNe().ToString());
                Console.WriteLine(focus.KacTekerOlusur().ToString());

                Civic civic = new Civic();
                Console.WriteLine(civic.HangiMarkanınAraci().ToString());
                Console.WriteLine(civic.StandartRengiNe().ToString());
                Console.WriteLine(civic.KacTekerOlusur().ToString());
                                
                Console.WriteLine("********Abstrac*******");



                NewFocus focus1 = new NewFocus();
                Console.WriteLine(focus1.HangiMarkanınAraci().ToString());
                Console.WriteLine(focus1.StandartRengiNe().ToString());
                Console.WriteLine(focus1.KacTekerOlusur().ToString());

                NewCivic civic1 = new NewCivic();
                Console.WriteLine(civic1.HangiMarkanınAraci().ToString());
                Console.WriteLine(civic1.StandartRengiNe().ToString());
                Console.WriteLine(civic1.KacTekerOlusur().ToString());

        }
    }
}
