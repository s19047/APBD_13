using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Confectionary_Order
	{
		//FK + PK
		public int IdConfection { get; set; }

		//FK + PK
		public int IdOrder { get; set; }

		
		public int Quantity { get; set; }
		public string Notes { get; set; }


		// One medicament that is connected to one prescription 
		public  Confectionary Confectionary { get; set; }
		public  Order Order { get; set; }

	}
}
