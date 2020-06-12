using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Customer
	{
		//PK
		public int IdClient { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		
		public ICollection<Order> Orders { get; set; }
	}
}
