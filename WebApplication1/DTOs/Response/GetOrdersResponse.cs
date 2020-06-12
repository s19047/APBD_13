using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.DTOs.Response
{
	public class GetOrdersResponse
	{
		public string customerName { get; set; }
		public int IdOrder { get; set; }
		public DateTime DateAccepted { get; set; }
		public DateTime DateFinished { get; set; }
		public string Notes { get; set; }

		public ICollection<string> Confectionaries{ get; set; }

		
	}
}
