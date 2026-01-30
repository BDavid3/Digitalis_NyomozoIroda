using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Ügy
	{
		private string ugyazonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Személy> szemelyek;
		private List<Bizonyíték> bizonyitekok;

		public Ügy(string ugyazonosito, string cim, string leiras, string allapot)
		{
			this.ugyazonosito = ugyazonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = new List<Személy>();
			this.bizonyitekok = new List<Bizonyíték>();
		}

		public string Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Személy> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Bizonyíték> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public void szemelyhozzaadas(Személy sz)
		{
			szemelyek.Add(sz);
		}
		/*public void szemelyeklekerdezese()
		{
			Console.WriteLine(this.cim);
			foreach (var item in szemelyek)
			{
				Console.WriteLine(item);
			}
		}*/

		public override string ToString()
		{
			return $"--------Konkrét bűnügy:--------\n\tÜgy azonosítója: {this.ugyazonosito}\n\tCím: {this.cim}\n\tLeírás: {this.cim}\n\tÁllapot: {this.allapot}\n\t Hozzá tartozó személyek listája: {this.szemelyek}\n\t Hozzá tartozó bizonyítékok listája: {this.bizonyitekok}";
		}
	}
}
