using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Felhasználó
	{
		private string nev;
		private string azonosito;
		private string szerepkor;

		public Felhasználó(string nev, string azonosito, string szerepkor)
		{
			this.nev = nev;
			this.azonosito = azonosito;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }

		public override string ToString()
		{
			return $"--------Renszer Felhasználó:--------\n\tNév: {this.nev}\n\tAzonosító: {this.azonosito}\n\tSzerepkör: {this.szerepkor}";
		}
	}
}
