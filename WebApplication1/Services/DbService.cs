using APBD_13.Exceptions;
using HospitalDB.DTOs.Requests;
using HospitalDB.DTOs.Response;
using HospitalDB.NewFolder;
using Microsoft.CodeAnalysis.FlowAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Services
{
	public class DbService : IDbService
	{
		private readonly SweetShopDbContext _context;

		public DbService(SweetShopDbContext context)
		{
			_context = context;
		}

		public IEnumerable<GetOrdersResponse> GetCustomerOrders(string name)
		{
			var responseList = new List<GetOrdersResponse>();

			if (!_context.Orders.Any())
			{
				throw new OrderDoesNotExistException("The List Of Orders is empty");
			}

			if (!name.Equals(""))
			{

				var client = _context.Customers.Where(c => c.FName.Equals(name)).FirstOrDefault();

				if (client is null)
				{
					throw new OrderDoesNotExistException("no customer with such name was found"); 
				}
				var orders = _context.Orders.Where(o => o.IdClient.Equals(client.IdClient)).ToList();

				foreach (var order in orders)
				{
					var confectionaryOrderList = _context.confectionary_Orders
													.Where(co => co.IdOrder.Equals(order.IdOrder)).ToList();

					var confectionaries = new List<string>();

					foreach (var co in confectionaryOrderList)
					{
						confectionaries.Add(_context.Confectionaries.Where(c => c.IdConfectionary.Equals(co.IdConfection)).Select(c => c.Name).FirstOrDefault());
					}

					var response = new GetOrdersResponse()
					{
						customerName = name,
						IdOrder = order.IdOrder,
						DateAccepted = order.DateAccepted,
						DateFinished = order.DateFinished,
						Notes = order.Notes,
						Confectionaries = confectionaries
					};

					responseList.Add(response);
				}

			}
			else
			{

				var clients = _context.Customers.ToList();

				foreach (Customer client in clients)
				{
					var orders = _context.Orders.Where(o => o.IdClient.Equals(client.IdClient)).ToList();

					foreach (var order in orders)
					{
						var confectionaryOrderList = _context.confectionary_Orders
														.Where(co => co.IdOrder.Equals(order.IdOrder)).ToList();

						var confectionaries = new List<string>();

						foreach (var co in confectionaryOrderList)
						{
							confectionaries.Add(_context.Confectionaries.Where(c => c.IdConfectionary.Equals(co.IdConfection)).Select(c => c.Name).FirstOrDefault());
						}

						var response = new GetOrdersResponse()
						{
							customerName = client.FName,
							IdOrder = order.IdOrder,
							DateAccepted = order.DateAccepted,
							DateFinished = order.DateFinished,
							Notes = order.Notes,
							Confectionaries = confectionaries
						};

						responseList.Add(response);
					}

				}
			}
			return responseList;
		}

		public string InsertOrder(InsertOrderRequest request,int customerId)
		{
			using (var trans = _context.Database.BeginTransaction())
			{

				//var orderId = _context.Orders.Count() + 1;
				var orderId = _context.Orders.Select(o => o.IdOrder).Max() + 1;


				if (request.Confectionery is null || request.Notes is null)
				{
					trans.Rollback();
					return null;
				}
				try
				{
					
					var Order = new Order
					{
						DateAccepted = request.DateAccepted,
						DateFinished = DateTime.Now,
						Notes = request.Notes,
						IdClient = customerId
					};

					_context.Orders.Add(Order);
					_context.SaveChanges();


					// check if confectionary already exists in database if it does add to Confectionary_Order
					foreach (var confec in request.Confectionery)
					{
						var confecId = _context.Confectionaries.Where(c => c.Name.Equals(confec.Name)).Select(c => c.IdConfectionary).FirstOrDefault();
						if (confecId == 0)
						{
							trans.Rollback();
							return null;
						}

						// else add to confictionary_order 
						var confecOrder = new Confectionary_Order
						{
							IdConfection = confecId,
							IdOrder = orderId,
							Quantity = confec.Quantity,
							Notes = confec.Notes
						};

						_context.confectionary_Orders.Add(confecOrder);
						_context.SaveChanges();
					}

					trans.Commit();

					return "Order has been successfully created!";

				}
				catch (Exception e)
				{
					trans.Rollback();
					return null;
				}

			}
		}


	}
}
