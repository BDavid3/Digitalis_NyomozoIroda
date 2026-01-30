using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class ÜgyÁllapot
	{
		private bool statusz;

		public ÜgyÁllapot(bool statusz)
		{
			this.statusz = statusz;
		}

		public bool Statusz { get => statusz; set => statusz = value; }
	}
}
