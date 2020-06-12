using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Confectionary
	{
		// PK
		public int IdConfectionary { get; set; }
		public string Name { get; set; }
		public float PricePerIte { get; set; }
		public string Type { get; set; }

		//List of Prescription_Medicaments 
		public ICollection<Confectionary_Order> Confectionary_Orders { get; set; }
	}
}
