using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class Tanú : Személy
	{
		private string vallomas;
		private int year;
		private int month;
		private int day;

        public Tanú(string nev, int eletkor, string megjegyzes, string vallomas, int year, int month, int day)
			: base(nev, eletkor, megjegyzes)
        {
            this.vallomas = vallomas;
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string Vallomas { get => vallomas; set => vallomas = value; }
		public int Year { get => year; set => year = value; }
		public int Month { get => month; set => month = value; }
		public int Day { get => day; set => day = value; }


		public override string ToString()
		{
			return $"\n---Tanú---: "+base.ToString()+$"-Vallomás szövege-: {this.vallomas} -Vallomás dátuma-: {this.year}/{this.month}/{this.day}";
		}
	}
}
