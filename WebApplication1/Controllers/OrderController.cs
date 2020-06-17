using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_13.Exceptions;
using HospitalDB.DTOs.Requests;
using HospitalDB.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IDbService _service;

        public OrderController(IDbService service)
        {
            _service = service;
        }


        [HttpGet("/orders/{name?}")]
        public IActionResult GetCustomerOrders(string name ="")
        {
            try
            {
                var res = _service.GetCustomerOrders(name);
                return Ok(res);

            }catch(OrderDoesNotExistException e)
            {
                return NotFound(e.Message);
            }

        }

        [HttpPost("client/{id}/orders")]
        public IActionResult InsertOrder(InsertOrderRequest request, int id)
        {
           
            var res = _service.InsertOrder(request, id);
           
            if (!(res is null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
           
        }



    }
}