using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Employee
	{
		//PK
		public int IdEmployee { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		
		public ICollection<Order> Orders { get; set; }
	}
}
