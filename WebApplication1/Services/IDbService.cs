using HospitalDB.DTOs.Requests;
using HospitalDB.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDB.NewFolder
{
	public interface IDbService
	{
		public IEnumerable<GetOrdersResponse> GetCustomerOrders(string name);
		public string InsertOrder(InsertOrderRequest request, int customerId);
	}
}
