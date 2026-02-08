using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
    internal class BizonyitekKezelő
    {
        private List<Bizonyíték> bizonyítékok;

        public BizonyitekKezelő()
        {
            bizonyítékok = new List<Bizonyíték>();
        }

        public void bizonyitekHozzaAdas(ÜgyKezelő ügyKezelő)
        {
            Console.WriteLine("\n=== BIZONYÍTÉK HOZZÁADÁSA ===");
            Console.Write("Azonosító: ");
            string azonosito = Console.ReadLine();
            Console.Write("Típus: ");
            string tipus = Console.ReadLine();
            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();
            Console.Write("Megbízhatósági érték: ");
            int megbizhatosagErtek = int.Parse(Console.ReadLine());

            Bizonyíték bizonyíték = new Bizonyíték(azonosito,tipus,leiras,megbizhatosagErtek);
            bizonyítékok.Add(bizonyíték);

            Console.Write("Ügy azonósítója amihez hozzá szeretnéd csatolni: ");
            string ugyAzonosito = Console.ReadLine();

            Ügy talalat = ügyKezelő.Ügykeresése(ugyAzonosito);
            talalat.bizonyitekhozzaadas(bizonyíték);
            Console.WriteLine("\nSikeresen hozzáadtál egy bizonyítékot az ügyedhez!");
        }
    }
}
