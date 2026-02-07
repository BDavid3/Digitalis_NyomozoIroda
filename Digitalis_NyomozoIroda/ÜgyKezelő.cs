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
        public Ügy Ügykeresése(string id)
        {
            foreach (var ugy in ügyek)
            {
                if (ugy.Ugyazonosito == id)
                {
                    return ugy;
                }
            }
            return null;
        }

    }
}
