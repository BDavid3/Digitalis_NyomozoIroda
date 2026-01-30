using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Személy
	{
		private string nev;
		private int eletkor;
		private string megjegyzes;

		public Személy(string nev, int eletkor, string megjegyzes)
		{
			this.nev = nev;
			this.eletkor = eletkor;
			this.megjegyzes = megjegyzes;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
	}
}
