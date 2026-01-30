using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Tanú
	{
		private Személy Person;
		private string vallomas;
		private DateOnly vallomasdatum;

		public Tanú(Személy person, string vallomas, DateOnly vallomasdatum)
		{
			Person = person;
			this.vallomas = vallomas;
			this.vallomasdatum = vallomasdatum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateOnly Vallomasdatum { get => vallomasdatum; set => vallomasdatum = value; }
		internal Személy Person1 { get => Person; set => Person = value; }
		public override string ToString()
		{
			return $"-------Tanú:-------\n\tSzemély: {this.Person}\n\tVallomás szövege: {this.vallomas}\n\t Vallomás dátuma: {this.vallomasdatum}";
		}
	}
}
