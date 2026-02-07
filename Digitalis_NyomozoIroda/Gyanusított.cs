using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Gyanusított
	{
		private Személy Person;
		private int gyanusitottsagszint;
		private string statusz;

		public Gyanusított(Személy person, int gyanusitottsagszint, string statusz)
		{
			Person = person;
			this.gyanusitottsagszint = gyanusitottsagszint;
			this.statusz = statusz;
		}

		public int Gyanusitottsagszint { get => gyanusitottsagszint; set => gyanusitottsagszint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Személy Person1 { get => Person; set => Person = value; }
		public override string ToString()
		{
			return $"--- Gyanusított ---{this.Person}Gyanúsítottsági szint: {this.gyanusitottsagszint} Státusz: {this.statusz}";
		}
	}

}
