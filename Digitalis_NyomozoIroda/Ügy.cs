using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

		public void ujugy()
		{
			
		}
		public void szemelyhozzaadas(Személy sz)
		{
			szemelyek.Add(sz);
		}

		public void bizonyitekhozzaadas(Bizonyíték b)
		{
			bizonyitekok.Add(b);
		}

		public string szemelyekkiiratas()
		{
			string s = "";
			foreach (var sz in szemelyek)
			{
				s += sz;
			}
			return s;
		}
		public string bizonyitekkiiras()
		{
			string b = "";
			foreach (var bi in bizonyitekok)
			{
				b += bi;
			}
			return b;
		}

		public override string ToString()
		{
			return $"Ügy azonosító: {this.ugyazonosito}\nCím: {this.cim}\nLeírás: {this.leiras}\nÁllapot: {this.allapot}\n\nHozzá tartozó személyek: {szemelyekkiiratas()}\nHozzá tartozó bizonyítékok: {bizonyitekkiiras()}";
		}
	}
}
