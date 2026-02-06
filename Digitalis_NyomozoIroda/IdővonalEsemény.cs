using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class IdővonalEsemény
	{
		private int year;
		private int month;
		private int day;
		private string esemenyleiras;

		public IdővonalEsemény(int year, int month, int day, string esemenyleiras)
		{
			this.year = year;
			this.month = month;
			this.day = day;
			this.esemenyleiras = esemenyleiras;
		}

		public int Year { get => year; set => year = value; }
		public int Month { get => month; set => month = value; }
		public int Day { get => day; set => day = value; }
		public string Esemenyleiras { get => esemenyleiras; set => esemenyleiras = value; }

		public override string ToString()
		{
			return $"---------Az ügy idővonalának egy eseménye:---------\n\tDátum: {this.year}/{this.month}/{this.day}\n\tEsemény leírása: {this.esemenyleiras}";
		}
	}
}
