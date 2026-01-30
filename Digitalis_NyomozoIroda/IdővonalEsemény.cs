using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class IdővonalEsemény
	{
		private DateOnly datum;
		private string esemenyleiras;

		public IdővonalEsemény(DateOnly datum, string esemenyleiras)
		{
			this.datum = datum;
			this.esemenyleiras = esemenyleiras;
		}

		public DateOnly Datum { get => datum; set => datum = value; }
		public string Esemenyleiras { get => esemenyleiras; set => esemenyleiras = value; }

		public override string ToString()
		{
			return $"---------Az ügy idővonalának egy eseménye:---------\n\tDátum: {this.datum}\n\tEsemény leírása: {this.esemenyleiras}";
		}
	}
}
