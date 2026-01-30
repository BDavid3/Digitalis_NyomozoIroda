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
		private List<Ügy> szemelyek;
		private List<Ügy> bizonyitekok;

		public Ügy(string ugyazonosito, string cim, string leiras, string allapot, List<Ügy> szemelyek, List<Ügy> bizonyitekok)
		{
			this.ugyazonosito = ugyazonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		public string Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Ügy> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Ügy> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public override string ToString()
		{
			return $"--------Konkrét bűnügy:--------\n\tÜgy azonosítója: {this.ugyazonosito}\n\tCím: {this.cim}\n\tLeírás: {this.cim}\n\tÁllapot: {this.allapot}\n\t Hozzá tartozó személyek listája: {this.szemelyek}\n\t Hozzá tartozó bizonyítékok listája: {this.bizonyitekok}";
		}
	}
}
