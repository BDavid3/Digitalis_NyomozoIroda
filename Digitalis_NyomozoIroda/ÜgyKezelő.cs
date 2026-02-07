using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class ÜgyKezelő
	{
		private List<Ügy> ügyek;

        public ÜgyKezelő()
        {
            ügyek = new List<Ügy>();
        }
        public void ujUgyLetrehozas()
        {
            Console.WriteLine("\n=== ÚJ ÜGY LÉTREHOZÁSA ===");
            Console.Write("Ügy azonosító: ");
            string azonosito = Console.ReadLine();
            Console.Write("Cím: ");
            string cim = Console.ReadLine();
            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();
            Console.Write("Állapot: ");
            string allapot = Console.ReadLine();

            Ügy ujUgy = new Ügy(azonosito, cim, leiras, allapot);

            Console.Write("Hozzá tartozó személyek száma: ");
            int szemelySzam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szemelySzam; i++)
            {
                Console.WriteLine($"\n--- {i+1}. személy ---");
                Console.Write("Név: ");
                string nev = Console.ReadLine();
                Console.Write("Életkor: ");
                int eletkor = int.Parse(Console.ReadLine());
                Console.Write("Megjegyzés: ");
                string megjegyzes = Console.ReadLine();

                Személy szemely = new Személy(nev, eletkor, megjegyzes);

                ujUgy.Szemelyek.Add(szemely);
            }
            Console.Write("\nHozzá tartozó bizonyítékok száma: ");
            int bizonyitekokSzama = int.Parse(Console.ReadLine());
            for (int i = 0; i < bizonyitekokSzama; i++)
            {
                Console.WriteLine($"\n--- {i+1}. bizonyíték ---");
                Console.Write("Azonosító: ");
                string bizonyAzonosito = Console.ReadLine();
                Console.Write("Típus: ");
                string bizonyTipus = Console.ReadLine();
                Console.Write("Leírás: ");
                string bizonyLeiras = Console.ReadLine();
                Console.Write("Megbízhatósági érték: ");
                int megbizhatosagiErtek = int.Parse(Console.ReadLine());

                Bizonyíték ujBizonyitek = new Bizonyíték(bizonyAzonosito, bizonyTipus, bizonyLeiras, megbizhatosagiErtek);

                ujUgy.Bizonyitekok.Add(ujBizonyitek);
            }
            ügyek.Add(ujUgy);
            Console.WriteLine("Ügy sikeresen hozzáadva!");
        }
        public void ugyekListazasa()
        {
            Console.WriteLine("\n=== ÜGYEK LISTÁJA ===");
            if (ügyek.Count == 0)
            {
                Console.WriteLine("Nincsenek rögzített ügyek!");
                return;
            }
            foreach (var ugy in ügyek)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(ugy);
                Console.WriteLine("-----------------");
            }
        }

    }
}
