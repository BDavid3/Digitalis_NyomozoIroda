using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Gyanusított : Személy
    {
		private int gyanusitottsagszint;
		private string statusz;

		public Gyanusított(string nev, int eletkor, string megjegyzes, int gyanusitottsagszint, string statusz)
			: base(nev, eletkor, megjegyzes)
        {
			this.gyanusitottsagszint = gyanusitottsagszint;
			this.statusz = statusz;
		}

		public int Gyanusitottsagszint { get => gyanusitottsagszint; set => gyanusitottsagszint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		public override string ToString()
		{
			return $"\n---Gyanusított---: "+base.ToString()+$"-Gyanúsítottsági szint-: {this.gyanusitottsagszint} -Státusz-: {this.statusz}";
		}
	}

}
