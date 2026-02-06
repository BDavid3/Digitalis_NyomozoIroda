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
		private int year;
		private int month;
		private int day;

		public Tanú(Személy person, string vallomas, int year, int month, int day)
		{
			Person = person;
			this.vallomas = vallomas;
			this.year = year;
			this.month = month;
			this.day = day;
		}
		public string Vallomas { get => vallomas; set => vallomas = value; }
		public int Year { get => year; set => year = value; }
		public int Month { get => month; set => month = value; }
		public int Day { get => day; set => day = value; }
		internal Személy Person1 { get => Person; set => Person = value; }

		public override string ToString()
		{
			return $"--------------Tanú:--------------\n\t{this.Person}\n\tVallomás szövege: {this.vallomas}\n\t Vallomás dátuma:{this.year}/{this.month}/{this.day}";
		}
	}
}
