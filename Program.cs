using System;

namespace Lukasz_Koscielniak_Kol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Statek statek = new Statek();

            statek.plyn();

            Samochod autko = new Samochod();

            autko.jedz();

            Samolot samolocik = new Samolot();

            samolocik.lec();

            Amfibia amfib = new Amfibia();

            amfib.jedz();

            amfib.plyn();
        }
    }
}
