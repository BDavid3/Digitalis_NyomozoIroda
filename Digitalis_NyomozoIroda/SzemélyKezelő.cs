using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
    internal class SzemélyKezelő
    {
        List<Személy> személyek;

        public SzemélyKezelő()
        {
            személyek = new List<Személy>();
        }

        public void szemelyHozzaAdas(ÜgyKezelő ügyKezelő)
        {
            Console.WriteLine("\n=== SZEMÉLY HOZZÁADÁSA ===");
            Console.Write("Név: ");
            string nev = Console.ReadLine();
            Console.Write("Életkor: ");
            int eletkor = int.Parse(Console.ReadLine());
            Console.Write("Megjegyzés: ");
            string megjegyzes = Console.ReadLine();

            Személy ujSzemely = new Személy(nev, eletkor, megjegyzes);

            Console.WriteLine($"Titulus (1 - Tanú / 2 - Gyanusított): ");
            int titulus = int.Parse(Console.ReadLine());
            if (titulus == 1)
            {
                Console.WriteLine("\n--- Tanú ---");
                Console.Write("Vallomás: ");
                string vallomas = Console.ReadLine();
                Console.Write("Vallomás dátuma: ");
                DateTime vallomasDatum = DateTime.Parse(Console.ReadLine());
                Tanú tanu = new Tanú(ujSzemely,vallomas,vallomasDatum.Year,vallomasDatum.Month,vallomasDatum.Day);

                Console.Write("Ügy azonósítója: ");
                string ugyAzonosito = Console.ReadLine();
                Ügy talalat = ügyKezelő.Ügykeresése(ugyAzonosito);
                talalat.szemelyhozzaadas(ujSzemely);

            }
            else if (titulus == 2)
            {
                Console.WriteLine("\n--- Gyanusított ---");
                Console.Write("Gyanusítottsági szint: ");
                int gyanusitottsagiSzint = int.Parse(Console.ReadLine());
                Console.WriteLine("Státusz: ");
                string statusz = Console.ReadLine();

                Console.WriteLine("Ügy azonósítója: ");
                string ugyAzonosito = Console.ReadLine();
                Ügy talalat = ügyKezelő.Ügykeresése(ugyAzonosito);
                talalat.szemelyhozzaadas(ujSzemely);
            }


        }

    }
}
