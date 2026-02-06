using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_NyomozoIroda
{
	internal class BizonyítékKezelő
	{
		private List<Bizonyíték> bizonyitekok;
		private List<Bizonyíték> raktár;

		public BizonyítékKezelő(List<Bizonyíték> bizonyitekok, List<Bizonyíték> raktár)
		{
			this.bizonyitekok = bizonyitekok;
			this.raktár = raktár;
		}

		internal List<Bizonyíték> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
		internal List<Bizonyíték> Raktár { get => raktár; set => raktár = value; }


	}
}
